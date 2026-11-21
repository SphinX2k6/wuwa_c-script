using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B13 RID: 2835
	[NetMessage(EMessageId.NewPlayerSupportSetCurUseTrialRoleResponse)]
	public sealed class NewPlayerSupportSetCurUseTrialRoleResponse : IMessage<NewPlayerSupportSetCurUseTrialRoleResponse>, IMessage, IEquatable<NewPlayerSupportSetCurUseTrialRoleResponse>, IDeepCloneable<NewPlayerSupportSetCurUseTrialRoleResponse>, IBufferMessage
	{
		// Token: 0x0600F67C RID: 63100 RVA: 0x0023F7F9 File Offset: 0x0023D9F9
		[NullableContext(1)]
		public static NewPlayerSupportSetCurUseTrialRoleResponse Create()
		{
			return new NewPlayerSupportSetCurUseTrialRoleResponse();
		}

		// Token: 0x17003231 RID: 12849
		// (get) Token: 0x0600F67D RID: 63101 RVA: 0x0023F800 File Offset: 0x0023DA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003232 RID: 12850
		// (get) Token: 0x0600F67E RID: 63102 RVA: 0x0023F803 File Offset: 0x0023DA03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportSetCurUseTrialRoleResponse.Descriptor;
			}
		}

		// Token: 0x0600F67F RID: 63103 RVA: 0x0023F80A File Offset: 0x0023DA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleResponse()
		{
		}

		// Token: 0x0600F680 RID: 63104 RVA: 0x0023F814 File Offset: 0x0023DA14
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

		// Token: 0x0600F681 RID: 63105 RVA: 0x0023F884 File Offset: 0x0023DA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleResponse Clone()
		{
			return new NewPlayerSupportSetCurUseTrialRoleResponse(this);
		}

		// Token: 0x17003233 RID: 12851
		// (get) Token: 0x0600F682 RID: 63106 RVA: 0x0023F88C File Offset: 0x0023DA8C
		// (set) Token: 0x0600F683 RID: 63107 RVA: 0x0023F894 File Offset: 0x0023DA94
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

		// Token: 0x17003234 RID: 12852
		// (get) Token: 0x0600F684 RID: 63108 RVA: 0x0023F89D File Offset: 0x0023DA9D
		// (set) Token: 0x0600F685 RID: 63109 RVA: 0x0023F8A5 File Offset: 0x0023DAA5
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

		// Token: 0x17003235 RID: 12853
		// (get) Token: 0x0600F686 RID: 63110 RVA: 0x0023F8AE File Offset: 0x0023DAAE
		// (set) Token: 0x0600F687 RID: 63111 RVA: 0x0023F8B6 File Offset: 0x0023DAB6
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

		// Token: 0x17003236 RID: 12854
		// (get) Token: 0x0600F688 RID: 63112 RVA: 0x0023F8BF File Offset: 0x0023DABF
		// (set) Token: 0x0600F689 RID: 63113 RVA: 0x0023F8C7 File Offset: 0x0023DAC7
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

		// Token: 0x17003237 RID: 12855
		// (get) Token: 0x0600F68A RID: 63114 RVA: 0x0023F8D0 File Offset: 0x0023DAD0
		// (set) Token: 0x0600F68B RID: 63115 RVA: 0x0023F8D8 File Offset: 0x0023DAD8
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

		// Token: 0x0600F68C RID: 63116 RVA: 0x0023F8E1 File Offset: 0x0023DAE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportSetCurUseTrialRoleResponse);
		}

		// Token: 0x0600F68D RID: 63117 RVA: 0x0023F8F0 File Offset: 0x0023DAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportSetCurUseTrialRoleResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && this.ReplacedCurRole == other.ReplacedCurRole && this.ReplacedRoleId == other.ReplacedRoleId && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F68E RID: 63118 RVA: 0x0023F970 File Offset: 0x0023DB70
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

		// Token: 0x0600F68F RID: 63119 RVA: 0x0023FA16 File Offset: 0x0023DC16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F690 RID: 63120 RVA: 0x0023FA23 File Offset: 0x0023DC23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F691 RID: 63121 RVA: 0x0023FA2C File Offset: 0x0023DC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.ReplacedCurRole)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.ReplacedCurRole);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Code);
			}
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			if (this.ReplacedRoleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ReplacedRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F692 RID: 63122 RVA: 0x0023FAD8 File Offset: 0x0023DCD8
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

		// Token: 0x0600F693 RID: 63123 RVA: 0x0023FB6C File Offset: 0x0023DD6C
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

		// Token: 0x0600F694 RID: 63124 RVA: 0x0023FC10 File Offset: 0x0023DE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F695 RID: 63125 RVA: 0x0023FC1C File Offset: 0x0023DE1C
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
				if (num <= 48U)
				{
					if (num == 8U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.ReplacedCurRole = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
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
					if (num == 96U)
					{
						this.ReplacedRoleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400635E RID: 25438
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400635F RID: 25439
		public const int CodeFieldNumber = 8;

		// Token: 0x04006360 RID: 25440
		private ErrorCode code_;

		// Token: 0x04006361 RID: 25441
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04006362 RID: 25442
		private int roleId_;

		// Token: 0x04006363 RID: 25443
		public const int ReplacedCurRoleFieldNumber = 6;

		// Token: 0x04006364 RID: 25444
		private bool replacedCurRole_;

		// Token: 0x04006365 RID: 25445
		public const int ReplacedRoleIdFieldNumber = 12;

		// Token: 0x04006366 RID: 25446
		private int replacedRoleId_;

		// Token: 0x04006367 RID: 25447
		public const int CurUseRoleInfoFieldNumber = 10;

		// Token: 0x04006368 RID: 25448
		private roleInfo curUseRoleInfo_;
	}
}
