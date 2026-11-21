using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000768 RID: 1896
	[NetMessage(EMessageId.HonamiStoryInstSettleNotify)]
	public sealed class HonamiStoryInstSettleNotify : IMessage<HonamiStoryInstSettleNotify>, IMessage, IEquatable<HonamiStoryInstSettleNotify>, IDeepCloneable<HonamiStoryInstSettleNotify>, IBufferMessage
	{
		// Token: 0x0600ABC6 RID: 43974 RVA: 0x0019D6CD File Offset: 0x0019B8CD
		[NullableContext(1)]
		public static HonamiStoryInstSettleNotify Create()
		{
			return new HonamiStoryInstSettleNotify();
		}

		// Token: 0x1700229C RID: 8860
		// (get) Token: 0x0600ABC7 RID: 43975 RVA: 0x0019D6D4 File Offset: 0x0019B8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700229D RID: 8861
		// (get) Token: 0x0600ABC8 RID: 43976 RVA: 0x0019D6D7 File Offset: 0x0019B8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryInstSettleNotify.Descriptor;
			}
		}

		// Token: 0x0600ABC9 RID: 43977 RVA: 0x0019D6DE File Offset: 0x0019B8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstSettleNotify()
		{
		}

		// Token: 0x0600ABCA RID: 43978 RVA: 0x0019D6E8 File Offset: 0x0019B8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstSettleNotify(HonamiStoryInstSettleNotify other) : this()
		{
			this.isSuccess_ = other.isSuccess_;
			this.useTime_ = other.useTime_;
			this.talentAdd_ = other.talentAdd_;
			this.totalValue_ = other.totalValue_;
			this.isUpdateTotalValue_ = other.isUpdateTotalValue_;
			this.itemTotalValue_ = other.itemTotalValue_;
			this.failAddProportion_ = other.failAddProportion_;
			this.isDeadSettle_ = other.isDeadSettle_;
			this.innerCoin_ = other.innerCoin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ABCB RID: 43979 RVA: 0x0019D778 File Offset: 0x0019B978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstSettleNotify Clone()
		{
			return new HonamiStoryInstSettleNotify(this);
		}

		// Token: 0x1700229E RID: 8862
		// (get) Token: 0x0600ABCC RID: 43980 RVA: 0x0019D780 File Offset: 0x0019B980
		// (set) Token: 0x0600ABCD RID: 43981 RVA: 0x0019D788 File Offset: 0x0019B988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuccess
		{
			get
			{
				return this.isSuccess_;
			}
			set
			{
				this.isSuccess_ = value;
			}
		}

		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x0600ABCE RID: 43982 RVA: 0x0019D791 File Offset: 0x0019B991
		// (set) Token: 0x0600ABCF RID: 43983 RVA: 0x0019D799 File Offset: 0x0019B999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseTime
		{
			get
			{
				return this.useTime_;
			}
			set
			{
				this.useTime_ = value;
			}
		}

		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x0600ABD0 RID: 43984 RVA: 0x0019D7A2 File Offset: 0x0019B9A2
		// (set) Token: 0x0600ABD1 RID: 43985 RVA: 0x0019D7AA File Offset: 0x0019B9AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TalentAdd
		{
			get
			{
				return this.talentAdd_;
			}
			set
			{
				this.talentAdd_ = value;
			}
		}

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x0600ABD2 RID: 43986 RVA: 0x0019D7B3 File Offset: 0x0019B9B3
		// (set) Token: 0x0600ABD3 RID: 43987 RVA: 0x0019D7BB File Offset: 0x0019B9BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalValue
		{
			get
			{
				return this.totalValue_;
			}
			set
			{
				this.totalValue_ = value;
			}
		}

		// Token: 0x170022A2 RID: 8866
		// (get) Token: 0x0600ABD4 RID: 43988 RVA: 0x0019D7C4 File Offset: 0x0019B9C4
		// (set) Token: 0x0600ABD5 RID: 43989 RVA: 0x0019D7CC File Offset: 0x0019B9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUpdateTotalValue
		{
			get
			{
				return this.isUpdateTotalValue_;
			}
			set
			{
				this.isUpdateTotalValue_ = value;
			}
		}

		// Token: 0x170022A3 RID: 8867
		// (get) Token: 0x0600ABD6 RID: 43990 RVA: 0x0019D7D5 File Offset: 0x0019B9D5
		// (set) Token: 0x0600ABD7 RID: 43991 RVA: 0x0019D7DD File Offset: 0x0019B9DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemTotalValue
		{
			get
			{
				return this.itemTotalValue_;
			}
			set
			{
				this.itemTotalValue_ = value;
			}
		}

		// Token: 0x170022A4 RID: 8868
		// (get) Token: 0x0600ABD8 RID: 43992 RVA: 0x0019D7E6 File Offset: 0x0019B9E6
		// (set) Token: 0x0600ABD9 RID: 43993 RVA: 0x0019D7EE File Offset: 0x0019B9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FailAddProportion
		{
			get
			{
				return this.failAddProportion_;
			}
			set
			{
				this.failAddProportion_ = value;
			}
		}

		// Token: 0x170022A5 RID: 8869
		// (get) Token: 0x0600ABDA RID: 43994 RVA: 0x0019D7F7 File Offset: 0x0019B9F7
		// (set) Token: 0x0600ABDB RID: 43995 RVA: 0x0019D7FF File Offset: 0x0019B9FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDeadSettle
		{
			get
			{
				return this.isDeadSettle_;
			}
			set
			{
				this.isDeadSettle_ = value;
			}
		}

		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x0600ABDC RID: 43996 RVA: 0x0019D808 File Offset: 0x0019BA08
		// (set) Token: 0x0600ABDD RID: 43997 RVA: 0x0019D810 File Offset: 0x0019BA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InnerCoin
		{
			get
			{
				return this.innerCoin_;
			}
			set
			{
				this.innerCoin_ = value;
			}
		}

		// Token: 0x0600ABDE RID: 43998 RVA: 0x0019D819 File Offset: 0x0019BA19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryInstSettleNotify);
		}

		// Token: 0x0600ABDF RID: 43999 RVA: 0x0019D828 File Offset: 0x0019BA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryInstSettleNotify other)
		{
			return other != null && (other == this || (this.IsSuccess == other.IsSuccess && this.UseTime == other.UseTime && this.TalentAdd == other.TalentAdd && this.TotalValue == other.TotalValue && this.IsUpdateTotalValue == other.IsUpdateTotalValue && this.ItemTotalValue == other.ItemTotalValue && this.FailAddProportion == other.FailAddProportion && this.IsDeadSettle == other.IsDeadSettle && this.InnerCoin == other.InnerCoin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ABE0 RID: 44000 RVA: 0x0019D8E4 File Offset: 0x0019BAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsSuccess)
			{
				num ^= this.IsSuccess.GetHashCode();
			}
			if (this.UseTime != 0)
			{
				num ^= this.UseTime.GetHashCode();
			}
			if (this.TalentAdd != 0)
			{
				num ^= this.TalentAdd.GetHashCode();
			}
			if (this.TotalValue != 0)
			{
				num ^= this.TotalValue.GetHashCode();
			}
			if (this.IsUpdateTotalValue)
			{
				num ^= this.IsUpdateTotalValue.GetHashCode();
			}
			if (this.ItemTotalValue != 0)
			{
				num ^= this.ItemTotalValue.GetHashCode();
			}
			if (this.FailAddProportion != 0)
			{
				num ^= this.FailAddProportion.GetHashCode();
			}
			if (this.IsDeadSettle)
			{
				num ^= this.IsDeadSettle.GetHashCode();
			}
			if (this.InnerCoin != 0)
			{
				num ^= this.InnerCoin.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ABE1 RID: 44001 RVA: 0x0019D9EB File Offset: 0x0019BBEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ABE2 RID: 44002 RVA: 0x0019D9F8 File Offset: 0x0019BBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ABE3 RID: 44003 RVA: 0x0019DA04 File Offset: 0x0019BC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalentAdd != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TalentAdd);
			}
			if (this.UseTime != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.UseTime);
			}
			if (this.FailAddProportion != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.FailAddProportion);
			}
			if (this.IsDeadSettle)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsDeadSettle);
			}
			if (this.ItemTotalValue != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ItemTotalValue);
			}
			if (this.IsSuccess)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsSuccess);
			}
			if (this.TotalValue != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TotalValue);
			}
			if (this.IsUpdateTotalValue)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsUpdateTotalValue);
			}
			if (this.InnerCoin != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.InnerCoin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ABE4 RID: 44004 RVA: 0x0019DB20 File Offset: 0x0019BD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsSuccess)
			{
				num += 2;
			}
			if (this.UseTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseTime);
			}
			if (this.TalentAdd != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TalentAdd);
			}
			if (this.TotalValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalValue);
			}
			if (this.IsUpdateTotalValue)
			{
				num += 2;
			}
			if (this.ItemTotalValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemTotalValue);
			}
			if (this.FailAddProportion != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FailAddProportion);
			}
			if (this.IsDeadSettle)
			{
				num += 2;
			}
			if (this.InnerCoin != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InnerCoin);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ABE5 RID: 44005 RVA: 0x0019DBFC File Offset: 0x0019BDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryInstSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsSuccess)
			{
				this.IsSuccess = other.IsSuccess;
			}
			if (other.UseTime != 0)
			{
				this.UseTime = other.UseTime;
			}
			if (other.TalentAdd != 0)
			{
				this.TalentAdd = other.TalentAdd;
			}
			if (other.TotalValue != 0)
			{
				this.TotalValue = other.TotalValue;
			}
			if (other.IsUpdateTotalValue)
			{
				this.IsUpdateTotalValue = other.IsUpdateTotalValue;
			}
			if (other.ItemTotalValue != 0)
			{
				this.ItemTotalValue = other.ItemTotalValue;
			}
			if (other.FailAddProportion != 0)
			{
				this.FailAddProportion = other.FailAddProportion;
			}
			if (other.IsDeadSettle)
			{
				this.IsDeadSettle = other.IsDeadSettle;
			}
			if (other.InnerCoin != 0)
			{
				this.InnerCoin = other.InnerCoin;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ABE6 RID: 44006 RVA: 0x0019DCD8 File Offset: 0x0019BED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ABE7 RID: 44007 RVA: 0x0019DCE4 File Offset: 0x0019BEE4
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
				if (num <= 64U)
				{
					if (num <= 48U)
					{
						if (num == 8U)
						{
							this.TalentAdd = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.UseTime = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.FailAddProportion = input.ReadInt32();
							continue;
						}
						if (num == 64U)
						{
							this.IsDeadSettle = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 72U)
					{
						this.ItemTotalValue = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.IsSuccess = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.TotalValue = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.IsUpdateTotalValue = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.InnerCoin = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004E48 RID: 20040
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E49 RID: 20041
		public const int IsSuccessFieldNumber = 10;

		// Token: 0x04004E4A RID: 20042
		private bool isSuccess_;

		// Token: 0x04004E4B RID: 20043
		public const int UseTimeFieldNumber = 6;

		// Token: 0x04004E4C RID: 20044
		private int useTime_;

		// Token: 0x04004E4D RID: 20045
		public const int TalentAddFieldNumber = 1;

		// Token: 0x04004E4E RID: 20046
		private int talentAdd_;

		// Token: 0x04004E4F RID: 20047
		public const int TotalValueFieldNumber = 11;

		// Token: 0x04004E50 RID: 20048
		private int totalValue_;

		// Token: 0x04004E51 RID: 20049
		public const int IsUpdateTotalValueFieldNumber = 14;

		// Token: 0x04004E52 RID: 20050
		private bool isUpdateTotalValue_;

		// Token: 0x04004E53 RID: 20051
		public const int ItemTotalValueFieldNumber = 9;

		// Token: 0x04004E54 RID: 20052
		private int itemTotalValue_;

		// Token: 0x04004E55 RID: 20053
		public const int FailAddProportionFieldNumber = 7;

		// Token: 0x04004E56 RID: 20054
		private int failAddProportion_;

		// Token: 0x04004E57 RID: 20055
		public const int IsDeadSettleFieldNumber = 8;

		// Token: 0x04004E58 RID: 20056
		private bool isDeadSettle_;

		// Token: 0x04004E59 RID: 20057
		public const int InnerCoinFieldNumber = 15;

		// Token: 0x04004E5A RID: 20058
		private int innerCoin_;
	}
}
