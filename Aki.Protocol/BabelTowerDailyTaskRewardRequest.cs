using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200014B RID: 331
	[NetMessage(EMessageId.BabelTowerDailyTaskRewardRequest)]
	public sealed class BabelTowerDailyTaskRewardRequest : IMessage<BabelTowerDailyTaskRewardRequest>, IMessage, IEquatable<BabelTowerDailyTaskRewardRequest>, IDeepCloneable<BabelTowerDailyTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06002A73 RID: 10867 RVA: 0x0006F5BB File Offset: 0x0006D7BB
		[NullableContext(1)]
		public static BabelTowerDailyTaskRewardRequest Create()
		{
			return new BabelTowerDailyTaskRewardRequest();
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x0006F5C2 File Offset: 0x0006D7C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06002A75 RID: 10869 RVA: 0x0006F5C5 File Offset: 0x0006D7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerDailyTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x0006F5CC File Offset: 0x0006D7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerDailyTaskRewardRequest()
		{
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x0006F5D4 File Offset: 0x0006D7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerDailyTaskRewardRequest(BabelTowerDailyTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x0006F5F9 File Offset: 0x0006D7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerDailyTaskRewardRequest Clone()
		{
			return new BabelTowerDailyTaskRewardRequest(this);
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06002A79 RID: 10873 RVA: 0x0006F601 File Offset: 0x0006D801
		// (set) Token: 0x06002A7A RID: 10874 RVA: 0x0006F609 File Offset: 0x0006D809
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

		// Token: 0x06002A7B RID: 10875 RVA: 0x0006F612 File Offset: 0x0006D812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerDailyTaskRewardRequest);
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x0006F620 File Offset: 0x0006D820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerDailyTaskRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x0006F650 File Offset: 0x0006D850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x0006F68F File Offset: 0x0006D88F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x0006F69C File Offset: 0x0006D89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x0006F6A5 File Offset: 0x0006D8A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x0006F6D8 File Offset: 0x0006D8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x0006F716 File Offset: 0x0006D916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerDailyTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x0006F747 File Offset: 0x0006D947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x0006F750 File Offset: 0x0006D950
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002768 RID: 10088
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002769 RID: 10089
		public const int TaskIdFieldNumber = 8;

		// Token: 0x0400276A RID: 10090
		private int taskId_;
	}
}
