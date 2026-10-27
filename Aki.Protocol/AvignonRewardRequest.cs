using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200012F RID: 303
	[NetMessage(EMessageId.AvignonRewardRequest)]
	public sealed class AvignonRewardRequest : IMessage<AvignonRewardRequest>, IMessage, IEquatable<AvignonRewardRequest>, IDeepCloneable<AvignonRewardRequest>, IBufferMessage
	{
		// Token: 0x06002813 RID: 10259 RVA: 0x00069AFF File Offset: 0x00067CFF
		[NullableContext(1)]
		public static AvignonRewardRequest Create()
		{
			return new AvignonRewardRequest();
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06002814 RID: 10260 RVA: 0x00069B06 File Offset: 0x00067D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x00069B09 File Offset: 0x00067D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvignonRewardRequest.Descriptor;
			}
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x00069B10 File Offset: 0x00067D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonRewardRequest()
		{
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x00069B18 File Offset: 0x00067D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonRewardRequest(AvignonRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x00069B49 File Offset: 0x00067D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonRewardRequest Clone()
		{
			return new AvignonRewardRequest(this);
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x00069B51 File Offset: 0x00067D51
		// (set) Token: 0x0600281A RID: 10266 RVA: 0x00069B59 File Offset: 0x00067D59
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

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x0600281B RID: 10267 RVA: 0x00069B62 File Offset: 0x00067D62
		// (set) Token: 0x0600281C RID: 10268 RVA: 0x00069B6A File Offset: 0x00067D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TaskId
		{
			get
			{
				return this.taskId_;
			}
			set
			{
				this.taskId_ = value;
			}
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x00069B73 File Offset: 0x00067D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvignonRewardRequest);
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x00069B81 File Offset: 0x00067D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvignonRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x00069BC0 File Offset: 0x00067DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x00069C18 File Offset: 0x00067E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x00069C25 File Offset: 0x00067E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x00069C30 File Offset: 0x00067E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.TaskId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x00069C8C File Offset: 0x00067E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x00069CE4 File Offset: 0x00067EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvignonRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x00069D34 File Offset: 0x00067F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x00069D40 File Offset: 0x00067F40
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
				if (num != 24U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TaskId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400268D RID: 9869
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400268E RID: 9870
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x0400268F RID: 9871
		private int activityId_;

		// Token: 0x04002690 RID: 9872
		public const int TaskIdFieldNumber = 4;

		// Token: 0x04002691 RID: 9873
		private int taskId_;
	}
}
