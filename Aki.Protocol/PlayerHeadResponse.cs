using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D85 RID: 3461
	[NetMessage(EMessageId.PlayerHeadResponse)]
	public sealed class PlayerHeadResponse : IMessage<PlayerHeadResponse>, IMessage, IEquatable<PlayerHeadResponse>, IDeepCloneable<PlayerHeadResponse>, IBufferMessage
	{
		// Token: 0x06012AF2 RID: 76530 RVA: 0x002BA97A File Offset: 0x002B8B7A
		[NullableContext(1)]
		public static PlayerHeadResponse Create()
		{
			return new PlayerHeadResponse();
		}

		// Token: 0x17003E01 RID: 15873
		// (get) Token: 0x06012AF3 RID: 76531 RVA: 0x002BA981 File Offset: 0x002B8B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E02 RID: 15874
		// (get) Token: 0x06012AF4 RID: 76532 RVA: 0x002BA984 File Offset: 0x002B8B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerHeadResponse.Descriptor;
			}
		}

		// Token: 0x06012AF5 RID: 76533 RVA: 0x002BA98B File Offset: 0x002B8B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadResponse()
		{
		}

		// Token: 0x06012AF6 RID: 76534 RVA: 0x002BA99E File Offset: 0x002B8B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadResponse(PlayerHeadResponse other) : this()
		{
			this.playerHeadIds_ = other.playerHeadIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012AF7 RID: 76535 RVA: 0x002BA9C8 File Offset: 0x002B8BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadResponse Clone()
		{
			return new PlayerHeadResponse(this);
		}

		// Token: 0x17003E03 RID: 15875
		// (get) Token: 0x06012AF8 RID: 76536 RVA: 0x002BA9D0 File Offset: 0x002B8BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PlayerHeadIds
		{
			get
			{
				return this.playerHeadIds_;
			}
		}

		// Token: 0x06012AF9 RID: 76537 RVA: 0x002BA9D8 File Offset: 0x002B8BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerHeadResponse);
		}

		// Token: 0x06012AFA RID: 76538 RVA: 0x002BA9E6 File Offset: 0x002B8BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerHeadResponse other)
		{
			return other != null && (other == this || (this.playerHeadIds_.Equals(other.playerHeadIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012AFB RID: 76539 RVA: 0x002BAA1C File Offset: 0x002B8C1C
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

		// Token: 0x06012AFC RID: 76540 RVA: 0x002BAA50 File Offset: 0x002B8C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012AFD RID: 76541 RVA: 0x002BAA5D File Offset: 0x002B8C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012AFE RID: 76542 RVA: 0x002BAA66 File Offset: 0x002B8C66
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

		// Token: 0x06012AFF RID: 76543 RVA: 0x002BAA90 File Offset: 0x002B8C90
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

		// Token: 0x06012B00 RID: 76544 RVA: 0x002BAAC9 File Offset: 0x002B8CC9
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

		// Token: 0x06012B01 RID: 76545 RVA: 0x002BAAF7 File Offset: 0x002B8CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012B02 RID: 76546 RVA: 0x002BAB00 File Offset: 0x002B8D00
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.playerHeadIds_.AddEntriesFrom(ref input, PlayerHeadResponse._repeated_playerHeadIds_codec);
				}
			}
		}

		// Token: 0x04007453 RID: 29779
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007454 RID: 29780
		public const int PlayerHeadIdsFieldNumber = 1;

		// Token: 0x04007455 RID: 29781
		private static readonly FieldCodec<int> _repeated_playerHeadIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04007456 RID: 29782
		private readonly RepeatedField<int> playerHeadIds_ = new RepeatedField<int>();
	}
}
