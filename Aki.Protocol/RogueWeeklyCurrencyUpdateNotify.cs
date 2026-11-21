using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001024 RID: 4132
	[NetMessage(EMessageId.RogueWeeklyCurrencyUpdateNotify)]
	public sealed class RogueWeeklyCurrencyUpdateNotify : IMessage<RogueWeeklyCurrencyUpdateNotify>, IMessage, IEquatable<RogueWeeklyCurrencyUpdateNotify>, IDeepCloneable<RogueWeeklyCurrencyUpdateNotify>, IBufferMessage
	{
		// Token: 0x060161C0 RID: 90560 RVA: 0x00336D13 File Offset: 0x00334F13
		[NullableContext(1)]
		public static RogueWeeklyCurrencyUpdateNotify Create()
		{
			return new RogueWeeklyCurrencyUpdateNotify();
		}

		// Token: 0x170049EA RID: 18922
		// (get) Token: 0x060161C1 RID: 90561 RVA: 0x00336D1A File Offset: 0x00334F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049EB RID: 18923
		// (get) Token: 0x060161C2 RID: 90562 RVA: 0x00336D1D File Offset: 0x00334F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyCurrencyUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060161C3 RID: 90563 RVA: 0x00336D24 File Offset: 0x00334F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyCurrencyUpdateNotify()
		{
		}

		// Token: 0x060161C4 RID: 90564 RVA: 0x00336D37 File Offset: 0x00334F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyCurrencyUpdateNotify(RogueWeeklyCurrencyUpdateNotify other) : this()
		{
			this.currencyDict_ = other.currencyDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060161C5 RID: 90565 RVA: 0x00336D61 File Offset: 0x00334F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyCurrencyUpdateNotify Clone()
		{
			return new RogueWeeklyCurrencyUpdateNotify(this);
		}

		// Token: 0x170049EC RID: 18924
		// (get) Token: 0x060161C6 RID: 90566 RVA: 0x00336D69 File Offset: 0x00334F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> CurrencyDict
		{
			get
			{
				return this.currencyDict_;
			}
		}

		// Token: 0x060161C7 RID: 90567 RVA: 0x00336D71 File Offset: 0x00334F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyCurrencyUpdateNotify);
		}

		// Token: 0x060161C8 RID: 90568 RVA: 0x00336D7F File Offset: 0x00334F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyCurrencyUpdateNotify other)
		{
			return other != null && (other == this || (this.CurrencyDict.Equals(other.CurrencyDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060161C9 RID: 90569 RVA: 0x00336DB4 File Offset: 0x00334FB4
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

		// Token: 0x060161CA RID: 90570 RVA: 0x00336DE8 File Offset: 0x00334FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060161CB RID: 90571 RVA: 0x00336DF5 File Offset: 0x00334FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060161CC RID: 90572 RVA: 0x00336DFE File Offset: 0x00334FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.currencyDict_.WriteTo(ref output, RogueWeeklyCurrencyUpdateNotify._map_currencyDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060161CD RID: 90573 RVA: 0x00336E28 File Offset: 0x00335028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.currencyDict_.CalculateSize(RogueWeeklyCurrencyUpdateNotify._map_currencyDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060161CE RID: 90574 RVA: 0x00336E61 File Offset: 0x00335061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyCurrencyUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.currencyDict_.MergeFrom(other.currencyDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060161CF RID: 90575 RVA: 0x00336E8F File Offset: 0x0033508F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060161D0 RID: 90576 RVA: 0x00336E98 File Offset: 0x00335098
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.currencyDict_.AddEntriesFrom(ref input, RogueWeeklyCurrencyUpdateNotify._map_currencyDict_codec);
				}
			}
		}

		// Token: 0x040084D3 RID: 34003
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084D4 RID: 34004
		public const int CurrencyDictFieldNumber = 5;

		// Token: 0x040084D5 RID: 34005
		private static readonly MapField<int, int>.Codec _map_currencyDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x040084D6 RID: 34006
		private readonly MapField<int, int> currencyDict_ = new MapField<int, int>();
	}
}
