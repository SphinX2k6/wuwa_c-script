using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000AC RID: 172
	[NetMessage(EMessageId.AddPlacementNotify)]
	public sealed class AddPlacementNotify : IMessage<AddPlacementNotify>, IMessage, IEquatable<AddPlacementNotify>, IDeepCloneable<AddPlacementNotify>, IBufferMessage
	{
		// Token: 0x06001D64 RID: 7524 RVA: 0x00051123 File Offset: 0x0004F323
		[NullableContext(1)]
		public static AddPlacementNotify Create()
		{
			return new AddPlacementNotify();
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x0005112A File Offset: 0x0004F32A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x0005112D File Offset: 0x0004F32D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddPlacementNotify.Descriptor;
			}
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x00051134 File Offset: 0x0004F334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddPlacementNotify()
		{
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x0005113C File Offset: 0x0004F33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddPlacementNotify(AddPlacementNotify other) : this()
		{
			this.gridInfo_ = ((other.gridInfo_ != null) ? other.gridInfo_.Clone() : null);
			this.boardEntityConfigId_ = other.boardEntityConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x00051188 File Offset: 0x0004F388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddPlacementNotify Clone()
		{
			return new AddPlacementNotify(this);
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x00051190 File Offset: 0x0004F390
		// (set) Token: 0x06001D6B RID: 7531 RVA: 0x00051198 File Offset: 0x0004F398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupiedBoardGridInfo GridInfo
		{
			get
			{
				return this.gridInfo_;
			}
			set
			{
				this.gridInfo_ = value;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x000511A1 File Offset: 0x0004F3A1
		// (set) Token: 0x06001D6D RID: 7533 RVA: 0x000511A9 File Offset: 0x0004F3A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoardEntityConfigId
		{
			get
			{
				return this.boardEntityConfigId_;
			}
			set
			{
				this.boardEntityConfigId_ = value;
			}
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x000511B2 File Offset: 0x0004F3B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddPlacementNotify);
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x000511C0 File Offset: 0x0004F3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddPlacementNotify other)
		{
			return other != null && (other == this || (object.Equals(this.GridInfo, other.GridInfo) && this.BoardEntityConfigId == other.BoardEntityConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x00051210 File Offset: 0x0004F410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gridInfo_ != null)
			{
				num ^= this.GridInfo.GetHashCode();
			}
			if (this.BoardEntityConfigId != 0)
			{
				num ^= this.BoardEntityConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x00051265 File Offset: 0x0004F465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x00051272 File Offset: 0x0004F472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x0005127C File Offset: 0x0004F47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gridInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.GridInfo);
			}
			if (this.BoardEntityConfigId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.BoardEntityConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x000512D8 File Offset: 0x0004F4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gridInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GridInfo);
			}
			if (this.BoardEntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoardEntityConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x00051330 File Offset: 0x0004F530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddPlacementNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gridInfo_ != null)
			{
				if (this.gridInfo_ == null)
				{
					this.GridInfo = new OccupiedBoardGridInfo();
				}
				this.GridInfo.MergeFrom(other.GridInfo);
			}
			if (other.BoardEntityConfigId != 0)
			{
				this.BoardEntityConfigId = other.BoardEntityConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x00051398 File Offset: 0x0004F598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x000513A4 File Offset: 0x0004F5A4
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
				if (num != 50U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BoardEntityConfigId = input.ReadInt32();
					}
				}
				else
				{
					if (this.gridInfo_ == null)
					{
						this.GridInfo = new OccupiedBoardGridInfo();
					}
					input.ReadMessage(this.GridInfo);
				}
			}
		}

		// Token: 0x0400236C RID: 9068
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400236D RID: 9069
		public const int GridInfoFieldNumber = 6;

		// Token: 0x0400236E RID: 9070
		private OccupiedBoardGridInfo gridInfo_;

		// Token: 0x0400236F RID: 9071
		public const int BoardEntityConfigIdFieldNumber = 9;

		// Token: 0x04002370 RID: 9072
		private int boardEntityConfigId_;
	}
}
