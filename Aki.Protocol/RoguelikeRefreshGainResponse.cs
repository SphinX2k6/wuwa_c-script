using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F9C RID: 3996
	[NetMessage(EMessageId.RoguelikeRefreshGainResponse)]
	public sealed class RoguelikeRefreshGainResponse : IMessage<RoguelikeRefreshGainResponse>, IMessage, IEquatable<RoguelikeRefreshGainResponse>, IDeepCloneable<RoguelikeRefreshGainResponse>, IBufferMessage
	{
		// Token: 0x06015650 RID: 87632 RVA: 0x0031B7CC File Offset: 0x003199CC
		[NullableContext(1)]
		public static RoguelikeRefreshGainResponse Create()
		{
			return new RoguelikeRefreshGainResponse();
		}

		// Token: 0x17004755 RID: 18261
		// (get) Token: 0x06015651 RID: 87633 RVA: 0x0031B7D3 File Offset: 0x003199D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004756 RID: 18262
		// (get) Token: 0x06015652 RID: 87634 RVA: 0x0031B7D6 File Offset: 0x003199D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeRefreshGainResponse.Descriptor;
			}
		}

		// Token: 0x06015653 RID: 87635 RVA: 0x0031B7DD File Offset: 0x003199DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRefreshGainResponse()
		{
		}

		// Token: 0x06015654 RID: 87636 RVA: 0x0031B7F0 File Offset: 0x003199F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRefreshGainResponse(RoguelikeRefreshGainResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.roguelikeChooseData_ = ((other.roguelikeChooseData_ != null) ? other.roguelikeChooseData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015655 RID: 87637 RVA: 0x0031B84D File Offset: 0x00319A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRefreshGainResponse Clone()
		{
			return new RoguelikeRefreshGainResponse(this);
		}

		// Token: 0x17004757 RID: 18263
		// (get) Token: 0x06015656 RID: 87638 RVA: 0x0031B855 File Offset: 0x00319A55
		// (set) Token: 0x06015657 RID: 87639 RVA: 0x0031B85D File Offset: 0x00319A5D
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

		// Token: 0x17004758 RID: 18264
		// (get) Token: 0x06015658 RID: 87640 RVA: 0x0031B866 File Offset: 0x00319A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x17004759 RID: 18265
		// (get) Token: 0x06015659 RID: 87641 RVA: 0x0031B86E File Offset: 0x00319A6E
		// (set) Token: 0x0601565A RID: 87642 RVA: 0x0031B876 File Offset: 0x00319A76
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

		// Token: 0x0601565B RID: 87643 RVA: 0x0031B87F File Offset: 0x00319A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeRefreshGainResponse);
		}

		// Token: 0x0601565C RID: 87644 RVA: 0x0031B890 File Offset: 0x00319A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeRefreshGainResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this.RoguelikeChooseData, other.RoguelikeChooseData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601565D RID: 87645 RVA: 0x0031B8F4 File Offset: 0x00319AF4
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

		// Token: 0x0601565E RID: 87646 RVA: 0x0031B95D File Offset: 0x00319B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601565F RID: 87647 RVA: 0x0031B96A File Offset: 0x00319B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015660 RID: 87648 RVA: 0x0031B974 File Offset: 0x00319B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roguelikeChooseData_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RoguelikeChooseData);
			}
			this.errorParams_.WriteTo(ref output, RoguelikeRefreshGainResponse._repeated_errorParams_codec);
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

		// Token: 0x06015661 RID: 87649 RVA: 0x0031B9E0 File Offset: 0x00319BE0
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

		// Token: 0x06015662 RID: 87650 RVA: 0x0031BA4C File Offset: 0x00319C4C
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

		// Token: 0x06015663 RID: 87651 RVA: 0x0031BAC5 File Offset: 0x00319CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015664 RID: 87652 RVA: 0x0031BAD0 File Offset: 0x00319CD0
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
				if (num != 34U)
				{
					if (num != 50U)
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
						this.errorParams_.AddEntriesFrom(ref input, RoguelikeRefreshGainResponse._repeated_errorParams_codec);
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

		// Token: 0x04008121 RID: 33057
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008122 RID: 33058
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04008123 RID: 33059
		private ErrorCode errorCode_;

		// Token: 0x04008124 RID: 33060
		public const int ErrorParamsFieldNumber = 6;

		// Token: 0x04008125 RID: 33061
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(50U);

		// Token: 0x04008126 RID: 33062
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x04008127 RID: 33063
		public const int RoguelikeChooseDataFieldNumber = 4;

		// Token: 0x04008128 RID: 33064
		private RoguelikeChooseData roguelikeChooseData_;
	}
}
