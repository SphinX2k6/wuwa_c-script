using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D72 RID: 3442
	[NetMessage(EMessageId.PlaceItemOnBoardRequest)]
	public sealed class PlaceItemOnBoardRequest : IMessage<PlaceItemOnBoardRequest>, IMessage, IEquatable<PlaceItemOnBoardRequest>, IDeepCloneable<PlaceItemOnBoardRequest>, IBufferMessage
	{
		// Token: 0x060128E2 RID: 76002 RVA: 0x002B4DA3 File Offset: 0x002B2FA3
		[NullableContext(1)]
		public static PlaceItemOnBoardRequest Create()
		{
			return new PlaceItemOnBoardRequest();
		}

		// Token: 0x17003D80 RID: 15744
		// (get) Token: 0x060128E3 RID: 76003 RVA: 0x002B4DAA File Offset: 0x002B2FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D81 RID: 15745
		// (get) Token: 0x060128E4 RID: 76004 RVA: 0x002B4DAD File Offset: 0x002B2FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlaceItemOnBoardRequest.Descriptor;
			}
		}

		// Token: 0x060128E5 RID: 76005 RVA: 0x002B4DB4 File Offset: 0x002B2FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardRequest()
		{
		}

		// Token: 0x060128E6 RID: 76006 RVA: 0x002B4DBC File Offset: 0x002B2FBC
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

		// Token: 0x060128E7 RID: 76007 RVA: 0x002B4E3B File Offset: 0x002B303B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardRequest Clone()
		{
			return new PlaceItemOnBoardRequest(this);
		}

		// Token: 0x17003D82 RID: 15746
		// (get) Token: 0x060128E8 RID: 76008 RVA: 0x002B4E43 File Offset: 0x002B3043
		// (set) Token: 0x060128E9 RID: 76009 RVA: 0x002B4E4B File Offset: 0x002B304B
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

		// Token: 0x17003D83 RID: 15747
		// (get) Token: 0x060128EA RID: 76010 RVA: 0x002B4E54 File Offset: 0x002B3054
		// (set) Token: 0x060128EB RID: 76011 RVA: 0x002B4E5C File Offset: 0x002B305C
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

		// Token: 0x17003D84 RID: 15748
		// (get) Token: 0x060128EC RID: 76012 RVA: 0x002B4E65 File Offset: 0x002B3065
		// (set) Token: 0x060128ED RID: 76013 RVA: 0x002B4E6D File Offset: 0x002B306D
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

		// Token: 0x17003D85 RID: 15749
		// (get) Token: 0x060128EE RID: 76014 RVA: 0x002B4E76 File Offset: 0x002B3076
		// (set) Token: 0x060128EF RID: 76015 RVA: 0x002B4E7E File Offset: 0x002B307E
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

		// Token: 0x17003D86 RID: 15750
		// (get) Token: 0x060128F0 RID: 76016 RVA: 0x002B4E87 File Offset: 0x002B3087
		// (set) Token: 0x060128F1 RID: 76017 RVA: 0x002B4EA0 File Offset: 0x002B30A0
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

		// Token: 0x17003D87 RID: 15751
		// (get) Token: 0x060128F2 RID: 76018 RVA: 0x002B4EB7 File Offset: 0x002B30B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardRequest.PositionAndRotateSetOneofCase PositionAndRotateSetCase
		{
			get
			{
				return this.positionAndRotateSetCase_;
			}
		}

		// Token: 0x060128F3 RID: 76019 RVA: 0x002B4EBF File Offset: 0x002B30BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPositionAndRotateSet()
		{
			this.positionAndRotateSetCase_ = PlaceItemOnBoardRequest.PositionAndRotateSetOneofCase.None;
			this.positionAndRotateSet_ = null;
		}

		// Token: 0x060128F4 RID: 76020 RVA: 0x002B4ECF File Offset: 0x002B30CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlaceItemOnBoardRequest);
		}

		// Token: 0x060128F5 RID: 76021 RVA: 0x002B4EE0 File Offset: 0x002B30E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlaceItemOnBoardRequest other)
		{
			return other != null && (other == this || (this.TargetBoardEntityId == other.TargetBoardEntityId && this.PlacementEntityId == other.PlacementEntityId && this.ToPlace == other.ToPlace && object.Equals(this.PosOnBoard, other.PosOnBoard) && object.Equals(this.PosRot, other.PosRot) && this.PositionAndRotateSetCase == other.PositionAndRotateSetCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060128F6 RID: 76022 RVA: 0x002B4F74 File Offset: 0x002B3174
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

		// Token: 0x060128F7 RID: 76023 RVA: 0x002B501C File Offset: 0x002B321C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060128F8 RID: 76024 RVA: 0x002B5029 File Offset: 0x002B3229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060128F9 RID: 76025 RVA: 0x002B5034 File Offset: 0x002B3234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ToPlace != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ToPlace);
			}
			if (this.TargetBoardEntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.TargetBoardEntityId);
			}
			if (this.positionAndRotateSetCase_ == PlaceItemOnBoardRequest.PositionAndRotateSetOneofCase.PosRot)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.PosRot);
			}
			if (this.posOnBoard_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PosOnBoard);
			}
			if (this.PlacementEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.PlacementEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060128FA RID: 76026 RVA: 0x002B50E4 File Offset: 0x002B32E4
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

		// Token: 0x060128FB RID: 76027 RVA: 0x002B5184 File Offset: 0x002B3384
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

		// Token: 0x060128FC RID: 76028 RVA: 0x002B5242 File Offset: 0x002B3442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060128FD RID: 76029 RVA: 0x002B524C File Offset: 0x002B344C
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
					if (num == 16U)
					{
						this.ToPlace = input.ReadInt32();
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
					if (num == 74U)
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
					if (num == 82U)
					{
						if (this.posOnBoard_ == null)
						{
							this.PosOnBoard = new BoardGridPositionInfo();
						}
						input.ReadMessage(this.PosOnBoard);
						continue;
					}
					if (num == 96U)
					{
						this.PlacementEntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400733B RID: 29499
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400733C RID: 29500
		public const int TargetBoardEntityIdFieldNumber = 6;

		// Token: 0x0400733D RID: 29501
		private long targetBoardEntityId_;

		// Token: 0x0400733E RID: 29502
		public const int PlacementEntityIdFieldNumber = 12;

		// Token: 0x0400733F RID: 29503
		private long placementEntityId_;

		// Token: 0x04007340 RID: 29504
		public const int ToPlaceFieldNumber = 2;

		// Token: 0x04007341 RID: 29505
		private int toPlace_;

		// Token: 0x04007342 RID: 29506
		public const int PosOnBoardFieldNumber = 10;

		// Token: 0x04007343 RID: 29507
		private BoardGridPositionInfo posOnBoard_;

		// Token: 0x04007344 RID: 29508
		public const int PosRotFieldNumber = 9;

		// Token: 0x04007345 RID: 29509
		private object positionAndRotateSet_;

		// Token: 0x04007346 RID: 29510
		private PlaceItemOnBoardRequest.PositionAndRotateSetOneofCase positionAndRotateSetCase_;

		// Token: 0x020018D9 RID: 6361
		public enum PositionAndRotateSetOneofCase
		{
			// Token: 0x0400C8ED RID: 51437
			None,
			// Token: 0x0400C8EE RID: 51438
			PosRot = 9
		}
	}
}
