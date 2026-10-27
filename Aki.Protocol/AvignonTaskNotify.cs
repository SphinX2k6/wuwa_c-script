using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000131 RID: 305
	[NetMessage(EMessageId.AvignonTaskNotify)]
	public sealed class AvignonTaskNotify : IMessage<AvignonTaskNotify>, IMessage, IEquatable<AvignonTaskNotify>, IDeepCloneable<AvignonTaskNotify>, IBufferMessage
	{
		// Token: 0x06002839 RID: 10297 RVA: 0x00069F79 File Offset: 0x00068179
		[NullableContext(1)]
		public static AvignonTaskNotify Create()
		{
			return new AvignonTaskNotify();
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x0600283A RID: 10298 RVA: 0x00069F80 File Offset: 0x00068180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x0600283B RID: 10299 RVA: 0x00069F83 File Offset: 0x00068183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvignonTaskNotify.Descriptor;
			}
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x00069F8A File Offset: 0x0006818A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonTaskNotify()
		{
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x00069F94 File Offset: 0x00068194
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

		// Token: 0x0600283E RID: 10302 RVA: 0x00069FE7 File Offset: 0x000681E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonTaskNotify Clone()
		{
			return new AvignonTaskNotify(this);
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x0600283F RID: 10303 RVA: 0x00069FEF File Offset: 0x000681EF
		// (set) Token: 0x06002840 RID: 10304 RVA: 0x0006A008 File Offset: 0x00068208
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

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06002841 RID: 10305 RVA: 0x0006A01F File Offset: 0x0006821F
		// (set) Token: 0x06002842 RID: 10306 RVA: 0x0006A036 File Offset: 0x00068236
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

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06002843 RID: 10307 RVA: 0x0006A04B File Offset: 0x0006824B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnLockStepId
		{
			get
			{
				return this.dataCase_ == AvignonTaskNotify.DataOneofCase.UnLockStepId;
			}
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x0006A056 File Offset: 0x00068256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnLockStepId()
		{
			if (this.HasUnLockStepId)
			{
				this.ClearData();
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06002845 RID: 10309 RVA: 0x0006A066 File Offset: 0x00068266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonTaskNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x0006A06E File Offset: 0x0006826E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = AvignonTaskNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x0006A07E File Offset: 0x0006827E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvignonTaskNotify);
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x0006A08C File Offset: 0x0006828C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvignonTaskNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTask, other.ActivityTask) && this.UnLockStepId == other.UnLockStepId && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x0006A0EC File Offset: 0x000682EC
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

		// Token: 0x0600284A RID: 10314 RVA: 0x0006A14C File Offset: 0x0006834C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x0006A159 File Offset: 0x00068359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x0006A164 File Offset: 0x00068364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasUnLockStepId)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.UnLockStepId);
			}
			if (this.dataCase_ == AvignonTaskNotify.DataOneofCase.ActivityTask)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.ActivityTask);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x0006A1C0 File Offset: 0x000683C0
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

		// Token: 0x0600284E RID: 10318 RVA: 0x0006A218 File Offset: 0x00068418
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

		// Token: 0x0600284F RID: 10319 RVA: 0x0006A282 File Offset: 0x00068482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x0006A28C File Offset: 0x0006848C
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
					if (num != 74U)
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

		// Token: 0x04002695 RID: 9877
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002696 RID: 9878
		public const int ActivityTaskFieldNumber = 9;

		// Token: 0x04002697 RID: 9879
		public const int UnLockStepIdFieldNumber = 1;

		// Token: 0x04002698 RID: 9880
		private object data_;

		// Token: 0x04002699 RID: 9881
		private AvignonTaskNotify.DataOneofCase dataCase_;

		// Token: 0x020016F0 RID: 5872
		public enum DataOneofCase
		{
			// Token: 0x0400C52F RID: 50479
			None,
			// Token: 0x0400C530 RID: 50480
			ActivityTask = 9,
			// Token: 0x0400C531 RID: 50481
			UnLockStepId = 1
		}
	}
}
