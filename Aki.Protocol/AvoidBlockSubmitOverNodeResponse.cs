using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200013A RID: 314
	[NetMessage(EMessageId.AvoidBlockSubmitOverNodeResponse)]
	public sealed class AvoidBlockSubmitOverNodeResponse : IMessage<AvoidBlockSubmitOverNodeResponse>, IMessage, IEquatable<AvoidBlockSubmitOverNodeResponse>, IDeepCloneable<AvoidBlockSubmitOverNodeResponse>, IBufferMessage
	{
		// Token: 0x0600293C RID: 10556 RVA: 0x0006C97F File Offset: 0x0006AB7F
		[NullableContext(1)]
		public static AvoidBlockSubmitOverNodeResponse Create()
		{
			return new AvoidBlockSubmitOverNodeResponse();
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x0600293D RID: 10557 RVA: 0x0006C986 File Offset: 0x0006AB86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x0600293E RID: 10558 RVA: 0x0006C989 File Offset: 0x0006AB89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvoidBlockSubmitOverNodeResponse.Descriptor;
			}
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x0006C990 File Offset: 0x0006AB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockSubmitOverNodeResponse()
		{
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x0006C998 File Offset: 0x0006AB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockSubmitOverNodeResponse(AvoidBlockSubmitOverNodeResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x0006C9BD File Offset: 0x0006ABBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockSubmitOverNodeResponse Clone()
		{
			return new AvoidBlockSubmitOverNodeResponse(this);
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06002942 RID: 10562 RVA: 0x0006C9C5 File Offset: 0x0006ABC5
		// (set) Token: 0x06002943 RID: 10563 RVA: 0x0006C9CD File Offset: 0x0006ABCD
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

		// Token: 0x06002944 RID: 10564 RVA: 0x0006C9D6 File Offset: 0x0006ABD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvoidBlockSubmitOverNodeResponse);
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x0006C9E4 File Offset: 0x0006ABE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvoidBlockSubmitOverNodeResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x0006CA14 File Offset: 0x0006AC14
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

		// Token: 0x06002947 RID: 10567 RVA: 0x0006CA59 File Offset: 0x0006AC59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x0006CA66 File Offset: 0x0006AC66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x0006CA6F File Offset: 0x0006AC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x0006CAA4 File Offset: 0x0006ACA4
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

		// Token: 0x0600294B RID: 10571 RVA: 0x0006CAE2 File Offset: 0x0006ACE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvoidBlockSubmitOverNodeResponse other)
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

		// Token: 0x0600294C RID: 10572 RVA: 0x0006CB13 File Offset: 0x0006AD13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x0006CB1C File Offset: 0x0006AD1C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002739 RID: 10041
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400273A RID: 10042
		public const int ErrorIdFieldNumber = 8;

		// Token: 0x0400273B RID: 10043
		private ErrorCode errorId_;
	}
}
