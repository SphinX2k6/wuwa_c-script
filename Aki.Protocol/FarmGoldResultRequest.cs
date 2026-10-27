using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200052B RID: 1323
	[NetMessage(EMessageId.FarmGoldResultRequest)]
	public sealed class FarmGoldResultRequest : IMessage<FarmGoldResultRequest>, IMessage, IEquatable<FarmGoldResultRequest>, IDeepCloneable<FarmGoldResultRequest>, IBufferMessage
	{
		// Token: 0x06007C0A RID: 31754 RVA: 0x0012CB01 File Offset: 0x0012AD01
		[NullableContext(1)]
		public static FarmGoldResultRequest Create()
		{
			return new FarmGoldResultRequest();
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x06007C0B RID: 31755 RVA: 0x0012CB08 File Offset: 0x0012AD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x06007C0C RID: 31756 RVA: 0x0012CB0B File Offset: 0x0012AD0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldResultRequest.Descriptor;
			}
		}

		// Token: 0x06007C0D RID: 31757 RVA: 0x0012CB12 File Offset: 0x0012AD12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldResultRequest()
		{
		}

		// Token: 0x06007C0E RID: 31758 RVA: 0x0012CB1A File Offset: 0x0012AD1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldResultRequest(FarmGoldResultRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C0F RID: 31759 RVA: 0x0012CB33 File Offset: 0x0012AD33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldResultRequest Clone()
		{
			return new FarmGoldResultRequest(this);
		}

		// Token: 0x06007C10 RID: 31760 RVA: 0x0012CB3B File Offset: 0x0012AD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldResultRequest);
		}

		// Token: 0x06007C11 RID: 31761 RVA: 0x0012CB49 File Offset: 0x0012AD49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldResultRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007C12 RID: 31762 RVA: 0x0012CB68 File Offset: 0x0012AD68
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

		// Token: 0x06007C13 RID: 31763 RVA: 0x0012CB8E File Offset: 0x0012AD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007C14 RID: 31764 RVA: 0x0012CB9B File Offset: 0x0012AD9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C15 RID: 31765 RVA: 0x0012CBA4 File Offset: 0x0012ADA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C16 RID: 31766 RVA: 0x0012CBBC File Offset: 0x0012ADBC
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

		// Token: 0x06007C17 RID: 31767 RVA: 0x0012CBE2 File Offset: 0x0012ADE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007C18 RID: 31768 RVA: 0x0012CBFF File Offset: 0x0012ADFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C19 RID: 31769 RVA: 0x0012CC08 File Offset: 0x0012AE08
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

		// Token: 0x04003F55 RID: 16213
		private UnknownFieldSet _unknownFields;
	}
}
