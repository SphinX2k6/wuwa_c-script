using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200063F RID: 1599
	public sealed class FRActionStageTributeChange : IMessage<FRActionStageTributeChange>, IMessage, IEquatable<FRActionStageTributeChange>, IDeepCloneable<FRActionStageTributeChange>, IBufferMessage
	{
		// Token: 0x0600934F RID: 37711 RVA: 0x00164730 File Offset: 0x00162930
		[NullableContext(1)]
		public static FRActionStageTributeChange Create()
		{
			return new FRActionStageTributeChange();
		}

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x06009350 RID: 37712 RVA: 0x00164737 File Offset: 0x00162937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x06009351 RID: 37713 RVA: 0x0016473A File Offset: 0x0016293A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRActionStageTributeChange.Descriptor;
			}
		}

		// Token: 0x06009352 RID: 37714 RVA: 0x00164741 File Offset: 0x00162941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionStageTributeChange()
		{
		}

		// Token: 0x06009353 RID: 37715 RVA: 0x00164749 File Offset: 0x00162949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionStageTributeChange(FRActionStageTributeChange other) : this()
		{
			this.tributeCount_ = other.tributeCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009354 RID: 37716 RVA: 0x0016476E File Offset: 0x0016296E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionStageTributeChange Clone()
		{
			return new FRActionStageTributeChange(this);
		}

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x06009355 RID: 37717 RVA: 0x00164776 File Offset: 0x00162976
		// (set) Token: 0x06009356 RID: 37718 RVA: 0x0016477E File Offset: 0x0016297E
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

		// Token: 0x06009357 RID: 37719 RVA: 0x00164787 File Offset: 0x00162987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRActionStageTributeChange);
		}

		// Token: 0x06009358 RID: 37720 RVA: 0x00164795 File Offset: 0x00162995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRActionStageTributeChange other)
		{
			return other != null && (other == this || (this.TributeCount == other.TributeCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009359 RID: 37721 RVA: 0x001647C4 File Offset: 0x001629C4
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

		// Token: 0x0600935A RID: 37722 RVA: 0x00164803 File Offset: 0x00162A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600935B RID: 37723 RVA: 0x00164810 File Offset: 0x00162A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600935C RID: 37724 RVA: 0x00164819 File Offset: 0x00162A19
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

		// Token: 0x0600935D RID: 37725 RVA: 0x0016484C File Offset: 0x00162A4C
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

		// Token: 0x0600935E RID: 37726 RVA: 0x0016488A File Offset: 0x00162A8A
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

		// Token: 0x0600935F RID: 37727 RVA: 0x001648BB File Offset: 0x00162ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009360 RID: 37728 RVA: 0x001648C4 File Offset: 0x00162AC4
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

		// Token: 0x040046E1 RID: 18145
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046E2 RID: 18146
		public const int TributeCountFieldNumber = 1;

		// Token: 0x040046E3 RID: 18147
		private long tributeCount_;
	}
}
