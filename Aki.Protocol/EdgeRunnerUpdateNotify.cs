using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200042B RID: 1067
	[NetMessage(EMessageId.EdgeRunnerUpdateNotify)]
	public sealed class EdgeRunnerUpdateNotify : IMessage<EdgeRunnerUpdateNotify>, IMessage, IEquatable<EdgeRunnerUpdateNotify>, IDeepCloneable<EdgeRunnerUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600666D RID: 26221 RVA: 0x000F6461 File Offset: 0x000F4661
		[NullableContext(1)]
		public static EdgeRunnerUpdateNotify Create()
		{
			return new EdgeRunnerUpdateNotify();
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x0600666E RID: 26222 RVA: 0x000F6468 File Offset: 0x000F4668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x0600666F RID: 26223 RVA: 0x000F646B File Offset: 0x000F466B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06006670 RID: 26224 RVA: 0x000F6472 File Offset: 0x000F4672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerUpdateNotify()
		{
		}

		// Token: 0x06006671 RID: 26225 RVA: 0x000F647C File Offset: 0x000F467C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerUpdateNotify(EdgeRunnerUpdateNotify other) : this()
		{
			EdgeRunnerUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != EdgeRunnerUpdateNotify.DataOneofCase.FunctionId)
			{
				if (dataCase == EdgeRunnerUpdateNotify.DataOneofCase.Task)
				{
					this.Task = other.Task.Clone();
				}
			}
			else
			{
				this.FunctionId = other.FunctionId;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006672 RID: 26226 RVA: 0x000F64D1 File Offset: 0x000F46D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerUpdateNotify Clone()
		{
			return new EdgeRunnerUpdateNotify(this);
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x06006673 RID: 26227 RVA: 0x000F64D9 File Offset: 0x000F46D9
		// (set) Token: 0x06006674 RID: 26228 RVA: 0x000F64F0 File Offset: 0x000F46F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FunctionId
		{
			get
			{
				if (!this.HasFunctionId)
				{
					return 0;
				}
				return (int)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = EdgeRunnerUpdateNotify.DataOneofCase.FunctionId;
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06006675 RID: 26229 RVA: 0x000F6505 File Offset: 0x000F4705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFunctionId
		{
			get
			{
				return this.dataCase_ == EdgeRunnerUpdateNotify.DataOneofCase.FunctionId;
			}
		}

		// Token: 0x06006676 RID: 26230 RVA: 0x000F6510 File Offset: 0x000F4710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFunctionId()
		{
			if (this.HasFunctionId)
			{
				this.ClearData();
			}
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06006677 RID: 26231 RVA: 0x000F6520 File Offset: 0x000F4720
		// (set) Token: 0x06006678 RID: 26232 RVA: 0x000F6539 File Offset: 0x000F4739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask Task
		{
			get
			{
				if (this.dataCase_ != EdgeRunnerUpdateNotify.DataOneofCase.Task)
				{
					return null;
				}
				return (ConditionTask)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? EdgeRunnerUpdateNotify.DataOneofCase.None : EdgeRunnerUpdateNotify.DataOneofCase.Task);
			}
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x06006679 RID: 26233 RVA: 0x000F6550 File Offset: 0x000F4750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerUpdateNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0600667A RID: 26234 RVA: 0x000F6558 File Offset: 0x000F4758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = EdgeRunnerUpdateNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0600667B RID: 26235 RVA: 0x000F6568 File Offset: 0x000F4768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerUpdateNotify);
		}

		// Token: 0x0600667C RID: 26236 RVA: 0x000F6578 File Offset: 0x000F4778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerUpdateNotify other)
		{
			return other != null && (other == this || (this.FunctionId == other.FunctionId && object.Equals(this.Task, other.Task) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600667D RID: 26237 RVA: 0x000F65D8 File Offset: 0x000F47D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasFunctionId)
			{
				num ^= this.FunctionId.GetHashCode();
			}
			if (this.dataCase_ == EdgeRunnerUpdateNotify.DataOneofCase.Task)
			{
				num ^= this.Task.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600667E RID: 26238 RVA: 0x000F6638 File Offset: 0x000F4838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600667F RID: 26239 RVA: 0x000F6645 File Offset: 0x000F4845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006680 RID: 26240 RVA: 0x000F6650 File Offset: 0x000F4850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasFunctionId)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.FunctionId);
			}
			if (this.dataCase_ == EdgeRunnerUpdateNotify.DataOneofCase.Task)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Task);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006681 RID: 26241 RVA: 0x000F66AC File Offset: 0x000F48AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasFunctionId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FunctionId);
			}
			if (this.dataCase_ == EdgeRunnerUpdateNotify.DataOneofCase.Task)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Task);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006682 RID: 26242 RVA: 0x000F6704 File Offset: 0x000F4904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			EdgeRunnerUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != EdgeRunnerUpdateNotify.DataOneofCase.FunctionId)
			{
				if (dataCase == EdgeRunnerUpdateNotify.DataOneofCase.Task)
				{
					if (this.Task == null)
					{
						this.Task = new ConditionTask();
					}
					this.Task.MergeFrom(other.Task);
				}
			}
			else
			{
				this.FunctionId = other.FunctionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006683 RID: 26243 RVA: 0x000F6770 File Offset: 0x000F4970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006684 RID: 26244 RVA: 0x000F677C File Offset: 0x000F497C
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
				if (num != 48U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						ConditionTask conditionTask = new ConditionTask();
						if (this.dataCase_ == EdgeRunnerUpdateNotify.DataOneofCase.Task)
						{
							conditionTask.MergeFrom(this.Task);
						}
						input.ReadMessage(conditionTask);
						this.Task = conditionTask;
					}
				}
				else
				{
					this.FunctionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003922 RID: 14626
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003923 RID: 14627
		public const int FunctionIdFieldNumber = 6;

		// Token: 0x04003924 RID: 14628
		public const int TaskFieldNumber = 14;

		// Token: 0x04003925 RID: 14629
		private object data_;

		// Token: 0x04003926 RID: 14630
		private EdgeRunnerUpdateNotify.DataOneofCase dataCase_;

		// Token: 0x02001762 RID: 5986
		public enum DataOneofCase
		{
			// Token: 0x0400C5E1 RID: 50657
			None,
			// Token: 0x0400C5E2 RID: 50658
			FunctionId = 6,
			// Token: 0x0400C5E3 RID: 50659
			Task = 14
		}
	}
}
