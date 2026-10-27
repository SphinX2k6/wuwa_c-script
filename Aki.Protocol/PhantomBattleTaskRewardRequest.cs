using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC1 RID: 3265
	[NetMessage(EMessageId.PhantomBattleTaskRewardRequest)]
	public sealed class PhantomBattleTaskRewardRequest : IMessage<PhantomBattleTaskRewardRequest>, IMessage, IEquatable<PhantomBattleTaskRewardRequest>, IDeepCloneable<PhantomBattleTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06011AE9 RID: 72425 RVA: 0x00296CAD File Offset: 0x00294EAD
		[NullableContext(1)]
		public static PhantomBattleTaskRewardRequest Create()
		{
			return new PhantomBattleTaskRewardRequest();
		}

		// Token: 0x17003A97 RID: 14999
		// (get) Token: 0x06011AEA RID: 72426 RVA: 0x00296CB4 File Offset: 0x00294EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A98 RID: 15000
		// (get) Token: 0x06011AEB RID: 72427 RVA: 0x00296CB7 File Offset: 0x00294EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06011AEC RID: 72428 RVA: 0x00296CBE File Offset: 0x00294EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTaskRewardRequest()
		{
		}

		// Token: 0x06011AED RID: 72429 RVA: 0x00296CC6 File Offset: 0x00294EC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTaskRewardRequest(PhantomBattleTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011AEE RID: 72430 RVA: 0x00296CEB File Offset: 0x00294EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTaskRewardRequest Clone()
		{
			return new PhantomBattleTaskRewardRequest(this);
		}

		// Token: 0x17003A99 RID: 15001
		// (get) Token: 0x06011AEF RID: 72431 RVA: 0x00296CF3 File Offset: 0x00294EF3
		// (set) Token: 0x06011AF0 RID: 72432 RVA: 0x00296CFB File Offset: 0x00294EFB
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

		// Token: 0x06011AF1 RID: 72433 RVA: 0x00296D04 File Offset: 0x00294F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleTaskRewardRequest);
		}

		// Token: 0x06011AF2 RID: 72434 RVA: 0x00296D12 File Offset: 0x00294F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleTaskRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011AF3 RID: 72435 RVA: 0x00296D40 File Offset: 0x00294F40
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

		// Token: 0x06011AF4 RID: 72436 RVA: 0x00296D7F File Offset: 0x00294F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011AF5 RID: 72437 RVA: 0x00296D8C File Offset: 0x00294F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011AF6 RID: 72438 RVA: 0x00296D95 File Offset: 0x00294F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011AF7 RID: 72439 RVA: 0x00296DC8 File Offset: 0x00294FC8
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

		// Token: 0x06011AF8 RID: 72440 RVA: 0x00296E06 File Offset: 0x00295006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleTaskRewardRequest other)
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

		// Token: 0x06011AF9 RID: 72441 RVA: 0x00296E37 File Offset: 0x00295037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011AFA RID: 72442 RVA: 0x00296E40 File Offset: 0x00295040
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006F44 RID: 28484
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F45 RID: 28485
		public const int TaskIdFieldNumber = 11;

		// Token: 0x04006F46 RID: 28486
		private int taskId_;
	}
}
