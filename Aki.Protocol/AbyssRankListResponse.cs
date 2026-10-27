using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200003A RID: 58
	[NetMessage(EMessageId.AbyssRankListResponse)]
	public sealed class AbyssRankListResponse : IMessage<AbyssRankListResponse>, IMessage, IEquatable<AbyssRankListResponse>, IDeepCloneable<AbyssRankListResponse>, IBufferMessage
	{
		// Token: 0x06001317 RID: 4887 RVA: 0x00034014 File Offset: 0x00032214
		[NullableContext(1)]
		public static AbyssRankListResponse Create()
		{
			return new AbyssRankListResponse();
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x0003401B File Offset: 0x0003221B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x0003401E File Offset: 0x0003221E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRankListResponse.Descriptor;
			}
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x00034025 File Offset: 0x00032225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRankListResponse()
		{
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00034044 File Offset: 0x00032244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRankListResponse(AbyssRankListResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.friendPassData_ = other.friendPassData_.Clone();
			this.selfPassData_ = other.selfPassData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00034096 File Offset: 0x00032296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRankListResponse Clone()
		{
			return new AbyssRankListResponse(this);
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x0003409E File Offset: 0x0003229E
		// (set) Token: 0x0600131E RID: 4894 RVA: 0x000340A6 File Offset: 0x000322A6
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

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x000340AF File Offset: 0x000322AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssChallengeInfo> FriendPassData
		{
			get
			{
				return this.friendPassData_;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x000340B7 File Offset: 0x000322B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssChallengeInfo> SelfPassData
		{
			get
			{
				return this.selfPassData_;
			}
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x000340BF File Offset: 0x000322BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRankListResponse);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x000340D0 File Offset: 0x000322D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRankListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.friendPassData_.Equals(other.friendPassData_) && this.selfPassData_.Equals(other.selfPassData_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00034134 File Offset: 0x00032334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.friendPassData_.GetHashCode();
			num ^= this.selfPassData_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x00034195 File Offset: 0x00032395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x000341A2 File Offset: 0x000323A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x000341AC File Offset: 0x000323AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.selfPassData_.WriteTo(ref output, AbyssRankListResponse._repeated_selfPassData_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.friendPassData_.WriteTo(ref output, AbyssRankListResponse._repeated_friendPassData_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x0003420C File Offset: 0x0003240C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.friendPassData_.CalculateSize(AbyssRankListResponse._repeated_friendPassData_codec);
			num += this.selfPassData_.CalculateSize(AbyssRankListResponse._repeated_selfPassData_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x00034270 File Offset: 0x00032470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssRankListResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.friendPassData_.Add(other.friendPassData_);
			this.selfPassData_.Add(other.selfPassData_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x000342CE File Offset: 0x000324CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x000342D8 File Offset: 0x000324D8
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
				if (num != 18U)
				{
					if (num != 32U)
					{
						if (num != 74U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.friendPassData_.AddEntriesFrom(ref input, AbyssRankListResponse._repeated_friendPassData_codec);
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.selfPassData_.AddEntriesFrom(ref input, AbyssRankListResponse._repeated_selfPassData_codec);
				}
			}
		}

		// Token: 0x04001FF6 RID: 8182
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FF7 RID: 8183
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04001FF8 RID: 8184
		private ErrorCode errorCode_;

		// Token: 0x04001FF9 RID: 8185
		public const int FriendPassDataFieldNumber = 9;

		// Token: 0x04001FFA RID: 8186
		private static readonly FieldCodec<AbyssChallengeInfo> _repeated_friendPassData_codec = FieldCodec.ForMessage<AbyssChallengeInfo>(74U, AbyssChallengeInfo.Parser);

		// Token: 0x04001FFB RID: 8187
		private readonly RepeatedField<AbyssChallengeInfo> friendPassData_ = new RepeatedField<AbyssChallengeInfo>();

		// Token: 0x04001FFC RID: 8188
		public const int SelfPassDataFieldNumber = 2;

		// Token: 0x04001FFD RID: 8189
		private static readonly FieldCodec<AbyssChallengeInfo> _repeated_selfPassData_codec = FieldCodec.ForMessage<AbyssChallengeInfo>(18U, AbyssChallengeInfo.Parser);

		// Token: 0x04001FFE RID: 8190
		private readonly RepeatedField<AbyssChallengeInfo> selfPassData_ = new RepeatedField<AbyssChallengeInfo>();
	}
}
