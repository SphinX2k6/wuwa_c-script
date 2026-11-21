using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200104F RID: 4175
	public sealed class RoleConfigInfo : IMessage<RoleConfigInfo>, IMessage, IEquatable<RoleConfigInfo>, IDeepCloneable<RoleConfigInfo>, IBufferMessage
	{
		// Token: 0x06016563 RID: 91491 RVA: 0x0033F988 File Offset: 0x0033DB88
		[NullableContext(1)]
		public static RoleConfigInfo Create()
		{
			return new RoleConfigInfo();
		}

		// Token: 0x17004AC0 RID: 19136
		// (get) Token: 0x06016564 RID: 91492 RVA: 0x0033F98F File Offset: 0x0033DB8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleConfigInfo> Parser
		{
			get
			{
				return RoleConfigInfo._parser;
			}
		}

		// Token: 0x17004AC1 RID: 19137
		// (get) Token: 0x06016565 RID: 91493 RVA: 0x0033F996 File Offset: 0x0033DB96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AC2 RID: 19138
		// (get) Token: 0x06016566 RID: 91494 RVA: 0x0033F999 File Offset: 0x0033DB99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleConfigInfo.Descriptor;
			}
		}

		// Token: 0x06016567 RID: 91495 RVA: 0x0033F9A0 File Offset: 0x0033DBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleConfigInfo()
		{
		}

		// Token: 0x06016568 RID: 91496 RVA: 0x0033F9A8 File Offset: 0x0033DBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleConfigInfo(RoleConfigInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skillBranch_ = other.skillBranch_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016569 RID: 91497 RVA: 0x0033F9D9 File Offset: 0x0033DBD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleConfigInfo Clone()
		{
			return new RoleConfigInfo(this);
		}

		// Token: 0x17004AC3 RID: 19139
		// (get) Token: 0x0601656A RID: 91498 RVA: 0x0033F9E1 File Offset: 0x0033DBE1
		// (set) Token: 0x0601656B RID: 91499 RVA: 0x0033F9E9 File Offset: 0x0033DBE9
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

		// Token: 0x17004AC4 RID: 19140
		// (get) Token: 0x0601656C RID: 91500 RVA: 0x0033F9F2 File Offset: 0x0033DBF2
		// (set) Token: 0x0601656D RID: 91501 RVA: 0x0033F9FA File Offset: 0x0033DBFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillBranch
		{
			get
			{
				return this.skillBranch_;
			}
			set
			{
				this.skillBranch_ = value;
			}
		}

		// Token: 0x0601656E RID: 91502 RVA: 0x0033FA03 File Offset: 0x0033DC03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleConfigInfo);
		}

		// Token: 0x0601656F RID: 91503 RVA: 0x0033FA11 File Offset: 0x0033DC11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleConfigInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkillBranch == other.SkillBranch && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016570 RID: 91504 RVA: 0x0033FA50 File Offset: 0x0033DC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.SkillBranch != 0)
			{
				num ^= this.SkillBranch.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016571 RID: 91505 RVA: 0x0033FAA8 File Offset: 0x0033DCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016572 RID: 91506 RVA: 0x0033FAB5 File Offset: 0x0033DCB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016573 RID: 91507 RVA: 0x0033FAC0 File Offset: 0x0033DCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.SkillBranch != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkillBranch);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016574 RID: 91508 RVA: 0x0033FB18 File Offset: 0x0033DD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.SkillBranch != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillBranch);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016575 RID: 91509 RVA: 0x0033FB70 File Offset: 0x0033DD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleConfigInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.SkillBranch != 0)
			{
				this.SkillBranch = other.SkillBranch;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016576 RID: 91510 RVA: 0x0033FBC0 File Offset: 0x0033DDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016577 RID: 91511 RVA: 0x0033FBCC File Offset: 0x0033DDCC
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkillBranch = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008611 RID: 34321
		private static readonly MessageParser<RoleConfigInfo> _parser = new MessageParser<RoleConfigInfo>(() => new RoleConfigInfo());

		// Token: 0x04008612 RID: 34322
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008613 RID: 34323
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04008614 RID: 34324
		private int roleId_;

		// Token: 0x04008615 RID: 34325
		public const int SkillBranchFieldNumber = 2;

		// Token: 0x04008616 RID: 34326
		private int skillBranch_;
	}
}
