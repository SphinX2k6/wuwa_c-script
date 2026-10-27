using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ABC RID: 2748
	[NetMessage(EMessageId.MovePlacementNotify)]
	public sealed class MovePlacementNotify : IMessage<MovePlacementNotify>, IMessage, IEquatable<MovePlacementNotify>, IDeepCloneable<MovePlacementNotify>, IBufferMessage
	{
		// Token: 0x0600EF1A RID: 61210 RVA: 0x0022E4B8 File Offset: 0x0022C6B8
		[NullableContext(1)]
		public static MovePlacementNotify Create()
		{
			return new MovePlacementNotify();
		}

		// Token: 0x17003098 RID: 12440
		// (get) Token: 0x0600EF1B RID: 61211 RVA: 0x0022E4BF File Offset: 0x0022C6BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003099 RID: 12441
		// (get) Token: 0x0600EF1C RID: 61212 RVA: 0x0022E4C2 File Offset: 0x0022C6C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MovePlacementNotify.Descriptor;
			}
		}

		// Token: 0x0600EF1D RID: 61213 RVA: 0x0022E4C9 File Offset: 0x0022C6C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementNotify()
		{
		}

		// Token: 0x0600EF1E RID: 61214 RVA: 0x0022E4D4 File Offset: 0x0022C6D4
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

		// Token: 0x0600EF1F RID: 61215 RVA: 0x0022E547 File Offset: 0x0022C747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementNotify Clone()
		{
			return new MovePlacementNotify(this);
		}

		// Token: 0x1700309A RID: 12442
		// (get) Token: 0x0600EF20 RID: 61216 RVA: 0x0022E54F File Offset: 0x0022C74F
		// (set) Token: 0x0600EF21 RID: 61217 RVA: 0x0022E557 File Offset: 0x0022C757
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

		// Token: 0x1700309B RID: 12443
		// (get) Token: 0x0600EF22 RID: 61218 RVA: 0x0022E560 File Offset: 0x0022C760
		// (set) Token: 0x0600EF23 RID: 61219 RVA: 0x0022E568 File Offset: 0x0022C768
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

		// Token: 0x1700309C RID: 12444
		// (get) Token: 0x0600EF24 RID: 61220 RVA: 0x0022E571 File Offset: 0x0022C771
		// (set) Token: 0x0600EF25 RID: 61221 RVA: 0x0022E579 File Offset: 0x0022C779
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

		// Token: 0x1700309D RID: 12445
		// (get) Token: 0x0600EF26 RID: 61222 RVA: 0x0022E582 File Offset: 0x0022C782
		// (set) Token: 0x0600EF27 RID: 61223 RVA: 0x0022E59B File Offset: 0x0022C79B
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

		// Token: 0x1700309E RID: 12446
		// (get) Token: 0x0600EF28 RID: 61224 RVA: 0x0022E5B2 File Offset: 0x0022C7B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementNotify.PositionAndRotateSetOneofCase PositionAndRotateSetCase
		{
			get
			{
				return this.positionAndRotateSetCase_;
			}
		}

		// Token: 0x0600EF29 RID: 61225 RVA: 0x0022E5BA File Offset: 0x0022C7BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPositionAndRotateSet()
		{
			this.positionAndRotateSetCase_ = MovePlacementNotify.PositionAndRotateSetOneofCase.None;
			this.positionAndRotateSet_ = null;
		}

		// Token: 0x0600EF2A RID: 61226 RVA: 0x0022E5CA File Offset: 0x0022C7CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MovePlacementNotify);
		}

		// Token: 0x0600EF2B RID: 61227 RVA: 0x0022E5D8 File Offset: 0x0022C7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MovePlacementNotify other)
		{
			return other != null && (other == this || (this.TargetBoardEntityId == other.TargetBoardEntityId && this.PlacementEntityId == other.PlacementEntityId && object.Equals(this.PosOnBoard, other.PosOnBoard) && object.Equals(this.PosRot, other.PosRot) && this.PositionAndRotateSetCase == other.PositionAndRotateSetCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EF2C RID: 61228 RVA: 0x0022E65C File Offset: 0x0022C85C
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

		// Token: 0x0600EF2D RID: 61229 RVA: 0x0022E6EB File Offset: 0x0022C8EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EF2E RID: 61230 RVA: 0x0022E6F8 File Offset: 0x0022C8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EF2F RID: 61231 RVA: 0x0022E704 File Offset: 0x0022C904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlacementEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.PlacementEntityId);
			}
			if (this.TargetBoardEntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TargetBoardEntityId);
			}
			if (this.posOnBoard_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.PosOnBoard);
			}
			if (this.positionAndRotateSetCase_ == MovePlacementNotify.PositionAndRotateSetOneofCase.PosRot)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.PosRot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EF30 RID: 61232 RVA: 0x0022E798 File Offset: 0x0022C998
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

		// Token: 0x0600EF31 RID: 61233 RVA: 0x0022E820 File Offset: 0x0022CA20
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

		// Token: 0x0600EF32 RID: 61234 RVA: 0x0022E8CA File Offset: 0x0022CACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EF33 RID: 61235 RVA: 0x0022E8D4 File Offset: 0x0022CAD4
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.PlacementEntityId = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.TargetBoardEntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						if (this.posOnBoard_ == null)
						{
							this.PosOnBoard = new BoardGridPositionInfo();
						}
						input.ReadMessage(this.PosOnBoard);
						continue;
					}
					if (num == 90U)
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
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040060AA RID: 24746
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060AB RID: 24747
		public const int TargetBoardEntityIdFieldNumber = 2;

		// Token: 0x040060AC RID: 24748
		private long targetBoardEntityId_;

		// Token: 0x040060AD RID: 24749
		public const int PlacementEntityIdFieldNumber = 1;

		// Token: 0x040060AE RID: 24750
		private long placementEntityId_;

		// Token: 0x040060AF RID: 24751
		public const int PosOnBoardFieldNumber = 9;

		// Token: 0x040060B0 RID: 24752
		private BoardGridPositionInfo posOnBoard_;

		// Token: 0x040060B1 RID: 24753
		public const int PosRotFieldNumber = 11;

		// Token: 0x040060B2 RID: 24754
		private object positionAndRotateSet_;

		// Token: 0x040060B3 RID: 24755
		private MovePlacementNotify.PositionAndRotateSetOneofCase positionAndRotateSetCase_;

		// Token: 0x02001854 RID: 6228
		public enum PositionAndRotateSetOneofCase
		{
			// Token: 0x0400C827 RID: 51239
			None,
			// Token: 0x0400C828 RID: 51240
			PosRot = 11
		}
	}
}
