using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E0A RID: 3594
	[NetMessage(EMessageId.QuestListNotify)]
	public sealed class QuestListNotify : IMessage<QuestListNotify>, IMessage, IEquatable<QuestListNotify>, IDeepCloneable<QuestListNotify>, IBufferMessage
	{
		// Token: 0x0601356A RID: 79210 RVA: 0x002D0BD3 File Offset: 0x002CEDD3
		[NullableContext(1)]
		public static QuestListNotify Create()
		{
			return new QuestListNotify();
		}

		// Token: 0x17004026 RID: 16422
		// (get) Token: 0x0601356B RID: 79211 RVA: 0x002D0BDA File Offset: 0x002CEDDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004027 RID: 16423
		// (get) Token: 0x0601356C RID: 79212 RVA: 0x002D0BDD File Offset: 0x002CEDDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestListNotify.Descriptor;
			}
		}

		// Token: 0x0601356D RID: 79213 RVA: 0x002D0BE4 File Offset: 0x002CEDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestListNotify()
		{
		}

		// Token: 0x0601356E RID: 79214 RVA: 0x002D0BF7 File Offset: 0x002CEDF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestListNotify(QuestListNotify other) : this()
		{
			this.quests_ = other.quests_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601356F RID: 79215 RVA: 0x002D0C21 File Offset: 0x002CEE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestListNotify Clone()
		{
			return new QuestListNotify(this);
		}

		// Token: 0x17004028 RID: 16424
		// (get) Token: 0x06013570 RID: 79216 RVA: 0x002D0C29 File Offset: 0x002CEE29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<QuestInfo> Quests
		{
			get
			{
				return this.quests_;
			}
		}

		// Token: 0x06013571 RID: 79217 RVA: 0x002D0C31 File Offset: 0x002CEE31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestListNotify);
		}

		// Token: 0x06013572 RID: 79218 RVA: 0x002D0C3F File Offset: 0x002CEE3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestListNotify other)
		{
			return other != null && (other == this || (this.quests_.Equals(other.quests_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013573 RID: 79219 RVA: 0x002D0C74 File Offset: 0x002CEE74
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

		// Token: 0x06013574 RID: 79220 RVA: 0x002D0CA8 File Offset: 0x002CEEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013575 RID: 79221 RVA: 0x002D0CB5 File Offset: 0x002CEEB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013576 RID: 79222 RVA: 0x002D0CBE File Offset: 0x002CEEBE
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

		// Token: 0x06013577 RID: 79223 RVA: 0x002D0CE8 File Offset: 0x002CEEE8
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

		// Token: 0x06013578 RID: 79224 RVA: 0x002D0D21 File Offset: 0x002CEF21
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

		// Token: 0x06013579 RID: 79225 RVA: 0x002D0D4F File Offset: 0x002CEF4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601357A RID: 79226 RVA: 0x002D0D58 File Offset: 0x002CEF58
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.quests_.AddEntriesFrom(ref input, QuestListNotify._repeated_quests_codec);
				}
			}
		}

		// Token: 0x04007728 RID: 30504
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007729 RID: 30505
		public const int QuestsFieldNumber = 14;

		// Token: 0x0400772A RID: 30506
		private static readonly FieldCodec<QuestInfo> _repeated_quests_codec = FieldCodec.ForMessage<QuestInfo>(114U, QuestInfo.Parser);

		// Token: 0x0400772B RID: 30507
		private readonly RepeatedField<QuestInfo> quests_ = new RepeatedField<QuestInfo>();
	}
}
