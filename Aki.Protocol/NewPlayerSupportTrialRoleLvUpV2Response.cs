using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B19 RID: 2841
	[NetMessage(EMessageId.NewPlayerSupportTrialRoleLvUpV2Response)]
	public sealed class NewPlayerSupportTrialRoleLvUpV2Response : IMessage<NewPlayerSupportTrialRoleLvUpV2Response>, IMessage, IEquatable<NewPlayerSupportTrialRoleLvUpV2Response>, IDeepCloneable<NewPlayerSupportTrialRoleLvUpV2Response>, IBufferMessage
	{
		// Token: 0x0600F6FC RID: 63228 RVA: 0x00240AC9 File Offset: 0x0023ECC9
		[NullableContext(1)]
		public static NewPlayerSupportTrialRoleLvUpV2Response Create()
		{
			return new NewPlayerSupportTrialRoleLvUpV2Response();
		}

		// Token: 0x1700324D RID: 12877
		// (get) Token: 0x0600F6FD RID: 63229 RVA: 0x00240AD0 File Offset: 0x0023ECD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700324E RID: 12878
		// (get) Token: 0x0600F6FE RID: 63230 RVA: 0x00240AD3 File Offset: 0x0023ECD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportTrialRoleLvUpV2Response.Descriptor;
			}
		}

		// Token: 0x0600F6FF RID: 63231 RVA: 0x00240ADA File Offset: 0x0023ECDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpV2Response()
		{
		}

		// Token: 0x0600F700 RID: 63232 RVA: 0x00240AE4 File Offset: 0x0023ECE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpV2Response(NewPlayerSupportTrialRoleLvUpV2Response other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_;
			this.curUseRoleInfo_ = ((other.curUseRoleInfo_ != null) ? other.curUseRoleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F701 RID: 63233 RVA: 0x00240B3C File Offset: 0x0023ED3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpV2Response Clone()
		{
			return new NewPlayerSupportTrialRoleLvUpV2Response(this);
		}

		// Token: 0x1700324F RID: 12879
		// (get) Token: 0x0600F702 RID: 63234 RVA: 0x00240B44 File Offset: 0x0023ED44
		// (set) Token: 0x0600F703 RID: 63235 RVA: 0x00240B4C File Offset: 0x0023ED4C
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

		// Token: 0x17003250 RID: 12880
		// (get) Token: 0x0600F704 RID: 63236 RVA: 0x00240B55 File Offset: 0x0023ED55
		// (set) Token: 0x0600F705 RID: 63237 RVA: 0x00240B5D File Offset: 0x0023ED5D
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

		// Token: 0x17003251 RID: 12881
		// (get) Token: 0x0600F706 RID: 63238 RVA: 0x00240B66 File Offset: 0x0023ED66
		// (set) Token: 0x0600F707 RID: 63239 RVA: 0x00240B6E File Offset: 0x0023ED6E
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

		// Token: 0x0600F708 RID: 63240 RVA: 0x00240B77 File Offset: 0x0023ED77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportTrialRoleLvUpV2Response);
		}

		// Token: 0x0600F709 RID: 63241 RVA: 0x00240B88 File Offset: 0x0023ED88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportTrialRoleLvUpV2Response other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F70A RID: 63242 RVA: 0x00240BE8 File Offset: 0x0023EDE8
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

		// Token: 0x0600F70B RID: 63243 RVA: 0x00240C5C File Offset: 0x0023EE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F70C RID: 63244 RVA: 0x00240C69 File Offset: 0x0023EE69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F70D RID: 63245 RVA: 0x00240C74 File Offset: 0x0023EE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F70E RID: 63246 RVA: 0x00240CEC File Offset: 0x0023EEEC
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

		// Token: 0x0600F70F RID: 63247 RVA: 0x00240D5C File Offset: 0x0023EF5C
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

		// Token: 0x0600F710 RID: 63248 RVA: 0x00240DD8 File Offset: 0x0023EFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F711 RID: 63249 RVA: 0x00240DE4 File Offset: 0x0023EFE4
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
				if (num != 16U)
				{
					if (num != 32U)
					{
						if (num != 82U)
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

		// Token: 0x04006384 RID: 25476
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006385 RID: 25477
		public const int CodeFieldNumber = 4;

		// Token: 0x04006386 RID: 25478
		private ErrorCode code_;

		// Token: 0x04006387 RID: 25479
		public const int RoleIdFieldNumber = 2;

		// Token: 0x04006388 RID: 25480
		private int roleId_;

		// Token: 0x04006389 RID: 25481
		public const int CurUseRoleInfoFieldNumber = 10;

		// Token: 0x0400638A RID: 25482
		private roleInfo curUseRoleInfo_;
	}
}
