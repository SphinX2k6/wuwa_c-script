using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A52 RID: 2642
	[NetMessage(EMessageId.MotorFightRankListResponse)]
	public sealed class MotorFightRankListResponse : IMessage<MotorFightRankListResponse>, IMessage, IEquatable<MotorFightRankListResponse>, IDeepCloneable<MotorFightRankListResponse>, IBufferMessage
	{
		// Token: 0x0600E683 RID: 59011 RVA: 0x0021ACAD File Offset: 0x00218EAD
		[NullableContext(1)]
		public static MotorFightRankListResponse Create()
		{
			return new MotorFightRankListResponse();
		}

		// Token: 0x17002EBC RID: 11964
		// (get) Token: 0x0600E684 RID: 59012 RVA: 0x0021ACB4 File Offset: 0x00218EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EBD RID: 11965
		// (get) Token: 0x0600E685 RID: 59013 RVA: 0x0021ACB7 File Offset: 0x00218EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRankListResponse.Descriptor;
			}
		}

		// Token: 0x0600E686 RID: 59014 RVA: 0x0021ACBE File Offset: 0x00218EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListResponse()
		{
		}

		// Token: 0x0600E687 RID: 59015 RVA: 0x0021ACD4 File Offset: 0x00218ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListResponse(MotorFightRankListResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.friendData_ = other.friendData_.Clone();
			this.selfData_ = ((other.selfData_ != null) ? other.selfData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E688 RID: 59016 RVA: 0x0021AD31 File Offset: 0x00218F31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListResponse Clone()
		{
			return new MotorFightRankListResponse(this);
		}

		// Token: 0x17002EBE RID: 11966
		// (get) Token: 0x0600E689 RID: 59017 RVA: 0x0021AD39 File Offset: 0x00218F39
		// (set) Token: 0x0600E68A RID: 59018 RVA: 0x0021AD41 File Offset: 0x00218F41
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

		// Token: 0x17002EBF RID: 11967
		// (get) Token: 0x0600E68B RID: 59019 RVA: 0x0021AD4A File Offset: 0x00218F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightPlayerRankingInfo> FriendData
		{
			get
			{
				return this.friendData_;
			}
		}

		// Token: 0x17002EC0 RID: 11968
		// (get) Token: 0x0600E68C RID: 59020 RVA: 0x0021AD52 File Offset: 0x00218F52
		// (set) Token: 0x0600E68D RID: 59021 RVA: 0x0021AD5A File Offset: 0x00218F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerRankingInfo SelfData
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

		// Token: 0x0600E68E RID: 59022 RVA: 0x0021AD63 File Offset: 0x00218F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRankListResponse);
		}

		// Token: 0x0600E68F RID: 59023 RVA: 0x0021AD74 File Offset: 0x00218F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRankListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.friendData_.Equals(other.friendData_) && object.Equals(this.SelfData, other.SelfData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E690 RID: 59024 RVA: 0x0021ADD8 File Offset: 0x00218FD8
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

		// Token: 0x0600E691 RID: 59025 RVA: 0x0021AE41 File Offset: 0x00219041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E692 RID: 59026 RVA: 0x0021AE4E File Offset: 0x0021904E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E693 RID: 59027 RVA: 0x0021AE58 File Offset: 0x00219058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.selfData_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.SelfData);
			}
			this.friendData_.WriteTo(ref output, MotorFightRankListResponse._repeated_friendData_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E694 RID: 59028 RVA: 0x0021AEC4 File Offset: 0x002190C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.friendData_.CalculateSize(MotorFightRankListResponse._repeated_friendData_codec);
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

		// Token: 0x0600E695 RID: 59029 RVA: 0x0021AF30 File Offset: 0x00219130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRankListResponse other)
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
					this.SelfData = new MotorFightPlayerRankingInfo();
				}
				this.SelfData.MergeFrom(other.SelfData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E696 RID: 59030 RVA: 0x0021AFA9 File Offset: 0x002191A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E697 RID: 59031 RVA: 0x0021AFB4 File Offset: 0x002191B4
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
					if (num != 50U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.friendData_.AddEntriesFrom(ref input, MotorFightRankListResponse._repeated_friendData_codec);
						}
					}
					else
					{
						if (this.selfData_ == null)
						{
							this.SelfData = new MotorFightPlayerRankingInfo();
						}
						input.ReadMessage(this.SelfData);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005E04 RID: 24068
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E05 RID: 24069
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04005E06 RID: 24070
		private ErrorCode errorCode_;

		// Token: 0x04005E07 RID: 24071
		public const int FriendDataFieldNumber = 11;

		// Token: 0x04005E08 RID: 24072
		private static readonly FieldCodec<MotorFightPlayerRankingInfo> _repeated_friendData_codec = FieldCodec.ForMessage<MotorFightPlayerRankingInfo>(90U, MotorFightPlayerRankingInfo.Parser);

		// Token: 0x04005E09 RID: 24073
		private readonly RepeatedField<MotorFightPlayerRankingInfo> friendData_ = new RepeatedField<MotorFightPlayerRankingInfo>();

		// Token: 0x04005E0A RID: 24074
		public const int SelfDataFieldNumber = 6;

		// Token: 0x04005E0B RID: 24075
		private MotorFightPlayerRankingInfo selfData_;
	}
}
