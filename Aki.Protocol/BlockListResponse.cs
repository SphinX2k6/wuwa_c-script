using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B2 RID: 434
	[NetMessage(EMessageId.BlockListResponse)]
	public sealed class BlockListResponse : IMessage<BlockListResponse>, IMessage, IEquatable<BlockListResponse>, IDeepCloneable<BlockListResponse>, IBufferMessage
	{
		// Token: 0x06003281 RID: 12929 RVA: 0x00080322 File Offset: 0x0007E522
		[NullableContext(1)]
		public static BlockListResponse Create()
		{
			return new BlockListResponse();
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06003282 RID: 12930 RVA: 0x00080329 File Offset: 0x0007E529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06003283 RID: 12931 RVA: 0x0008032C File Offset: 0x0007E52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockListResponse.Descriptor;
			}
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x00080333 File Offset: 0x0007E533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockListResponse()
		{
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x00080346 File Offset: 0x0007E546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockListResponse(BlockListResponse other) : this()
		{
			this.blockList_ = other.blockList_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x0008037C File Offset: 0x0007E57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockListResponse Clone()
		{
			return new BlockListResponse(this);
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06003287 RID: 12935 RVA: 0x00080384 File Offset: 0x0007E584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerDetails> BlockList
		{
			get
			{
				return this.blockList_;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06003288 RID: 12936 RVA: 0x0008038C File Offset: 0x0007E58C
		// (set) Token: 0x06003289 RID: 12937 RVA: 0x00080394 File Offset: 0x0007E594
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

		// Token: 0x0600328A RID: 12938 RVA: 0x0008039D File Offset: 0x0007E59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlockListResponse);
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x000803AC File Offset: 0x0007E5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlockListResponse other)
		{
			return other != null && (other == this || (this.blockList_.Equals(other.blockList_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x000803FC File Offset: 0x0007E5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.blockList_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x0008044F File Offset: 0x0007E64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x0008045C File Offset: 0x0007E65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x00080468 File Offset: 0x0007E668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.blockList_.WriteTo(ref output, BlockListResponse._repeated_blockList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x000804B8 File Offset: 0x0007E6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.blockList_.CalculateSize(BlockListResponse._repeated_blockList_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x0008050C File Offset: 0x0007E70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlockListResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.blockList_.Add(other.blockList_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x00080559 File Offset: 0x0007E759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x00080564 File Offset: 0x0007E764
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
				if (num != 24U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.blockList_.AddEntriesFrom(ref input, BlockListResponse._repeated_blockList_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400297B RID: 10619
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400297C RID: 10620
		public const int BlockListFieldNumber = 7;

		// Token: 0x0400297D RID: 10621
		private static readonly FieldCodec<PlayerDetails> _repeated_blockList_codec = FieldCodec.ForMessage<PlayerDetails>(58U, PlayerDetails.Parser);

		// Token: 0x0400297E RID: 10622
		private readonly RepeatedField<PlayerDetails> blockList_ = new RepeatedField<PlayerDetails>();

		// Token: 0x0400297F RID: 10623
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04002980 RID: 10624
		private ErrorCode errorCode_;
	}
}
