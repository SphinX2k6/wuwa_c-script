using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B24 RID: 2852
	[NetMessage(EMessageId.NewPlayerSupportSetCurUseTrialRoleResponse)]
	public sealed class NewPlayerSupportSetCurUseTrialRoleResponse : IMessage<NewPlayerSupportSetCurUseTrialRoleResponse>, IMessage, IEquatable<NewPlayerSupportSetCurUseTrialRoleResponse>, IDeepCloneable<NewPlayerSupportSetCurUseTrialRoleResponse>, IBufferMessage
	{
		// Token: 0x0600F796 RID: 63382 RVA: 0x00241A11 File Offset: 0x0023FC11
		[NullableContext(1)]
		public static NewPlayerSupportSetCurUseTrialRoleResponse Create()
		{
			return new NewPlayerSupportSetCurUseTrialRoleResponse();
		}

		// Token: 0x1700326F RID: 12911
		// (get) Token: 0x0600F797 RID: 63383 RVA: 0x00241A18 File Offset: 0x0023FC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003270 RID: 12912
		// (get) Token: 0x0600F798 RID: 63384 RVA: 0x00241A1B File Offset: 0x0023FC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportSetCurUseTrialRoleResponse.Descriptor;
			}
		}

		// Token: 0x0600F799 RID: 63385 RVA: 0x00241A22 File Offset: 0x0023FC22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleResponse()
		{
		}

		// Token: 0x0600F79A RID: 63386 RVA: 0x00241A2C File Offset: 0x0023FC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleResponse(NewPlayerSupportSetCurUseTrialRoleResponse other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_;
			this.replacedCurRole_ = other.replacedCurRole_;
			this.replacedRoleId_ = other.replacedRoleId_;
			this.curUseRoleInfo_ = ((other.curUseRoleInfo_ != null) ? other.curUseRoleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F79B RID: 63387 RVA: 0x00241A9C File Offset: 0x0023FC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleResponse Clone()
		{
			return new NewPlayerSupportSetCurUseTrialRoleResponse(this);
		}

		// Token: 0x17003271 RID: 12913
		// (get) Token: 0x0600F79C RID: 63388 RVA: 0x00241AA4 File Offset: 0x0023FCA4
		// (set) Token: 0x0600F79D RID: 63389 RVA: 0x00241AAC File Offset: 0x0023FCAC
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

		// Token: 0x17003272 RID: 12914
		// (get) Token: 0x0600F79E RID: 63390 RVA: 0x00241AB5 File Offset: 0x0023FCB5
		// (set) Token: 0x0600F79F RID: 63391 RVA: 0x00241ABD File Offset: 0x0023FCBD
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

		// Token: 0x17003273 RID: 12915
		// (get) Token: 0x0600F7A0 RID: 63392 RVA: 0x00241AC6 File Offset: 0x0023FCC6
		// (set) Token: 0x0600F7A1 RID: 63393 RVA: 0x00241ACE File Offset: 0x0023FCCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ReplacedCurRole
		{
			get
			{
				return this.replacedCurRole_;
			}
			set
			{
				this.replacedCurRole_ = value;
			}
		}

		// Token: 0x17003274 RID: 12916
		// (get) Token: 0x0600F7A2 RID: 63394 RVA: 0x00241AD7 File Offset: 0x0023FCD7
		// (set) Token: 0x0600F7A3 RID: 63395 RVA: 0x00241ADF File Offset: 0x0023FCDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReplacedRoleId
		{
			get
			{
				return this.replacedRoleId_;
			}
			set
			{
				this.replacedRoleId_ = value;
			}
		}

		// Token: 0x17003275 RID: 12917
		// (get) Token: 0x0600F7A4 RID: 63396 RVA: 0x00241AE8 File Offset: 0x0023FCE8
		// (set) Token: 0x0600F7A5 RID: 63397 RVA: 0x00241AF0 File Offset: 0x0023FCF0
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

		// Token: 0x0600F7A6 RID: 63398 RVA: 0x00241AF9 File Offset: 0x0023FCF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportSetCurUseTrialRoleResponse);
		}

		// Token: 0x0600F7A7 RID: 63399 RVA: 0x00241B08 File Offset: 0x0023FD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportSetCurUseTrialRoleResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && this.ReplacedCurRole == other.ReplacedCurRole && this.ReplacedRoleId == other.ReplacedRoleId && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F7A8 RID: 63400 RVA: 0x00241B88 File Offset: 0x0023FD88
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
			if (this.ReplacedCurRole)
			{
				num ^= this.ReplacedCurRole.GetHashCode();
			}
			if (this.ReplacedRoleId != 0)
			{
				num ^= this.ReplacedRoleId.GetHashCode();
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

		// Token: 0x0600F7A9 RID: 63401 RVA: 0x00241C2E File Offset: 0x0023FE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F7AA RID: 63402 RVA: 0x00241C3B File Offset: 0x0023FE3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F7AB RID: 63403 RVA: 0x00241C44 File Offset: 0x0023FE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Code);
			}
			if (this.ReplacedRoleId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ReplacedRoleId);
			}
			if (this.ReplacedCurRole)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.ReplacedCurRole);
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

		// Token: 0x0600F7AC RID: 63404 RVA: 0x00241CF4 File Offset: 0x0023FEF4
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
			if (this.ReplacedCurRole)
			{
				num += 2;
			}
			if (this.ReplacedRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReplacedRoleId);
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

		// Token: 0x0600F7AD RID: 63405 RVA: 0x00241D88 File Offset: 0x0023FF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewPlayerSupportSetCurUseTrialRoleResponse other)
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
			if (other.ReplacedCurRole)
			{
				this.ReplacedCurRole = other.ReplacedCurRole;
			}
			if (other.ReplacedRoleId != 0)
			{
				this.ReplacedRoleId = other.ReplacedRoleId;
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

		// Token: 0x0600F7AE RID: 63406 RVA: 0x00241E2C File Offset: 0x0024002C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F7AF RID: 63407 RVA: 0x00241E38 File Offset: 0x00240038
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
				if (num <= 24U)
				{
					if (num == 10U)
					{
						if (this.curUseRoleInfo_ == null)
						{
							this.CurUseRoleInfo = new roleInfo();
						}
						input.ReadMessage(this.CurUseRoleInfo);
						continue;
					}
					if (num == 24U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.ReplacedRoleId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.ReplacedCurRole = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006355 RID: 25429
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006356 RID: 25430
		public const int CodeFieldNumber = 3;

		// Token: 0x04006357 RID: 25431
		private ErrorCode code_;

		// Token: 0x04006358 RID: 25432
		public const int RoleIdFieldNumber = 15;

		// Token: 0x04006359 RID: 25433
		private int roleId_;

		// Token: 0x0400635A RID: 25434
		public const int ReplacedCurRoleFieldNumber = 12;

		// Token: 0x0400635B RID: 25435
		private bool replacedCurRole_;

		// Token: 0x0400635C RID: 25436
		public const int ReplacedRoleIdFieldNumber = 7;

		// Token: 0x0400635D RID: 25437
		private int replacedRoleId_;

		// Token: 0x0400635E RID: 25438
		public const int CurUseRoleInfoFieldNumber = 1;

		// Token: 0x0400635F RID: 25439
		private roleInfo curUseRoleInfo_;
	}
}
