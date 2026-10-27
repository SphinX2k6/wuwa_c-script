using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E1 RID: 737
	public sealed class ConsumptiveActivityInfo : IMessage<ConsumptiveActivityInfo>, IMessage, IEquatable<ConsumptiveActivityInfo>, IDeepCloneable<ConsumptiveActivityInfo>, IBufferMessage
	{
		// Token: 0x06004B19 RID: 19225 RVA: 0x000B71E4 File Offset: 0x000B53E4
		[NullableContext(1)]
		public static ConsumptiveActivityInfo Create()
		{
			return new ConsumptiveActivityInfo();
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06004B1A RID: 19226 RVA: 0x000B71EB File Offset: 0x000B53EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06004B1B RID: 19227 RVA: 0x000B71EE File Offset: 0x000B53EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveActivityInfo.Descriptor;
			}
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x000B71F5 File Offset: 0x000B53F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfo()
		{
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x000B7208 File Offset: 0x000B5408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfo(ConsumptiveActivityInfo other) : this()
		{
			this.activityId_ = other.activityId_;
			this.tasks_ = other.tasks_.Clone();
			this.totalScore_ = other.totalScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x000B7255 File Offset: 0x000B5455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfo Clone()
		{
			return new ConsumptiveActivityInfo(this);
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06004B1F RID: 19231 RVA: 0x000B725D File Offset: 0x000B545D
		// (set) Token: 0x06004B20 RID: 19232 RVA: 0x000B7265 File Offset: 0x000B5465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06004B21 RID: 19233 RVA: 0x000B726E File Offset: 0x000B546E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConsumptiveTaskInfo> Tasks
		{
			get
			{
				return this.tasks_;
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06004B22 RID: 19234 RVA: 0x000B7276 File Offset: 0x000B5476
		// (set) Token: 0x06004B23 RID: 19235 RVA: 0x000B727E File Offset: 0x000B547E
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

		// Token: 0x06004B24 RID: 19236 RVA: 0x000B7287 File Offset: 0x000B5487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveActivityInfo);
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x000B7298 File Offset: 0x000B5498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveActivityInfo other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.tasks_.Equals(other.tasks_) && this.TotalScore == other.TotalScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B26 RID: 19238 RVA: 0x000B72F8 File Offset: 0x000B54F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.tasks_.GetHashCode();
			if (this.TotalScore != 0)
			{
				num ^= this.TotalScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x000B735E File Offset: 0x000B555E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x000B736B File Offset: 0x000B556B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x000B7374 File Offset: 0x000B5574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			this.tasks_.WriteTo(ref output, ConsumptiveActivityInfo._repeated_tasks_codec);
			if (this.TotalScore != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TotalScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x000B73E0 File Offset: 0x000B55E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.tasks_.CalculateSize(ConsumptiveActivityInfo._repeated_tasks_codec);
			if (this.TotalScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x000B744C File Offset: 0x000B564C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.tasks_.Add(other.tasks_);
			if (other.TotalScore != 0)
			{
				this.TotalScore = other.TotalScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x000B74AD File Offset: 0x000B56AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x000B74B8 File Offset: 0x000B56B8
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
				if (num != 16U)
				{
					if (num != 26U)
					{
						if (num != 32U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TotalScore = input.ReadInt32();
						}
					}
					else
					{
						this.tasks_.AddEntriesFrom(ref input, ConsumptiveActivityInfo._repeated_tasks_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400309F RID: 12447
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030A0 RID: 12448
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x040030A1 RID: 12449
		private int activityId_;

		// Token: 0x040030A2 RID: 12450
		public const int TasksFieldNumber = 3;

		// Token: 0x040030A3 RID: 12451
		private static readonly FieldCodec<ConsumptiveTaskInfo> _repeated_tasks_codec = FieldCodec.ForMessage<ConsumptiveTaskInfo>(26U, ConsumptiveTaskInfo.Parser);

		// Token: 0x040030A4 RID: 12452
		private readonly RepeatedField<ConsumptiveTaskInfo> tasks_ = new RepeatedField<ConsumptiveTaskInfo>();

		// Token: 0x040030A5 RID: 12453
		public const int TotalScoreFieldNumber = 4;

		// Token: 0x040030A6 RID: 12454
		private int totalScore_;
	}
}
