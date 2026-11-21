using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F88 RID: 3976
	[NetMessage(EMessageId.RoguelikeCurrencyNotify)]
	public sealed class RoguelikeCurrencyNotify : IMessage<RoguelikeCurrencyNotify>, IMessage, IEquatable<RoguelikeCurrencyNotify>, IDeepCloneable<RoguelikeCurrencyNotify>, IBufferMessage
	{
		// Token: 0x060154B9 RID: 87225 RVA: 0x00317DDB File Offset: 0x00315FDB
		[NullableContext(1)]
		public static RoguelikeCurrencyNotify Create()
		{
			return new RoguelikeCurrencyNotify();
		}

		// Token: 0x170046FF RID: 18175
		// (get) Token: 0x060154BA RID: 87226 RVA: 0x00317DE2 File Offset: 0x00315FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004700 RID: 18176
		// (get) Token: 0x060154BB RID: 87227 RVA: 0x00317DE5 File Offset: 0x00315FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeCurrencyNotify.Descriptor;
			}
		}

		// Token: 0x060154BC RID: 87228 RVA: 0x00317DEC File Offset: 0x00315FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeCurrencyNotify()
		{
		}

		// Token: 0x060154BD RID: 87229 RVA: 0x00317DFF File Offset: 0x00315FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeCurrencyNotify(RoguelikeCurrencyNotify other) : this()
		{
			this.currencyDict_ = other.currencyDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060154BE RID: 87230 RVA: 0x00317E29 File Offset: 0x00316029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeCurrencyNotify Clone()
		{
			return new RoguelikeCurrencyNotify(this);
		}

		// Token: 0x17004701 RID: 18177
		// (get) Token: 0x060154BF RID: 87231 RVA: 0x00317E31 File Offset: 0x00316031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> CurrencyDict
		{
			get
			{
				return this.currencyDict_;
			}
		}

		// Token: 0x060154C0 RID: 87232 RVA: 0x00317E39 File Offset: 0x00316039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeCurrencyNotify);
		}

		// Token: 0x060154C1 RID: 87233 RVA: 0x00317E47 File Offset: 0x00316047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeCurrencyNotify other)
		{
			return other != null && (other == this || (this.CurrencyDict.Equals(other.CurrencyDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060154C2 RID: 87234 RVA: 0x00317E7C File Offset: 0x0031607C
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

		// Token: 0x060154C3 RID: 87235 RVA: 0x00317EB0 File Offset: 0x003160B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060154C4 RID: 87236 RVA: 0x00317EBD File Offset: 0x003160BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060154C5 RID: 87237 RVA: 0x00317EC6 File Offset: 0x003160C6
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

		// Token: 0x060154C6 RID: 87238 RVA: 0x00317EF0 File Offset: 0x003160F0
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

		// Token: 0x060154C7 RID: 87239 RVA: 0x00317F29 File Offset: 0x00316129
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

		// Token: 0x060154C8 RID: 87240 RVA: 0x00317F57 File Offset: 0x00316157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060154C9 RID: 87241 RVA: 0x00317F60 File Offset: 0x00316160
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.currencyDict_.AddEntriesFrom(ref input, RoguelikeCurrencyNotify._map_currencyDict_codec);
				}
			}
		}

		// Token: 0x040080A4 RID: 32932
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080A5 RID: 32933
		public const int CurrencyDictFieldNumber = 12;

		// Token: 0x040080A6 RID: 32934
		private static readonly MapField<int, int>.Codec _map_currencyDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 98U);

		// Token: 0x040080A7 RID: 32935
		private readonly MapField<int, int> currencyDict_ = new MapField<int, int>();
	}
}
