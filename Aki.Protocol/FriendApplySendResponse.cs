using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200063D RID: 1597
	[NetMessage(EMessageId.FriendApplySendResponse)]
	public sealed class FriendApplySendResponse : IMessage<FriendApplySendResponse>, IMessage, IEquatable<FriendApplySendResponse>, IDeepCloneable<FriendApplySendResponse>, IBufferMessage
	{
		// Token: 0x06009356 RID: 37718 RVA: 0x00164970 File Offset: 0x00162B70
		[NullableContext(1)]
		public static FriendApplySendResponse Create()
		{
			return new FriendApplySendResponse();
		}

		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x06009357 RID: 37719 RVA: 0x00164977 File Offset: 0x00162B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x06009358 RID: 37720 RVA: 0x0016497A File Offset: 0x00162B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendApplySendResponse.Descriptor;
			}
		}

		// Token: 0x06009359 RID: 37721 RVA: 0x00164981 File Offset: 0x00162B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplySendResponse()
		{
		}

		// Token: 0x0600935A RID: 37722 RVA: 0x00164989 File Offset: 0x00162B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplySendResponse(FriendApplySendResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600935B RID: 37723 RVA: 0x001649AE File Offset: 0x00162BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplySendResponse Clone()
		{
			return new FriendApplySendResponse(this);
		}

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x0600935C RID: 37724 RVA: 0x001649B6 File Offset: 0x00162BB6
		// (set) Token: 0x0600935D RID: 37725 RVA: 0x001649BE File Offset: 0x00162BBE
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

		// Token: 0x0600935E RID: 37726 RVA: 0x001649C7 File Offset: 0x00162BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendApplySendResponse);
		}

		// Token: 0x0600935F RID: 37727 RVA: 0x001649D5 File Offset: 0x00162BD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendApplySendResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009360 RID: 37728 RVA: 0x00164A04 File Offset: 0x00162C04
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

		// Token: 0x06009361 RID: 37729 RVA: 0x00164A49 File Offset: 0x00162C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009362 RID: 37730 RVA: 0x00164A56 File Offset: 0x00162C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009363 RID: 37731 RVA: 0x00164A5F File Offset: 0x00162C5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009364 RID: 37732 RVA: 0x00164A94 File Offset: 0x00162C94
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

		// Token: 0x06009365 RID: 37733 RVA: 0x00164AD2 File Offset: 0x00162CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendApplySendResponse other)
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

		// Token: 0x06009366 RID: 37734 RVA: 0x00164B03 File Offset: 0x00162D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009367 RID: 37735 RVA: 0x00164B0C File Offset: 0x00162D0C
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400472F RID: 18223
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004730 RID: 18224
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04004731 RID: 18225
		private ErrorCode errorCode_;
	}
}
