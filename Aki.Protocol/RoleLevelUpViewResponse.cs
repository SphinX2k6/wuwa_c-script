using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200108A RID: 4234
	[NetMessage(EMessageId.RoleLevelUpViewResponse)]
	public sealed class RoleLevelUpViewResponse : IMessage<RoleLevelUpViewResponse>, IMessage, IEquatable<RoleLevelUpViewResponse>, IDeepCloneable<RoleLevelUpViewResponse>, IBufferMessage
	{
		// Token: 0x060169E8 RID: 92648 RVA: 0x00349B6A File Offset: 0x00347D6A
		[NullableContext(1)]
		public static RoleLevelUpViewResponse Create()
		{
			return new RoleLevelUpViewResponse();
		}

		// Token: 0x17004BC2 RID: 19394
		// (get) Token: 0x060169E9 RID: 92649 RVA: 0x00349B71 File Offset: 0x00347D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BC3 RID: 19395
		// (get) Token: 0x060169EA RID: 92650 RVA: 0x00349B74 File Offset: 0x00347D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleLevelUpViewResponse.Descriptor;
			}
		}

		// Token: 0x060169EB RID: 92651 RVA: 0x00349B7B File Offset: 0x00347D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleLevelUpViewResponse()
		{
		}

		// Token: 0x060169EC RID: 92652 RVA: 0x00349BBC File Offset: 0x00347DBC
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

		// Token: 0x060169ED RID: 92653 RVA: 0x00349C65 File Offset: 0x00347E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleLevelUpViewResponse Clone()
		{
			return new RoleLevelUpViewResponse(this);
		}

		// Token: 0x17004BC4 RID: 19396
		// (get) Token: 0x060169EE RID: 92654 RVA: 0x00349C6D File Offset: 0x00347E6D
		// (set) Token: 0x060169EF RID: 92655 RVA: 0x00349C75 File Offset: 0x00347E75
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

		// Token: 0x17004BC5 RID: 19397
		// (get) Token: 0x060169F0 RID: 92656 RVA: 0x00349C7E File Offset: 0x00347E7E
		// (set) Token: 0x060169F1 RID: 92657 RVA: 0x00349C86 File Offset: 0x00347E86
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

		// Token: 0x17004BC6 RID: 19398
		// (get) Token: 0x060169F2 RID: 92658 RVA: 0x00349C8F File Offset: 0x00347E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> LevelExpInfo
		{
			get
			{
				return this.levelExpInfo_;
			}
		}

		// Token: 0x17004BC7 RID: 19399
		// (get) Token: 0x060169F3 RID: 92659 RVA: 0x00349C97 File Offset: 0x00347E97
		// (set) Token: 0x060169F4 RID: 92660 RVA: 0x00349C9F File Offset: 0x00347E9F
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

		// Token: 0x17004BC8 RID: 19400
		// (get) Token: 0x060169F5 RID: 92661 RVA: 0x00349CA8 File Offset: 0x00347EA8
		// (set) Token: 0x060169F6 RID: 92662 RVA: 0x00349CB0 File Offset: 0x00347EB0
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

		// Token: 0x17004BC9 RID: 19401
		// (get) Token: 0x060169F7 RID: 92663 RVA: 0x00349CB9 File Offset: 0x00347EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntDouble> FinalProp
		{
			get
			{
				return this.finalProp_;
			}
		}

		// Token: 0x17004BCA RID: 19402
		// (get) Token: 0x060169F8 RID: 92664 RVA: 0x00349CC1 File Offset: 0x00347EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> CostList
		{
			get
			{
				return this.costList_;
			}
		}

		// Token: 0x17004BCB RID: 19403
		// (get) Token: 0x060169F9 RID: 92665 RVA: 0x00349CC9 File Offset: 0x00347EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> OverflowList
		{
			get
			{
				return this.overflowList_;
			}
		}

		// Token: 0x17004BCC RID: 19404
		// (get) Token: 0x060169FA RID: 92666 RVA: 0x00349CD1 File Offset: 0x00347ED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x060169FB RID: 92667 RVA: 0x00349CD9 File Offset: 0x00347ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleLevelUpViewResponse);
		}

		// Token: 0x060169FC RID: 92668 RVA: 0x00349CE8 File Offset: 0x00347EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleLevelUpViewResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Level == other.Level && this.levelExpInfo_.Equals(other.levelExpInfo_) && this.Exp == other.Exp && this.AddExp == other.AddExp && this.finalProp_.Equals(other.finalProp_) && this.costList_.Equals(other.costList_) && this.overflowList_.Equals(other.overflowList_) && this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060169FD RID: 92669 RVA: 0x00349DBC File Offset: 0x00347FBC
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

		// Token: 0x060169FE RID: 92670 RVA: 0x00349E92 File Offset: 0x00348092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060169FF RID: 92671 RVA: 0x00349E9F File Offset: 0x0034809F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016A00 RID: 92672 RVA: 0x00349EA8 File Offset: 0x003480A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Exp != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Exp);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Code);
			}
			if (this.AddExp != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.AddExp);
			}
			this.itemList_.WriteTo(ref output, RoleLevelUpViewResponse._repeated_itemList_codec);
			this.finalProp_.WriteTo(ref output, RoleLevelUpViewResponse._repeated_finalProp_codec);
			this.overflowList_.WriteTo(ref output, RoleLevelUpViewResponse._repeated_overflowList_codec);
			if (this.Level != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Level);
			}
			this.levelExpInfo_.WriteTo(ref output, RoleLevelUpViewResponse._repeated_levelExpInfo_codec);
			this.costList_.WriteTo(ref output, RoleLevelUpViewResponse._repeated_costList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016A01 RID: 92673 RVA: 0x00349F90 File Offset: 0x00348190
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

		// Token: 0x06016A02 RID: 92674 RVA: 0x0034A078 File Offset: 0x00348278
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

		// Token: 0x06016A03 RID: 92675 RVA: 0x0034A145 File Offset: 0x00348345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016A04 RID: 92676 RVA: 0x0034A150 File Offset: 0x00348350
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
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.Exp = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.Code = (ErrorCode)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.AddExp = input.ReadInt32();
							continue;
						}
						if (num == 58U)
						{
							this.itemList_.AddEntriesFrom(ref input, RoleLevelUpViewResponse._repeated_itemList_codec);
							continue;
						}
					}
				}
				else if (num <= 82U)
				{
					if (num == 74U)
					{
						this.finalProp_.AddEntriesFrom(ref input, RoleLevelUpViewResponse._repeated_finalProp_codec);
						continue;
					}
					if (num == 82U)
					{
						this.overflowList_.AddEntriesFrom(ref input, RoleLevelUpViewResponse._repeated_overflowList_codec);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
					if (num == 98U)
					{
						this.levelExpInfo_.AddEntriesFrom(ref input, RoleLevelUpViewResponse._repeated_levelExpInfo_codec);
						continue;
					}
					if (num == 122U)
					{
						this.costList_.AddEntriesFrom(ref input, RoleLevelUpViewResponse._repeated_costList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400872E RID: 34606
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400872F RID: 34607
		public const int CodeFieldNumber = 2;

		// Token: 0x04008730 RID: 34608
		private ErrorCode code_;

		// Token: 0x04008731 RID: 34609
		public const int LevelFieldNumber = 11;

		// Token: 0x04008732 RID: 34610
		private int level_;

		// Token: 0x04008733 RID: 34611
		public const int LevelExpInfoFieldNumber = 12;

		// Token: 0x04008734 RID: 34612
		private static readonly FieldCodec<ArrayIntInt> _repeated_levelExpInfo_codec = FieldCodec.ForMessage<ArrayIntInt>(98U, ArrayIntInt.Parser);

		// Token: 0x04008735 RID: 34613
		private readonly RepeatedField<ArrayIntInt> levelExpInfo_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x04008736 RID: 34614
		public const int ExpFieldNumber = 1;

		// Token: 0x04008737 RID: 34615
		private int exp_;

		// Token: 0x04008738 RID: 34616
		public const int AddExpFieldNumber = 5;

		// Token: 0x04008739 RID: 34617
		private int addExp_;

		// Token: 0x0400873A RID: 34618
		public const int FinalPropFieldNumber = 9;

		// Token: 0x0400873B RID: 34619
		private static readonly FieldCodec<ArrayIntDouble> _repeated_finalProp_codec = FieldCodec.ForMessage<ArrayIntDouble>(74U, ArrayIntDouble.Parser);

		// Token: 0x0400873C RID: 34620
		private readonly RepeatedField<ArrayIntDouble> finalProp_ = new RepeatedField<ArrayIntDouble>();

		// Token: 0x0400873D RID: 34621
		public const int CostListFieldNumber = 15;

		// Token: 0x0400873E RID: 34622
		private static readonly FieldCodec<ArrayIntInt> _repeated_costList_codec = FieldCodec.ForMessage<ArrayIntInt>(122U, ArrayIntInt.Parser);

		// Token: 0x0400873F RID: 34623
		private readonly RepeatedField<ArrayIntInt> costList_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x04008740 RID: 34624
		public const int OverflowListFieldNumber = 10;

		// Token: 0x04008741 RID: 34625
		private static readonly FieldCodec<ArrayIntInt> _repeated_overflowList_codec = FieldCodec.ForMessage<ArrayIntInt>(82U, ArrayIntInt.Parser);

		// Token: 0x04008742 RID: 34626
		private readonly RepeatedField<ArrayIntInt> overflowList_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x04008743 RID: 34627
		public const int ItemListFieldNumber = 7;

		// Token: 0x04008744 RID: 34628
		private static readonly FieldCodec<ArrayIntInt> _repeated_itemList_codec = FieldCodec.ForMessage<ArrayIntInt>(58U, ArrayIntInt.Parser);

		// Token: 0x04008745 RID: 34629
		private readonly RepeatedField<ArrayIntInt> itemList_ = new RepeatedField<ArrayIntInt>();
	}
}
