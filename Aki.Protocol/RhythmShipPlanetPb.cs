using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F4B RID: 3915
	public sealed class RhythmShipPlanetPb : IMessage<RhythmShipPlanetPb>, IMessage, IEquatable<RhythmShipPlanetPb>, IDeepCloneable<RhythmShipPlanetPb>, IBufferMessage
	{
		// Token: 0x06014F22 RID: 85794 RVA: 0x0030A009 File Offset: 0x00308209
		[NullableContext(1)]
		public static RhythmShipPlanetPb Create()
		{
			return new RhythmShipPlanetPb();
		}

		// Token: 0x170045AA RID: 17834
		// (get) Token: 0x06014F23 RID: 85795 RVA: 0x0030A010 File Offset: 0x00308210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RhythmShipPlanetPb> Parser
		{
			get
			{
				return RhythmShipPlanetPb._parser;
			}
		}

		// Token: 0x170045AB RID: 17835
		// (get) Token: 0x06014F24 RID: 85796 RVA: 0x0030A017 File Offset: 0x00308217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045AC RID: 17836
		// (get) Token: 0x06014F25 RID: 85797 RVA: 0x0030A01A File Offset: 0x0030821A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmShipPlanetPb.Descriptor;
			}
		}

		// Token: 0x06014F26 RID: 85798 RVA: 0x0030A021 File Offset: 0x00308221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipPlanetPb()
		{
		}

		// Token: 0x06014F27 RID: 85799 RVA: 0x0030A034 File Offset: 0x00308234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipPlanetPb(RhythmShipPlanetPb other) : this()
		{
			this.planetId_ = other.planetId_;
			this.openTime_ = other.openTime_;
			this.rhythmShipLevelPb_ = other.rhythmShipLevelPb_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014F28 RID: 85800 RVA: 0x0030A081 File Offset: 0x00308281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipPlanetPb Clone()
		{
			return new RhythmShipPlanetPb(this);
		}

		// Token: 0x170045AD RID: 17837
		// (get) Token: 0x06014F29 RID: 85801 RVA: 0x0030A089 File Offset: 0x00308289
		// (set) Token: 0x06014F2A RID: 85802 RVA: 0x0030A091 File Offset: 0x00308291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlanetId
		{
			get
			{
				return this.planetId_;
			}
			set
			{
				this.planetId_ = value;
			}
		}

		// Token: 0x170045AE RID: 17838
		// (get) Token: 0x06014F2B RID: 85803 RVA: 0x0030A09A File Offset: 0x0030829A
		// (set) Token: 0x06014F2C RID: 85804 RVA: 0x0030A0A2 File Offset: 0x003082A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OpenTime
		{
			get
			{
				return this.openTime_;
			}
			set
			{
				this.openTime_ = value;
			}
		}

		// Token: 0x170045AF RID: 17839
		// (get) Token: 0x06014F2D RID: 85805 RVA: 0x0030A0AB File Offset: 0x003082AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RhythmShipLevelPb> RhythmShipLevelPb
		{
			get
			{
				return this.rhythmShipLevelPb_;
			}
		}

		// Token: 0x06014F2E RID: 85806 RVA: 0x0030A0B3 File Offset: 0x003082B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmShipPlanetPb);
		}

		// Token: 0x06014F2F RID: 85807 RVA: 0x0030A0C4 File Offset: 0x003082C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmShipPlanetPb other)
		{
			return other != null && (other == this || (this.PlanetId == other.PlanetId && this.OpenTime == other.OpenTime && this.rhythmShipLevelPb_.Equals(other.rhythmShipLevelPb_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014F30 RID: 85808 RVA: 0x0030A124 File Offset: 0x00308324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlanetId != 0)
			{
				num ^= this.PlanetId.GetHashCode();
			}
			if (this.OpenTime != 0L)
			{
				num ^= this.OpenTime.GetHashCode();
			}
			num ^= this.rhythmShipLevelPb_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014F31 RID: 85809 RVA: 0x0030A18A File Offset: 0x0030838A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014F32 RID: 85810 RVA: 0x0030A197 File Offset: 0x00308397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014F33 RID: 85811 RVA: 0x0030A1A0 File Offset: 0x003083A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlanetId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlanetId);
			}
			if (this.OpenTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.OpenTime);
			}
			this.rhythmShipLevelPb_.WriteTo(ref output, RhythmShipPlanetPb._repeated_rhythmShipLevelPb_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014F34 RID: 85812 RVA: 0x0030A20C File Offset: 0x0030840C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlanetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlanetId);
			}
			if (this.OpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OpenTime);
			}
			num += this.rhythmShipLevelPb_.CalculateSize(RhythmShipPlanetPb._repeated_rhythmShipLevelPb_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014F35 RID: 85813 RVA: 0x0030A278 File Offset: 0x00308478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmShipPlanetPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlanetId != 0)
			{
				this.PlanetId = other.PlanetId;
			}
			if (other.OpenTime != 0L)
			{
				this.OpenTime = other.OpenTime;
			}
			this.rhythmShipLevelPb_.Add(other.rhythmShipLevelPb_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014F36 RID: 85814 RVA: 0x0030A2D9 File Offset: 0x003084D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014F37 RID: 85815 RVA: 0x0030A2E4 File Offset: 0x003084E4
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.rhythmShipLevelPb_.AddEntriesFrom(ref input, RhythmShipPlanetPb._repeated_rhythmShipLevelPb_codec);
						}
					}
					else
					{
						this.OpenTime = input.ReadInt64();
					}
				}
				else
				{
					this.PlanetId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007E4B RID: 32331
		private static readonly MessageParser<RhythmShipPlanetPb> _parser = new MessageParser<RhythmShipPlanetPb>(() => new RhythmShipPlanetPb());

		// Token: 0x04007E4C RID: 32332
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E4D RID: 32333
		public const int PlanetIdFieldNumber = 1;

		// Token: 0x04007E4E RID: 32334
		private int planetId_;

		// Token: 0x04007E4F RID: 32335
		public const int OpenTimeFieldNumber = 2;

		// Token: 0x04007E50 RID: 32336
		private long openTime_;

		// Token: 0x04007E51 RID: 32337
		public const int RhythmShipLevelPbFieldNumber = 3;

		// Token: 0x04007E52 RID: 32338
		private static readonly FieldCodec<RhythmShipLevelPb> _repeated_rhythmShipLevelPb_codec = FieldCodec.ForMessage<RhythmShipLevelPb>(26U, Aki.Protocol.RhythmShipLevelPb.Parser);

		// Token: 0x04007E53 RID: 32339
		private readonly RepeatedField<RhythmShipLevelPb> rhythmShipLevelPb_ = new RepeatedField<RhythmShipLevelPb>();
	}
}
