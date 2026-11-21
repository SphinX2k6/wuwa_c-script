using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001448 RID: 5192
	[NetMessage(EMessageId.TraceQuestNotify)]
	public sealed class TraceQuestNotify : IMessage<TraceQuestNotify>, IMessage, IEquatable<TraceQuestNotify>, IDeepCloneable<TraceQuestNotify>, IBufferMessage
	{
		// Token: 0x0601B94E RID: 112974 RVA: 0x004020F5 File Offset: 0x004002F5
		[NullableContext(1)]
		public static TraceQuestNotify Create()
		{
			return new TraceQuestNotify();
		}

		// Token: 0x17005D5D RID: 23901
		// (get) Token: 0x0601B94F RID: 112975 RVA: 0x004020FC File Offset: 0x004002FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D5E RID: 23902
		// (get) Token: 0x0601B950 RID: 112976 RVA: 0x004020FF File Offset: 0x004002FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceQuestNotify.Descriptor;
			}
		}

		// Token: 0x0601B951 RID: 112977 RVA: 0x00402106 File Offset: 0x00400306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceQuestNotify()
		{
		}

		// Token: 0x0601B952 RID: 112978 RVA: 0x0040210E File Offset: 0x0040030E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceQuestNotify(TraceQuestNotify other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B953 RID: 112979 RVA: 0x00402133 File Offset: 0x00400333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceQuestNotify Clone()
		{
			return new TraceQuestNotify(this);
		}

		// Token: 0x17005D5F RID: 23903
		// (get) Token: 0x0601B954 RID: 112980 RVA: 0x0040213B File Offset: 0x0040033B
		// (set) Token: 0x0601B955 RID: 112981 RVA: 0x00402143 File Offset: 0x00400343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x0601B956 RID: 112982 RVA: 0x0040214C File Offset: 0x0040034C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceQuestNotify);
		}

		// Token: 0x0601B957 RID: 112983 RVA: 0x0040215A File Offset: 0x0040035A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceQuestNotify other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B958 RID: 112984 RVA: 0x00402188 File Offset: 0x00400388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B959 RID: 112985 RVA: 0x004021C7 File Offset: 0x004003C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B95A RID: 112986 RVA: 0x004021D4 File Offset: 0x004003D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B95B RID: 112987 RVA: 0x004021DD File Offset: 0x004003DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B95C RID: 112988 RVA: 0x00402210 File Offset: 0x00400410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B95D RID: 112989 RVA: 0x0040224E File Offset: 0x0040044E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceQuestNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B95E RID: 112990 RVA: 0x0040227F File Offset: 0x0040047F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B95F RID: 112991 RVA: 0x00402288 File Offset: 0x00400488
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A05D RID: 41053
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A05E RID: 41054
		public const int QuestIdFieldNumber = 13;

		// Token: 0x0400A05F RID: 41055
		private int questId_;
	}
}
