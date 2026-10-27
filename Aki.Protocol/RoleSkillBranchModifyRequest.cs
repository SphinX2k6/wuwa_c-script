using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010AE RID: 4270
	[NetMessage(EMessageId.RoleSkillBranchModifyRequest)]
	public sealed class RoleSkillBranchModifyRequest : IMessage<RoleSkillBranchModifyRequest>, IMessage, IEquatable<RoleSkillBranchModifyRequest>, IDeepCloneable<RoleSkillBranchModifyRequest>, IBufferMessage
	{
		// Token: 0x06016CC7 RID: 93383 RVA: 0x0034FF01 File Offset: 0x0034E101
		[NullableContext(1)]
		public static RoleSkillBranchModifyRequest Create()
		{
			return new RoleSkillBranchModifyRequest();
		}

		// Token: 0x17004C62 RID: 19554
		// (get) Token: 0x06016CC8 RID: 93384 RVA: 0x0034FF08 File Offset: 0x0034E108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C63 RID: 19555
		// (get) Token: 0x06016CC9 RID: 93385 RVA: 0x0034FF0B File Offset: 0x0034E10B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillBranchModifyRequest.Descriptor;
			}
		}

		// Token: 0x06016CCA RID: 93386 RVA: 0x0034FF12 File Offset: 0x0034E112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillBranchModifyRequest()
		{
		}

		// Token: 0x06016CCB RID: 93387 RVA: 0x0034FF1A File Offset: 0x0034E11A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillBranchModifyRequest(RoleSkillBranchModifyRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skillBranch_ = other.skillBranch_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016CCC RID: 93388 RVA: 0x0034FF4B File Offset: 0x0034E14B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillBranchModifyRequest Clone()
		{
			return new RoleSkillBranchModifyRequest(this);
		}

		// Token: 0x17004C64 RID: 19556
		// (get) Token: 0x06016CCD RID: 93389 RVA: 0x0034FF53 File Offset: 0x0034E153
		// (set) Token: 0x06016CCE RID: 93390 RVA: 0x0034FF5B File Offset: 0x0034E15B
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

		// Token: 0x17004C65 RID: 19557
		// (get) Token: 0x06016CCF RID: 93391 RVA: 0x0034FF64 File Offset: 0x0034E164
		// (set) Token: 0x06016CD0 RID: 93392 RVA: 0x0034FF6C File Offset: 0x0034E16C
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

		// Token: 0x06016CD1 RID: 93393 RVA: 0x0034FF75 File Offset: 0x0034E175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillBranchModifyRequest);
		}

		// Token: 0x06016CD2 RID: 93394 RVA: 0x0034FF83 File Offset: 0x0034E183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillBranchModifyRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkillBranch == other.SkillBranch && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016CD3 RID: 93395 RVA: 0x0034FFC4 File Offset: 0x0034E1C4
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

		// Token: 0x06016CD4 RID: 93396 RVA: 0x0035001C File Offset: 0x0034E21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016CD5 RID: 93397 RVA: 0x00350029 File Offset: 0x0034E229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016CD6 RID: 93398 RVA: 0x00350034 File Offset: 0x0034E234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleId);
			}
			if (this.SkillBranch != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SkillBranch);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016CD7 RID: 93399 RVA: 0x00350090 File Offset: 0x0034E290
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

		// Token: 0x06016CD8 RID: 93400 RVA: 0x003500E8 File Offset: 0x0034E2E8
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

		// Token: 0x06016CD9 RID: 93401 RVA: 0x00350138 File Offset: 0x0034E338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016CDA RID: 93402 RVA: 0x00350144 File Offset: 0x0034E344
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
				if (num != 32U)
				{
					if (num != 40U)
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

		// Token: 0x04008813 RID: 34835
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008814 RID: 34836
		public const int RoleIdFieldNumber = 4;

		// Token: 0x04008815 RID: 34837
		private int roleId_;

		// Token: 0x04008816 RID: 34838
		public const int SkillBranchFieldNumber = 5;

		// Token: 0x04008817 RID: 34839
		private int skillBranch_;
	}
}
