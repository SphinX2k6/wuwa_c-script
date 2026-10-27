using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014CB RID: 5323
	[NetMessage(EMessageId.VehicleEnterSharingRequest)]
	public sealed class VehicleEnterSharingRequest : IMessage<VehicleEnterSharingRequest>, IMessage, IEquatable<VehicleEnterSharingRequest>, IDeepCloneable<VehicleEnterSharingRequest>, IBufferMessage
	{
		// Token: 0x0601C26D RID: 115309 RVA: 0x00411C55 File Offset: 0x0040FE55
		[NullableContext(1)]
		public static VehicleEnterSharingRequest Create()
		{
			return new VehicleEnterSharingRequest();
		}

		// Token: 0x17005EE9 RID: 24297
		// (get) Token: 0x0601C26E RID: 115310 RVA: 0x00411C5C File Offset: 0x0040FE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EEA RID: 24298
		// (get) Token: 0x0601C26F RID: 115311 RVA: 0x00411C5F File Offset: 0x0040FE5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleEnterSharingRequest.Descriptor;
			}
		}

		// Token: 0x0601C270 RID: 115312 RVA: 0x00411C66 File Offset: 0x0040FE66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleEnterSharingRequest()
		{
		}

		// Token: 0x0601C271 RID: 115313 RVA: 0x00411C6E File Offset: 0x0040FE6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleEnterSharingRequest(VehicleEnterSharingRequest other) : this()
		{
			this.isEnter_ = other.isEnter_;
			this.rideMode_ = other.rideMode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C272 RID: 115314 RVA: 0x00411C9F File Offset: 0x0040FE9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleEnterSharingRequest Clone()
		{
			return new VehicleEnterSharingRequest(this);
		}

		// Token: 0x17005EEB RID: 24299
		// (get) Token: 0x0601C273 RID: 115315 RVA: 0x00411CA7 File Offset: 0x0040FEA7
		// (set) Token: 0x0601C274 RID: 115316 RVA: 0x00411CAF File Offset: 0x0040FEAF
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

		// Token: 0x17005EEC RID: 24300
		// (get) Token: 0x0601C275 RID: 115317 RVA: 0x00411CB8 File Offset: 0x0040FEB8
		// (set) Token: 0x0601C276 RID: 115318 RVA: 0x00411CC0 File Offset: 0x0040FEC0
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

		// Token: 0x0601C277 RID: 115319 RVA: 0x00411CC9 File Offset: 0x0040FEC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleEnterSharingRequest);
		}

		// Token: 0x0601C278 RID: 115320 RVA: 0x00411CD7 File Offset: 0x0040FED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleEnterSharingRequest other)
		{
			return other != null && (other == this || (this.IsEnter == other.IsEnter && this.RideMode == other.RideMode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C279 RID: 115321 RVA: 0x00411D18 File Offset: 0x0040FF18
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

		// Token: 0x0601C27A RID: 115322 RVA: 0x00411D76 File Offset: 0x0040FF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C27B RID: 115323 RVA: 0x00411D83 File Offset: 0x0040FF83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C27C RID: 115324 RVA: 0x00411D8C File Offset: 0x0040FF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RideMode != ShareRideMode.MovieMotor)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.RideMode);
			}
			if (this.IsEnter)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsEnter);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C27D RID: 115325 RVA: 0x00411DE8 File Offset: 0x0040FFE8
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

		// Token: 0x0601C27E RID: 115326 RVA: 0x00411E34 File Offset: 0x00410034
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

		// Token: 0x0601C27F RID: 115327 RVA: 0x00411E84 File Offset: 0x00410084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C280 RID: 115328 RVA: 0x00411E90 File Offset: 0x00410090
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
				if (num != 72U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsEnter = input.ReadBool();
					}
				}
				else
				{
					this.RideMode = (ShareRideMode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A186 RID: 41350
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A187 RID: 41351
		public const int IsEnterFieldNumber = 15;

		// Token: 0x0400A188 RID: 41352
		private bool isEnter_;

		// Token: 0x0400A189 RID: 41353
		public const int RideModeFieldNumber = 9;

		// Token: 0x0400A18A RID: 41354
		private ShareRideMode rideMode_;
	}
}
