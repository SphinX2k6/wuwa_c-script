using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000635 RID: 1589
	[NetMessage(EMessageId.FormationSwitchRoleResponse)]
	public sealed class FormationSwitchRoleResponse : IMessage<FormationSwitchRoleResponse>, IMessage, IEquatable<FormationSwitchRoleResponse>, IDeepCloneable<FormationSwitchRoleResponse>, IBufferMessage
	{
		// Token: 0x06009270 RID: 37488 RVA: 0x001623B9 File Offset: 0x001605B9
		[NullableContext(1)]
		public static FormationSwitchRoleResponse Create()
		{
			return new FormationSwitchRoleResponse();
		}

		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x06009271 RID: 37489 RVA: 0x001623C0 File Offset: 0x001605C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x06009272 RID: 37490 RVA: 0x001623C3 File Offset: 0x001605C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationSwitchRoleResponse.Descriptor;
			}
		}

		// Token: 0x06009273 RID: 37491 RVA: 0x001623CA File Offset: 0x001605CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchRoleResponse()
		{
		}

		// Token: 0x06009274 RID: 37492 RVA: 0x001623D2 File Offset: 0x001605D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchRoleResponse(FormationSwitchRoleResponse other) : this()
		{
			this.roleIndex_ = other.roleIndex_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009275 RID: 37493 RVA: 0x00162403 File Offset: 0x00160603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchRoleResponse Clone()
		{
			return new FormationSwitchRoleResponse(this);
		}

		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x06009276 RID: 37494 RVA: 0x0016240B File Offset: 0x0016060B
		// (set) Token: 0x06009277 RID: 37495 RVA: 0x00162413 File Offset: 0x00160613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleIndex
		{
			get
			{
				return this.roleIndex_;
			}
			set
			{
				this.roleIndex_ = value;
			}
		}

		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x06009278 RID: 37496 RVA: 0x0016241C File Offset: 0x0016061C
		// (set) Token: 0x06009279 RID: 37497 RVA: 0x00162424 File Offset: 0x00160624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600927A RID: 37498 RVA: 0x0016242D File Offset: 0x0016062D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationSwitchRoleResponse);
		}

		// Token: 0x0600927B RID: 37499 RVA: 0x0016243B File Offset: 0x0016063B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationSwitchRoleResponse other)
		{
			return other != null && (other == this || (this.RoleIndex == other.RoleIndex && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600927C RID: 37500 RVA: 0x0016247C File Offset: 0x0016067C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleIndex != 0)
			{
				num ^= this.RoleIndex.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600927D RID: 37501 RVA: 0x001624DA File Offset: 0x001606DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600927E RID: 37502 RVA: 0x001624E7 File Offset: 0x001606E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600927F RID: 37503 RVA: 0x001624F0 File Offset: 0x001606F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.RoleIndex != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.RoleIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009280 RID: 37504 RVA: 0x0016254C File Offset: 0x0016074C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleIndex);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009281 RID: 37505 RVA: 0x001625A4 File Offset: 0x001607A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationSwitchRoleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleIndex != 0)
			{
				this.RoleIndex = other.RoleIndex;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009282 RID: 37506 RVA: 0x001625F4 File Offset: 0x001607F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009283 RID: 37507 RVA: 0x00162600 File Offset: 0x00160800
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleIndex = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004695 RID: 18069
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004696 RID: 18070
		public const int RoleIndexFieldNumber = 15;

		// Token: 0x04004697 RID: 18071
		private int roleIndex_;

		// Token: 0x04004698 RID: 18072
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04004699 RID: 18073
		private ErrorCode errorCode_;
	}
}
