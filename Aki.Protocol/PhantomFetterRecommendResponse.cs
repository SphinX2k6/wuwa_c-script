using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD3 RID: 3283
	[NetMessage(EMessageId.PhantomFetterRecommendResponse)]
	public sealed class PhantomFetterRecommendResponse : IMessage<PhantomFetterRecommendResponse>, IMessage, IEquatable<PhantomFetterRecommendResponse>, IDeepCloneable<PhantomFetterRecommendResponse>, IBufferMessage
	{
		// Token: 0x06011C4D RID: 72781 RVA: 0x00299921 File Offset: 0x00297B21
		[NullableContext(1)]
		public static PhantomFetterRecommendResponse Create()
		{
			return new PhantomFetterRecommendResponse();
		}

		// Token: 0x17003ADF RID: 15071
		// (get) Token: 0x06011C4E RID: 72782 RVA: 0x00299928 File Offset: 0x00297B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AE0 RID: 15072
		// (get) Token: 0x06011C4F RID: 72783 RVA: 0x0029992B File Offset: 0x00297B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomFetterRecommendResponse.Descriptor;
			}
		}

		// Token: 0x06011C50 RID: 72784 RVA: 0x00299932 File Offset: 0x00297B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterRecommendResponse()
		{
		}

		// Token: 0x06011C51 RID: 72785 RVA: 0x00299945 File Offset: 0x00297B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterRecommendResponse(PhantomFetterRecommendResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomFetterRecommendInfos_ = other.phantomFetterRecommendInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011C52 RID: 72786 RVA: 0x0029997B File Offset: 0x00297B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterRecommendResponse Clone()
		{
			return new PhantomFetterRecommendResponse(this);
		}

		// Token: 0x17003AE1 RID: 15073
		// (get) Token: 0x06011C53 RID: 72787 RVA: 0x00299983 File Offset: 0x00297B83
		// (set) Token: 0x06011C54 RID: 72788 RVA: 0x0029998B File Offset: 0x00297B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17003AE2 RID: 15074
		// (get) Token: 0x06011C55 RID: 72789 RVA: 0x00299994 File Offset: 0x00297B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomFetterRecommendInfo> PhantomFetterRecommendInfos
		{
			get
			{
				return this.phantomFetterRecommendInfos_;
			}
		}

		// Token: 0x06011C56 RID: 72790 RVA: 0x0029999C File Offset: 0x00297B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomFetterRecommendResponse);
		}

		// Token: 0x06011C57 RID: 72791 RVA: 0x002999AC File Offset: 0x00297BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomFetterRecommendResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomFetterRecommendInfos_.Equals(other.phantomFetterRecommendInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011C58 RID: 72792 RVA: 0x002999FC File Offset: 0x00297BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.phantomFetterRecommendInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011C59 RID: 72793 RVA: 0x00299A4F File Offset: 0x00297C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011C5A RID: 72794 RVA: 0x00299A5C File Offset: 0x00297C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011C5B RID: 72795 RVA: 0x00299A68 File Offset: 0x00297C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.phantomFetterRecommendInfos_.WriteTo(ref output, PhantomFetterRecommendResponse._repeated_phantomFetterRecommendInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011C5C RID: 72796 RVA: 0x00299AB8 File Offset: 0x00297CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.phantomFetterRecommendInfos_.CalculateSize(PhantomFetterRecommendResponse._repeated_phantomFetterRecommendInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011C5D RID: 72797 RVA: 0x00299B0C File Offset: 0x00297D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomFetterRecommendResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.phantomFetterRecommendInfos_.Add(other.phantomFetterRecommendInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011C5E RID: 72798 RVA: 0x00299B59 File Offset: 0x00297D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011C5F RID: 72799 RVA: 0x00299B64 File Offset: 0x00297D64
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
				if (num != 8U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.phantomFetterRecommendInfos_.AddEntriesFrom(ref input, PhantomFetterRecommendResponse._repeated_phantomFetterRecommendInfos_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006FA2 RID: 28578
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FA3 RID: 28579
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04006FA4 RID: 28580
		private ErrorCode errorCode_;

		// Token: 0x04006FA5 RID: 28581
		public const int PhantomFetterRecommendInfosFieldNumber = 15;

		// Token: 0x04006FA6 RID: 28582
		private static readonly FieldCodec<PhantomFetterRecommendInfo> _repeated_phantomFetterRecommendInfos_codec = FieldCodec.ForMessage<PhantomFetterRecommendInfo>(122U, PhantomFetterRecommendInfo.Parser);

		// Token: 0x04006FA7 RID: 28583
		private readonly RepeatedField<PhantomFetterRecommendInfo> phantomFetterRecommendInfos_ = new RepeatedField<PhantomFetterRecommendInfo>();
	}
}
