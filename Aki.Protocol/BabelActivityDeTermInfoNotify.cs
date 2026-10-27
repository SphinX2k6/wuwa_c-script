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
	[NetMessage(EMessageId.BabelActivityDeTermInfoNotify)]
	public sealed class BabelActivityDeTermInfoNotify : IMessage<BabelActivityDeTermInfoNotify>, IMessage, IEquatable<BabelActivityDeTermInfoNotify>, IDeepCloneable<BabelActivityDeTermInfoNotify>, IBufferMessage
	{
		// Token: 0x06002977 RID: 10615 RVA: 0x0006CAAF File Offset: 0x0006ACAF
		[NullableContext(1)]
		public static BabelActivityDeTermInfoNotify Create()
		{
			return new BabelActivityDeTermInfoNotify();
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06002978 RID: 10616 RVA: 0x0006CAB6 File Offset: 0x0006ACB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06002979 RID: 10617 RVA: 0x0006CAB9 File Offset: 0x0006ACB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityDeTermInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x0006CAC0 File Offset: 0x0006ACC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityDeTermInfoNotify()
		{
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x0006CAD3 File Offset: 0x0006ACD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityDeTermInfoNotify(BabelActivityDeTermInfoNotify other) : this()
		{
			this.babelActivityDeTermInfos_ = other.babelActivityDeTermInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x0006CAFD File Offset: 0x0006ACFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityDeTermInfoNotify Clone()
		{
			return new BabelActivityDeTermInfoNotify(this);
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x0600297D RID: 10621 RVA: 0x0006CB05 File Offset: 0x0006AD05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BabelActivityDeTermInfo> BabelActivityDeTermInfos
		{
			get
			{
				return this.babelActivityDeTermInfos_;
			}
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x0006CB0D File Offset: 0x0006AD0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityDeTermInfoNotify);
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x0006CB1B File Offset: 0x0006AD1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityDeTermInfoNotify other)
		{
			return other != null && (other == this || (this.babelActivityDeTermInfos_.Equals(other.babelActivityDeTermInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x0006CB50 File Offset: 0x0006AD50
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

		// Token: 0x06002981 RID: 10625 RVA: 0x0006CB84 File Offset: 0x0006AD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x0006CB91 File Offset: 0x0006AD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x0006CB9A File Offset: 0x0006AD9A
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

		// Token: 0x06002984 RID: 10628 RVA: 0x0006CBC4 File Offset: 0x0006ADC4
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

		// Token: 0x06002985 RID: 10629 RVA: 0x0006CBFD File Offset: 0x0006ADFD
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

		// Token: 0x06002986 RID: 10630 RVA: 0x0006CC2B File Offset: 0x0006AE2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x0006CC34 File Offset: 0x0006AE34
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
					this.babelActivityDeTermInfos_.AddEntriesFrom(ref input, BabelActivityDeTermInfoNotify._repeated_babelActivityDeTermInfos_codec);
				}
			}
		}

		// Token: 0x040026F0 RID: 9968
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026F1 RID: 9969
		public const int BabelActivityDeTermInfosFieldNumber = 9;

		// Token: 0x040026F2 RID: 9970
		private static readonly FieldCodec<BabelActivityDeTermInfo> _repeated_babelActivityDeTermInfos_codec = FieldCodec.ForMessage<BabelActivityDeTermInfo>(74U, BabelActivityDeTermInfo.Parser);

		// Token: 0x040026F3 RID: 9971
		private readonly RepeatedField<BabelActivityDeTermInfo> babelActivityDeTermInfos_ = new RepeatedField<BabelActivityDeTermInfo>();
	}
}
