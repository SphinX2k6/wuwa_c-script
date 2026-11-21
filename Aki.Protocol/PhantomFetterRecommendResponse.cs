using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC3 RID: 3267
	[NetMessage(EMessageId.PhantomFetterRecommendResponse)]
	public sealed class PhantomFetterRecommendResponse : IMessage<PhantomFetterRecommendResponse>, IMessage, IEquatable<PhantomFetterRecommendResponse>, IDeepCloneable<PhantomFetterRecommendResponse>, IBufferMessage
	{
		// Token: 0x06011B51 RID: 72529 RVA: 0x00297D05 File Offset: 0x00295F05
		[NullableContext(1)]
		public static PhantomFetterRecommendResponse Create()
		{
			return new PhantomFetterRecommendResponse();
		}

		// Token: 0x17003AAA RID: 15018
		// (get) Token: 0x06011B52 RID: 72530 RVA: 0x00297D0C File Offset: 0x00295F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AAB RID: 15019
		// (get) Token: 0x06011B53 RID: 72531 RVA: 0x00297D0F File Offset: 0x00295F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomFetterRecommendResponse.Descriptor;
			}
		}

		// Token: 0x06011B54 RID: 72532 RVA: 0x00297D16 File Offset: 0x00295F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterRecommendResponse()
		{
		}

		// Token: 0x06011B55 RID: 72533 RVA: 0x00297D29 File Offset: 0x00295F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterRecommendResponse(PhantomFetterRecommendResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomFetterRecommendInfos_ = other.phantomFetterRecommendInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011B56 RID: 72534 RVA: 0x00297D5F File Offset: 0x00295F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterRecommendResponse Clone()
		{
			return new PhantomFetterRecommendResponse(this);
		}

		// Token: 0x17003AAC RID: 15020
		// (get) Token: 0x06011B57 RID: 72535 RVA: 0x00297D67 File Offset: 0x00295F67
		// (set) Token: 0x06011B58 RID: 72536 RVA: 0x00297D6F File Offset: 0x00295F6F
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

		// Token: 0x17003AAD RID: 15021
		// (get) Token: 0x06011B59 RID: 72537 RVA: 0x00297D78 File Offset: 0x00295F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomFetterRecommendInfo> PhantomFetterRecommendInfos
		{
			get
			{
				return this.phantomFetterRecommendInfos_;
			}
		}

		// Token: 0x06011B5A RID: 72538 RVA: 0x00297D80 File Offset: 0x00295F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomFetterRecommendResponse);
		}

		// Token: 0x06011B5B RID: 72539 RVA: 0x00297D90 File Offset: 0x00295F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomFetterRecommendResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomFetterRecommendInfos_.Equals(other.phantomFetterRecommendInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011B5C RID: 72540 RVA: 0x00297DE0 File Offset: 0x00295FE0
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

		// Token: 0x06011B5D RID: 72541 RVA: 0x00297E33 File Offset: 0x00296033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011B5E RID: 72542 RVA: 0x00297E40 File Offset: 0x00296040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011B5F RID: 72543 RVA: 0x00297E4C File Offset: 0x0029604C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.phantomFetterRecommendInfos_.WriteTo(ref output, PhantomFetterRecommendResponse._repeated_phantomFetterRecommendInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011B60 RID: 72544 RVA: 0x00297E9C File Offset: 0x0029609C
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

		// Token: 0x06011B61 RID: 72545 RVA: 0x00297EF0 File Offset: 0x002960F0
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

		// Token: 0x06011B62 RID: 72546 RVA: 0x00297F3D File Offset: 0x0029613D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011B63 RID: 72547 RVA: 0x00297F48 File Offset: 0x00296148
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
				if (num != 64U)
				{
					if (num != 82U)
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

		// Token: 0x04006FBA RID: 28602
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FBB RID: 28603
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04006FBC RID: 28604
		private ErrorCode errorCode_;

		// Token: 0x04006FBD RID: 28605
		public const int PhantomFetterRecommendInfosFieldNumber = 10;

		// Token: 0x04006FBE RID: 28606
		private static readonly FieldCodec<PhantomFetterRecommendInfo> _repeated_phantomFetterRecommendInfos_codec = FieldCodec.ForMessage<PhantomFetterRecommendInfo>(82U, PhantomFetterRecommendInfo.Parser);

		// Token: 0x04006FBF RID: 28607
		private readonly RepeatedField<PhantomFetterRecommendInfo> phantomFetterRecommendInfos_ = new RepeatedField<PhantomFetterRecommendInfo>();
	}
}
