using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B2A RID: 2858
	[NetMessage(EMessageId.NewPlayerSupportTrialRoleLvUpV2Response)]
	public sealed class NewPlayerSupportTrialRoleLvUpV2Response : IMessage<NewPlayerSupportTrialRoleLvUpV2Response>, IMessage, IEquatable<NewPlayerSupportTrialRoleLvUpV2Response>, IDeepCloneable<NewPlayerSupportTrialRoleLvUpV2Response>, IBufferMessage
	{
		// Token: 0x0600F816 RID: 63510 RVA: 0x00242CE5 File Offset: 0x00240EE5
		[NullableContext(1)]
		public static NewPlayerSupportTrialRoleLvUpV2Response Create()
		{
			return new NewPlayerSupportTrialRoleLvUpV2Response();
		}

		// Token: 0x1700328B RID: 12939
		// (get) Token: 0x0600F817 RID: 63511 RVA: 0x00242CEC File Offset: 0x00240EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700328C RID: 12940
		// (get) Token: 0x0600F818 RID: 63512 RVA: 0x00242CEF File Offset: 0x00240EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportTrialRoleLvUpV2Response.Descriptor;
			}
		}

		// Token: 0x0600F819 RID: 63513 RVA: 0x00242CF6 File Offset: 0x00240EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpV2Response()
		{
		}

		// Token: 0x0600F81A RID: 63514 RVA: 0x00242D00 File Offset: 0x00240F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpV2Response(NewPlayerSupportTrialRoleLvUpV2Response other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_;
			this.curUseRoleInfo_ = ((other.curUseRoleInfo_ != null) ? other.curUseRoleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F81B RID: 63515 RVA: 0x00242D58 File Offset: 0x00240F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpV2Response Clone()
		{
			return new NewPlayerSupportTrialRoleLvUpV2Response(this);
		}

		// Token: 0x1700328D RID: 12941
		// (get) Token: 0x0600F81C RID: 63516 RVA: 0x00242D60 File Offset: 0x00240F60
		// (set) Token: 0x0600F81D RID: 63517 RVA: 0x00242D68 File Offset: 0x00240F68
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

		// Token: 0x1700328E RID: 12942
		// (get) Token: 0x0600F81E RID: 63518 RVA: 0x00242D71 File Offset: 0x00240F71
		// (set) Token: 0x0600F81F RID: 63519 RVA: 0x00242D79 File Offset: 0x00240F79
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

		// Token: 0x1700328F RID: 12943
		// (get) Token: 0x0600F820 RID: 63520 RVA: 0x00242D82 File Offset: 0x00240F82
		// (set) Token: 0x0600F821 RID: 63521 RVA: 0x00242D8A File Offset: 0x00240F8A
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

		// Token: 0x0600F822 RID: 63522 RVA: 0x00242D93 File Offset: 0x00240F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportTrialRoleLvUpV2Response);
		}

		// Token: 0x0600F823 RID: 63523 RVA: 0x00242DA4 File Offset: 0x00240FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportTrialRoleLvUpV2Response other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F824 RID: 63524 RVA: 0x00242E04 File Offset: 0x00241004
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

		// Token: 0x0600F825 RID: 63525 RVA: 0x00242E78 File Offset: 0x00241078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F826 RID: 63526 RVA: 0x00242E85 File Offset: 0x00241085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F827 RID: 63527 RVA: 0x00242E90 File Offset: 0x00241090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Code);
			}
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F828 RID: 63528 RVA: 0x00242F08 File Offset: 0x00241108
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

		// Token: 0x0600F829 RID: 63529 RVA: 0x00242F78 File Offset: 0x00241178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewPlayerSupportTrialRoleLvUpV2Response other)
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

		// Token: 0x0600F82A RID: 63530 RVA: 0x00242FF4 File Offset: 0x002411F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F82B RID: 63531 RVA: 0x00243000 File Offset: 0x00241200
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
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
		}

		// Token: 0x0400637B RID: 25467
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400637C RID: 25468
		public const int CodeFieldNumber = 5;

		// Token: 0x0400637D RID: 25469
		private ErrorCode code_;

		// Token: 0x0400637E RID: 25470
		public const int RoleIdFieldNumber = 4;

		// Token: 0x0400637F RID: 25471
		private int roleId_;

		// Token: 0x04006380 RID: 25472
		public const int CurUseRoleInfoFieldNumber = 13;

		// Token: 0x04006381 RID: 25473
		private roleInfo curUseRoleInfo_;
	}
}
