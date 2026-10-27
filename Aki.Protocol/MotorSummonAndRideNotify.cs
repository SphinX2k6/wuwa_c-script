using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA1 RID: 2721
	[NetMessage(EMessageId.MotorSummonAndRideNotify)]
	public sealed class MotorSummonAndRideNotify : IMessage<MotorSummonAndRideNotify>, IMessage, IEquatable<MotorSummonAndRideNotify>, IDeepCloneable<MotorSummonAndRideNotify>, IBufferMessage
	{
		// Token: 0x0600ECE3 RID: 60643 RVA: 0x0022948D File Offset: 0x0022768D
		[NullableContext(1)]
		public static MotorSummonAndRideNotify Create()
		{
			return new MotorSummonAndRideNotify();
		}

		// Token: 0x1700301D RID: 12317
		// (get) Token: 0x0600ECE4 RID: 60644 RVA: 0x00229494 File Offset: 0x00227694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700301E RID: 12318
		// (get) Token: 0x0600ECE5 RID: 60645 RVA: 0x00229497 File Offset: 0x00227697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorSummonAndRideNotify.Descriptor;
			}
		}

		// Token: 0x0600ECE6 RID: 60646 RVA: 0x0022949E File Offset: 0x0022769E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSummonAndRideNotify()
		{
		}

		// Token: 0x0600ECE7 RID: 60647 RVA: 0x002294A8 File Offset: 0x002276A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSummonAndRideNotify(MotorSummonAndRideNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.entityId_ = other.entityId_;
			this.vehicleIncId_ = other.vehicleIncId_;
			this.transform_ = ((other.transform_ != null) ? other.transform_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ECE8 RID: 60648 RVA: 0x0022950C File Offset: 0x0022770C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSummonAndRideNotify Clone()
		{
			return new MotorSummonAndRideNotify(this);
		}

		// Token: 0x1700301F RID: 12319
		// (get) Token: 0x0600ECE9 RID: 60649 RVA: 0x00229514 File Offset: 0x00227714
		// (set) Token: 0x0600ECEA RID: 60650 RVA: 0x0022951C File Offset: 0x0022771C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17003020 RID: 12320
		// (get) Token: 0x0600ECEB RID: 60651 RVA: 0x00229525 File Offset: 0x00227725
		// (set) Token: 0x0600ECEC RID: 60652 RVA: 0x0022952D File Offset: 0x0022772D
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

		// Token: 0x17003021 RID: 12321
		// (get) Token: 0x0600ECED RID: 60653 RVA: 0x00229536 File Offset: 0x00227736
		// (set) Token: 0x0600ECEE RID: 60654 RVA: 0x0022953E File Offset: 0x0022773E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long VehicleIncId
		{
			get
			{
				return this.vehicleIncId_;
			}
			set
			{
				this.vehicleIncId_ = value;
			}
		}

		// Token: 0x17003022 RID: 12322
		// (get) Token: 0x0600ECEF RID: 60655 RVA: 0x00229547 File Offset: 0x00227747
		// (set) Token: 0x0600ECF0 RID: 60656 RVA: 0x0022954F File Offset: 0x0022774F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Transform Transform
		{
			get
			{
				return this.transform_;
			}
			set
			{
				this.transform_ = value;
			}
		}

		// Token: 0x0600ECF1 RID: 60657 RVA: 0x00229558 File Offset: 0x00227758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorSummonAndRideNotify);
		}

		// Token: 0x0600ECF2 RID: 60658 RVA: 0x00229568 File Offset: 0x00227768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorSummonAndRideNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.EntityId == other.EntityId && this.VehicleIncId == other.VehicleIncId && object.Equals(this.Transform, other.Transform) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ECF3 RID: 60659 RVA: 0x002295D8 File Offset: 0x002277D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.VehicleIncId != 0L)
			{
				num ^= this.VehicleIncId.GetHashCode();
			}
			if (this.transform_ != null)
			{
				num ^= this.Transform.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ECF4 RID: 60660 RVA: 0x0022965F File Offset: 0x0022785F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ECF5 RID: 60661 RVA: 0x0022966C File Offset: 0x0022786C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ECF6 RID: 60662 RVA: 0x00229678 File Offset: 0x00227878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.transform_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Transform);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PlayerId);
			}
			if (this.VehicleIncId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.VehicleIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ECF7 RID: 60663 RVA: 0x00229708 File Offset: 0x00227908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.VehicleIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.VehicleIncId);
			}
			if (this.transform_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Transform);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ECF8 RID: 60664 RVA: 0x00229790 File Offset: 0x00227990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorSummonAndRideNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.VehicleIncId != 0L)
			{
				this.VehicleIncId = other.VehicleIncId;
			}
			if (other.transform_ != null)
			{
				if (this.transform_ == null)
				{
					this.Transform = new Transform();
				}
				this.Transform.MergeFrom(other.Transform);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ECF9 RID: 60665 RVA: 0x00229820 File Offset: 0x00227A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ECFA RID: 60666 RVA: 0x0022982C File Offset: 0x00227A2C
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 26U)
					{
						if (this.transform_ == null)
						{
							this.Transform = new Transform();
						}
						input.ReadMessage(this.Transform);
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.VehicleIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005FFF RID: 24575
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006000 RID: 24576
		public const int PlayerIdFieldNumber = 4;

		// Token: 0x04006001 RID: 24577
		private int playerId_;

		// Token: 0x04006002 RID: 24578
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04006003 RID: 24579
		private long entityId_;

		// Token: 0x04006004 RID: 24580
		public const int VehicleIncIdFieldNumber = 7;

		// Token: 0x04006005 RID: 24581
		private long vehicleIncId_;

		// Token: 0x04006006 RID: 24582
		public const int TransformFieldNumber = 3;

		// Token: 0x04006007 RID: 24583
		private Transform transform_;
	}
}
