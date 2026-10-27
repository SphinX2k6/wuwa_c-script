using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D7 RID: 2519
	[NetMessage(EMessageId.MiniWriteLetterLoginNotify)]
	public sealed class MiniWriteLetterLoginNotify : IMessage<MiniWriteLetterLoginNotify>, IMessage, IEquatable<MiniWriteLetterLoginNotify>, IDeepCloneable<MiniWriteLetterLoginNotify>, IBufferMessage
	{
		// Token: 0x0600DCE0 RID: 56544 RVA: 0x00206BE0 File Offset: 0x00204DE0
		[NullableContext(1)]
		public static MiniWriteLetterLoginNotify Create()
		{
			return new MiniWriteLetterLoginNotify();
		}

		// Token: 0x17002CC7 RID: 11463
		// (get) Token: 0x0600DCE1 RID: 56545 RVA: 0x00206BE7 File Offset: 0x00204DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CC8 RID: 11464
		// (get) Token: 0x0600DCE2 RID: 56546 RVA: 0x00206BEA File Offset: 0x00204DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MiniWriteLetterLoginNotify.Descriptor;
			}
		}

		// Token: 0x0600DCE3 RID: 56547 RVA: 0x00206BF1 File Offset: 0x00204DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniWriteLetterLoginNotify()
		{
		}

		// Token: 0x0600DCE4 RID: 56548 RVA: 0x00206C04 File Offset: 0x00204E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniWriteLetterLoginNotify(MiniWriteLetterLoginNotify other) : this()
		{
			this.letterContent_ = other.letterContent_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DCE5 RID: 56549 RVA: 0x00206C2E File Offset: 0x00204E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniWriteLetterLoginNotify Clone()
		{
			return new MiniWriteLetterLoginNotify(this);
		}

		// Token: 0x17002CC9 RID: 11465
		// (get) Token: 0x0600DCE6 RID: 56550 RVA: 0x00206C36 File Offset: 0x00204E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MiniLetterContentPb> LetterContent
		{
			get
			{
				return this.letterContent_;
			}
		}

		// Token: 0x0600DCE7 RID: 56551 RVA: 0x00206C3E File Offset: 0x00204E3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MiniWriteLetterLoginNotify);
		}

		// Token: 0x0600DCE8 RID: 56552 RVA: 0x00206C4C File Offset: 0x00204E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MiniWriteLetterLoginNotify other)
		{
			return other != null && (other == this || (this.letterContent_.Equals(other.letterContent_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DCE9 RID: 56553 RVA: 0x00206C80 File Offset: 0x00204E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.letterContent_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DCEA RID: 56554 RVA: 0x00206CB4 File Offset: 0x00204EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DCEB RID: 56555 RVA: 0x00206CC1 File Offset: 0x00204EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DCEC RID: 56556 RVA: 0x00206CCA File Offset: 0x00204ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.letterContent_.WriteTo(ref output, MiniWriteLetterLoginNotify._repeated_letterContent_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DCED RID: 56557 RVA: 0x00206CF4 File Offset: 0x00204EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.letterContent_.CalculateSize(MiniWriteLetterLoginNotify._repeated_letterContent_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DCEE RID: 56558 RVA: 0x00206D2D File Offset: 0x00204F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MiniWriteLetterLoginNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.letterContent_.Add(other.letterContent_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DCEF RID: 56559 RVA: 0x00206D5B File Offset: 0x00204F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DCF0 RID: 56560 RVA: 0x00206D64 File Offset: 0x00204F64
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.letterContent_.AddEntriesFrom(ref input, MiniWriteLetterLoginNotify._repeated_letterContent_codec);
				}
			}
		}

		// Token: 0x04005B71 RID: 23409
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B72 RID: 23410
		public const int LetterContentFieldNumber = 6;

		// Token: 0x04005B73 RID: 23411
		private static readonly FieldCodec<MiniLetterContentPb> _repeated_letterContent_codec = FieldCodec.ForMessage<MiniLetterContentPb>(50U, MiniLetterContentPb.Parser);

		// Token: 0x04005B74 RID: 23412
		private readonly RepeatedField<MiniLetterContentPb> letterContent_ = new RepeatedField<MiniLetterContentPb>();
	}
}
