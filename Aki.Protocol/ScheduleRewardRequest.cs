using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D2 RID: 4562
	[NetMessage(EMessageId.ScheduleRewardRequest)]
	public sealed class ScheduleRewardRequest : IMessage<ScheduleRewardRequest>, IMessage, IEquatable<ScheduleRewardRequest>, IDeepCloneable<ScheduleRewardRequest>, IBufferMessage
	{
		// Token: 0x060185AC RID: 99756 RVA: 0x0038B8B5 File Offset: 0x00389AB5
		[NullableContext(1)]
		public static ScheduleRewardRequest Create()
		{
			return new ScheduleRewardRequest();
		}

		// Token: 0x17005215 RID: 21013
		// (get) Token: 0x060185AD RID: 99757 RVA: 0x0038B8BC File Offset: 0x00389ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005216 RID: 21014
		// (get) Token: 0x060185AE RID: 99758 RVA: 0x0038B8BF File Offset: 0x00389ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScheduleRewardRequest.Descriptor;
			}
		}

		// Token: 0x060185AF RID: 99759 RVA: 0x0038B8C6 File Offset: 0x00389AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleRewardRequest()
		{
		}

		// Token: 0x060185B0 RID: 99760 RVA: 0x0038B8CE File Offset: 0x00389ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleRewardRequest(ScheduleRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.rewardId_ = other.rewardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060185B1 RID: 99761 RVA: 0x0038B8FF File Offset: 0x00389AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleRewardRequest Clone()
		{
			return new ScheduleRewardRequest(this);
		}

		// Token: 0x17005217 RID: 21015
		// (get) Token: 0x060185B2 RID: 99762 RVA: 0x0038B907 File Offset: 0x00389B07
		// (set) Token: 0x060185B3 RID: 99763 RVA: 0x0038B90F File Offset: 0x00389B0F
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

		// Token: 0x17005218 RID: 21016
		// (get) Token: 0x060185B4 RID: 99764 RVA: 0x0038B918 File Offset: 0x00389B18
		// (set) Token: 0x060185B5 RID: 99765 RVA: 0x0038B920 File Offset: 0x00389B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardId
		{
			get
			{
				return this.rewardId_;
			}
			set
			{
				this.rewardId_ = value;
			}
		}

		// Token: 0x060185B6 RID: 99766 RVA: 0x0038B929 File Offset: 0x00389B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScheduleRewardRequest);
		}

		// Token: 0x060185B7 RID: 99767 RVA: 0x0038B937 File Offset: 0x00389B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScheduleRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.RewardId == other.RewardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060185B8 RID: 99768 RVA: 0x0038B978 File Offset: 0x00389B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.RewardId != 0)
			{
				num ^= this.RewardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060185B9 RID: 99769 RVA: 0x0038B9D0 File Offset: 0x00389BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060185BA RID: 99770 RVA: 0x0038B9DD File Offset: 0x00389BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060185BB RID: 99771 RVA: 0x0038B9E8 File Offset: 0x00389BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RewardId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060185BC RID: 99772 RVA: 0x0038BA44 File Offset: 0x00389C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.RewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060185BD RID: 99773 RVA: 0x0038BA9C File Offset: 0x00389C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScheduleRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.RewardId != 0)
			{
				this.RewardId = other.RewardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060185BE RID: 99774 RVA: 0x0038BAEC File Offset: 0x00389CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060185BF RID: 99775 RVA: 0x0038BAF8 File Offset: 0x00389CF8
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
				if (num != 72U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.RewardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040090B9 RID: 37049
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090BA RID: 37050
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x040090BB RID: 37051
		private int activityId_;

		// Token: 0x040090BC RID: 37052
		public const int RewardIdFieldNumber = 9;

		// Token: 0x040090BD RID: 37053
		private int rewardId_;
	}
}
