using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E2 RID: 1250
	[NetMessage(EMessageId.ExchangeRewardInfoResponse)]
	public sealed class ExchangeRewardInfoResponse : IMessage<ExchangeRewardInfoResponse>, IMessage, IEquatable<ExchangeRewardInfoResponse>, IDeepCloneable<ExchangeRewardInfoResponse>, IBufferMessage
	{
		// Token: 0x06007676 RID: 30326 RVA: 0x00121982 File Offset: 0x0011FB82
		[NullableContext(1)]
		public static ExchangeRewardInfoResponse Create()
		{
			return new ExchangeRewardInfoResponse();
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x06007677 RID: 30327 RVA: 0x00121989 File Offset: 0x0011FB89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x06007678 RID: 30328 RVA: 0x0012198C File Offset: 0x0011FB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExchangeRewardInfoResponse.Descriptor;
			}
		}

		// Token: 0x06007679 RID: 30329 RVA: 0x00121993 File Offset: 0x0011FB93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRewardInfoResponse()
		{
		}

		// Token: 0x0600767A RID: 30330 RVA: 0x001219B1 File Offset: 0x0011FBB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRewardInfoResponse(ExchangeRewardInfoResponse other) : this()
		{
			this.sharedDict_ = other.sharedDict_.Clone();
			this.exchangeRewardDict_ = other.exchangeRewardDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600767B RID: 30331 RVA: 0x001219EC File Offset: 0x0011FBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRewardInfoResponse Clone()
		{
			return new ExchangeRewardInfoResponse(this);
		}

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x0600767C RID: 30332 RVA: 0x001219F4 File Offset: 0x0011FBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> SharedDict
		{
			get
			{
				return this.sharedDict_;
			}
		}

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x0600767D RID: 30333 RVA: 0x001219FC File Offset: 0x0011FBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ExchangeRewardDict
		{
			get
			{
				return this.exchangeRewardDict_;
			}
		}

		// Token: 0x0600767E RID: 30334 RVA: 0x00121A04 File Offset: 0x0011FC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExchangeRewardInfoResponse);
		}

		// Token: 0x0600767F RID: 30335 RVA: 0x00121A14 File Offset: 0x0011FC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExchangeRewardInfoResponse other)
		{
			return other != null && (other == this || (this.SharedDict.Equals(other.SharedDict) && this.ExchangeRewardDict.Equals(other.ExchangeRewardDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007680 RID: 30336 RVA: 0x00121A68 File Offset: 0x0011FC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.SharedDict.GetHashCode();
			num ^= this.ExchangeRewardDict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007681 RID: 30337 RVA: 0x00121AAA File Offset: 0x0011FCAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007682 RID: 30338 RVA: 0x00121AB7 File Offset: 0x0011FCB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007683 RID: 30339 RVA: 0x00121AC0 File Offset: 0x0011FCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.sharedDict_.WriteTo(ref output, ExchangeRewardInfoResponse._map_sharedDict_codec);
			this.exchangeRewardDict_.WriteTo(ref output, ExchangeRewardInfoResponse._map_exchangeRewardDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007684 RID: 30340 RVA: 0x00121AF8 File Offset: 0x0011FCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.sharedDict_.CalculateSize(ExchangeRewardInfoResponse._map_sharedDict_codec);
			num += this.exchangeRewardDict_.CalculateSize(ExchangeRewardInfoResponse._map_exchangeRewardDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007685 RID: 30341 RVA: 0x00121B44 File Offset: 0x0011FD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExchangeRewardInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.sharedDict_.MergeFrom(other.sharedDict_);
			this.exchangeRewardDict_.MergeFrom(other.exchangeRewardDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007686 RID: 30342 RVA: 0x00121B83 File Offset: 0x0011FD83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007687 RID: 30343 RVA: 0x00121B8C File Offset: 0x0011FD8C
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
				if (num != 58U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.exchangeRewardDict_.AddEntriesFrom(ref input, ExchangeRewardInfoResponse._map_exchangeRewardDict_codec);
					}
				}
				else
				{
					this.sharedDict_.AddEntriesFrom(ref input, ExchangeRewardInfoResponse._map_sharedDict_codec);
				}
			}
		}

		// Token: 0x04003DF5 RID: 15861
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DF6 RID: 15862
		public const int SharedDictFieldNumber = 7;

		// Token: 0x04003DF7 RID: 15863
		private static readonly MapField<int, int>.Codec _map_sharedDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 58U);

		// Token: 0x04003DF8 RID: 15864
		private readonly MapField<int, int> sharedDict_ = new MapField<int, int>();

		// Token: 0x04003DF9 RID: 15865
		public const int ExchangeRewardDictFieldNumber = 9;

		// Token: 0x04003DFA RID: 15866
		private static readonly MapField<int, int>.Codec _map_exchangeRewardDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x04003DFB RID: 15867
		private readonly MapField<int, int> exchangeRewardDict_ = new MapField<int, int>();
	}
}
