using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EBF RID: 3775
	[NetMessage(EMessageId.RecallQuestFinishListNotify)]
	public sealed class RecallQuestFinishListNotify : IMessage<RecallQuestFinishListNotify>, IMessage, IEquatable<RecallQuestFinishListNotify>, IDeepCloneable<RecallQuestFinishListNotify>, IBufferMessage
	{
		// Token: 0x060143F3 RID: 82931 RVA: 0x002F1AF1 File Offset: 0x002EFCF1
		[NullableContext(1)]
		public static RecallQuestFinishListNotify Create()
		{
			return new RecallQuestFinishListNotify();
		}

		// Token: 0x17004352 RID: 17234
		// (get) Token: 0x060143F4 RID: 82932 RVA: 0x002F1AF8 File Offset: 0x002EFCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004353 RID: 17235
		// (get) Token: 0x060143F5 RID: 82933 RVA: 0x002F1AFB File Offset: 0x002EFCFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestFinishListNotify.Descriptor;
			}
		}

		// Token: 0x060143F6 RID: 82934 RVA: 0x002F1B02 File Offset: 0x002EFD02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishListNotify()
		{
		}

		// Token: 0x060143F7 RID: 82935 RVA: 0x002F1B15 File Offset: 0x002EFD15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishListNotify(RecallQuestFinishListNotify other) : this()
		{
			this.recallQuestIds_ = other.recallQuestIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060143F8 RID: 82936 RVA: 0x002F1B3F File Offset: 0x002EFD3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishListNotify Clone()
		{
			return new RecallQuestFinishListNotify(this);
		}

		// Token: 0x17004354 RID: 17236
		// (get) Token: 0x060143F9 RID: 82937 RVA: 0x002F1B47 File Offset: 0x002EFD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RecallQuestIds
		{
			get
			{
				return this.recallQuestIds_;
			}
		}

		// Token: 0x060143FA RID: 82938 RVA: 0x002F1B4F File Offset: 0x002EFD4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestFinishListNotify);
		}

		// Token: 0x060143FB RID: 82939 RVA: 0x002F1B5D File Offset: 0x002EFD5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestFinishListNotify other)
		{
			return other != null && (other == this || (this.recallQuestIds_.Equals(other.recallQuestIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060143FC RID: 82940 RVA: 0x002F1B90 File Offset: 0x002EFD90
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

		// Token: 0x060143FD RID: 82941 RVA: 0x002F1BC4 File Offset: 0x002EFDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060143FE RID: 82942 RVA: 0x002F1BD1 File Offset: 0x002EFDD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060143FF RID: 82943 RVA: 0x002F1BDA File Offset: 0x002EFDDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.recallQuestIds_.WriteTo(ref output, RecallQuestFinishListNotify._repeated_recallQuestIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014400 RID: 82944 RVA: 0x002F1C04 File Offset: 0x002EFE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.recallQuestIds_.CalculateSize(RecallQuestFinishListNotify._repeated_recallQuestIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014401 RID: 82945 RVA: 0x002F1C3D File Offset: 0x002EFE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestFinishListNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.recallQuestIds_.Add(other.recallQuestIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014402 RID: 82946 RVA: 0x002F1C6B File Offset: 0x002EFE6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014403 RID: 82947 RVA: 0x002F1C74 File Offset: 0x002EFE74
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.recallQuestIds_.AddEntriesFrom(ref input, RecallQuestFinishListNotify._repeated_recallQuestIds_codec);
				}
			}
		}

		// Token: 0x04007B20 RID: 31520
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B21 RID: 31521
		public const int RecallQuestIdsFieldNumber = 8;

		// Token: 0x04007B22 RID: 31522
		private static readonly FieldCodec<int> _repeated_recallQuestIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04007B23 RID: 31523
		private readonly RepeatedField<int> recallQuestIds_ = new RepeatedField<int>();
	}
}
