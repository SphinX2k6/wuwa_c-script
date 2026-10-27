using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F99 RID: 3993
	[NetMessage(EMessageId.RoguelikeCurrencyUpdateNotify)]
	public sealed class RoguelikeCurrencyUpdateNotify : IMessage<RoguelikeCurrencyUpdateNotify>, IMessage, IEquatable<RoguelikeCurrencyUpdateNotify>, IDeepCloneable<RoguelikeCurrencyUpdateNotify>, IBufferMessage
	{
		// Token: 0x060155B0 RID: 87472 RVA: 0x0031966F File Offset: 0x0031786F
		[NullableContext(1)]
		public static RoguelikeCurrencyUpdateNotify Create()
		{
			return new RoguelikeCurrencyUpdateNotify();
		}

		// Token: 0x1700472C RID: 18220
		// (get) Token: 0x060155B1 RID: 87473 RVA: 0x00319676 File Offset: 0x00317876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700472D RID: 18221
		// (get) Token: 0x060155B2 RID: 87474 RVA: 0x00319679 File Offset: 0x00317879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeCurrencyUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060155B3 RID: 87475 RVA: 0x00319680 File Offset: 0x00317880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeCurrencyUpdateNotify()
		{
		}

		// Token: 0x060155B4 RID: 87476 RVA: 0x00319693 File Offset: 0x00317893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeCurrencyUpdateNotify(RoguelikeCurrencyUpdateNotify other) : this()
		{
			this.currencyUpdateDict_ = other.currencyUpdateDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060155B5 RID: 87477 RVA: 0x003196BD File Offset: 0x003178BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeCurrencyUpdateNotify Clone()
		{
			return new RoguelikeCurrencyUpdateNotify(this);
		}

		// Token: 0x1700472E RID: 18222
		// (get) Token: 0x060155B6 RID: 87478 RVA: 0x003196C5 File Offset: 0x003178C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> CurrencyUpdateDict
		{
			get
			{
				return this.currencyUpdateDict_;
			}
		}

		// Token: 0x060155B7 RID: 87479 RVA: 0x003196CD File Offset: 0x003178CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeCurrencyUpdateNotify);
		}

		// Token: 0x060155B8 RID: 87480 RVA: 0x003196DB File Offset: 0x003178DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeCurrencyUpdateNotify other)
		{
			return other != null && (other == this || (this.CurrencyUpdateDict.Equals(other.CurrencyUpdateDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060155B9 RID: 87481 RVA: 0x00319710 File Offset: 0x00317910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.CurrencyUpdateDict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060155BA RID: 87482 RVA: 0x00319744 File Offset: 0x00317944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060155BB RID: 87483 RVA: 0x00319751 File Offset: 0x00317951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060155BC RID: 87484 RVA: 0x0031975A File Offset: 0x0031795A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.currencyUpdateDict_.WriteTo(ref output, RoguelikeCurrencyUpdateNotify._map_currencyUpdateDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060155BD RID: 87485 RVA: 0x00319784 File Offset: 0x00317984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.currencyUpdateDict_.CalculateSize(RoguelikeCurrencyUpdateNotify._map_currencyUpdateDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060155BE RID: 87486 RVA: 0x003197BD File Offset: 0x003179BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeCurrencyUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.currencyUpdateDict_.MergeFrom(other.currencyUpdateDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060155BF RID: 87487 RVA: 0x003197EB File Offset: 0x003179EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060155C0 RID: 87488 RVA: 0x003197F4 File Offset: 0x003179F4
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.currencyUpdateDict_.AddEntriesFrom(ref input, RoguelikeCurrencyUpdateNotify._map_currencyUpdateDict_codec);
				}
			}
		}

		// Token: 0x0400807E RID: 32894
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400807F RID: 32895
		public const int CurrencyUpdateDictFieldNumber = 11;

		// Token: 0x04008080 RID: 32896
		private static readonly MapField<int, int>.Codec _map_currencyUpdateDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 90U);

		// Token: 0x04008081 RID: 32897
		private readonly MapField<int, int> currencyUpdateDict_ = new MapField<int, int>();
	}
}
