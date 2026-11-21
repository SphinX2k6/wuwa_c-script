using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA7 RID: 3495
	[NetMessage(EMessageId.PlayerTitleUpdateNotify)]
	public sealed class PlayerTitleUpdateNotify : IMessage<PlayerTitleUpdateNotify>, IMessage, IEquatable<PlayerTitleUpdateNotify>, IDeepCloneable<PlayerTitleUpdateNotify>, IBufferMessage
	{
		// Token: 0x06012DB4 RID: 77236 RVA: 0x002C0C81 File Offset: 0x002BEE81
		[NullableContext(1)]
		public static PlayerTitleUpdateNotify Create()
		{
			return new PlayerTitleUpdateNotify();
		}

		// Token: 0x17003E9A RID: 16026
		// (get) Token: 0x06012DB5 RID: 77237 RVA: 0x002C0C88 File Offset: 0x002BEE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E9B RID: 16027
		// (get) Token: 0x06012DB6 RID: 77238 RVA: 0x002C0C8B File Offset: 0x002BEE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerTitleUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06012DB7 RID: 77239 RVA: 0x002C0C92 File Offset: 0x002BEE92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleUpdateNotify()
		{
		}

		// Token: 0x06012DB8 RID: 77240 RVA: 0x002C0CB0 File Offset: 0x002BEEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleUpdateNotify(PlayerTitleUpdateNotify other) : this()
		{
			this.playerTitleInfos_ = other.playerTitleInfos_.Clone();
			this.removedPlayerTitleIds_ = other.removedPlayerTitleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012DB9 RID: 77241 RVA: 0x002C0CEB File Offset: 0x002BEEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleUpdateNotify Clone()
		{
			return new PlayerTitleUpdateNotify(this);
		}

		// Token: 0x17003E9C RID: 16028
		// (get) Token: 0x06012DBA RID: 77242 RVA: 0x002C0CF3 File Offset: 0x002BEEF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerTitleInfo> PlayerTitleInfos
		{
			get
			{
				return this.playerTitleInfos_;
			}
		}

		// Token: 0x17003E9D RID: 16029
		// (get) Token: 0x06012DBB RID: 77243 RVA: 0x002C0CFB File Offset: 0x002BEEFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RemovedPlayerTitleIds
		{
			get
			{
				return this.removedPlayerTitleIds_;
			}
		}

		// Token: 0x06012DBC RID: 77244 RVA: 0x002C0D03 File Offset: 0x002BEF03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerTitleUpdateNotify);
		}

		// Token: 0x06012DBD RID: 77245 RVA: 0x002C0D14 File Offset: 0x002BEF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerTitleUpdateNotify other)
		{
			return other != null && (other == this || (this.playerTitleInfos_.Equals(other.playerTitleInfos_) && this.removedPlayerTitleIds_.Equals(other.removedPlayerTitleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012DBE RID: 77246 RVA: 0x002C0D68 File Offset: 0x002BEF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playerTitleInfos_.GetHashCode();
			num ^= this.removedPlayerTitleIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012DBF RID: 77247 RVA: 0x002C0DAA File Offset: 0x002BEFAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012DC0 RID: 77248 RVA: 0x002C0DB7 File Offset: 0x002BEFB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012DC1 RID: 77249 RVA: 0x002C0DC0 File Offset: 0x002BEFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.removedPlayerTitleIds_.WriteTo(ref output, PlayerTitleUpdateNotify._repeated_removedPlayerTitleIds_codec);
			this.playerTitleInfos_.WriteTo(ref output, PlayerTitleUpdateNotify._repeated_playerTitleInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012DC2 RID: 77250 RVA: 0x002C0DF8 File Offset: 0x002BEFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerTitleInfos_.CalculateSize(PlayerTitleUpdateNotify._repeated_playerTitleInfos_codec);
			num += this.removedPlayerTitleIds_.CalculateSize(PlayerTitleUpdateNotify._repeated_removedPlayerTitleIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012DC3 RID: 77251 RVA: 0x002C0E44 File Offset: 0x002BF044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerTitleUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.playerTitleInfos_.Add(other.playerTitleInfos_);
			this.removedPlayerTitleIds_.Add(other.removedPlayerTitleIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012DC4 RID: 77252 RVA: 0x002C0E83 File Offset: 0x002BF083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012DC5 RID: 77253 RVA: 0x002C0E8C File Offset: 0x002BF08C
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
				if (num != 56U && num != 58U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.playerTitleInfos_.AddEntriesFrom(ref input, PlayerTitleUpdateNotify._repeated_playerTitleInfos_codec);
					}
				}
				else
				{
					this.removedPlayerTitleIds_.AddEntriesFrom(ref input, PlayerTitleUpdateNotify._repeated_removedPlayerTitleIds_codec);
				}
			}
		}

		// Token: 0x0400752B RID: 29995
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400752C RID: 29996
		public const int PlayerTitleInfosFieldNumber = 11;

		// Token: 0x0400752D RID: 29997
		private static readonly FieldCodec<PlayerTitleInfo> _repeated_playerTitleInfos_codec = FieldCodec.ForMessage<PlayerTitleInfo>(90U, PlayerTitleInfo.Parser);

		// Token: 0x0400752E RID: 29998
		private readonly RepeatedField<PlayerTitleInfo> playerTitleInfos_ = new RepeatedField<PlayerTitleInfo>();

		// Token: 0x0400752F RID: 29999
		public const int RemovedPlayerTitleIdsFieldNumber = 7;

		// Token: 0x04007530 RID: 30000
		private static readonly FieldCodec<int> _repeated_removedPlayerTitleIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04007531 RID: 30001
		private readonly RepeatedField<int> removedPlayerTitleIds_ = new RepeatedField<int>();
	}
}
