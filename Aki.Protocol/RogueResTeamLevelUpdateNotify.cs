using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001010 RID: 4112
	[NetMessage(EMessageId.RogueResTeamLevelUpdateNotify)]
	public sealed class RogueResTeamLevelUpdateNotify : IMessage<RogueResTeamLevelUpdateNotify>, IMessage, IEquatable<RogueResTeamLevelUpdateNotify>, IDeepCloneable<RogueResTeamLevelUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015FC3 RID: 90051 RVA: 0x003322D0 File Offset: 0x003304D0
		[NullableContext(1)]
		public static RogueResTeamLevelUpdateNotify Create()
		{
			return new RogueResTeamLevelUpdateNotify();
		}

		// Token: 0x1700497A RID: 18810
		// (get) Token: 0x06015FC4 RID: 90052 RVA: 0x003322D7 File Offset: 0x003304D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700497B RID: 18811
		// (get) Token: 0x06015FC5 RID: 90053 RVA: 0x003322DA File Offset: 0x003304DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResTeamLevelUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015FC6 RID: 90054 RVA: 0x003322E1 File Offset: 0x003304E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTeamLevelUpdateNotify()
		{
		}

		// Token: 0x06015FC7 RID: 90055 RVA: 0x003322E9 File Offset: 0x003304E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTeamLevelUpdateNotify(RogueResTeamLevelUpdateNotify other) : this()
		{
			this.teamLevel_ = other.teamLevel_;
			this.roleLevel_ = other.roleLevel_;
			this.eventType_ = other.eventType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015FC8 RID: 90056 RVA: 0x00332326 File Offset: 0x00330526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTeamLevelUpdateNotify Clone()
		{
			return new RogueResTeamLevelUpdateNotify(this);
		}

		// Token: 0x1700497C RID: 18812
		// (get) Token: 0x06015FC9 RID: 90057 RVA: 0x0033232E File Offset: 0x0033052E
		// (set) Token: 0x06015FCA RID: 90058 RVA: 0x00332336 File Offset: 0x00330536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TeamLevel
		{
			get
			{
				return this.teamLevel_;
			}
			set
			{
				this.teamLevel_ = value;
			}
		}

		// Token: 0x1700497D RID: 18813
		// (get) Token: 0x06015FCB RID: 90059 RVA: 0x0033233F File Offset: 0x0033053F
		// (set) Token: 0x06015FCC RID: 90060 RVA: 0x00332347 File Offset: 0x00330547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleLevel
		{
			get
			{
				return this.roleLevel_;
			}
			set
			{
				this.roleLevel_ = value;
			}
		}

		// Token: 0x1700497E RID: 18814
		// (get) Token: 0x06015FCD RID: 90061 RVA: 0x00332350 File Offset: 0x00330550
		// (set) Token: 0x06015FCE RID: 90062 RVA: 0x00332358 File Offset: 0x00330558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventType
		{
			get
			{
				return this.eventType_;
			}
			set
			{
				this.eventType_ = value;
			}
		}

		// Token: 0x06015FCF RID: 90063 RVA: 0x00332361 File Offset: 0x00330561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResTeamLevelUpdateNotify);
		}

		// Token: 0x06015FD0 RID: 90064 RVA: 0x00332370 File Offset: 0x00330570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResTeamLevelUpdateNotify other)
		{
			return other != null && (other == this || (this.TeamLevel == other.TeamLevel && this.RoleLevel == other.RoleLevel && this.EventType == other.EventType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015FD1 RID: 90065 RVA: 0x003323CC File Offset: 0x003305CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TeamLevel != 0)
			{
				num ^= this.TeamLevel.GetHashCode();
			}
			if (this.RoleLevel != 0)
			{
				num ^= this.RoleLevel.GetHashCode();
			}
			if (this.EventType != 0)
			{
				num ^= this.EventType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015FD2 RID: 90066 RVA: 0x0033243D File Offset: 0x0033063D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015FD3 RID: 90067 RVA: 0x0033244A File Offset: 0x0033064A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015FD4 RID: 90068 RVA: 0x00332454 File Offset: 0x00330654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TeamLevel != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TeamLevel);
			}
			if (this.EventType != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.EventType);
			}
			if (this.RoleLevel != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RoleLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015FD5 RID: 90069 RVA: 0x003324CC File Offset: 0x003306CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TeamLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TeamLevel);
			}
			if (this.RoleLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleLevel);
			}
			if (this.EventType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015FD6 RID: 90070 RVA: 0x0033253C File Offset: 0x0033073C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResTeamLevelUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TeamLevel != 0)
			{
				this.TeamLevel = other.TeamLevel;
			}
			if (other.RoleLevel != 0)
			{
				this.RoleLevel = other.RoleLevel;
			}
			if (other.EventType != 0)
			{
				this.EventType = other.EventType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015FD7 RID: 90071 RVA: 0x003325A0 File Offset: 0x003307A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015FD8 RID: 90072 RVA: 0x003325AC File Offset: 0x003307AC
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
				if (num != 40U)
				{
					if (num != 56U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RoleLevel = input.ReadInt32();
						}
					}
					else
					{
						this.EventType = input.ReadInt32();
					}
				}
				else
				{
					this.TeamLevel = input.ReadInt32();
				}
			}
		}

		// Token: 0x040083DF RID: 33759
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083E0 RID: 33760
		public const int TeamLevelFieldNumber = 5;

		// Token: 0x040083E1 RID: 33761
		private int teamLevel_;

		// Token: 0x040083E2 RID: 33762
		public const int RoleLevelFieldNumber = 11;

		// Token: 0x040083E3 RID: 33763
		private int roleLevel_;

		// Token: 0x040083E4 RID: 33764
		public const int EventTypeFieldNumber = 7;

		// Token: 0x040083E5 RID: 33765
		private int eventType_;
	}
}
