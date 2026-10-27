using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200051A RID: 1306
	[NetMessage(EMessageId.FallFinishNotify)]
	public sealed class FallFinishNotify : IMessage<FallFinishNotify>, IMessage, IEquatable<FallFinishNotify>, IDeepCloneable<FallFinishNotify>, IBufferMessage
	{
		// Token: 0x06007AB9 RID: 31417 RVA: 0x0012A01B File Offset: 0x0012821B
		[NullableContext(1)]
		public static FallFinishNotify Create()
		{
			return new FallFinishNotify();
		}

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x06007ABA RID: 31418 RVA: 0x0012A022 File Offset: 0x00128222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x06007ABB RID: 31419 RVA: 0x0012A025 File Offset: 0x00128225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FallFinishNotify.Descriptor;
			}
		}

		// Token: 0x06007ABC RID: 31420 RVA: 0x0012A02C File Offset: 0x0012822C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FallFinishNotify()
		{
		}

		// Token: 0x06007ABD RID: 31421 RVA: 0x0012A034 File Offset: 0x00128234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FallFinishNotify(FallFinishNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007ABE RID: 31422 RVA: 0x0012A04D File Offset: 0x0012824D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FallFinishNotify Clone()
		{
			return new FallFinishNotify(this);
		}

		// Token: 0x06007ABF RID: 31423 RVA: 0x0012A055 File Offset: 0x00128255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FallFinishNotify);
		}

		// Token: 0x06007AC0 RID: 31424 RVA: 0x0012A063 File Offset: 0x00128263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FallFinishNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007AC1 RID: 31425 RVA: 0x0012A084 File Offset: 0x00128284
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

		// Token: 0x06007AC2 RID: 31426 RVA: 0x0012A0AA File Offset: 0x001282AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007AC3 RID: 31427 RVA: 0x0012A0B7 File Offset: 0x001282B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007AC4 RID: 31428 RVA: 0x0012A0C0 File Offset: 0x001282C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007AC5 RID: 31429 RVA: 0x0012A0D8 File Offset: 0x001282D8
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

		// Token: 0x06007AC6 RID: 31430 RVA: 0x0012A0FE File Offset: 0x001282FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FallFinishNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007AC7 RID: 31431 RVA: 0x0012A11B File Offset: 0x0012831B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007AC8 RID: 31432 RVA: 0x0012A124 File Offset: 0x00128324
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

		// Token: 0x04003EFE RID: 16126
		private UnknownFieldSet _unknownFields;
	}
}
