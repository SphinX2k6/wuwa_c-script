using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F98 RID: 3992
	[NetMessage(EMessageId.RoguelikeCurrencyNotify)]
	public sealed class RoguelikeCurrencyNotify : IMessage<RoguelikeCurrencyNotify>, IMessage, IEquatable<RoguelikeCurrencyNotify>, IDeepCloneable<RoguelikeCurrencyNotify>, IBufferMessage
	{
		// Token: 0x0601559E RID: 87454 RVA: 0x00319484 File Offset: 0x00317684
		[NullableContext(1)]
		public static RoguelikeCurrencyNotify Create()
		{
			return new RoguelikeCurrencyNotify();
		}

		// Token: 0x17004729 RID: 18217
		// (get) Token: 0x0601559F RID: 87455 RVA: 0x0031948B File Offset: 0x0031768B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700472A RID: 18218
		// (get) Token: 0x060155A0 RID: 87456 RVA: 0x0031948E File Offset: 0x0031768E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeCurrencyNotify.Descriptor;
			}
		}

		// Token: 0x060155A1 RID: 87457 RVA: 0x00319495 File Offset: 0x00317695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeCurrencyNotify()
		{
		}

		// Token: 0x060155A2 RID: 87458 RVA: 0x003194A8 File Offset: 0x003176A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeCurrencyNotify(RoguelikeCurrencyNotify other) : this()
		{
			this.currencyDict_ = other.currencyDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060155A3 RID: 87459 RVA: 0x003194D2 File Offset: 0x003176D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeCurrencyNotify Clone()
		{
			return new RoguelikeCurrencyNotify(this);
		}

		// Token: 0x1700472B RID: 18219
		// (get) Token: 0x060155A4 RID: 87460 RVA: 0x003194DA File Offset: 0x003176DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> CurrencyDict
		{
			get
			{
				return this.currencyDict_;
			}
		}

		// Token: 0x060155A5 RID: 87461 RVA: 0x003194E2 File Offset: 0x003176E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeCurrencyNotify);
		}

		// Token: 0x060155A6 RID: 87462 RVA: 0x003194F0 File Offset: 0x003176F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeCurrencyNotify other)
		{
			return other != null && (other == this || (this.CurrencyDict.Equals(other.CurrencyDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060155A7 RID: 87463 RVA: 0x00319524 File Offset: 0x00317724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.CurrencyDict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060155A8 RID: 87464 RVA: 0x00319558 File Offset: 0x00317758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060155A9 RID: 87465 RVA: 0x00319565 File Offset: 0x00317765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060155AA RID: 87466 RVA: 0x0031956E File Offset: 0x0031776E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.currencyDict_.WriteTo(ref output, RoguelikeCurrencyNotify._map_currencyDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060155AB RID: 87467 RVA: 0x00319598 File Offset: 0x00317798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.currencyDict_.CalculateSize(RoguelikeCurrencyNotify._map_currencyDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060155AC RID: 87468 RVA: 0x003195D1 File Offset: 0x003177D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeCurrencyNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.currencyDict_.MergeFrom(other.currencyDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060155AD RID: 87469 RVA: 0x003195FF File Offset: 0x003177FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060155AE RID: 87470 RVA: 0x00319608 File Offset: 0x00317808
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.currencyDict_.AddEntriesFrom(ref input, RoguelikeCurrencyNotify._map_currencyDict_codec);
				}
			}
		}

		// Token: 0x0400807A RID: 32890
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400807B RID: 32891
		public const int CurrencyDictFieldNumber = 14;

		// Token: 0x0400807C RID: 32892
		private static readonly MapField<int, int>.Codec _map_currencyDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 114U);

		// Token: 0x0400807D RID: 32893
		private readonly MapField<int, int> currencyDict_ = new MapField<int, int>();
	}
}
