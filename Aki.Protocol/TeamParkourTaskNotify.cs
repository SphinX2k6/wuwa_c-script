using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200139E RID: 5022
	[NetMessage(EMessageId.TeamParkourTaskNotify)]
	public sealed class TeamParkourTaskNotify : IMessage<TeamParkourTaskNotify>, IMessage, IEquatable<TeamParkourTaskNotify>, IDeepCloneable<TeamParkourTaskNotify>, IBufferMessage
	{
		// Token: 0x0601ABB7 RID: 109495 RVA: 0x003E4CBC File Offset: 0x003E2EBC
		[NullableContext(1)]
		public static TeamParkourTaskNotify Create()
		{
			return new TeamParkourTaskNotify();
		}

		// Token: 0x17005A83 RID: 23171
		// (get) Token: 0x0601ABB8 RID: 109496 RVA: 0x003E4CC3 File Offset: 0x003E2EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A84 RID: 23172
		// (get) Token: 0x0601ABB9 RID: 109497 RVA: 0x003E4CC6 File Offset: 0x003E2EC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamParkourTaskNotify.Descriptor;
			}
		}

		// Token: 0x0601ABBA RID: 109498 RVA: 0x003E4CCD File Offset: 0x003E2ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourTaskNotify()
		{
		}

		// Token: 0x0601ABBB RID: 109499 RVA: 0x003E4CD5 File Offset: 0x003E2ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourTaskNotify(TeamParkourTaskNotify other) : this()
		{
			this.activityTask_ = ((other.activityTask_ != null) ? other.activityTask_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ABBC RID: 109500 RVA: 0x003E4D0A File Offset: 0x003E2F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourTaskNotify Clone()
		{
			return new TeamParkourTaskNotify(this);
		}

		// Token: 0x17005A85 RID: 23173
		// (get) Token: 0x0601ABBD RID: 109501 RVA: 0x003E4D12 File Offset: 0x003E2F12
		// (set) Token: 0x0601ABBE RID: 109502 RVA: 0x003E4D1A File Offset: 0x003E2F1A
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

		// Token: 0x0601ABBF RID: 109503 RVA: 0x003E4D23 File Offset: 0x003E2F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamParkourTaskNotify);
		}

		// Token: 0x0601ABC0 RID: 109504 RVA: 0x003E4D31 File Offset: 0x003E2F31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamParkourTaskNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTask, other.ActivityTask) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ABC1 RID: 109505 RVA: 0x003E4D64 File Offset: 0x003E2F64
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

		// Token: 0x0601ABC2 RID: 109506 RVA: 0x003E4DA0 File Offset: 0x003E2FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ABC3 RID: 109507 RVA: 0x003E4DAD File Offset: 0x003E2FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ABC4 RID: 109508 RVA: 0x003E4DB6 File Offset: 0x003E2FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activityTask_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.ActivityTask);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ABC5 RID: 109509 RVA: 0x003E4DE8 File Offset: 0x003E2FE8
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

		// Token: 0x0601ABC6 RID: 109510 RVA: 0x003E4E28 File Offset: 0x003E3028
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

		// Token: 0x0601ABC7 RID: 109511 RVA: 0x003E4E7C File Offset: 0x003E307C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ABC8 RID: 109512 RVA: 0x003E4E88 File Offset: 0x003E3088
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
				if (num != 82U)
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

		// Token: 0x04009C82 RID: 40066
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C83 RID: 40067
		public const int ActivityTaskFieldNumber = 10;

		// Token: 0x04009C84 RID: 40068
		private ActivityTask activityTask_;
	}
}
