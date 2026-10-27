using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A34 RID: 2612
	[NetMessage(EMessageId.MotorExpAddNotify)]
	public sealed class MotorExpAddNotify : IMessage<MotorExpAddNotify>, IMessage, IEquatable<MotorExpAddNotify>, IDeepCloneable<MotorExpAddNotify>, IBufferMessage
	{
		// Token: 0x0600E41A RID: 58394 RVA: 0x00215B35 File Offset: 0x00213D35
		[NullableContext(1)]
		public static MotorExpAddNotify Create()
		{
			return new MotorExpAddNotify();
		}

		// Token: 0x17002E3A RID: 11834
		// (get) Token: 0x0600E41B RID: 58395 RVA: 0x00215B3C File Offset: 0x00213D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E3B RID: 11835
		// (get) Token: 0x0600E41C RID: 58396 RVA: 0x00215B3F File Offset: 0x00213D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorExpAddNotify.Descriptor;
			}
		}

		// Token: 0x0600E41D RID: 58397 RVA: 0x00215B46 File Offset: 0x00213D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorExpAddNotify()
		{
		}

		// Token: 0x0600E41E RID: 58398 RVA: 0x00215B50 File Offset: 0x00213D50
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

		// Token: 0x0600E41F RID: 58399 RVA: 0x00215BB0 File Offset: 0x00213DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorExpAddNotify Clone()
		{
			return new MotorExpAddNotify(this);
		}

		// Token: 0x17002E3C RID: 11836
		// (get) Token: 0x0600E420 RID: 58400 RVA: 0x00215BB8 File Offset: 0x00213DB8
		// (set) Token: 0x0600E421 RID: 58401 RVA: 0x00215BC0 File Offset: 0x00213DC0
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

		// Token: 0x17002E3D RID: 11837
		// (get) Token: 0x0600E422 RID: 58402 RVA: 0x00215BC9 File Offset: 0x00213DC9
		// (set) Token: 0x0600E423 RID: 58403 RVA: 0x00215BD1 File Offset: 0x00213DD1
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

		// Token: 0x17002E3E RID: 11838
		// (get) Token: 0x0600E424 RID: 58404 RVA: 0x00215BDA File Offset: 0x00213DDA
		// (set) Token: 0x0600E425 RID: 58405 RVA: 0x00215BE2 File Offset: 0x00213DE2
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

		// Token: 0x17002E3F RID: 11839
		// (get) Token: 0x0600E426 RID: 58406 RVA: 0x00215BEB File Offset: 0x00213DEB
		// (set) Token: 0x0600E427 RID: 58407 RVA: 0x00215BF3 File Offset: 0x00213DF3
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

		// Token: 0x17002E40 RID: 11840
		// (get) Token: 0x0600E428 RID: 58408 RVA: 0x00215BFC File Offset: 0x00213DFC
		// (set) Token: 0x0600E429 RID: 58409 RVA: 0x00215C04 File Offset: 0x00213E04
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

		// Token: 0x0600E42A RID: 58410 RVA: 0x00215C0D File Offset: 0x00213E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorExpAddNotify);
		}

		// Token: 0x0600E42B RID: 58411 RVA: 0x00215C1C File Offset: 0x00213E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorExpAddNotify other)
		{
			return other != null && (other == this || (this.CurExp == other.CurExp && this.AddExp == other.AddExp && this.CurLevel == other.CurLevel && this.MotorExpLimitGainDaily == other.MotorExpLimitGainDaily && this.MotorExpMonsterDropDailyLimit == other.MotorExpMonsterDropDailyLimit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E42C RID: 58412 RVA: 0x00215C98 File Offset: 0x00213E98
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

		// Token: 0x0600E42D RID: 58413 RVA: 0x00215D3B File Offset: 0x00213F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E42E RID: 58414 RVA: 0x00215D48 File Offset: 0x00213F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E42F RID: 58415 RVA: 0x00215D54 File Offset: 0x00213F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MotorExpLimitGainDaily != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MotorExpLimitGainDaily);
			}
			if (this.MotorExpMonsterDropDailyLimit != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MotorExpMonsterDropDailyLimit);
			}
			if (this.CurExp != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CurExp);
			}
			if (this.AddExp != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.AddExp);
			}
			if (this.CurLevel != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.CurLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E430 RID: 58416 RVA: 0x00215E04 File Offset: 0x00214004
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

		// Token: 0x0600E431 RID: 58417 RVA: 0x00215EA4 File Offset: 0x002140A4
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

		// Token: 0x0600E432 RID: 58418 RVA: 0x00215F30 File Offset: 0x00214130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E433 RID: 58419 RVA: 0x00215F3C File Offset: 0x0021413C
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
				if (num <= 40U)
				{
					if (num == 16U)
					{
						this.MotorExpLimitGainDaily = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.MotorExpMonsterDropDailyLimit = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.CurExp = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.AddExp = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.CurLevel = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005D56 RID: 23894
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D57 RID: 23895
		public const int CurExpFieldNumber = 7;

		// Token: 0x04005D58 RID: 23896
		private int curExp_;

		// Token: 0x04005D59 RID: 23897
		public const int AddExpFieldNumber = 10;

		// Token: 0x04005D5A RID: 23898
		private int addExp_;

		// Token: 0x04005D5B RID: 23899
		public const int CurLevelFieldNumber = 14;

		// Token: 0x04005D5C RID: 23900
		private int curLevel_;

		// Token: 0x04005D5D RID: 23901
		public const int MotorExpLimitGainDailyFieldNumber = 2;

		// Token: 0x04005D5E RID: 23902
		private int motorExpLimitGainDaily_;

		// Token: 0x04005D5F RID: 23903
		public const int MotorExpMonsterDropDailyLimitFieldNumber = 5;

		// Token: 0x04005D60 RID: 23904
		private int motorExpMonsterDropDailyLimit_;
	}
}
