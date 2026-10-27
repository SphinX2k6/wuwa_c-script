using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001054 RID: 4180
	[NetMessage(EMessageId.RoleActivateSkillRequest)]
	public sealed class RoleActivateSkillRequest : IMessage<RoleActivateSkillRequest>, IMessage, IEquatable<RoleActivateSkillRequest>, IDeepCloneable<RoleActivateSkillRequest>, IBufferMessage
	{
		// Token: 0x06016556 RID: 91478 RVA: 0x0033EB99 File Offset: 0x0033CD99
		[NullableContext(1)]
		public static RoleActivateSkillRequest Create()
		{
			return new RoleActivateSkillRequest();
		}

		// Token: 0x17004AB2 RID: 19122
		// (get) Token: 0x06016557 RID: 91479 RVA: 0x0033EBA0 File Offset: 0x0033CDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AB3 RID: 19123
		// (get) Token: 0x06016558 RID: 91480 RVA: 0x0033EBA3 File Offset: 0x0033CDA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleActivateSkillRequest.Descriptor;
			}
		}

		// Token: 0x06016559 RID: 91481 RVA: 0x0033EBAA File Offset: 0x0033CDAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleActivateSkillRequest()
		{
		}

		// Token: 0x0601655A RID: 91482 RVA: 0x0033EBB2 File Offset: 0x0033CDB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleActivateSkillRequest(RoleActivateSkillRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skillNodeId_ = other.skillNodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601655B RID: 91483 RVA: 0x0033EBE3 File Offset: 0x0033CDE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleActivateSkillRequest Clone()
		{
			return new RoleActivateSkillRequest(this);
		}

		// Token: 0x17004AB4 RID: 19124
		// (get) Token: 0x0601655C RID: 91484 RVA: 0x0033EBEB File Offset: 0x0033CDEB
		// (set) Token: 0x0601655D RID: 91485 RVA: 0x0033EBF3 File Offset: 0x0033CDF3
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

		// Token: 0x17004AB5 RID: 19125
		// (get) Token: 0x0601655E RID: 91486 RVA: 0x0033EBFC File Offset: 0x0033CDFC
		// (set) Token: 0x0601655F RID: 91487 RVA: 0x0033EC04 File Offset: 0x0033CE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillNodeId
		{
			get
			{
				return this.skillNodeId_;
			}
			set
			{
				this.skillNodeId_ = value;
			}
		}

		// Token: 0x06016560 RID: 91488 RVA: 0x0033EC0D File Offset: 0x0033CE0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleActivateSkillRequest);
		}

		// Token: 0x06016561 RID: 91489 RVA: 0x0033EC1B File Offset: 0x0033CE1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleActivateSkillRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkillNodeId == other.SkillNodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016562 RID: 91490 RVA: 0x0033EC5C File Offset: 0x0033CE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.SkillNodeId != 0)
			{
				num ^= this.SkillNodeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016563 RID: 91491 RVA: 0x0033ECB4 File Offset: 0x0033CEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016564 RID: 91492 RVA: 0x0033ECC1 File Offset: 0x0033CEC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016565 RID: 91493 RVA: 0x0033ECCC File Offset: 0x0033CECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RoleId);
			}
			if (this.SkillNodeId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.SkillNodeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016566 RID: 91494 RVA: 0x0033ED28 File Offset: 0x0033CF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.SkillNodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillNodeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016567 RID: 91495 RVA: 0x0033ED80 File Offset: 0x0033CF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleActivateSkillRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.SkillNodeId != 0)
			{
				this.SkillNodeId = other.SkillNodeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016568 RID: 91496 RVA: 0x0033EDD0 File Offset: 0x0033CFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016569 RID: 91497 RVA: 0x0033EDDC File Offset: 0x0033CFDC
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
				if (num != 56U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkillNodeId = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008594 RID: 34196
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008595 RID: 34197
		public const int RoleIdFieldNumber = 7;

		// Token: 0x04008596 RID: 34198
		private int roleId_;

		// Token: 0x04008597 RID: 34199
		public const int SkillNodeIdFieldNumber = 9;

		// Token: 0x04008598 RID: 34200
		private int skillNodeId_;
	}
}
