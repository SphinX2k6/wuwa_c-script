using System;
using System.Buffers;
using System.Buffers.Text;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Text.Json
{
	// Token: 0x0200001E RID: 30
	public sealed class JsonDocument : IDisposable
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600021B RID: 539 RVA: 0x000068D4 File Offset: 0x00004AD4
		internal bool IsDisposable { get; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600021C RID: 540 RVA: 0x000068DC File Offset: 0x00004ADC
		public JsonElement RootElement
		{
			get
			{
				return new JsonElement(this, 0);
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000068E5 File Offset: 0x00004AE5
		private JsonDocument(ReadOnlyMemory<byte> utf8Json, JsonDocument.MetadataDb parsedData, byte[] extraRentedArrayPoolBytes = null, PooledByteBufferWriter extraPooledByteBufferWriter = null, bool isDisposable = true)
		{
			this._utf8Json = utf8Json;
			this._parsedData = parsedData;
			this._extraRentedArrayPoolBytes = extraRentedArrayPoolBytes;
			this._extraPooledByteBufferWriter = extraPooledByteBufferWriter;
			this.IsDisposable = isDisposable;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00006914 File Offset: 0x00004B14
		public void Dispose()
		{
			int length = this._utf8Json.Length;
			if (length == 0 || !this.IsDisposable)
			{
				return;
			}
			this._parsedData.Dispose();
			this._utf8Json = ReadOnlyMemory<byte>.Empty;
			if (this._extraRentedArrayPoolBytes != null)
			{
				byte[] array = Interlocked.Exchange<byte[]>(ref this._extraRentedArrayPoolBytes, null);
				if (array != null)
				{
					array.AsSpan(0, length).Clear();
					ArrayPool<byte>.Shared.Return(array, false);
					return;
				}
			}
			else if (this._extraPooledByteBufferWriter != null)
			{
				PooledByteBufferWriter pooledByteBufferWriter = Interlocked.Exchange<PooledByteBufferWriter>(ref this._extraPooledByteBufferWriter, null);
				if (pooledByteBufferWriter == null)
				{
					return;
				}
				pooledByteBufferWriter.Dispose();
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000069A4 File Offset: 0x00004BA4
		[NullableContext(1)]
		public void WriteTo(Utf8JsonWriter writer)
		{
			if (writer == null)
			{
				ThrowHelper.ThrowArgumentNullException("writer");
			}
			this.RootElement.WriteTo(writer);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000069CD File Offset: 0x00004BCD
		internal JsonTokenType GetJsonTokenType(int index)
		{
			this.CheckNotDisposed();
			return this._parsedData.GetJsonTokenType(index);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000069E4 File Offset: 0x00004BE4
		internal bool ValueIsEscaped(int index, bool isPropertyName)
		{
			this.CheckNotDisposed();
			int index2 = isPropertyName ? (index - 12) : index;
			return this._parsedData.Get(index2).HasComplexChildren;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00006A18 File Offset: 0x00004C18
		internal int GetArrayLength(int index)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.StartArray, dbRow.TokenType);
			return dbRow.SizeOrLength;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00006A4C File Offset: 0x00004C4C
		internal int GetPropertyCount(int index)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.StartObject, dbRow.TokenType);
			return dbRow.SizeOrLength;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00006A80 File Offset: 0x00004C80
		internal JsonElement GetArrayIndexElement(int currentIndex, int arrayIndex)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(currentIndex);
			JsonDocument.CheckExpectedType(JsonTokenType.StartArray, dbRow.TokenType);
			int sizeOrLength = dbRow.SizeOrLength;
			if (arrayIndex >= sizeOrLength)
			{
				throw new IndexOutOfRangeException();
			}
			if (!dbRow.HasComplexChildren)
			{
				return new JsonElement(this, currentIndex + (arrayIndex + 1) * 12);
			}
			int num = 0;
			for (int i = currentIndex + 12; i < this._parsedData.Length; i += 12)
			{
				if (arrayIndex == num)
				{
					return new JsonElement(this, i);
				}
				dbRow = this._parsedData.Get(i);
				if (!dbRow.IsSimpleValue)
				{
					i += 12 * dbRow.NumberOfRows;
				}
				num++;
			}
			throw new IndexOutOfRangeException();
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00006B2C File Offset: 0x00004D2C
		internal int GetEndIndex(int index, bool includeEndElement)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			if (dbRow.IsSimpleValue)
			{
				return index + 12;
			}
			int num = index + 12 * dbRow.NumberOfRows;
			if (includeEndElement)
			{
				num += 12;
			}
			return num;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00006B70 File Offset: 0x00004D70
		internal ReadOnlyMemory<byte> GetRootRawValue()
		{
			return this.GetRawValue(0, true);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00006B7C File Offset: 0x00004D7C
		internal ReadOnlyMemory<byte> GetRawValue(int index, bool includeQuotes)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			if (!dbRow.IsSimpleValue)
			{
				int endIndex = this.GetEndIndex(index, false);
				int location = dbRow.Location;
				dbRow = this._parsedData.Get(endIndex);
				return this._utf8Json.Slice(location, dbRow.Location - location + dbRow.SizeOrLength);
			}
			if (includeQuotes && dbRow.TokenType == JsonTokenType.String)
			{
				return this._utf8Json.Slice(dbRow.Location - 1, dbRow.SizeOrLength + 2);
			}
			return this._utf8Json.Slice(dbRow.Location, dbRow.SizeOrLength);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00006C28 File Offset: 0x00004E28
		private ReadOnlyMemory<byte> GetPropertyRawValue(int valueIndex)
		{
			this.CheckNotDisposed();
			int num = this._parsedData.Get(valueIndex - 12).Location - 1;
			JsonDocument.DbRow dbRow = this._parsedData.Get(valueIndex);
			int num2;
			if (dbRow.IsSimpleValue)
			{
				num2 = dbRow.Location + dbRow.SizeOrLength;
				if (dbRow.TokenType == JsonTokenType.String)
				{
					num2++;
				}
				return this._utf8Json.Slice(num, num2 - num);
			}
			int endIndex = this.GetEndIndex(valueIndex, false);
			dbRow = this._parsedData.Get(endIndex);
			num2 = dbRow.Location + dbRow.SizeOrLength;
			return this._utf8Json.Slice(num, num2 - num);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00006CD0 File Offset: 0x00004ED0
		internal string GetString(int index, JsonTokenType expectedType)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonTokenType tokenType = dbRow.TokenType;
			if (tokenType == JsonTokenType.Null)
			{
				return null;
			}
			JsonDocument.CheckExpectedType(expectedType, tokenType);
			ReadOnlySpan<byte> readOnlySpan = this._utf8Json.Span.Slice(dbRow.Location, dbRow.SizeOrLength);
			if (!dbRow.HasComplexChildren)
			{
				return JsonReaderHelper.TranscodeHelper(readOnlySpan);
			}
			return JsonReaderHelper.GetUnescapedString(readOnlySpan);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00006D40 File Offset: 0x00004F40
		internal unsafe bool TextEquals(int index, ReadOnlySpan<char> otherText, bool isPropertyName)
		{
			this.CheckNotDisposed();
			byte[] array = null;
			int num = checked(otherText.Length * 3);
			Span<byte> span;
			if (num <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(num));
			}
			Span<byte> destination = span;
			int length;
			bool result = JsonWriterHelper.ToUtf8(otherText, destination, out length) != OperationStatus.InvalidData && this.TextEquals(index, destination.Slice(0, length), isPropertyName, true);
			if (array != null)
			{
				destination.Slice(0, length).Clear();
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00006DE4 File Offset: 0x00004FE4
		internal bool TextEquals(int index, ReadOnlySpan<byte> otherUtf8Text, bool isPropertyName, bool shouldUnescape)
		{
			this.CheckNotDisposed();
			int index2 = isPropertyName ? (index - 12) : index;
			JsonDocument.DbRow dbRow = this._parsedData.Get(index2);
			JsonDocument.CheckExpectedType(isPropertyName ? JsonTokenType.PropertyName : JsonTokenType.String, dbRow.TokenType);
			ReadOnlySpan<byte> span = this._utf8Json.Span.Slice(dbRow.Location, dbRow.SizeOrLength);
			if (otherUtf8Text.Length > span.Length || (!shouldUnescape && otherUtf8Text.Length != span.Length))
			{
				return false;
			}
			if (!dbRow.HasComplexChildren || !shouldUnescape)
			{
				return span.SequenceEqual(otherUtf8Text);
			}
			if (otherUtf8Text.Length < span.Length / 6)
			{
				return false;
			}
			int num = span.IndexOf(92);
			return otherUtf8Text.StartsWith(span.Slice(0, num)) && JsonReaderHelper.UnescapeAndCompare(span.Slice(num), otherUtf8Text.Slice(num));
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00006EC7 File Offset: 0x000050C7
		internal string GetNameOfPropertyValue(int index)
		{
			return this.GetString(index - 12, JsonTokenType.PropertyName);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00006ED4 File Offset: 0x000050D4
		internal ReadOnlySpan<byte> GetPropertyNameRaw(int index)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index - 12);
			return this._utf8Json.Span.Slice(dbRow.Location, dbRow.SizeOrLength);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00006F18 File Offset: 0x00005118
		internal bool TryGetValue(int index, [NotNullWhen(true)] out byte[] value)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.String, dbRow.TokenType);
			ReadOnlySpan<byte> readOnlySpan = this._utf8Json.Span.Slice(dbRow.Location, dbRow.SizeOrLength);
			if (dbRow.HasComplexChildren)
			{
				return JsonReaderHelper.TryGetUnescapedBase64Bytes(readOnlySpan, out value);
			}
			return JsonReaderHelper.TryDecodeBase64(readOnlySpan, out value);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00006F80 File Offset: 0x00005180
		internal bool TryGetValue(int index, out sbyte value)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.Number, dbRow.TokenType);
			ReadOnlySpan<byte> source = this._utf8Json.Span.Slice(dbRow.Location, dbRow.SizeOrLength);
			sbyte b;
			int num;
			if (Utf8Parser.TryParse(source, out b, out num, '\0') && num == source.Length)
			{
				value = b;
				return true;
			}
			value = 0;
			return false;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00006FF0 File Offset: 0x000051F0
		internal bool TryGetValue(int index, out byte value)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.Number, dbRow.TokenType);
			ReadOnlySpan<byte> source = this._utf8Json.Span.Slice(dbRow.Location, dbRow.SizeOrLength);
			byte b;
			int num;
			if (Utf8Parser.TryParse(source, out b, out num, '\0') && num == source.Length)
			{
				value = b;
				return true;
			}
			value = 0;
			return false;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00007060 File Offset: 0x00005260
		internal bool TryGetValue(int index, out short value)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.Number, dbRow.TokenType);
			ReadOnlySpan<byte> source = this._utf8Json.Span.Slice(dbRow.Location, dbRow.SizeOrLength);
			short num;
			int num2;
			if (Utf8Parser.TryParse(source, out num, out num2, '\0') && num2 == source.Length)
			{
				value = num;
				return true;
			}
			value = 0;
			return false;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000070D0 File Offset: 0x000052D0
		internal bool TryGetValue(int index, out ushort value)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.Number, dbRow.TokenType);
			ReadOnlySpan<byte> source = this._utf8Json.Span.Slice(dbRow.Location, dbRow.SizeOrLength);
			ushort num;
			int num2;
			if (Utf8Parser.TryParse(source, out num, out num2, '\0') && num2 == source.Length)
			{
				value = num;
				return true;
			}
			value = 0;
			return false;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00007140 File Offset: 0x00005340
		internal bool TryGetValue(int index, out int value)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.Number, dbRow.TokenType);
			ReadOnlySpan<byte> source = this._utf8Json.Span.Slice(dbRow.Location, dbRow.SizeOrLength);
			int num;
			int num2;
			if (Utf8Parser.TryParse(source, out num, out num2, '\0') && num2 == source.Length)
			{
				value = num;
				return true;
			}
			value = 0;
			return false;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000071B0 File Offset: 0x000053B0
		internal bool TryGetValue(int index, out uint value)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.Number, dbRow.TokenType);
			ReadOnlySpan<byte> source = this._utf8Json.Span.Slice(dbRow.Location, dbRow.SizeOrLength);
			uint num;
			int num2;
			if (Utf8Parser.TryParse(source, out num, out num2, '\0') && num2 == source.Length)
			{
				value = num;
				return true;
			}
			value = 0U;
			return false;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00007220 File Offset: 0x00005420
		internal bool TryGetValue(int index, out long value)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.Number, dbRow.TokenType);
			ReadOnlySpan<byte> source = this._utf8Json.Span.Slice(dbRow.Location, dbRow.SizeOrLength);
			long num;
			int num2;
			if (Utf8Parser.TryParse(source, out num, out num2, '\0') && num2 == source.Length)
			{
				value = num;
				return true;
			}
			value = 0L;
			return false;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00007294 File Offset: 0x00005494
		internal bool TryGetValue(int index, out ulong value)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.Number, dbRow.TokenType);
			ReadOnlySpan<byte> source = this._utf8Json.Span.Slice(dbRow.Location, dbRow.SizeOrLength);
			ulong num;
			int num2;
			if (Utf8Parser.TryParse(source, out num, out num2, '\0') && num2 == source.Length)
			{
				value = num;
				return true;
			}
			value = 0UL;
			return false;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00007308 File Offset: 0x00005508
		internal bool TryGetValue(int index, out double value)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.Number, dbRow.TokenType);
			ReadOnlySpan<byte> source = this._utf8Json.Span.Slice(dbRow.Location, dbRow.SizeOrLength);
			double num;
			int num2;
			if (Utf8Parser.TryParse(source, out num, out num2, '\0') && source.Length == num2)
			{
				value = num;
				return true;
			}
			value = 0.0;
			return false;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00007380 File Offset: 0x00005580
		internal bool TryGetValue(int index, out float value)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.Number, dbRow.TokenType);
			ReadOnlySpan<byte> source = this._utf8Json.Span.Slice(dbRow.Location, dbRow.SizeOrLength);
			float num;
			int num2;
			if (Utf8Parser.TryParse(source, out num, out num2, '\0') && source.Length == num2)
			{
				value = num;
				return true;
			}
			value = 0f;
			return false;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000073F4 File Offset: 0x000055F4
		internal bool TryGetValue(int index, out decimal value)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.Number, dbRow.TokenType);
			ReadOnlySpan<byte> source = this._utf8Json.Span.Slice(dbRow.Location, dbRow.SizeOrLength);
			decimal num;
			int num2;
			if (Utf8Parser.TryParse(source, out num, out num2, '\0') && source.Length == num2)
			{
				value = num;
				return true;
			}
			value = 0m;
			return false;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000746C File Offset: 0x0000566C
		internal bool TryGetValue(int index, out DateTime value)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.String, dbRow.TokenType);
			ReadOnlySpan<byte> source = this._utf8Json.Span.Slice(dbRow.Location, dbRow.SizeOrLength);
			if (!JsonHelpers.IsValidDateTimeOffsetParseLength(source.Length))
			{
				value = default(DateTime);
				return false;
			}
			if (dbRow.HasComplexChildren)
			{
				return JsonReaderHelper.TryGetEscapedDateTime(source, out value);
			}
			DateTime dateTime;
			if (JsonHelpers.TryParseAsISO(source, out dateTime))
			{
				value = dateTime;
				return true;
			}
			value = default(DateTime);
			return false;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00007500 File Offset: 0x00005700
		internal bool TryGetValue(int index, out DateTimeOffset value)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.String, dbRow.TokenType);
			ReadOnlySpan<byte> source = this._utf8Json.Span.Slice(dbRow.Location, dbRow.SizeOrLength);
			if (!JsonHelpers.IsValidDateTimeOffsetParseLength(source.Length))
			{
				value = default(DateTimeOffset);
				return false;
			}
			if (dbRow.HasComplexChildren)
			{
				return JsonReaderHelper.TryGetEscapedDateTimeOffset(source, out value);
			}
			DateTimeOffset dateTimeOffset;
			if (JsonHelpers.TryParseAsISO(source, out dateTimeOffset))
			{
				value = dateTimeOffset;
				return true;
			}
			value = default(DateTimeOffset);
			return false;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00007594 File Offset: 0x00005794
		internal bool TryGetValue(int index, out Guid value)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.String, dbRow.TokenType);
			ReadOnlySpan<byte> source = this._utf8Json.Span.Slice(dbRow.Location, dbRow.SizeOrLength);
			if (source.Length > 216)
			{
				value = default(Guid);
				return false;
			}
			if (dbRow.HasComplexChildren)
			{
				return JsonReaderHelper.TryGetEscapedGuid(source, out value);
			}
			Guid guid;
			int num;
			if (source.Length == 36 && Utf8Parser.TryParse(source, out guid, out num, 'D'))
			{
				value = guid;
				return true;
			}
			value = default(Guid);
			return false;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00007638 File Offset: 0x00005838
		internal string GetRawValueAsString(int index)
		{
			return JsonReaderHelper.TranscodeHelper(this.GetRawValue(index, true).Span);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000765C File Offset: 0x0000585C
		internal string GetPropertyRawValueAsString(int valueIndex)
		{
			return JsonReaderHelper.TranscodeHelper(this.GetPropertyRawValue(valueIndex).Span);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00007680 File Offset: 0x00005880
		internal JsonElement CloneElement(int index)
		{
			int endIndex = this.GetEndIndex(index, true);
			JsonDocument.MetadataDb parsedData = this._parsedData.CopySegment(index, endIndex);
			return new JsonDocument(this.GetRawValue(index, true).ToArray(), parsedData, null, null, false).RootElement;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000076C8 File Offset: 0x000058C8
		internal void WriteElementTo(int index, Utf8JsonWriter writer)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			switch (dbRow.TokenType)
			{
			case JsonTokenType.StartObject:
				writer.WriteStartObject();
				this.WriteComplexElement(index, writer);
				return;
			case JsonTokenType.EndObject:
			case JsonTokenType.EndArray:
			case JsonTokenType.PropertyName:
			case JsonTokenType.Comment:
				return;
			case JsonTokenType.StartArray:
				writer.WriteStartArray();
				this.WriteComplexElement(index, writer);
				return;
			case JsonTokenType.String:
				this.WriteString(dbRow, writer);
				return;
			case JsonTokenType.Number:
				writer.WriteNumberValue(this._utf8Json.Slice(dbRow.Location, dbRow.SizeOrLength).Span);
				return;
			case JsonTokenType.True:
				writer.WriteBooleanValue(true);
				return;
			case JsonTokenType.False:
				writer.WriteBooleanValue(false);
				return;
			case JsonTokenType.Null:
				writer.WriteNullValue();
				return;
			default:
				return;
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000778C File Offset: 0x0000598C
		private void WriteComplexElement(int index, Utf8JsonWriter writer)
		{
			int endIndex = this.GetEndIndex(index, true);
			for (int i = index + 12; i < endIndex; i += 12)
			{
				JsonDocument.DbRow dbRow = this._parsedData.Get(i);
				switch (dbRow.TokenType)
				{
				case JsonTokenType.StartObject:
					writer.WriteStartObject();
					break;
				case JsonTokenType.EndObject:
					writer.WriteEndObject();
					break;
				case JsonTokenType.StartArray:
					writer.WriteStartArray();
					break;
				case JsonTokenType.EndArray:
					writer.WriteEndArray();
					break;
				case JsonTokenType.PropertyName:
					this.WritePropertyName(dbRow, writer);
					break;
				case JsonTokenType.String:
					this.WriteString(dbRow, writer);
					break;
				case JsonTokenType.Number:
					writer.WriteNumberValue(this._utf8Json.Slice(dbRow.Location, dbRow.SizeOrLength).Span);
					break;
				case JsonTokenType.True:
					writer.WriteBooleanValue(true);
					break;
				case JsonTokenType.False:
					writer.WriteBooleanValue(false);
					break;
				case JsonTokenType.Null:
					writer.WriteNullValue();
					break;
				}
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000787C File Offset: 0x00005A7C
		private ReadOnlySpan<byte> UnescapeString(in JsonDocument.DbRow row, out ArraySegment<byte> rented)
		{
			int location = row.Location;
			int sizeOrLength = row.SizeOrLength;
			ReadOnlySpan<byte> span = this._utf8Json.Slice(location, sizeOrLength).Span;
			if (!row.HasComplexChildren)
			{
				rented = default(ArraySegment<byte>);
				return span;
			}
			byte[] array = ArrayPool<byte>.Shared.Rent(sizeOrLength);
			int count;
			JsonReaderHelper.Unescape(span, array, out count);
			rented = new ArraySegment<byte>(array, 0, count);
			return rented.AsSpan<byte>();
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000078F8 File Offset: 0x00005AF8
		private static void ClearAndReturn(ArraySegment<byte> rented)
		{
			if (rented.Array != null)
			{
				rented.AsSpan<byte>().Clear();
				ArrayPool<byte>.Shared.Return(rented.Array, false);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00007930 File Offset: 0x00005B30
		internal void WritePropertyName(int index, Utf8JsonWriter writer)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index - 12);
			this.WritePropertyName(dbRow, writer);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000795C File Offset: 0x00005B5C
		private void WritePropertyName(in JsonDocument.DbRow row, Utf8JsonWriter writer)
		{
			ArraySegment<byte> rented = default(ArraySegment<byte>);
			try
			{
				writer.WritePropertyName(this.UnescapeString(row, out rented));
			}
			finally
			{
				JsonDocument.ClearAndReturn(rented);
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000799C File Offset: 0x00005B9C
		private void WriteString(in JsonDocument.DbRow row, Utf8JsonWriter writer)
		{
			ArraySegment<byte> rented = default(ArraySegment<byte>);
			try
			{
				writer.WriteStringValue(this.UnescapeString(row, out rented));
			}
			finally
			{
				JsonDocument.ClearAndReturn(rented);
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000079DC File Offset: 0x00005BDC
		private static void Parse(ReadOnlySpan<byte> utf8JsonSpan, JsonReaderOptions readerOptions, ref JsonDocument.MetadataDb database, ref JsonDocument.StackRowStack stack)
		{
			bool flag = false;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Utf8JsonReader utf8JsonReader = new Utf8JsonReader(utf8JsonSpan, true, new JsonReaderState(readerOptions));
			while (utf8JsonReader.Read())
			{
				JsonTokenType tokenType = utf8JsonReader.TokenType;
				int num4 = (int)utf8JsonReader.TokenStartIndex;
				if (tokenType == JsonTokenType.StartObject)
				{
					if (flag)
					{
						num++;
					}
					num3++;
					database.Append(tokenType, num4, -1);
					JsonDocument.StackRow row = new JsonDocument.StackRow(num, num2 + 1);
					stack.Push(row);
					num = 0;
					num2 = 0;
				}
				else if (tokenType == JsonTokenType.EndObject)
				{
					int index = database.FindIndexOfFirstUnsetSizeOrLength(JsonTokenType.StartObject);
					num3++;
					num2++;
					database.SetLength(index, num);
					int length = database.Length;
					database.Append(tokenType, num4, utf8JsonReader.ValueSpan.Length);
					database.SetNumberOfRows(index, num2);
					database.SetNumberOfRows(length, num2);
					JsonDocument.StackRow stackRow = stack.Pop();
					num = stackRow.SizeOrLength;
					num2 += stackRow.NumberOfRows;
				}
				else if (tokenType == JsonTokenType.StartArray)
				{
					if (flag)
					{
						num++;
					}
					num2++;
					database.Append(tokenType, num4, -1);
					JsonDocument.StackRow row2 = new JsonDocument.StackRow(num, num3 + 1);
					stack.Push(row2);
					num = 0;
					num3 = 0;
				}
				else if (tokenType == JsonTokenType.EndArray)
				{
					int num5 = database.FindIndexOfFirstUnsetSizeOrLength(JsonTokenType.StartArray);
					num3++;
					num2++;
					database.SetLength(num5, num);
					database.SetNumberOfRows(num5, num3);
					if (num + 1 != num3)
					{
						database.SetHasComplexChildren(num5);
					}
					int length2 = database.Length;
					database.Append(tokenType, num4, utf8JsonReader.ValueSpan.Length);
					database.SetNumberOfRows(length2, num3);
					JsonDocument.StackRow stackRow2 = stack.Pop();
					num = stackRow2.SizeOrLength;
					num3 += stackRow2.NumberOfRows;
				}
				else if (tokenType == JsonTokenType.PropertyName)
				{
					num3++;
					num2++;
					num++;
					database.Append(tokenType, num4 + 1, utf8JsonReader.ValueSpan.Length);
					if (utf8JsonReader.ValueIsEscaped)
					{
						database.SetHasComplexChildren(database.Length - 12);
					}
				}
				else
				{
					num3++;
					num2++;
					if (flag)
					{
						num++;
					}
					if (tokenType == JsonTokenType.String)
					{
						database.Append(tokenType, num4 + 1, utf8JsonReader.ValueSpan.Length);
						if (utf8JsonReader.ValueIsEscaped)
						{
							database.SetHasComplexChildren(database.Length - 12);
						}
					}
					else
					{
						database.Append(tokenType, num4, utf8JsonReader.ValueSpan.Length);
					}
				}
				flag = utf8JsonReader.IsInArray;
			}
			database.CompleteAllocations();
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00007C3D File Offset: 0x00005E3D
		private void CheckNotDisposed()
		{
			if (this._utf8Json.IsEmpty)
			{
				ThrowHelper.ThrowObjectDisposedException_JsonDocument();
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00007C51 File Offset: 0x00005E51
		private static void CheckExpectedType(JsonTokenType expected, JsonTokenType actual)
		{
			if (expected != actual)
			{
				ThrowHelper.ThrowJsonElementWrongTypeException(expected, actual);
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00007C5E File Offset: 0x00005E5E
		private static void CheckSupportedOptions(JsonReaderOptions readerOptions, string paramName)
		{
			if (readerOptions.CommentHandling == JsonCommentHandling.Allow)
			{
				throw new ArgumentException(SR.JsonDocumentDoesNotSupportComments, paramName);
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00007C76 File Offset: 0x00005E76
		[return: Nullable(1)]
		public static JsonDocument Parse(ReadOnlyMemory<byte> utf8Json, JsonDocumentOptions options = default(JsonDocumentOptions))
		{
			return JsonDocument.Parse(utf8Json, options.GetReaderOptions(), null, null);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00007C88 File Offset: 0x00005E88
		[return: Nullable(1)]
		public static JsonDocument Parse(ReadOnlySequence<byte> utf8Json, JsonDocumentOptions options = default(JsonDocumentOptions))
		{
			JsonReaderOptions readerOptions = options.GetReaderOptions();
			if (utf8Json.IsSingleSegment)
			{
				return JsonDocument.Parse(utf8Json.First, readerOptions, null, null);
			}
			int num = checked((int)utf8Json.Length);
			byte[] array = ArrayPool<byte>.Shared.Rent(num);
			JsonDocument result;
			try
			{
				utf8Json.CopyTo(array.AsSpan<byte>());
				result = JsonDocument.Parse(array.AsMemory(0, num), readerOptions, array, null);
			}
			catch
			{
				array.AsSpan(0, num).Clear();
				ArrayPool<byte>.Shared.Return(array, false);
				throw;
			}
			return result;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00007D24 File Offset: 0x00005F24
		[NullableContext(1)]
		public static JsonDocument Parse(Stream utf8Json, JsonDocumentOptions options = default(JsonDocumentOptions))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			ArraySegment<byte> segment = JsonDocument.ReadToEnd(utf8Json);
			JsonDocument result;
			try
			{
				result = JsonDocument.Parse(segment.AsMemory<byte>(), options.GetReaderOptions(), segment.Array, null);
			}
			catch
			{
				segment.AsSpan<byte>().Clear();
				ArrayPool<byte>.Shared.Return(segment.Array, false);
				throw;
			}
			return result;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00007D9C File Offset: 0x00005F9C
		internal static JsonDocument ParseRented(PooledByteBufferWriter utf8Json, JsonDocumentOptions options = default(JsonDocumentOptions))
		{
			return JsonDocument.Parse(utf8Json.WrittenMemory, options.GetReaderOptions(), null, utf8Json);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00007DB4 File Offset: 0x00005FB4
		internal static JsonDocument ParseValue(Stream utf8Json, JsonDocumentOptions options)
		{
			ArraySegment<byte> segment = JsonDocument.ReadToEnd(utf8Json);
			byte[] array = new byte[segment.Count];
			Buffer.BlockCopy(segment.Array, 0, array, 0, segment.Count);
			segment.AsSpan<byte>().Clear();
			ArrayPool<byte>.Shared.Return(segment.Array, false);
			return JsonDocument.ParseUnrented(array.AsMemory<byte>(), options.GetReaderOptions(), JsonTokenType.None);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00007E24 File Offset: 0x00006024
		internal static JsonDocument ParseValue(ReadOnlySpan<byte> utf8Json, JsonDocumentOptions options)
		{
			byte[] array = new byte[utf8Json.Length];
			utf8Json.CopyTo(array);
			return JsonDocument.ParseUnrented(array.AsMemory<byte>(), options.GetReaderOptions(), JsonTokenType.None);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00007E63 File Offset: 0x00006063
		internal static JsonDocument ParseValue(string json, JsonDocumentOptions options)
		{
			return JsonDocument.ParseValue(json.AsMemory(), options);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00007E71 File Offset: 0x00006071
		[NullableContext(1)]
		public static Task<JsonDocument> ParseAsync(Stream utf8Json, JsonDocumentOptions options = default(JsonDocumentOptions), CancellationToken cancellationToken = default(CancellationToken))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			return JsonDocument.ParseAsyncCore(utf8Json, options, cancellationToken);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00007E88 File Offset: 0x00006088
		private static Task<JsonDocument> ParseAsyncCore(Stream utf8Json, JsonDocumentOptions options = default(JsonDocumentOptions), CancellationToken cancellationToken = default(CancellationToken))
		{
			JsonDocument.<ParseAsyncCore>d__69 <ParseAsyncCore>d__;
			<ParseAsyncCore>d__.<>t__builder = AsyncTaskMethodBuilder<JsonDocument>.Create();
			<ParseAsyncCore>d__.utf8Json = utf8Json;
			<ParseAsyncCore>d__.options = options;
			<ParseAsyncCore>d__.cancellationToken = cancellationToken;
			<ParseAsyncCore>d__.<>1__state = -1;
			<ParseAsyncCore>d__.<>t__builder.Start<JsonDocument.<ParseAsyncCore>d__69>(ref <ParseAsyncCore>d__);
			return <ParseAsyncCore>d__.<>t__builder.Task;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00007EDC File Offset: 0x000060DC
		internal static Task<JsonDocument> ParseAsyncCoreUnrented(Stream utf8Json, JsonDocumentOptions options = default(JsonDocumentOptions), CancellationToken cancellationToken = default(CancellationToken))
		{
			JsonDocument.<ParseAsyncCoreUnrented>d__70 <ParseAsyncCoreUnrented>d__;
			<ParseAsyncCoreUnrented>d__.<>t__builder = AsyncTaskMethodBuilder<JsonDocument>.Create();
			<ParseAsyncCoreUnrented>d__.utf8Json = utf8Json;
			<ParseAsyncCoreUnrented>d__.options = options;
			<ParseAsyncCoreUnrented>d__.cancellationToken = cancellationToken;
			<ParseAsyncCoreUnrented>d__.<>1__state = -1;
			<ParseAsyncCoreUnrented>d__.<>t__builder.Start<JsonDocument.<ParseAsyncCoreUnrented>d__70>(ref <ParseAsyncCoreUnrented>d__);
			return <ParseAsyncCoreUnrented>d__.<>t__builder.Task;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00007F30 File Offset: 0x00006130
		[return: Nullable(1)]
		public static JsonDocument Parse([StringSyntax("Json")] ReadOnlyMemory<char> json, JsonDocumentOptions options = default(JsonDocumentOptions))
		{
			ReadOnlySpan<char> span = json.Span;
			int utf8ByteCount = JsonReaderHelper.GetUtf8ByteCount(span);
			byte[] array = ArrayPool<byte>.Shared.Rent(utf8ByteCount);
			JsonDocument result;
			try
			{
				int utf8FromText = JsonReaderHelper.GetUtf8FromText(span, array);
				result = JsonDocument.Parse(array.AsMemory(0, utf8FromText), options.GetReaderOptions(), array, null);
			}
			catch
			{
				array.AsSpan(0, utf8ByteCount).Clear();
				ArrayPool<byte>.Shared.Return(array, false);
				throw;
			}
			return result;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00007FB8 File Offset: 0x000061B8
		internal static JsonDocument ParseValue(ReadOnlyMemory<char> json, JsonDocumentOptions options)
		{
			ReadOnlySpan<char> span = json.Span;
			int utf8ByteCount = JsonReaderHelper.GetUtf8ByteCount(span);
			byte[] array = ArrayPool<byte>.Shared.Rent(utf8ByteCount);
			byte[] array2;
			try
			{
				int utf8FromText = JsonReaderHelper.GetUtf8FromText(span, array);
				array2 = new byte[utf8FromText];
				Buffer.BlockCopy(array, 0, array2, 0, utf8FromText);
			}
			finally
			{
				array.AsSpan(0, utf8ByteCount).Clear();
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return JsonDocument.ParseUnrented(array2.AsMemory<byte>(), options.GetReaderOptions(), JsonTokenType.None);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000804C File Offset: 0x0000624C
		[NullableContext(1)]
		public static JsonDocument Parse([StringSyntax("Json")] string json, JsonDocumentOptions options = default(JsonDocumentOptions))
		{
			if (json == null)
			{
				ThrowHelper.ThrowArgumentNullException("json");
			}
			return JsonDocument.Parse(json.AsMemory(), options);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00008067 File Offset: 0x00006267
		[NullableContext(2)]
		public static bool TryParseValue(ref Utf8JsonReader reader, [NotNullWhen(true)] out JsonDocument document)
		{
			return JsonDocument.TryParseValue(ref reader, out document, false, true);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00008074 File Offset: 0x00006274
		[NullableContext(1)]
		public static JsonDocument ParseValue(ref Utf8JsonReader reader)
		{
			JsonDocument result;
			JsonDocument.TryParseValue(ref reader, out result, true, true);
			return result;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00008090 File Offset: 0x00006290
		internal unsafe static bool TryParseValue(ref Utf8JsonReader reader, [NotNullWhen(true)] out JsonDocument document, bool shouldThrow, bool useArrayPools)
		{
			JsonReaderState currentState = reader.CurrentState;
			JsonDocument.CheckSupportedOptions(currentState.Options, "reader");
			Utf8JsonReader utf8JsonReader = reader;
			ReadOnlySpan<byte> readOnlySpan = default(ReadOnlySpan<byte>);
			ReadOnlySequence<byte> readOnlySequence = default(ReadOnlySequence<byte>);
			try
			{
				JsonTokenType tokenType = reader.TokenType;
				if ((tokenType == JsonTokenType.None || tokenType == JsonTokenType.PropertyName) && !reader.Read())
				{
					if (shouldThrow)
					{
						ThrowHelper.ThrowJsonReaderException(ref reader, ExceptionResource.ExpectedJsonTokens, 0, default(ReadOnlySpan<byte>));
					}
					reader = utf8JsonReader;
					document = null;
					return false;
				}
				switch (reader.TokenType)
				{
				case JsonTokenType.StartObject:
				case JsonTokenType.StartArray:
				{
					long tokenStartIndex = reader.TokenStartIndex;
					if (!reader.TrySkip())
					{
						if (shouldThrow)
						{
							ThrowHelper.ThrowJsonReaderException(ref reader, ExceptionResource.ExpectedJsonTokens, 0, default(ReadOnlySpan<byte>));
						}
						reader = utf8JsonReader;
						document = null;
						return false;
					}
					long num = reader.BytesConsumed - tokenStartIndex;
					ReadOnlySequence<byte> originalSequence = reader.OriginalSequence;
					if (originalSequence.IsEmpty)
					{
						readOnlySpan = checked(reader.OriginalSpan.Slice((int)tokenStartIndex, (int)num));
						goto IL_251;
					}
					readOnlySequence = originalSequence.Slice(tokenStartIndex, num);
					goto IL_251;
				}
				case JsonTokenType.String:
				{
					ReadOnlySequence<byte> originalSequence2 = reader.OriginalSequence;
					if (originalSequence2.IsEmpty)
					{
						int length = reader.ValueSpan.Length + 2;
						readOnlySpan = reader.OriginalSpan.Slice((int)reader.TokenStartIndex, length);
						goto IL_251;
					}
					long num2 = 2L;
					if (reader.HasValueSequence)
					{
						num2 += reader.ValueSequence.Length;
					}
					else
					{
						num2 += (long)reader.ValueSpan.Length;
					}
					readOnlySequence = originalSequence2.Slice(reader.TokenStartIndex, num2);
					goto IL_251;
				}
				case JsonTokenType.Number:
					if (reader.HasValueSequence)
					{
						readOnlySequence = reader.ValueSequence;
						goto IL_251;
					}
					readOnlySpan = reader.ValueSpan;
					goto IL_251;
				case JsonTokenType.True:
				case JsonTokenType.False:
				case JsonTokenType.Null:
					if (!useArrayPools)
					{
						document = JsonDocument.CreateForLiteral(reader.TokenType);
						return true;
					}
					if (reader.HasValueSequence)
					{
						readOnlySequence = reader.ValueSequence;
						goto IL_251;
					}
					readOnlySpan = reader.ValueSpan;
					goto IL_251;
				}
				if (shouldThrow)
				{
					byte nextByte = *reader.ValueSpan[0];
					ThrowHelper.ThrowJsonReaderException(ref reader, ExceptionResource.ExpectedStartOfValueNotFound, nextByte, default(ReadOnlySpan<byte>));
				}
				reader = utf8JsonReader;
				document = null;
				return false;
				IL_251:;
			}
			catch
			{
				reader = utf8JsonReader;
				throw;
			}
			int num3 = readOnlySpan.IsEmpty ? checked((int)readOnlySequence.Length) : readOnlySpan.Length;
			if (useArrayPools)
			{
				byte[] array = ArrayPool<byte>.Shared.Rent(num3);
				Span<byte> destination = array.AsSpan(0, num3);
				try
				{
					if (readOnlySpan.IsEmpty)
					{
						readOnlySequence.CopyTo(destination);
					}
					else
					{
						readOnlySpan.CopyTo(destination);
					}
					document = JsonDocument.Parse(array.AsMemory(0, num3), currentState.Options, array, null);
					return true;
				}
				catch
				{
					destination.Clear();
					ArrayPool<byte>.Shared.Return(array, false);
					throw;
				}
			}
			byte[] array2;
			if (readOnlySpan.IsEmpty)
			{
				array2 = readOnlySequence.ToArray<byte>();
			}
			else
			{
				array2 = readOnlySpan.ToArray();
			}
			document = JsonDocument.ParseUnrented(array2, currentState.Options, reader.TokenType);
			return true;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000083FC File Offset: 0x000065FC
		private static JsonDocument CreateForLiteral(JsonTokenType tokenType)
		{
			JsonDocument.<>c__DisplayClass77_0 CS$<>8__locals1;
			CS$<>8__locals1.tokenType = tokenType;
			JsonTokenType tokenType2 = CS$<>8__locals1.tokenType;
			if (tokenType2 == JsonTokenType.True)
			{
				if (JsonDocument.s_trueLiteral == null)
				{
					JsonDocument.s_trueLiteral = JsonDocument.<CreateForLiteral>g__Create|77_0(JsonConstants.TrueValue.ToArray(), ref CS$<>8__locals1);
				}
				return JsonDocument.s_trueLiteral;
			}
			if (tokenType2 == JsonTokenType.False)
			{
				if (JsonDocument.s_falseLiteral == null)
				{
					JsonDocument.s_falseLiteral = JsonDocument.<CreateForLiteral>g__Create|77_0(JsonConstants.FalseValue.ToArray(), ref CS$<>8__locals1);
				}
				return JsonDocument.s_falseLiteral;
			}
			if (JsonDocument.s_nullLiteral == null)
			{
				JsonDocument.s_nullLiteral = JsonDocument.<CreateForLiteral>g__Create|77_0(JsonConstants.NullValue.ToArray(), ref CS$<>8__locals1);
			}
			return JsonDocument.s_nullLiteral;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00008494 File Offset: 0x00006694
		private static JsonDocument Parse(ReadOnlyMemory<byte> utf8Json, JsonReaderOptions readerOptions, byte[] extraRentedArrayPoolBytes = null, PooledByteBufferWriter extraPooledByteBufferWriter = null)
		{
			ReadOnlySpan<byte> span = utf8Json.Span;
			JsonDocument.MetadataDb parsedData = JsonDocument.MetadataDb.CreateRented(utf8Json.Length, false);
			JsonDocument.StackRowStack stackRowStack = new JsonDocument.StackRowStack(512);
			try
			{
				JsonDocument.Parse(span, readerOptions, ref parsedData, ref stackRowStack);
			}
			catch
			{
				parsedData.Dispose();
				throw;
			}
			finally
			{
				stackRowStack.Dispose();
			}
			return new JsonDocument(utf8Json, parsedData, extraRentedArrayPoolBytes, extraPooledByteBufferWriter, true);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00008508 File Offset: 0x00006708
		private static JsonDocument ParseUnrented(ReadOnlyMemory<byte> utf8Json, JsonReaderOptions readerOptions, JsonTokenType tokenType = JsonTokenType.None)
		{
			ReadOnlySpan<byte> span = utf8Json.Span;
			JsonDocument.MetadataDb parsedData;
			if (tokenType == JsonTokenType.String || tokenType == JsonTokenType.Number)
			{
				parsedData = JsonDocument.MetadataDb.CreateLocked(utf8Json.Length);
				JsonDocument.StackRowStack stackRowStack = default(JsonDocument.StackRowStack);
				JsonDocument.Parse(span, readerOptions, ref parsedData, ref stackRowStack);
			}
			else
			{
				parsedData = JsonDocument.MetadataDb.CreateRented(utf8Json.Length, true);
				JsonDocument.StackRowStack stackRowStack2 = new JsonDocument.StackRowStack(512);
				try
				{
					JsonDocument.Parse(span, readerOptions, ref parsedData, ref stackRowStack2);
				}
				finally
				{
					stackRowStack2.Dispose();
				}
			}
			return new JsonDocument(utf8Json, parsedData, null, null, false);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00008590 File Offset: 0x00006790
		private static ArraySegment<byte> ReadToEnd(Stream stream)
		{
			int num = 0;
			byte[] array = null;
			ReadOnlySpan<byte> utf8Bom = JsonConstants.Utf8Bom;
			ArraySegment<byte> result;
			try
			{
				if (stream.CanSeek)
				{
					long num2 = Math.Max((long)utf8Bom.Length, stream.Length - stream.Position) + 1L;
					array = ArrayPool<byte>.Shared.Rent(checked((int)num2));
				}
				else
				{
					array = ArrayPool<byte>.Shared.Rent(4096);
				}
				int num3;
				do
				{
					num3 = stream.Read(array, num, utf8Bom.Length - num);
					num += num3;
				}
				while (num3 > 0 && num < utf8Bom.Length);
				if (num == utf8Bom.Length && utf8Bom.SequenceEqual(array.AsSpan(0, utf8Bom.Length)))
				{
					num = 0;
				}
				do
				{
					if (array.Length == num)
					{
						byte[] array2 = array;
						array = ArrayPool<byte>.Shared.Rent(checked(array2.Length * 2));
						Buffer.BlockCopy(array2, 0, array, 0, array2.Length);
						ArrayPool<byte>.Shared.Return(array2, true);
					}
					num3 = stream.Read(array, num, array.Length - num);
					num += num3;
				}
				while (num3 > 0);
				result = new ArraySegment<byte>(array, 0, num);
			}
			catch
			{
				if (array != null)
				{
					array.AsSpan(0, num).Clear();
					ArrayPool<byte>.Shared.Return(array, false);
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000086C8 File Offset: 0x000068C8
		private static ValueTask<ArraySegment<byte>> ReadToEndAsync(Stream stream, CancellationToken cancellationToken)
		{
			JsonDocument.<ReadToEndAsync>d__81 <ReadToEndAsync>d__;
			<ReadToEndAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder<ArraySegment<byte>>.Create();
			<ReadToEndAsync>d__.stream = stream;
			<ReadToEndAsync>d__.cancellationToken = cancellationToken;
			<ReadToEndAsync>d__.<>1__state = -1;
			<ReadToEndAsync>d__.<>t__builder.Start<JsonDocument.<ReadToEndAsync>d__81>(ref <ReadToEndAsync>d__);
			return <ReadToEndAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00008714 File Offset: 0x00006914
		internal unsafe bool TryGetNamedPropertyValue(int index, ReadOnlySpan<char> propertyName, out JsonElement value)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.StartObject, dbRow.TokenType);
			if (dbRow.NumberOfRows == 1)
			{
				value = default(JsonElement);
				return false;
			}
			int maxByteCount = JsonReaderHelper.s_utf8Encoding.GetMaxByteCount(propertyName.Length);
			int startIndex = index + 12;
			int num = checked(dbRow.NumberOfRows * 12 + index);
			if (maxByteCount < 256)
			{
				Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
				int utf8FromText = JsonReaderHelper.GetUtf8FromText(propertyName, span);
				span = span.Slice(0, utf8FromText);
				return this.TryGetNamedPropertyValue(startIndex, num, span, out value);
			}
			int length = propertyName.Length;
			for (int i = num - 12; i > index; i -= 12)
			{
				int num2 = i;
				dbRow = this._parsedData.Get(i);
				if (dbRow.IsSimpleValue)
				{
					i -= 12;
				}
				else
				{
					i -= 12 * (dbRow.NumberOfRows + 1);
				}
				if (this._parsedData.Get(i).SizeOrLength >= length)
				{
					byte[] array = ArrayPool<byte>.Shared.Rent(maxByteCount);
					Span<byte> span2 = default(Span<byte>);
					try
					{
						int utf8FromText2 = JsonReaderHelper.GetUtf8FromText(propertyName, array);
						span2 = array.AsSpan(0, utf8FromText2);
						return this.TryGetNamedPropertyValue(startIndex, num2 + 12, span2, out value);
					}
					finally
					{
						span2.Clear();
						ArrayPool<byte>.Shared.Return(array, false);
					}
				}
			}
			value = default(JsonElement);
			return false;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000088A4 File Offset: 0x00006AA4
		internal bool TryGetNamedPropertyValue(int index, ReadOnlySpan<byte> propertyName, out JsonElement value)
		{
			this.CheckNotDisposed();
			JsonDocument.DbRow dbRow = this._parsedData.Get(index);
			JsonDocument.CheckExpectedType(JsonTokenType.StartObject, dbRow.TokenType);
			if (dbRow.NumberOfRows == 1)
			{
				value = default(JsonElement);
				return false;
			}
			int endIndex = checked(dbRow.NumberOfRows * 12 + index);
			return this.TryGetNamedPropertyValue(index + 12, endIndex, propertyName, out value);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00008900 File Offset: 0x00006B00
		private unsafe bool TryGetNamedPropertyValue(int startIndex, int endIndex, ReadOnlySpan<byte> propertyName, out JsonElement value)
		{
			ReadOnlySpan<byte> span = this._utf8Json.Span;
			Span<byte> span2 = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			int i = endIndex - 12;
			while (i > startIndex)
			{
				JsonDocument.DbRow dbRow = this._parsedData.Get(i);
				if (dbRow.IsSimpleValue)
				{
					i -= 12;
				}
				else
				{
					i -= 12 * (dbRow.NumberOfRows + 1);
				}
				dbRow = this._parsedData.Get(i);
				ReadOnlySpan<byte> span3 = span.Slice(dbRow.Location, dbRow.SizeOrLength);
				if (!dbRow.HasComplexChildren)
				{
					goto IL_16F;
				}
				if (span3.Length > propertyName.Length)
				{
					int num = span3.IndexOf(92);
					if (propertyName.Length > num && span3.Slice(0, num).SequenceEqual(propertyName.Slice(0, num)))
					{
						int num2 = span3.Length - num;
						int length = 0;
						byte[] array = null;
						try
						{
							Span<byte> destination = (num2 <= span2.Length) ? span2 : (array = ArrayPool<byte>.Shared.Rent(num2));
							JsonReaderHelper.Unescape(span3.Slice(num), destination, 0, out length);
							if (destination.Slice(0, length).SequenceEqual(propertyName.Slice(num)))
							{
								value = new JsonElement(this, i + 12);
								return true;
							}
							goto IL_18C;
						}
						finally
						{
							if (array != null)
							{
								array.AsSpan(0, length).Clear();
								ArrayPool<byte>.Shared.Return(array, false);
							}
						}
						goto IL_16F;
					}
				}
				IL_18C:
				i -= 12;
				continue;
				IL_16F:
				if (span3.SequenceEqual(propertyName))
				{
					value = new JsonElement(this, i + 12);
					return true;
				}
				goto IL_18C;
			}
			value = default(JsonElement);
			return false;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00008AC4 File Offset: 0x00006CC4
		[CompilerGenerated]
		internal static JsonDocument <CreateForLiteral>g__Create|77_0(byte[] utf8Json, ref JsonDocument.<>c__DisplayClass77_0 A_1)
		{
			JsonDocument.MetadataDb parsedData = JsonDocument.MetadataDb.CreateLocked(utf8Json.Length);
			parsedData.Append(A_1.tokenType, 0, utf8Json.Length);
			return new JsonDocument(utf8Json, parsedData, null, null, false);
		}

		// Token: 0x04000038 RID: 56
		private ReadOnlyMemory<byte> _utf8Json;

		// Token: 0x04000039 RID: 57
		private JsonDocument.MetadataDb _parsedData;

		// Token: 0x0400003A RID: 58
		private byte[] _extraRentedArrayPoolBytes;

		// Token: 0x0400003B RID: 59
		private PooledByteBufferWriter _extraPooledByteBufferWriter;

		// Token: 0x0400003D RID: 61
		private static JsonDocument s_nullLiteral;

		// Token: 0x0400003E RID: 62
		private static JsonDocument s_trueLiteral;

		// Token: 0x0400003F RID: 63
		private static JsonDocument s_falseLiteral;

		// Token: 0x0200001F RID: 31
		internal readonly struct DbRow
		{
			// Token: 0x170000ED RID: 237
			// (get) Token: 0x06000264 RID: 612 RVA: 0x00008AFA File Offset: 0x00006CFA
			internal int Location
			{
				get
				{
					return this._location;
				}
			}

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x06000265 RID: 613 RVA: 0x00008B02 File Offset: 0x00006D02
			internal int SizeOrLength
			{
				get
				{
					return this._sizeOrLengthUnion & int.MaxValue;
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x06000266 RID: 614 RVA: 0x00008B10 File Offset: 0x00006D10
			internal bool IsUnknownSize
			{
				get
				{
					return this._sizeOrLengthUnion == -1;
				}
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x06000267 RID: 615 RVA: 0x00008B1B File Offset: 0x00006D1B
			internal bool HasComplexChildren
			{
				get
				{
					return this._sizeOrLengthUnion < 0;
				}
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x06000268 RID: 616 RVA: 0x00008B26 File Offset: 0x00006D26
			internal int NumberOfRows
			{
				get
				{
					return this._numberOfRowsAndTypeUnion & 268435455;
				}
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x06000269 RID: 617 RVA: 0x00008B34 File Offset: 0x00006D34
			internal JsonTokenType TokenType
			{
				get
				{
					return (JsonTokenType)((uint)this._numberOfRowsAndTypeUnion >> 28);
				}
			}

			// Token: 0x0600026A RID: 618 RVA: 0x00008B40 File Offset: 0x00006D40
			internal DbRow(JsonTokenType jsonTokenType, int location, int sizeOrLength)
			{
				this._location = location;
				this._sizeOrLengthUnion = sizeOrLength;
				this._numberOfRowsAndTypeUnion = (int)((int)jsonTokenType << 28);
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x0600026B RID: 619 RVA: 0x00008B5A File Offset: 0x00006D5A
			internal bool IsSimpleValue
			{
				get
				{
					return this.TokenType >= JsonTokenType.PropertyName;
				}
			}

			// Token: 0x04000040 RID: 64
			private readonly int _location;

			// Token: 0x04000041 RID: 65
			private readonly int _sizeOrLengthUnion;

			// Token: 0x04000042 RID: 66
			private readonly int _numberOfRowsAndTypeUnion;
		}

		// Token: 0x02000020 RID: 32
		private struct MetadataDb : IDisposable
		{
			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x0600026C RID: 620 RVA: 0x00008B68 File Offset: 0x00006D68
			// (set) Token: 0x0600026D RID: 621 RVA: 0x00008B70 File Offset: 0x00006D70
			internal int Length { readonly get; private set; }

			// Token: 0x0600026E RID: 622 RVA: 0x00008B79 File Offset: 0x00006D79
			private MetadataDb(byte[] initialDb, bool isLocked, bool convertToAlloc)
			{
				this._data = initialDb;
				this._isLocked = isLocked;
				this._convertToAlloc = convertToAlloc;
				this.Length = 0;
			}

			// Token: 0x0600026F RID: 623 RVA: 0x00008B97 File Offset: 0x00006D97
			internal MetadataDb(byte[] completeDb)
			{
				this._data = completeDb;
				this._isLocked = true;
				this._convertToAlloc = false;
				this.Length = completeDb.Length;
			}

			// Token: 0x06000270 RID: 624 RVA: 0x00008BB8 File Offset: 0x00006DB8
			internal static JsonDocument.MetadataDb CreateRented(int payloadLength, bool convertToAlloc)
			{
				int num = payloadLength + 12;
				if (num > 1048576 && num <= 4194304)
				{
					num = 1048576;
				}
				return new JsonDocument.MetadataDb(ArrayPool<byte>.Shared.Rent(num), false, convertToAlloc);
			}

			// Token: 0x06000271 RID: 625 RVA: 0x00008BF2 File Offset: 0x00006DF2
			internal static JsonDocument.MetadataDb CreateLocked(int payloadLength)
			{
				return new JsonDocument.MetadataDb(new byte[payloadLength + 12], true, false);
			}

			// Token: 0x06000272 RID: 626 RVA: 0x00008C04 File Offset: 0x00006E04
			public void Dispose()
			{
				byte[] array = Interlocked.Exchange<byte[]>(ref this._data, null);
				if (array == null)
				{
					return;
				}
				ArrayPool<byte>.Shared.Return(array, false);
				this.Length = 0;
			}

			// Token: 0x06000273 RID: 627 RVA: 0x00008C38 File Offset: 0x00006E38
			internal void CompleteAllocations()
			{
				if (!this._isLocked)
				{
					if (this._convertToAlloc)
					{
						byte[] data = this._data;
						this._data = this._data.AsSpan(0, this.Length).ToArray();
						this._isLocked = true;
						this._convertToAlloc = false;
						ArrayPool<byte>.Shared.Return(data, false);
						return;
					}
					if (this.Length <= this._data.Length / 2)
					{
						byte[] array = ArrayPool<byte>.Shared.Rent(this.Length);
						byte[] array2 = array;
						if (array.Length < this._data.Length)
						{
							Buffer.BlockCopy(this._data, 0, array, 0, this.Length);
							array2 = this._data;
							this._data = array;
						}
						ArrayPool<byte>.Shared.Return(array2, false);
					}
				}
			}

			// Token: 0x06000274 RID: 628 RVA: 0x00008CFC File Offset: 0x00006EFC
			internal void Append(JsonTokenType tokenType, int startLocation, int length)
			{
				if (this.Length >= this._data.Length - 12)
				{
					this.Enlarge();
				}
				JsonDocument.DbRow dbRow = new JsonDocument.DbRow(tokenType, startLocation, length);
				MemoryMarshal.Write<JsonDocument.DbRow>(this._data.AsSpan(this.Length), dbRow);
				this.Length += 12;
			}

			// Token: 0x06000275 RID: 629 RVA: 0x00008D54 File Offset: 0x00006F54
			private void Enlarge()
			{
				byte[] data = this._data;
				int num = data.Length * 2;
				if (num > 2147483591)
				{
					num = 2147483591;
				}
				if (num == data.Length)
				{
					num = int.MaxValue;
				}
				this._data = ArrayPool<byte>.Shared.Rent(num);
				Buffer.BlockCopy(data, 0, this._data, 0, data.Length);
				ArrayPool<byte>.Shared.Return(data, false);
			}

			// Token: 0x06000276 RID: 630 RVA: 0x00008DB6 File Offset: 0x00006FB6
			internal void SetLength(int index, int length)
			{
				MemoryMarshal.Write<int>(this._data.AsSpan(index + 4), length);
			}

			// Token: 0x06000277 RID: 631 RVA: 0x00008DD0 File Offset: 0x00006FD0
			internal void SetNumberOfRows(int index, int numberOfRows)
			{
				Span<byte> span = this._data.AsSpan(index + 8);
				int num = (MemoryMarshal.Read<int>(span) & -268435456) | numberOfRows;
				MemoryMarshal.Write<int>(span, num);
			}

			// Token: 0x06000278 RID: 632 RVA: 0x00008E08 File Offset: 0x00007008
			internal void SetHasComplexChildren(int index)
			{
				Span<byte> span = this._data.AsSpan(index + 4);
				int num = MemoryMarshal.Read<int>(span) | int.MinValue;
				MemoryMarshal.Write<int>(span, num);
			}

			// Token: 0x06000279 RID: 633 RVA: 0x00008E3C File Offset: 0x0000703C
			internal int FindIndexOfFirstUnsetSizeOrLength(JsonTokenType lookupType)
			{
				return this.FindOpenElement(lookupType);
			}

			// Token: 0x0600027A RID: 634 RVA: 0x00008E48 File Offset: 0x00007048
			private int FindOpenElement(JsonTokenType lookupType)
			{
				Span<byte> span = this._data.AsSpan(0, this.Length);
				for (int i = this.Length - 12; i >= 0; i -= 12)
				{
					JsonDocument.DbRow dbRow = MemoryMarshal.Read<JsonDocument.DbRow>(span.Slice(i));
					if (dbRow.IsUnknownSize && dbRow.TokenType == lookupType)
					{
						return i;
					}
				}
				return -1;
			}

			// Token: 0x0600027B RID: 635 RVA: 0x00008EA6 File Offset: 0x000070A6
			internal JsonDocument.DbRow Get(int index)
			{
				return MemoryMarshal.Read<JsonDocument.DbRow>(this._data.AsSpan(index));
			}

			// Token: 0x0600027C RID: 636 RVA: 0x00008EBE File Offset: 0x000070BE
			internal JsonTokenType GetJsonTokenType(int index)
			{
				return (JsonTokenType)(MemoryMarshal.Read<uint>(this._data.AsSpan(index + 8)) >> 28);
			}

			// Token: 0x0600027D RID: 637 RVA: 0x00008EDC File Offset: 0x000070DC
			internal unsafe JsonDocument.MetadataDb CopySegment(int startIndex, int endIndex)
			{
				JsonDocument.DbRow dbRow = this.Get(startIndex);
				int num = endIndex - startIndex;
				byte[] array = new byte[num];
				this._data.AsSpan(startIndex, num).CopyTo(array);
				Span<int> span = MemoryMarshal.Cast<byte, int>(array);
				int num2 = *span[0];
				if (dbRow.TokenType == JsonTokenType.String)
				{
					num2--;
				}
				for (int i = (num - 12) / 4; i >= 0; i -= 3)
				{
					*span[i] -= num2;
				}
				return new JsonDocument.MetadataDb(array);
			}

			// Token: 0x04000044 RID: 68
			private byte[] _data;

			// Token: 0x04000045 RID: 69
			private bool _convertToAlloc;

			// Token: 0x04000046 RID: 70
			private bool _isLocked;
		}

		// Token: 0x02000021 RID: 33
		private readonly struct StackRow
		{
			// Token: 0x0600027E RID: 638 RVA: 0x00008F69 File Offset: 0x00007169
			internal StackRow(int sizeOrLength = 0, int numberOfRows = -1)
			{
				this.SizeOrLength = sizeOrLength;
				this.NumberOfRows = numberOfRows;
			}

			// Token: 0x04000047 RID: 71
			internal readonly int SizeOrLength;

			// Token: 0x04000048 RID: 72
			internal readonly int NumberOfRows;
		}

		// Token: 0x02000022 RID: 34
		private struct StackRowStack : IDisposable
		{
			// Token: 0x0600027F RID: 639 RVA: 0x00008F79 File Offset: 0x00007179
			public StackRowStack(int initialSize)
			{
				this._rentedBuffer = ArrayPool<byte>.Shared.Rent(initialSize);
				this._topOfStack = this._rentedBuffer.Length;
			}

			// Token: 0x06000280 RID: 640 RVA: 0x00008F9C File Offset: 0x0000719C
			public void Dispose()
			{
				byte[] rentedBuffer = this._rentedBuffer;
				this._rentedBuffer = null;
				this._topOfStack = 0;
				if (rentedBuffer != null)
				{
					ArrayPool<byte>.Shared.Return(rentedBuffer, false);
				}
			}

			// Token: 0x06000281 RID: 641 RVA: 0x00008FCD File Offset: 0x000071CD
			internal void Push(JsonDocument.StackRow row)
			{
				if (this._topOfStack < 8)
				{
					this.Enlarge();
				}
				this._topOfStack -= 8;
				MemoryMarshal.Write<JsonDocument.StackRow>(this._rentedBuffer.AsSpan(this._topOfStack), row);
			}

			// Token: 0x06000282 RID: 642 RVA: 0x00009004 File Offset: 0x00007204
			internal JsonDocument.StackRow Pop()
			{
				JsonDocument.StackRow result = MemoryMarshal.Read<JsonDocument.StackRow>(this._rentedBuffer.AsSpan(this._topOfStack));
				this._topOfStack += 8;
				return result;
			}

			// Token: 0x06000283 RID: 643 RVA: 0x00009030 File Offset: 0x00007230
			private void Enlarge()
			{
				byte[] rentedBuffer = this._rentedBuffer;
				this._rentedBuffer = ArrayPool<byte>.Shared.Rent(rentedBuffer.Length * 2);
				Buffer.BlockCopy(rentedBuffer, this._topOfStack, this._rentedBuffer, this._rentedBuffer.Length - rentedBuffer.Length + this._topOfStack, rentedBuffer.Length - this._topOfStack);
				this._topOfStack += this._rentedBuffer.Length - rentedBuffer.Length;
				ArrayPool<byte>.Shared.Return(rentedBuffer, false);
			}

			// Token: 0x04000049 RID: 73
			private byte[] _rentedBuffer;

			// Token: 0x0400004A RID: 74
			private int _topOfStack;
		}
	}
}
