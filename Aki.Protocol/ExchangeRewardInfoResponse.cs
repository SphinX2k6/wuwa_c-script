using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004CC RID: 1228
	[NetMessage(EMessageId.ExchangeRewardInfoResponse)]
	public sealed class ExchangeRewardInfoResponse : IMessage<ExchangeRewardInfoResponse>, IMessage, IEquatable<ExchangeRewardInfoResponse>, IDeepCloneable<ExchangeRewardInfoResponse>, IBufferMessage
	{
		// Token: 0x060074FA RID: 29946 RVA: 0x0011EAFE File Offset: 0x0011CCFE
		[NullableContext(1)]
		public static ExchangeRewardInfoResponse Create()
		{
			return new ExchangeRewardInfoResponse();
		}

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x060074FB RID: 29947 RVA: 0x0011EB05 File Offset: 0x0011CD05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x060074FC RID: 29948 RVA: 0x0011EB08 File Offset: 0x0011CD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExchangeRewardInfoResponse.Descriptor;
			}
		}

		// Token: 0x060074FD RID: 29949 RVA: 0x0011EB0F File Offset: 0x0011CD0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRewardInfoResponse()
		{
		}

		// Token: 0x060074FE RID: 29950 RVA: 0x0011EB2D File Offset: 0x0011CD2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRewardInfoResponse(ExchangeRewardInfoResponse other) : this()
		{
			this.sharedDict_ = other.sharedDict_.Clone();
			this.exchangeRewardDict_ = other.exchangeRewardDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060074FF RID: 29951 RVA: 0x0011EB68 File Offset: 0x0011CD68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRewardInfoResponse Clone()
		{
			return new ExchangeRewardInfoResponse(this);
		}

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06007500 RID: 29952 RVA: 0x0011EB70 File Offset: 0x0011CD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> SharedDict
		{
			get
			{
				return this.sharedDict_;
			}
		}

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x06007501 RID: 29953 RVA: 0x0011EB78 File Offset: 0x0011CD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ExchangeRewardDict
		{
			get
			{
				return this.exchangeRewardDict_;
			}
		}

		// Token: 0x06007502 RID: 29954 RVA: 0x0011EB80 File Offset: 0x0011CD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExchangeRewardInfoResponse);
		}

		// Token: 0x06007503 RID: 29955 RVA: 0x0011EB90 File Offset: 0x0011CD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExchangeRewardInfoResponse other)
		{
			return other != null && (other == this || (this.SharedDict.Equals(other.SharedDict) && this.ExchangeRewardDict.Equals(other.ExchangeRewardDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007504 RID: 29956 RVA: 0x0011EBE4 File Offset: 0x0011CDE4
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

		// Token: 0x06007505 RID: 29957 RVA: 0x0011EC26 File Offset: 0x0011CE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007506 RID: 29958 RVA: 0x0011EC33 File Offset: 0x0011CE33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007507 RID: 29959 RVA: 0x0011EC3C File Offset: 0x0011CE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.exchangeRewardDict_.WriteTo(ref output, ExchangeRewardInfoResponse._map_exchangeRewardDict_codec);
			this.sharedDict_.WriteTo(ref output, ExchangeRewardInfoResponse._map_sharedDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007508 RID: 29960 RVA: 0x0011EC74 File Offset: 0x0011CE74
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

		// Token: 0x06007509 RID: 29961 RVA: 0x0011ECC0 File Offset: 0x0011CEC0
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

		// Token: 0x0600750A RID: 29962 RVA: 0x0011ECFF File Offset: 0x0011CEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600750B RID: 29963 RVA: 0x0011ED08 File Offset: 0x0011CF08
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
				if (num != 98U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.sharedDict_.AddEntriesFrom(ref input, ExchangeRewardInfoResponse._map_sharedDict_codec);
					}
				}
				else
				{
					this.exchangeRewardDict_.AddEntriesFrom(ref input, ExchangeRewardInfoResponse._map_exchangeRewardDict_codec);
				}
			}
		}

		// Token: 0x04003DE6 RID: 15846
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DE7 RID: 15847
		public const int SharedDictFieldNumber = 13;

		// Token: 0x04003DE8 RID: 15848
		private static readonly MapField<int, int>.Codec _map_sharedDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 106U);

		// Token: 0x04003DE9 RID: 15849
		private readonly MapField<int, int> sharedDict_ = new MapField<int, int>();

		// Token: 0x04003DEA RID: 15850
		public const int ExchangeRewardDictFieldNumber = 12;

		// Token: 0x04003DEB RID: 15851
		private static readonly MapField<int, int>.Codec _map_exchangeRewardDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 98U);

		// Token: 0x04003DEC RID: 15852
		private readonly MapField<int, int> exchangeRewardDict_ = new MapField<int, int>();
	}
}
