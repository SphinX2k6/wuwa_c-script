using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B8 RID: 5304
	public sealed class UseSkillInformation : IMessage<UseSkillInformation>, IMessage, IEquatable<UseSkillInformation>, IDeepCloneable<UseSkillInformation>, IBufferMessage
	{
		// Token: 0x0601C0BD RID: 114877 RVA: 0x0040DA6B File Offset: 0x0040BC6B
		[NullableContext(1)]
		public static UseSkillInformation Create()
		{
			return new UseSkillInformation();
		}

		// Token: 0x17005E83 RID: 24195
		// (get) Token: 0x0601C0BE RID: 114878 RVA: 0x0040DA72 File Offset: 0x0040BC72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E84 RID: 24196
		// (get) Token: 0x0601C0BF RID: 114879 RVA: 0x0040DA75 File Offset: 0x0040BC75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseSkillInformation.Descriptor;
			}
		}

		// Token: 0x0601C0C0 RID: 114880 RVA: 0x0040DA7C File Offset: 0x0040BC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillInformation()
		{
		}

		// Token: 0x0601C0C1 RID: 114881 RVA: 0x0040DA84 File Offset: 0x0040BC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillInformation(UseSkillInformation other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.id_ = other.id_;
			this.skillId_ = other.skillId_;
			this.movementInformation_ = ((other.movementInformation_ != null) ? other.movementInformation_.Clone() : null);
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.targetId_ = other.targetId_;
			this.timeStamp_ = other.timeStamp_;
			this.isSpecialSkill_ = other.isSpecialSkill_;
			this.duration_ = other.duration_;
			this.skillInterruptLevel_ = other.skillInterruptLevel_;
			this.fightState_ = other.fightState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C0C2 RID: 114882 RVA: 0x0040DB5C File Offset: 0x0040BD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillInformation Clone()
		{
			return new UseSkillInformation(this);
		}

		// Token: 0x17005E85 RID: 24197
		// (get) Token: 0x0601C0C3 RID: 114883 RVA: 0x0040DB64 File Offset: 0x0040BD64
		// (set) Token: 0x0601C0C4 RID: 114884 RVA: 0x0040DB6C File Offset: 0x0040BD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x17005E86 RID: 24198
		// (get) Token: 0x0601C0C5 RID: 114885 RVA: 0x0040DB75 File Offset: 0x0040BD75
		// (set) Token: 0x0601C0C6 RID: 114886 RVA: 0x0040DB7D File Offset: 0x0040BD7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17005E87 RID: 24199
		// (get) Token: 0x0601C0C7 RID: 114887 RVA: 0x0040DB86 File Offset: 0x0040BD86
		// (set) Token: 0x0601C0C8 RID: 114888 RVA: 0x0040DB8E File Offset: 0x0040BD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17005E88 RID: 24200
		// (get) Token: 0x0601C0C9 RID: 114889 RVA: 0x0040DB97 File Offset: 0x0040BD97
		// (set) Token: 0x0601C0CA RID: 114890 RVA: 0x0040DB9F File Offset: 0x0040BD9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovementInformation MovementInformation
		{
			get
			{
				return this.movementInformation_;
			}
			set
			{
				this.movementInformation_ = value;
			}
		}

		// Token: 0x17005E89 RID: 24201
		// (get) Token: 0x0601C0CB RID: 114891 RVA: 0x0040DBA8 File Offset: 0x0040BDA8
		// (set) Token: 0x0601C0CC RID: 114892 RVA: 0x0040DBB0 File Offset: 0x0040BDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x17005E8A RID: 24202
		// (get) Token: 0x0601C0CD RID: 114893 RVA: 0x0040DBB9 File Offset: 0x0040BDB9
		// (set) Token: 0x0601C0CE RID: 114894 RVA: 0x0040DBC1 File Offset: 0x0040BDC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x17005E8B RID: 24203
		// (get) Token: 0x0601C0CF RID: 114895 RVA: 0x0040DBCA File Offset: 0x0040BDCA
		// (set) Token: 0x0601C0D0 RID: 114896 RVA: 0x0040DBD2 File Offset: 0x0040BDD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float TimeStamp
		{
			get
			{
				return this.timeStamp_;
			}
			set
			{
				this.timeStamp_ = value;
			}
		}

		// Token: 0x17005E8C RID: 24204
		// (get) Token: 0x0601C0D1 RID: 114897 RVA: 0x0040DBDB File Offset: 0x0040BDDB
		// (set) Token: 0x0601C0D2 RID: 114898 RVA: 0x0040DBE3 File Offset: 0x0040BDE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSpecialSkill
		{
			get
			{
				return this.isSpecialSkill_;
			}
			set
			{
				this.isSpecialSkill_ = value;
			}
		}

		// Token: 0x17005E8D RID: 24205
		// (get) Token: 0x0601C0D3 RID: 114899 RVA: 0x0040DBEC File Offset: 0x0040BDEC
		// (set) Token: 0x0601C0D4 RID: 114900 RVA: 0x0040DBF4 File Offset: 0x0040BDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Duration
		{
			get
			{
				return this.duration_;
			}
			set
			{
				this.duration_ = value;
			}
		}

		// Token: 0x17005E8E RID: 24206
		// (get) Token: 0x0601C0D5 RID: 114901 RVA: 0x0040DBFD File Offset: 0x0040BDFD
		// (set) Token: 0x0601C0D6 RID: 114902 RVA: 0x0040DC05 File Offset: 0x0040BE05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillInterruptLevel
		{
			get
			{
				return this.skillInterruptLevel_;
			}
			set
			{
				this.skillInterruptLevel_ = value;
			}
		}

		// Token: 0x17005E8F RID: 24207
		// (get) Token: 0x0601C0D7 RID: 114903 RVA: 0x0040DC0E File Offset: 0x0040BE0E
		// (set) Token: 0x0601C0D8 RID: 114904 RVA: 0x0040DC16 File Offset: 0x0040BE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FightState
		{
			get
			{
				return this.fightState_;
			}
			set
			{
				this.fightState_ = value;
			}
		}

		// Token: 0x0601C0D9 RID: 114905 RVA: 0x0040DC1F File Offset: 0x0040BE1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseSkillInformation);
		}

		// Token: 0x0601C0DA RID: 114906 RVA: 0x0040DC30 File Offset: 0x0040BE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseSkillInformation other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.SkillId == other.SkillId && object.Equals(this.MovementInformation, other.MovementInformation) && object.Equals(this.Location, other.Location) && this.TargetId == other.TargetId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeStamp, other.TimeStamp) && this.IsSpecialSkill == other.IsSpecialSkill && this.Duration == other.Duration && this.SkillInterruptLevel == other.SkillInterruptLevel && this.FightState == other.FightState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C0DB RID: 114907 RVA: 0x0040DD24 File Offset: 0x0040BF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.movementInformation_ != null)
			{
				num ^= this.MovementInformation.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.TargetId != 0L)
			{
				num ^= this.TargetId.GetHashCode();
			}
			if (this.TimeStamp != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.TimeStamp);
			}
			if (this.IsSpecialSkill)
			{
				num ^= this.IsSpecialSkill.GetHashCode();
			}
			if (this.Duration != 0)
			{
				num ^= this.Duration.GetHashCode();
			}
			if (this.SkillInterruptLevel != 0)
			{
				num ^= this.SkillInterruptLevel.GetHashCode();
			}
			if (this.FightState != 0)
			{
				num ^= this.FightState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C0DC RID: 114908 RVA: 0x0040DE5B File Offset: 0x0040C05B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C0DD RID: 114909 RVA: 0x0040DE68 File Offset: 0x0040C068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C0DE RID: 114910 RVA: 0x0040DE74 File Offset: 0x0040C074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.Id);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.SkillId);
			}
			if (this.movementInformation_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.MovementInformation);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Location);
			}
			if (this.TargetId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.TargetId);
			}
			if (this.TimeStamp != 0f)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.TimeStamp);
			}
			if (this.IsSpecialSkill)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsSpecialSkill);
			}
			if (this.Duration != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Duration);
			}
			if (this.SkillInterruptLevel != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SkillInterruptLevel);
			}
			if (this.FightState != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.FightState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C0DF RID: 114911 RVA: 0x0040DFD0 File Offset: 0x0040C1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this.movementInformation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MovementInformation);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.TargetId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetId);
			}
			if (this.TimeStamp != 0f)
			{
				num += 5;
			}
			if (this.IsSpecialSkill)
			{
				num += 2;
			}
			if (this.Duration != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Duration);
			}
			if (this.SkillInterruptLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillInterruptLevel);
			}
			if (this.FightState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FightState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C0E0 RID: 114912 RVA: 0x0040E0EC File Offset: 0x0040C2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseSkillInformation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			if (other.movementInformation_ != null)
			{
				if (this.movementInformation_ == null)
				{
					this.MovementInformation = new MovementInformation();
				}
				this.MovementInformation.MergeFrom(other.MovementInformation);
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			if (other.TargetId != 0L)
			{
				this.TargetId = other.TargetId;
			}
			if (other.TimeStamp != 0f)
			{
				this.TimeStamp = other.TimeStamp;
			}
			if (other.IsSpecialSkill)
			{
				this.IsSpecialSkill = other.IsSpecialSkill;
			}
			if (other.Duration != 0)
			{
				this.Duration = other.Duration;
			}
			if (other.SkillInterruptLevel != 0)
			{
				this.SkillInterruptLevel = other.SkillInterruptLevel;
			}
			if (other.FightState != 0)
			{
				this.FightState = other.FightState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C0E1 RID: 114913 RVA: 0x0040E23D File Offset: 0x0040C43D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C0E2 RID: 114914 RVA: 0x0040E248 File Offset: 0x0040C448
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
				if (num <= 42U)
				{
					if (num <= 16U)
					{
						if (num == 10U)
						{
							if (this.combatCommon_ == null)
							{
								this.CombatCommon = new CombatCommon();
							}
							input.ReadMessage(this.CombatCommon);
							continue;
						}
						if (num == 16U)
						{
							this.Id = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.SkillId = input.ReadInt64();
							continue;
						}
						if (num == 34U)
						{
							if (this.movementInformation_ == null)
							{
								this.MovementInformation = new MovementInformation();
							}
							input.ReadMessage(this.MovementInformation);
							continue;
						}
						if (num == 42U)
						{
							if (this.location_ == null)
							{
								this.Location = new Vector();
							}
							input.ReadMessage(this.Location);
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 48U)
					{
						this.TargetId = input.ReadInt64();
						continue;
					}
					if (num == 61U)
					{
						this.TimeStamp = input.ReadFloat();
						continue;
					}
					if (num == 64U)
					{
						this.IsSpecialSkill = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Duration = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.SkillInterruptLevel = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.FightState = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A108 RID: 41224
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A109 RID: 41225
		public const int CombatCommonFieldNumber = 1;

		// Token: 0x0400A10A RID: 41226
		private CombatCommon combatCommon_;

		// Token: 0x0400A10B RID: 41227
		public const int IdFieldNumber = 2;

		// Token: 0x0400A10C RID: 41228
		private long id_;

		// Token: 0x0400A10D RID: 41229
		public const int SkillIdFieldNumber = 3;

		// Token: 0x0400A10E RID: 41230
		private long skillId_;

		// Token: 0x0400A10F RID: 41231
		public const int MovementInformationFieldNumber = 4;

		// Token: 0x0400A110 RID: 41232
		private MovementInformation movementInformation_;

		// Token: 0x0400A111 RID: 41233
		public const int LocationFieldNumber = 5;

		// Token: 0x0400A112 RID: 41234
		private Vector location_;

		// Token: 0x0400A113 RID: 41235
		public const int TargetIdFieldNumber = 6;

		// Token: 0x0400A114 RID: 41236
		private long targetId_;

		// Token: 0x0400A115 RID: 41237
		public const int TimeStampFieldNumber = 7;

		// Token: 0x0400A116 RID: 41238
		private float timeStamp_;

		// Token: 0x0400A117 RID: 41239
		public const int IsSpecialSkillFieldNumber = 8;

		// Token: 0x0400A118 RID: 41240
		private bool isSpecialSkill_;

		// Token: 0x0400A119 RID: 41241
		public const int DurationFieldNumber = 9;

		// Token: 0x0400A11A RID: 41242
		private int duration_;

		// Token: 0x0400A11B RID: 41243
		public const int SkillInterruptLevelFieldNumber = 10;

		// Token: 0x0400A11C RID: 41244
		private int skillInterruptLevel_;

		// Token: 0x0400A11D RID: 41245
		public const int FightStateFieldNumber = 11;

		// Token: 0x0400A11E RID: 41246
		private int fightState_;
	}
}
