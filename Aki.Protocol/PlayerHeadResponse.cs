using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D95 RID: 3477
	[NetMessage(EMessageId.PlayerHeadResponse)]
	public sealed class PlayerHeadResponse : IMessage<PlayerHeadResponse>, IMessage, IEquatable<PlayerHeadResponse>, IDeepCloneable<PlayerHeadResponse>, IBufferMessage
	{
		// Token: 0x06012BEE RID: 76782 RVA: 0x002BC59E File Offset: 0x002BA79E
		[NullableContext(1)]
		public static PlayerHeadResponse Create()
		{
			return new PlayerHeadResponse();
		}

		// Token: 0x17003E36 RID: 15926
		// (get) Token: 0x06012BEF RID: 76783 RVA: 0x002BC5A5 File Offset: 0x002BA7A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E37 RID: 15927
		// (get) Token: 0x06012BF0 RID: 76784 RVA: 0x002BC5A8 File Offset: 0x002BA7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerHeadResponse.Descriptor;
			}
		}

		// Token: 0x06012BF1 RID: 76785 RVA: 0x002BC5AF File Offset: 0x002BA7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadResponse()
		{
		}

		// Token: 0x06012BF2 RID: 76786 RVA: 0x002BC5C2 File Offset: 0x002BA7C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadResponse(PlayerHeadResponse other) : this()
		{
			this.playerHeadIds_ = other.playerHeadIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012BF3 RID: 76787 RVA: 0x002BC5EC File Offset: 0x002BA7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadResponse Clone()
		{
			return new PlayerHeadResponse(this);
		}

		// Token: 0x17003E38 RID: 15928
		// (get) Token: 0x06012BF4 RID: 76788 RVA: 0x002BC5F4 File Offset: 0x002BA7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PlayerHeadIds
		{
			get
			{
				return this.playerHeadIds_;
			}
		}

		// Token: 0x06012BF5 RID: 76789 RVA: 0x002BC5FC File Offset: 0x002BA7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerHeadResponse);
		}

		// Token: 0x06012BF6 RID: 76790 RVA: 0x002BC60A File Offset: 0x002BA80A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerHeadResponse other)
		{
			return other != null && (other == this || (this.playerHeadIds_.Equals(other.playerHeadIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012BF7 RID: 76791 RVA: 0x002BC640 File Offset: 0x002BA840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playerHeadIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012BF8 RID: 76792 RVA: 0x002BC674 File Offset: 0x002BA874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012BF9 RID: 76793 RVA: 0x002BC681 File Offset: 0x002BA881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012BFA RID: 76794 RVA: 0x002BC68A File Offset: 0x002BA88A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerHeadIds_.WriteTo(ref output, PlayerHeadResponse._repeated_playerHeadIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012BFB RID: 76795 RVA: 0x002BC6B4 File Offset: 0x002BA8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerHeadIds_.CalculateSize(PlayerHeadResponse._repeated_playerHeadIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012BFC RID: 76796 RVA: 0x002BC6ED File Offset: 0x002BA8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerHeadResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.playerHeadIds_.Add(other.playerHeadIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012BFD RID: 76797 RVA: 0x002BC71B File Offset: 0x002BA91B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012BFE RID: 76798 RVA: 0x002BC724 File Offset: 0x002BA924
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.playerHeadIds_.AddEntriesFrom(ref input, PlayerHeadResponse._repeated_playerHeadIds_codec);
				}
			}
		}

		// Token: 0x0400743B RID: 29755
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400743C RID: 29756
		public const int PlayerHeadIdsFieldNumber = 9;

		// Token: 0x0400743D RID: 29757
		private static readonly FieldCodec<int> _repeated_playerHeadIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400743E RID: 29758
		private readonly RepeatedField<int> playerHeadIds_ = new RepeatedField<int>();
	}
}
