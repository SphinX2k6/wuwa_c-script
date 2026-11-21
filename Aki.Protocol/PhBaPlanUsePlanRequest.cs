using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D14 RID: 3348
	[NetMessage(EMessageId.PhBaPlanUsePlanRequest)]
	public sealed class PhBaPlanUsePlanRequest : IMessage<PhBaPlanUsePlanRequest>, IMessage, IEquatable<PhBaPlanUsePlanRequest>, IDeepCloneable<PhBaPlanUsePlanRequest>, IBufferMessage
	{
		// Token: 0x060121A5 RID: 74149 RVA: 0x002A54F0 File Offset: 0x002A36F0
		[NullableContext(1)]
		public static PhBaPlanUsePlanRequest Create()
		{
			return new PhBaPlanUsePlanRequest();
		}

		// Token: 0x17003BF7 RID: 15351
		// (get) Token: 0x060121A6 RID: 74150 RVA: 0x002A54F7 File Offset: 0x002A36F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BF8 RID: 15352
		// (get) Token: 0x060121A7 RID: 74151 RVA: 0x002A54FA File Offset: 0x002A36FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanUsePlanRequest.Descriptor;
			}
		}

		// Token: 0x060121A8 RID: 74152 RVA: 0x002A5501 File Offset: 0x002A3701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUsePlanRequest()
		{
		}

		// Token: 0x060121A9 RID: 74153 RVA: 0x002A5509 File Offset: 0x002A3709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUsePlanRequest(PhBaPlanUsePlanRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060121AA RID: 74154 RVA: 0x002A5522 File Offset: 0x002A3722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUsePlanRequest Clone()
		{
			return new PhBaPlanUsePlanRequest(this);
		}

		// Token: 0x060121AB RID: 74155 RVA: 0x002A552A File Offset: 0x002A372A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanUsePlanRequest);
		}

		// Token: 0x060121AC RID: 74156 RVA: 0x002A5538 File Offset: 0x002A3738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanUsePlanRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060121AD RID: 74157 RVA: 0x002A5558 File Offset: 0x002A3758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060121AE RID: 74158 RVA: 0x002A557E File Offset: 0x002A377E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060121AF RID: 74159 RVA: 0x002A558B File Offset: 0x002A378B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060121B0 RID: 74160 RVA: 0x002A5594 File Offset: 0x002A3794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060121B1 RID: 74161 RVA: 0x002A55AC File Offset: 0x002A37AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060121B2 RID: 74162 RVA: 0x002A55D2 File Offset: 0x002A37D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanUsePlanRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060121B3 RID: 74163 RVA: 0x002A55EF File Offset: 0x002A37EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060121B4 RID: 74164 RVA: 0x002A55F8 File Offset: 0x002A37F8
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400718B RID: 29067
		private UnknownFieldSet _unknownFields;
	}
}
