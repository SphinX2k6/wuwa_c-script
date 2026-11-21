using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200128A RID: 4746
	[NetMessage(EMessageId.SlashAndTowerRecommendResponse)]
	public sealed class SlashAndTowerRecommendResponse : IMessage<SlashAndTowerRecommendResponse>, IMessage, IEquatable<SlashAndTowerRecommendResponse>, IDeepCloneable<SlashAndTowerRecommendResponse>, IBufferMessage
	{
		// Token: 0x06019551 RID: 103761 RVA: 0x003B1C91 File Offset: 0x003AFE91
		[NullableContext(1)]
		public static SlashAndTowerRecommendResponse Create()
		{
			return new SlashAndTowerRecommendResponse();
		}

		// Token: 0x170055AD RID: 21933
		// (get) Token: 0x06019552 RID: 103762 RVA: 0x003B1C98 File Offset: 0x003AFE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055AE RID: 21934
		// (get) Token: 0x06019553 RID: 103763 RVA: 0x003B1C9B File Offset: 0x003AFE9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerRecommendResponse.Descriptor;
			}
		}

		// Token: 0x06019554 RID: 103764 RVA: 0x003B1CA2 File Offset: 0x003AFEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerRecommendResponse()
		{
		}

		// Token: 0x06019555 RID: 103765 RVA: 0x003B1CB5 File Offset: 0x003AFEB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerRecommendResponse(SlashAndTowerRecommendResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.recommendInfos_ = other.recommendInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019556 RID: 103766 RVA: 0x003B1CEB File Offset: 0x003AFEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerRecommendResponse Clone()
		{
			return new SlashAndTowerRecommendResponse(this);
		}

		// Token: 0x170055AF RID: 21935
		// (get) Token: 0x06019557 RID: 103767 RVA: 0x003B1CF3 File Offset: 0x003AFEF3
		// (set) Token: 0x06019558 RID: 103768 RVA: 0x003B1CFB File Offset: 0x003AFEFB
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

		// Token: 0x170055B0 RID: 21936
		// (get) Token: 0x06019559 RID: 103769 RVA: 0x003B1D04 File Offset: 0x003AFF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SlashLevelRecommend> RecommendInfos
		{
			get
			{
				return this.recommendInfos_;
			}
		}

		// Token: 0x0601955A RID: 103770 RVA: 0x003B1D0C File Offset: 0x003AFF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerRecommendResponse);
		}

		// Token: 0x0601955B RID: 103771 RVA: 0x003B1D1C File Offset: 0x003AFF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerRecommendResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.recommendInfos_.Equals(other.recommendInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601955C RID: 103772 RVA: 0x003B1D6C File Offset: 0x003AFF6C
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

		// Token: 0x0601955D RID: 103773 RVA: 0x003B1DBF File Offset: 0x003AFFBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601955E RID: 103774 RVA: 0x003B1DCC File Offset: 0x003AFFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601955F RID: 103775 RVA: 0x003B1DD8 File Offset: 0x003AFFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.recommendInfos_.WriteTo(ref output, SlashAndTowerRecommendResponse._repeated_recommendInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019560 RID: 103776 RVA: 0x003B1E28 File Offset: 0x003B0028
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

		// Token: 0x06019561 RID: 103777 RVA: 0x003B1E7C File Offset: 0x003B007C
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

		// Token: 0x06019562 RID: 103778 RVA: 0x003B1EC9 File Offset: 0x003B00C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019563 RID: 103779 RVA: 0x003B1ED4 File Offset: 0x003B00D4
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
				if (num != 34U)
				{
					if (num != 80U)
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

		// Token: 0x040095DA RID: 38362
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095DB RID: 38363
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040095DC RID: 38364
		private ErrorCode errorCode_;

		// Token: 0x040095DD RID: 38365
		public const int RecommendInfosFieldNumber = 4;

		// Token: 0x040095DE RID: 38366
		private static readonly FieldCodec<SlashLevelRecommend> _repeated_recommendInfos_codec = FieldCodec.ForMessage<SlashLevelRecommend>(34U, SlashLevelRecommend.Parser);

		// Token: 0x040095DF RID: 38367
		private readonly RepeatedField<SlashLevelRecommend> recommendInfos_ = new RepeatedField<SlashLevelRecommend>();
	}
}
