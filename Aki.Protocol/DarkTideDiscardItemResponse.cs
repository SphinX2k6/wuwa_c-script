using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A0 RID: 928
	[NetMessage(EMessageId.DarkTideDiscardItemResponse)]
	public sealed class DarkTideDiscardItemResponse : IMessage<DarkTideDiscardItemResponse>, IMessage, IEquatable<DarkTideDiscardItemResponse>, IDeepCloneable<DarkTideDiscardItemResponse>, IBufferMessage
	{
		// Token: 0x06005B6D RID: 23405 RVA: 0x000DE698 File Offset: 0x000DC898
		[NullableContext(1)]
		public static DarkTideDiscardItemResponse Create()
		{
			return new DarkTideDiscardItemResponse();
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06005B6E RID: 23406 RVA: 0x000DE69F File Offset: 0x000DC89F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x06005B6F RID: 23407 RVA: 0x000DE6A2 File Offset: 0x000DC8A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideDiscardItemResponse.Descriptor;
			}
		}

		// Token: 0x06005B70 RID: 23408 RVA: 0x000DE6A9 File Offset: 0x000DC8A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDiscardItemResponse()
		{
		}

		// Token: 0x06005B71 RID: 23409 RVA: 0x000DE6B1 File Offset: 0x000DC8B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDiscardItemResponse(DarkTideDiscardItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B72 RID: 23410 RVA: 0x000DE6D6 File Offset: 0x000DC8D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDiscardItemResponse Clone()
		{
			return new DarkTideDiscardItemResponse(this);
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06005B73 RID: 23411 RVA: 0x000DE6DE File Offset: 0x000DC8DE
		// (set) Token: 0x06005B74 RID: 23412 RVA: 0x000DE6E6 File Offset: 0x000DC8E6
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

		// Token: 0x06005B75 RID: 23413 RVA: 0x000DE6EF File Offset: 0x000DC8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideDiscardItemResponse);
		}

		// Token: 0x06005B76 RID: 23414 RVA: 0x000DE6FD File Offset: 0x000DC8FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideDiscardItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005B77 RID: 23415 RVA: 0x000DE72C File Offset: 0x000DC92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06005B78 RID: 23416 RVA: 0x000DE771 File Offset: 0x000DC971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005B79 RID: 23417 RVA: 0x000DE77E File Offset: 0x000DC97E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B7A RID: 23418 RVA: 0x000DE787 File Offset: 0x000DC987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B7B RID: 23419 RVA: 0x000DE7BC File Offset: 0x000DC9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06005B7C RID: 23420 RVA: 0x000DE7FA File Offset: 0x000DC9FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideDiscardItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B7D RID: 23421 RVA: 0x000DE82B File Offset: 0x000DCA2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B7E RID: 23422 RVA: 0x000DE834 File Offset: 0x000DCA34
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003605 RID: 13829
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003606 RID: 13830
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04003607 RID: 13831
		private ErrorCode errorCode_;
	}
}
