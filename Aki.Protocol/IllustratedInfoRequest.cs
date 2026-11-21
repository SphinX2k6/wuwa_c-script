using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B2 RID: 1970
	[NetMessage(EMessageId.IllustratedInfoRequest)]
	public sealed class IllustratedInfoRequest : IMessage<IllustratedInfoRequest>, IMessage, IEquatable<IllustratedInfoRequest>, IDeepCloneable<IllustratedInfoRequest>, IBufferMessage
	{
		// Token: 0x0600B1B5 RID: 45493 RVA: 0x001AA050 File Offset: 0x001A8250
		[NullableContext(1)]
		public static IllustratedInfoRequest Create()
		{
			return new IllustratedInfoRequest();
		}

		// Token: 0x170023D9 RID: 9177
		// (get) Token: 0x0600B1B6 RID: 45494 RVA: 0x001AA057 File Offset: 0x001A8257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023DA RID: 9178
		// (get) Token: 0x0600B1B7 RID: 45495 RVA: 0x001AA05A File Offset: 0x001A825A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600B1B8 RID: 45496 RVA: 0x001AA061 File Offset: 0x001A8261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedInfoRequest()
		{
		}

		// Token: 0x0600B1B9 RID: 45497 RVA: 0x001AA074 File Offset: 0x001A8274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedInfoRequest(IllustratedInfoRequest other) : this()
		{
			this.typeList_ = other.typeList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B1BA RID: 45498 RVA: 0x001AA09E File Offset: 0x001A829E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedInfoRequest Clone()
		{
			return new IllustratedInfoRequest(this);
		}

		// Token: 0x170023DB RID: 9179
		// (get) Token: 0x0600B1BB RID: 45499 RVA: 0x001AA0A6 File Offset: 0x001A82A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<IllustratedType> TypeList
		{
			get
			{
				return this.typeList_;
			}
		}

		// Token: 0x0600B1BC RID: 45500 RVA: 0x001AA0AE File Offset: 0x001A82AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedInfoRequest);
		}

		// Token: 0x0600B1BD RID: 45501 RVA: 0x001AA0BC File Offset: 0x001A82BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedInfoRequest other)
		{
			return other != null && (other == this || (this.typeList_.Equals(other.typeList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B1BE RID: 45502 RVA: 0x001AA0F0 File Offset: 0x001A82F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.typeList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B1BF RID: 45503 RVA: 0x001AA124 File Offset: 0x001A8324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B1C0 RID: 45504 RVA: 0x001AA131 File Offset: 0x001A8331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B1C1 RID: 45505 RVA: 0x001AA13A File Offset: 0x001A833A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.typeList_.WriteTo(ref output, IllustratedInfoRequest._repeated_typeList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B1C2 RID: 45506 RVA: 0x001AA164 File Offset: 0x001A8364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.typeList_.CalculateSize(IllustratedInfoRequest._repeated_typeList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B1C3 RID: 45507 RVA: 0x001AA19D File Offset: 0x001A839D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IllustratedInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.typeList_.Add(other.typeList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B1C4 RID: 45508 RVA: 0x001AA1CB File Offset: 0x001A83CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B1C5 RID: 45509 RVA: 0x001AA1D4 File Offset: 0x001A83D4
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.typeList_.AddEntriesFrom(ref input, IllustratedInfoRequest._repeated_typeList_codec);
				}
			}
		}

		// Token: 0x04004FEC RID: 20460
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FED RID: 20461
		public const int TypeListFieldNumber = 9;

		// Token: 0x04004FEE RID: 20462
		private static readonly FieldCodec<IllustratedType> _repeated_typeList_codec = FieldCodec.ForEnum<IllustratedType>(74U, (IllustratedType x) => (int)x, (int x) => (IllustratedType)x);

		// Token: 0x04004FEF RID: 20463
		private readonly RepeatedField<IllustratedType> typeList_ = new RepeatedField<IllustratedType>();
	}
}
