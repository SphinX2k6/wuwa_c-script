using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E7B RID: 3707
	[NetMessage(EMessageId.RacingBetsTaskRewardRequest)]
	public sealed class RacingBetsTaskRewardRequest : IMessage<RacingBetsTaskRewardRequest>, IMessage, IEquatable<RacingBetsTaskRewardRequest>, IDeepCloneable<RacingBetsTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06013E8F RID: 81551 RVA: 0x002E6219 File Offset: 0x002E4419
		[NullableContext(1)]
		public static RacingBetsTaskRewardRequest Create()
		{
			return new RacingBetsTaskRewardRequest();
		}

		// Token: 0x17004235 RID: 16949
		// (get) Token: 0x06013E90 RID: 81552 RVA: 0x002E6220 File Offset: 0x002E4420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004236 RID: 16950
		// (get) Token: 0x06013E91 RID: 81553 RVA: 0x002E6223 File Offset: 0x002E4423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06013E92 RID: 81554 RVA: 0x002E622A File Offset: 0x002E442A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskRewardRequest()
		{
		}

		// Token: 0x06013E93 RID: 81555 RVA: 0x002E6232 File Offset: 0x002E4432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskRewardRequest(RacingBetsTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013E94 RID: 81556 RVA: 0x002E6257 File Offset: 0x002E4457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskRewardRequest Clone()
		{
			return new RacingBetsTaskRewardRequest(this);
		}

		// Token: 0x17004237 RID: 16951
		// (get) Token: 0x06013E95 RID: 81557 RVA: 0x002E625F File Offset: 0x002E445F
		// (set) Token: 0x06013E96 RID: 81558 RVA: 0x002E6267 File Offset: 0x002E4467
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

		// Token: 0x06013E97 RID: 81559 RVA: 0x002E6270 File Offset: 0x002E4470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsTaskRewardRequest);
		}

		// Token: 0x06013E98 RID: 81560 RVA: 0x002E627E File Offset: 0x002E447E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsTaskRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013E99 RID: 81561 RVA: 0x002E62AC File Offset: 0x002E44AC
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

		// Token: 0x06013E9A RID: 81562 RVA: 0x002E62EB File Offset: 0x002E44EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013E9B RID: 81563 RVA: 0x002E62F8 File Offset: 0x002E44F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013E9C RID: 81564 RVA: 0x002E6301 File Offset: 0x002E4501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013E9D RID: 81565 RVA: 0x002E6334 File Offset: 0x002E4534
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

		// Token: 0x06013E9E RID: 81566 RVA: 0x002E6372 File Offset: 0x002E4572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsTaskRewardRequest other)
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

		// Token: 0x06013E9F RID: 81567 RVA: 0x002E63A3 File Offset: 0x002E45A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013EA0 RID: 81568 RVA: 0x002E63AC File Offset: 0x002E45AC
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040079B0 RID: 31152
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079B1 RID: 31153
		public const int TaskIdFieldNumber = 3;

		// Token: 0x040079B2 RID: 31154
		private int taskId_;
	}
}
