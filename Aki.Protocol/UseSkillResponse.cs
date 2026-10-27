using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014BB RID: 5307
	[NetMessage(EMessageId.UseSkillResponse)]
	public sealed class UseSkillResponse : IMessage<UseSkillResponse>, IMessage, IEquatable<UseSkillResponse>, IDeepCloneable<UseSkillResponse>, IBufferMessage
	{
		// Token: 0x0601C111 RID: 114961 RVA: 0x0040EC18 File Offset: 0x0040CE18
		[NullableContext(1)]
		public static UseSkillResponse Create()
		{
			return new UseSkillResponse();
		}

		// Token: 0x17005E9B RID: 24219
		// (get) Token: 0x0601C112 RID: 114962 RVA: 0x0040EC1F File Offset: 0x0040CE1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E9C RID: 24220
		// (get) Token: 0x0601C113 RID: 114963 RVA: 0x0040EC22 File Offset: 0x0040CE22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseSkillResponse.Descriptor;
			}
		}

		// Token: 0x0601C114 RID: 114964 RVA: 0x0040EC29 File Offset: 0x0040CE29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillResponse()
		{
		}

		// Token: 0x0601C115 RID: 114965 RVA: 0x0040EC34 File Offset: 0x0040CE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillResponse(UseSkillResponse other) : this()
		{
			this.useSkillInfo_ = ((other.useSkillInfo_ != null) ? other.useSkillInfo_.Clone() : null);
			this.skillSingleId_ = other.skillSingleId_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C116 RID: 114966 RVA: 0x0040EC8C File Offset: 0x0040CE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillResponse Clone()
		{
			return new UseSkillResponse(this);
		}

		// Token: 0x17005E9D RID: 24221
		// (get) Token: 0x0601C117 RID: 114967 RVA: 0x0040EC94 File Offset: 0x0040CE94
		// (set) Token: 0x0601C118 RID: 114968 RVA: 0x0040EC9C File Offset: 0x0040CE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillInformation UseSkillInfo
		{
			get
			{
				return this.useSkillInfo_;
			}
			set
			{
				this.useSkillInfo_ = value;
			}
		}

		// Token: 0x17005E9E RID: 24222
		// (get) Token: 0x0601C119 RID: 114969 RVA: 0x0040ECA5 File Offset: 0x0040CEA5
		// (set) Token: 0x0601C11A RID: 114970 RVA: 0x0040ECAD File Offset: 0x0040CEAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillSingleId
		{
			get
			{
				return this.skillSingleId_;
			}
			set
			{
				this.skillSingleId_ = value;
			}
		}

		// Token: 0x17005E9F RID: 24223
		// (get) Token: 0x0601C11B RID: 114971 RVA: 0x0040ECB6 File Offset: 0x0040CEB6
		// (set) Token: 0x0601C11C RID: 114972 RVA: 0x0040ECBE File Offset: 0x0040CEBE
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

		// Token: 0x0601C11D RID: 114973 RVA: 0x0040ECC7 File Offset: 0x0040CEC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseSkillResponse);
		}

		// Token: 0x0601C11E RID: 114974 RVA: 0x0040ECD8 File Offset: 0x0040CED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseSkillResponse other)
		{
			return other != null && (other == this || (object.Equals(this.UseSkillInfo, other.UseSkillInfo) && this.SkillSingleId == other.SkillSingleId && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C11F RID: 114975 RVA: 0x0040ED38 File Offset: 0x0040CF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.useSkillInfo_ != null)
			{
				num ^= this.UseSkillInfo.GetHashCode();
			}
			if (this.SkillSingleId != 0)
			{
				num ^= this.SkillSingleId.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C120 RID: 114976 RVA: 0x0040EDAC File Offset: 0x0040CFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C121 RID: 114977 RVA: 0x0040EDB9 File Offset: 0x0040CFB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C122 RID: 114978 RVA: 0x0040EDC4 File Offset: 0x0040CFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.SkillSingleId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SkillSingleId);
			}
			if (this.useSkillInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.UseSkillInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C123 RID: 114979 RVA: 0x0040EE3C File Offset: 0x0040D03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.useSkillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UseSkillInfo);
			}
			if (this.SkillSingleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillSingleId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C124 RID: 114980 RVA: 0x0040EEAC File Offset: 0x0040D0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseSkillResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.useSkillInfo_ != null)
			{
				if (this.useSkillInfo_ == null)
				{
					this.UseSkillInfo = new UseSkillInformation();
				}
				this.UseSkillInfo.MergeFrom(other.UseSkillInfo);
			}
			if (other.SkillSingleId != 0)
			{
				this.SkillSingleId = other.SkillSingleId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C125 RID: 114981 RVA: 0x0040EF28 File Offset: 0x0040D128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C126 RID: 114982 RVA: 0x0040EF34 File Offset: 0x0040D134
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
					if (num != 104U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.useSkillInfo_ == null)
							{
								this.UseSkillInfo = new UseSkillInformation();
							}
							input.ReadMessage(this.UseSkillInfo);
						}
					}
					else
					{
						this.SkillSingleId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A130 RID: 41264
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A131 RID: 41265
		public const int UseSkillInfoFieldNumber = 15;

		// Token: 0x0400A132 RID: 41266
		private UseSkillInformation useSkillInfo_;

		// Token: 0x0400A133 RID: 41267
		public const int SkillSingleIdFieldNumber = 13;

		// Token: 0x0400A134 RID: 41268
		private int skillSingleId_;

		// Token: 0x0400A135 RID: 41269
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400A136 RID: 41270
		private ErrorCode errorCode_;
	}
}
