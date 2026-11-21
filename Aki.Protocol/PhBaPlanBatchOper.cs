using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D06 RID: 3334
	public sealed class PhBaPlanBatchOper : IMessage<PhBaPlanBatchOper>, IMessage, IEquatable<PhBaPlanBatchOper>, IDeepCloneable<PhBaPlanBatchOper>, IBufferMessage
	{
		// Token: 0x06012098 RID: 73880 RVA: 0x002A345F File Offset: 0x002A165F
		[NullableContext(1)]
		public static PhBaPlanBatchOper Create()
		{
			return new PhBaPlanBatchOper();
		}

		// Token: 0x17003BC4 RID: 15300
		// (get) Token: 0x06012099 RID: 73881 RVA: 0x002A3466 File Offset: 0x002A1666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhBaPlanBatchOper> Parser
		{
			get
			{
				return PhBaPlanBatchOper._parser;
			}
		}

		// Token: 0x17003BC5 RID: 15301
		// (get) Token: 0x0601209A RID: 73882 RVA: 0x002A346D File Offset: 0x002A166D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BC6 RID: 15302
		// (get) Token: 0x0601209B RID: 73883 RVA: 0x002A3470 File Offset: 0x002A1670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanBatchOper.Descriptor;
			}
		}

		// Token: 0x0601209C RID: 73884 RVA: 0x002A3477 File Offset: 0x002A1677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanBatchOper()
		{
		}

		// Token: 0x0601209D RID: 73885 RVA: 0x002A348A File Offset: 0x002A168A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanBatchOper(PhBaPlanBatchOper other) : this()
		{
			this.oper_ = other.oper_;
			this.incrId_ = other.incrId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601209E RID: 73886 RVA: 0x002A34C0 File Offset: 0x002A16C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanBatchOper Clone()
		{
			return new PhBaPlanBatchOper(this);
		}

		// Token: 0x17003BC7 RID: 15303
		// (get) Token: 0x0601209F RID: 73887 RVA: 0x002A34C8 File Offset: 0x002A16C8
		// (set) Token: 0x060120A0 RID: 73888 RVA: 0x002A34D0 File Offset: 0x002A16D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchOper Oper
		{
			get
			{
				return this.oper_;
			}
			set
			{
				this.oper_ = value;
			}
		}

		// Token: 0x17003BC8 RID: 15304
		// (get) Token: 0x060120A1 RID: 73889 RVA: 0x002A34D9 File Offset: 0x002A16D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> IncrId
		{
			get
			{
				return this.incrId_;
			}
		}

		// Token: 0x060120A2 RID: 73890 RVA: 0x002A34E1 File Offset: 0x002A16E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanBatchOper);
		}

		// Token: 0x060120A3 RID: 73891 RVA: 0x002A34F0 File Offset: 0x002A16F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanBatchOper other)
		{
			return other != null && (other == this || (this.Oper == other.Oper && this.incrId_.Equals(other.incrId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060120A4 RID: 73892 RVA: 0x002A3540 File Offset: 0x002A1740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Oper != PhantomBatchOper.Lock)
			{
				num ^= this.Oper.GetHashCode();
			}
			num ^= this.incrId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060120A5 RID: 73893 RVA: 0x002A3593 File Offset: 0x002A1793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060120A6 RID: 73894 RVA: 0x002A35A0 File Offset: 0x002A17A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060120A7 RID: 73895 RVA: 0x002A35AC File Offset: 0x002A17AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Oper != PhantomBatchOper.Lock)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Oper);
			}
			this.incrId_.WriteTo(ref output, PhBaPlanBatchOper._repeated_incrId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060120A8 RID: 73896 RVA: 0x002A35FC File Offset: 0x002A17FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Oper != PhantomBatchOper.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Oper);
			}
			num += this.incrId_.CalculateSize(PhBaPlanBatchOper._repeated_incrId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060120A9 RID: 73897 RVA: 0x002A3650 File Offset: 0x002A1850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanBatchOper other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Oper != PhantomBatchOper.Lock)
			{
				this.Oper = other.Oper;
			}
			this.incrId_.Add(other.incrId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060120AA RID: 73898 RVA: 0x002A369D File Offset: 0x002A189D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060120AB RID: 73899 RVA: 0x002A36A8 File Offset: 0x002A18A8
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.incrId_.AddEntriesFrom(ref input, PhBaPlanBatchOper._repeated_incrId_codec);
					}
				}
				else
				{
					this.Oper = (PhantomBatchOper)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400714E RID: 29006
		private static readonly MessageParser<PhBaPlanBatchOper> _parser = new MessageParser<PhBaPlanBatchOper>(() => new PhBaPlanBatchOper());

		// Token: 0x0400714F RID: 29007
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007150 RID: 29008
		public const int OperFieldNumber = 1;

		// Token: 0x04007151 RID: 29009
		private PhantomBatchOper oper_;

		// Token: 0x04007152 RID: 29010
		public const int IncrIdFieldNumber = 2;

		// Token: 0x04007153 RID: 29011
		private static readonly FieldCodec<int> _repeated_incrId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007154 RID: 29012
		private readonly RepeatedField<int> incrId_ = new RepeatedField<int>();
	}
}
