using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EAF RID: 3759
	[NetMessage(EMessageId.RecallItemRewardNotify)]
	public sealed class RecallItemRewardNotify : IMessage<RecallItemRewardNotify>, IMessage, IEquatable<RecallItemRewardNotify>, IDeepCloneable<RecallItemRewardNotify>, IBufferMessage
	{
		// Token: 0x060142BF RID: 82623 RVA: 0x002EF5A4 File Offset: 0x002ED7A4
		[NullableContext(1)]
		public static RecallItemRewardNotify Create()
		{
			return new RecallItemRewardNotify();
		}

		// Token: 0x17004318 RID: 17176
		// (get) Token: 0x060142C0 RID: 82624 RVA: 0x002EF5AB File Offset: 0x002ED7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004319 RID: 17177
		// (get) Token: 0x060142C1 RID: 82625 RVA: 0x002EF5AE File Offset: 0x002ED7AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallItemRewardNotify.Descriptor;
			}
		}

		// Token: 0x060142C2 RID: 82626 RVA: 0x002EF5B5 File Offset: 0x002ED7B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemRewardNotify()
		{
		}

		// Token: 0x060142C3 RID: 82627 RVA: 0x002EF5C8 File Offset: 0x002ED7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemRewardNotify(RecallItemRewardNotify other) : this()
		{
			this.recallId_ = other.recallId_;
			this.dropId_ = other.dropId_;
			this.reason_ = other.reason_;
			this.rewardItems_ = other.rewardItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060142C4 RID: 82628 RVA: 0x002EF621 File Offset: 0x002ED821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemRewardNotify Clone()
		{
			return new RecallItemRewardNotify(this);
		}

		// Token: 0x1700431A RID: 17178
		// (get) Token: 0x060142C5 RID: 82629 RVA: 0x002EF629 File Offset: 0x002ED829
		// (set) Token: 0x060142C6 RID: 82630 RVA: 0x002EF631 File Offset: 0x002ED831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallId
		{
			get
			{
				return this.recallId_;
			}
			set
			{
				this.recallId_ = value;
			}
		}

		// Token: 0x1700431B RID: 17179
		// (get) Token: 0x060142C7 RID: 82631 RVA: 0x002EF63A File Offset: 0x002ED83A
		// (set) Token: 0x060142C8 RID: 82632 RVA: 0x002EF642 File Offset: 0x002ED842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DropId
		{
			get
			{
				return this.dropId_;
			}
			set
			{
				this.dropId_ = value;
			}
		}

		// Token: 0x1700431C RID: 17180
		// (get) Token: 0x060142C9 RID: 82633 RVA: 0x002EF64B File Offset: 0x002ED84B
		// (set) Token: 0x060142CA RID: 82634 RVA: 0x002EF653 File Offset: 0x002ED853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x1700431D RID: 17181
		// (get) Token: 0x060142CB RID: 82635 RVA: 0x002EF65C File Offset: 0x002ED85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RewardItemInfo> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x060142CC RID: 82636 RVA: 0x002EF664 File Offset: 0x002ED864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallItemRewardNotify);
		}

		// Token: 0x060142CD RID: 82637 RVA: 0x002EF674 File Offset: 0x002ED874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallItemRewardNotify other)
		{
			return other != null && (other == this || (this.RecallId == other.RecallId && this.DropId == other.DropId && this.Reason == other.Reason && this.rewardItems_.Equals(other.rewardItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060142CE RID: 82638 RVA: 0x002EF6E4 File Offset: 0x002ED8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallId != 0)
			{
				num ^= this.RecallId.GetHashCode();
			}
			if (this.DropId != 0)
			{
				num ^= this.DropId.GetHashCode();
			}
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			num ^= this.rewardItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060142CF RID: 82639 RVA: 0x002EF763 File Offset: 0x002ED963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060142D0 RID: 82640 RVA: 0x002EF770 File Offset: 0x002ED970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060142D1 RID: 82641 RVA: 0x002EF77C File Offset: 0x002ED97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardItems_.WriteTo(ref output, RecallItemRewardNotify._repeated_rewardItems_codec);
			if (this.RecallId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RecallId);
			}
			if (this.DropId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.DropId);
			}
			if (this.Reason != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060142D2 RID: 82642 RVA: 0x002EF804 File Offset: 0x002EDA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallId);
			}
			if (this.DropId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DropId);
			}
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			num += this.rewardItems_.CalculateSize(RecallItemRewardNotify._repeated_rewardItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060142D3 RID: 82643 RVA: 0x002EF888 File Offset: 0x002EDA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallItemRewardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallId != 0)
			{
				this.RecallId = other.RecallId;
			}
			if (other.DropId != 0)
			{
				this.DropId = other.DropId;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			this.rewardItems_.Add(other.rewardItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060142D4 RID: 82644 RVA: 0x002EF8FD File Offset: 0x002EDAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060142D5 RID: 82645 RVA: 0x002EF908 File Offset: 0x002EDB08
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
				if (num <= 24U)
				{
					if (num == 10U)
					{
						this.rewardItems_.AddEntriesFrom(ref input, RecallItemRewardNotify._repeated_rewardItems_codec);
						continue;
					}
					if (num == 24U)
					{
						this.RecallId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.DropId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.Reason = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007AD8 RID: 31448
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AD9 RID: 31449
		public const int RecallIdFieldNumber = 3;

		// Token: 0x04007ADA RID: 31450
		private int recallId_;

		// Token: 0x04007ADB RID: 31451
		public const int DropIdFieldNumber = 7;

		// Token: 0x04007ADC RID: 31452
		private int dropId_;

		// Token: 0x04007ADD RID: 31453
		public const int ReasonFieldNumber = 13;

		// Token: 0x04007ADE RID: 31454
		private int reason_;

		// Token: 0x04007ADF RID: 31455
		public const int RewardItemsFieldNumber = 1;

		// Token: 0x04007AE0 RID: 31456
		private static readonly FieldCodec<RewardItemInfo> _repeated_rewardItems_codec = FieldCodec.ForMessage<RewardItemInfo>(10U, RewardItemInfo.Parser);

		// Token: 0x04007AE1 RID: 31457
		private readonly RepeatedField<RewardItemInfo> rewardItems_ = new RepeatedField<RewardItemInfo>();
	}
}
