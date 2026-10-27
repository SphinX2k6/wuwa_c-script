using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA9 RID: 2729
	public sealed class MotorTaskTreePb : IMessage<MotorTaskTreePb>, IMessage, IEquatable<MotorTaskTreePb>, IDeepCloneable<MotorTaskTreePb>, IBufferMessage
	{
		// Token: 0x0600ED8F RID: 60815 RVA: 0x0022ADB6 File Offset: 0x00228FB6
		[NullableContext(1)]
		public static MotorTaskTreePb Create()
		{
			return new MotorTaskTreePb();
		}

		// Token: 0x17003043 RID: 12355
		// (get) Token: 0x0600ED90 RID: 60816 RVA: 0x0022ADBD File Offset: 0x00228FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorTaskTreePb> Parser
		{
			get
			{
				return MotorTaskTreePb._parser;
			}
		}

		// Token: 0x17003044 RID: 12356
		// (get) Token: 0x0600ED91 RID: 60817 RVA: 0x0022ADC4 File Offset: 0x00228FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003045 RID: 12357
		// (get) Token: 0x0600ED92 RID: 60818 RVA: 0x0022ADC7 File Offset: 0x00228FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTaskTreePb.Descriptor;
			}
		}

		// Token: 0x0600ED93 RID: 60819 RVA: 0x0022ADCE File Offset: 0x00228FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskTreePb()
		{
		}

		// Token: 0x0600ED94 RID: 60820 RVA: 0x0022ADE4 File Offset: 0x00228FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskTreePb(MotorTaskTreePb other) : this()
		{
			this.treeId_ = other.treeId_;
			this.tasks_ = other.tasks_.Clone();
			this.tpRewarded_ = other.tpRewarded_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ED95 RID: 60821 RVA: 0x0022AE31 File Offset: 0x00229031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskTreePb Clone()
		{
			return new MotorTaskTreePb(this);
		}

		// Token: 0x17003046 RID: 12358
		// (get) Token: 0x0600ED96 RID: 60822 RVA: 0x0022AE39 File Offset: 0x00229039
		// (set) Token: 0x0600ED97 RID: 60823 RVA: 0x0022AE41 File Offset: 0x00229041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeId
		{
			get
			{
				return this.treeId_;
			}
			set
			{
				this.treeId_ = value;
			}
		}

		// Token: 0x17003047 RID: 12359
		// (get) Token: 0x0600ED98 RID: 60824 RVA: 0x0022AE4A File Offset: 0x0022904A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorTaskPb> Tasks
		{
			get
			{
				return this.tasks_;
			}
		}

		// Token: 0x17003048 RID: 12360
		// (get) Token: 0x0600ED99 RID: 60825 RVA: 0x0022AE52 File Offset: 0x00229052
		// (set) Token: 0x0600ED9A RID: 60826 RVA: 0x0022AE5A File Offset: 0x0022905A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TpRewarded
		{
			get
			{
				return this.tpRewarded_;
			}
			set
			{
				this.tpRewarded_ = value;
			}
		}

		// Token: 0x0600ED9B RID: 60827 RVA: 0x0022AE63 File Offset: 0x00229063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTaskTreePb);
		}

		// Token: 0x0600ED9C RID: 60828 RVA: 0x0022AE74 File Offset: 0x00229074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTaskTreePb other)
		{
			return other != null && (other == this || (this.TreeId == other.TreeId && this.tasks_.Equals(other.tasks_) && this.TpRewarded == other.TpRewarded && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ED9D RID: 60829 RVA: 0x0022AED4 File Offset: 0x002290D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeId != 0)
			{
				num ^= this.TreeId.GetHashCode();
			}
			num ^= this.tasks_.GetHashCode();
			if (this.TpRewarded != 0)
			{
				num ^= this.TpRewarded.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ED9E RID: 60830 RVA: 0x0022AF3A File Offset: 0x0022913A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ED9F RID: 60831 RVA: 0x0022AF47 File Offset: 0x00229147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EDA0 RID: 60832 RVA: 0x0022AF50 File Offset: 0x00229150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TreeId);
			}
			this.tasks_.WriteTo(ref output, MotorTaskTreePb._repeated_tasks_codec);
			if (this.TpRewarded != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TpRewarded);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EDA1 RID: 60833 RVA: 0x0022AFBC File Offset: 0x002291BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeId);
			}
			num += this.tasks_.CalculateSize(MotorTaskTreePb._repeated_tasks_codec);
			if (this.TpRewarded != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TpRewarded);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EDA2 RID: 60834 RVA: 0x0022B028 File Offset: 0x00229228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTaskTreePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeId != 0)
			{
				this.TreeId = other.TreeId;
			}
			this.tasks_.Add(other.tasks_);
			if (other.TpRewarded != 0)
			{
				this.TpRewarded = other.TpRewarded;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EDA3 RID: 60835 RVA: 0x0022B089 File Offset: 0x00229289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EDA4 RID: 60836 RVA: 0x0022B094 File Offset: 0x00229294
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
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TpRewarded = input.ReadInt32();
						}
					}
					else
					{
						this.tasks_.AddEntriesFrom(ref input, MotorTaskTreePb._repeated_tasks_codec);
					}
				}
				else
				{
					this.TreeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006034 RID: 24628
		private static readonly MessageParser<MotorTaskTreePb> _parser = new MessageParser<MotorTaskTreePb>(() => new MotorTaskTreePb());

		// Token: 0x04006035 RID: 24629
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006036 RID: 24630
		public const int TreeIdFieldNumber = 1;

		// Token: 0x04006037 RID: 24631
		private int treeId_;

		// Token: 0x04006038 RID: 24632
		public const int TasksFieldNumber = 2;

		// Token: 0x04006039 RID: 24633
		private static readonly FieldCodec<MotorTaskPb> _repeated_tasks_codec = FieldCodec.ForMessage<MotorTaskPb>(18U, MotorTaskPb.Parser);

		// Token: 0x0400603A RID: 24634
		private readonly RepeatedField<MotorTaskPb> tasks_ = new RepeatedField<MotorTaskPb>();

		// Token: 0x0400603B RID: 24635
		public const int TpRewardedFieldNumber = 3;

		// Token: 0x0400603C RID: 24636
		private int tpRewarded_;
	}
}
