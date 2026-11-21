using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014BF RID: 5311
	[NetMessage(EMessageId.TrapDefenseSlotUpdateResponse)]
	public sealed class TrapDefenseSlotUpdateResponse : IMessage<TrapDefenseSlotUpdateResponse>, IMessage, IEquatable<TrapDefenseSlotUpdateResponse>, IDeepCloneable<TrapDefenseSlotUpdateResponse>, IBufferMessage
	{
		// Token: 0x0601C2DF RID: 115423 RVA: 0x004172F1 File Offset: 0x004154F1
		[NullableContext(1)]
		public static TrapDefenseSlotUpdateResponse Create()
		{
			return new TrapDefenseSlotUpdateResponse();
		}

		// Token: 0x17005F63 RID: 24419
		// (get) Token: 0x0601C2E0 RID: 115424 RVA: 0x004172F8 File Offset: 0x004154F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F64 RID: 24420
		// (get) Token: 0x0601C2E1 RID: 115425 RVA: 0x004172FB File Offset: 0x004154FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSlotUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0601C2E2 RID: 115426 RVA: 0x00417302 File Offset: 0x00415502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlotUpdateResponse()
		{
		}

		// Token: 0x0601C2E3 RID: 115427 RVA: 0x0041730A File Offset: 0x0041550A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlotUpdateResponse(TrapDefenseSlotUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C2E4 RID: 115428 RVA: 0x0041732F File Offset: 0x0041552F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlotUpdateResponse Clone()
		{
			return new TrapDefenseSlotUpdateResponse(this);
		}

		// Token: 0x17005F65 RID: 24421
		// (get) Token: 0x0601C2E5 RID: 115429 RVA: 0x00417337 File Offset: 0x00415537
		// (set) Token: 0x0601C2E6 RID: 115430 RVA: 0x0041733F File Offset: 0x0041553F
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

		// Token: 0x0601C2E7 RID: 115431 RVA: 0x00417348 File Offset: 0x00415548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSlotUpdateResponse);
		}

		// Token: 0x0601C2E8 RID: 115432 RVA: 0x00417356 File Offset: 0x00415556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSlotUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C2E9 RID: 115433 RVA: 0x00417384 File Offset: 0x00415584
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

		// Token: 0x0601C2EA RID: 115434 RVA: 0x004173C9 File Offset: 0x004155C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C2EB RID: 115435 RVA: 0x004173D6 File Offset: 0x004155D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C2EC RID: 115436 RVA: 0x004173DF File Offset: 0x004155DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C2ED RID: 115437 RVA: 0x00417414 File Offset: 0x00415614
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

		// Token: 0x0601C2EE RID: 115438 RVA: 0x00417452 File Offset: 0x00415652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseSlotUpdateResponse other)
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

		// Token: 0x0601C2EF RID: 115439 RVA: 0x00417483 File Offset: 0x00415683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C2F0 RID: 115440 RVA: 0x0041748C File Offset: 0x0041568C
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A301 RID: 41729
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A302 RID: 41730
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400A303 RID: 41731
		private ErrorCode errorCode_;
	}
}
