using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D07 RID: 3335
	[NetMessage(EMessageId.PhBaPlanBatchOperRequest)]
	public sealed class PhBaPlanBatchOperRequest : IMessage<PhBaPlanBatchOperRequest>, IMessage, IEquatable<PhBaPlanBatchOperRequest>, IDeepCloneable<PhBaPlanBatchOperRequest>, IBufferMessage
	{
		// Token: 0x060120AD RID: 73901 RVA: 0x002A3731 File Offset: 0x002A1931
		[NullableContext(1)]
		public static PhBaPlanBatchOperRequest Create()
		{
			return new PhBaPlanBatchOperRequest();
		}

		// Token: 0x17003BC9 RID: 15305
		// (get) Token: 0x060120AE RID: 73902 RVA: 0x002A3738 File Offset: 0x002A1938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BCA RID: 15306
		// (get) Token: 0x060120AF RID: 73903 RVA: 0x002A373B File Offset: 0x002A193B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanBatchOperRequest.Descriptor;
			}
		}

		// Token: 0x060120B0 RID: 73904 RVA: 0x002A3742 File Offset: 0x002A1942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanBatchOperRequest()
		{
		}

		// Token: 0x060120B1 RID: 73905 RVA: 0x002A3755 File Offset: 0x002A1955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanBatchOperRequest(PhBaPlanBatchOperRequest other) : this()
		{
			this.batchOper_ = other.batchOper_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060120B2 RID: 73906 RVA: 0x002A377F File Offset: 0x002A197F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanBatchOperRequest Clone()
		{
			return new PhBaPlanBatchOperRequest(this);
		}

		// Token: 0x17003BCB RID: 15307
		// (get) Token: 0x060120B3 RID: 73907 RVA: 0x002A3787 File Offset: 0x002A1987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhBaPlanBatchOper> BatchOper
		{
			get
			{
				return this.batchOper_;
			}
		}

		// Token: 0x060120B4 RID: 73908 RVA: 0x002A378F File Offset: 0x002A198F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanBatchOperRequest);
		}

		// Token: 0x060120B5 RID: 73909 RVA: 0x002A379D File Offset: 0x002A199D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanBatchOperRequest other)
		{
			return other != null && (other == this || (this.batchOper_.Equals(other.batchOper_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060120B6 RID: 73910 RVA: 0x002A37D0 File Offset: 0x002A19D0
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

		// Token: 0x060120B7 RID: 73911 RVA: 0x002A3804 File Offset: 0x002A1A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060120B8 RID: 73912 RVA: 0x002A3811 File Offset: 0x002A1A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060120B9 RID: 73913 RVA: 0x002A381A File Offset: 0x002A1A1A
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

		// Token: 0x060120BA RID: 73914 RVA: 0x002A3844 File Offset: 0x002A1A44
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

		// Token: 0x060120BB RID: 73915 RVA: 0x002A387D File Offset: 0x002A1A7D
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

		// Token: 0x060120BC RID: 73916 RVA: 0x002A38AB File Offset: 0x002A1AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060120BD RID: 73917 RVA: 0x002A38B4 File Offset: 0x002A1AB4
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.batchOper_.AddEntriesFrom(ref input, PhBaPlanBatchOperRequest._repeated_batchOper_codec);
				}
			}
		}

		// Token: 0x04007155 RID: 29013
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007156 RID: 29014
		public const int BatchOperFieldNumber = 5;

		// Token: 0x04007157 RID: 29015
		private static readonly FieldCodec<PhBaPlanBatchOper> _repeated_batchOper_codec = FieldCodec.ForMessage<PhBaPlanBatchOper>(42U, PhBaPlanBatchOper.Parser);

		// Token: 0x04007158 RID: 29016
		private readonly RepeatedField<PhBaPlanBatchOper> batchOper_ = new RepeatedField<PhBaPlanBatchOper>();
	}
}
