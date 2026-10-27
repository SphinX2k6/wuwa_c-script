using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000145 RID: 325
	[NetMessage(EMessageId.BabelActivityLevelInfoNotify)]
	public sealed class BabelActivityLevelInfoNotify : IMessage<BabelActivityLevelInfoNotify>, IMessage, IEquatable<BabelActivityLevelInfoNotify>, IDeepCloneable<BabelActivityLevelInfoNotify>, IBufferMessage
	{
		// Token: 0x060029F5 RID: 10741 RVA: 0x0006E42B File Offset: 0x0006C62B
		[NullableContext(1)]
		public static BabelActivityLevelInfoNotify Create()
		{
			return new BabelActivityLevelInfoNotify();
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060029F6 RID: 10742 RVA: 0x0006E432 File Offset: 0x0006C632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060029F7 RID: 10743 RVA: 0x0006E435 File Offset: 0x0006C635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityLevelInfoNotify.Descriptor;
			}
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x0006E43C File Offset: 0x0006C63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityLevelInfoNotify()
		{
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x0006E44F File Offset: 0x0006C64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityLevelInfoNotify(BabelActivityLevelInfoNotify other) : this()
		{
			this.babelActivityLevelInfos_ = other.babelActivityLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x0006E479 File Offset: 0x0006C679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityLevelInfoNotify Clone()
		{
			return new BabelActivityLevelInfoNotify(this);
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060029FB RID: 10747 RVA: 0x0006E481 File Offset: 0x0006C681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BabelActivityLevelInfo> BabelActivityLevelInfos
		{
			get
			{
				return this.babelActivityLevelInfos_;
			}
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x0006E489 File Offset: 0x0006C689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityLevelInfoNotify);
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x0006E497 File Offset: 0x0006C697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityLevelInfoNotify other)
		{
			return other != null && (other == this || (this.babelActivityLevelInfos_.Equals(other.babelActivityLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x0006E4CC File Offset: 0x0006C6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.babelActivityLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x0006E500 File Offset: 0x0006C700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x0006E50D File Offset: 0x0006C70D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x0006E516 File Offset: 0x0006C716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.babelActivityLevelInfos_.WriteTo(ref output, BabelActivityLevelInfoNotify._repeated_babelActivityLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x0006E540 File Offset: 0x0006C740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.babelActivityLevelInfos_.CalculateSize(BabelActivityLevelInfoNotify._repeated_babelActivityLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x0006E579 File Offset: 0x0006C779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelActivityLevelInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.babelActivityLevelInfos_.Add(other.babelActivityLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x0006E5A7 File Offset: 0x0006C7A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x0006E5B0 File Offset: 0x0006C7B0
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
					this.babelActivityLevelInfos_.AddEntriesFrom(ref input, BabelActivityLevelInfoNotify._repeated_babelActivityLevelInfos_codec);
				}
			}
		}

		// Token: 0x0400273D RID: 10045
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400273E RID: 10046
		public const int BabelActivityLevelInfosFieldNumber = 6;

		// Token: 0x0400273F RID: 10047
		private static readonly FieldCodec<BabelActivityLevelInfo> _repeated_babelActivityLevelInfos_codec = FieldCodec.ForMessage<BabelActivityLevelInfo>(50U, BabelActivityLevelInfo.Parser);

		// Token: 0x04002740 RID: 10048
		private readonly RepeatedField<BabelActivityLevelInfo> babelActivityLevelInfos_ = new RepeatedField<BabelActivityLevelInfo>();
	}
}
