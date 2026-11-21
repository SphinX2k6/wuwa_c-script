using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200135B RID: 4955
	[NetMessage(EMessageId.SurvivorsTalentUnlockNotify)]
	public sealed class SurvivorsTalentUnlockNotify : IMessage<SurvivorsTalentUnlockNotify>, IMessage, IEquatable<SurvivorsTalentUnlockNotify>, IDeepCloneable<SurvivorsTalentUnlockNotify>, IBufferMessage
	{
		// Token: 0x0601A660 RID: 108128 RVA: 0x003D9028 File Offset: 0x003D7228
		[NullableContext(1)]
		public static SurvivorsTalentUnlockNotify Create()
		{
			return new SurvivorsTalentUnlockNotify();
		}

		// Token: 0x17005965 RID: 22885
		// (get) Token: 0x0601A661 RID: 108129 RVA: 0x003D902F File Offset: 0x003D722F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005966 RID: 22886
		// (get) Token: 0x0601A662 RID: 108130 RVA: 0x003D9032 File Offset: 0x003D7232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsTalentUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0601A663 RID: 108131 RVA: 0x003D9039 File Offset: 0x003D7239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTalentUnlockNotify()
		{
		}

		// Token: 0x0601A664 RID: 108132 RVA: 0x003D9041 File Offset: 0x003D7241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTalentUnlockNotify(SurvivorsTalentUnlockNotify other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A665 RID: 108133 RVA: 0x003D9066 File Offset: 0x003D7266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTalentUnlockNotify Clone()
		{
			return new SurvivorsTalentUnlockNotify(this);
		}

		// Token: 0x17005967 RID: 22887
		// (get) Token: 0x0601A666 RID: 108134 RVA: 0x003D906E File Offset: 0x003D726E
		// (set) Token: 0x0601A667 RID: 108135 RVA: 0x003D9076 File Offset: 0x003D7276
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

		// Token: 0x0601A668 RID: 108136 RVA: 0x003D907F File Offset: 0x003D727F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsTalentUnlockNotify);
		}

		// Token: 0x0601A669 RID: 108137 RVA: 0x003D908D File Offset: 0x003D728D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsTalentUnlockNotify other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A66A RID: 108138 RVA: 0x003D90BC File Offset: 0x003D72BC
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

		// Token: 0x0601A66B RID: 108139 RVA: 0x003D90FB File Offset: 0x003D72FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A66C RID: 108140 RVA: 0x003D9108 File Offset: 0x003D7308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A66D RID: 108141 RVA: 0x003D9111 File Offset: 0x003D7311
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

		// Token: 0x0601A66E RID: 108142 RVA: 0x003D9144 File Offset: 0x003D7344
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

		// Token: 0x0601A66F RID: 108143 RVA: 0x003D9182 File Offset: 0x003D7382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsTalentUnlockNotify other)
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

		// Token: 0x0601A670 RID: 108144 RVA: 0x003D91B3 File Offset: 0x003D73B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A671 RID: 108145 RVA: 0x003D91BC File Offset: 0x003D73BC
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

		// Token: 0x04009AFB RID: 39675
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AFC RID: 39676
		public const int SkillIdFieldNumber = 7;

		// Token: 0x04009AFD RID: 39677
		private int skillId_;
	}
}
