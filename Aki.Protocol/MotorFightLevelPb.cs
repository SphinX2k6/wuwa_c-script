using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A37 RID: 2615
	public sealed class MotorFightLevelPb : IMessage<MotorFightLevelPb>, IMessage, IEquatable<MotorFightLevelPb>, IDeepCloneable<MotorFightLevelPb>, IBufferMessage
	{
		// Token: 0x0600E49D RID: 58525 RVA: 0x002170E2 File Offset: 0x002152E2
		[NullableContext(1)]
		public static MotorFightLevelPb Create()
		{
			return new MotorFightLevelPb();
		}

		// Token: 0x17002E54 RID: 11860
		// (get) Token: 0x0600E49E RID: 58526 RVA: 0x002170E9 File Offset: 0x002152E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightLevelPb> Parser
		{
			get
			{
				return MotorFightLevelPb._parser;
			}
		}

		// Token: 0x17002E55 RID: 11861
		// (get) Token: 0x0600E49F RID: 58527 RVA: 0x002170F0 File Offset: 0x002152F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E56 RID: 11862
		// (get) Token: 0x0600E4A0 RID: 58528 RVA: 0x002170F3 File Offset: 0x002152F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightLevelPb.Descriptor;
			}
		}

		// Token: 0x0600E4A1 RID: 58529 RVA: 0x002170FA File Offset: 0x002152FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLevelPb()
		{
		}

		// Token: 0x0600E4A2 RID: 58530 RVA: 0x00217104 File Offset: 0x00215304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLevelPb(MotorFightLevelPb other) : this()
		{
			this.levelId_ = other.levelId_;
			this.openTime_ = other.openTime_;
			this.cleared_ = other.cleared_;
			this.bestScore_ = other.bestScore_;
			this.lastRoleId_ = other.lastRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E4A3 RID: 58531 RVA: 0x00217164 File Offset: 0x00215364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLevelPb Clone()
		{
			return new MotorFightLevelPb(this);
		}

		// Token: 0x17002E57 RID: 11863
		// (get) Token: 0x0600E4A4 RID: 58532 RVA: 0x0021716C File Offset: 0x0021536C
		// (set) Token: 0x0600E4A5 RID: 58533 RVA: 0x00217174 File Offset: 0x00215374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17002E58 RID: 11864
		// (get) Token: 0x0600E4A6 RID: 58534 RVA: 0x0021717D File Offset: 0x0021537D
		// (set) Token: 0x0600E4A7 RID: 58535 RVA: 0x00217185 File Offset: 0x00215385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OpenTime
		{
			get
			{
				return this.openTime_;
			}
			set
			{
				this.openTime_ = value;
			}
		}

		// Token: 0x17002E59 RID: 11865
		// (get) Token: 0x0600E4A8 RID: 58536 RVA: 0x0021718E File Offset: 0x0021538E
		// (set) Token: 0x0600E4A9 RID: 58537 RVA: 0x00217196 File Offset: 0x00215396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Cleared
		{
			get
			{
				return this.cleared_;
			}
			set
			{
				this.cleared_ = value;
			}
		}

		// Token: 0x17002E5A RID: 11866
		// (get) Token: 0x0600E4AA RID: 58538 RVA: 0x0021719F File Offset: 0x0021539F
		// (set) Token: 0x0600E4AB RID: 58539 RVA: 0x002171A7 File Offset: 0x002153A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BestScore
		{
			get
			{
				return this.bestScore_;
			}
			set
			{
				this.bestScore_ = value;
			}
		}

		// Token: 0x17002E5B RID: 11867
		// (get) Token: 0x0600E4AC RID: 58540 RVA: 0x002171B0 File Offset: 0x002153B0
		// (set) Token: 0x0600E4AD RID: 58541 RVA: 0x002171B8 File Offset: 0x002153B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastRoleId
		{
			get
			{
				return this.lastRoleId_;
			}
			set
			{
				this.lastRoleId_ = value;
			}
		}

		// Token: 0x0600E4AE RID: 58542 RVA: 0x002171C1 File Offset: 0x002153C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightLevelPb);
		}

		// Token: 0x0600E4AF RID: 58543 RVA: 0x002171D0 File Offset: 0x002153D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightLevelPb other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.OpenTime == other.OpenTime && this.Cleared == other.Cleared && this.BestScore == other.BestScore && this.LastRoleId == other.LastRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E4B0 RID: 58544 RVA: 0x0021724C File Offset: 0x0021544C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.OpenTime != 0L)
			{
				num ^= this.OpenTime.GetHashCode();
			}
			if (this.Cleared)
			{
				num ^= this.Cleared.GetHashCode();
			}
			if (this.BestScore != 0)
			{
				num ^= this.BestScore.GetHashCode();
			}
			if (this.LastRoleId != 0)
			{
				num ^= this.LastRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E4B1 RID: 58545 RVA: 0x002172EF File Offset: 0x002154EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E4B2 RID: 58546 RVA: 0x002172FC File Offset: 0x002154FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E4B3 RID: 58547 RVA: 0x00217308 File Offset: 0x00215508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.OpenTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.OpenTime);
			}
			if (this.Cleared)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Cleared);
			}
			if (this.BestScore != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BestScore);
			}
			if (this.LastRoleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LastRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E4B4 RID: 58548 RVA: 0x002173B4 File Offset: 0x002155B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.OpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OpenTime);
			}
			if (this.Cleared)
			{
				num += 2;
			}
			if (this.BestScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BestScore);
			}
			if (this.LastRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E4B5 RID: 58549 RVA: 0x00217448 File Offset: 0x00215648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightLevelPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.OpenTime != 0L)
			{
				this.OpenTime = other.OpenTime;
			}
			if (other.Cleared)
			{
				this.Cleared = other.Cleared;
			}
			if (other.BestScore != 0)
			{
				this.BestScore = other.BestScore;
			}
			if (other.LastRoleId != 0)
			{
				this.LastRoleId = other.LastRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E4B6 RID: 58550 RVA: 0x002174D4 File Offset: 0x002156D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E4B7 RID: 58551 RVA: 0x002174E0 File Offset: 0x002156E0
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.LevelId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.OpenTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Cleared = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.BestScore = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.LastRoleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005DD8 RID: 24024
		private static readonly MessageParser<MotorFightLevelPb> _parser = new MessageParser<MotorFightLevelPb>(() => new MotorFightLevelPb());

		// Token: 0x04005DD9 RID: 24025
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DDA RID: 24026
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04005DDB RID: 24027
		private int levelId_;

		// Token: 0x04005DDC RID: 24028
		public const int OpenTimeFieldNumber = 2;

		// Token: 0x04005DDD RID: 24029
		private long openTime_;

		// Token: 0x04005DDE RID: 24030
		public const int ClearedFieldNumber = 3;

		// Token: 0x04005DDF RID: 24031
		private bool cleared_;

		// Token: 0x04005DE0 RID: 24032
		public const int BestScoreFieldNumber = 4;

		// Token: 0x04005DE1 RID: 24033
		private int bestScore_;

		// Token: 0x04005DE2 RID: 24034
		public const int LastRoleIdFieldNumber = 5;

		// Token: 0x04005DE3 RID: 24035
		private int lastRoleId_;
	}
}
