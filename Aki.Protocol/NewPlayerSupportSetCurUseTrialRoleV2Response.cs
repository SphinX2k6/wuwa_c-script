using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B26 RID: 2854
	[NetMessage(EMessageId.NewPlayerSupportSetCurUseTrialRoleV2Response)]
	public sealed class NewPlayerSupportSetCurUseTrialRoleV2Response : IMessage<NewPlayerSupportSetCurUseTrialRoleV2Response>, IMessage, IEquatable<NewPlayerSupportSetCurUseTrialRoleV2Response>, IDeepCloneable<NewPlayerSupportSetCurUseTrialRoleV2Response>, IBufferMessage
	{
		// Token: 0x0600F7C2 RID: 63426 RVA: 0x002420C1 File Offset: 0x002402C1
		[NullableContext(1)]
		public static NewPlayerSupportSetCurUseTrialRoleV2Response Create()
		{
			return new NewPlayerSupportSetCurUseTrialRoleV2Response();
		}

		// Token: 0x17003279 RID: 12921
		// (get) Token: 0x0600F7C3 RID: 63427 RVA: 0x002420C8 File Offset: 0x002402C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700327A RID: 12922
		// (get) Token: 0x0600F7C4 RID: 63428 RVA: 0x002420CB File Offset: 0x002402CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportSetCurUseTrialRoleV2Response.Descriptor;
			}
		}

		// Token: 0x0600F7C5 RID: 63429 RVA: 0x002420D2 File Offset: 0x002402D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleV2Response()
		{
		}

		// Token: 0x0600F7C6 RID: 63430 RVA: 0x002420DC File Offset: 0x002402DC
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

		// Token: 0x0600F7C7 RID: 63431 RVA: 0x0024214C File Offset: 0x0024034C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleV2Response Clone()
		{
			return new NewPlayerSupportSetCurUseTrialRoleV2Response(this);
		}

		// Token: 0x1700327B RID: 12923
		// (get) Token: 0x0600F7C8 RID: 63432 RVA: 0x00242154 File Offset: 0x00240354
		// (set) Token: 0x0600F7C9 RID: 63433 RVA: 0x0024215C File Offset: 0x0024035C
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

		// Token: 0x1700327C RID: 12924
		// (get) Token: 0x0600F7CA RID: 63434 RVA: 0x00242165 File Offset: 0x00240365
		// (set) Token: 0x0600F7CB RID: 63435 RVA: 0x0024216D File Offset: 0x0024036D
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

		// Token: 0x1700327D RID: 12925
		// (get) Token: 0x0600F7CC RID: 63436 RVA: 0x00242176 File Offset: 0x00240376
		// (set) Token: 0x0600F7CD RID: 63437 RVA: 0x0024217E File Offset: 0x0024037E
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

		// Token: 0x1700327E RID: 12926
		// (get) Token: 0x0600F7CE RID: 63438 RVA: 0x00242187 File Offset: 0x00240387
		// (set) Token: 0x0600F7CF RID: 63439 RVA: 0x0024218F File Offset: 0x0024038F
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

		// Token: 0x1700327F RID: 12927
		// (get) Token: 0x0600F7D0 RID: 63440 RVA: 0x00242198 File Offset: 0x00240398
		// (set) Token: 0x0600F7D1 RID: 63441 RVA: 0x002421A0 File Offset: 0x002403A0
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

		// Token: 0x0600F7D2 RID: 63442 RVA: 0x002421A9 File Offset: 0x002403A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportSetCurUseTrialRoleV2Response);
		}

		// Token: 0x0600F7D3 RID: 63443 RVA: 0x002421B8 File Offset: 0x002403B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportSetCurUseTrialRoleV2Response other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && this.ReplacedCurRole == other.ReplacedCurRole && this.ReplacedRoleId == other.ReplacedRoleId && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F7D4 RID: 63444 RVA: 0x00242238 File Offset: 0x00240438
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

		// Token: 0x0600F7D5 RID: 63445 RVA: 0x002422DE File Offset: 0x002404DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F7D6 RID: 63446 RVA: 0x002422EB File Offset: 0x002404EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F7D7 RID: 63447 RVA: 0x002422F4 File Offset: 0x002404F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			if (this.ReplacedCurRole)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.ReplacedCurRole);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Code);
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
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F7D8 RID: 63448 RVA: 0x002423A4 File Offset: 0x002405A4
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

		// Token: 0x0600F7D9 RID: 63449 RVA: 0x00242438 File Offset: 0x00240638
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

		// Token: 0x0600F7DA RID: 63450 RVA: 0x002424DC File Offset: 0x002406DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F7DB RID: 63451 RVA: 0x002424E8 File Offset: 0x002406E8
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
					if (num == 34U)
					{
						if (this.curUseRoleInfo_ == null)
						{
							this.CurUseRoleInfo = new roleInfo();
						}
						input.ReadMessage(this.CurUseRoleInfo);
						continue;
					}
					if (num == 64U)
					{
						this.ReplacedCurRole = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
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
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006363 RID: 25443
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006364 RID: 25444
		public const int CodeFieldNumber = 10;

		// Token: 0x04006365 RID: 25445
		private ErrorCode code_;

		// Token: 0x04006366 RID: 25446
		public const int RoleIdFieldNumber = 12;

		// Token: 0x04006367 RID: 25447
		private int roleId_;

		// Token: 0x04006368 RID: 25448
		public const int ReplacedCurRoleFieldNumber = 8;

		// Token: 0x04006369 RID: 25449
		private bool replacedCurRole_;

		// Token: 0x0400636A RID: 25450
		public const int ReplacedRoleIdFieldNumber = 13;

		// Token: 0x0400636B RID: 25451
		private int replacedRoleId_;

		// Token: 0x0400636C RID: 25452
		public const int CurUseRoleInfoFieldNumber = 4;

		// Token: 0x0400636D RID: 25453
		private roleInfo curUseRoleInfo_;
	}
}
