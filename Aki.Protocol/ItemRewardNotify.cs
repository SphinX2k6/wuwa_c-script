using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200085C RID: 2140
	[NetMessage(EMessageId.ItemRewardNotify)]
	public sealed class ItemRewardNotify : IMessage<ItemRewardNotify>, IMessage, IEquatable<ItemRewardNotify>, IDeepCloneable<ItemRewardNotify>, IBufferMessage
	{
		// Token: 0x0600BEC3 RID: 48835 RVA: 0x001C534E File Offset: 0x001C354E
		[NullableContext(1)]
		public static ItemRewardNotify Create()
		{
			return new ItemRewardNotify();
		}

		// Token: 0x17002686 RID: 9862
		// (get) Token: 0x0600BEC4 RID: 48836 RVA: 0x001C5355 File Offset: 0x001C3555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002687 RID: 9863
		// (get) Token: 0x0600BEC5 RID: 48837 RVA: 0x001C5358 File Offset: 0x001C3558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemRewardNotify.Descriptor;
			}
		}

		// Token: 0x0600BEC6 RID: 48838 RVA: 0x001C535F File Offset: 0x001C355F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemRewardNotify()
		{
		}

		// Token: 0x0600BEC7 RID: 48839 RVA: 0x001C5374 File Offset: 0x001C3574
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

		// Token: 0x0600BEC8 RID: 48840 RVA: 0x001C53D9 File Offset: 0x001C35D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemRewardNotify Clone()
		{
			return new ItemRewardNotify(this);
		}

		// Token: 0x17002688 RID: 9864
		// (get) Token: 0x0600BEC9 RID: 48841 RVA: 0x001C53E1 File Offset: 0x001C35E1
		// (set) Token: 0x0600BECA RID: 48842 RVA: 0x001C53E9 File Offset: 0x001C35E9
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

		// Token: 0x17002689 RID: 9865
		// (get) Token: 0x0600BECB RID: 48843 RVA: 0x001C53F2 File Offset: 0x001C35F2
		// (set) Token: 0x0600BECC RID: 48844 RVA: 0x001C53FA File Offset: 0x001C35FA
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

		// Token: 0x1700268A RID: 9866
		// (get) Token: 0x0600BECD RID: 48845 RVA: 0x001C5403 File Offset: 0x001C3603
		// (set) Token: 0x0600BECE RID: 48846 RVA: 0x001C540B File Offset: 0x001C360B
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

		// Token: 0x1700268B RID: 9867
		// (get) Token: 0x0600BECF RID: 48847 RVA: 0x001C5414 File Offset: 0x001C3614
		// (set) Token: 0x0600BED0 RID: 48848 RVA: 0x001C541C File Offset: 0x001C361C
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

		// Token: 0x1700268C RID: 9868
		// (get) Token: 0x0600BED1 RID: 48849 RVA: 0x001C5425 File Offset: 0x001C3625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, RewardItemInfoList> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x0600BED2 RID: 48850 RVA: 0x001C542D File Offset: 0x001C362D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemRewardNotify);
		}

		// Token: 0x0600BED3 RID: 48851 RVA: 0x001C543C File Offset: 0x001C363C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemRewardNotify other)
		{
			return other != null && (other == this || (this.DropId == other.DropId && this.Reason == other.Reason && this.Magnification == other.Magnification && this.From == other.From && this.RewardItems.Equals(other.RewardItems) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BED4 RID: 48852 RVA: 0x001C54BC File Offset: 0x001C36BC
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

		// Token: 0x0600BED5 RID: 48853 RVA: 0x001C555A File Offset: 0x001C375A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BED6 RID: 48854 RVA: 0x001C5567 File Offset: 0x001C3767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BED7 RID: 48855 RVA: 0x001C5570 File Offset: 0x001C3770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Magnification != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Magnification);
			}
			this.rewardItems_.WriteTo(ref output, ItemRewardNotify._map_rewardItems_codec);
			if (this.Reason != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Reason);
			}
			if (this.From != DoubleDropFrom.UnDefineDouble)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.From);
			}
			if (this.DropId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.DropId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BED8 RID: 48856 RVA: 0x001C5614 File Offset: 0x001C3814
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

		// Token: 0x0600BED9 RID: 48857 RVA: 0x001C56B0 File Offset: 0x001C38B0
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

		// Token: 0x0600BEDA RID: 48858 RVA: 0x001C5739 File Offset: 0x001C3939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BEDB RID: 48859 RVA: 0x001C5744 File Offset: 0x001C3944
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
				if (num <= 74U)
				{
					if (num == 40U)
					{
						this.Magnification = input.ReadInt32();
						continue;
					}
					if (num == 74U)
					{
						this.rewardItems_.AddEntriesFrom(ref input, ItemRewardNotify._map_rewardItems_codec);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Reason = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.From = (DoubleDropFrom)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.DropId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005327 RID: 21287
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005328 RID: 21288
		public const int DropIdFieldNumber = 14;

		// Token: 0x04005329 RID: 21289
		private int dropId_;

		// Token: 0x0400532A RID: 21290
		public const int ReasonFieldNumber = 11;

		// Token: 0x0400532B RID: 21291
		private int reason_;

		// Token: 0x0400532C RID: 21292
		public const int MagnificationFieldNumber = 5;

		// Token: 0x0400532D RID: 21293
		private int magnification_;

		// Token: 0x0400532E RID: 21294
		public const int FromFieldNumber = 12;

		// Token: 0x0400532F RID: 21295
		private DoubleDropFrom from_;

		// Token: 0x04005330 RID: 21296
		public const int RewardItemsFieldNumber = 9;

		// Token: 0x04005331 RID: 21297
		private static readonly MapField<int, RewardItemInfoList>.Codec _map_rewardItems_codec = new MapField<int, RewardItemInfoList>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<RewardItemInfoList>(18U, RewardItemInfoList.Parser), 74U);

		// Token: 0x04005332 RID: 21298
		private readonly MapField<int, RewardItemInfoList> rewardItems_ = new MapField<int, RewardItemInfoList>();
	}
}
