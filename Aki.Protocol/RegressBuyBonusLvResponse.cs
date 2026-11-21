using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ECD RID: 3789
	[NetMessage(EMessageId.RegressBuyBonusLvResponse)]
	public sealed class RegressBuyBonusLvResponse : IMessage<RegressBuyBonusLvResponse>, IMessage, IEquatable<RegressBuyBonusLvResponse>, IDeepCloneable<RegressBuyBonusLvResponse>, IBufferMessage
	{
		// Token: 0x06014563 RID: 83299 RVA: 0x002F5051 File Offset: 0x002F3251
		[NullableContext(1)]
		public static RegressBuyBonusLvResponse Create()
		{
			return new RegressBuyBonusLvResponse();
		}

		// Token: 0x170043A0 RID: 17312
		// (get) Token: 0x06014564 RID: 83300 RVA: 0x002F5058 File Offset: 0x002F3258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043A1 RID: 17313
		// (get) Token: 0x06014565 RID: 83301 RVA: 0x002F505B File Offset: 0x002F325B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressBuyBonusLvResponse.Descriptor;
			}
		}

		// Token: 0x06014566 RID: 83302 RVA: 0x002F5062 File Offset: 0x002F3262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBuyBonusLvResponse()
		{
		}

		// Token: 0x06014567 RID: 83303 RVA: 0x002F506A File Offset: 0x002F326A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBuyBonusLvResponse(RegressBuyBonusLvResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.bonusNum_ = other.bonusNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014568 RID: 83304 RVA: 0x002F509B File Offset: 0x002F329B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBuyBonusLvResponse Clone()
		{
			return new RegressBuyBonusLvResponse(this);
		}

		// Token: 0x170043A2 RID: 17314
		// (get) Token: 0x06014569 RID: 83305 RVA: 0x002F50A3 File Offset: 0x002F32A3
		// (set) Token: 0x0601456A RID: 83306 RVA: 0x002F50AB File Offset: 0x002F32AB
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

		// Token: 0x170043A3 RID: 17315
		// (get) Token: 0x0601456B RID: 83307 RVA: 0x002F50B4 File Offset: 0x002F32B4
		// (set) Token: 0x0601456C RID: 83308 RVA: 0x002F50BC File Offset: 0x002F32BC
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

		// Token: 0x0601456D RID: 83309 RVA: 0x002F50C5 File Offset: 0x002F32C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressBuyBonusLvResponse);
		}

		// Token: 0x0601456E RID: 83310 RVA: 0x002F50D3 File Offset: 0x002F32D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressBuyBonusLvResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.BonusNum == other.BonusNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601456F RID: 83311 RVA: 0x002F5114 File Offset: 0x002F3314
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

		// Token: 0x06014570 RID: 83312 RVA: 0x002F5172 File Offset: 0x002F3372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014571 RID: 83313 RVA: 0x002F517F File Offset: 0x002F337F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014572 RID: 83314 RVA: 0x002F5188 File Offset: 0x002F3388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.BonusNum != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.BonusNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014573 RID: 83315 RVA: 0x002F51E4 File Offset: 0x002F33E4
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

		// Token: 0x06014574 RID: 83316 RVA: 0x002F523C File Offset: 0x002F343C
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

		// Token: 0x06014575 RID: 83317 RVA: 0x002F528C File Offset: 0x002F348C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014576 RID: 83318 RVA: 0x002F5298 File Offset: 0x002F3498
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
				if (num != 88U)
				{
					if (num != 104U)
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

		// Token: 0x04007BE8 RID: 31720
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BE9 RID: 31721
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04007BEA RID: 31722
		private ErrorCode errorCode_;

		// Token: 0x04007BEB RID: 31723
		public const int BonusNumFieldNumber = 13;

		// Token: 0x04007BEC RID: 31724
		private int bonusNum_;
	}
}
