using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000523 RID: 1315
	[NetMessage(EMessageId.FarmGoldLevelPlayRepeatedResponse)]
	public sealed class FarmGoldLevelPlayRepeatedResponse : IMessage<FarmGoldLevelPlayRepeatedResponse>, IMessage, IEquatable<FarmGoldLevelPlayRepeatedResponse>, IDeepCloneable<FarmGoldLevelPlayRepeatedResponse>, IBufferMessage
	{
		// Token: 0x06007B6E RID: 31598 RVA: 0x0012B7A8 File Offset: 0x001299A8
		[NullableContext(1)]
		public static FarmGoldLevelPlayRepeatedResponse Create()
		{
			return new FarmGoldLevelPlayRepeatedResponse();
		}

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x06007B6F RID: 31599 RVA: 0x0012B7AF File Offset: 0x001299AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x06007B70 RID: 31600 RVA: 0x0012B7B2 File Offset: 0x001299B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldLevelPlayRepeatedResponse.Descriptor;
			}
		}

		// Token: 0x06007B71 RID: 31601 RVA: 0x0012B7B9 File Offset: 0x001299B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayRepeatedResponse()
		{
		}

		// Token: 0x06007B72 RID: 31602 RVA: 0x0012B7C1 File Offset: 0x001299C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayRepeatedResponse(FarmGoldLevelPlayRepeatedResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B73 RID: 31603 RVA: 0x0012B7E6 File Offset: 0x001299E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayRepeatedResponse Clone()
		{
			return new FarmGoldLevelPlayRepeatedResponse(this);
		}

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x06007B74 RID: 31604 RVA: 0x0012B7EE File Offset: 0x001299EE
		// (set) Token: 0x06007B75 RID: 31605 RVA: 0x0012B7F6 File Offset: 0x001299F6
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

		// Token: 0x06007B76 RID: 31606 RVA: 0x0012B7FF File Offset: 0x001299FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldLevelPlayRepeatedResponse);
		}

		// Token: 0x06007B77 RID: 31607 RVA: 0x0012B80D File Offset: 0x00129A0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldLevelPlayRepeatedResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B78 RID: 31608 RVA: 0x0012B83C File Offset: 0x00129A3C
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

		// Token: 0x06007B79 RID: 31609 RVA: 0x0012B881 File Offset: 0x00129A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007B7A RID: 31610 RVA: 0x0012B88E File Offset: 0x00129A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B7B RID: 31611 RVA: 0x0012B897 File Offset: 0x00129A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B7C RID: 31612 RVA: 0x0012B8CC File Offset: 0x00129ACC
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

		// Token: 0x06007B7D RID: 31613 RVA: 0x0012B90A File Offset: 0x00129B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldLevelPlayRepeatedResponse other)
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

		// Token: 0x06007B7E RID: 31614 RVA: 0x0012B93B File Offset: 0x00129B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B7F RID: 31615 RVA: 0x0012B944 File Offset: 0x00129B44
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003F30 RID: 16176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F31 RID: 16177
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04003F32 RID: 16178
		private ErrorCode errorCode_;
	}
}
