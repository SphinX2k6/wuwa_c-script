using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FFE RID: 4094
	public sealed class RogueResOption : IMessage<RogueResOption>, IMessage, IEquatable<RogueResOption>, IDeepCloneable<RogueResOption>, IBufferMessage
	{
		// Token: 0x06015E26 RID: 89638 RVA: 0x0032E0E9 File Offset: 0x0032C2E9
		[NullableContext(1)]
		public static RogueResOption Create()
		{
			return new RogueResOption();
		}

		// Token: 0x17004914 RID: 18708
		// (get) Token: 0x06015E27 RID: 89639 RVA: 0x0032E0F0 File Offset: 0x0032C2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueResOption> Parser
		{
			get
			{
				return RogueResOption._parser;
			}
		}

		// Token: 0x17004915 RID: 18709
		// (get) Token: 0x06015E28 RID: 89640 RVA: 0x0032E0F7 File Offset: 0x0032C2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004916 RID: 18710
		// (get) Token: 0x06015E29 RID: 89641 RVA: 0x0032E0FA File Offset: 0x0032C2FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResOption.Descriptor;
			}
		}

		// Token: 0x06015E2A RID: 89642 RVA: 0x0032E101 File Offset: 0x0032C301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOption()
		{
		}

		// Token: 0x06015E2B RID: 89643 RVA: 0x0032E114 File Offset: 0x0032C314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOption(RogueResOption other) : this()
		{
			this.rogueResDataType_ = other.rogueResDataType_;
			this.isSelect_ = other.isSelect_;
			this.canGiveUp_ = other.canGiveUp_;
			this.canMultiSelect_ = other.canMultiSelect_;
			this.maxSelectCount_ = other.maxSelectCount_;
			this.useSelectCount_ = other.useSelectCount_;
			this.maxRefreshCount_ = other.maxRefreshCount_;
			this.useRefreshCount_ = other.useRefreshCount_;
			this.refreshItem_ = other.refreshItem_;
			this.refreshCost_ = other.refreshCost_;
			this.roleId_ = other.roleId_;
			this.rogueResGainDatas_ = other.rogueResGainDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015E2C RID: 89644 RVA: 0x0032E1CD File Offset: 0x0032C3CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOption Clone()
		{
			return new RogueResOption(this);
		}

		// Token: 0x17004917 RID: 18711
		// (get) Token: 0x06015E2D RID: 89645 RVA: 0x0032E1D5 File Offset: 0x0032C3D5
		// (set) Token: 0x06015E2E RID: 89646 RVA: 0x0032E1DD File Offset: 0x0032C3DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResDataType RogueResDataType
		{
			get
			{
				return this.rogueResDataType_;
			}
			set
			{
				this.rogueResDataType_ = value;
			}
		}

		// Token: 0x17004918 RID: 18712
		// (get) Token: 0x06015E2F RID: 89647 RVA: 0x0032E1E6 File Offset: 0x0032C3E6
		// (set) Token: 0x06015E30 RID: 89648 RVA: 0x0032E1EE File Offset: 0x0032C3EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSelect
		{
			get
			{
				return this.isSelect_;
			}
			set
			{
				this.isSelect_ = value;
			}
		}

		// Token: 0x17004919 RID: 18713
		// (get) Token: 0x06015E31 RID: 89649 RVA: 0x0032E1F7 File Offset: 0x0032C3F7
		// (set) Token: 0x06015E32 RID: 89650 RVA: 0x0032E1FF File Offset: 0x0032C3FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanGiveUp
		{
			get
			{
				return this.canGiveUp_;
			}
			set
			{
				this.canGiveUp_ = value;
			}
		}

		// Token: 0x1700491A RID: 18714
		// (get) Token: 0x06015E33 RID: 89651 RVA: 0x0032E208 File Offset: 0x0032C408
		// (set) Token: 0x06015E34 RID: 89652 RVA: 0x0032E210 File Offset: 0x0032C410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanMultiSelect
		{
			get
			{
				return this.canMultiSelect_;
			}
			set
			{
				this.canMultiSelect_ = value;
			}
		}

		// Token: 0x1700491B RID: 18715
		// (get) Token: 0x06015E35 RID: 89653 RVA: 0x0032E219 File Offset: 0x0032C419
		// (set) Token: 0x06015E36 RID: 89654 RVA: 0x0032E221 File Offset: 0x0032C421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxSelectCount
		{
			get
			{
				return this.maxSelectCount_;
			}
			set
			{
				this.maxSelectCount_ = value;
			}
		}

		// Token: 0x1700491C RID: 18716
		// (get) Token: 0x06015E37 RID: 89655 RVA: 0x0032E22A File Offset: 0x0032C42A
		// (set) Token: 0x06015E38 RID: 89656 RVA: 0x0032E232 File Offset: 0x0032C432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseSelectCount
		{
			get
			{
				return this.useSelectCount_;
			}
			set
			{
				this.useSelectCount_ = value;
			}
		}

		// Token: 0x1700491D RID: 18717
		// (get) Token: 0x06015E39 RID: 89657 RVA: 0x0032E23B File Offset: 0x0032C43B
		// (set) Token: 0x06015E3A RID: 89658 RVA: 0x0032E243 File Offset: 0x0032C443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxRefreshCount
		{
			get
			{
				return this.maxRefreshCount_;
			}
			set
			{
				this.maxRefreshCount_ = value;
			}
		}

		// Token: 0x1700491E RID: 18718
		// (get) Token: 0x06015E3B RID: 89659 RVA: 0x0032E24C File Offset: 0x0032C44C
		// (set) Token: 0x06015E3C RID: 89660 RVA: 0x0032E254 File Offset: 0x0032C454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseRefreshCount
		{
			get
			{
				return this.useRefreshCount_;
			}
			set
			{
				this.useRefreshCount_ = value;
			}
		}

		// Token: 0x1700491F RID: 18719
		// (get) Token: 0x06015E3D RID: 89661 RVA: 0x0032E25D File Offset: 0x0032C45D
		// (set) Token: 0x06015E3E RID: 89662 RVA: 0x0032E265 File Offset: 0x0032C465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RefreshItem
		{
			get
			{
				return this.refreshItem_;
			}
			set
			{
				this.refreshItem_ = value;
			}
		}

		// Token: 0x17004920 RID: 18720
		// (get) Token: 0x06015E3F RID: 89663 RVA: 0x0032E26E File Offset: 0x0032C46E
		// (set) Token: 0x06015E40 RID: 89664 RVA: 0x0032E276 File Offset: 0x0032C476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RefreshCost
		{
			get
			{
				return this.refreshCost_;
			}
			set
			{
				this.refreshCost_ = value;
			}
		}

		// Token: 0x17004921 RID: 18721
		// (get) Token: 0x06015E41 RID: 89665 RVA: 0x0032E27F File Offset: 0x0032C47F
		// (set) Token: 0x06015E42 RID: 89666 RVA: 0x0032E287 File Offset: 0x0032C487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004922 RID: 18722
		// (get) Token: 0x06015E43 RID: 89667 RVA: 0x0032E290 File Offset: 0x0032C490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResGainData> RogueResGainDatas
		{
			get
			{
				return this.rogueResGainDatas_;
			}
		}

		// Token: 0x06015E44 RID: 89668 RVA: 0x0032E298 File Offset: 0x0032C498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResOption);
		}

		// Token: 0x06015E45 RID: 89669 RVA: 0x0032E2A8 File Offset: 0x0032C4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResOption other)
		{
			return other != null && (other == this || (this.RogueResDataType == other.RogueResDataType && this.IsSelect == other.IsSelect && this.CanGiveUp == other.CanGiveUp && this.CanMultiSelect == other.CanMultiSelect && this.MaxSelectCount == other.MaxSelectCount && this.UseSelectCount == other.UseSelectCount && this.MaxRefreshCount == other.MaxRefreshCount && this.UseRefreshCount == other.UseRefreshCount && this.RefreshItem == other.RefreshItem && this.RefreshCost == other.RefreshCost && this.RoleId == other.RoleId && this.rogueResGainDatas_.Equals(other.rogueResGainDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015E46 RID: 89670 RVA: 0x0032E398 File Offset: 0x0032C598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RogueResDataType != RogueResDataType.NoGain)
			{
				num ^= this.RogueResDataType.GetHashCode();
			}
			if (this.IsSelect)
			{
				num ^= this.IsSelect.GetHashCode();
			}
			if (this.CanGiveUp)
			{
				num ^= this.CanGiveUp.GetHashCode();
			}
			if (this.CanMultiSelect)
			{
				num ^= this.CanMultiSelect.GetHashCode();
			}
			if (this.MaxSelectCount != 0)
			{
				num ^= this.MaxSelectCount.GetHashCode();
			}
			if (this.UseSelectCount != 0)
			{
				num ^= this.UseSelectCount.GetHashCode();
			}
			if (this.MaxRefreshCount != 0)
			{
				num ^= this.MaxRefreshCount.GetHashCode();
			}
			if (this.UseRefreshCount != 0)
			{
				num ^= this.UseRefreshCount.GetHashCode();
			}
			if (this.RefreshItem != 0)
			{
				num ^= this.RefreshItem.GetHashCode();
			}
			if (this.RefreshCost != 0)
			{
				num ^= this.RefreshCost.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			num ^= this.rogueResGainDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015E47 RID: 89671 RVA: 0x0032E4E5 File Offset: 0x0032C6E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015E48 RID: 89672 RVA: 0x0032E4F2 File Offset: 0x0032C6F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015E49 RID: 89673 RVA: 0x0032E4FC File Offset: 0x0032C6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueResGainDatas_.WriteTo(ref output, RogueResOption._repeated_rogueResGainDatas_codec);
			if (this.RogueResDataType != RogueResDataType.NoGain)
			{
				output.WriteRawTag(192, 62);
				output.WriteEnum((int)this.RogueResDataType);
			}
			if (this.IsSelect)
			{
				output.WriteRawTag(200, 62);
				output.WriteBool(this.IsSelect);
			}
			if (this.CanGiveUp)
			{
				output.WriteRawTag(208, 62);
				output.WriteBool(this.CanGiveUp);
			}
			if (this.CanMultiSelect)
			{
				output.WriteRawTag(216, 62);
				output.WriteBool(this.CanMultiSelect);
			}
			if (this.MaxSelectCount != 0)
			{
				output.WriteRawTag(224, 62);
				output.WriteInt32(this.MaxSelectCount);
			}
			if (this.UseSelectCount != 0)
			{
				output.WriteRawTag(232, 62);
				output.WriteInt32(this.UseSelectCount);
			}
			if (this.MaxRefreshCount != 0)
			{
				output.WriteRawTag(240, 62);
				output.WriteInt32(this.MaxRefreshCount);
			}
			if (this.UseRefreshCount != 0)
			{
				output.WriteRawTag(248, 62);
				output.WriteInt32(this.UseRefreshCount);
			}
			if (this.RefreshItem != 0)
			{
				output.WriteRawTag(128, 63);
				output.WriteInt32(this.RefreshItem);
			}
			if (this.RefreshCost != 0)
			{
				output.WriteRawTag(136, 63);
				output.WriteInt32(this.RefreshCost);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(144, 63);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015E4A RID: 89674 RVA: 0x0032E69C File Offset: 0x0032C89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RogueResDataType != RogueResDataType.NoGain)
			{
				num += 2 + CodedOutputStream.ComputeEnumSize((int)this.RogueResDataType);
			}
			if (this.IsSelect)
			{
				num += 3;
			}
			if (this.CanGiveUp)
			{
				num += 3;
			}
			if (this.CanMultiSelect)
			{
				num += 3;
			}
			if (this.MaxSelectCount != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MaxSelectCount);
			}
			if (this.UseSelectCount != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.UseSelectCount);
			}
			if (this.MaxRefreshCount != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MaxRefreshCount);
			}
			if (this.UseRefreshCount != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.UseRefreshCount);
			}
			if (this.RefreshItem != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RefreshItem);
			}
			if (this.RefreshCost != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RefreshCost);
			}
			if (this.RoleId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			num += this.rogueResGainDatas_.CalculateSize(RogueResOption._repeated_rogueResGainDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015E4B RID: 89675 RVA: 0x0032E7BC File Offset: 0x0032C9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResOption other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RogueResDataType != RogueResDataType.NoGain)
			{
				this.RogueResDataType = other.RogueResDataType;
			}
			if (other.IsSelect)
			{
				this.IsSelect = other.IsSelect;
			}
			if (other.CanGiveUp)
			{
				this.CanGiveUp = other.CanGiveUp;
			}
			if (other.CanMultiSelect)
			{
				this.CanMultiSelect = other.CanMultiSelect;
			}
			if (other.MaxSelectCount != 0)
			{
				this.MaxSelectCount = other.MaxSelectCount;
			}
			if (other.UseSelectCount != 0)
			{
				this.UseSelectCount = other.UseSelectCount;
			}
			if (other.MaxRefreshCount != 0)
			{
				this.MaxRefreshCount = other.MaxRefreshCount;
			}
			if (other.UseRefreshCount != 0)
			{
				this.UseRefreshCount = other.UseRefreshCount;
			}
			if (other.RefreshItem != 0)
			{
				this.RefreshItem = other.RefreshItem;
			}
			if (other.RefreshCost != 0)
			{
				this.RefreshCost = other.RefreshCost;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this.rogueResGainDatas_.Add(other.rogueResGainDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015E4C RID: 89676 RVA: 0x0032E8D1 File Offset: 0x0032CAD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015E4D RID: 89677 RVA: 0x0032E8DC File Offset: 0x0032CADC
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
				if (num <= 8032U)
				{
					if (num <= 8008U)
					{
						if (num == 10U)
						{
							this.rogueResGainDatas_.AddEntriesFrom(ref input, RogueResOption._repeated_rogueResGainDatas_codec);
							continue;
						}
						if (num == 8000U)
						{
							this.RogueResDataType = (RogueResDataType)input.ReadEnum();
							continue;
						}
						if (num == 8008U)
						{
							this.IsSelect = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 8016U)
						{
							this.CanGiveUp = input.ReadBool();
							continue;
						}
						if (num == 8024U)
						{
							this.CanMultiSelect = input.ReadBool();
							continue;
						}
						if (num == 8032U)
						{
							this.MaxSelectCount = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 8056U)
				{
					if (num == 8040U)
					{
						this.UseSelectCount = input.ReadInt32();
						continue;
					}
					if (num == 8048U)
					{
						this.MaxRefreshCount = input.ReadInt32();
						continue;
					}
					if (num == 8056U)
					{
						this.UseRefreshCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 8064U)
					{
						this.RefreshItem = input.ReadInt32();
						continue;
					}
					if (num == 8072U)
					{
						this.RefreshCost = input.ReadInt32();
						continue;
					}
					if (num == 8080U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400833F RID: 33599
		private static readonly MessageParser<RogueResOption> _parser = new MessageParser<RogueResOption>(() => new RogueResOption());

		// Token: 0x04008340 RID: 33600
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008341 RID: 33601
		public const int RogueResDataTypeFieldNumber = 1000;

		// Token: 0x04008342 RID: 33602
		private RogueResDataType rogueResDataType_;

		// Token: 0x04008343 RID: 33603
		public const int IsSelectFieldNumber = 1001;

		// Token: 0x04008344 RID: 33604
		private bool isSelect_;

		// Token: 0x04008345 RID: 33605
		public const int CanGiveUpFieldNumber = 1002;

		// Token: 0x04008346 RID: 33606
		private bool canGiveUp_;

		// Token: 0x04008347 RID: 33607
		public const int CanMultiSelectFieldNumber = 1003;

		// Token: 0x04008348 RID: 33608
		private bool canMultiSelect_;

		// Token: 0x04008349 RID: 33609
		public const int MaxSelectCountFieldNumber = 1004;

		// Token: 0x0400834A RID: 33610
		private int maxSelectCount_;

		// Token: 0x0400834B RID: 33611
		public const int UseSelectCountFieldNumber = 1005;

		// Token: 0x0400834C RID: 33612
		private int useSelectCount_;

		// Token: 0x0400834D RID: 33613
		public const int MaxRefreshCountFieldNumber = 1006;

		// Token: 0x0400834E RID: 33614
		private int maxRefreshCount_;

		// Token: 0x0400834F RID: 33615
		public const int UseRefreshCountFieldNumber = 1007;

		// Token: 0x04008350 RID: 33616
		private int useRefreshCount_;

		// Token: 0x04008351 RID: 33617
		public const int RefreshItemFieldNumber = 1008;

		// Token: 0x04008352 RID: 33618
		private int refreshItem_;

		// Token: 0x04008353 RID: 33619
		public const int RefreshCostFieldNumber = 1009;

		// Token: 0x04008354 RID: 33620
		private int refreshCost_;

		// Token: 0x04008355 RID: 33621
		public const int RoleIdFieldNumber = 1010;

		// Token: 0x04008356 RID: 33622
		private int roleId_;

		// Token: 0x04008357 RID: 33623
		public const int RogueResGainDatasFieldNumber = 1;

		// Token: 0x04008358 RID: 33624
		private static readonly FieldCodec<RogueResGainData> _repeated_rogueResGainDatas_codec = FieldCodec.ForMessage<RogueResGainData>(10U, RogueResGainData.Parser);

		// Token: 0x04008359 RID: 33625
		private readonly RepeatedField<RogueResGainData> rogueResGainDatas_ = new RepeatedField<RogueResGainData>();
	}
}
