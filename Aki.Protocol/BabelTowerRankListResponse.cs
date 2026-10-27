using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200014E RID: 334
	[NetMessage(EMessageId.BabelTowerRankListResponse)]
	public sealed class BabelTowerRankListResponse : IMessage<BabelTowerRankListResponse>, IMessage, IEquatable<BabelTowerRankListResponse>, IDeepCloneable<BabelTowerRankListResponse>, IBufferMessage
	{
		// Token: 0x06002AA9 RID: 10921 RVA: 0x0006FB4D File Offset: 0x0006DD4D
		[NullableContext(1)]
		public static BabelTowerRankListResponse Create()
		{
			return new BabelTowerRankListResponse();
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06002AAA RID: 10922 RVA: 0x0006FB54 File Offset: 0x0006DD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06002AAB RID: 10923 RVA: 0x0006FB57 File Offset: 0x0006DD57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerRankListResponse.Descriptor;
			}
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x0006FB5E File Offset: 0x0006DD5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerRankListResponse()
		{
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x0006FB74 File Offset: 0x0006DD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerRankListResponse(BabelTowerRankListResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.friendPassData_ = other.friendPassData_.Clone();
			this.selfPassData_ = ((other.selfPassData_ != null) ? other.selfPassData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x0006FBD1 File Offset: 0x0006DDD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerRankListResponse Clone()
		{
			return new BabelTowerRankListResponse(this);
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06002AAF RID: 10927 RVA: 0x0006FBD9 File Offset: 0x0006DDD9
		// (set) Token: 0x06002AB0 RID: 10928 RVA: 0x0006FBE1 File Offset: 0x0006DDE1
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

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x0006FBEA File Offset: 0x0006DDEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PublicBabelTowerInfo> FriendPassData
		{
			get
			{
				return this.friendPassData_;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06002AB2 RID: 10930 RVA: 0x0006FBF2 File Offset: 0x0006DDF2
		// (set) Token: 0x06002AB3 RID: 10931 RVA: 0x0006FBFA File Offset: 0x0006DDFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicBabelTowerInfo SelfPassData
		{
			get
			{
				return this.selfPassData_;
			}
			set
			{
				this.selfPassData_ = value;
			}
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x0006FC03 File Offset: 0x0006DE03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerRankListResponse);
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x0006FC14 File Offset: 0x0006DE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerRankListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.friendPassData_.Equals(other.friendPassData_) && object.Equals(this.SelfPassData, other.SelfPassData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x0006FC78 File Offset: 0x0006DE78
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
			if (this.selfPassData_ != null)
			{
				num ^= this.SelfPassData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x0006FCE1 File Offset: 0x0006DEE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x0006FCEE File Offset: 0x0006DEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x0006FCF8 File Offset: 0x0006DEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.selfPassData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SelfPassData);
			}
			this.friendPassData_.WriteTo(ref output, BabelTowerRankListResponse._repeated_friendPassData_codec);
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

		// Token: 0x06002ABA RID: 10938 RVA: 0x0006FD64 File Offset: 0x0006DF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.friendPassData_.CalculateSize(BabelTowerRankListResponse._repeated_friendPassData_codec);
			if (this.selfPassData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelfPassData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x0006FDD0 File Offset: 0x0006DFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerRankListResponse other)
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
			if (other.selfPassData_ != null)
			{
				if (this.selfPassData_ == null)
				{
					this.SelfPassData = new PublicBabelTowerInfo();
				}
				this.SelfPassData.MergeFrom(other.SelfPassData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x0006FE49 File Offset: 0x0006E049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x0006FE54 File Offset: 0x0006E054
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
					if (num != 66U)
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
						this.friendPassData_.AddEntriesFrom(ref input, BabelTowerRankListResponse._repeated_friendPassData_codec);
					}
				}
				else
				{
					if (this.selfPassData_ == null)
					{
						this.SelfPassData = new PublicBabelTowerInfo();
					}
					input.ReadMessage(this.SelfPassData);
				}
			}
		}

		// Token: 0x04002771 RID: 10097
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002772 RID: 10098
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04002773 RID: 10099
		private ErrorCode errorCode_;

		// Token: 0x04002774 RID: 10100
		public const int FriendPassDataFieldNumber = 8;

		// Token: 0x04002775 RID: 10101
		private static readonly FieldCodec<PublicBabelTowerInfo> _repeated_friendPassData_codec = FieldCodec.ForMessage<PublicBabelTowerInfo>(66U, PublicBabelTowerInfo.Parser);

		// Token: 0x04002776 RID: 10102
		private readonly RepeatedField<PublicBabelTowerInfo> friendPassData_ = new RepeatedField<PublicBabelTowerInfo>();

		// Token: 0x04002777 RID: 10103
		public const int SelfPassDataFieldNumber = 3;

		// Token: 0x04002778 RID: 10104
		private PublicBabelTowerInfo selfPassData_;
	}
}
