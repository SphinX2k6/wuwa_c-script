using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E3F RID: 3647
	[NetMessage(EMessageId.RacingBetMatchInfoResponse)]
	public sealed class RacingBetMatchInfoResponse : IMessage<RacingBetMatchInfoResponse>, IMessage, IEquatable<RacingBetMatchInfoResponse>, IDeepCloneable<RacingBetMatchInfoResponse>, IBufferMessage
	{
		// Token: 0x0601393C RID: 80188 RVA: 0x002D83A8 File Offset: 0x002D65A8
		[NullableContext(1)]
		public static RacingBetMatchInfoResponse Create()
		{
			return new RacingBetMatchInfoResponse();
		}

		// Token: 0x170040EB RID: 16619
		// (get) Token: 0x0601393D RID: 80189 RVA: 0x002D83AF File Offset: 0x002D65AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040EC RID: 16620
		// (get) Token: 0x0601393E RID: 80190 RVA: 0x002D83B2 File Offset: 0x002D65B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601393F RID: 80191 RVA: 0x002D83B9 File Offset: 0x002D65B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchInfoResponse()
		{
		}

		// Token: 0x06013940 RID: 80192 RVA: 0x002D83CC File Offset: 0x002D65CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchInfoResponse(RacingBetMatchInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.dangoInfo_ = other.dangoInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013941 RID: 80193 RVA: 0x002D8402 File Offset: 0x002D6602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchInfoResponse Clone()
		{
			return new RacingBetMatchInfoResponse(this);
		}

		// Token: 0x170040ED RID: 16621
		// (get) Token: 0x06013942 RID: 80194 RVA: 0x002D840A File Offset: 0x002D660A
		// (set) Token: 0x06013943 RID: 80195 RVA: 0x002D8412 File Offset: 0x002D6612
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

		// Token: 0x170040EE RID: 16622
		// (get) Token: 0x06013944 RID: 80196 RVA: 0x002D841B File Offset: 0x002D661B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsInstanceDangoInfo> DangoInfo
		{
			get
			{
				return this.dangoInfo_;
			}
		}

		// Token: 0x06013945 RID: 80197 RVA: 0x002D8423 File Offset: 0x002D6623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchInfoResponse);
		}

		// Token: 0x06013946 RID: 80198 RVA: 0x002D8434 File Offset: 0x002D6634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.dangoInfo_.Equals(other.dangoInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013947 RID: 80199 RVA: 0x002D8484 File Offset: 0x002D6684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.dangoInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013948 RID: 80200 RVA: 0x002D84D7 File Offset: 0x002D66D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013949 RID: 80201 RVA: 0x002D84E4 File Offset: 0x002D66E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601394A RID: 80202 RVA: 0x002D84F0 File Offset: 0x002D66F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.dangoInfo_.WriteTo(ref output, RacingBetMatchInfoResponse._repeated_dangoInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601394B RID: 80203 RVA: 0x002D8540 File Offset: 0x002D6740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.dangoInfo_.CalculateSize(RacingBetMatchInfoResponse._repeated_dangoInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601394C RID: 80204 RVA: 0x002D8594 File Offset: 0x002D6794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetMatchInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.dangoInfo_.Add(other.dangoInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601394D RID: 80205 RVA: 0x002D85E1 File Offset: 0x002D67E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601394E RID: 80206 RVA: 0x002D85EC File Offset: 0x002D67EC
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
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.dangoInfo_.AddEntriesFrom(ref input, RacingBetMatchInfoResponse._repeated_dangoInfo_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040077CE RID: 30670
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077CF RID: 30671
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040077D0 RID: 30672
		private ErrorCode errorCode_;

		// Token: 0x040077D1 RID: 30673
		public const int DangoInfoFieldNumber = 6;

		// Token: 0x040077D2 RID: 30674
		private static readonly FieldCodec<RacingBetsInstanceDangoInfo> _repeated_dangoInfo_codec = FieldCodec.ForMessage<RacingBetsInstanceDangoInfo>(50U, RacingBetsInstanceDangoInfo.Parser);

		// Token: 0x040077D3 RID: 30675
		private readonly RepeatedField<RacingBetsInstanceDangoInfo> dangoInfo_ = new RepeatedField<RacingBetsInstanceDangoInfo>();
	}
}
