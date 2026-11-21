using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200107A RID: 4218
	[NetMessage(EMessageId.RoleLevelUpViewResponse)]
	public sealed class RoleLevelUpViewResponse : IMessage<RoleLevelUpViewResponse>, IMessage, IEquatable<RoleLevelUpViewResponse>, IDeepCloneable<RoleLevelUpViewResponse>, IBufferMessage
	{
		// Token: 0x06016903 RID: 92419 RVA: 0x00348493 File Offset: 0x00346693
		[NullableContext(1)]
		public static RoleLevelUpViewResponse Create()
		{
			return new RoleLevelUpViewResponse();
		}

		// Token: 0x17004B98 RID: 19352
		// (get) Token: 0x06016904 RID: 92420 RVA: 0x0034849A File Offset: 0x0034669A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B99 RID: 19353
		// (get) Token: 0x06016905 RID: 92421 RVA: 0x0034849D File Offset: 0x0034669D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleLevelUpViewResponse.Descriptor;
			}
		}

		// Token: 0x06016906 RID: 92422 RVA: 0x003484A4 File Offset: 0x003466A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleLevelUpViewResponse()
		{
		}

		// Token: 0x06016907 RID: 92423 RVA: 0x003484E4 File Offset: 0x003466E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleLevelUpViewResponse(RoleLevelUpViewResponse other) : this()
		{
			this.code_ = other.code_;
			this.level_ = other.level_;
			this.levelExpInfo_ = other.levelExpInfo_.Clone();
			this.exp_ = other.exp_;
			this.addExp_ = other.addExp_;
			this.finalProp_ = other.finalProp_.Clone();
			this.costList_ = other.costList_.Clone();
			this.overflowList_ = other.overflowList_.Clone();
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016908 RID: 92424 RVA: 0x0034858D File Offset: 0x0034678D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleLevelUpViewResponse Clone()
		{
			return new RoleLevelUpViewResponse(this);
		}

		// Token: 0x17004B9A RID: 19354
		// (get) Token: 0x06016909 RID: 92425 RVA: 0x00348595 File Offset: 0x00346795
		// (set) Token: 0x0601690A RID: 92426 RVA: 0x0034859D File Offset: 0x0034679D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17004B9B RID: 19355
		// (get) Token: 0x0601690B RID: 92427 RVA: 0x003485A6 File Offset: 0x003467A6
		// (set) Token: 0x0601690C RID: 92428 RVA: 0x003485AE File Offset: 0x003467AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17004B9C RID: 19356
		// (get) Token: 0x0601690D RID: 92429 RVA: 0x003485B7 File Offset: 0x003467B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> LevelExpInfo
		{
			get
			{
				return this.levelExpInfo_;
			}
		}

		// Token: 0x17004B9D RID: 19357
		// (get) Token: 0x0601690E RID: 92430 RVA: 0x003485BF File Offset: 0x003467BF
		// (set) Token: 0x0601690F RID: 92431 RVA: 0x003485C7 File Offset: 0x003467C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x17004B9E RID: 19358
		// (get) Token: 0x06016910 RID: 92432 RVA: 0x003485D0 File Offset: 0x003467D0
		// (set) Token: 0x06016911 RID: 92433 RVA: 0x003485D8 File Offset: 0x003467D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AddExp
		{
			get
			{
				return this.addExp_;
			}
			set
			{
				this.addExp_ = value;
			}
		}

		// Token: 0x17004B9F RID: 19359
		// (get) Token: 0x06016912 RID: 92434 RVA: 0x003485E1 File Offset: 0x003467E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntDouble> FinalProp
		{
			get
			{
				return this.finalProp_;
			}
		}

		// Token: 0x17004BA0 RID: 19360
		// (get) Token: 0x06016913 RID: 92435 RVA: 0x003485E9 File Offset: 0x003467E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> CostList
		{
			get
			{
				return this.costList_;
			}
		}

		// Token: 0x17004BA1 RID: 19361
		// (get) Token: 0x06016914 RID: 92436 RVA: 0x003485F1 File Offset: 0x003467F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> OverflowList
		{
			get
			{
				return this.overflowList_;
			}
		}

		// Token: 0x17004BA2 RID: 19362
		// (get) Token: 0x06016915 RID: 92437 RVA: 0x003485F9 File Offset: 0x003467F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x06016916 RID: 92438 RVA: 0x00348601 File Offset: 0x00346801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleLevelUpViewResponse);
		}

		// Token: 0x06016917 RID: 92439 RVA: 0x00348610 File Offset: 0x00346810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleLevelUpViewResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Level == other.Level && this.levelExpInfo_.Equals(other.levelExpInfo_) && this.Exp == other.Exp && this.AddExp == other.AddExp && this.finalProp_.Equals(other.finalProp_) && this.costList_.Equals(other.costList_) && this.overflowList_.Equals(other.overflowList_) && this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016918 RID: 92440 RVA: 0x003486E4 File Offset: 0x003468E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			num ^= this.levelExpInfo_.GetHashCode();
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.AddExp != 0)
			{
				num ^= this.AddExp.GetHashCode();
			}
			num ^= this.finalProp_.GetHashCode();
			num ^= this.costList_.GetHashCode();
			num ^= this.overflowList_.GetHashCode();
			num ^= this.itemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016919 RID: 92441 RVA: 0x003487BA File Offset: 0x003469BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601691A RID: 92442 RVA: 0x003487C7 File Offset: 0x003469C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601691B RID: 92443 RVA: 0x003487D0 File Offset: 0x003469D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			this.costList_.WriteTo(ref output, RoleLevelUpViewResponse._repeated_costList_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Code);
			}
			this.levelExpInfo_.WriteTo(ref output, RoleLevelUpViewResponse._repeated_levelExpInfo_codec);
			if (this.AddExp != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.AddExp);
			}
			this.itemList_.WriteTo(ref output, RoleLevelUpViewResponse._repeated_itemList_codec);
			this.overflowList_.WriteTo(ref output, RoleLevelUpViewResponse._repeated_overflowList_codec);
			if (this.Exp != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Exp);
			}
			this.finalProp_.WriteTo(ref output, RoleLevelUpViewResponse._repeated_finalProp_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601691C RID: 92444 RVA: 0x003488B8 File Offset: 0x00346AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			num += this.levelExpInfo_.CalculateSize(RoleLevelUpViewResponse._repeated_levelExpInfo_codec);
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			if (this.AddExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AddExp);
			}
			num += this.finalProp_.CalculateSize(RoleLevelUpViewResponse._repeated_finalProp_codec);
			num += this.costList_.CalculateSize(RoleLevelUpViewResponse._repeated_costList_codec);
			num += this.overflowList_.CalculateSize(RoleLevelUpViewResponse._repeated_overflowList_codec);
			num += this.itemList_.CalculateSize(RoleLevelUpViewResponse._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601691D RID: 92445 RVA: 0x003489A0 File Offset: 0x00346BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleLevelUpViewResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this.levelExpInfo_.Add(other.levelExpInfo_);
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			if (other.AddExp != 0)
			{
				this.AddExp = other.AddExp;
			}
			this.finalProp_.Add(other.finalProp_);
			this.costList_.Add(other.costList_);
			this.overflowList_.Add(other.overflowList_);
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601691E RID: 92446 RVA: 0x00348A6D File Offset: 0x00346C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601691F RID: 92447 RVA: 0x00348A78 File Offset: 0x00346C78
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
				if (num <= 58U)
				{
					if (num <= 26U)
					{
						if (num == 16U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
						if (num == 26U)
						{
							this.costList_.AddEntriesFrom(ref input, RoleLevelUpViewResponse._repeated_costList_codec);
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.Code = (ErrorCode)input.ReadEnum();
							continue;
						}
						if (num == 58U)
						{
							this.levelExpInfo_.AddEntriesFrom(ref input, RoleLevelUpViewResponse._repeated_levelExpInfo_codec);
							continue;
						}
					}
				}
				else if (num <= 74U)
				{
					if (num == 64U)
					{
						this.AddExp = input.ReadInt32();
						continue;
					}
					if (num == 74U)
					{
						this.itemList_.AddEntriesFrom(ref input, RoleLevelUpViewResponse._repeated_itemList_codec);
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						this.overflowList_.AddEntriesFrom(ref input, RoleLevelUpViewResponse._repeated_overflowList_codec);
						continue;
					}
					if (num == 112U)
					{
						this.Exp = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						this.finalProp_.AddEntriesFrom(ref input, RoleLevelUpViewResponse._repeated_finalProp_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008758 RID: 34648
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008759 RID: 34649
		public const int CodeFieldNumber = 5;

		// Token: 0x0400875A RID: 34650
		private ErrorCode code_;

		// Token: 0x0400875B RID: 34651
		public const int LevelFieldNumber = 2;

		// Token: 0x0400875C RID: 34652
		private int level_;

		// Token: 0x0400875D RID: 34653
		public const int LevelExpInfoFieldNumber = 7;

		// Token: 0x0400875E RID: 34654
		private static readonly FieldCodec<ArrayIntInt> _repeated_levelExpInfo_codec = FieldCodec.ForMessage<ArrayIntInt>(58U, ArrayIntInt.Parser);

		// Token: 0x0400875F RID: 34655
		private readonly RepeatedField<ArrayIntInt> levelExpInfo_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x04008760 RID: 34656
		public const int ExpFieldNumber = 14;

		// Token: 0x04008761 RID: 34657
		private int exp_;

		// Token: 0x04008762 RID: 34658
		public const int AddExpFieldNumber = 8;

		// Token: 0x04008763 RID: 34659
		private int addExp_;

		// Token: 0x04008764 RID: 34660
		public const int FinalPropFieldNumber = 15;

		// Token: 0x04008765 RID: 34661
		private static readonly FieldCodec<ArrayIntDouble> _repeated_finalProp_codec = FieldCodec.ForMessage<ArrayIntDouble>(122U, ArrayIntDouble.Parser);

		// Token: 0x04008766 RID: 34662
		private readonly RepeatedField<ArrayIntDouble> finalProp_ = new RepeatedField<ArrayIntDouble>();

		// Token: 0x04008767 RID: 34663
		public const int CostListFieldNumber = 3;

		// Token: 0x04008768 RID: 34664
		private static readonly FieldCodec<ArrayIntInt> _repeated_costList_codec = FieldCodec.ForMessage<ArrayIntInt>(26U, ArrayIntInt.Parser);

		// Token: 0x04008769 RID: 34665
		private readonly RepeatedField<ArrayIntInt> costList_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x0400876A RID: 34666
		public const int OverflowListFieldNumber = 13;

		// Token: 0x0400876B RID: 34667
		private static readonly FieldCodec<ArrayIntInt> _repeated_overflowList_codec = FieldCodec.ForMessage<ArrayIntInt>(106U, ArrayIntInt.Parser);

		// Token: 0x0400876C RID: 34668
		private readonly RepeatedField<ArrayIntInt> overflowList_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x0400876D RID: 34669
		public const int ItemListFieldNumber = 9;

		// Token: 0x0400876E RID: 34670
		private static readonly FieldCodec<ArrayIntInt> _repeated_itemList_codec = FieldCodec.ForMessage<ArrayIntInt>(74U, ArrayIntInt.Parser);

		// Token: 0x0400876F RID: 34671
		private readonly RepeatedField<ArrayIntInt> itemList_ = new RepeatedField<ArrayIntInt>();
	}
}
