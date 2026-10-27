using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB6 RID: 3510
	[NetMessage(EMessageId.PlayerTitleResponse)]
	public sealed class PlayerTitleResponse : IMessage<PlayerTitleResponse>, IMessage, IEquatable<PlayerTitleResponse>, IDeepCloneable<PlayerTitleResponse>, IBufferMessage
	{
		// Token: 0x06012E9B RID: 77467 RVA: 0x002C2546 File Offset: 0x002C0746
		[NullableContext(1)]
		public static PlayerTitleResponse Create()
		{
			return new PlayerTitleResponse();
		}

		// Token: 0x17003ECA RID: 16074
		// (get) Token: 0x06012E9C RID: 77468 RVA: 0x002C254D File Offset: 0x002C074D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ECB RID: 16075
		// (get) Token: 0x06012E9D RID: 77469 RVA: 0x002C2550 File Offset: 0x002C0750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerTitleResponse.Descriptor;
			}
		}

		// Token: 0x06012E9E RID: 77470 RVA: 0x002C2557 File Offset: 0x002C0757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleResponse()
		{
		}

		// Token: 0x06012E9F RID: 77471 RVA: 0x002C2578 File Offset: 0x002C0778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleResponse(PlayerTitleResponse other) : this()
		{
			this.playerTitleInfo_ = other.playerTitleInfo_.Clone();
			this.errorCode_ = other.errorCode_;
			this.playerTitleLimitInfos_ = other.playerTitleLimitInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012EA0 RID: 77472 RVA: 0x002C25CA File Offset: 0x002C07CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleResponse Clone()
		{
			return new PlayerTitleResponse(this);
		}

		// Token: 0x17003ECC RID: 16076
		// (get) Token: 0x06012EA1 RID: 77473 RVA: 0x002C25D2 File Offset: 0x002C07D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerTitleInfo> PlayerTitleInfo
		{
			get
			{
				return this.playerTitleInfo_;
			}
		}

		// Token: 0x17003ECD RID: 16077
		// (get) Token: 0x06012EA2 RID: 77474 RVA: 0x002C25DA File Offset: 0x002C07DA
		// (set) Token: 0x06012EA3 RID: 77475 RVA: 0x002C25E2 File Offset: 0x002C07E2
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

		// Token: 0x17003ECE RID: 16078
		// (get) Token: 0x06012EA4 RID: 77476 RVA: 0x002C25EB File Offset: 0x002C07EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerTitleLimitInfo> PlayerTitleLimitInfos
		{
			get
			{
				return this.playerTitleLimitInfos_;
			}
		}

		// Token: 0x06012EA5 RID: 77477 RVA: 0x002C25F3 File Offset: 0x002C07F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerTitleResponse);
		}

		// Token: 0x06012EA6 RID: 77478 RVA: 0x002C2604 File Offset: 0x002C0804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerTitleResponse other)
		{
			return other != null && (other == this || (this.playerTitleInfo_.Equals(other.playerTitleInfo_) && this.ErrorCode == other.ErrorCode && this.playerTitleLimitInfos_.Equals(other.playerTitleLimitInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012EA7 RID: 77479 RVA: 0x002C2668 File Offset: 0x002C0868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playerTitleInfo_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.playerTitleLimitInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012EA8 RID: 77480 RVA: 0x002C26C9 File Offset: 0x002C08C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012EA9 RID: 77481 RVA: 0x002C26D6 File Offset: 0x002C08D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012EAA RID: 77482 RVA: 0x002C26E0 File Offset: 0x002C08E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerTitleInfo_.WriteTo(ref output, PlayerTitleResponse._repeated_playerTitleInfo_codec);
			this.playerTitleLimitInfos_.WriteTo(ref output, PlayerTitleResponse._repeated_playerTitleLimitInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012EAB RID: 77483 RVA: 0x002C2740 File Offset: 0x002C0940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerTitleInfo_.CalculateSize(PlayerTitleResponse._repeated_playerTitleInfo_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.playerTitleLimitInfos_.CalculateSize(PlayerTitleResponse._repeated_playerTitleLimitInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012EAC RID: 77484 RVA: 0x002C27A4 File Offset: 0x002C09A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerTitleResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.playerTitleInfo_.Add(other.playerTitleInfo_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.playerTitleLimitInfos_.Add(other.playerTitleLimitInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012EAD RID: 77485 RVA: 0x002C2802 File Offset: 0x002C0A02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012EAE RID: 77486 RVA: 0x002C280C File Offset: 0x002C0A0C
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
				if (num != 42U)
				{
					if (num != 74U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.playerTitleLimitInfos_.AddEntriesFrom(ref input, PlayerTitleResponse._repeated_playerTitleLimitInfos_codec);
					}
				}
				else
				{
					this.playerTitleInfo_.AddEntriesFrom(ref input, PlayerTitleResponse._repeated_playerTitleInfo_codec);
				}
			}
		}

		// Token: 0x0400750A RID: 29962
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400750B RID: 29963
		public const int PlayerTitleInfoFieldNumber = 5;

		// Token: 0x0400750C RID: 29964
		private static readonly FieldCodec<PlayerTitleInfo> _repeated_playerTitleInfo_codec = FieldCodec.ForMessage<PlayerTitleInfo>(42U, Aki.Protocol.PlayerTitleInfo.Parser);

		// Token: 0x0400750D RID: 29965
		private readonly RepeatedField<PlayerTitleInfo> playerTitleInfo_ = new RepeatedField<PlayerTitleInfo>();

		// Token: 0x0400750E RID: 29966
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400750F RID: 29967
		private ErrorCode errorCode_;

		// Token: 0x04007510 RID: 29968
		public const int PlayerTitleLimitInfosFieldNumber = 9;

		// Token: 0x04007511 RID: 29969
		private static readonly FieldCodec<PlayerTitleLimitInfo> _repeated_playerTitleLimitInfos_codec = FieldCodec.ForMessage<PlayerTitleLimitInfo>(74U, PlayerTitleLimitInfo.Parser);

		// Token: 0x04007512 RID: 29970
		private readonly RepeatedField<PlayerTitleLimitInfo> playerTitleLimitInfos_ = new RepeatedField<PlayerTitleLimitInfo>();
	}
}
