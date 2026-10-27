using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D2E RID: 3374
	[NetMessage(EMessageId.PhotoFightSettleResponse)]
	public sealed class PhotoFightSettleResponse : IMessage<PhotoFightSettleResponse>, IMessage, IEquatable<PhotoFightSettleResponse>, IDeepCloneable<PhotoFightSettleResponse>, IBufferMessage
	{
		// Token: 0x0601237F RID: 74623 RVA: 0x002A928E File Offset: 0x002A748E
		[NullableContext(1)]
		public static PhotoFightSettleResponse Create()
		{
			return new PhotoFightSettleResponse();
		}

		// Token: 0x17003C61 RID: 15457
		// (get) Token: 0x06012380 RID: 74624 RVA: 0x002A9295 File Offset: 0x002A7495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C62 RID: 15458
		// (get) Token: 0x06012381 RID: 74625 RVA: 0x002A9298 File Offset: 0x002A7498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightSettleResponse.Descriptor;
			}
		}

		// Token: 0x06012382 RID: 74626 RVA: 0x002A929F File Offset: 0x002A749F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightSettleResponse()
		{
		}

		// Token: 0x06012383 RID: 74627 RVA: 0x002A92A7 File Offset: 0x002A74A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightSettleResponse(PhotoFightSettleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012384 RID: 74628 RVA: 0x002A92CC File Offset: 0x002A74CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightSettleResponse Clone()
		{
			return new PhotoFightSettleResponse(this);
		}

		// Token: 0x17003C63 RID: 15459
		// (get) Token: 0x06012385 RID: 74629 RVA: 0x002A92D4 File Offset: 0x002A74D4
		// (set) Token: 0x06012386 RID: 74630 RVA: 0x002A92DC File Offset: 0x002A74DC
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

		// Token: 0x06012387 RID: 74631 RVA: 0x002A92E5 File Offset: 0x002A74E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightSettleResponse);
		}

		// Token: 0x06012388 RID: 74632 RVA: 0x002A92F3 File Offset: 0x002A74F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightSettleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012389 RID: 74633 RVA: 0x002A9324 File Offset: 0x002A7524
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

		// Token: 0x0601238A RID: 74634 RVA: 0x002A9369 File Offset: 0x002A7569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601238B RID: 74635 RVA: 0x002A9376 File Offset: 0x002A7576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601238C RID: 74636 RVA: 0x002A937F File Offset: 0x002A757F
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

		// Token: 0x0601238D RID: 74637 RVA: 0x002A93B4 File Offset: 0x002A75B4
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

		// Token: 0x0601238E RID: 74638 RVA: 0x002A93F2 File Offset: 0x002A75F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoFightSettleResponse other)
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

		// Token: 0x0601238F RID: 74639 RVA: 0x002A9423 File Offset: 0x002A7623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012390 RID: 74640 RVA: 0x002A942C File Offset: 0x002A762C
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

		// Token: 0x040071C3 RID: 29123
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071C4 RID: 29124
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040071C5 RID: 29125
		private ErrorCode errorCode_;
	}
}
