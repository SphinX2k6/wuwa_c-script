using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA1 RID: 3233
	[NetMessage(EMessageId.PhantomBattleSelectReserveCardResponse)]
	public sealed class PhantomBattleSelectReserveCardResponse : IMessage<PhantomBattleSelectReserveCardResponse>, IMessage, IEquatable<PhantomBattleSelectReserveCardResponse>, IDeepCloneable<PhantomBattleSelectReserveCardResponse>, IBufferMessage
	{
		// Token: 0x06011894 RID: 71828 RVA: 0x00291DD5 File Offset: 0x0028FFD5
		[NullableContext(1)]
		public static PhantomBattleSelectReserveCardResponse Create()
		{
			return new PhantomBattleSelectReserveCardResponse();
		}

		// Token: 0x17003A15 RID: 14869
		// (get) Token: 0x06011895 RID: 71829 RVA: 0x00291DDC File Offset: 0x0028FFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A16 RID: 14870
		// (get) Token: 0x06011896 RID: 71830 RVA: 0x00291DDF File Offset: 0x0028FFDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSelectReserveCardResponse.Descriptor;
			}
		}

		// Token: 0x06011897 RID: 71831 RVA: 0x00291DE6 File Offset: 0x0028FFE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectReserveCardResponse()
		{
		}

		// Token: 0x06011898 RID: 71832 RVA: 0x00291DFC File Offset: 0x0028FFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectReserveCardResponse(PhantomBattleSelectReserveCardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.reserveCardUIds_ = other.reserveCardUIds_.Clone();
			this.handCardNum_ = other.handCardNum_;
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011899 RID: 71833 RVA: 0x00291E55 File Offset: 0x00290055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectReserveCardResponse Clone()
		{
			return new PhantomBattleSelectReserveCardResponse(this);
		}

		// Token: 0x17003A17 RID: 14871
		// (get) Token: 0x0601189A RID: 71834 RVA: 0x00291E5D File Offset: 0x0029005D
		// (set) Token: 0x0601189B RID: 71835 RVA: 0x00291E65 File Offset: 0x00290065
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

		// Token: 0x17003A18 RID: 14872
		// (get) Token: 0x0601189C RID: 71836 RVA: 0x00291E6E File Offset: 0x0029006E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReserveCardUIds
		{
			get
			{
				return this.reserveCardUIds_;
			}
		}

		// Token: 0x17003A19 RID: 14873
		// (get) Token: 0x0601189D RID: 71837 RVA: 0x00291E76 File Offset: 0x00290076
		// (set) Token: 0x0601189E RID: 71838 RVA: 0x00291E7E File Offset: 0x0029007E
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

		// Token: 0x17003A1A RID: 14874
		// (get) Token: 0x0601189F RID: 71839 RVA: 0x00291E87 File Offset: 0x00290087
		// (set) Token: 0x060118A0 RID: 71840 RVA: 0x00291E8F File Offset: 0x0029008F
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

		// Token: 0x060118A1 RID: 71841 RVA: 0x00291E98 File Offset: 0x00290098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSelectReserveCardResponse);
		}

		// Token: 0x060118A2 RID: 71842 RVA: 0x00291EA8 File Offset: 0x002900A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSelectReserveCardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.reserveCardUIds_.Equals(other.reserveCardUIds_) && this.HandCardNum == other.HandCardNum && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060118A3 RID: 71843 RVA: 0x00291F18 File Offset: 0x00290118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.reserveCardUIds_.GetHashCode();
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

		// Token: 0x060118A4 RID: 71844 RVA: 0x00291F9D File Offset: 0x0029019D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060118A5 RID: 71845 RVA: 0x00291FAA File Offset: 0x002901AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060118A6 RID: 71846 RVA: 0x00291FB4 File Offset: 0x002901B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.reserveCardUIds_.WriteTo(ref output, PhantomBattleSelectReserveCardResponse._repeated_reserveCardUIds_codec);
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CurCardLibraryNum);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.HandCardNum != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.HandCardNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060118A7 RID: 71847 RVA: 0x0029203C File Offset: 0x0029023C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.reserveCardUIds_.CalculateSize(PhantomBattleSelectReserveCardResponse._repeated_reserveCardUIds_codec);
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

		// Token: 0x060118A8 RID: 71848 RVA: 0x002920C0 File Offset: 0x002902C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSelectReserveCardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.reserveCardUIds_.Add(other.reserveCardUIds_);
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

		// Token: 0x060118A9 RID: 71849 RVA: 0x00292135 File Offset: 0x00290335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060118AA RID: 71850 RVA: 0x00292140 File Offset: 0x00290340
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
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.reserveCardUIds_.AddEntriesFrom(ref input, PhantomBattleSelectReserveCardResponse._repeated_reserveCardUIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.CurCardLibraryNum = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						this.HandCardNum = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006EEB RID: 28395
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EEC RID: 28396
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04006EED RID: 28397
		private ErrorCode errorCode_;

		// Token: 0x04006EEE RID: 28398
		public const int ReserveCardUIdsFieldNumber = 2;

		// Token: 0x04006EEF RID: 28399
		private static readonly FieldCodec<int> _repeated_reserveCardUIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006EF0 RID: 28400
		private readonly RepeatedField<int> reserveCardUIds_ = new RepeatedField<int>();

		// Token: 0x04006EF1 RID: 28401
		public const int HandCardNumFieldNumber = 12;

		// Token: 0x04006EF2 RID: 28402
		private int handCardNum_;

		// Token: 0x04006EF3 RID: 28403
		public const int CurCardLibraryNumFieldNumber = 7;

		// Token: 0x04006EF4 RID: 28404
		private int curCardLibraryNum_;
	}
}
