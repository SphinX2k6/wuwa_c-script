using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE6 RID: 4070
	[NetMessage(EMessageId.RogueResMoodUpdateNotify)]
	public sealed class RogueResMoodUpdateNotify : IMessage<RogueResMoodUpdateNotify>, IMessage, IEquatable<RogueResMoodUpdateNotify>, IDeepCloneable<RogueResMoodUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015C8B RID: 89227 RVA: 0x0032A9B4 File Offset: 0x00328BB4
		[NullableContext(1)]
		public static RogueResMoodUpdateNotify Create()
		{
			return new RogueResMoodUpdateNotify();
		}

		// Token: 0x170048BE RID: 18622
		// (get) Token: 0x06015C8C RID: 89228 RVA: 0x0032A9BB File Offset: 0x00328BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048BF RID: 18623
		// (get) Token: 0x06015C8D RID: 89229 RVA: 0x0032A9BE File Offset: 0x00328BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResMoodUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015C8E RID: 89230 RVA: 0x0032A9C5 File Offset: 0x00328BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoodUpdateNotify()
		{
		}

		// Token: 0x06015C8F RID: 89231 RVA: 0x0032A9D0 File Offset: 0x00328BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoodUpdateNotify(RogueResMoodUpdateNotify other) : this()
		{
			this.mood_ = other.mood_;
			this.moodRuleId_ = other.moodRuleId_;
			this.eventType_ = other.eventType_;
			this.ignorePerformance_ = other.ignorePerformance_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015C90 RID: 89232 RVA: 0x0032AA24 File Offset: 0x00328C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoodUpdateNotify Clone()
		{
			return new RogueResMoodUpdateNotify(this);
		}

		// Token: 0x170048C0 RID: 18624
		// (get) Token: 0x06015C91 RID: 89233 RVA: 0x0032AA2C File Offset: 0x00328C2C
		// (set) Token: 0x06015C92 RID: 89234 RVA: 0x0032AA34 File Offset: 0x00328C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Mood
		{
			get
			{
				return this.mood_;
			}
			set
			{
				this.mood_ = value;
			}
		}

		// Token: 0x170048C1 RID: 18625
		// (get) Token: 0x06015C93 RID: 89235 RVA: 0x0032AA3D File Offset: 0x00328C3D
		// (set) Token: 0x06015C94 RID: 89236 RVA: 0x0032AA45 File Offset: 0x00328C45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoodRuleId
		{
			get
			{
				return this.moodRuleId_;
			}
			set
			{
				this.moodRuleId_ = value;
			}
		}

		// Token: 0x170048C2 RID: 18626
		// (get) Token: 0x06015C95 RID: 89237 RVA: 0x0032AA4E File Offset: 0x00328C4E
		// (set) Token: 0x06015C96 RID: 89238 RVA: 0x0032AA56 File Offset: 0x00328C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventType
		{
			get
			{
				return this.eventType_;
			}
			set
			{
				this.eventType_ = value;
			}
		}

		// Token: 0x170048C3 RID: 18627
		// (get) Token: 0x06015C97 RID: 89239 RVA: 0x0032AA5F File Offset: 0x00328C5F
		// (set) Token: 0x06015C98 RID: 89240 RVA: 0x0032AA67 File Offset: 0x00328C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IgnorePerformance
		{
			get
			{
				return this.ignorePerformance_;
			}
			set
			{
				this.ignorePerformance_ = value;
			}
		}

		// Token: 0x06015C99 RID: 89241 RVA: 0x0032AA70 File Offset: 0x00328C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResMoodUpdateNotify);
		}

		// Token: 0x06015C9A RID: 89242 RVA: 0x0032AA80 File Offset: 0x00328C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResMoodUpdateNotify other)
		{
			return other != null && (other == this || (this.Mood == other.Mood && this.MoodRuleId == other.MoodRuleId && this.EventType == other.EventType && this.IgnorePerformance == other.IgnorePerformance && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015C9B RID: 89243 RVA: 0x0032AAEC File Offset: 0x00328CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Mood != 0)
			{
				num ^= this.Mood.GetHashCode();
			}
			if (this.MoodRuleId != 0)
			{
				num ^= this.MoodRuleId.GetHashCode();
			}
			if (this.EventType != 0)
			{
				num ^= this.EventType.GetHashCode();
			}
			if (this.IgnorePerformance)
			{
				num ^= this.IgnorePerformance.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015C9C RID: 89244 RVA: 0x0032AB76 File Offset: 0x00328D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015C9D RID: 89245 RVA: 0x0032AB83 File Offset: 0x00328D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015C9E RID: 89246 RVA: 0x0032AB8C File Offset: 0x00328D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IgnorePerformance)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IgnorePerformance);
			}
			if (this.Mood != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Mood);
			}
			if (this.MoodRuleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MoodRuleId);
			}
			if (this.EventType != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.EventType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015C9F RID: 89247 RVA: 0x0032AC1C File Offset: 0x00328E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Mood != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Mood);
			}
			if (this.MoodRuleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoodRuleId);
			}
			if (this.EventType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventType);
			}
			if (this.IgnorePerformance)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015CA0 RID: 89248 RVA: 0x0032AC98 File Offset: 0x00328E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResMoodUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Mood != 0)
			{
				this.Mood = other.Mood;
			}
			if (other.MoodRuleId != 0)
			{
				this.MoodRuleId = other.MoodRuleId;
			}
			if (other.EventType != 0)
			{
				this.EventType = other.EventType;
			}
			if (other.IgnorePerformance)
			{
				this.IgnorePerformance = other.IgnorePerformance;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015CA1 RID: 89249 RVA: 0x0032AD10 File Offset: 0x00328F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015CA2 RID: 89250 RVA: 0x0032AD1C File Offset: 0x00328F1C
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
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.IgnorePerformance = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.Mood = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.MoodRuleId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.EventType = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400832F RID: 33583
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008330 RID: 33584
		public const int MoodFieldNumber = 4;

		// Token: 0x04008331 RID: 33585
		private int mood_;

		// Token: 0x04008332 RID: 33586
		public const int MoodRuleIdFieldNumber = 6;

		// Token: 0x04008333 RID: 33587
		private int moodRuleId_;

		// Token: 0x04008334 RID: 33588
		public const int EventTypeFieldNumber = 13;

		// Token: 0x04008335 RID: 33589
		private int eventType_;

		// Token: 0x04008336 RID: 33590
		public const int IgnorePerformanceFieldNumber = 1;

		// Token: 0x04008337 RID: 33591
		private bool ignorePerformance_;
	}
}
