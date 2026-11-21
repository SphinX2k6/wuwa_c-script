using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200151B RID: 5403
	public sealed class UpdateQuestTimerNotify : IMessage<UpdateQuestTimerNotify>, IMessage, IEquatable<UpdateQuestTimerNotify>, IDeepCloneable<UpdateQuestTimerNotify>, IBufferMessage
	{
		// Token: 0x0601C9FE RID: 117246 RVA: 0x00425E3F File Offset: 0x0042403F
		[NullableContext(1)]
		public static UpdateQuestTimerNotify Create()
		{
			return new UpdateQuestTimerNotify();
		}

		// Token: 0x170060D2 RID: 24786
		// (get) Token: 0x0601C9FF RID: 117247 RVA: 0x00425E46 File Offset: 0x00424046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060D3 RID: 24787
		// (get) Token: 0x0601CA00 RID: 117248 RVA: 0x00425E49 File Offset: 0x00424049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateQuestTimerNotify.Descriptor;
			}
		}

		// Token: 0x0601CA01 RID: 117249 RVA: 0x00425E50 File Offset: 0x00424050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateQuestTimerNotify()
		{
		}

		// Token: 0x0601CA02 RID: 117250 RVA: 0x00425E63 File Offset: 0x00424063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateQuestTimerNotify(UpdateQuestTimerNotify other) : this()
		{
			this.questTimers_ = other.questTimers_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CA03 RID: 117251 RVA: 0x00425E8D File Offset: 0x0042408D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateQuestTimerNotify Clone()
		{
			return new UpdateQuestTimerNotify(this);
		}

		// Token: 0x170060D4 RID: 24788
		// (get) Token: 0x0601CA04 RID: 117252 RVA: 0x00425E95 File Offset: 0x00424095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, QuestTimer> QuestTimers
		{
			get
			{
				return this.questTimers_;
			}
		}

		// Token: 0x0601CA05 RID: 117253 RVA: 0x00425E9D File Offset: 0x0042409D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateQuestTimerNotify);
		}

		// Token: 0x0601CA06 RID: 117254 RVA: 0x00425EAB File Offset: 0x004240AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateQuestTimerNotify other)
		{
			return other != null && (other == this || (this.QuestTimers.Equals(other.QuestTimers) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CA07 RID: 117255 RVA: 0x00425EE0 File Offset: 0x004240E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.QuestTimers.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CA08 RID: 117256 RVA: 0x00425F14 File Offset: 0x00424114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CA09 RID: 117257 RVA: 0x00425F21 File Offset: 0x00424121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CA0A RID: 117258 RVA: 0x00425F2A File Offset: 0x0042412A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questTimers_.WriteTo(ref output, UpdateQuestTimerNotify._map_questTimers_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CA0B RID: 117259 RVA: 0x00425F54 File Offset: 0x00424154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questTimers_.CalculateSize(UpdateQuestTimerNotify._map_questTimers_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CA0C RID: 117260 RVA: 0x00425F8D File Offset: 0x0042418D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateQuestTimerNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.questTimers_.MergeFrom(other.questTimers_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CA0D RID: 117261 RVA: 0x00425FBB File Offset: 0x004241BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CA0E RID: 117262 RVA: 0x00425FC4 File Offset: 0x004241C4
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questTimers_.AddEntriesFrom(ref input, UpdateQuestTimerNotify._map_questTimers_codec);
				}
			}
		}

		// Token: 0x0400A4ED RID: 42221
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A4EE RID: 42222
		public const int QuestTimersFieldNumber = 1;

		// Token: 0x0400A4EF RID: 42223
		private static readonly MapField<int, QuestTimer>.Codec _map_questTimers_codec = new MapField<int, QuestTimer>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<QuestTimer>(18U, QuestTimer.Parser), 10U);

		// Token: 0x0400A4F0 RID: 42224
		private readonly MapField<int, QuestTimer> questTimers_ = new MapField<int, QuestTimer>();
	}
}
