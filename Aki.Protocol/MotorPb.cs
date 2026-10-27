using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A9A RID: 2714
	public sealed class MotorPb : IMessage<MotorPb>, IMessage, IEquatable<MotorPb>, IDeepCloneable<MotorPb>, IBufferMessage
	{
		// Token: 0x0600EC4A RID: 60490 RVA: 0x00227D67 File Offset: 0x00225F67
		[NullableContext(1)]
		public static MotorPb Create()
		{
			return new MotorPb();
		}

		// Token: 0x17002FFA RID: 12282
		// (get) Token: 0x0600EC4B RID: 60491 RVA: 0x00227D6E File Offset: 0x00225F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FFB RID: 12283
		// (get) Token: 0x0600EC4C RID: 60492 RVA: 0x00227D71 File Offset: 0x00225F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorPb.Descriptor;
			}
		}

		// Token: 0x0600EC4D RID: 60493 RVA: 0x00227D78 File Offset: 0x00225F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPb()
		{
		}

		// Token: 0x0600EC4E RID: 60494 RVA: 0x00227D98 File Offset: 0x00225F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPb(MotorPb other) : this()
		{
			this.motorLevel_ = other.motorLevel_;
			this.motorExp_ = other.motorExp_;
			this.motorRewardedLvMax_ = other.motorRewardedLvMax_;
			this.unlockedTree_ = other.unlockedTree_.Clone();
			this.treeInUse_ = other.treeInUse_;
			this.taskTrees_ = other.taskTrees_.Clone();
			this.motorExpLimitGainDaily_ = other.motorExpLimitGainDaily_;
			this.motorExpMonsterDropDailyLimit_ = other.motorExpMonsterDropDailyLimit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EC4F RID: 60495 RVA: 0x00227E26 File Offset: 0x00226026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPb Clone()
		{
			return new MotorPb(this);
		}

		// Token: 0x17002FFC RID: 12284
		// (get) Token: 0x0600EC50 RID: 60496 RVA: 0x00227E2E File Offset: 0x0022602E
		// (set) Token: 0x0600EC51 RID: 60497 RVA: 0x00227E36 File Offset: 0x00226036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MotorLevel
		{
			get
			{
				return this.motorLevel_;
			}
			set
			{
				this.motorLevel_ = value;
			}
		}

		// Token: 0x17002FFD RID: 12285
		// (get) Token: 0x0600EC52 RID: 60498 RVA: 0x00227E3F File Offset: 0x0022603F
		// (set) Token: 0x0600EC53 RID: 60499 RVA: 0x00227E47 File Offset: 0x00226047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MotorExp
		{
			get
			{
				return this.motorExp_;
			}
			set
			{
				this.motorExp_ = value;
			}
		}

		// Token: 0x17002FFE RID: 12286
		// (get) Token: 0x0600EC54 RID: 60500 RVA: 0x00227E50 File Offset: 0x00226050
		// (set) Token: 0x0600EC55 RID: 60501 RVA: 0x00227E58 File Offset: 0x00226058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MotorRewardedLvMax
		{
			get
			{
				return this.motorRewardedLvMax_;
			}
			set
			{
				this.motorRewardedLvMax_ = value;
			}
		}

		// Token: 0x17002FFF RID: 12287
		// (get) Token: 0x0600EC56 RID: 60502 RVA: 0x00227E61 File Offset: 0x00226061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorTechOneTreePb> UnlockedTree
		{
			get
			{
				return this.unlockedTree_;
			}
		}

		// Token: 0x17003000 RID: 12288
		// (get) Token: 0x0600EC57 RID: 60503 RVA: 0x00227E69 File Offset: 0x00226069
		// (set) Token: 0x0600EC58 RID: 60504 RVA: 0x00227E71 File Offset: 0x00226071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeInUse
		{
			get
			{
				return this.treeInUse_;
			}
			set
			{
				this.treeInUse_ = value;
			}
		}

		// Token: 0x17003001 RID: 12289
		// (get) Token: 0x0600EC59 RID: 60505 RVA: 0x00227E7A File Offset: 0x0022607A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorTaskTreePb> TaskTrees
		{
			get
			{
				return this.taskTrees_;
			}
		}

		// Token: 0x17003002 RID: 12290
		// (get) Token: 0x0600EC5A RID: 60506 RVA: 0x00227E82 File Offset: 0x00226082
		// (set) Token: 0x0600EC5B RID: 60507 RVA: 0x00227E8A File Offset: 0x0022608A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MotorExpLimitGainDaily
		{
			get
			{
				return this.motorExpLimitGainDaily_;
			}
			set
			{
				this.motorExpLimitGainDaily_ = value;
			}
		}

		// Token: 0x17003003 RID: 12291
		// (get) Token: 0x0600EC5C RID: 60508 RVA: 0x00227E93 File Offset: 0x00226093
		// (set) Token: 0x0600EC5D RID: 60509 RVA: 0x00227E9B File Offset: 0x0022609B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MotorExpMonsterDropDailyLimit
		{
			get
			{
				return this.motorExpMonsterDropDailyLimit_;
			}
			set
			{
				this.motorExpMonsterDropDailyLimit_ = value;
			}
		}

		// Token: 0x0600EC5E RID: 60510 RVA: 0x00227EA4 File Offset: 0x002260A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorPb);
		}

		// Token: 0x0600EC5F RID: 60511 RVA: 0x00227EB4 File Offset: 0x002260B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorPb other)
		{
			return other != null && (other == this || (this.MotorLevel == other.MotorLevel && this.MotorExp == other.MotorExp && this.MotorRewardedLvMax == other.MotorRewardedLvMax && this.unlockedTree_.Equals(other.unlockedTree_) && this.TreeInUse == other.TreeInUse && this.taskTrees_.Equals(other.taskTrees_) && this.MotorExpLimitGainDaily == other.MotorExpLimitGainDaily && this.MotorExpMonsterDropDailyLimit == other.MotorExpMonsterDropDailyLimit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EC60 RID: 60512 RVA: 0x00227F68 File Offset: 0x00226168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MotorLevel != 0)
			{
				num ^= this.MotorLevel.GetHashCode();
			}
			if (this.MotorExp != 0)
			{
				num ^= this.MotorExp.GetHashCode();
			}
			if (this.MotorRewardedLvMax != 0)
			{
				num ^= this.MotorRewardedLvMax.GetHashCode();
			}
			num ^= this.unlockedTree_.GetHashCode();
			if (this.TreeInUse != 0)
			{
				num ^= this.TreeInUse.GetHashCode();
			}
			num ^= this.taskTrees_.GetHashCode();
			if (this.MotorExpLimitGainDaily != 0)
			{
				num ^= this.MotorExpLimitGainDaily.GetHashCode();
			}
			if (this.MotorExpMonsterDropDailyLimit != 0)
			{
				num ^= this.MotorExpMonsterDropDailyLimit.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EC61 RID: 60513 RVA: 0x00228040 File Offset: 0x00226240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EC62 RID: 60514 RVA: 0x0022804D File Offset: 0x0022624D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EC63 RID: 60515 RVA: 0x00228058 File Offset: 0x00226258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MotorLevel != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MotorLevel);
			}
			if (this.MotorExp != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MotorExp);
			}
			if (this.MotorRewardedLvMax != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MotorRewardedLvMax);
			}
			this.unlockedTree_.WriteTo(ref output, MotorPb._repeated_unlockedTree_codec);
			if (this.TreeInUse != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TreeInUse);
			}
			this.taskTrees_.WriteTo(ref output, MotorPb._repeated_taskTrees_codec);
			if (this.MotorExpLimitGainDaily != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MotorExpLimitGainDaily);
			}
			if (this.MotorExpMonsterDropDailyLimit != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.MotorExpMonsterDropDailyLimit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EC64 RID: 60516 RVA: 0x00228144 File Offset: 0x00226344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MotorLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MotorLevel);
			}
			if (this.MotorExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MotorExp);
			}
			if (this.MotorRewardedLvMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MotorRewardedLvMax);
			}
			num += this.unlockedTree_.CalculateSize(MotorPb._repeated_unlockedTree_codec);
			if (this.TreeInUse != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeInUse);
			}
			num += this.taskTrees_.CalculateSize(MotorPb._repeated_taskTrees_codec);
			if (this.MotorExpLimitGainDaily != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MotorExpLimitGainDaily);
			}
			if (this.MotorExpMonsterDropDailyLimit != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MotorExpMonsterDropDailyLimit);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EC65 RID: 60517 RVA: 0x00228220 File Offset: 0x00226420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MotorLevel != 0)
			{
				this.MotorLevel = other.MotorLevel;
			}
			if (other.MotorExp != 0)
			{
				this.MotorExp = other.MotorExp;
			}
			if (other.MotorRewardedLvMax != 0)
			{
				this.MotorRewardedLvMax = other.MotorRewardedLvMax;
			}
			this.unlockedTree_.Add(other.unlockedTree_);
			if (other.TreeInUse != 0)
			{
				this.TreeInUse = other.TreeInUse;
			}
			this.taskTrees_.Add(other.taskTrees_);
			if (other.MotorExpLimitGainDaily != 0)
			{
				this.MotorExpLimitGainDaily = other.MotorExpLimitGainDaily;
			}
			if (other.MotorExpMonsterDropDailyLimit != 0)
			{
				this.MotorExpMonsterDropDailyLimit = other.MotorExpMonsterDropDailyLimit;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EC66 RID: 60518 RVA: 0x002282E2 File Offset: 0x002264E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EC67 RID: 60519 RVA: 0x002282EC File Offset: 0x002264EC
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
				if (num <= 34U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.MotorLevel = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.MotorExp = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.MotorRewardedLvMax = input.ReadInt32();
							continue;
						}
						if (num == 34U)
						{
							this.unlockedTree_.AddEntriesFrom(ref input, MotorPb._repeated_unlockedTree_codec);
							continue;
						}
					}
				}
				else if (num <= 50U)
				{
					if (num == 40U)
					{
						this.TreeInUse = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						this.taskTrees_.AddEntriesFrom(ref input, MotorPb._repeated_taskTrees_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.MotorExpLimitGainDaily = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.MotorExpMonsterDropDailyLimit = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005FCC RID: 24524
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FCD RID: 24525
		public const int MotorLevelFieldNumber = 1;

		// Token: 0x04005FCE RID: 24526
		private int motorLevel_;

		// Token: 0x04005FCF RID: 24527
		public const int MotorExpFieldNumber = 2;

		// Token: 0x04005FD0 RID: 24528
		private int motorExp_;

		// Token: 0x04005FD1 RID: 24529
		public const int MotorRewardedLvMaxFieldNumber = 3;

		// Token: 0x04005FD2 RID: 24530
		private int motorRewardedLvMax_;

		// Token: 0x04005FD3 RID: 24531
		public const int UnlockedTreeFieldNumber = 4;

		// Token: 0x04005FD4 RID: 24532
		private static readonly FieldCodec<MotorTechOneTreePb> _repeated_unlockedTree_codec = FieldCodec.ForMessage<MotorTechOneTreePb>(34U, MotorTechOneTreePb.Parser);

		// Token: 0x04005FD5 RID: 24533
		private readonly RepeatedField<MotorTechOneTreePb> unlockedTree_ = new RepeatedField<MotorTechOneTreePb>();

		// Token: 0x04005FD6 RID: 24534
		public const int TreeInUseFieldNumber = 5;

		// Token: 0x04005FD7 RID: 24535
		private int treeInUse_;

		// Token: 0x04005FD8 RID: 24536
		public const int TaskTreesFieldNumber = 6;

		// Token: 0x04005FD9 RID: 24537
		private static readonly FieldCodec<MotorTaskTreePb> _repeated_taskTrees_codec = FieldCodec.ForMessage<MotorTaskTreePb>(50U, MotorTaskTreePb.Parser);

		// Token: 0x04005FDA RID: 24538
		private readonly RepeatedField<MotorTaskTreePb> taskTrees_ = new RepeatedField<MotorTaskTreePb>();

		// Token: 0x04005FDB RID: 24539
		public const int MotorExpLimitGainDailyFieldNumber = 7;

		// Token: 0x04005FDC RID: 24540
		private int motorExpLimitGainDaily_;

		// Token: 0x04005FDD RID: 24541
		public const int MotorExpMonsterDropDailyLimitFieldNumber = 8;

		// Token: 0x04005FDE RID: 24542
		private int motorExpMonsterDropDailyLimit_;
	}
}
