using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000636 RID: 1590
	[NetMessage(EMessageId.FriendAllResponse)]
	public sealed class FriendAllResponse : IMessage<FriendAllResponse>, IMessage, IEquatable<FriendAllResponse>, IDeepCloneable<FriendAllResponse>, IBufferMessage
	{
		// Token: 0x060092CB RID: 37579 RVA: 0x001636D2 File Offset: 0x001618D2
		[NullableContext(1)]
		public static FriendAllResponse Create()
		{
			return new FriendAllResponse();
		}

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x060092CC RID: 37580 RVA: 0x001636D9 File Offset: 0x001618D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x060092CD RID: 37581 RVA: 0x001636DC File Offset: 0x001618DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendAllResponse.Descriptor;
			}
		}

		// Token: 0x060092CE RID: 37582 RVA: 0x001636E3 File Offset: 0x001618E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendAllResponse()
		{
		}

		// Token: 0x060092CF RID: 37583 RVA: 0x00163704 File Offset: 0x00161904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendAllResponse(FriendAllResponse other) : this()
		{
			this.friendInfoList_ = other.friendInfoList_.Clone();
			this.friendApplyList_ = other.friendApplyList_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060092D0 RID: 37584 RVA: 0x00163756 File Offset: 0x00161956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendAllResponse Clone()
		{
			return new FriendAllResponse(this);
		}

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x060092D1 RID: 37585 RVA: 0x0016375E File Offset: 0x0016195E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FriendInfo> FriendInfoList
		{
			get
			{
				return this.friendInfoList_;
			}
		}

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x060092D2 RID: 37586 RVA: 0x00163766 File Offset: 0x00161966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FriendApply> FriendApplyList
		{
			get
			{
				return this.friendApplyList_;
			}
		}

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x060092D3 RID: 37587 RVA: 0x0016376E File Offset: 0x0016196E
		// (set) Token: 0x060092D4 RID: 37588 RVA: 0x00163776 File Offset: 0x00161976
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

		// Token: 0x060092D5 RID: 37589 RVA: 0x0016377F File Offset: 0x0016197F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendAllResponse);
		}

		// Token: 0x060092D6 RID: 37590 RVA: 0x00163790 File Offset: 0x00161990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendAllResponse other)
		{
			return other != null && (other == this || (this.friendInfoList_.Equals(other.friendInfoList_) && this.friendApplyList_.Equals(other.friendApplyList_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060092D7 RID: 37591 RVA: 0x001637F4 File Offset: 0x001619F4
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

		// Token: 0x060092D8 RID: 37592 RVA: 0x00163855 File Offset: 0x00161A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060092D9 RID: 37593 RVA: 0x00163862 File Offset: 0x00161A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060092DA RID: 37594 RVA: 0x0016386C File Offset: 0x00161A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.friendApplyList_.WriteTo(ref output, FriendAllResponse._repeated_friendApplyList_codec);
			this.friendInfoList_.WriteTo(ref output, FriendAllResponse._repeated_friendInfoList_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060092DB RID: 37595 RVA: 0x001638CC File Offset: 0x00161ACC
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

		// Token: 0x060092DC RID: 37596 RVA: 0x00163930 File Offset: 0x00161B30
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

		// Token: 0x060092DD RID: 37597 RVA: 0x0016398E File Offset: 0x00161B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060092DE RID: 37598 RVA: 0x00163998 File Offset: 0x00161B98
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
				if (num != 26U)
				{
					if (num != 58U)
					{
						if (num != 80U)
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
						this.friendInfoList_.AddEntriesFrom(ref input, FriendAllResponse._repeated_friendInfoList_codec);
					}
				}
				else
				{
					this.friendApplyList_.AddEntriesFrom(ref input, FriendAllResponse._repeated_friendApplyList_codec);
				}
			}
		}

		// Token: 0x04004709 RID: 18185
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400470A RID: 18186
		public const int FriendInfoListFieldNumber = 7;

		// Token: 0x0400470B RID: 18187
		private static readonly FieldCodec<FriendInfo> _repeated_friendInfoList_codec = FieldCodec.ForMessage<FriendInfo>(58U, FriendInfo.Parser);

		// Token: 0x0400470C RID: 18188
		private readonly RepeatedField<FriendInfo> friendInfoList_ = new RepeatedField<FriendInfo>();

		// Token: 0x0400470D RID: 18189
		public const int FriendApplyListFieldNumber = 3;

		// Token: 0x0400470E RID: 18190
		private static readonly FieldCodec<FriendApply> _repeated_friendApplyList_codec = FieldCodec.ForMessage<FriendApply>(26U, FriendApply.Parser);

		// Token: 0x0400470F RID: 18191
		private readonly RepeatedField<FriendApply> friendApplyList_ = new RepeatedField<FriendApply>();

		// Token: 0x04004710 RID: 18192
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04004711 RID: 18193
		private ErrorCode errorCode_;
	}
}
