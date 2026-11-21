using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001541 RID: 5441
	[NetMessage(EMessageId.VehicleEnterSharingRequest)]
	public sealed class VehicleEnterSharingRequest : IMessage<VehicleEnterSharingRequest>, IMessage, IEquatable<VehicleEnterSharingRequest>, IDeepCloneable<VehicleEnterSharingRequest>, IBufferMessage
	{
		// Token: 0x0601CD34 RID: 118068 RVA: 0x0042D711 File Offset: 0x0042B911
		[NullableContext(1)]
		public static VehicleEnterSharingRequest Create()
		{
			return new VehicleEnterSharingRequest();
		}

		// Token: 0x1700618A RID: 24970
		// (get) Token: 0x0601CD35 RID: 118069 RVA: 0x0042D718 File Offset: 0x0042B918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700618B RID: 24971
		// (get) Token: 0x0601CD36 RID: 118070 RVA: 0x0042D71B File Offset: 0x0042B91B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleEnterSharingRequest.Descriptor;
			}
		}

		// Token: 0x0601CD37 RID: 118071 RVA: 0x0042D722 File Offset: 0x0042B922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleEnterSharingRequest()
		{
		}

		// Token: 0x0601CD38 RID: 118072 RVA: 0x0042D72A File Offset: 0x0042B92A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleEnterSharingRequest(VehicleEnterSharingRequest other) : this()
		{
			this.isEnter_ = other.isEnter_;
			this.rideMode_ = other.rideMode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CD39 RID: 118073 RVA: 0x0042D75B File Offset: 0x0042B95B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleEnterSharingRequest Clone()
		{
			return new VehicleEnterSharingRequest(this);
		}

		// Token: 0x1700618C RID: 24972
		// (get) Token: 0x0601CD3A RID: 118074 RVA: 0x0042D763 File Offset: 0x0042B963
		// (set) Token: 0x0601CD3B RID: 118075 RVA: 0x0042D76B File Offset: 0x0042B96B
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

		// Token: 0x1700618D RID: 24973
		// (get) Token: 0x0601CD3C RID: 118076 RVA: 0x0042D774 File Offset: 0x0042B974
		// (set) Token: 0x0601CD3D RID: 118077 RVA: 0x0042D77C File Offset: 0x0042B97C
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

		// Token: 0x0601CD3E RID: 118078 RVA: 0x0042D785 File Offset: 0x0042B985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleEnterSharingRequest);
		}

		// Token: 0x0601CD3F RID: 118079 RVA: 0x0042D793 File Offset: 0x0042B993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleEnterSharingRequest other)
		{
			return other != null && (other == this || (this.IsEnter == other.IsEnter && this.RideMode == other.RideMode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CD40 RID: 118080 RVA: 0x0042D7D4 File Offset: 0x0042B9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsEnter)
			{
				num ^= this.IsEnter.GetHashCode();
			}
			if (this.RideMode != ShareRideMode.MovieMotor)
			{
				num ^= this.RideMode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CD41 RID: 118081 RVA: 0x0042D832 File Offset: 0x0042BA32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CD42 RID: 118082 RVA: 0x0042D83F File Offset: 0x0042BA3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CD43 RID: 118083 RVA: 0x0042D848 File Offset: 0x0042BA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsEnter)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsEnter);
			}
			if (this.RideMode != ShareRideMode.MovieMotor)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.RideMode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CD44 RID: 118084 RVA: 0x0042D8A4 File Offset: 0x0042BAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsEnter)
			{
				num += 2;
			}
			if (this.RideMode != ShareRideMode.MovieMotor)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RideMode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CD45 RID: 118085 RVA: 0x0042D8F0 File Offset: 0x0042BAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehicleEnterSharingRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsEnter)
			{
				this.IsEnter = other.IsEnter;
			}
			if (other.RideMode != ShareRideMode.MovieMotor)
			{
				this.RideMode = other.RideMode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CD46 RID: 118086 RVA: 0x0042D940 File Offset: 0x0042BB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CD47 RID: 118087 RVA: 0x0042D94C File Offset: 0x0042BB4C
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
				if (num != 32U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RideMode = (ShareRideMode)input.ReadEnum();
					}
				}
				else
				{
					this.IsEnter = input.ReadBool();
				}
			}
		}

		// Token: 0x0400A5DF RID: 42463
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A5E0 RID: 42464
		public const int IsEnterFieldNumber = 4;

		// Token: 0x0400A5E1 RID: 42465
		private bool isEnter_;

		// Token: 0x0400A5E2 RID: 42466
		public const int RideModeFieldNumber = 9;

		// Token: 0x0400A5E3 RID: 42467
		private ShareRideMode rideMode_;
	}
}
