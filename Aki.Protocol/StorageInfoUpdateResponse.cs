using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200130B RID: 4875
	[NetMessage(EMessageId.StorageInfoUpdateResponse)]
	public sealed class StorageInfoUpdateResponse : IMessage<StorageInfoUpdateResponse>, IMessage, IEquatable<StorageInfoUpdateResponse>, IDeepCloneable<StorageInfoUpdateResponse>, IBufferMessage
	{
		// Token: 0x06019FF4 RID: 106484 RVA: 0x003CA36D File Offset: 0x003C856D
		[NullableContext(1)]
		public static StorageInfoUpdateResponse Create()
		{
			return new StorageInfoUpdateResponse();
		}

		// Token: 0x17005807 RID: 22535
		// (get) Token: 0x06019FF5 RID: 106485 RVA: 0x003CA374 File Offset: 0x003C8574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005808 RID: 22536
		// (get) Token: 0x06019FF6 RID: 106486 RVA: 0x003CA377 File Offset: 0x003C8577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StorageInfoUpdateResponse.Descriptor;
			}
		}

		// Token: 0x06019FF7 RID: 106487 RVA: 0x003CA37E File Offset: 0x003C857E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoUpdateResponse()
		{
		}

		// Token: 0x06019FF8 RID: 106488 RVA: 0x003CA386 File Offset: 0x003C8586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoUpdateResponse(StorageInfoUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019FF9 RID: 106489 RVA: 0x003CA3AB File Offset: 0x003C85AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoUpdateResponse Clone()
		{
			return new StorageInfoUpdateResponse(this);
		}

		// Token: 0x17005809 RID: 22537
		// (get) Token: 0x06019FFA RID: 106490 RVA: 0x003CA3B3 File Offset: 0x003C85B3
		// (set) Token: 0x06019FFB RID: 106491 RVA: 0x003CA3BB File Offset: 0x003C85BB
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

		// Token: 0x06019FFC RID: 106492 RVA: 0x003CA3C4 File Offset: 0x003C85C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StorageInfoUpdateResponse);
		}

		// Token: 0x06019FFD RID: 106493 RVA: 0x003CA3D2 File Offset: 0x003C85D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StorageInfoUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019FFE RID: 106494 RVA: 0x003CA400 File Offset: 0x003C8600
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

		// Token: 0x06019FFF RID: 106495 RVA: 0x003CA445 File Offset: 0x003C8645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A000 RID: 106496 RVA: 0x003CA452 File Offset: 0x003C8652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A001 RID: 106497 RVA: 0x003CA45B File Offset: 0x003C865B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A002 RID: 106498 RVA: 0x003CA490 File Offset: 0x003C8690
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

		// Token: 0x0601A003 RID: 106499 RVA: 0x003CA4CE File Offset: 0x003C86CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StorageInfoUpdateResponse other)
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

		// Token: 0x0601A004 RID: 106500 RVA: 0x003CA4FF File Offset: 0x003C86FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A005 RID: 106501 RVA: 0x003CA508 File Offset: 0x003C8708
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009925 RID: 39205
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009926 RID: 39206
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04009927 RID: 39207
		private ErrorCode errorCode_;
	}
}
