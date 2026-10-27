using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007CB RID: 1995
	[NetMessage(EMessageId.IllustratedRedDotResponse)]
	public sealed class IllustratedRedDotResponse : IMessage<IllustratedRedDotResponse>, IMessage, IEquatable<IllustratedRedDotResponse>, IDeepCloneable<IllustratedRedDotResponse>, IBufferMessage
	{
		// Token: 0x0600B36A RID: 45930 RVA: 0x001AD65A File Offset: 0x001AB85A
		[NullableContext(1)]
		public static IllustratedRedDotResponse Create()
		{
			return new IllustratedRedDotResponse();
		}

		// Token: 0x17002435 RID: 9269
		// (get) Token: 0x0600B36B RID: 45931 RVA: 0x001AD661 File Offset: 0x001AB861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002436 RID: 9270
		// (get) Token: 0x0600B36C RID: 45932 RVA: 0x001AD664 File Offset: 0x001AB864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedRedDotResponse.Descriptor;
			}
		}

		// Token: 0x0600B36D RID: 45933 RVA: 0x001AD66B File Offset: 0x001AB86B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedRedDotResponse()
		{
		}

		// Token: 0x0600B36E RID: 45934 RVA: 0x001AD67E File Offset: 0x001AB87E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedRedDotResponse(IllustratedRedDotResponse other) : this()
		{
			this.redDotList_ = other.redDotList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B36F RID: 45935 RVA: 0x001AD6A8 File Offset: 0x001AB8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedRedDotResponse Clone()
		{
			return new IllustratedRedDotResponse(this);
		}

		// Token: 0x17002437 RID: 9271
		// (get) Token: 0x0600B370 RID: 45936 RVA: 0x001AD6B0 File Offset: 0x001AB8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<IllustratedType> RedDotList
		{
			get
			{
				return this.redDotList_;
			}
		}

		// Token: 0x0600B371 RID: 45937 RVA: 0x001AD6B8 File Offset: 0x001AB8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedRedDotResponse);
		}

		// Token: 0x0600B372 RID: 45938 RVA: 0x001AD6C6 File Offset: 0x001AB8C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedRedDotResponse other)
		{
			return other != null && (other == this || (this.redDotList_.Equals(other.redDotList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B373 RID: 45939 RVA: 0x001AD6FC File Offset: 0x001AB8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.redDotList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B374 RID: 45940 RVA: 0x001AD730 File Offset: 0x001AB930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B375 RID: 45941 RVA: 0x001AD73D File Offset: 0x001AB93D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B376 RID: 45942 RVA: 0x001AD746 File Offset: 0x001AB946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.redDotList_.WriteTo(ref output, IllustratedRedDotResponse._repeated_redDotList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B377 RID: 45943 RVA: 0x001AD770 File Offset: 0x001AB970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.redDotList_.CalculateSize(IllustratedRedDotResponse._repeated_redDotList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B378 RID: 45944 RVA: 0x001AD7A9 File Offset: 0x001AB9A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IllustratedRedDotResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.redDotList_.Add(other.redDotList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B379 RID: 45945 RVA: 0x001AD7D7 File Offset: 0x001AB9D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B37A RID: 45946 RVA: 0x001AD7E0 File Offset: 0x001AB9E0
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.redDotList_.AddEntriesFrom(ref input, IllustratedRedDotResponse._repeated_redDotList_codec);
				}
			}
		}

		// Token: 0x0400500C RID: 20492
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400500D RID: 20493
		public const int RedDotListFieldNumber = 12;

		// Token: 0x0400500E RID: 20494
		private static readonly FieldCodec<IllustratedType> _repeated_redDotList_codec = FieldCodec.ForEnum<IllustratedType>(98U, (IllustratedType x) => (int)x, (int x) => (IllustratedType)x);

		// Token: 0x0400500F RID: 20495
		private readonly RepeatedField<IllustratedType> redDotList_ = new RepeatedField<IllustratedType>();
	}
}
