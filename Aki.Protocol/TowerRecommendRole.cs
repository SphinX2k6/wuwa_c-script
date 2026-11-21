using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001437 RID: 5175
	public sealed class TowerRecommendRole : IMessage<TowerRecommendRole>, IMessage, IEquatable<TowerRecommendRole>, IDeepCloneable<TowerRecommendRole>, IBufferMessage
	{
		// Token: 0x0601B7FC RID: 112636 RVA: 0x003FF5CE File Offset: 0x003FD7CE
		[NullableContext(1)]
		public static TowerRecommendRole Create()
		{
			return new TowerRecommendRole();
		}

		// Token: 0x17005D1A RID: 23834
		// (get) Token: 0x0601B7FD RID: 112637 RVA: 0x003FF5D5 File Offset: 0x003FD7D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerRecommendRole> Parser
		{
			get
			{
				return TowerRecommendRole._parser;
			}
		}

		// Token: 0x17005D1B RID: 23835
		// (get) Token: 0x0601B7FE RID: 112638 RVA: 0x003FF5DC File Offset: 0x003FD7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D1C RID: 23836
		// (get) Token: 0x0601B7FF RID: 112639 RVA: 0x003FF5DF File Offset: 0x003FD7DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerRecommendRole.Descriptor;
			}
		}

		// Token: 0x0601B800 RID: 112640 RVA: 0x003FF5E6 File Offset: 0x003FD7E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRecommendRole()
		{
		}

		// Token: 0x0601B801 RID: 112641 RVA: 0x003FF5F0 File Offset: 0x003FD7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRecommendRole(TowerRecommendRole other) : this()
		{
			this.roleId_ = other.roleId_;
			this.leaveSkillId_ = other.leaveSkillId_;
			this.level_ = other.level_;
			this.skillBranchId_ = other.skillBranchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B802 RID: 112642 RVA: 0x003FF644 File Offset: 0x003FD844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRecommendRole Clone()
		{
			return new TowerRecommendRole(this);
		}

		// Token: 0x17005D1D RID: 23837
		// (get) Token: 0x0601B803 RID: 112643 RVA: 0x003FF64C File Offset: 0x003FD84C
		// (set) Token: 0x0601B804 RID: 112644 RVA: 0x003FF654 File Offset: 0x003FD854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17005D1E RID: 23838
		// (get) Token: 0x0601B805 RID: 112645 RVA: 0x003FF65D File Offset: 0x003FD85D
		// (set) Token: 0x0601B806 RID: 112646 RVA: 0x003FF665 File Offset: 0x003FD865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LeaveSkillId
		{
			get
			{
				return this.leaveSkillId_;
			}
			set
			{
				this.leaveSkillId_ = value;
			}
		}

		// Token: 0x17005D1F RID: 23839
		// (get) Token: 0x0601B807 RID: 112647 RVA: 0x003FF66E File Offset: 0x003FD86E
		// (set) Token: 0x0601B808 RID: 112648 RVA: 0x003FF676 File Offset: 0x003FD876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17005D20 RID: 23840
		// (get) Token: 0x0601B809 RID: 112649 RVA: 0x003FF67F File Offset: 0x003FD87F
		// (set) Token: 0x0601B80A RID: 112650 RVA: 0x003FF687 File Offset: 0x003FD887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillBranchId
		{
			get
			{
				return this.skillBranchId_;
			}
			set
			{
				this.skillBranchId_ = value;
			}
		}

		// Token: 0x0601B80B RID: 112651 RVA: 0x003FF690 File Offset: 0x003FD890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerRecommendRole);
		}

		// Token: 0x0601B80C RID: 112652 RVA: 0x003FF6A0 File Offset: 0x003FD8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerRecommendRole other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.LeaveSkillId == other.LeaveSkillId && this.Level == other.Level && this.SkillBranchId == other.SkillBranchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B80D RID: 112653 RVA: 0x003FF70C File Offset: 0x003FD90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.LeaveSkillId != 0)
			{
				num ^= this.LeaveSkillId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.SkillBranchId != 0)
			{
				num ^= this.SkillBranchId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B80E RID: 112654 RVA: 0x003FF796 File Offset: 0x003FD996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B80F RID: 112655 RVA: 0x003FF7A3 File Offset: 0x003FD9A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B810 RID: 112656 RVA: 0x003FF7AC File Offset: 0x003FD9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.LeaveSkillId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LeaveSkillId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Level);
			}
			if (this.SkillBranchId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SkillBranchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B811 RID: 112657 RVA: 0x003FF83C File Offset: 0x003FDA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.LeaveSkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LeaveSkillId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.SkillBranchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillBranchId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B812 RID: 112658 RVA: 0x003FF8C4 File Offset: 0x003FDAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerRecommendRole other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.LeaveSkillId != 0)
			{
				this.LeaveSkillId = other.LeaveSkillId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.SkillBranchId != 0)
			{
				this.SkillBranchId = other.SkillBranchId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B813 RID: 112659 RVA: 0x003FF93C File Offset: 0x003FDB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B814 RID: 112660 RVA: 0x003FF948 File Offset: 0x003FDB48
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
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LeaveSkillId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.SkillBranchId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A009 RID: 40969
		private static readonly MessageParser<TowerRecommendRole> _parser = new MessageParser<TowerRecommendRole>(() => new TowerRecommendRole());

		// Token: 0x0400A00A RID: 40970
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A00B RID: 40971
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400A00C RID: 40972
		private int roleId_;

		// Token: 0x0400A00D RID: 40973
		public const int LeaveSkillIdFieldNumber = 2;

		// Token: 0x0400A00E RID: 40974
		private int leaveSkillId_;

		// Token: 0x0400A00F RID: 40975
		public const int LevelFieldNumber = 3;

		// Token: 0x0400A010 RID: 40976
		private int level_;

		// Token: 0x0400A011 RID: 40977
		public const int SkillBranchIdFieldNumber = 4;

		// Token: 0x0400A012 RID: 40978
		private int skillBranchId_;
	}
}
