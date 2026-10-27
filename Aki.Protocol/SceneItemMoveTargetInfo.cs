using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200116A RID: 4458
	public sealed class SceneItemMoveTargetInfo : IMessage<SceneItemMoveTargetInfo>, IMessage, IEquatable<SceneItemMoveTargetInfo>, IDeepCloneable<SceneItemMoveTargetInfo>, IBufferMessage
	{
		// Token: 0x06017C4B RID: 97355 RVA: 0x00373DE9 File Offset: 0x00371FE9
		[NullableContext(1)]
		public static SceneItemMoveTargetInfo Create()
		{
			return new SceneItemMoveTargetInfo();
		}

		// Token: 0x17004FD8 RID: 20440
		// (get) Token: 0x06017C4C RID: 97356 RVA: 0x00373DF0 File Offset: 0x00371FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FD9 RID: 20441
		// (get) Token: 0x06017C4D RID: 97357 RVA: 0x00373DF3 File Offset: 0x00371FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemMoveTargetInfo.Descriptor;
			}
		}

		// Token: 0x06017C4E RID: 97358 RVA: 0x00373DFA File Offset: 0x00371FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetInfo()
		{
		}

		// Token: 0x06017C4F RID: 97359 RVA: 0x00373E04 File Offset: 0x00372004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetInfo(SceneItemMoveTargetInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.moveTime_ = other.moveTime_;
			this.stayTime_ = other.stayTime_;
			this.maxSpeed_ = other.maxSpeed_;
			this.acceleration_ = other.acceleration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017C50 RID: 97360 RVA: 0x00373E80 File Offset: 0x00372080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetInfo Clone()
		{
			return new SceneItemMoveTargetInfo(this);
		}

		// Token: 0x17004FDA RID: 20442
		// (get) Token: 0x06017C51 RID: 97361 RVA: 0x00373E88 File Offset: 0x00372088
		// (set) Token: 0x06017C52 RID: 97362 RVA: 0x00373E90 File Offset: 0x00372090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17004FDB RID: 20443
		// (get) Token: 0x06017C53 RID: 97363 RVA: 0x00373E99 File Offset: 0x00372099
		// (set) Token: 0x06017C54 RID: 97364 RVA: 0x00373EA1 File Offset: 0x003720A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x17004FDC RID: 20444
		// (get) Token: 0x06017C55 RID: 97365 RVA: 0x00373EAA File Offset: 0x003720AA
		// (set) Token: 0x06017C56 RID: 97366 RVA: 0x00373EB2 File Offset: 0x003720B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float MoveTime
		{
			get
			{
				return this.moveTime_;
			}
			set
			{
				this.moveTime_ = value;
			}
		}

		// Token: 0x17004FDD RID: 20445
		// (get) Token: 0x06017C57 RID: 97367 RVA: 0x00373EBB File Offset: 0x003720BB
		// (set) Token: 0x06017C58 RID: 97368 RVA: 0x00373EC3 File Offset: 0x003720C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float StayTime
		{
			get
			{
				return this.stayTime_;
			}
			set
			{
				this.stayTime_ = value;
			}
		}

		// Token: 0x17004FDE RID: 20446
		// (get) Token: 0x06017C59 RID: 97369 RVA: 0x00373ECC File Offset: 0x003720CC
		// (set) Token: 0x06017C5A RID: 97370 RVA: 0x00373ED4 File Offset: 0x003720D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float MaxSpeed
		{
			get
			{
				return this.maxSpeed_;
			}
			set
			{
				this.maxSpeed_ = value;
			}
		}

		// Token: 0x17004FDF RID: 20447
		// (get) Token: 0x06017C5B RID: 97371 RVA: 0x00373EDD File Offset: 0x003720DD
		// (set) Token: 0x06017C5C RID: 97372 RVA: 0x00373EE5 File Offset: 0x003720E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Acceleration
		{
			get
			{
				return this.acceleration_;
			}
			set
			{
				this.acceleration_ = value;
			}
		}

		// Token: 0x06017C5D RID: 97373 RVA: 0x00373EEE File Offset: 0x003720EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemMoveTargetInfo);
		}

		// Token: 0x06017C5E RID: 97374 RVA: 0x00373EFC File Offset: 0x003720FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemMoveTargetInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.Location, other.Location) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MoveTime, other.MoveTime) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.StayTime, other.StayTime) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MaxSpeed, other.MaxSpeed) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Acceleration, other.Acceleration) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017C5F RID: 97375 RVA: 0x00373FB4 File Offset: 0x003721B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.MoveTime != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MoveTime);
			}
			if (this.StayTime != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.StayTime);
			}
			if (this.MaxSpeed != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MaxSpeed);
			}
			if (this.Acceleration != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Acceleration);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017C60 RID: 97376 RVA: 0x00374089 File Offset: 0x00372289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017C61 RID: 97377 RVA: 0x00374096 File Offset: 0x00372296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017C62 RID: 97378 RVA: 0x003740A0 File Offset: 0x003722A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Location);
			}
			if (this.MoveTime != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.MoveTime);
			}
			if (this.StayTime != 0f)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.StayTime);
			}
			if (this.MaxSpeed != 0f)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.MaxSpeed);
			}
			if (this.Acceleration != 0f)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.Acceleration);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017C63 RID: 97379 RVA: 0x0037417C File Offset: 0x0037237C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.MoveTime != 0f)
			{
				num += 5;
			}
			if (this.StayTime != 0f)
			{
				num += 5;
			}
			if (this.MaxSpeed != 0f)
			{
				num += 5;
			}
			if (this.Acceleration != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017C64 RID: 97380 RVA: 0x00374218 File Offset: 0x00372418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemMoveTargetInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			if (other.MoveTime != 0f)
			{
				this.MoveTime = other.MoveTime;
			}
			if (other.StayTime != 0f)
			{
				this.StayTime = other.StayTime;
			}
			if (other.MaxSpeed != 0f)
			{
				this.MaxSpeed = other.MaxSpeed;
			}
			if (other.Acceleration != 0f)
			{
				this.Acceleration = other.Acceleration;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017C65 RID: 97381 RVA: 0x003742E4 File Offset: 0x003724E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017C66 RID: 97382 RVA: 0x003742F0 File Offset: 0x003724F0
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
				if (num <= 29U)
				{
					if (num == 8U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 18U)
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
						continue;
					}
					if (num == 29U)
					{
						this.MoveTime = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 37U)
					{
						this.StayTime = input.ReadFloat();
						continue;
					}
					if (num == 45U)
					{
						this.MaxSpeed = input.ReadFloat();
						continue;
					}
					if (num == 53U)
					{
						this.Acceleration = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008D07 RID: 36103
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D08 RID: 36104
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04008D09 RID: 36105
		private long entityId_;

		// Token: 0x04008D0A RID: 36106
		public const int LocationFieldNumber = 2;

		// Token: 0x04008D0B RID: 36107
		private Vector location_;

		// Token: 0x04008D0C RID: 36108
		public const int MoveTimeFieldNumber = 3;

		// Token: 0x04008D0D RID: 36109
		private float moveTime_;

		// Token: 0x04008D0E RID: 36110
		public const int StayTimeFieldNumber = 4;

		// Token: 0x04008D0F RID: 36111
		private float stayTime_;

		// Token: 0x04008D10 RID: 36112
		public const int MaxSpeedFieldNumber = 5;

		// Token: 0x04008D11 RID: 36113
		private float maxSpeed_;

		// Token: 0x04008D12 RID: 36114
		public const int AccelerationFieldNumber = 6;

		// Token: 0x04008D13 RID: 36115
		private float acceleration_;
	}
}
