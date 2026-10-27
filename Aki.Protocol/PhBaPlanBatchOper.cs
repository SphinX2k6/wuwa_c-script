using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D16 RID: 3350
	public sealed class PhBaPlanBatchOper : IMessage<PhBaPlanBatchOper>, IMessage, IEquatable<PhBaPlanBatchOper>, IDeepCloneable<PhBaPlanBatchOper>, IBufferMessage
	{
		// Token: 0x06012194 RID: 74132 RVA: 0x002A5083 File Offset: 0x002A3283
		[NullableContext(1)]
		public static PhBaPlanBatchOper Create()
		{
			return new PhBaPlanBatchOper();
		}

		// Token: 0x17003BF9 RID: 15353
		// (get) Token: 0x06012195 RID: 74133 RVA: 0x002A508A File Offset: 0x002A328A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhBaPlanBatchOper> Parser
		{
			get
			{
				return PhBaPlanBatchOper._parser;
			}
		}

		// Token: 0x17003BFA RID: 15354
		// (get) Token: 0x06012196 RID: 74134 RVA: 0x002A5091 File Offset: 0x002A3291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BFB RID: 15355
		// (get) Token: 0x06012197 RID: 74135 RVA: 0x002A5094 File Offset: 0x002A3294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanBatchOper.Descriptor;
			}
		}

		// Token: 0x06012198 RID: 74136 RVA: 0x002A509B File Offset: 0x002A329B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanBatchOper()
		{
		}

		// Token: 0x06012199 RID: 74137 RVA: 0x002A50AE File Offset: 0x002A32AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanBatchOper(PhBaPlanBatchOper other) : this()
		{
			this.oper_ = other.oper_;
			this.incrId_ = other.incrId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601219A RID: 74138 RVA: 0x002A50E4 File Offset: 0x002A32E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanBatchOper Clone()
		{
			return new PhBaPlanBatchOper(this);
		}

		// Token: 0x17003BFC RID: 15356
		// (get) Token: 0x0601219B RID: 74139 RVA: 0x002A50EC File Offset: 0x002A32EC
		// (set) Token: 0x0601219C RID: 74140 RVA: 0x002A50F4 File Offset: 0x002A32F4
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

		// Token: 0x17003BFD RID: 15357
		// (get) Token: 0x0601219D RID: 74141 RVA: 0x002A50FD File Offset: 0x002A32FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> IncrId
		{
			get
			{
				return this.incrId_;
			}
		}

		// Token: 0x0601219E RID: 74142 RVA: 0x002A5105 File Offset: 0x002A3305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanBatchOper);
		}

		// Token: 0x0601219F RID: 74143 RVA: 0x002A5114 File Offset: 0x002A3314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanBatchOper other)
		{
			return other != null && (other == this || (this.Oper == other.Oper && this.incrId_.Equals(other.incrId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060121A0 RID: 74144 RVA: 0x002A5164 File Offset: 0x002A3364
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

		// Token: 0x060121A1 RID: 74145 RVA: 0x002A51B7 File Offset: 0x002A33B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060121A2 RID: 74146 RVA: 0x002A51C4 File Offset: 0x002A33C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060121A3 RID: 74147 RVA: 0x002A51D0 File Offset: 0x002A33D0
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

		// Token: 0x060121A4 RID: 74148 RVA: 0x002A5220 File Offset: 0x002A3420
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

		// Token: 0x060121A5 RID: 74149 RVA: 0x002A5274 File Offset: 0x002A3474
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

		// Token: 0x060121A6 RID: 74150 RVA: 0x002A52C1 File Offset: 0x002A34C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060121A7 RID: 74151 RVA: 0x002A52CC File Offset: 0x002A34CC
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

		// Token: 0x04007136 RID: 28982
		private static readonly MessageParser<PhBaPlanBatchOper> _parser = new MessageParser<PhBaPlanBatchOper>(() => new PhBaPlanBatchOper());

		// Token: 0x04007137 RID: 28983
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007138 RID: 28984
		public const int OperFieldNumber = 1;

		// Token: 0x04007139 RID: 28985
		private PhantomBatchOper oper_;

		// Token: 0x0400713A RID: 28986
		public const int IncrIdFieldNumber = 2;

		// Token: 0x0400713B RID: 28987
		private static readonly FieldCodec<int> _repeated_incrId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400713C RID: 28988
		private readonly RepeatedField<int> incrId_ = new RepeatedField<int>();
	}
}
