using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E85 RID: 3717
	public sealed class RbBlockComponentPb : IMessage<RbBlockComponentPb>, IMessage, IEquatable<RbBlockComponentPb>, IDeepCloneable<RbBlockComponentPb>, IBufferMessage
	{
		// Token: 0x06013F62 RID: 81762 RVA: 0x002E8044 File Offset: 0x002E6244
		[NullableContext(1)]
		public static RbBlockComponentPb Create()
		{
			return new RbBlockComponentPb();
		}

		// Token: 0x17004263 RID: 16995
		// (get) Token: 0x06013F63 RID: 81763 RVA: 0x002E804B File Offset: 0x002E624B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004264 RID: 16996
		// (get) Token: 0x06013F64 RID: 81764 RVA: 0x002E804E File Offset: 0x002E624E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbBlockComponentPb.Descriptor;
			}
		}

		// Token: 0x06013F65 RID: 81765 RVA: 0x002E8055 File Offset: 0x002E6255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockComponentPb()
		{
		}

		// Token: 0x06013F66 RID: 81766 RVA: 0x002E8068 File Offset: 0x002E6268
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

		// Token: 0x06013F67 RID: 81767 RVA: 0x002E8174 File Offset: 0x002E6374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockComponentPb Clone()
		{
			return new RbBlockComponentPb(this);
		}

		// Token: 0x17004265 RID: 16997
		// (get) Token: 0x06013F68 RID: 81768 RVA: 0x002E817C File Offset: 0x002E637C
		// (set) Token: 0x06013F69 RID: 81769 RVA: 0x002E8184 File Offset: 0x002E6384
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

		// Token: 0x17004266 RID: 16998
		// (get) Token: 0x06013F6A RID: 81770 RVA: 0x002E818D File Offset: 0x002E638D
		// (set) Token: 0x06013F6B RID: 81771 RVA: 0x002E8195 File Offset: 0x002E6395
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

		// Token: 0x17004267 RID: 16999
		// (get) Token: 0x06013F6C RID: 81772 RVA: 0x002E819E File Offset: 0x002E639E
		// (set) Token: 0x06013F6D RID: 81773 RVA: 0x002E81A6 File Offset: 0x002E63A6
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

		// Token: 0x17004268 RID: 17000
		// (get) Token: 0x06013F6E RID: 81774 RVA: 0x002E81AF File Offset: 0x002E63AF
		// (set) Token: 0x06013F6F RID: 81775 RVA: 0x002E81B7 File Offset: 0x002E63B7
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

		// Token: 0x17004269 RID: 17001
		// (get) Token: 0x06013F70 RID: 81776 RVA: 0x002E81C0 File Offset: 0x002E63C0
		// (set) Token: 0x06013F71 RID: 81777 RVA: 0x002E81C8 File Offset: 0x002E63C8
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

		// Token: 0x1700426A RID: 17002
		// (get) Token: 0x06013F72 RID: 81778 RVA: 0x002E81D1 File Offset: 0x002E63D1
		// (set) Token: 0x06013F73 RID: 81779 RVA: 0x002E81D9 File Offset: 0x002E63D9
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

		// Token: 0x1700426B RID: 17003
		// (get) Token: 0x06013F74 RID: 81780 RVA: 0x002E81E2 File Offset: 0x002E63E2
		// (set) Token: 0x06013F75 RID: 81781 RVA: 0x002E81EA File Offset: 0x002E63EA
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

		// Token: 0x1700426C RID: 17004
		// (get) Token: 0x06013F76 RID: 81782 RVA: 0x002E81F3 File Offset: 0x002E63F3
		// (set) Token: 0x06013F77 RID: 81783 RVA: 0x002E81FB File Offset: 0x002E63FB
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

		// Token: 0x1700426D RID: 17005
		// (get) Token: 0x06013F78 RID: 81784 RVA: 0x002E8204 File Offset: 0x002E6404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RbGridPosition> OccupiedCellPositions
		{
			get
			{
				return this.occupiedCellPositions_;
			}
		}

		// Token: 0x1700426E RID: 17006
		// (get) Token: 0x06013F79 RID: 81785 RVA: 0x002E820C File Offset: 0x002E640C
		// (set) Token: 0x06013F7A RID: 81786 RVA: 0x002E8225 File Offset: 0x002E6425
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

		// Token: 0x1700426F RID: 17007
		// (get) Token: 0x06013F7B RID: 81787 RVA: 0x002E823C File Offset: 0x002E643C
		// (set) Token: 0x06013F7C RID: 81788 RVA: 0x002E8255 File Offset: 0x002E6455
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

		// Token: 0x17004270 RID: 17008
		// (get) Token: 0x06013F7D RID: 81789 RVA: 0x002E826C File Offset: 0x002E646C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockComponentPb.TypeOneofCase TypeCase
		{
			get
			{
				return this.typeCase_;
			}
		}

		// Token: 0x06013F7E RID: 81790 RVA: 0x002E8274 File Offset: 0x002E6474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearType()
		{
			this.typeCase_ = RbBlockComponentPb.TypeOneofCase.None;
			this.type_ = null;
		}

		// Token: 0x06013F7F RID: 81791 RVA: 0x002E8284 File Offset: 0x002E6484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbBlockComponentPb);
		}

		// Token: 0x06013F80 RID: 81792 RVA: 0x002E8294 File Offset: 0x002E6494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbBlockComponentPb other)
		{
			return other != null && (other == this || (object.Equals(this.CenterPosition, other.CenterPosition) && this.SizeX == other.SizeX && this.SizeY == other.SizeY && this.SizeZ == other.SizeZ && object.Equals(this.Forward, other.Forward) && object.Equals(this.Right, other.Right) && object.Equals(this.State, other.State) && this.GamePlayIncId == other.GamePlayIncId && this.occupiedCellPositions_.Equals(other.occupiedCellPositions_) && object.Equals(this.DefaultBlockType, other.DefaultBlockType) && object.Equals(this.VisionBlockType, other.VisionBlockType) && this.TypeCase == other.TypeCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013F81 RID: 81793 RVA: 0x002E83A0 File Offset: 0x002E65A0
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

		// Token: 0x06013F82 RID: 81794 RVA: 0x002E84C9 File Offset: 0x002E66C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013F83 RID: 81795 RVA: 0x002E84D6 File Offset: 0x002E66D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013F84 RID: 81796 RVA: 0x002E84E0 File Offset: 0x002E66E0
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

		// Token: 0x06013F85 RID: 81797 RVA: 0x002E8630 File Offset: 0x002E6830
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

		// Token: 0x06013F86 RID: 81798 RVA: 0x002E8760 File Offset: 0x002E6960
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

		// Token: 0x06013F87 RID: 81799 RVA: 0x002E88F6 File Offset: 0x002E6AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013F88 RID: 81800 RVA: 0x002E8900 File Offset: 0x002E6B00
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

		// Token: 0x040079F1 RID: 31217
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079F2 RID: 31218
		public const int CenterPositionFieldNumber = 1;

		// Token: 0x040079F3 RID: 31219
		private Vector centerPosition_;

		// Token: 0x040079F4 RID: 31220
		public const int SizeXFieldNumber = 2;

		// Token: 0x040079F5 RID: 31221
		private int sizeX_;

		// Token: 0x040079F6 RID: 31222
		public const int SizeYFieldNumber = 3;

		// Token: 0x040079F7 RID: 31223
		private int sizeY_;

		// Token: 0x040079F8 RID: 31224
		public const int SizeZFieldNumber = 4;

		// Token: 0x040079F9 RID: 31225
		private int sizeZ_;

		// Token: 0x040079FA RID: 31226
		public const int ForwardFieldNumber = 5;

		// Token: 0x040079FB RID: 31227
		private Vector forward_;

		// Token: 0x040079FC RID: 31228
		public const int RightFieldNumber = 6;

		// Token: 0x040079FD RID: 31229
		private Vector right_;

		// Token: 0x040079FE RID: 31230
		public const int StateFieldNumber = 7;

		// Token: 0x040079FF RID: 31231
		private RbBlockPbState state_;

		// Token: 0x04007A00 RID: 31232
		public const int GamePlayIncIdFieldNumber = 8;

		// Token: 0x04007A01 RID: 31233
		private int gamePlayIncId_;

		// Token: 0x04007A02 RID: 31234
		public const int OccupiedCellPositionsFieldNumber = 9;

		// Token: 0x04007A03 RID: 31235
		private static readonly FieldCodec<RbGridPosition> _repeated_occupiedCellPositions_codec = FieldCodec.ForMessage<RbGridPosition>(74U, RbGridPosition.Parser);

		// Token: 0x04007A04 RID: 31236
		private readonly RepeatedField<RbGridPosition> occupiedCellPositions_ = new RepeatedField<RbGridPosition>();

		// Token: 0x04007A05 RID: 31237
		public const int DefaultBlockTypeFieldNumber = 10;

		// Token: 0x04007A06 RID: 31238
		public const int VisionBlockTypeFieldNumber = 11;

		// Token: 0x04007A07 RID: 31239
		private object type_;

		// Token: 0x04007A08 RID: 31240
		private RbBlockComponentPb.TypeOneofCase typeCase_;

		// Token: 0x02001906 RID: 6406
		public enum TypeOneofCase
		{
			// Token: 0x0400C935 RID: 51509
			None,
			// Token: 0x0400C936 RID: 51510
			DefaultBlockType = 10,
			// Token: 0x0400C937 RID: 51511
			VisionBlockType
		}
	}
}
