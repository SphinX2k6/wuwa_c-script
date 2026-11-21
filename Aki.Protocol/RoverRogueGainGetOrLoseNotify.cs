using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001139 RID: 4409
	[NetMessage(EMessageId.RoverRogueGainGetOrLoseNotify)]
	public sealed class RoverRogueGainGetOrLoseNotify : IMessage<RoverRogueGainGetOrLoseNotify>, IMessage, IEquatable<RoverRogueGainGetOrLoseNotify>, IDeepCloneable<RoverRogueGainGetOrLoseNotify>, IBufferMessage
	{
		// Token: 0x060178DE RID: 96478 RVA: 0x0036D4F0 File Offset: 0x0036B6F0
		[NullableContext(1)]
		public static RoverRogueGainGetOrLoseNotify Create()
		{
			return new RoverRogueGainGetOrLoseNotify();
		}

		// Token: 0x17004F2D RID: 20269
		// (get) Token: 0x060178DF RID: 96479 RVA: 0x0036D4F7 File Offset: 0x0036B6F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F2E RID: 20270
		// (get) Token: 0x060178E0 RID: 96480 RVA: 0x0036D4FA File Offset: 0x0036B6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueGainGetOrLoseNotify.Descriptor;
			}
		}

		// Token: 0x060178E1 RID: 96481 RVA: 0x0036D501 File Offset: 0x0036B701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainGetOrLoseNotify()
		{
		}

		// Token: 0x060178E2 RID: 96482 RVA: 0x0036D52C File Offset: 0x0036B72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainGetOrLoseNotify(RoverRogueGainGetOrLoseNotify other) : this()
		{
			this.roverRogueGainEntryIncIdGet_ = other.roverRogueGainEntryIncIdGet_.Clone();
			this.roverRogueGainEntryIncIdLose_ = other.roverRogueGainEntryIncIdLose_.Clone();
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060178E3 RID: 96483 RVA: 0x0036D583 File Offset: 0x0036B783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainGetOrLoseNotify Clone()
		{
			return new RoverRogueGainGetOrLoseNotify(this);
		}

		// Token: 0x17004F2F RID: 20271
		// (get) Token: 0x060178E4 RID: 96484 RVA: 0x0036D58B File Offset: 0x0036B78B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> RoverRogueGainEntryIncIdGet
		{
			get
			{
				return this.roverRogueGainEntryIncIdGet_;
			}
		}

		// Token: 0x17004F30 RID: 20272
		// (get) Token: 0x060178E5 RID: 96485 RVA: 0x0036D593 File Offset: 0x0036B793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> RoverRogueGainEntryIncIdLose
		{
			get
			{
				return this.roverRogueGainEntryIncIdLose_;
			}
		}

		// Token: 0x17004F31 RID: 20273
		// (get) Token: 0x060178E6 RID: 96486 RVA: 0x0036D59B File Offset: 0x0036B79B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGetOrLoseData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x060178E7 RID: 96487 RVA: 0x0036D5A3 File Offset: 0x0036B7A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueGainGetOrLoseNotify);
		}

		// Token: 0x060178E8 RID: 96488 RVA: 0x0036D5B4 File Offset: 0x0036B7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueGainGetOrLoseNotify other)
		{
			return other != null && (other == this || (this.roverRogueGainEntryIncIdGet_.Equals(other.roverRogueGainEntryIncIdGet_) && this.roverRogueGainEntryIncIdLose_.Equals(other.roverRogueGainEntryIncIdLose_) && this.data_.Equals(other.data_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060178E9 RID: 96489 RVA: 0x0036D61C File Offset: 0x0036B81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roverRogueGainEntryIncIdGet_.GetHashCode();
			num ^= this.roverRogueGainEntryIncIdLose_.GetHashCode();
			num ^= this.data_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060178EA RID: 96490 RVA: 0x0036D66C File Offset: 0x0036B86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060178EB RID: 96491 RVA: 0x0036D679 File Offset: 0x0036B879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060178EC RID: 96492 RVA: 0x0036D684 File Offset: 0x0036B884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.data_.WriteTo(ref output, RoverRogueGainGetOrLoseNotify._repeated_data_codec);
			this.roverRogueGainEntryIncIdLose_.WriteTo(ref output, RoverRogueGainGetOrLoseNotify._repeated_roverRogueGainEntryIncIdLose_codec);
			this.roverRogueGainEntryIncIdGet_.WriteTo(ref output, RoverRogueGainGetOrLoseNotify._repeated_roverRogueGainEntryIncIdGet_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060178ED RID: 96493 RVA: 0x0036D6D8 File Offset: 0x0036B8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roverRogueGainEntryIncIdGet_.CalculateSize(RoverRogueGainGetOrLoseNotify._repeated_roverRogueGainEntryIncIdGet_codec);
			num += this.roverRogueGainEntryIncIdLose_.CalculateSize(RoverRogueGainGetOrLoseNotify._repeated_roverRogueGainEntryIncIdLose_codec);
			num += this.data_.CalculateSize(RoverRogueGainGetOrLoseNotify._repeated_data_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060178EE RID: 96494 RVA: 0x0036D738 File Offset: 0x0036B938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueGainGetOrLoseNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roverRogueGainEntryIncIdGet_.Add(other.roverRogueGainEntryIncIdGet_);
			this.roverRogueGainEntryIncIdLose_.Add(other.roverRogueGainEntryIncIdLose_);
			this.data_.Add(other.data_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060178EF RID: 96495 RVA: 0x0036D793 File Offset: 0x0036B993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060178F0 RID: 96496 RVA: 0x0036D79C File Offset: 0x0036B99C
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
				if (num != 34U)
				{
					if (num != 50U)
					{
						if (num != 74U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.roverRogueGainEntryIncIdGet_.AddEntriesFrom(ref input, RoverRogueGainGetOrLoseNotify._repeated_roverRogueGainEntryIncIdGet_codec);
						}
					}
					else
					{
						this.roverRogueGainEntryIncIdLose_.AddEntriesFrom(ref input, RoverRogueGainGetOrLoseNotify._repeated_roverRogueGainEntryIncIdLose_codec);
					}
				}
				else
				{
					this.data_.AddEntriesFrom(ref input, RoverRogueGainGetOrLoseNotify._repeated_data_codec);
				}
			}
		}

		// Token: 0x04008C8F RID: 35983
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C90 RID: 35984
		public const int RoverRogueGainEntryIncIdGetFieldNumber = 9;

		// Token: 0x04008C91 RID: 35985
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_roverRogueGainEntryIncIdGet_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(74U, RoverRogueGainEntry.Parser);

		// Token: 0x04008C92 RID: 35986
		private readonly RepeatedField<RoverRogueGainEntry> roverRogueGainEntryIncIdGet_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008C93 RID: 35987
		public const int RoverRogueGainEntryIncIdLoseFieldNumber = 6;

		// Token: 0x04008C94 RID: 35988
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_roverRogueGainEntryIncIdLose_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(50U, RoverRogueGainEntry.Parser);

		// Token: 0x04008C95 RID: 35989
		private readonly RepeatedField<RoverRogueGainEntry> roverRogueGainEntryIncIdLose_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008C96 RID: 35990
		public const int DataFieldNumber = 4;

		// Token: 0x04008C97 RID: 35991
		private static readonly FieldCodec<RoverRogueGetOrLoseData> _repeated_data_codec = FieldCodec.ForMessage<RoverRogueGetOrLoseData>(34U, RoverRogueGetOrLoseData.Parser);

		// Token: 0x04008C98 RID: 35992
		private readonly RepeatedField<RoverRogueGetOrLoseData> data_ = new RepeatedField<RoverRogueGetOrLoseData>();
	}
}
