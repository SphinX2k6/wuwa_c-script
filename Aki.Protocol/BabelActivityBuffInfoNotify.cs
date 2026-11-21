using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000140 RID: 320
	[NetMessage(EMessageId.BabelActivityBuffInfoNotify)]
	public sealed class BabelActivityBuffInfoNotify : IMessage<BabelActivityBuffInfoNotify>, IMessage, IEquatable<BabelActivityBuffInfoNotify>, IDeepCloneable<BabelActivityBuffInfoNotify>, IBufferMessage
	{
		// Token: 0x060029B4 RID: 10676 RVA: 0x0006D877 File Offset: 0x0006BA77
		[NullableContext(1)]
		public static BabelActivityBuffInfoNotify Create()
		{
			return new BabelActivityBuffInfoNotify();
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060029B5 RID: 10677 RVA: 0x0006D87E File Offset: 0x0006BA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x060029B6 RID: 10678 RVA: 0x0006D881 File Offset: 0x0006BA81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityBuffInfoNotify.Descriptor;
			}
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x0006D888 File Offset: 0x0006BA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityBuffInfoNotify()
		{
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x0006D89B File Offset: 0x0006BA9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityBuffInfoNotify(BabelActivityBuffInfoNotify other) : this()
		{
			this.babelActivityBuffInfos_ = other.babelActivityBuffInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x0006D8C5 File Offset: 0x0006BAC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityBuffInfoNotify Clone()
		{
			return new BabelActivityBuffInfoNotify(this);
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060029BA RID: 10682 RVA: 0x0006D8CD File Offset: 0x0006BACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BabelActivityBuffInfo> BabelActivityBuffInfos
		{
			get
			{
				return this.babelActivityBuffInfos_;
			}
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x0006D8D5 File Offset: 0x0006BAD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityBuffInfoNotify);
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x0006D8E3 File Offset: 0x0006BAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityBuffInfoNotify other)
		{
			return other != null && (other == this || (this.babelActivityBuffInfos_.Equals(other.babelActivityBuffInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x0006D918 File Offset: 0x0006BB18
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

		// Token: 0x060029BE RID: 10686 RVA: 0x0006D94C File Offset: 0x0006BB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x0006D959 File Offset: 0x0006BB59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x0006D962 File Offset: 0x0006BB62
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

		// Token: 0x060029C1 RID: 10689 RVA: 0x0006D98C File Offset: 0x0006BB8C
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

		// Token: 0x060029C2 RID: 10690 RVA: 0x0006D9C5 File Offset: 0x0006BBC5
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

		// Token: 0x060029C3 RID: 10691 RVA: 0x0006D9F3 File Offset: 0x0006BBF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x0006D9FC File Offset: 0x0006BBFC
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.babelActivityBuffInfos_.AddEntriesFrom(ref input, BabelActivityBuffInfoNotify._repeated_babelActivityBuffInfos_codec);
				}
			}
		}

		// Token: 0x04002756 RID: 10070
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002757 RID: 10071
		public const int BabelActivityBuffInfosFieldNumber = 9;

		// Token: 0x04002758 RID: 10072
		private static readonly FieldCodec<BabelActivityBuffInfo> _repeated_babelActivityBuffInfos_codec = FieldCodec.ForMessage<BabelActivityBuffInfo>(74U, BabelActivityBuffInfo.Parser);

		// Token: 0x04002759 RID: 10073
		private readonly RepeatedField<BabelActivityBuffInfo> babelActivityBuffInfos_ = new RepeatedField<BabelActivityBuffInfo>();
	}
}
