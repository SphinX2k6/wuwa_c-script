using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013CB RID: 5067
	public sealed class TowerRolePb : IMessage<TowerRolePb>, IMessage, IEquatable<TowerRolePb>, IDeepCloneable<TowerRolePb>, IBufferMessage
	{
		// Token: 0x0601AE01 RID: 110081 RVA: 0x003E565A File Offset: 0x003E385A
		[NullableContext(1)]
		public static TowerRolePb Create()
		{
			return new TowerRolePb();
		}

		// Token: 0x17005AA3 RID: 23203
		// (get) Token: 0x0601AE02 RID: 110082 RVA: 0x003E5661 File Offset: 0x003E3861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerRolePb> Parser
		{
			get
			{
				return TowerRolePb._parser;
			}
		}

		// Token: 0x17005AA4 RID: 23204
		// (get) Token: 0x0601AE03 RID: 110083 RVA: 0x003E5668 File Offset: 0x003E3868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AA5 RID: 23205
		// (get) Token: 0x0601AE04 RID: 110084 RVA: 0x003E566B File Offset: 0x003E386B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerRolePb.Descriptor;
			}
		}

		// Token: 0x0601AE05 RID: 110085 RVA: 0x003E5672 File Offset: 0x003E3872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRolePb()
		{
		}

		// Token: 0x0601AE06 RID: 110086 RVA: 0x003E567A File Offset: 0x003E387A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRolePb(TowerRolePb other) : this()
		{
			this.roleId_ = other.roleId_;
			this.leaveSkillId_ = other.leaveSkillId_;
			this.skillBranchId_ = other.skillBranchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AE07 RID: 110087 RVA: 0x003E56B7 File Offset: 0x003E38B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRolePb Clone()
		{
			return new TowerRolePb(this);
		}

		// Token: 0x17005AA6 RID: 23206
		// (get) Token: 0x0601AE08 RID: 110088 RVA: 0x003E56BF File Offset: 0x003E38BF
		// (set) Token: 0x0601AE09 RID: 110089 RVA: 0x003E56C7 File Offset: 0x003E38C7
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

		// Token: 0x17005AA7 RID: 23207
		// (get) Token: 0x0601AE0A RID: 110090 RVA: 0x003E56D0 File Offset: 0x003E38D0
		// (set) Token: 0x0601AE0B RID: 110091 RVA: 0x003E56D8 File Offset: 0x003E38D8
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

		// Token: 0x17005AA8 RID: 23208
		// (get) Token: 0x0601AE0C RID: 110092 RVA: 0x003E56E1 File Offset: 0x003E38E1
		// (set) Token: 0x0601AE0D RID: 110093 RVA: 0x003E56E9 File Offset: 0x003E38E9
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

		// Token: 0x0601AE0E RID: 110094 RVA: 0x003E56F2 File Offset: 0x003E38F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerRolePb);
		}

		// Token: 0x0601AE0F RID: 110095 RVA: 0x003E5700 File Offset: 0x003E3900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerRolePb other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.LeaveSkillId == other.LeaveSkillId && this.SkillBranchId == other.SkillBranchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AE10 RID: 110096 RVA: 0x003E575C File Offset: 0x003E395C
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

		// Token: 0x0601AE11 RID: 110097 RVA: 0x003E57CD File Offset: 0x003E39CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AE12 RID: 110098 RVA: 0x003E57DA File Offset: 0x003E39DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AE13 RID: 110099 RVA: 0x003E57E4 File Offset: 0x003E39E4
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

		// Token: 0x0601AE14 RID: 110100 RVA: 0x003E5858 File Offset: 0x003E3A58
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

		// Token: 0x0601AE15 RID: 110101 RVA: 0x003E58C8 File Offset: 0x003E3AC8
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

		// Token: 0x0601AE16 RID: 110102 RVA: 0x003E592C File Offset: 0x003E3B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AE17 RID: 110103 RVA: 0x003E5938 File Offset: 0x003E3B38
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

		// Token: 0x04009BEA RID: 39914
		private static readonly MessageParser<TowerRolePb> _parser = new MessageParser<TowerRolePb>(() => new TowerRolePb());

		// Token: 0x04009BEB RID: 39915
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BEC RID: 39916
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04009BED RID: 39917
		private int roleId_;

		// Token: 0x04009BEE RID: 39918
		public const int LeaveSkillIdFieldNumber = 2;

		// Token: 0x04009BEF RID: 39919
		private int leaveSkillId_;

		// Token: 0x04009BF0 RID: 39920
		public const int SkillBranchIdFieldNumber = 3;

		// Token: 0x04009BF1 RID: 39921
		private int skillBranchId_;
	}
}
