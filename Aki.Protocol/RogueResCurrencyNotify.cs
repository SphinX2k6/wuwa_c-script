using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD4 RID: 4052
	[NetMessage(EMessageId.RogueResCurrencyNotify)]
	public sealed class RogueResCurrencyNotify : IMessage<RogueResCurrencyNotify>, IMessage, IEquatable<RogueResCurrencyNotify>, IDeepCloneable<RogueResCurrencyNotify>, IBufferMessage
	{
		// Token: 0x06015A8C RID: 88716 RVA: 0x00324C86 File Offset: 0x00322E86
		[NullableContext(1)]
		public static RogueResCurrencyNotify Create()
		{
			return new RogueResCurrencyNotify();
		}

		// Token: 0x1700483C RID: 18492
		// (get) Token: 0x06015A8D RID: 88717 RVA: 0x00324C8D File Offset: 0x00322E8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700483D RID: 18493
		// (get) Token: 0x06015A8E RID: 88718 RVA: 0x00324C90 File Offset: 0x00322E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResCurrencyNotify.Descriptor;
			}
		}

		// Token: 0x06015A8F RID: 88719 RVA: 0x00324C97 File Offset: 0x00322E97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResCurrencyNotify()
		{
		}

		// Token: 0x06015A90 RID: 88720 RVA: 0x00324CAA File Offset: 0x00322EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResCurrencyNotify(RogueResCurrencyNotify other) : this()
		{
			this.currencyDict_ = other.currencyDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015A91 RID: 88721 RVA: 0x00324CD4 File Offset: 0x00322ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResCurrencyNotify Clone()
		{
			return new RogueResCurrencyNotify(this);
		}

		// Token: 0x1700483E RID: 18494
		// (get) Token: 0x06015A92 RID: 88722 RVA: 0x00324CDC File Offset: 0x00322EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> CurrencyDict
		{
			get
			{
				return this.currencyDict_;
			}
		}

		// Token: 0x06015A93 RID: 88723 RVA: 0x00324CE4 File Offset: 0x00322EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResCurrencyNotify);
		}

		// Token: 0x06015A94 RID: 88724 RVA: 0x00324CF2 File Offset: 0x00322EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResCurrencyNotify other)
		{
			return other != null && (other == this || (this.CurrencyDict.Equals(other.CurrencyDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015A95 RID: 88725 RVA: 0x00324D28 File Offset: 0x00322F28
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

		// Token: 0x06015A96 RID: 88726 RVA: 0x00324D5C File Offset: 0x00322F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015A97 RID: 88727 RVA: 0x00324D69 File Offset: 0x00322F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015A98 RID: 88728 RVA: 0x00324D72 File Offset: 0x00322F72
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

		// Token: 0x06015A99 RID: 88729 RVA: 0x00324D9C File Offset: 0x00322F9C
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

		// Token: 0x06015A9A RID: 88730 RVA: 0x00324DD5 File Offset: 0x00322FD5
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

		// Token: 0x06015A9B RID: 88731 RVA: 0x00324E03 File Offset: 0x00323003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015A9C RID: 88732 RVA: 0x00324E0C File Offset: 0x0032300C
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.currencyDict_.AddEntriesFrom(ref input, RogueResCurrencyNotify._map_currencyDict_codec);
				}
			}
		}

		// Token: 0x04008207 RID: 33287
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008208 RID: 33288
		public const int CurrencyDictFieldNumber = 9;

		// Token: 0x04008209 RID: 33289
		private static readonly MapField<int, int>.Codec _map_currencyDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x0400820A RID: 33290
		private readonly MapField<int, int> currencyDict_ = new MapField<int, int>();
	}
}
