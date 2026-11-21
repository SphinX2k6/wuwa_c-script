using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA3 RID: 3491
	[NetMessage(EMessageId.PlayerTitleInfoUpdateNotify)]
	public sealed class PlayerTitleInfoUpdateNotify : IMessage<PlayerTitleInfoUpdateNotify>, IMessage, IEquatable<PlayerTitleInfoUpdateNotify>, IDeepCloneable<PlayerTitleInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06012D64 RID: 77156 RVA: 0x002C01F8 File Offset: 0x002BE3F8
		[NullableContext(1)]
		public static PlayerTitleInfoUpdateNotify Create()
		{
			return new PlayerTitleInfoUpdateNotify();
		}

		// Token: 0x17003E89 RID: 16009
		// (get) Token: 0x06012D65 RID: 77157 RVA: 0x002C01FF File Offset: 0x002BE3FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E8A RID: 16010
		// (get) Token: 0x06012D66 RID: 77158 RVA: 0x002C0202 File Offset: 0x002BE402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerTitleInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06012D67 RID: 77159 RVA: 0x002C0209 File Offset: 0x002BE409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleInfoUpdateNotify()
		{
		}

		// Token: 0x06012D68 RID: 77160 RVA: 0x002C0227 File Offset: 0x002BE427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleInfoUpdateNotify(PlayerTitleInfoUpdateNotify other) : this()
		{
			this.playerTitleInfo_ = other.playerTitleInfo_.Clone();
			this.playerTitleLimitInfos_ = other.playerTitleLimitInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012D69 RID: 77161 RVA: 0x002C0262 File Offset: 0x002BE462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleInfoUpdateNotify Clone()
		{
			return new PlayerTitleInfoUpdateNotify(this);
		}

		// Token: 0x17003E8B RID: 16011
		// (get) Token: 0x06012D6A RID: 77162 RVA: 0x002C026A File Offset: 0x002BE46A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerTitleInfo> PlayerTitleInfo
		{
			get
			{
				return this.playerTitleInfo_;
			}
		}

		// Token: 0x17003E8C RID: 16012
		// (get) Token: 0x06012D6B RID: 77163 RVA: 0x002C0272 File Offset: 0x002BE472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerTitleLimitInfo> PlayerTitleLimitInfos
		{
			get
			{
				return this.playerTitleLimitInfos_;
			}
		}

		// Token: 0x06012D6C RID: 77164 RVA: 0x002C027A File Offset: 0x002BE47A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerTitleInfoUpdateNotify);
		}

		// Token: 0x06012D6D RID: 77165 RVA: 0x002C0288 File Offset: 0x002BE488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerTitleInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.playerTitleInfo_.Equals(other.playerTitleInfo_) && this.playerTitleLimitInfos_.Equals(other.playerTitleLimitInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012D6E RID: 77166 RVA: 0x002C02DC File Offset: 0x002BE4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playerTitleInfo_.GetHashCode();
			num ^= this.playerTitleLimitInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012D6F RID: 77167 RVA: 0x002C031E File Offset: 0x002BE51E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012D70 RID: 77168 RVA: 0x002C032B File Offset: 0x002BE52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012D71 RID: 77169 RVA: 0x002C0334 File Offset: 0x002BE534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerTitleInfo_.WriteTo(ref output, PlayerTitleInfoUpdateNotify._repeated_playerTitleInfo_codec);
			this.playerTitleLimitInfos_.WriteTo(ref output, PlayerTitleInfoUpdateNotify._repeated_playerTitleLimitInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012D72 RID: 77170 RVA: 0x002C036C File Offset: 0x002BE56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerTitleInfo_.CalculateSize(PlayerTitleInfoUpdateNotify._repeated_playerTitleInfo_codec);
			num += this.playerTitleLimitInfos_.CalculateSize(PlayerTitleInfoUpdateNotify._repeated_playerTitleLimitInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012D73 RID: 77171 RVA: 0x002C03B8 File Offset: 0x002BE5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerTitleInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.playerTitleInfo_.Add(other.playerTitleInfo_);
			this.playerTitleLimitInfos_.Add(other.playerTitleLimitInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012D74 RID: 77172 RVA: 0x002C03F7 File Offset: 0x002BE5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012D75 RID: 77173 RVA: 0x002C0400 File Offset: 0x002BE600
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
				if (num != 50U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.playerTitleLimitInfos_.AddEntriesFrom(ref input, PlayerTitleInfoUpdateNotify._repeated_playerTitleLimitInfos_codec);
					}
				}
				else
				{
					this.playerTitleInfo_.AddEntriesFrom(ref input, PlayerTitleInfoUpdateNotify._repeated_playerTitleInfo_codec);
				}
			}
		}

		// Token: 0x04007512 RID: 29970
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007513 RID: 29971
		public const int PlayerTitleInfoFieldNumber = 6;

		// Token: 0x04007514 RID: 29972
		private static readonly FieldCodec<PlayerTitleInfo> _repeated_playerTitleInfo_codec = FieldCodec.ForMessage<PlayerTitleInfo>(50U, Aki.Protocol.PlayerTitleInfo.Parser);

		// Token: 0x04007515 RID: 29973
		private readonly RepeatedField<PlayerTitleInfo> playerTitleInfo_ = new RepeatedField<PlayerTitleInfo>();

		// Token: 0x04007516 RID: 29974
		public const int PlayerTitleLimitInfosFieldNumber = 8;

		// Token: 0x04007517 RID: 29975
		private static readonly FieldCodec<PlayerTitleLimitInfo> _repeated_playerTitleLimitInfos_codec = FieldCodec.ForMessage<PlayerTitleLimitInfo>(66U, PlayerTitleLimitInfo.Parser);

		// Token: 0x04007518 RID: 29976
		private readonly RepeatedField<PlayerTitleLimitInfo> playerTitleLimitInfos_ = new RepeatedField<PlayerTitleLimitInfo>();
	}
}
