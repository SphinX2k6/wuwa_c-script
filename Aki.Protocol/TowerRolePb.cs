using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200143E RID: 5182
	public sealed class TowerRolePb : IMessage<TowerRolePb>, IMessage, IEquatable<TowerRolePb>, IDeepCloneable<TowerRolePb>, IBufferMessage
	{
		// Token: 0x0601B88C RID: 112780 RVA: 0x0040091E File Offset: 0x003FEB1E
		[NullableContext(1)]
		public static TowerRolePb Create()
		{
			return new TowerRolePb();
		}

		// Token: 0x17005D38 RID: 23864
		// (get) Token: 0x0601B88D RID: 112781 RVA: 0x00400925 File Offset: 0x003FEB25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerRolePb> Parser
		{
			get
			{
				return TowerRolePb._parser;
			}
		}

		// Token: 0x17005D39 RID: 23865
		// (get) Token: 0x0601B88E RID: 112782 RVA: 0x0040092C File Offset: 0x003FEB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D3A RID: 23866
		// (get) Token: 0x0601B88F RID: 112783 RVA: 0x0040092F File Offset: 0x003FEB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerRolePb.Descriptor;
			}
		}

		// Token: 0x0601B890 RID: 112784 RVA: 0x00400936 File Offset: 0x003FEB36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRolePb()
		{
		}

		// Token: 0x0601B891 RID: 112785 RVA: 0x0040093E File Offset: 0x003FEB3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRolePb(TowerRolePb other) : this()
		{
			this.roleId_ = other.roleId_;
			this.leaveSkillId_ = other.leaveSkillId_;
			this.skillBranchId_ = other.skillBranchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B892 RID: 112786 RVA: 0x0040097B File Offset: 0x003FEB7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRolePb Clone()
		{
			return new TowerRolePb(this);
		}

		// Token: 0x17005D3B RID: 23867
		// (get) Token: 0x0601B893 RID: 112787 RVA: 0x00400983 File Offset: 0x003FEB83
		// (set) Token: 0x0601B894 RID: 112788 RVA: 0x0040098B File Offset: 0x003FEB8B
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

		// Token: 0x17005D3C RID: 23868
		// (get) Token: 0x0601B895 RID: 112789 RVA: 0x00400994 File Offset: 0x003FEB94
		// (set) Token: 0x0601B896 RID: 112790 RVA: 0x0040099C File Offset: 0x003FEB9C
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

		// Token: 0x17005D3D RID: 23869
		// (get) Token: 0x0601B897 RID: 112791 RVA: 0x004009A5 File Offset: 0x003FEBA5
		// (set) Token: 0x0601B898 RID: 112792 RVA: 0x004009AD File Offset: 0x003FEBAD
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

		// Token: 0x0601B899 RID: 112793 RVA: 0x004009B6 File Offset: 0x003FEBB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerRolePb);
		}

		// Token: 0x0601B89A RID: 112794 RVA: 0x004009C4 File Offset: 0x003FEBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerRolePb other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.LeaveSkillId == other.LeaveSkillId && this.SkillBranchId == other.SkillBranchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B89B RID: 112795 RVA: 0x00400A20 File Offset: 0x003FEC20
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

		// Token: 0x0601B89C RID: 112796 RVA: 0x00400A91 File Offset: 0x003FEC91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B89D RID: 112797 RVA: 0x00400A9E File Offset: 0x003FEC9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B89E RID: 112798 RVA: 0x00400AA8 File Offset: 0x003FECA8
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
			if (this.SkillBranchId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SkillBranchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B89F RID: 112799 RVA: 0x00400B1C File Offset: 0x003FED1C
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

		// Token: 0x0601B8A0 RID: 112800 RVA: 0x00400B8C File Offset: 0x003FED8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerRolePb other)
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
			if (other.SkillBranchId != 0)
			{
				this.SkillBranchId = other.SkillBranchId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B8A1 RID: 112801 RVA: 0x00400BF0 File Offset: 0x003FEDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B8A2 RID: 112802 RVA: 0x00400BFC File Offset: 0x003FEDFC
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SkillBranchId = input.ReadInt32();
						}
					}
					else
					{
						this.LeaveSkillId = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A031 RID: 41009
		private static readonly MessageParser<TowerRolePb> _parser = new MessageParser<TowerRolePb>(() => new TowerRolePb());

		// Token: 0x0400A032 RID: 41010
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A033 RID: 41011
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400A034 RID: 41012
		private int roleId_;

		// Token: 0x0400A035 RID: 41013
		public const int LeaveSkillIdFieldNumber = 2;

		// Token: 0x0400A036 RID: 41014
		private int leaveSkillId_;

		// Token: 0x0400A037 RID: 41015
		public const int SkillBranchIdFieldNumber = 3;

		// Token: 0x0400A038 RID: 41016
		private int skillBranchId_;
	}
}
