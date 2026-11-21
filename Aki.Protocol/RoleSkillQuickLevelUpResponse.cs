using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A5 RID: 4261
	[NetMessage(EMessageId.RoleSkillQuickLevelUpResponse)]
	public sealed class RoleSkillQuickLevelUpResponse : IMessage<RoleSkillQuickLevelUpResponse>, IMessage, IEquatable<RoleSkillQuickLevelUpResponse>, IDeepCloneable<RoleSkillQuickLevelUpResponse>, IBufferMessage
	{
		// Token: 0x06016C73 RID: 93299 RVA: 0x0034FC3C File Offset: 0x0034DE3C
		[NullableContext(1)]
		public static RoleSkillQuickLevelUpResponse Create()
		{
			return new RoleSkillQuickLevelUpResponse();
		}

		// Token: 0x17004C57 RID: 19543
		// (get) Token: 0x06016C74 RID: 93300 RVA: 0x0034FC43 File Offset: 0x0034DE43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C58 RID: 19544
		// (get) Token: 0x06016C75 RID: 93301 RVA: 0x0034FC46 File Offset: 0x0034DE46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillQuickLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x06016C76 RID: 93302 RVA: 0x0034FC4D File Offset: 0x0034DE4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillQuickLevelUpResponse()
		{
		}

		// Token: 0x06016C77 RID: 93303 RVA: 0x0034FC58 File Offset: 0x0034DE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillQuickLevelUpResponse(RoleSkillQuickLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.roleInfo_ = ((other.roleInfo_ != null) ? other.roleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016C78 RID: 93304 RVA: 0x0034FCA4 File Offset: 0x0034DEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillQuickLevelUpResponse Clone()
		{
			return new RoleSkillQuickLevelUpResponse(this);
		}

		// Token: 0x17004C59 RID: 19545
		// (get) Token: 0x06016C79 RID: 93305 RVA: 0x0034FCAC File Offset: 0x0034DEAC
		// (set) Token: 0x06016C7A RID: 93306 RVA: 0x0034FCB4 File Offset: 0x0034DEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17004C5A RID: 19546
		// (get) Token: 0x06016C7B RID: 93307 RVA: 0x0034FCBD File Offset: 0x0034DEBD
		// (set) Token: 0x06016C7C RID: 93308 RVA: 0x0034FCC5 File Offset: 0x0034DEC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public roleInfo RoleInfo
		{
			get
			{
				return this.roleInfo_;
			}
			set
			{
				this.roleInfo_ = value;
			}
		}

		// Token: 0x06016C7D RID: 93309 RVA: 0x0034FCCE File Offset: 0x0034DECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillQuickLevelUpResponse);
		}

		// Token: 0x06016C7E RID: 93310 RVA: 0x0034FCDC File Offset: 0x0034DEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillQuickLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.RoleInfo, other.RoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016C7F RID: 93311 RVA: 0x0034FD2C File Offset: 0x0034DF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.roleInfo_ != null)
			{
				num ^= this.RoleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016C80 RID: 93312 RVA: 0x0034FD87 File Offset: 0x0034DF87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016C81 RID: 93313 RVA: 0x0034FD94 File Offset: 0x0034DF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016C82 RID: 93314 RVA: 0x0034FDA0 File Offset: 0x0034DFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roleInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RoleInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016C83 RID: 93315 RVA: 0x0034FDFC File Offset: 0x0034DFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.roleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016C84 RID: 93316 RVA: 0x0034FE54 File Offset: 0x0034E054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkillQuickLevelUpResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.roleInfo_ != null)
			{
				if (this.roleInfo_ == null)
				{
					this.RoleInfo = new roleInfo();
				}
				this.RoleInfo.MergeFrom(other.RoleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016C85 RID: 93317 RVA: 0x0034FEBC File Offset: 0x0034E0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016C86 RID: 93318 RVA: 0x0034FEC8 File Offset: 0x0034E0C8
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
				if (num != 58U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.roleInfo_ == null)
					{
						this.RoleInfo = new roleInfo();
					}
					input.ReadMessage(this.RoleInfo);
				}
			}
		}

		// Token: 0x04008868 RID: 34920
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008869 RID: 34921
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400886A RID: 34922
		private ErrorCode errorCode_;

		// Token: 0x0400886B RID: 34923
		public const int RoleInfoFieldNumber = 7;

		// Token: 0x0400886C RID: 34924
		private roleInfo roleInfo_;
	}
}
