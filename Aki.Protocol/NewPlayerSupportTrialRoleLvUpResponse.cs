using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B28 RID: 2856
	[NetMessage(EMessageId.NewPlayerSupportTrialRoleLvUpResponse)]
	public sealed class NewPlayerSupportTrialRoleLvUpResponse : IMessage<NewPlayerSupportTrialRoleLvUpResponse>, IMessage, IEquatable<NewPlayerSupportTrialRoleLvUpResponse>, IDeepCloneable<NewPlayerSupportTrialRoleLvUpResponse>, IBufferMessage
	{
		// Token: 0x0600F7EE RID: 63470 RVA: 0x00242771 File Offset: 0x00240971
		[NullableContext(1)]
		public static NewPlayerSupportTrialRoleLvUpResponse Create()
		{
			return new NewPlayerSupportTrialRoleLvUpResponse();
		}

		// Token: 0x17003283 RID: 12931
		// (get) Token: 0x0600F7EF RID: 63471 RVA: 0x00242778 File Offset: 0x00240978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003284 RID: 12932
		// (get) Token: 0x0600F7F0 RID: 63472 RVA: 0x0024277B File Offset: 0x0024097B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportTrialRoleLvUpResponse.Descriptor;
			}
		}

		// Token: 0x0600F7F1 RID: 63473 RVA: 0x00242782 File Offset: 0x00240982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpResponse()
		{
		}

		// Token: 0x0600F7F2 RID: 63474 RVA: 0x0024278C File Offset: 0x0024098C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpResponse(NewPlayerSupportTrialRoleLvUpResponse other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_;
			this.curUseRoleInfo_ = ((other.curUseRoleInfo_ != null) ? other.curUseRoleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F7F3 RID: 63475 RVA: 0x002427E4 File Offset: 0x002409E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpResponse Clone()
		{
			return new NewPlayerSupportTrialRoleLvUpResponse(this);
		}

		// Token: 0x17003285 RID: 12933
		// (get) Token: 0x0600F7F4 RID: 63476 RVA: 0x002427EC File Offset: 0x002409EC
		// (set) Token: 0x0600F7F5 RID: 63477 RVA: 0x002427F4 File Offset: 0x002409F4
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

		// Token: 0x17003286 RID: 12934
		// (get) Token: 0x0600F7F6 RID: 63478 RVA: 0x002427FD File Offset: 0x002409FD
		// (set) Token: 0x0600F7F7 RID: 63479 RVA: 0x00242805 File Offset: 0x00240A05
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

		// Token: 0x17003287 RID: 12935
		// (get) Token: 0x0600F7F8 RID: 63480 RVA: 0x0024280E File Offset: 0x00240A0E
		// (set) Token: 0x0600F7F9 RID: 63481 RVA: 0x00242816 File Offset: 0x00240A16
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

		// Token: 0x0600F7FA RID: 63482 RVA: 0x0024281F File Offset: 0x00240A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportTrialRoleLvUpResponse);
		}

		// Token: 0x0600F7FB RID: 63483 RVA: 0x00242830 File Offset: 0x00240A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportTrialRoleLvUpResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F7FC RID: 63484 RVA: 0x00242890 File Offset: 0x00240A90
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

		// Token: 0x0600F7FD RID: 63485 RVA: 0x00242904 File Offset: 0x00240B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F7FE RID: 63486 RVA: 0x00242911 File Offset: 0x00240B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F7FF RID: 63487 RVA: 0x0024291C File Offset: 0x00240B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleId);
			}
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F800 RID: 63488 RVA: 0x00242994 File Offset: 0x00240B94
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

		// Token: 0x0600F801 RID: 63489 RVA: 0x00242A04 File Offset: 0x00240C04
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

		// Token: 0x0600F802 RID: 63490 RVA: 0x00242A80 File Offset: 0x00240C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F803 RID: 63491 RVA: 0x00242A8C File Offset: 0x00240C8C
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
					if (num != 50U)
					{
						if (num != 88U)
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
		}

		// Token: 0x04006371 RID: 25457
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006372 RID: 25458
		public const int CodeFieldNumber = 11;

		// Token: 0x04006373 RID: 25459
		private ErrorCode code_;

		// Token: 0x04006374 RID: 25460
		public const int RoleIdFieldNumber = 4;

		// Token: 0x04006375 RID: 25461
		private int roleId_;

		// Token: 0x04006376 RID: 25462
		public const int CurUseRoleInfoFieldNumber = 6;

		// Token: 0x04006377 RID: 25463
		private roleInfo curUseRoleInfo_;
	}
}
