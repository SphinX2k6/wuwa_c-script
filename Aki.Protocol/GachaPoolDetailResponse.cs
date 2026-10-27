using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000697 RID: 1687
	[NetMessage(EMessageId.GachaPoolDetailResponse)]
	public sealed class GachaPoolDetailResponse : IMessage<GachaPoolDetailResponse>, IMessage, IEquatable<GachaPoolDetailResponse>, IDeepCloneable<GachaPoolDetailResponse>, IBufferMessage
	{
		// Token: 0x06009A75 RID: 39541 RVA: 0x001748ED File Offset: 0x00172AED
		[NullableContext(1)]
		public static GachaPoolDetailResponse Create()
		{
			return new GachaPoolDetailResponse();
		}

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x06009A76 RID: 39542 RVA: 0x001748F4 File Offset: 0x00172AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x06009A77 RID: 39543 RVA: 0x001748F7 File Offset: 0x00172AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaPoolDetailResponse.Descriptor;
			}
		}

		// Token: 0x06009A78 RID: 39544 RVA: 0x001748FE File Offset: 0x00172AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetailResponse()
		{
		}

		// Token: 0x06009A79 RID: 39545 RVA: 0x00174908 File Offset: 0x00172B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetailResponse(GachaPoolDetailResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.detail_ = ((other.detail_ != null) ? other.detail_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A7A RID: 39546 RVA: 0x00174954 File Offset: 0x00172B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetailResponse Clone()
		{
			return new GachaPoolDetailResponse(this);
		}

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x06009A7B RID: 39547 RVA: 0x0017495C File Offset: 0x00172B5C
		// (set) Token: 0x06009A7C RID: 39548 RVA: 0x00174964 File Offset: 0x00172B64
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

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x06009A7D RID: 39549 RVA: 0x0017496D File Offset: 0x00172B6D
		// (set) Token: 0x06009A7E RID: 39550 RVA: 0x00174975 File Offset: 0x00172B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetail Detail
		{
			get
			{
				return this.detail_;
			}
			set
			{
				this.detail_ = value;
			}
		}

		// Token: 0x06009A7F RID: 39551 RVA: 0x0017497E File Offset: 0x00172B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaPoolDetailResponse);
		}

		// Token: 0x06009A80 RID: 39552 RVA: 0x0017498C File Offset: 0x00172B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaPoolDetailResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Detail, other.Detail) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009A81 RID: 39553 RVA: 0x001749DC File Offset: 0x00172BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.detail_ != null)
			{
				num ^= this.Detail.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009A82 RID: 39554 RVA: 0x00174A37 File Offset: 0x00172C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009A83 RID: 39555 RVA: 0x00174A44 File Offset: 0x00172C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A84 RID: 39556 RVA: 0x00174A50 File Offset: 0x00172C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.detail_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Detail);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A85 RID: 39557 RVA: 0x00174AAC File Offset: 0x00172CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.detail_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Detail);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009A86 RID: 39558 RVA: 0x00174B04 File Offset: 0x00172D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaPoolDetailResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.detail_ != null)
			{
				if (this.detail_ == null)
				{
					this.Detail = new GachaPoolDetail();
				}
				this.Detail.MergeFrom(other.Detail);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009A87 RID: 39559 RVA: 0x00174B6C File Offset: 0x00172D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A88 RID: 39560 RVA: 0x00174B78 File Offset: 0x00172D78
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
				if (num != 16U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.detail_ == null)
						{
							this.Detail = new GachaPoolDetail();
						}
						input.ReadMessage(this.Detail);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400490D RID: 18701
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400490E RID: 18702
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400490F RID: 18703
		private ErrorCode errorCode_;

		// Token: 0x04004910 RID: 18704
		public const int DetailFieldNumber = 7;

		// Token: 0x04004911 RID: 18705
		private GachaPoolDetail detail_;
	}
}
