using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001331 RID: 4913
	[NetMessage(EMessageId.TeamParkourTaskNotify)]
	public sealed class TeamParkourTaskNotify : IMessage<TeamParkourTaskNotify>, IMessage, IEquatable<TeamParkourTaskNotify>, IDeepCloneable<TeamParkourTaskNotify>, IBufferMessage
	{
		// Token: 0x0601A1A7 RID: 106919 RVA: 0x003CAA00 File Offset: 0x003C8C00
		[NullableContext(1)]
		public static TeamParkourTaskNotify Create()
		{
			return new TeamParkourTaskNotify();
		}

		// Token: 0x17005809 RID: 22537
		// (get) Token: 0x0601A1A8 RID: 106920 RVA: 0x003CAA07 File Offset: 0x003C8C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700580A RID: 22538
		// (get) Token: 0x0601A1A9 RID: 106921 RVA: 0x003CAA0A File Offset: 0x003C8C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamParkourTaskNotify.Descriptor;
			}
		}

		// Token: 0x0601A1AA RID: 106922 RVA: 0x003CAA11 File Offset: 0x003C8C11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourTaskNotify()
		{
		}

		// Token: 0x0601A1AB RID: 106923 RVA: 0x003CAA19 File Offset: 0x003C8C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourTaskNotify(TeamParkourTaskNotify other) : this()
		{
			this.activityTask_ = ((other.activityTask_ != null) ? other.activityTask_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A1AC RID: 106924 RVA: 0x003CAA4E File Offset: 0x003C8C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourTaskNotify Clone()
		{
			return new TeamParkourTaskNotify(this);
		}

		// Token: 0x1700580B RID: 22539
		// (get) Token: 0x0601A1AD RID: 106925 RVA: 0x003CAA56 File Offset: 0x003C8C56
		// (set) Token: 0x0601A1AE RID: 106926 RVA: 0x003CAA5E File Offset: 0x003C8C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTask ActivityTask
		{
			get
			{
				return this.activityTask_;
			}
			set
			{
				this.activityTask_ = value;
			}
		}

		// Token: 0x0601A1AF RID: 106927 RVA: 0x003CAA67 File Offset: 0x003C8C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamParkourTaskNotify);
		}

		// Token: 0x0601A1B0 RID: 106928 RVA: 0x003CAA75 File Offset: 0x003C8C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamParkourTaskNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTask, other.ActivityTask) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A1B1 RID: 106929 RVA: 0x003CAAA8 File Offset: 0x003C8CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.activityTask_ != null)
			{
				num ^= this.ActivityTask.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A1B2 RID: 106930 RVA: 0x003CAAE4 File Offset: 0x003C8CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A1B3 RID: 106931 RVA: 0x003CAAF1 File Offset: 0x003C8CF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A1B4 RID: 106932 RVA: 0x003CAAFA File Offset: 0x003C8CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activityTask_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ActivityTask);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A1B5 RID: 106933 RVA: 0x003CAB2C File Offset: 0x003C8D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.activityTask_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActivityTask);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A1B6 RID: 106934 RVA: 0x003CAB6C File Offset: 0x003C8D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamParkourTaskNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.activityTask_ != null)
			{
				if (this.activityTask_ == null)
				{
					this.ActivityTask = new ActivityTask();
				}
				this.ActivityTask.MergeFrom(other.ActivityTask);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A1B7 RID: 106935 RVA: 0x003CABC0 File Offset: 0x003C8DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A1B8 RID: 106936 RVA: 0x003CABCC File Offset: 0x003C8DCC
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.activityTask_ == null)
					{
						this.ActivityTask = new ActivityTask();
					}
					input.ReadMessage(this.ActivityTask);
				}
			}
		}

		// Token: 0x04009860 RID: 39008
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009861 RID: 39009
		public const int ActivityTaskFieldNumber = 5;

		// Token: 0x04009862 RID: 39010
		private ActivityTask activityTask_;
	}
}
