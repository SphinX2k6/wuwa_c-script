using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000414 RID: 1044
	[NetMessage(EMessageId.EdgeRunnerUpdateNotify)]
	public sealed class EdgeRunnerUpdateNotify : IMessage<EdgeRunnerUpdateNotify>, IMessage, IEquatable<EdgeRunnerUpdateNotify>, IDeepCloneable<EdgeRunnerUpdateNotify>, IBufferMessage
	{
		// Token: 0x060064DD RID: 25821 RVA: 0x000F32ED File Offset: 0x000F14ED
		[NullableContext(1)]
		public static EdgeRunnerUpdateNotify Create()
		{
			return new EdgeRunnerUpdateNotify();
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x060064DE RID: 25822 RVA: 0x000F32F4 File Offset: 0x000F14F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x060064DF RID: 25823 RVA: 0x000F32F7 File Offset: 0x000F14F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060064E0 RID: 25824 RVA: 0x000F32FE File Offset: 0x000F14FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerUpdateNotify()
		{
		}

		// Token: 0x060064E1 RID: 25825 RVA: 0x000F3308 File Offset: 0x000F1508
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

		// Token: 0x060064E2 RID: 25826 RVA: 0x000F335D File Offset: 0x000F155D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerUpdateNotify Clone()
		{
			return new EdgeRunnerUpdateNotify(this);
		}

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x060064E3 RID: 25827 RVA: 0x000F3365 File Offset: 0x000F1565
		// (set) Token: 0x060064E4 RID: 25828 RVA: 0x000F337C File Offset: 0x000F157C
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

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x060064E5 RID: 25829 RVA: 0x000F3391 File Offset: 0x000F1591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFunctionId
		{
			get
			{
				return this.dataCase_ == EdgeRunnerUpdateNotify.DataOneofCase.FunctionId;
			}
		}

		// Token: 0x060064E6 RID: 25830 RVA: 0x000F339C File Offset: 0x000F159C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFunctionId()
		{
			if (this.HasFunctionId)
			{
				this.ClearData();
			}
		}

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x060064E7 RID: 25831 RVA: 0x000F33AC File Offset: 0x000F15AC
		// (set) Token: 0x060064E8 RID: 25832 RVA: 0x000F33C5 File Offset: 0x000F15C5
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

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x060064E9 RID: 25833 RVA: 0x000F33DC File Offset: 0x000F15DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerUpdateNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x060064EA RID: 25834 RVA: 0x000F33E4 File Offset: 0x000F15E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = EdgeRunnerUpdateNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x060064EB RID: 25835 RVA: 0x000F33F4 File Offset: 0x000F15F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerUpdateNotify);
		}

		// Token: 0x060064EC RID: 25836 RVA: 0x000F3404 File Offset: 0x000F1604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerUpdateNotify other)
		{
			return other != null && (other == this || (this.FunctionId == other.FunctionId && object.Equals(this.Task, other.Task) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060064ED RID: 25837 RVA: 0x000F3464 File Offset: 0x000F1664
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

		// Token: 0x060064EE RID: 25838 RVA: 0x000F34C4 File Offset: 0x000F16C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060064EF RID: 25839 RVA: 0x000F34D1 File Offset: 0x000F16D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060064F0 RID: 25840 RVA: 0x000F34DC File Offset: 0x000F16DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasFunctionId)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FunctionId);
			}
			if (this.dataCase_ == EdgeRunnerUpdateNotify.DataOneofCase.Task)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Task);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060064F1 RID: 25841 RVA: 0x000F3538 File Offset: 0x000F1738
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

		// Token: 0x060064F2 RID: 25842 RVA: 0x000F3590 File Offset: 0x000F1790
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

		// Token: 0x060064F3 RID: 25843 RVA: 0x000F35FC File Offset: 0x000F17FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064F4 RID: 25844 RVA: 0x000F3608 File Offset: 0x000F1808
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
					if (num != 90U)
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

		// Token: 0x0400390F RID: 14607
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003910 RID: 14608
		public const int FunctionIdFieldNumber = 1;

		// Token: 0x04003911 RID: 14609
		public const int TaskFieldNumber = 11;

		// Token: 0x04003912 RID: 14610
		private object data_;

		// Token: 0x04003913 RID: 14611
		private EdgeRunnerUpdateNotify.DataOneofCase dataCase_;

		// Token: 0x020017DA RID: 6106
		public enum DataOneofCase
		{
			// Token: 0x0400CB0B RID: 51979
			None,
			// Token: 0x0400CB0C RID: 51980
			FunctionId,
			// Token: 0x0400CB0D RID: 51981
			Task = 11
		}
	}
}
