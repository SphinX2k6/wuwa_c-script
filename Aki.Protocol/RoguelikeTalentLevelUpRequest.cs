using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB0 RID: 4016
	[NetMessage(EMessageId.RoguelikeTalentLevelUpRequest)]
	public sealed class RoguelikeTalentLevelUpRequest : IMessage<RoguelikeTalentLevelUpRequest>, IMessage, IEquatable<RoguelikeTalentLevelUpRequest>, IDeepCloneable<RoguelikeTalentLevelUpRequest>, IBufferMessage
	{
		// Token: 0x06015807 RID: 88071 RVA: 0x0031FBE2 File Offset: 0x0031DDE2
		[NullableContext(1)]
		public static RoguelikeTalentLevelUpRequest Create()
		{
			return new RoguelikeTalentLevelUpRequest();
		}

		// Token: 0x170047B9 RID: 18361
		// (get) Token: 0x06015808 RID: 88072 RVA: 0x0031FBE9 File Offset: 0x0031DDE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047BA RID: 18362
		// (get) Token: 0x06015809 RID: 88073 RVA: 0x0031FBEC File Offset: 0x0031DDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeTalentLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0601580A RID: 88074 RVA: 0x0031FBF3 File Offset: 0x0031DDF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentLevelUpRequest()
		{
		}

		// Token: 0x0601580B RID: 88075 RVA: 0x0031FBFB File Offset: 0x0031DDFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentLevelUpRequest(RoguelikeTalentLevelUpRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601580C RID: 88076 RVA: 0x0031FC20 File Offset: 0x0031DE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentLevelUpRequest Clone()
		{
			return new RoguelikeTalentLevelUpRequest(this);
		}

		// Token: 0x170047BB RID: 18363
		// (get) Token: 0x0601580D RID: 88077 RVA: 0x0031FC28 File Offset: 0x0031DE28
		// (set) Token: 0x0601580E RID: 88078 RVA: 0x0031FC30 File Offset: 0x0031DE30
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

		// Token: 0x0601580F RID: 88079 RVA: 0x0031FC39 File Offset: 0x0031DE39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeTalentLevelUpRequest);
		}

		// Token: 0x06015810 RID: 88080 RVA: 0x0031FC47 File Offset: 0x0031DE47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeTalentLevelUpRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015811 RID: 88081 RVA: 0x0031FC78 File Offset: 0x0031DE78
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

		// Token: 0x06015812 RID: 88082 RVA: 0x0031FCB7 File Offset: 0x0031DEB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015813 RID: 88083 RVA: 0x0031FCC4 File Offset: 0x0031DEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015814 RID: 88084 RVA: 0x0031FCCD File Offset: 0x0031DECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015815 RID: 88085 RVA: 0x0031FD00 File Offset: 0x0031DF00
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

		// Token: 0x06015816 RID: 88086 RVA: 0x0031FD3E File Offset: 0x0031DF3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeTalentLevelUpRequest other)
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

		// Token: 0x06015817 RID: 88087 RVA: 0x0031FD6F File Offset: 0x0031DF6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015818 RID: 88088 RVA: 0x0031FD78 File Offset: 0x0031DF78
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040081B6 RID: 33206
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081B7 RID: 33207
		public const int SkillIdFieldNumber = 2;

		// Token: 0x040081B8 RID: 33208
		private int skillId_;
	}
}
