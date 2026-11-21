using System;
using System.Collections.Generic;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000958 RID: 2392
	internal sealed class TraceLoggingMetadataCollector
	{
		// Token: 0x06008E94 RID: 36500 RVA: 0x00160180 File Offset: 0x0015E380
		internal TraceLoggingMetadataCollector()
		{
			this.impl = new TraceLoggingMetadataCollector.Impl();
		}

		// Token: 0x06008E95 RID: 36501 RVA: 0x0016019E File Offset: 0x0015E39E
		private TraceLoggingMetadataCollector(TraceLoggingMetadataCollector other, FieldMetadata group)
		{
			this.impl = other.impl;
			this.currentGroup = group;
		}

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x06008E96 RID: 36502 RVA: 0x001601C4 File Offset: 0x0015E3C4
		// (set) Token: 0x06008E97 RID: 36503 RVA: 0x001601CC File Offset: 0x0015E3CC
		internal EventFieldTags Tags { get; set; }

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x06008E98 RID: 36504 RVA: 0x001601D5 File Offset: 0x0015E3D5
		internal int ScratchSize
		{
			get
			{
				return (int)this.impl.scratchSize;
			}
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x06008E99 RID: 36505 RVA: 0x001601E2 File Offset: 0x0015E3E2
		internal int DataCount
		{
			get
			{
				return (int)this.impl.dataCount;
			}
		}

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06008E9A RID: 36506 RVA: 0x001601EF File Offset: 0x0015E3EF
		internal int PinCount
		{
			get
			{
				return (int)this.impl.pinCount;
			}
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x06008E9B RID: 36507 RVA: 0x001601FC File Offset: 0x0015E3FC
		private bool BeginningBufferedArray
		{
			get
			{
				return this.bufferedArrayFieldCount == 0;
			}
		}

		// Token: 0x06008E9C RID: 36508 RVA: 0x00160208 File Offset: 0x0015E408
		public TraceLoggingMetadataCollector AddGroup(string name)
		{
			TraceLoggingMetadataCollector result = this;
			if (name != null || this.BeginningBufferedArray)
			{
				FieldMetadata fieldMetadata = new FieldMetadata(name, TraceLoggingDataType.Struct, this.Tags, this.BeginningBufferedArray);
				this.AddField(fieldMetadata);
				result = new TraceLoggingMetadataCollector(this, fieldMetadata);
			}
			return result;
		}

		// Token: 0x06008E9D RID: 36509 RVA: 0x00160248 File Offset: 0x0015E448
		public void AddScalar(string name, TraceLoggingDataType type)
		{
			TraceLoggingDataType traceLoggingDataType = type & (TraceLoggingDataType)31;
			int num;
			switch (traceLoggingDataType)
			{
			case TraceLoggingDataType.Int8:
			case TraceLoggingDataType.UInt8:
				break;
			case TraceLoggingDataType.Int16:
			case TraceLoggingDataType.UInt16:
				goto IL_6F;
			case TraceLoggingDataType.Int32:
			case TraceLoggingDataType.UInt32:
			case TraceLoggingDataType.Float:
			case TraceLoggingDataType.Boolean32:
			case TraceLoggingDataType.HexInt32:
				num = 4;
				goto IL_8B;
			case TraceLoggingDataType.Int64:
			case TraceLoggingDataType.UInt64:
			case TraceLoggingDataType.Double:
			case TraceLoggingDataType.FileTime:
			case TraceLoggingDataType.HexInt64:
				num = 8;
				goto IL_8B;
			case TraceLoggingDataType.Binary:
			case (TraceLoggingDataType)16:
			case (TraceLoggingDataType)19:
				goto IL_80;
			case TraceLoggingDataType.Guid:
			case TraceLoggingDataType.SystemTime:
				num = 16;
				goto IL_8B;
			default:
				if (traceLoggingDataType != TraceLoggingDataType.Char8)
				{
					if (traceLoggingDataType != TraceLoggingDataType.Char16)
					{
						goto IL_80;
					}
					goto IL_6F;
				}
				break;
			}
			num = 1;
			goto IL_8B;
			IL_6F:
			num = 2;
			goto IL_8B;
			IL_80:
			throw new ArgumentOutOfRangeException("type");
			IL_8B:
			int size = num;
			this.impl.AddScalar(size);
			this.AddField(new FieldMetadata(name, type, this.Tags, this.BeginningBufferedArray));
		}

		// Token: 0x06008E9E RID: 36510 RVA: 0x00160307 File Offset: 0x0015E507
		public void AddNullTerminatedString(string name, TraceLoggingDataType type)
		{
			if ((type & (TraceLoggingDataType)31) != TraceLoggingDataType.Utf16String)
			{
				throw new ArgumentOutOfRangeException("type");
			}
			this.impl.AddNonscalar();
			this.AddField(new FieldMetadata(name, type, this.Tags, this.BeginningBufferedArray));
		}

		// Token: 0x06008E9F RID: 36511 RVA: 0x00160340 File Offset: 0x0015E540
		public void AddArray(string name, TraceLoggingDataType type)
		{
			TraceLoggingDataType traceLoggingDataType = type & (TraceLoggingDataType)31;
			switch (traceLoggingDataType)
			{
			case TraceLoggingDataType.Int8:
			case TraceLoggingDataType.UInt8:
			case TraceLoggingDataType.Int16:
			case TraceLoggingDataType.UInt16:
			case TraceLoggingDataType.Int32:
			case TraceLoggingDataType.UInt32:
			case TraceLoggingDataType.Int64:
			case TraceLoggingDataType.UInt64:
			case TraceLoggingDataType.Float:
			case TraceLoggingDataType.Double:
			case TraceLoggingDataType.Boolean32:
			case TraceLoggingDataType.Guid:
			case TraceLoggingDataType.FileTime:
			case TraceLoggingDataType.HexInt32:
			case TraceLoggingDataType.HexInt64:
				goto IL_74;
			case TraceLoggingDataType.Binary:
			case (TraceLoggingDataType)16:
			case TraceLoggingDataType.SystemTime:
			case (TraceLoggingDataType)19:
				break;
			default:
				if (traceLoggingDataType == TraceLoggingDataType.Char8 || traceLoggingDataType == TraceLoggingDataType.Char16)
				{
					goto IL_74;
				}
				break;
			}
			throw new ArgumentOutOfRangeException("type");
			IL_74:
			if (this.BeginningBufferedArray)
			{
				throw new NotSupportedException(SR.EventSource_NotSupportedNestedArraysEnums);
			}
			this.impl.AddScalar(2);
			this.impl.AddNonscalar();
			this.AddField(new FieldMetadata(name, type, this.Tags, true));
		}

		// Token: 0x06008EA0 RID: 36512 RVA: 0x001603FF File Offset: 0x0015E5FF
		public void BeginBufferedArray()
		{
			if (this.bufferedArrayFieldCount >= 0)
			{
				throw new NotSupportedException(SR.EventSource_NotSupportedNestedArraysEnums);
			}
			this.bufferedArrayFieldCount = 0;
			this.impl.BeginBuffered();
		}

		// Token: 0x06008EA1 RID: 36513 RVA: 0x00160427 File Offset: 0x0015E627
		public void EndBufferedArray()
		{
			if (this.bufferedArrayFieldCount != 1)
			{
				throw new InvalidOperationException(SR.EventSource_IncorrentlyAuthoredTypeInfo);
			}
			this.bufferedArrayFieldCount = int.MinValue;
			this.impl.EndBuffered();
		}

		// Token: 0x06008EA2 RID: 36514 RVA: 0x00160454 File Offset: 0x0015E654
		internal byte[] GetMetadata()
		{
			byte[] array = new byte[this.impl.Encode(null)];
			this.impl.Encode(array);
			return array;
		}

		// Token: 0x06008EA3 RID: 36515 RVA: 0x00160481 File Offset: 0x0015E681
		private void AddField(FieldMetadata fieldMetadata)
		{
			this.Tags = EventFieldTags.None;
			this.bufferedArrayFieldCount++;
			this.impl.fields.Add(fieldMetadata);
			FieldMetadata fieldMetadata2 = this.currentGroup;
			if (fieldMetadata2 == null)
			{
				return;
			}
			fieldMetadata2.IncrementStructFieldCount();
		}

		// Token: 0x040021B2 RID: 8626
		private readonly TraceLoggingMetadataCollector.Impl impl;

		// Token: 0x040021B3 RID: 8627
		private readonly FieldMetadata currentGroup;

		// Token: 0x040021B4 RID: 8628
		private int bufferedArrayFieldCount = int.MinValue;

		// Token: 0x02000959 RID: 2393
		private sealed class Impl
		{
			// Token: 0x06008EA4 RID: 36516 RVA: 0x001604B9 File Offset: 0x0015E6B9
			public void AddScalar(int size)
			{
				checked
				{
					if (this.bufferNesting == 0)
					{
						if (!this.scalar)
						{
							this.dataCount += 1;
						}
						this.scalar = true;
						this.scratchSize = (short)((int)this.scratchSize + size);
					}
				}
			}

			// Token: 0x06008EA5 RID: 36517 RVA: 0x001604F0 File Offset: 0x0015E6F0
			public void AddNonscalar()
			{
				checked
				{
					if (this.bufferNesting == 0)
					{
						this.scalar = false;
						this.pinCount += 1;
						this.dataCount += 1;
					}
				}
			}

			// Token: 0x06008EA6 RID: 36518 RVA: 0x0016051F File Offset: 0x0015E71F
			public void BeginBuffered()
			{
				if (this.bufferNesting == 0)
				{
					this.AddNonscalar();
				}
				this.bufferNesting++;
			}

			// Token: 0x06008EA7 RID: 36519 RVA: 0x0016053D File Offset: 0x0015E73D
			public void EndBuffered()
			{
				this.bufferNesting--;
			}

			// Token: 0x06008EA8 RID: 36520 RVA: 0x00160550 File Offset: 0x0015E750
			public int Encode(byte[] metadata)
			{
				int result = 0;
				foreach (FieldMetadata fieldMetadata in this.fields)
				{
					fieldMetadata.Encode(ref result, metadata);
				}
				return result;
			}

			// Token: 0x040021B6 RID: 8630
			internal readonly List<FieldMetadata> fields = new List<FieldMetadata>();

			// Token: 0x040021B7 RID: 8631
			internal short scratchSize;

			// Token: 0x040021B8 RID: 8632
			internal sbyte dataCount;

			// Token: 0x040021B9 RID: 8633
			internal sbyte pinCount;

			// Token: 0x040021BA RID: 8634
			private int bufferNesting;

			// Token: 0x040021BB RID: 8635
			private bool scalar;
		}
	}
}
