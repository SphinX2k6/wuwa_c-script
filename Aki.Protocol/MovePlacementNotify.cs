using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AAB RID: 2731
	[NetMessage(EMessageId.MovePlacementNotify)]
	public sealed class MovePlacementNotify : IMessage<MovePlacementNotify>, IMessage, IEquatable<MovePlacementNotify>, IDeepCloneable<MovePlacementNotify>, IBufferMessage
	{
		// Token: 0x0600EE00 RID: 60928 RVA: 0x0022C2B8 File Offset: 0x0022A4B8
		[NullableContext(1)]
		public static MovePlacementNotify Create()
		{
			return new MovePlacementNotify();
		}

		// Token: 0x1700305A RID: 12378
		// (get) Token: 0x0600EE01 RID: 60929 RVA: 0x0022C2BF File Offset: 0x0022A4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700305B RID: 12379
		// (get) Token: 0x0600EE02 RID: 60930 RVA: 0x0022C2C2 File Offset: 0x0022A4C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MovePlacementNotify.Descriptor;
			}
		}

		// Token: 0x0600EE03 RID: 60931 RVA: 0x0022C2C9 File Offset: 0x0022A4C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementNotify()
		{
		}

		// Token: 0x0600EE04 RID: 60932 RVA: 0x0022C2D4 File Offset: 0x0022A4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementNotify(MovePlacementNotify other) : this()
		{
			this.targetBoardEntityId_ = other.targetBoardEntityId_;
			this.placementEntityId_ = other.placementEntityId_;
			this.posOnBoard_ = ((other.posOnBoard_ != null) ? other.posOnBoard_.Clone() : null);
			if (other.PositionAndRotateSetCase == MovePlacementNotify.PositionAndRotateSetOneofCase.PosRot)
			{
				this.PosRot = other.PosRot.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EE05 RID: 60933 RVA: 0x0022C347 File Offset: 0x0022A547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementNotify Clone()
		{
			return new MovePlacementNotify(this);
		}

		// Token: 0x1700305C RID: 12380
		// (get) Token: 0x0600EE06 RID: 60934 RVA: 0x0022C34F File Offset: 0x0022A54F
		// (set) Token: 0x0600EE07 RID: 60935 RVA: 0x0022C357 File Offset: 0x0022A557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetBoardEntityId
		{
			get
			{
				return this.targetBoardEntityId_;
			}
			set
			{
				this.targetBoardEntityId_ = value;
			}
		}

		// Token: 0x1700305D RID: 12381
		// (get) Token: 0x0600EE08 RID: 60936 RVA: 0x0022C360 File Offset: 0x0022A560
		// (set) Token: 0x0600EE09 RID: 60937 RVA: 0x0022C368 File Offset: 0x0022A568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlacementEntityId
		{
			get
			{
				return this.placementEntityId_;
			}
			set
			{
				this.placementEntityId_ = value;
			}
		}

		// Token: 0x1700305E RID: 12382
		// (get) Token: 0x0600EE0A RID: 60938 RVA: 0x0022C371 File Offset: 0x0022A571
		// (set) Token: 0x0600EE0B RID: 60939 RVA: 0x0022C379 File Offset: 0x0022A579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridPositionInfo PosOnBoard
		{
			get
			{
				return this.posOnBoard_;
			}
			set
			{
				this.posOnBoard_ = value;
			}
		}

		// Token: 0x1700305F RID: 12383
		// (get) Token: 0x0600EE0C RID: 60940 RVA: 0x0022C382 File Offset: 0x0022A582
		// (set) Token: 0x0600EE0D RID: 60941 RVA: 0x0022C39B File Offset: 0x0022A59B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PositionAndRotate PosRot
		{
			get
			{
				if (this.positionAndRotateSetCase_ != MovePlacementNotify.PositionAndRotateSetOneofCase.PosRot)
				{
					return null;
				}
				return (PositionAndRotate)this.positionAndRotateSet_;
			}
			set
			{
				this.positionAndRotateSet_ = value;
				this.positionAndRotateSetCase_ = ((value == null) ? MovePlacementNotify.PositionAndRotateSetOneofCase.None : MovePlacementNotify.PositionAndRotateSetOneofCase.PosRot);
			}
		}

		// Token: 0x17003060 RID: 12384
		// (get) Token: 0x0600EE0E RID: 60942 RVA: 0x0022C3B2 File Offset: 0x0022A5B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementNotify.PositionAndRotateSetOneofCase PositionAndRotateSetCase
		{
			get
			{
				return this.positionAndRotateSetCase_;
			}
		}

		// Token: 0x0600EE0F RID: 60943 RVA: 0x0022C3BA File Offset: 0x0022A5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPositionAndRotateSet()
		{
			this.positionAndRotateSetCase_ = MovePlacementNotify.PositionAndRotateSetOneofCase.None;
			this.positionAndRotateSet_ = null;
		}

		// Token: 0x0600EE10 RID: 60944 RVA: 0x0022C3CA File Offset: 0x0022A5CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MovePlacementNotify);
		}

		// Token: 0x0600EE11 RID: 60945 RVA: 0x0022C3D8 File Offset: 0x0022A5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MovePlacementNotify other)
		{
			return other != null && (other == this || (this.TargetBoardEntityId == other.TargetBoardEntityId && this.PlacementEntityId == other.PlacementEntityId && object.Equals(this.PosOnBoard, other.PosOnBoard) && object.Equals(this.PosRot, other.PosRot) && this.PositionAndRotateSetCase == other.PositionAndRotateSetCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EE12 RID: 60946 RVA: 0x0022C45C File Offset: 0x0022A65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetBoardEntityId != 0L)
			{
				num ^= this.TargetBoardEntityId.GetHashCode();
			}
			if (this.PlacementEntityId != 0L)
			{
				num ^= this.PlacementEntityId.GetHashCode();
			}
			if (this.posOnBoard_ != null)
			{
				num ^= this.PosOnBoard.GetHashCode();
			}
			if (this.positionAndRotateSetCase_ == MovePlacementNotify.PositionAndRotateSetOneofCase.PosRot)
			{
				num ^= this.PosRot.GetHashCode();
			}
			num ^= (int)this.positionAndRotateSetCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EE13 RID: 60947 RVA: 0x0022C4EB File Offset: 0x0022A6EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EE14 RID: 60948 RVA: 0x0022C4F8 File Offset: 0x0022A6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EE15 RID: 60949 RVA: 0x0022C504 File Offset: 0x0022A704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetBoardEntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TargetBoardEntityId);
			}
			if (this.PlacementEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.PlacementEntityId);
			}
			if (this.positionAndRotateSetCase_ == MovePlacementNotify.PositionAndRotateSetOneofCase.PosRot)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PosRot);
			}
			if (this.posOnBoard_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.PosOnBoard);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EE16 RID: 60950 RVA: 0x0022C598 File Offset: 0x0022A798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetBoardEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetBoardEntityId);
			}
			if (this.PlacementEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PlacementEntityId);
			}
			if (this.posOnBoard_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PosOnBoard);
			}
			if (this.positionAndRotateSetCase_ == MovePlacementNotify.PositionAndRotateSetOneofCase.PosRot)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PosRot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EE17 RID: 60951 RVA: 0x0022C620 File Offset: 0x0022A820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MovePlacementNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetBoardEntityId != 0L)
			{
				this.TargetBoardEntityId = other.TargetBoardEntityId;
			}
			if (other.PlacementEntityId != 0L)
			{
				this.PlacementEntityId = other.PlacementEntityId;
			}
			if (other.posOnBoard_ != null)
			{
				if (this.posOnBoard_ == null)
				{
					this.PosOnBoard = new BoardGridPositionInfo();
				}
				this.PosOnBoard.MergeFrom(other.PosOnBoard);
			}
			if (other.PositionAndRotateSetCase == MovePlacementNotify.PositionAndRotateSetOneofCase.PosRot)
			{
				if (this.PosRot == null)
				{
					this.PosRot = new PositionAndRotate();
				}
				this.PosRot.MergeFrom(other.PosRot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EE18 RID: 60952 RVA: 0x0022C6CA File Offset: 0x0022A8CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EE19 RID: 60953 RVA: 0x0022C6D4 File Offset: 0x0022A8D4
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
				if (num <= 64U)
				{
					if (num == 16U)
					{
						this.TargetBoardEntityId = input.ReadInt64();
						continue;
					}
					if (num == 64U)
					{
						this.PlacementEntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						PositionAndRotate positionAndRotate = new PositionAndRotate();
						if (this.positionAndRotateSetCase_ == MovePlacementNotify.PositionAndRotateSetOneofCase.PosRot)
						{
							positionAndRotate.MergeFrom(this.PosRot);
						}
						input.ReadMessage(positionAndRotate);
						this.PosRot = positionAndRotate;
						continue;
					}
					if (num == 90U)
					{
						if (this.posOnBoard_ == null)
						{
							this.PosOnBoard = new BoardGridPositionInfo();
						}
						input.ReadMessage(this.PosOnBoard);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040060B3 RID: 24755
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060B4 RID: 24756
		public const int TargetBoardEntityIdFieldNumber = 2;

		// Token: 0x040060B5 RID: 24757
		private long targetBoardEntityId_;

		// Token: 0x040060B6 RID: 24758
		public const int PlacementEntityIdFieldNumber = 8;

		// Token: 0x040060B7 RID: 24759
		private long placementEntityId_;

		// Token: 0x040060B8 RID: 24760
		public const int PosOnBoardFieldNumber = 11;

		// Token: 0x040060B9 RID: 24761
		private BoardGridPositionInfo posOnBoard_;

		// Token: 0x040060BA RID: 24762
		public const int PosRotFieldNumber = 10;

		// Token: 0x040060BB RID: 24763
		private object positionAndRotateSet_;

		// Token: 0x040060BC RID: 24764
		private MovePlacementNotify.PositionAndRotateSetOneofCase positionAndRotateSetCase_;

		// Token: 0x020018CC RID: 6348
		public enum PositionAndRotateSetOneofCase
		{
			// Token: 0x0400CD52 RID: 52562
			None,
			// Token: 0x0400CD53 RID: 52563
			PosRot = 10
		}
	}
}
