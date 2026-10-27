using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000789 RID: 1929
	[NetMessage(EMessageId.HonamiStoryLimitTaskRewardRequest)]
	public sealed class HonamiStoryLimitTaskRewardRequest : IMessage<HonamiStoryLimitTaskRewardRequest>, IMessage, IEquatable<HonamiStoryLimitTaskRewardRequest>, IDeepCloneable<HonamiStoryLimitTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600AE37 RID: 44599 RVA: 0x001A29C5 File Offset: 0x001A0BC5
		[NullableContext(1)]
		public static HonamiStoryLimitTaskRewardRequest Create()
		{
			return new HonamiStoryLimitTaskRewardRequest();
		}

		// Token: 0x17002326 RID: 8998
		// (get) Token: 0x0600AE38 RID: 44600 RVA: 0x001A29CC File Offset: 0x001A0BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002327 RID: 8999
		// (get) Token: 0x0600AE39 RID: 44601 RVA: 0x001A29CF File Offset: 0x001A0BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryLimitTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600AE3A RID: 44602 RVA: 0x001A29D6 File Offset: 0x001A0BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitTaskRewardRequest()
		{
		}

		// Token: 0x0600AE3B RID: 44603 RVA: 0x001A29EC File Offset: 0x001A0BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitTaskRewardRequest(HonamiStoryLimitTaskRewardRequest other) : this()
		{
			this.limitTaskId_ = other.limitTaskId_;
			this.limitTaskIds_ = other.limitTaskIds_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE3C RID: 44604 RVA: 0x001A2A39 File Offset: 0x001A0C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitTaskRewardRequest Clone()
		{
			return new HonamiStoryLimitTaskRewardRequest(this);
		}

		// Token: 0x17002328 RID: 9000
		// (get) Token: 0x0600AE3D RID: 44605 RVA: 0x001A2A41 File Offset: 0x001A0C41
		// (set) Token: 0x0600AE3E RID: 44606 RVA: 0x001A2A49 File Offset: 0x001A0C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LimitTaskId
		{
			get
			{
				return this.limitTaskId_;
			}
			set
			{
				this.limitTaskId_ = value;
			}
		}

		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x0600AE3F RID: 44607 RVA: 0x001A2A52 File Offset: 0x001A0C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LimitTaskIds
		{
			get
			{
				return this.limitTaskIds_;
			}
		}

		// Token: 0x1700232A RID: 9002
		// (get) Token: 0x0600AE40 RID: 44608 RVA: 0x001A2A5A File Offset: 0x001A0C5A
		// (set) Token: 0x0600AE41 RID: 44609 RVA: 0x001A2A62 File Offset: 0x001A0C62
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

		// Token: 0x0600AE42 RID: 44610 RVA: 0x001A2A6B File Offset: 0x001A0C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryLimitTaskRewardRequest);
		}

		// Token: 0x0600AE43 RID: 44611 RVA: 0x001A2A7C File Offset: 0x001A0C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryLimitTaskRewardRequest other)
		{
			return other != null && (other == this || (this.LimitTaskId == other.LimitTaskId && this.limitTaskIds_.Equals(other.limitTaskIds_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE44 RID: 44612 RVA: 0x001A2ADC File Offset: 0x001A0CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LimitTaskId != 0)
			{
				num ^= this.LimitTaskId.GetHashCode();
			}
			num ^= this.limitTaskIds_.GetHashCode();
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE45 RID: 44613 RVA: 0x001A2B42 File Offset: 0x001A0D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AE46 RID: 44614 RVA: 0x001A2B4F File Offset: 0x001A0D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE47 RID: 44615 RVA: 0x001A2B58 File Offset: 0x001A0D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LimitTaskId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LimitTaskId);
			}
			this.limitTaskIds_.WriteTo(ref output, HonamiStoryLimitTaskRewardRequest._repeated_limitTaskIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE48 RID: 44616 RVA: 0x001A2BC4 File Offset: 0x001A0DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LimitTaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitTaskId);
			}
			num += this.limitTaskIds_.CalculateSize(HonamiStoryLimitTaskRewardRequest._repeated_limitTaskIds_codec);
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE49 RID: 44617 RVA: 0x001A2C30 File Offset: 0x001A0E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryLimitTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LimitTaskId != 0)
			{
				this.LimitTaskId = other.LimitTaskId;
			}
			this.limitTaskIds_.Add(other.limitTaskIds_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AE4A RID: 44618 RVA: 0x001A2C91 File Offset: 0x001A0E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE4B RID: 44619 RVA: 0x001A2C9C File Offset: 0x001A0E9C
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
				if (num <= 48U)
				{
					if (num == 40U)
					{
						this.LimitTaskId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 50U)
					{
						goto IL_46;
					}
					if (num == 104U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.limitTaskIds_.AddEntriesFrom(ref input, HonamiStoryLimitTaskRewardRequest._repeated_limitTaskIds_codec);
			}
		}

		// Token: 0x04004EAA RID: 20138
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EAB RID: 20139
		public const int LimitTaskIdFieldNumber = 5;

		// Token: 0x04004EAC RID: 20140
		private int limitTaskId_;

		// Token: 0x04004EAD RID: 20141
		public const int LimitTaskIdsFieldNumber = 6;

		// Token: 0x04004EAE RID: 20142
		private static readonly FieldCodec<int> _repeated_limitTaskIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04004EAF RID: 20143
		private readonly RepeatedField<int> limitTaskIds_ = new RepeatedField<int>();

		// Token: 0x04004EB0 RID: 20144
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04004EB1 RID: 20145
		private int activityId_;
	}
}
