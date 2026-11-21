using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000096 RID: 150
	public sealed class ActivityTask : IMessage<ActivityTask>, IMessage, IEquatable<ActivityTask>, IDeepCloneable<ActivityTask>, IBufferMessage
	{
		// Token: 0x06001BA9 RID: 7081 RVA: 0x0004D650 File Offset: 0x0004B850
		[NullableContext(1)]
		public static ActivityTask Create()
		{
			return new ActivityTask();
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x0004D657 File Offset: 0x0004B857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivityTask> Parser
		{
			get
			{
				return ActivityTask._parser;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06001BAB RID: 7083 RVA: 0x0004D65E File Offset: 0x0004B85E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x0004D661 File Offset: 0x0004B861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityTask.Descriptor;
			}
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0004D668 File Offset: 0x0004B868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTask()
		{
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x0004D67C File Offset: 0x0004B87C
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

		// Token: 0x06001BAF RID: 7087 RVA: 0x0004D6E1 File Offset: 0x0004B8E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTask Clone()
		{
			return new ActivityTask(this);
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x0004D6E9 File Offset: 0x0004B8E9
		// (set) Token: 0x06001BB1 RID: 7089 RVA: 0x0004D6F1 File Offset: 0x0004B8F1
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

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x0004D6FA File Offset: 0x0004B8FA
		// (set) Token: 0x06001BB3 RID: 7091 RVA: 0x0004D702 File Offset: 0x0004B902
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

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x0004D70B File Offset: 0x0004B90B
		// (set) Token: 0x06001BB5 RID: 7093 RVA: 0x0004D713 File Offset: 0x0004B913
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

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x0004D71C File Offset: 0x0004B91C
		// (set) Token: 0x06001BB7 RID: 7095 RVA: 0x0004D724 File Offset: 0x0004B924
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

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x0004D72D File Offset: 0x0004B92D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> PreItemMap
		{
			get
			{
				return this.preItemMap_;
			}
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x0004D735 File Offset: 0x0004B935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityTask);
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0004D744 File Offset: 0x0004B944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityTask other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Current == other.Current && this.Target == other.Target && this.Status == other.Status && this.PreItemMap.Equals(other.PreItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x0004D7C4 File Offset: 0x0004B9C4
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

		// Token: 0x06001BBC RID: 7100 RVA: 0x0004D862 File Offset: 0x0004BA62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x0004D86F File Offset: 0x0004BA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x0004D878 File Offset: 0x0004BA78
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

		// Token: 0x06001BBF RID: 7103 RVA: 0x0004D91C File Offset: 0x0004BB1C
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

		// Token: 0x06001BC0 RID: 7104 RVA: 0x0004D9B8 File Offset: 0x0004BBB8
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

		// Token: 0x06001BC1 RID: 7105 RVA: 0x0004DA41 File Offset: 0x0004BC41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x0004DA4C File Offset: 0x0004BC4C
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

		// Token: 0x040022F5 RID: 8949
		private static readonly MessageParser<ActivityTask> _parser = new MessageParser<ActivityTask>(() => new ActivityTask());

		// Token: 0x040022F6 RID: 8950
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022F7 RID: 8951
		public const int IdFieldNumber = 1;

		// Token: 0x040022F8 RID: 8952
		private int id_;

		// Token: 0x040022F9 RID: 8953
		public const int CurrentFieldNumber = 2;

		// Token: 0x040022FA RID: 8954
		private int current_;

		// Token: 0x040022FB RID: 8955
		public const int TargetFieldNumber = 3;

		// Token: 0x040022FC RID: 8956
		private int target_;

		// Token: 0x040022FD RID: 8957
		public const int StatusFieldNumber = 4;

		// Token: 0x040022FE RID: 8958
		private ActivityTaskState status_;

		// Token: 0x040022FF RID: 8959
		public const int PreItemMapFieldNumber = 5;

		// Token: 0x04002300 RID: 8960
		private static readonly MapField<int, int>.Codec _map_preItemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x04002301 RID: 8961
		private readonly MapField<int, int> preItemMap_ = new MapField<int, int>();
	}
}
