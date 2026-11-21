using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AAC RID: 2732
	[NetMessage(EMessageId.MovePlacementRequest)]
	public sealed class MovePlacementRequest : IMessage<MovePlacementRequest>, IMessage, IEquatable<MovePlacementRequest>, IDeepCloneable<MovePlacementRequest>, IBufferMessage
	{
		// Token: 0x0600EE1A RID: 60954 RVA: 0x0022C790 File Offset: 0x0022A990
		[NullableContext(1)]
		public static MovePlacementRequest Create()
		{
			return new MovePlacementRequest();
		}

		// Token: 0x17003061 RID: 12385
		// (get) Token: 0x0600EE1B RID: 60955 RVA: 0x0022C797 File Offset: 0x0022A997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003062 RID: 12386
		// (get) Token: 0x0600EE1C RID: 60956 RVA: 0x0022C79A File Offset: 0x0022A99A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MovePlacementRequest.Descriptor;
			}
		}

		// Token: 0x0600EE1D RID: 60957 RVA: 0x0022C7A1 File Offset: 0x0022A9A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementRequest()
		{
		}

		// Token: 0x0600EE1E RID: 60958 RVA: 0x0022C7AC File Offset: 0x0022A9AC
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

		// Token: 0x0600EE1F RID: 60959 RVA: 0x0022C81E File Offset: 0x0022AA1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementRequest Clone()
		{
			return new MovePlacementRequest(this);
		}

		// Token: 0x17003063 RID: 12387
		// (get) Token: 0x0600EE20 RID: 60960 RVA: 0x0022C826 File Offset: 0x0022AA26
		// (set) Token: 0x0600EE21 RID: 60961 RVA: 0x0022C82E File Offset: 0x0022AA2E
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

		// Token: 0x17003064 RID: 12388
		// (get) Token: 0x0600EE22 RID: 60962 RVA: 0x0022C837 File Offset: 0x0022AA37
		// (set) Token: 0x0600EE23 RID: 60963 RVA: 0x0022C83F File Offset: 0x0022AA3F
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

		// Token: 0x17003065 RID: 12389
		// (get) Token: 0x0600EE24 RID: 60964 RVA: 0x0022C848 File Offset: 0x0022AA48
		// (set) Token: 0x0600EE25 RID: 60965 RVA: 0x0022C850 File Offset: 0x0022AA50
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

		// Token: 0x17003066 RID: 12390
		// (get) Token: 0x0600EE26 RID: 60966 RVA: 0x0022C859 File Offset: 0x0022AA59
		// (set) Token: 0x0600EE27 RID: 60967 RVA: 0x0022C871 File Offset: 0x0022AA71
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

		// Token: 0x17003067 RID: 12391
		// (get) Token: 0x0600EE28 RID: 60968 RVA: 0x0022C887 File Offset: 0x0022AA87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementRequest.PositionAndRotateSetOneofCase PositionAndRotateSetCase
		{
			get
			{
				return this.positionAndRotateSetCase_;
			}
		}

		// Token: 0x0600EE29 RID: 60969 RVA: 0x0022C88F File Offset: 0x0022AA8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPositionAndRotateSet()
		{
			this.positionAndRotateSetCase_ = MovePlacementRequest.PositionAndRotateSetOneofCase.None;
			this.positionAndRotateSet_ = null;
		}

		// Token: 0x0600EE2A RID: 60970 RVA: 0x0022C89F File Offset: 0x0022AA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MovePlacementRequest);
		}

		// Token: 0x0600EE2B RID: 60971 RVA: 0x0022C8B0 File Offset: 0x0022AAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MovePlacementRequest other)
		{
			return other != null && (other == this || (this.TargetBoardEntityId == other.TargetBoardEntityId && this.PlacementEntityId == other.PlacementEntityId && object.Equals(this.PosOnBoard, other.PosOnBoard) && object.Equals(this.PosRot, other.PosRot) && this.PositionAndRotateSetCase == other.PositionAndRotateSetCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EE2C RID: 60972 RVA: 0x0022C934 File Offset: 0x0022AB34
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

		// Token: 0x0600EE2D RID: 60973 RVA: 0x0022C9C2 File Offset: 0x0022ABC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EE2E RID: 60974 RVA: 0x0022C9CF File Offset: 0x0022ABCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EE2F RID: 60975 RVA: 0x0022C9D8 File Offset: 0x0022ABD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.positionAndRotateSetCase_ == MovePlacementRequest.PositionAndRotateSetOneofCase.PosRot)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PosRot);
			}
			if (this.TargetBoardEntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TargetBoardEntityId);
			}
			if (this.PlacementEntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.PlacementEntityId);
			}
			if (this.posOnBoard_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.PosOnBoard);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EE30 RID: 60976 RVA: 0x0022CA6C File Offset: 0x0022AC6C
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

		// Token: 0x0600EE31 RID: 60977 RVA: 0x0022CAF4 File Offset: 0x0022ACF4
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

		// Token: 0x0600EE32 RID: 60978 RVA: 0x0022CB9D File Offset: 0x0022AD9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EE33 RID: 60979 RVA: 0x0022CBA8 File Offset: 0x0022ADA8
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
					if (num == 10U)
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
					if (num == 16U)
					{
						this.TargetBoardEntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.PlacementEntityId = input.ReadInt64();
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
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040060BD RID: 24765
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060BE RID: 24766
		public const int TargetBoardEntityIdFieldNumber = 2;

		// Token: 0x040060BF RID: 24767
		private long targetBoardEntityId_;

		// Token: 0x040060C0 RID: 24768
		public const int PlacementEntityIdFieldNumber = 4;

		// Token: 0x040060C1 RID: 24769
		private long placementEntityId_;

		// Token: 0x040060C2 RID: 24770
		public const int PosOnBoardFieldNumber = 13;

		// Token: 0x040060C3 RID: 24771
		private BoardGridPositionInfo posOnBoard_;

		// Token: 0x040060C4 RID: 24772
		public const int PosRotFieldNumber = 1;

		// Token: 0x040060C5 RID: 24773
		private object positionAndRotateSet_;

		// Token: 0x040060C6 RID: 24774
		private MovePlacementRequest.PositionAndRotateSetOneofCase positionAndRotateSetCase_;

		// Token: 0x020018CD RID: 6349
		public enum PositionAndRotateSetOneofCase
		{
			// Token: 0x0400CD55 RID: 52565
			None,
			// Token: 0x0400CD56 RID: 52566
			PosRot
		}
	}
}
