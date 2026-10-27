using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B5E RID: 2910
	[NetMessage(EMessageId.NormalItemRequest)]
	public sealed class NormalItemRequest : IMessage<NormalItemRequest>, IMessage, IEquatable<NormalItemRequest>, IDeepCloneable<NormalItemRequest>, IBufferMessage
	{
		// Token: 0x0600FC34 RID: 64564 RVA: 0x0024BC49 File Offset: 0x00249E49
		[NullableContext(1)]
		public static NormalItemRequest Create()
		{
			return new NormalItemRequest();
		}

		// Token: 0x1700336B RID: 13163
		// (get) Token: 0x0600FC35 RID: 64565 RVA: 0x0024BC50 File Offset: 0x00249E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700336C RID: 13164
		// (get) Token: 0x0600FC36 RID: 64566 RVA: 0x0024BC53 File Offset: 0x00249E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalItemRequest.Descriptor;
			}
		}

		// Token: 0x0600FC37 RID: 64567 RVA: 0x0024BC5A File Offset: 0x00249E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemRequest()
		{
		}

		// Token: 0x0600FC38 RID: 64568 RVA: 0x0024BC62 File Offset: 0x00249E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemRequest(NormalItemRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FC39 RID: 64569 RVA: 0x0024BC7B File Offset: 0x00249E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemRequest Clone()
		{
			return new NormalItemRequest(this);
		}

		// Token: 0x0600FC3A RID: 64570 RVA: 0x0024BC83 File Offset: 0x00249E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalItemRequest);
		}

		// Token: 0x0600FC3B RID: 64571 RVA: 0x0024BC91 File Offset: 0x00249E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalItemRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600FC3C RID: 64572 RVA: 0x0024BCB0 File Offset: 0x00249EB0
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

		// Token: 0x0600FC3D RID: 64573 RVA: 0x0024BCD6 File Offset: 0x00249ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FC3E RID: 64574 RVA: 0x0024BCE3 File Offset: 0x00249EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FC3F RID: 64575 RVA: 0x0024BCEC File Offset: 0x00249EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FC40 RID: 64576 RVA: 0x0024BD04 File Offset: 0x00249F04
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

		// Token: 0x0600FC41 RID: 64577 RVA: 0x0024BD2A File Offset: 0x00249F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NormalItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FC42 RID: 64578 RVA: 0x0024BD47 File Offset: 0x00249F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FC43 RID: 64579 RVA: 0x0024BD50 File Offset: 0x00249F50
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

		// Token: 0x040064B8 RID: 25784
		private UnknownFieldSet _unknownFields;
	}
}
