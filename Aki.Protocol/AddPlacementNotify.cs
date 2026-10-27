using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000AB RID: 171
	[NetMessage(EMessageId.AddPlacementNotify)]
	public sealed class AddPlacementNotify : IMessage<AddPlacementNotify>, IMessage, IEquatable<AddPlacementNotify>, IDeepCloneable<AddPlacementNotify>, IBufferMessage
	{
		// Token: 0x06001D1B RID: 7451 RVA: 0x0005046C File Offset: 0x0004E66C
		[NullableContext(1)]
		public static AddPlacementNotify Create()
		{
			return new AddPlacementNotify();
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001D1C RID: 7452 RVA: 0x00050473 File Offset: 0x0004E673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x00050476 File Offset: 0x0004E676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddPlacementNotify.Descriptor;
			}
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x0005047D File Offset: 0x0004E67D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddPlacementNotify()
		{
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x00050488 File Offset: 0x0004E688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddPlacementNotify(AddPlacementNotify other) : this()
		{
			this.gridInfo_ = ((other.gridInfo_ != null) ? other.gridInfo_.Clone() : null);
			this.boardEntityConfigId_ = other.boardEntityConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x000504D4 File Offset: 0x0004E6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddPlacementNotify Clone()
		{
			return new AddPlacementNotify(this);
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x000504DC File Offset: 0x0004E6DC
		// (set) Token: 0x06001D22 RID: 7458 RVA: 0x000504E4 File Offset: 0x0004E6E4
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

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x000504ED File Offset: 0x0004E6ED
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x000504F5 File Offset: 0x0004E6F5
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

		// Token: 0x06001D25 RID: 7461 RVA: 0x000504FE File Offset: 0x0004E6FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddPlacementNotify);
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x0005050C File Offset: 0x0004E70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddPlacementNotify other)
		{
			return other != null && (other == this || (object.Equals(this.GridInfo, other.GridInfo) && this.BoardEntityConfigId == other.BoardEntityConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x0005055C File Offset: 0x0004E75C
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

		// Token: 0x06001D28 RID: 7464 RVA: 0x000505B1 File Offset: 0x0004E7B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x000505BE File Offset: 0x0004E7BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x000505C8 File Offset: 0x0004E7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gridInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.GridInfo);
			}
			if (this.BoardEntityConfigId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.BoardEntityConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x00050624 File Offset: 0x0004E824
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

		// Token: 0x06001D2C RID: 7468 RVA: 0x0005067C File Offset: 0x0004E87C
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

		// Token: 0x06001D2D RID: 7469 RVA: 0x000506E4 File Offset: 0x0004E8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x000506F0 File Offset: 0x0004E8F0
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
				if (num != 90U)
				{
					if (num != 104U)
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

		// Token: 0x04002309 RID: 8969
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400230A RID: 8970
		public const int GridInfoFieldNumber = 11;

		// Token: 0x0400230B RID: 8971
		private OccupiedBoardGridInfo gridInfo_;

		// Token: 0x0400230C RID: 8972
		public const int BoardEntityConfigIdFieldNumber = 13;

		// Token: 0x0400230D RID: 8973
		private int boardEntityConfigId_;
	}
}
