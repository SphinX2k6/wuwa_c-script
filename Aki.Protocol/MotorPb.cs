using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A89 RID: 2697
	public sealed class MotorPb : IMessage<MotorPb>, IMessage, IEquatable<MotorPb>, IDeepCloneable<MotorPb>, IBufferMessage
	{
		// Token: 0x0600EB30 RID: 60208 RVA: 0x00225B6F File Offset: 0x00223D6F
		[NullableContext(1)]
		public static MotorPb Create()
		{
			return new MotorPb();
		}

		// Token: 0x17002FBC RID: 12220
		// (get) Token: 0x0600EB31 RID: 60209 RVA: 0x00225B76 File Offset: 0x00223D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FBD RID: 12221
		// (get) Token: 0x0600EB32 RID: 60210 RVA: 0x00225B79 File Offset: 0x00223D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorPb.Descriptor;
			}
		}

		// Token: 0x0600EB33 RID: 60211 RVA: 0x00225B80 File Offset: 0x00223D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPb()
		{
		}

		// Token: 0x0600EB34 RID: 60212 RVA: 0x00225BA0 File Offset: 0x00223DA0
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

		// Token: 0x0600EB35 RID: 60213 RVA: 0x00225C2E File Offset: 0x00223E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPb Clone()
		{
			return new MotorPb(this);
		}

		// Token: 0x17002FBE RID: 12222
		// (get) Token: 0x0600EB36 RID: 60214 RVA: 0x00225C36 File Offset: 0x00223E36
		// (set) Token: 0x0600EB37 RID: 60215 RVA: 0x00225C3E File Offset: 0x00223E3E
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

		// Token: 0x17002FBF RID: 12223
		// (get) Token: 0x0600EB38 RID: 60216 RVA: 0x00225C47 File Offset: 0x00223E47
		// (set) Token: 0x0600EB39 RID: 60217 RVA: 0x00225C4F File Offset: 0x00223E4F
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

		// Token: 0x17002FC0 RID: 12224
		// (get) Token: 0x0600EB3A RID: 60218 RVA: 0x00225C58 File Offset: 0x00223E58
		// (set) Token: 0x0600EB3B RID: 60219 RVA: 0x00225C60 File Offset: 0x00223E60
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

		// Token: 0x17002FC1 RID: 12225
		// (get) Token: 0x0600EB3C RID: 60220 RVA: 0x00225C69 File Offset: 0x00223E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorTechOneTreePb> UnlockedTree
		{
			get
			{
				return this.unlockedTree_;
			}
		}

		// Token: 0x17002FC2 RID: 12226
		// (get) Token: 0x0600EB3D RID: 60221 RVA: 0x00225C71 File Offset: 0x00223E71
		// (set) Token: 0x0600EB3E RID: 60222 RVA: 0x00225C79 File Offset: 0x00223E79
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

		// Token: 0x17002FC3 RID: 12227
		// (get) Token: 0x0600EB3F RID: 60223 RVA: 0x00225C82 File Offset: 0x00223E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorTaskTreePb> TaskTrees
		{
			get
			{
				return this.taskTrees_;
			}
		}

		// Token: 0x17002FC4 RID: 12228
		// (get) Token: 0x0600EB40 RID: 60224 RVA: 0x00225C8A File Offset: 0x00223E8A
		// (set) Token: 0x0600EB41 RID: 60225 RVA: 0x00225C92 File Offset: 0x00223E92
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

		// Token: 0x17002FC5 RID: 12229
		// (get) Token: 0x0600EB42 RID: 60226 RVA: 0x00225C9B File Offset: 0x00223E9B
		// (set) Token: 0x0600EB43 RID: 60227 RVA: 0x00225CA3 File Offset: 0x00223EA3
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

		// Token: 0x0600EB44 RID: 60228 RVA: 0x00225CAC File Offset: 0x00223EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorPb);
		}

		// Token: 0x0600EB45 RID: 60229 RVA: 0x00225CBC File Offset: 0x00223EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorPb other)
		{
			return other != null && (other == this || (this.MotorLevel == other.MotorLevel && this.MotorExp == other.MotorExp && this.MotorRewardedLvMax == other.MotorRewardedLvMax && this.unlockedTree_.Equals(other.unlockedTree_) && this.TreeInUse == other.TreeInUse && this.taskTrees_.Equals(other.taskTrees_) && this.MotorExpLimitGainDaily == other.MotorExpLimitGainDaily && this.MotorExpMonsterDropDailyLimit == other.MotorExpMonsterDropDailyLimit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EB46 RID: 60230 RVA: 0x00225D70 File Offset: 0x00223F70
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

		// Token: 0x0600EB47 RID: 60231 RVA: 0x00225E48 File Offset: 0x00224048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EB48 RID: 60232 RVA: 0x00225E55 File Offset: 0x00224055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EB49 RID: 60233 RVA: 0x00225E60 File Offset: 0x00224060
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

		// Token: 0x0600EB4A RID: 60234 RVA: 0x00225F4C File Offset: 0x0022414C
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

		// Token: 0x0600EB4B RID: 60235 RVA: 0x00226028 File Offset: 0x00224228
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

		// Token: 0x0600EB4C RID: 60236 RVA: 0x002260EA File Offset: 0x002242EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EB4D RID: 60237 RVA: 0x002260F4 File Offset: 0x002242F4
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

		// Token: 0x04005FD5 RID: 24533
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FD6 RID: 24534
		public const int MotorLevelFieldNumber = 1;

		// Token: 0x04005FD7 RID: 24535
		private int motorLevel_;

		// Token: 0x04005FD8 RID: 24536
		public const int MotorExpFieldNumber = 2;

		// Token: 0x04005FD9 RID: 24537
		private int motorExp_;

		// Token: 0x04005FDA RID: 24538
		public const int MotorRewardedLvMaxFieldNumber = 3;

		// Token: 0x04005FDB RID: 24539
		private int motorRewardedLvMax_;

		// Token: 0x04005FDC RID: 24540
		public const int UnlockedTreeFieldNumber = 4;

		// Token: 0x04005FDD RID: 24541
		private static readonly FieldCodec<MotorTechOneTreePb> _repeated_unlockedTree_codec = FieldCodec.ForMessage<MotorTechOneTreePb>(34U, MotorTechOneTreePb.Parser);

		// Token: 0x04005FDE RID: 24542
		private readonly RepeatedField<MotorTechOneTreePb> unlockedTree_ = new RepeatedField<MotorTechOneTreePb>();

		// Token: 0x04005FDF RID: 24543
		public const int TreeInUseFieldNumber = 5;

		// Token: 0x04005FE0 RID: 24544
		private int treeInUse_;

		// Token: 0x04005FE1 RID: 24545
		public const int TaskTreesFieldNumber = 6;

		// Token: 0x04005FE2 RID: 24546
		private static readonly FieldCodec<MotorTaskTreePb> _repeated_taskTrees_codec = FieldCodec.ForMessage<MotorTaskTreePb>(50U, MotorTaskTreePb.Parser);

		// Token: 0x04005FE3 RID: 24547
		private readonly RepeatedField<MotorTaskTreePb> taskTrees_ = new RepeatedField<MotorTaskTreePb>();

		// Token: 0x04005FE4 RID: 24548
		public const int MotorExpLimitGainDailyFieldNumber = 7;

		// Token: 0x04005FE5 RID: 24549
		private int motorExpLimitGainDaily_;

		// Token: 0x04005FE6 RID: 24550
		public const int MotorExpMonsterDropDailyLimitFieldNumber = 8;

		// Token: 0x04005FE7 RID: 24551
		private int motorExpMonsterDropDailyLimit_;
	}
}
