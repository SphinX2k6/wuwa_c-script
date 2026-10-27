using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000327 RID: 807
	[NetMessage(EMessageId.DailyQuestGetRewardRequest)]
	public sealed class DailyQuestGetRewardRequest : IMessage<DailyQuestGetRewardRequest>, IMessage, IEquatable<DailyQuestGetRewardRequest>, IDeepCloneable<DailyQuestGetRewardRequest>, IBufferMessage
	{
		// Token: 0x0600510A RID: 20746 RVA: 0x000C53E1 File Offset: 0x000C35E1
		[NullableContext(1)]
		public static DailyQuestGetRewardRequest Create()
		{
			return new DailyQuestGetRewardRequest();
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x0600510B RID: 20747 RVA: 0x000C53E8 File Offset: 0x000C35E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x0600510C RID: 20748 RVA: 0x000C53EB File Offset: 0x000C35EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyQuestGetRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x000C53F2 File Offset: 0x000C35F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestGetRewardRequest()
		{
		}

		// Token: 0x0600510E RID: 20750 RVA: 0x000C5405 File Offset: 0x000C3605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestGetRewardRequest(DailyQuestGetRewardRequest other) : this()
		{
			this.questId_ = other.questId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600510F RID: 20751 RVA: 0x000C542F File Offset: 0x000C362F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestGetRewardRequest Clone()
		{
			return new DailyQuestGetRewardRequest(this);
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06005110 RID: 20752 RVA: 0x000C5437 File Offset: 0x000C3637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestId
		{
			get
			{
				return this.questId_;
			}
		}

		// Token: 0x06005111 RID: 20753 RVA: 0x000C543F File Offset: 0x000C363F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyQuestGetRewardRequest);
		}

		// Token: 0x06005112 RID: 20754 RVA: 0x000C544D File Offset: 0x000C364D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyQuestGetRewardRequest other)
		{
			return other != null && (other == this || (this.questId_.Equals(other.questId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005113 RID: 20755 RVA: 0x000C5480 File Offset: 0x000C3680
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

		// Token: 0x06005114 RID: 20756 RVA: 0x000C54B4 File Offset: 0x000C36B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005115 RID: 20757 RVA: 0x000C54C1 File Offset: 0x000C36C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005116 RID: 20758 RVA: 0x000C54CA File Offset: 0x000C36CA
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

		// Token: 0x06005117 RID: 20759 RVA: 0x000C54F4 File Offset: 0x000C36F4
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

		// Token: 0x06005118 RID: 20760 RVA: 0x000C552D File Offset: 0x000C372D
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

		// Token: 0x06005119 RID: 20761 RVA: 0x000C555B File Offset: 0x000C375B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600511A RID: 20762 RVA: 0x000C5564 File Offset: 0x000C3764
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questId_.AddEntriesFrom(ref input, DailyQuestGetRewardRequest._repeated_questId_codec);
				}
			}
		}

		// Token: 0x04003288 RID: 12936
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003289 RID: 12937
		public const int QuestIdFieldNumber = 7;

		// Token: 0x0400328A RID: 12938
		private static readonly FieldCodec<int> _repeated_questId_codec = FieldCodec.ForInt32(58U);

		// Token: 0x0400328B RID: 12939
		private readonly RepeatedField<int> questId_ = new RepeatedField<int>();
	}
}
