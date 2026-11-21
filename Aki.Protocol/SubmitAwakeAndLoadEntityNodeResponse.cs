using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001310 RID: 4880
	[NetMessage(EMessageId.SubmitAwakeAndLoadEntityNodeResponse)]
	public sealed class SubmitAwakeAndLoadEntityNodeResponse : IMessage<SubmitAwakeAndLoadEntityNodeResponse>, IMessage, IEquatable<SubmitAwakeAndLoadEntityNodeResponse>, IDeepCloneable<SubmitAwakeAndLoadEntityNodeResponse>, IBufferMessage
	{
		// Token: 0x0601A058 RID: 106584 RVA: 0x003CB017 File Offset: 0x003C9217
		[NullableContext(1)]
		public static SubmitAwakeAndLoadEntityNodeResponse Create()
		{
			return new SubmitAwakeAndLoadEntityNodeResponse();
		}

		// Token: 0x1700581B RID: 22555
		// (get) Token: 0x0601A059 RID: 106585 RVA: 0x003CB01E File Offset: 0x003C921E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700581C RID: 22556
		// (get) Token: 0x0601A05A RID: 106586 RVA: 0x003CB021 File Offset: 0x003C9221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitAwakeAndLoadEntityNodeResponse.Descriptor;
			}
		}

		// Token: 0x0601A05B RID: 106587 RVA: 0x003CB028 File Offset: 0x003C9228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitAwakeAndLoadEntityNodeResponse()
		{
		}

		// Token: 0x0601A05C RID: 106588 RVA: 0x003CB030 File Offset: 0x003C9230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitAwakeAndLoadEntityNodeResponse(SubmitAwakeAndLoadEntityNodeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A05D RID: 106589 RVA: 0x003CB055 File Offset: 0x003C9255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitAwakeAndLoadEntityNodeResponse Clone()
		{
			return new SubmitAwakeAndLoadEntityNodeResponse(this);
		}

		// Token: 0x1700581D RID: 22557
		// (get) Token: 0x0601A05E RID: 106590 RVA: 0x003CB05D File Offset: 0x003C925D
		// (set) Token: 0x0601A05F RID: 106591 RVA: 0x003CB065 File Offset: 0x003C9265
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

		// Token: 0x0601A060 RID: 106592 RVA: 0x003CB06E File Offset: 0x003C926E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitAwakeAndLoadEntityNodeResponse);
		}

		// Token: 0x0601A061 RID: 106593 RVA: 0x003CB07C File Offset: 0x003C927C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitAwakeAndLoadEntityNodeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A062 RID: 106594 RVA: 0x003CB0AC File Offset: 0x003C92AC
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

		// Token: 0x0601A063 RID: 106595 RVA: 0x003CB0F1 File Offset: 0x003C92F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A064 RID: 106596 RVA: 0x003CB0FE File Offset: 0x003C92FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A065 RID: 106597 RVA: 0x003CB107 File Offset: 0x003C9307
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

		// Token: 0x0601A066 RID: 106598 RVA: 0x003CB13C File Offset: 0x003C933C
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

		// Token: 0x0601A067 RID: 106599 RVA: 0x003CB17A File Offset: 0x003C937A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitAwakeAndLoadEntityNodeResponse other)
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

		// Token: 0x0601A068 RID: 106600 RVA: 0x003CB1AB File Offset: 0x003C93AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A069 RID: 106601 RVA: 0x003CB1B4 File Offset: 0x003C93B4
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

		// Token: 0x0400993E RID: 39230
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400993F RID: 39231
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04009940 RID: 39232
		private ErrorCode errorCode_;
	}
}
