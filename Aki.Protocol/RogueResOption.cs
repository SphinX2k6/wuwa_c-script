using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FEE RID: 4078
	public sealed class RogueResOption : IMessage<RogueResOption>, IMessage, IEquatable<RogueResOption>, IDeepCloneable<RogueResOption>, IBufferMessage
	{
		// Token: 0x06015D41 RID: 89409 RVA: 0x0032CA29 File Offset: 0x0032AC29
		[NullableContext(1)]
		public static RogueResOption Create()
		{
			return new RogueResOption();
		}

		// Token: 0x170048EA RID: 18666
		// (get) Token: 0x06015D42 RID: 89410 RVA: 0x0032CA30 File Offset: 0x0032AC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueResOption> Parser
		{
			get
			{
				return RogueResOption._parser;
			}
		}

		// Token: 0x170048EB RID: 18667
		// (get) Token: 0x06015D43 RID: 89411 RVA: 0x0032CA37 File Offset: 0x0032AC37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048EC RID: 18668
		// (get) Token: 0x06015D44 RID: 89412 RVA: 0x0032CA3A File Offset: 0x0032AC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResOption.Descriptor;
			}
		}

		// Token: 0x06015D45 RID: 89413 RVA: 0x0032CA41 File Offset: 0x0032AC41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOption()
		{
		}

		// Token: 0x06015D46 RID: 89414 RVA: 0x0032CA54 File Offset: 0x0032AC54
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

		// Token: 0x06015D47 RID: 89415 RVA: 0x0032CB0D File Offset: 0x0032AD0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOption Clone()
		{
			return new RogueResOption(this);
		}

		// Token: 0x170048ED RID: 18669
		// (get) Token: 0x06015D48 RID: 89416 RVA: 0x0032CB15 File Offset: 0x0032AD15
		// (set) Token: 0x06015D49 RID: 89417 RVA: 0x0032CB1D File Offset: 0x0032AD1D
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

		// Token: 0x170048EE RID: 18670
		// (get) Token: 0x06015D4A RID: 89418 RVA: 0x0032CB26 File Offset: 0x0032AD26
		// (set) Token: 0x06015D4B RID: 89419 RVA: 0x0032CB2E File Offset: 0x0032AD2E
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

		// Token: 0x170048EF RID: 18671
		// (get) Token: 0x06015D4C RID: 89420 RVA: 0x0032CB37 File Offset: 0x0032AD37
		// (set) Token: 0x06015D4D RID: 89421 RVA: 0x0032CB3F File Offset: 0x0032AD3F
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

		// Token: 0x170048F0 RID: 18672
		// (get) Token: 0x06015D4E RID: 89422 RVA: 0x0032CB48 File Offset: 0x0032AD48
		// (set) Token: 0x06015D4F RID: 89423 RVA: 0x0032CB50 File Offset: 0x0032AD50
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

		// Token: 0x170048F1 RID: 18673
		// (get) Token: 0x06015D50 RID: 89424 RVA: 0x0032CB59 File Offset: 0x0032AD59
		// (set) Token: 0x06015D51 RID: 89425 RVA: 0x0032CB61 File Offset: 0x0032AD61
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

		// Token: 0x170048F2 RID: 18674
		// (get) Token: 0x06015D52 RID: 89426 RVA: 0x0032CB6A File Offset: 0x0032AD6A
		// (set) Token: 0x06015D53 RID: 89427 RVA: 0x0032CB72 File Offset: 0x0032AD72
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

		// Token: 0x170048F3 RID: 18675
		// (get) Token: 0x06015D54 RID: 89428 RVA: 0x0032CB7B File Offset: 0x0032AD7B
		// (set) Token: 0x06015D55 RID: 89429 RVA: 0x0032CB83 File Offset: 0x0032AD83
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

		// Token: 0x170048F4 RID: 18676
		// (get) Token: 0x06015D56 RID: 89430 RVA: 0x0032CB8C File Offset: 0x0032AD8C
		// (set) Token: 0x06015D57 RID: 89431 RVA: 0x0032CB94 File Offset: 0x0032AD94
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

		// Token: 0x170048F5 RID: 18677
		// (get) Token: 0x06015D58 RID: 89432 RVA: 0x0032CB9D File Offset: 0x0032AD9D
		// (set) Token: 0x06015D59 RID: 89433 RVA: 0x0032CBA5 File Offset: 0x0032ADA5
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

		// Token: 0x170048F6 RID: 18678
		// (get) Token: 0x06015D5A RID: 89434 RVA: 0x0032CBAE File Offset: 0x0032ADAE
		// (set) Token: 0x06015D5B RID: 89435 RVA: 0x0032CBB6 File Offset: 0x0032ADB6
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

		// Token: 0x170048F7 RID: 18679
		// (get) Token: 0x06015D5C RID: 89436 RVA: 0x0032CBBF File Offset: 0x0032ADBF
		// (set) Token: 0x06015D5D RID: 89437 RVA: 0x0032CBC7 File Offset: 0x0032ADC7
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

		// Token: 0x170048F8 RID: 18680
		// (get) Token: 0x06015D5E RID: 89438 RVA: 0x0032CBD0 File Offset: 0x0032ADD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResGainData> RogueResGainDatas
		{
			get
			{
				return this.rogueResGainDatas_;
			}
		}

		// Token: 0x06015D5F RID: 89439 RVA: 0x0032CBD8 File Offset: 0x0032ADD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResOption);
		}

		// Token: 0x06015D60 RID: 89440 RVA: 0x0032CBE8 File Offset: 0x0032ADE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResOption other)
		{
			return other != null && (other == this || (this.RogueResDataType == other.RogueResDataType && this.IsSelect == other.IsSelect && this.CanGiveUp == other.CanGiveUp && this.CanMultiSelect == other.CanMultiSelect && this.MaxSelectCount == other.MaxSelectCount && this.UseSelectCount == other.UseSelectCount && this.MaxRefreshCount == other.MaxRefreshCount && this.UseRefreshCount == other.UseRefreshCount && this.RefreshItem == other.RefreshItem && this.RefreshCost == other.RefreshCost && this.RoleId == other.RoleId && this.rogueResGainDatas_.Equals(other.rogueResGainDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015D61 RID: 89441 RVA: 0x0032CCD8 File Offset: 0x0032AED8
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

		// Token: 0x06015D62 RID: 89442 RVA: 0x0032CE25 File Offset: 0x0032B025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015D63 RID: 89443 RVA: 0x0032CE32 File Offset: 0x0032B032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015D64 RID: 89444 RVA: 0x0032CE3C File Offset: 0x0032B03C
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

		// Token: 0x06015D65 RID: 89445 RVA: 0x0032CFDC File Offset: 0x0032B1DC
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

		// Token: 0x06015D66 RID: 89446 RVA: 0x0032D0FC File Offset: 0x0032B2FC
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

		// Token: 0x06015D67 RID: 89447 RVA: 0x0032D211 File Offset: 0x0032B411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015D68 RID: 89448 RVA: 0x0032D21C File Offset: 0x0032B41C
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

		// Token: 0x04008369 RID: 33641
		private static readonly MessageParser<RogueResOption> _parser = new MessageParser<RogueResOption>(() => new RogueResOption());

		// Token: 0x0400836A RID: 33642
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400836B RID: 33643
		public const int RogueResDataTypeFieldNumber = 1000;

		// Token: 0x0400836C RID: 33644
		private RogueResDataType rogueResDataType_;

		// Token: 0x0400836D RID: 33645
		public const int IsSelectFieldNumber = 1001;

		// Token: 0x0400836E RID: 33646
		private bool isSelect_;

		// Token: 0x0400836F RID: 33647
		public const int CanGiveUpFieldNumber = 1002;

		// Token: 0x04008370 RID: 33648
		private bool canGiveUp_;

		// Token: 0x04008371 RID: 33649
		public const int CanMultiSelectFieldNumber = 1003;

		// Token: 0x04008372 RID: 33650
		private bool canMultiSelect_;

		// Token: 0x04008373 RID: 33651
		public const int MaxSelectCountFieldNumber = 1004;

		// Token: 0x04008374 RID: 33652
		private int maxSelectCount_;

		// Token: 0x04008375 RID: 33653
		public const int UseSelectCountFieldNumber = 1005;

		// Token: 0x04008376 RID: 33654
		private int useSelectCount_;

		// Token: 0x04008377 RID: 33655
		public const int MaxRefreshCountFieldNumber = 1006;

		// Token: 0x04008378 RID: 33656
		private int maxRefreshCount_;

		// Token: 0x04008379 RID: 33657
		public const int UseRefreshCountFieldNumber = 1007;

		// Token: 0x0400837A RID: 33658
		private int useRefreshCount_;

		// Token: 0x0400837B RID: 33659
		public const int RefreshItemFieldNumber = 1008;

		// Token: 0x0400837C RID: 33660
		private int refreshItem_;

		// Token: 0x0400837D RID: 33661
		public const int RefreshCostFieldNumber = 1009;

		// Token: 0x0400837E RID: 33662
		private int refreshCost_;

		// Token: 0x0400837F RID: 33663
		public const int RoleIdFieldNumber = 1010;

		// Token: 0x04008380 RID: 33664
		private int roleId_;

		// Token: 0x04008381 RID: 33665
		public const int RogueResGainDatasFieldNumber = 1;

		// Token: 0x04008382 RID: 33666
		private static readonly FieldCodec<RogueResGainData> _repeated_rogueResGainDatas_codec = FieldCodec.ForMessage<RogueResGainData>(10U, RogueResGainData.Parser);

		// Token: 0x04008383 RID: 33667
		private readonly RepeatedField<RogueResGainData> rogueResGainDatas_ = new RepeatedField<RogueResGainData>();
	}
}
