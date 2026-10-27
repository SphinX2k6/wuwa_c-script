using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001100 RID: 4352
	public sealed class RoverRogueGetOrLoseData : IMessage<RoverRogueGetOrLoseData>, IMessage, IEquatable<RoverRogueGetOrLoseData>, IDeepCloneable<RoverRogueGetOrLoseData>, IBufferMessage
	{
		// Token: 0x06017351 RID: 95057 RVA: 0x0035E4F7 File Offset: 0x0035C6F7
		[NullableContext(1)]
		public static RoverRogueGetOrLoseData Create()
		{
			return new RoverRogueGetOrLoseData();
		}

		// Token: 0x17004DC6 RID: 19910
		// (get) Token: 0x06017352 RID: 95058 RVA: 0x0035E4FE File Offset: 0x0035C6FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueGetOrLoseData> Parser
		{
			get
			{
				return RoverRogueGetOrLoseData._parser;
			}
		}

		// Token: 0x17004DC7 RID: 19911
		// (get) Token: 0x06017353 RID: 95059 RVA: 0x0035E505 File Offset: 0x0035C705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DC8 RID: 19912
		// (get) Token: 0x06017354 RID: 95060 RVA: 0x0035E508 File Offset: 0x0035C708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueGetOrLoseData.Descriptor;
			}
		}

		// Token: 0x06017355 RID: 95061 RVA: 0x0035E50F File Offset: 0x0035C70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGetOrLoseData()
		{
		}

		// Token: 0x06017356 RID: 95062 RVA: 0x0035E530 File Offset: 0x0035C730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGetOrLoseData(RoverRogueGetOrLoseData other) : this()
		{
			this.effectId_ = other.effectId_;
			this.roverRogueGainEntryIncIdGet_ = other.roverRogueGainEntryIncIdGet_.Clone();
			this.roverRogueGainEntryIncIdLose_ = other.roverRogueGainEntryIncIdLose_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017357 RID: 95063 RVA: 0x0035E582 File Offset: 0x0035C782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGetOrLoseData Clone()
		{
			return new RoverRogueGetOrLoseData(this);
		}

		// Token: 0x17004DC9 RID: 19913
		// (get) Token: 0x06017358 RID: 95064 RVA: 0x0035E58A File Offset: 0x0035C78A
		// (set) Token: 0x06017359 RID: 95065 RVA: 0x0035E592 File Offset: 0x0035C792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EffectId
		{
			get
			{
				return this.effectId_;
			}
			set
			{
				this.effectId_ = value;
			}
		}

		// Token: 0x17004DCA RID: 19914
		// (get) Token: 0x0601735A RID: 95066 RVA: 0x0035E59B File Offset: 0x0035C79B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> RoverRogueGainEntryIncIdGet
		{
			get
			{
				return this.roverRogueGainEntryIncIdGet_;
			}
		}

		// Token: 0x17004DCB RID: 19915
		// (get) Token: 0x0601735B RID: 95067 RVA: 0x0035E5A3 File Offset: 0x0035C7A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> RoverRogueGainEntryIncIdLose
		{
			get
			{
				return this.roverRogueGainEntryIncIdLose_;
			}
		}

		// Token: 0x0601735C RID: 95068 RVA: 0x0035E5AB File Offset: 0x0035C7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueGetOrLoseData);
		}

		// Token: 0x0601735D RID: 95069 RVA: 0x0035E5BC File Offset: 0x0035C7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueGetOrLoseData other)
		{
			return other != null && (other == this || (this.EffectId == other.EffectId && this.roverRogueGainEntryIncIdGet_.Equals(other.roverRogueGainEntryIncIdGet_) && this.roverRogueGainEntryIncIdLose_.Equals(other.roverRogueGainEntryIncIdLose_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601735E RID: 95070 RVA: 0x0035E620 File Offset: 0x0035C820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EffectId != 0)
			{
				num ^= this.EffectId.GetHashCode();
			}
			num ^= this.roverRogueGainEntryIncIdGet_.GetHashCode();
			num ^= this.roverRogueGainEntryIncIdLose_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601735F RID: 95071 RVA: 0x0035E67B File Offset: 0x0035C87B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017360 RID: 95072 RVA: 0x0035E688 File Offset: 0x0035C888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017361 RID: 95073 RVA: 0x0035E694 File Offset: 0x0035C894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EffectId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EffectId);
			}
			this.roverRogueGainEntryIncIdGet_.WriteTo(ref output, RoverRogueGetOrLoseData._repeated_roverRogueGainEntryIncIdGet_codec);
			this.roverRogueGainEntryIncIdLose_.WriteTo(ref output, RoverRogueGetOrLoseData._repeated_roverRogueGainEntryIncIdLose_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017362 RID: 95074 RVA: 0x0035E6F4 File Offset: 0x0035C8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EffectId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EffectId);
			}
			num += this.roverRogueGainEntryIncIdGet_.CalculateSize(RoverRogueGetOrLoseData._repeated_roverRogueGainEntryIncIdGet_codec);
			num += this.roverRogueGainEntryIncIdLose_.CalculateSize(RoverRogueGetOrLoseData._repeated_roverRogueGainEntryIncIdLose_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017363 RID: 95075 RVA: 0x0035E758 File Offset: 0x0035C958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueGetOrLoseData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EffectId != 0)
			{
				this.EffectId = other.EffectId;
			}
			this.roverRogueGainEntryIncIdGet_.Add(other.roverRogueGainEntryIncIdGet_);
			this.roverRogueGainEntryIncIdLose_.Add(other.roverRogueGainEntryIncIdLose_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017364 RID: 95076 RVA: 0x0035E7B6 File Offset: 0x0035C9B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017365 RID: 95077 RVA: 0x0035E7C0 File Offset: 0x0035C9C0
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
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.roverRogueGainEntryIncIdLose_.AddEntriesFrom(ref input, RoverRogueGetOrLoseData._repeated_roverRogueGainEntryIncIdLose_codec);
						}
					}
					else
					{
						this.roverRogueGainEntryIncIdGet_.AddEntriesFrom(ref input, RoverRogueGetOrLoseData._repeated_roverRogueGainEntryIncIdGet_codec);
					}
				}
				else
				{
					this.EffectId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008A06 RID: 35334
		private static readonly MessageParser<RoverRogueGetOrLoseData> _parser = new MessageParser<RoverRogueGetOrLoseData>(() => new RoverRogueGetOrLoseData());

		// Token: 0x04008A07 RID: 35335
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A08 RID: 35336
		public const int EffectIdFieldNumber = 1;

		// Token: 0x04008A09 RID: 35337
		private int effectId_;

		// Token: 0x04008A0A RID: 35338
		public const int RoverRogueGainEntryIncIdGetFieldNumber = 2;

		// Token: 0x04008A0B RID: 35339
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_roverRogueGainEntryIncIdGet_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(18U, RoverRogueGainEntry.Parser);

		// Token: 0x04008A0C RID: 35340
		private readonly RepeatedField<RoverRogueGainEntry> roverRogueGainEntryIncIdGet_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008A0D RID: 35341
		public const int RoverRogueGainEntryIncIdLoseFieldNumber = 3;

		// Token: 0x04008A0E RID: 35342
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_roverRogueGainEntryIncIdLose_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(26U, RoverRogueGainEntry.Parser);

		// Token: 0x04008A0F RID: 35343
		private readonly RepeatedField<RoverRogueGainEntry> roverRogueGainEntryIncIdLose_ = new RepeatedField<RoverRogueGainEntry>();
	}
}
