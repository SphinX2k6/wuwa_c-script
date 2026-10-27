using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003CA RID: 970
	[NetMessage(EMessageId.DestroyRecallQuestsNotify)]
	public sealed class DestroyRecallQuestsNotify : IMessage<DestroyRecallQuestsNotify>, IMessage, IEquatable<DestroyRecallQuestsNotify>, IDeepCloneable<DestroyRecallQuestsNotify>, IBufferMessage
	{
		// Token: 0x06005EAF RID: 24239 RVA: 0x000E5401 File Offset: 0x000E3601
		[NullableContext(1)]
		public static DestroyRecallQuestsNotify Create()
		{
			return new DestroyRecallQuestsNotify();
		}

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x06005EB0 RID: 24240 RVA: 0x000E5408 File Offset: 0x000E3608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x06005EB1 RID: 24241 RVA: 0x000E540B File Offset: 0x000E360B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyRecallQuestsNotify.Descriptor;
			}
		}

		// Token: 0x06005EB2 RID: 24242 RVA: 0x000E5412 File Offset: 0x000E3612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyRecallQuestsNotify()
		{
		}

		// Token: 0x06005EB3 RID: 24243 RVA: 0x000E5425 File Offset: 0x000E3625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyRecallQuestsNotify(DestroyRecallQuestsNotify other) : this()
		{
			this.recallQuestIds_ = other.recallQuestIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005EB4 RID: 24244 RVA: 0x000E544F File Offset: 0x000E364F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyRecallQuestsNotify Clone()
		{
			return new DestroyRecallQuestsNotify(this);
		}

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x06005EB5 RID: 24245 RVA: 0x000E5457 File Offset: 0x000E3657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RecallQuestIds
		{
			get
			{
				return this.recallQuestIds_;
			}
		}

		// Token: 0x06005EB6 RID: 24246 RVA: 0x000E545F File Offset: 0x000E365F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyRecallQuestsNotify);
		}

		// Token: 0x06005EB7 RID: 24247 RVA: 0x000E546D File Offset: 0x000E366D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DestroyRecallQuestsNotify other)
		{
			return other != null && (other == this || (this.recallQuestIds_.Equals(other.recallQuestIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005EB8 RID: 24248 RVA: 0x000E54A0 File Offset: 0x000E36A0
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

		// Token: 0x06005EB9 RID: 24249 RVA: 0x000E54D4 File Offset: 0x000E36D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005EBA RID: 24250 RVA: 0x000E54E1 File Offset: 0x000E36E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005EBB RID: 24251 RVA: 0x000E54EA File Offset: 0x000E36EA
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

		// Token: 0x06005EBC RID: 24252 RVA: 0x000E5514 File Offset: 0x000E3714
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

		// Token: 0x06005EBD RID: 24253 RVA: 0x000E554D File Offset: 0x000E374D
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

		// Token: 0x06005EBE RID: 24254 RVA: 0x000E557B File Offset: 0x000E377B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005EBF RID: 24255 RVA: 0x000E5584 File Offset: 0x000E3784
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.recallQuestIds_.AddEntriesFrom(ref input, DestroyRecallQuestsNotify._repeated_recallQuestIds_codec);
				}
			}
		}

		// Token: 0x040036D9 RID: 14041
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036DA RID: 14042
		public const int RecallQuestIdsFieldNumber = 15;

		// Token: 0x040036DB RID: 14043
		private static readonly FieldCodec<int> _repeated_recallQuestIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x040036DC RID: 14044
		private readonly RepeatedField<int> recallQuestIds_ = new RepeatedField<int>();
	}
}
