using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D9 RID: 5337
	[NetMessage(EMessageId.VehicleShareNotify)]
	public sealed class VehicleShareNotify : IMessage<VehicleShareNotify>, IMessage, IEquatable<VehicleShareNotify>, IDeepCloneable<VehicleShareNotify>, IBufferMessage
	{
		// Token: 0x0601C385 RID: 115589 RVA: 0x00413FD1 File Offset: 0x004121D1
		[NullableContext(1)]
		public static VehicleShareNotify Create()
		{
			return new VehicleShareNotify();
		}

		// Token: 0x17005F21 RID: 24353
		// (get) Token: 0x0601C386 RID: 115590 RVA: 0x00413FD8 File Offset: 0x004121D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F22 RID: 24354
		// (get) Token: 0x0601C387 RID: 115591 RVA: 0x00413FDB File Offset: 0x004121DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleShareNotify.Descriptor;
			}
		}

		// Token: 0x0601C388 RID: 115592 RVA: 0x00413FE2 File Offset: 0x004121E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleShareNotify()
		{
		}

		// Token: 0x0601C389 RID: 115593 RVA: 0x00413FEC File Offset: 0x004121EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleShareNotify(VehicleShareNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.rideMode_ = other.rideMode_;
			this.isEnter_ = other.isEnter_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C38A RID: 115594 RVA: 0x00414040 File Offset: 0x00412240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleShareNotify Clone()
		{
			return new VehicleShareNotify(this);
		}

		// Token: 0x17005F23 RID: 24355
		// (get) Token: 0x0601C38B RID: 115595 RVA: 0x00414048 File Offset: 0x00412248
		// (set) Token: 0x0601C38C RID: 115596 RVA: 0x00414050 File Offset: 0x00412250
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

		// Token: 0x17005F24 RID: 24356
		// (get) Token: 0x0601C38D RID: 115597 RVA: 0x00414059 File Offset: 0x00412259
		// (set) Token: 0x0601C38E RID: 115598 RVA: 0x00414061 File Offset: 0x00412261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShareRideMode RideMode
		{
			get
			{
				return this.rideMode_;
			}
			set
			{
				this.rideMode_ = value;
			}
		}

		// Token: 0x17005F25 RID: 24357
		// (get) Token: 0x0601C38F RID: 115599 RVA: 0x0041406A File Offset: 0x0041226A
		// (set) Token: 0x0601C390 RID: 115600 RVA: 0x00414072 File Offset: 0x00412272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnter
		{
			get
			{
				return this.isEnter_;
			}
			set
			{
				this.isEnter_ = value;
			}
		}

		// Token: 0x17005F26 RID: 24358
		// (get) Token: 0x0601C391 RID: 115601 RVA: 0x0041407B File Offset: 0x0041227B
		// (set) Token: 0x0601C392 RID: 115602 RVA: 0x00414083 File Offset: 0x00412283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleShareReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x0601C393 RID: 115603 RVA: 0x0041408C File Offset: 0x0041228C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleShareNotify);
		}

		// Token: 0x0601C394 RID: 115604 RVA: 0x0041409C File Offset: 0x0041229C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleShareNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.RideMode == other.RideMode && this.IsEnter == other.IsEnter && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C395 RID: 115605 RVA: 0x00414108 File Offset: 0x00412308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.RideMode != ShareRideMode.MovieMotor)
			{
				num ^= this.RideMode.GetHashCode();
			}
			if (this.IsEnter)
			{
				num ^= this.IsEnter.GetHashCode();
			}
			if (this.Reason != VehicleShareReason.ClientRequest)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C396 RID: 115606 RVA: 0x0041419F File Offset: 0x0041239F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C397 RID: 115607 RVA: 0x004141AC File Offset: 0x004123AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C398 RID: 115608 RVA: 0x004141B8 File Offset: 0x004123B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RideMode != ShareRideMode.MovieMotor)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.RideMode);
			}
			if (this.IsEnter)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsEnter);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Reason != VehicleShareReason.ClientRequest)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C399 RID: 115609 RVA: 0x0041424C File Offset: 0x0041244C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.RideMode != ShareRideMode.MovieMotor)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RideMode);
			}
			if (this.IsEnter)
			{
				num += 2;
			}
			if (this.Reason != VehicleShareReason.ClientRequest)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C39A RID: 115610 RVA: 0x004142C8 File Offset: 0x004124C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehicleShareNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.RideMode != ShareRideMode.MovieMotor)
			{
				this.RideMode = other.RideMode;
			}
			if (other.IsEnter)
			{
				this.IsEnter = other.IsEnter;
			}
			if (other.Reason != VehicleShareReason.ClientRequest)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C39B RID: 115611 RVA: 0x00414340 File Offset: 0x00412540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C39C RID: 115612 RVA: 0x0041434C File Offset: 0x0041254C
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
				if (num <= 64U)
				{
					if (num == 48U)
					{
						this.RideMode = (ShareRideMode)input.ReadEnum();
						continue;
					}
					if (num == 64U)
					{
						this.IsEnter = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Reason = (VehicleShareReason)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A1CC RID: 41420
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1CD RID: 41421
		public const int PlayerIdFieldNumber = 10;

		// Token: 0x0400A1CE RID: 41422
		private int playerId_;

		// Token: 0x0400A1CF RID: 41423
		public const int RideModeFieldNumber = 6;

		// Token: 0x0400A1D0 RID: 41424
		private ShareRideMode rideMode_;

		// Token: 0x0400A1D1 RID: 41425
		public const int IsEnterFieldNumber = 8;

		// Token: 0x0400A1D2 RID: 41426
		private bool isEnter_;

		// Token: 0x0400A1D3 RID: 41427
		public const int ReasonFieldNumber = 15;

		// Token: 0x0400A1D4 RID: 41428
		private VehicleShareReason reason_;
	}
}
