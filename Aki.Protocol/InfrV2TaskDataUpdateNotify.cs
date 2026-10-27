using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000806 RID: 2054
	[NetMessage(EMessageId.InfrV2TaskDataUpdateNotify)]
	public sealed class InfrV2TaskDataUpdateNotify : IMessage<InfrV2TaskDataUpdateNotify>, IMessage, IEquatable<InfrV2TaskDataUpdateNotify>, IDeepCloneable<InfrV2TaskDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B7DA RID: 47066 RVA: 0x001B6419 File Offset: 0x001B4619
		[NullableContext(1)]
		public static InfrV2TaskDataUpdateNotify Create()
		{
			return new InfrV2TaskDataUpdateNotify();
		}

		// Token: 0x1700250E RID: 9486
		// (get) Token: 0x0600B7DB RID: 47067 RVA: 0x001B6420 File Offset: 0x001B4620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700250F RID: 9487
		// (get) Token: 0x0600B7DC RID: 47068 RVA: 0x001B6423 File Offset: 0x001B4623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2TaskDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B7DD RID: 47069 RVA: 0x001B642A File Offset: 0x001B462A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TaskDataUpdateNotify()
		{
		}

		// Token: 0x0600B7DE RID: 47070 RVA: 0x001B6432 File Offset: 0x001B4632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TaskDataUpdateNotify(InfrV2TaskDataUpdateNotify other) : this()
		{
			this.task_ = ((other.task_ != null) ? other.task_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B7DF RID: 47071 RVA: 0x001B6467 File Offset: 0x001B4667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TaskDataUpdateNotify Clone()
		{
			return new InfrV2TaskDataUpdateNotify(this);
		}

		// Token: 0x17002510 RID: 9488
		// (get) Token: 0x0600B7E0 RID: 47072 RVA: 0x001B646F File Offset: 0x001B466F
		// (set) Token: 0x0600B7E1 RID: 47073 RVA: 0x001B6477 File Offset: 0x001B4677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask Task
		{
			get
			{
				return this.task_;
			}
			set
			{
				this.task_ = value;
			}
		}

		// Token: 0x0600B7E2 RID: 47074 RVA: 0x001B6480 File Offset: 0x001B4680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2TaskDataUpdateNotify);
		}

		// Token: 0x0600B7E3 RID: 47075 RVA: 0x001B648E File Offset: 0x001B468E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2TaskDataUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Task, other.Task) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B7E4 RID: 47076 RVA: 0x001B64C4 File Offset: 0x001B46C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.task_ != null)
			{
				num ^= this.Task.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B7E5 RID: 47077 RVA: 0x001B6500 File Offset: 0x001B4700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B7E6 RID: 47078 RVA: 0x001B650D File Offset: 0x001B470D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B7E7 RID: 47079 RVA: 0x001B6516 File Offset: 0x001B4716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.task_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Task);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B7E8 RID: 47080 RVA: 0x001B6548 File Offset: 0x001B4748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.task_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Task);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B7E9 RID: 47081 RVA: 0x001B6588 File Offset: 0x001B4788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2TaskDataUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.task_ != null)
			{
				if (this.task_ == null)
				{
					this.Task = new ConditionTask();
				}
				this.Task.MergeFrom(other.Task);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B7EA RID: 47082 RVA: 0x001B65DC File Offset: 0x001B47DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B7EB RID: 47083 RVA: 0x001B65E8 File Offset: 0x001B47E8
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.task_ == null)
					{
						this.Task = new ConditionTask();
					}
					input.ReadMessage(this.Task);
				}
			}
		}

		// Token: 0x0400511E RID: 20766
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400511F RID: 20767
		public const int TaskFieldNumber = 3;

		// Token: 0x04005120 RID: 20768
		private ConditionTask task_;
	}
}
