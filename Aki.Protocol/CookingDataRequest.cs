using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F6 RID: 758
	[NetMessage(EMessageId.CookingDataRequest)]
	public sealed class CookingDataRequest : IMessage<CookingDataRequest>, IMessage, IEquatable<CookingDataRequest>, IDeepCloneable<CookingDataRequest>, IBufferMessage
	{
		// Token: 0x06004CCA RID: 19658 RVA: 0x000BAC9C File Offset: 0x000B8E9C
		[NullableContext(1)]
		public static CookingDataRequest Create()
		{
			return new CookingDataRequest();
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06004CCB RID: 19659 RVA: 0x000BACA3 File Offset: 0x000B8EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06004CCC RID: 19660 RVA: 0x000BACA6 File Offset: 0x000B8EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookingDataRequest.Descriptor;
			}
		}

		// Token: 0x06004CCD RID: 19661 RVA: 0x000BACAD File Offset: 0x000B8EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingDataRequest()
		{
		}

		// Token: 0x06004CCE RID: 19662 RVA: 0x000BACB5 File Offset: 0x000B8EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingDataRequest(CookingDataRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004CCF RID: 19663 RVA: 0x000BACCE File Offset: 0x000B8ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingDataRequest Clone()
		{
			return new CookingDataRequest(this);
		}

		// Token: 0x06004CD0 RID: 19664 RVA: 0x000BACD6 File Offset: 0x000B8ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookingDataRequest);
		}

		// Token: 0x06004CD1 RID: 19665 RVA: 0x000BACE4 File Offset: 0x000B8EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CookingDataRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004CD2 RID: 19666 RVA: 0x000BAD04 File Offset: 0x000B8F04
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

		// Token: 0x06004CD3 RID: 19667 RVA: 0x000BAD2A File Offset: 0x000B8F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004CD4 RID: 19668 RVA: 0x000BAD37 File Offset: 0x000B8F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004CD5 RID: 19669 RVA: 0x000BAD40 File Offset: 0x000B8F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004CD6 RID: 19670 RVA: 0x000BAD58 File Offset: 0x000B8F58
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

		// Token: 0x06004CD7 RID: 19671 RVA: 0x000BAD7E File Offset: 0x000B8F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CookingDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004CD8 RID: 19672 RVA: 0x000BAD9B File Offset: 0x000B8F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004CD9 RID: 19673 RVA: 0x000BADA4 File Offset: 0x000B8FA4
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

		// Token: 0x04003119 RID: 12569
		private UnknownFieldSet _unknownFields;
	}
}
