using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C2 RID: 450
	[NetMessage(EMessageId.BossPilingBuffUpdateNotify)]
	public sealed class BossPilingBuffUpdateNotify : IMessage<BossPilingBuffUpdateNotify>, IMessage, IEquatable<BossPilingBuffUpdateNotify>, IDeepCloneable<BossPilingBuffUpdateNotify>, IBufferMessage
	{
		// Token: 0x060033C3 RID: 13251 RVA: 0x00082DA2 File Offset: 0x00080FA2
		[NullableContext(1)]
		public static BossPilingBuffUpdateNotify Create()
		{
			return new BossPilingBuffUpdateNotify();
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060033C4 RID: 13252 RVA: 0x00082DA9 File Offset: 0x00080FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060033C5 RID: 13253 RVA: 0x00082DAC File Offset: 0x00080FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingBuffUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x00082DB3 File Offset: 0x00080FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingBuffUpdateNotify()
		{
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x00082DC6 File Offset: 0x00080FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingBuffUpdateNotify(BossPilingBuffUpdateNotify other) : this()
		{
			this.bossPilingBuffs_ = other.bossPilingBuffs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x00082DF0 File Offset: 0x00080FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingBuffUpdateNotify Clone()
		{
			return new BossPilingBuffUpdateNotify(this);
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060033C9 RID: 13257 RVA: 0x00082DF8 File Offset: 0x00080FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BossPilingBuffs
		{
			get
			{
				return this.bossPilingBuffs_;
			}
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x00082E00 File Offset: 0x00081000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingBuffUpdateNotify);
		}

		// Token: 0x060033CB RID: 13259 RVA: 0x00082E0E File Offset: 0x0008100E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingBuffUpdateNotify other)
		{
			return other != null && (other == this || (this.BossPilingBuffs.Equals(other.BossPilingBuffs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x00082E44 File Offset: 0x00081044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.BossPilingBuffs.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060033CD RID: 13261 RVA: 0x00082E78 File Offset: 0x00081078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x00082E85 File Offset: 0x00081085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x00082E8E File Offset: 0x0008108E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bossPilingBuffs_.WriteTo(ref output, BossPilingBuffUpdateNotify._map_bossPilingBuffs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x00082EB8 File Offset: 0x000810B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bossPilingBuffs_.CalculateSize(BossPilingBuffUpdateNotify._map_bossPilingBuffs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x00082EF1 File Offset: 0x000810F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingBuffUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.bossPilingBuffs_.MergeFrom(other.bossPilingBuffs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x00082F1F File Offset: 0x0008111F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x00082F28 File Offset: 0x00081128
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.bossPilingBuffs_.AddEntriesFrom(ref input, BossPilingBuffUpdateNotify._map_bossPilingBuffs_codec);
				}
			}
		}

		// Token: 0x040029D3 RID: 10707
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029D4 RID: 10708
		public const int BossPilingBuffsFieldNumber = 4;

		// Token: 0x040029D5 RID: 10709
		private static readonly MapField<int, int>.Codec _map_bossPilingBuffs_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x040029D6 RID: 10710
		private readonly MapField<int, int> bossPilingBuffs_ = new MapField<int, int>();
	}
}
