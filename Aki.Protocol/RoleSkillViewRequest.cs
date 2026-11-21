using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A6 RID: 4262
	[NetMessage(EMessageId.RoleSkillViewRequest)]
	public sealed class RoleSkillViewRequest : IMessage<RoleSkillViewRequest>, IMessage, IEquatable<RoleSkillViewRequest>, IDeepCloneable<RoleSkillViewRequest>, IBufferMessage
	{
		// Token: 0x06016C87 RID: 93319 RVA: 0x0034FF33 File Offset: 0x0034E133
		[NullableContext(1)]
		public static RoleSkillViewRequest Create()
		{
			return new RoleSkillViewRequest();
		}

		// Token: 0x17004C5B RID: 19547
		// (get) Token: 0x06016C88 RID: 93320 RVA: 0x0034FF3A File Offset: 0x0034E13A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C5C RID: 19548
		// (get) Token: 0x06016C89 RID: 93321 RVA: 0x0034FF3D File Offset: 0x0034E13D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillViewRequest.Descriptor;
			}
		}

		// Token: 0x06016C8A RID: 93322 RVA: 0x0034FF44 File Offset: 0x0034E144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillViewRequest()
		{
		}

		// Token: 0x06016C8B RID: 93323 RVA: 0x0034FF4C File Offset: 0x0034E14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillViewRequest(RoleSkillViewRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016C8C RID: 93324 RVA: 0x0034FF7D File Offset: 0x0034E17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillViewRequest Clone()
		{
			return new RoleSkillViewRequest(this);
		}

		// Token: 0x17004C5D RID: 19549
		// (get) Token: 0x06016C8D RID: 93325 RVA: 0x0034FF85 File Offset: 0x0034E185
		// (set) Token: 0x06016C8E RID: 93326 RVA: 0x0034FF8D File Offset: 0x0034E18D
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

		// Token: 0x17004C5E RID: 19550
		// (get) Token: 0x06016C8F RID: 93327 RVA: 0x0034FF96 File Offset: 0x0034E196
		// (set) Token: 0x06016C90 RID: 93328 RVA: 0x0034FF9E File Offset: 0x0034E19E
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

		// Token: 0x06016C91 RID: 93329 RVA: 0x0034FFA7 File Offset: 0x0034E1A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillViewRequest);
		}

		// Token: 0x06016C92 RID: 93330 RVA: 0x0034FFB5 File Offset: 0x0034E1B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillViewRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016C93 RID: 93331 RVA: 0x0034FFF4 File Offset: 0x0034E1F4
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

		// Token: 0x06016C94 RID: 93332 RVA: 0x0035004C File Offset: 0x0034E24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016C95 RID: 93333 RVA: 0x00350059 File Offset: 0x0034E259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016C96 RID: 93334 RVA: 0x00350064 File Offset: 0x0034E264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SkillId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016C97 RID: 93335 RVA: 0x003500C0 File Offset: 0x0034E2C0
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

		// Token: 0x06016C98 RID: 93336 RVA: 0x00350118 File Offset: 0x0034E318
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

		// Token: 0x06016C99 RID: 93337 RVA: 0x00350168 File Offset: 0x0034E368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016C9A RID: 93338 RVA: 0x00350174 File Offset: 0x0034E374
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
				if (num != 24U)
				{
					if (num != 56U)
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

		// Token: 0x0400886D RID: 34925
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400886E RID: 34926
		public const int RoleIdFieldNumber = 7;

		// Token: 0x0400886F RID: 34927
		private int roleId_;

		// Token: 0x04008870 RID: 34928
		public const int SkillIdFieldNumber = 3;

		// Token: 0x04008871 RID: 34929
		private int skillId_;
	}
}
