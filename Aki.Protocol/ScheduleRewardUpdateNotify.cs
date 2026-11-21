using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D4 RID: 4564
	[NetMessage(EMessageId.ScheduleRewardUpdateNotify)]
	public sealed class ScheduleRewardUpdateNotify : IMessage<ScheduleRewardUpdateNotify>, IMessage, IEquatable<ScheduleRewardUpdateNotify>, IDeepCloneable<ScheduleRewardUpdateNotify>, IBufferMessage
	{
		// Token: 0x060185D2 RID: 99794 RVA: 0x0038BD31 File Offset: 0x00389F31
		[NullableContext(1)]
		public static ScheduleRewardUpdateNotify Create()
		{
			return new ScheduleRewardUpdateNotify();
		}

		// Token: 0x1700521C RID: 21020
		// (get) Token: 0x060185D3 RID: 99795 RVA: 0x0038BD38 File Offset: 0x00389F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700521D RID: 21021
		// (get) Token: 0x060185D4 RID: 99796 RVA: 0x0038BD3B File Offset: 0x00389F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScheduleRewardUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060185D5 RID: 99797 RVA: 0x0038BD42 File Offset: 0x00389F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleRewardUpdateNotify()
		{
		}

		// Token: 0x060185D6 RID: 99798 RVA: 0x0038BD55 File Offset: 0x00389F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleRewardUpdateNotify(ScheduleRewardUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.scheduleRewardDatas_ = other.scheduleRewardDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060185D7 RID: 99799 RVA: 0x0038BD8B File Offset: 0x00389F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleRewardUpdateNotify Clone()
		{
			return new ScheduleRewardUpdateNotify(this);
		}

		// Token: 0x1700521E RID: 21022
		// (get) Token: 0x060185D8 RID: 99800 RVA: 0x0038BD93 File Offset: 0x00389F93
		// (set) Token: 0x060185D9 RID: 99801 RVA: 0x0038BD9B File Offset: 0x00389F9B
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

		// Token: 0x1700521F RID: 21023
		// (get) Token: 0x060185DA RID: 99802 RVA: 0x0038BDA4 File Offset: 0x00389FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CiacconaScheduleRewardPbData> ScheduleRewardDatas
		{
			get
			{
				return this.scheduleRewardDatas_;
			}
		}

		// Token: 0x060185DB RID: 99803 RVA: 0x0038BDAC File Offset: 0x00389FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScheduleRewardUpdateNotify);
		}

		// Token: 0x060185DC RID: 99804 RVA: 0x0038BDBC File Offset: 0x00389FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScheduleRewardUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.scheduleRewardDatas_.Equals(other.scheduleRewardDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060185DD RID: 99805 RVA: 0x0038BE0C File Offset: 0x0038A00C
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

		// Token: 0x060185DE RID: 99806 RVA: 0x0038BE59 File Offset: 0x0038A059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060185DF RID: 99807 RVA: 0x0038BE66 File Offset: 0x0038A066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060185E0 RID: 99808 RVA: 0x0038BE70 File Offset: 0x0038A070
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

		// Token: 0x060185E1 RID: 99809 RVA: 0x0038BEC0 File Offset: 0x0038A0C0
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

		// Token: 0x060185E2 RID: 99810 RVA: 0x0038BF14 File Offset: 0x0038A114
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

		// Token: 0x060185E3 RID: 99811 RVA: 0x0038BF61 File Offset: 0x0038A161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060185E4 RID: 99812 RVA: 0x0038BF6C File Offset: 0x0038A16C
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
					if (num != 42U)
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

		// Token: 0x040090C1 RID: 37057
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090C2 RID: 37058
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x040090C3 RID: 37059
		private int activityId_;

		// Token: 0x040090C4 RID: 37060
		public const int ScheduleRewardDatasFieldNumber = 5;

		// Token: 0x040090C5 RID: 37061
		private static readonly FieldCodec<CiacconaScheduleRewardPbData> _repeated_scheduleRewardDatas_codec = FieldCodec.ForMessage<CiacconaScheduleRewardPbData>(42U, CiacconaScheduleRewardPbData.Parser);

		// Token: 0x040090C6 RID: 37062
		private readonly RepeatedField<CiacconaScheduleRewardPbData> scheduleRewardDatas_ = new RepeatedField<CiacconaScheduleRewardPbData>();
	}
}
