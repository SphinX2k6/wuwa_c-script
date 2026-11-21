using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC5 RID: 4037
	[NetMessage(EMessageId.RogueResCurrencyUpdateNotify)]
	public sealed class RogueResCurrencyUpdateNotify : IMessage<RogueResCurrencyUpdateNotify>, IMessage, IEquatable<RogueResCurrencyUpdateNotify>, IDeepCloneable<RogueResCurrencyUpdateNotify>, IBufferMessage
	{
		// Token: 0x060159B9 RID: 88505 RVA: 0x003237BF File Offset: 0x003219BF
		[NullableContext(1)]
		public static RogueResCurrencyUpdateNotify Create()
		{
			return new RogueResCurrencyUpdateNotify();
		}

		// Token: 0x17004815 RID: 18453
		// (get) Token: 0x060159BA RID: 88506 RVA: 0x003237C6 File Offset: 0x003219C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004816 RID: 18454
		// (get) Token: 0x060159BB RID: 88507 RVA: 0x003237C9 File Offset: 0x003219C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResCurrencyUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060159BC RID: 88508 RVA: 0x003237D0 File Offset: 0x003219D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResCurrencyUpdateNotify()
		{
		}

		// Token: 0x060159BD RID: 88509 RVA: 0x003237E3 File Offset: 0x003219E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResCurrencyUpdateNotify(RogueResCurrencyUpdateNotify other) : this()
		{
			this.currencyUpdateDict_ = other.currencyUpdateDict_.Clone();
			this.eventType_ = other.eventType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060159BE RID: 88510 RVA: 0x00323819 File Offset: 0x00321A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResCurrencyUpdateNotify Clone()
		{
			return new RogueResCurrencyUpdateNotify(this);
		}

		// Token: 0x17004817 RID: 18455
		// (get) Token: 0x060159BF RID: 88511 RVA: 0x00323821 File Offset: 0x00321A21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> CurrencyUpdateDict
		{
			get
			{
				return this.currencyUpdateDict_;
			}
		}

		// Token: 0x17004818 RID: 18456
		// (get) Token: 0x060159C0 RID: 88512 RVA: 0x00323829 File Offset: 0x00321A29
		// (set) Token: 0x060159C1 RID: 88513 RVA: 0x00323831 File Offset: 0x00321A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventType
		{
			get
			{
				return this.eventType_;
			}
			set
			{
				this.eventType_ = value;
			}
		}

		// Token: 0x060159C2 RID: 88514 RVA: 0x0032383A File Offset: 0x00321A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResCurrencyUpdateNotify);
		}

		// Token: 0x060159C3 RID: 88515 RVA: 0x00323848 File Offset: 0x00321A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResCurrencyUpdateNotify other)
		{
			return other != null && (other == this || (this.CurrencyUpdateDict.Equals(other.CurrencyUpdateDict) && this.EventType == other.EventType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060159C4 RID: 88516 RVA: 0x00323898 File Offset: 0x00321A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.CurrencyUpdateDict.GetHashCode();
			if (this.EventType != 0)
			{
				num ^= this.EventType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060159C5 RID: 88517 RVA: 0x003238E5 File Offset: 0x00321AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060159C6 RID: 88518 RVA: 0x003238F2 File Offset: 0x00321AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060159C7 RID: 88519 RVA: 0x003238FC File Offset: 0x00321AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.EventType);
			}
			this.currencyUpdateDict_.WriteTo(ref output, RogueResCurrencyUpdateNotify._map_currencyUpdateDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060159C8 RID: 88520 RVA: 0x0032394C File Offset: 0x00321B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.currencyUpdateDict_.CalculateSize(RogueResCurrencyUpdateNotify._map_currencyUpdateDict_codec);
			if (this.EventType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060159C9 RID: 88521 RVA: 0x003239A0 File Offset: 0x00321BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResCurrencyUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.currencyUpdateDict_.MergeFrom(other.currencyUpdateDict_);
			if (other.EventType != 0)
			{
				this.EventType = other.EventType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060159CA RID: 88522 RVA: 0x003239ED File Offset: 0x00321BED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060159CB RID: 88523 RVA: 0x003239F8 File Offset: 0x00321BF8
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
				if (num != 32U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.currencyUpdateDict_.AddEntriesFrom(ref input, RogueResCurrencyUpdateNotify._map_currencyUpdateDict_codec);
					}
				}
				else
				{
					this.EventType = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008235 RID: 33333
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008236 RID: 33334
		public const int CurrencyUpdateDictFieldNumber = 12;

		// Token: 0x04008237 RID: 33335
		private static readonly MapField<int, int>.Codec _map_currencyUpdateDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 98U);

		// Token: 0x04008238 RID: 33336
		private readonly MapField<int, int> currencyUpdateDict_ = new MapField<int, int>();

		// Token: 0x04008239 RID: 33337
		public const int EventTypeFieldNumber = 4;

		// Token: 0x0400823A RID: 33338
		private int eventType_;
	}
}
