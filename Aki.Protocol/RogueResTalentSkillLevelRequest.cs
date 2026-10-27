using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200100A RID: 4106
	[NetMessage(EMessageId.RogueResTalentSkillLevelRequest)]
	public sealed class RogueResTalentSkillLevelRequest : IMessage<RogueResTalentSkillLevelRequest>, IMessage, IEquatable<RogueResTalentSkillLevelRequest>, IDeepCloneable<RogueResTalentSkillLevelRequest>, IBufferMessage
	{
		// Token: 0x06015F55 RID: 89941 RVA: 0x003316A1 File Offset: 0x0032F8A1
		[NullableContext(1)]
		public static RogueResTalentSkillLevelRequest Create()
		{
			return new RogueResTalentSkillLevelRequest();
		}

		// Token: 0x17004967 RID: 18791
		// (get) Token: 0x06015F56 RID: 89942 RVA: 0x003316A8 File Offset: 0x0032F8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004968 RID: 18792
		// (get) Token: 0x06015F57 RID: 89943 RVA: 0x003316AB File Offset: 0x0032F8AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResTalentSkillLevelRequest.Descriptor;
			}
		}

		// Token: 0x06015F58 RID: 89944 RVA: 0x003316B2 File Offset: 0x0032F8B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTalentSkillLevelRequest()
		{
		}

		// Token: 0x06015F59 RID: 89945 RVA: 0x003316BA File Offset: 0x0032F8BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTalentSkillLevelRequest(RogueResTalentSkillLevelRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015F5A RID: 89946 RVA: 0x003316DF File Offset: 0x0032F8DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTalentSkillLevelRequest Clone()
		{
			return new RogueResTalentSkillLevelRequest(this);
		}

		// Token: 0x17004969 RID: 18793
		// (get) Token: 0x06015F5B RID: 89947 RVA: 0x003316E7 File Offset: 0x0032F8E7
		// (set) Token: 0x06015F5C RID: 89948 RVA: 0x003316EF File Offset: 0x0032F8EF
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

		// Token: 0x06015F5D RID: 89949 RVA: 0x003316F8 File Offset: 0x0032F8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResTalentSkillLevelRequest);
		}

		// Token: 0x06015F5E RID: 89950 RVA: 0x00331706 File Offset: 0x0032F906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResTalentSkillLevelRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015F5F RID: 89951 RVA: 0x00331734 File Offset: 0x0032F934
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

		// Token: 0x06015F60 RID: 89952 RVA: 0x00331773 File Offset: 0x0032F973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015F61 RID: 89953 RVA: 0x00331780 File Offset: 0x0032F980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015F62 RID: 89954 RVA: 0x00331789 File Offset: 0x0032F989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015F63 RID: 89955 RVA: 0x003317BC File Offset: 0x0032F9BC
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

		// Token: 0x06015F64 RID: 89956 RVA: 0x003317FA File Offset: 0x0032F9FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResTalentSkillLevelRequest other)
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

		// Token: 0x06015F65 RID: 89957 RVA: 0x0033182B File Offset: 0x0032FA2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015F66 RID: 89958 RVA: 0x00331834 File Offset: 0x0032FA34
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040083CB RID: 33739
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083CC RID: 33740
		public const int SkillIdFieldNumber = 5;

		// Token: 0x040083CD RID: 33741
		private int skillId_;
	}
}
