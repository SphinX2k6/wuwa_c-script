using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F1 RID: 753
	public sealed class ConsumptiveTaskProcess : IMessage<ConsumptiveTaskProcess>, IMessage, IEquatable<ConsumptiveTaskProcess>, IDeepCloneable<ConsumptiveTaskProcess>, IBufferMessage
	{
		// Token: 0x06004CA8 RID: 19624 RVA: 0x000BAECC File Offset: 0x000B90CC
		[NullableContext(1)]
		public static ConsumptiveTaskProcess Create()
		{
			return new ConsumptiveTaskProcess();
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06004CA9 RID: 19625 RVA: 0x000BAED3 File Offset: 0x000B90D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06004CAA RID: 19626 RVA: 0x000BAED6 File Offset: 0x000B90D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveTaskProcess.Descriptor;
			}
		}

		// Token: 0x06004CAB RID: 19627 RVA: 0x000BAEDD File Offset: 0x000B90DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskProcess()
		{
		}

		// Token: 0x06004CAC RID: 19628 RVA: 0x000BAEE5 File Offset: 0x000B90E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskProcess(ConsumptiveTaskProcess other) : this()
		{
			this.current_ = other.current_;
			this.target_ = other.target_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004CAD RID: 19629 RVA: 0x000BAF16 File Offset: 0x000B9116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskProcess Clone()
		{
			return new ConsumptiveTaskProcess(this);
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x06004CAE RID: 19630 RVA: 0x000BAF1E File Offset: 0x000B911E
		// (set) Token: 0x06004CAF RID: 19631 RVA: 0x000BAF26 File Offset: 0x000B9126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Current
		{
			get
			{
				return this.current_;
			}
			set
			{
				this.current_ = value;
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06004CB0 RID: 19632 RVA: 0x000BAF2F File Offset: 0x000B912F
		// (set) Token: 0x06004CB1 RID: 19633 RVA: 0x000BAF37 File Offset: 0x000B9137
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

		// Token: 0x06004CB2 RID: 19634 RVA: 0x000BAF40 File Offset: 0x000B9140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveTaskProcess);
		}

		// Token: 0x06004CB3 RID: 19635 RVA: 0x000BAF4E File Offset: 0x000B914E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveTaskProcess other)
		{
			return other != null && (other == this || (this.Current == other.Current && this.Target == other.Target && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004CB4 RID: 19636 RVA: 0x000BAF8C File Offset: 0x000B918C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Current != 0)
			{
				int num2 = num;
				int num3 = this.Current;
				num = (num2 ^ num3.GetHashCode());
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004CB5 RID: 19637 RVA: 0x000BAFE4 File Offset: 0x000B91E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004CB6 RID: 19638 RVA: 0x000BAFF1 File Offset: 0x000B91F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004CB7 RID: 19639 RVA: 0x000BAFFC File Offset: 0x000B91FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Current != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Current);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Target);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004CB8 RID: 19640 RVA: 0x000BB054 File Offset: 0x000B9254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Current != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Current);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004CB9 RID: 19641 RVA: 0x000BB0AC File Offset: 0x000B92AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveTaskProcess other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Current != 0)
			{
				this.Current = other.Current;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004CBA RID: 19642 RVA: 0x000BB0FC File Offset: 0x000B92FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004CBB RID: 19643 RVA: 0x000BB108 File Offset: 0x000B9308
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Target = input.ReadInt32();
					}
				}
				else
				{
					this.Current = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003167 RID: 12647
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003168 RID: 12648
		public const int CurrentFieldNumber = 1;

		// Token: 0x04003169 RID: 12649
		private int current_;

		// Token: 0x0400316A RID: 12650
		public const int TargetFieldNumber = 2;

		// Token: 0x0400316B RID: 12651
		private int target_;
	}
}
