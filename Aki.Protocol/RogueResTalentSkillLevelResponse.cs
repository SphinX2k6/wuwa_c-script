using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FFB RID: 4091
	[NetMessage(EMessageId.RogueResTalentSkillLevelResponse)]
	public sealed class RogueResTalentSkillLevelResponse : IMessage<RogueResTalentSkillLevelResponse>, IMessage, IEquatable<RogueResTalentSkillLevelResponse>, IDeepCloneable<RogueResTalentSkillLevelResponse>, IBufferMessage
	{
		// Token: 0x06015E82 RID: 89730 RVA: 0x003301BD File Offset: 0x0032E3BD
		[NullableContext(1)]
		public static RogueResTalentSkillLevelResponse Create()
		{
			return new RogueResTalentSkillLevelResponse();
		}

		// Token: 0x17004940 RID: 18752
		// (get) Token: 0x06015E83 RID: 89731 RVA: 0x003301C4 File Offset: 0x0032E3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004941 RID: 18753
		// (get) Token: 0x06015E84 RID: 89732 RVA: 0x003301C7 File Offset: 0x0032E3C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResTalentSkillLevelResponse.Descriptor;
			}
		}

		// Token: 0x06015E85 RID: 89733 RVA: 0x003301CE File Offset: 0x0032E3CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTalentSkillLevelResponse()
		{
		}

		// Token: 0x06015E86 RID: 89734 RVA: 0x003301D6 File Offset: 0x0032E3D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTalentSkillLevelResponse(RogueResTalentSkillLevelResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015E87 RID: 89735 RVA: 0x00330207 File Offset: 0x0032E407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTalentSkillLevelResponse Clone()
		{
			return new RogueResTalentSkillLevelResponse(this);
		}

		// Token: 0x17004942 RID: 18754
		// (get) Token: 0x06015E88 RID: 89736 RVA: 0x0033020F File Offset: 0x0032E40F
		// (set) Token: 0x06015E89 RID: 89737 RVA: 0x00330217 File Offset: 0x0032E417
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

		// Token: 0x17004943 RID: 18755
		// (get) Token: 0x06015E8A RID: 89738 RVA: 0x00330220 File Offset: 0x0032E420
		// (set) Token: 0x06015E8B RID: 89739 RVA: 0x00330228 File Offset: 0x0032E428
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

		// Token: 0x06015E8C RID: 89740 RVA: 0x00330231 File Offset: 0x0032E431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResTalentSkillLevelResponse);
		}

		// Token: 0x06015E8D RID: 89741 RVA: 0x0033023F File Offset: 0x0032E43F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResTalentSkillLevelResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015E8E RID: 89742 RVA: 0x00330280 File Offset: 0x0032E480
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

		// Token: 0x06015E8F RID: 89743 RVA: 0x003302DE File Offset: 0x0032E4DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015E90 RID: 89744 RVA: 0x003302EB File Offset: 0x0032E4EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015E91 RID: 89745 RVA: 0x003302F4 File Offset: 0x0032E4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Level);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015E92 RID: 89746 RVA: 0x00330350 File Offset: 0x0032E550
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

		// Token: 0x06015E93 RID: 89747 RVA: 0x003303A8 File Offset: 0x0032E5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResTalentSkillLevelResponse other)
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

		// Token: 0x06015E94 RID: 89748 RVA: 0x003303F8 File Offset: 0x0032E5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015E95 RID: 89749 RVA: 0x00330404 File Offset: 0x0032E604
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
				if (num != 48U)
				{
					if (num != 88U)
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
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x040083F8 RID: 33784
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083F9 RID: 33785
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040083FA RID: 33786
		private ErrorCode errorCode_;

		// Token: 0x040083FB RID: 33787
		public const int LevelFieldNumber = 6;

		// Token: 0x040083FC RID: 33788
		private int level_;
	}
}
