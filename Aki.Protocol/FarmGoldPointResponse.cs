using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000514 RID: 1300
	[NetMessage(EMessageId.FarmGoldPointResponse)]
	public sealed class FarmGoldPointResponse : IMessage<FarmGoldPointResponse>, IMessage, IEquatable<FarmGoldPointResponse>, IDeepCloneable<FarmGoldPointResponse>, IBufferMessage
	{
		// Token: 0x06007A78 RID: 31352 RVA: 0x00129924 File Offset: 0x00127B24
		[NullableContext(1)]
		public static FarmGoldPointResponse Create()
		{
			return new FarmGoldPointResponse();
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06007A79 RID: 31353 RVA: 0x0012992B File Offset: 0x00127B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x06007A7A RID: 31354 RVA: 0x0012992E File Offset: 0x00127B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldPointResponse.Descriptor;
			}
		}

		// Token: 0x06007A7B RID: 31355 RVA: 0x00129935 File Offset: 0x00127B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointResponse()
		{
		}

		// Token: 0x06007A7C RID: 31356 RVA: 0x0012993D File Offset: 0x00127B3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointResponse(FarmGoldPointResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A7D RID: 31357 RVA: 0x00129962 File Offset: 0x00127B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointResponse Clone()
		{
			return new FarmGoldPointResponse(this);
		}

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x06007A7E RID: 31358 RVA: 0x0012996A File Offset: 0x00127B6A
		// (set) Token: 0x06007A7F RID: 31359 RVA: 0x00129972 File Offset: 0x00127B72
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

		// Token: 0x06007A80 RID: 31360 RVA: 0x0012997B File Offset: 0x00127B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldPointResponse);
		}

		// Token: 0x06007A81 RID: 31361 RVA: 0x00129989 File Offset: 0x00127B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldPointResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A82 RID: 31362 RVA: 0x001299B8 File Offset: 0x00127BB8
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

		// Token: 0x06007A83 RID: 31363 RVA: 0x001299FD File Offset: 0x00127BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007A84 RID: 31364 RVA: 0x00129A0A File Offset: 0x00127C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A85 RID: 31365 RVA: 0x00129A13 File Offset: 0x00127C13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A86 RID: 31366 RVA: 0x00129A48 File Offset: 0x00127C48
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

		// Token: 0x06007A87 RID: 31367 RVA: 0x00129A86 File Offset: 0x00127C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldPointResponse other)
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

		// Token: 0x06007A88 RID: 31368 RVA: 0x00129AB7 File Offset: 0x00127CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A89 RID: 31369 RVA: 0x00129AC0 File Offset: 0x00127CC0
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003F3F RID: 16191
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F40 RID: 16192
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04003F41 RID: 16193
		private ErrorCode errorCode_;
	}
}
