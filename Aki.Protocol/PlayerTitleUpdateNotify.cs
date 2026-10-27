using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB7 RID: 3511
	[NetMessage(EMessageId.PlayerTitleUpdateNotify)]
	public sealed class PlayerTitleUpdateNotify : IMessage<PlayerTitleUpdateNotify>, IMessage, IEquatable<PlayerTitleUpdateNotify>, IDeepCloneable<PlayerTitleUpdateNotify>, IBufferMessage
	{
		// Token: 0x06012EB0 RID: 77488 RVA: 0x002C28A5 File Offset: 0x002C0AA5
		[NullableContext(1)]
		public static PlayerTitleUpdateNotify Create()
		{
			return new PlayerTitleUpdateNotify();
		}

		// Token: 0x17003ECF RID: 16079
		// (get) Token: 0x06012EB1 RID: 77489 RVA: 0x002C28AC File Offset: 0x002C0AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ED0 RID: 16080
		// (get) Token: 0x06012EB2 RID: 77490 RVA: 0x002C28AF File Offset: 0x002C0AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerTitleUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06012EB3 RID: 77491 RVA: 0x002C28B6 File Offset: 0x002C0AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleUpdateNotify()
		{
		}

		// Token: 0x06012EB4 RID: 77492 RVA: 0x002C28D4 File Offset: 0x002C0AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleUpdateNotify(PlayerTitleUpdateNotify other) : this()
		{
			this.playerTitleInfos_ = other.playerTitleInfos_.Clone();
			this.removedPlayerTitleIds_ = other.removedPlayerTitleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012EB5 RID: 77493 RVA: 0x002C290F File Offset: 0x002C0B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleUpdateNotify Clone()
		{
			return new PlayerTitleUpdateNotify(this);
		}

		// Token: 0x17003ED1 RID: 16081
		// (get) Token: 0x06012EB6 RID: 77494 RVA: 0x002C2917 File Offset: 0x002C0B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerTitleInfo> PlayerTitleInfos
		{
			get
			{
				return this.playerTitleInfos_;
			}
		}

		// Token: 0x17003ED2 RID: 16082
		// (get) Token: 0x06012EB7 RID: 77495 RVA: 0x002C291F File Offset: 0x002C0B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RemovedPlayerTitleIds
		{
			get
			{
				return this.removedPlayerTitleIds_;
			}
		}

		// Token: 0x06012EB8 RID: 77496 RVA: 0x002C2927 File Offset: 0x002C0B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerTitleUpdateNotify);
		}

		// Token: 0x06012EB9 RID: 77497 RVA: 0x002C2938 File Offset: 0x002C0B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerTitleUpdateNotify other)
		{
			return other != null && (other == this || (this.playerTitleInfos_.Equals(other.playerTitleInfos_) && this.removedPlayerTitleIds_.Equals(other.removedPlayerTitleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012EBA RID: 77498 RVA: 0x002C298C File Offset: 0x002C0B8C
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

		// Token: 0x06012EBB RID: 77499 RVA: 0x002C29CE File Offset: 0x002C0BCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012EBC RID: 77500 RVA: 0x002C29DB File Offset: 0x002C0BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012EBD RID: 77501 RVA: 0x002C29E4 File Offset: 0x002C0BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerTitleInfos_.WriteTo(ref output, PlayerTitleUpdateNotify._repeated_playerTitleInfos_codec);
			this.removedPlayerTitleIds_.WriteTo(ref output, PlayerTitleUpdateNotify._repeated_removedPlayerTitleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012EBE RID: 77502 RVA: 0x002C2A1C File Offset: 0x002C0C1C
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

		// Token: 0x06012EBF RID: 77503 RVA: 0x002C2A68 File Offset: 0x002C0C68
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

		// Token: 0x06012EC0 RID: 77504 RVA: 0x002C2AA7 File Offset: 0x002C0CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012EC1 RID: 77505 RVA: 0x002C2AB0 File Offset: 0x002C0CB0
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
				if (num != 34U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.removedPlayerTitleIds_.AddEntriesFrom(ref input, PlayerTitleUpdateNotify._repeated_removedPlayerTitleIds_codec);
					}
				}
				else
				{
					this.playerTitleInfos_.AddEntriesFrom(ref input, PlayerTitleUpdateNotify._repeated_playerTitleInfos_codec);
				}
			}
		}

		// Token: 0x04007513 RID: 29971
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007514 RID: 29972
		public const int PlayerTitleInfosFieldNumber = 4;

		// Token: 0x04007515 RID: 29973
		private static readonly FieldCodec<PlayerTitleInfo> _repeated_playerTitleInfos_codec = FieldCodec.ForMessage<PlayerTitleInfo>(34U, PlayerTitleInfo.Parser);

		// Token: 0x04007516 RID: 29974
		private readonly RepeatedField<PlayerTitleInfo> playerTitleInfos_ = new RepeatedField<PlayerTitleInfo>();

		// Token: 0x04007517 RID: 29975
		public const int RemovedPlayerTitleIdsFieldNumber = 13;

		// Token: 0x04007518 RID: 29976
		private static readonly FieldCodec<int> _repeated_removedPlayerTitleIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04007519 RID: 29977
		private readonly RepeatedField<int> removedPlayerTitleIds_ = new RepeatedField<int>();
	}
}
