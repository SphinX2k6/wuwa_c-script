using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000155 RID: 341
	[NetMessage(EMessageId.BabelTowerTaskRewardRequest)]
	public sealed class BabelTowerTaskRewardRequest : IMessage<BabelTowerTaskRewardRequest>, IMessage, IEquatable<BabelTowerTaskRewardRequest>, IDeepCloneable<BabelTowerTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06002B2D RID: 11053 RVA: 0x00070B49 File Offset: 0x0006ED49
		[NullableContext(1)]
		public static BabelTowerTaskRewardRequest Create()
		{
			return new BabelTowerTaskRewardRequest();
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06002B2E RID: 11054 RVA: 0x00070B50 File Offset: 0x0006ED50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06002B2F RID: 11055 RVA: 0x00070B53 File Offset: 0x0006ED53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x00070B5A File Offset: 0x0006ED5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerTaskRewardRequest()
		{
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x00070B70 File Offset: 0x0006ED70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerTaskRewardRequest(BabelTowerTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this.taskIds_ = other.taskIds_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x00070BBD File Offset: 0x0006EDBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerTaskRewardRequest Clone()
		{
			return new BabelTowerTaskRewardRequest(this);
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06002B33 RID: 11059 RVA: 0x00070BC5 File Offset: 0x0006EDC5
		// (set) Token: 0x06002B34 RID: 11060 RVA: 0x00070BCD File Offset: 0x0006EDCD
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

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06002B35 RID: 11061 RVA: 0x00070BD6 File Offset: 0x0006EDD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06002B36 RID: 11062 RVA: 0x00070BDE File Offset: 0x0006EDDE
		// (set) Token: 0x06002B37 RID: 11063 RVA: 0x00070BE6 File Offset: 0x0006EDE6
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

		// Token: 0x06002B38 RID: 11064 RVA: 0x00070BEF File Offset: 0x0006EDEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerTaskRewardRequest);
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x00070C00 File Offset: 0x0006EE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerTaskRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && this.taskIds_.Equals(other.taskIds_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x00070C60 File Offset: 0x0006EE60
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

		// Token: 0x06002B3B RID: 11067 RVA: 0x00070CC6 File Offset: 0x0006EEC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x00070CD3 File Offset: 0x0006EED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x00070CDC File Offset: 0x0006EEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TaskId);
			}
			this.taskIds_.WriteTo(ref output, BabelTowerTaskRewardRequest._repeated_taskIds_codec);
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

		// Token: 0x06002B3E RID: 11070 RVA: 0x00070D48 File Offset: 0x0006EF48
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

		// Token: 0x06002B3F RID: 11071 RVA: 0x00070DB4 File Offset: 0x0006EFB4
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

		// Token: 0x06002B40 RID: 11072 RVA: 0x00070E15 File Offset: 0x0006F015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x00070E20 File Offset: 0x0006F020
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
				if (num <= 96U)
				{
					if (num == 88U)
					{
						this.TaskId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 98U)
					{
						goto IL_46;
					}
					if (num == 104U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.taskIds_.AddEntriesFrom(ref input, BabelTowerTaskRewardRequest._repeated_taskIds_codec);
			}
		}

		// Token: 0x0400278D RID: 10125
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400278E RID: 10126
		public const int TaskIdFieldNumber = 11;

		// Token: 0x0400278F RID: 10127
		private int taskId_;

		// Token: 0x04002790 RID: 10128
		public const int TaskIdsFieldNumber = 12;

		// Token: 0x04002791 RID: 10129
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04002792 RID: 10130
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();

		// Token: 0x04002793 RID: 10131
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04002794 RID: 10132
		private int activityId_;
	}
}
