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
		// Token: 0x06001342 RID: 4930 RVA: 0x000345C9 File Offset: 0x000327C9
		[NullableContext(1)]
		public static AbyssRankListResponse Create()
		{
			return new AbyssRankListResponse();
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x000345D0 File Offset: 0x000327D0
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
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x000345D3 File Offset: 0x000327D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRankListResponse.Descriptor;
			}
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x000345DA File Offset: 0x000327DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRankListResponse()
		{
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x000345F8 File Offset: 0x000327F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRankListResponse(AbyssRankListResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.friendPassData_ = other.friendPassData_.Clone();
			this.selfPassData_ = other.selfPassData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x0003464A File Offset: 0x0003284A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRankListResponse Clone()
		{
			return new AbyssRankListResponse(this);
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x00034652 File Offset: 0x00032852
		// (set) Token: 0x06001349 RID: 4937 RVA: 0x0003465A File Offset: 0x0003285A
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
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x00034663 File Offset: 0x00032863
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
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x0003466B File Offset: 0x0003286B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssChallengeInfo> SelfPassData
		{
			get
			{
				return this.selfPassData_;
			}
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00034673 File Offset: 0x00032873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRankListResponse);
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x00034684 File Offset: 0x00032884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRankListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.friendPassData_.Equals(other.friendPassData_) && this.selfPassData_.Equals(other.selfPassData_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x000346E8 File Offset: 0x000328E8
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

		// Token: 0x0600134F RID: 4943 RVA: 0x00034749 File Offset: 0x00032949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00034756 File Offset: 0x00032956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00034760 File Offset: 0x00032960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.friendPassData_.WriteTo(ref output, AbyssRankListResponse._repeated_friendPassData_codec);
			this.selfPassData_.WriteTo(ref output, AbyssRankListResponse._repeated_selfPassData_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x000347C0 File Offset: 0x000329C0
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

		// Token: 0x06001353 RID: 4947 RVA: 0x00034824 File Offset: 0x00032A24
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

		// Token: 0x06001354 RID: 4948 RVA: 0x00034882 File Offset: 0x00032A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x0003488C File Offset: 0x00032A8C
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
					if (num != 66U)
					{
						if (num != 96U)
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
						this.selfPassData_.AddEntriesFrom(ref input, AbyssRankListResponse._repeated_selfPassData_codec);
					}
				}
				else
				{
					this.friendPassData_.AddEntriesFrom(ref input, AbyssRankListResponse._repeated_friendPassData_codec);
				}
			}
		}

		// Token: 0x0400204C RID: 8268
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400204D RID: 8269
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400204E RID: 8270
		private ErrorCode errorCode_;

		// Token: 0x0400204F RID: 8271
		public const int FriendPassDataFieldNumber = 1;

		// Token: 0x04002050 RID: 8272
		private static readonly FieldCodec<AbyssChallengeInfo> _repeated_friendPassData_codec = FieldCodec.ForMessage<AbyssChallengeInfo>(10U, AbyssChallengeInfo.Parser);

		// Token: 0x04002051 RID: 8273
		private readonly RepeatedField<AbyssChallengeInfo> friendPassData_ = new RepeatedField<AbyssChallengeInfo>();

		// Token: 0x04002052 RID: 8274
		public const int SelfPassDataFieldNumber = 8;

		// Token: 0x04002053 RID: 8275
		private static readonly FieldCodec<AbyssChallengeInfo> _repeated_selfPassData_codec = FieldCodec.ForMessage<AbyssChallengeInfo>(66U, AbyssChallengeInfo.Parser);

		// Token: 0x04002054 RID: 8276
		private readonly RepeatedField<AbyssChallengeInfo> selfPassData_ = new RepeatedField<AbyssChallengeInfo>();
	}
}
