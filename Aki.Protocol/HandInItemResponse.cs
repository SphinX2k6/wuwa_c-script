using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000739 RID: 1849
	[NetMessage(EMessageId.HandInItemResponse)]
	public sealed class HandInItemResponse : IMessage<HandInItemResponse>, IMessage, IEquatable<HandInItemResponse>, IDeepCloneable<HandInItemResponse>, IBufferMessage
	{
		// Token: 0x0600A7A1 RID: 42913 RVA: 0x00193838 File Offset: 0x00191A38
		[NullableContext(1)]
		public static HandInItemResponse Create()
		{
			return new HandInItemResponse();
		}

		// Token: 0x170021B4 RID: 8628
		// (get) Token: 0x0600A7A2 RID: 42914 RVA: 0x0019383F File Offset: 0x00191A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021B5 RID: 8629
		// (get) Token: 0x0600A7A3 RID: 42915 RVA: 0x00193842 File Offset: 0x00191A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HandInItemResponse.Descriptor;
			}
		}

		// Token: 0x0600A7A4 RID: 42916 RVA: 0x00193849 File Offset: 0x00191A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInItemResponse()
		{
		}

		// Token: 0x0600A7A5 RID: 42917 RVA: 0x00193851 File Offset: 0x00191A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInItemResponse(HandInItemResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A7A6 RID: 42918 RVA: 0x00193876 File Offset: 0x00191A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInItemResponse Clone()
		{
			return new HandInItemResponse(this);
		}

		// Token: 0x170021B6 RID: 8630
		// (get) Token: 0x0600A7A7 RID: 42919 RVA: 0x0019387E File Offset: 0x00191A7E
		// (set) Token: 0x0600A7A8 RID: 42920 RVA: 0x00193886 File Offset: 0x00191A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x0600A7A9 RID: 42921 RVA: 0x0019388F File Offset: 0x00191A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HandInItemResponse);
		}

		// Token: 0x0600A7AA RID: 42922 RVA: 0x0019389D File Offset: 0x00191A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HandInItemResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A7AB RID: 42923 RVA: 0x001938CC File Offset: 0x00191ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A7AC RID: 42924 RVA: 0x00193911 File Offset: 0x00191B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A7AD RID: 42925 RVA: 0x0019391E File Offset: 0x00191B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A7AE RID: 42926 RVA: 0x00193927 File Offset: 0x00191B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A7AF RID: 42927 RVA: 0x0019395C File Offset: 0x00191B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A7B0 RID: 42928 RVA: 0x0019399A File Offset: 0x00191B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HandInItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A7B1 RID: 42929 RVA: 0x001939CB File Offset: 0x00191BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A7B2 RID: 42930 RVA: 0x001939D4 File Offset: 0x00191BD4
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004C9D RID: 19613
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C9E RID: 19614
		public const int ErrorIdFieldNumber = 10;

		// Token: 0x04004C9F RID: 19615
		private ErrorCode errorId_;
	}
}
