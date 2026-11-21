using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000397 RID: 919
	[NetMessage(EMessageId.DangoMonopolyTaskAddNotify)]
	public sealed class DangoMonopolyTaskAddNotify : IMessage<DangoMonopolyTaskAddNotify>, IMessage, IEquatable<DangoMonopolyTaskAddNotify>, IDeepCloneable<DangoMonopolyTaskAddNotify>, IBufferMessage
	{
		// Token: 0x06005AEE RID: 23278 RVA: 0x000DD83E File Offset: 0x000DBA3E
		[NullableContext(1)]
		public static DangoMonopolyTaskAddNotify Create()
		{
			return new DangoMonopolyTaskAddNotify();
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x06005AEF RID: 23279 RVA: 0x000DD845 File Offset: 0x000DBA45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x06005AF0 RID: 23280 RVA: 0x000DD848 File Offset: 0x000DBA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyTaskAddNotify.Descriptor;
			}
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x000DD84F File Offset: 0x000DBA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskAddNotify()
		{
		}

		// Token: 0x06005AF2 RID: 23282 RVA: 0x000DD862 File Offset: 0x000DBA62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskAddNotify(DangoMonopolyTaskAddNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskDatas_ = other.taskDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005AF3 RID: 23283 RVA: 0x000DD898 File Offset: 0x000DBA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskAddNotify Clone()
		{
			return new DangoMonopolyTaskAddNotify(this);
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x06005AF4 RID: 23284 RVA: 0x000DD8A0 File Offset: 0x000DBAA0
		// (set) Token: 0x06005AF5 RID: 23285 RVA: 0x000DD8A8 File Offset: 0x000DBAA8
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

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06005AF6 RID: 23286 RVA: 0x000DD8B1 File Offset: 0x000DBAB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoMonopolyTaskData> TaskDatas
		{
			get
			{
				return this.taskDatas_;
			}
		}

		// Token: 0x06005AF7 RID: 23287 RVA: 0x000DD8B9 File Offset: 0x000DBAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyTaskAddNotify);
		}

		// Token: 0x06005AF8 RID: 23288 RVA: 0x000DD8C8 File Offset: 0x000DBAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyTaskAddNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskDatas_.Equals(other.taskDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005AF9 RID: 23289 RVA: 0x000DD918 File Offset: 0x000DBB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.taskDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005AFA RID: 23290 RVA: 0x000DD965 File Offset: 0x000DBB65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005AFB RID: 23291 RVA: 0x000DD972 File Offset: 0x000DBB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005AFC RID: 23292 RVA: 0x000DD97C File Offset: 0x000DBB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskDatas_.WriteTo(ref output, DangoMonopolyTaskAddNotify._repeated_taskDatas_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005AFD RID: 23293 RVA: 0x000DD9CC File Offset: 0x000DBBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskDatas_.CalculateSize(DangoMonopolyTaskAddNotify._repeated_taskDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005AFE RID: 23294 RVA: 0x000DDA20 File Offset: 0x000DBC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyTaskAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.taskDatas_.Add(other.taskDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005AFF RID: 23295 RVA: 0x000DDA6D File Offset: 0x000DBC6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B00 RID: 23296 RVA: 0x000DDA78 File Offset: 0x000DBC78
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
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.taskDatas_.AddEntriesFrom(ref input, DangoMonopolyTaskAddNotify._repeated_taskDatas_codec);
				}
			}
		}

		// Token: 0x0400362E RID: 13870
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400362F RID: 13871
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04003630 RID: 13872
		private int activityId_;

		// Token: 0x04003631 RID: 13873
		public const int TaskDatasFieldNumber = 3;

		// Token: 0x04003632 RID: 13874
		private static readonly FieldCodec<DangoMonopolyTaskData> _repeated_taskDatas_codec = FieldCodec.ForMessage<DangoMonopolyTaskData>(26U, DangoMonopolyTaskData.Parser);

		// Token: 0x04003633 RID: 13875
		private readonly RepeatedField<DangoMonopolyTaskData> taskDatas_ = new RepeatedField<DangoMonopolyTaskData>();
	}
}
