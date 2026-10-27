using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A48 RID: 2632
	public sealed class MotorFightLevelPb : IMessage<MotorFightLevelPb>, IMessage, IEquatable<MotorFightLevelPb>, IDeepCloneable<MotorFightLevelPb>, IBufferMessage
	{
		// Token: 0x0600E5B7 RID: 58807 RVA: 0x002192D6 File Offset: 0x002174D6
		[NullableContext(1)]
		public static MotorFightLevelPb Create()
		{
			return new MotorFightLevelPb();
		}

		// Token: 0x17002E92 RID: 11922
		// (get) Token: 0x0600E5B8 RID: 58808 RVA: 0x002192DD File Offset: 0x002174DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightLevelPb> Parser
		{
			get
			{
				return MotorFightLevelPb._parser;
			}
		}

		// Token: 0x17002E93 RID: 11923
		// (get) Token: 0x0600E5B9 RID: 58809 RVA: 0x002192E4 File Offset: 0x002174E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E94 RID: 11924
		// (get) Token: 0x0600E5BA RID: 58810 RVA: 0x002192E7 File Offset: 0x002174E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightLevelPb.Descriptor;
			}
		}

		// Token: 0x0600E5BB RID: 58811 RVA: 0x002192EE File Offset: 0x002174EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLevelPb()
		{
		}

		// Token: 0x0600E5BC RID: 58812 RVA: 0x002192F8 File Offset: 0x002174F8
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

		// Token: 0x0600E5BD RID: 58813 RVA: 0x00219358 File Offset: 0x00217558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLevelPb Clone()
		{
			return new MotorFightLevelPb(this);
		}

		// Token: 0x17002E95 RID: 11925
		// (get) Token: 0x0600E5BE RID: 58814 RVA: 0x00219360 File Offset: 0x00217560
		// (set) Token: 0x0600E5BF RID: 58815 RVA: 0x00219368 File Offset: 0x00217568
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

		// Token: 0x17002E96 RID: 11926
		// (get) Token: 0x0600E5C0 RID: 58816 RVA: 0x00219371 File Offset: 0x00217571
		// (set) Token: 0x0600E5C1 RID: 58817 RVA: 0x00219379 File Offset: 0x00217579
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

		// Token: 0x17002E97 RID: 11927
		// (get) Token: 0x0600E5C2 RID: 58818 RVA: 0x00219382 File Offset: 0x00217582
		// (set) Token: 0x0600E5C3 RID: 58819 RVA: 0x0021938A File Offset: 0x0021758A
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

		// Token: 0x17002E98 RID: 11928
		// (get) Token: 0x0600E5C4 RID: 58820 RVA: 0x00219393 File Offset: 0x00217593
		// (set) Token: 0x0600E5C5 RID: 58821 RVA: 0x0021939B File Offset: 0x0021759B
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

		// Token: 0x17002E99 RID: 11929
		// (get) Token: 0x0600E5C6 RID: 58822 RVA: 0x002193A4 File Offset: 0x002175A4
		// (set) Token: 0x0600E5C7 RID: 58823 RVA: 0x002193AC File Offset: 0x002175AC
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

		// Token: 0x0600E5C8 RID: 58824 RVA: 0x002193B5 File Offset: 0x002175B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightLevelPb);
		}

		// Token: 0x0600E5C9 RID: 58825 RVA: 0x002193C4 File Offset: 0x002175C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightLevelPb other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.OpenTime == other.OpenTime && this.Cleared == other.Cleared && this.BestScore == other.BestScore && this.LastRoleId == other.LastRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E5CA RID: 58826 RVA: 0x00219440 File Offset: 0x00217640
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

		// Token: 0x0600E5CB RID: 58827 RVA: 0x002194E3 File Offset: 0x002176E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E5CC RID: 58828 RVA: 0x002194F0 File Offset: 0x002176F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E5CD RID: 58829 RVA: 0x002194FC File Offset: 0x002176FC
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

		// Token: 0x0600E5CE RID: 58830 RVA: 0x002195A8 File Offset: 0x002177A8
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

		// Token: 0x0600E5CF RID: 58831 RVA: 0x0021963C File Offset: 0x0021783C
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

		// Token: 0x0600E5D0 RID: 58832 RVA: 0x002196C8 File Offset: 0x002178C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E5D1 RID: 58833 RVA: 0x002196D4 File Offset: 0x002178D4
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

		// Token: 0x04005DCF RID: 24015
		private static readonly MessageParser<MotorFightLevelPb> _parser = new MessageParser<MotorFightLevelPb>(() => new MotorFightLevelPb());

		// Token: 0x04005DD0 RID: 24016
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DD1 RID: 24017
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04005DD2 RID: 24018
		private int levelId_;

		// Token: 0x04005DD3 RID: 24019
		public const int OpenTimeFieldNumber = 2;

		// Token: 0x04005DD4 RID: 24020
		private long openTime_;

		// Token: 0x04005DD5 RID: 24021
		public const int ClearedFieldNumber = 3;

		// Token: 0x04005DD6 RID: 24022
		private bool cleared_;

		// Token: 0x04005DD7 RID: 24023
		public const int BestScoreFieldNumber = 4;

		// Token: 0x04005DD8 RID: 24024
		private int bestScore_;

		// Token: 0x04005DD9 RID: 24025
		public const int LastRoleIdFieldNumber = 5;

		// Token: 0x04005DDA RID: 24026
		private int lastRoleId_;
	}
}
