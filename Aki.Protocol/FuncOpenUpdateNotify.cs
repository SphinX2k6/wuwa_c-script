using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000662 RID: 1634
	[NetMessage(EMessageId.FuncOpenUpdateNotify)]
	public sealed class FuncOpenUpdateNotify : IMessage<FuncOpenUpdateNotify>, IMessage, IEquatable<FuncOpenUpdateNotify>, IDeepCloneable<FuncOpenUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600964B RID: 38475 RVA: 0x0016B0F5 File Offset: 0x001692F5
		[NullableContext(1)]
		public static FuncOpenUpdateNotify Create()
		{
			return new FuncOpenUpdateNotify();
		}

		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x0600964C RID: 38476 RVA: 0x0016B0FC File Offset: 0x001692FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x0600964D RID: 38477 RVA: 0x0016B0FF File Offset: 0x001692FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FuncOpenUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600964E RID: 38478 RVA: 0x0016B106 File Offset: 0x00169306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncOpenUpdateNotify()
		{
		}

		// Token: 0x0600964F RID: 38479 RVA: 0x0016B119 File Offset: 0x00169319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncOpenUpdateNotify(FuncOpenUpdateNotify other) : this()
		{
			this.func_ = other.func_.Clone();
			this.silent_ = other.silent_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009650 RID: 38480 RVA: 0x0016B14F File Offset: 0x0016934F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncOpenUpdateNotify Clone()
		{
			return new FuncOpenUpdateNotify(this);
		}

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x06009651 RID: 38481 RVA: 0x0016B157 File Offset: 0x00169357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Function> Func
		{
			get
			{
				return this.func_;
			}
		}

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x06009652 RID: 38482 RVA: 0x0016B15F File Offset: 0x0016935F
		// (set) Token: 0x06009653 RID: 38483 RVA: 0x0016B167 File Offset: 0x00169367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Silent
		{
			get
			{
				return this.silent_;
			}
			set
			{
				this.silent_ = value;
			}
		}

		// Token: 0x06009654 RID: 38484 RVA: 0x0016B170 File Offset: 0x00169370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FuncOpenUpdateNotify);
		}

		// Token: 0x06009655 RID: 38485 RVA: 0x0016B180 File Offset: 0x00169380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FuncOpenUpdateNotify other)
		{
			return other != null && (other == this || (this.func_.Equals(other.func_) && this.Silent == other.Silent && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009656 RID: 38486 RVA: 0x0016B1D0 File Offset: 0x001693D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.func_.GetHashCode();
			if (this.Silent)
			{
				num ^= this.Silent.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009657 RID: 38487 RVA: 0x0016B21D File Offset: 0x0016941D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009658 RID: 38488 RVA: 0x0016B22A File Offset: 0x0016942A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009659 RID: 38489 RVA: 0x0016B234 File Offset: 0x00169434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Silent)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.Silent);
			}
			this.func_.WriteTo(ref output, FuncOpenUpdateNotify._repeated_func_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600965A RID: 38490 RVA: 0x0016B284 File Offset: 0x00169484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.func_.CalculateSize(FuncOpenUpdateNotify._repeated_func_codec);
			if (this.Silent)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600965B RID: 38491 RVA: 0x0016B2CC File Offset: 0x001694CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FuncOpenUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.func_.Add(other.func_);
			if (other.Silent)
			{
				this.Silent = other.Silent;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600965C RID: 38492 RVA: 0x0016B319 File Offset: 0x00169519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600965D RID: 38493 RVA: 0x0016B324 File Offset: 0x00169524
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
				if (num != 64U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.func_.AddEntriesFrom(ref input, FuncOpenUpdateNotify._repeated_func_codec);
					}
				}
				else
				{
					this.Silent = input.ReadBool();
				}
			}
		}

		// Token: 0x04004805 RID: 18437
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004806 RID: 18438
		public const int FuncFieldNumber = 12;

		// Token: 0x04004807 RID: 18439
		private static readonly FieldCodec<Function> _repeated_func_codec = FieldCodec.ForMessage<Function>(98U, Function.Parser);

		// Token: 0x04004808 RID: 18440
		private readonly RepeatedField<Function> func_ = new RepeatedField<Function>();

		// Token: 0x04004809 RID: 18441
		public const int SilentFieldNumber = 8;

		// Token: 0x0400480A RID: 18442
		private bool silent_;
	}
}
