using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010FF RID: 4351
	[NetMessage(EMessageId.RoverRogueGainGetOrLoseNotify)]
	public sealed class RoverRogueGainGetOrLoseNotify : IMessage<RoverRogueGainGetOrLoseNotify>, IMessage, IEquatable<RoverRogueGainGetOrLoseNotify>, IDeepCloneable<RoverRogueGainGetOrLoseNotify>, IBufferMessage
	{
		// Token: 0x0601733D RID: 95037 RVA: 0x0035E19C File Offset: 0x0035C39C
		[NullableContext(1)]
		public static RoverRogueGainGetOrLoseNotify Create()
		{
			return new RoverRogueGainGetOrLoseNotify();
		}

		// Token: 0x17004DC1 RID: 19905
		// (get) Token: 0x0601733E RID: 95038 RVA: 0x0035E1A3 File Offset: 0x0035C3A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DC2 RID: 19906
		// (get) Token: 0x0601733F RID: 95039 RVA: 0x0035E1A6 File Offset: 0x0035C3A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueGainGetOrLoseNotify.Descriptor;
			}
		}

		// Token: 0x06017340 RID: 95040 RVA: 0x0035E1AD File Offset: 0x0035C3AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainGetOrLoseNotify()
		{
		}

		// Token: 0x06017341 RID: 95041 RVA: 0x0035E1D8 File Offset: 0x0035C3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainGetOrLoseNotify(RoverRogueGainGetOrLoseNotify other) : this()
		{
			this.roverRogueGainEntryIncIdGet_ = other.roverRogueGainEntryIncIdGet_.Clone();
			this.roverRogueGainEntryIncIdLose_ = other.roverRogueGainEntryIncIdLose_.Clone();
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017342 RID: 95042 RVA: 0x0035E22F File Offset: 0x0035C42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainGetOrLoseNotify Clone()
		{
			return new RoverRogueGainGetOrLoseNotify(this);
		}

		// Token: 0x17004DC3 RID: 19907
		// (get) Token: 0x06017343 RID: 95043 RVA: 0x0035E237 File Offset: 0x0035C437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> RoverRogueGainEntryIncIdGet
		{
			get
			{
				return this.roverRogueGainEntryIncIdGet_;
			}
		}

		// Token: 0x17004DC4 RID: 19908
		// (get) Token: 0x06017344 RID: 95044 RVA: 0x0035E23F File Offset: 0x0035C43F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> RoverRogueGainEntryIncIdLose
		{
			get
			{
				return this.roverRogueGainEntryIncIdLose_;
			}
		}

		// Token: 0x17004DC5 RID: 19909
		// (get) Token: 0x06017345 RID: 95045 RVA: 0x0035E247 File Offset: 0x0035C447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGetOrLoseData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x06017346 RID: 95046 RVA: 0x0035E24F File Offset: 0x0035C44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueGainGetOrLoseNotify);
		}

		// Token: 0x06017347 RID: 95047 RVA: 0x0035E260 File Offset: 0x0035C460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueGainGetOrLoseNotify other)
		{
			return other != null && (other == this || (this.roverRogueGainEntryIncIdGet_.Equals(other.roverRogueGainEntryIncIdGet_) && this.roverRogueGainEntryIncIdLose_.Equals(other.roverRogueGainEntryIncIdLose_) && this.data_.Equals(other.data_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017348 RID: 95048 RVA: 0x0035E2C8 File Offset: 0x0035C4C8
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

		// Token: 0x06017349 RID: 95049 RVA: 0x0035E318 File Offset: 0x0035C518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601734A RID: 95050 RVA: 0x0035E325 File Offset: 0x0035C525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601734B RID: 95051 RVA: 0x0035E330 File Offset: 0x0035C530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roverRogueGainEntryIncIdGet_.WriteTo(ref output, RoverRogueGainGetOrLoseNotify._repeated_roverRogueGainEntryIncIdGet_codec);
			this.roverRogueGainEntryIncIdLose_.WriteTo(ref output, RoverRogueGainGetOrLoseNotify._repeated_roverRogueGainEntryIncIdLose_codec);
			this.data_.WriteTo(ref output, RoverRogueGainGetOrLoseNotify._repeated_data_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601734C RID: 95052 RVA: 0x0035E384 File Offset: 0x0035C584
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

		// Token: 0x0601734D RID: 95053 RVA: 0x0035E3E4 File Offset: 0x0035C5E4
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

		// Token: 0x0601734E RID: 95054 RVA: 0x0035E43F File Offset: 0x0035C63F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601734F RID: 95055 RVA: 0x0035E448 File Offset: 0x0035C648
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
				if (num != 10U)
				{
					if (num != 50U)
					{
						if (num != 82U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.data_.AddEntriesFrom(ref input, RoverRogueGainGetOrLoseNotify._repeated_data_codec);
						}
					}
					else
					{
						this.roverRogueGainEntryIncIdLose_.AddEntriesFrom(ref input, RoverRogueGainGetOrLoseNotify._repeated_roverRogueGainEntryIncIdLose_codec);
					}
				}
				else
				{
					this.roverRogueGainEntryIncIdGet_.AddEntriesFrom(ref input, RoverRogueGainGetOrLoseNotify._repeated_roverRogueGainEntryIncIdGet_codec);
				}
			}
		}

		// Token: 0x040089FC RID: 35324
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089FD RID: 35325
		public const int RoverRogueGainEntryIncIdGetFieldNumber = 1;

		// Token: 0x040089FE RID: 35326
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_roverRogueGainEntryIncIdGet_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(10U, RoverRogueGainEntry.Parser);

		// Token: 0x040089FF RID: 35327
		private readonly RepeatedField<RoverRogueGainEntry> roverRogueGainEntryIncIdGet_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008A00 RID: 35328
		public const int RoverRogueGainEntryIncIdLoseFieldNumber = 6;

		// Token: 0x04008A01 RID: 35329
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_roverRogueGainEntryIncIdLose_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(50U, RoverRogueGainEntry.Parser);

		// Token: 0x04008A02 RID: 35330
		private readonly RepeatedField<RoverRogueGainEntry> roverRogueGainEntryIncIdLose_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008A03 RID: 35331
		public const int DataFieldNumber = 10;

		// Token: 0x04008A04 RID: 35332
		private static readonly FieldCodec<RoverRogueGetOrLoseData> _repeated_data_codec = FieldCodec.ForMessage<RoverRogueGetOrLoseData>(82U, RoverRogueGetOrLoseData.Parser);

		// Token: 0x04008A05 RID: 35333
		private readonly RepeatedField<RoverRogueGetOrLoseData> data_ = new RepeatedField<RoverRogueGetOrLoseData>();
	}
}
