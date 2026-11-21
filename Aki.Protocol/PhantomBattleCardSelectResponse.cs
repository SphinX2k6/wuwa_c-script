using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C51 RID: 3153
	[NetMessage(EMessageId.PhantomBattleCardSelectResponse)]
	public sealed class PhantomBattleCardSelectResponse : IMessage<PhantomBattleCardSelectResponse>, IMessage, IEquatable<PhantomBattleCardSelectResponse>, IDeepCloneable<PhantomBattleCardSelectResponse>, IBufferMessage
	{
		// Token: 0x060111D6 RID: 70102 RVA: 0x00281D85 File Offset: 0x0027FF85
		[NullableContext(1)]
		public static PhantomBattleCardSelectResponse Create()
		{
			return new PhantomBattleCardSelectResponse();
		}

		// Token: 0x17003890 RID: 14480
		// (get) Token: 0x060111D7 RID: 70103 RVA: 0x00281D8C File Offset: 0x0027FF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003891 RID: 14481
		// (get) Token: 0x060111D8 RID: 70104 RVA: 0x00281D8F File Offset: 0x0027FF8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardSelectResponse.Descriptor;
			}
		}

		// Token: 0x060111D9 RID: 70105 RVA: 0x00281D96 File Offset: 0x0027FF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectResponse()
		{
		}

		// Token: 0x060111DA RID: 70106 RVA: 0x00281DAC File Offset: 0x0027FFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectResponse(PhantomBattleCardSelectResponse other) : this()
		{
			this.error_ = other.error_;
			this.phantomBattleHandCardInfos_ = other.phantomBattleHandCardInfos_.Clone();
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060111DB RID: 70107 RVA: 0x00281DF9 File Offset: 0x0027FFF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectResponse Clone()
		{
			return new PhantomBattleCardSelectResponse(this);
		}

		// Token: 0x17003892 RID: 14482
		// (get) Token: 0x060111DC RID: 70108 RVA: 0x00281E01 File Offset: 0x00280001
		// (set) Token: 0x060111DD RID: 70109 RVA: 0x00281E09 File Offset: 0x00280009
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

		// Token: 0x17003893 RID: 14483
		// (get) Token: 0x060111DE RID: 70110 RVA: 0x00281E12 File Offset: 0x00280012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfos
		{
			get
			{
				return this.phantomBattleHandCardInfos_;
			}
		}

		// Token: 0x17003894 RID: 14484
		// (get) Token: 0x060111DF RID: 70111 RVA: 0x00281E1A File Offset: 0x0028001A
		// (set) Token: 0x060111E0 RID: 70112 RVA: 0x00281E22 File Offset: 0x00280022
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

		// Token: 0x060111E1 RID: 70113 RVA: 0x00281E2B File Offset: 0x0028002B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardSelectResponse);
		}

		// Token: 0x060111E2 RID: 70114 RVA: 0x00281E3C File Offset: 0x0028003C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardSelectResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && this.phantomBattleHandCardInfos_.Equals(other.phantomBattleHandCardInfos_) && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060111E3 RID: 70115 RVA: 0x00281E9C File Offset: 0x0028009C
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

		// Token: 0x060111E4 RID: 70116 RVA: 0x00281F08 File Offset: 0x00280108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060111E5 RID: 70117 RVA: 0x00281F15 File Offset: 0x00280115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060111E6 RID: 70118 RVA: 0x00281F20 File Offset: 0x00280120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Error);
			}
			this.phantomBattleHandCardInfos_.WriteTo(ref output, PhantomBattleCardSelectResponse._repeated_phantomBattleHandCardInfos_codec);
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.CurCardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060111E7 RID: 70119 RVA: 0x00281F8C File Offset: 0x0028018C
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

		// Token: 0x060111E8 RID: 70120 RVA: 0x00281FF8 File Offset: 0x002801F8
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

		// Token: 0x060111E9 RID: 70121 RVA: 0x00282059 File Offset: 0x00280259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060111EA RID: 70122 RVA: 0x00282064 File Offset: 0x00280264
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
					if (num != 42U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CurCardLibraryNum = input.ReadInt32();
						}
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
		}

		// Token: 0x04006CBE RID: 27838
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CBF RID: 27839
		public const int ErrorFieldNumber = 1;

		// Token: 0x04006CC0 RID: 27840
		private ErrorCode error_;

		// Token: 0x04006CC1 RID: 27841
		public const int PhantomBattleHandCardInfosFieldNumber = 5;

		// Token: 0x04006CC2 RID: 27842
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(42U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006CC3 RID: 27843
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006CC4 RID: 27844
		public const int CurCardLibraryNumFieldNumber = 11;

		// Token: 0x04006CC5 RID: 27845
		private int curCardLibraryNum_;
	}
}
