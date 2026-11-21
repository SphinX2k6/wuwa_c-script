using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C6 RID: 1478
	[NetMessage(EMessageId.FloroRanchRewardMilestoneRequest)]
	public sealed class FloroRanchRewardMilestoneRequest : IMessage<FloroRanchRewardMilestoneRequest>, IMessage, IEquatable<FloroRanchRewardMilestoneRequest>, IDeepCloneable<FloroRanchRewardMilestoneRequest>, IBufferMessage
	{
		// Token: 0x0600894B RID: 35147 RVA: 0x0014C9A7 File Offset: 0x0014ABA7
		[NullableContext(1)]
		public static FloroRanchRewardMilestoneRequest Create()
		{
			return new FloroRanchRewardMilestoneRequest();
		}

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x0600894C RID: 35148 RVA: 0x0014C9AE File Offset: 0x0014ABAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x0600894D RID: 35149 RVA: 0x0014C9B1 File Offset: 0x0014ABB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchRewardMilestoneRequest.Descriptor;
			}
		}

		// Token: 0x0600894E RID: 35150 RVA: 0x0014C9B8 File Offset: 0x0014ABB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardMilestoneRequest()
		{
		}

		// Token: 0x0600894F RID: 35151 RVA: 0x0014C9CB File Offset: 0x0014ABCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardMilestoneRequest(FloroRanchRewardMilestoneRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.milestoneIds_ = other.milestoneIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008950 RID: 35152 RVA: 0x0014CA01 File Offset: 0x0014AC01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardMilestoneRequest Clone()
		{
			return new FloroRanchRewardMilestoneRequest(this);
		}

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x06008951 RID: 35153 RVA: 0x0014CA09 File Offset: 0x0014AC09
		// (set) Token: 0x06008952 RID: 35154 RVA: 0x0014CA11 File Offset: 0x0014AC11
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

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x06008953 RID: 35155 RVA: 0x0014CA1A File Offset: 0x0014AC1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MilestoneIds
		{
			get
			{
				return this.milestoneIds_;
			}
		}

		// Token: 0x06008954 RID: 35156 RVA: 0x0014CA22 File Offset: 0x0014AC22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchRewardMilestoneRequest);
		}

		// Token: 0x06008955 RID: 35157 RVA: 0x0014CA30 File Offset: 0x0014AC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchRewardMilestoneRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.milestoneIds_.Equals(other.milestoneIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008956 RID: 35158 RVA: 0x0014CA80 File Offset: 0x0014AC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.milestoneIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008957 RID: 35159 RVA: 0x0014CACD File Offset: 0x0014ACCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008958 RID: 35160 RVA: 0x0014CADA File Offset: 0x0014ACDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008959 RID: 35161 RVA: 0x0014CAE4 File Offset: 0x0014ACE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			this.milestoneIds_.WriteTo(ref output, FloroRanchRewardMilestoneRequest._repeated_milestoneIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600895A RID: 35162 RVA: 0x0014CB34 File Offset: 0x0014AD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.milestoneIds_.CalculateSize(FloroRanchRewardMilestoneRequest._repeated_milestoneIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600895B RID: 35163 RVA: 0x0014CB88 File Offset: 0x0014AD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchRewardMilestoneRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.milestoneIds_.Add(other.milestoneIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600895C RID: 35164 RVA: 0x0014CBD5 File Offset: 0x0014ADD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600895D RID: 35165 RVA: 0x0014CBE0 File Offset: 0x0014ADE0
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
				if (num != 80U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.milestoneIds_.AddEntriesFrom(ref input, FloroRanchRewardMilestoneRequest._repeated_milestoneIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400440D RID: 17421
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400440E RID: 17422
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x0400440F RID: 17423
		private int activityId_;

		// Token: 0x04004410 RID: 17424
		public const int MilestoneIdsFieldNumber = 13;

		// Token: 0x04004411 RID: 17425
		private static readonly FieldCodec<int> _repeated_milestoneIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04004412 RID: 17426
		private readonly RepeatedField<int> milestoneIds_ = new RepeatedField<int>();
	}
}
