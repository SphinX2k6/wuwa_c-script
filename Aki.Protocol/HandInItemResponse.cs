using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000725 RID: 1829
	[NetMessage(EMessageId.HandInItemResponse)]
	public sealed class HandInItemResponse : IMessage<HandInItemResponse>, IMessage, IEquatable<HandInItemResponse>, IDeepCloneable<HandInItemResponse>, IBufferMessage
	{
		// Token: 0x0600A64B RID: 42571 RVA: 0x00190E05 File Offset: 0x0018F005
		[NullableContext(1)]
		public static HandInItemResponse Create()
		{
			return new HandInItemResponse();
		}

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x0600A64C RID: 42572 RVA: 0x00190E0C File Offset: 0x0018F00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x0600A64D RID: 42573 RVA: 0x00190E0F File Offset: 0x0018F00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HandInItemResponse.Descriptor;
			}
		}

		// Token: 0x0600A64E RID: 42574 RVA: 0x00190E16 File Offset: 0x0018F016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInItemResponse()
		{
		}

		// Token: 0x0600A64F RID: 42575 RVA: 0x00190E1E File Offset: 0x0018F01E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInItemResponse(HandInItemResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A650 RID: 42576 RVA: 0x00190E43 File Offset: 0x0018F043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInItemResponse Clone()
		{
			return new HandInItemResponse(this);
		}

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x0600A651 RID: 42577 RVA: 0x00190E4B File Offset: 0x0018F04B
		// (set) Token: 0x0600A652 RID: 42578 RVA: 0x00190E53 File Offset: 0x0018F053
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

		// Token: 0x0600A653 RID: 42579 RVA: 0x00190E5C File Offset: 0x0018F05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HandInItemResponse);
		}

		// Token: 0x0600A654 RID: 42580 RVA: 0x00190E6A File Offset: 0x0018F06A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HandInItemResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A655 RID: 42581 RVA: 0x00190E98 File Offset: 0x0018F098
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

		// Token: 0x0600A656 RID: 42582 RVA: 0x00190EDD File Offset: 0x0018F0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A657 RID: 42583 RVA: 0x00190EEA File Offset: 0x0018F0EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A658 RID: 42584 RVA: 0x00190EF3 File Offset: 0x0018F0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A659 RID: 42585 RVA: 0x00190F28 File Offset: 0x0018F128
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

		// Token: 0x0600A65A RID: 42586 RVA: 0x00190F66 File Offset: 0x0018F166
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

		// Token: 0x0600A65B RID: 42587 RVA: 0x00190F97 File Offset: 0x0018F197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A65C RID: 42588 RVA: 0x00190FA0 File Offset: 0x0018F1A0
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004C96 RID: 19606
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C97 RID: 19607
		public const int ErrorIdFieldNumber = 3;

		// Token: 0x04004C98 RID: 19608
		private ErrorCode errorId_;
	}
}
