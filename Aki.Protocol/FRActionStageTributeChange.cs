using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200062B RID: 1579
	public sealed class FRActionStageTributeChange : IMessage<FRActionStageTributeChange>, IMessage, IEquatable<FRActionStageTributeChange>, IDeepCloneable<FRActionStageTributeChange>, IBufferMessage
	{
		// Token: 0x060091F9 RID: 37369 RVA: 0x00161D04 File Offset: 0x0015FF04
		[NullableContext(1)]
		public static FRActionStageTributeChange Create()
		{
			return new FRActionStageTributeChange();
		}

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x060091FA RID: 37370 RVA: 0x00161D0B File Offset: 0x0015FF0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x060091FB RID: 37371 RVA: 0x00161D0E File Offset: 0x0015FF0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRActionStageTributeChange.Descriptor;
			}
		}

		// Token: 0x060091FC RID: 37372 RVA: 0x00161D15 File Offset: 0x0015FF15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionStageTributeChange()
		{
		}

		// Token: 0x060091FD RID: 37373 RVA: 0x00161D1D File Offset: 0x0015FF1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionStageTributeChange(FRActionStageTributeChange other) : this()
		{
			this.tributeCount_ = other.tributeCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060091FE RID: 37374 RVA: 0x00161D42 File Offset: 0x0015FF42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionStageTributeChange Clone()
		{
			return new FRActionStageTributeChange(this);
		}

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x060091FF RID: 37375 RVA: 0x00161D4A File Offset: 0x0015FF4A
		// (set) Token: 0x06009200 RID: 37376 RVA: 0x00161D52 File Offset: 0x0015FF52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TributeCount
		{
			get
			{
				return this.tributeCount_;
			}
			set
			{
				this.tributeCount_ = value;
			}
		}

		// Token: 0x06009201 RID: 37377 RVA: 0x00161D5B File Offset: 0x0015FF5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRActionStageTributeChange);
		}

		// Token: 0x06009202 RID: 37378 RVA: 0x00161D69 File Offset: 0x0015FF69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRActionStageTributeChange other)
		{
			return other != null && (other == this || (this.TributeCount == other.TributeCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009203 RID: 37379 RVA: 0x00161D98 File Offset: 0x0015FF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TributeCount != 0L)
			{
				num ^= this.TributeCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009204 RID: 37380 RVA: 0x00161DD7 File Offset: 0x0015FFD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009205 RID: 37381 RVA: 0x00161DE4 File Offset: 0x0015FFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009206 RID: 37382 RVA: 0x00161DED File Offset: 0x0015FFED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TributeCount != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TributeCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009207 RID: 37383 RVA: 0x00161E20 File Offset: 0x00160020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TributeCount != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TributeCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009208 RID: 37384 RVA: 0x00161E5E File Offset: 0x0016005E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRActionStageTributeChange other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TributeCount != 0L)
			{
				this.TributeCount = other.TributeCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009209 RID: 37385 RVA: 0x00161E8F File Offset: 0x0016008F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600920A RID: 37386 RVA: 0x00161E98 File Offset: 0x00160098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TributeCount = input.ReadInt64();
				}
			}
		}

		// Token: 0x040046DA RID: 18138
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046DB RID: 18139
		public const int TributeCountFieldNumber = 1;

		// Token: 0x040046DC RID: 18140
		private long tributeCount_;
	}
}
