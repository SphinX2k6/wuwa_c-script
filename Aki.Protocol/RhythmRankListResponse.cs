using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F40 RID: 3904
	[NetMessage(EMessageId.RhythmRankListResponse)]
	public sealed class RhythmRankListResponse : IMessage<RhythmRankListResponse>, IMessage, IEquatable<RhythmRankListResponse>, IDeepCloneable<RhythmRankListResponse>, IBufferMessage
	{
		// Token: 0x06014E33 RID: 85555 RVA: 0x00307A71 File Offset: 0x00305C71
		[NullableContext(1)]
		public static RhythmRankListResponse Create()
		{
			return new RhythmRankListResponse();
		}

		// Token: 0x17004573 RID: 17779
		// (get) Token: 0x06014E34 RID: 85556 RVA: 0x00307A78 File Offset: 0x00305C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004574 RID: 17780
		// (get) Token: 0x06014E35 RID: 85557 RVA: 0x00307A7B File Offset: 0x00305C7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmRankListResponse.Descriptor;
			}
		}

		// Token: 0x06014E36 RID: 85558 RVA: 0x00307A82 File Offset: 0x00305C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListResponse()
		{
		}

		// Token: 0x06014E37 RID: 85559 RVA: 0x00307A98 File Offset: 0x00305C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListResponse(RhythmRankListResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.friendData_ = other.friendData_.Clone();
			this.selfData_ = ((other.selfData_ != null) ? other.selfData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014E38 RID: 85560 RVA: 0x00307AF5 File Offset: 0x00305CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListResponse Clone()
		{
			return new RhythmRankListResponse(this);
		}

		// Token: 0x17004575 RID: 17781
		// (get) Token: 0x06014E39 RID: 85561 RVA: 0x00307AFD File Offset: 0x00305CFD
		// (set) Token: 0x06014E3A RID: 85562 RVA: 0x00307B05 File Offset: 0x00305D05
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

		// Token: 0x17004576 RID: 17782
		// (get) Token: 0x06014E3B RID: 85563 RVA: 0x00307B0E File Offset: 0x00305D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RhythmPlayerRankingInfo> FriendData
		{
			get
			{
				return this.friendData_;
			}
		}

		// Token: 0x17004577 RID: 17783
		// (get) Token: 0x06014E3C RID: 85564 RVA: 0x00307B16 File Offset: 0x00305D16
		// (set) Token: 0x06014E3D RID: 85565 RVA: 0x00307B1E File Offset: 0x00305D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmPlayerRankingInfo SelfData
		{
			get
			{
				return this.selfData_;
			}
			set
			{
				this.selfData_ = value;
			}
		}

		// Token: 0x06014E3E RID: 85566 RVA: 0x00307B27 File Offset: 0x00305D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmRankListResponse);
		}

		// Token: 0x06014E3F RID: 85567 RVA: 0x00307B38 File Offset: 0x00305D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmRankListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.friendData_.Equals(other.friendData_) && object.Equals(this.SelfData, other.SelfData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014E40 RID: 85568 RVA: 0x00307B9C File Offset: 0x00305D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.friendData_.GetHashCode();
			if (this.selfData_ != null)
			{
				num ^= this.SelfData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014E41 RID: 85569 RVA: 0x00307C05 File Offset: 0x00305E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014E42 RID: 85570 RVA: 0x00307C12 File Offset: 0x00305E12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014E43 RID: 85571 RVA: 0x00307C1C File Offset: 0x00305E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.friendData_.WriteTo(ref output, RhythmRankListResponse._repeated_friendData_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.selfData_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.SelfData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014E44 RID: 85572 RVA: 0x00307C88 File Offset: 0x00305E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.friendData_.CalculateSize(RhythmRankListResponse._repeated_friendData_codec);
			if (this.selfData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelfData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014E45 RID: 85573 RVA: 0x00307CF4 File Offset: 0x00305EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmRankListResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.friendData_.Add(other.friendData_);
			if (other.selfData_ != null)
			{
				if (this.selfData_ == null)
				{
					this.SelfData = new RhythmPlayerRankingInfo();
				}
				this.SelfData.MergeFrom(other.SelfData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014E46 RID: 85574 RVA: 0x00307D6D File Offset: 0x00305F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014E47 RID: 85575 RVA: 0x00307D78 File Offset: 0x00305F78
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
					if (num != 40U)
					{
						if (num != 74U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.selfData_ == null)
							{
								this.SelfData = new RhythmPlayerRankingInfo();
							}
							input.ReadMessage(this.SelfData);
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.friendData_.AddEntriesFrom(ref input, RhythmRankListResponse._repeated_friendData_codec);
				}
			}
		}

		// Token: 0x04007DF8 RID: 32248
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DF9 RID: 32249
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04007DFA RID: 32250
		private ErrorCode errorCode_;

		// Token: 0x04007DFB RID: 32251
		public const int FriendDataFieldNumber = 1;

		// Token: 0x04007DFC RID: 32252
		private static readonly FieldCodec<RhythmPlayerRankingInfo> _repeated_friendData_codec = FieldCodec.ForMessage<RhythmPlayerRankingInfo>(10U, RhythmPlayerRankingInfo.Parser);

		// Token: 0x04007DFD RID: 32253
		private readonly RepeatedField<RhythmPlayerRankingInfo> friendData_ = new RepeatedField<RhythmPlayerRankingInfo>();

		// Token: 0x04007DFE RID: 32254
		public const int SelfDataFieldNumber = 9;

		// Token: 0x04007DFF RID: 32255
		private RhythmPlayerRankingInfo selfData_;
	}
}
