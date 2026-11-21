using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200109E RID: 4254
	[NetMessage(EMessageId.RoleSkillBranchModifyRequest)]
	public sealed class RoleSkillBranchModifyRequest : IMessage<RoleSkillBranchModifyRequest>, IMessage, IEquatable<RoleSkillBranchModifyRequest>, IDeepCloneable<RoleSkillBranchModifyRequest>, IBufferMessage
	{
		// Token: 0x06016BE2 RID: 93154 RVA: 0x0034E825 File Offset: 0x0034CA25
		[NullableContext(1)]
		public static RoleSkillBranchModifyRequest Create()
		{
			return new RoleSkillBranchModifyRequest();
		}

		// Token: 0x17004C38 RID: 19512
		// (get) Token: 0x06016BE3 RID: 93155 RVA: 0x0034E82C File Offset: 0x0034CA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C39 RID: 19513
		// (get) Token: 0x06016BE4 RID: 93156 RVA: 0x0034E82F File Offset: 0x0034CA2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillBranchModifyRequest.Descriptor;
			}
		}

		// Token: 0x06016BE5 RID: 93157 RVA: 0x0034E836 File Offset: 0x0034CA36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillBranchModifyRequest()
		{
		}

		// Token: 0x06016BE6 RID: 93158 RVA: 0x0034E83E File Offset: 0x0034CA3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillBranchModifyRequest(RoleSkillBranchModifyRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skillBranch_ = other.skillBranch_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016BE7 RID: 93159 RVA: 0x0034E86F File Offset: 0x0034CA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillBranchModifyRequest Clone()
		{
			return new RoleSkillBranchModifyRequest(this);
		}

		// Token: 0x17004C3A RID: 19514
		// (get) Token: 0x06016BE8 RID: 93160 RVA: 0x0034E877 File Offset: 0x0034CA77
		// (set) Token: 0x06016BE9 RID: 93161 RVA: 0x0034E87F File Offset: 0x0034CA7F
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

		// Token: 0x17004C3B RID: 19515
		// (get) Token: 0x06016BEA RID: 93162 RVA: 0x0034E888 File Offset: 0x0034CA88
		// (set) Token: 0x06016BEB RID: 93163 RVA: 0x0034E890 File Offset: 0x0034CA90
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

		// Token: 0x06016BEC RID: 93164 RVA: 0x0034E899 File Offset: 0x0034CA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillBranchModifyRequest);
		}

		// Token: 0x06016BED RID: 93165 RVA: 0x0034E8A7 File Offset: 0x0034CAA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillBranchModifyRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkillBranch == other.SkillBranch && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016BEE RID: 93166 RVA: 0x0034E8E8 File Offset: 0x0034CAE8
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

		// Token: 0x06016BEF RID: 93167 RVA: 0x0034E940 File Offset: 0x0034CB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016BF0 RID: 93168 RVA: 0x0034E94D File Offset: 0x0034CB4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016BF1 RID: 93169 RVA: 0x0034E958 File Offset: 0x0034CB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RoleId);
			}
			if (this.SkillBranch != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SkillBranch);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016BF2 RID: 93170 RVA: 0x0034E9B4 File Offset: 0x0034CBB4
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

		// Token: 0x06016BF3 RID: 93171 RVA: 0x0034EA0C File Offset: 0x0034CC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkillBranchModifyRequest other)
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

		// Token: 0x06016BF4 RID: 93172 RVA: 0x0034EA5C File Offset: 0x0034CC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016BF5 RID: 93173 RVA: 0x0034EA68 File Offset: 0x0034CC68
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
				if (num != 112U)
				{
					if (num != 120U)
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

		// Token: 0x0400883D RID: 34877
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400883E RID: 34878
		public const int RoleIdFieldNumber = 14;

		// Token: 0x0400883F RID: 34879
		private int roleId_;

		// Token: 0x04008840 RID: 34880
		public const int SkillBranchFieldNumber = 15;

		// Token: 0x04008841 RID: 34881
		private int skillBranch_;
	}
}
