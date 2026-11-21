using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D38 RID: 3384
	[NetMessage(EMessageId.PinballFriendRankResponse)]
	public sealed class PinballFriendRankResponse : IMessage<PinballFriendRankResponse>, IMessage, IEquatable<PinballFriendRankResponse>, IDeepCloneable<PinballFriendRankResponse>, IBufferMessage
	{
		// Token: 0x06012481 RID: 74881 RVA: 0x002AB6F2 File Offset: 0x002A98F2
		[NullableContext(1)]
		public static PinballFriendRankResponse Create()
		{
			return new PinballFriendRankResponse();
		}

		// Token: 0x17003C92 RID: 15506
		// (get) Token: 0x06012482 RID: 74882 RVA: 0x002AB6F9 File Offset: 0x002A98F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C93 RID: 15507
		// (get) Token: 0x06012483 RID: 74883 RVA: 0x002AB6FC File Offset: 0x002A98FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballFriendRankResponse.Descriptor;
			}
		}

		// Token: 0x06012484 RID: 74884 RVA: 0x002AB703 File Offset: 0x002A9903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFriendRankResponse()
		{
		}

		// Token: 0x06012485 RID: 74885 RVA: 0x002AB718 File Offset: 0x002A9918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFriendRankResponse(PinballFriendRankResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rankData_ = other.rankData_.Clone();
			this.playerSelf_ = ((other.playerSelf_ != null) ? other.playerSelf_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012486 RID: 74886 RVA: 0x002AB775 File Offset: 0x002A9975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFriendRankResponse Clone()
		{
			return new PinballFriendRankResponse(this);
		}

		// Token: 0x17003C94 RID: 15508
		// (get) Token: 0x06012487 RID: 74887 RVA: 0x002AB77D File Offset: 0x002A997D
		// (set) Token: 0x06012488 RID: 74888 RVA: 0x002AB785 File Offset: 0x002A9985
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

		// Token: 0x17003C95 RID: 15509
		// (get) Token: 0x06012489 RID: 74889 RVA: 0x002AB78E File Offset: 0x002A998E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PinballRankData> RankData
		{
			get
			{
				return this.rankData_;
			}
		}

		// Token: 0x17003C96 RID: 15510
		// (get) Token: 0x0601248A RID: 74890 RVA: 0x002AB796 File Offset: 0x002A9996
		// (set) Token: 0x0601248B RID: 74891 RVA: 0x002AB79E File Offset: 0x002A999E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRankData PlayerSelf
		{
			get
			{
				return this.playerSelf_;
			}
			set
			{
				this.playerSelf_ = value;
			}
		}

		// Token: 0x0601248C RID: 74892 RVA: 0x002AB7A7 File Offset: 0x002A99A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballFriendRankResponse);
		}

		// Token: 0x0601248D RID: 74893 RVA: 0x002AB7B8 File Offset: 0x002A99B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballFriendRankResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.rankData_.Equals(other.rankData_) && object.Equals(this.PlayerSelf, other.PlayerSelf) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601248E RID: 74894 RVA: 0x002AB81C File Offset: 0x002A9A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.rankData_.GetHashCode();
			if (this.playerSelf_ != null)
			{
				num ^= this.PlayerSelf.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601248F RID: 74895 RVA: 0x002AB885 File Offset: 0x002A9A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012490 RID: 74896 RVA: 0x002AB892 File Offset: 0x002A9A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012491 RID: 74897 RVA: 0x002AB89C File Offset: 0x002A9A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.rankData_.WriteTo(ref output, PinballFriendRankResponse._repeated_rankData_codec);
			if (this.playerSelf_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.PlayerSelf);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012492 RID: 74898 RVA: 0x002AB908 File Offset: 0x002A9B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.rankData_.CalculateSize(PinballFriendRankResponse._repeated_rankData_codec);
			if (this.playerSelf_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerSelf);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012493 RID: 74899 RVA: 0x002AB974 File Offset: 0x002A9B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballFriendRankResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.rankData_.Add(other.rankData_);
			if (other.playerSelf_ != null)
			{
				if (this.playerSelf_ == null)
				{
					this.PlayerSelf = new PinballRankData();
				}
				this.PlayerSelf.MergeFrom(other.PlayerSelf);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012494 RID: 74900 RVA: 0x002AB9ED File Offset: 0x002A9BED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012495 RID: 74901 RVA: 0x002AB9F8 File Offset: 0x002A9BF8
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
					if (num != 42U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.playerSelf_ == null)
							{
								this.PlayerSelf = new PinballRankData();
							}
							input.ReadMessage(this.PlayerSelf);
						}
					}
					else
					{
						this.rankData_.AddEntriesFrom(ref input, PinballFriendRankResponse._repeated_rankData_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007261 RID: 29281
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007262 RID: 29282
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04007263 RID: 29283
		private ErrorCode errorCode_;

		// Token: 0x04007264 RID: 29284
		public const int RankDataFieldNumber = 5;

		// Token: 0x04007265 RID: 29285
		private static readonly FieldCodec<PinballRankData> _repeated_rankData_codec = FieldCodec.ForMessage<PinballRankData>(42U, PinballRankData.Parser);

		// Token: 0x04007266 RID: 29286
		private readonly RepeatedField<PinballRankData> rankData_ = new RepeatedField<PinballRankData>();

		// Token: 0x04007267 RID: 29287
		public const int PlayerSelfFieldNumber = 11;

		// Token: 0x04007268 RID: 29288
		private PinballRankData playerSelf_;
	}
}
