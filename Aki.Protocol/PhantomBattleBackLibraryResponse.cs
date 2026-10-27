using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C2C RID: 3116
	[NetMessage(EMessageId.PhantomBattleBackLibraryResponse)]
	public sealed class PhantomBattleBackLibraryResponse : IMessage<PhantomBattleBackLibraryResponse>, IMessage, IEquatable<PhantomBattleBackLibraryResponse>, IDeepCloneable<PhantomBattleBackLibraryResponse>, IBufferMessage
	{
		// Token: 0x06010E7A RID: 69242 RVA: 0x00279CB9 File Offset: 0x00277EB9
		[NullableContext(1)]
		public static PhantomBattleBackLibraryResponse Create()
		{
			return new PhantomBattleBackLibraryResponse();
		}

		// Token: 0x170037D3 RID: 14291
		// (get) Token: 0x06010E7B RID: 69243 RVA: 0x00279CC0 File Offset: 0x00277EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037D4 RID: 14292
		// (get) Token: 0x06010E7C RID: 69244 RVA: 0x00279CC3 File Offset: 0x00277EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBackLibraryResponse.Descriptor;
			}
		}

		// Token: 0x06010E7D RID: 69245 RVA: 0x00279CCA File Offset: 0x00277ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackLibraryResponse()
		{
		}

		// Token: 0x06010E7E RID: 69246 RVA: 0x00279CD2 File Offset: 0x00277ED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackLibraryResponse(PhantomBattleBackLibraryResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.cardUid_ = other.cardUid_;
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010E7F RID: 69247 RVA: 0x00279D0F File Offset: 0x00277F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackLibraryResponse Clone()
		{
			return new PhantomBattleBackLibraryResponse(this);
		}

		// Token: 0x170037D5 RID: 14293
		// (get) Token: 0x06010E80 RID: 69248 RVA: 0x00279D17 File Offset: 0x00277F17
		// (set) Token: 0x06010E81 RID: 69249 RVA: 0x00279D1F File Offset: 0x00277F1F
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

		// Token: 0x170037D6 RID: 14294
		// (get) Token: 0x06010E82 RID: 69250 RVA: 0x00279D28 File Offset: 0x00277F28
		// (set) Token: 0x06010E83 RID: 69251 RVA: 0x00279D30 File Offset: 0x00277F30
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

		// Token: 0x170037D7 RID: 14295
		// (get) Token: 0x06010E84 RID: 69252 RVA: 0x00279D39 File Offset: 0x00277F39
		// (set) Token: 0x06010E85 RID: 69253 RVA: 0x00279D41 File Offset: 0x00277F41
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

		// Token: 0x06010E86 RID: 69254 RVA: 0x00279D4A File Offset: 0x00277F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBackLibraryResponse);
		}

		// Token: 0x06010E87 RID: 69255 RVA: 0x00279D58 File Offset: 0x00277F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBackLibraryResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CardUid == other.CardUid && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010E88 RID: 69256 RVA: 0x00279DB4 File Offset: 0x00277FB4
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

		// Token: 0x06010E89 RID: 69257 RVA: 0x00279E2B File Offset: 0x0027802B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010E8A RID: 69258 RVA: 0x00279E38 File Offset: 0x00278038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010E8B RID: 69259 RVA: 0x00279E44 File Offset: 0x00278044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUid != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CardUid);
			}
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CurCardLibraryNum);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010E8C RID: 69260 RVA: 0x00279EBC File Offset: 0x002780BC
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

		// Token: 0x06010E8D RID: 69261 RVA: 0x00279F2C File Offset: 0x0027812C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBackLibraryResponse other)
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

		// Token: 0x06010E8E RID: 69262 RVA: 0x00279F90 File Offset: 0x00278190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010E8F RID: 69263 RVA: 0x00279F9C File Offset: 0x0027819C
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
					if (num != 56U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.CardUid = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006B48 RID: 27464
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B49 RID: 27465
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04006B4A RID: 27466
		private ErrorCode errorCode_;

		// Token: 0x04006B4B RID: 27467
		public const int CardUidFieldNumber = 3;

		// Token: 0x04006B4C RID: 27468
		private int cardUid_;

		// Token: 0x04006B4D RID: 27469
		public const int CurCardLibraryNumFieldNumber = 7;

		// Token: 0x04006B4E RID: 27470
		private int curCardLibraryNum_;
	}
}
