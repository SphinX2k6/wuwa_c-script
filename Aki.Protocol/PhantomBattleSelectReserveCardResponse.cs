using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB1 RID: 3249
	[NetMessage(EMessageId.PhantomBattleSelectReserveCardResponse)]
	public sealed class PhantomBattleSelectReserveCardResponse : IMessage<PhantomBattleSelectReserveCardResponse>, IMessage, IEquatable<PhantomBattleSelectReserveCardResponse>, IDeepCloneable<PhantomBattleSelectReserveCardResponse>, IBufferMessage
	{
		// Token: 0x06011994 RID: 72084 RVA: 0x00293B41 File Offset: 0x00291D41
		[NullableContext(1)]
		public static PhantomBattleSelectReserveCardResponse Create()
		{
			return new PhantomBattleSelectReserveCardResponse();
		}

		// Token: 0x17003A4C RID: 14924
		// (get) Token: 0x06011995 RID: 72085 RVA: 0x00293B48 File Offset: 0x00291D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A4D RID: 14925
		// (get) Token: 0x06011996 RID: 72086 RVA: 0x00293B4B File Offset: 0x00291D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSelectReserveCardResponse.Descriptor;
			}
		}

		// Token: 0x06011997 RID: 72087 RVA: 0x00293B52 File Offset: 0x00291D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectReserveCardResponse()
		{
		}

		// Token: 0x06011998 RID: 72088 RVA: 0x00293B68 File Offset: 0x00291D68
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

		// Token: 0x06011999 RID: 72089 RVA: 0x00293BC1 File Offset: 0x00291DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectReserveCardResponse Clone()
		{
			return new PhantomBattleSelectReserveCardResponse(this);
		}

		// Token: 0x17003A4E RID: 14926
		// (get) Token: 0x0601199A RID: 72090 RVA: 0x00293BC9 File Offset: 0x00291DC9
		// (set) Token: 0x0601199B RID: 72091 RVA: 0x00293BD1 File Offset: 0x00291DD1
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

		// Token: 0x17003A4F RID: 14927
		// (get) Token: 0x0601199C RID: 72092 RVA: 0x00293BDA File Offset: 0x00291DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReserveCardUIds
		{
			get
			{
				return this.reserveCardUIds_;
			}
		}

		// Token: 0x17003A50 RID: 14928
		// (get) Token: 0x0601199D RID: 72093 RVA: 0x00293BE2 File Offset: 0x00291DE2
		// (set) Token: 0x0601199E RID: 72094 RVA: 0x00293BEA File Offset: 0x00291DEA
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

		// Token: 0x17003A51 RID: 14929
		// (get) Token: 0x0601199F RID: 72095 RVA: 0x00293BF3 File Offset: 0x00291DF3
		// (set) Token: 0x060119A0 RID: 72096 RVA: 0x00293BFB File Offset: 0x00291DFB
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

		// Token: 0x060119A1 RID: 72097 RVA: 0x00293C04 File Offset: 0x00291E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSelectReserveCardResponse);
		}

		// Token: 0x060119A2 RID: 72098 RVA: 0x00293C14 File Offset: 0x00291E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSelectReserveCardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.reserveCardUIds_.Equals(other.reserveCardUIds_) && this.HandCardNum == other.HandCardNum && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060119A3 RID: 72099 RVA: 0x00293C84 File Offset: 0x00291E84
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

		// Token: 0x060119A4 RID: 72100 RVA: 0x00293D09 File Offset: 0x00291F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060119A5 RID: 72101 RVA: 0x00293D16 File Offset: 0x00291F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060119A6 RID: 72102 RVA: 0x00293D20 File Offset: 0x00291F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurCardLibraryNum);
			}
			this.reserveCardUIds_.WriteTo(ref output, PhantomBattleSelectReserveCardResponse._repeated_reserveCardUIds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.HandCardNum != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.HandCardNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060119A7 RID: 72103 RVA: 0x00293DA8 File Offset: 0x00291FA8
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

		// Token: 0x060119A8 RID: 72104 RVA: 0x00293E2C File Offset: 0x0029202C
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

		// Token: 0x060119A9 RID: 72105 RVA: 0x00293EA1 File Offset: 0x002920A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060119AA RID: 72106 RVA: 0x00293EAC File Offset: 0x002920AC
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.CurCardLibraryNum = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 26U)
					{
						goto IL_4A;
					}
					if (num == 88U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.HandCardNum = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.reserveCardUIds_.AddEntriesFrom(ref input, PhantomBattleSelectReserveCardResponse._repeated_reserveCardUIds_codec);
			}
		}

		// Token: 0x04006ED7 RID: 28375
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006ED8 RID: 28376
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04006ED9 RID: 28377
		private ErrorCode errorCode_;

		// Token: 0x04006EDA RID: 28378
		public const int ReserveCardUIdsFieldNumber = 3;

		// Token: 0x04006EDB RID: 28379
		private static readonly FieldCodec<int> _repeated_reserveCardUIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006EDC RID: 28380
		private readonly RepeatedField<int> reserveCardUIds_ = new RepeatedField<int>();

		// Token: 0x04006EDD RID: 28381
		public const int HandCardNumFieldNumber = 14;

		// Token: 0x04006EDE RID: 28382
		private int handCardNum_;

		// Token: 0x04006EDF RID: 28383
		public const int CurCardLibraryNumFieldNumber = 1;

		// Token: 0x04006EE0 RID: 28384
		private int curCardLibraryNum_;
	}
}
