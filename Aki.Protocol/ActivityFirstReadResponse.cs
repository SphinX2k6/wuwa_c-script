using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000087 RID: 135
	[NetMessage(EMessageId.ActivityFirstReadResponse)]
	public sealed class ActivityFirstReadResponse : IMessage<ActivityFirstReadResponse>, IMessage, IEquatable<ActivityFirstReadResponse>, IDeepCloneable<ActivityFirstReadResponse>, IBufferMessage
	{
		// Token: 0x06001A7A RID: 6778 RVA: 0x0004AF1D File Offset: 0x0004911D
		[NullableContext(1)]
		public static ActivityFirstReadResponse Create()
		{
			return new ActivityFirstReadResponse();
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x0004AF24 File Offset: 0x00049124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x0004AF27 File Offset: 0x00049127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityFirstReadResponse.Descriptor;
			}
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x0004AF2E File Offset: 0x0004912E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityFirstReadResponse()
		{
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x0004AF36 File Offset: 0x00049136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityFirstReadResponse(ActivityFirstReadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x0004AF5B File Offset: 0x0004915B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityFirstReadResponse Clone()
		{
			return new ActivityFirstReadResponse(this);
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x0004AF63 File Offset: 0x00049163
		// (set) Token: 0x06001A81 RID: 6785 RVA: 0x0004AF6B File Offset: 0x0004916B
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

		// Token: 0x06001A82 RID: 6786 RVA: 0x0004AF74 File Offset: 0x00049174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityFirstReadResponse);
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0004AF82 File Offset: 0x00049182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityFirstReadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0004AFB0 File Offset: 0x000491B0
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

		// Token: 0x06001A85 RID: 6789 RVA: 0x0004AFF5 File Offset: 0x000491F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x0004B002 File Offset: 0x00049202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x0004B00B File Offset: 0x0004920B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0004B040 File Offset: 0x00049240
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

		// Token: 0x06001A89 RID: 6793 RVA: 0x0004B07E File Offset: 0x0004927E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityFirstReadResponse other)
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

		// Token: 0x06001A8A RID: 6794 RVA: 0x0004B0AF File Offset: 0x000492AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x0004B0B8 File Offset: 0x000492B8
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040022A1 RID: 8865
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022A2 RID: 8866
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040022A3 RID: 8867
		private ErrorCode errorCode_;
	}
}
