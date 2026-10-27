using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A5 RID: 5285
	public sealed class UpdateQuestTimerNotify : IMessage<UpdateQuestTimerNotify>, IMessage, IEquatable<UpdateQuestTimerNotify>, IDeepCloneable<UpdateQuestTimerNotify>, IBufferMessage
	{
		// Token: 0x0601BF37 RID: 114487 RVA: 0x0040A387 File Offset: 0x00408587
		[NullableContext(1)]
		public static UpdateQuestTimerNotify Create()
		{
			return new UpdateQuestTimerNotify();
		}

		// Token: 0x17005E31 RID: 24113
		// (get) Token: 0x0601BF38 RID: 114488 RVA: 0x0040A38E File Offset: 0x0040858E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E32 RID: 24114
		// (get) Token: 0x0601BF39 RID: 114489 RVA: 0x0040A391 File Offset: 0x00408591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateQuestTimerNotify.Descriptor;
			}
		}

		// Token: 0x0601BF3A RID: 114490 RVA: 0x0040A398 File Offset: 0x00408598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateQuestTimerNotify()
		{
		}

		// Token: 0x0601BF3B RID: 114491 RVA: 0x0040A3AB File Offset: 0x004085AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateQuestTimerNotify(UpdateQuestTimerNotify other) : this()
		{
			this.questTimers_ = other.questTimers_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BF3C RID: 114492 RVA: 0x0040A3D5 File Offset: 0x004085D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateQuestTimerNotify Clone()
		{
			return new UpdateQuestTimerNotify(this);
		}

		// Token: 0x17005E33 RID: 24115
		// (get) Token: 0x0601BF3D RID: 114493 RVA: 0x0040A3DD File Offset: 0x004085DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, QuestTimer> QuestTimers
		{
			get
			{
				return this.questTimers_;
			}
		}

		// Token: 0x0601BF3E RID: 114494 RVA: 0x0040A3E5 File Offset: 0x004085E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateQuestTimerNotify);
		}

		// Token: 0x0601BF3F RID: 114495 RVA: 0x0040A3F3 File Offset: 0x004085F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateQuestTimerNotify other)
		{
			return other != null && (other == this || (this.QuestTimers.Equals(other.QuestTimers) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BF40 RID: 114496 RVA: 0x0040A428 File Offset: 0x00408628
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

		// Token: 0x0601BF41 RID: 114497 RVA: 0x0040A45C File Offset: 0x0040865C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BF42 RID: 114498 RVA: 0x0040A469 File Offset: 0x00408669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BF43 RID: 114499 RVA: 0x0040A472 File Offset: 0x00408672
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

		// Token: 0x0601BF44 RID: 114500 RVA: 0x0040A49C File Offset: 0x0040869C
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

		// Token: 0x0601BF45 RID: 114501 RVA: 0x0040A4D5 File Offset: 0x004086D5
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

		// Token: 0x0601BF46 RID: 114502 RVA: 0x0040A503 File Offset: 0x00408703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BF47 RID: 114503 RVA: 0x0040A50C File Offset: 0x0040870C
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

		// Token: 0x0400A094 RID: 41108
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A095 RID: 41109
		public const int QuestTimersFieldNumber = 1;

		// Token: 0x0400A096 RID: 41110
		private static readonly MapField<int, QuestTimer>.Codec _map_questTimers_codec = new MapField<int, QuestTimer>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<QuestTimer>(18U, QuestTimer.Parser), 10U);

		// Token: 0x0400A097 RID: 41111
		private readonly MapField<int, QuestTimer> questTimers_ = new MapField<int, QuestTimer>();
	}
}
