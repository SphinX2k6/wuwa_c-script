using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001402 RID: 5122
	[NetMessage(EMessageId.TotalTopUpRewardResponse)]
	public sealed class TotalTopUpRewardResponse : IMessage<TotalTopUpRewardResponse>, IMessage, IEquatable<TotalTopUpRewardResponse>, IDeepCloneable<TotalTopUpRewardResponse>, IBufferMessage
	{
		// Token: 0x0601B3B1 RID: 111537 RVA: 0x003F61D0 File Offset: 0x003F43D0
		[NullableContext(1)]
		public static TotalTopUpRewardResponse Create()
		{
			return new TotalTopUpRewardResponse();
		}

		// Token: 0x17005C2D RID: 23597
		// (get) Token: 0x0601B3B2 RID: 111538 RVA: 0x003F61D7 File Offset: 0x003F43D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C2E RID: 23598
		// (get) Token: 0x0601B3B3 RID: 111539 RVA: 0x003F61DA File Offset: 0x003F43DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TotalTopUpRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601B3B4 RID: 111540 RVA: 0x003F61E1 File Offset: 0x003F43E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardResponse()
		{
		}

		// Token: 0x0601B3B5 RID: 111541 RVA: 0x003F61E9 File Offset: 0x003F43E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardResponse(TotalTopUpRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B3B6 RID: 111542 RVA: 0x003F620E File Offset: 0x003F440E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardResponse Clone()
		{
			return new TotalTopUpRewardResponse(this);
		}

		// Token: 0x17005C2F RID: 23599
		// (get) Token: 0x0601B3B7 RID: 111543 RVA: 0x003F6216 File Offset: 0x003F4416
		// (set) Token: 0x0601B3B8 RID: 111544 RVA: 0x003F621E File Offset: 0x003F441E
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

		// Token: 0x0601B3B9 RID: 111545 RVA: 0x003F6227 File Offset: 0x003F4427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TotalTopUpRewardResponse);
		}

		// Token: 0x0601B3BA RID: 111546 RVA: 0x003F6235 File Offset: 0x003F4435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TotalTopUpRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B3BB RID: 111547 RVA: 0x003F6264 File Offset: 0x003F4464
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

		// Token: 0x0601B3BC RID: 111548 RVA: 0x003F62A9 File Offset: 0x003F44A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B3BD RID: 111549 RVA: 0x003F62B6 File Offset: 0x003F44B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B3BE RID: 111550 RVA: 0x003F62BF File Offset: 0x003F44BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B3BF RID: 111551 RVA: 0x003F62F4 File Offset: 0x003F44F4
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

		// Token: 0x0601B3C0 RID: 111552 RVA: 0x003F6332 File Offset: 0x003F4532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TotalTopUpRewardResponse other)
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

		// Token: 0x0601B3C1 RID: 111553 RVA: 0x003F6363 File Offset: 0x003F4563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B3C2 RID: 111554 RVA: 0x003F636C File Offset: 0x003F456C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009EBF RID: 40639
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EC0 RID: 40640
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04009EC1 RID: 40641
		private ErrorCode errorCode_;
	}
}
