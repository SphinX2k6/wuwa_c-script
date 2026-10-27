using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ABD RID: 2749
	[NetMessage(EMessageId.MovePlacementRequest)]
	public sealed class MovePlacementRequest : IMessage<MovePlacementRequest>, IMessage, IEquatable<MovePlacementRequest>, IDeepCloneable<MovePlacementRequest>, IBufferMessage
	{
		// Token: 0x0600EF34 RID: 61236 RVA: 0x0022E98F File Offset: 0x0022CB8F
		[NullableContext(1)]
		public static MovePlacementRequest Create()
		{
			return new MovePlacementRequest();
		}

		// Token: 0x1700309F RID: 12447
		// (get) Token: 0x0600EF35 RID: 61237 RVA: 0x0022E996 File Offset: 0x0022CB96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030A0 RID: 12448
		// (get) Token: 0x0600EF36 RID: 61238 RVA: 0x0022E999 File Offset: 0x0022CB99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MovePlacementRequest.Descriptor;
			}
		}

		// Token: 0x0600EF37 RID: 61239 RVA: 0x0022E9A0 File Offset: 0x0022CBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementRequest()
		{
		}

		// Token: 0x0600EF38 RID: 61240 RVA: 0x0022E9A8 File Offset: 0x0022CBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementRequest(MovePlacementRequest other) : this()
		{
			this.targetBoardEntityId_ = other.targetBoardEntityId_;
			this.placementEntityId_ = other.placementEntityId_;
			this.posOnBoard_ = ((other.posOnBoard_ != null) ? other.posOnBoard_.Clone() : null);
			if (other.PositionAndRotateSetCase == MovePlacementRequest.PositionAndRotateSetOneofCase.PosRot)
			{
				this.PosRot = other.PosRot.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EF39 RID: 61241 RVA: 0x0022EA1B File Offset: 0x0022CC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementRequest Clone()
		{
			return new MovePlacementRequest(this);
		}

		// Token: 0x170030A1 RID: 12449
		// (get) Token: 0x0600EF3A RID: 61242 RVA: 0x0022EA23 File Offset: 0x0022CC23
		// (set) Token: 0x0600EF3B RID: 61243 RVA: 0x0022EA2B File Offset: 0x0022CC2B
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

		// Token: 0x170030A2 RID: 12450
		// (get) Token: 0x0600EF3C RID: 61244 RVA: 0x0022EA34 File Offset: 0x0022CC34
		// (set) Token: 0x0600EF3D RID: 61245 RVA: 0x0022EA3C File Offset: 0x0022CC3C
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

		// Token: 0x170030A3 RID: 12451
		// (get) Token: 0x0600EF3E RID: 61246 RVA: 0x0022EA45 File Offset: 0x0022CC45
		// (set) Token: 0x0600EF3F RID: 61247 RVA: 0x0022EA4D File Offset: 0x0022CC4D
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

		// Token: 0x170030A4 RID: 12452
		// (get) Token: 0x0600EF40 RID: 61248 RVA: 0x0022EA56 File Offset: 0x0022CC56
		// (set) Token: 0x0600EF41 RID: 61249 RVA: 0x0022EA6F File Offset: 0x0022CC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PositionAndRotate PosRot
		{
			get
			{
				if (this.positionAndRotateSetCase_ != MovePlacementRequest.PositionAndRotateSetOneofCase.PosRot)
				{
					return null;
				}
				return (PositionAndRotate)this.positionAndRotateSet_;
			}
			set
			{
				this.positionAndRotateSet_ = value;
				this.positionAndRotateSetCase_ = ((value == null) ? MovePlacementRequest.PositionAndRotateSetOneofCase.None : MovePlacementRequest.PositionAndRotateSetOneofCase.PosRot);
			}
		}

		// Token: 0x170030A5 RID: 12453
		// (get) Token: 0x0600EF42 RID: 61250 RVA: 0x0022EA86 File Offset: 0x0022CC86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementRequest.PositionAndRotateSetOneofCase PositionAndRotateSetCase
		{
			get
			{
				return this.positionAndRotateSetCase_;
			}
		}

		// Token: 0x0600EF43 RID: 61251 RVA: 0x0022EA8E File Offset: 0x0022CC8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPositionAndRotateSet()
		{
			this.positionAndRotateSetCase_ = MovePlacementRequest.PositionAndRotateSetOneofCase.None;
			this.positionAndRotateSet_ = null;
		}

		// Token: 0x0600EF44 RID: 61252 RVA: 0x0022EA9E File Offset: 0x0022CC9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MovePlacementRequest);
		}

		// Token: 0x0600EF45 RID: 61253 RVA: 0x0022EAAC File Offset: 0x0022CCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MovePlacementRequest other)
		{
			return other != null && (other == this || (this.TargetBoardEntityId == other.TargetBoardEntityId && this.PlacementEntityId == other.PlacementEntityId && object.Equals(this.PosOnBoard, other.PosOnBoard) && object.Equals(this.PosRot, other.PosRot) && this.PositionAndRotateSetCase == other.PositionAndRotateSetCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EF46 RID: 61254 RVA: 0x0022EB30 File Offset: 0x0022CD30
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
			if (this.positionAndRotateSetCase_ == MovePlacementRequest.PositionAndRotateSetOneofCase.PosRot)
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

		// Token: 0x0600EF47 RID: 61255 RVA: 0x0022EBBF File Offset: 0x0022CDBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EF48 RID: 61256 RVA: 0x0022EBCC File Offset: 0x0022CDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EF49 RID: 61257 RVA: 0x0022EBD8 File Offset: 0x0022CDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.posOnBoard_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PosOnBoard);
			}
			if (this.positionAndRotateSetCase_ == MovePlacementRequest.PositionAndRotateSetOneofCase.PosRot)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PosRot);
			}
			if (this.TargetBoardEntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.TargetBoardEntityId);
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

		// Token: 0x0600EF4A RID: 61258 RVA: 0x0022EC6C File Offset: 0x0022CE6C
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
			if (this.positionAndRotateSetCase_ == MovePlacementRequest.PositionAndRotateSetOneofCase.PosRot)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PosRot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EF4B RID: 61259 RVA: 0x0022ECF4 File Offset: 0x0022CEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MovePlacementRequest other)
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
			if (other.PositionAndRotateSetCase == MovePlacementRequest.PositionAndRotateSetOneofCase.PosRot)
			{
				if (this.PosRot == null)
				{
					this.PosRot = new PositionAndRotate();
				}
				this.PosRot.MergeFrom(other.PosRot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EF4C RID: 61260 RVA: 0x0022ED9E File Offset: 0x0022CF9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EF4D RID: 61261 RVA: 0x0022EDA8 File Offset: 0x0022CFA8
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
					if (num == 10U)
					{
						if (this.posOnBoard_ == null)
						{
							this.PosOnBoard = new BoardGridPositionInfo();
						}
						input.ReadMessage(this.PosOnBoard);
						continue;
					}
					if (num == 82U)
					{
						PositionAndRotate positionAndRotate = new PositionAndRotate();
						if (this.positionAndRotateSetCase_ == MovePlacementRequest.PositionAndRotateSetOneofCase.PosRot)
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
					if (num == 88U)
					{
						this.TargetBoardEntityId = input.ReadInt64();
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

		// Token: 0x040060B4 RID: 24756
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060B5 RID: 24757
		public const int TargetBoardEntityIdFieldNumber = 11;

		// Token: 0x040060B6 RID: 24758
		private long targetBoardEntityId_;

		// Token: 0x040060B7 RID: 24759
		public const int PlacementEntityIdFieldNumber = 12;

		// Token: 0x040060B8 RID: 24760
		private long placementEntityId_;

		// Token: 0x040060B9 RID: 24761
		public const int PosOnBoardFieldNumber = 1;

		// Token: 0x040060BA RID: 24762
		private BoardGridPositionInfo posOnBoard_;

		// Token: 0x040060BB RID: 24763
		public const int PosRotFieldNumber = 10;

		// Token: 0x040060BC RID: 24764
		private object positionAndRotateSet_;

		// Token: 0x040060BD RID: 24765
		private MovePlacementRequest.PositionAndRotateSetOneofCase positionAndRotateSetCase_;

		// Token: 0x02001855 RID: 6229
		public enum PositionAndRotateSetOneofCase
		{
			// Token: 0x0400C82A RID: 51242
			None,
			// Token: 0x0400C82B RID: 51243
			PosRot = 10
		}
	}
}
