using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000672 RID: 1650
	[NetMessage(EMessageId.FsmStateBehaviorResponse)]
	public sealed class FsmStateBehaviorResponse : IMessage<FsmStateBehaviorResponse>, IMessage, IEquatable<FsmStateBehaviorResponse>, IDeepCloneable<FsmStateBehaviorResponse>, IBufferMessage
	{
		// Token: 0x0600974D RID: 38733 RVA: 0x0016CF55 File Offset: 0x0016B155
		[NullableContext(1)]
		public static FsmStateBehaviorResponse Create()
		{
			return new FsmStateBehaviorResponse();
		}

		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x0600974E RID: 38734 RVA: 0x0016CF5C File Offset: 0x0016B15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x0600974F RID: 38735 RVA: 0x0016CF5F File Offset: 0x0016B15F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmStateBehaviorResponse.Descriptor;
			}
		}

		// Token: 0x06009750 RID: 38736 RVA: 0x0016CF66 File Offset: 0x0016B166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateBehaviorResponse()
		{
		}

		// Token: 0x06009751 RID: 38737 RVA: 0x0016CF6E File Offset: 0x0016B16E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateBehaviorResponse(FsmStateBehaviorResponse other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.state_ = other.state_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009752 RID: 38738 RVA: 0x0016CFAB File Offset: 0x0016B1AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateBehaviorResponse Clone()
		{
			return new FsmStateBehaviorResponse(this);
		}

		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x06009753 RID: 38739 RVA: 0x0016CFB3 File Offset: 0x0016B1B3
		// (set) Token: 0x06009754 RID: 38740 RVA: 0x0016CFBB File Offset: 0x0016B1BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FsmId
		{
			get
			{
				return this.fsmId_;
			}
			set
			{
				this.fsmId_ = value;
			}
		}

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x06009755 RID: 38741 RVA: 0x0016CFC4 File Offset: 0x0016B1C4
		// (set) Token: 0x06009756 RID: 38742 RVA: 0x0016CFCC File Offset: 0x0016B1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x06009757 RID: 38743 RVA: 0x0016CFD5 File Offset: 0x0016B1D5
		// (set) Token: 0x06009758 RID: 38744 RVA: 0x0016CFDD File Offset: 0x0016B1DD
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

		// Token: 0x06009759 RID: 38745 RVA: 0x0016CFE6 File Offset: 0x0016B1E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmStateBehaviorResponse);
		}

		// Token: 0x0600975A RID: 38746 RVA: 0x0016CFF4 File Offset: 0x0016B1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmStateBehaviorResponse other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.State == other.State && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600975B RID: 38747 RVA: 0x0016D050 File Offset: 0x0016B250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FsmId != 0)
			{
				num ^= this.FsmId.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
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

		// Token: 0x0600975C RID: 38748 RVA: 0x0016D0C7 File Offset: 0x0016B2C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600975D RID: 38749 RVA: 0x0016D0D4 File Offset: 0x0016B2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600975E RID: 38750 RVA: 0x0016D0E0 File Offset: 0x0016B2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FsmId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FsmId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600975F RID: 38751 RVA: 0x0016D158 File Offset: 0x0016B358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FsmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FsmId);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
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

		// Token: 0x06009760 RID: 38752 RVA: 0x0016D1C8 File Offset: 0x0016B3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmStateBehaviorResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FsmId != 0)
			{
				this.FsmId = other.FsmId;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009761 RID: 38753 RVA: 0x0016D22C File Offset: 0x0016B42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009762 RID: 38754 RVA: 0x0016D238 File Offset: 0x0016B438
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
				if (num != 32U)
				{
					if (num != 56U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.State = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.FsmId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040047F3 RID: 18419
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047F4 RID: 18420
		public const int FsmIdFieldNumber = 4;

		// Token: 0x040047F5 RID: 18421
		private int fsmId_;

		// Token: 0x040047F6 RID: 18422
		public const int StateFieldNumber = 12;

		// Token: 0x040047F7 RID: 18423
		private int state_;

		// Token: 0x040047F8 RID: 18424
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040047F9 RID: 18425
		private ErrorCode errorCode_;
	}
}
