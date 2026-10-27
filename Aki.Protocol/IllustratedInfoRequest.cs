using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C6 RID: 1990
	[NetMessage(EMessageId.IllustratedInfoRequest)]
	public sealed class IllustratedInfoRequest : IMessage<IllustratedInfoRequest>, IMessage, IEquatable<IllustratedInfoRequest>, IDeepCloneable<IllustratedInfoRequest>, IBufferMessage
	{
		// Token: 0x0600B30B RID: 45835 RVA: 0x001ACA80 File Offset: 0x001AAC80
		[NullableContext(1)]
		public static IllustratedInfoRequest Create()
		{
			return new IllustratedInfoRequest();
		}

		// Token: 0x17002423 RID: 9251
		// (get) Token: 0x0600B30C RID: 45836 RVA: 0x001ACA87 File Offset: 0x001AAC87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002424 RID: 9252
		// (get) Token: 0x0600B30D RID: 45837 RVA: 0x001ACA8A File Offset: 0x001AAC8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600B30E RID: 45838 RVA: 0x001ACA91 File Offset: 0x001AAC91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedInfoRequest()
		{
		}

		// Token: 0x0600B30F RID: 45839 RVA: 0x001ACAA4 File Offset: 0x001AACA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedInfoRequest(IllustratedInfoRequest other) : this()
		{
			this.typeList_ = other.typeList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B310 RID: 45840 RVA: 0x001ACACE File Offset: 0x001AACCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedInfoRequest Clone()
		{
			return new IllustratedInfoRequest(this);
		}

		// Token: 0x17002425 RID: 9253
		// (get) Token: 0x0600B311 RID: 45841 RVA: 0x001ACAD6 File Offset: 0x001AACD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<IllustratedType> TypeList
		{
			get
			{
				return this.typeList_;
			}
		}

		// Token: 0x0600B312 RID: 45842 RVA: 0x001ACADE File Offset: 0x001AACDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedInfoRequest);
		}

		// Token: 0x0600B313 RID: 45843 RVA: 0x001ACAEC File Offset: 0x001AACEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedInfoRequest other)
		{
			return other != null && (other == this || (this.typeList_.Equals(other.typeList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B314 RID: 45844 RVA: 0x001ACB20 File Offset: 0x001AAD20
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

		// Token: 0x0600B315 RID: 45845 RVA: 0x001ACB54 File Offset: 0x001AAD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B316 RID: 45846 RVA: 0x001ACB61 File Offset: 0x001AAD61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B317 RID: 45847 RVA: 0x001ACB6A File Offset: 0x001AAD6A
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

		// Token: 0x0600B318 RID: 45848 RVA: 0x001ACB94 File Offset: 0x001AAD94
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

		// Token: 0x0600B319 RID: 45849 RVA: 0x001ACBCD File Offset: 0x001AADCD
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

		// Token: 0x0600B31A RID: 45850 RVA: 0x001ACBFB File Offset: 0x001AADFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B31B RID: 45851 RVA: 0x001ACC04 File Offset: 0x001AAE04
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.typeList_.AddEntriesFrom(ref input, IllustratedInfoRequest._repeated_typeList_codec);
				}
			}
		}

		// Token: 0x04004FF3 RID: 20467
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FF4 RID: 20468
		public const int TypeListFieldNumber = 8;

		// Token: 0x04004FF5 RID: 20469
		private static readonly FieldCodec<IllustratedType> _repeated_typeList_codec = FieldCodec.ForEnum<IllustratedType>(66U, (IllustratedType x) => (int)x, (int x) => (IllustratedType)x);

		// Token: 0x04004FF6 RID: 20470
		private readonly RepeatedField<IllustratedType> typeList_ = new RepeatedField<IllustratedType>();
	}
}
