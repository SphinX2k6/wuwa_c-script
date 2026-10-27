using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C8 RID: 4552
	[NetMessage(EMessageId.SetAlertUiVisibleResponse)]
	public sealed class SetAlertUiVisibleResponse : IMessage<SetAlertUiVisibleResponse>, IMessage, IEquatable<SetAlertUiVisibleResponse>, IDeepCloneable<SetAlertUiVisibleResponse>, IBufferMessage
	{
		// Token: 0x06018488 RID: 99464 RVA: 0x00388BE0 File Offset: 0x00386DE0
		[NullableContext(1)]
		public static SetAlertUiVisibleResponse Create()
		{
			return new SetAlertUiVisibleResponse();
		}

		// Token: 0x170051CB RID: 20939
		// (get) Token: 0x06018489 RID: 99465 RVA: 0x00388BE7 File Offset: 0x00386DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051CC RID: 20940
		// (get) Token: 0x0601848A RID: 99466 RVA: 0x00388BEA File Offset: 0x00386DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetAlertUiVisibleResponse.Descriptor;
			}
		}

		// Token: 0x0601848B RID: 99467 RVA: 0x00388BF1 File Offset: 0x00386DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAlertUiVisibleResponse()
		{
		}

		// Token: 0x0601848C RID: 99468 RVA: 0x00388BF9 File Offset: 0x00386DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAlertUiVisibleResponse(SetAlertUiVisibleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601848D RID: 99469 RVA: 0x00388C1E File Offset: 0x00386E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAlertUiVisibleResponse Clone()
		{
			return new SetAlertUiVisibleResponse(this);
		}

		// Token: 0x170051CD RID: 20941
		// (get) Token: 0x0601848E RID: 99470 RVA: 0x00388C26 File Offset: 0x00386E26
		// (set) Token: 0x0601848F RID: 99471 RVA: 0x00388C2E File Offset: 0x00386E2E
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

		// Token: 0x06018490 RID: 99472 RVA: 0x00388C37 File Offset: 0x00386E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetAlertUiVisibleResponse);
		}

		// Token: 0x06018491 RID: 99473 RVA: 0x00388C45 File Offset: 0x00386E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetAlertUiVisibleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018492 RID: 99474 RVA: 0x00388C74 File Offset: 0x00386E74
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

		// Token: 0x06018493 RID: 99475 RVA: 0x00388CB9 File Offset: 0x00386EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018494 RID: 99476 RVA: 0x00388CC6 File Offset: 0x00386EC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018495 RID: 99477 RVA: 0x00388CCF File Offset: 0x00386ECF
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

		// Token: 0x06018496 RID: 99478 RVA: 0x00388D04 File Offset: 0x00386F04
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

		// Token: 0x06018497 RID: 99479 RVA: 0x00388D42 File Offset: 0x00386F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetAlertUiVisibleResponse other)
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

		// Token: 0x06018498 RID: 99480 RVA: 0x00388D73 File Offset: 0x00386F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018499 RID: 99481 RVA: 0x00388D7C File Offset: 0x00386F7C
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

		// Token: 0x04008FE0 RID: 36832
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FE1 RID: 36833
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04008FE2 RID: 36834
		private ErrorCode errorCode_;
	}
}
