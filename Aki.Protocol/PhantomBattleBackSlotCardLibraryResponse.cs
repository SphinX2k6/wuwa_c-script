using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C1E RID: 3102
	[NetMessage(EMessageId.PhantomBattleBackSlotCardLibraryResponse)]
	public sealed class PhantomBattleBackSlotCardLibraryResponse : IMessage<PhantomBattleBackSlotCardLibraryResponse>, IMessage, IEquatable<PhantomBattleBackSlotCardLibraryResponse>, IDeepCloneable<PhantomBattleBackSlotCardLibraryResponse>, IBufferMessage
	{
		// Token: 0x06010DA2 RID: 69026 RVA: 0x0027847D File Offset: 0x0027667D
		[NullableContext(1)]
		public static PhantomBattleBackSlotCardLibraryResponse Create()
		{
			return new PhantomBattleBackSlotCardLibraryResponse();
		}

		// Token: 0x170037A4 RID: 14244
		// (get) Token: 0x06010DA3 RID: 69027 RVA: 0x00278484 File Offset: 0x00276684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037A5 RID: 14245
		// (get) Token: 0x06010DA4 RID: 69028 RVA: 0x00278487 File Offset: 0x00276687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBackSlotCardLibraryResponse.Descriptor;
			}
		}

		// Token: 0x06010DA5 RID: 69029 RVA: 0x0027848E File Offset: 0x0027668E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackSlotCardLibraryResponse()
		{
		}

		// Token: 0x06010DA6 RID: 69030 RVA: 0x00278496 File Offset: 0x00276696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackSlotCardLibraryResponse(PhantomBattleBackSlotCardLibraryResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.cardUid_ = other.cardUid_;
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010DA7 RID: 69031 RVA: 0x002784D3 File Offset: 0x002766D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackSlotCardLibraryResponse Clone()
		{
			return new PhantomBattleBackSlotCardLibraryResponse(this);
		}

		// Token: 0x170037A6 RID: 14246
		// (get) Token: 0x06010DA8 RID: 69032 RVA: 0x002784DB File Offset: 0x002766DB
		// (set) Token: 0x06010DA9 RID: 69033 RVA: 0x002784E3 File Offset: 0x002766E3
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

		// Token: 0x170037A7 RID: 14247
		// (get) Token: 0x06010DAA RID: 69034 RVA: 0x002784EC File Offset: 0x002766EC
		// (set) Token: 0x06010DAB RID: 69035 RVA: 0x002784F4 File Offset: 0x002766F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUid
		{
			get
			{
				return this.cardUid_;
			}
			set
			{
				this.cardUid_ = value;
			}
		}

		// Token: 0x170037A8 RID: 14248
		// (get) Token: 0x06010DAC RID: 69036 RVA: 0x002784FD File Offset: 0x002766FD
		// (set) Token: 0x06010DAD RID: 69037 RVA: 0x00278505 File Offset: 0x00276705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCardLibraryNum
		{
			get
			{
				return this.curCardLibraryNum_;
			}
			set
			{
				this.curCardLibraryNum_ = value;
			}
		}

		// Token: 0x06010DAE RID: 69038 RVA: 0x0027850E File Offset: 0x0027670E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBackSlotCardLibraryResponse);
		}

		// Token: 0x06010DAF RID: 69039 RVA: 0x0027851C File Offset: 0x0027671C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBackSlotCardLibraryResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CardUid == other.CardUid && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010DB0 RID: 69040 RVA: 0x00278578 File Offset: 0x00276778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.CardUid != 0)
			{
				num ^= this.CardUid.GetHashCode();
			}
			if (this.CurCardLibraryNum != 0)
			{
				num ^= this.CurCardLibraryNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010DB1 RID: 69041 RVA: 0x002785EF File Offset: 0x002767EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010DB2 RID: 69042 RVA: 0x002785FC File Offset: 0x002767FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010DB3 RID: 69043 RVA: 0x00278608 File Offset: 0x00276808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CurCardLibraryNum);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CardUid != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.CardUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010DB4 RID: 69044 RVA: 0x00278680 File Offset: 0x00276880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.CardUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUid);
			}
			if (this.CurCardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurCardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010DB5 RID: 69045 RVA: 0x002786F0 File Offset: 0x002768F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBackSlotCardLibraryResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.CardUid != 0)
			{
				this.CardUid = other.CardUid;
			}
			if (other.CurCardLibraryNum != 0)
			{
				this.CurCardLibraryNum = other.CurCardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010DB6 RID: 69046 RVA: 0x00278754 File Offset: 0x00276954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010DB7 RID: 69047 RVA: 0x00278760 File Offset: 0x00276960
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
					if (num != 40U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CardUid = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.CurCardLibraryNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006B66 RID: 27494
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B67 RID: 27495
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04006B68 RID: 27496
		private ErrorCode errorCode_;

		// Token: 0x04006B69 RID: 27497
		public const int CardUidFieldNumber = 13;

		// Token: 0x04006B6A RID: 27498
		private int cardUid_;

		// Token: 0x04006B6B RID: 27499
		public const int CurCardLibraryNumFieldNumber = 4;

		// Token: 0x04006B6C RID: 27500
		private int curCardLibraryNum_;
	}
}
