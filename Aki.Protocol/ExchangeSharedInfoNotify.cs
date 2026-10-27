using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E3 RID: 1251
	[NetMessage(EMessageId.ExchangeSharedInfoNotify)]
	public sealed class ExchangeSharedInfoNotify : IMessage<ExchangeSharedInfoNotify>, IMessage, IEquatable<ExchangeSharedInfoNotify>, IDeepCloneable<ExchangeSharedInfoNotify>, IBufferMessage
	{
		// Token: 0x06007689 RID: 30345 RVA: 0x00121C26 File Offset: 0x0011FE26
		[NullableContext(1)]
		public static ExchangeSharedInfoNotify Create()
		{
			return new ExchangeSharedInfoNotify();
		}

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x0600768A RID: 30346 RVA: 0x00121C2D File Offset: 0x0011FE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x0600768B RID: 30347 RVA: 0x00121C30 File Offset: 0x0011FE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExchangeSharedInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600768C RID: 30348 RVA: 0x00121C37 File Offset: 0x0011FE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeSharedInfoNotify()
		{
		}

		// Token: 0x0600768D RID: 30349 RVA: 0x00121C4A File Offset: 0x0011FE4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeSharedInfoNotify(ExchangeSharedInfoNotify other) : this()
		{
			this.sharedUpdateDict_ = other.sharedUpdateDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600768E RID: 30350 RVA: 0x00121C74 File Offset: 0x0011FE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeSharedInfoNotify Clone()
		{
			return new ExchangeSharedInfoNotify(this);
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x0600768F RID: 30351 RVA: 0x00121C7C File Offset: 0x0011FE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> SharedUpdateDict
		{
			get
			{
				return this.sharedUpdateDict_;
			}
		}

		// Token: 0x06007690 RID: 30352 RVA: 0x00121C84 File Offset: 0x0011FE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExchangeSharedInfoNotify);
		}

		// Token: 0x06007691 RID: 30353 RVA: 0x00121C92 File Offset: 0x0011FE92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExchangeSharedInfoNotify other)
		{
			return other != null && (other == this || (this.SharedUpdateDict.Equals(other.SharedUpdateDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007692 RID: 30354 RVA: 0x00121CC8 File Offset: 0x0011FEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.SharedUpdateDict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007693 RID: 30355 RVA: 0x00121CFC File Offset: 0x0011FEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007694 RID: 30356 RVA: 0x00121D09 File Offset: 0x0011FF09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007695 RID: 30357 RVA: 0x00121D12 File Offset: 0x0011FF12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.sharedUpdateDict_.WriteTo(ref output, ExchangeSharedInfoNotify._map_sharedUpdateDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007696 RID: 30358 RVA: 0x00121D3C File Offset: 0x0011FF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.sharedUpdateDict_.CalculateSize(ExchangeSharedInfoNotify._map_sharedUpdateDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007697 RID: 30359 RVA: 0x00121D75 File Offset: 0x0011FF75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExchangeSharedInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.sharedUpdateDict_.MergeFrom(other.sharedUpdateDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007698 RID: 30360 RVA: 0x00121DA3 File Offset: 0x0011FFA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007699 RID: 30361 RVA: 0x00121DAC File Offset: 0x0011FFAC
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.sharedUpdateDict_.AddEntriesFrom(ref input, ExchangeSharedInfoNotify._map_sharedUpdateDict_codec);
				}
			}
		}

		// Token: 0x04003DFC RID: 15868
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DFD RID: 15869
		public const int SharedUpdateDictFieldNumber = 10;

		// Token: 0x04003DFE RID: 15870
		private static readonly MapField<int, int>.Codec _map_sharedUpdateDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 82U);

		// Token: 0x04003DFF RID: 15871
		private readonly MapField<int, int> sharedUpdateDict_ = new MapField<int, int>();
	}
}
