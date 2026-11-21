using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B17 RID: 2839
	[NetMessage(EMessageId.NewPlayerSupportTrialRoleLvUpResponse)]
	public sealed class NewPlayerSupportTrialRoleLvUpResponse : IMessage<NewPlayerSupportTrialRoleLvUpResponse>, IMessage, IEquatable<NewPlayerSupportTrialRoleLvUpResponse>, IDeepCloneable<NewPlayerSupportTrialRoleLvUpResponse>, IBufferMessage
	{
		// Token: 0x0600F6D4 RID: 63188 RVA: 0x00240555 File Offset: 0x0023E755
		[NullableContext(1)]
		public static NewPlayerSupportTrialRoleLvUpResponse Create()
		{
			return new NewPlayerSupportTrialRoleLvUpResponse();
		}

		// Token: 0x17003245 RID: 12869
		// (get) Token: 0x0600F6D5 RID: 63189 RVA: 0x0024055C File Offset: 0x0023E75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003246 RID: 12870
		// (get) Token: 0x0600F6D6 RID: 63190 RVA: 0x0024055F File Offset: 0x0023E75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportTrialRoleLvUpResponse.Descriptor;
			}
		}

		// Token: 0x0600F6D7 RID: 63191 RVA: 0x00240566 File Offset: 0x0023E766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpResponse()
		{
		}

		// Token: 0x0600F6D8 RID: 63192 RVA: 0x00240570 File Offset: 0x0023E770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpResponse(NewPlayerSupportTrialRoleLvUpResponse other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_;
			this.curUseRoleInfo_ = ((other.curUseRoleInfo_ != null) ? other.curUseRoleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F6D9 RID: 63193 RVA: 0x002405C8 File Offset: 0x0023E7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpResponse Clone()
		{
			return new NewPlayerSupportTrialRoleLvUpResponse(this);
		}

		// Token: 0x17003247 RID: 12871
		// (get) Token: 0x0600F6DA RID: 63194 RVA: 0x002405D0 File Offset: 0x0023E7D0
		// (set) Token: 0x0600F6DB RID: 63195 RVA: 0x002405D8 File Offset: 0x0023E7D8
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

		// Token: 0x17003248 RID: 12872
		// (get) Token: 0x0600F6DC RID: 63196 RVA: 0x002405E1 File Offset: 0x0023E7E1
		// (set) Token: 0x0600F6DD RID: 63197 RVA: 0x002405E9 File Offset: 0x0023E7E9
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

		// Token: 0x17003249 RID: 12873
		// (get) Token: 0x0600F6DE RID: 63198 RVA: 0x002405F2 File Offset: 0x0023E7F2
		// (set) Token: 0x0600F6DF RID: 63199 RVA: 0x002405FA File Offset: 0x0023E7FA
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

		// Token: 0x0600F6E0 RID: 63200 RVA: 0x00240603 File Offset: 0x0023E803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportTrialRoleLvUpResponse);
		}

		// Token: 0x0600F6E1 RID: 63201 RVA: 0x00240614 File Offset: 0x0023E814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportTrialRoleLvUpResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F6E2 RID: 63202 RVA: 0x00240674 File Offset: 0x0023E874
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

		// Token: 0x0600F6E3 RID: 63203 RVA: 0x002406E8 File Offset: 0x0023E8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F6E4 RID: 63204 RVA: 0x002406F5 File Offset: 0x0023E8F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F6E5 RID: 63205 RVA: 0x00240700 File Offset: 0x0023E900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Code);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoleId);
			}
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F6E6 RID: 63206 RVA: 0x00240778 File Offset: 0x0023E978
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

		// Token: 0x0600F6E7 RID: 63207 RVA: 0x002407E8 File Offset: 0x0023E9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewPlayerSupportTrialRoleLvUpResponse other)
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

		// Token: 0x0600F6E8 RID: 63208 RVA: 0x00240864 File Offset: 0x0023EA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F6E9 RID: 63209 RVA: 0x00240870 File Offset: 0x0023EA70
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
				if (num != 72U)
				{
					if (num != 80U)
					{
						if (num != 122U)
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
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400637A RID: 25466
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400637B RID: 25467
		public const int CodeFieldNumber = 9;

		// Token: 0x0400637C RID: 25468
		private ErrorCode code_;

		// Token: 0x0400637D RID: 25469
		public const int RoleIdFieldNumber = 10;

		// Token: 0x0400637E RID: 25470
		private int roleId_;

		// Token: 0x0400637F RID: 25471
		public const int CurUseRoleInfoFieldNumber = 15;

		// Token: 0x04006380 RID: 25472
		private roleInfo curUseRoleInfo_;
	}
}
