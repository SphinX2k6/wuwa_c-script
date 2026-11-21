using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C0E RID: 3086
	[NetMessage(EMessageId.PhantomBatchOperRequest)]
	public sealed class PhantomBatchOperRequest : IMessage<PhantomBatchOperRequest>, IMessage, IEquatable<PhantomBatchOperRequest>, IDeepCloneable<PhantomBatchOperRequest>, IBufferMessage
	{
		// Token: 0x06010C64 RID: 68708 RVA: 0x00275713 File Offset: 0x00273913
		[NullableContext(1)]
		public static PhantomBatchOperRequest Create()
		{
			return new PhantomBatchOperRequest();
		}

		// Token: 0x1700375F RID: 14175
		// (get) Token: 0x06010C65 RID: 68709 RVA: 0x0027571A File Offset: 0x0027391A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003760 RID: 14176
		// (get) Token: 0x06010C66 RID: 68710 RVA: 0x0027571D File Offset: 0x0027391D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBatchOperRequest.Descriptor;
			}
		}

		// Token: 0x06010C67 RID: 68711 RVA: 0x00275724 File Offset: 0x00273924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchOperRequest()
		{
		}

		// Token: 0x06010C68 RID: 68712 RVA: 0x00275737 File Offset: 0x00273937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchOperRequest(PhantomBatchOperRequest other) : this()
		{
			this.oper_ = other.oper_;
			this.incrId_ = other.incrId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010C69 RID: 68713 RVA: 0x0027576D File Offset: 0x0027396D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchOperRequest Clone()
		{
			return new PhantomBatchOperRequest(this);
		}

		// Token: 0x17003761 RID: 14177
		// (get) Token: 0x06010C6A RID: 68714 RVA: 0x00275775 File Offset: 0x00273975
		// (set) Token: 0x06010C6B RID: 68715 RVA: 0x0027577D File Offset: 0x0027397D
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

		// Token: 0x17003762 RID: 14178
		// (get) Token: 0x06010C6C RID: 68716 RVA: 0x00275786 File Offset: 0x00273986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> IncrId
		{
			get
			{
				return this.incrId_;
			}
		}

		// Token: 0x06010C6D RID: 68717 RVA: 0x0027578E File Offset: 0x0027398E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBatchOperRequest);
		}

		// Token: 0x06010C6E RID: 68718 RVA: 0x0027579C File Offset: 0x0027399C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBatchOperRequest other)
		{
			return other != null && (other == this || (this.Oper == other.Oper && this.incrId_.Equals(other.incrId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010C6F RID: 68719 RVA: 0x002757EC File Offset: 0x002739EC
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

		// Token: 0x06010C70 RID: 68720 RVA: 0x0027583F File Offset: 0x00273A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010C71 RID: 68721 RVA: 0x0027584C File Offset: 0x00273A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010C72 RID: 68722 RVA: 0x00275858 File Offset: 0x00273A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Oper != PhantomBatchOper.Lock)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Oper);
			}
			this.incrId_.WriteTo(ref output, PhantomBatchOperRequest._repeated_incrId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010C73 RID: 68723 RVA: 0x002758A8 File Offset: 0x00273AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Oper != PhantomBatchOper.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Oper);
			}
			num += this.incrId_.CalculateSize(PhantomBatchOperRequest._repeated_incrId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010C74 RID: 68724 RVA: 0x002758FC File Offset: 0x00273AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBatchOperRequest other)
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

		// Token: 0x06010C75 RID: 68725 RVA: 0x00275949 File Offset: 0x00273B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010C76 RID: 68726 RVA: 0x00275954 File Offset: 0x00273B54
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
					if (num != 80U && num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.incrId_.AddEntriesFrom(ref input, PhantomBatchOperRequest._repeated_incrId_codec);
					}
				}
				else
				{
					this.Oper = (PhantomBatchOper)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006AFA RID: 27386
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006AFB RID: 27387
		public const int OperFieldNumber = 1;

		// Token: 0x04006AFC RID: 27388
		private PhantomBatchOper oper_;

		// Token: 0x04006AFD RID: 27389
		public const int IncrIdFieldNumber = 10;

		// Token: 0x04006AFE RID: 27390
		private static readonly FieldCodec<int> _repeated_incrId_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04006AFF RID: 27391
		private readonly RepeatedField<int> incrId_ = new RepeatedField<int>();
	}
}
