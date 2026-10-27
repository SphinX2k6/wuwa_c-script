using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE6 RID: 3814
	[NetMessage(EMessageId.RegressSetCurUseTrialRoleResponse)]
	public sealed class RegressSetCurUseTrialRoleResponse : IMessage<RegressSetCurUseTrialRoleResponse>, IMessage, IEquatable<RegressSetCurUseTrialRoleResponse>, IDeepCloneable<RegressSetCurUseTrialRoleResponse>, IBufferMessage
	{
		// Token: 0x06014708 RID: 83720 RVA: 0x002F8495 File Offset: 0x002F6695
		[NullableContext(1)]
		public static RegressSetCurUseTrialRoleResponse Create()
		{
			return new RegressSetCurUseTrialRoleResponse();
		}

		// Token: 0x170043F7 RID: 17399
		// (get) Token: 0x06014709 RID: 83721 RVA: 0x002F849C File Offset: 0x002F669C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043F8 RID: 17400
		// (get) Token: 0x0601470A RID: 83722 RVA: 0x002F849F File Offset: 0x002F669F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressSetCurUseTrialRoleResponse.Descriptor;
			}
		}

		// Token: 0x0601470B RID: 83723 RVA: 0x002F84A6 File Offset: 0x002F66A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressSetCurUseTrialRoleResponse()
		{
		}

		// Token: 0x0601470C RID: 83724 RVA: 0x002F84B0 File Offset: 0x002F66B0
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

		// Token: 0x0601470D RID: 83725 RVA: 0x002F8520 File Offset: 0x002F6720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressSetCurUseTrialRoleResponse Clone()
		{
			return new RegressSetCurUseTrialRoleResponse(this);
		}

		// Token: 0x170043F9 RID: 17401
		// (get) Token: 0x0601470E RID: 83726 RVA: 0x002F8528 File Offset: 0x002F6728
		// (set) Token: 0x0601470F RID: 83727 RVA: 0x002F8530 File Offset: 0x002F6730
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

		// Token: 0x170043FA RID: 17402
		// (get) Token: 0x06014710 RID: 83728 RVA: 0x002F8539 File Offset: 0x002F6739
		// (set) Token: 0x06014711 RID: 83729 RVA: 0x002F8541 File Offset: 0x002F6741
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

		// Token: 0x170043FB RID: 17403
		// (get) Token: 0x06014712 RID: 83730 RVA: 0x002F854A File Offset: 0x002F674A
		// (set) Token: 0x06014713 RID: 83731 RVA: 0x002F8552 File Offset: 0x002F6752
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

		// Token: 0x170043FC RID: 17404
		// (get) Token: 0x06014714 RID: 83732 RVA: 0x002F855B File Offset: 0x002F675B
		// (set) Token: 0x06014715 RID: 83733 RVA: 0x002F8563 File Offset: 0x002F6763
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

		// Token: 0x170043FD RID: 17405
		// (get) Token: 0x06014716 RID: 83734 RVA: 0x002F856C File Offset: 0x002F676C
		// (set) Token: 0x06014717 RID: 83735 RVA: 0x002F8574 File Offset: 0x002F6774
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

		// Token: 0x06014718 RID: 83736 RVA: 0x002F857D File Offset: 0x002F677D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressSetCurUseTrialRoleResponse);
		}

		// Token: 0x06014719 RID: 83737 RVA: 0x002F858C File Offset: 0x002F678C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressSetCurUseTrialRoleResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && this.ReplacedCurRole == other.ReplacedCurRole && this.ReplacedRoleId == other.ReplacedRoleId && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601471A RID: 83738 RVA: 0x002F860C File Offset: 0x002F680C
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

		// Token: 0x0601471B RID: 83739 RVA: 0x002F86B2 File Offset: 0x002F68B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601471C RID: 83740 RVA: 0x002F86BF File Offset: 0x002F68BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601471D RID: 83741 RVA: 0x002F86C8 File Offset: 0x002F68C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReplacedCurRole)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.ReplacedCurRole);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RoleId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Code);
			}
			if (this.ReplacedRoleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ReplacedRoleId);
			}
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601471E RID: 83742 RVA: 0x002F8778 File Offset: 0x002F6978
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

		// Token: 0x0601471F RID: 83743 RVA: 0x002F880C File Offset: 0x002F6A0C
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

		// Token: 0x06014720 RID: 83744 RVA: 0x002F88B0 File Offset: 0x002F6AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014721 RID: 83745 RVA: 0x002F88BC File Offset: 0x002F6ABC
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
				if (num <= 64U)
				{
					if (num == 40U)
					{
						this.ReplacedCurRole = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 80U)
					{
						this.ReplacedRoleId = input.ReadInt32();
						continue;
					}
					if (num == 98U)
					{
						if (this.curUseRoleInfo_ == null)
						{
							this.CurUseRoleInfo = new roleInfo();
						}
						input.ReadMessage(this.CurUseRoleInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007C05 RID: 31749
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C06 RID: 31750
		public const int CodeFieldNumber = 9;

		// Token: 0x04007C07 RID: 31751
		private ErrorCode code_;

		// Token: 0x04007C08 RID: 31752
		public const int RoleIdFieldNumber = 8;

		// Token: 0x04007C09 RID: 31753
		private int roleId_;

		// Token: 0x04007C0A RID: 31754
		public const int ReplacedCurRoleFieldNumber = 5;

		// Token: 0x04007C0B RID: 31755
		private bool replacedCurRole_;

		// Token: 0x04007C0C RID: 31756
		public const int ReplacedRoleIdFieldNumber = 10;

		// Token: 0x04007C0D RID: 31757
		private int replacedRoleId_;

		// Token: 0x04007C0E RID: 31758
		public const int CurUseRoleInfoFieldNumber = 12;

		// Token: 0x04007C0F RID: 31759
		private roleInfo curUseRoleInfo_;
	}
}
