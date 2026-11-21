using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007DD RID: 2013
	public sealed class InfrTaskPb : IMessage<InfrTaskPb>, IMessage, IEquatable<InfrTaskPb>, IDeepCloneable<InfrTaskPb>, IBufferMessage
	{
		// Token: 0x0600B4F0 RID: 46320 RVA: 0x001B07B0 File Offset: 0x001AE9B0
		[NullableContext(1)]
		public static InfrTaskPb Create()
		{
			return new InfrTaskPb();
		}

		// Token: 0x17002477 RID: 9335
		// (get) Token: 0x0600B4F1 RID: 46321 RVA: 0x001B07B7 File Offset: 0x001AE9B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InfrTaskPb> Parser
		{
			get
			{
				return InfrTaskPb._parser;
			}
		}

		// Token: 0x17002478 RID: 9336
		// (get) Token: 0x0600B4F2 RID: 46322 RVA: 0x001B07BE File Offset: 0x001AE9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002479 RID: 9337
		// (get) Token: 0x0600B4F3 RID: 46323 RVA: 0x001B07C1 File Offset: 0x001AE9C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrTaskPb.Descriptor;
			}
		}

		// Token: 0x0600B4F4 RID: 46324 RVA: 0x001B07C8 File Offset: 0x001AE9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrTaskPb()
		{
		}

		// Token: 0x0600B4F5 RID: 46325 RVA: 0x001B07D0 File Offset: 0x001AE9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrTaskPb(InfrTaskPb other) : this()
		{
			this.taskId_ = other.taskId_;
			this.target_ = other.target_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B4F6 RID: 46326 RVA: 0x001B080D File Offset: 0x001AEA0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrTaskPb Clone()
		{
			return new InfrTaskPb(this);
		}

		// Token: 0x1700247A RID: 9338
		// (get) Token: 0x0600B4F7 RID: 46327 RVA: 0x001B0815 File Offset: 0x001AEA15
		// (set) Token: 0x0600B4F8 RID: 46328 RVA: 0x001B081D File Offset: 0x001AEA1D
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

		// Token: 0x1700247B RID: 9339
		// (get) Token: 0x0600B4F9 RID: 46329 RVA: 0x001B0826 File Offset: 0x001AEA26
		// (set) Token: 0x0600B4FA RID: 46330 RVA: 0x001B082E File Offset: 0x001AEA2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x1700247C RID: 9340
		// (get) Token: 0x0600B4FB RID: 46331 RVA: 0x001B0837 File Offset: 0x001AEA37
		// (set) Token: 0x0600B4FC RID: 46332 RVA: 0x001B083F File Offset: 0x001AEA3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrTaskStatusPb Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0600B4FD RID: 46333 RVA: 0x001B0848 File Offset: 0x001AEA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrTaskPb);
		}

		// Token: 0x0600B4FE RID: 46334 RVA: 0x001B0858 File Offset: 0x001AEA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrTaskPb other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && this.Target == other.Target && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B4FF RID: 46335 RVA: 0x001B08B4 File Offset: 0x001AEAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this.Status != InfrTaskStatusPb.InfrTaskRunning)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B500 RID: 46336 RVA: 0x001B092B File Offset: 0x001AEB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B501 RID: 46337 RVA: 0x001B0938 File Offset: 0x001AEB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B502 RID: 46338 RVA: 0x001B0944 File Offset: 0x001AEB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TaskId);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Target);
			}
			if (this.Status != InfrTaskStatusPb.InfrTaskRunning)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B503 RID: 46339 RVA: 0x001B09B8 File Offset: 0x001AEBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this.Status != InfrTaskStatusPb.InfrTaskRunning)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B504 RID: 46340 RVA: 0x001B0A28 File Offset: 0x001AEC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrTaskPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			if (other.Status != InfrTaskStatusPb.InfrTaskRunning)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B505 RID: 46341 RVA: 0x001B0A8C File Offset: 0x001AEC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B506 RID: 46342 RVA: 0x001B0A98 File Offset: 0x001AEC98
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Status = (InfrTaskStatusPb)input.ReadEnum();
						}
					}
					else
					{
						this.Target = input.ReadInt32();
					}
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040050B9 RID: 20665
		private static readonly MessageParser<InfrTaskPb> _parser = new MessageParser<InfrTaskPb>(() => new InfrTaskPb());

		// Token: 0x040050BA RID: 20666
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050BB RID: 20667
		public const int TaskIdFieldNumber = 1;

		// Token: 0x040050BC RID: 20668
		private int taskId_;

		// Token: 0x040050BD RID: 20669
		public const int TargetFieldNumber = 2;

		// Token: 0x040050BE RID: 20670
		private int target_;

		// Token: 0x040050BF RID: 20671
		public const int StatusFieldNumber = 3;

		// Token: 0x040050C0 RID: 20672
		private InfrTaskStatusPb status_;
	}
}
