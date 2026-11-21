using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E80 RID: 3712
	public sealed class RbItemComponentPb : IMessage<RbItemComponentPb>, IMessage, IEquatable<RbItemComponentPb>, IDeepCloneable<RbItemComponentPb>, IBufferMessage
	{
		// Token: 0x06013F73 RID: 81779 RVA: 0x002E90DA File Offset: 0x002E72DA
		[NullableContext(1)]
		public static RbItemComponentPb Create()
		{
			return new RbItemComponentPb();
		}

		// Token: 0x17004272 RID: 17010
		// (get) Token: 0x06013F74 RID: 81780 RVA: 0x002E90E1 File Offset: 0x002E72E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004273 RID: 17011
		// (get) Token: 0x06013F75 RID: 81781 RVA: 0x002E90E4 File Offset: 0x002E72E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbItemComponentPb.Descriptor;
			}
		}

		// Token: 0x06013F76 RID: 81782 RVA: 0x002E90EB File Offset: 0x002E72EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbItemComponentPb()
		{
		}

		// Token: 0x06013F77 RID: 81783 RVA: 0x002E9100 File Offset: 0x002E7300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbItemComponentPb(RbItemComponentPb other) : this()
		{
			this.gamePlayIncId_ = other.gamePlayIncId_;
			this.occupiedCellPositions_ = other.occupiedCellPositions_.Clone();
			RbItemComponentPb.TypeOneofCase typeCase = other.TypeCase;
			if (typeCase != RbItemComponentPb.TypeOneofCase.BreakableObstacleType)
			{
				if (typeCase == RbItemComponentPb.TypeOneofCase.RbLaserEmitterType)
				{
					this.RbLaserEmitterType = other.RbLaserEmitterType.Clone();
				}
			}
			else
			{
				this.BreakableObstacleType = other.BreakableObstacleType.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013F78 RID: 81784 RVA: 0x002E9176 File Offset: 0x002E7376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbItemComponentPb Clone()
		{
			return new RbItemComponentPb(this);
		}

		// Token: 0x17004274 RID: 17012
		// (get) Token: 0x06013F79 RID: 81785 RVA: 0x002E917E File Offset: 0x002E737E
		// (set) Token: 0x06013F7A RID: 81786 RVA: 0x002E9186 File Offset: 0x002E7386
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

		// Token: 0x17004275 RID: 17013
		// (get) Token: 0x06013F7B RID: 81787 RVA: 0x002E918F File Offset: 0x002E738F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RbGridPosition> OccupiedCellPositions
		{
			get
			{
				return this.occupiedCellPositions_;
			}
		}

		// Token: 0x17004276 RID: 17014
		// (get) Token: 0x06013F7C RID: 81788 RVA: 0x002E9197 File Offset: 0x002E7397
		// (set) Token: 0x06013F7D RID: 81789 RVA: 0x002E91AF File Offset: 0x002E73AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBreakableObstaclePbType BreakableObstacleType
		{
			get
			{
				if (this.typeCase_ != RbItemComponentPb.TypeOneofCase.BreakableObstacleType)
				{
					return null;
				}
				return (RbBreakableObstaclePbType)this.type_;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? RbItemComponentPb.TypeOneofCase.None : RbItemComponentPb.TypeOneofCase.BreakableObstacleType);
			}
		}

		// Token: 0x17004277 RID: 17015
		// (get) Token: 0x06013F7E RID: 81790 RVA: 0x002E91C5 File Offset: 0x002E73C5
		// (set) Token: 0x06013F7F RID: 81791 RVA: 0x002E91DD File Offset: 0x002E73DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbLaserEmitterPbType RbLaserEmitterType
		{
			get
			{
				if (this.typeCase_ != RbItemComponentPb.TypeOneofCase.RbLaserEmitterType)
				{
					return null;
				}
				return (RbLaserEmitterPbType)this.type_;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? RbItemComponentPb.TypeOneofCase.None : RbItemComponentPb.TypeOneofCase.RbLaserEmitterType);
			}
		}

		// Token: 0x17004278 RID: 17016
		// (get) Token: 0x06013F80 RID: 81792 RVA: 0x002E91F3 File Offset: 0x002E73F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbItemComponentPb.TypeOneofCase TypeCase
		{
			get
			{
				return this.typeCase_;
			}
		}

		// Token: 0x06013F81 RID: 81793 RVA: 0x002E91FB File Offset: 0x002E73FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearType()
		{
			this.typeCase_ = RbItemComponentPb.TypeOneofCase.None;
			this.type_ = null;
		}

		// Token: 0x06013F82 RID: 81794 RVA: 0x002E920B File Offset: 0x002E740B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbItemComponentPb);
		}

		// Token: 0x06013F83 RID: 81795 RVA: 0x002E921C File Offset: 0x002E741C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbItemComponentPb other)
		{
			return other != null && (other == this || (this.GamePlayIncId == other.GamePlayIncId && this.occupiedCellPositions_.Equals(other.occupiedCellPositions_) && object.Equals(this.BreakableObstacleType, other.BreakableObstacleType) && object.Equals(this.RbLaserEmitterType, other.RbLaserEmitterType) && this.TypeCase == other.TypeCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013F84 RID: 81796 RVA: 0x002E92A4 File Offset: 0x002E74A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GamePlayIncId != 0)
			{
				num ^= this.GamePlayIncId.GetHashCode();
			}
			num ^= this.occupiedCellPositions_.GetHashCode();
			if (this.typeCase_ == RbItemComponentPb.TypeOneofCase.BreakableObstacleType)
			{
				num ^= this.BreakableObstacleType.GetHashCode();
			}
			if (this.typeCase_ == RbItemComponentPb.TypeOneofCase.RbLaserEmitterType)
			{
				num ^= this.RbLaserEmitterType.GetHashCode();
			}
			num ^= (int)this.typeCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013F85 RID: 81797 RVA: 0x002E9328 File Offset: 0x002E7528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013F86 RID: 81798 RVA: 0x002E9335 File Offset: 0x002E7535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013F87 RID: 81799 RVA: 0x002E9340 File Offset: 0x002E7540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GamePlayIncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GamePlayIncId);
			}
			this.occupiedCellPositions_.WriteTo(ref output, RbItemComponentPb._repeated_occupiedCellPositions_codec);
			if (this.typeCase_ == RbItemComponentPb.TypeOneofCase.BreakableObstacleType)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.BreakableObstacleType);
			}
			if (this.typeCase_ == RbItemComponentPb.TypeOneofCase.RbLaserEmitterType)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RbLaserEmitterType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013F88 RID: 81800 RVA: 0x002E93C8 File Offset: 0x002E75C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GamePlayIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamePlayIncId);
			}
			num += this.occupiedCellPositions_.CalculateSize(RbItemComponentPb._repeated_occupiedCellPositions_codec);
			if (this.typeCase_ == RbItemComponentPb.TypeOneofCase.BreakableObstacleType)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BreakableObstacleType);
			}
			if (this.typeCase_ == RbItemComponentPb.TypeOneofCase.RbLaserEmitterType)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RbLaserEmitterType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013F89 RID: 81801 RVA: 0x002E944C File Offset: 0x002E764C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbItemComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GamePlayIncId != 0)
			{
				this.GamePlayIncId = other.GamePlayIncId;
			}
			this.occupiedCellPositions_.Add(other.occupiedCellPositions_);
			RbItemComponentPb.TypeOneofCase typeCase = other.TypeCase;
			if (typeCase != RbItemComponentPb.TypeOneofCase.BreakableObstacleType)
			{
				if (typeCase == RbItemComponentPb.TypeOneofCase.RbLaserEmitterType)
				{
					if (this.RbLaserEmitterType == null)
					{
						this.RbLaserEmitterType = new RbLaserEmitterPbType();
					}
					this.RbLaserEmitterType.MergeFrom(other.RbLaserEmitterType);
				}
			}
			else
			{
				if (this.BreakableObstacleType == null)
				{
					this.BreakableObstacleType = new RbBreakableObstaclePbType();
				}
				this.BreakableObstacleType.MergeFrom(other.BreakableObstacleType);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013F8A RID: 81802 RVA: 0x002E94F4 File Offset: 0x002E76F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013F8B RID: 81803 RVA: 0x002E9500 File Offset: 0x002E7700
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.GamePlayIncId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.occupiedCellPositions_.AddEntriesFrom(ref input, RbItemComponentPb._repeated_occupiedCellPositions_codec);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						RbBreakableObstaclePbType rbBreakableObstaclePbType = new RbBreakableObstaclePbType();
						if (this.typeCase_ == RbItemComponentPb.TypeOneofCase.BreakableObstacleType)
						{
							rbBreakableObstaclePbType.MergeFrom(this.BreakableObstacleType);
						}
						input.ReadMessage(rbBreakableObstaclePbType);
						this.BreakableObstacleType = rbBreakableObstaclePbType;
						continue;
					}
					if (num == 34U)
					{
						RbLaserEmitterPbType rbLaserEmitterPbType = new RbLaserEmitterPbType();
						if (this.typeCase_ == RbItemComponentPb.TypeOneofCase.RbLaserEmitterType)
						{
							rbLaserEmitterPbType.MergeFrom(this.RbLaserEmitterType);
						}
						input.ReadMessage(rbLaserEmitterPbType);
						this.RbLaserEmitterType = rbLaserEmitterPbType;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007A66 RID: 31334
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A67 RID: 31335
		public const int GamePlayIncIdFieldNumber = 1;

		// Token: 0x04007A68 RID: 31336
		private int gamePlayIncId_;

		// Token: 0x04007A69 RID: 31337
		public const int OccupiedCellPositionsFieldNumber = 2;

		// Token: 0x04007A6A RID: 31338
		private static readonly FieldCodec<RbGridPosition> _repeated_occupiedCellPositions_codec = FieldCodec.ForMessage<RbGridPosition>(18U, RbGridPosition.Parser);

		// Token: 0x04007A6B RID: 31339
		private readonly RepeatedField<RbGridPosition> occupiedCellPositions_ = new RepeatedField<RbGridPosition>();

		// Token: 0x04007A6C RID: 31340
		public const int BreakableObstacleTypeFieldNumber = 3;

		// Token: 0x04007A6D RID: 31341
		public const int RbLaserEmitterTypeFieldNumber = 4;

		// Token: 0x04007A6E RID: 31342
		private object type_;

		// Token: 0x04007A6F RID: 31343
		private RbItemComponentPb.TypeOneofCase typeCase_;

		// Token: 0x02001984 RID: 6532
		public enum TypeOneofCase
		{
			// Token: 0x0400CE71 RID: 52849
			None,
			// Token: 0x0400CE72 RID: 52850
			BreakableObstacleType = 3,
			// Token: 0x0400CE73 RID: 52851
			RbLaserEmitterType
		}
	}
}
