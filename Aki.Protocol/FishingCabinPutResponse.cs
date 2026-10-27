using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200054B RID: 1355
	[NetMessage(EMessageId.FishingCabinPutResponse)]
	public sealed class FishingCabinPutResponse : IMessage<FishingCabinPutResponse>, IMessage, IEquatable<FishingCabinPutResponse>, IDeepCloneable<FishingCabinPutResponse>, IBufferMessage
	{
		// Token: 0x06007EB5 RID: 32437 RVA: 0x00132B84 File Offset: 0x00130D84
		[NullableContext(1)]
		public static FishingCabinPutResponse Create()
		{
			return new FishingCabinPutResponse();
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x06007EB6 RID: 32438 RVA: 0x00132B8B File Offset: 0x00130D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x06007EB7 RID: 32439 RVA: 0x00132B8E File Offset: 0x00130D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingCabinPutResponse.Descriptor;
			}
		}

		// Token: 0x06007EB8 RID: 32440 RVA: 0x00132B95 File Offset: 0x00130D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCabinPutResponse()
		{
		}

		// Token: 0x06007EB9 RID: 32441 RVA: 0x00132B9D File Offset: 0x00130D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCabinPutResponse(FishingCabinPutResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007EBA RID: 32442 RVA: 0x00132BC2 File Offset: 0x00130DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCabinPutResponse Clone()
		{
			return new FishingCabinPutResponse(this);
		}

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x06007EBB RID: 32443 RVA: 0x00132BCA File Offset: 0x00130DCA
		// (set) Token: 0x06007EBC RID: 32444 RVA: 0x00132BD2 File Offset: 0x00130DD2
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

		// Token: 0x06007EBD RID: 32445 RVA: 0x00132BDB File Offset: 0x00130DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingCabinPutResponse);
		}

		// Token: 0x06007EBE RID: 32446 RVA: 0x00132BE9 File Offset: 0x00130DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingCabinPutResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007EBF RID: 32447 RVA: 0x00132C18 File Offset: 0x00130E18
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

		// Token: 0x06007EC0 RID: 32448 RVA: 0x00132C5D File Offset: 0x00130E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007EC1 RID: 32449 RVA: 0x00132C6A File Offset: 0x00130E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007EC2 RID: 32450 RVA: 0x00132C73 File Offset: 0x00130E73
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

		// Token: 0x06007EC3 RID: 32451 RVA: 0x00132CA8 File Offset: 0x00130EA8
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

		// Token: 0x06007EC4 RID: 32452 RVA: 0x00132CE6 File Offset: 0x00130EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingCabinPutResponse other)
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

		// Token: 0x06007EC5 RID: 32453 RVA: 0x00132D17 File Offset: 0x00130F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007EC6 RID: 32454 RVA: 0x00132D20 File Offset: 0x00130F20
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

		// Token: 0x04004031 RID: 16433
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004032 RID: 16434
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04004033 RID: 16435
		private ErrorCode errorCode_;
	}
}
