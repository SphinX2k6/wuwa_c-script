using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A23 RID: 2595
	[NetMessage(EMessageId.MotorExpAddNotify)]
	public sealed class MotorExpAddNotify : IMessage<MotorExpAddNotify>, IMessage, IEquatable<MotorExpAddNotify>, IDeepCloneable<MotorExpAddNotify>, IBufferMessage
	{
		// Token: 0x0600E300 RID: 58112 RVA: 0x00213945 File Offset: 0x00211B45
		[NullableContext(1)]
		public static MotorExpAddNotify Create()
		{
			return new MotorExpAddNotify();
		}

		// Token: 0x17002DFC RID: 11772
		// (get) Token: 0x0600E301 RID: 58113 RVA: 0x0021394C File Offset: 0x00211B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DFD RID: 11773
		// (get) Token: 0x0600E302 RID: 58114 RVA: 0x0021394F File Offset: 0x00211B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorExpAddNotify.Descriptor;
			}
		}

		// Token: 0x0600E303 RID: 58115 RVA: 0x00213956 File Offset: 0x00211B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorExpAddNotify()
		{
		}

		// Token: 0x0600E304 RID: 58116 RVA: 0x00213960 File Offset: 0x00211B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorExpAddNotify(MotorExpAddNotify other) : this()
		{
			this.curExp_ = other.curExp_;
			this.addExp_ = other.addExp_;
			this.curLevel_ = other.curLevel_;
			this.motorExpLimitGainDaily_ = other.motorExpLimitGainDaily_;
			this.motorExpMonsterDropDailyLimit_ = other.motorExpMonsterDropDailyLimit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E305 RID: 58117 RVA: 0x002139C0 File Offset: 0x00211BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorExpAddNotify Clone()
		{
			return new MotorExpAddNotify(this);
		}

		// Token: 0x17002DFE RID: 11774
		// (get) Token: 0x0600E306 RID: 58118 RVA: 0x002139C8 File Offset: 0x00211BC8
		// (set) Token: 0x0600E307 RID: 58119 RVA: 0x002139D0 File Offset: 0x00211BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurExp
		{
			get
			{
				return this.curExp_;
			}
			set
			{
				this.curExp_ = value;
			}
		}

		// Token: 0x17002DFF RID: 11775
		// (get) Token: 0x0600E308 RID: 58120 RVA: 0x002139D9 File Offset: 0x00211BD9
		// (set) Token: 0x0600E309 RID: 58121 RVA: 0x002139E1 File Offset: 0x00211BE1
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

		// Token: 0x17002E00 RID: 11776
		// (get) Token: 0x0600E30A RID: 58122 RVA: 0x002139EA File Offset: 0x00211BEA
		// (set) Token: 0x0600E30B RID: 58123 RVA: 0x002139F2 File Offset: 0x00211BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurLevel
		{
			get
			{
				return this.curLevel_;
			}
			set
			{
				this.curLevel_ = value;
			}
		}

		// Token: 0x17002E01 RID: 11777
		// (get) Token: 0x0600E30C RID: 58124 RVA: 0x002139FB File Offset: 0x00211BFB
		// (set) Token: 0x0600E30D RID: 58125 RVA: 0x00213A03 File Offset: 0x00211C03
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

		// Token: 0x17002E02 RID: 11778
		// (get) Token: 0x0600E30E RID: 58126 RVA: 0x00213A0C File Offset: 0x00211C0C
		// (set) Token: 0x0600E30F RID: 58127 RVA: 0x00213A14 File Offset: 0x00211C14
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

		// Token: 0x0600E310 RID: 58128 RVA: 0x00213A1D File Offset: 0x00211C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorExpAddNotify);
		}

		// Token: 0x0600E311 RID: 58129 RVA: 0x00213A2C File Offset: 0x00211C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorExpAddNotify other)
		{
			return other != null && (other == this || (this.CurExp == other.CurExp && this.AddExp == other.AddExp && this.CurLevel == other.CurLevel && this.MotorExpLimitGainDaily == other.MotorExpLimitGainDaily && this.MotorExpMonsterDropDailyLimit == other.MotorExpMonsterDropDailyLimit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E312 RID: 58130 RVA: 0x00213AA8 File Offset: 0x00211CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurExp != 0)
			{
				num ^= this.CurExp.GetHashCode();
			}
			if (this.AddExp != 0)
			{
				num ^= this.AddExp.GetHashCode();
			}
			if (this.CurLevel != 0)
			{
				num ^= this.CurLevel.GetHashCode();
			}
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

		// Token: 0x0600E313 RID: 58131 RVA: 0x00213B4B File Offset: 0x00211D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E314 RID: 58132 RVA: 0x00213B58 File Offset: 0x00211D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E315 RID: 58133 RVA: 0x00213B64 File Offset: 0x00211D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MotorExpLimitGainDaily != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MotorExpLimitGainDaily);
			}
			if (this.CurExp != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.CurExp);
			}
			if (this.AddExp != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.AddExp);
			}
			if (this.CurLevel != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.CurLevel);
			}
			if (this.MotorExpMonsterDropDailyLimit != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.MotorExpMonsterDropDailyLimit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E316 RID: 58134 RVA: 0x00213C14 File Offset: 0x00211E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurExp);
			}
			if (this.AddExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AddExp);
			}
			if (this.CurLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurLevel);
			}
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

		// Token: 0x0600E317 RID: 58135 RVA: 0x00213CB4 File Offset: 0x00211EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorExpAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurExp != 0)
			{
				this.CurExp = other.CurExp;
			}
			if (other.AddExp != 0)
			{
				this.AddExp = other.AddExp;
			}
			if (other.CurLevel != 0)
			{
				this.CurLevel = other.CurLevel;
			}
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

		// Token: 0x0600E318 RID: 58136 RVA: 0x00213D40 File Offset: 0x00211F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E319 RID: 58137 RVA: 0x00213D4C File Offset: 0x00211F4C
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
				if (num <= 96U)
				{
					if (num == 32U)
					{
						this.MotorExpLimitGainDaily = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.CurExp = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.AddExp = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.CurLevel = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.MotorExpMonsterDropDailyLimit = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005D5F RID: 23903
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D60 RID: 23904
		public const int CurExpFieldNumber = 12;

		// Token: 0x04005D61 RID: 23905
		private int curExp_;

		// Token: 0x04005D62 RID: 23906
		public const int AddExpFieldNumber = 13;

		// Token: 0x04005D63 RID: 23907
		private int addExp_;

		// Token: 0x04005D64 RID: 23908
		public const int CurLevelFieldNumber = 14;

		// Token: 0x04005D65 RID: 23909
		private int curLevel_;

		// Token: 0x04005D66 RID: 23910
		public const int MotorExpLimitGainDailyFieldNumber = 4;

		// Token: 0x04005D67 RID: 23911
		private int motorExpLimitGainDaily_;

		// Token: 0x04005D68 RID: 23912
		public const int MotorExpMonsterDropDailyLimitFieldNumber = 15;

		// Token: 0x04005D69 RID: 23913
		private int motorExpMonsterDropDailyLimit_;
	}
}
