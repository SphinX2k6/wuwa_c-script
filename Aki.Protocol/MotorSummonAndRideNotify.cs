using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A90 RID: 2704
	[NetMessage(EMessageId.MotorSummonAndRideNotify)]
	public sealed class MotorSummonAndRideNotify : IMessage<MotorSummonAndRideNotify>, IMessage, IEquatable<MotorSummonAndRideNotify>, IDeepCloneable<MotorSummonAndRideNotify>, IBufferMessage
	{
		// Token: 0x0600EBC9 RID: 60361 RVA: 0x00227291 File Offset: 0x00225491
		[NullableContext(1)]
		public static MotorSummonAndRideNotify Create()
		{
			return new MotorSummonAndRideNotify();
		}

		// Token: 0x17002FDF RID: 12255
		// (get) Token: 0x0600EBCA RID: 60362 RVA: 0x00227298 File Offset: 0x00225498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FE0 RID: 12256
		// (get) Token: 0x0600EBCB RID: 60363 RVA: 0x0022729B File Offset: 0x0022549B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorSummonAndRideNotify.Descriptor;
			}
		}

		// Token: 0x0600EBCC RID: 60364 RVA: 0x002272A2 File Offset: 0x002254A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSummonAndRideNotify()
		{
		}

		// Token: 0x0600EBCD RID: 60365 RVA: 0x002272AC File Offset: 0x002254AC
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

		// Token: 0x0600EBCE RID: 60366 RVA: 0x00227310 File Offset: 0x00225510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSummonAndRideNotify Clone()
		{
			return new MotorSummonAndRideNotify(this);
		}

		// Token: 0x17002FE1 RID: 12257
		// (get) Token: 0x0600EBCF RID: 60367 RVA: 0x00227318 File Offset: 0x00225518
		// (set) Token: 0x0600EBD0 RID: 60368 RVA: 0x00227320 File Offset: 0x00225520
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

		// Token: 0x17002FE2 RID: 12258
		// (get) Token: 0x0600EBD1 RID: 60369 RVA: 0x00227329 File Offset: 0x00225529
		// (set) Token: 0x0600EBD2 RID: 60370 RVA: 0x00227331 File Offset: 0x00225531
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

		// Token: 0x17002FE3 RID: 12259
		// (get) Token: 0x0600EBD3 RID: 60371 RVA: 0x0022733A File Offset: 0x0022553A
		// (set) Token: 0x0600EBD4 RID: 60372 RVA: 0x00227342 File Offset: 0x00225542
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

		// Token: 0x17002FE4 RID: 12260
		// (get) Token: 0x0600EBD5 RID: 60373 RVA: 0x0022734B File Offset: 0x0022554B
		// (set) Token: 0x0600EBD6 RID: 60374 RVA: 0x00227353 File Offset: 0x00225553
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

		// Token: 0x0600EBD7 RID: 60375 RVA: 0x0022735C File Offset: 0x0022555C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorSummonAndRideNotify);
		}

		// Token: 0x0600EBD8 RID: 60376 RVA: 0x0022736C File Offset: 0x0022556C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorSummonAndRideNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.EntityId == other.EntityId && this.VehicleIncId == other.VehicleIncId && object.Equals(this.Transform, other.Transform) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EBD9 RID: 60377 RVA: 0x002273DC File Offset: 0x002255DC
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

		// Token: 0x0600EBDA RID: 60378 RVA: 0x00227463 File Offset: 0x00225663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EBDB RID: 60379 RVA: 0x00227470 File Offset: 0x00225670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EBDC RID: 60380 RVA: 0x0022747C File Offset: 0x0022567C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.transform_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Transform);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this.VehicleIncId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.VehicleIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EBDD RID: 60381 RVA: 0x0022750C File Offset: 0x0022570C
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

		// Token: 0x0600EBDE RID: 60382 RVA: 0x00227594 File Offset: 0x00225794
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

		// Token: 0x0600EBDF RID: 60383 RVA: 0x00227624 File Offset: 0x00225824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EBE0 RID: 60384 RVA: 0x00227630 File Offset: 0x00225830
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
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
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
					if (num == 88U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.VehicleIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006008 RID: 24584
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006009 RID: 24585
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x0400600A RID: 24586
		private int playerId_;

		// Token: 0x0400600B RID: 24587
		public const int EntityIdFieldNumber = 11;

		// Token: 0x0400600C RID: 24588
		private long entityId_;

		// Token: 0x0400600D RID: 24589
		public const int VehicleIncIdFieldNumber = 14;

		// Token: 0x0400600E RID: 24590
		private long vehicleIncId_;

		// Token: 0x0400600F RID: 24591
		public const int TransformFieldNumber = 2;

		// Token: 0x04006010 RID: 24592
		private Transform transform_;
	}
}
