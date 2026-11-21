using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD1 RID: 3281
	[NetMessage(EMessageId.PhantomItemResponse)]
	public sealed class PhantomItemResponse : IMessage<PhantomItemResponse>, IMessage, IEquatable<PhantomItemResponse>, IDeepCloneable<PhantomItemResponse>, IBufferMessage
	{
		// Token: 0x06011C70 RID: 72816 RVA: 0x0029A57E File Offset: 0x0029877E
		[NullableContext(1)]
		public static PhantomItemResponse Create()
		{
			return new PhantomItemResponse();
		}

		// Token: 0x17003AE8 RID: 15080
		// (get) Token: 0x06011C71 RID: 72817 RVA: 0x0029A585 File Offset: 0x00298785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AE9 RID: 15081
		// (get) Token: 0x06011C72 RID: 72818 RVA: 0x0029A588 File Offset: 0x00298788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomItemResponse.Descriptor;
			}
		}

		// Token: 0x06011C73 RID: 72819 RVA: 0x0029A58F File Offset: 0x0029878F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemResponse()
		{
		}

		// Token: 0x06011C74 RID: 72820 RVA: 0x0029A5C4 File Offset: 0x002987C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemResponse(PhantomItemResponse other) : this()
		{
			this.phantomItemList_ = other.phantomItemList_.Clone();
			this.equipInfo_ = other.equipInfo_.Clone();
			this.propInfo_ = other.propInfo_.Clone();
			this.totalCost_ = other.totalCost_;
			this.unlockSkins_ = other.unlockSkins_.Clone();
			this.directRefineWeekTimes_ = other.directRefineWeekTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011C75 RID: 72821 RVA: 0x0029A644 File Offset: 0x00298844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemResponse Clone()
		{
			return new PhantomItemResponse(this);
		}

		// Token: 0x17003AEA RID: 15082
		// (get) Token: 0x06011C76 RID: 72822 RVA: 0x0029A64C File Offset: 0x0029884C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomItem> PhantomItemList
		{
			get
			{
				return this.phantomItemList_;
			}
		}

		// Token: 0x17003AEB RID: 15083
		// (get) Token: 0x06011C77 RID: 72823 RVA: 0x0029A654 File Offset: 0x00298854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RolePhantomEquipInfo> EquipInfo
		{
			get
			{
				return this.equipInfo_;
			}
		}

		// Token: 0x17003AEC RID: 15084
		// (get) Token: 0x06011C78 RID: 72824 RVA: 0x0029A65C File Offset: 0x0029885C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RolePhantomPropInfo> PropInfo
		{
			get
			{
				return this.propInfo_;
			}
		}

		// Token: 0x17003AED RID: 15085
		// (get) Token: 0x06011C79 RID: 72825 RVA: 0x0029A664 File Offset: 0x00298864
		// (set) Token: 0x06011C7A RID: 72826 RVA: 0x0029A66C File Offset: 0x0029886C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalCost
		{
			get
			{
				return this.totalCost_;
			}
			set
			{
				this.totalCost_ = value;
			}
		}

		// Token: 0x17003AEE RID: 15086
		// (get) Token: 0x06011C7B RID: 72827 RVA: 0x0029A675 File Offset: 0x00298875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockSkins
		{
			get
			{
				return this.unlockSkins_;
			}
		}

		// Token: 0x17003AEF RID: 15087
		// (get) Token: 0x06011C7C RID: 72828 RVA: 0x0029A67D File Offset: 0x0029887D
		// (set) Token: 0x06011C7D RID: 72829 RVA: 0x0029A685 File Offset: 0x00298885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DirectRefineWeekTimes
		{
			get
			{
				return this.directRefineWeekTimes_;
			}
			set
			{
				this.directRefineWeekTimes_ = value;
			}
		}

		// Token: 0x06011C7E RID: 72830 RVA: 0x0029A68E File Offset: 0x0029888E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomItemResponse);
		}

		// Token: 0x06011C7F RID: 72831 RVA: 0x0029A69C File Offset: 0x0029889C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomItemResponse other)
		{
			return other != null && (other == this || (this.phantomItemList_.Equals(other.phantomItemList_) && this.equipInfo_.Equals(other.equipInfo_) && this.propInfo_.Equals(other.propInfo_) && this.TotalCost == other.TotalCost && this.unlockSkins_.Equals(other.unlockSkins_) && this.DirectRefineWeekTimes == other.DirectRefineWeekTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011C80 RID: 72832 RVA: 0x0029A73C File Offset: 0x0029893C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomItemList_.GetHashCode();
			num ^= this.equipInfo_.GetHashCode();
			num ^= this.propInfo_.GetHashCode();
			if (this.TotalCost != 0)
			{
				num ^= this.TotalCost.GetHashCode();
			}
			num ^= this.unlockSkins_.GetHashCode();
			if (this.DirectRefineWeekTimes != 0)
			{
				num ^= this.DirectRefineWeekTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011C81 RID: 72833 RVA: 0x0029A7CC File Offset: 0x002989CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011C82 RID: 72834 RVA: 0x0029A7D9 File Offset: 0x002989D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011C83 RID: 72835 RVA: 0x0029A7E4 File Offset: 0x002989E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalCost != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TotalCost);
			}
			this.propInfo_.WriteTo(ref output, PhantomItemResponse._repeated_propInfo_codec);
			if (this.DirectRefineWeekTimes != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.DirectRefineWeekTimes);
			}
			this.unlockSkins_.WriteTo(ref output, PhantomItemResponse._repeated_unlockSkins_codec);
			this.phantomItemList_.WriteTo(ref output, PhantomItemResponse._repeated_phantomItemList_codec);
			this.equipInfo_.WriteTo(ref output, PhantomItemResponse._repeated_equipInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011C84 RID: 72836 RVA: 0x0029A884 File Offset: 0x00298A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomItemList_.CalculateSize(PhantomItemResponse._repeated_phantomItemList_codec);
			num += this.equipInfo_.CalculateSize(PhantomItemResponse._repeated_equipInfo_codec);
			num += this.propInfo_.CalculateSize(PhantomItemResponse._repeated_propInfo_codec);
			if (this.TotalCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalCost);
			}
			num += this.unlockSkins_.CalculateSize(PhantomItemResponse._repeated_unlockSkins_codec);
			if (this.DirectRefineWeekTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DirectRefineWeekTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011C85 RID: 72837 RVA: 0x0029A928 File Offset: 0x00298B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomItemList_.Add(other.phantomItemList_);
			this.equipInfo_.Add(other.equipInfo_);
			this.propInfo_.Add(other.propInfo_);
			if (other.TotalCost != 0)
			{
				this.TotalCost = other.TotalCost;
			}
			this.unlockSkins_.Add(other.unlockSkins_);
			if (other.DirectRefineWeekTimes != 0)
			{
				this.DirectRefineWeekTimes = other.DirectRefineWeekTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011C86 RID: 72838 RVA: 0x0029A9BC File Offset: 0x00298BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011C87 RID: 72839 RVA: 0x0029A9C8 File Offset: 0x00298BC8
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
					if (num == 16U)
					{
						this.TotalCost = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.propInfo_.AddEntriesFrom(ref input, PhantomItemResponse._repeated_propInfo_codec);
						continue;
					}
					if (num == 40U)
					{
						this.DirectRefineWeekTimes = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 50U)
				{
					if (num == 48U || num == 50U)
					{
						this.unlockSkins_.AddEntriesFrom(ref input, PhantomItemResponse._repeated_unlockSkins_codec);
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.phantomItemList_.AddEntriesFrom(ref input, PhantomItemResponse._repeated_phantomItemList_codec);
						continue;
					}
					if (num == 122U)
					{
						this.equipInfo_.AddEntriesFrom(ref input, PhantomItemResponse._repeated_equipInfo_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007017 RID: 28695
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007018 RID: 28696
		public const int PhantomItemListFieldNumber = 9;

		// Token: 0x04007019 RID: 28697
		private static readonly FieldCodec<PhantomItem> _repeated_phantomItemList_codec = FieldCodec.ForMessage<PhantomItem>(74U, PhantomItem.Parser);

		// Token: 0x0400701A RID: 28698
		private readonly RepeatedField<PhantomItem> phantomItemList_ = new RepeatedField<PhantomItem>();

		// Token: 0x0400701B RID: 28699
		public const int EquipInfoFieldNumber = 15;

		// Token: 0x0400701C RID: 28700
		private static readonly FieldCodec<RolePhantomEquipInfo> _repeated_equipInfo_codec = FieldCodec.ForMessage<RolePhantomEquipInfo>(122U, RolePhantomEquipInfo.Parser);

		// Token: 0x0400701D RID: 28701
		private readonly RepeatedField<RolePhantomEquipInfo> equipInfo_ = new RepeatedField<RolePhantomEquipInfo>();

		// Token: 0x0400701E RID: 28702
		public const int PropInfoFieldNumber = 4;

		// Token: 0x0400701F RID: 28703
		private static readonly FieldCodec<RolePhantomPropInfo> _repeated_propInfo_codec = FieldCodec.ForMessage<RolePhantomPropInfo>(34U, RolePhantomPropInfo.Parser);

		// Token: 0x04007020 RID: 28704
		private readonly RepeatedField<RolePhantomPropInfo> propInfo_ = new RepeatedField<RolePhantomPropInfo>();

		// Token: 0x04007021 RID: 28705
		public const int TotalCostFieldNumber = 2;

		// Token: 0x04007022 RID: 28706
		private int totalCost_;

		// Token: 0x04007023 RID: 28707
		public const int UnlockSkinsFieldNumber = 6;

		// Token: 0x04007024 RID: 28708
		private static readonly FieldCodec<int> _repeated_unlockSkins_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007025 RID: 28709
		private readonly RepeatedField<int> unlockSkins_ = new RepeatedField<int>();

		// Token: 0x04007026 RID: 28710
		public const int DirectRefineWeekTimesFieldNumber = 5;

		// Token: 0x04007027 RID: 28711
		private int directRefineWeekTimes_;
	}
}
