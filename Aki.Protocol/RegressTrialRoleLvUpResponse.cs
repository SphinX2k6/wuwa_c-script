using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EDA RID: 3802
	[NetMessage(EMessageId.RegressTrialRoleLvUpResponse)]
	public sealed class RegressTrialRoleLvUpResponse : IMessage<RegressTrialRoleLvUpResponse>, IMessage, IEquatable<RegressTrialRoleLvUpResponse>, IDeepCloneable<RegressTrialRoleLvUpResponse>, IBufferMessage
	{
		// Token: 0x06014677 RID: 83575 RVA: 0x002F79C1 File Offset: 0x002F5BC1
		[NullableContext(1)]
		public static RegressTrialRoleLvUpResponse Create()
		{
			return new RegressTrialRoleLvUpResponse();
		}

		// Token: 0x170043DF RID: 17375
		// (get) Token: 0x06014678 RID: 83576 RVA: 0x002F79C8 File Offset: 0x002F5BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043E0 RID: 17376
		// (get) Token: 0x06014679 RID: 83577 RVA: 0x002F79CB File Offset: 0x002F5BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressTrialRoleLvUpResponse.Descriptor;
			}
		}

		// Token: 0x0601467A RID: 83578 RVA: 0x002F79D2 File Offset: 0x002F5BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTrialRoleLvUpResponse()
		{
		}

		// Token: 0x0601467B RID: 83579 RVA: 0x002F79DC File Offset: 0x002F5BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTrialRoleLvUpResponse(RegressTrialRoleLvUpResponse other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_;
			this.curUseRoleInfo_ = ((other.curUseRoleInfo_ != null) ? other.curUseRoleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601467C RID: 83580 RVA: 0x002F7A34 File Offset: 0x002F5C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTrialRoleLvUpResponse Clone()
		{
			return new RegressTrialRoleLvUpResponse(this);
		}

		// Token: 0x170043E1 RID: 17377
		// (get) Token: 0x0601467D RID: 83581 RVA: 0x002F7A3C File Offset: 0x002F5C3C
		// (set) Token: 0x0601467E RID: 83582 RVA: 0x002F7A44 File Offset: 0x002F5C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x170043E2 RID: 17378
		// (get) Token: 0x0601467F RID: 83583 RVA: 0x002F7A4D File Offset: 0x002F5C4D
		// (set) Token: 0x06014680 RID: 83584 RVA: 0x002F7A55 File Offset: 0x002F5C55
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

		// Token: 0x170043E3 RID: 17379
		// (get) Token: 0x06014681 RID: 83585 RVA: 0x002F7A5E File Offset: 0x002F5C5E
		// (set) Token: 0x06014682 RID: 83586 RVA: 0x002F7A66 File Offset: 0x002F5C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public roleInfo CurUseRoleInfo
		{
			get
			{
				return this.curUseRoleInfo_;
			}
			set
			{
				this.curUseRoleInfo_ = value;
			}
		}

		// Token: 0x06014683 RID: 83587 RVA: 0x002F7A6F File Offset: 0x002F5C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressTrialRoleLvUpResponse);
		}

		// Token: 0x06014684 RID: 83588 RVA: 0x002F7A80 File Offset: 0x002F5C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressTrialRoleLvUpResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014685 RID: 83589 RVA: 0x002F7AE0 File Offset: 0x002F5CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.curUseRoleInfo_ != null)
			{
				num ^= this.CurUseRoleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014686 RID: 83590 RVA: 0x002F7B54 File Offset: 0x002F5D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014687 RID: 83591 RVA: 0x002F7B61 File Offset: 0x002F5D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014688 RID: 83592 RVA: 0x002F7B6C File Offset: 0x002F5D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RoleId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014689 RID: 83593 RVA: 0x002F7BE4 File Offset: 0x002F5DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.curUseRoleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurUseRoleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601468A RID: 83594 RVA: 0x002F7C54 File Offset: 0x002F5E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressTrialRoleLvUpResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.curUseRoleInfo_ != null)
			{
				if (this.curUseRoleInfo_ == null)
				{
					this.CurUseRoleInfo = new roleInfo();
				}
				this.CurUseRoleInfo.MergeFrom(other.CurUseRoleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601468B RID: 83595 RVA: 0x002F7CD0 File Offset: 0x002F5ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601468C RID: 83596 RVA: 0x002F7CDC File Offset: 0x002F5EDC
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
				if (num != 90U)
				{
					if (num != 96U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Code = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					if (this.curUseRoleInfo_ == null)
					{
						this.CurUseRoleInfo = new roleInfo();
					}
					input.ReadMessage(this.CurUseRoleInfo);
				}
			}
		}

		// Token: 0x04007C47 RID: 31815
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C48 RID: 31816
		public const int CodeFieldNumber = 15;

		// Token: 0x04007C49 RID: 31817
		private ErrorCode code_;

		// Token: 0x04007C4A RID: 31818
		public const int RoleIdFieldNumber = 12;

		// Token: 0x04007C4B RID: 31819
		private int roleId_;

		// Token: 0x04007C4C RID: 31820
		public const int CurUseRoleInfoFieldNumber = 11;

		// Token: 0x04007C4D RID: 31821
		private roleInfo curUseRoleInfo_;
	}
}
