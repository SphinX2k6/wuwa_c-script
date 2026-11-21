using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA6 RID: 3494
	[NetMessage(EMessageId.PlayerTitleResponse)]
	public sealed class PlayerTitleResponse : IMessage<PlayerTitleResponse>, IMessage, IEquatable<PlayerTitleResponse>, IDeepCloneable<PlayerTitleResponse>, IBufferMessage
	{
		// Token: 0x06012D9F RID: 77215 RVA: 0x002C0922 File Offset: 0x002BEB22
		[NullableContext(1)]
		public static PlayerTitleResponse Create()
		{
			return new PlayerTitleResponse();
		}

		// Token: 0x17003E95 RID: 16021
		// (get) Token: 0x06012DA0 RID: 77216 RVA: 0x002C0929 File Offset: 0x002BEB29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E96 RID: 16022
		// (get) Token: 0x06012DA1 RID: 77217 RVA: 0x002C092C File Offset: 0x002BEB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerTitleResponse.Descriptor;
			}
		}

		// Token: 0x06012DA2 RID: 77218 RVA: 0x002C0933 File Offset: 0x002BEB33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleResponse()
		{
		}

		// Token: 0x06012DA3 RID: 77219 RVA: 0x002C0954 File Offset: 0x002BEB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleResponse(PlayerTitleResponse other) : this()
		{
			this.playerTitleInfo_ = other.playerTitleInfo_.Clone();
			this.errorCode_ = other.errorCode_;
			this.playerTitleLimitInfos_ = other.playerTitleLimitInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012DA4 RID: 77220 RVA: 0x002C09A6 File Offset: 0x002BEBA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleResponse Clone()
		{
			return new PlayerTitleResponse(this);
		}

		// Token: 0x17003E97 RID: 16023
		// (get) Token: 0x06012DA5 RID: 77221 RVA: 0x002C09AE File Offset: 0x002BEBAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerTitleInfo> PlayerTitleInfo
		{
			get
			{
				return this.playerTitleInfo_;
			}
		}

		// Token: 0x17003E98 RID: 16024
		// (get) Token: 0x06012DA6 RID: 77222 RVA: 0x002C09B6 File Offset: 0x002BEBB6
		// (set) Token: 0x06012DA7 RID: 77223 RVA: 0x002C09BE File Offset: 0x002BEBBE
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

		// Token: 0x17003E99 RID: 16025
		// (get) Token: 0x06012DA8 RID: 77224 RVA: 0x002C09C7 File Offset: 0x002BEBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerTitleLimitInfo> PlayerTitleLimitInfos
		{
			get
			{
				return this.playerTitleLimitInfos_;
			}
		}

		// Token: 0x06012DA9 RID: 77225 RVA: 0x002C09CF File Offset: 0x002BEBCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerTitleResponse);
		}

		// Token: 0x06012DAA RID: 77226 RVA: 0x002C09E0 File Offset: 0x002BEBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerTitleResponse other)
		{
			return other != null && (other == this || (this.playerTitleInfo_.Equals(other.playerTitleInfo_) && this.ErrorCode == other.ErrorCode && this.playerTitleLimitInfos_.Equals(other.playerTitleLimitInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012DAB RID: 77227 RVA: 0x002C0A44 File Offset: 0x002BEC44
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

		// Token: 0x06012DAC RID: 77228 RVA: 0x002C0AA5 File Offset: 0x002BECA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012DAD RID: 77229 RVA: 0x002C0AB2 File Offset: 0x002BECB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012DAE RID: 77230 RVA: 0x002C0ABC File Offset: 0x002BECBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerTitleInfo_.WriteTo(ref output, PlayerTitleResponse._repeated_playerTitleInfo_codec);
			this.playerTitleLimitInfos_.WriteTo(ref output, PlayerTitleResponse._repeated_playerTitleLimitInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012DAF RID: 77231 RVA: 0x002C0B1C File Offset: 0x002BED1C
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

		// Token: 0x06012DB0 RID: 77232 RVA: 0x002C0B80 File Offset: 0x002BED80
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

		// Token: 0x06012DB1 RID: 77233 RVA: 0x002C0BDE File Offset: 0x002BEDDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012DB2 RID: 77234 RVA: 0x002C0BE8 File Offset: 0x002BEDE8
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
				if (num != 10U)
				{
					if (num != 26U)
					{
						if (num != 96U)
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

		// Token: 0x04007522 RID: 29986
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007523 RID: 29987
		public const int PlayerTitleInfoFieldNumber = 1;

		// Token: 0x04007524 RID: 29988
		private static readonly FieldCodec<PlayerTitleInfo> _repeated_playerTitleInfo_codec = FieldCodec.ForMessage<PlayerTitleInfo>(10U, Aki.Protocol.PlayerTitleInfo.Parser);

		// Token: 0x04007525 RID: 29989
		private readonly RepeatedField<PlayerTitleInfo> playerTitleInfo_ = new RepeatedField<PlayerTitleInfo>();

		// Token: 0x04007526 RID: 29990
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04007527 RID: 29991
		private ErrorCode errorCode_;

		// Token: 0x04007528 RID: 29992
		public const int PlayerTitleLimitInfosFieldNumber = 3;

		// Token: 0x04007529 RID: 29993
		private static readonly FieldCodec<PlayerTitleLimitInfo> _repeated_playerTitleLimitInfos_codec = FieldCodec.ForMessage<PlayerTitleLimitInfo>(26U, PlayerTitleLimitInfo.Parser);

		// Token: 0x0400752A RID: 29994
		private readonly RepeatedField<PlayerTitleLimitInfo> playerTitleLimitInfos_ = new RepeatedField<PlayerTitleLimitInfo>();
	}
}
