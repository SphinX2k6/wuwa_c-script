using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C3 RID: 707
	[NetMessage(EMessageId.CompleteMarkNotify)]
	public sealed class CompleteMarkNotify : IMessage<CompleteMarkNotify>, IMessage, IEquatable<CompleteMarkNotify>, IDeepCloneable<CompleteMarkNotify>, IBufferMessage
	{
		// Token: 0x060048B8 RID: 18616 RVA: 0x000B208F File Offset: 0x000B028F
		[NullableContext(1)]
		public static CompleteMarkNotify Create()
		{
			return new CompleteMarkNotify();
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x060048B9 RID: 18617 RVA: 0x000B2096 File Offset: 0x000B0296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x060048BA RID: 18618 RVA: 0x000B2099 File Offset: 0x000B0299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CompleteMarkNotify.Descriptor;
			}
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x000B20A0 File Offset: 0x000B02A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompleteMarkNotify()
		{
		}

		// Token: 0x060048BC RID: 18620 RVA: 0x000B20B3 File Offset: 0x000B02B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompleteMarkNotify(CompleteMarkNotify other) : this()
		{
			this.markIds_ = other.markIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x000B20DD File Offset: 0x000B02DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompleteMarkNotify Clone()
		{
			return new CompleteMarkNotify(this);
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x060048BE RID: 18622 RVA: 0x000B20E5 File Offset: 0x000B02E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MarkIds
		{
			get
			{
				return this.markIds_;
			}
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x000B20ED File Offset: 0x000B02ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CompleteMarkNotify);
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x000B20FB File Offset: 0x000B02FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CompleteMarkNotify other)
		{
			return other != null && (other == this || (this.markIds_.Equals(other.markIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x000B2130 File Offset: 0x000B0330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.markIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x000B2164 File Offset: 0x000B0364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x000B2171 File Offset: 0x000B0371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x000B217A File Offset: 0x000B037A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.markIds_.WriteTo(ref output, CompleteMarkNotify._repeated_markIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x000B21A4 File Offset: 0x000B03A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.markIds_.CalculateSize(CompleteMarkNotify._repeated_markIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x000B21DD File Offset: 0x000B03DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CompleteMarkNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.markIds_.Add(other.markIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x000B220B File Offset: 0x000B040B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x000B2214 File Offset: 0x000B0414
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.markIds_.AddEntriesFrom(ref input, CompleteMarkNotify._repeated_markIds_codec);
				}
			}
		}

		// Token: 0x04002FF2 RID: 12274
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FF3 RID: 12275
		public const int MarkIdsFieldNumber = 6;

		// Token: 0x04002FF4 RID: 12276
		private static readonly FieldCodec<int> _repeated_markIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04002FF5 RID: 12277
		private readonly RepeatedField<int> markIds_ = new RepeatedField<int>();
	}
}
