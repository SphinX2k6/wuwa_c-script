using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD5 RID: 4053
	[NetMessage(EMessageId.RogueResCurrencyUpdateNotify)]
	public sealed class RogueResCurrencyUpdateNotify : IMessage<RogueResCurrencyUpdateNotify>, IMessage, IEquatable<RogueResCurrencyUpdateNotify>, IDeepCloneable<RogueResCurrencyUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015A9E RID: 88734 RVA: 0x00324E73 File Offset: 0x00323073
		[NullableContext(1)]
		public static RogueResCurrencyUpdateNotify Create()
		{
			return new RogueResCurrencyUpdateNotify();
		}

		// Token: 0x1700483F RID: 18495
		// (get) Token: 0x06015A9F RID: 88735 RVA: 0x00324E7A File Offset: 0x0032307A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004840 RID: 18496
		// (get) Token: 0x06015AA0 RID: 88736 RVA: 0x00324E7D File Offset: 0x0032307D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResCurrencyUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015AA1 RID: 88737 RVA: 0x00324E84 File Offset: 0x00323084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResCurrencyUpdateNotify()
		{
		}

		// Token: 0x06015AA2 RID: 88738 RVA: 0x00324E97 File Offset: 0x00323097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResCurrencyUpdateNotify(RogueResCurrencyUpdateNotify other) : this()
		{
			this.currencyUpdateDict_ = other.currencyUpdateDict_.Clone();
			this.eventType_ = other.eventType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015AA3 RID: 88739 RVA: 0x00324ECD File Offset: 0x003230CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResCurrencyUpdateNotify Clone()
		{
			return new RogueResCurrencyUpdateNotify(this);
		}

		// Token: 0x17004841 RID: 18497
		// (get) Token: 0x06015AA4 RID: 88740 RVA: 0x00324ED5 File Offset: 0x003230D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> CurrencyUpdateDict
		{
			get
			{
				return this.currencyUpdateDict_;
			}
		}

		// Token: 0x17004842 RID: 18498
		// (get) Token: 0x06015AA5 RID: 88741 RVA: 0x00324EDD File Offset: 0x003230DD
		// (set) Token: 0x06015AA6 RID: 88742 RVA: 0x00324EE5 File Offset: 0x003230E5
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

		// Token: 0x06015AA7 RID: 88743 RVA: 0x00324EEE File Offset: 0x003230EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResCurrencyUpdateNotify);
		}

		// Token: 0x06015AA8 RID: 88744 RVA: 0x00324EFC File Offset: 0x003230FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResCurrencyUpdateNotify other)
		{
			return other != null && (other == this || (this.CurrencyUpdateDict.Equals(other.CurrencyUpdateDict) && this.EventType == other.EventType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015AA9 RID: 88745 RVA: 0x00324F4C File Offset: 0x0032314C
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

		// Token: 0x06015AAA RID: 88746 RVA: 0x00324F99 File Offset: 0x00323199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015AAB RID: 88747 RVA: 0x00324FA6 File Offset: 0x003231A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015AAC RID: 88748 RVA: 0x00324FB0 File Offset: 0x003231B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EventType);
			}
			this.currencyUpdateDict_.WriteTo(ref output, RogueResCurrencyUpdateNotify._map_currencyUpdateDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015AAD RID: 88749 RVA: 0x00325000 File Offset: 0x00323200
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

		// Token: 0x06015AAE RID: 88750 RVA: 0x00325054 File Offset: 0x00323254
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

		// Token: 0x06015AAF RID: 88751 RVA: 0x003250A1 File Offset: 0x003232A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015AB0 RID: 88752 RVA: 0x003250AC File Offset: 0x003232AC
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
				if (num != 40U)
				{
					if (num != 122U)
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

		// Token: 0x0400820B RID: 33291
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400820C RID: 33292
		public const int CurrencyUpdateDictFieldNumber = 15;

		// Token: 0x0400820D RID: 33293
		private static readonly MapField<int, int>.Codec _map_currencyUpdateDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 122U);

		// Token: 0x0400820E RID: 33294
		private readonly MapField<int, int> currencyUpdateDict_ = new MapField<int, int>();

		// Token: 0x0400820F RID: 33295
		public const int EventTypeFieldNumber = 5;

		// Token: 0x04008210 RID: 33296
		private int eventType_;
	}
}
