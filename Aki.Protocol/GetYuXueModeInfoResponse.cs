using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C0 RID: 1728
	[NetMessage(EMessageId.GetYuXueModeInfoResponse)]
	public sealed class GetYuXueModeInfoResponse : IMessage<GetYuXueModeInfoResponse>, IMessage, IEquatable<GetYuXueModeInfoResponse>, IDeepCloneable<GetYuXueModeInfoResponse>, IBufferMessage
	{
		// Token: 0x06009E54 RID: 40532 RVA: 0x001802DE File Offset: 0x0017E4DE
		[NullableContext(1)]
		public static GetYuXueModeInfoResponse Create()
		{
			return new GetYuXueModeInfoResponse();
		}

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x06009E55 RID: 40533 RVA: 0x001802E5 File Offset: 0x0017E4E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x06009E56 RID: 40534 RVA: 0x001802E8 File Offset: 0x0017E4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetYuXueModeInfoResponse.Descriptor;
			}
		}

		// Token: 0x06009E57 RID: 40535 RVA: 0x001802EF File Offset: 0x0017E4EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetYuXueModeInfoResponse()
		{
		}

		// Token: 0x06009E58 RID: 40536 RVA: 0x001802F7 File Offset: 0x0017E4F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetYuXueModeInfoResponse(GetYuXueModeInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E59 RID: 40537 RVA: 0x0018031C File Offset: 0x0017E51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetYuXueModeInfoResponse Clone()
		{
			return new GetYuXueModeInfoResponse(this);
		}

		// Token: 0x17001FC8 RID: 8136
		// (get) Token: 0x06009E5A RID: 40538 RVA: 0x00180324 File Offset: 0x0017E524
		// (set) Token: 0x06009E5B RID: 40539 RVA: 0x0018032C File Offset: 0x0017E52C
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

		// Token: 0x06009E5C RID: 40540 RVA: 0x00180335 File Offset: 0x0017E535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetYuXueModeInfoResponse);
		}

		// Token: 0x06009E5D RID: 40541 RVA: 0x00180343 File Offset: 0x0017E543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetYuXueModeInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E5E RID: 40542 RVA: 0x00180374 File Offset: 0x0017E574
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

		// Token: 0x06009E5F RID: 40543 RVA: 0x001803B9 File Offset: 0x0017E5B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009E60 RID: 40544 RVA: 0x001803C6 File Offset: 0x0017E5C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E61 RID: 40545 RVA: 0x001803CF File Offset: 0x0017E5CF
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

		// Token: 0x06009E62 RID: 40546 RVA: 0x00180404 File Offset: 0x0017E604
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

		// Token: 0x06009E63 RID: 40547 RVA: 0x00180442 File Offset: 0x0017E642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetYuXueModeInfoResponse other)
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

		// Token: 0x06009E64 RID: 40548 RVA: 0x00180473 File Offset: 0x0017E673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E65 RID: 40549 RVA: 0x0018047C File Offset: 0x0017E67C
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

		// Token: 0x04004A6F RID: 19055
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A70 RID: 19056
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04004A71 RID: 19057
		private ErrorCode errorCode_;
	}
}
