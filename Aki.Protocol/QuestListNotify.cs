using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E1A RID: 3610
	[NetMessage(EMessageId.QuestListNotify)]
	public sealed class QuestListNotify : IMessage<QuestListNotify>, IMessage, IEquatable<QuestListNotify>, IDeepCloneable<QuestListNotify>, IBufferMessage
	{
		// Token: 0x0601364F RID: 79439 RVA: 0x002D2297 File Offset: 0x002D0497
		[NullableContext(1)]
		public static QuestListNotify Create()
		{
			return new QuestListNotify();
		}

		// Token: 0x17004050 RID: 16464
		// (get) Token: 0x06013650 RID: 79440 RVA: 0x002D229E File Offset: 0x002D049E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004051 RID: 16465
		// (get) Token: 0x06013651 RID: 79441 RVA: 0x002D22A1 File Offset: 0x002D04A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestListNotify.Descriptor;
			}
		}

		// Token: 0x06013652 RID: 79442 RVA: 0x002D22A8 File Offset: 0x002D04A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestListNotify()
		{
		}

		// Token: 0x06013653 RID: 79443 RVA: 0x002D22BB File Offset: 0x002D04BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestListNotify(QuestListNotify other) : this()
		{
			this.quests_ = other.quests_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013654 RID: 79444 RVA: 0x002D22E5 File Offset: 0x002D04E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestListNotify Clone()
		{
			return new QuestListNotify(this);
		}

		// Token: 0x17004052 RID: 16466
		// (get) Token: 0x06013655 RID: 79445 RVA: 0x002D22ED File Offset: 0x002D04ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<QuestInfo> Quests
		{
			get
			{
				return this.quests_;
			}
		}

		// Token: 0x06013656 RID: 79446 RVA: 0x002D22F5 File Offset: 0x002D04F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestListNotify);
		}

		// Token: 0x06013657 RID: 79447 RVA: 0x002D2303 File Offset: 0x002D0503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestListNotify other)
		{
			return other != null && (other == this || (this.quests_.Equals(other.quests_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013658 RID: 79448 RVA: 0x002D2338 File Offset: 0x002D0538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.quests_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013659 RID: 79449 RVA: 0x002D236C File Offset: 0x002D056C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601365A RID: 79450 RVA: 0x002D2379 File Offset: 0x002D0579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601365B RID: 79451 RVA: 0x002D2382 File Offset: 0x002D0582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.quests_.WriteTo(ref output, QuestListNotify._repeated_quests_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601365C RID: 79452 RVA: 0x002D23AC File Offset: 0x002D05AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.quests_.CalculateSize(QuestListNotify._repeated_quests_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601365D RID: 79453 RVA: 0x002D23E5 File Offset: 0x002D05E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestListNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.quests_.Add(other.quests_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601365E RID: 79454 RVA: 0x002D2413 File Offset: 0x002D0613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601365F RID: 79455 RVA: 0x002D241C File Offset: 0x002D061C
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.quests_.AddEntriesFrom(ref input, QuestListNotify._repeated_quests_codec);
				}
			}
		}

		// Token: 0x040076FE RID: 30462
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076FF RID: 30463
		public const int QuestsFieldNumber = 6;

		// Token: 0x04007700 RID: 30464
		private static readonly FieldCodec<QuestInfo> _repeated_quests_codec = FieldCodec.ForMessage<QuestInfo>(50U, QuestInfo.Parser);

		// Token: 0x04007701 RID: 30465
		private readonly RepeatedField<QuestInfo> quests_ = new RepeatedField<QuestInfo>();
	}
}
