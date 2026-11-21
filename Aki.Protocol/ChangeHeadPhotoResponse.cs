using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000256 RID: 598
	[NetMessage(EMessageId.ChangeHeadPhotoResponse)]
	public sealed class ChangeHeadPhotoResponse : IMessage<ChangeHeadPhotoResponse>, IMessage, IEquatable<ChangeHeadPhotoResponse>, IDeepCloneable<ChangeHeadPhotoResponse>, IBufferMessage
	{
		// Token: 0x06003FD6 RID: 16342 RVA: 0x0009D551 File Offset: 0x0009B751
		[NullableContext(1)]
		public static ChangeHeadPhotoResponse Create()
		{
			return new ChangeHeadPhotoResponse();
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06003FD7 RID: 16343 RVA: 0x0009D558 File Offset: 0x0009B758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06003FD8 RID: 16344 RVA: 0x0009D55B File Offset: 0x0009B75B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeHeadPhotoResponse.Descriptor;
			}
		}

		// Token: 0x06003FD9 RID: 16345 RVA: 0x0009D562 File Offset: 0x0009B762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeHeadPhotoResponse()
		{
		}

		// Token: 0x06003FDA RID: 16346 RVA: 0x0009D56A File Offset: 0x0009B76A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeHeadPhotoResponse(ChangeHeadPhotoResponse other) : this()
		{
			this.headPhotoId_ = other.headPhotoId_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003FDB RID: 16347 RVA: 0x0009D59B File Offset: 0x0009B79B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeHeadPhotoResponse Clone()
		{
			return new ChangeHeadPhotoResponse(this);
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06003FDC RID: 16348 RVA: 0x0009D5A3 File Offset: 0x0009B7A3
		// (set) Token: 0x06003FDD RID: 16349 RVA: 0x0009D5AB File Offset: 0x0009B7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeadPhotoId
		{
			get
			{
				return this.headPhotoId_;
			}
			set
			{
				this.headPhotoId_ = value;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06003FDE RID: 16350 RVA: 0x0009D5B4 File Offset: 0x0009B7B4
		// (set) Token: 0x06003FDF RID: 16351 RVA: 0x0009D5BC File Offset: 0x0009B7BC
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

		// Token: 0x06003FE0 RID: 16352 RVA: 0x0009D5C5 File Offset: 0x0009B7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeHeadPhotoResponse);
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x0009D5D3 File Offset: 0x0009B7D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeHeadPhotoResponse other)
		{
			return other != null && (other == this || (this.HeadPhotoId == other.HeadPhotoId && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x0009D614 File Offset: 0x0009B814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HeadPhotoId != 0)
			{
				num ^= this.HeadPhotoId.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x0009D672 File Offset: 0x0009B872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x0009D67F File Offset: 0x0009B87F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x0009D688 File Offset: 0x0009B888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HeadPhotoId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.HeadPhotoId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003FE6 RID: 16358 RVA: 0x0009D6E4 File Offset: 0x0009B8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HeadPhotoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadPhotoId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x0009D73C File Offset: 0x0009B93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeHeadPhotoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HeadPhotoId != 0)
			{
				this.HeadPhotoId = other.HeadPhotoId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x0009D78C File Offset: 0x0009B98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x0009D798 File Offset: 0x0009B998
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
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.HeadPhotoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D91 RID: 11665
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D92 RID: 11666
		public const int HeadPhotoIdFieldNumber = 8;

		// Token: 0x04002D93 RID: 11667
		private int headPhotoId_;

		// Token: 0x04002D94 RID: 11668
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04002D95 RID: 11669
		private ErrorCode errorCode_;
	}
}
