using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C80 RID: 3200
	[NetMessage(EMessageId.PhantomBattleDiscardCardResponse)]
	public sealed class PhantomBattleDiscardCardResponse : IMessage<PhantomBattleDiscardCardResponse>, IMessage, IEquatable<PhantomBattleDiscardCardResponse>, IDeepCloneable<PhantomBattleDiscardCardResponse>, IBufferMessage
	{
		// Token: 0x06011578 RID: 71032 RVA: 0x00289E7D File Offset: 0x0028807D
		[NullableContext(1)]
		public static PhantomBattleDiscardCardResponse Create()
		{
			return new PhantomBattleDiscardCardResponse();
		}

		// Token: 0x17003962 RID: 14690
		// (get) Token: 0x06011579 RID: 71033 RVA: 0x00289E84 File Offset: 0x00288084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003963 RID: 14691
		// (get) Token: 0x0601157A RID: 71034 RVA: 0x00289E87 File Offset: 0x00288087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDiscardCardResponse.Descriptor;
			}
		}

		// Token: 0x0601157B RID: 71035 RVA: 0x00289E8E File Offset: 0x0028808E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDiscardCardResponse()
		{
		}

		// Token: 0x0601157C RID: 71036 RVA: 0x00289EA4 File Offset: 0x002880A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDiscardCardResponse(PhantomBattleDiscardCardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.discardCardIds_ = other.discardCardIds_.Clone();
			this.handCardNum_ = other.handCardNum_;
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601157D RID: 71037 RVA: 0x00289EFD File Offset: 0x002880FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDiscardCardResponse Clone()
		{
			return new PhantomBattleDiscardCardResponse(this);
		}

		// Token: 0x17003964 RID: 14692
		// (get) Token: 0x0601157E RID: 71038 RVA: 0x00289F05 File Offset: 0x00288105
		// (set) Token: 0x0601157F RID: 71039 RVA: 0x00289F0D File Offset: 0x0028810D
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

		// Token: 0x17003965 RID: 14693
		// (get) Token: 0x06011580 RID: 71040 RVA: 0x00289F16 File Offset: 0x00288116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DiscardCardIds
		{
			get
			{
				return this.discardCardIds_;
			}
		}

		// Token: 0x17003966 RID: 14694
		// (get) Token: 0x06011581 RID: 71041 RVA: 0x00289F1E File Offset: 0x0028811E
		// (set) Token: 0x06011582 RID: 71042 RVA: 0x00289F26 File Offset: 0x00288126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandCardNum
		{
			get
			{
				return this.handCardNum_;
			}
			set
			{
				this.handCardNum_ = value;
			}
		}

		// Token: 0x17003967 RID: 14695
		// (get) Token: 0x06011583 RID: 71043 RVA: 0x00289F2F File Offset: 0x0028812F
		// (set) Token: 0x06011584 RID: 71044 RVA: 0x00289F37 File Offset: 0x00288137
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

		// Token: 0x06011585 RID: 71045 RVA: 0x00289F40 File Offset: 0x00288140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDiscardCardResponse);
		}

		// Token: 0x06011586 RID: 71046 RVA: 0x00289F50 File Offset: 0x00288150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDiscardCardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.discardCardIds_.Equals(other.discardCardIds_) && this.HandCardNum == other.HandCardNum && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011587 RID: 71047 RVA: 0x00289FC0 File Offset: 0x002881C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.discardCardIds_.GetHashCode();
			if (this.HandCardNum != 0)
			{
				num ^= this.HandCardNum.GetHashCode();
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

		// Token: 0x06011588 RID: 71048 RVA: 0x0028A045 File Offset: 0x00288245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011589 RID: 71049 RVA: 0x0028A052 File Offset: 0x00288252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601158A RID: 71050 RVA: 0x0028A05C File Offset: 0x0028825C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CurCardLibraryNum);
			}
			this.discardCardIds_.WriteTo(ref output, PhantomBattleDiscardCardResponse._repeated_discardCardIds_codec);
			if (this.HandCardNum != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.HandCardNum);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601158B RID: 71051 RVA: 0x0028A0E4 File Offset: 0x002882E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.discardCardIds_.CalculateSize(PhantomBattleDiscardCardResponse._repeated_discardCardIds_codec);
			if (this.HandCardNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandCardNum);
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

		// Token: 0x0601158C RID: 71052 RVA: 0x0028A168 File Offset: 0x00288368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDiscardCardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.discardCardIds_.Add(other.discardCardIds_);
			if (other.HandCardNum != 0)
			{
				this.HandCardNum = other.HandCardNum;
			}
			if (other.CurCardLibraryNum != 0)
			{
				this.CurCardLibraryNum = other.CurCardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601158D RID: 71053 RVA: 0x0028A1DD File Offset: 0x002883DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601158E RID: 71054 RVA: 0x0028A1E8 File Offset: 0x002883E8
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
				if (num <= 56U)
				{
					if (num == 32U)
					{
						this.CurCardLibraryNum = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 58U)
					{
						goto IL_4B;
					}
					if (num == 104U)
					{
						this.HandCardNum = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.discardCardIds_.AddEntriesFrom(ref input, PhantomBattleDiscardCardResponse._repeated_discardCardIds_codec);
			}
		}

		// Token: 0x04006D96 RID: 28054
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D97 RID: 28055
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04006D98 RID: 28056
		private ErrorCode errorCode_;

		// Token: 0x04006D99 RID: 28057
		public const int DiscardCardIdsFieldNumber = 7;

		// Token: 0x04006D9A RID: 28058
		private static readonly FieldCodec<int> _repeated_discardCardIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04006D9B RID: 28059
		private readonly RepeatedField<int> discardCardIds_ = new RepeatedField<int>();

		// Token: 0x04006D9C RID: 28060
		public const int HandCardNumFieldNumber = 13;

		// Token: 0x04006D9D RID: 28061
		private int handCardNum_;

		// Token: 0x04006D9E RID: 28062
		public const int CurCardLibraryNumFieldNumber = 4;

		// Token: 0x04006D9F RID: 28063
		private int curCardLibraryNum_;
	}
}
