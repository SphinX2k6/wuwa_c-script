using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FAC RID: 4012
	[NetMessage(EMessageId.RoguelikeRefreshGainResponse)]
	public sealed class RoguelikeRefreshGainResponse : IMessage<RoguelikeRefreshGainResponse>, IMessage, IEquatable<RoguelikeRefreshGainResponse>, IDeepCloneable<RoguelikeRefreshGainResponse>, IBufferMessage
	{
		// Token: 0x06015735 RID: 87861 RVA: 0x0031CE78 File Offset: 0x0031B078
		[NullableContext(1)]
		public static RoguelikeRefreshGainResponse Create()
		{
			return new RoguelikeRefreshGainResponse();
		}

		// Token: 0x1700477F RID: 18303
		// (get) Token: 0x06015736 RID: 87862 RVA: 0x0031CE7F File Offset: 0x0031B07F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004780 RID: 18304
		// (get) Token: 0x06015737 RID: 87863 RVA: 0x0031CE82 File Offset: 0x0031B082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeRefreshGainResponse.Descriptor;
			}
		}

		// Token: 0x06015738 RID: 87864 RVA: 0x0031CE89 File Offset: 0x0031B089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRefreshGainResponse()
		{
		}

		// Token: 0x06015739 RID: 87865 RVA: 0x0031CE9C File Offset: 0x0031B09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRefreshGainResponse(RoguelikeRefreshGainResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.roguelikeChooseData_ = ((other.roguelikeChooseData_ != null) ? other.roguelikeChooseData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601573A RID: 87866 RVA: 0x0031CEF9 File Offset: 0x0031B0F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRefreshGainResponse Clone()
		{
			return new RoguelikeRefreshGainResponse(this);
		}

		// Token: 0x17004781 RID: 18305
		// (get) Token: 0x0601573B RID: 87867 RVA: 0x0031CF01 File Offset: 0x0031B101
		// (set) Token: 0x0601573C RID: 87868 RVA: 0x0031CF09 File Offset: 0x0031B109
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

		// Token: 0x17004782 RID: 18306
		// (get) Token: 0x0601573D RID: 87869 RVA: 0x0031CF12 File Offset: 0x0031B112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x17004783 RID: 18307
		// (get) Token: 0x0601573E RID: 87870 RVA: 0x0031CF1A File Offset: 0x0031B11A
		// (set) Token: 0x0601573F RID: 87871 RVA: 0x0031CF22 File Offset: 0x0031B122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseData RoguelikeChooseData
		{
			get
			{
				return this.roguelikeChooseData_;
			}
			set
			{
				this.roguelikeChooseData_ = value;
			}
		}

		// Token: 0x06015740 RID: 87872 RVA: 0x0031CF2B File Offset: 0x0031B12B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeRefreshGainResponse);
		}

		// Token: 0x06015741 RID: 87873 RVA: 0x0031CF3C File Offset: 0x0031B13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeRefreshGainResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this.RoguelikeChooseData, other.RoguelikeChooseData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015742 RID: 87874 RVA: 0x0031CFA0 File Offset: 0x0031B1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.errorParams_.GetHashCode();
			if (this.roguelikeChooseData_ != null)
			{
				num ^= this.RoguelikeChooseData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015743 RID: 87875 RVA: 0x0031D009 File Offset: 0x0031B209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015744 RID: 87876 RVA: 0x0031D016 File Offset: 0x0031B216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015745 RID: 87877 RVA: 0x0031D020 File Offset: 0x0031B220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.errorParams_.WriteTo(ref output, RoguelikeRefreshGainResponse._repeated_errorParams_codec);
			if (this.roguelikeChooseData_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.RoguelikeChooseData);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015746 RID: 87878 RVA: 0x0031D08C File Offset: 0x0031B28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(RoguelikeRefreshGainResponse._repeated_errorParams_codec);
			if (this.roguelikeChooseData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoguelikeChooseData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015747 RID: 87879 RVA: 0x0031D0F8 File Offset: 0x0031B2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeRefreshGainResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.errorParams_.Add(other.errorParams_);
			if (other.roguelikeChooseData_ != null)
			{
				if (this.roguelikeChooseData_ == null)
				{
					this.RoguelikeChooseData = new RoguelikeChooseData();
				}
				this.RoguelikeChooseData.MergeFrom(other.RoguelikeChooseData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015748 RID: 87880 RVA: 0x0031D171 File Offset: 0x0031B371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015749 RID: 87881 RVA: 0x0031D17C File Offset: 0x0031B37C
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
				if (num != 50U)
				{
					if (num != 98U)
					{
						if (num != 104U)
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
						if (this.roguelikeChooseData_ == null)
						{
							this.RoguelikeChooseData = new RoguelikeChooseData();
						}
						input.ReadMessage(this.RoguelikeChooseData);
					}
				}
				else
				{
					this.errorParams_.AddEntriesFrom(ref input, RoguelikeRefreshGainResponse._repeated_errorParams_codec);
				}
			}
		}

		// Token: 0x040080F7 RID: 33015
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080F8 RID: 33016
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040080F9 RID: 33017
		private ErrorCode errorCode_;

		// Token: 0x040080FA RID: 33018
		public const int ErrorParamsFieldNumber = 6;

		// Token: 0x040080FB RID: 33019
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(50U);

		// Token: 0x040080FC RID: 33020
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x040080FD RID: 33021
		public const int RoguelikeChooseDataFieldNumber = 12;

		// Token: 0x040080FE RID: 33022
		private RoguelikeChooseData roguelikeChooseData_;
	}
}
