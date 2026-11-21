using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001045 RID: 4165
	[NetMessage(EMessageId.RoleActivateSkillResponse)]
	public sealed class RoleActivateSkillResponse : IMessage<RoleActivateSkillResponse>, IMessage, IEquatable<RoleActivateSkillResponse>, IDeepCloneable<RoleActivateSkillResponse>, IBufferMessage
	{
		// Token: 0x06016485 RID: 91269 RVA: 0x0033D763 File Offset: 0x0033B963
		[NullableContext(1)]
		public static RoleActivateSkillResponse Create()
		{
			return new RoleActivateSkillResponse();
		}

		// Token: 0x17004A8C RID: 19084
		// (get) Token: 0x06016486 RID: 91270 RVA: 0x0033D76A File Offset: 0x0033B96A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A8D RID: 19085
		// (get) Token: 0x06016487 RID: 91271 RVA: 0x0033D76D File Offset: 0x0033B96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleActivateSkillResponse.Descriptor;
			}
		}

		// Token: 0x06016488 RID: 91272 RVA: 0x0033D774 File Offset: 0x0033B974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleActivateSkillResponse()
		{
		}

		// Token: 0x06016489 RID: 91273 RVA: 0x0033D77C File Offset: 0x0033B97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleActivateSkillResponse(RoleActivateSkillResponse other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_;
			this.skillInfo_ = ((other.skillInfo_ != null) ? other.skillInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601648A RID: 91274 RVA: 0x0033D7D4 File Offset: 0x0033B9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleActivateSkillResponse Clone()
		{
			return new RoleActivateSkillResponse(this);
		}

		// Token: 0x17004A8E RID: 19086
		// (get) Token: 0x0601648B RID: 91275 RVA: 0x0033D7DC File Offset: 0x0033B9DC
		// (set) Token: 0x0601648C RID: 91276 RVA: 0x0033D7E4 File Offset: 0x0033B9E4
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

		// Token: 0x17004A8F RID: 19087
		// (get) Token: 0x0601648D RID: 91277 RVA: 0x0033D7ED File Offset: 0x0033B9ED
		// (set) Token: 0x0601648E RID: 91278 RVA: 0x0033D7F5 File Offset: 0x0033B9F5
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

		// Token: 0x17004A90 RID: 19088
		// (get) Token: 0x0601648F RID: 91279 RVA: 0x0033D7FE File Offset: 0x0033B9FE
		// (set) Token: 0x06016490 RID: 91280 RVA: 0x0033D806 File Offset: 0x0033BA06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArrayIntInt SkillInfo
		{
			get
			{
				return this.skillInfo_;
			}
			set
			{
				this.skillInfo_ = value;
			}
		}

		// Token: 0x06016491 RID: 91281 RVA: 0x0033D80F File Offset: 0x0033BA0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleActivateSkillResponse);
		}

		// Token: 0x06016492 RID: 91282 RVA: 0x0033D820 File Offset: 0x0033BA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleActivateSkillResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && object.Equals(this.SkillInfo, other.SkillInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016493 RID: 91283 RVA: 0x0033D880 File Offset: 0x0033BA80
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
			if (this.skillInfo_ != null)
			{
				num ^= this.SkillInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016494 RID: 91284 RVA: 0x0033D8F4 File Offset: 0x0033BAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016495 RID: 91285 RVA: 0x0033D901 File Offset: 0x0033BB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016496 RID: 91286 RVA: 0x0033D90C File Offset: 0x0033BB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.skillInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SkillInfo);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RoleId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016497 RID: 91287 RVA: 0x0033D984 File Offset: 0x0033BB84
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
			if (this.skillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016498 RID: 91288 RVA: 0x0033D9F4 File Offset: 0x0033BBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleActivateSkillResponse other)
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
			if (other.skillInfo_ != null)
			{
				if (this.skillInfo_ == null)
				{
					this.SkillInfo = new ArrayIntInt();
				}
				this.SkillInfo.MergeFrom(other.SkillInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016499 RID: 91289 RVA: 0x0033DA70 File Offset: 0x0033BC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601649A RID: 91290 RVA: 0x0033DA7C File Offset: 0x0033BC7C
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
				if (num != 18U)
				{
					if (num != 88U)
					{
						if (num != 104U)
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
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					if (this.skillInfo_ == null)
					{
						this.SkillInfo = new ArrayIntInt();
					}
					input.ReadMessage(this.SkillInfo);
				}
			}
		}

		// Token: 0x040085C3 RID: 34243
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085C4 RID: 34244
		public const int CodeFieldNumber = 13;

		// Token: 0x040085C5 RID: 34245
		private ErrorCode code_;

		// Token: 0x040085C6 RID: 34246
		public const int RoleIdFieldNumber = 11;

		// Token: 0x040085C7 RID: 34247
		private int roleId_;

		// Token: 0x040085C8 RID: 34248
		public const int SkillInfoFieldNumber = 2;

		// Token: 0x040085C9 RID: 34249
		private ArrayIntInt skillInfo_;
	}
}
