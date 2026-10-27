using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000424 RID: 1060
	[NetMessage(EMessageId.EdgeRunnerLordGymLevelPlayResultNotify)]
	public sealed class EdgeRunnerLordGymLevelPlayResultNotify : IMessage<EdgeRunnerLordGymLevelPlayResultNotify>, IMessage, IEquatable<EdgeRunnerLordGymLevelPlayResultNotify>, IDeepCloneable<EdgeRunnerLordGymLevelPlayResultNotify>, IBufferMessage
	{
		// Token: 0x060065DD RID: 26077 RVA: 0x000F5178 File Offset: 0x000F3378
		[NullableContext(1)]
		public static EdgeRunnerLordGymLevelPlayResultNotify Create()
		{
			return new EdgeRunnerLordGymLevelPlayResultNotify();
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x060065DE RID: 26078 RVA: 0x000F517F File Offset: 0x000F337F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x060065DF RID: 26079 RVA: 0x000F5182 File Offset: 0x000F3382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerLordGymLevelPlayResultNotify.Descriptor;
			}
		}

		// Token: 0x060065E0 RID: 26080 RVA: 0x000F5189 File Offset: 0x000F3389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymLevelPlayResultNotify()
		{
		}

		// Token: 0x060065E1 RID: 26081 RVA: 0x000F519C File Offset: 0x000F339C
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

		// Token: 0x060065E2 RID: 26082 RVA: 0x000F5229 File Offset: 0x000F3429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymLevelPlayResultNotify Clone()
		{
			return new EdgeRunnerLordGymLevelPlayResultNotify(this);
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x060065E3 RID: 26083 RVA: 0x000F5231 File Offset: 0x000F3431
		// (set) Token: 0x060065E4 RID: 26084 RVA: 0x000F5239 File Offset: 0x000F3439
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

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x060065E5 RID: 26085 RVA: 0x000F5242 File Offset: 0x000F3442
		// (set) Token: 0x060065E6 RID: 26086 RVA: 0x000F524A File Offset: 0x000F344A
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

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x060065E7 RID: 26087 RVA: 0x000F5253 File Offset: 0x000F3453
		// (set) Token: 0x060065E8 RID: 26088 RVA: 0x000F525B File Offset: 0x000F345B
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

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x060065E9 RID: 26089 RVA: 0x000F5264 File Offset: 0x000F3464
		// (set) Token: 0x060065EA RID: 26090 RVA: 0x000F526C File Offset: 0x000F346C
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

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x060065EB RID: 26091 RVA: 0x000F5275 File Offset: 0x000F3475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemData> ItemDatas
		{
			get
			{
				return this.itemDatas_;
			}
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x060065EC RID: 26092 RVA: 0x000F527D File Offset: 0x000F347D
		// (set) Token: 0x060065ED RID: 26093 RVA: 0x000F5285 File Offset: 0x000F3485
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

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x060065EE RID: 26094 RVA: 0x000F528E File Offset: 0x000F348E
		// (set) Token: 0x060065EF RID: 26095 RVA: 0x000F5296 File Offset: 0x000F3496
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

		// Token: 0x060065F0 RID: 26096 RVA: 0x000F529F File Offset: 0x000F349F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerLordGymLevelPlayResultNotify);
		}

		// Token: 0x060065F1 RID: 26097 RVA: 0x000F52B0 File Offset: 0x000F34B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerLordGymLevelPlayResultNotify other)
		{
			return other != null && (other == this || (this.IsSuccess == other.IsSuccess && this.IsNewRecord == other.IsNewRecord && object.Equals(this.LordGymPassRecord, other.LordGymPassRecord) && this.FailLoadGymId == other.FailLoadGymId && this.itemDatas_.Equals(other.itemDatas_) && this.IsPkgFull == other.IsPkgFull && this.PassTime == other.PassTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060065F2 RID: 26098 RVA: 0x000F5354 File Offset: 0x000F3554
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

		// Token: 0x060065F3 RID: 26099 RVA: 0x000F541B File Offset: 0x000F361B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060065F4 RID: 26100 RVA: 0x000F5428 File Offset: 0x000F3628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060065F5 RID: 26101 RVA: 0x000F5434 File Offset: 0x000F3634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsPkgFull)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsPkgFull);
			}
			if (this.IsNewRecord)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsNewRecord);
			}
			if (this.IsSuccess)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsSuccess);
			}
			if (this.lordGymPassRecord_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.LordGymPassRecord);
			}
			if (this.PassTime != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PassTime);
			}
			if (this.FailLoadGymId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.FailLoadGymId);
			}
			this.itemDatas_.WriteTo(ref output, EdgeRunnerLordGymLevelPlayResultNotify._repeated_itemDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060065F6 RID: 26102 RVA: 0x000F5510 File Offset: 0x000F3710
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

		// Token: 0x060065F7 RID: 26103 RVA: 0x000F55B8 File Offset: 0x000F37B8
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

		// Token: 0x060065F8 RID: 26104 RVA: 0x000F5681 File Offset: 0x000F3881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060065F9 RID: 26105 RVA: 0x000F568C File Offset: 0x000F388C
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
				if (num <= 72U)
				{
					if (num == 48U)
					{
						this.IsPkgFull = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.IsNewRecord = input.ReadBool();
						continue;
					}
					if (num == 72U)
					{
						this.IsSuccess = input.ReadBool();
						continue;
					}
				}
				else if (num <= 88U)
				{
					if (num == 82U)
					{
						if (this.lordGymPassRecord_ == null)
						{
							this.LordGymPassRecord = new EdgeRunnerLordGymPassRecord();
						}
						input.ReadMessage(this.LordGymPassRecord);
						continue;
					}
					if (num == 88U)
					{
						this.PassTime = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.FailLoadGymId = input.ReadInt32();
						continue;
					}
					if (num == 106U)
					{
						this.itemDatas_.AddEntriesFrom(ref input, EdgeRunnerLordGymLevelPlayResultNotify._repeated_itemDatas_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040038F9 RID: 14585
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038FA RID: 14586
		public const int IsSuccessFieldNumber = 9;

		// Token: 0x040038FB RID: 14587
		private bool isSuccess_;

		// Token: 0x040038FC RID: 14588
		public const int IsNewRecordFieldNumber = 8;

		// Token: 0x040038FD RID: 14589
		private bool isNewRecord_;

		// Token: 0x040038FE RID: 14590
		public const int LordGymPassRecordFieldNumber = 10;

		// Token: 0x040038FF RID: 14591
		private EdgeRunnerLordGymPassRecord lordGymPassRecord_;

		// Token: 0x04003900 RID: 14592
		public const int FailLoadGymIdFieldNumber = 12;

		// Token: 0x04003901 RID: 14593
		private int failLoadGymId_;

		// Token: 0x04003902 RID: 14594
		public const int ItemDatasFieldNumber = 13;

		// Token: 0x04003903 RID: 14595
		private static readonly FieldCodec<ItemData> _repeated_itemDatas_codec = FieldCodec.ForMessage<ItemData>(106U, ItemData.Parser);

		// Token: 0x04003904 RID: 14596
		private readonly RepeatedField<ItemData> itemDatas_ = new RepeatedField<ItemData>();

		// Token: 0x04003905 RID: 14597
		public const int IsPkgFullFieldNumber = 6;

		// Token: 0x04003906 RID: 14598
		private bool isPkgFull_;

		// Token: 0x04003907 RID: 14599
		public const int PassTimeFieldNumber = 11;

		// Token: 0x04003908 RID: 14600
		private int passTime_;
	}
}
