using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC0 RID: 4032
	[NetMessage(EMessageId.RoguelikeTalentLevelUpRequest)]
	public sealed class RoguelikeTalentLevelUpRequest : IMessage<RoguelikeTalentLevelUpRequest>, IMessage, IEquatable<RoguelikeTalentLevelUpRequest>, IDeepCloneable<RoguelikeTalentLevelUpRequest>, IBufferMessage
	{
		// Token: 0x060158EC RID: 88300 RVA: 0x00321296 File Offset: 0x0031F496
		[NullableContext(1)]
		public static RoguelikeTalentLevelUpRequest Create()
		{
			return new RoguelikeTalentLevelUpRequest();
		}

		// Token: 0x170047E3 RID: 18403
		// (get) Token: 0x060158ED RID: 88301 RVA: 0x0032129D File Offset: 0x0031F49D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047E4 RID: 18404
		// (get) Token: 0x060158EE RID: 88302 RVA: 0x003212A0 File Offset: 0x0031F4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeTalentLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x060158EF RID: 88303 RVA: 0x003212A7 File Offset: 0x0031F4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentLevelUpRequest()
		{
		}

		// Token: 0x060158F0 RID: 88304 RVA: 0x003212AF File Offset: 0x0031F4AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentLevelUpRequest(RoguelikeTalentLevelUpRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060158F1 RID: 88305 RVA: 0x003212D4 File Offset: 0x0031F4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentLevelUpRequest Clone()
		{
			return new RoguelikeTalentLevelUpRequest(this);
		}

		// Token: 0x170047E5 RID: 18405
		// (get) Token: 0x060158F2 RID: 88306 RVA: 0x003212DC File Offset: 0x0031F4DC
		// (set) Token: 0x060158F3 RID: 88307 RVA: 0x003212E4 File Offset: 0x0031F4E4
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

		// Token: 0x060158F4 RID: 88308 RVA: 0x003212ED File Offset: 0x0031F4ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeTalentLevelUpRequest);
		}

		// Token: 0x060158F5 RID: 88309 RVA: 0x003212FB File Offset: 0x0031F4FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeTalentLevelUpRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060158F6 RID: 88310 RVA: 0x0032132C File Offset: 0x0031F52C
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

		// Token: 0x060158F7 RID: 88311 RVA: 0x0032136B File Offset: 0x0031F56B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060158F8 RID: 88312 RVA: 0x00321378 File Offset: 0x0031F578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060158F9 RID: 88313 RVA: 0x00321381 File Offset: 0x0031F581
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

		// Token: 0x060158FA RID: 88314 RVA: 0x003213B4 File Offset: 0x0031F5B4
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

		// Token: 0x060158FB RID: 88315 RVA: 0x003213F2 File Offset: 0x0031F5F2
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

		// Token: 0x060158FC RID: 88316 RVA: 0x00321423 File Offset: 0x0031F623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060158FD RID: 88317 RVA: 0x0032142C File Offset: 0x0031F62C
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

		// Token: 0x0400818C RID: 33164
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400818D RID: 33165
		public const int SkillIdFieldNumber = 7;

		// Token: 0x0400818E RID: 33166
		private int skillId_;
	}
}
