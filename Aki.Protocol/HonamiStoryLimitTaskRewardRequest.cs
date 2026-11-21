using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000775 RID: 1909
	[NetMessage(EMessageId.HonamiStoryLimitTaskRewardRequest)]
	public sealed class HonamiStoryLimitTaskRewardRequest : IMessage<HonamiStoryLimitTaskRewardRequest>, IMessage, IEquatable<HonamiStoryLimitTaskRewardRequest>, IDeepCloneable<HonamiStoryLimitTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600ACE1 RID: 44257 RVA: 0x0019FFA1 File Offset: 0x0019E1A1
		[NullableContext(1)]
		public static HonamiStoryLimitTaskRewardRequest Create()
		{
			return new HonamiStoryLimitTaskRewardRequest();
		}

		// Token: 0x170022DC RID: 8924
		// (get) Token: 0x0600ACE2 RID: 44258 RVA: 0x0019FFA8 File Offset: 0x0019E1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022DD RID: 8925
		// (get) Token: 0x0600ACE3 RID: 44259 RVA: 0x0019FFAB File Offset: 0x0019E1AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryLimitTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600ACE4 RID: 44260 RVA: 0x0019FFB2 File Offset: 0x0019E1B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitTaskRewardRequest()
		{
		}

		// Token: 0x0600ACE5 RID: 44261 RVA: 0x0019FFC8 File Offset: 0x0019E1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitTaskRewardRequest(HonamiStoryLimitTaskRewardRequest other) : this()
		{
			this.limitTaskId_ = other.limitTaskId_;
			this.limitTaskIds_ = other.limitTaskIds_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ACE6 RID: 44262 RVA: 0x001A0015 File Offset: 0x0019E215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitTaskRewardRequest Clone()
		{
			return new HonamiStoryLimitTaskRewardRequest(this);
		}

		// Token: 0x170022DE RID: 8926
		// (get) Token: 0x0600ACE7 RID: 44263 RVA: 0x001A001D File Offset: 0x0019E21D
		// (set) Token: 0x0600ACE8 RID: 44264 RVA: 0x001A0025 File Offset: 0x0019E225
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

		// Token: 0x170022DF RID: 8927
		// (get) Token: 0x0600ACE9 RID: 44265 RVA: 0x001A002E File Offset: 0x0019E22E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LimitTaskIds
		{
			get
			{
				return this.limitTaskIds_;
			}
		}

		// Token: 0x170022E0 RID: 8928
		// (get) Token: 0x0600ACEA RID: 44266 RVA: 0x001A0036 File Offset: 0x0019E236
		// (set) Token: 0x0600ACEB RID: 44267 RVA: 0x001A003E File Offset: 0x0019E23E
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

		// Token: 0x0600ACEC RID: 44268 RVA: 0x001A0047 File Offset: 0x0019E247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryLimitTaskRewardRequest);
		}

		// Token: 0x0600ACED RID: 44269 RVA: 0x001A0058 File Offset: 0x0019E258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryLimitTaskRewardRequest other)
		{
			return other != null && (other == this || (this.LimitTaskId == other.LimitTaskId && this.limitTaskIds_.Equals(other.limitTaskIds_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ACEE RID: 44270 RVA: 0x001A00B8 File Offset: 0x0019E2B8
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

		// Token: 0x0600ACEF RID: 44271 RVA: 0x001A011E File Offset: 0x0019E31E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ACF0 RID: 44272 RVA: 0x001A012B File Offset: 0x0019E32B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ACF1 RID: 44273 RVA: 0x001A0134 File Offset: 0x0019E334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LimitTaskId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LimitTaskId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			this.limitTaskIds_.WriteTo(ref output, HonamiStoryLimitTaskRewardRequest._repeated_limitTaskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ACF2 RID: 44274 RVA: 0x001A01A0 File Offset: 0x0019E3A0
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

		// Token: 0x0600ACF3 RID: 44275 RVA: 0x001A020C File Offset: 0x0019E40C
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

		// Token: 0x0600ACF4 RID: 44276 RVA: 0x001A026D File Offset: 0x0019E46D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ACF5 RID: 44277 RVA: 0x001A0278 File Offset: 0x0019E478
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
				if (num <= 80U)
				{
					if (num == 16U)
					{
						this.LimitTaskId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.limitTaskIds_.AddEntriesFrom(ref input, HonamiStoryLimitTaskRewardRequest._repeated_limitTaskIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004EA3 RID: 20131
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EA4 RID: 20132
		public const int LimitTaskIdFieldNumber = 2;

		// Token: 0x04004EA5 RID: 20133
		private int limitTaskId_;

		// Token: 0x04004EA6 RID: 20134
		public const int LimitTaskIdsFieldNumber = 14;

		// Token: 0x04004EA7 RID: 20135
		private static readonly FieldCodec<int> _repeated_limitTaskIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04004EA8 RID: 20136
		private readonly RepeatedField<int> limitTaskIds_ = new RepeatedField<int>();

		// Token: 0x04004EA9 RID: 20137
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x04004EAA RID: 20138
		private int activityId_;
	}
}
