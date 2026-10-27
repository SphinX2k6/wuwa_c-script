using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000095 RID: 149
	public sealed class ActivityTask : IMessage<ActivityTask>, IMessage, IEquatable<ActivityTask>, IDeepCloneable<ActivityTask>, IBufferMessage
	{
		// Token: 0x06001B62 RID: 7010 RVA: 0x0004CA40 File Offset: 0x0004AC40
		[NullableContext(1)]
		public static ActivityTask Create()
		{
			return new ActivityTask();
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x0004CA47 File Offset: 0x0004AC47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivityTask> Parser
		{
			get
			{
				return ActivityTask._parser;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001B64 RID: 7012 RVA: 0x0004CA4E File Offset: 0x0004AC4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x0004CA51 File Offset: 0x0004AC51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityTask.Descriptor;
			}
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0004CA58 File Offset: 0x0004AC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTask()
		{
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x0004CA6C File Offset: 0x0004AC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTask(ActivityTask other) : this()
		{
			this.id_ = other.id_;
			this.current_ = other.current_;
			this.target_ = other.target_;
			this.status_ = other.status_;
			this.preItemMap_ = other.preItemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x0004CAD1 File Offset: 0x0004ACD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTask Clone()
		{
			return new ActivityTask(this);
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x0004CAD9 File Offset: 0x0004ACD9
		// (set) Token: 0x06001B6A RID: 7018 RVA: 0x0004CAE1 File Offset: 0x0004ACE1
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

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x0004CAEA File Offset: 0x0004ACEA
		// (set) Token: 0x06001B6C RID: 7020 RVA: 0x0004CAF2 File Offset: 0x0004ACF2
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

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x0004CAFB File Offset: 0x0004ACFB
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x0004CB03 File Offset: 0x0004AD03
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

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001B6F RID: 7023 RVA: 0x0004CB0C File Offset: 0x0004AD0C
		// (set) Token: 0x06001B70 RID: 7024 RVA: 0x0004CB14 File Offset: 0x0004AD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskState Status
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

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x0004CB1D File Offset: 0x0004AD1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> PreItemMap
		{
			get
			{
				return this.preItemMap_;
			}
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x0004CB25 File Offset: 0x0004AD25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityTask);
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x0004CB34 File Offset: 0x0004AD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityTask other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Current == other.Current && this.Target == other.Target && this.Status == other.Status && this.PreItemMap.Equals(other.PreItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x0004CBB4 File Offset: 0x0004ADB4
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
			if (this.Status != ActivityTaskState.ActivityTaskRunning)
			{
				num ^= this.Status.GetHashCode();
			}
			num ^= this.PreItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0004CC52 File Offset: 0x0004AE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x0004CC5F File Offset: 0x0004AE5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x0004CC68 File Offset: 0x0004AE68
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
			if (this.Status != ActivityTaskState.ActivityTaskRunning)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Status);
			}
			this.preItemMap_.WriteTo(ref output, ActivityTask._map_preItemMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x0004CD0C File Offset: 0x0004AF0C
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
			if (this.Status != ActivityTaskState.ActivityTaskRunning)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			num += this.preItemMap_.CalculateSize(ActivityTask._map_preItemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x0004CDA8 File Offset: 0x0004AFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityTask other)
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
			if (other.Status != ActivityTaskState.ActivityTaskRunning)
			{
				this.Status = other.Status;
			}
			this.preItemMap_.MergeFrom(other.preItemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x0004CE31 File Offset: 0x0004B031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x0004CE3C File Offset: 0x0004B03C
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
						this.Status = (ActivityTaskState)input.ReadEnum();
						continue;
					}
					if (num == 42U)
					{
						this.preItemMap_.AddEntriesFrom(ref input, ActivityTask._map_preItemMap_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002294 RID: 8852
		private static readonly MessageParser<ActivityTask> _parser = new MessageParser<ActivityTask>(() => new ActivityTask());

		// Token: 0x04002295 RID: 8853
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002296 RID: 8854
		public const int IdFieldNumber = 1;

		// Token: 0x04002297 RID: 8855
		private int id_;

		// Token: 0x04002298 RID: 8856
		public const int CurrentFieldNumber = 2;

		// Token: 0x04002299 RID: 8857
		private int current_;

		// Token: 0x0400229A RID: 8858
		public const int TargetFieldNumber = 3;

		// Token: 0x0400229B RID: 8859
		private int target_;

		// Token: 0x0400229C RID: 8860
		public const int StatusFieldNumber = 4;

		// Token: 0x0400229D RID: 8861
		private ActivityTaskState status_;

		// Token: 0x0400229E RID: 8862
		public const int PreItemMapFieldNumber = 5;

		// Token: 0x0400229F RID: 8863
		private static readonly MapField<int, int>.Codec _map_preItemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x040022A0 RID: 8864
		private readonly MapField<int, int> preItemMap_ = new MapField<int, int>();
	}
}
