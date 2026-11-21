using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D2C RID: 3372
	[NetMessage(EMessageId.PickUpDropItemResponse)]
	public sealed class PickUpDropItemResponse : IMessage<PickUpDropItemResponse>, IMessage, IEquatable<PickUpDropItemResponse>, IDeepCloneable<PickUpDropItemResponse>, IBufferMessage
	{
		// Token: 0x06012391 RID: 74641 RVA: 0x002A970B File Offset: 0x002A790B
		[NullableContext(1)]
		public static PickUpDropItemResponse Create()
		{
			return new PickUpDropItemResponse();
		}

		// Token: 0x17003C60 RID: 15456
		// (get) Token: 0x06012392 RID: 74642 RVA: 0x002A9712 File Offset: 0x002A7912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C61 RID: 15457
		// (get) Token: 0x06012393 RID: 74643 RVA: 0x002A9715 File Offset: 0x002A7915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PickUpDropItemResponse.Descriptor;
			}
		}

		// Token: 0x06012394 RID: 74644 RVA: 0x002A971C File Offset: 0x002A791C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PickUpDropItemResponse()
		{
		}

		// Token: 0x06012395 RID: 74645 RVA: 0x002A9724 File Offset: 0x002A7924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PickUpDropItemResponse(PickUpDropItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012396 RID: 74646 RVA: 0x002A9749 File Offset: 0x002A7949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PickUpDropItemResponse Clone()
		{
			return new PickUpDropItemResponse(this);
		}

		// Token: 0x17003C62 RID: 15458
		// (get) Token: 0x06012397 RID: 74647 RVA: 0x002A9751 File Offset: 0x002A7951
		// (set) Token: 0x06012398 RID: 74648 RVA: 0x002A9759 File Offset: 0x002A7959
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

		// Token: 0x06012399 RID: 74649 RVA: 0x002A9762 File Offset: 0x002A7962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PickUpDropItemResponse);
		}

		// Token: 0x0601239A RID: 74650 RVA: 0x002A9770 File Offset: 0x002A7970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PickUpDropItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601239B RID: 74651 RVA: 0x002A97A0 File Offset: 0x002A79A0
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

		// Token: 0x0601239C RID: 74652 RVA: 0x002A97E5 File Offset: 0x002A79E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601239D RID: 74653 RVA: 0x002A97F2 File Offset: 0x002A79F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601239E RID: 74654 RVA: 0x002A97FB File Offset: 0x002A79FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601239F RID: 74655 RVA: 0x002A9830 File Offset: 0x002A7A30
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

		// Token: 0x060123A0 RID: 74656 RVA: 0x002A986E File Offset: 0x002A7A6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PickUpDropItemResponse other)
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

		// Token: 0x060123A1 RID: 74657 RVA: 0x002A989F File Offset: 0x002A7A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060123A2 RID: 74658 RVA: 0x002A98A8 File Offset: 0x002A7AA8
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400721D RID: 29213
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400721E RID: 29214
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400721F RID: 29215
		private ErrorCode errorCode_;
	}
}
