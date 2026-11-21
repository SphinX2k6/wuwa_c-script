using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001023 RID: 4131
	[NetMessage(EMessageId.RogueWeeklyCurrencyNotify)]
	public sealed class RogueWeeklyCurrencyNotify : IMessage<RogueWeeklyCurrencyNotify>, IMessage, IEquatable<RogueWeeklyCurrencyNotify>, IDeepCloneable<RogueWeeklyCurrencyNotify>, IBufferMessage
	{
		// Token: 0x060161AE RID: 90542 RVA: 0x00336B28 File Offset: 0x00334D28
		[NullableContext(1)]
		public static RogueWeeklyCurrencyNotify Create()
		{
			return new RogueWeeklyCurrencyNotify();
		}

		// Token: 0x170049E7 RID: 18919
		// (get) Token: 0x060161AF RID: 90543 RVA: 0x00336B2F File Offset: 0x00334D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049E8 RID: 18920
		// (get) Token: 0x060161B0 RID: 90544 RVA: 0x00336B32 File Offset: 0x00334D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyCurrencyNotify.Descriptor;
			}
		}

		// Token: 0x060161B1 RID: 90545 RVA: 0x00336B39 File Offset: 0x00334D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyCurrencyNotify()
		{
		}

		// Token: 0x060161B2 RID: 90546 RVA: 0x00336B4C File Offset: 0x00334D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyCurrencyNotify(RogueWeeklyCurrencyNotify other) : this()
		{
			this.currencyDict_ = other.currencyDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060161B3 RID: 90547 RVA: 0x00336B76 File Offset: 0x00334D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyCurrencyNotify Clone()
		{
			return new RogueWeeklyCurrencyNotify(this);
		}

		// Token: 0x170049E9 RID: 18921
		// (get) Token: 0x060161B4 RID: 90548 RVA: 0x00336B7E File Offset: 0x00334D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> CurrencyDict
		{
			get
			{
				return this.currencyDict_;
			}
		}

		// Token: 0x060161B5 RID: 90549 RVA: 0x00336B86 File Offset: 0x00334D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyCurrencyNotify);
		}

		// Token: 0x060161B6 RID: 90550 RVA: 0x00336B94 File Offset: 0x00334D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyCurrencyNotify other)
		{
			return other != null && (other == this || (this.CurrencyDict.Equals(other.CurrencyDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060161B7 RID: 90551 RVA: 0x00336BC8 File Offset: 0x00334DC8
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

		// Token: 0x060161B8 RID: 90552 RVA: 0x00336BFC File Offset: 0x00334DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060161B9 RID: 90553 RVA: 0x00336C09 File Offset: 0x00334E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060161BA RID: 90554 RVA: 0x00336C12 File Offset: 0x00334E12
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

		// Token: 0x060161BB RID: 90555 RVA: 0x00336C3C File Offset: 0x00334E3C
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

		// Token: 0x060161BC RID: 90556 RVA: 0x00336C75 File Offset: 0x00334E75
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

		// Token: 0x060161BD RID: 90557 RVA: 0x00336CA3 File Offset: 0x00334EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060161BE RID: 90558 RVA: 0x00336CAC File Offset: 0x00334EAC
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.currencyDict_.AddEntriesFrom(ref input, RogueWeeklyCurrencyNotify._map_currencyDict_codec);
				}
			}
		}

		// Token: 0x040084CF RID: 33999
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084D0 RID: 34000
		public const int CurrencyDictFieldNumber = 2;

		// Token: 0x040084D1 RID: 34001
		private static readonly MapField<int, int>.Codec _map_currencyDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x040084D2 RID: 34002
		private readonly MapField<int, int> currencyDict_ = new MapField<int, int>();
	}
}
