using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000324 RID: 804
	[NetMessage(EMessageId.DailyQuestCancelNotify)]
	public sealed class DailyQuestCancelNotify : IMessage<DailyQuestCancelNotify>, IMessage, IEquatable<DailyQuestCancelNotify>, IDeepCloneable<DailyQuestCancelNotify>, IBufferMessage
	{
		// Token: 0x060050D2 RID: 20690 RVA: 0x000C4D87 File Offset: 0x000C2F87
		[NullableContext(1)]
		public static DailyQuestCancelNotify Create()
		{
			return new DailyQuestCancelNotify();
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x060050D3 RID: 20691 RVA: 0x000C4D8E File Offset: 0x000C2F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x060050D4 RID: 20692 RVA: 0x000C4D91 File Offset: 0x000C2F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyQuestCancelNotify.Descriptor;
			}
		}

		// Token: 0x060050D5 RID: 20693 RVA: 0x000C4D98 File Offset: 0x000C2F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestCancelNotify()
		{
		}

		// Token: 0x060050D6 RID: 20694 RVA: 0x000C4DAB File Offset: 0x000C2FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestCancelNotify(DailyQuestCancelNotify other) : this()
		{
			this.questIds_ = other.questIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060050D7 RID: 20695 RVA: 0x000C4DD5 File Offset: 0x000C2FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestCancelNotify Clone()
		{
			return new DailyQuestCancelNotify(this);
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x060050D8 RID: 20696 RVA: 0x000C4DDD File Offset: 0x000C2FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestIds
		{
			get
			{
				return this.questIds_;
			}
		}

		// Token: 0x060050D9 RID: 20697 RVA: 0x000C4DE5 File Offset: 0x000C2FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyQuestCancelNotify);
		}

		// Token: 0x060050DA RID: 20698 RVA: 0x000C4DF3 File Offset: 0x000C2FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyQuestCancelNotify other)
		{
			return other != null && (other == this || (this.questIds_.Equals(other.questIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060050DB RID: 20699 RVA: 0x000C4E28 File Offset: 0x000C3028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.questIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060050DC RID: 20700 RVA: 0x000C4E5C File Offset: 0x000C305C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060050DD RID: 20701 RVA: 0x000C4E69 File Offset: 0x000C3069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060050DE RID: 20702 RVA: 0x000C4E72 File Offset: 0x000C3072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questIds_.WriteTo(ref output, DailyQuestCancelNotify._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060050DF RID: 20703 RVA: 0x000C4E9C File Offset: 0x000C309C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questIds_.CalculateSize(DailyQuestCancelNotify._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060050E0 RID: 20704 RVA: 0x000C4ED5 File Offset: 0x000C30D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyQuestCancelNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.questIds_.Add(other.questIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x000C4F03 File Offset: 0x000C3103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x000C4F0C File Offset: 0x000C310C
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questIds_.AddEntriesFrom(ref input, DailyQuestCancelNotify._repeated_questIds_codec);
				}
			}
		}

		// Token: 0x0400327C RID: 12924
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400327D RID: 12925
		public const int QuestIdsFieldNumber = 1;

		// Token: 0x0400327E RID: 12926
		private static readonly FieldCodec<int> _repeated_questIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400327F RID: 12927
		private readonly RepeatedField<int> questIds_ = new RepeatedField<int>();
	}
}
