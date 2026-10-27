using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE1 RID: 3297
	[NetMessage(EMessageId.PhantomItemResponse)]
	public sealed class PhantomItemResponse : IMessage<PhantomItemResponse>, IMessage, IEquatable<PhantomItemResponse>, IDeepCloneable<PhantomItemResponse>, IBufferMessage
	{
		// Token: 0x06011D6C RID: 73068 RVA: 0x0029C19A File Offset: 0x0029A39A
		[NullableContext(1)]
		public static PhantomItemResponse Create()
		{
			return new PhantomItemResponse();
		}

		// Token: 0x17003B1D RID: 15133
		// (get) Token: 0x06011D6D RID: 73069 RVA: 0x0029C1A1 File Offset: 0x0029A3A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B1E RID: 15134
		// (get) Token: 0x06011D6E RID: 73070 RVA: 0x0029C1A4 File Offset: 0x0029A3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomItemResponse.Descriptor;
			}
		}

		// Token: 0x06011D6F RID: 73071 RVA: 0x0029C1AB File Offset: 0x0029A3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemResponse()
		{
		}

		// Token: 0x06011D70 RID: 73072 RVA: 0x0029C1E0 File Offset: 0x0029A3E0
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

		// Token: 0x06011D71 RID: 73073 RVA: 0x0029C260 File Offset: 0x0029A460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemResponse Clone()
		{
			return new PhantomItemResponse(this);
		}

		// Token: 0x17003B1F RID: 15135
		// (get) Token: 0x06011D72 RID: 73074 RVA: 0x0029C268 File Offset: 0x0029A468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomItem> PhantomItemList
		{
			get
			{
				return this.phantomItemList_;
			}
		}

		// Token: 0x17003B20 RID: 15136
		// (get) Token: 0x06011D73 RID: 73075 RVA: 0x0029C270 File Offset: 0x0029A470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RolePhantomEquipInfo> EquipInfo
		{
			get
			{
				return this.equipInfo_;
			}
		}

		// Token: 0x17003B21 RID: 15137
		// (get) Token: 0x06011D74 RID: 73076 RVA: 0x0029C278 File Offset: 0x0029A478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RolePhantomPropInfo> PropInfo
		{
			get
			{
				return this.propInfo_;
			}
		}

		// Token: 0x17003B22 RID: 15138
		// (get) Token: 0x06011D75 RID: 73077 RVA: 0x0029C280 File Offset: 0x0029A480
		// (set) Token: 0x06011D76 RID: 73078 RVA: 0x0029C288 File Offset: 0x0029A488
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

		// Token: 0x17003B23 RID: 15139
		// (get) Token: 0x06011D77 RID: 73079 RVA: 0x0029C291 File Offset: 0x0029A491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockSkins
		{
			get
			{
				return this.unlockSkins_;
			}
		}

		// Token: 0x17003B24 RID: 15140
		// (get) Token: 0x06011D78 RID: 73080 RVA: 0x0029C299 File Offset: 0x0029A499
		// (set) Token: 0x06011D79 RID: 73081 RVA: 0x0029C2A1 File Offset: 0x0029A4A1
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

		// Token: 0x06011D7A RID: 73082 RVA: 0x0029C2AA File Offset: 0x0029A4AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomItemResponse);
		}

		// Token: 0x06011D7B RID: 73083 RVA: 0x0029C2B8 File Offset: 0x0029A4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomItemResponse other)
		{
			return other != null && (other == this || (this.phantomItemList_.Equals(other.phantomItemList_) && this.equipInfo_.Equals(other.equipInfo_) && this.propInfo_.Equals(other.propInfo_) && this.TotalCost == other.TotalCost && this.unlockSkins_.Equals(other.unlockSkins_) && this.DirectRefineWeekTimes == other.DirectRefineWeekTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011D7C RID: 73084 RVA: 0x0029C358 File Offset: 0x0029A558
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

		// Token: 0x06011D7D RID: 73085 RVA: 0x0029C3E8 File Offset: 0x0029A5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011D7E RID: 73086 RVA: 0x0029C3F5 File Offset: 0x0029A5F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011D7F RID: 73087 RVA: 0x0029C400 File Offset: 0x0029A600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DirectRefineWeekTimes != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DirectRefineWeekTimes);
			}
			if (this.TotalCost != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TotalCost);
			}
			this.phantomItemList_.WriteTo(ref output, PhantomItemResponse._repeated_phantomItemList_codec);
			this.propInfo_.WriteTo(ref output, PhantomItemResponse._repeated_propInfo_codec);
			this.equipInfo_.WriteTo(ref output, PhantomItemResponse._repeated_equipInfo_codec);
			this.unlockSkins_.WriteTo(ref output, PhantomItemResponse._repeated_unlockSkins_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011D80 RID: 73088 RVA: 0x0029C49C File Offset: 0x0029A69C
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

		// Token: 0x06011D81 RID: 73089 RVA: 0x0029C540 File Offset: 0x0029A740
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

		// Token: 0x06011D82 RID: 73090 RVA: 0x0029C5D4 File Offset: 0x0029A7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011D83 RID: 73091 RVA: 0x0029C5E0 File Offset: 0x0029A7E0
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.DirectRefineWeekTimes = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.TotalCost = input.ReadInt32();
						continue;
					}
					if (num == 26U)
					{
						this.phantomItemList_.AddEntriesFrom(ref input, PhantomItemResponse._repeated_phantomItemList_codec);
						continue;
					}
				}
				else if (num <= 66U)
				{
					if (num == 42U)
					{
						this.propInfo_.AddEntriesFrom(ref input, PhantomItemResponse._repeated_propInfo_codec);
						continue;
					}
					if (num == 66U)
					{
						this.equipInfo_.AddEntriesFrom(ref input, PhantomItemResponse._repeated_equipInfo_codec);
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.unlockSkins_.AddEntriesFrom(ref input, PhantomItemResponse._repeated_unlockSkins_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006FFF RID: 28671
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007000 RID: 28672
		public const int PhantomItemListFieldNumber = 3;

		// Token: 0x04007001 RID: 28673
		private static readonly FieldCodec<PhantomItem> _repeated_phantomItemList_codec = FieldCodec.ForMessage<PhantomItem>(26U, PhantomItem.Parser);

		// Token: 0x04007002 RID: 28674
		private readonly RepeatedField<PhantomItem> phantomItemList_ = new RepeatedField<PhantomItem>();

		// Token: 0x04007003 RID: 28675
		public const int EquipInfoFieldNumber = 8;

		// Token: 0x04007004 RID: 28676
		private static readonly FieldCodec<RolePhantomEquipInfo> _repeated_equipInfo_codec = FieldCodec.ForMessage<RolePhantomEquipInfo>(66U, RolePhantomEquipInfo.Parser);

		// Token: 0x04007005 RID: 28677
		private readonly RepeatedField<RolePhantomEquipInfo> equipInfo_ = new RepeatedField<RolePhantomEquipInfo>();

		// Token: 0x04007006 RID: 28678
		public const int PropInfoFieldNumber = 5;

		// Token: 0x04007007 RID: 28679
		private static readonly FieldCodec<RolePhantomPropInfo> _repeated_propInfo_codec = FieldCodec.ForMessage<RolePhantomPropInfo>(42U, RolePhantomPropInfo.Parser);

		// Token: 0x04007008 RID: 28680
		private readonly RepeatedField<RolePhantomPropInfo> propInfo_ = new RepeatedField<RolePhantomPropInfo>();

		// Token: 0x04007009 RID: 28681
		public const int TotalCostFieldNumber = 2;

		// Token: 0x0400700A RID: 28682
		private int totalCost_;

		// Token: 0x0400700B RID: 28683
		public const int UnlockSkinsFieldNumber = 15;

		// Token: 0x0400700C RID: 28684
		private static readonly FieldCodec<int> _repeated_unlockSkins_codec = FieldCodec.ForInt32(122U);

		// Token: 0x0400700D RID: 28685
		private readonly RepeatedField<int> unlockSkins_ = new RepeatedField<int>();

		// Token: 0x0400700E RID: 28686
		public const int DirectRefineWeekTimesFieldNumber = 1;

		// Token: 0x0400700F RID: 28687
		private int directRefineWeekTimes_;
	}
}
