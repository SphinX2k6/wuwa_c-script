using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC8 RID: 4040
	[NetMessage(EMessageId.RoguelikeWriteCatBossRewardRequest)]
	public sealed class RoguelikeWriteCatBossRewardRequest : IMessage<RoguelikeWriteCatBossRewardRequest>, IMessage, IEquatable<RoguelikeWriteCatBossRewardRequest>, IDeepCloneable<RoguelikeWriteCatBossRewardRequest>, IBufferMessage
	{
		// Token: 0x06015994 RID: 88468 RVA: 0x00322A48 File Offset: 0x00320C48
		[NullableContext(1)]
		public static RoguelikeWriteCatBossRewardRequest Create()
		{
			return new RoguelikeWriteCatBossRewardRequest();
		}

		// Token: 0x17004808 RID: 18440
		// (get) Token: 0x06015995 RID: 88469 RVA: 0x00322A4F File Offset: 0x00320C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004809 RID: 18441
		// (get) Token: 0x06015996 RID: 88470 RVA: 0x00322A52 File Offset: 0x00320C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeWriteCatBossRewardRequest.Descriptor;
			}
		}

		// Token: 0x06015997 RID: 88471 RVA: 0x00322A59 File Offset: 0x00320C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatBossRewardRequest()
		{
		}

		// Token: 0x06015998 RID: 88472 RVA: 0x00322A61 File Offset: 0x00320C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatBossRewardRequest(RoguelikeWriteCatBossRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015999 RID: 88473 RVA: 0x00322A92 File Offset: 0x00320C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatBossRewardRequest Clone()
		{
			return new RoguelikeWriteCatBossRewardRequest(this);
		}

		// Token: 0x1700480A RID: 18442
		// (get) Token: 0x0601599A RID: 88474 RVA: 0x00322A9A File Offset: 0x00320C9A
		// (set) Token: 0x0601599B RID: 88475 RVA: 0x00322AA2 File Offset: 0x00320CA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x1700480B RID: 18443
		// (get) Token: 0x0601599C RID: 88476 RVA: 0x00322AAB File Offset: 0x00320CAB
		// (set) Token: 0x0601599D RID: 88477 RVA: 0x00322AB3 File Offset: 0x00320CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x0601599E RID: 88478 RVA: 0x00322ABC File Offset: 0x00320CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeWriteCatBossRewardRequest);
		}

		// Token: 0x0601599F RID: 88479 RVA: 0x00322ACA File Offset: 0x00320CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeWriteCatBossRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060159A0 RID: 88480 RVA: 0x00322B08 File Offset: 0x00320D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060159A1 RID: 88481 RVA: 0x00322B60 File Offset: 0x00320D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060159A2 RID: 88482 RVA: 0x00322B6D File Offset: 0x00320D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060159A3 RID: 88483 RVA: 0x00322B78 File Offset: 0x00320D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060159A4 RID: 88484 RVA: 0x00322BD4 File Offset: 0x00320DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060159A5 RID: 88485 RVA: 0x00322C2C File Offset: 0x00320E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeWriteCatBossRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060159A6 RID: 88486 RVA: 0x00322C7C File Offset: 0x00320E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060159A7 RID: 88487 RVA: 0x00322C88 File Offset: 0x00320E88
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
				if (num != 24U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040081C2 RID: 33218
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081C3 RID: 33219
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x040081C4 RID: 33220
		private int activityId_;

		// Token: 0x040081C5 RID: 33221
		public const int IndexFieldNumber = 13;

		// Token: 0x040081C6 RID: 33222
		private int index_;
	}
}
