using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007BA RID: 1978
	[NetMessage(EMessageId.HookLockPointResponse)]
	public sealed class HookLockPointResponse : IMessage<HookLockPointResponse>, IMessage, IEquatable<HookLockPointResponse>, IDeepCloneable<HookLockPointResponse>, IBufferMessage
	{
		// Token: 0x0600B20B RID: 45579 RVA: 0x001AA805 File Offset: 0x001A8A05
		[NullableContext(1)]
		public static HookLockPointResponse Create()
		{
			return new HookLockPointResponse();
		}

		// Token: 0x170023EB RID: 9195
		// (get) Token: 0x0600B20C RID: 45580 RVA: 0x001AA80C File Offset: 0x001A8A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023EC RID: 9196
		// (get) Token: 0x0600B20D RID: 45581 RVA: 0x001AA80F File Offset: 0x001A8A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockPointResponse.Descriptor;
			}
		}

		// Token: 0x0600B20E RID: 45582 RVA: 0x001AA816 File Offset: 0x001A8A16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointResponse()
		{
		}

		// Token: 0x0600B20F RID: 45583 RVA: 0x001AA81E File Offset: 0x001A8A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointResponse(HookLockPointResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B210 RID: 45584 RVA: 0x001AA843 File Offset: 0x001A8A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointResponse Clone()
		{
			return new HookLockPointResponse(this);
		}

		// Token: 0x170023ED RID: 9197
		// (get) Token: 0x0600B211 RID: 45585 RVA: 0x001AA84B File Offset: 0x001A8A4B
		// (set) Token: 0x0600B212 RID: 45586 RVA: 0x001AA853 File Offset: 0x001A8A53
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

		// Token: 0x0600B213 RID: 45587 RVA: 0x001AA85C File Offset: 0x001A8A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockPointResponse);
		}

		// Token: 0x0600B214 RID: 45588 RVA: 0x001AA86A File Offset: 0x001A8A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockPointResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B215 RID: 45589 RVA: 0x001AA898 File Offset: 0x001A8A98
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

		// Token: 0x0600B216 RID: 45590 RVA: 0x001AA8DD File Offset: 0x001A8ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B217 RID: 45591 RVA: 0x001AA8EA File Offset: 0x001A8AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B218 RID: 45592 RVA: 0x001AA8F3 File Offset: 0x001A8AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B219 RID: 45593 RVA: 0x001AA928 File Offset: 0x001A8B28
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

		// Token: 0x0600B21A RID: 45594 RVA: 0x001AA966 File Offset: 0x001A8B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HookLockPointResponse other)
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

		// Token: 0x0600B21B RID: 45595 RVA: 0x001AA997 File Offset: 0x001A8B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B21C RID: 45596 RVA: 0x001AA9A0 File Offset: 0x001A8BA0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004FAE RID: 20398
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FAF RID: 20399
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04004FB0 RID: 20400
		private ErrorCode errorCode_;
	}
}
