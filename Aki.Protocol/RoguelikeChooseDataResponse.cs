using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F95 RID: 3989
	[NetMessage(EMessageId.RoguelikeChooseDataResponse)]
	public sealed class RoguelikeChooseDataResponse : IMessage<RoguelikeChooseDataResponse>, IMessage, IEquatable<RoguelikeChooseDataResponse>, IDeepCloneable<RoguelikeChooseDataResponse>, IBufferMessage
	{
		// Token: 0x06015556 RID: 87382 RVA: 0x00318740 File Offset: 0x00316940
		[NullableContext(1)]
		public static RoguelikeChooseDataResponse Create()
		{
			return new RoguelikeChooseDataResponse();
		}

		// Token: 0x17004716 RID: 18198
		// (get) Token: 0x06015557 RID: 87383 RVA: 0x00318747 File Offset: 0x00316947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004717 RID: 18199
		// (get) Token: 0x06015558 RID: 87384 RVA: 0x0031874A File Offset: 0x0031694A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeChooseDataResponse.Descriptor;
			}
		}

		// Token: 0x06015559 RID: 87385 RVA: 0x00318751 File Offset: 0x00316951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataResponse()
		{
		}

		// Token: 0x0601555A RID: 87386 RVA: 0x00318764 File Offset: 0x00316964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataResponse(RoguelikeChooseDataResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.roguelikeChooseData_ = ((other.roguelikeChooseData_ != null) ? other.roguelikeChooseData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601555B RID: 87387 RVA: 0x003187C1 File Offset: 0x003169C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataResponse Clone()
		{
			return new RoguelikeChooseDataResponse(this);
		}

		// Token: 0x17004718 RID: 18200
		// (get) Token: 0x0601555C RID: 87388 RVA: 0x003187C9 File Offset: 0x003169C9
		// (set) Token: 0x0601555D RID: 87389 RVA: 0x003187D1 File Offset: 0x003169D1
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

		// Token: 0x17004719 RID: 18201
		// (get) Token: 0x0601555E RID: 87390 RVA: 0x003187DA File Offset: 0x003169DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x1700471A RID: 18202
		// (get) Token: 0x0601555F RID: 87391 RVA: 0x003187E2 File Offset: 0x003169E2
		// (set) Token: 0x06015560 RID: 87392 RVA: 0x003187EA File Offset: 0x003169EA
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

		// Token: 0x06015561 RID: 87393 RVA: 0x003187F3 File Offset: 0x003169F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeChooseDataResponse);
		}

		// Token: 0x06015562 RID: 87394 RVA: 0x00318804 File Offset: 0x00316A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeChooseDataResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this.RoguelikeChooseData, other.RoguelikeChooseData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015563 RID: 87395 RVA: 0x00318868 File Offset: 0x00316A68
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

		// Token: 0x06015564 RID: 87396 RVA: 0x003188D1 File Offset: 0x00316AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015565 RID: 87397 RVA: 0x003188DE File Offset: 0x00316ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015566 RID: 87398 RVA: 0x003188E8 File Offset: 0x00316AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.roguelikeChooseData_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.RoguelikeChooseData);
			}
			this.errorParams_.WriteTo(ref output, RoguelikeChooseDataResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015567 RID: 87399 RVA: 0x00318954 File Offset: 0x00316B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(RoguelikeChooseDataResponse._repeated_errorParams_codec);
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

		// Token: 0x06015568 RID: 87400 RVA: 0x003189C0 File Offset: 0x00316BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeChooseDataResponse other)
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

		// Token: 0x06015569 RID: 87401 RVA: 0x00318A39 File Offset: 0x00316C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601556A RID: 87402 RVA: 0x00318A44 File Offset: 0x00316C44
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
				if (num != 56U)
				{
					if (num != 66U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.errorParams_.AddEntriesFrom(ref input, RoguelikeChooseDataResponse._repeated_errorParams_codec);
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008059 RID: 32857
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400805A RID: 32858
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400805B RID: 32859
		private ErrorCode errorCode_;

		// Token: 0x0400805C RID: 32860
		public const int ErrorParamsFieldNumber = 13;

		// Token: 0x0400805D RID: 32861
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(106U);

		// Token: 0x0400805E RID: 32862
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x0400805F RID: 32863
		public const int RoguelikeChooseDataFieldNumber = 8;

		// Token: 0x04008060 RID: 32864
		private RoguelikeChooseData roguelikeChooseData_;
	}
}
