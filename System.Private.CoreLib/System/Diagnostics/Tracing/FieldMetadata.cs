using System;
using System.Text;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000928 RID: 2344
	internal sealed class FieldMetadata
	{
		// Token: 0x06008DB4 RID: 36276 RVA: 0x0015D652 File Offset: 0x0015B852
		public FieldMetadata(string name, TraceLoggingDataType type, EventFieldTags tags, bool variableCount) : this(name, type, tags, variableCount ? 64 : 0, 0, null)
		{
		}

		// Token: 0x06008DB5 RID: 36277 RVA: 0x0015D668 File Offset: 0x0015B868
		private FieldMetadata(string name, TraceLoggingDataType dataType, EventFieldTags tags, byte countFlags, ushort fixedCount = 0, byte[] custom = null)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name", "This usually means that the object passed to Write is of a type that does not support being used as the top-level object in an event, e.g. a primitive or built-in type.");
			}
			Statics.CheckName(name);
			int num = (int)(dataType & (TraceLoggingDataType)31);
			this.name = name;
			this.nameSize = Encoding.UTF8.GetByteCount(this.name) + 1;
			this.inType = (byte)(num | (int)countFlags);
			this.outType = (byte)(dataType >> 8 & (TraceLoggingDataType)127);
			this.tags = tags;
			this.fixedCount = fixedCount;
			this.custom = custom;
			if (countFlags != 0)
			{
				if (num == 0)
				{
					throw new NotSupportedException(SR.EventSource_NotSupportedArrayOfNil);
				}
				if (num == 14)
				{
					throw new NotSupportedException(SR.EventSource_NotSupportedArrayOfBinary);
				}
				if (num == 1 || num == 2)
				{
					throw new NotSupportedException(SR.EventSource_NotSupportedArrayOfNullTerminatedString);
				}
			}
			if ((this.tags & (EventFieldTags)268435455) != EventFieldTags.None)
			{
				this.outType |= 128;
			}
			if (this.outType != 0)
			{
				this.inType |= 128;
			}
		}

		// Token: 0x06008DB6 RID: 36278 RVA: 0x0015D758 File Offset: 0x0015B958
		public void IncrementStructFieldCount()
		{
			this.inType |= 128;
			this.outType += 1;
			if ((this.outType & 127) == 0)
			{
				throw new NotSupportedException(SR.EventSource_TooManyFields);
			}
		}

		// Token: 0x06008DB7 RID: 36279 RVA: 0x0015D794 File Offset: 0x0015B994
		public void Encode(ref int pos, byte[] metadata)
		{
			if (metadata != null)
			{
				Encoding.UTF8.GetBytes(this.name, 0, this.name.Length, metadata, pos);
			}
			pos += this.nameSize;
			if (metadata != null)
			{
				metadata[pos] = this.inType;
			}
			pos++;
			if ((this.inType & 128) != 0)
			{
				if (metadata != null)
				{
					metadata[pos] = this.outType;
				}
				pos++;
				if ((this.outType & 128) != 0)
				{
					Statics.EncodeTags((int)this.tags, ref pos, metadata);
				}
			}
			if ((this.inType & 32) != 0)
			{
				if (metadata != null)
				{
					metadata[pos] = (byte)this.fixedCount;
					metadata[pos + 1] = (byte)(this.fixedCount >> 8);
				}
				pos += 2;
				if (96 == (this.inType & 96) && this.fixedCount != 0)
				{
					if (metadata != null)
					{
						Buffer.BlockCopy(this.custom, 0, metadata, pos, (int)this.fixedCount);
					}
					pos += (int)this.fixedCount;
				}
			}
		}

		// Token: 0x040020FC RID: 8444
		private readonly string name;

		// Token: 0x040020FD RID: 8445
		private readonly int nameSize;

		// Token: 0x040020FE RID: 8446
		private readonly EventFieldTags tags;

		// Token: 0x040020FF RID: 8447
		private readonly byte[] custom;

		// Token: 0x04002100 RID: 8448
		private readonly ushort fixedCount;

		// Token: 0x04002101 RID: 8449
		private byte inType;

		// Token: 0x04002102 RID: 8450
		private byte outType;
	}
}
