using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200064A RID: 1610
	[NetMessage(EMessageId.FriendAllResponse)]
	public sealed class FriendAllResponse : IMessage<FriendAllResponse>, IMessage, IEquatable<FriendAllResponse>, IDeepCloneable<FriendAllResponse>, IBufferMessage
	{
		// Token: 0x06009421 RID: 37921 RVA: 0x00166102 File Offset: 0x00164302
		[NullableContext(1)]
		public static FriendAllResponse Create()
		{
			return new FriendAllResponse();
		}

		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x06009422 RID: 37922 RVA: 0x00166109 File Offset: 0x00164309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D7D RID: 7549
		// (get) Token: 0x06009423 RID: 37923 RVA: 0x0016610C File Offset: 0x0016430C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendAllResponse.Descriptor;
			}
		}

		// Token: 0x06009424 RID: 37924 RVA: 0x00166113 File Offset: 0x00164313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendAllResponse()
		{
		}

		// Token: 0x06009425 RID: 37925 RVA: 0x00166134 File Offset: 0x00164334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendAllResponse(FriendAllResponse other) : this()
		{
			this.friendInfoList_ = other.friendInfoList_.Clone();
			this.friendApplyList_ = other.friendApplyList_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009426 RID: 37926 RVA: 0x00166186 File Offset: 0x00164386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendAllResponse Clone()
		{
			return new FriendAllResponse(this);
		}

		// Token: 0x17001D7E RID: 7550
		// (get) Token: 0x06009427 RID: 37927 RVA: 0x0016618E File Offset: 0x0016438E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FriendInfo> FriendInfoList
		{
			get
			{
				return this.friendInfoList_;
			}
		}

		// Token: 0x17001D7F RID: 7551
		// (get) Token: 0x06009428 RID: 37928 RVA: 0x00166196 File Offset: 0x00164396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FriendApply> FriendApplyList
		{
			get
			{
				return this.friendApplyList_;
			}
		}

		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x06009429 RID: 37929 RVA: 0x0016619E File Offset: 0x0016439E
		// (set) Token: 0x0600942A RID: 37930 RVA: 0x001661A6 File Offset: 0x001643A6
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

		// Token: 0x0600942B RID: 37931 RVA: 0x001661AF File Offset: 0x001643AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendAllResponse);
		}

		// Token: 0x0600942C RID: 37932 RVA: 0x001661C0 File Offset: 0x001643C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendAllResponse other)
		{
			return other != null && (other == this || (this.friendInfoList_.Equals(other.friendInfoList_) && this.friendApplyList_.Equals(other.friendApplyList_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600942D RID: 37933 RVA: 0x00166224 File Offset: 0x00164424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.friendInfoList_.GetHashCode();
			num ^= this.friendApplyList_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600942E RID: 37934 RVA: 0x00166285 File Offset: 0x00164485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600942F RID: 37935 RVA: 0x00166292 File Offset: 0x00164492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009430 RID: 37936 RVA: 0x0016629C File Offset: 0x0016449C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.friendInfoList_.WriteTo(ref output, FriendAllResponse._repeated_friendInfoList_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.friendApplyList_.WriteTo(ref output, FriendAllResponse._repeated_friendApplyList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009431 RID: 37937 RVA: 0x001662FC File Offset: 0x001644FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.friendInfoList_.CalculateSize(FriendAllResponse._repeated_friendInfoList_codec);
			num += this.friendApplyList_.CalculateSize(FriendAllResponse._repeated_friendApplyList_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009432 RID: 37938 RVA: 0x00166360 File Offset: 0x00164560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendAllResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.friendInfoList_.Add(other.friendInfoList_);
			this.friendApplyList_.Add(other.friendApplyList_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009433 RID: 37939 RVA: 0x001663BE File Offset: 0x001645BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009434 RID: 37940 RVA: 0x001663C8 File Offset: 0x001645C8
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
				if (num != 42U)
				{
					if (num != 64U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.friendApplyList_.AddEntriesFrom(ref input, FriendAllResponse._repeated_friendApplyList_codec);
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.friendInfoList_.AddEntriesFrom(ref input, FriendAllResponse._repeated_friendInfoList_codec);
				}
			}
		}

		// Token: 0x04004710 RID: 18192
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004711 RID: 18193
		public const int FriendInfoListFieldNumber = 5;

		// Token: 0x04004712 RID: 18194
		private static readonly FieldCodec<FriendInfo> _repeated_friendInfoList_codec = FieldCodec.ForMessage<FriendInfo>(42U, FriendInfo.Parser);

		// Token: 0x04004713 RID: 18195
		private readonly RepeatedField<FriendInfo> friendInfoList_ = new RepeatedField<FriendInfo>();

		// Token: 0x04004714 RID: 18196
		public const int FriendApplyListFieldNumber = 11;

		// Token: 0x04004715 RID: 18197
		private static readonly FieldCodec<FriendApply> _repeated_friendApplyList_codec = FieldCodec.ForMessage<FriendApply>(90U, FriendApply.Parser);

		// Token: 0x04004716 RID: 18198
		private readonly RepeatedField<FriendApply> friendApplyList_ = new RepeatedField<FriendApply>();

		// Token: 0x04004717 RID: 18199
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04004718 RID: 18200
		private ErrorCode errorCode_;
	}
}
