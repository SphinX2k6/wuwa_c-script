using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF6 RID: 4086
	[NetMessage(EMessageId.RogueResMoodUpdateNotify)]
	public sealed class RogueResMoodUpdateNotify : IMessage<RogueResMoodUpdateNotify>, IMessage, IEquatable<RogueResMoodUpdateNotify>, IDeepCloneable<RogueResMoodUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015D70 RID: 89456 RVA: 0x0032C078 File Offset: 0x0032A278
		[NullableContext(1)]
		public static RogueResMoodUpdateNotify Create()
		{
			return new RogueResMoodUpdateNotify();
		}

		// Token: 0x170048E8 RID: 18664
		// (get) Token: 0x06015D71 RID: 89457 RVA: 0x0032C07F File Offset: 0x0032A27F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048E9 RID: 18665
		// (get) Token: 0x06015D72 RID: 89458 RVA: 0x0032C082 File Offset: 0x0032A282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResMoodUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015D73 RID: 89459 RVA: 0x0032C089 File Offset: 0x0032A289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoodUpdateNotify()
		{
		}

		// Token: 0x06015D74 RID: 89460 RVA: 0x0032C094 File Offset: 0x0032A294
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

		// Token: 0x06015D75 RID: 89461 RVA: 0x0032C0E8 File Offset: 0x0032A2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoodUpdateNotify Clone()
		{
			return new RogueResMoodUpdateNotify(this);
		}

		// Token: 0x170048EA RID: 18666
		// (get) Token: 0x06015D76 RID: 89462 RVA: 0x0032C0F0 File Offset: 0x0032A2F0
		// (set) Token: 0x06015D77 RID: 89463 RVA: 0x0032C0F8 File Offset: 0x0032A2F8
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

		// Token: 0x170048EB RID: 18667
		// (get) Token: 0x06015D78 RID: 89464 RVA: 0x0032C101 File Offset: 0x0032A301
		// (set) Token: 0x06015D79 RID: 89465 RVA: 0x0032C109 File Offset: 0x0032A309
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

		// Token: 0x170048EC RID: 18668
		// (get) Token: 0x06015D7A RID: 89466 RVA: 0x0032C112 File Offset: 0x0032A312
		// (set) Token: 0x06015D7B RID: 89467 RVA: 0x0032C11A File Offset: 0x0032A31A
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

		// Token: 0x170048ED RID: 18669
		// (get) Token: 0x06015D7C RID: 89468 RVA: 0x0032C123 File Offset: 0x0032A323
		// (set) Token: 0x06015D7D RID: 89469 RVA: 0x0032C12B File Offset: 0x0032A32B
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

		// Token: 0x06015D7E RID: 89470 RVA: 0x0032C134 File Offset: 0x0032A334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResMoodUpdateNotify);
		}

		// Token: 0x06015D7F RID: 89471 RVA: 0x0032C144 File Offset: 0x0032A344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResMoodUpdateNotify other)
		{
			return other != null && (other == this || (this.Mood == other.Mood && this.MoodRuleId == other.MoodRuleId && this.EventType == other.EventType && this.IgnorePerformance == other.IgnorePerformance && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015D80 RID: 89472 RVA: 0x0032C1B0 File Offset: 0x0032A3B0
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

		// Token: 0x06015D81 RID: 89473 RVA: 0x0032C23A File Offset: 0x0032A43A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015D82 RID: 89474 RVA: 0x0032C247 File Offset: 0x0032A447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015D83 RID: 89475 RVA: 0x0032C250 File Offset: 0x0032A450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MoodRuleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MoodRuleId);
			}
			if (this.IgnorePerformance)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IgnorePerformance);
			}
			if (this.EventType != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.EventType);
			}
			if (this.Mood != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Mood);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015D84 RID: 89476 RVA: 0x0032C2E0 File Offset: 0x0032A4E0
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

		// Token: 0x06015D85 RID: 89477 RVA: 0x0032C35C File Offset: 0x0032A55C
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

		// Token: 0x06015D86 RID: 89478 RVA: 0x0032C3D4 File Offset: 0x0032A5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015D87 RID: 89479 RVA: 0x0032C3E0 File Offset: 0x0032A5E0
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
						this.MoodRuleId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IgnorePerformance = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.EventType = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.Mood = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008305 RID: 33541
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008306 RID: 33542
		public const int MoodFieldNumber = 12;

		// Token: 0x04008307 RID: 33543
		private int mood_;

		// Token: 0x04008308 RID: 33544
		public const int MoodRuleIdFieldNumber = 1;

		// Token: 0x04008309 RID: 33545
		private int moodRuleId_;

		// Token: 0x0400830A RID: 33546
		public const int EventTypeFieldNumber = 10;

		// Token: 0x0400830B RID: 33547
		private int eventType_;

		// Token: 0x0400830C RID: 33548
		public const int IgnorePerformanceFieldNumber = 4;

		// Token: 0x0400830D RID: 33549
		private bool ignorePerformance_;
	}
}
