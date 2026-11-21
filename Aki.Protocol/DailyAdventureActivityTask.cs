using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000324 RID: 804
	public sealed class DailyAdventureActivityTask : IMessage<DailyAdventureActivityTask>, IMessage, IEquatable<DailyAdventureActivityTask>, IDeepCloneable<DailyAdventureActivityTask>, IBufferMessage
	{
		// Token: 0x06005121 RID: 20769 RVA: 0x000C60BE File Offset: 0x000C42BE
		[NullableContext(1)]
		public static DailyAdventureActivityTask Create()
		{
			return new DailyAdventureActivityTask();
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06005122 RID: 20770 RVA: 0x000C60C5 File Offset: 0x000C42C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DailyAdventureActivityTask> Parser
		{
			get
			{
				return DailyAdventureActivityTask._parser;
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06005123 RID: 20771 RVA: 0x000C60CC File Offset: 0x000C42CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06005124 RID: 20772 RVA: 0x000C60CF File Offset: 0x000C42CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyAdventureActivityTask.Descriptor;
			}
		}

		// Token: 0x06005125 RID: 20773 RVA: 0x000C60D6 File Offset: 0x000C42D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureActivityTask()
		{
		}

		// Token: 0x06005126 RID: 20774 RVA: 0x000C60E0 File Offset: 0x000C42E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureActivityTask(DailyAdventureActivityTask other) : this()
		{
			this.id_ = other.id_;
			this.current_ = other.current_;
			this.target_ = other.target_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005127 RID: 20775 RVA: 0x000C6134 File Offset: 0x000C4334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureActivityTask Clone()
		{
			return new DailyAdventureActivityTask(this);
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06005128 RID: 20776 RVA: 0x000C613C File Offset: 0x000C433C
		// (set) Token: 0x06005129 RID: 20777 RVA: 0x000C6144 File Offset: 0x000C4344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x0600512A RID: 20778 RVA: 0x000C614D File Offset: 0x000C434D
		// (set) Token: 0x0600512B RID: 20779 RVA: 0x000C6155 File Offset: 0x000C4355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Current
		{
			get
			{
				return this.current_;
			}
			set
			{
				this.current_ = value;
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x0600512C RID: 20780 RVA: 0x000C615E File Offset: 0x000C435E
		// (set) Token: 0x0600512D RID: 20781 RVA: 0x000C6166 File Offset: 0x000C4366
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

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x0600512E RID: 20782 RVA: 0x000C616F File Offset: 0x000C436F
		// (set) Token: 0x0600512F RID: 20783 RVA: 0x000C6177 File Offset: 0x000C4377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskState Status
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

		// Token: 0x06005130 RID: 20784 RVA: 0x000C6180 File Offset: 0x000C4380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyAdventureActivityTask);
		}

		// Token: 0x06005131 RID: 20785 RVA: 0x000C6190 File Offset: 0x000C4390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyAdventureActivityTask other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Current == other.Current && this.Target == other.Target && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005132 RID: 20786 RVA: 0x000C61FC File Offset: 0x000C43FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Current != 0)
			{
				int num2 = num;
				int num3 = this.Current;
				num = (num2 ^ num3.GetHashCode());
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this.Status != DailyAdventureTaskState.DailyAdventureTaskRunning)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005133 RID: 20787 RVA: 0x000C628C File Offset: 0x000C448C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005134 RID: 20788 RVA: 0x000C6299 File Offset: 0x000C4499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005135 RID: 20789 RVA: 0x000C62A4 File Offset: 0x000C44A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Current != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Current);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Target);
			}
			if (this.Status != DailyAdventureTaskState.DailyAdventureTaskRunning)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005136 RID: 20790 RVA: 0x000C6334 File Offset: 0x000C4534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Current != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Current);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this.Status != DailyAdventureTaskState.DailyAdventureTaskRunning)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005137 RID: 20791 RVA: 0x000C63BC File Offset: 0x000C45BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyAdventureActivityTask other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Current != 0)
			{
				this.Current = other.Current;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			if (other.Status != DailyAdventureTaskState.DailyAdventureTaskRunning)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005138 RID: 20792 RVA: 0x000C6434 File Offset: 0x000C4634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005139 RID: 20793 RVA: 0x000C6440 File Offset: 0x000C4640
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Current = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Target = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Status = (DailyAdventureTaskState)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040032F2 RID: 13042
		private static readonly MessageParser<DailyAdventureActivityTask> _parser = new MessageParser<DailyAdventureActivityTask>(() => new DailyAdventureActivityTask());

		// Token: 0x040032F3 RID: 13043
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032F4 RID: 13044
		public const int IdFieldNumber = 1;

		// Token: 0x040032F5 RID: 13045
		private int id_;

		// Token: 0x040032F6 RID: 13046
		public const int CurrentFieldNumber = 2;

		// Token: 0x040032F7 RID: 13047
		private int current_;

		// Token: 0x040032F8 RID: 13048
		public const int TargetFieldNumber = 3;

		// Token: 0x040032F9 RID: 13049
		private int target_;

		// Token: 0x040032FA RID: 13050
		public const int StatusFieldNumber = 4;

		// Token: 0x040032FB RID: 13051
		private DailyAdventureTaskState status_;
	}
}
