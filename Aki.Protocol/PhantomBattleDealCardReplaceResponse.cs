using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C63 RID: 3171
	[NetMessage(EMessageId.PhantomBattleDealCardReplaceResponse)]
	public sealed class PhantomBattleDealCardReplaceResponse : IMessage<PhantomBattleDealCardReplaceResponse>, IMessage, IEquatable<PhantomBattleDealCardReplaceResponse>, IDeepCloneable<PhantomBattleDealCardReplaceResponse>, IBufferMessage
	{
		// Token: 0x0601136A RID: 70506 RVA: 0x00285ABD File Offset: 0x00283CBD
		[NullableContext(1)]
		public static PhantomBattleDealCardReplaceResponse Create()
		{
			return new PhantomBattleDealCardReplaceResponse();
		}

		// Token: 0x170038EF RID: 14575
		// (get) Token: 0x0601136B RID: 70507 RVA: 0x00285AC4 File Offset: 0x00283CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038F0 RID: 14576
		// (get) Token: 0x0601136C RID: 70508 RVA: 0x00285AC7 File Offset: 0x00283CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDealCardReplaceResponse.Descriptor;
			}
		}

		// Token: 0x0601136D RID: 70509 RVA: 0x00285ACE File Offset: 0x00283CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardReplaceResponse()
		{
		}

		// Token: 0x0601136E RID: 70510 RVA: 0x00285AE4 File Offset: 0x00283CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardReplaceResponse(PhantomBattleDealCardReplaceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleHandCardInfos_ = other.phantomBattleHandCardInfos_.Clone();
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601136F RID: 70511 RVA: 0x00285B31 File Offset: 0x00283D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardReplaceResponse Clone()
		{
			return new PhantomBattleDealCardReplaceResponse(this);
		}

		// Token: 0x170038F1 RID: 14577
		// (get) Token: 0x06011370 RID: 70512 RVA: 0x00285B39 File Offset: 0x00283D39
		// (set) Token: 0x06011371 RID: 70513 RVA: 0x00285B41 File Offset: 0x00283D41
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

		// Token: 0x170038F2 RID: 14578
		// (get) Token: 0x06011372 RID: 70514 RVA: 0x00285B4A File Offset: 0x00283D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfos
		{
			get
			{
				return this.phantomBattleHandCardInfos_;
			}
		}

		// Token: 0x170038F3 RID: 14579
		// (get) Token: 0x06011373 RID: 70515 RVA: 0x00285B52 File Offset: 0x00283D52
		// (set) Token: 0x06011374 RID: 70516 RVA: 0x00285B5A File Offset: 0x00283D5A
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

		// Token: 0x06011375 RID: 70517 RVA: 0x00285B63 File Offset: 0x00283D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDealCardReplaceResponse);
		}

		// Token: 0x06011376 RID: 70518 RVA: 0x00285B74 File Offset: 0x00283D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDealCardReplaceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomBattleHandCardInfos_.Equals(other.phantomBattleHandCardInfos_) && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011377 RID: 70519 RVA: 0x00285BD4 File Offset: 0x00283DD4
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

		// Token: 0x06011378 RID: 70520 RVA: 0x00285C40 File Offset: 0x00283E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011379 RID: 70521 RVA: 0x00285C4D File Offset: 0x00283E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601137A RID: 70522 RVA: 0x00285C58 File Offset: 0x00283E58
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
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.phantomBattleHandCardInfos_.WriteTo(ref output, PhantomBattleDealCardReplaceResponse._repeated_phantomBattleHandCardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601137B RID: 70523 RVA: 0x00285CC4 File Offset: 0x00283EC4
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

		// Token: 0x0601137C RID: 70524 RVA: 0x00285D30 File Offset: 0x00283F30
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

		// Token: 0x0601137D RID: 70525 RVA: 0x00285D91 File Offset: 0x00283F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601137E RID: 70526 RVA: 0x00285D9C File Offset: 0x00283F9C
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
					if (num != 72U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.phantomBattleHandCardInfos_.AddEntriesFrom(ref input, PhantomBattleDealCardReplaceResponse._repeated_phantomBattleHandCardInfos_codec);
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

		// Token: 0x04006D52 RID: 27986
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D53 RID: 27987
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04006D54 RID: 27988
		private ErrorCode errorCode_;

		// Token: 0x04006D55 RID: 27989
		public const int PhantomBattleHandCardInfosFieldNumber = 15;

		// Token: 0x04006D56 RID: 27990
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(122U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006D57 RID: 27991
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006D58 RID: 27992
		public const int CurCardLibraryNumFieldNumber = 4;

		// Token: 0x04006D59 RID: 27993
		private int curCardLibraryNum_;
	}
}
