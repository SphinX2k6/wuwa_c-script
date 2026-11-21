using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A4 RID: 4516
	public sealed class SceneItemMoveTargetInfo : IMessage<SceneItemMoveTargetInfo>, IMessage, IEquatable<SceneItemMoveTargetInfo>, IDeepCloneable<SceneItemMoveTargetInfo>, IBufferMessage
	{
		// Token: 0x060181EC RID: 98796 RVA: 0x00383139 File Offset: 0x00381339
		[NullableContext(1)]
		public static SceneItemMoveTargetInfo Create()
		{
			return new SceneItemMoveTargetInfo();
		}

		// Token: 0x17005144 RID: 20804
		// (get) Token: 0x060181ED RID: 98797 RVA: 0x00383140 File Offset: 0x00381340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005145 RID: 20805
		// (get) Token: 0x060181EE RID: 98798 RVA: 0x00383143 File Offset: 0x00381343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemMoveTargetInfo.Descriptor;
			}
		}

		// Token: 0x060181EF RID: 98799 RVA: 0x0038314A File Offset: 0x0038134A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetInfo()
		{
		}

		// Token: 0x060181F0 RID: 98800 RVA: 0x00383154 File Offset: 0x00381354
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

		// Token: 0x060181F1 RID: 98801 RVA: 0x003831D0 File Offset: 0x003813D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetInfo Clone()
		{
			return new SceneItemMoveTargetInfo(this);
		}

		// Token: 0x17005146 RID: 20806
		// (get) Token: 0x060181F2 RID: 98802 RVA: 0x003831D8 File Offset: 0x003813D8
		// (set) Token: 0x060181F3 RID: 98803 RVA: 0x003831E0 File Offset: 0x003813E0
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

		// Token: 0x17005147 RID: 20807
		// (get) Token: 0x060181F4 RID: 98804 RVA: 0x003831E9 File Offset: 0x003813E9
		// (set) Token: 0x060181F5 RID: 98805 RVA: 0x003831F1 File Offset: 0x003813F1
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

		// Token: 0x17005148 RID: 20808
		// (get) Token: 0x060181F6 RID: 98806 RVA: 0x003831FA File Offset: 0x003813FA
		// (set) Token: 0x060181F7 RID: 98807 RVA: 0x00383202 File Offset: 0x00381402
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

		// Token: 0x17005149 RID: 20809
		// (get) Token: 0x060181F8 RID: 98808 RVA: 0x0038320B File Offset: 0x0038140B
		// (set) Token: 0x060181F9 RID: 98809 RVA: 0x00383213 File Offset: 0x00381413
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

		// Token: 0x1700514A RID: 20810
		// (get) Token: 0x060181FA RID: 98810 RVA: 0x0038321C File Offset: 0x0038141C
		// (set) Token: 0x060181FB RID: 98811 RVA: 0x00383224 File Offset: 0x00381424
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

		// Token: 0x1700514B RID: 20811
		// (get) Token: 0x060181FC RID: 98812 RVA: 0x0038322D File Offset: 0x0038142D
		// (set) Token: 0x060181FD RID: 98813 RVA: 0x00383235 File Offset: 0x00381435
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

		// Token: 0x060181FE RID: 98814 RVA: 0x0038323E File Offset: 0x0038143E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemMoveTargetInfo);
		}

		// Token: 0x060181FF RID: 98815 RVA: 0x0038324C File Offset: 0x0038144C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemMoveTargetInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.Location, other.Location) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MoveTime, other.MoveTime) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.StayTime, other.StayTime) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MaxSpeed, other.MaxSpeed) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Acceleration, other.Acceleration) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018200 RID: 98816 RVA: 0x00383304 File Offset: 0x00381504
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

		// Token: 0x06018201 RID: 98817 RVA: 0x003833D9 File Offset: 0x003815D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018202 RID: 98818 RVA: 0x003833E6 File Offset: 0x003815E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018203 RID: 98819 RVA: 0x003833F0 File Offset: 0x003815F0
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

		// Token: 0x06018204 RID: 98820 RVA: 0x003834CC File Offset: 0x003816CC
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

		// Token: 0x06018205 RID: 98821 RVA: 0x00383568 File Offset: 0x00381768
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

		// Token: 0x06018206 RID: 98822 RVA: 0x00383634 File Offset: 0x00381834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018207 RID: 98823 RVA: 0x00383640 File Offset: 0x00381840
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

		// Token: 0x04008F9A RID: 36762
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F9B RID: 36763
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04008F9C RID: 36764
		private long entityId_;

		// Token: 0x04008F9D RID: 36765
		public const int LocationFieldNumber = 2;

		// Token: 0x04008F9E RID: 36766
		private Vector location_;

		// Token: 0x04008F9F RID: 36767
		public const int MoveTimeFieldNumber = 3;

		// Token: 0x04008FA0 RID: 36768
		private float moveTime_;

		// Token: 0x04008FA1 RID: 36769
		public const int StayTimeFieldNumber = 4;

		// Token: 0x04008FA2 RID: 36770
		private float stayTime_;

		// Token: 0x04008FA3 RID: 36771
		public const int MaxSpeedFieldNumber = 5;

		// Token: 0x04008FA4 RID: 36772
		private float maxSpeed_;

		// Token: 0x04008FA5 RID: 36773
		public const int AccelerationFieldNumber = 6;

		// Token: 0x04008FA6 RID: 36774
		private float acceleration_;
	}
}
