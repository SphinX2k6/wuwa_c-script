using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A6 RID: 4518
	[NetMessage(EMessageId.SeamlessTeleportRequest)]
	public sealed class SeamlessTeleportRequest : IMessage<SeamlessTeleportRequest>, IMessage, IEquatable<SeamlessTeleportRequest>, IDeepCloneable<SeamlessTeleportRequest>, IBufferMessage
	{
		// Token: 0x0601812E RID: 98606 RVA: 0x0037EEF7 File Offset: 0x0037D0F7
		[NullableContext(1)]
		public static SeamlessTeleportRequest Create()
		{
			return new SeamlessTeleportRequest();
		}

		// Token: 0x170050E9 RID: 20713
		// (get) Token: 0x0601812F RID: 98607 RVA: 0x0037EEFE File Offset: 0x0037D0FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050EA RID: 20714
		// (get) Token: 0x06018130 RID: 98608 RVA: 0x0037EF01 File Offset: 0x0037D101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SeamlessTeleportRequest.Descriptor;
			}
		}

		// Token: 0x06018131 RID: 98609 RVA: 0x0037EF08 File Offset: 0x0037D108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportRequest()
		{
		}

		// Token: 0x06018132 RID: 98610 RVA: 0x0037EF10 File Offset: 0x0037D110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportRequest(SeamlessTeleportRequest other) : this()
		{
			this.teleportType_ = other.teleportType_;
			this.teleportArgs_ = ((other.teleportArgs_ != null) ? other.teleportArgs_.Clone() : null);
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this.vehicleId_ = other.vehicleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018133 RID: 98611 RVA: 0x0037EFA0 File Offset: 0x0037D1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportRequest Clone()
		{
			return new SeamlessTeleportRequest(this);
		}

		// Token: 0x170050EB RID: 20715
		// (get) Token: 0x06018134 RID: 98612 RVA: 0x0037EFA8 File Offset: 0x0037D1A8
		// (set) Token: 0x06018135 RID: 98613 RVA: 0x0037EFB0 File Offset: 0x0037D1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportType TeleportType
		{
			get
			{
				return this.teleportType_;
			}
			set
			{
				this.teleportType_ = value;
			}
		}

		// Token: 0x170050EC RID: 20716
		// (get) Token: 0x06018136 RID: 98614 RVA: 0x0037EFB9 File Offset: 0x0037D1B9
		// (set) Token: 0x06018137 RID: 98615 RVA: 0x0037EFC1 File Offset: 0x0037D1C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportArgs TeleportArgs
		{
			get
			{
				return this.teleportArgs_;
			}
			set
			{
				this.teleportArgs_ = value;
			}
		}

		// Token: 0x170050ED RID: 20717
		// (get) Token: 0x06018138 RID: 98616 RVA: 0x0037EFCA File Offset: 0x0037D1CA
		// (set) Token: 0x06018139 RID: 98617 RVA: 0x0037EFD2 File Offset: 0x0037D1D2
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

		// Token: 0x170050EE RID: 20718
		// (get) Token: 0x0601813A RID: 98618 RVA: 0x0037EFDB File Offset: 0x0037D1DB
		// (set) Token: 0x0601813B RID: 98619 RVA: 0x0037EFE3 File Offset: 0x0037D1E3
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

		// Token: 0x170050EF RID: 20719
		// (get) Token: 0x0601813C RID: 98620 RVA: 0x0037EFEC File Offset: 0x0037D1EC
		// (set) Token: 0x0601813D RID: 98621 RVA: 0x0037EFF4 File Offset: 0x0037D1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long VehicleId
		{
			get
			{
				return this.vehicleId_;
			}
			set
			{
				this.vehicleId_ = value;
			}
		}

		// Token: 0x0601813E RID: 98622 RVA: 0x0037EFFD File Offset: 0x0037D1FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SeamlessTeleportRequest);
		}

		// Token: 0x0601813F RID: 98623 RVA: 0x0037F00C File Offset: 0x0037D20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SeamlessTeleportRequest other)
		{
			return other != null && (other == this || (this.TeleportType == other.TeleportType && object.Equals(this.TeleportArgs, other.TeleportArgs) && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && this.VehicleId == other.VehicleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018140 RID: 98624 RVA: 0x0037F094 File Offset: 0x0037D294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TeleportType != SeamlessTeleportType.ClientTriggerAction)
			{
				num ^= this.TeleportType.GetHashCode();
			}
			if (this.teleportArgs_ != null)
			{
				num ^= this.TeleportArgs.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this.VehicleId != 0L)
			{
				num ^= this.VehicleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018141 RID: 98625 RVA: 0x0037F134 File Offset: 0x0037D334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018142 RID: 98626 RVA: 0x0037F141 File Offset: 0x0037D341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018143 RID: 98627 RVA: 0x0037F14C File Offset: 0x0037D34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TeleportType != SeamlessTeleportType.ClientTriggerAction)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.TeleportType);
			}
			if (this.teleportArgs_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.TeleportArgs);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Rotation);
			}
			if (this.VehicleId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.VehicleId);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Location);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018144 RID: 98628 RVA: 0x0037F1FC File Offset: 0x0037D3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TeleportType != SeamlessTeleportType.ClientTriggerAction)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TeleportType);
			}
			if (this.teleportArgs_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TeleportArgs);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this.VehicleId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.VehicleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018145 RID: 98629 RVA: 0x0037F29C File Offset: 0x0037D49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SeamlessTeleportRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TeleportType != SeamlessTeleportType.ClientTriggerAction)
			{
				this.TeleportType = other.TeleportType;
			}
			if (other.teleportArgs_ != null)
			{
				if (this.teleportArgs_ == null)
				{
					this.TeleportArgs = new SeamlessTeleportArgs();
				}
				this.TeleportArgs.MergeFrom(other.TeleportArgs);
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
			if (other.VehicleId != 0L)
			{
				this.VehicleId = other.VehicleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018146 RID: 98630 RVA: 0x0037F370 File Offset: 0x0037D570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018147 RID: 98631 RVA: 0x0037F37C File Offset: 0x0037D57C
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
				if (num <= 58U)
				{
					if (num == 40U)
					{
						this.TeleportType = (SeamlessTeleportType)input.ReadEnum();
						continue;
					}
					if (num == 58U)
					{
						if (this.teleportArgs_ == null)
						{
							this.TeleportArgs = new SeamlessTeleportArgs();
						}
						input.ReadMessage(this.TeleportArgs);
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Rotator();
						}
						input.ReadMessage(this.Rotation);
						continue;
					}
					if (num == 80U)
					{
						this.VehicleId = input.ReadInt64();
						continue;
					}
					if (num == 122U)
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008E7F RID: 36479
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E80 RID: 36480
		public const int TeleportTypeFieldNumber = 5;

		// Token: 0x04008E81 RID: 36481
		private SeamlessTeleportType teleportType_;

		// Token: 0x04008E82 RID: 36482
		public const int TeleportArgsFieldNumber = 7;

		// Token: 0x04008E83 RID: 36483
		private SeamlessTeleportArgs teleportArgs_;

		// Token: 0x04008E84 RID: 36484
		public const int LocationFieldNumber = 15;

		// Token: 0x04008E85 RID: 36485
		private Vector location_;

		// Token: 0x04008E86 RID: 36486
		public const int RotationFieldNumber = 9;

		// Token: 0x04008E87 RID: 36487
		private Rotator rotation_;

		// Token: 0x04008E88 RID: 36488
		public const int VehicleIdFieldNumber = 10;

		// Token: 0x04008E89 RID: 36489
		private long vehicleId_;
	}
}
