using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A0 RID: 4512
	[NetMessage(EMessageId.ScratchCardRewardRequest)]
	public sealed class ScratchCardRewardRequest : IMessage<ScratchCardRewardRequest>, IMessage, IEquatable<ScratchCardRewardRequest>, IDeepCloneable<ScratchCardRewardRequest>, IBufferMessage
	{
		// Token: 0x060180A6 RID: 98470 RVA: 0x0037D893 File Offset: 0x0037BA93
		[NullableContext(1)]
		public static ScratchCardRewardRequest Create()
		{
			return new ScratchCardRewardRequest();
		}

		// Token: 0x170050C7 RID: 20679
		// (get) Token: 0x060180A7 RID: 98471 RVA: 0x0037D89A File Offset: 0x0037BA9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050C8 RID: 20680
		// (get) Token: 0x060180A8 RID: 98472 RVA: 0x0037D89D File Offset: 0x0037BA9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScratchCardRewardRequest.Descriptor;
			}
		}

		// Token: 0x060180A9 RID: 98473 RVA: 0x0037D8A4 File Offset: 0x0037BAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRewardRequest()
		{
		}

		// Token: 0x060180AA RID: 98474 RVA: 0x0037D8AC File Offset: 0x0037BAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRewardRequest(ScratchCardRewardRequest other) : this()
		{
			this.roundId_ = other.roundId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060180AB RID: 98475 RVA: 0x0037D8DD File Offset: 0x0037BADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRewardRequest Clone()
		{
			return new ScratchCardRewardRequest(this);
		}

		// Token: 0x170050C9 RID: 20681
		// (get) Token: 0x060180AC RID: 98476 RVA: 0x0037D8E5 File Offset: 0x0037BAE5
		// (set) Token: 0x060180AD RID: 98477 RVA: 0x0037D8ED File Offset: 0x0037BAED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundId
		{
			get
			{
				return this.roundId_;
			}
			set
			{
				this.roundId_ = value;
			}
		}

		// Token: 0x170050CA RID: 20682
		// (get) Token: 0x060180AE RID: 98478 RVA: 0x0037D8F6 File Offset: 0x0037BAF6
		// (set) Token: 0x060180AF RID: 98479 RVA: 0x0037D8FE File Offset: 0x0037BAFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x060180B0 RID: 98480 RVA: 0x0037D907 File Offset: 0x0037BB07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScratchCardRewardRequest);
		}

		// Token: 0x060180B1 RID: 98481 RVA: 0x0037D915 File Offset: 0x0037BB15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScratchCardRewardRequest other)
		{
			return other != null && (other == this || (this.RoundId == other.RoundId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060180B2 RID: 98482 RVA: 0x0037D954 File Offset: 0x0037BB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoundId != 0)
			{
				num ^= this.RoundId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060180B3 RID: 98483 RVA: 0x0037D9AC File Offset: 0x0037BBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060180B4 RID: 98484 RVA: 0x0037D9B9 File Offset: 0x0037BBB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060180B5 RID: 98485 RVA: 0x0037D9C4 File Offset: 0x0037BBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Index);
			}
			if (this.RoundId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RoundId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060180B6 RID: 98486 RVA: 0x0037DA1C File Offset: 0x0037BC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoundId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060180B7 RID: 98487 RVA: 0x0037DA74 File Offset: 0x0037BC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScratchCardRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoundId != 0)
			{
				this.RoundId = other.RoundId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060180B8 RID: 98488 RVA: 0x0037DAC4 File Offset: 0x0037BCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060180B9 RID: 98489 RVA: 0x0037DAD0 File Offset: 0x0037BCD0
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
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoundId = input.ReadInt32();
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E4D RID: 36429
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E4E RID: 36430
		public const int RoundIdFieldNumber = 5;

		// Token: 0x04008E4F RID: 36431
		private int roundId_;

		// Token: 0x04008E50 RID: 36432
		public const int IndexFieldNumber = 1;

		// Token: 0x04008E51 RID: 36433
		private int index_;
	}
}
