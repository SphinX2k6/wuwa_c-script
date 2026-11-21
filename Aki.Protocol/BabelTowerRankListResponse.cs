using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000151 RID: 337
	[NetMessage(EMessageId.BabelTowerRankListResponse)]
	public sealed class BabelTowerRankListResponse : IMessage<BabelTowerRankListResponse>, IMessage, IEquatable<BabelTowerRankListResponse>, IDeepCloneable<BabelTowerRankListResponse>, IBufferMessage
	{
		// Token: 0x06002B20 RID: 11040 RVA: 0x00070F81 File Offset: 0x0006F181
		[NullableContext(1)]
		public static BabelTowerRankListResponse Create()
		{
			return new BabelTowerRankListResponse();
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06002B21 RID: 11041 RVA: 0x00070F88 File Offset: 0x0006F188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06002B22 RID: 11042 RVA: 0x00070F8B File Offset: 0x0006F18B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerRankListResponse.Descriptor;
			}
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x00070F92 File Offset: 0x0006F192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerRankListResponse()
		{
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x00070FA8 File Offset: 0x0006F1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerRankListResponse(BabelTowerRankListResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.friendPassData_ = other.friendPassData_.Clone();
			this.selfPassData_ = ((other.selfPassData_ != null) ? other.selfPassData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x00071005 File Offset: 0x0006F205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerRankListResponse Clone()
		{
			return new BabelTowerRankListResponse(this);
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06002B26 RID: 11046 RVA: 0x0007100D File Offset: 0x0006F20D
		// (set) Token: 0x06002B27 RID: 11047 RVA: 0x00071015 File Offset: 0x0006F215
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

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06002B28 RID: 11048 RVA: 0x0007101E File Offset: 0x0006F21E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PublicBabelTowerInfo> FriendPassData
		{
			get
			{
				return this.friendPassData_;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06002B29 RID: 11049 RVA: 0x00071026 File Offset: 0x0006F226
		// (set) Token: 0x06002B2A RID: 11050 RVA: 0x0007102E File Offset: 0x0006F22E
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

		// Token: 0x06002B2B RID: 11051 RVA: 0x00071037 File Offset: 0x0006F237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerRankListResponse);
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x00071048 File Offset: 0x0006F248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerRankListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.friendPassData_.Equals(other.friendPassData_) && object.Equals(this.SelfPassData, other.SelfPassData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x000710AC File Offset: 0x0006F2AC
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

		// Token: 0x06002B2E RID: 11054 RVA: 0x00071115 File Offset: 0x0006F315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x00071122 File Offset: 0x0006F322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x0007112C File Offset: 0x0006F32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.selfPassData_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.SelfPassData);
			}
			this.friendPassData_.WriteTo(ref output, BabelTowerRankListResponse._repeated_friendPassData_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x00071198 File Offset: 0x0006F398
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

		// Token: 0x06002B32 RID: 11058 RVA: 0x00071204 File Offset: 0x0006F404
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

		// Token: 0x06002B33 RID: 11059 RVA: 0x0007127D File Offset: 0x0006F47D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x00071288 File Offset: 0x0006F488
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
				if (num != 8U)
				{
					if (num != 34U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040027E5 RID: 10213
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027E6 RID: 10214
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040027E7 RID: 10215
		private ErrorCode errorCode_;

		// Token: 0x040027E8 RID: 10216
		public const int FriendPassDataFieldNumber = 14;

		// Token: 0x040027E9 RID: 10217
		private static readonly FieldCodec<PublicBabelTowerInfo> _repeated_friendPassData_codec = FieldCodec.ForMessage<PublicBabelTowerInfo>(114U, PublicBabelTowerInfo.Parser);

		// Token: 0x040027EA RID: 10218
		private readonly RepeatedField<PublicBabelTowerInfo> friendPassData_ = new RepeatedField<PublicBabelTowerInfo>();

		// Token: 0x040027EB RID: 10219
		public const int SelfPassDataFieldNumber = 4;

		// Token: 0x040027EC RID: 10220
		private PublicBabelTowerInfo selfPassData_;
	}
}
