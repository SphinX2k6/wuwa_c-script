using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA2 RID: 2722
	[NetMessage(EMessageId.MotorSummonAndRidePush)]
	public sealed class MotorSummonAndRidePush : IMessage<MotorSummonAndRidePush>, IMessage, IEquatable<MotorSummonAndRidePush>, IDeepCloneable<MotorSummonAndRidePush>, IBufferMessage
	{
		// Token: 0x0600ECFB RID: 60667 RVA: 0x002298C6 File Offset: 0x00227AC6
		[NullableContext(1)]
		public static MotorSummonAndRidePush Create()
		{
			return new MotorSummonAndRidePush();
		}

		// Token: 0x17003023 RID: 12323
		// (get) Token: 0x0600ECFC RID: 60668 RVA: 0x002298CD File Offset: 0x00227ACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003024 RID: 12324
		// (get) Token: 0x0600ECFD RID: 60669 RVA: 0x002298D0 File Offset: 0x00227AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorSummonAndRidePush.Descriptor;
			}
		}

		// Token: 0x0600ECFE RID: 60670 RVA: 0x002298D7 File Offset: 0x00227AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSummonAndRidePush()
		{
		}

		// Token: 0x0600ECFF RID: 60671 RVA: 0x002298E0 File Offset: 0x00227AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSummonAndRidePush(MotorSummonAndRidePush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.vehicleIncId_ = other.vehicleIncId_;
			this.transform_ = ((other.transform_ != null) ? other.transform_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ED00 RID: 60672 RVA: 0x00229938 File Offset: 0x00227B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSummonAndRidePush Clone()
		{
			return new MotorSummonAndRidePush(this);
		}

		// Token: 0x17003025 RID: 12325
		// (get) Token: 0x0600ED01 RID: 60673 RVA: 0x00229940 File Offset: 0x00227B40
		// (set) Token: 0x0600ED02 RID: 60674 RVA: 0x00229948 File Offset: 0x00227B48
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

		// Token: 0x17003026 RID: 12326
		// (get) Token: 0x0600ED03 RID: 60675 RVA: 0x00229951 File Offset: 0x00227B51
		// (set) Token: 0x0600ED04 RID: 60676 RVA: 0x00229959 File Offset: 0x00227B59
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

		// Token: 0x17003027 RID: 12327
		// (get) Token: 0x0600ED05 RID: 60677 RVA: 0x00229962 File Offset: 0x00227B62
		// (set) Token: 0x0600ED06 RID: 60678 RVA: 0x0022996A File Offset: 0x00227B6A
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

		// Token: 0x0600ED07 RID: 60679 RVA: 0x00229973 File Offset: 0x00227B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorSummonAndRidePush);
		}

		// Token: 0x0600ED08 RID: 60680 RVA: 0x00229984 File Offset: 0x00227B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorSummonAndRidePush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.VehicleIncId == other.VehicleIncId && object.Equals(this.Transform, other.Transform) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ED09 RID: 60681 RVA: 0x002299E4 File Offset: 0x00227BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600ED0A RID: 60682 RVA: 0x00229A52 File Offset: 0x00227C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ED0B RID: 60683 RVA: 0x00229A5F File Offset: 0x00227C5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ED0C RID: 60684 RVA: 0x00229A68 File Offset: 0x00227C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.VehicleIncId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.VehicleIncId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this.transform_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Transform);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ED0D RID: 60685 RVA: 0x00229AE0 File Offset: 0x00227CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600ED0E RID: 60686 RVA: 0x00229B50 File Offset: 0x00227D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorSummonAndRidePush other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x0600ED0F RID: 60687 RVA: 0x00229BCC File Offset: 0x00227DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ED10 RID: 60688 RVA: 0x00229BD8 File Offset: 0x00227DD8
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						if (num != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.transform_ == null)
							{
								this.Transform = new Transform();
							}
							input.ReadMessage(this.Transform);
						}
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.VehicleIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04006008 RID: 24584
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006009 RID: 24585
		public const int EntityIdFieldNumber = 3;

		// Token: 0x0400600A RID: 24586
		private long entityId_;

		// Token: 0x0400600B RID: 24587
		public const int VehicleIncIdFieldNumber = 2;

		// Token: 0x0400600C RID: 24588
		private long vehicleIncId_;

		// Token: 0x0400600D RID: 24589
		public const int TransformFieldNumber = 4;

		// Token: 0x0400600E RID: 24590
		private Transform transform_;
	}
}
