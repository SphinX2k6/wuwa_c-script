using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BCA RID: 3018
	[NetMessage(EMessageId.PayGiftConditionFinishNotify)]
	public sealed class PayGiftConditionFinishNotify : IMessage<PayGiftConditionFinishNotify>, IMessage, IEquatable<PayGiftConditionFinishNotify>, IDeepCloneable<PayGiftConditionFinishNotify>, IBufferMessage
	{
		// Token: 0x060105CD RID: 67021 RVA: 0x00262FF8 File Offset: 0x002611F8
		[NullableContext(1)]
		public static PayGiftConditionFinishNotify Create()
		{
			return new PayGiftConditionFinishNotify();
		}

		// Token: 0x170035A2 RID: 13730
		// (get) Token: 0x060105CE RID: 67022 RVA: 0x00262FFF File Offset: 0x002611FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035A3 RID: 13731
		// (get) Token: 0x060105CF RID: 67023 RVA: 0x00263002 File Offset: 0x00261202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayGiftConditionFinishNotify.Descriptor;
			}
		}

		// Token: 0x060105D0 RID: 67024 RVA: 0x00263009 File Offset: 0x00261209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftConditionFinishNotify()
		{
		}

		// Token: 0x060105D1 RID: 67025 RVA: 0x0026301C File Offset: 0x0026121C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftConditionFinishNotify(PayGiftConditionFinishNotify other) : this()
		{
			this.gifts_ = other.gifts_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060105D2 RID: 67026 RVA: 0x00263046 File Offset: 0x00261246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftConditionFinishNotify Clone()
		{
			return new PayGiftConditionFinishNotify(this);
		}

		// Token: 0x170035A4 RID: 13732
		// (get) Token: 0x060105D3 RID: 67027 RVA: 0x0026304E File Offset: 0x0026124E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayGiftInfo> Gifts
		{
			get
			{
				return this.gifts_;
			}
		}

		// Token: 0x060105D4 RID: 67028 RVA: 0x00263056 File Offset: 0x00261256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayGiftConditionFinishNotify);
		}

		// Token: 0x060105D5 RID: 67029 RVA: 0x00263064 File Offset: 0x00261264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayGiftConditionFinishNotify other)
		{
			return other != null && (other == this || (this.gifts_.Equals(other.gifts_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060105D6 RID: 67030 RVA: 0x00263098 File Offset: 0x00261298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gifts_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060105D7 RID: 67031 RVA: 0x002630CC File Offset: 0x002612CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060105D8 RID: 67032 RVA: 0x002630D9 File Offset: 0x002612D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060105D9 RID: 67033 RVA: 0x002630E2 File Offset: 0x002612E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gifts_.WriteTo(ref output, PayGiftConditionFinishNotify._repeated_gifts_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060105DA RID: 67034 RVA: 0x0026310C File Offset: 0x0026130C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gifts_.CalculateSize(PayGiftConditionFinishNotify._repeated_gifts_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060105DB RID: 67035 RVA: 0x00263145 File Offset: 0x00261345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayGiftConditionFinishNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.gifts_.Add(other.gifts_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060105DC RID: 67036 RVA: 0x00263173 File Offset: 0x00261373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060105DD RID: 67037 RVA: 0x0026317C File Offset: 0x0026137C
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.gifts_.AddEntriesFrom(ref input, PayGiftConditionFinishNotify._repeated_gifts_codec);
				}
			}
		}

		// Token: 0x04006833 RID: 26675
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006834 RID: 26676
		public const int GiftsFieldNumber = 8;

		// Token: 0x04006835 RID: 26677
		private static readonly FieldCodec<PayGiftInfo> _repeated_gifts_codec = FieldCodec.ForMessage<PayGiftInfo>(66U, PayGiftInfo.Parser);

		// Token: 0x04006836 RID: 26678
		private readonly RepeatedField<PayGiftInfo> gifts_ = new RepeatedField<PayGiftInfo>();
	}
}
