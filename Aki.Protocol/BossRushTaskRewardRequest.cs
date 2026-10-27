using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E1 RID: 481
	[NetMessage(EMessageId.BossRushTaskRewardRequest)]
	public sealed class BossRushTaskRewardRequest : IMessage<BossRushTaskRewardRequest>, IMessage, IEquatable<BossRushTaskRewardRequest>, IDeepCloneable<BossRushTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06003635 RID: 13877 RVA: 0x00088308 File Offset: 0x00086508
		[NullableContext(1)]
		public static BossRushTaskRewardRequest Create()
		{
			return new BossRushTaskRewardRequest();
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06003636 RID: 13878 RVA: 0x0008830F File Offset: 0x0008650F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06003637 RID: 13879 RVA: 0x00088312 File Offset: 0x00086512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x00088319 File Offset: 0x00086519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushTaskRewardRequest()
		{
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x00088321 File Offset: 0x00086521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushTaskRewardRequest(BossRushTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x00088346 File Offset: 0x00086546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushTaskRewardRequest Clone()
		{
			return new BossRushTaskRewardRequest(this);
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x0600363B RID: 13883 RVA: 0x0008834E File Offset: 0x0008654E
		// (set) Token: 0x0600363C RID: 13884 RVA: 0x00088356 File Offset: 0x00086556
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

		// Token: 0x0600363D RID: 13885 RVA: 0x0008835F File Offset: 0x0008655F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushTaskRewardRequest);
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x0008836D File Offset: 0x0008656D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushTaskRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x0008839C File Offset: 0x0008659C
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

		// Token: 0x06003640 RID: 13888 RVA: 0x000883DB File Offset: 0x000865DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x000883E8 File Offset: 0x000865E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x000883F1 File Offset: 0x000865F1
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

		// Token: 0x06003643 RID: 13891 RVA: 0x00088424 File Offset: 0x00086624
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

		// Token: 0x06003644 RID: 13892 RVA: 0x00088462 File Offset: 0x00086662
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

		// Token: 0x06003645 RID: 13893 RVA: 0x00088493 File Offset: 0x00086693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x0008849C File Offset: 0x0008669C
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

		// Token: 0x04002A95 RID: 10901
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A96 RID: 10902
		public const int TaskIdFieldNumber = 7;

		// Token: 0x04002A97 RID: 10903
		private int taskId_;
	}
}
