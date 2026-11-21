using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DCC RID: 3532
	[NetMessage(EMessageId.PrivateChatDataRequest)]
	public sealed class PrivateChatDataRequest : IMessage<PrivateChatDataRequest>, IMessage, IEquatable<PrivateChatDataRequest>, IDeepCloneable<PrivateChatDataRequest>, IBufferMessage
	{
		// Token: 0x06013098 RID: 77976 RVA: 0x002C6BB1 File Offset: 0x002C4DB1
		[NullableContext(1)]
		public static PrivateChatDataRequest Create()
		{
			return new PrivateChatDataRequest();
		}

		// Token: 0x17003F2E RID: 16174
		// (get) Token: 0x06013099 RID: 77977 RVA: 0x002C6BB8 File Offset: 0x002C4DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F2F RID: 16175
		// (get) Token: 0x0601309A RID: 77978 RVA: 0x002C6BBB File Offset: 0x002C4DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatDataRequest.Descriptor;
			}
		}

		// Token: 0x0601309B RID: 77979 RVA: 0x002C6BC2 File Offset: 0x002C4DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatDataRequest()
		{
		}

		// Token: 0x0601309C RID: 77980 RVA: 0x002C6BCA File Offset: 0x002C4DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatDataRequest(PrivateChatDataRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601309D RID: 77981 RVA: 0x002C6BE3 File Offset: 0x002C4DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatDataRequest Clone()
		{
			return new PrivateChatDataRequest(this);
		}

		// Token: 0x0601309E RID: 77982 RVA: 0x002C6BEB File Offset: 0x002C4DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatDataRequest);
		}

		// Token: 0x0601309F RID: 77983 RVA: 0x002C6BF9 File Offset: 0x002C4DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatDataRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060130A0 RID: 77984 RVA: 0x002C6C18 File Offset: 0x002C4E18
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

		// Token: 0x060130A1 RID: 77985 RVA: 0x002C6C3E File Offset: 0x002C4E3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060130A2 RID: 77986 RVA: 0x002C6C4B File Offset: 0x002C4E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060130A3 RID: 77987 RVA: 0x002C6C54 File Offset: 0x002C4E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060130A4 RID: 77988 RVA: 0x002C6C6C File Offset: 0x002C4E6C
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

		// Token: 0x060130A5 RID: 77989 RVA: 0x002C6C92 File Offset: 0x002C4E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateChatDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060130A6 RID: 77990 RVA: 0x002C6CAF File Offset: 0x002C4EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060130A7 RID: 77991 RVA: 0x002C6CB8 File Offset: 0x002C4EB8
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

		// Token: 0x040075E6 RID: 30182
		private UnknownFieldSet _unknownFields;
	}
}
