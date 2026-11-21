using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A91 RID: 2705
	[NetMessage(EMessageId.MotorSummonAndRidePush)]
	public sealed class MotorSummonAndRidePush : IMessage<MotorSummonAndRidePush>, IMessage, IEquatable<MotorSummonAndRidePush>, IDeepCloneable<MotorSummonAndRidePush>, IBufferMessage
	{
		// Token: 0x0600EBE1 RID: 60385 RVA: 0x002276CA File Offset: 0x002258CA
		[NullableContext(1)]
		public static MotorSummonAndRidePush Create()
		{
			return new MotorSummonAndRidePush();
		}

		// Token: 0x17002FE5 RID: 12261
		// (get) Token: 0x0600EBE2 RID: 60386 RVA: 0x002276D1 File Offset: 0x002258D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FE6 RID: 12262
		// (get) Token: 0x0600EBE3 RID: 60387 RVA: 0x002276D4 File Offset: 0x002258D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorSummonAndRidePush.Descriptor;
			}
		}

		// Token: 0x0600EBE4 RID: 60388 RVA: 0x002276DB File Offset: 0x002258DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSummonAndRidePush()
		{
		}

		// Token: 0x0600EBE5 RID: 60389 RVA: 0x002276E4 File Offset: 0x002258E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSummonAndRidePush(MotorSummonAndRidePush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.vehicleIncId_ = other.vehicleIncId_;
			this.transform_ = ((other.transform_ != null) ? other.transform_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EBE6 RID: 60390 RVA: 0x0022773C File Offset: 0x0022593C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSummonAndRidePush Clone()
		{
			return new MotorSummonAndRidePush(this);
		}

		// Token: 0x17002FE7 RID: 12263
		// (get) Token: 0x0600EBE7 RID: 60391 RVA: 0x00227744 File Offset: 0x00225944
		// (set) Token: 0x0600EBE8 RID: 60392 RVA: 0x0022774C File Offset: 0x0022594C
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

		// Token: 0x17002FE8 RID: 12264
		// (get) Token: 0x0600EBE9 RID: 60393 RVA: 0x00227755 File Offset: 0x00225955
		// (set) Token: 0x0600EBEA RID: 60394 RVA: 0x0022775D File Offset: 0x0022595D
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

		// Token: 0x17002FE9 RID: 12265
		// (get) Token: 0x0600EBEB RID: 60395 RVA: 0x00227766 File Offset: 0x00225966
		// (set) Token: 0x0600EBEC RID: 60396 RVA: 0x0022776E File Offset: 0x0022596E
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

		// Token: 0x0600EBED RID: 60397 RVA: 0x00227777 File Offset: 0x00225977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorSummonAndRidePush);
		}

		// Token: 0x0600EBEE RID: 60398 RVA: 0x00227788 File Offset: 0x00225988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorSummonAndRidePush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.VehicleIncId == other.VehicleIncId && object.Equals(this.Transform, other.Transform) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EBEF RID: 60399 RVA: 0x002277E8 File Offset: 0x002259E8
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

		// Token: 0x0600EBF0 RID: 60400 RVA: 0x00227856 File Offset: 0x00225A56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EBF1 RID: 60401 RVA: 0x00227863 File Offset: 0x00225A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EBF2 RID: 60402 RVA: 0x0022786C File Offset: 0x00225A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.transform_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Transform);
			}
			if (this.VehicleIncId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.VehicleIncId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EBF3 RID: 60403 RVA: 0x002278E4 File Offset: 0x00225AE4
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

		// Token: 0x0600EBF4 RID: 60404 RVA: 0x00227954 File Offset: 0x00225B54
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

		// Token: 0x0600EBF5 RID: 60405 RVA: 0x002279D0 File Offset: 0x00225BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EBF6 RID: 60406 RVA: 0x002279DC File Offset: 0x00225BDC
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
				if (num != 66U)
				{
					if (num != 80U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					if (this.transform_ == null)
					{
						this.Transform = new Transform();
					}
					input.ReadMessage(this.Transform);
				}
			}
		}

		// Token: 0x04006011 RID: 24593
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006012 RID: 24594
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04006013 RID: 24595
		private long entityId_;

		// Token: 0x04006014 RID: 24596
		public const int VehicleIncIdFieldNumber = 10;

		// Token: 0x04006015 RID: 24597
		private long vehicleIncId_;

		// Token: 0x04006016 RID: 24598
		public const int TransformFieldNumber = 8;

		// Token: 0x04006017 RID: 24599
		private Transform transform_;
	}
}
