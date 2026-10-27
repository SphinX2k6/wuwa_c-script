using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001033 RID: 4147
	[NetMessage(EMessageId.RogueWeeklyCurrencyNotify)]
	public sealed class RogueWeeklyCurrencyNotify : IMessage<RogueWeeklyCurrencyNotify>, IMessage, IEquatable<RogueWeeklyCurrencyNotify>, IDeepCloneable<RogueWeeklyCurrencyNotify>, IBufferMessage
	{
		// Token: 0x06016293 RID: 90771 RVA: 0x003381EC File Offset: 0x003363EC
		[NullableContext(1)]
		public static RogueWeeklyCurrencyNotify Create()
		{
			return new RogueWeeklyCurrencyNotify();
		}

		// Token: 0x17004A11 RID: 18961
		// (get) Token: 0x06016294 RID: 90772 RVA: 0x003381F3 File Offset: 0x003363F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A12 RID: 18962
		// (get) Token: 0x06016295 RID: 90773 RVA: 0x003381F6 File Offset: 0x003363F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyCurrencyNotify.Descriptor;
			}
		}

		// Token: 0x06016296 RID: 90774 RVA: 0x003381FD File Offset: 0x003363FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyCurrencyNotify()
		{
		}

		// Token: 0x06016297 RID: 90775 RVA: 0x00338210 File Offset: 0x00336410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyCurrencyNotify(RogueWeeklyCurrencyNotify other) : this()
		{
			this.currencyDict_ = other.currencyDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016298 RID: 90776 RVA: 0x0033823A File Offset: 0x0033643A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyCurrencyNotify Clone()
		{
			return new RogueWeeklyCurrencyNotify(this);
		}

		// Token: 0x17004A13 RID: 18963
		// (get) Token: 0x06016299 RID: 90777 RVA: 0x00338242 File Offset: 0x00336442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> CurrencyDict
		{
			get
			{
				return this.currencyDict_;
			}
		}

		// Token: 0x0601629A RID: 90778 RVA: 0x0033824A File Offset: 0x0033644A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyCurrencyNotify);
		}

		// Token: 0x0601629B RID: 90779 RVA: 0x00338258 File Offset: 0x00336458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyCurrencyNotify other)
		{
			return other != null && (other == this || (this.CurrencyDict.Equals(other.CurrencyDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601629C RID: 90780 RVA: 0x0033828C File Offset: 0x0033648C
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

		// Token: 0x0601629D RID: 90781 RVA: 0x003382C0 File Offset: 0x003364C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601629E RID: 90782 RVA: 0x003382CD File Offset: 0x003364CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601629F RID: 90783 RVA: 0x003382D6 File Offset: 0x003364D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.currencyDict_.WriteTo(ref output, RogueWeeklyCurrencyNotify._map_currencyDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060162A0 RID: 90784 RVA: 0x00338300 File Offset: 0x00336500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.currencyDict_.CalculateSize(RogueWeeklyCurrencyNotify._map_currencyDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060162A1 RID: 90785 RVA: 0x00338339 File Offset: 0x00336539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyCurrencyNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.currencyDict_.MergeFrom(other.currencyDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060162A2 RID: 90786 RVA: 0x00338367 File Offset: 0x00336567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060162A3 RID: 90787 RVA: 0x00338370 File Offset: 0x00336570
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
					this.currencyDict_.AddEntriesFrom(ref input, RogueWeeklyCurrencyNotify._map_currencyDict_codec);
				}
			}
		}

		// Token: 0x040084A5 RID: 33957
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084A6 RID: 33958
		public const int CurrencyDictFieldNumber = 12;

		// Token: 0x040084A7 RID: 33959
		private static readonly MapField<int, int>.Codec _map_currencyDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 98U);

		// Token: 0x040084A8 RID: 33960
		private readonly MapField<int, int> currencyDict_ = new MapField<int, int>();
	}
}
