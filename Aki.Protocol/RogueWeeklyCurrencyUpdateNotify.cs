using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001034 RID: 4148
	[NetMessage(EMessageId.RogueWeeklyCurrencyUpdateNotify)]
	public sealed class RogueWeeklyCurrencyUpdateNotify : IMessage<RogueWeeklyCurrencyUpdateNotify>, IMessage, IEquatable<RogueWeeklyCurrencyUpdateNotify>, IDeepCloneable<RogueWeeklyCurrencyUpdateNotify>, IBufferMessage
	{
		// Token: 0x060162A5 RID: 90789 RVA: 0x003383D7 File Offset: 0x003365D7
		[NullableContext(1)]
		public static RogueWeeklyCurrencyUpdateNotify Create()
		{
			return new RogueWeeklyCurrencyUpdateNotify();
		}

		// Token: 0x17004A14 RID: 18964
		// (get) Token: 0x060162A6 RID: 90790 RVA: 0x003383DE File Offset: 0x003365DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A15 RID: 18965
		// (get) Token: 0x060162A7 RID: 90791 RVA: 0x003383E1 File Offset: 0x003365E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyCurrencyUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060162A8 RID: 90792 RVA: 0x003383E8 File Offset: 0x003365E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyCurrencyUpdateNotify()
		{
		}

		// Token: 0x060162A9 RID: 90793 RVA: 0x003383FB File Offset: 0x003365FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyCurrencyUpdateNotify(RogueWeeklyCurrencyUpdateNotify other) : this()
		{
			this.currencyDict_ = other.currencyDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060162AA RID: 90794 RVA: 0x00338425 File Offset: 0x00336625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyCurrencyUpdateNotify Clone()
		{
			return new RogueWeeklyCurrencyUpdateNotify(this);
		}

		// Token: 0x17004A16 RID: 18966
		// (get) Token: 0x060162AB RID: 90795 RVA: 0x0033842D File Offset: 0x0033662D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> CurrencyDict
		{
			get
			{
				return this.currencyDict_;
			}
		}

		// Token: 0x060162AC RID: 90796 RVA: 0x00338435 File Offset: 0x00336635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyCurrencyUpdateNotify);
		}

		// Token: 0x060162AD RID: 90797 RVA: 0x00338443 File Offset: 0x00336643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyCurrencyUpdateNotify other)
		{
			return other != null && (other == this || (this.CurrencyDict.Equals(other.CurrencyDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060162AE RID: 90798 RVA: 0x00338478 File Offset: 0x00336678
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

		// Token: 0x060162AF RID: 90799 RVA: 0x003384AC File Offset: 0x003366AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060162B0 RID: 90800 RVA: 0x003384B9 File Offset: 0x003366B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060162B1 RID: 90801 RVA: 0x003384C2 File Offset: 0x003366C2
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

		// Token: 0x060162B2 RID: 90802 RVA: 0x003384EC File Offset: 0x003366EC
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

		// Token: 0x060162B3 RID: 90803 RVA: 0x00338525 File Offset: 0x00336725
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

		// Token: 0x060162B4 RID: 90804 RVA: 0x00338553 File Offset: 0x00336753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060162B5 RID: 90805 RVA: 0x0033855C File Offset: 0x0033675C
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.currencyDict_.AddEntriesFrom(ref input, RogueWeeklyCurrencyUpdateNotify._map_currencyDict_codec);
				}
			}
		}

		// Token: 0x040084A9 RID: 33961
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084AA RID: 33962
		public const int CurrencyDictFieldNumber = 13;

		// Token: 0x040084AB RID: 33963
		private static readonly MapField<int, int>.Codec _map_currencyDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 106U);

		// Token: 0x040084AC RID: 33964
		private readonly MapField<int, int> currencyDict_ = new MapField<int, int>();
	}
}
