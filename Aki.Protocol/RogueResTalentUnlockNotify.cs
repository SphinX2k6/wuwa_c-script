using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200100C RID: 4108
	[NetMessage(EMessageId.RogueResTalentUnlockNotify)]
	public sealed class RogueResTalentUnlockNotify : IMessage<RogueResTalentUnlockNotify>, IMessage, IEquatable<RogueResTalentUnlockNotify>, IDeepCloneable<RogueResTalentUnlockNotify>, IBufferMessage
	{
		// Token: 0x06015F7B RID: 89979 RVA: 0x00331B18 File Offset: 0x0032FD18
		[NullableContext(1)]
		public static RogueResTalentUnlockNotify Create()
		{
			return new RogueResTalentUnlockNotify();
		}

		// Token: 0x1700496E RID: 18798
		// (get) Token: 0x06015F7C RID: 89980 RVA: 0x00331B1F File Offset: 0x0032FD1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700496F RID: 18799
		// (get) Token: 0x06015F7D RID: 89981 RVA: 0x00331B22 File Offset: 0x0032FD22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResTalentUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06015F7E RID: 89982 RVA: 0x00331B29 File Offset: 0x0032FD29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTalentUnlockNotify()
		{
		}

		// Token: 0x06015F7F RID: 89983 RVA: 0x00331B31 File Offset: 0x0032FD31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTalentUnlockNotify(RogueResTalentUnlockNotify other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015F80 RID: 89984 RVA: 0x00331B56 File Offset: 0x0032FD56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTalentUnlockNotify Clone()
		{
			return new RogueResTalentUnlockNotify(this);
		}

		// Token: 0x17004970 RID: 18800
		// (get) Token: 0x06015F81 RID: 89985 RVA: 0x00331B5E File Offset: 0x0032FD5E
		// (set) Token: 0x06015F82 RID: 89986 RVA: 0x00331B66 File Offset: 0x0032FD66
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

		// Token: 0x06015F83 RID: 89987 RVA: 0x00331B6F File Offset: 0x0032FD6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResTalentUnlockNotify);
		}

		// Token: 0x06015F84 RID: 89988 RVA: 0x00331B7D File Offset: 0x0032FD7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResTalentUnlockNotify other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015F85 RID: 89989 RVA: 0x00331BAC File Offset: 0x0032FDAC
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

		// Token: 0x06015F86 RID: 89990 RVA: 0x00331BEB File Offset: 0x0032FDEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015F87 RID: 89991 RVA: 0x00331BF8 File Offset: 0x0032FDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015F88 RID: 89992 RVA: 0x00331C01 File Offset: 0x0032FE01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015F89 RID: 89993 RVA: 0x00331C34 File Offset: 0x0032FE34
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

		// Token: 0x06015F8A RID: 89994 RVA: 0x00331C72 File Offset: 0x0032FE72
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

		// Token: 0x06015F8B RID: 89995 RVA: 0x00331CA3 File Offset: 0x0032FEA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015F8C RID: 89996 RVA: 0x00331CAC File Offset: 0x0032FEAC
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040083D3 RID: 33747
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083D4 RID: 33748
		public const int SkillIdFieldNumber = 15;

		// Token: 0x040083D5 RID: 33749
		private int skillId_;
	}
}
