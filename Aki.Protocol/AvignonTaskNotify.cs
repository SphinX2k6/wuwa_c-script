using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000134 RID: 308
	[NetMessage(EMessageId.AvignonTaskNotify)]
	public sealed class AvignonTaskNotify : IMessage<AvignonTaskNotify>, IMessage, IEquatable<AvignonTaskNotify>, IDeepCloneable<AvignonTaskNotify>, IBufferMessage
	{
		// Token: 0x060028B0 RID: 10416 RVA: 0x0006B3A1 File Offset: 0x000695A1
		[NullableContext(1)]
		public static AvignonTaskNotify Create()
		{
			return new AvignonTaskNotify();
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x0006B3A8 File Offset: 0x000695A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060028B2 RID: 10418 RVA: 0x0006B3AB File Offset: 0x000695AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvignonTaskNotify.Descriptor;
			}
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x0006B3B2 File Offset: 0x000695B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonTaskNotify()
		{
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x0006B3BC File Offset: 0x000695BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonTaskNotify(AvignonTaskNotify other) : this()
		{
			AvignonTaskNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != AvignonTaskNotify.DataOneofCase.UnLockStepId)
			{
				if (dataCase == AvignonTaskNotify.DataOneofCase.ActivityTask)
				{
					this.ActivityTask = other.ActivityTask.Clone();
				}
			}
			else
			{
				this.UnLockStepId = other.UnLockStepId;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x0006B410 File Offset: 0x00069610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonTaskNotify Clone()
		{
			return new AvignonTaskNotify(this);
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060028B6 RID: 10422 RVA: 0x0006B418 File Offset: 0x00069618
		// (set) Token: 0x060028B7 RID: 10423 RVA: 0x0006B431 File Offset: 0x00069631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTask ActivityTask
		{
			get
			{
				if (this.dataCase_ != AvignonTaskNotify.DataOneofCase.ActivityTask)
				{
					return null;
				}
				return (ActivityTask)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? AvignonTaskNotify.DataOneofCase.None : AvignonTaskNotify.DataOneofCase.ActivityTask);
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060028B8 RID: 10424 RVA: 0x0006B448 File Offset: 0x00069648
		// (set) Token: 0x060028B9 RID: 10425 RVA: 0x0006B45F File Offset: 0x0006965F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnLockStepId
		{
			get
			{
				if (!this.HasUnLockStepId)
				{
					return 0;
				}
				return (int)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = AvignonTaskNotify.DataOneofCase.UnLockStepId;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060028BA RID: 10426 RVA: 0x0006B475 File Offset: 0x00069675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnLockStepId
		{
			get
			{
				return this.dataCase_ == AvignonTaskNotify.DataOneofCase.UnLockStepId;
			}
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x0006B481 File Offset: 0x00069681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnLockStepId()
		{
			if (this.HasUnLockStepId)
			{
				this.ClearData();
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060028BC RID: 10428 RVA: 0x0006B491 File Offset: 0x00069691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonTaskNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x0006B499 File Offset: 0x00069699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = AvignonTaskNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x0006B4A9 File Offset: 0x000696A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvignonTaskNotify);
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x0006B4B8 File Offset: 0x000696B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvignonTaskNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTask, other.ActivityTask) && this.UnLockStepId == other.UnLockStepId && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x0006B518 File Offset: 0x00069718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dataCase_ == AvignonTaskNotify.DataOneofCase.ActivityTask)
			{
				num ^= this.ActivityTask.GetHashCode();
			}
			if (this.HasUnLockStepId)
			{
				num ^= this.UnLockStepId.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x0006B578 File Offset: 0x00069778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x0006B585 File Offset: 0x00069785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x0006B590 File Offset: 0x00069790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasUnLockStepId)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.UnLockStepId);
			}
			if (this.dataCase_ == AvignonTaskNotify.DataOneofCase.ActivityTask)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.ActivityTask);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x0006B5EC File Offset: 0x000697EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dataCase_ == AvignonTaskNotify.DataOneofCase.ActivityTask)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActivityTask);
			}
			if (this.HasUnLockStepId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnLockStepId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x0006B644 File Offset: 0x00069844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvignonTaskNotify other)
		{
			if (other == null)
			{
				return;
			}
			AvignonTaskNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != AvignonTaskNotify.DataOneofCase.UnLockStepId)
			{
				if (dataCase == AvignonTaskNotify.DataOneofCase.ActivityTask)
				{
					if (this.ActivityTask == null)
					{
						this.ActivityTask = new ActivityTask();
					}
					this.ActivityTask.MergeFrom(other.ActivityTask);
				}
			}
			else
			{
				this.UnLockStepId = other.UnLockStepId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x0006B6AF File Offset: 0x000698AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x0006B6B8 File Offset: 0x000698B8
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
				if (num != 96U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						ActivityTask activityTask = new ActivityTask();
						if (this.dataCase_ == AvignonTaskNotify.DataOneofCase.ActivityTask)
						{
							activityTask.MergeFrom(this.ActivityTask);
						}
						input.ReadMessage(activityTask);
						this.ActivityTask = activityTask;
					}
				}
				else
				{
					this.UnLockStepId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002709 RID: 9993
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400270A RID: 9994
		public const int ActivityTaskFieldNumber = 15;

		// Token: 0x0400270B RID: 9995
		public const int UnLockStepIdFieldNumber = 12;

		// Token: 0x0400270C RID: 9996
		private object data_;

		// Token: 0x0400270D RID: 9997
		private AvignonTaskNotify.DataOneofCase dataCase_;

		// Token: 0x0200176C RID: 5996
		public enum DataOneofCase
		{
			// Token: 0x0400CA60 RID: 51808
			None,
			// Token: 0x0400CA61 RID: 51809
			ActivityTask = 15,
			// Token: 0x0400CA62 RID: 51810
			UnLockStepId = 12
		}
	}
}
