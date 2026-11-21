using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B15 RID: 2837
	[NetMessage(EMessageId.NewPlayerSupportSetCurUseTrialRoleV2Response)]
	public sealed class NewPlayerSupportSetCurUseTrialRoleV2Response : IMessage<NewPlayerSupportSetCurUseTrialRoleV2Response>, IMessage, IEquatable<NewPlayerSupportSetCurUseTrialRoleV2Response>, IDeepCloneable<NewPlayerSupportSetCurUseTrialRoleV2Response>, IBufferMessage
	{
		// Token: 0x0600F6A8 RID: 63144 RVA: 0x0023FEA5 File Offset: 0x0023E0A5
		[NullableContext(1)]
		public static NewPlayerSupportSetCurUseTrialRoleV2Response Create()
		{
			return new NewPlayerSupportSetCurUseTrialRoleV2Response();
		}

		// Token: 0x1700323B RID: 12859
		// (get) Token: 0x0600F6A9 RID: 63145 RVA: 0x0023FEAC File Offset: 0x0023E0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700323C RID: 12860
		// (get) Token: 0x0600F6AA RID: 63146 RVA: 0x0023FEAF File Offset: 0x0023E0AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportSetCurUseTrialRoleV2Response.Descriptor;
			}
		}

		// Token: 0x0600F6AB RID: 63147 RVA: 0x0023FEB6 File Offset: 0x0023E0B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleV2Response()
		{
		}

		// Token: 0x0600F6AC RID: 63148 RVA: 0x0023FEC0 File Offset: 0x0023E0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleV2Response(NewPlayerSupportSetCurUseTrialRoleV2Response other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_;
			this.replacedCurRole_ = other.replacedCurRole_;
			this.replacedRoleId_ = other.replacedRoleId_;
			this.curUseRoleInfo_ = ((other.curUseRoleInfo_ != null) ? other.curUseRoleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F6AD RID: 63149 RVA: 0x0023FF30 File Offset: 0x0023E130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleV2Response Clone()
		{
			return new NewPlayerSupportSetCurUseTrialRoleV2Response(this);
		}

		// Token: 0x1700323D RID: 12861
		// (get) Token: 0x0600F6AE RID: 63150 RVA: 0x0023FF38 File Offset: 0x0023E138
		// (set) Token: 0x0600F6AF RID: 63151 RVA: 0x0023FF40 File Offset: 0x0023E140
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

		// Token: 0x1700323E RID: 12862
		// (get) Token: 0x0600F6B0 RID: 63152 RVA: 0x0023FF49 File Offset: 0x0023E149
		// (set) Token: 0x0600F6B1 RID: 63153 RVA: 0x0023FF51 File Offset: 0x0023E151
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

		// Token: 0x1700323F RID: 12863
		// (get) Token: 0x0600F6B2 RID: 63154 RVA: 0x0023FF5A File Offset: 0x0023E15A
		// (set) Token: 0x0600F6B3 RID: 63155 RVA: 0x0023FF62 File Offset: 0x0023E162
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

		// Token: 0x17003240 RID: 12864
		// (get) Token: 0x0600F6B4 RID: 63156 RVA: 0x0023FF6B File Offset: 0x0023E16B
		// (set) Token: 0x0600F6B5 RID: 63157 RVA: 0x0023FF73 File Offset: 0x0023E173
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

		// Token: 0x17003241 RID: 12865
		// (get) Token: 0x0600F6B6 RID: 63158 RVA: 0x0023FF7C File Offset: 0x0023E17C
		// (set) Token: 0x0600F6B7 RID: 63159 RVA: 0x0023FF84 File Offset: 0x0023E184
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

		// Token: 0x0600F6B8 RID: 63160 RVA: 0x0023FF8D File Offset: 0x0023E18D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportSetCurUseTrialRoleV2Response);
		}

		// Token: 0x0600F6B9 RID: 63161 RVA: 0x0023FF9C File Offset: 0x0023E19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportSetCurUseTrialRoleV2Response other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && this.ReplacedCurRole == other.ReplacedCurRole && this.ReplacedRoleId == other.ReplacedRoleId && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F6BA RID: 63162 RVA: 0x0024001C File Offset: 0x0023E21C
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

		// Token: 0x0600F6BB RID: 63163 RVA: 0x002400C2 File Offset: 0x0023E2C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F6BC RID: 63164 RVA: 0x002400CF File Offset: 0x0023E2CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F6BD RID: 63165 RVA: 0x002400D8 File Offset: 0x0023E2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Code);
			}
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
			if (this.ReplacedRoleId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ReplacedRoleId);
			}
			if (this.ReplacedCurRole)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.ReplacedCurRole);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F6BE RID: 63166 RVA: 0x00240188 File Offset: 0x0023E388
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

		// Token: 0x0600F6BF RID: 63167 RVA: 0x0024021C File Offset: 0x0023E41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewPlayerSupportSetCurUseTrialRoleV2Response other)
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

		// Token: 0x0600F6C0 RID: 63168 RVA: 0x002402C0 File Offset: 0x0023E4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F6C1 RID: 63169 RVA: 0x002402CC File Offset: 0x0023E4CC
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
				if (num <= 90U)
				{
					if (num == 40U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 90U)
					{
						if (this.curUseRoleInfo_ == null)
						{
							this.CurUseRoleInfo = new roleInfo();
						}
						input.ReadMessage(this.CurUseRoleInfo);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.ReplacedRoleId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.ReplacedCurRole = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400636C RID: 25452
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400636D RID: 25453
		public const int CodeFieldNumber = 5;

		// Token: 0x0400636E RID: 25454
		private ErrorCode code_;

		// Token: 0x0400636F RID: 25455
		public const int RoleIdFieldNumber = 12;

		// Token: 0x04006370 RID: 25456
		private int roleId_;

		// Token: 0x04006371 RID: 25457
		public const int ReplacedCurRoleFieldNumber = 15;

		// Token: 0x04006372 RID: 25458
		private bool replacedCurRole_;

		// Token: 0x04006373 RID: 25459
		public const int ReplacedRoleIdFieldNumber = 13;

		// Token: 0x04006374 RID: 25460
		private int replacedRoleId_;

		// Token: 0x04006375 RID: 25461
		public const int CurUseRoleInfoFieldNumber = 11;

		// Token: 0x04006376 RID: 25462
		private roleInfo curUseRoleInfo_;
	}
}
