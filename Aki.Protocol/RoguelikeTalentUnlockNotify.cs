using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC2 RID: 4034
	[NetMessage(EMessageId.RoguelikeTalentUnlockNotify)]
	public sealed class RoguelikeTalentUnlockNotify : IMessage<RoguelikeTalentUnlockNotify>, IMessage, IEquatable<RoguelikeTalentUnlockNotify>, IDeepCloneable<RoguelikeTalentUnlockNotify>, IBufferMessage
	{
		// Token: 0x06015912 RID: 88338 RVA: 0x00321710 File Offset: 0x0031F910
		[NullableContext(1)]
		public static RoguelikeTalentUnlockNotify Create()
		{
			return new RoguelikeTalentUnlockNotify();
		}

		// Token: 0x170047EA RID: 18410
		// (get) Token: 0x06015913 RID: 88339 RVA: 0x00321717 File Offset: 0x0031F917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047EB RID: 18411
		// (get) Token: 0x06015914 RID: 88340 RVA: 0x0032171A File Offset: 0x0031F91A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeTalentUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06015915 RID: 88341 RVA: 0x00321721 File Offset: 0x0031F921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentUnlockNotify()
		{
		}

		// Token: 0x06015916 RID: 88342 RVA: 0x00321729 File Offset: 0x0031F929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentUnlockNotify(RoguelikeTalentUnlockNotify other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015917 RID: 88343 RVA: 0x0032174E File Offset: 0x0031F94E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentUnlockNotify Clone()
		{
			return new RoguelikeTalentUnlockNotify(this);
		}

		// Token: 0x170047EC RID: 18412
		// (get) Token: 0x06015918 RID: 88344 RVA: 0x00321756 File Offset: 0x0031F956
		// (set) Token: 0x06015919 RID: 88345 RVA: 0x0032175E File Offset: 0x0031F95E
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

		// Token: 0x0601591A RID: 88346 RVA: 0x00321767 File Offset: 0x0031F967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeTalentUnlockNotify);
		}

		// Token: 0x0601591B RID: 88347 RVA: 0x00321775 File Offset: 0x0031F975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeTalentUnlockNotify other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601591C RID: 88348 RVA: 0x003217A4 File Offset: 0x0031F9A4
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

		// Token: 0x0601591D RID: 88349 RVA: 0x003217E3 File Offset: 0x0031F9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601591E RID: 88350 RVA: 0x003217F0 File Offset: 0x0031F9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601591F RID: 88351 RVA: 0x003217F9 File Offset: 0x0031F9F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015920 RID: 88352 RVA: 0x0032182C File Offset: 0x0031FA2C
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

		// Token: 0x06015921 RID: 88353 RVA: 0x0032186A File Offset: 0x0031FA6A
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

		// Token: 0x06015922 RID: 88354 RVA: 0x0032189B File Offset: 0x0031FA9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015923 RID: 88355 RVA: 0x003218A4 File Offset: 0x0031FAA4
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008194 RID: 33172
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008195 RID: 33173
		public const int SkillIdFieldNumber = 9;

		// Token: 0x04008196 RID: 33174
		private int skillId_;
	}
}
