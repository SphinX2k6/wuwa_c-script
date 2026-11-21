using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200032E RID: 814
	[NetMessage(EMessageId.DailyQuestGetRewardRequest)]
	public sealed class DailyQuestGetRewardRequest : IMessage<DailyQuestGetRewardRequest>, IMessage, IEquatable<DailyQuestGetRewardRequest>, IDeepCloneable<DailyQuestGetRewardRequest>, IBufferMessage
	{
		// Token: 0x060051E3 RID: 20963 RVA: 0x000C77D5 File Offset: 0x000C59D5
		[NullableContext(1)]
		public static DailyQuestGetRewardRequest Create()
		{
			return new DailyQuestGetRewardRequest();
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x060051E4 RID: 20964 RVA: 0x000C77DC File Offset: 0x000C59DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x060051E5 RID: 20965 RVA: 0x000C77DF File Offset: 0x000C59DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyQuestGetRewardRequest.Descriptor;
			}
		}

		// Token: 0x060051E6 RID: 20966 RVA: 0x000C77E6 File Offset: 0x000C59E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestGetRewardRequest()
		{
		}

		// Token: 0x060051E7 RID: 20967 RVA: 0x000C77F9 File Offset: 0x000C59F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestGetRewardRequest(DailyQuestGetRewardRequest other) : this()
		{
			this.questId_ = other.questId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060051E8 RID: 20968 RVA: 0x000C7823 File Offset: 0x000C5A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestGetRewardRequest Clone()
		{
			return new DailyQuestGetRewardRequest(this);
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x060051E9 RID: 20969 RVA: 0x000C782B File Offset: 0x000C5A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestId
		{
			get
			{
				return this.questId_;
			}
		}

		// Token: 0x060051EA RID: 20970 RVA: 0x000C7833 File Offset: 0x000C5A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyQuestGetRewardRequest);
		}

		// Token: 0x060051EB RID: 20971 RVA: 0x000C7841 File Offset: 0x000C5A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyQuestGetRewardRequest other)
		{
			return other != null && (other == this || (this.questId_.Equals(other.questId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060051EC RID: 20972 RVA: 0x000C7874 File Offset: 0x000C5A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.questId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060051ED RID: 20973 RVA: 0x000C78A8 File Offset: 0x000C5AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060051EE RID: 20974 RVA: 0x000C78B5 File Offset: 0x000C5AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x000C78BE File Offset: 0x000C5ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questId_.WriteTo(ref output, DailyQuestGetRewardRequest._repeated_questId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060051F0 RID: 20976 RVA: 0x000C78E8 File Offset: 0x000C5AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questId_.CalculateSize(DailyQuestGetRewardRequest._repeated_questId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060051F1 RID: 20977 RVA: 0x000C7921 File Offset: 0x000C5B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyQuestGetRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.questId_.Add(other.questId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060051F2 RID: 20978 RVA: 0x000C794F File Offset: 0x000C5B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060051F3 RID: 20979 RVA: 0x000C7958 File Offset: 0x000C5B58
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
					this.questId_.AddEntriesFrom(ref input, DailyQuestGetRewardRequest._repeated_questId_codec);
				}
			}
		}

		// Token: 0x0400331F RID: 13087
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003320 RID: 13088
		public const int QuestIdFieldNumber = 1;

		// Token: 0x04003321 RID: 13089
		private static readonly FieldCodec<int> _repeated_questId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04003322 RID: 13090
		private readonly RepeatedField<int> questId_ = new RepeatedField<int>();
	}
}
