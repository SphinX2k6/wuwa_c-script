using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000931 RID: 2353
	[NetMessage(EMessageId.LobbyListResponse)]
	public sealed class LobbyListResponse : IMessage<LobbyListResponse>, IMessage, IEquatable<LobbyListResponse>, IDeepCloneable<LobbyListResponse>, IBufferMessage
	{
		// Token: 0x0600CFA4 RID: 53156 RVA: 0x001E9181 File Offset: 0x001E7381
		[NullableContext(1)]
		public static LobbyListResponse Create()
		{
			return new LobbyListResponse();
		}

		// Token: 0x170029EB RID: 10731
		// (get) Token: 0x0600CFA5 RID: 53157 RVA: 0x001E9188 File Offset: 0x001E7388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029EC RID: 10732
		// (get) Token: 0x0600CFA6 RID: 53158 RVA: 0x001E918B File Offset: 0x001E738B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyListResponse.Descriptor;
			}
		}

		// Token: 0x0600CFA7 RID: 53159 RVA: 0x001E9192 File Offset: 0x001E7392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyListResponse()
		{
		}

		// Token: 0x0600CFA8 RID: 53160 RVA: 0x001E91A5 File Offset: 0x001E73A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyListResponse(LobbyListResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CFA9 RID: 53161 RVA: 0x001E91DB File Offset: 0x001E73DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyListResponse Clone()
		{
			return new LobbyListResponse(this);
		}

		// Token: 0x170029ED RID: 10733
		// (get) Token: 0x0600CFAA RID: 53162 RVA: 0x001E91E3 File Offset: 0x001E73E3
		// (set) Token: 0x0600CFAB RID: 53163 RVA: 0x001E91EB File Offset: 0x001E73EB
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

		// Token: 0x170029EE RID: 10734
		// (get) Token: 0x0600CFAC RID: 53164 RVA: 0x001E91F4 File Offset: 0x001E73F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerDetails> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x0600CFAD RID: 53165 RVA: 0x001E91FC File Offset: 0x001E73FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyListResponse);
		}

		// Token: 0x0600CFAE RID: 53166 RVA: 0x001E920C File Offset: 0x001E740C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CFAF RID: 53167 RVA: 0x001E925C File Offset: 0x001E745C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.itemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CFB0 RID: 53168 RVA: 0x001E92AF File Offset: 0x001E74AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CFB1 RID: 53169 RVA: 0x001E92BC File Offset: 0x001E74BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CFB2 RID: 53170 RVA: 0x001E92C8 File Offset: 0x001E74C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.itemList_.WriteTo(ref output, LobbyListResponse._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CFB3 RID: 53171 RVA: 0x001E9318 File Offset: 0x001E7518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.itemList_.CalculateSize(LobbyListResponse._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CFB4 RID: 53172 RVA: 0x001E936C File Offset: 0x001E756C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyListResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CFB5 RID: 53173 RVA: 0x001E93B9 File Offset: 0x001E75B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CFB6 RID: 53174 RVA: 0x001E93C4 File Offset: 0x001E75C4
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
				if (num != 16U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.itemList_.AddEntriesFrom(ref input, LobbyListResponse._repeated_itemList_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040057E1 RID: 22497
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057E2 RID: 22498
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040057E3 RID: 22499
		private ErrorCode errorCode_;

		// Token: 0x040057E4 RID: 22500
		public const int ItemListFieldNumber = 8;

		// Token: 0x040057E5 RID: 22501
		private static readonly FieldCodec<PlayerDetails> _repeated_itemList_codec = FieldCodec.ForMessage<PlayerDetails>(66U, PlayerDetails.Parser);

		// Token: 0x040057E6 RID: 22502
		private readonly RepeatedField<PlayerDetails> itemList_ = new RepeatedField<PlayerDetails>();
	}
}
