using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200119A RID: 4506
	[NetMessage(EMessageId.ScheduleRewardUpdateNotify)]
	public sealed class ScheduleRewardUpdateNotify : IMessage<ScheduleRewardUpdateNotify>, IMessage, IEquatable<ScheduleRewardUpdateNotify>, IDeepCloneable<ScheduleRewardUpdateNotify>, IBufferMessage
	{
		// Token: 0x06018031 RID: 98353 RVA: 0x0037C9F1 File Offset: 0x0037ABF1
		[NullableContext(1)]
		public static ScheduleRewardUpdateNotify Create()
		{
			return new ScheduleRewardUpdateNotify();
		}

		// Token: 0x170050B0 RID: 20656
		// (get) Token: 0x06018032 RID: 98354 RVA: 0x0037C9F8 File Offset: 0x0037ABF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050B1 RID: 20657
		// (get) Token: 0x06018033 RID: 98355 RVA: 0x0037C9FB File Offset: 0x0037ABFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScheduleRewardUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06018034 RID: 98356 RVA: 0x0037CA02 File Offset: 0x0037AC02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleRewardUpdateNotify()
		{
		}

		// Token: 0x06018035 RID: 98357 RVA: 0x0037CA15 File Offset: 0x0037AC15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleRewardUpdateNotify(ScheduleRewardUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.scheduleRewardDatas_ = other.scheduleRewardDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018036 RID: 98358 RVA: 0x0037CA4B File Offset: 0x0037AC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleRewardUpdateNotify Clone()
		{
			return new ScheduleRewardUpdateNotify(this);
		}

		// Token: 0x170050B2 RID: 20658
		// (get) Token: 0x06018037 RID: 98359 RVA: 0x0037CA53 File Offset: 0x0037AC53
		// (set) Token: 0x06018038 RID: 98360 RVA: 0x0037CA5B File Offset: 0x0037AC5B
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

		// Token: 0x170050B3 RID: 20659
		// (get) Token: 0x06018039 RID: 98361 RVA: 0x0037CA64 File Offset: 0x0037AC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CiacconaScheduleRewardPbData> ScheduleRewardDatas
		{
			get
			{
				return this.scheduleRewardDatas_;
			}
		}

		// Token: 0x0601803A RID: 98362 RVA: 0x0037CA6C File Offset: 0x0037AC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScheduleRewardUpdateNotify);
		}

		// Token: 0x0601803B RID: 98363 RVA: 0x0037CA7C File Offset: 0x0037AC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScheduleRewardUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.scheduleRewardDatas_.Equals(other.scheduleRewardDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601803C RID: 98364 RVA: 0x0037CACC File Offset: 0x0037ACCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.scheduleRewardDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601803D RID: 98365 RVA: 0x0037CB19 File Offset: 0x0037AD19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601803E RID: 98366 RVA: 0x0037CB26 File Offset: 0x0037AD26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601803F RID: 98367 RVA: 0x0037CB30 File Offset: 0x0037AD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			this.scheduleRewardDatas_.WriteTo(ref output, ScheduleRewardUpdateNotify._repeated_scheduleRewardDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018040 RID: 98368 RVA: 0x0037CB80 File Offset: 0x0037AD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.scheduleRewardDatas_.CalculateSize(ScheduleRewardUpdateNotify._repeated_scheduleRewardDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018041 RID: 98369 RVA: 0x0037CBD4 File Offset: 0x0037ADD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScheduleRewardUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.scheduleRewardDatas_.Add(other.scheduleRewardDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018042 RID: 98370 RVA: 0x0037CC21 File Offset: 0x0037AE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018043 RID: 98371 RVA: 0x0037CC2C File Offset: 0x0037AE2C
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
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.scheduleRewardDatas_.AddEntriesFrom(ref input, ScheduleRewardUpdateNotify._repeated_scheduleRewardDatas_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E2E RID: 36398
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E2F RID: 36399
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04008E30 RID: 36400
		private int activityId_;

		// Token: 0x04008E31 RID: 36401
		public const int ScheduleRewardDatasFieldNumber = 14;

		// Token: 0x04008E32 RID: 36402
		private static readonly FieldCodec<CiacconaScheduleRewardPbData> _repeated_scheduleRewardDatas_codec = FieldCodec.ForMessage<CiacconaScheduleRewardPbData>(114U, CiacconaScheduleRewardPbData.Parser);

		// Token: 0x04008E33 RID: 36403
		private readonly RepeatedField<CiacconaScheduleRewardPbData> scheduleRewardDatas_ = new RepeatedField<CiacconaScheduleRewardPbData>();
	}
}
