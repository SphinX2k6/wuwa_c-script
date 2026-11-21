using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200039C RID: 924
	[NetMessage(EMessageId.DangoMonopolyTaskUpdateNotify)]
	public sealed class DangoMonopolyTaskUpdateNotify : IMessage<DangoMonopolyTaskUpdateNotify>, IMessage, IEquatable<DangoMonopolyTaskUpdateNotify>, IDeepCloneable<DangoMonopolyTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x06005B56 RID: 23382 RVA: 0x000DE641 File Offset: 0x000DC841
		[NullableContext(1)]
		public static DangoMonopolyTaskUpdateNotify Create()
		{
			return new DangoMonopolyTaskUpdateNotify();
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x06005B57 RID: 23383 RVA: 0x000DE648 File Offset: 0x000DC848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x06005B58 RID: 23384 RVA: 0x000DE64B File Offset: 0x000DC84B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06005B59 RID: 23385 RVA: 0x000DE652 File Offset: 0x000DC852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskUpdateNotify()
		{
		}

		// Token: 0x06005B5A RID: 23386 RVA: 0x000DE665 File Offset: 0x000DC865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskUpdateNotify(DangoMonopolyTaskUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskDatas_ = other.taskDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B5B RID: 23387 RVA: 0x000DE69B File Offset: 0x000DC89B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskUpdateNotify Clone()
		{
			return new DangoMonopolyTaskUpdateNotify(this);
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x06005B5C RID: 23388 RVA: 0x000DE6A3 File Offset: 0x000DC8A3
		// (set) Token: 0x06005B5D RID: 23389 RVA: 0x000DE6AB File Offset: 0x000DC8AB
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

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x06005B5E RID: 23390 RVA: 0x000DE6B4 File Offset: 0x000DC8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoMonopolyTaskData> TaskDatas
		{
			get
			{
				return this.taskDatas_;
			}
		}

		// Token: 0x06005B5F RID: 23391 RVA: 0x000DE6BC File Offset: 0x000DC8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyTaskUpdateNotify);
		}

		// Token: 0x06005B60 RID: 23392 RVA: 0x000DE6CC File Offset: 0x000DC8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskDatas_.Equals(other.taskDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005B61 RID: 23393 RVA: 0x000DE71C File Offset: 0x000DC91C
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

		// Token: 0x06005B62 RID: 23394 RVA: 0x000DE769 File Offset: 0x000DC969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005B63 RID: 23395 RVA: 0x000DE776 File Offset: 0x000DC976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B64 RID: 23396 RVA: 0x000DE780 File Offset: 0x000DC980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskDatas_.WriteTo(ref output, DangoMonopolyTaskUpdateNotify._repeated_taskDatas_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B65 RID: 23397 RVA: 0x000DE7D0 File Offset: 0x000DC9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskDatas_.CalculateSize(DangoMonopolyTaskUpdateNotify._repeated_taskDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005B66 RID: 23398 RVA: 0x000DE824 File Offset: 0x000DCA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyTaskUpdateNotify other)
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

		// Token: 0x06005B67 RID: 23399 RVA: 0x000DE871 File Offset: 0x000DCA71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B68 RID: 23400 RVA: 0x000DE87C File Offset: 0x000DCA7C
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
				if (num != 34U)
				{
					if (num != 104U)
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
					this.taskDatas_.AddEntriesFrom(ref input, DangoMonopolyTaskUpdateNotify._repeated_taskDatas_codec);
				}
			}
		}

		// Token: 0x0400364D RID: 13901
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400364E RID: 13902
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x0400364F RID: 13903
		private int activityId_;

		// Token: 0x04003650 RID: 13904
		public const int TaskDatasFieldNumber = 4;

		// Token: 0x04003651 RID: 13905
		private static readonly FieldCodec<DangoMonopolyTaskData> _repeated_taskDatas_codec = FieldCodec.ForMessage<DangoMonopolyTaskData>(34U, DangoMonopolyTaskData.Parser);

		// Token: 0x04003652 RID: 13906
		private readonly RepeatedField<DangoMonopolyTaskData> taskDatas_ = new RepeatedField<DangoMonopolyTaskData>();
	}
}
