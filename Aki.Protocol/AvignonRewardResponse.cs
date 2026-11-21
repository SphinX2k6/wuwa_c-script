using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000133 RID: 307
	[NetMessage(EMessageId.AvignonRewardResponse)]
	public sealed class AvignonRewardResponse : IMessage<AvignonRewardResponse>, IMessage, IEquatable<AvignonRewardResponse>, IDeepCloneable<AvignonRewardResponse>, IBufferMessage
	{
		// Token: 0x0600289E RID: 10398 RVA: 0x0006B1C0 File Offset: 0x000693C0
		[NullableContext(1)]
		public static AvignonRewardResponse Create()
		{
			return new AvignonRewardResponse();
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x0006B1C7 File Offset: 0x000693C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x0006B1CA File Offset: 0x000693CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvignonRewardResponse.Descriptor;
			}
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x0006B1D1 File Offset: 0x000693D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonRewardResponse()
		{
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x0006B1D9 File Offset: 0x000693D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonRewardResponse(AvignonRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x0006B1FE File Offset: 0x000693FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonRewardResponse Clone()
		{
			return new AvignonRewardResponse(this);
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x0006B206 File Offset: 0x00069406
		// (set) Token: 0x060028A5 RID: 10405 RVA: 0x0006B20E File Offset: 0x0006940E
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

		// Token: 0x060028A6 RID: 10406 RVA: 0x0006B217 File Offset: 0x00069417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvignonRewardResponse);
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x0006B225 File Offset: 0x00069425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvignonRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x0006B254 File Offset: 0x00069454
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

		// Token: 0x060028A9 RID: 10409 RVA: 0x0006B299 File Offset: 0x00069499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x0006B2A6 File Offset: 0x000694A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x0006B2AF File Offset: 0x000694AF
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

		// Token: 0x060028AC RID: 10412 RVA: 0x0006B2E4 File Offset: 0x000694E4
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

		// Token: 0x060028AD RID: 10413 RVA: 0x0006B322 File Offset: 0x00069522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvignonRewardResponse other)
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

		// Token: 0x060028AE RID: 10414 RVA: 0x0006B353 File Offset: 0x00069553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x0006B35C File Offset: 0x0006955C
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

		// Token: 0x04002706 RID: 9990
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002707 RID: 9991
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04002708 RID: 9992
		private ErrorCode errorCode_;
	}
}
