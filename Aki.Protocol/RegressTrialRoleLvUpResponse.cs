using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EEA RID: 3818
	[NetMessage(EMessageId.RegressTrialRoleLvUpResponse)]
	public sealed class RegressTrialRoleLvUpResponse : IMessage<RegressTrialRoleLvUpResponse>, IMessage, IEquatable<RegressTrialRoleLvUpResponse>, IDeepCloneable<RegressTrialRoleLvUpResponse>, IBufferMessage
	{
		// Token: 0x0601475C RID: 83804 RVA: 0x002F9075 File Offset: 0x002F7275
		[NullableContext(1)]
		public static RegressTrialRoleLvUpResponse Create()
		{
			return new RegressTrialRoleLvUpResponse();
		}

		// Token: 0x17004409 RID: 17417
		// (get) Token: 0x0601475D RID: 83805 RVA: 0x002F907C File Offset: 0x002F727C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700440A RID: 17418
		// (get) Token: 0x0601475E RID: 83806 RVA: 0x002F907F File Offset: 0x002F727F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressTrialRoleLvUpResponse.Descriptor;
			}
		}

		// Token: 0x0601475F RID: 83807 RVA: 0x002F9086 File Offset: 0x002F7286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTrialRoleLvUpResponse()
		{
		}

		// Token: 0x06014760 RID: 83808 RVA: 0x002F9090 File Offset: 0x002F7290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTrialRoleLvUpResponse(RegressTrialRoleLvUpResponse other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_;
			this.curUseRoleInfo_ = ((other.curUseRoleInfo_ != null) ? other.curUseRoleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014761 RID: 83809 RVA: 0x002F90E8 File Offset: 0x002F72E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTrialRoleLvUpResponse Clone()
		{
			return new RegressTrialRoleLvUpResponse(this);
		}

		// Token: 0x1700440B RID: 17419
		// (get) Token: 0x06014762 RID: 83810 RVA: 0x002F90F0 File Offset: 0x002F72F0
		// (set) Token: 0x06014763 RID: 83811 RVA: 0x002F90F8 File Offset: 0x002F72F8
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

		// Token: 0x1700440C RID: 17420
		// (get) Token: 0x06014764 RID: 83812 RVA: 0x002F9101 File Offset: 0x002F7301
		// (set) Token: 0x06014765 RID: 83813 RVA: 0x002F9109 File Offset: 0x002F7309
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

		// Token: 0x1700440D RID: 17421
		// (get) Token: 0x06014766 RID: 83814 RVA: 0x002F9112 File Offset: 0x002F7312
		// (set) Token: 0x06014767 RID: 83815 RVA: 0x002F911A File Offset: 0x002F731A
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

		// Token: 0x06014768 RID: 83816 RVA: 0x002F9123 File Offset: 0x002F7323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressTrialRoleLvUpResponse);
		}

		// Token: 0x06014769 RID: 83817 RVA: 0x002F9134 File Offset: 0x002F7334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressTrialRoleLvUpResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601476A RID: 83818 RVA: 0x002F9194 File Offset: 0x002F7394
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

		// Token: 0x0601476B RID: 83819 RVA: 0x002F9208 File Offset: 0x002F7408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601476C RID: 83820 RVA: 0x002F9215 File Offset: 0x002F7415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601476D RID: 83821 RVA: 0x002F9220 File Offset: 0x002F7420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoleId);
			}
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601476E RID: 83822 RVA: 0x002F9298 File Offset: 0x002F7498
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

		// Token: 0x0601476F RID: 83823 RVA: 0x002F9308 File Offset: 0x002F7508
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

		// Token: 0x06014770 RID: 83824 RVA: 0x002F9384 File Offset: 0x002F7584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014771 RID: 83825 RVA: 0x002F9390 File Offset: 0x002F7590
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
					if (num != 48U)
					{
						if (num != 114U)
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

		// Token: 0x04007C1D RID: 31773
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C1E RID: 31774
		public const int CodeFieldNumber = 4;

		// Token: 0x04007C1F RID: 31775
		private ErrorCode code_;

		// Token: 0x04007C20 RID: 31776
		public const int RoleIdFieldNumber = 6;

		// Token: 0x04007C21 RID: 31777
		private int roleId_;

		// Token: 0x04007C22 RID: 31778
		public const int CurUseRoleInfoFieldNumber = 14;

		// Token: 0x04007C23 RID: 31779
		private roleInfo curUseRoleInfo_;
	}
}
