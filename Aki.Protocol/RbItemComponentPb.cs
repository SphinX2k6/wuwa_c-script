using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E90 RID: 3728
	public sealed class RbItemComponentPb : IMessage<RbItemComponentPb>, IMessage, IEquatable<RbItemComponentPb>, IDeepCloneable<RbItemComponentPb>, IBufferMessage
	{
		// Token: 0x06014058 RID: 82008 RVA: 0x002EA796 File Offset: 0x002E8996
		[NullableContext(1)]
		public static RbItemComponentPb Create()
		{
			return new RbItemComponentPb();
		}

		// Token: 0x1700429C RID: 17052
		// (get) Token: 0x06014059 RID: 82009 RVA: 0x002EA79D File Offset: 0x002E899D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700429D RID: 17053
		// (get) Token: 0x0601405A RID: 82010 RVA: 0x002EA7A0 File Offset: 0x002E89A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbItemComponentPb.Descriptor;
			}
		}

		// Token: 0x0601405B RID: 82011 RVA: 0x002EA7A7 File Offset: 0x002E89A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbItemComponentPb()
		{
		}

		// Token: 0x0601405C RID: 82012 RVA: 0x002EA7BC File Offset: 0x002E89BC
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

		// Token: 0x0601405D RID: 82013 RVA: 0x002EA832 File Offset: 0x002E8A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbItemComponentPb Clone()
		{
			return new RbItemComponentPb(this);
		}

		// Token: 0x1700429E RID: 17054
		// (get) Token: 0x0601405E RID: 82014 RVA: 0x002EA83A File Offset: 0x002E8A3A
		// (set) Token: 0x0601405F RID: 82015 RVA: 0x002EA842 File Offset: 0x002E8A42
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

		// Token: 0x1700429F RID: 17055
		// (get) Token: 0x06014060 RID: 82016 RVA: 0x002EA84B File Offset: 0x002E8A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RbGridPosition> OccupiedCellPositions
		{
			get
			{
				return this.occupiedCellPositions_;
			}
		}

		// Token: 0x170042A0 RID: 17056
		// (get) Token: 0x06014061 RID: 82017 RVA: 0x002EA853 File Offset: 0x002E8A53
		// (set) Token: 0x06014062 RID: 82018 RVA: 0x002EA86B File Offset: 0x002E8A6B
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

		// Token: 0x170042A1 RID: 17057
		// (get) Token: 0x06014063 RID: 82019 RVA: 0x002EA881 File Offset: 0x002E8A81
		// (set) Token: 0x06014064 RID: 82020 RVA: 0x002EA899 File Offset: 0x002E8A99
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

		// Token: 0x170042A2 RID: 17058
		// (get) Token: 0x06014065 RID: 82021 RVA: 0x002EA8AF File Offset: 0x002E8AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbItemComponentPb.TypeOneofCase TypeCase
		{
			get
			{
				return this.typeCase_;
			}
		}

		// Token: 0x06014066 RID: 82022 RVA: 0x002EA8B7 File Offset: 0x002E8AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearType()
		{
			this.typeCase_ = RbItemComponentPb.TypeOneofCase.None;
			this.type_ = null;
		}

		// Token: 0x06014067 RID: 82023 RVA: 0x002EA8C7 File Offset: 0x002E8AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbItemComponentPb);
		}

		// Token: 0x06014068 RID: 82024 RVA: 0x002EA8D8 File Offset: 0x002E8AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbItemComponentPb other)
		{
			return other != null && (other == this || (this.GamePlayIncId == other.GamePlayIncId && this.occupiedCellPositions_.Equals(other.occupiedCellPositions_) && object.Equals(this.BreakableObstacleType, other.BreakableObstacleType) && object.Equals(this.RbLaserEmitterType, other.RbLaserEmitterType) && this.TypeCase == other.TypeCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014069 RID: 82025 RVA: 0x002EA960 File Offset: 0x002E8B60
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

		// Token: 0x0601406A RID: 82026 RVA: 0x002EA9E4 File Offset: 0x002E8BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601406B RID: 82027 RVA: 0x002EA9F1 File Offset: 0x002E8BF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601406C RID: 82028 RVA: 0x002EA9FC File Offset: 0x002E8BFC
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

		// Token: 0x0601406D RID: 82029 RVA: 0x002EAA84 File Offset: 0x002E8C84
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

		// Token: 0x0601406E RID: 82030 RVA: 0x002EAB08 File Offset: 0x002E8D08
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

		// Token: 0x0601406F RID: 82031 RVA: 0x002EABB0 File Offset: 0x002E8DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014070 RID: 82032 RVA: 0x002EABBC File Offset: 0x002E8DBC
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

		// Token: 0x04007A3C RID: 31292
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A3D RID: 31293
		public const int GamePlayIncIdFieldNumber = 1;

		// Token: 0x04007A3E RID: 31294
		private int gamePlayIncId_;

		// Token: 0x04007A3F RID: 31295
		public const int OccupiedCellPositionsFieldNumber = 2;

		// Token: 0x04007A40 RID: 31296
		private static readonly FieldCodec<RbGridPosition> _repeated_occupiedCellPositions_codec = FieldCodec.ForMessage<RbGridPosition>(18U, RbGridPosition.Parser);

		// Token: 0x04007A41 RID: 31297
		private readonly RepeatedField<RbGridPosition> occupiedCellPositions_ = new RepeatedField<RbGridPosition>();

		// Token: 0x04007A42 RID: 31298
		public const int BreakableObstacleTypeFieldNumber = 3;

		// Token: 0x04007A43 RID: 31299
		public const int RbLaserEmitterTypeFieldNumber = 4;

		// Token: 0x04007A44 RID: 31300
		private object type_;

		// Token: 0x04007A45 RID: 31301
		private RbItemComponentPb.TypeOneofCase typeCase_;

		// Token: 0x0200190C RID: 6412
		public enum TypeOneofCase
		{
			// Token: 0x0400C946 RID: 51526
			None,
			// Token: 0x0400C947 RID: 51527
			BreakableObstacleType = 3,
			// Token: 0x0400C948 RID: 51528
			RbLaserEmitterType
		}
	}
}
