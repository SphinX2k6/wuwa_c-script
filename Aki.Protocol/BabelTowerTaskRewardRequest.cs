using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000158 RID: 344
	[NetMessage(EMessageId.BabelTowerTaskRewardRequest)]
	public sealed class BabelTowerTaskRewardRequest : IMessage<BabelTowerTaskRewardRequest>, IMessage, IEquatable<BabelTowerTaskRewardRequest>, IDeepCloneable<BabelTowerTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06002BA4 RID: 11172 RVA: 0x00071F75 File Offset: 0x00070175
		[NullableContext(1)]
		public static BabelTowerTaskRewardRequest Create()
		{
			return new BabelTowerTaskRewardRequest();
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06002BA5 RID: 11173 RVA: 0x00071F7C File Offset: 0x0007017C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x00071F7F File Offset: 0x0007017F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x00071F86 File Offset: 0x00070186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerTaskRewardRequest()
		{
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x00071F9C File Offset: 0x0007019C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerTaskRewardRequest(BabelTowerTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this.taskIds_ = other.taskIds_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x00071FE9 File Offset: 0x000701E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerTaskRewardRequest Clone()
		{
			return new BabelTowerTaskRewardRequest(this);
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06002BAA RID: 11178 RVA: 0x00071FF1 File Offset: 0x000701F1
		// (set) Token: 0x06002BAB RID: 11179 RVA: 0x00071FF9 File Offset: 0x000701F9
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

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06002BAC RID: 11180 RVA: 0x00072002 File Offset: 0x00070202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06002BAD RID: 11181 RVA: 0x0007200A File Offset: 0x0007020A
		// (set) Token: 0x06002BAE RID: 11182 RVA: 0x00072012 File Offset: 0x00070212
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

		// Token: 0x06002BAF RID: 11183 RVA: 0x0007201B File Offset: 0x0007021B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerTaskRewardRequest);
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x0007202C File Offset: 0x0007022C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerTaskRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && this.taskIds_.Equals(other.taskIds_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x0007208C File Offset: 0x0007028C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			num ^= this.taskIds_.GetHashCode();
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x000720F2 File Offset: 0x000702F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x000720FF File Offset: 0x000702FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x00072108 File Offset: 0x00070308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, BabelTowerTaskRewardRequest._repeated_taskIds_codec);
			if (this.TaskId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.TaskId);
			}
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

		// Token: 0x06002BB5 RID: 11189 RVA: 0x00072174 File Offset: 0x00070374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			num += this.taskIds_.CalculateSize(BabelTowerTaskRewardRequest._repeated_taskIds_codec);
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x000721E0 File Offset: 0x000703E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			this.taskIds_.Add(other.taskIds_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x00072241 File Offset: 0x00070441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x0007224C File Offset: 0x0007044C
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
				if (num <= 74U)
				{
					if (num == 72U || num == 74U)
					{
						this.taskIds_.AddEntriesFrom(ref input, BabelTowerTaskRewardRequest._repeated_taskIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.TaskId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002801 RID: 10241
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002802 RID: 10242
		public const int TaskIdFieldNumber = 10;

		// Token: 0x04002803 RID: 10243
		private int taskId_;

		// Token: 0x04002804 RID: 10244
		public const int TaskIdsFieldNumber = 9;

		// Token: 0x04002805 RID: 10245
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04002806 RID: 10246
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();

		// Token: 0x04002807 RID: 10247
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04002808 RID: 10248
		private int activityId_;
	}
}
