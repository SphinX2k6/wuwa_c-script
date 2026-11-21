using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F30 RID: 3888
	[NetMessage(EMessageId.RhythmRankListResponse)]
	public sealed class RhythmRankListResponse : IMessage<RhythmRankListResponse>, IMessage, IEquatable<RhythmRankListResponse>, IDeepCloneable<RhythmRankListResponse>, IBufferMessage
	{
		// Token: 0x06014D4E RID: 85326 RVA: 0x003063B5 File Offset: 0x003045B5
		[NullableContext(1)]
		public static RhythmRankListResponse Create()
		{
			return new RhythmRankListResponse();
		}

		// Token: 0x17004549 RID: 17737
		// (get) Token: 0x06014D4F RID: 85327 RVA: 0x003063BC File Offset: 0x003045BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700454A RID: 17738
		// (get) Token: 0x06014D50 RID: 85328 RVA: 0x003063BF File Offset: 0x003045BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmRankListResponse.Descriptor;
			}
		}

		// Token: 0x06014D51 RID: 85329 RVA: 0x003063C6 File Offset: 0x003045C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListResponse()
		{
		}

		// Token: 0x06014D52 RID: 85330 RVA: 0x003063DC File Offset: 0x003045DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListResponse(RhythmRankListResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.friendData_ = other.friendData_.Clone();
			this.selfData_ = ((other.selfData_ != null) ? other.selfData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014D53 RID: 85331 RVA: 0x00306439 File Offset: 0x00304639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListResponse Clone()
		{
			return new RhythmRankListResponse(this);
		}

		// Token: 0x1700454B RID: 17739
		// (get) Token: 0x06014D54 RID: 85332 RVA: 0x00306441 File Offset: 0x00304641
		// (set) Token: 0x06014D55 RID: 85333 RVA: 0x00306449 File Offset: 0x00304649
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

		// Token: 0x1700454C RID: 17740
		// (get) Token: 0x06014D56 RID: 85334 RVA: 0x00306452 File Offset: 0x00304652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RhythmPlayerRankingInfo> FriendData
		{
			get
			{
				return this.friendData_;
			}
		}

		// Token: 0x1700454D RID: 17741
		// (get) Token: 0x06014D57 RID: 85335 RVA: 0x0030645A File Offset: 0x0030465A
		// (set) Token: 0x06014D58 RID: 85336 RVA: 0x00306462 File Offset: 0x00304662
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

		// Token: 0x06014D59 RID: 85337 RVA: 0x0030646B File Offset: 0x0030466B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmRankListResponse);
		}

		// Token: 0x06014D5A RID: 85338 RVA: 0x0030647C File Offset: 0x0030467C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmRankListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.friendData_.Equals(other.friendData_) && object.Equals(this.SelfData, other.SelfData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014D5B RID: 85339 RVA: 0x003064E0 File Offset: 0x003046E0
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

		// Token: 0x06014D5C RID: 85340 RVA: 0x00306549 File Offset: 0x00304749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014D5D RID: 85341 RVA: 0x00306556 File Offset: 0x00304756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014D5E RID: 85342 RVA: 0x00306560 File Offset: 0x00304760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.selfData_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SelfData);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.friendData_.WriteTo(ref output, RhythmRankListResponse._repeated_friendData_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014D5F RID: 85343 RVA: 0x003065CC File Offset: 0x003047CC
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

		// Token: 0x06014D60 RID: 85344 RVA: 0x00306638 File Offset: 0x00304838
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

		// Token: 0x06014D61 RID: 85345 RVA: 0x003066B1 File Offset: 0x003048B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014D62 RID: 85346 RVA: 0x003066BC File Offset: 0x003048BC
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
					if (num != 24U)
					{
						if (num != 74U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.friendData_.AddEntriesFrom(ref input, RhythmRankListResponse._repeated_friendData_codec);
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
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
		}

		// Token: 0x04007E22 RID: 32290
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E23 RID: 32291
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04007E24 RID: 32292
		private ErrorCode errorCode_;

		// Token: 0x04007E25 RID: 32293
		public const int FriendDataFieldNumber = 9;

		// Token: 0x04007E26 RID: 32294
		private static readonly FieldCodec<RhythmPlayerRankingInfo> _repeated_friendData_codec = FieldCodec.ForMessage<RhythmPlayerRankingInfo>(74U, RhythmPlayerRankingInfo.Parser);

		// Token: 0x04007E27 RID: 32295
		private readonly RepeatedField<RhythmPlayerRankingInfo> friendData_ = new RepeatedField<RhythmPlayerRankingInfo>();

		// Token: 0x04007E28 RID: 32296
		public const int SelfDataFieldNumber = 1;

		// Token: 0x04007E29 RID: 32297
		private RhythmPlayerRankingInfo selfData_;
	}
}
