using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200154F RID: 5455
	[NetMessage(EMessageId.VehicleShareNotify)]
	public sealed class VehicleShareNotify : IMessage<VehicleShareNotify>, IMessage, IEquatable<VehicleShareNotify>, IDeepCloneable<VehicleShareNotify>, IBufferMessage
	{
		// Token: 0x0601CE4C RID: 118348 RVA: 0x0042FA8D File Offset: 0x0042DC8D
		[NullableContext(1)]
		public static VehicleShareNotify Create()
		{
			return new VehicleShareNotify();
		}

		// Token: 0x170061C2 RID: 25026
		// (get) Token: 0x0601CE4D RID: 118349 RVA: 0x0042FA94 File Offset: 0x0042DC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061C3 RID: 25027
		// (get) Token: 0x0601CE4E RID: 118350 RVA: 0x0042FA97 File Offset: 0x0042DC97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleShareNotify.Descriptor;
			}
		}

		// Token: 0x0601CE4F RID: 118351 RVA: 0x0042FA9E File Offset: 0x0042DC9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleShareNotify()
		{
		}

		// Token: 0x0601CE50 RID: 118352 RVA: 0x0042FAA8 File Offset: 0x0042DCA8
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

		// Token: 0x0601CE51 RID: 118353 RVA: 0x0042FAFC File Offset: 0x0042DCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleShareNotify Clone()
		{
			return new VehicleShareNotify(this);
		}

		// Token: 0x170061C4 RID: 25028
		// (get) Token: 0x0601CE52 RID: 118354 RVA: 0x0042FB04 File Offset: 0x0042DD04
		// (set) Token: 0x0601CE53 RID: 118355 RVA: 0x0042FB0C File Offset: 0x0042DD0C
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

		// Token: 0x170061C5 RID: 25029
		// (get) Token: 0x0601CE54 RID: 118356 RVA: 0x0042FB15 File Offset: 0x0042DD15
		// (set) Token: 0x0601CE55 RID: 118357 RVA: 0x0042FB1D File Offset: 0x0042DD1D
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

		// Token: 0x170061C6 RID: 25030
		// (get) Token: 0x0601CE56 RID: 118358 RVA: 0x0042FB26 File Offset: 0x0042DD26
		// (set) Token: 0x0601CE57 RID: 118359 RVA: 0x0042FB2E File Offset: 0x0042DD2E
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

		// Token: 0x170061C7 RID: 25031
		// (get) Token: 0x0601CE58 RID: 118360 RVA: 0x0042FB37 File Offset: 0x0042DD37
		// (set) Token: 0x0601CE59 RID: 118361 RVA: 0x0042FB3F File Offset: 0x0042DD3F
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

		// Token: 0x0601CE5A RID: 118362 RVA: 0x0042FB48 File Offset: 0x0042DD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleShareNotify);
		}

		// Token: 0x0601CE5B RID: 118363 RVA: 0x0042FB58 File Offset: 0x0042DD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleShareNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.RideMode == other.RideMode && this.IsEnter == other.IsEnter && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CE5C RID: 118364 RVA: 0x0042FBC4 File Offset: 0x0042DDC4
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

		// Token: 0x0601CE5D RID: 118365 RVA: 0x0042FC5B File Offset: 0x0042DE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CE5E RID: 118366 RVA: 0x0042FC68 File Offset: 0x0042DE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CE5F RID: 118367 RVA: 0x0042FC74 File Offset: 0x0042DE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RideMode != ShareRideMode.MovieMotor)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.RideMode);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PlayerId);
			}
			if (this.IsEnter)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsEnter);
			}
			if (this.Reason != VehicleShareReason.ClientRequest)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CE60 RID: 118368 RVA: 0x0042FD08 File Offset: 0x0042DF08
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

		// Token: 0x0601CE61 RID: 118369 RVA: 0x0042FD84 File Offset: 0x0042DF84
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

		// Token: 0x0601CE62 RID: 118370 RVA: 0x0042FDFC File Offset: 0x0042DFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CE63 RID: 118371 RVA: 0x0042FE08 File Offset: 0x0042E008
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
				if (num <= 88U)
				{
					if (num == 56U)
					{
						this.RideMode = (ShareRideMode)input.ReadEnum();
						continue;
					}
					if (num == 88U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.IsEnter = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.Reason = (VehicleShareReason)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A625 RID: 42533
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A626 RID: 42534
		public const int PlayerIdFieldNumber = 11;

		// Token: 0x0400A627 RID: 42535
		private int playerId_;

		// Token: 0x0400A628 RID: 42536
		public const int RideModeFieldNumber = 7;

		// Token: 0x0400A629 RID: 42537
		private ShareRideMode rideMode_;

		// Token: 0x0400A62A RID: 42538
		public const int IsEnterFieldNumber = 12;

		// Token: 0x0400A62B RID: 42539
		private bool isEnter_;

		// Token: 0x0400A62C RID: 42540
		public const int ReasonFieldNumber = 14;

		// Token: 0x0400A62D RID: 42541
		private VehicleShareReason reason_;
	}
}
