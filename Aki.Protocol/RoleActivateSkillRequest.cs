using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001044 RID: 4164
	[NetMessage(EMessageId.RoleActivateSkillRequest)]
	public sealed class RoleActivateSkillRequest : IMessage<RoleActivateSkillRequest>, IMessage, IEquatable<RoleActivateSkillRequest>, IDeepCloneable<RoleActivateSkillRequest>, IBufferMessage
	{
		// Token: 0x06016471 RID: 91249 RVA: 0x0033D4CD File Offset: 0x0033B6CD
		[NullableContext(1)]
		public static RoleActivateSkillRequest Create()
		{
			return new RoleActivateSkillRequest();
		}

		// Token: 0x17004A88 RID: 19080
		// (get) Token: 0x06016472 RID: 91250 RVA: 0x0033D4D4 File Offset: 0x0033B6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A89 RID: 19081
		// (get) Token: 0x06016473 RID: 91251 RVA: 0x0033D4D7 File Offset: 0x0033B6D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleActivateSkillRequest.Descriptor;
			}
		}

		// Token: 0x06016474 RID: 91252 RVA: 0x0033D4DE File Offset: 0x0033B6DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleActivateSkillRequest()
		{
		}

		// Token: 0x06016475 RID: 91253 RVA: 0x0033D4E6 File Offset: 0x0033B6E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleActivateSkillRequest(RoleActivateSkillRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skillNodeId_ = other.skillNodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016476 RID: 91254 RVA: 0x0033D517 File Offset: 0x0033B717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleActivateSkillRequest Clone()
		{
			return new RoleActivateSkillRequest(this);
		}

		// Token: 0x17004A8A RID: 19082
		// (get) Token: 0x06016477 RID: 91255 RVA: 0x0033D51F File Offset: 0x0033B71F
		// (set) Token: 0x06016478 RID: 91256 RVA: 0x0033D527 File Offset: 0x0033B727
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

		// Token: 0x17004A8B RID: 19083
		// (get) Token: 0x06016479 RID: 91257 RVA: 0x0033D530 File Offset: 0x0033B730
		// (set) Token: 0x0601647A RID: 91258 RVA: 0x0033D538 File Offset: 0x0033B738
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

		// Token: 0x0601647B RID: 91259 RVA: 0x0033D541 File Offset: 0x0033B741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleActivateSkillRequest);
		}

		// Token: 0x0601647C RID: 91260 RVA: 0x0033D54F File Offset: 0x0033B74F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleActivateSkillRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkillNodeId == other.SkillNodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601647D RID: 91261 RVA: 0x0033D590 File Offset: 0x0033B790
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

		// Token: 0x0601647E RID: 91262 RVA: 0x0033D5E8 File Offset: 0x0033B7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601647F RID: 91263 RVA: 0x0033D5F5 File Offset: 0x0033B7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016480 RID: 91264 RVA: 0x0033D600 File Offset: 0x0033B800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillNodeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkillNodeId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016481 RID: 91265 RVA: 0x0033D658 File Offset: 0x0033B858
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

		// Token: 0x06016482 RID: 91266 RVA: 0x0033D6B0 File Offset: 0x0033B8B0
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

		// Token: 0x06016483 RID: 91267 RVA: 0x0033D700 File Offset: 0x0033B900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016484 RID: 91268 RVA: 0x0033D70C File Offset: 0x0033B90C
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
					if (num != 48U)
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
					this.SkillNodeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040085BE RID: 34238
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085BF RID: 34239
		public const int RoleIdFieldNumber = 6;

		// Token: 0x040085C0 RID: 34240
		private int roleId_;

		// Token: 0x040085C1 RID: 34241
		public const int SkillNodeIdFieldNumber = 1;

		// Token: 0x040085C2 RID: 34242
		private int skillNodeId_;
	}
}
