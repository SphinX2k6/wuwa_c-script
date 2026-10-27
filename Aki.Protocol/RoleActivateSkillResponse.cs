using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001055 RID: 4181
	[NetMessage(EMessageId.RoleActivateSkillResponse)]
	public sealed class RoleActivateSkillResponse : IMessage<RoleActivateSkillResponse>, IMessage, IEquatable<RoleActivateSkillResponse>, IDeepCloneable<RoleActivateSkillResponse>, IBufferMessage
	{
		// Token: 0x0601656A RID: 91498 RVA: 0x0033EE34 File Offset: 0x0033D034
		[NullableContext(1)]
		public static RoleActivateSkillResponse Create()
		{
			return new RoleActivateSkillResponse();
		}

		// Token: 0x17004AB6 RID: 19126
		// (get) Token: 0x0601656B RID: 91499 RVA: 0x0033EE3B File Offset: 0x0033D03B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AB7 RID: 19127
		// (get) Token: 0x0601656C RID: 91500 RVA: 0x0033EE3E File Offset: 0x0033D03E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleActivateSkillResponse.Descriptor;
			}
		}

		// Token: 0x0601656D RID: 91501 RVA: 0x0033EE45 File Offset: 0x0033D045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleActivateSkillResponse()
		{
		}

		// Token: 0x0601656E RID: 91502 RVA: 0x0033EE50 File Offset: 0x0033D050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleActivateSkillResponse(RoleActivateSkillResponse other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_;
			this.skillInfo_ = ((other.skillInfo_ != null) ? other.skillInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601656F RID: 91503 RVA: 0x0033EEA8 File Offset: 0x0033D0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleActivateSkillResponse Clone()
		{
			return new RoleActivateSkillResponse(this);
		}

		// Token: 0x17004AB8 RID: 19128
		// (get) Token: 0x06016570 RID: 91504 RVA: 0x0033EEB0 File Offset: 0x0033D0B0
		// (set) Token: 0x06016571 RID: 91505 RVA: 0x0033EEB8 File Offset: 0x0033D0B8
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

		// Token: 0x17004AB9 RID: 19129
		// (get) Token: 0x06016572 RID: 91506 RVA: 0x0033EEC1 File Offset: 0x0033D0C1
		// (set) Token: 0x06016573 RID: 91507 RVA: 0x0033EEC9 File Offset: 0x0033D0C9
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

		// Token: 0x17004ABA RID: 19130
		// (get) Token: 0x06016574 RID: 91508 RVA: 0x0033EED2 File Offset: 0x0033D0D2
		// (set) Token: 0x06016575 RID: 91509 RVA: 0x0033EEDA File Offset: 0x0033D0DA
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

		// Token: 0x06016576 RID: 91510 RVA: 0x0033EEE3 File Offset: 0x0033D0E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleActivateSkillResponse);
		}

		// Token: 0x06016577 RID: 91511 RVA: 0x0033EEF4 File Offset: 0x0033D0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleActivateSkillResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && object.Equals(this.SkillInfo, other.SkillInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016578 RID: 91512 RVA: 0x0033EF54 File Offset: 0x0033D154
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

		// Token: 0x06016579 RID: 91513 RVA: 0x0033EFC8 File Offset: 0x0033D1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601657A RID: 91514 RVA: 0x0033EFD5 File Offset: 0x0033D1D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601657B RID: 91515 RVA: 0x0033EFE0 File Offset: 0x0033D1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.skillInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SkillInfo);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Code);
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

		// Token: 0x0601657C RID: 91516 RVA: 0x0033F058 File Offset: 0x0033D258
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

		// Token: 0x0601657D RID: 91517 RVA: 0x0033F0C8 File Offset: 0x0033D2C8
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

		// Token: 0x0601657E RID: 91518 RVA: 0x0033F144 File Offset: 0x0033D344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601657F RID: 91519 RVA: 0x0033F150 File Offset: 0x0033D350
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
				if (num != 26U)
				{
					if (num != 104U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x04008599 RID: 34201
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400859A RID: 34202
		public const int CodeFieldNumber = 13;

		// Token: 0x0400859B RID: 34203
		private ErrorCode code_;

		// Token: 0x0400859C RID: 34204
		public const int RoleIdFieldNumber = 15;

		// Token: 0x0400859D RID: 34205
		private int roleId_;

		// Token: 0x0400859E RID: 34206
		public const int SkillInfoFieldNumber = 3;

		// Token: 0x0400859F RID: 34207
		private ArrayIntInt skillInfo_;
	}
}
