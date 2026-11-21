using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010DB RID: 4315
	[NetMessage(EMessageId.RoleTowerRankResponse)]
	public sealed class RoleTowerRankResponse : IMessage<RoleTowerRankResponse>, IMessage, IEquatable<RoleTowerRankResponse>, IDeepCloneable<RoleTowerRankResponse>, IBufferMessage
	{
		// Token: 0x06017126 RID: 94502 RVA: 0x0035B8F9 File Offset: 0x00359AF9
		[NullableContext(1)]
		public static RoleTowerRankResponse Create()
		{
			return new RoleTowerRankResponse();
		}

		// Token: 0x17004D78 RID: 19832
		// (get) Token: 0x06017127 RID: 94503 RVA: 0x0035B900 File Offset: 0x00359B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D79 RID: 19833
		// (get) Token: 0x06017128 RID: 94504 RVA: 0x0035B903 File Offset: 0x00359B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerRankResponse.Descriptor;
			}
		}

		// Token: 0x06017129 RID: 94505 RVA: 0x0035B90A File Offset: 0x00359B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankResponse()
		{
		}

		// Token: 0x0601712A RID: 94506 RVA: 0x0035B91D File Offset: 0x00359B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankResponse(RoleTowerRankResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rankInfo_ = other.rankInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601712B RID: 94507 RVA: 0x0035B953 File Offset: 0x00359B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankResponse Clone()
		{
			return new RoleTowerRankResponse(this);
		}

		// Token: 0x17004D7A RID: 19834
		// (get) Token: 0x0601712C RID: 94508 RVA: 0x0035B95B File Offset: 0x00359B5B
		// (set) Token: 0x0601712D RID: 94509 RVA: 0x0035B963 File Offset: 0x00359B63
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

		// Token: 0x17004D7B RID: 19835
		// (get) Token: 0x0601712E RID: 94510 RVA: 0x0035B96C File Offset: 0x00359B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerRankInfo> RankInfo
		{
			get
			{
				return this.rankInfo_;
			}
		}

		// Token: 0x0601712F RID: 94511 RVA: 0x0035B974 File Offset: 0x00359B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerRankResponse);
		}

		// Token: 0x06017130 RID: 94512 RVA: 0x0035B984 File Offset: 0x00359B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerRankResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.rankInfo_.Equals(other.rankInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017131 RID: 94513 RVA: 0x0035B9D4 File Offset: 0x00359BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.rankInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017132 RID: 94514 RVA: 0x0035BA27 File Offset: 0x00359C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017133 RID: 94515 RVA: 0x0035BA34 File Offset: 0x00359C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017134 RID: 94516 RVA: 0x0035BA40 File Offset: 0x00359C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rankInfo_.WriteTo(ref output, RoleTowerRankResponse._repeated_rankInfo_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017135 RID: 94517 RVA: 0x0035BA90 File Offset: 0x00359C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.rankInfo_.CalculateSize(RoleTowerRankResponse._repeated_rankInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017136 RID: 94518 RVA: 0x0035BAE4 File Offset: 0x00359CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerRankResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.rankInfo_.Add(other.rankInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017137 RID: 94519 RVA: 0x0035BB31 File Offset: 0x00359D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017138 RID: 94520 RVA: 0x0035BB3C File Offset: 0x00359D3C
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
				if (num != 26U)
				{
					if (num != 64U)
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
					this.rankInfo_.AddEntriesFrom(ref input, RoleTowerRankResponse._repeated_rankInfo_codec);
				}
			}
		}

		// Token: 0x04008A28 RID: 35368
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A29 RID: 35369
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04008A2A RID: 35370
		private ErrorCode errorCode_;

		// Token: 0x04008A2B RID: 35371
		public const int RankInfoFieldNumber = 3;

		// Token: 0x04008A2C RID: 35372
		private static readonly FieldCodec<RoleTowerRankInfo> _repeated_rankInfo_codec = FieldCodec.ForMessage<RoleTowerRankInfo>(26U, RoleTowerRankInfo.Parser);

		// Token: 0x04008A2D RID: 35373
		private readonly RepeatedField<RoleTowerRankInfo> rankInfo_ = new RepeatedField<RoleTowerRankInfo>();
	}
}
