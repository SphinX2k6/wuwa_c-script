using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FFA RID: 4090
	[NetMessage(EMessageId.RogueResTalentSkillLevelRequest)]
	public sealed class RogueResTalentSkillLevelRequest : IMessage<RogueResTalentSkillLevelRequest>, IMessage, IEquatable<RogueResTalentSkillLevelRequest>, IDeepCloneable<RogueResTalentSkillLevelRequest>, IBufferMessage
	{
		// Token: 0x06015E70 RID: 89712 RVA: 0x0032FFE5 File Offset: 0x0032E1E5
		[NullableContext(1)]
		public static RogueResTalentSkillLevelRequest Create()
		{
			return new RogueResTalentSkillLevelRequest();
		}

		// Token: 0x1700493D RID: 18749
		// (get) Token: 0x06015E71 RID: 89713 RVA: 0x0032FFEC File Offset: 0x0032E1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700493E RID: 18750
		// (get) Token: 0x06015E72 RID: 89714 RVA: 0x0032FFEF File Offset: 0x0032E1EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResTalentSkillLevelRequest.Descriptor;
			}
		}

		// Token: 0x06015E73 RID: 89715 RVA: 0x0032FFF6 File Offset: 0x0032E1F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTalentSkillLevelRequest()
		{
		}

		// Token: 0x06015E74 RID: 89716 RVA: 0x0032FFFE File Offset: 0x0032E1FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTalentSkillLevelRequest(RogueResTalentSkillLevelRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015E75 RID: 89717 RVA: 0x00330023 File Offset: 0x0032E223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTalentSkillLevelRequest Clone()
		{
			return new RogueResTalentSkillLevelRequest(this);
		}

		// Token: 0x1700493F RID: 18751
		// (get) Token: 0x06015E76 RID: 89718 RVA: 0x0033002B File Offset: 0x0032E22B
		// (set) Token: 0x06015E77 RID: 89719 RVA: 0x00330033 File Offset: 0x0032E233
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

		// Token: 0x06015E78 RID: 89720 RVA: 0x0033003C File Offset: 0x0032E23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResTalentSkillLevelRequest);
		}

		// Token: 0x06015E79 RID: 89721 RVA: 0x0033004A File Offset: 0x0032E24A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResTalentSkillLevelRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015E7A RID: 89722 RVA: 0x00330078 File Offset: 0x0032E278
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

		// Token: 0x06015E7B RID: 89723 RVA: 0x003300B7 File Offset: 0x0032E2B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015E7C RID: 89724 RVA: 0x003300C4 File Offset: 0x0032E2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015E7D RID: 89725 RVA: 0x003300CD File Offset: 0x0032E2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015E7E RID: 89726 RVA: 0x00330100 File Offset: 0x0032E300
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

		// Token: 0x06015E7F RID: 89727 RVA: 0x0033013E File Offset: 0x0032E33E
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

		// Token: 0x06015E80 RID: 89728 RVA: 0x0033016F File Offset: 0x0032E36F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015E81 RID: 89729 RVA: 0x00330178 File Offset: 0x0032E378
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040083F5 RID: 33781
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083F6 RID: 33782
		public const int SkillIdFieldNumber = 8;

		// Token: 0x040083F7 RID: 33783
		private int skillId_;
	}
}
