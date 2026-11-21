using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB1 RID: 3249
	[NetMessage(EMessageId.PhantomBattleTaskRewardRequest)]
	public sealed class PhantomBattleTaskRewardRequest : IMessage<PhantomBattleTaskRewardRequest>, IMessage, IEquatable<PhantomBattleTaskRewardRequest>, IDeepCloneable<PhantomBattleTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x060119E9 RID: 72169 RVA: 0x00294F4D File Offset: 0x0029314D
		[NullableContext(1)]
		public static PhantomBattleTaskRewardRequest Create()
		{
			return new PhantomBattleTaskRewardRequest();
		}

		// Token: 0x17003A60 RID: 14944
		// (get) Token: 0x060119EA RID: 72170 RVA: 0x00294F54 File Offset: 0x00293154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A61 RID: 14945
		// (get) Token: 0x060119EB RID: 72171 RVA: 0x00294F57 File Offset: 0x00293157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x060119EC RID: 72172 RVA: 0x00294F5E File Offset: 0x0029315E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTaskRewardRequest()
		{
		}

		// Token: 0x060119ED RID: 72173 RVA: 0x00294F66 File Offset: 0x00293166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTaskRewardRequest(PhantomBattleTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060119EE RID: 72174 RVA: 0x00294F8B File Offset: 0x0029318B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTaskRewardRequest Clone()
		{
			return new PhantomBattleTaskRewardRequest(this);
		}

		// Token: 0x17003A62 RID: 14946
		// (get) Token: 0x060119EF RID: 72175 RVA: 0x00294F93 File Offset: 0x00293193
		// (set) Token: 0x060119F0 RID: 72176 RVA: 0x00294F9B File Offset: 0x0029319B
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

		// Token: 0x060119F1 RID: 72177 RVA: 0x00294FA4 File Offset: 0x002931A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleTaskRewardRequest);
		}

		// Token: 0x060119F2 RID: 72178 RVA: 0x00294FB2 File Offset: 0x002931B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleTaskRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060119F3 RID: 72179 RVA: 0x00294FE0 File Offset: 0x002931E0
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

		// Token: 0x060119F4 RID: 72180 RVA: 0x0029501F File Offset: 0x0029321F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060119F5 RID: 72181 RVA: 0x0029502C File Offset: 0x0029322C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060119F6 RID: 72182 RVA: 0x00295035 File Offset: 0x00293235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060119F7 RID: 72183 RVA: 0x00295068 File Offset: 0x00293268
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

		// Token: 0x060119F8 RID: 72184 RVA: 0x002950A6 File Offset: 0x002932A6
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

		// Token: 0x060119F9 RID: 72185 RVA: 0x002950D7 File Offset: 0x002932D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060119FA RID: 72186 RVA: 0x002950E0 File Offset: 0x002932E0
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006F58 RID: 28504
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F59 RID: 28505
		public const int TaskIdFieldNumber = 5;

		// Token: 0x04006F5A RID: 28506
		private int taskId_;
	}
}
