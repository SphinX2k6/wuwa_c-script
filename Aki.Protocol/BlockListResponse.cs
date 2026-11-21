using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B6 RID: 438
	[NetMessage(EMessageId.BlockListResponse)]
	public sealed class BlockListResponse : IMessage<BlockListResponse>, IMessage, IEquatable<BlockListResponse>, IDeepCloneable<BlockListResponse>, IBufferMessage
	{
		// Token: 0x0600330E RID: 13070 RVA: 0x00081A8E File Offset: 0x0007FC8E
		[NullableContext(1)]
		public static BlockListResponse Create()
		{
			return new BlockListResponse();
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x0600330F RID: 13071 RVA: 0x00081A95 File Offset: 0x0007FC95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06003310 RID: 13072 RVA: 0x00081A98 File Offset: 0x0007FC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockListResponse.Descriptor;
			}
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x00081A9F File Offset: 0x0007FC9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockListResponse()
		{
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x00081AB2 File Offset: 0x0007FCB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockListResponse(BlockListResponse other) : this()
		{
			this.blockList_ = other.blockList_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x00081AE8 File Offset: 0x0007FCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockListResponse Clone()
		{
			return new BlockListResponse(this);
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06003314 RID: 13076 RVA: 0x00081AF0 File Offset: 0x0007FCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerDetails> BlockList
		{
			get
			{
				return this.blockList_;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06003315 RID: 13077 RVA: 0x00081AF8 File Offset: 0x0007FCF8
		// (set) Token: 0x06003316 RID: 13078 RVA: 0x00081B00 File Offset: 0x0007FD00
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

		// Token: 0x06003317 RID: 13079 RVA: 0x00081B09 File Offset: 0x0007FD09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlockListResponse);
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x00081B18 File Offset: 0x0007FD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlockListResponse other)
		{
			return other != null && (other == this || (this.blockList_.Equals(other.blockList_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x00081B68 File Offset: 0x0007FD68
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

		// Token: 0x0600331A RID: 13082 RVA: 0x00081BBB File Offset: 0x0007FDBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x00081BC8 File Offset: 0x0007FDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x00081BD4 File Offset: 0x0007FDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.blockList_.WriteTo(ref output, BlockListResponse._repeated_blockList_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x00081C24 File Offset: 0x0007FE24
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

		// Token: 0x0600331E RID: 13086 RVA: 0x00081C78 File Offset: 0x0007FE78
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

		// Token: 0x0600331F RID: 13087 RVA: 0x00081CC5 File Offset: 0x0007FEC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x00081CD0 File Offset: 0x0007FED0
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
					if (num != 40U)
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
					this.blockList_.AddEntriesFrom(ref input, BlockListResponse._repeated_blockList_codec);
				}
			}
		}

		// Token: 0x040029F6 RID: 10742
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029F7 RID: 10743
		public const int BlockListFieldNumber = 2;

		// Token: 0x040029F8 RID: 10744
		private static readonly FieldCodec<PlayerDetails> _repeated_blockList_codec = FieldCodec.ForMessage<PlayerDetails>(18U, PlayerDetails.Parser);

		// Token: 0x040029F9 RID: 10745
		private readonly RepeatedField<PlayerDetails> blockList_ = new RepeatedField<PlayerDetails>();

		// Token: 0x040029FA RID: 10746
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040029FB RID: 10747
		private ErrorCode errorCode_;
	}
}
