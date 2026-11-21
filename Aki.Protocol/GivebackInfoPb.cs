using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D9 RID: 1753
	public sealed class GivebackInfoPb : IMessage<GivebackInfoPb>, IMessage, IEquatable<GivebackInfoPb>, IDeepCloneable<GivebackInfoPb>, IBufferMessage
	{
		// Token: 0x0600A050 RID: 41040 RVA: 0x00184797 File Offset: 0x00182997
		[NullableContext(1)]
		public static GivebackInfoPb Create()
		{
			return new GivebackInfoPb();
		}

		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x0600A051 RID: 41041 RVA: 0x0018479E File Offset: 0x0018299E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x0600A052 RID: 41042 RVA: 0x001847A1 File Offset: 0x001829A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackInfoPb.Descriptor;
			}
		}

		// Token: 0x0600A053 RID: 41043 RVA: 0x001847A8 File Offset: 0x001829A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoPb()
		{
		}

		// Token: 0x0600A054 RID: 41044 RVA: 0x001847C8 File Offset: 0x001829C8
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

		// Token: 0x0600A055 RID: 41045 RVA: 0x00184826 File Offset: 0x00182A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoPb Clone()
		{
			return new GivebackInfoPb(this);
		}

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x0600A056 RID: 41046 RVA: 0x0018482E File Offset: 0x00182A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GivebackTaskPb> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x0600A057 RID: 41047 RVA: 0x00184836 File Offset: 0x00182A36
		// (set) Token: 0x0600A058 RID: 41048 RVA: 0x0018483E File Offset: 0x00182A3E
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

		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x0600A059 RID: 41049 RVA: 0x00184847 File Offset: 0x00182A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedIds
		{
			get
			{
				return this.rewardedIds_;
			}
		}

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x0600A05A RID: 41050 RVA: 0x0018484F File Offset: 0x00182A4F
		// (set) Token: 0x0600A05B RID: 41051 RVA: 0x00184857 File Offset: 0x00182A57
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

		// Token: 0x0600A05C RID: 41052 RVA: 0x00184860 File Offset: 0x00182A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackInfoPb);
		}

		// Token: 0x0600A05D RID: 41053 RVA: 0x00184870 File Offset: 0x00182A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackInfoPb other)
		{
			return other != null && (other == this || (this.task_.Equals(other.task_) && this.TotalScore == other.TotalScore && this.rewardedIds_.Equals(other.rewardedIds_) && this.ActiveDay == other.ActiveDay && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A05E RID: 41054 RVA: 0x001848E4 File Offset: 0x00182AE4
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

		// Token: 0x0600A05F RID: 41055 RVA: 0x00184958 File Offset: 0x00182B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A060 RID: 41056 RVA: 0x00184965 File Offset: 0x00182B65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A061 RID: 41057 RVA: 0x00184970 File Offset: 0x00182B70
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

		// Token: 0x0600A062 RID: 41058 RVA: 0x001849EC File Offset: 0x00182BEC
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

		// Token: 0x0600A063 RID: 41059 RVA: 0x00184A68 File Offset: 0x00182C68
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

		// Token: 0x0600A064 RID: 41060 RVA: 0x00184ADA File Offset: 0x00182CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A065 RID: 41061 RVA: 0x00184AE4 File Offset: 0x00182CE4
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

		// Token: 0x04004B02 RID: 19202
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B03 RID: 19203
		public const int TaskFieldNumber = 1;

		// Token: 0x04004B04 RID: 19204
		private static readonly FieldCodec<GivebackTaskPb> _repeated_task_codec = FieldCodec.ForMessage<GivebackTaskPb>(10U, GivebackTaskPb.Parser);

		// Token: 0x04004B05 RID: 19205
		private readonly RepeatedField<GivebackTaskPb> task_ = new RepeatedField<GivebackTaskPb>();

		// Token: 0x04004B06 RID: 19206
		public const int TotalScoreFieldNumber = 2;

		// Token: 0x04004B07 RID: 19207
		private int totalScore_;

		// Token: 0x04004B08 RID: 19208
		public const int RewardedIdsFieldNumber = 3;

		// Token: 0x04004B09 RID: 19209
		private static readonly FieldCodec<int> _repeated_rewardedIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04004B0A RID: 19210
		private readonly RepeatedField<int> rewardedIds_ = new RepeatedField<int>();

		// Token: 0x04004B0B RID: 19211
		public const int ActiveDayFieldNumber = 4;

		// Token: 0x04004B0C RID: 19212
		private int activeDay_;
	}
}
