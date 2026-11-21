using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED6 RID: 3798
	[NetMessage(EMessageId.RegressSetCurUseTrialRoleResponse)]
	public sealed class RegressSetCurUseTrialRoleResponse : IMessage<RegressSetCurUseTrialRoleResponse>, IMessage, IEquatable<RegressSetCurUseTrialRoleResponse>, IDeepCloneable<RegressSetCurUseTrialRoleResponse>, IBufferMessage
	{
		// Token: 0x06014623 RID: 83491 RVA: 0x002F6DE9 File Offset: 0x002F4FE9
		[NullableContext(1)]
		public static RegressSetCurUseTrialRoleResponse Create()
		{
			return new RegressSetCurUseTrialRoleResponse();
		}

		// Token: 0x170043CD RID: 17357
		// (get) Token: 0x06014624 RID: 83492 RVA: 0x002F6DF0 File Offset: 0x002F4FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043CE RID: 17358
		// (get) Token: 0x06014625 RID: 83493 RVA: 0x002F6DF3 File Offset: 0x002F4FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressSetCurUseTrialRoleResponse.Descriptor;
			}
		}

		// Token: 0x06014626 RID: 83494 RVA: 0x002F6DFA File Offset: 0x002F4FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressSetCurUseTrialRoleResponse()
		{
		}

		// Token: 0x06014627 RID: 83495 RVA: 0x002F6E04 File Offset: 0x002F5004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressSetCurUseTrialRoleResponse(RegressSetCurUseTrialRoleResponse other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_;
			this.replacedCurRole_ = other.replacedCurRole_;
			this.replacedRoleId_ = other.replacedRoleId_;
			this.curUseRoleInfo_ = ((other.curUseRoleInfo_ != null) ? other.curUseRoleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014628 RID: 83496 RVA: 0x002F6E74 File Offset: 0x002F5074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressSetCurUseTrialRoleResponse Clone()
		{
			return new RegressSetCurUseTrialRoleResponse(this);
		}

		// Token: 0x170043CF RID: 17359
		// (get) Token: 0x06014629 RID: 83497 RVA: 0x002F6E7C File Offset: 0x002F507C
		// (set) Token: 0x0601462A RID: 83498 RVA: 0x002F6E84 File Offset: 0x002F5084
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

		// Token: 0x170043D0 RID: 17360
		// (get) Token: 0x0601462B RID: 83499 RVA: 0x002F6E8D File Offset: 0x002F508D
		// (set) Token: 0x0601462C RID: 83500 RVA: 0x002F6E95 File Offset: 0x002F5095
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

		// Token: 0x170043D1 RID: 17361
		// (get) Token: 0x0601462D RID: 83501 RVA: 0x002F6E9E File Offset: 0x002F509E
		// (set) Token: 0x0601462E RID: 83502 RVA: 0x002F6EA6 File Offset: 0x002F50A6
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

		// Token: 0x170043D2 RID: 17362
		// (get) Token: 0x0601462F RID: 83503 RVA: 0x002F6EAF File Offset: 0x002F50AF
		// (set) Token: 0x06014630 RID: 83504 RVA: 0x002F6EB7 File Offset: 0x002F50B7
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

		// Token: 0x170043D3 RID: 17363
		// (get) Token: 0x06014631 RID: 83505 RVA: 0x002F6EC0 File Offset: 0x002F50C0
		// (set) Token: 0x06014632 RID: 83506 RVA: 0x002F6EC8 File Offset: 0x002F50C8
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

		// Token: 0x06014633 RID: 83507 RVA: 0x002F6ED1 File Offset: 0x002F50D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressSetCurUseTrialRoleResponse);
		}

		// Token: 0x06014634 RID: 83508 RVA: 0x002F6EE0 File Offset: 0x002F50E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressSetCurUseTrialRoleResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && this.ReplacedCurRole == other.ReplacedCurRole && this.ReplacedRoleId == other.ReplacedRoleId && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014635 RID: 83509 RVA: 0x002F6F60 File Offset: 0x002F5160
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

		// Token: 0x06014636 RID: 83510 RVA: 0x002F7006 File Offset: 0x002F5206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014637 RID: 83511 RVA: 0x002F7013 File Offset: 0x002F5213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014638 RID: 83512 RVA: 0x002F701C File Offset: 0x002F521C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Code);
			}
			if (this.ReplacedRoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ReplacedRoleId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RoleId);
			}
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			if (this.ReplacedCurRole)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.ReplacedCurRole);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014639 RID: 83513 RVA: 0x002F70C8 File Offset: 0x002F52C8
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

		// Token: 0x0601463A RID: 83514 RVA: 0x002F715C File Offset: 0x002F535C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressSetCurUseTrialRoleResponse other)
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

		// Token: 0x0601463B RID: 83515 RVA: 0x002F7200 File Offset: 0x002F5400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601463C RID: 83516 RVA: 0x002F720C File Offset: 0x002F540C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.ReplacedRoleId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 82U)
					{
						if (this.curUseRoleInfo_ == null)
						{
							this.CurUseRoleInfo = new roleInfo();
						}
						input.ReadMessage(this.CurUseRoleInfo);
						continue;
					}
					if (num == 88U)
					{
						this.ReplacedCurRole = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007C2F RID: 31791
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C30 RID: 31792
		public const int CodeFieldNumber = 1;

		// Token: 0x04007C31 RID: 31793
		private ErrorCode code_;

		// Token: 0x04007C32 RID: 31794
		public const int RoleIdFieldNumber = 8;

		// Token: 0x04007C33 RID: 31795
		private int roleId_;

		// Token: 0x04007C34 RID: 31796
		public const int ReplacedCurRoleFieldNumber = 11;

		// Token: 0x04007C35 RID: 31797
		private bool replacedCurRole_;

		// Token: 0x04007C36 RID: 31798
		public const int ReplacedRoleIdFieldNumber = 2;

		// Token: 0x04007C37 RID: 31799
		private int replacedRoleId_;

		// Token: 0x04007C38 RID: 31800
		public const int CurUseRoleInfoFieldNumber = 10;

		// Token: 0x04007C39 RID: 31801
		private roleInfo curUseRoleInfo_;
	}
}
