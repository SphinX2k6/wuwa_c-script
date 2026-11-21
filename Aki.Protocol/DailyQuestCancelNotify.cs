using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200032B RID: 811
	[NetMessage(EMessageId.DailyQuestCancelNotify)]
	public sealed class DailyQuestCancelNotify : IMessage<DailyQuestCancelNotify>, IMessage, IEquatable<DailyQuestCancelNotify>, IDeepCloneable<DailyQuestCancelNotify>, IBufferMessage
	{
		// Token: 0x060051AB RID: 20907 RVA: 0x000C7177 File Offset: 0x000C5377
		[NullableContext(1)]
		public static DailyQuestCancelNotify Create()
		{
			return new DailyQuestCancelNotify();
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x060051AC RID: 20908 RVA: 0x000C717E File Offset: 0x000C537E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x060051AD RID: 20909 RVA: 0x000C7181 File Offset: 0x000C5381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyQuestCancelNotify.Descriptor;
			}
		}

		// Token: 0x060051AE RID: 20910 RVA: 0x000C7188 File Offset: 0x000C5388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestCancelNotify()
		{
		}

		// Token: 0x060051AF RID: 20911 RVA: 0x000C719B File Offset: 0x000C539B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestCancelNotify(DailyQuestCancelNotify other) : this()
		{
			this.questIds_ = other.questIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060051B0 RID: 20912 RVA: 0x000C71C5 File Offset: 0x000C53C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestCancelNotify Clone()
		{
			return new DailyQuestCancelNotify(this);
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x060051B1 RID: 20913 RVA: 0x000C71CD File Offset: 0x000C53CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestIds
		{
			get
			{
				return this.questIds_;
			}
		}

		// Token: 0x060051B2 RID: 20914 RVA: 0x000C71D5 File Offset: 0x000C53D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyQuestCancelNotify);
		}

		// Token: 0x060051B3 RID: 20915 RVA: 0x000C71E3 File Offset: 0x000C53E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyQuestCancelNotify other)
		{
			return other != null && (other == this || (this.questIds_.Equals(other.questIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060051B4 RID: 20916 RVA: 0x000C7218 File Offset: 0x000C5418
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

		// Token: 0x060051B5 RID: 20917 RVA: 0x000C724C File Offset: 0x000C544C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060051B6 RID: 20918 RVA: 0x000C7259 File Offset: 0x000C5459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060051B7 RID: 20919 RVA: 0x000C7262 File Offset: 0x000C5462
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

		// Token: 0x060051B8 RID: 20920 RVA: 0x000C728C File Offset: 0x000C548C
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

		// Token: 0x060051B9 RID: 20921 RVA: 0x000C72C5 File Offset: 0x000C54C5
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

		// Token: 0x060051BA RID: 20922 RVA: 0x000C72F3 File Offset: 0x000C54F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060051BB RID: 20923 RVA: 0x000C72FC File Offset: 0x000C54FC
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questIds_.AddEntriesFrom(ref input, DailyQuestCancelNotify._repeated_questIds_codec);
				}
			}
		}

		// Token: 0x04003313 RID: 13075
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003314 RID: 13076
		public const int QuestIdsFieldNumber = 11;

		// Token: 0x04003315 RID: 13077
		private static readonly FieldCodec<int> _repeated_questIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04003316 RID: 13078
		private readonly RepeatedField<int> questIds_ = new RepeatedField<int>();
	}
}
