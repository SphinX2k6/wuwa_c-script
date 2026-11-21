using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F3B RID: 3899
	public sealed class RhythmShipPlanetPb : IMessage<RhythmShipPlanetPb>, IMessage, IEquatable<RhythmShipPlanetPb>, IDeepCloneable<RhythmShipPlanetPb>, IBufferMessage
	{
		// Token: 0x06014E3D RID: 85565 RVA: 0x0030894D File Offset: 0x00306B4D
		[NullableContext(1)]
		public static RhythmShipPlanetPb Create()
		{
			return new RhythmShipPlanetPb();
		}

		// Token: 0x17004580 RID: 17792
		// (get) Token: 0x06014E3E RID: 85566 RVA: 0x00308954 File Offset: 0x00306B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RhythmShipPlanetPb> Parser
		{
			get
			{
				return RhythmShipPlanetPb._parser;
			}
		}

		// Token: 0x17004581 RID: 17793
		// (get) Token: 0x06014E3F RID: 85567 RVA: 0x0030895B File Offset: 0x00306B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004582 RID: 17794
		// (get) Token: 0x06014E40 RID: 85568 RVA: 0x0030895E File Offset: 0x00306B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmShipPlanetPb.Descriptor;
			}
		}

		// Token: 0x06014E41 RID: 85569 RVA: 0x00308965 File Offset: 0x00306B65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipPlanetPb()
		{
		}

		// Token: 0x06014E42 RID: 85570 RVA: 0x00308978 File Offset: 0x00306B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipPlanetPb(RhythmShipPlanetPb other) : this()
		{
			this.planetId_ = other.planetId_;
			this.openTime_ = other.openTime_;
			this.rhythmShipLevelPb_ = other.rhythmShipLevelPb_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014E43 RID: 85571 RVA: 0x003089C5 File Offset: 0x00306BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipPlanetPb Clone()
		{
			return new RhythmShipPlanetPb(this);
		}

		// Token: 0x17004583 RID: 17795
		// (get) Token: 0x06014E44 RID: 85572 RVA: 0x003089CD File Offset: 0x00306BCD
		// (set) Token: 0x06014E45 RID: 85573 RVA: 0x003089D5 File Offset: 0x00306BD5
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

		// Token: 0x17004584 RID: 17796
		// (get) Token: 0x06014E46 RID: 85574 RVA: 0x003089DE File Offset: 0x00306BDE
		// (set) Token: 0x06014E47 RID: 85575 RVA: 0x003089E6 File Offset: 0x00306BE6
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

		// Token: 0x17004585 RID: 17797
		// (get) Token: 0x06014E48 RID: 85576 RVA: 0x003089EF File Offset: 0x00306BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RhythmShipLevelPb> RhythmShipLevelPb
		{
			get
			{
				return this.rhythmShipLevelPb_;
			}
		}

		// Token: 0x06014E49 RID: 85577 RVA: 0x003089F7 File Offset: 0x00306BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmShipPlanetPb);
		}

		// Token: 0x06014E4A RID: 85578 RVA: 0x00308A08 File Offset: 0x00306C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmShipPlanetPb other)
		{
			return other != null && (other == this || (this.PlanetId == other.PlanetId && this.OpenTime == other.OpenTime && this.rhythmShipLevelPb_.Equals(other.rhythmShipLevelPb_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014E4B RID: 85579 RVA: 0x00308A68 File Offset: 0x00306C68
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

		// Token: 0x06014E4C RID: 85580 RVA: 0x00308ACE File Offset: 0x00306CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014E4D RID: 85581 RVA: 0x00308ADB File Offset: 0x00306CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014E4E RID: 85582 RVA: 0x00308AE4 File Offset: 0x00306CE4
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

		// Token: 0x06014E4F RID: 85583 RVA: 0x00308B50 File Offset: 0x00306D50
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

		// Token: 0x06014E50 RID: 85584 RVA: 0x00308BBC File Offset: 0x00306DBC
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

		// Token: 0x06014E51 RID: 85585 RVA: 0x00308C1D File Offset: 0x00306E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014E52 RID: 85586 RVA: 0x00308C28 File Offset: 0x00306E28
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

		// Token: 0x04007E75 RID: 32373
		private static readonly MessageParser<RhythmShipPlanetPb> _parser = new MessageParser<RhythmShipPlanetPb>(() => new RhythmShipPlanetPb());

		// Token: 0x04007E76 RID: 32374
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E77 RID: 32375
		public const int PlanetIdFieldNumber = 1;

		// Token: 0x04007E78 RID: 32376
		private int planetId_;

		// Token: 0x04007E79 RID: 32377
		public const int OpenTimeFieldNumber = 2;

		// Token: 0x04007E7A RID: 32378
		private long openTime_;

		// Token: 0x04007E7B RID: 32379
		public const int RhythmShipLevelPbFieldNumber = 3;

		// Token: 0x04007E7C RID: 32380
		private static readonly FieldCodec<RhythmShipLevelPb> _repeated_rhythmShipLevelPb_codec = FieldCodec.ForMessage<RhythmShipLevelPb>(26U, Aki.Protocol.RhythmShipLevelPb.Parser);

		// Token: 0x04007E7D RID: 32381
		private readonly RepeatedField<RhythmShipLevelPb> rhythmShipLevelPb_ = new RepeatedField<RhythmShipLevelPb>();
	}
}
