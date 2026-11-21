using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B7 RID: 5047
	[NetMessage(EMessageId.TeleportVehicleNotify)]
	public sealed class TeleportVehicleNotify : IMessage<TeleportVehicleNotify>, IMessage, IEquatable<TeleportVehicleNotify>, IDeepCloneable<TeleportVehicleNotify>, IBufferMessage
	{
		// Token: 0x0601ADBA RID: 110010 RVA: 0x003E9389 File Offset: 0x003E7589
		[NullableContext(1)]
		public static TeleportVehicleNotify Create()
		{
			return new TeleportVehicleNotify();
		}

		// Token: 0x17005AF0 RID: 23280
		// (get) Token: 0x0601ADBB RID: 110011 RVA: 0x003E9390 File Offset: 0x003E7590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AF1 RID: 23281
		// (get) Token: 0x0601ADBC RID: 110012 RVA: 0x003E9393 File Offset: 0x003E7593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportVehicleNotify.Descriptor;
			}
		}

		// Token: 0x0601ADBD RID: 110013 RVA: 0x003E939A File Offset: 0x003E759A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportVehicleNotify()
		{
		}

		// Token: 0x0601ADBE RID: 110014 RVA: 0x003E93B8 File Offset: 0x003E75B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportVehicleNotify(TeleportVehicleNotify other) : this()
		{
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this.reason_ = other.reason_;
			this.psgPlayerIds_ = other.psgPlayerIds_.Clone();
			this.psgEntityIds_ = other.psgEntityIds_.Clone();
			this.vehicle_ = other.vehicle_;
			this.noLoading_ = other.noLoading_;
			this.transitionOption_ = ((other.transitionOption_ != null) ? other.transitionOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ADBF RID: 110015 RVA: 0x003E9476 File Offset: 0x003E7676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportVehicleNotify Clone()
		{
			return new TeleportVehicleNotify(this);
		}

		// Token: 0x17005AF2 RID: 23282
		// (get) Token: 0x0601ADC0 RID: 110016 RVA: 0x003E947E File Offset: 0x003E767E
		// (set) Token: 0x0601ADC1 RID: 110017 RVA: 0x003E9486 File Offset: 0x003E7686
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

		// Token: 0x17005AF3 RID: 23283
		// (get) Token: 0x0601ADC2 RID: 110018 RVA: 0x003E948F File Offset: 0x003E768F
		// (set) Token: 0x0601ADC3 RID: 110019 RVA: 0x003E9497 File Offset: 0x003E7697
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

		// Token: 0x17005AF4 RID: 23284
		// (get) Token: 0x0601ADC4 RID: 110020 RVA: 0x003E94A0 File Offset: 0x003E76A0
		// (set) Token: 0x0601ADC5 RID: 110021 RVA: 0x003E94A8 File Offset: 0x003E76A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportReason Reason
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

		// Token: 0x17005AF5 RID: 23285
		// (get) Token: 0x0601ADC6 RID: 110022 RVA: 0x003E94B1 File Offset: 0x003E76B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PsgPlayerIds
		{
			get
			{
				return this.psgPlayerIds_;
			}
		}

		// Token: 0x17005AF6 RID: 23286
		// (get) Token: 0x0601ADC7 RID: 110023 RVA: 0x003E94B9 File Offset: 0x003E76B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> PsgEntityIds
		{
			get
			{
				return this.psgEntityIds_;
			}
		}

		// Token: 0x17005AF7 RID: 23287
		// (get) Token: 0x0601ADC8 RID: 110024 RVA: 0x003E94C1 File Offset: 0x003E76C1
		// (set) Token: 0x0601ADC9 RID: 110025 RVA: 0x003E94C9 File Offset: 0x003E76C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Vehicle
		{
			get
			{
				return this.vehicle_;
			}
			set
			{
				this.vehicle_ = value;
			}
		}

		// Token: 0x17005AF8 RID: 23288
		// (get) Token: 0x0601ADCA RID: 110026 RVA: 0x003E94D2 File Offset: 0x003E76D2
		// (set) Token: 0x0601ADCB RID: 110027 RVA: 0x003E94DA File Offset: 0x003E76DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NoLoading
		{
			get
			{
				return this.noLoading_;
			}
			set
			{
				this.noLoading_ = value;
			}
		}

		// Token: 0x17005AF9 RID: 23289
		// (get) Token: 0x0601ADCC RID: 110028 RVA: 0x003E94E3 File Offset: 0x003E76E3
		// (set) Token: 0x0601ADCD RID: 110029 RVA: 0x003E94EB File Offset: 0x003E76EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionOptionPb TransitionOption
		{
			get
			{
				return this.transitionOption_;
			}
			set
			{
				this.transitionOption_ = value;
			}
		}

		// Token: 0x0601ADCE RID: 110030 RVA: 0x003E94F4 File Offset: 0x003E76F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportVehicleNotify);
		}

		// Token: 0x0601ADCF RID: 110031 RVA: 0x003E9504 File Offset: 0x003E7704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportVehicleNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && this.Reason == other.Reason && this.psgPlayerIds_.Equals(other.psgPlayerIds_) && this.psgEntityIds_.Equals(other.psgEntityIds_) && this.Vehicle == other.Vehicle && this.NoLoading == other.NoLoading && object.Equals(this.TransitionOption, other.TransitionOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ADD0 RID: 110032 RVA: 0x003E95C8 File Offset: 0x003E77C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this.Reason != TeleportReason.Transfer)
			{
				num ^= this.Reason.GetHashCode();
			}
			num ^= this.psgPlayerIds_.GetHashCode();
			num ^= this.psgEntityIds_.GetHashCode();
			if (this.Vehicle != 0L)
			{
				num ^= this.Vehicle.GetHashCode();
			}
			if (this.NoLoading)
			{
				num ^= this.NoLoading.GetHashCode();
			}
			if (this.transitionOption_ != null)
			{
				num ^= this.TransitionOption.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ADD1 RID: 110033 RVA: 0x003E969D File Offset: 0x003E789D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ADD2 RID: 110034 RVA: 0x003E96AA File Offset: 0x003E78AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ADD3 RID: 110035 RVA: 0x003E96B4 File Offset: 0x003E78B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != TeleportReason.Transfer)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Reason);
			}
			if (this.Vehicle != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.Vehicle);
			}
			if (this.transitionOption_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.TransitionOption);
			}
			if (this.NoLoading)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.NoLoading);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Rotation);
			}
			this.psgEntityIds_.WriteTo(ref output, TeleportVehicleNotify._repeated_psgEntityIds_codec);
			if (this.location_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Location);
			}
			this.psgPlayerIds_.WriteTo(ref output, TeleportVehicleNotify._repeated_psgPlayerIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ADD4 RID: 110036 RVA: 0x003E97A0 File Offset: 0x003E79A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this.Reason != TeleportReason.Transfer)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			num += this.psgPlayerIds_.CalculateSize(TeleportVehicleNotify._repeated_psgPlayerIds_codec);
			num += this.psgEntityIds_.CalculateSize(TeleportVehicleNotify._repeated_psgEntityIds_codec);
			if (this.Vehicle != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Vehicle);
			}
			if (this.NoLoading)
			{
				num += 2;
			}
			if (this.transitionOption_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransitionOption);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ADD5 RID: 110037 RVA: 0x003E9870 File Offset: 0x003E7A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportVehicleNotify other)
		{
			if (other == null)
			{
				return;
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
			if (other.Reason != TeleportReason.Transfer)
			{
				this.Reason = other.Reason;
			}
			this.psgPlayerIds_.Add(other.psgPlayerIds_);
			this.psgEntityIds_.Add(other.psgEntityIds_);
			if (other.Vehicle != 0L)
			{
				this.Vehicle = other.Vehicle;
			}
			if (other.NoLoading)
			{
				this.NoLoading = other.NoLoading;
			}
			if (other.transitionOption_ != null)
			{
				if (this.transitionOption_ == null)
				{
					this.TransitionOption = new TransitionOptionPb();
				}
				this.TransitionOption.MergeFrom(other.TransitionOption);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ADD6 RID: 110038 RVA: 0x003E997A File Offset: 0x003E7B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ADD7 RID: 110039 RVA: 0x003E9984 File Offset: 0x003E7B84
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
				if (num <= 66U)
				{
					if (num <= 32U)
					{
						if (num == 24U)
						{
							this.Reason = (TeleportReason)input.ReadEnum();
							continue;
						}
						if (num == 32U)
						{
							this.Vehicle = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 42U)
						{
							if (this.transitionOption_ == null)
							{
								this.TransitionOption = new TransitionOptionPb();
							}
							input.ReadMessage(this.TransitionOption);
							continue;
						}
						if (num == 56U)
						{
							this.NoLoading = input.ReadBool();
							continue;
						}
						if (num == 66U)
						{
							if (this.rotation_ == null)
							{
								this.Rotation = new Rotator();
							}
							input.ReadMessage(this.Rotation);
							continue;
						}
					}
				}
				else if (num <= 82U)
				{
					if (num == 80U || num == 82U)
					{
						this.psgEntityIds_.AddEntriesFrom(ref input, TeleportVehicleNotify._repeated_psgEntityIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
						continue;
					}
					if (num == 112U || num == 114U)
					{
						this.psgPlayerIds_.AddEntriesFrom(ref input, TeleportVehicleNotify._repeated_psgPlayerIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009D14 RID: 40212
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D15 RID: 40213
		public const int LocationFieldNumber = 13;

		// Token: 0x04009D16 RID: 40214
		private Vector location_;

		// Token: 0x04009D17 RID: 40215
		public const int RotationFieldNumber = 8;

		// Token: 0x04009D18 RID: 40216
		private Rotator rotation_;

		// Token: 0x04009D19 RID: 40217
		public const int ReasonFieldNumber = 3;

		// Token: 0x04009D1A RID: 40218
		private TeleportReason reason_;

		// Token: 0x04009D1B RID: 40219
		public const int PsgPlayerIdsFieldNumber = 14;

		// Token: 0x04009D1C RID: 40220
		private static readonly FieldCodec<int> _repeated_psgPlayerIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04009D1D RID: 40221
		private readonly RepeatedField<int> psgPlayerIds_ = new RepeatedField<int>();

		// Token: 0x04009D1E RID: 40222
		public const int PsgEntityIdsFieldNumber = 10;

		// Token: 0x04009D1F RID: 40223
		private static readonly FieldCodec<long> _repeated_psgEntityIds_codec = FieldCodec.ForInt64(82U);

		// Token: 0x04009D20 RID: 40224
		private readonly RepeatedField<long> psgEntityIds_ = new RepeatedField<long>();

		// Token: 0x04009D21 RID: 40225
		public const int VehicleFieldNumber = 4;

		// Token: 0x04009D22 RID: 40226
		private long vehicle_;

		// Token: 0x04009D23 RID: 40227
		public const int NoLoadingFieldNumber = 7;

		// Token: 0x04009D24 RID: 40228
		private bool noLoading_;

		// Token: 0x04009D25 RID: 40229
		public const int TransitionOptionFieldNumber = 5;

		// Token: 0x04009D26 RID: 40230
		private TransitionOptionPb transitionOption_;
	}
}
