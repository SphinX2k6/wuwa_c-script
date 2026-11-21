using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D61 RID: 3425
	[NetMessage(EMessageId.PlaceItemOnBoardNotify)]
	public sealed class PlaceItemOnBoardNotify : IMessage<PlaceItemOnBoardNotify>, IMessage, IEquatable<PlaceItemOnBoardNotify>, IDeepCloneable<PlaceItemOnBoardNotify>, IBufferMessage
	{
		// Token: 0x060127CE RID: 75726 RVA: 0x002B2D49 File Offset: 0x002B0F49
		[NullableContext(1)]
		public static PlaceItemOnBoardNotify Create()
		{
			return new PlaceItemOnBoardNotify();
		}

		// Token: 0x17003D45 RID: 15685
		// (get) Token: 0x060127CF RID: 75727 RVA: 0x002B2D50 File Offset: 0x002B0F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D46 RID: 15686
		// (get) Token: 0x060127D0 RID: 75728 RVA: 0x002B2D53 File Offset: 0x002B0F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlaceItemOnBoardNotify.Descriptor;
			}
		}

		// Token: 0x060127D1 RID: 75729 RVA: 0x002B2D5A File Offset: 0x002B0F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardNotify()
		{
		}

		// Token: 0x060127D2 RID: 75730 RVA: 0x002B2D64 File Offset: 0x002B0F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardNotify(PlaceItemOnBoardNotify other) : this()
		{
			this.targetBoardEntityId_ = other.targetBoardEntityId_;
			this.placementEntityId_ = other.placementEntityId_;
			this.toPlace_ = other.toPlace_;
			this.posOnBoard_ = ((other.posOnBoard_ != null) ? other.posOnBoard_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060127D3 RID: 75731 RVA: 0x002B2DC8 File Offset: 0x002B0FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardNotify Clone()
		{
			return new PlaceItemOnBoardNotify(this);
		}

		// Token: 0x17003D47 RID: 15687
		// (get) Token: 0x060127D4 RID: 75732 RVA: 0x002B2DD0 File Offset: 0x002B0FD0
		// (set) Token: 0x060127D5 RID: 75733 RVA: 0x002B2DD8 File Offset: 0x002B0FD8
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

		// Token: 0x17003D48 RID: 15688
		// (get) Token: 0x060127D6 RID: 75734 RVA: 0x002B2DE1 File Offset: 0x002B0FE1
		// (set) Token: 0x060127D7 RID: 75735 RVA: 0x002B2DE9 File Offset: 0x002B0FE9
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

		// Token: 0x17003D49 RID: 15689
		// (get) Token: 0x060127D8 RID: 75736 RVA: 0x002B2DF2 File Offset: 0x002B0FF2
		// (set) Token: 0x060127D9 RID: 75737 RVA: 0x002B2DFA File Offset: 0x002B0FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ToPlace
		{
			get
			{
				return this.toPlace_;
			}
			set
			{
				this.toPlace_ = value;
			}
		}

		// Token: 0x17003D4A RID: 15690
		// (get) Token: 0x060127DA RID: 75738 RVA: 0x002B2E03 File Offset: 0x002B1003
		// (set) Token: 0x060127DB RID: 75739 RVA: 0x002B2E0B File Offset: 0x002B100B
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

		// Token: 0x060127DC RID: 75740 RVA: 0x002B2E14 File Offset: 0x002B1014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlaceItemOnBoardNotify);
		}

		// Token: 0x060127DD RID: 75741 RVA: 0x002B2E24 File Offset: 0x002B1024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlaceItemOnBoardNotify other)
		{
			return other != null && (other == this || (this.TargetBoardEntityId == other.TargetBoardEntityId && this.PlacementEntityId == other.PlacementEntityId && this.ToPlace == other.ToPlace && object.Equals(this.PosOnBoard, other.PosOnBoard) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060127DE RID: 75742 RVA: 0x002B2E94 File Offset: 0x002B1094
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
			if (this.ToPlace != 0)
			{
				num ^= this.ToPlace.GetHashCode();
			}
			if (this.posOnBoard_ != null)
			{
				num ^= this.PosOnBoard.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060127DF RID: 75743 RVA: 0x002B2F1B File Offset: 0x002B111B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060127E0 RID: 75744 RVA: 0x002B2F28 File Offset: 0x002B1128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060127E1 RID: 75745 RVA: 0x002B2F34 File Offset: 0x002B1134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.posOnBoard_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.PosOnBoard);
			}
			if (this.TargetBoardEntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.TargetBoardEntityId);
			}
			if (this.PlacementEntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.PlacementEntityId);
			}
			if (this.ToPlace != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ToPlace);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060127E2 RID: 75746 RVA: 0x002B2FC8 File Offset: 0x002B11C8
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
			if (this.ToPlace != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ToPlace);
			}
			if (this.posOnBoard_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PosOnBoard);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060127E3 RID: 75747 RVA: 0x002B3050 File Offset: 0x002B1250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlaceItemOnBoardNotify other)
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
			if (other.ToPlace != 0)
			{
				this.ToPlace = other.ToPlace;
			}
			if (other.posOnBoard_ != null)
			{
				if (this.posOnBoard_ == null)
				{
					this.PosOnBoard = new BoardGridPositionInfo();
				}
				this.PosOnBoard.MergeFrom(other.PosOnBoard);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060127E4 RID: 75748 RVA: 0x002B30E0 File Offset: 0x002B12E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060127E5 RID: 75749 RVA: 0x002B30EC File Offset: 0x002B12EC
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
				if (num <= 48U)
				{
					if (num == 42U)
					{
						if (this.posOnBoard_ == null)
						{
							this.PosOnBoard = new BoardGridPositionInfo();
						}
						input.ReadMessage(this.PosOnBoard);
						continue;
					}
					if (num == 48U)
					{
						this.TargetBoardEntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.PlacementEntityId = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.ToPlace = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400734A RID: 29514
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400734B RID: 29515
		public const int TargetBoardEntityIdFieldNumber = 6;

		// Token: 0x0400734C RID: 29516
		private long targetBoardEntityId_;

		// Token: 0x0400734D RID: 29517
		public const int PlacementEntityIdFieldNumber = 14;

		// Token: 0x0400734E RID: 29518
		private long placementEntityId_;

		// Token: 0x0400734F RID: 29519
		public const int ToPlaceFieldNumber = 15;

		// Token: 0x04007350 RID: 29520
		private int toPlace_;

		// Token: 0x04007351 RID: 29521
		public const int PosOnBoardFieldNumber = 5;

		// Token: 0x04007352 RID: 29522
		private BoardGridPositionInfo posOnBoard_;
	}
}
