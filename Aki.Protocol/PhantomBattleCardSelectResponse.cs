using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C61 RID: 3169
	[NetMessage(EMessageId.PhantomBattleCardSelectResponse)]
	public sealed class PhantomBattleCardSelectResponse : IMessage<PhantomBattleCardSelectResponse>, IMessage, IEquatable<PhantomBattleCardSelectResponse>, IDeepCloneable<PhantomBattleCardSelectResponse>, IBufferMessage
	{
		// Token: 0x060112D6 RID: 70358 RVA: 0x00283AF4 File Offset: 0x00281CF4
		[NullableContext(1)]
		public static PhantomBattleCardSelectResponse Create()
		{
			return new PhantomBattleCardSelectResponse();
		}

		// Token: 0x170038C7 RID: 14535
		// (get) Token: 0x060112D7 RID: 70359 RVA: 0x00283AFB File Offset: 0x00281CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038C8 RID: 14536
		// (get) Token: 0x060112D8 RID: 70360 RVA: 0x00283AFE File Offset: 0x00281CFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardSelectResponse.Descriptor;
			}
		}

		// Token: 0x060112D9 RID: 70361 RVA: 0x00283B05 File Offset: 0x00281D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectResponse()
		{
		}

		// Token: 0x060112DA RID: 70362 RVA: 0x00283B18 File Offset: 0x00281D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectResponse(PhantomBattleCardSelectResponse other) : this()
		{
			this.error_ = other.error_;
			this.phantomBattleHandCardInfos_ = other.phantomBattleHandCardInfos_.Clone();
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060112DB RID: 70363 RVA: 0x00283B65 File Offset: 0x00281D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectResponse Clone()
		{
			return new PhantomBattleCardSelectResponse(this);
		}

		// Token: 0x170038C9 RID: 14537
		// (get) Token: 0x060112DC RID: 70364 RVA: 0x00283B6D File Offset: 0x00281D6D
		// (set) Token: 0x060112DD RID: 70365 RVA: 0x00283B75 File Offset: 0x00281D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x170038CA RID: 14538
		// (get) Token: 0x060112DE RID: 70366 RVA: 0x00283B7E File Offset: 0x00281D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfos
		{
			get
			{
				return this.phantomBattleHandCardInfos_;
			}
		}

		// Token: 0x170038CB RID: 14539
		// (get) Token: 0x060112DF RID: 70367 RVA: 0x00283B86 File Offset: 0x00281D86
		// (set) Token: 0x060112E0 RID: 70368 RVA: 0x00283B8E File Offset: 0x00281D8E
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

		// Token: 0x060112E1 RID: 70369 RVA: 0x00283B97 File Offset: 0x00281D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardSelectResponse);
		}

		// Token: 0x060112E2 RID: 70370 RVA: 0x00283BA8 File Offset: 0x00281DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardSelectResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && this.phantomBattleHandCardInfos_.Equals(other.phantomBattleHandCardInfos_) && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060112E3 RID: 70371 RVA: 0x00283C08 File Offset: 0x00281E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
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

		// Token: 0x060112E4 RID: 70372 RVA: 0x00283C74 File Offset: 0x00281E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060112E5 RID: 70373 RVA: 0x00283C81 File Offset: 0x00281E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060112E6 RID: 70374 RVA: 0x00283C8C File Offset: 0x00281E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CurCardLibraryNum);
			}
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Error);
			}
			this.phantomBattleHandCardInfos_.WriteTo(ref output, PhantomBattleCardSelectResponse._repeated_phantomBattleHandCardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060112E7 RID: 70375 RVA: 0x00283CF8 File Offset: 0x00281EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			num += this.phantomBattleHandCardInfos_.CalculateSize(PhantomBattleCardSelectResponse._repeated_phantomBattleHandCardInfos_codec);
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

		// Token: 0x060112E8 RID: 70376 RVA: 0x00283D64 File Offset: 0x00281F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardSelectResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this.phantomBattleHandCardInfos_.Add(other.phantomBattleHandCardInfos_);
			if (other.CurCardLibraryNum != 0)
			{
				this.CurCardLibraryNum = other.CurCardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060112E9 RID: 70377 RVA: 0x00283DC5 File Offset: 0x00281FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060112EA RID: 70378 RVA: 0x00283DD0 File Offset: 0x00281FD0
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
				if (num != 48U)
				{
					if (num != 96U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.phantomBattleHandCardInfos_.AddEntriesFrom(ref input, PhantomBattleCardSelectResponse._repeated_phantomBattleHandCardInfos_codec);
						}
					}
					else
					{
						this.Error = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.CurCardLibraryNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006CAA RID: 27818
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CAB RID: 27819
		public const int ErrorFieldNumber = 12;

		// Token: 0x04006CAC RID: 27820
		private ErrorCode error_;

		// Token: 0x04006CAD RID: 27821
		public const int PhantomBattleHandCardInfosFieldNumber = 15;

		// Token: 0x04006CAE RID: 27822
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(122U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006CAF RID: 27823
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006CB0 RID: 27824
		public const int CurCardLibraryNumFieldNumber = 6;

		// Token: 0x04006CB1 RID: 27825
		private int curCardLibraryNum_;
	}
}
