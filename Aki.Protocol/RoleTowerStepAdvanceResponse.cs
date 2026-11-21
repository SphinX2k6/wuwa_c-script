using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F5 RID: 4341
	[NetMessage(EMessageId.RoleTowerStepAdvanceResponse)]
	public sealed class RoleTowerStepAdvanceResponse : IMessage<RoleTowerStepAdvanceResponse>, IMessage, IEquatable<RoleTowerStepAdvanceResponse>, IDeepCloneable<RoleTowerStepAdvanceResponse>, IBufferMessage
	{
		// Token: 0x06017354 RID: 95060 RVA: 0x00360A6B File Offset: 0x0035EC6B
		[NullableContext(1)]
		public static RoleTowerStepAdvanceResponse Create()
		{
			return new RoleTowerStepAdvanceResponse();
		}

		// Token: 0x17004DF7 RID: 19959
		// (get) Token: 0x06017355 RID: 95061 RVA: 0x00360A72 File Offset: 0x0035EC72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DF8 RID: 19960
		// (get) Token: 0x06017356 RID: 95062 RVA: 0x00360A75 File Offset: 0x0035EC75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerStepAdvanceResponse.Descriptor;
			}
		}

		// Token: 0x06017357 RID: 95063 RVA: 0x00360A7C File Offset: 0x0035EC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStepAdvanceResponse()
		{
		}

		// Token: 0x06017358 RID: 95064 RVA: 0x00360A84 File Offset: 0x0035EC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStepAdvanceResponse(RoleTowerStepAdvanceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017359 RID: 95065 RVA: 0x00360AA9 File Offset: 0x0035ECA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStepAdvanceResponse Clone()
		{
			return new RoleTowerStepAdvanceResponse(this);
		}

		// Token: 0x17004DF9 RID: 19961
		// (get) Token: 0x0601735A RID: 95066 RVA: 0x00360AB1 File Offset: 0x0035ECB1
		// (set) Token: 0x0601735B RID: 95067 RVA: 0x00360AB9 File Offset: 0x0035ECB9
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

		// Token: 0x0601735C RID: 95068 RVA: 0x00360AC2 File Offset: 0x0035ECC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerStepAdvanceResponse);
		}

		// Token: 0x0601735D RID: 95069 RVA: 0x00360AD0 File Offset: 0x0035ECD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerStepAdvanceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601735E RID: 95070 RVA: 0x00360B00 File Offset: 0x0035ED00
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

		// Token: 0x0601735F RID: 95071 RVA: 0x00360B45 File Offset: 0x0035ED45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017360 RID: 95072 RVA: 0x00360B52 File Offset: 0x0035ED52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017361 RID: 95073 RVA: 0x00360B5B File Offset: 0x0035ED5B
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

		// Token: 0x06017362 RID: 95074 RVA: 0x00360B90 File Offset: 0x0035ED90
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

		// Token: 0x06017363 RID: 95075 RVA: 0x00360BCE File Offset: 0x0035EDCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerStepAdvanceResponse other)
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

		// Token: 0x06017364 RID: 95076 RVA: 0x00360BFF File Offset: 0x0035EDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017365 RID: 95077 RVA: 0x00360C08 File Offset: 0x0035EE08
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

		// Token: 0x04008ADB RID: 35547
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008ADC RID: 35548
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04008ADD RID: 35549
		private ErrorCode errorCode_;
	}
}
