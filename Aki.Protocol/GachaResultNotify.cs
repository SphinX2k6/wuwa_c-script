using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200068B RID: 1675
	[NetMessage(EMessageId.GachaResultNotify)]
	public sealed class GachaResultNotify : IMessage<GachaResultNotify>, IMessage, IEquatable<GachaResultNotify>, IDeepCloneable<GachaResultNotify>, IBufferMessage
	{
		// Token: 0x060099D4 RID: 39380 RVA: 0x00173CB9 File Offset: 0x00171EB9
		[NullableContext(1)]
		public static GachaResultNotify Create()
		{
			return new GachaResultNotify();
		}

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x060099D5 RID: 39381 RVA: 0x00173CC0 File Offset: 0x00171EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x060099D6 RID: 39382 RVA: 0x00173CC3 File Offset: 0x00171EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaResultNotify.Descriptor;
			}
		}

		// Token: 0x060099D7 RID: 39383 RVA: 0x00173CCA File Offset: 0x00171ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaResultNotify()
		{
		}

		// Token: 0x060099D8 RID: 39384 RVA: 0x00173CDD File Offset: 0x00171EDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaResultNotify(GachaResultNotify other) : this()
		{
			this.gachaResults_ = other.gachaResults_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060099D9 RID: 39385 RVA: 0x00173D07 File Offset: 0x00171F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaResultNotify Clone()
		{
			return new GachaResultNotify(this);
		}

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x060099DA RID: 39386 RVA: 0x00173D0F File Offset: 0x00171F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaResult> GachaResults
		{
			get
			{
				return this.gachaResults_;
			}
		}

		// Token: 0x060099DB RID: 39387 RVA: 0x00173D17 File Offset: 0x00171F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaResultNotify);
		}

		// Token: 0x060099DC RID: 39388 RVA: 0x00173D25 File Offset: 0x00171F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaResultNotify other)
		{
			return other != null && (other == this || (this.gachaResults_.Equals(other.gachaResults_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060099DD RID: 39389 RVA: 0x00173D58 File Offset: 0x00171F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gachaResults_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060099DE RID: 39390 RVA: 0x00173D8C File Offset: 0x00171F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060099DF RID: 39391 RVA: 0x00173D99 File Offset: 0x00171F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060099E0 RID: 39392 RVA: 0x00173DA2 File Offset: 0x00171FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gachaResults_.WriteTo(ref output, GachaResultNotify._repeated_gachaResults_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060099E1 RID: 39393 RVA: 0x00173DCC File Offset: 0x00171FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gachaResults_.CalculateSize(GachaResultNotify._repeated_gachaResults_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060099E2 RID: 39394 RVA: 0x00173E05 File Offset: 0x00172005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.gachaResults_.Add(other.gachaResults_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060099E3 RID: 39395 RVA: 0x00173E33 File Offset: 0x00172033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060099E4 RID: 39396 RVA: 0x00173E3C File Offset: 0x0017203C
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
					this.gachaResults_.AddEntriesFrom(ref input, GachaResultNotify._repeated_gachaResults_codec);
				}
			}
		}

		// Token: 0x0400494C RID: 18764
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400494D RID: 18765
		public const int GachaResultsFieldNumber = 7;

		// Token: 0x0400494E RID: 18766
		private static readonly FieldCodec<GachaResult> _repeated_gachaResults_codec = FieldCodec.ForMessage<GachaResult>(58U, GachaResult.Parser);

		// Token: 0x0400494F RID: 18767
		private readonly RepeatedField<GachaResult> gachaResults_ = new RepeatedField<GachaResult>();
	}
}
