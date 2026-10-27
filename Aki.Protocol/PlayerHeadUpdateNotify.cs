using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D96 RID: 3478
	[NetMessage(EMessageId.PlayerHeadUpdateNotify)]
	public sealed class PlayerHeadUpdateNotify : IMessage<PlayerHeadUpdateNotify>, IMessage, IEquatable<PlayerHeadUpdateNotify>, IDeepCloneable<PlayerHeadUpdateNotify>, IBufferMessage
	{
		// Token: 0x06012C00 RID: 76800 RVA: 0x002BC781 File Offset: 0x002BA981
		[NullableContext(1)]
		public static PlayerHeadUpdateNotify Create()
		{
			return new PlayerHeadUpdateNotify();
		}

		// Token: 0x17003E39 RID: 15929
		// (get) Token: 0x06012C01 RID: 76801 RVA: 0x002BC788 File Offset: 0x002BA988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E3A RID: 15930
		// (get) Token: 0x06012C02 RID: 76802 RVA: 0x002BC78B File Offset: 0x002BA98B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerHeadUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06012C03 RID: 76803 RVA: 0x002BC792 File Offset: 0x002BA992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadUpdateNotify()
		{
		}

		// Token: 0x06012C04 RID: 76804 RVA: 0x002BC7A5 File Offset: 0x002BA9A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadUpdateNotify(PlayerHeadUpdateNotify other) : this()
		{
			this.playerHeadIds_ = other.playerHeadIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012C05 RID: 76805 RVA: 0x002BC7CF File Offset: 0x002BA9CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadUpdateNotify Clone()
		{
			return new PlayerHeadUpdateNotify(this);
		}

		// Token: 0x17003E3B RID: 15931
		// (get) Token: 0x06012C06 RID: 76806 RVA: 0x002BC7D7 File Offset: 0x002BA9D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PlayerHeadIds
		{
			get
			{
				return this.playerHeadIds_;
			}
		}

		// Token: 0x06012C07 RID: 76807 RVA: 0x002BC7DF File Offset: 0x002BA9DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerHeadUpdateNotify);
		}

		// Token: 0x06012C08 RID: 76808 RVA: 0x002BC7ED File Offset: 0x002BA9ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerHeadUpdateNotify other)
		{
			return other != null && (other == this || (this.playerHeadIds_.Equals(other.playerHeadIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012C09 RID: 76809 RVA: 0x002BC820 File Offset: 0x002BAA20
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

		// Token: 0x06012C0A RID: 76810 RVA: 0x002BC854 File Offset: 0x002BAA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012C0B RID: 76811 RVA: 0x002BC861 File Offset: 0x002BAA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012C0C RID: 76812 RVA: 0x002BC86A File Offset: 0x002BAA6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerHeadIds_.WriteTo(ref output, PlayerHeadUpdateNotify._repeated_playerHeadIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012C0D RID: 76813 RVA: 0x002BC894 File Offset: 0x002BAA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerHeadIds_.CalculateSize(PlayerHeadUpdateNotify._repeated_playerHeadIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012C0E RID: 76814 RVA: 0x002BC8CD File Offset: 0x002BAACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerHeadUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.playerHeadIds_.Add(other.playerHeadIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012C0F RID: 76815 RVA: 0x002BC8FB File Offset: 0x002BAAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012C10 RID: 76816 RVA: 0x002BC904 File Offset: 0x002BAB04
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
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.playerHeadIds_.AddEntriesFrom(ref input, PlayerHeadUpdateNotify._repeated_playerHeadIds_codec);
				}
			}
		}

		// Token: 0x0400743F RID: 29759
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007440 RID: 29760
		public const int PlayerHeadIdsFieldNumber = 13;

		// Token: 0x04007441 RID: 29761
		private static readonly FieldCodec<int> _repeated_playerHeadIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04007442 RID: 29762
		private readonly RepeatedField<int> playerHeadIds_ = new RepeatedField<int>();
	}
}
