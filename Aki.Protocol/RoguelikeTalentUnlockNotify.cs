using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB2 RID: 4018
	[NetMessage(EMessageId.RoguelikeTalentUnlockNotify)]
	public sealed class RoguelikeTalentUnlockNotify : IMessage<RoguelikeTalentUnlockNotify>, IMessage, IEquatable<RoguelikeTalentUnlockNotify>, IDeepCloneable<RoguelikeTalentUnlockNotify>, IBufferMessage
	{
		// Token: 0x0601582D RID: 88109 RVA: 0x0032005C File Offset: 0x0031E25C
		[NullableContext(1)]
		public static RoguelikeTalentUnlockNotify Create()
		{
			return new RoguelikeTalentUnlockNotify();
		}

		// Token: 0x170047C0 RID: 18368
		// (get) Token: 0x0601582E RID: 88110 RVA: 0x00320063 File Offset: 0x0031E263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047C1 RID: 18369
		// (get) Token: 0x0601582F RID: 88111 RVA: 0x00320066 File Offset: 0x0031E266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeTalentUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06015830 RID: 88112 RVA: 0x0032006D File Offset: 0x0031E26D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentUnlockNotify()
		{
		}

		// Token: 0x06015831 RID: 88113 RVA: 0x00320075 File Offset: 0x0031E275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentUnlockNotify(RoguelikeTalentUnlockNotify other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015832 RID: 88114 RVA: 0x0032009A File Offset: 0x0031E29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentUnlockNotify Clone()
		{
			return new RoguelikeTalentUnlockNotify(this);
		}

		// Token: 0x170047C2 RID: 18370
		// (get) Token: 0x06015833 RID: 88115 RVA: 0x003200A2 File Offset: 0x0031E2A2
		// (set) Token: 0x06015834 RID: 88116 RVA: 0x003200AA File Offset: 0x0031E2AA
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

		// Token: 0x06015835 RID: 88117 RVA: 0x003200B3 File Offset: 0x0031E2B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeTalentUnlockNotify);
		}

		// Token: 0x06015836 RID: 88118 RVA: 0x003200C1 File Offset: 0x0031E2C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeTalentUnlockNotify other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015837 RID: 88119 RVA: 0x003200F0 File Offset: 0x0031E2F0
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

		// Token: 0x06015838 RID: 88120 RVA: 0x0032012F File Offset: 0x0031E32F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015839 RID: 88121 RVA: 0x0032013C File Offset: 0x0031E33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601583A RID: 88122 RVA: 0x00320145 File Offset: 0x0031E345
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

		// Token: 0x0601583B RID: 88123 RVA: 0x00320178 File Offset: 0x0031E378
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

		// Token: 0x0601583C RID: 88124 RVA: 0x003201B6 File Offset: 0x0031E3B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeTalentUnlockNotify other)
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

		// Token: 0x0601583D RID: 88125 RVA: 0x003201E7 File Offset: 0x0031E3E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601583E RID: 88126 RVA: 0x003201F0 File Offset: 0x0031E3F0
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

		// Token: 0x040081BE RID: 33214
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081BF RID: 33215
		public const int SkillIdFieldNumber = 7;

		// Token: 0x040081C0 RID: 33216
		private int skillId_;
	}
}
