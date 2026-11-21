using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001000 RID: 4096
	[NetMessage(EMessageId.RogueResTeamLevelUpdateNotify)]
	public sealed class RogueResTeamLevelUpdateNotify : IMessage<RogueResTeamLevelUpdateNotify>, IMessage, IEquatable<RogueResTeamLevelUpdateNotify>, IDeepCloneable<RogueResTeamLevelUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015EDE RID: 89822 RVA: 0x00330C14 File Offset: 0x0032EE14
		[NullableContext(1)]
		public static RogueResTeamLevelUpdateNotify Create()
		{
			return new RogueResTeamLevelUpdateNotify();
		}

		// Token: 0x17004950 RID: 18768
		// (get) Token: 0x06015EDF RID: 89823 RVA: 0x00330C1B File Offset: 0x0032EE1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004951 RID: 18769
		// (get) Token: 0x06015EE0 RID: 89824 RVA: 0x00330C1E File Offset: 0x0032EE1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResTeamLevelUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015EE1 RID: 89825 RVA: 0x00330C25 File Offset: 0x0032EE25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTeamLevelUpdateNotify()
		{
		}

		// Token: 0x06015EE2 RID: 89826 RVA: 0x00330C2D File Offset: 0x0032EE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTeamLevelUpdateNotify(RogueResTeamLevelUpdateNotify other) : this()
		{
			this.teamLevel_ = other.teamLevel_;
			this.roleLevel_ = other.roleLevel_;
			this.eventType_ = other.eventType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015EE3 RID: 89827 RVA: 0x00330C6A File Offset: 0x0032EE6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTeamLevelUpdateNotify Clone()
		{
			return new RogueResTeamLevelUpdateNotify(this);
		}

		// Token: 0x17004952 RID: 18770
		// (get) Token: 0x06015EE4 RID: 89828 RVA: 0x00330C72 File Offset: 0x0032EE72
		// (set) Token: 0x06015EE5 RID: 89829 RVA: 0x00330C7A File Offset: 0x0032EE7A
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

		// Token: 0x17004953 RID: 18771
		// (get) Token: 0x06015EE6 RID: 89830 RVA: 0x00330C83 File Offset: 0x0032EE83
		// (set) Token: 0x06015EE7 RID: 89831 RVA: 0x00330C8B File Offset: 0x0032EE8B
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

		// Token: 0x17004954 RID: 18772
		// (get) Token: 0x06015EE8 RID: 89832 RVA: 0x00330C94 File Offset: 0x0032EE94
		// (set) Token: 0x06015EE9 RID: 89833 RVA: 0x00330C9C File Offset: 0x0032EE9C
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

		// Token: 0x06015EEA RID: 89834 RVA: 0x00330CA5 File Offset: 0x0032EEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResTeamLevelUpdateNotify);
		}

		// Token: 0x06015EEB RID: 89835 RVA: 0x00330CB4 File Offset: 0x0032EEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResTeamLevelUpdateNotify other)
		{
			return other != null && (other == this || (this.TeamLevel == other.TeamLevel && this.RoleLevel == other.RoleLevel && this.EventType == other.EventType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015EEC RID: 89836 RVA: 0x00330D10 File Offset: 0x0032EF10
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

		// Token: 0x06015EED RID: 89837 RVA: 0x00330D81 File Offset: 0x0032EF81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015EEE RID: 89838 RVA: 0x00330D8E File Offset: 0x0032EF8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015EEF RID: 89839 RVA: 0x00330D98 File Offset: 0x0032EF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventType != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.EventType);
			}
			if (this.TeamLevel != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TeamLevel);
			}
			if (this.RoleLevel != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.RoleLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015EF0 RID: 89840 RVA: 0x00330E10 File Offset: 0x0032F010
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

		// Token: 0x06015EF1 RID: 89841 RVA: 0x00330E80 File Offset: 0x0032F080
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

		// Token: 0x06015EF2 RID: 89842 RVA: 0x00330EE4 File Offset: 0x0032F0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015EF3 RID: 89843 RVA: 0x00330EF0 File Offset: 0x0032F0F0
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
				if (num != 48U)
				{
					if (num != 56U)
					{
						if (num != 120U)
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
						this.TeamLevel = input.ReadInt32();
					}
				}
				else
				{
					this.EventType = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008409 RID: 33801
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400840A RID: 33802
		public const int TeamLevelFieldNumber = 7;

		// Token: 0x0400840B RID: 33803
		private int teamLevel_;

		// Token: 0x0400840C RID: 33804
		public const int RoleLevelFieldNumber = 15;

		// Token: 0x0400840D RID: 33805
		private int roleLevel_;

		// Token: 0x0400840E RID: 33806
		public const int EventTypeFieldNumber = 6;

		// Token: 0x0400840F RID: 33807
		private int eventType_;
	}
}
