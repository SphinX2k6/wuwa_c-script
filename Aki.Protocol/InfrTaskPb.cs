using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F1 RID: 2033
	public sealed class InfrTaskPb : IMessage<InfrTaskPb>, IMessage, IEquatable<InfrTaskPb>, IDeepCloneable<InfrTaskPb>, IBufferMessage
	{
		// Token: 0x0600B646 RID: 46662 RVA: 0x001B31E8 File Offset: 0x001B13E8
		[NullableContext(1)]
		public static InfrTaskPb Create()
		{
			return new InfrTaskPb();
		}

		// Token: 0x170024C1 RID: 9409
		// (get) Token: 0x0600B647 RID: 46663 RVA: 0x001B31EF File Offset: 0x001B13EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InfrTaskPb> Parser
		{
			get
			{
				return InfrTaskPb._parser;
			}
		}

		// Token: 0x170024C2 RID: 9410
		// (get) Token: 0x0600B648 RID: 46664 RVA: 0x001B31F6 File Offset: 0x001B13F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024C3 RID: 9411
		// (get) Token: 0x0600B649 RID: 46665 RVA: 0x001B31F9 File Offset: 0x001B13F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrTaskPb.Descriptor;
			}
		}

		// Token: 0x0600B64A RID: 46666 RVA: 0x001B3200 File Offset: 0x001B1400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrTaskPb()
		{
		}

		// Token: 0x0600B64B RID: 46667 RVA: 0x001B3208 File Offset: 0x001B1408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrTaskPb(InfrTaskPb other) : this()
		{
			this.taskId_ = other.taskId_;
			this.target_ = other.target_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B64C RID: 46668 RVA: 0x001B3245 File Offset: 0x001B1445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrTaskPb Clone()
		{
			return new InfrTaskPb(this);
		}

		// Token: 0x170024C4 RID: 9412
		// (get) Token: 0x0600B64D RID: 46669 RVA: 0x001B324D File Offset: 0x001B144D
		// (set) Token: 0x0600B64E RID: 46670 RVA: 0x001B3255 File Offset: 0x001B1455
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

		// Token: 0x170024C5 RID: 9413
		// (get) Token: 0x0600B64F RID: 46671 RVA: 0x001B325E File Offset: 0x001B145E
		// (set) Token: 0x0600B650 RID: 46672 RVA: 0x001B3266 File Offset: 0x001B1466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x170024C6 RID: 9414
		// (get) Token: 0x0600B651 RID: 46673 RVA: 0x001B326F File Offset: 0x001B146F
		// (set) Token: 0x0600B652 RID: 46674 RVA: 0x001B3277 File Offset: 0x001B1477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrTaskStatusPb Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0600B653 RID: 46675 RVA: 0x001B3280 File Offset: 0x001B1480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrTaskPb);
		}

		// Token: 0x0600B654 RID: 46676 RVA: 0x001B3290 File Offset: 0x001B1490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrTaskPb other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && this.Target == other.Target && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B655 RID: 46677 RVA: 0x001B32EC File Offset: 0x001B14EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this.Status != InfrTaskStatusPb.InfrTaskRunning)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B656 RID: 46678 RVA: 0x001B3363 File Offset: 0x001B1563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B657 RID: 46679 RVA: 0x001B3370 File Offset: 0x001B1570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B658 RID: 46680 RVA: 0x001B337C File Offset: 0x001B157C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TaskId);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Target);
			}
			if (this.Status != InfrTaskStatusPb.InfrTaskRunning)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B659 RID: 46681 RVA: 0x001B33F0 File Offset: 0x001B15F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this.Status != InfrTaskStatusPb.InfrTaskRunning)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B65A RID: 46682 RVA: 0x001B3460 File Offset: 0x001B1660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrTaskPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			if (other.Status != InfrTaskStatusPb.InfrTaskRunning)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B65B RID: 46683 RVA: 0x001B34C4 File Offset: 0x001B16C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B65C RID: 46684 RVA: 0x001B34D0 File Offset: 0x001B16D0
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Status = (InfrTaskStatusPb)input.ReadEnum();
						}
					}
					else
					{
						this.Target = input.ReadInt32();
					}
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040050C0 RID: 20672
		private static readonly MessageParser<InfrTaskPb> _parser = new MessageParser<InfrTaskPb>(() => new InfrTaskPb());

		// Token: 0x040050C1 RID: 20673
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050C2 RID: 20674
		public const int TaskIdFieldNumber = 1;

		// Token: 0x040050C3 RID: 20675
		private int taskId_;

		// Token: 0x040050C4 RID: 20676
		public const int TargetFieldNumber = 2;

		// Token: 0x040050C5 RID: 20677
		private int target_;

		// Token: 0x040050C6 RID: 20678
		public const int StatusFieldNumber = 3;

		// Token: 0x040050C7 RID: 20679
		private InfrTaskStatusPb status_;
	}
}
