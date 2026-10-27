using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B6 RID: 4278
	[NetMessage(EMessageId.RoleSkillViewRequest)]
	public sealed class RoleSkillViewRequest : IMessage<RoleSkillViewRequest>, IMessage, IEquatable<RoleSkillViewRequest>, IDeepCloneable<RoleSkillViewRequest>, IBufferMessage
	{
		// Token: 0x06016D6C RID: 93548 RVA: 0x0035160F File Offset: 0x0034F80F
		[NullableContext(1)]
		public static RoleSkillViewRequest Create()
		{
			return new RoleSkillViewRequest();
		}

		// Token: 0x17004C85 RID: 19589
		// (get) Token: 0x06016D6D RID: 93549 RVA: 0x00351616 File Offset: 0x0034F816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C86 RID: 19590
		// (get) Token: 0x06016D6E RID: 93550 RVA: 0x00351619 File Offset: 0x0034F819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillViewRequest.Descriptor;
			}
		}

		// Token: 0x06016D6F RID: 93551 RVA: 0x00351620 File Offset: 0x0034F820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillViewRequest()
		{
		}

		// Token: 0x06016D70 RID: 93552 RVA: 0x00351628 File Offset: 0x0034F828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillViewRequest(RoleSkillViewRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016D71 RID: 93553 RVA: 0x00351659 File Offset: 0x0034F859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillViewRequest Clone()
		{
			return new RoleSkillViewRequest(this);
		}

		// Token: 0x17004C87 RID: 19591
		// (get) Token: 0x06016D72 RID: 93554 RVA: 0x00351661 File Offset: 0x0034F861
		// (set) Token: 0x06016D73 RID: 93555 RVA: 0x00351669 File Offset: 0x0034F869
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

		// Token: 0x17004C88 RID: 19592
		// (get) Token: 0x06016D74 RID: 93556 RVA: 0x00351672 File Offset: 0x0034F872
		// (set) Token: 0x06016D75 RID: 93557 RVA: 0x0035167A File Offset: 0x0034F87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x06016D76 RID: 93558 RVA: 0x00351683 File Offset: 0x0034F883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillViewRequest);
		}

		// Token: 0x06016D77 RID: 93559 RVA: 0x00351691 File Offset: 0x0034F891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillViewRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016D78 RID: 93560 RVA: 0x003516D0 File Offset: 0x0034F8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016D79 RID: 93561 RVA: 0x00351728 File Offset: 0x0034F928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016D7A RID: 93562 RVA: 0x00351735 File Offset: 0x0034F935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016D7B RID: 93563 RVA: 0x00351740 File Offset: 0x0034F940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SkillId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016D7C RID: 93564 RVA: 0x0035179C File Offset: 0x0034F99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016D7D RID: 93565 RVA: 0x003517F4 File Offset: 0x0034F9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkillViewRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016D7E RID: 93566 RVA: 0x00351844 File Offset: 0x0034FA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016D7F RID: 93567 RVA: 0x00351850 File Offset: 0x0034FA50
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008843 RID: 34883
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008844 RID: 34884
		public const int RoleIdFieldNumber = 15;

		// Token: 0x04008845 RID: 34885
		private int roleId_;

		// Token: 0x04008846 RID: 34886
		public const int SkillIdFieldNumber = 6;

		// Token: 0x04008847 RID: 34887
		private int skillId_;
	}
}
