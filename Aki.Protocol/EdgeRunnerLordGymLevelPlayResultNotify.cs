using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200040D RID: 1037
	[NetMessage(EMessageId.EdgeRunnerLordGymLevelPlayResultNotify)]
	public sealed class EdgeRunnerLordGymLevelPlayResultNotify : IMessage<EdgeRunnerLordGymLevelPlayResultNotify>, IMessage, IEquatable<EdgeRunnerLordGymLevelPlayResultNotify>, IDeepCloneable<EdgeRunnerLordGymLevelPlayResultNotify>, IBufferMessage
	{
		// Token: 0x0600644D RID: 25677 RVA: 0x000F2004 File Offset: 0x000F0204
		[NullableContext(1)]
		public static EdgeRunnerLordGymLevelPlayResultNotify Create()
		{
			return new EdgeRunnerLordGymLevelPlayResultNotify();
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x0600644E RID: 25678 RVA: 0x000F200B File Offset: 0x000F020B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x0600644F RID: 25679 RVA: 0x000F200E File Offset: 0x000F020E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerLordGymLevelPlayResultNotify.Descriptor;
			}
		}

		// Token: 0x06006450 RID: 25680 RVA: 0x000F2015 File Offset: 0x000F0215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymLevelPlayResultNotify()
		{
		}

		// Token: 0x06006451 RID: 25681 RVA: 0x000F2028 File Offset: 0x000F0228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymLevelPlayResultNotify(EdgeRunnerLordGymLevelPlayResultNotify other) : this()
		{
			this.isSuccess_ = other.isSuccess_;
			this.isNewRecord_ = other.isNewRecord_;
			this.lordGymPassRecord_ = ((other.lordGymPassRecord_ != null) ? other.lordGymPassRecord_.Clone() : null);
			this.failLoadGymId_ = other.failLoadGymId_;
			this.itemDatas_ = other.itemDatas_.Clone();
			this.isPkgFull_ = other.isPkgFull_;
			this.passTime_ = other.passTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006452 RID: 25682 RVA: 0x000F20B5 File Offset: 0x000F02B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymLevelPlayResultNotify Clone()
		{
			return new EdgeRunnerLordGymLevelPlayResultNotify(this);
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06006453 RID: 25683 RVA: 0x000F20BD File Offset: 0x000F02BD
		// (set) Token: 0x06006454 RID: 25684 RVA: 0x000F20C5 File Offset: 0x000F02C5
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

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x06006455 RID: 25685 RVA: 0x000F20CE File Offset: 0x000F02CE
		// (set) Token: 0x06006456 RID: 25686 RVA: 0x000F20D6 File Offset: 0x000F02D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNewRecord
		{
			get
			{
				return this.isNewRecord_;
			}
			set
			{
				this.isNewRecord_ = value;
			}
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x06006457 RID: 25687 RVA: 0x000F20DF File Offset: 0x000F02DF
		// (set) Token: 0x06006458 RID: 25688 RVA: 0x000F20E7 File Offset: 0x000F02E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymPassRecord LordGymPassRecord
		{
			get
			{
				return this.lordGymPassRecord_;
			}
			set
			{
				this.lordGymPassRecord_ = value;
			}
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x06006459 RID: 25689 RVA: 0x000F20F0 File Offset: 0x000F02F0
		// (set) Token: 0x0600645A RID: 25690 RVA: 0x000F20F8 File Offset: 0x000F02F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FailLoadGymId
		{
			get
			{
				return this.failLoadGymId_;
			}
			set
			{
				this.failLoadGymId_ = value;
			}
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x0600645B RID: 25691 RVA: 0x000F2101 File Offset: 0x000F0301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemData> ItemDatas
		{
			get
			{
				return this.itemDatas_;
			}
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x0600645C RID: 25692 RVA: 0x000F2109 File Offset: 0x000F0309
		// (set) Token: 0x0600645D RID: 25693 RVA: 0x000F2111 File Offset: 0x000F0311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPkgFull
		{
			get
			{
				return this.isPkgFull_;
			}
			set
			{
				this.isPkgFull_ = value;
			}
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x0600645E RID: 25694 RVA: 0x000F211A File Offset: 0x000F031A
		// (set) Token: 0x0600645F RID: 25695 RVA: 0x000F2122 File Offset: 0x000F0322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassTime
		{
			get
			{
				return this.passTime_;
			}
			set
			{
				this.passTime_ = value;
			}
		}

		// Token: 0x06006460 RID: 25696 RVA: 0x000F212B File Offset: 0x000F032B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerLordGymLevelPlayResultNotify);
		}

		// Token: 0x06006461 RID: 25697 RVA: 0x000F213C File Offset: 0x000F033C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerLordGymLevelPlayResultNotify other)
		{
			return other != null && (other == this || (this.IsSuccess == other.IsSuccess && this.IsNewRecord == other.IsNewRecord && object.Equals(this.LordGymPassRecord, other.LordGymPassRecord) && this.FailLoadGymId == other.FailLoadGymId && this.itemDatas_.Equals(other.itemDatas_) && this.IsPkgFull == other.IsPkgFull && this.PassTime == other.PassTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006462 RID: 25698 RVA: 0x000F21E0 File Offset: 0x000F03E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsSuccess)
			{
				num ^= this.IsSuccess.GetHashCode();
			}
			if (this.IsNewRecord)
			{
				num ^= this.IsNewRecord.GetHashCode();
			}
			if (this.lordGymPassRecord_ != null)
			{
				num ^= this.LordGymPassRecord.GetHashCode();
			}
			if (this.FailLoadGymId != 0)
			{
				num ^= this.FailLoadGymId.GetHashCode();
			}
			num ^= this.itemDatas_.GetHashCode();
			if (this.IsPkgFull)
			{
				num ^= this.IsPkgFull.GetHashCode();
			}
			if (this.PassTime != 0)
			{
				num ^= this.PassTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006463 RID: 25699 RVA: 0x000F22A7 File Offset: 0x000F04A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006464 RID: 25700 RVA: 0x000F22B4 File Offset: 0x000F04B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006465 RID: 25701 RVA: 0x000F22C0 File Offset: 0x000F04C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemDatas_.WriteTo(ref output, EdgeRunnerLordGymLevelPlayResultNotify._repeated_itemDatas_codec);
			if (this.lordGymPassRecord_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.LordGymPassRecord);
			}
			if (this.IsPkgFull)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsPkgFull);
			}
			if (this.PassTime != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PassTime);
			}
			if (this.IsSuccess)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsSuccess);
			}
			if (this.IsNewRecord)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsNewRecord);
			}
			if (this.FailLoadGymId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.FailLoadGymId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006466 RID: 25702 RVA: 0x000F239C File Offset: 0x000F059C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsSuccess)
			{
				num += 2;
			}
			if (this.IsNewRecord)
			{
				num += 2;
			}
			if (this.lordGymPassRecord_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LordGymPassRecord);
			}
			if (this.FailLoadGymId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FailLoadGymId);
			}
			num += this.itemDatas_.CalculateSize(EdgeRunnerLordGymLevelPlayResultNotify._repeated_itemDatas_codec);
			if (this.IsPkgFull)
			{
				num += 2;
			}
			if (this.PassTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006467 RID: 25703 RVA: 0x000F2444 File Offset: 0x000F0644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerLordGymLevelPlayResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsSuccess)
			{
				this.IsSuccess = other.IsSuccess;
			}
			if (other.IsNewRecord)
			{
				this.IsNewRecord = other.IsNewRecord;
			}
			if (other.lordGymPassRecord_ != null)
			{
				if (this.lordGymPassRecord_ == null)
				{
					this.LordGymPassRecord = new EdgeRunnerLordGymPassRecord();
				}
				this.LordGymPassRecord.MergeFrom(other.LordGymPassRecord);
			}
			if (other.FailLoadGymId != 0)
			{
				this.FailLoadGymId = other.FailLoadGymId;
			}
			this.itemDatas_.Add(other.itemDatas_);
			if (other.IsPkgFull)
			{
				this.IsPkgFull = other.IsPkgFull;
			}
			if (other.PassTime != 0)
			{
				this.PassTime = other.PassTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006468 RID: 25704 RVA: 0x000F250D File Offset: 0x000F070D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006469 RID: 25705 RVA: 0x000F2518 File Offset: 0x000F0718
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
					if (num == 18U)
					{
						this.itemDatas_.AddEntriesFrom(ref input, EdgeRunnerLordGymLevelPlayResultNotify._repeated_itemDatas_codec);
						continue;
					}
					if (num == 26U)
					{
						if (this.lordGymPassRecord_ == null)
						{
							this.LordGymPassRecord = new EdgeRunnerLordGymPassRecord();
						}
						input.ReadMessage(this.LordGymPassRecord);
						continue;
					}
					if (num == 32U)
					{
						this.IsPkgFull = input.ReadBool();
						continue;
					}
				}
				else if (num <= 96U)
				{
					if (num == 64U)
					{
						this.PassTime = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.IsSuccess = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.IsNewRecord = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.FailLoadGymId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040038E6 RID: 14566
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038E7 RID: 14567
		public const int IsSuccessFieldNumber = 12;

		// Token: 0x040038E8 RID: 14568
		private bool isSuccess_;

		// Token: 0x040038E9 RID: 14569
		public const int IsNewRecordFieldNumber = 13;

		// Token: 0x040038EA RID: 14570
		private bool isNewRecord_;

		// Token: 0x040038EB RID: 14571
		public const int LordGymPassRecordFieldNumber = 3;

		// Token: 0x040038EC RID: 14572
		private EdgeRunnerLordGymPassRecord lordGymPassRecord_;

		// Token: 0x040038ED RID: 14573
		public const int FailLoadGymIdFieldNumber = 14;

		// Token: 0x040038EE RID: 14574
		private int failLoadGymId_;

		// Token: 0x040038EF RID: 14575
		public const int ItemDatasFieldNumber = 2;

		// Token: 0x040038F0 RID: 14576
		private static readonly FieldCodec<ItemData> _repeated_itemDatas_codec = FieldCodec.ForMessage<ItemData>(18U, ItemData.Parser);

		// Token: 0x040038F1 RID: 14577
		private readonly RepeatedField<ItemData> itemDatas_ = new RepeatedField<ItemData>();

		// Token: 0x040038F2 RID: 14578
		public const int IsPkgFullFieldNumber = 4;

		// Token: 0x040038F3 RID: 14579
		private bool isPkgFull_;

		// Token: 0x040038F4 RID: 14580
		public const int PassTimeFieldNumber = 8;

		// Token: 0x040038F5 RID: 14581
		private int passTime_;
	}
}
