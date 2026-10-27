using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BDA RID: 3034
	[NetMessage(EMessageId.PayGiftConditionFinishNotify)]
	public sealed class PayGiftConditionFinishNotify : IMessage<PayGiftConditionFinishNotify>, IMessage, IEquatable<PayGiftConditionFinishNotify>, IDeepCloneable<PayGiftConditionFinishNotify>, IBufferMessage
	{
		// Token: 0x060106D1 RID: 67281 RVA: 0x00264EB4 File Offset: 0x002630B4
		[NullableContext(1)]
		public static PayGiftConditionFinishNotify Create()
		{
			return new PayGiftConditionFinishNotify();
		}

		// Token: 0x170035DB RID: 13787
		// (get) Token: 0x060106D2 RID: 67282 RVA: 0x00264EBB File Offset: 0x002630BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035DC RID: 13788
		// (get) Token: 0x060106D3 RID: 67283 RVA: 0x00264EBE File Offset: 0x002630BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayGiftConditionFinishNotify.Descriptor;
			}
		}

		// Token: 0x060106D4 RID: 67284 RVA: 0x00264EC5 File Offset: 0x002630C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftConditionFinishNotify()
		{
		}

		// Token: 0x060106D5 RID: 67285 RVA: 0x00264ED8 File Offset: 0x002630D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftConditionFinishNotify(PayGiftConditionFinishNotify other) : this()
		{
			this.gifts_ = other.gifts_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060106D6 RID: 67286 RVA: 0x00264F02 File Offset: 0x00263102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftConditionFinishNotify Clone()
		{
			return new PayGiftConditionFinishNotify(this);
		}

		// Token: 0x170035DD RID: 13789
		// (get) Token: 0x060106D7 RID: 67287 RVA: 0x00264F0A File Offset: 0x0026310A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayGiftInfo> Gifts
		{
			get
			{
				return this.gifts_;
			}
		}

		// Token: 0x060106D8 RID: 67288 RVA: 0x00264F12 File Offset: 0x00263112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayGiftConditionFinishNotify);
		}

		// Token: 0x060106D9 RID: 67289 RVA: 0x00264F20 File Offset: 0x00263120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayGiftConditionFinishNotify other)
		{
			return other != null && (other == this || (this.gifts_.Equals(other.gifts_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060106DA RID: 67290 RVA: 0x00264F54 File Offset: 0x00263154
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

		// Token: 0x060106DB RID: 67291 RVA: 0x00264F88 File Offset: 0x00263188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060106DC RID: 67292 RVA: 0x00264F95 File Offset: 0x00263195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060106DD RID: 67293 RVA: 0x00264F9E File Offset: 0x0026319E
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

		// Token: 0x060106DE RID: 67294 RVA: 0x00264FC8 File Offset: 0x002631C8
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

		// Token: 0x060106DF RID: 67295 RVA: 0x00265001 File Offset: 0x00263201
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

		// Token: 0x060106E0 RID: 67296 RVA: 0x0026502F File Offset: 0x0026322F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060106E1 RID: 67297 RVA: 0x00265038 File Offset: 0x00263238
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.gifts_.AddEntriesFrom(ref input, PayGiftConditionFinishNotify._repeated_gifts_codec);
				}
			}
		}

		// Token: 0x04006823 RID: 26659
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006824 RID: 26660
		public const int GiftsFieldNumber = 3;

		// Token: 0x04006825 RID: 26661
		private static readonly FieldCodec<PayGiftInfo> _repeated_gifts_codec = FieldCodec.ForMessage<PayGiftInfo>(26U, PayGiftInfo.Parser);

		// Token: 0x04006826 RID: 26662
		private readonly RepeatedField<PayGiftInfo> gifts_ = new RepeatedField<PayGiftInfo>();
	}
}
