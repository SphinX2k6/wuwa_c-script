using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200031D RID: 797
	public sealed class DailyAdventureActivityTask : IMessage<DailyAdventureActivityTask>, IMessage, IEquatable<DailyAdventureActivityTask>, IDeepCloneable<DailyAdventureActivityTask>, IBufferMessage
	{
		// Token: 0x06005048 RID: 20552 RVA: 0x000C3CCE File Offset: 0x000C1ECE
		[NullableContext(1)]
		public static DailyAdventureActivityTask Create()
		{
			return new DailyAdventureActivityTask();
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06005049 RID: 20553 RVA: 0x000C3CD5 File Offset: 0x000C1ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DailyAdventureActivityTask> Parser
		{
			get
			{
				return DailyAdventureActivityTask._parser;
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x0600504A RID: 20554 RVA: 0x000C3CDC File Offset: 0x000C1EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x0600504B RID: 20555 RVA: 0x000C3CDF File Offset: 0x000C1EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyAdventureActivityTask.Descriptor;
			}
		}

		// Token: 0x0600504C RID: 20556 RVA: 0x000C3CE6 File Offset: 0x000C1EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureActivityTask()
		{
		}

		// Token: 0x0600504D RID: 20557 RVA: 0x000C3CF0 File Offset: 0x000C1EF0
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

		// Token: 0x0600504E RID: 20558 RVA: 0x000C3D44 File Offset: 0x000C1F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureActivityTask Clone()
		{
			return new DailyAdventureActivityTask(this);
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x0600504F RID: 20559 RVA: 0x000C3D4C File Offset: 0x000C1F4C
		// (set) Token: 0x06005050 RID: 20560 RVA: 0x000C3D54 File Offset: 0x000C1F54
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

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06005051 RID: 20561 RVA: 0x000C3D5D File Offset: 0x000C1F5D
		// (set) Token: 0x06005052 RID: 20562 RVA: 0x000C3D65 File Offset: 0x000C1F65
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

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06005053 RID: 20563 RVA: 0x000C3D6E File Offset: 0x000C1F6E
		// (set) Token: 0x06005054 RID: 20564 RVA: 0x000C3D76 File Offset: 0x000C1F76
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

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06005055 RID: 20565 RVA: 0x000C3D7F File Offset: 0x000C1F7F
		// (set) Token: 0x06005056 RID: 20566 RVA: 0x000C3D87 File Offset: 0x000C1F87
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

		// Token: 0x06005057 RID: 20567 RVA: 0x000C3D90 File Offset: 0x000C1F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyAdventureActivityTask);
		}

		// Token: 0x06005058 RID: 20568 RVA: 0x000C3DA0 File Offset: 0x000C1FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyAdventureActivityTask other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Current == other.Current && this.Target == other.Target && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005059 RID: 20569 RVA: 0x000C3E0C File Offset: 0x000C200C
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

		// Token: 0x0600505A RID: 20570 RVA: 0x000C3E9C File Offset: 0x000C209C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600505B RID: 20571 RVA: 0x000C3EA9 File Offset: 0x000C20A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600505C RID: 20572 RVA: 0x000C3EB4 File Offset: 0x000C20B4
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

		// Token: 0x0600505D RID: 20573 RVA: 0x000C3F44 File Offset: 0x000C2144
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

		// Token: 0x0600505E RID: 20574 RVA: 0x000C3FCC File Offset: 0x000C21CC
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

		// Token: 0x0600505F RID: 20575 RVA: 0x000C4044 File Offset: 0x000C2244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005060 RID: 20576 RVA: 0x000C4050 File Offset: 0x000C2250
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

		// Token: 0x0400325B RID: 12891
		private static readonly MessageParser<DailyAdventureActivityTask> _parser = new MessageParser<DailyAdventureActivityTask>(() => new DailyAdventureActivityTask());

		// Token: 0x0400325C RID: 12892
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400325D RID: 12893
		public const int IdFieldNumber = 1;

		// Token: 0x0400325E RID: 12894
		private int id_;

		// Token: 0x0400325F RID: 12895
		public const int CurrentFieldNumber = 2;

		// Token: 0x04003260 RID: 12896
		private int current_;

		// Token: 0x04003261 RID: 12897
		public const int TargetFieldNumber = 3;

		// Token: 0x04003262 RID: 12898
		private int target_;

		// Token: 0x04003263 RID: 12899
		public const int StatusFieldNumber = 4;

		// Token: 0x04003264 RID: 12900
		private DailyAdventureTaskState status_;
	}
}
