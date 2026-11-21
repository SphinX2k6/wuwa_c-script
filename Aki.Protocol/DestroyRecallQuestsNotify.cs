using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B3 RID: 947
	[NetMessage(EMessageId.DestroyRecallQuestsNotify)]
	public sealed class DestroyRecallQuestsNotify : IMessage<DestroyRecallQuestsNotify>, IMessage, IEquatable<DestroyRecallQuestsNotify>, IDeepCloneable<DestroyRecallQuestsNotify>, IBufferMessage
	{
		// Token: 0x06005D1F RID: 23839 RVA: 0x000E227D File Offset: 0x000E047D
		[NullableContext(1)]
		public static DestroyRecallQuestsNotify Create()
		{
			return new DestroyRecallQuestsNotify();
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x06005D20 RID: 23840 RVA: 0x000E2284 File Offset: 0x000E0484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x06005D21 RID: 23841 RVA: 0x000E2287 File Offset: 0x000E0487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyRecallQuestsNotify.Descriptor;
			}
		}

		// Token: 0x06005D22 RID: 23842 RVA: 0x000E228E File Offset: 0x000E048E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyRecallQuestsNotify()
		{
		}

		// Token: 0x06005D23 RID: 23843 RVA: 0x000E22A1 File Offset: 0x000E04A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyRecallQuestsNotify(DestroyRecallQuestsNotify other) : this()
		{
			this.recallQuestIds_ = other.recallQuestIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D24 RID: 23844 RVA: 0x000E22CB File Offset: 0x000E04CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyRecallQuestsNotify Clone()
		{
			return new DestroyRecallQuestsNotify(this);
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x06005D25 RID: 23845 RVA: 0x000E22D3 File Offset: 0x000E04D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RecallQuestIds
		{
			get
			{
				return this.recallQuestIds_;
			}
		}

		// Token: 0x06005D26 RID: 23846 RVA: 0x000E22DB File Offset: 0x000E04DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyRecallQuestsNotify);
		}

		// Token: 0x06005D27 RID: 23847 RVA: 0x000E22E9 File Offset: 0x000E04E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DestroyRecallQuestsNotify other)
		{
			return other != null && (other == this || (this.recallQuestIds_.Equals(other.recallQuestIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D28 RID: 23848 RVA: 0x000E231C File Offset: 0x000E051C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.recallQuestIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D29 RID: 23849 RVA: 0x000E2350 File Offset: 0x000E0550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005D2A RID: 23850 RVA: 0x000E235D File Offset: 0x000E055D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D2B RID: 23851 RVA: 0x000E2366 File Offset: 0x000E0566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.recallQuestIds_.WriteTo(ref output, DestroyRecallQuestsNotify._repeated_recallQuestIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D2C RID: 23852 RVA: 0x000E2390 File Offset: 0x000E0590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.recallQuestIds_.CalculateSize(DestroyRecallQuestsNotify._repeated_recallQuestIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D2D RID: 23853 RVA: 0x000E23C9 File Offset: 0x000E05C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DestroyRecallQuestsNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.recallQuestIds_.Add(other.recallQuestIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D2E RID: 23854 RVA: 0x000E23F7 File Offset: 0x000E05F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D2F RID: 23855 RVA: 0x000E2400 File Offset: 0x000E0600
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.recallQuestIds_.AddEntriesFrom(ref input, DestroyRecallQuestsNotify._repeated_recallQuestIds_codec);
				}
			}
		}

		// Token: 0x040036C6 RID: 14022
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036C7 RID: 14023
		public const int RecallQuestIdsFieldNumber = 3;

		// Token: 0x040036C8 RID: 14024
		private static readonly FieldCodec<int> _repeated_recallQuestIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040036C9 RID: 14025
		private readonly RepeatedField<int> recallQuestIds_ = new RepeatedField<int>();
	}
}
