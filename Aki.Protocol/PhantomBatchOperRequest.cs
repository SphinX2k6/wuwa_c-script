using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C1E RID: 3102
	[NetMessage(EMessageId.PhantomBatchOperRequest)]
	public sealed class PhantomBatchOperRequest : IMessage<PhantomBatchOperRequest>, IMessage, IEquatable<PhantomBatchOperRequest>, IDeepCloneable<PhantomBatchOperRequest>, IBufferMessage
	{
		// Token: 0x06010D64 RID: 68964 RVA: 0x00277477 File Offset: 0x00275677
		[NullableContext(1)]
		public static PhantomBatchOperRequest Create()
		{
			return new PhantomBatchOperRequest();
		}

		// Token: 0x17003796 RID: 14230
		// (get) Token: 0x06010D65 RID: 68965 RVA: 0x0027747E File Offset: 0x0027567E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003797 RID: 14231
		// (get) Token: 0x06010D66 RID: 68966 RVA: 0x00277481 File Offset: 0x00275681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBatchOperRequest.Descriptor;
			}
		}

		// Token: 0x06010D67 RID: 68967 RVA: 0x00277488 File Offset: 0x00275688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchOperRequest()
		{
		}

		// Token: 0x06010D68 RID: 68968 RVA: 0x0027749B File Offset: 0x0027569B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchOperRequest(PhantomBatchOperRequest other) : this()
		{
			this.oper_ = other.oper_;
			this.incrId_ = other.incrId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010D69 RID: 68969 RVA: 0x002774D1 File Offset: 0x002756D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchOperRequest Clone()
		{
			return new PhantomBatchOperRequest(this);
		}

		// Token: 0x17003798 RID: 14232
		// (get) Token: 0x06010D6A RID: 68970 RVA: 0x002774D9 File Offset: 0x002756D9
		// (set) Token: 0x06010D6B RID: 68971 RVA: 0x002774E1 File Offset: 0x002756E1
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

		// Token: 0x17003799 RID: 14233
		// (get) Token: 0x06010D6C RID: 68972 RVA: 0x002774EA File Offset: 0x002756EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> IncrId
		{
			get
			{
				return this.incrId_;
			}
		}

		// Token: 0x06010D6D RID: 68973 RVA: 0x002774F2 File Offset: 0x002756F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBatchOperRequest);
		}

		// Token: 0x06010D6E RID: 68974 RVA: 0x00277500 File Offset: 0x00275700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBatchOperRequest other)
		{
			return other != null && (other == this || (this.Oper == other.Oper && this.incrId_.Equals(other.incrId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010D6F RID: 68975 RVA: 0x00277550 File Offset: 0x00275750
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

		// Token: 0x06010D70 RID: 68976 RVA: 0x002775A3 File Offset: 0x002757A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010D71 RID: 68977 RVA: 0x002775B0 File Offset: 0x002757B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010D72 RID: 68978 RVA: 0x002775BC File Offset: 0x002757BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Oper != PhantomBatchOper.Lock)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Oper);
			}
			this.incrId_.WriteTo(ref output, PhantomBatchOperRequest._repeated_incrId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010D73 RID: 68979 RVA: 0x0027760C File Offset: 0x0027580C
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

		// Token: 0x06010D74 RID: 68980 RVA: 0x00277660 File Offset: 0x00275860
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

		// Token: 0x06010D75 RID: 68981 RVA: 0x002776AD File Offset: 0x002758AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010D76 RID: 68982 RVA: 0x002776B8 File Offset: 0x002758B8
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
				if (num != 72U)
				{
					if (num != 88U && num != 90U)
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

		// Token: 0x04006AE6 RID: 27366
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006AE7 RID: 27367
		public const int OperFieldNumber = 9;

		// Token: 0x04006AE8 RID: 27368
		private PhantomBatchOper oper_;

		// Token: 0x04006AE9 RID: 27369
		public const int IncrIdFieldNumber = 11;

		// Token: 0x04006AEA RID: 27370
		private static readonly FieldCodec<int> _repeated_incrId_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04006AEB RID: 27371
		private readonly RepeatedField<int> incrId_ = new RepeatedField<int>();
	}
}
