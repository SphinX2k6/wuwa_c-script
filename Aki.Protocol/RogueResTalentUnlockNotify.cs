using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FFC RID: 4092
	[NetMessage(EMessageId.RogueResTalentUnlockNotify)]
	public sealed class RogueResTalentUnlockNotify : IMessage<RogueResTalentUnlockNotify>, IMessage, IEquatable<RogueResTalentUnlockNotify>, IDeepCloneable<RogueResTalentUnlockNotify>, IBufferMessage
	{
		// Token: 0x06015E96 RID: 89750 RVA: 0x0033045C File Offset: 0x0032E65C
		[NullableContext(1)]
		public static RogueResTalentUnlockNotify Create()
		{
			return new RogueResTalentUnlockNotify();
		}

		// Token: 0x17004944 RID: 18756
		// (get) Token: 0x06015E97 RID: 89751 RVA: 0x00330463 File Offset: 0x0032E663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004945 RID: 18757
		// (get) Token: 0x06015E98 RID: 89752 RVA: 0x00330466 File Offset: 0x0032E666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResTalentUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06015E99 RID: 89753 RVA: 0x0033046D File Offset: 0x0032E66D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTalentUnlockNotify()
		{
		}

		// Token: 0x06015E9A RID: 89754 RVA: 0x00330475 File Offset: 0x0032E675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTalentUnlockNotify(RogueResTalentUnlockNotify other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015E9B RID: 89755 RVA: 0x0033049A File Offset: 0x0032E69A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTalentUnlockNotify Clone()
		{
			return new RogueResTalentUnlockNotify(this);
		}

		// Token: 0x17004946 RID: 18758
		// (get) Token: 0x06015E9C RID: 89756 RVA: 0x003304A2 File Offset: 0x0032E6A2
		// (set) Token: 0x06015E9D RID: 89757 RVA: 0x003304AA File Offset: 0x0032E6AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x06015E9E RID: 89758 RVA: 0x003304B3 File Offset: 0x0032E6B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResTalentUnlockNotify);
		}

		// Token: 0x06015E9F RID: 89759 RVA: 0x003304C1 File Offset: 0x0032E6C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResTalentUnlockNotify other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015EA0 RID: 89760 RVA: 0x003304F0 File Offset: 0x0032E6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015EA1 RID: 89761 RVA: 0x0033052F File Offset: 0x0032E72F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015EA2 RID: 89762 RVA: 0x0033053C File Offset: 0x0032E73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015EA3 RID: 89763 RVA: 0x00330545 File Offset: 0x0032E745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015EA4 RID: 89764 RVA: 0x00330578 File Offset: 0x0032E778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015EA5 RID: 89765 RVA: 0x003305B6 File Offset: 0x0032E7B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResTalentUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015EA6 RID: 89766 RVA: 0x003305E7 File Offset: 0x0032E7E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015EA7 RID: 89767 RVA: 0x003305F0 File Offset: 0x0032E7F0
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040083FD RID: 33789
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083FE RID: 33790
		public const int SkillIdFieldNumber = 7;

		// Token: 0x040083FF RID: 33791
		private int skillId_;
	}
}
