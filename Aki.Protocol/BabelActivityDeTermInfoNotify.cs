using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000143 RID: 323
	[NetMessage(EMessageId.BabelActivityDeTermInfoNotify)]
	public sealed class BabelActivityDeTermInfoNotify : IMessage<BabelActivityDeTermInfoNotify>, IMessage, IEquatable<BabelActivityDeTermInfoNotify>, IDeepCloneable<BabelActivityDeTermInfoNotify>, IBufferMessage
	{
		// Token: 0x060029EE RID: 10734 RVA: 0x0006DEE3 File Offset: 0x0006C0E3
		[NullableContext(1)]
		public static BabelActivityDeTermInfoNotify Create()
		{
			return new BabelActivityDeTermInfoNotify();
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060029EF RID: 10735 RVA: 0x0006DEEA File Offset: 0x0006C0EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060029F0 RID: 10736 RVA: 0x0006DEED File Offset: 0x0006C0ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityDeTermInfoNotify.Descriptor;
			}
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x0006DEF4 File Offset: 0x0006C0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityDeTermInfoNotify()
		{
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x0006DF07 File Offset: 0x0006C107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityDeTermInfoNotify(BabelActivityDeTermInfoNotify other) : this()
		{
			this.babelActivityDeTermInfos_ = other.babelActivityDeTermInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x0006DF31 File Offset: 0x0006C131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityDeTermInfoNotify Clone()
		{
			return new BabelActivityDeTermInfoNotify(this);
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060029F4 RID: 10740 RVA: 0x0006DF39 File Offset: 0x0006C139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BabelActivityDeTermInfo> BabelActivityDeTermInfos
		{
			get
			{
				return this.babelActivityDeTermInfos_;
			}
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x0006DF41 File Offset: 0x0006C141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityDeTermInfoNotify);
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x0006DF4F File Offset: 0x0006C14F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityDeTermInfoNotify other)
		{
			return other != null && (other == this || (this.babelActivityDeTermInfos_.Equals(other.babelActivityDeTermInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x0006DF84 File Offset: 0x0006C184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.babelActivityDeTermInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x0006DFB8 File Offset: 0x0006C1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x0006DFC5 File Offset: 0x0006C1C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x0006DFCE File Offset: 0x0006C1CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.babelActivityDeTermInfos_.WriteTo(ref output, BabelActivityDeTermInfoNotify._repeated_babelActivityDeTermInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x0006DFF8 File Offset: 0x0006C1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.babelActivityDeTermInfos_.CalculateSize(BabelActivityDeTermInfoNotify._repeated_babelActivityDeTermInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x0006E031 File Offset: 0x0006C231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelActivityDeTermInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.babelActivityDeTermInfos_.Add(other.babelActivityDeTermInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x0006E05F File Offset: 0x0006C25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x0006E068 File Offset: 0x0006C268
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
					this.babelActivityDeTermInfos_.AddEntriesFrom(ref input, BabelActivityDeTermInfoNotify._repeated_babelActivityDeTermInfos_codec);
				}
			}
		}

		// Token: 0x04002764 RID: 10084
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002765 RID: 10085
		public const int BabelActivityDeTermInfosFieldNumber = 6;

		// Token: 0x04002766 RID: 10086
		private static readonly FieldCodec<BabelActivityDeTermInfo> _repeated_babelActivityDeTermInfos_codec = FieldCodec.ForMessage<BabelActivityDeTermInfo>(50U, BabelActivityDeTermInfo.Parser);

		// Token: 0x04002767 RID: 10087
		private readonly RepeatedField<BabelActivityDeTermInfo> babelActivityDeTermInfos_ = new RepeatedField<BabelActivityDeTermInfo>();
	}
}
