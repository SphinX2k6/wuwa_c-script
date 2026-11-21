using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200084A RID: 2122
	[NetMessage(EMessageId.ItemRewardNotify)]
	public sealed class ItemRewardNotify : IMessage<ItemRewardNotify>, IMessage, IEquatable<ItemRewardNotify>, IDeepCloneable<ItemRewardNotify>, IBufferMessage
	{
		// Token: 0x0600BD95 RID: 48533 RVA: 0x001C2E87 File Offset: 0x001C1087
		[NullableContext(1)]
		public static ItemRewardNotify Create()
		{
			return new ItemRewardNotify();
		}

		// Token: 0x17002644 RID: 9796
		// (get) Token: 0x0600BD96 RID: 48534 RVA: 0x001C2E8E File Offset: 0x001C108E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002645 RID: 9797
		// (get) Token: 0x0600BD97 RID: 48535 RVA: 0x001C2E91 File Offset: 0x001C1091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemRewardNotify.Descriptor;
			}
		}

		// Token: 0x0600BD98 RID: 48536 RVA: 0x001C2E98 File Offset: 0x001C1098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemRewardNotify()
		{
		}

		// Token: 0x0600BD99 RID: 48537 RVA: 0x001C2EAC File Offset: 0x001C10AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemRewardNotify(ItemRewardNotify other) : this()
		{
			this.dropId_ = other.dropId_;
			this.reason_ = other.reason_;
			this.magnification_ = other.magnification_;
			this.from_ = other.from_;
			this.rewardItems_ = other.rewardItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD9A RID: 48538 RVA: 0x001C2F11 File Offset: 0x001C1111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemRewardNotify Clone()
		{
			return new ItemRewardNotify(this);
		}

		// Token: 0x17002646 RID: 9798
		// (get) Token: 0x0600BD9B RID: 48539 RVA: 0x001C2F19 File Offset: 0x001C1119
		// (set) Token: 0x0600BD9C RID: 48540 RVA: 0x001C2F21 File Offset: 0x001C1121
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

		// Token: 0x17002647 RID: 9799
		// (get) Token: 0x0600BD9D RID: 48541 RVA: 0x001C2F2A File Offset: 0x001C112A
		// (set) Token: 0x0600BD9E RID: 48542 RVA: 0x001C2F32 File Offset: 0x001C1132
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

		// Token: 0x17002648 RID: 9800
		// (get) Token: 0x0600BD9F RID: 48543 RVA: 0x001C2F3B File Offset: 0x001C113B
		// (set) Token: 0x0600BDA0 RID: 48544 RVA: 0x001C2F43 File Offset: 0x001C1143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Magnification
		{
			get
			{
				return this.magnification_;
			}
			set
			{
				this.magnification_ = value;
			}
		}

		// Token: 0x17002649 RID: 9801
		// (get) Token: 0x0600BDA1 RID: 48545 RVA: 0x001C2F4C File Offset: 0x001C114C
		// (set) Token: 0x0600BDA2 RID: 48546 RVA: 0x001C2F54 File Offset: 0x001C1154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoubleDropFrom From
		{
			get
			{
				return this.from_;
			}
			set
			{
				this.from_ = value;
			}
		}

		// Token: 0x1700264A RID: 9802
		// (get) Token: 0x0600BDA3 RID: 48547 RVA: 0x001C2F5D File Offset: 0x001C115D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, RewardItemInfoList> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x0600BDA4 RID: 48548 RVA: 0x001C2F65 File Offset: 0x001C1165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemRewardNotify);
		}

		// Token: 0x0600BDA5 RID: 48549 RVA: 0x001C2F74 File Offset: 0x001C1174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemRewardNotify other)
		{
			return other != null && (other == this || (this.DropId == other.DropId && this.Reason == other.Reason && this.Magnification == other.Magnification && this.From == other.From && this.RewardItems.Equals(other.RewardItems) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BDA6 RID: 48550 RVA: 0x001C2FF4 File Offset: 0x001C11F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DropId != 0)
			{
				num ^= this.DropId.GetHashCode();
			}
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.Magnification != 0)
			{
				num ^= this.Magnification.GetHashCode();
			}
			if (this.From != DoubleDropFrom.UnDefineDouble)
			{
				num ^= this.From.GetHashCode();
			}
			num ^= this.RewardItems.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BDA7 RID: 48551 RVA: 0x001C3092 File Offset: 0x001C1292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BDA8 RID: 48552 RVA: 0x001C309F File Offset: 0x001C129F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BDA9 RID: 48553 RVA: 0x001C30A8 File Offset: 0x001C12A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DropId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DropId);
			}
			if (this.Magnification != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Magnification);
			}
			this.rewardItems_.WriteTo(ref output, ItemRewardNotify._map_rewardItems_codec);
			if (this.From != DoubleDropFrom.UnDefineDouble)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.From);
			}
			if (this.Reason != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BDAA RID: 48554 RVA: 0x001C314C File Offset: 0x001C134C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DropId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DropId);
			}
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			if (this.Magnification != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Magnification);
			}
			if (this.From != DoubleDropFrom.UnDefineDouble)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.From);
			}
			num += this.rewardItems_.CalculateSize(ItemRewardNotify._map_rewardItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BDAB RID: 48555 RVA: 0x001C31E8 File Offset: 0x001C13E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemRewardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DropId != 0)
			{
				this.DropId = other.DropId;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			if (other.Magnification != 0)
			{
				this.Magnification = other.Magnification;
			}
			if (other.From != DoubleDropFrom.UnDefineDouble)
			{
				this.From = other.From;
			}
			this.rewardItems_.MergeFrom(other.rewardItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BDAC RID: 48556 RVA: 0x001C3271 File Offset: 0x001C1471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BDAD RID: 48557 RVA: 0x001C327C File Offset: 0x001C147C
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
				if (num <= 32U)
				{
					if (num == 16U)
					{
						this.DropId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Magnification = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						this.rewardItems_.AddEntriesFrom(ref input, ItemRewardNotify._map_rewardItems_codec);
						continue;
					}
					if (num == 72U)
					{
						this.From = (DoubleDropFrom)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.Reason = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400532A RID: 21290
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400532B RID: 21291
		public const int DropIdFieldNumber = 2;

		// Token: 0x0400532C RID: 21292
		private int dropId_;

		// Token: 0x0400532D RID: 21293
		public const int ReasonFieldNumber = 14;

		// Token: 0x0400532E RID: 21294
		private int reason_;

		// Token: 0x0400532F RID: 21295
		public const int MagnificationFieldNumber = 4;

		// Token: 0x04005330 RID: 21296
		private int magnification_;

		// Token: 0x04005331 RID: 21297
		public const int FromFieldNumber = 9;

		// Token: 0x04005332 RID: 21298
		private DoubleDropFrom from_;

		// Token: 0x04005333 RID: 21299
		public const int RewardItemsFieldNumber = 7;

		// Token: 0x04005334 RID: 21300
		private static readonly MapField<int, RewardItemInfoList>.Codec _map_rewardItems_codec = new MapField<int, RewardItemInfoList>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<RewardItemInfoList>(18U, RewardItemInfoList.Parser), 58U);

		// Token: 0x04005335 RID: 21301
		private readonly MapField<int, RewardItemInfoList> rewardItems_ = new MapField<int, RewardItemInfoList>();
	}
}
