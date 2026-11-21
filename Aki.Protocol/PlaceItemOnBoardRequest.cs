using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D62 RID: 3426
	[NetMessage(EMessageId.PlaceItemOnBoardRequest)]
	public sealed class PlaceItemOnBoardRequest : IMessage<PlaceItemOnBoardRequest>, IMessage, IEquatable<PlaceItemOnBoardRequest>, IDeepCloneable<PlaceItemOnBoardRequest>, IBufferMessage
	{
		// Token: 0x060127E6 RID: 75750 RVA: 0x002B3187 File Offset: 0x002B1387
		[NullableContext(1)]
		public static PlaceItemOnBoardRequest Create()
		{
			return new PlaceItemOnBoardRequest();
		}

		// Token: 0x17003D4B RID: 15691
		// (get) Token: 0x060127E7 RID: 75751 RVA: 0x002B318E File Offset: 0x002B138E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D4C RID: 15692
		// (get) Token: 0x060127E8 RID: 75752 RVA: 0x002B3191 File Offset: 0x002B1391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlaceItemOnBoardRequest.Descriptor;
			}
		}

		// Token: 0x060127E9 RID: 75753 RVA: 0x002B3198 File Offset: 0x002B1398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardRequest()
		{
		}

		// Token: 0x060127EA RID: 75754 RVA: 0x002B31A0 File Offset: 0x002B13A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardRequest(PlaceItemOnBoardRequest other) : this()
		{
			this.targetBoardEntityId_ = other.targetBoardEntityId_;
			this.placementEntityId_ = other.placementEntityId_;
			this.toPlace_ = other.toPlace_;
			this.posOnBoard_ = ((other.posOnBoard_ != null) ? other.posOnBoard_.Clone() : null);
			if (other.PositionAndRotateSetCase == PlaceItemOnBoardRequest.PositionAndRotateSetOneofCase.PosRot)
			{
				this.PosRot = other.PosRot.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060127EB RID: 75755 RVA: 0x002B321F File Offset: 0x002B141F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardRequest Clone()
		{
			return new PlaceItemOnBoardRequest(this);
		}

		// Token: 0x17003D4D RID: 15693
		// (get) Token: 0x060127EC RID: 75756 RVA: 0x002B3227 File Offset: 0x002B1427
		// (set) Token: 0x060127ED RID: 75757 RVA: 0x002B322F File Offset: 0x002B142F
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

		// Token: 0x17003D4E RID: 15694
		// (get) Token: 0x060127EE RID: 75758 RVA: 0x002B3238 File Offset: 0x002B1438
		// (set) Token: 0x060127EF RID: 75759 RVA: 0x002B3240 File Offset: 0x002B1440
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

		// Token: 0x17003D4F RID: 15695
		// (get) Token: 0x060127F0 RID: 75760 RVA: 0x002B3249 File Offset: 0x002B1449
		// (set) Token: 0x060127F1 RID: 75761 RVA: 0x002B3251 File Offset: 0x002B1451
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

		// Token: 0x17003D50 RID: 15696
		// (get) Token: 0x060127F2 RID: 75762 RVA: 0x002B325A File Offset: 0x002B145A
		// (set) Token: 0x060127F3 RID: 75763 RVA: 0x002B3262 File Offset: 0x002B1462
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

		// Token: 0x17003D51 RID: 15697
		// (get) Token: 0x060127F4 RID: 75764 RVA: 0x002B326B File Offset: 0x002B146B
		// (set) Token: 0x060127F5 RID: 75765 RVA: 0x002B3284 File Offset: 0x002B1484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PositionAndRotate PosRot
		{
			get
			{
				if (this.positionAndRotateSetCase_ != PlaceItemOnBoardRequest.PositionAndRotateSetOneofCase.PosRot)
				{
					return null;
				}
				return (PositionAndRotate)this.positionAndRotateSet_;
			}
			set
			{
				this.positionAndRotateSet_ = value;
				this.positionAndRotateSetCase_ = ((value == null) ? PlaceItemOnBoardRequest.PositionAndRotateSetOneofCase.None : PlaceItemOnBoardRequest.PositionAndRotateSetOneofCase.PosRot);
			}
		}

		// Token: 0x17003D52 RID: 15698
		// (get) Token: 0x060127F6 RID: 75766 RVA: 0x002B329B File Offset: 0x002B149B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardRequest.PositionAndRotateSetOneofCase PositionAndRotateSetCase
		{
			get
			{
				return this.positionAndRotateSetCase_;
			}
		}

		// Token: 0x060127F7 RID: 75767 RVA: 0x002B32A3 File Offset: 0x002B14A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPositionAndRotateSet()
		{
			this.positionAndRotateSetCase_ = PlaceItemOnBoardRequest.PositionAndRotateSetOneofCase.None;
			this.positionAndRotateSet_ = null;
		}

		// Token: 0x060127F8 RID: 75768 RVA: 0x002B32B3 File Offset: 0x002B14B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlaceItemOnBoardRequest);
		}

		// Token: 0x060127F9 RID: 75769 RVA: 0x002B32C4 File Offset: 0x002B14C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlaceItemOnBoardRequest other)
		{
			return other != null && (other == this || (this.TargetBoardEntityId == other.TargetBoardEntityId && this.PlacementEntityId == other.PlacementEntityId && this.ToPlace == other.ToPlace && object.Equals(this.PosOnBoard, other.PosOnBoard) && object.Equals(this.PosRot, other.PosRot) && this.PositionAndRotateSetCase == other.PositionAndRotateSetCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060127FA RID: 75770 RVA: 0x002B3358 File Offset: 0x002B1558
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
			if (this.positionAndRotateSetCase_ == PlaceItemOnBoardRequest.PositionAndRotateSetOneofCase.PosRot)
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

		// Token: 0x060127FB RID: 75771 RVA: 0x002B3400 File Offset: 0x002B1600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060127FC RID: 75772 RVA: 0x002B340D File Offset: 0x002B160D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060127FD RID: 75773 RVA: 0x002B3418 File Offset: 0x002B1618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetBoardEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TargetBoardEntityId);
			}
			if (this.positionAndRotateSetCase_ == PlaceItemOnBoardRequest.PositionAndRotateSetOneofCase.PosRot)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PosRot);
			}
			if (this.ToPlace != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ToPlace);
			}
			if (this.posOnBoard_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.PosOnBoard);
			}
			if (this.PlacementEntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.PlacementEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060127FE RID: 75774 RVA: 0x002B34C8 File Offset: 0x002B16C8
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
			if (this.positionAndRotateSetCase_ == PlaceItemOnBoardRequest.PositionAndRotateSetOneofCase.PosRot)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PosRot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060127FF RID: 75775 RVA: 0x002B3568 File Offset: 0x002B1768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlaceItemOnBoardRequest other)
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
			if (other.PositionAndRotateSetCase == PlaceItemOnBoardRequest.PositionAndRotateSetOneofCase.PosRot)
			{
				if (this.PosRot == null)
				{
					this.PosRot = new PositionAndRotate();
				}
				this.PosRot.MergeFrom(other.PosRot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012800 RID: 75776 RVA: 0x002B3626 File Offset: 0x002B1826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012801 RID: 75777 RVA: 0x002B3630 File Offset: 0x002B1830
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
				if (num <= 82U)
				{
					if (num == 8U)
					{
						this.TargetBoardEntityId = input.ReadInt64();
						continue;
					}
					if (num == 82U)
					{
						PositionAndRotate positionAndRotate = new PositionAndRotate();
						if (this.positionAndRotateSetCase_ == PlaceItemOnBoardRequest.PositionAndRotateSetOneofCase.PosRot)
						{
							positionAndRotate.MergeFrom(this.PosRot);
						}
						input.ReadMessage(positionAndRotate);
						this.PosRot = positionAndRotate;
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.ToPlace = input.ReadInt32();
						continue;
					}
					if (num == 106U)
					{
						if (this.posOnBoard_ == null)
						{
							this.PosOnBoard = new BoardGridPositionInfo();
						}
						input.ReadMessage(this.PosOnBoard);
						continue;
					}
					if (num == 120U)
					{
						this.PlacementEntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007353 RID: 29523
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007354 RID: 29524
		public const int TargetBoardEntityIdFieldNumber = 1;

		// Token: 0x04007355 RID: 29525
		private long targetBoardEntityId_;

		// Token: 0x04007356 RID: 29526
		public const int PlacementEntityIdFieldNumber = 15;

		// Token: 0x04007357 RID: 29527
		private long placementEntityId_;

		// Token: 0x04007358 RID: 29528
		public const int ToPlaceFieldNumber = 12;

		// Token: 0x04007359 RID: 29529
		private int toPlace_;

		// Token: 0x0400735A RID: 29530
		public const int PosOnBoardFieldNumber = 13;

		// Token: 0x0400735B RID: 29531
		private BoardGridPositionInfo posOnBoard_;

		// Token: 0x0400735C RID: 29532
		public const int PosRotFieldNumber = 10;

		// Token: 0x0400735D RID: 29533
		private object positionAndRotateSet_;

		// Token: 0x0400735E RID: 29534
		private PlaceItemOnBoardRequest.PositionAndRotateSetOneofCase positionAndRotateSetCase_;

		// Token: 0x02001951 RID: 6481
		public enum PositionAndRotateSetOneofCase
		{
			// Token: 0x0400CE18 RID: 52760
			None,
			// Token: 0x0400CE19 RID: 52761
			PosRot = 10
		}
	}
}
