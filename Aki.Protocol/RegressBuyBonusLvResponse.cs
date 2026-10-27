using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EDD RID: 3805
	[NetMessage(EMessageId.RegressBuyBonusLvResponse)]
	public sealed class RegressBuyBonusLvResponse : IMessage<RegressBuyBonusLvResponse>, IMessage, IEquatable<RegressBuyBonusLvResponse>, IDeepCloneable<RegressBuyBonusLvResponse>, IBufferMessage
	{
		// Token: 0x06014648 RID: 83528 RVA: 0x002F6705 File Offset: 0x002F4905
		[NullableContext(1)]
		public static RegressBuyBonusLvResponse Create()
		{
			return new RegressBuyBonusLvResponse();
		}

		// Token: 0x170043CA RID: 17354
		// (get) Token: 0x06014649 RID: 83529 RVA: 0x002F670C File Offset: 0x002F490C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043CB RID: 17355
		// (get) Token: 0x0601464A RID: 83530 RVA: 0x002F670F File Offset: 0x002F490F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressBuyBonusLvResponse.Descriptor;
			}
		}

		// Token: 0x0601464B RID: 83531 RVA: 0x002F6716 File Offset: 0x002F4916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBuyBonusLvResponse()
		{
		}

		// Token: 0x0601464C RID: 83532 RVA: 0x002F671E File Offset: 0x002F491E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBuyBonusLvResponse(RegressBuyBonusLvResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.bonusNum_ = other.bonusNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601464D RID: 83533 RVA: 0x002F674F File Offset: 0x002F494F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBuyBonusLvResponse Clone()
		{
			return new RegressBuyBonusLvResponse(this);
		}

		// Token: 0x170043CC RID: 17356
		// (get) Token: 0x0601464E RID: 83534 RVA: 0x002F6757 File Offset: 0x002F4957
		// (set) Token: 0x0601464F RID: 83535 RVA: 0x002F675F File Offset: 0x002F495F
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

		// Token: 0x170043CD RID: 17357
		// (get) Token: 0x06014650 RID: 83536 RVA: 0x002F6768 File Offset: 0x002F4968
		// (set) Token: 0x06014651 RID: 83537 RVA: 0x002F6770 File Offset: 0x002F4970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BonusNum
		{
			get
			{
				return this.bonusNum_;
			}
			set
			{
				this.bonusNum_ = value;
			}
		}

		// Token: 0x06014652 RID: 83538 RVA: 0x002F6779 File Offset: 0x002F4979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressBuyBonusLvResponse);
		}

		// Token: 0x06014653 RID: 83539 RVA: 0x002F6787 File Offset: 0x002F4987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressBuyBonusLvResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.BonusNum == other.BonusNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014654 RID: 83540 RVA: 0x002F67C8 File Offset: 0x002F49C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.BonusNum != 0)
			{
				num ^= this.BonusNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014655 RID: 83541 RVA: 0x002F6826 File Offset: 0x002F4A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014656 RID: 83542 RVA: 0x002F6833 File Offset: 0x002F4A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014657 RID: 83543 RVA: 0x002F683C File Offset: 0x002F4A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.BonusNum != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BonusNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014658 RID: 83544 RVA: 0x002F6894 File Offset: 0x002F4A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.BonusNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BonusNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014659 RID: 83545 RVA: 0x002F68EC File Offset: 0x002F4AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressBuyBonusLvResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.BonusNum != 0)
			{
				this.BonusNum = other.BonusNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601465A RID: 83546 RVA: 0x002F693C File Offset: 0x002F4B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601465B RID: 83547 RVA: 0x002F6948 File Offset: 0x002F4B48
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
				if (num != 8U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BonusNum = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007BBE RID: 31678
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BBF RID: 31679
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04007BC0 RID: 31680
		private ErrorCode errorCode_;

		// Token: 0x04007BC1 RID: 31681
		public const int BonusNumFieldNumber = 3;

		// Token: 0x04007BC2 RID: 31682
		private int bonusNum_;
	}
}
