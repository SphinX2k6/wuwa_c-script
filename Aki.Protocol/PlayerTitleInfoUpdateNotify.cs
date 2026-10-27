using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB3 RID: 3507
	[NetMessage(EMessageId.PlayerTitleInfoUpdateNotify)]
	public sealed class PlayerTitleInfoUpdateNotify : IMessage<PlayerTitleInfoUpdateNotify>, IMessage, IEquatable<PlayerTitleInfoUpdateNotify>, IDeepCloneable<PlayerTitleInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06012E60 RID: 77408 RVA: 0x002C1E1C File Offset: 0x002C001C
		[NullableContext(1)]
		public static PlayerTitleInfoUpdateNotify Create()
		{
			return new PlayerTitleInfoUpdateNotify();
		}

		// Token: 0x17003EBE RID: 16062
		// (get) Token: 0x06012E61 RID: 77409 RVA: 0x002C1E23 File Offset: 0x002C0023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EBF RID: 16063
		// (get) Token: 0x06012E62 RID: 77410 RVA: 0x002C1E26 File Offset: 0x002C0026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerTitleInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06012E63 RID: 77411 RVA: 0x002C1E2D File Offset: 0x002C002D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleInfoUpdateNotify()
		{
		}

		// Token: 0x06012E64 RID: 77412 RVA: 0x002C1E4B File Offset: 0x002C004B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleInfoUpdateNotify(PlayerTitleInfoUpdateNotify other) : this()
		{
			this.playerTitleInfo_ = other.playerTitleInfo_.Clone();
			this.playerTitleLimitInfos_ = other.playerTitleLimitInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012E65 RID: 77413 RVA: 0x002C1E86 File Offset: 0x002C0086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleInfoUpdateNotify Clone()
		{
			return new PlayerTitleInfoUpdateNotify(this);
		}

		// Token: 0x17003EC0 RID: 16064
		// (get) Token: 0x06012E66 RID: 77414 RVA: 0x002C1E8E File Offset: 0x002C008E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerTitleInfo> PlayerTitleInfo
		{
			get
			{
				return this.playerTitleInfo_;
			}
		}

		// Token: 0x17003EC1 RID: 16065
		// (get) Token: 0x06012E67 RID: 77415 RVA: 0x002C1E96 File Offset: 0x002C0096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerTitleLimitInfo> PlayerTitleLimitInfos
		{
			get
			{
				return this.playerTitleLimitInfos_;
			}
		}

		// Token: 0x06012E68 RID: 77416 RVA: 0x002C1E9E File Offset: 0x002C009E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerTitleInfoUpdateNotify);
		}

		// Token: 0x06012E69 RID: 77417 RVA: 0x002C1EAC File Offset: 0x002C00AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerTitleInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.playerTitleInfo_.Equals(other.playerTitleInfo_) && this.playerTitleLimitInfos_.Equals(other.playerTitleLimitInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012E6A RID: 77418 RVA: 0x002C1F00 File Offset: 0x002C0100
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

		// Token: 0x06012E6B RID: 77419 RVA: 0x002C1F42 File Offset: 0x002C0142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012E6C RID: 77420 RVA: 0x002C1F4F File Offset: 0x002C014F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012E6D RID: 77421 RVA: 0x002C1F58 File Offset: 0x002C0158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerTitleLimitInfos_.WriteTo(ref output, PlayerTitleInfoUpdateNotify._repeated_playerTitleLimitInfos_codec);
			this.playerTitleInfo_.WriteTo(ref output, PlayerTitleInfoUpdateNotify._repeated_playerTitleInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012E6E RID: 77422 RVA: 0x002C1F90 File Offset: 0x002C0190
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

		// Token: 0x06012E6F RID: 77423 RVA: 0x002C1FDC File Offset: 0x002C01DC
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

		// Token: 0x06012E70 RID: 77424 RVA: 0x002C201B File Offset: 0x002C021B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012E71 RID: 77425 RVA: 0x002C2024 File Offset: 0x002C0224
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
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.playerTitleInfo_.AddEntriesFrom(ref input, PlayerTitleInfoUpdateNotify._repeated_playerTitleInfo_codec);
					}
				}
				else
				{
					this.playerTitleLimitInfos_.AddEntriesFrom(ref input, PlayerTitleInfoUpdateNotify._repeated_playerTitleLimitInfos_codec);
				}
			}
		}

		// Token: 0x040074FA RID: 29946
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074FB RID: 29947
		public const int PlayerTitleInfoFieldNumber = 11;

		// Token: 0x040074FC RID: 29948
		private static readonly FieldCodec<PlayerTitleInfo> _repeated_playerTitleInfo_codec = FieldCodec.ForMessage<PlayerTitleInfo>(90U, Aki.Protocol.PlayerTitleInfo.Parser);

		// Token: 0x040074FD RID: 29949
		private readonly RepeatedField<PlayerTitleInfo> playerTitleInfo_ = new RepeatedField<PlayerTitleInfo>();

		// Token: 0x040074FE RID: 29950
		public const int PlayerTitleLimitInfosFieldNumber = 2;

		// Token: 0x040074FF RID: 29951
		private static readonly FieldCodec<PlayerTitleLimitInfo> _repeated_playerTitleLimitInfos_codec = FieldCodec.ForMessage<PlayerTitleLimitInfo>(18U, PlayerTitleLimitInfo.Parser);

		// Token: 0x04007500 RID: 29952
		private readonly RepeatedField<PlayerTitleLimitInfo> playerTitleLimitInfos_ = new RepeatedField<PlayerTitleLimitInfo>();
	}
}
