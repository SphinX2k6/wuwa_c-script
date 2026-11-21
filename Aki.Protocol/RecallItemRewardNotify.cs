using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E9F RID: 3743
	[NetMessage(EMessageId.RecallItemRewardNotify)]
	public sealed class RecallItemRewardNotify : IMessage<RecallItemRewardNotify>, IMessage, IEquatable<RecallItemRewardNotify>, IDeepCloneable<RecallItemRewardNotify>, IBufferMessage
	{
		// Token: 0x060141DA RID: 82394 RVA: 0x002EDEF8 File Offset: 0x002EC0F8
		[NullableContext(1)]
		public static RecallItemRewardNotify Create()
		{
			return new RecallItemRewardNotify();
		}

		// Token: 0x170042EE RID: 17134
		// (get) Token: 0x060141DB RID: 82395 RVA: 0x002EDEFF File Offset: 0x002EC0FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042EF RID: 17135
		// (get) Token: 0x060141DC RID: 82396 RVA: 0x002EDF02 File Offset: 0x002EC102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallItemRewardNotify.Descriptor;
			}
		}

		// Token: 0x060141DD RID: 82397 RVA: 0x002EDF09 File Offset: 0x002EC109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemRewardNotify()
		{
		}

		// Token: 0x060141DE RID: 82398 RVA: 0x002EDF1C File Offset: 0x002EC11C
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

		// Token: 0x060141DF RID: 82399 RVA: 0x002EDF75 File Offset: 0x002EC175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemRewardNotify Clone()
		{
			return new RecallItemRewardNotify(this);
		}

		// Token: 0x170042F0 RID: 17136
		// (get) Token: 0x060141E0 RID: 82400 RVA: 0x002EDF7D File Offset: 0x002EC17D
		// (set) Token: 0x060141E1 RID: 82401 RVA: 0x002EDF85 File Offset: 0x002EC185
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

		// Token: 0x170042F1 RID: 17137
		// (get) Token: 0x060141E2 RID: 82402 RVA: 0x002EDF8E File Offset: 0x002EC18E
		// (set) Token: 0x060141E3 RID: 82403 RVA: 0x002EDF96 File Offset: 0x002EC196
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

		// Token: 0x170042F2 RID: 17138
		// (get) Token: 0x060141E4 RID: 82404 RVA: 0x002EDF9F File Offset: 0x002EC19F
		// (set) Token: 0x060141E5 RID: 82405 RVA: 0x002EDFA7 File Offset: 0x002EC1A7
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

		// Token: 0x170042F3 RID: 17139
		// (get) Token: 0x060141E6 RID: 82406 RVA: 0x002EDFB0 File Offset: 0x002EC1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RewardItemInfo> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x060141E7 RID: 82407 RVA: 0x002EDFB8 File Offset: 0x002EC1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallItemRewardNotify);
		}

		// Token: 0x060141E8 RID: 82408 RVA: 0x002EDFC8 File Offset: 0x002EC1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallItemRewardNotify other)
		{
			return other != null && (other == this || (this.RecallId == other.RecallId && this.DropId == other.DropId && this.Reason == other.Reason && this.rewardItems_.Equals(other.rewardItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060141E9 RID: 82409 RVA: 0x002EE038 File Offset: 0x002EC238
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

		// Token: 0x060141EA RID: 82410 RVA: 0x002EE0B7 File Offset: 0x002EC2B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060141EB RID: 82411 RVA: 0x002EE0C4 File Offset: 0x002EC2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060141EC RID: 82412 RVA: 0x002EE0D0 File Offset: 0x002EC2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RecallId);
			}
			if (this.Reason != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Reason);
			}
			if (this.DropId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.DropId);
			}
			this.rewardItems_.WriteTo(ref output, RecallItemRewardNotify._repeated_rewardItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060141ED RID: 82413 RVA: 0x002EE158 File Offset: 0x002EC358
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

		// Token: 0x060141EE RID: 82414 RVA: 0x002EE1DC File Offset: 0x002EC3DC
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

		// Token: 0x060141EF RID: 82415 RVA: 0x002EE251 File Offset: 0x002EC451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060141F0 RID: 82416 RVA: 0x002EE25C File Offset: 0x002EC45C
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
				if (num <= 40U)
				{
					if (num == 24U)
					{
						this.RecallId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Reason = input.ReadInt32();
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
					if (num == 106U)
					{
						this.rewardItems_.AddEntriesFrom(ref input, RecallItemRewardNotify._repeated_rewardItems_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007B02 RID: 31490
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B03 RID: 31491
		public const int RecallIdFieldNumber = 3;

		// Token: 0x04007B04 RID: 31492
		private int recallId_;

		// Token: 0x04007B05 RID: 31493
		public const int DropIdFieldNumber = 7;

		// Token: 0x04007B06 RID: 31494
		private int dropId_;

		// Token: 0x04007B07 RID: 31495
		public const int ReasonFieldNumber = 5;

		// Token: 0x04007B08 RID: 31496
		private int reason_;

		// Token: 0x04007B09 RID: 31497
		public const int RewardItemsFieldNumber = 13;

		// Token: 0x04007B0A RID: 31498
		private static readonly FieldCodec<RewardItemInfo> _repeated_rewardItems_codec = FieldCodec.ForMessage<RewardItemInfo>(106U, RewardItemInfo.Parser);

		// Token: 0x04007B0B RID: 31499
		private readonly RepeatedField<RewardItemInfo> rewardItems_ = new RepeatedField<RewardItemInfo>();
	}
}
