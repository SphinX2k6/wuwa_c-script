using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001344 RID: 4932
	[NetMessage(EMessageId.TeleportVehicleNotify)]
	public sealed class TeleportVehicleNotify : IMessage<TeleportVehicleNotify>, IMessage, IEquatable<TeleportVehicleNotify>, IDeepCloneable<TeleportVehicleNotify>, IBufferMessage
	{
		// Token: 0x0601A333 RID: 107315 RVA: 0x003CE25D File Offset: 0x003CC45D
		[NullableContext(1)]
		public static TeleportVehicleNotify Create()
		{
			return new TeleportVehicleNotify();
		}

		// Token: 0x1700585D RID: 22621
		// (get) Token: 0x0601A334 RID: 107316 RVA: 0x003CE264 File Offset: 0x003CC464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700585E RID: 22622
		// (get) Token: 0x0601A335 RID: 107317 RVA: 0x003CE267 File Offset: 0x003CC467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportVehicleNotify.Descriptor;
			}
		}

		// Token: 0x0601A336 RID: 107318 RVA: 0x003CE26E File Offset: 0x003CC46E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportVehicleNotify()
		{
		}

		// Token: 0x0601A337 RID: 107319 RVA: 0x003CE28C File Offset: 0x003CC48C
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

		// Token: 0x0601A338 RID: 107320 RVA: 0x003CE34A File Offset: 0x003CC54A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportVehicleNotify Clone()
		{
			return new TeleportVehicleNotify(this);
		}

		// Token: 0x1700585F RID: 22623
		// (get) Token: 0x0601A339 RID: 107321 RVA: 0x003CE352 File Offset: 0x003CC552
		// (set) Token: 0x0601A33A RID: 107322 RVA: 0x003CE35A File Offset: 0x003CC55A
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

		// Token: 0x17005860 RID: 22624
		// (get) Token: 0x0601A33B RID: 107323 RVA: 0x003CE363 File Offset: 0x003CC563
		// (set) Token: 0x0601A33C RID: 107324 RVA: 0x003CE36B File Offset: 0x003CC56B
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

		// Token: 0x17005861 RID: 22625
		// (get) Token: 0x0601A33D RID: 107325 RVA: 0x003CE374 File Offset: 0x003CC574
		// (set) Token: 0x0601A33E RID: 107326 RVA: 0x003CE37C File Offset: 0x003CC57C
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

		// Token: 0x17005862 RID: 22626
		// (get) Token: 0x0601A33F RID: 107327 RVA: 0x003CE385 File Offset: 0x003CC585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PsgPlayerIds
		{
			get
			{
				return this.psgPlayerIds_;
			}
		}

		// Token: 0x17005863 RID: 22627
		// (get) Token: 0x0601A340 RID: 107328 RVA: 0x003CE38D File Offset: 0x003CC58D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> PsgEntityIds
		{
			get
			{
				return this.psgEntityIds_;
			}
		}

		// Token: 0x17005864 RID: 22628
		// (get) Token: 0x0601A341 RID: 107329 RVA: 0x003CE395 File Offset: 0x003CC595
		// (set) Token: 0x0601A342 RID: 107330 RVA: 0x003CE39D File Offset: 0x003CC59D
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

		// Token: 0x17005865 RID: 22629
		// (get) Token: 0x0601A343 RID: 107331 RVA: 0x003CE3A6 File Offset: 0x003CC5A6
		// (set) Token: 0x0601A344 RID: 107332 RVA: 0x003CE3AE File Offset: 0x003CC5AE
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

		// Token: 0x17005866 RID: 22630
		// (get) Token: 0x0601A345 RID: 107333 RVA: 0x003CE3B7 File Offset: 0x003CC5B7
		// (set) Token: 0x0601A346 RID: 107334 RVA: 0x003CE3BF File Offset: 0x003CC5BF
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

		// Token: 0x0601A347 RID: 107335 RVA: 0x003CE3C8 File Offset: 0x003CC5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportVehicleNotify);
		}

		// Token: 0x0601A348 RID: 107336 RVA: 0x003CE3D8 File Offset: 0x003CC5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportVehicleNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && this.Reason == other.Reason && this.psgPlayerIds_.Equals(other.psgPlayerIds_) && this.psgEntityIds_.Equals(other.psgEntityIds_) && this.Vehicle == other.Vehicle && this.NoLoading == other.NoLoading && object.Equals(this.TransitionOption, other.TransitionOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A349 RID: 107337 RVA: 0x003CE49C File Offset: 0x003CC69C
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

		// Token: 0x0601A34A RID: 107338 RVA: 0x003CE571 File Offset: 0x003CC771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A34B RID: 107339 RVA: 0x003CE57E File Offset: 0x003CC77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A34C RID: 107340 RVA: 0x003CE588 File Offset: 0x003CC788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.psgEntityIds_.WriteTo(ref output, TeleportVehicleNotify._repeated_psgEntityIds_codec);
			if (this.rotation_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Rotation);
			}
			if (this.transitionOption_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.TransitionOption);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Location);
			}
			if (this.Vehicle != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.Vehicle);
			}
			this.psgPlayerIds_.WriteTo(ref output, TeleportVehicleNotify._repeated_psgPlayerIds_codec);
			if (this.Reason != TeleportReason.Transfer)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Reason);
			}
			if (this.NoLoading)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.NoLoading);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A34D RID: 107341 RVA: 0x003CE674 File Offset: 0x003CC874
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

		// Token: 0x0601A34E RID: 107342 RVA: 0x003CE744 File Offset: 0x003CC944
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

		// Token: 0x0601A34F RID: 107343 RVA: 0x003CE84E File Offset: 0x003CCA4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A350 RID: 107344 RVA: 0x003CE858 File Offset: 0x003CCA58
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
				if (num > 50U)
				{
					if (num <= 88U)
					{
						if (num == 72U)
						{
							this.Vehicle = input.ReadInt64();
							continue;
						}
						if (num != 88U)
						{
							goto IL_67;
						}
					}
					else if (num != 90U)
					{
						if (num == 104U)
						{
							this.Reason = (TeleportReason)input.ReadEnum();
							continue;
						}
						if (num != 120U)
						{
							goto IL_67;
						}
						this.NoLoading = input.ReadBool();
						continue;
					}
					this.psgPlayerIds_.AddEntriesFrom(ref input, TeleportVehicleNotify._repeated_psgPlayerIds_codec);
					continue;
				}
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.psgEntityIds_.AddEntriesFrom(ref input, TeleportVehicleNotify._repeated_psgEntityIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Rotator();
						}
						input.ReadMessage(this.Rotation);
						continue;
					}
					if (num == 42U)
					{
						if (this.transitionOption_ == null)
						{
							this.TransitionOption = new TransitionOptionPb();
						}
						input.ReadMessage(this.TransitionOption);
						continue;
					}
					if (num == 50U)
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
						continue;
					}
				}
				IL_67:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040098D2 RID: 39122
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098D3 RID: 39123
		public const int LocationFieldNumber = 6;

		// Token: 0x040098D4 RID: 39124
		private Vector location_;

		// Token: 0x040098D5 RID: 39125
		public const int RotationFieldNumber = 3;

		// Token: 0x040098D6 RID: 39126
		private Rotator rotation_;

		// Token: 0x040098D7 RID: 39127
		public const int ReasonFieldNumber = 13;

		// Token: 0x040098D8 RID: 39128
		private TeleportReason reason_;

		// Token: 0x040098D9 RID: 39129
		public const int PsgPlayerIdsFieldNumber = 11;

		// Token: 0x040098DA RID: 39130
		private static readonly FieldCodec<int> _repeated_psgPlayerIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x040098DB RID: 39131
		private readonly RepeatedField<int> psgPlayerIds_ = new RepeatedField<int>();

		// Token: 0x040098DC RID: 39132
		public const int PsgEntityIdsFieldNumber = 1;

		// Token: 0x040098DD RID: 39133
		private static readonly FieldCodec<long> _repeated_psgEntityIds_codec = FieldCodec.ForInt64(10U);

		// Token: 0x040098DE RID: 39134
		private readonly RepeatedField<long> psgEntityIds_ = new RepeatedField<long>();

		// Token: 0x040098DF RID: 39135
		public const int VehicleFieldNumber = 9;

		// Token: 0x040098E0 RID: 39136
		private long vehicle_;

		// Token: 0x040098E1 RID: 39137
		public const int NoLoadingFieldNumber = 15;

		// Token: 0x040098E2 RID: 39138
		private bool noLoading_;

		// Token: 0x040098E3 RID: 39139
		public const int TransitionOptionFieldNumber = 5;

		// Token: 0x040098E4 RID: 39140
		private TransitionOptionPb transitionOption_;
	}
}
