using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200013D RID: 317
	[NetMessage(EMessageId.BabelActivityBuffInfoNotify)]
	public sealed class BabelActivityBuffInfoNotify : IMessage<BabelActivityBuffInfoNotify>, IMessage, IEquatable<BabelActivityBuffInfoNotify>, IDeepCloneable<BabelActivityBuffInfoNotify>, IBufferMessage
	{
		// Token: 0x0600293D RID: 10557 RVA: 0x0006C443 File Offset: 0x0006A643
		[NullableContext(1)]
		public static BabelActivityBuffInfoNotify Create()
		{
			return new BabelActivityBuffInfoNotify();
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x0600293E RID: 10558 RVA: 0x0006C44A File Offset: 0x0006A64A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600293F RID: 10559 RVA: 0x0006C44D File Offset: 0x0006A64D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityBuffInfoNotify.Descriptor;
			}
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x0006C454 File Offset: 0x0006A654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityBuffInfoNotify()
		{
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x0006C467 File Offset: 0x0006A667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityBuffInfoNotify(BabelActivityBuffInfoNotify other) : this()
		{
			this.babelActivityBuffInfos_ = other.babelActivityBuffInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x0006C491 File Offset: 0x0006A691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityBuffInfoNotify Clone()
		{
			return new BabelActivityBuffInfoNotify(this);
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x0006C499 File Offset: 0x0006A699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BabelActivityBuffInfo> BabelActivityBuffInfos
		{
			get
			{
				return this.babelActivityBuffInfos_;
			}
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x0006C4A1 File Offset: 0x0006A6A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityBuffInfoNotify);
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x0006C4AF File Offset: 0x0006A6AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityBuffInfoNotify other)
		{
			return other != null && (other == this || (this.babelActivityBuffInfos_.Equals(other.babelActivityBuffInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x0006C4E4 File Offset: 0x0006A6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.babelActivityBuffInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x0006C518 File Offset: 0x0006A718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x0006C525 File Offset: 0x0006A725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x0006C52E File Offset: 0x0006A72E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.babelActivityBuffInfos_.WriteTo(ref output, BabelActivityBuffInfoNotify._repeated_babelActivityBuffInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x0006C558 File Offset: 0x0006A758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.babelActivityBuffInfos_.CalculateSize(BabelActivityBuffInfoNotify._repeated_babelActivityBuffInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x0006C591 File Offset: 0x0006A791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelActivityBuffInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.babelActivityBuffInfos_.Add(other.babelActivityBuffInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x0006C5BF File Offset: 0x0006A7BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x0006C5C8 File Offset: 0x0006A7C8
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.babelActivityBuffInfos_.AddEntriesFrom(ref input, BabelActivityBuffInfoNotify._repeated_babelActivityBuffInfos_codec);
				}
			}
		}

		// Token: 0x040026E2 RID: 9954
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026E3 RID: 9955
		public const int BabelActivityBuffInfosFieldNumber = 7;

		// Token: 0x040026E4 RID: 9956
		private static readonly FieldCodec<BabelActivityBuffInfo> _repeated_babelActivityBuffInfos_codec = FieldCodec.ForMessage<BabelActivityBuffInfo>(58U, BabelActivityBuffInfo.Parser);

		// Token: 0x040026E5 RID: 9957
		private readonly RepeatedField<BabelActivityBuffInfo> babelActivityBuffInfos_ = new RepeatedField<BabelActivityBuffInfo>();
	}
}
