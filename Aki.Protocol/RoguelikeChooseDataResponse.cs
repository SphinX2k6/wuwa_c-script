using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F85 RID: 3973
	[NetMessage(EMessageId.RoguelikeChooseDataResponse)]
	public sealed class RoguelikeChooseDataResponse : IMessage<RoguelikeChooseDataResponse>, IMessage, IEquatable<RoguelikeChooseDataResponse>, IDeepCloneable<RoguelikeChooseDataResponse>, IBufferMessage
	{
		// Token: 0x06015471 RID: 87153 RVA: 0x0031708C File Offset: 0x0031528C
		[NullableContext(1)]
		public static RoguelikeChooseDataResponse Create()
		{
			return new RoguelikeChooseDataResponse();
		}

		// Token: 0x170046EC RID: 18156
		// (get) Token: 0x06015472 RID: 87154 RVA: 0x00317093 File Offset: 0x00315293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046ED RID: 18157
		// (get) Token: 0x06015473 RID: 87155 RVA: 0x00317096 File Offset: 0x00315296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeChooseDataResponse.Descriptor;
			}
		}

		// Token: 0x06015474 RID: 87156 RVA: 0x0031709D File Offset: 0x0031529D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataResponse()
		{
		}

		// Token: 0x06015475 RID: 87157 RVA: 0x003170B0 File Offset: 0x003152B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataResponse(RoguelikeChooseDataResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.roguelikeChooseData_ = ((other.roguelikeChooseData_ != null) ? other.roguelikeChooseData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015476 RID: 87158 RVA: 0x0031710D File Offset: 0x0031530D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataResponse Clone()
		{
			return new RoguelikeChooseDataResponse(this);
		}

		// Token: 0x170046EE RID: 18158
		// (get) Token: 0x06015477 RID: 87159 RVA: 0x00317115 File Offset: 0x00315315
		// (set) Token: 0x06015478 RID: 87160 RVA: 0x0031711D File Offset: 0x0031531D
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

		// Token: 0x170046EF RID: 18159
		// (get) Token: 0x06015479 RID: 87161 RVA: 0x00317126 File Offset: 0x00315326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x170046F0 RID: 18160
		// (get) Token: 0x0601547A RID: 87162 RVA: 0x0031712E File Offset: 0x0031532E
		// (set) Token: 0x0601547B RID: 87163 RVA: 0x00317136 File Offset: 0x00315336
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

		// Token: 0x0601547C RID: 87164 RVA: 0x0031713F File Offset: 0x0031533F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeChooseDataResponse);
		}

		// Token: 0x0601547D RID: 87165 RVA: 0x00317150 File Offset: 0x00315350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeChooseDataResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this.RoguelikeChooseData, other.RoguelikeChooseData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601547E RID: 87166 RVA: 0x003171B4 File Offset: 0x003153B4
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

		// Token: 0x0601547F RID: 87167 RVA: 0x0031721D File Offset: 0x0031541D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015480 RID: 87168 RVA: 0x0031722A File Offset: 0x0031542A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015481 RID: 87169 RVA: 0x00317234 File Offset: 0x00315434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roguelikeChooseData_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RoguelikeChooseData);
			}
			this.errorParams_.WriteTo(ref output, RoguelikeChooseDataResponse._repeated_errorParams_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015482 RID: 87170 RVA: 0x003172A0 File Offset: 0x003154A0
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

		// Token: 0x06015483 RID: 87171 RVA: 0x0031730C File Offset: 0x0031550C
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

		// Token: 0x06015484 RID: 87172 RVA: 0x00317385 File Offset: 0x00315585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015485 RID: 87173 RVA: 0x00317390 File Offset: 0x00315590
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
				if (num != 10U)
				{
					if (num != 34U)
					{
						if (num != 120U)
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
		}

		// Token: 0x04008083 RID: 32899
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008084 RID: 32900
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04008085 RID: 32901
		private ErrorCode errorCode_;

		// Token: 0x04008086 RID: 32902
		public const int ErrorParamsFieldNumber = 4;

		// Token: 0x04008087 RID: 32903
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(34U);

		// Token: 0x04008088 RID: 32904
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x04008089 RID: 32905
		public const int RoguelikeChooseDataFieldNumber = 1;

		// Token: 0x0400808A RID: 32906
		private RoguelikeChooseData roguelikeChooseData_;
	}
}
