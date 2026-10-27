using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D17 RID: 3351
	[NetMessage(EMessageId.PhBaPlanBatchOperRequest)]
	public sealed class PhBaPlanBatchOperRequest : IMessage<PhBaPlanBatchOperRequest>, IMessage, IEquatable<PhBaPlanBatchOperRequest>, IDeepCloneable<PhBaPlanBatchOperRequest>, IBufferMessage
	{
		// Token: 0x060121A9 RID: 74153 RVA: 0x002A5355 File Offset: 0x002A3555
		[NullableContext(1)]
		public static PhBaPlanBatchOperRequest Create()
		{
			return new PhBaPlanBatchOperRequest();
		}

		// Token: 0x17003BFE RID: 15358
		// (get) Token: 0x060121AA RID: 74154 RVA: 0x002A535C File Offset: 0x002A355C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BFF RID: 15359
		// (get) Token: 0x060121AB RID: 74155 RVA: 0x002A535F File Offset: 0x002A355F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanBatchOperRequest.Descriptor;
			}
		}

		// Token: 0x060121AC RID: 74156 RVA: 0x002A5366 File Offset: 0x002A3566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanBatchOperRequest()
		{
		}

		// Token: 0x060121AD RID: 74157 RVA: 0x002A5379 File Offset: 0x002A3579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanBatchOperRequest(PhBaPlanBatchOperRequest other) : this()
		{
			this.batchOper_ = other.batchOper_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060121AE RID: 74158 RVA: 0x002A53A3 File Offset: 0x002A35A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanBatchOperRequest Clone()
		{
			return new PhBaPlanBatchOperRequest(this);
		}

		// Token: 0x17003C00 RID: 15360
		// (get) Token: 0x060121AF RID: 74159 RVA: 0x002A53AB File Offset: 0x002A35AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhBaPlanBatchOper> BatchOper
		{
			get
			{
				return this.batchOper_;
			}
		}

		// Token: 0x060121B0 RID: 74160 RVA: 0x002A53B3 File Offset: 0x002A35B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanBatchOperRequest);
		}

		// Token: 0x060121B1 RID: 74161 RVA: 0x002A53C1 File Offset: 0x002A35C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanBatchOperRequest other)
		{
			return other != null && (other == this || (this.batchOper_.Equals(other.batchOper_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060121B2 RID: 74162 RVA: 0x002A53F4 File Offset: 0x002A35F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.batchOper_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060121B3 RID: 74163 RVA: 0x002A5428 File Offset: 0x002A3628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060121B4 RID: 74164 RVA: 0x002A5435 File Offset: 0x002A3635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060121B5 RID: 74165 RVA: 0x002A543E File Offset: 0x002A363E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.batchOper_.WriteTo(ref output, PhBaPlanBatchOperRequest._repeated_batchOper_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060121B6 RID: 74166 RVA: 0x002A5468 File Offset: 0x002A3668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.batchOper_.CalculateSize(PhBaPlanBatchOperRequest._repeated_batchOper_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060121B7 RID: 74167 RVA: 0x002A54A1 File Offset: 0x002A36A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanBatchOperRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.batchOper_.Add(other.batchOper_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060121B8 RID: 74168 RVA: 0x002A54CF File Offset: 0x002A36CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060121B9 RID: 74169 RVA: 0x002A54D8 File Offset: 0x002A36D8
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.batchOper_.AddEntriesFrom(ref input, PhBaPlanBatchOperRequest._repeated_batchOper_codec);
				}
			}
		}

		// Token: 0x0400713D RID: 28989
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400713E RID: 28990
		public const int BatchOperFieldNumber = 10;

		// Token: 0x0400713F RID: 28991
		private static readonly FieldCodec<PhBaPlanBatchOper> _repeated_batchOper_codec = FieldCodec.ForMessage<PhBaPlanBatchOper>(82U, PhBaPlanBatchOper.Parser);

		// Token: 0x04007140 RID: 28992
		private readonly RepeatedField<PhBaPlanBatchOper> batchOper_ = new RepeatedField<PhBaPlanBatchOper>();
	}
}
