using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x0200172D RID: 5933
	[NetMessage(EMessageId.AiHateRequest)]
	public sealed class AiHateRequest : IMessage<AiHateRequest>, IMessage, IEquatable<AiHateRequest>, IDeepCloneable<AiHateRequest>, IBufferMessage
	{
		// Token: 0x0601DC7C RID: 121980 RVA: 0x0045DF79 File Offset: 0x0045C179
		[NullableContext(1)]
		public static AiHateRequest Create()
		{
			return new AiHateRequest();
		}

		// Token: 0x17006562 RID: 25954
		// (get) Token: 0x0601DC7D RID: 121981 RVA: 0x0045DF80 File Offset: 0x0045C180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006563 RID: 25955
		// (get) Token: 0x0601DC7E RID: 121982 RVA: 0x0045DF83 File Offset: 0x0045C183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiHateRequest.Descriptor;
			}
		}

		// Token: 0x0601DC7F RID: 121983 RVA: 0x0045DF8A File Offset: 0x0045C18A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateRequest()
		{
		}

		// Token: 0x0601DC80 RID: 121984 RVA: 0x0045DF9D File Offset: 0x0045C19D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateRequest(AiHateRequest other) : this()
		{
			this.hateList_ = other.hateList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DC81 RID: 121985 RVA: 0x0045DFC7 File Offset: 0x0045C1C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateRequest Clone()
		{
			return new AiHateRequest(this);
		}

		// Token: 0x17006564 RID: 25956
		// (get) Token: 0x0601DC82 RID: 121986 RVA: 0x0045DFCF File Offset: 0x0045C1CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AiHateEntity> HateList
		{
			get
			{
				return this.hateList_;
			}
		}

		// Token: 0x0601DC83 RID: 121987 RVA: 0x0045DFD7 File Offset: 0x0045C1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiHateRequest);
		}

		// Token: 0x0601DC84 RID: 121988 RVA: 0x0045DFE5 File Offset: 0x0045C1E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiHateRequest other)
		{
			return other != null && (other == this || (this.hateList_.Equals(other.hateList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DC85 RID: 121989 RVA: 0x0045E018 File Offset: 0x0045C218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hateList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DC86 RID: 121990 RVA: 0x0045E04C File Offset: 0x0045C24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DC87 RID: 121991 RVA: 0x0045E059 File Offset: 0x0045C259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DC88 RID: 121992 RVA: 0x0045E062 File Offset: 0x0045C262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hateList_.WriteTo(ref output, AiHateRequest._repeated_hateList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DC89 RID: 121993 RVA: 0x0045E08C File Offset: 0x0045C28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hateList_.CalculateSize(AiHateRequest._repeated_hateList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DC8A RID: 121994 RVA: 0x0045E0C5 File Offset: 0x0045C2C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiHateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.hateList_.Add(other.hateList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DC8B RID: 121995 RVA: 0x0045E0F3 File Offset: 0x0045C2F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DC8C RID: 121996 RVA: 0x0045E0FC File Offset: 0x0045C2FC
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.hateList_.AddEntriesFrom(ref input, AiHateRequest._repeated_hateList_codec);
				}
			}
		}

		// Token: 0x0400C977 RID: 51575
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C978 RID: 51576
		public const int HateListFieldNumber = 15;

		// Token: 0x0400C979 RID: 51577
		private static readonly FieldCodec<AiHateEntity> _repeated_hateList_codec = FieldCodec.ForMessage<AiHateEntity>(122U, AiHateEntity.Parser);

		// Token: 0x0400C97A RID: 51578
		private readonly RepeatedField<AiHateEntity> hateList_ = new RepeatedField<AiHateEntity>();
	}
}
