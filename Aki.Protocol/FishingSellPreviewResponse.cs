using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200057A RID: 1402
	[NetMessage(EMessageId.FishingSellPreviewResponse)]
	public sealed class FishingSellPreviewResponse : IMessage<FishingSellPreviewResponse>, IMessage, IEquatable<FishingSellPreviewResponse>, IDeepCloneable<FishingSellPreviewResponse>, IBufferMessage
	{
		// Token: 0x06008256 RID: 33366 RVA: 0x0013A7F1 File Offset: 0x001389F1
		[NullableContext(1)]
		public static FishingSellPreviewResponse Create()
		{
			return new FishingSellPreviewResponse();
		}

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x06008257 RID: 33367 RVA: 0x0013A7F8 File Offset: 0x001389F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x06008258 RID: 33368 RVA: 0x0013A7FB File Offset: 0x001389FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSellPreviewResponse.Descriptor;
			}
		}

		// Token: 0x06008259 RID: 33369 RVA: 0x0013A802 File Offset: 0x00138A02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellPreviewResponse()
		{
		}

		// Token: 0x0600825A RID: 33370 RVA: 0x0013A815 File Offset: 0x00138A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellPreviewResponse(FishingSellPreviewResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rewardItems_ = other.rewardItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600825B RID: 33371 RVA: 0x0013A84B File Offset: 0x00138A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellPreviewResponse Clone()
		{
			return new FishingSellPreviewResponse(this);
		}

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x0600825C RID: 33372 RVA: 0x0013A853 File Offset: 0x00138A53
		// (set) Token: 0x0600825D RID: 33373 RVA: 0x0013A85B File Offset: 0x00138A5B
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

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x0600825E RID: 33374 RVA: 0x0013A864 File Offset: 0x00138A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x0600825F RID: 33375 RVA: 0x0013A86C File Offset: 0x00138A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSellPreviewResponse);
		}

		// Token: 0x06008260 RID: 33376 RVA: 0x0013A87C File Offset: 0x00138A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSellPreviewResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.RewardItems.Equals(other.RewardItems) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008261 RID: 33377 RVA: 0x0013A8CC File Offset: 0x00138ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.RewardItems.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008262 RID: 33378 RVA: 0x0013A91F File Offset: 0x00138B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008263 RID: 33379 RVA: 0x0013A92C File Offset: 0x00138B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008264 RID: 33380 RVA: 0x0013A938 File Offset: 0x00138B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardItems_.WriteTo(ref output, FishingSellPreviewResponse._map_rewardItems_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008265 RID: 33381 RVA: 0x0013A988 File Offset: 0x00138B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.rewardItems_.CalculateSize(FishingSellPreviewResponse._map_rewardItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008266 RID: 33382 RVA: 0x0013A9DC File Offset: 0x00138BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSellPreviewResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.rewardItems_.MergeFrom(other.rewardItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008267 RID: 33383 RVA: 0x0013AA29 File Offset: 0x00138C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008268 RID: 33384 RVA: 0x0013AA34 File Offset: 0x00138C34
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
				if (num != 18U)
				{
					if (num != 104U)
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
					this.rewardItems_.AddEntriesFrom(ref input, FishingSellPreviewResponse._map_rewardItems_codec);
				}
			}
		}

		// Token: 0x04004139 RID: 16697
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400413A RID: 16698
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400413B RID: 16699
		private ErrorCode errorCode_;

		// Token: 0x0400413C RID: 16700
		public const int RewardItemsFieldNumber = 2;

		// Token: 0x0400413D RID: 16701
		private static readonly MapField<int, int>.Codec _map_rewardItems_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x0400413E RID: 16702
		private readonly MapField<int, int> rewardItems_ = new MapField<int, int>();
	}
}
