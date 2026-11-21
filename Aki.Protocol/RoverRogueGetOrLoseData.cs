using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200113A RID: 4410
	public sealed class RoverRogueGetOrLoseData : IMessage<RoverRogueGetOrLoseData>, IMessage, IEquatable<RoverRogueGetOrLoseData>, IDeepCloneable<RoverRogueGetOrLoseData>, IBufferMessage
	{
		// Token: 0x060178F2 RID: 96498 RVA: 0x0036D84B File Offset: 0x0036BA4B
		[NullableContext(1)]
		public static RoverRogueGetOrLoseData Create()
		{
			return new RoverRogueGetOrLoseData();
		}

		// Token: 0x17004F32 RID: 20274
		// (get) Token: 0x060178F3 RID: 96499 RVA: 0x0036D852 File Offset: 0x0036BA52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueGetOrLoseData> Parser
		{
			get
			{
				return RoverRogueGetOrLoseData._parser;
			}
		}

		// Token: 0x17004F33 RID: 20275
		// (get) Token: 0x060178F4 RID: 96500 RVA: 0x0036D859 File Offset: 0x0036BA59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F34 RID: 20276
		// (get) Token: 0x060178F5 RID: 96501 RVA: 0x0036D85C File Offset: 0x0036BA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueGetOrLoseData.Descriptor;
			}
		}

		// Token: 0x060178F6 RID: 96502 RVA: 0x0036D863 File Offset: 0x0036BA63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGetOrLoseData()
		{
		}

		// Token: 0x060178F7 RID: 96503 RVA: 0x0036D884 File Offset: 0x0036BA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGetOrLoseData(RoverRogueGetOrLoseData other) : this()
		{
			this.effectId_ = other.effectId_;
			this.roverRogueGainEntryIncIdGet_ = other.roverRogueGainEntryIncIdGet_.Clone();
			this.roverRogueGainEntryIncIdLose_ = other.roverRogueGainEntryIncIdLose_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060178F8 RID: 96504 RVA: 0x0036D8D6 File Offset: 0x0036BAD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGetOrLoseData Clone()
		{
			return new RoverRogueGetOrLoseData(this);
		}

		// Token: 0x17004F35 RID: 20277
		// (get) Token: 0x060178F9 RID: 96505 RVA: 0x0036D8DE File Offset: 0x0036BADE
		// (set) Token: 0x060178FA RID: 96506 RVA: 0x0036D8E6 File Offset: 0x0036BAE6
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

		// Token: 0x17004F36 RID: 20278
		// (get) Token: 0x060178FB RID: 96507 RVA: 0x0036D8EF File Offset: 0x0036BAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> RoverRogueGainEntryIncIdGet
		{
			get
			{
				return this.roverRogueGainEntryIncIdGet_;
			}
		}

		// Token: 0x17004F37 RID: 20279
		// (get) Token: 0x060178FC RID: 96508 RVA: 0x0036D8F7 File Offset: 0x0036BAF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> RoverRogueGainEntryIncIdLose
		{
			get
			{
				return this.roverRogueGainEntryIncIdLose_;
			}
		}

		// Token: 0x060178FD RID: 96509 RVA: 0x0036D8FF File Offset: 0x0036BAFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueGetOrLoseData);
		}

		// Token: 0x060178FE RID: 96510 RVA: 0x0036D910 File Offset: 0x0036BB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueGetOrLoseData other)
		{
			return other != null && (other == this || (this.EffectId == other.EffectId && this.roverRogueGainEntryIncIdGet_.Equals(other.roverRogueGainEntryIncIdGet_) && this.roverRogueGainEntryIncIdLose_.Equals(other.roverRogueGainEntryIncIdLose_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060178FF RID: 96511 RVA: 0x0036D974 File Offset: 0x0036BB74
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

		// Token: 0x06017900 RID: 96512 RVA: 0x0036D9CF File Offset: 0x0036BBCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017901 RID: 96513 RVA: 0x0036D9DC File Offset: 0x0036BBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017902 RID: 96514 RVA: 0x0036D9E8 File Offset: 0x0036BBE8
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

		// Token: 0x06017903 RID: 96515 RVA: 0x0036DA48 File Offset: 0x0036BC48
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

		// Token: 0x06017904 RID: 96516 RVA: 0x0036DAAC File Offset: 0x0036BCAC
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

		// Token: 0x06017905 RID: 96517 RVA: 0x0036DB0A File Offset: 0x0036BD0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017906 RID: 96518 RVA: 0x0036DB14 File Offset: 0x0036BD14
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

		// Token: 0x04008C99 RID: 35993
		private static readonly MessageParser<RoverRogueGetOrLoseData> _parser = new MessageParser<RoverRogueGetOrLoseData>(() => new RoverRogueGetOrLoseData());

		// Token: 0x04008C9A RID: 35994
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C9B RID: 35995
		public const int EffectIdFieldNumber = 1;

		// Token: 0x04008C9C RID: 35996
		private int effectId_;

		// Token: 0x04008C9D RID: 35997
		public const int RoverRogueGainEntryIncIdGetFieldNumber = 2;

		// Token: 0x04008C9E RID: 35998
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_roverRogueGainEntryIncIdGet_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(18U, RoverRogueGainEntry.Parser);

		// Token: 0x04008C9F RID: 35999
		private readonly RepeatedField<RoverRogueGainEntry> roverRogueGainEntryIncIdGet_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008CA0 RID: 36000
		public const int RoverRogueGainEntryIncIdLoseFieldNumber = 3;

		// Token: 0x04008CA1 RID: 36001
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_roverRogueGainEntryIncIdLose_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(26U, RoverRogueGainEntry.Parser);

		// Token: 0x04008CA2 RID: 36002
		private readonly RepeatedField<RoverRogueGainEntry> roverRogueGainEntryIncIdLose_ = new RepeatedField<RoverRogueGainEntry>();
	}
}
