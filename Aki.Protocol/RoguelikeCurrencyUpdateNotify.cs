using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F89 RID: 3977
	[NetMessage(EMessageId.RoguelikeCurrencyUpdateNotify)]
	public sealed class RoguelikeCurrencyUpdateNotify : IMessage<RoguelikeCurrencyUpdateNotify>, IMessage, IEquatable<RoguelikeCurrencyUpdateNotify>, IDeepCloneable<RoguelikeCurrencyUpdateNotify>, IBufferMessage
	{
		// Token: 0x060154CB RID: 87243 RVA: 0x00317FC7 File Offset: 0x003161C7
		[NullableContext(1)]
		public static RoguelikeCurrencyUpdateNotify Create()
		{
			return new RoguelikeCurrencyUpdateNotify();
		}

		// Token: 0x17004702 RID: 18178
		// (get) Token: 0x060154CC RID: 87244 RVA: 0x00317FCE File Offset: 0x003161CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004703 RID: 18179
		// (get) Token: 0x060154CD RID: 87245 RVA: 0x00317FD1 File Offset: 0x003161D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeCurrencyUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060154CE RID: 87246 RVA: 0x00317FD8 File Offset: 0x003161D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeCurrencyUpdateNotify()
		{
		}

		// Token: 0x060154CF RID: 87247 RVA: 0x00317FEB File Offset: 0x003161EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeCurrencyUpdateNotify(RoguelikeCurrencyUpdateNotify other) : this()
		{
			this.currencyUpdateDict_ = other.currencyUpdateDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060154D0 RID: 87248 RVA: 0x00318015 File Offset: 0x00316215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeCurrencyUpdateNotify Clone()
		{
			return new RoguelikeCurrencyUpdateNotify(this);
		}

		// Token: 0x17004704 RID: 18180
		// (get) Token: 0x060154D1 RID: 87249 RVA: 0x0031801D File Offset: 0x0031621D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> CurrencyUpdateDict
		{
			get
			{
				return this.currencyUpdateDict_;
			}
		}

		// Token: 0x060154D2 RID: 87250 RVA: 0x00318025 File Offset: 0x00316225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeCurrencyUpdateNotify);
		}

		// Token: 0x060154D3 RID: 87251 RVA: 0x00318033 File Offset: 0x00316233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeCurrencyUpdateNotify other)
		{
			return other != null && (other == this || (this.CurrencyUpdateDict.Equals(other.CurrencyUpdateDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060154D4 RID: 87252 RVA: 0x00318068 File Offset: 0x00316268
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

		// Token: 0x060154D5 RID: 87253 RVA: 0x0031809C File Offset: 0x0031629C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060154D6 RID: 87254 RVA: 0x003180A9 File Offset: 0x003162A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060154D7 RID: 87255 RVA: 0x003180B2 File Offset: 0x003162B2
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

		// Token: 0x060154D8 RID: 87256 RVA: 0x003180DC File Offset: 0x003162DC
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

		// Token: 0x060154D9 RID: 87257 RVA: 0x00318115 File Offset: 0x00316315
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

		// Token: 0x060154DA RID: 87258 RVA: 0x00318143 File Offset: 0x00316343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060154DB RID: 87259 RVA: 0x0031814C File Offset: 0x0031634C
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

		// Token: 0x040080A8 RID: 32936
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080A9 RID: 32937
		public const int CurrencyUpdateDictFieldNumber = 11;

		// Token: 0x040080AA RID: 32938
		private static readonly MapField<int, int>.Codec _map_currencyUpdateDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 90U);

		// Token: 0x040080AB RID: 32939
		private readonly MapField<int, int> currencyUpdateDict_ = new MapField<int, int>();
	}
}
