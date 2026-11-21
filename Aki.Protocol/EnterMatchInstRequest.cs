using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000441 RID: 1089
	[NetMessage(EMessageId.EnterMatchInstRequest)]
	public sealed class EnterMatchInstRequest : IMessage<EnterMatchInstRequest>, IMessage, IEquatable<EnterMatchInstRequest>, IDeepCloneable<EnterMatchInstRequest>, IBufferMessage
	{
		// Token: 0x060068D0 RID: 26832 RVA: 0x000FDE6B File Offset: 0x000FC06B
		[NullableContext(1)]
		public static EnterMatchInstRequest Create()
		{
			return new EnterMatchInstRequest();
		}

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x060068D1 RID: 26833 RVA: 0x000FDE72 File Offset: 0x000FC072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x060068D2 RID: 26834 RVA: 0x000FDE75 File Offset: 0x000FC075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterMatchInstRequest.Descriptor;
			}
		}

		// Token: 0x060068D3 RID: 26835 RVA: 0x000FDE7C File Offset: 0x000FC07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMatchInstRequest()
		{
		}

		// Token: 0x060068D4 RID: 26836 RVA: 0x000FDE84 File Offset: 0x000FC084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMatchInstRequest(EnterMatchInstRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060068D5 RID: 26837 RVA: 0x000FDE9D File Offset: 0x000FC09D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMatchInstRequest Clone()
		{
			return new EnterMatchInstRequest(this);
		}

		// Token: 0x060068D6 RID: 26838 RVA: 0x000FDEA5 File Offset: 0x000FC0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterMatchInstRequest);
		}

		// Token: 0x060068D7 RID: 26839 RVA: 0x000FDEB3 File Offset: 0x000FC0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterMatchInstRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060068D8 RID: 26840 RVA: 0x000FDED4 File Offset: 0x000FC0D4
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

		// Token: 0x060068D9 RID: 26841 RVA: 0x000FDEFA File Offset: 0x000FC0FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060068DA RID: 26842 RVA: 0x000FDF07 File Offset: 0x000FC107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068DB RID: 26843 RVA: 0x000FDF10 File Offset: 0x000FC110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060068DC RID: 26844 RVA: 0x000FDF28 File Offset: 0x000FC128
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

		// Token: 0x060068DD RID: 26845 RVA: 0x000FDF4E File Offset: 0x000FC14E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterMatchInstRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060068DE RID: 26846 RVA: 0x000FDF6B File Offset: 0x000FC16B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060068DF RID: 26847 RVA: 0x000FDF74 File Offset: 0x000FC174
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

		// Token: 0x04003A3C RID: 14908
		private UnknownFieldSet _unknownFields;
	}
}
