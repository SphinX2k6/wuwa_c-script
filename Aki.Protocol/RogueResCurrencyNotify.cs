using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC4 RID: 4036
	[NetMessage(EMessageId.RogueResCurrencyNotify)]
	public sealed class RogueResCurrencyNotify : IMessage<RogueResCurrencyNotify>, IMessage, IEquatable<RogueResCurrencyNotify>, IDeepCloneable<RogueResCurrencyNotify>, IBufferMessage
	{
		// Token: 0x060159A7 RID: 88487 RVA: 0x003235D2 File Offset: 0x003217D2
		[NullableContext(1)]
		public static RogueResCurrencyNotify Create()
		{
			return new RogueResCurrencyNotify();
		}

		// Token: 0x17004812 RID: 18450
		// (get) Token: 0x060159A8 RID: 88488 RVA: 0x003235D9 File Offset: 0x003217D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004813 RID: 18451
		// (get) Token: 0x060159A9 RID: 88489 RVA: 0x003235DC File Offset: 0x003217DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResCurrencyNotify.Descriptor;
			}
		}

		// Token: 0x060159AA RID: 88490 RVA: 0x003235E3 File Offset: 0x003217E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResCurrencyNotify()
		{
		}

		// Token: 0x060159AB RID: 88491 RVA: 0x003235F6 File Offset: 0x003217F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResCurrencyNotify(RogueResCurrencyNotify other) : this()
		{
			this.currencyDict_ = other.currencyDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060159AC RID: 88492 RVA: 0x00323620 File Offset: 0x00321820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResCurrencyNotify Clone()
		{
			return new RogueResCurrencyNotify(this);
		}

		// Token: 0x17004814 RID: 18452
		// (get) Token: 0x060159AD RID: 88493 RVA: 0x00323628 File Offset: 0x00321828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> CurrencyDict
		{
			get
			{
				return this.currencyDict_;
			}
		}

		// Token: 0x060159AE RID: 88494 RVA: 0x00323630 File Offset: 0x00321830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResCurrencyNotify);
		}

		// Token: 0x060159AF RID: 88495 RVA: 0x0032363E File Offset: 0x0032183E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResCurrencyNotify other)
		{
			return other != null && (other == this || (this.CurrencyDict.Equals(other.CurrencyDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060159B0 RID: 88496 RVA: 0x00323674 File Offset: 0x00321874
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

		// Token: 0x060159B1 RID: 88497 RVA: 0x003236A8 File Offset: 0x003218A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060159B2 RID: 88498 RVA: 0x003236B5 File Offset: 0x003218B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060159B3 RID: 88499 RVA: 0x003236BE File Offset: 0x003218BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.currencyDict_.WriteTo(ref output, RogueResCurrencyNotify._map_currencyDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060159B4 RID: 88500 RVA: 0x003236E8 File Offset: 0x003218E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.currencyDict_.CalculateSize(RogueResCurrencyNotify._map_currencyDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060159B5 RID: 88501 RVA: 0x00323721 File Offset: 0x00321921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResCurrencyNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.currencyDict_.MergeFrom(other.currencyDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060159B6 RID: 88502 RVA: 0x0032374F File Offset: 0x0032194F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060159B7 RID: 88503 RVA: 0x00323758 File Offset: 0x00321958
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
					this.currencyDict_.AddEntriesFrom(ref input, RogueResCurrencyNotify._map_currencyDict_codec);
				}
			}
		}

		// Token: 0x04008231 RID: 33329
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008232 RID: 33330
		public const int CurrencyDictFieldNumber = 14;

		// Token: 0x04008233 RID: 33331
		private static readonly MapField<int, int>.Codec _map_currencyDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 114U);

		// Token: 0x04008234 RID: 33332
		private readonly MapField<int, int> currencyDict_ = new MapField<int, int>();
	}
}
