using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A8 RID: 4520
	[NetMessage(EMessageId.SeamlessTeleportVehicleRequest)]
	public sealed class SeamlessTeleportVehicleRequest : IMessage<SeamlessTeleportVehicleRequest>, IMessage, IEquatable<SeamlessTeleportVehicleRequest>, IDeepCloneable<SeamlessTeleportVehicleRequest>, IBufferMessage
	{
		// Token: 0x0601815A RID: 98650 RVA: 0x0037F635 File Offset: 0x0037D835
		[NullableContext(1)]
		public static SeamlessTeleportVehicleRequest Create()
		{
			return new SeamlessTeleportVehicleRequest();
		}

		// Token: 0x170050F3 RID: 20723
		// (get) Token: 0x0601815B RID: 98651 RVA: 0x0037F63C File Offset: 0x0037D83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050F4 RID: 20724
		// (get) Token: 0x0601815C RID: 98652 RVA: 0x0037F63F File Offset: 0x0037D83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SeamlessTeleportVehicleRequest.Descriptor;
			}
		}

		// Token: 0x0601815D RID: 98653 RVA: 0x0037F646 File Offset: 0x0037D846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportVehicleRequest()
		{
		}

		// Token: 0x0601815E RID: 98654 RVA: 0x0037F650 File Offset: 0x0037D850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportVehicleRequest(SeamlessTeleportVehicleRequest other) : this()
		{
			this.vehicleEntityId_ = other.vehicleEntityId_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601815F RID: 98655 RVA: 0x0037F6B8 File Offset: 0x0037D8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportVehicleRequest Clone()
		{
			return new SeamlessTeleportVehicleRequest(this);
		}

		// Token: 0x170050F5 RID: 20725
		// (get) Token: 0x06018160 RID: 98656 RVA: 0x0037F6C0 File Offset: 0x0037D8C0
		// (set) Token: 0x06018161 RID: 98657 RVA: 0x0037F6C8 File Offset: 0x0037D8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long VehicleEntityId
		{
			get
			{
				return this.vehicleEntityId_;
			}
			set
			{
				this.vehicleEntityId_ = value;
			}
		}

		// Token: 0x170050F6 RID: 20726
		// (get) Token: 0x06018162 RID: 98658 RVA: 0x0037F6D1 File Offset: 0x0037D8D1
		// (set) Token: 0x06018163 RID: 98659 RVA: 0x0037F6D9 File Offset: 0x0037D8D9
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

		// Token: 0x170050F7 RID: 20727
		// (get) Token: 0x06018164 RID: 98660 RVA: 0x0037F6E2 File Offset: 0x0037D8E2
		// (set) Token: 0x06018165 RID: 98661 RVA: 0x0037F6EA File Offset: 0x0037D8EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rotation
		{
			get
			{
				return this.rotation_;
			}
			set
			{
				this.rotation_ = value;
			}
		}

		// Token: 0x06018166 RID: 98662 RVA: 0x0037F6F3 File Offset: 0x0037D8F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SeamlessTeleportVehicleRequest);
		}

		// Token: 0x06018167 RID: 98663 RVA: 0x0037F704 File Offset: 0x0037D904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SeamlessTeleportVehicleRequest other)
		{
			return other != null && (other == this || (this.VehicleEntityId == other.VehicleEntityId && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018168 RID: 98664 RVA: 0x0037F768 File Offset: 0x0037D968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.VehicleEntityId != 0L)
			{
				num ^= this.VehicleEntityId.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018169 RID: 98665 RVA: 0x0037F7D3 File Offset: 0x0037D9D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601816A RID: 98666 RVA: 0x0037F7E0 File Offset: 0x0037D9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601816B RID: 98667 RVA: 0x0037F7EC File Offset: 0x0037D9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.location_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Location);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Rotation);
			}
			if (this.VehicleEntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.VehicleEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601816C RID: 98668 RVA: 0x0037F864 File Offset: 0x0037DA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.VehicleEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.VehicleEntityId);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601816D RID: 98669 RVA: 0x0037F8D4 File Offset: 0x0037DAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SeamlessTeleportVehicleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.VehicleEntityId != 0L)
			{
				this.VehicleEntityId = other.VehicleEntityId;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			if (other.rotation_ != null)
			{
				if (this.rotation_ == null)
				{
					this.Rotation = new Rotator();
				}
				this.Rotation.MergeFrom(other.Rotation);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601816E RID: 98670 RVA: 0x0037F968 File Offset: 0x0037DB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601816F RID: 98671 RVA: 0x0037F974 File Offset: 0x0037DB74
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
					if (num != 114U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.VehicleEntityId = input.ReadInt64();
						}
					}
					else
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Rotator();
						}
						input.ReadMessage(this.Rotation);
					}
				}
				else
				{
					if (this.location_ == null)
					{
						this.Location = new Vector();
					}
					input.ReadMessage(this.Location);
				}
			}
		}

		// Token: 0x04008E8D RID: 36493
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E8E RID: 36494
		public const int VehicleEntityIdFieldNumber = 15;

		// Token: 0x04008E8F RID: 36495
		private long vehicleEntityId_;

		// Token: 0x04008E90 RID: 36496
		public const int LocationFieldNumber = 8;

		// Token: 0x04008E91 RID: 36497
		private Vector location_;

		// Token: 0x04008E92 RID: 36498
		public const int RotationFieldNumber = 14;

		// Token: 0x04008E93 RID: 36499
		private Rotator rotation_;
	}
}
