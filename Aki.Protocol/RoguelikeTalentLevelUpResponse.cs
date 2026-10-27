using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC1 RID: 4033
	[NetMessage(EMessageId.RoguelikeTalentLevelUpResponse)]
	public sealed class RoguelikeTalentLevelUpResponse : IMessage<RoguelikeTalentLevelUpResponse>, IMessage, IEquatable<RoguelikeTalentLevelUpResponse>, IDeepCloneable<RoguelikeTalentLevelUpResponse>, IBufferMessage
	{
		// Token: 0x060158FE RID: 88318 RVA: 0x00321471 File Offset: 0x0031F671
		[NullableContext(1)]
		public static RoguelikeTalentLevelUpResponse Create()
		{
			return new RoguelikeTalentLevelUpResponse();
		}

		// Token: 0x170047E6 RID: 18406
		// (get) Token: 0x060158FF RID: 88319 RVA: 0x00321478 File Offset: 0x0031F678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047E7 RID: 18407
		// (get) Token: 0x06015900 RID: 88320 RVA: 0x0032147B File Offset: 0x0031F67B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeTalentLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x06015901 RID: 88321 RVA: 0x00321482 File Offset: 0x0031F682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentLevelUpResponse()
		{
		}

		// Token: 0x06015902 RID: 88322 RVA: 0x0032148A File Offset: 0x0031F68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentLevelUpResponse(RoguelikeTalentLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015903 RID: 88323 RVA: 0x003214BB File Offset: 0x0031F6BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentLevelUpResponse Clone()
		{
			return new RoguelikeTalentLevelUpResponse(this);
		}

		// Token: 0x170047E8 RID: 18408
		// (get) Token: 0x06015904 RID: 88324 RVA: 0x003214C3 File Offset: 0x0031F6C3
		// (set) Token: 0x06015905 RID: 88325 RVA: 0x003214CB File Offset: 0x0031F6CB
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

		// Token: 0x170047E9 RID: 18409
		// (get) Token: 0x06015906 RID: 88326 RVA: 0x003214D4 File Offset: 0x0031F6D4
		// (set) Token: 0x06015907 RID: 88327 RVA: 0x003214DC File Offset: 0x0031F6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x06015908 RID: 88328 RVA: 0x003214E5 File Offset: 0x0031F6E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeTalentLevelUpResponse);
		}

		// Token: 0x06015909 RID: 88329 RVA: 0x003214F3 File Offset: 0x0031F6F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeTalentLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601590A RID: 88330 RVA: 0x00321534 File Offset: 0x0031F734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601590B RID: 88331 RVA: 0x00321592 File Offset: 0x0031F792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601590C RID: 88332 RVA: 0x0032159F File Offset: 0x0031F79F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601590D RID: 88333 RVA: 0x003215A8 File Offset: 0x0031F7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601590E RID: 88334 RVA: 0x00321604 File Offset: 0x0031F804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601590F RID: 88335 RVA: 0x0032165C File Offset: 0x0031F85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeTalentLevelUpResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015910 RID: 88336 RVA: 0x003216AC File Offset: 0x0031F8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015911 RID: 88337 RVA: 0x003216B8 File Offset: 0x0031F8B8
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
				if (num != 16U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Level = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400818F RID: 33167
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008190 RID: 33168
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04008191 RID: 33169
		private ErrorCode errorCode_;

		// Token: 0x04008192 RID: 33170
		public const int LevelFieldNumber = 4;

		// Token: 0x04008193 RID: 33171
		private int level_;
	}
}
