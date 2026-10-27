using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000942 RID: 2370
	[NetMessage(EMessageId.LobbyListResponse)]
	public sealed class LobbyListResponse : IMessage<LobbyListResponse>, IMessage, IEquatable<LobbyListResponse>, IDeepCloneable<LobbyListResponse>, IBufferMessage
	{
		// Token: 0x0600D0C0 RID: 53440 RVA: 0x001EB455 File Offset: 0x001E9655
		[NullableContext(1)]
		public static LobbyListResponse Create()
		{
			return new LobbyListResponse();
		}

		// Token: 0x17002A2A RID: 10794
		// (get) Token: 0x0600D0C1 RID: 53441 RVA: 0x001EB45C File Offset: 0x001E965C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A2B RID: 10795
		// (get) Token: 0x0600D0C2 RID: 53442 RVA: 0x001EB45F File Offset: 0x001E965F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyListResponse.Descriptor;
			}
		}

		// Token: 0x0600D0C3 RID: 53443 RVA: 0x001EB466 File Offset: 0x001E9666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyListResponse()
		{
		}

		// Token: 0x0600D0C4 RID: 53444 RVA: 0x001EB479 File Offset: 0x001E9679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyListResponse(LobbyListResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D0C5 RID: 53445 RVA: 0x001EB4AF File Offset: 0x001E96AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyListResponse Clone()
		{
			return new LobbyListResponse(this);
		}

		// Token: 0x17002A2C RID: 10796
		// (get) Token: 0x0600D0C6 RID: 53446 RVA: 0x001EB4B7 File Offset: 0x001E96B7
		// (set) Token: 0x0600D0C7 RID: 53447 RVA: 0x001EB4BF File Offset: 0x001E96BF
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

		// Token: 0x17002A2D RID: 10797
		// (get) Token: 0x0600D0C8 RID: 53448 RVA: 0x001EB4C8 File Offset: 0x001E96C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerDetails> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x0600D0C9 RID: 53449 RVA: 0x001EB4D0 File Offset: 0x001E96D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyListResponse);
		}

		// Token: 0x0600D0CA RID: 53450 RVA: 0x001EB4E0 File Offset: 0x001E96E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D0CB RID: 53451 RVA: 0x001EB530 File Offset: 0x001E9730
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

		// Token: 0x0600D0CC RID: 53452 RVA: 0x001EB583 File Offset: 0x001E9783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D0CD RID: 53453 RVA: 0x001EB590 File Offset: 0x001E9790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D0CE RID: 53454 RVA: 0x001EB59C File Offset: 0x001E979C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.itemList_.WriteTo(ref output, LobbyListResponse._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D0CF RID: 53455 RVA: 0x001EB5EC File Offset: 0x001E97EC
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

		// Token: 0x0600D0D0 RID: 53456 RVA: 0x001EB640 File Offset: 0x001E9840
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

		// Token: 0x0600D0D1 RID: 53457 RVA: 0x001EB68D File Offset: 0x001E988D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D0D2 RID: 53458 RVA: 0x001EB698 File Offset: 0x001E9898
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
					if (num != 82U)
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

		// Token: 0x040057DA RID: 22490
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057DB RID: 22491
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040057DC RID: 22492
		private ErrorCode errorCode_;

		// Token: 0x040057DD RID: 22493
		public const int ItemListFieldNumber = 10;

		// Token: 0x040057DE RID: 22494
		private static readonly FieldCodec<PlayerDetails> _repeated_itemList_codec = FieldCodec.ForMessage<PlayerDetails>(82U, PlayerDetails.Parser);

		// Token: 0x040057DF RID: 22495
		private readonly RepeatedField<PlayerDetails> itemList_ = new RepeatedField<PlayerDetails>();
	}
}
