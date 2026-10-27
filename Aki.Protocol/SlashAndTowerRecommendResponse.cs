using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200124D RID: 4685
	[NetMessage(EMessageId.SlashAndTowerRecommendResponse)]
	public sealed class SlashAndTowerRecommendResponse : IMessage<SlashAndTowerRecommendResponse>, IMessage, IEquatable<SlashAndTowerRecommendResponse>, IDeepCloneable<SlashAndTowerRecommendResponse>, IBufferMessage
	{
		// Token: 0x06018F67 RID: 102247 RVA: 0x003A1D35 File Offset: 0x0039FF35
		[NullableContext(1)]
		public static SlashAndTowerRecommendResponse Create()
		{
			return new SlashAndTowerRecommendResponse();
		}

		// Token: 0x1700542E RID: 21550
		// (get) Token: 0x06018F68 RID: 102248 RVA: 0x003A1D3C File Offset: 0x0039FF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700542F RID: 21551
		// (get) Token: 0x06018F69 RID: 102249 RVA: 0x003A1D3F File Offset: 0x0039FF3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerRecommendResponse.Descriptor;
			}
		}

		// Token: 0x06018F6A RID: 102250 RVA: 0x003A1D46 File Offset: 0x0039FF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerRecommendResponse()
		{
		}

		// Token: 0x06018F6B RID: 102251 RVA: 0x003A1D59 File Offset: 0x0039FF59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerRecommendResponse(SlashAndTowerRecommendResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.recommendInfos_ = other.recommendInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018F6C RID: 102252 RVA: 0x003A1D8F File Offset: 0x0039FF8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerRecommendResponse Clone()
		{
			return new SlashAndTowerRecommendResponse(this);
		}

		// Token: 0x17005430 RID: 21552
		// (get) Token: 0x06018F6D RID: 102253 RVA: 0x003A1D97 File Offset: 0x0039FF97
		// (set) Token: 0x06018F6E RID: 102254 RVA: 0x003A1D9F File Offset: 0x0039FF9F
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

		// Token: 0x17005431 RID: 21553
		// (get) Token: 0x06018F6F RID: 102255 RVA: 0x003A1DA8 File Offset: 0x0039FFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SlashLevelRecommend> RecommendInfos
		{
			get
			{
				return this.recommendInfos_;
			}
		}

		// Token: 0x06018F70 RID: 102256 RVA: 0x003A1DB0 File Offset: 0x0039FFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerRecommendResponse);
		}

		// Token: 0x06018F71 RID: 102257 RVA: 0x003A1DC0 File Offset: 0x0039FFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerRecommendResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.recommendInfos_.Equals(other.recommendInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018F72 RID: 102258 RVA: 0x003A1E10 File Offset: 0x003A0010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.recommendInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018F73 RID: 102259 RVA: 0x003A1E63 File Offset: 0x003A0063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018F74 RID: 102260 RVA: 0x003A1E70 File Offset: 0x003A0070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018F75 RID: 102261 RVA: 0x003A1E7C File Offset: 0x003A007C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.recommendInfos_.WriteTo(ref output, SlashAndTowerRecommendResponse._repeated_recommendInfos_codec);
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

		// Token: 0x06018F76 RID: 102262 RVA: 0x003A1ECC File Offset: 0x003A00CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.recommendInfos_.CalculateSize(SlashAndTowerRecommendResponse._repeated_recommendInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018F77 RID: 102263 RVA: 0x003A1F20 File Offset: 0x003A0120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerRecommendResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.recommendInfos_.Add(other.recommendInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018F78 RID: 102264 RVA: 0x003A1F6D File Offset: 0x003A016D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018F79 RID: 102265 RVA: 0x003A1F78 File Offset: 0x003A0178
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
					this.recommendInfos_.AddEntriesFrom(ref input, SlashAndTowerRecommendResponse._repeated_recommendInfos_codec);
				}
			}
		}

		// Token: 0x04009328 RID: 37672
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009329 RID: 37673
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400932A RID: 37674
		private ErrorCode errorCode_;

		// Token: 0x0400932B RID: 37675
		public const int RecommendInfosFieldNumber = 3;

		// Token: 0x0400932C RID: 37676
		private static readonly FieldCodec<SlashLevelRecommend> _repeated_recommendInfos_codec = FieldCodec.ForMessage<SlashLevelRecommend>(26U, SlashLevelRecommend.Parser);

		// Token: 0x0400932D RID: 37677
		private readonly RepeatedField<SlashLevelRecommend> recommendInfos_ = new RepeatedField<SlashLevelRecommend>();
	}
}
