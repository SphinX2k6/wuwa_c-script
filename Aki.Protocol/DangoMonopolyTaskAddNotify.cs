using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200038F RID: 911
	[NetMessage(EMessageId.DangoMonopolyTaskAddNotify)]
	public sealed class DangoMonopolyTaskAddNotify : IMessage<DangoMonopolyTaskAddNotify>, IMessage, IEquatable<DangoMonopolyTaskAddNotify>, IDeepCloneable<DangoMonopolyTaskAddNotify>, IBufferMessage
	{
		// Token: 0x06005A01 RID: 23041 RVA: 0x000DB1B6 File Offset: 0x000D93B6
		[NullableContext(1)]
		public static DangoMonopolyTaskAddNotify Create()
		{
			return new DangoMonopolyTaskAddNotify();
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x06005A02 RID: 23042 RVA: 0x000DB1BD File Offset: 0x000D93BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x06005A03 RID: 23043 RVA: 0x000DB1C0 File Offset: 0x000D93C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyTaskAddNotify.Descriptor;
			}
		}

		// Token: 0x06005A04 RID: 23044 RVA: 0x000DB1C7 File Offset: 0x000D93C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskAddNotify()
		{
		}

		// Token: 0x06005A05 RID: 23045 RVA: 0x000DB1DA File Offset: 0x000D93DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskAddNotify(DangoMonopolyTaskAddNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskDatas_ = other.taskDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A06 RID: 23046 RVA: 0x000DB210 File Offset: 0x000D9410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskAddNotify Clone()
		{
			return new DangoMonopolyTaskAddNotify(this);
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06005A07 RID: 23047 RVA: 0x000DB218 File Offset: 0x000D9418
		// (set) Token: 0x06005A08 RID: 23048 RVA: 0x000DB220 File Offset: 0x000D9420
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

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06005A09 RID: 23049 RVA: 0x000DB229 File Offset: 0x000D9429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoMonopolyTaskData> TaskDatas
		{
			get
			{
				return this.taskDatas_;
			}
		}

		// Token: 0x06005A0A RID: 23050 RVA: 0x000DB231 File Offset: 0x000D9431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyTaskAddNotify);
		}

		// Token: 0x06005A0B RID: 23051 RVA: 0x000DB240 File Offset: 0x000D9440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyTaskAddNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskDatas_.Equals(other.taskDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A0C RID: 23052 RVA: 0x000DB290 File Offset: 0x000D9490
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

		// Token: 0x06005A0D RID: 23053 RVA: 0x000DB2DD File Offset: 0x000D94DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005A0E RID: 23054 RVA: 0x000DB2EA File Offset: 0x000D94EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A0F RID: 23055 RVA: 0x000DB2F4 File Offset: 0x000D94F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskDatas_.WriteTo(ref output, DangoMonopolyTaskAddNotify._repeated_taskDatas_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A10 RID: 23056 RVA: 0x000DB344 File Offset: 0x000D9544
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

		// Token: 0x06005A11 RID: 23057 RVA: 0x000DB398 File Offset: 0x000D9598
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

		// Token: 0x06005A12 RID: 23058 RVA: 0x000DB3E5 File Offset: 0x000D95E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A13 RID: 23059 RVA: 0x000DB3F0 File Offset: 0x000D95F0
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
				if (num != 58U)
				{
					if (num != 120U)
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

		// Token: 0x04003592 RID: 13714
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003593 RID: 13715
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04003594 RID: 13716
		private int activityId_;

		// Token: 0x04003595 RID: 13717
		public const int TaskDatasFieldNumber = 7;

		// Token: 0x04003596 RID: 13718
		private static readonly FieldCodec<DangoMonopolyTaskData> _repeated_taskDatas_codec = FieldCodec.ForMessage<DangoMonopolyTaskData>(58U, DangoMonopolyTaskData.Parser);

		// Token: 0x04003597 RID: 13719
		private readonly RepeatedField<DangoMonopolyTaskData> taskDatas_ = new RepeatedField<DangoMonopolyTaskData>();
	}
}
