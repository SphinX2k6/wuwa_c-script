using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C73 RID: 3187
	[NetMessage(EMessageId.PhantomBattleDealCardReplaceResponse)]
	public sealed class PhantomBattleDealCardReplaceResponse : IMessage<PhantomBattleDealCardReplaceResponse>, IMessage, IEquatable<PhantomBattleDealCardReplaceResponse>, IDeepCloneable<PhantomBattleDealCardReplaceResponse>, IBufferMessage
	{
		// Token: 0x0601146A RID: 70762 RVA: 0x0028782D File Offset: 0x00285A2D
		[NullableContext(1)]
		public static PhantomBattleDealCardReplaceResponse Create()
		{
			return new PhantomBattleDealCardReplaceResponse();
		}

		// Token: 0x17003926 RID: 14630
		// (get) Token: 0x0601146B RID: 70763 RVA: 0x00287834 File Offset: 0x00285A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003927 RID: 14631
		// (get) Token: 0x0601146C RID: 70764 RVA: 0x00287837 File Offset: 0x00285A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDealCardReplaceResponse.Descriptor;
			}
		}

		// Token: 0x0601146D RID: 70765 RVA: 0x0028783E File Offset: 0x00285A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardReplaceResponse()
		{
		}

		// Token: 0x0601146E RID: 70766 RVA: 0x00287854 File Offset: 0x00285A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardReplaceResponse(PhantomBattleDealCardReplaceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleHandCardInfos_ = other.phantomBattleHandCardInfos_.Clone();
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601146F RID: 70767 RVA: 0x002878A1 File Offset: 0x00285AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardReplaceResponse Clone()
		{
			return new PhantomBattleDealCardReplaceResponse(this);
		}

		// Token: 0x17003928 RID: 14632
		// (get) Token: 0x06011470 RID: 70768 RVA: 0x002878A9 File Offset: 0x00285AA9
		// (set) Token: 0x06011471 RID: 70769 RVA: 0x002878B1 File Offset: 0x00285AB1
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

		// Token: 0x17003929 RID: 14633
		// (get) Token: 0x06011472 RID: 70770 RVA: 0x002878BA File Offset: 0x00285ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfos
		{
			get
			{
				return this.phantomBattleHandCardInfos_;
			}
		}

		// Token: 0x1700392A RID: 14634
		// (get) Token: 0x06011473 RID: 70771 RVA: 0x002878C2 File Offset: 0x00285AC2
		// (set) Token: 0x06011474 RID: 70772 RVA: 0x002878CA File Offset: 0x00285ACA
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

		// Token: 0x06011475 RID: 70773 RVA: 0x002878D3 File Offset: 0x00285AD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDealCardReplaceResponse);
		}

		// Token: 0x06011476 RID: 70774 RVA: 0x002878E4 File Offset: 0x00285AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDealCardReplaceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomBattleHandCardInfos_.Equals(other.phantomBattleHandCardInfos_) && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011477 RID: 70775 RVA: 0x00287944 File Offset: 0x00285B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.phantomBattleHandCardInfos_.GetHashCode();
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

		// Token: 0x06011478 RID: 70776 RVA: 0x002879B0 File Offset: 0x00285BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011479 RID: 70777 RVA: 0x002879BD File Offset: 0x00285BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601147A RID: 70778 RVA: 0x002879C8 File Offset: 0x00285BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleHandCardInfos_.WriteTo(ref output, PhantomBattleDealCardReplaceResponse._repeated_phantomBattleHandCardInfos_codec);
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.CurCardLibraryNum);
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

		// Token: 0x0601147B RID: 70779 RVA: 0x00287A34 File Offset: 0x00285C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.phantomBattleHandCardInfos_.CalculateSize(PhantomBattleDealCardReplaceResponse._repeated_phantomBattleHandCardInfos_codec);
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

		// Token: 0x0601147C RID: 70780 RVA: 0x00287AA0 File Offset: 0x00285CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDealCardReplaceResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.phantomBattleHandCardInfos_.Add(other.phantomBattleHandCardInfos_);
			if (other.CurCardLibraryNum != 0)
			{
				this.CurCardLibraryNum = other.CurCardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601147D RID: 70781 RVA: 0x00287B01 File Offset: 0x00285D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601147E RID: 70782 RVA: 0x00287B0C File Offset: 0x00285D0C
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
				if (num != 42U)
				{
					if (num != 88U)
					{
						if (num != 112U)
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
					this.phantomBattleHandCardInfos_.AddEntriesFrom(ref input, PhantomBattleDealCardReplaceResponse._repeated_phantomBattleHandCardInfos_codec);
				}
			}
		}

		// Token: 0x04006D3E RID: 27966
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D3F RID: 27967
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04006D40 RID: 27968
		private ErrorCode errorCode_;

		// Token: 0x04006D41 RID: 27969
		public const int PhantomBattleHandCardInfosFieldNumber = 5;

		// Token: 0x04006D42 RID: 27970
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(42U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006D43 RID: 27971
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006D44 RID: 27972
		public const int CurCardLibraryNumFieldNumber = 11;

		// Token: 0x04006D45 RID: 27973
		private int curCardLibraryNum_;
	}
}
