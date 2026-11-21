using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E0 RID: 4576
	[NetMessage(EMessageId.SeamlessTeleportRequest)]
	public sealed class SeamlessTeleportRequest : IMessage<SeamlessTeleportRequest>, IMessage, IEquatable<SeamlessTeleportRequest>, IDeepCloneable<SeamlessTeleportRequest>, IBufferMessage
	{
		// Token: 0x060186CF RID: 100047 RVA: 0x0038E23B File Offset: 0x0038C43B
		[NullableContext(1)]
		public static SeamlessTeleportRequest Create()
		{
			return new SeamlessTeleportRequest();
		}

		// Token: 0x17005255 RID: 21077
		// (get) Token: 0x060186D0 RID: 100048 RVA: 0x0038E242 File Offset: 0x0038C442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005256 RID: 21078
		// (get) Token: 0x060186D1 RID: 100049 RVA: 0x0038E245 File Offset: 0x0038C445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SeamlessTeleportRequest.Descriptor;
			}
		}

		// Token: 0x060186D2 RID: 100050 RVA: 0x0038E24C File Offset: 0x0038C44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportRequest()
		{
		}

		// Token: 0x060186D3 RID: 100051 RVA: 0x0038E254 File Offset: 0x0038C454
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

		// Token: 0x060186D4 RID: 100052 RVA: 0x0038E2E4 File Offset: 0x0038C4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportRequest Clone()
		{
			return new SeamlessTeleportRequest(this);
		}

		// Token: 0x17005257 RID: 21079
		// (get) Token: 0x060186D5 RID: 100053 RVA: 0x0038E2EC File Offset: 0x0038C4EC
		// (set) Token: 0x060186D6 RID: 100054 RVA: 0x0038E2F4 File Offset: 0x0038C4F4
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

		// Token: 0x17005258 RID: 21080
		// (get) Token: 0x060186D7 RID: 100055 RVA: 0x0038E2FD File Offset: 0x0038C4FD
		// (set) Token: 0x060186D8 RID: 100056 RVA: 0x0038E305 File Offset: 0x0038C505
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

		// Token: 0x17005259 RID: 21081
		// (get) Token: 0x060186D9 RID: 100057 RVA: 0x0038E30E File Offset: 0x0038C50E
		// (set) Token: 0x060186DA RID: 100058 RVA: 0x0038E316 File Offset: 0x0038C516
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

		// Token: 0x1700525A RID: 21082
		// (get) Token: 0x060186DB RID: 100059 RVA: 0x0038E31F File Offset: 0x0038C51F
		// (set) Token: 0x060186DC RID: 100060 RVA: 0x0038E327 File Offset: 0x0038C527
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

		// Token: 0x1700525B RID: 21083
		// (get) Token: 0x060186DD RID: 100061 RVA: 0x0038E330 File Offset: 0x0038C530
		// (set) Token: 0x060186DE RID: 100062 RVA: 0x0038E338 File Offset: 0x0038C538
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

		// Token: 0x060186DF RID: 100063 RVA: 0x0038E341 File Offset: 0x0038C541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SeamlessTeleportRequest);
		}

		// Token: 0x060186E0 RID: 100064 RVA: 0x0038E350 File Offset: 0x0038C550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SeamlessTeleportRequest other)
		{
			return other != null && (other == this || (this.TeleportType == other.TeleportType && object.Equals(this.TeleportArgs, other.TeleportArgs) && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && this.VehicleId == other.VehicleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060186E1 RID: 100065 RVA: 0x0038E3D8 File Offset: 0x0038C5D8
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

		// Token: 0x060186E2 RID: 100066 RVA: 0x0038E478 File Offset: 0x0038C678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060186E3 RID: 100067 RVA: 0x0038E485 File Offset: 0x0038C685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060186E4 RID: 100068 RVA: 0x0038E490 File Offset: 0x0038C690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rotation_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Rotation);
			}
			if (this.teleportArgs_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.TeleportArgs);
			}
			if (this.TeleportType != SeamlessTeleportType.ClientTriggerAction)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.TeleportType);
			}
			if (this.VehicleId != 0L)
			{
				output.WriteRawTag(112);
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

		// Token: 0x060186E5 RID: 100069 RVA: 0x0038E540 File Offset: 0x0038C740
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

		// Token: 0x060186E6 RID: 100070 RVA: 0x0038E5E0 File Offset: 0x0038C7E0
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

		// Token: 0x060186E7 RID: 100071 RVA: 0x0038E6B4 File Offset: 0x0038C8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060186E8 RID: 100072 RVA: 0x0038E6C0 File Offset: 0x0038C8C0
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
					if (num == 34U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Rotator();
						}
						input.ReadMessage(this.Rotation);
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
					if (num == 80U)
					{
						this.TeleportType = (SeamlessTeleportType)input.ReadEnum();
						continue;
					}
					if (num == 112U)
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

		// Token: 0x04009112 RID: 37138
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009113 RID: 37139
		public const int TeleportTypeFieldNumber = 10;

		// Token: 0x04009114 RID: 37140
		private SeamlessTeleportType teleportType_;

		// Token: 0x04009115 RID: 37141
		public const int TeleportArgsFieldNumber = 7;

		// Token: 0x04009116 RID: 37142
		private SeamlessTeleportArgs teleportArgs_;

		// Token: 0x04009117 RID: 37143
		public const int LocationFieldNumber = 15;

		// Token: 0x04009118 RID: 37144
		private Vector location_;

		// Token: 0x04009119 RID: 37145
		public const int RotationFieldNumber = 4;

		// Token: 0x0400911A RID: 37146
		private Rotator rotation_;

		// Token: 0x0400911B RID: 37147
		public const int VehicleIdFieldNumber = 14;

		// Token: 0x0400911C RID: 37148
		private long vehicleId_;
	}
}
