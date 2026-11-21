using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E75 RID: 3701
	public sealed class RbBlockComponentPb : IMessage<RbBlockComponentPb>, IMessage, IEquatable<RbBlockComponentPb>, IDeepCloneable<RbBlockComponentPb>, IBufferMessage
	{
		// Token: 0x06013E7D RID: 81533 RVA: 0x002E6988 File Offset: 0x002E4B88
		[NullableContext(1)]
		public static RbBlockComponentPb Create()
		{
			return new RbBlockComponentPb();
		}

		// Token: 0x17004239 RID: 16953
		// (get) Token: 0x06013E7E RID: 81534 RVA: 0x002E698F File Offset: 0x002E4B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700423A RID: 16954
		// (get) Token: 0x06013E7F RID: 81535 RVA: 0x002E6992 File Offset: 0x002E4B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbBlockComponentPb.Descriptor;
			}
		}

		// Token: 0x06013E80 RID: 81536 RVA: 0x002E6999 File Offset: 0x002E4B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockComponentPb()
		{
		}

		// Token: 0x06013E81 RID: 81537 RVA: 0x002E69AC File Offset: 0x002E4BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockComponentPb(RbBlockComponentPb other) : this()
		{
			this.centerPosition_ = ((other.centerPosition_ != null) ? other.centerPosition_.Clone() : null);
			this.sizeX_ = other.sizeX_;
			this.sizeY_ = other.sizeY_;
			this.sizeZ_ = other.sizeZ_;
			this.forward_ = ((other.forward_ != null) ? other.forward_.Clone() : null);
			this.right_ = ((other.right_ != null) ? other.right_.Clone() : null);
			this.state_ = ((other.state_ != null) ? other.state_.Clone() : null);
			this.gamePlayIncId_ = other.gamePlayIncId_;
			this.occupiedCellPositions_ = other.occupiedCellPositions_.Clone();
			RbBlockComponentPb.TypeOneofCase typeCase = other.TypeCase;
			if (typeCase != RbBlockComponentPb.TypeOneofCase.DefaultBlockType)
			{
				if (typeCase == RbBlockComponentPb.TypeOneofCase.VisionBlockType)
				{
					this.VisionBlockType = other.VisionBlockType.Clone();
				}
			}
			else
			{
				this.DefaultBlockType = other.DefaultBlockType.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013E82 RID: 81538 RVA: 0x002E6AB8 File Offset: 0x002E4CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockComponentPb Clone()
		{
			return new RbBlockComponentPb(this);
		}

		// Token: 0x1700423B RID: 16955
		// (get) Token: 0x06013E83 RID: 81539 RVA: 0x002E6AC0 File Offset: 0x002E4CC0
		// (set) Token: 0x06013E84 RID: 81540 RVA: 0x002E6AC8 File Offset: 0x002E4CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector CenterPosition
		{
			get
			{
				return this.centerPosition_;
			}
			set
			{
				this.centerPosition_ = value;
			}
		}

		// Token: 0x1700423C RID: 16956
		// (get) Token: 0x06013E85 RID: 81541 RVA: 0x002E6AD1 File Offset: 0x002E4CD1
		// (set) Token: 0x06013E86 RID: 81542 RVA: 0x002E6AD9 File Offset: 0x002E4CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SizeX
		{
			get
			{
				return this.sizeX_;
			}
			set
			{
				this.sizeX_ = value;
			}
		}

		// Token: 0x1700423D RID: 16957
		// (get) Token: 0x06013E87 RID: 81543 RVA: 0x002E6AE2 File Offset: 0x002E4CE2
		// (set) Token: 0x06013E88 RID: 81544 RVA: 0x002E6AEA File Offset: 0x002E4CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SizeY
		{
			get
			{
				return this.sizeY_;
			}
			set
			{
				this.sizeY_ = value;
			}
		}

		// Token: 0x1700423E RID: 16958
		// (get) Token: 0x06013E89 RID: 81545 RVA: 0x002E6AF3 File Offset: 0x002E4CF3
		// (set) Token: 0x06013E8A RID: 81546 RVA: 0x002E6AFB File Offset: 0x002E4CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SizeZ
		{
			get
			{
				return this.sizeZ_;
			}
			set
			{
				this.sizeZ_ = value;
			}
		}

		// Token: 0x1700423F RID: 16959
		// (get) Token: 0x06013E8B RID: 81547 RVA: 0x002E6B04 File Offset: 0x002E4D04
		// (set) Token: 0x06013E8C RID: 81548 RVA: 0x002E6B0C File Offset: 0x002E4D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Forward
		{
			get
			{
				return this.forward_;
			}
			set
			{
				this.forward_ = value;
			}
		}

		// Token: 0x17004240 RID: 16960
		// (get) Token: 0x06013E8D RID: 81549 RVA: 0x002E6B15 File Offset: 0x002E4D15
		// (set) Token: 0x06013E8E RID: 81550 RVA: 0x002E6B1D File Offset: 0x002E4D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Right
		{
			get
			{
				return this.right_;
			}
			set
			{
				this.right_ = value;
			}
		}

		// Token: 0x17004241 RID: 16961
		// (get) Token: 0x06013E8F RID: 81551 RVA: 0x002E6B26 File Offset: 0x002E4D26
		// (set) Token: 0x06013E90 RID: 81552 RVA: 0x002E6B2E File Offset: 0x002E4D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockPbState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17004242 RID: 16962
		// (get) Token: 0x06013E91 RID: 81553 RVA: 0x002E6B37 File Offset: 0x002E4D37
		// (set) Token: 0x06013E92 RID: 81554 RVA: 0x002E6B3F File Offset: 0x002E4D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GamePlayIncId
		{
			get
			{
				return this.gamePlayIncId_;
			}
			set
			{
				this.gamePlayIncId_ = value;
			}
		}

		// Token: 0x17004243 RID: 16963
		// (get) Token: 0x06013E93 RID: 81555 RVA: 0x002E6B48 File Offset: 0x002E4D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RbGridPosition> OccupiedCellPositions
		{
			get
			{
				return this.occupiedCellPositions_;
			}
		}

		// Token: 0x17004244 RID: 16964
		// (get) Token: 0x06013E94 RID: 81556 RVA: 0x002E6B50 File Offset: 0x002E4D50
		// (set) Token: 0x06013E95 RID: 81557 RVA: 0x002E6B69 File Offset: 0x002E4D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbDefaultBlockPbType DefaultBlockType
		{
			get
			{
				if (this.typeCase_ != RbBlockComponentPb.TypeOneofCase.DefaultBlockType)
				{
					return null;
				}
				return (RbDefaultBlockPbType)this.type_;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? RbBlockComponentPb.TypeOneofCase.None : RbBlockComponentPb.TypeOneofCase.DefaultBlockType);
			}
		}

		// Token: 0x17004245 RID: 16965
		// (get) Token: 0x06013E96 RID: 81558 RVA: 0x002E6B80 File Offset: 0x002E4D80
		// (set) Token: 0x06013E97 RID: 81559 RVA: 0x002E6B99 File Offset: 0x002E4D99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbVisionBlockPbType VisionBlockType
		{
			get
			{
				if (this.typeCase_ != RbBlockComponentPb.TypeOneofCase.VisionBlockType)
				{
					return null;
				}
				return (RbVisionBlockPbType)this.type_;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? RbBlockComponentPb.TypeOneofCase.None : RbBlockComponentPb.TypeOneofCase.VisionBlockType);
			}
		}

		// Token: 0x17004246 RID: 16966
		// (get) Token: 0x06013E98 RID: 81560 RVA: 0x002E6BB0 File Offset: 0x002E4DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockComponentPb.TypeOneofCase TypeCase
		{
			get
			{
				return this.typeCase_;
			}
		}

		// Token: 0x06013E99 RID: 81561 RVA: 0x002E6BB8 File Offset: 0x002E4DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearType()
		{
			this.typeCase_ = RbBlockComponentPb.TypeOneofCase.None;
			this.type_ = null;
		}

		// Token: 0x06013E9A RID: 81562 RVA: 0x002E6BC8 File Offset: 0x002E4DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbBlockComponentPb);
		}

		// Token: 0x06013E9B RID: 81563 RVA: 0x002E6BD8 File Offset: 0x002E4DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbBlockComponentPb other)
		{
			return other != null && (other == this || (object.Equals(this.CenterPosition, other.CenterPosition) && this.SizeX == other.SizeX && this.SizeY == other.SizeY && this.SizeZ == other.SizeZ && object.Equals(this.Forward, other.Forward) && object.Equals(this.Right, other.Right) && object.Equals(this.State, other.State) && this.GamePlayIncId == other.GamePlayIncId && this.occupiedCellPositions_.Equals(other.occupiedCellPositions_) && object.Equals(this.DefaultBlockType, other.DefaultBlockType) && object.Equals(this.VisionBlockType, other.VisionBlockType) && this.TypeCase == other.TypeCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013E9C RID: 81564 RVA: 0x002E6CE4 File Offset: 0x002E4EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.centerPosition_ != null)
			{
				num ^= this.CenterPosition.GetHashCode();
			}
			if (this.SizeX != 0)
			{
				num ^= this.SizeX.GetHashCode();
			}
			if (this.SizeY != 0)
			{
				num ^= this.SizeY.GetHashCode();
			}
			if (this.SizeZ != 0)
			{
				num ^= this.SizeZ.GetHashCode();
			}
			if (this.forward_ != null)
			{
				num ^= this.Forward.GetHashCode();
			}
			if (this.right_ != null)
			{
				num ^= this.Right.GetHashCode();
			}
			if (this.state_ != null)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.GamePlayIncId != 0)
			{
				num ^= this.GamePlayIncId.GetHashCode();
			}
			num ^= this.occupiedCellPositions_.GetHashCode();
			if (this.typeCase_ == RbBlockComponentPb.TypeOneofCase.DefaultBlockType)
			{
				num ^= this.DefaultBlockType.GetHashCode();
			}
			if (this.typeCase_ == RbBlockComponentPb.TypeOneofCase.VisionBlockType)
			{
				num ^= this.VisionBlockType.GetHashCode();
			}
			num ^= (int)this.typeCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013E9D RID: 81565 RVA: 0x002E6E0D File Offset: 0x002E500D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013E9E RID: 81566 RVA: 0x002E6E1A File Offset: 0x002E501A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013E9F RID: 81567 RVA: 0x002E6E24 File Offset: 0x002E5024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.centerPosition_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CenterPosition);
			}
			if (this.SizeX != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SizeX);
			}
			if (this.SizeY != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SizeY);
			}
			if (this.SizeZ != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SizeZ);
			}
			if (this.forward_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Forward);
			}
			if (this.right_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Right);
			}
			if (this.state_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.State);
			}
			if (this.GamePlayIncId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.GamePlayIncId);
			}
			this.occupiedCellPositions_.WriteTo(ref output, RbBlockComponentPb._repeated_occupiedCellPositions_codec);
			if (this.typeCase_ == RbBlockComponentPb.TypeOneofCase.DefaultBlockType)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.DefaultBlockType);
			}
			if (this.typeCase_ == RbBlockComponentPb.TypeOneofCase.VisionBlockType)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.VisionBlockType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013EA0 RID: 81568 RVA: 0x002E6F74 File Offset: 0x002E5174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.centerPosition_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CenterPosition);
			}
			if (this.SizeX != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SizeX);
			}
			if (this.SizeY != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SizeY);
			}
			if (this.SizeZ != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SizeZ);
			}
			if (this.forward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Forward);
			}
			if (this.right_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Right);
			}
			if (this.state_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.State);
			}
			if (this.GamePlayIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamePlayIncId);
			}
			num += this.occupiedCellPositions_.CalculateSize(RbBlockComponentPb._repeated_occupiedCellPositions_codec);
			if (this.typeCase_ == RbBlockComponentPb.TypeOneofCase.DefaultBlockType)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DefaultBlockType);
			}
			if (this.typeCase_ == RbBlockComponentPb.TypeOneofCase.VisionBlockType)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.VisionBlockType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013EA1 RID: 81569 RVA: 0x002E70A4 File Offset: 0x002E52A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbBlockComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.centerPosition_ != null)
			{
				if (this.centerPosition_ == null)
				{
					this.CenterPosition = new Vector();
				}
				this.CenterPosition.MergeFrom(other.CenterPosition);
			}
			if (other.SizeX != 0)
			{
				this.SizeX = other.SizeX;
			}
			if (other.SizeY != 0)
			{
				this.SizeY = other.SizeY;
			}
			if (other.SizeZ != 0)
			{
				this.SizeZ = other.SizeZ;
			}
			if (other.forward_ != null)
			{
				if (this.forward_ == null)
				{
					this.Forward = new Vector();
				}
				this.Forward.MergeFrom(other.Forward);
			}
			if (other.right_ != null)
			{
				if (this.right_ == null)
				{
					this.Right = new Vector();
				}
				this.Right.MergeFrom(other.Right);
			}
			if (other.state_ != null)
			{
				if (this.state_ == null)
				{
					this.State = new RbBlockPbState();
				}
				this.State.MergeFrom(other.State);
			}
			if (other.GamePlayIncId != 0)
			{
				this.GamePlayIncId = other.GamePlayIncId;
			}
			this.occupiedCellPositions_.Add(other.occupiedCellPositions_);
			RbBlockComponentPb.TypeOneofCase typeCase = other.TypeCase;
			if (typeCase != RbBlockComponentPb.TypeOneofCase.DefaultBlockType)
			{
				if (typeCase == RbBlockComponentPb.TypeOneofCase.VisionBlockType)
				{
					if (this.VisionBlockType == null)
					{
						this.VisionBlockType = new RbVisionBlockPbType();
					}
					this.VisionBlockType.MergeFrom(other.VisionBlockType);
				}
			}
			else
			{
				if (this.DefaultBlockType == null)
				{
					this.DefaultBlockType = new RbDefaultBlockPbType();
				}
				this.DefaultBlockType.MergeFrom(other.DefaultBlockType);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013EA2 RID: 81570 RVA: 0x002E723A File Offset: 0x002E543A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013EA3 RID: 81571 RVA: 0x002E7244 File Offset: 0x002E5444
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
				if (num <= 42U)
				{
					if (num <= 16U)
					{
						if (num == 10U)
						{
							if (this.centerPosition_ == null)
							{
								this.CenterPosition = new Vector();
							}
							input.ReadMessage(this.CenterPosition);
							continue;
						}
						if (num == 16U)
						{
							this.SizeX = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.SizeY = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.SizeZ = input.ReadInt32();
							continue;
						}
						if (num == 42U)
						{
							if (this.forward_ == null)
							{
								this.Forward = new Vector();
							}
							input.ReadMessage(this.Forward);
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 50U)
					{
						if (this.right_ == null)
						{
							this.Right = new Vector();
						}
						input.ReadMessage(this.Right);
						continue;
					}
					if (num == 58U)
					{
						if (this.state_ == null)
						{
							this.State = new RbBlockPbState();
						}
						input.ReadMessage(this.State);
						continue;
					}
					if (num == 64U)
					{
						this.GamePlayIncId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.occupiedCellPositions_.AddEntriesFrom(ref input, RbBlockComponentPb._repeated_occupiedCellPositions_codec);
						continue;
					}
					if (num == 82U)
					{
						RbDefaultBlockPbType rbDefaultBlockPbType = new RbDefaultBlockPbType();
						if (this.typeCase_ == RbBlockComponentPb.TypeOneofCase.DefaultBlockType)
						{
							rbDefaultBlockPbType.MergeFrom(this.DefaultBlockType);
						}
						input.ReadMessage(rbDefaultBlockPbType);
						this.DefaultBlockType = rbDefaultBlockPbType;
						continue;
					}
					if (num == 90U)
					{
						RbVisionBlockPbType rbVisionBlockPbType = new RbVisionBlockPbType();
						if (this.typeCase_ == RbBlockComponentPb.TypeOneofCase.VisionBlockType)
						{
							rbVisionBlockPbType.MergeFrom(this.VisionBlockType);
						}
						input.ReadMessage(rbVisionBlockPbType);
						this.VisionBlockType = rbVisionBlockPbType;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007A1B RID: 31259
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A1C RID: 31260
		public const int CenterPositionFieldNumber = 1;

		// Token: 0x04007A1D RID: 31261
		private Vector centerPosition_;

		// Token: 0x04007A1E RID: 31262
		public const int SizeXFieldNumber = 2;

		// Token: 0x04007A1F RID: 31263
		private int sizeX_;

		// Token: 0x04007A20 RID: 31264
		public const int SizeYFieldNumber = 3;

		// Token: 0x04007A21 RID: 31265
		private int sizeY_;

		// Token: 0x04007A22 RID: 31266
		public const int SizeZFieldNumber = 4;

		// Token: 0x04007A23 RID: 31267
		private int sizeZ_;

		// Token: 0x04007A24 RID: 31268
		public const int ForwardFieldNumber = 5;

		// Token: 0x04007A25 RID: 31269
		private Vector forward_;

		// Token: 0x04007A26 RID: 31270
		public const int RightFieldNumber = 6;

		// Token: 0x04007A27 RID: 31271
		private Vector right_;

		// Token: 0x04007A28 RID: 31272
		public const int StateFieldNumber = 7;

		// Token: 0x04007A29 RID: 31273
		private RbBlockPbState state_;

		// Token: 0x04007A2A RID: 31274
		public const int GamePlayIncIdFieldNumber = 8;

		// Token: 0x04007A2B RID: 31275
		private int gamePlayIncId_;

		// Token: 0x04007A2C RID: 31276
		public const int OccupiedCellPositionsFieldNumber = 9;

		// Token: 0x04007A2D RID: 31277
		private static readonly FieldCodec<RbGridPosition> _repeated_occupiedCellPositions_codec = FieldCodec.ForMessage<RbGridPosition>(74U, RbGridPosition.Parser);

		// Token: 0x04007A2E RID: 31278
		private readonly RepeatedField<RbGridPosition> occupiedCellPositions_ = new RepeatedField<RbGridPosition>();

		// Token: 0x04007A2F RID: 31279
		public const int DefaultBlockTypeFieldNumber = 10;

		// Token: 0x04007A30 RID: 31280
		public const int VisionBlockTypeFieldNumber = 11;

		// Token: 0x04007A31 RID: 31281
		private object type_;

		// Token: 0x04007A32 RID: 31282
		private RbBlockComponentPb.TypeOneofCase typeCase_;

		// Token: 0x0200197E RID: 6526
		public enum TypeOneofCase
		{
			// Token: 0x0400CE60 RID: 52832
			None,
			// Token: 0x0400CE61 RID: 52833
			DefaultBlockType = 10,
			// Token: 0x0400CE62 RID: 52834
			VisionBlockType
		}
	}
}
