using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E5 RID: 485
	[NetMessage(EMessageId.BossRushTaskRewardRequest)]
	public sealed class BossRushTaskRewardRequest : IMessage<BossRushTaskRewardRequest>, IMessage, IEquatable<BossRushTaskRewardRequest>, IDeepCloneable<BossRushTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x060036C2 RID: 14018 RVA: 0x00089A7D File Offset: 0x00087C7D
		[NullableContext(1)]
		public static BossRushTaskRewardRequest Create()
		{
			return new BossRushTaskRewardRequest();
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x060036C3 RID: 14019 RVA: 0x00089A84 File Offset: 0x00087C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x060036C4 RID: 14020 RVA: 0x00089A87 File Offset: 0x00087C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x00089A8E File Offset: 0x00087C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushTaskRewardRequest()
		{
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x00089A96 File Offset: 0x00087C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushTaskRewardRequest(BossRushTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x00089ABB File Offset: 0x00087CBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushTaskRewardRequest Clone()
		{
			return new BossRushTaskRewardRequest(this);
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x060036C8 RID: 14024 RVA: 0x00089AC3 File Offset: 0x00087CC3
		// (set) Token: 0x060036C9 RID: 14025 RVA: 0x00089ACB File Offset: 0x00087CCB
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

		// Token: 0x060036CA RID: 14026 RVA: 0x00089AD4 File Offset: 0x00087CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushTaskRewardRequest);
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x00089AE2 File Offset: 0x00087CE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushTaskRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x00089B10 File Offset: 0x00087D10
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

		// Token: 0x060036CD RID: 14029 RVA: 0x00089B4F File Offset: 0x00087D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x00089B5C File Offset: 0x00087D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x00089B65 File Offset: 0x00087D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x00089B98 File Offset: 0x00087D98
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

		// Token: 0x060036D1 RID: 14033 RVA: 0x00089BD6 File Offset: 0x00087DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushTaskRewardRequest other)
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

		// Token: 0x060036D2 RID: 14034 RVA: 0x00089C07 File Offset: 0x00087E07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x00089C10 File Offset: 0x00087E10
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002B10 RID: 11024
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B11 RID: 11025
		public const int TaskIdFieldNumber = 7;

		// Token: 0x04002B12 RID: 11026
		private int taskId_;
	}
}
