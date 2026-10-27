using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006ED RID: 1773
	public sealed class GivebackInfoPb : IMessage<GivebackInfoPb>, IMessage, IEquatable<GivebackInfoPb>, IDeepCloneable<GivebackInfoPb>, IBufferMessage
	{
		// Token: 0x0600A1A6 RID: 41382 RVA: 0x001871CB File Offset: 0x001853CB
		[NullableContext(1)]
		public static GivebackInfoPb Create()
		{
			return new GivebackInfoPb();
		}

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x0600A1A7 RID: 41383 RVA: 0x001871D2 File Offset: 0x001853D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x0600A1A8 RID: 41384 RVA: 0x001871D5 File Offset: 0x001853D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackInfoPb.Descriptor;
			}
		}

		// Token: 0x0600A1A9 RID: 41385 RVA: 0x001871DC File Offset: 0x001853DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoPb()
		{
		}

		// Token: 0x0600A1AA RID: 41386 RVA: 0x001871FC File Offset: 0x001853FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoPb(GivebackInfoPb other) : this()
		{
			this.task_ = other.task_.Clone();
			this.totalScore_ = other.totalScore_;
			this.rewardedIds_ = other.rewardedIds_.Clone();
			this.activeDay_ = other.activeDay_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1AB RID: 41387 RVA: 0x0018725A File Offset: 0x0018545A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoPb Clone()
		{
			return new GivebackInfoPb(this);
		}

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x0600A1AC RID: 41388 RVA: 0x00187262 File Offset: 0x00185462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GivebackTaskPb> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x0600A1AD RID: 41389 RVA: 0x0018726A File Offset: 0x0018546A
		// (set) Token: 0x0600A1AE RID: 41390 RVA: 0x00187272 File Offset: 0x00185472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalScore
		{
			get
			{
				return this.totalScore_;
			}
			set
			{
				this.totalScore_ = value;
			}
		}

		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x0600A1AF RID: 41391 RVA: 0x0018727B File Offset: 0x0018547B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedIds
		{
			get
			{
				return this.rewardedIds_;
			}
		}

		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x0600A1B0 RID: 41392 RVA: 0x00187283 File Offset: 0x00185483
		// (set) Token: 0x0600A1B1 RID: 41393 RVA: 0x0018728B File Offset: 0x0018548B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActiveDay
		{
			get
			{
				return this.activeDay_;
			}
			set
			{
				this.activeDay_ = value;
			}
		}

		// Token: 0x0600A1B2 RID: 41394 RVA: 0x00187294 File Offset: 0x00185494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackInfoPb);
		}

		// Token: 0x0600A1B3 RID: 41395 RVA: 0x001872A4 File Offset: 0x001854A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackInfoPb other)
		{
			return other != null && (other == this || (this.task_.Equals(other.task_) && this.TotalScore == other.TotalScore && this.rewardedIds_.Equals(other.rewardedIds_) && this.ActiveDay == other.ActiveDay && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A1B4 RID: 41396 RVA: 0x00187318 File Offset: 0x00185518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.task_.GetHashCode();
			if (this.TotalScore != 0)
			{
				num ^= this.TotalScore.GetHashCode();
			}
			num ^= this.rewardedIds_.GetHashCode();
			if (this.ActiveDay != 0)
			{
				num ^= this.ActiveDay.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A1B5 RID: 41397 RVA: 0x0018738C File Offset: 0x0018558C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A1B6 RID: 41398 RVA: 0x00187399 File Offset: 0x00185599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1B7 RID: 41399 RVA: 0x001873A4 File Offset: 0x001855A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.task_.WriteTo(ref output, GivebackInfoPb._repeated_task_codec);
			if (this.TotalScore != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TotalScore);
			}
			this.rewardedIds_.WriteTo(ref output, GivebackInfoPb._repeated_rewardedIds_codec);
			if (this.ActiveDay != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActiveDay);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A1B8 RID: 41400 RVA: 0x00187420 File Offset: 0x00185620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.task_.CalculateSize(GivebackInfoPb._repeated_task_codec);
			if (this.TotalScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalScore);
			}
			num += this.rewardedIds_.CalculateSize(GivebackInfoPb._repeated_rewardedIds_codec);
			if (this.ActiveDay != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActiveDay);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A1B9 RID: 41401 RVA: 0x0018749C File Offset: 0x0018569C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GivebackInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			this.task_.Add(other.task_);
			if (other.TotalScore != 0)
			{
				this.TotalScore = other.TotalScore;
			}
			this.rewardedIds_.Add(other.rewardedIds_);
			if (other.ActiveDay != 0)
			{
				this.ActiveDay = other.ActiveDay;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A1BA RID: 41402 RVA: 0x0018750E File Offset: 0x0018570E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1BB RID: 41403 RVA: 0x00187518 File Offset: 0x00185718
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.task_.AddEntriesFrom(ref input, GivebackInfoPb._repeated_task_codec);
						continue;
					}
					if (num == 16U)
					{
						this.TotalScore = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.rewardedIds_.AddEntriesFrom(ref input, GivebackInfoPb._repeated_rewardedIds_codec);
						continue;
					}
					if (num == 32U)
					{
						this.ActiveDay = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004B09 RID: 19209
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B0A RID: 19210
		public const int TaskFieldNumber = 1;

		// Token: 0x04004B0B RID: 19211
		private static readonly FieldCodec<GivebackTaskPb> _repeated_task_codec = FieldCodec.ForMessage<GivebackTaskPb>(10U, GivebackTaskPb.Parser);

		// Token: 0x04004B0C RID: 19212
		private readonly RepeatedField<GivebackTaskPb> task_ = new RepeatedField<GivebackTaskPb>();

		// Token: 0x04004B0D RID: 19213
		public const int TotalScoreFieldNumber = 2;

		// Token: 0x04004B0E RID: 19214
		private int totalScore_;

		// Token: 0x04004B0F RID: 19215
		public const int RewardedIdsFieldNumber = 3;

		// Token: 0x04004B10 RID: 19216
		private static readonly FieldCodec<int> _repeated_rewardedIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04004B11 RID: 19217
		private readonly RepeatedField<int> rewardedIds_ = new RepeatedField<int>();

		// Token: 0x04004B12 RID: 19218
		public const int ActiveDayFieldNumber = 4;

		// Token: 0x04004B13 RID: 19219
		private int activeDay_;
	}
}
