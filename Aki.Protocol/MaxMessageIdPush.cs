using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D1 RID: 2513
	[NetMessage(EMessageId.MaxMessageIdPush)]
	public sealed class MaxMessageIdPush : IMessage<MaxMessageIdPush>, IMessage, IEquatable<MaxMessageIdPush>, IDeepCloneable<MaxMessageIdPush>, IBufferMessage
	{
		// Token: 0x0600DC67 RID: 56423 RVA: 0x00205C8F File Offset: 0x00203E8F
		[NullableContext(1)]
		public static MaxMessageIdPush Create()
		{
			return new MaxMessageIdPush();
		}

		// Token: 0x17002CAE RID: 11438
		// (get) Token: 0x0600DC68 RID: 56424 RVA: 0x00205C96 File Offset: 0x00203E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CAF RID: 11439
		// (get) Token: 0x0600DC69 RID: 56425 RVA: 0x00205C99 File Offset: 0x00203E99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MaxMessageIdPush.Descriptor;
			}
		}

		// Token: 0x0600DC6A RID: 56426 RVA: 0x00205CA0 File Offset: 0x00203EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaxMessageIdPush()
		{
		}

		// Token: 0x0600DC6B RID: 56427 RVA: 0x00205CA8 File Offset: 0x00203EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaxMessageIdPush(MaxMessageIdPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC6C RID: 56428 RVA: 0x00205CC1 File Offset: 0x00203EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaxMessageIdPush Clone()
		{
			return new MaxMessageIdPush(this);
		}

		// Token: 0x0600DC6D RID: 56429 RVA: 0x00205CC9 File Offset: 0x00203EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MaxMessageIdPush);
		}

		// Token: 0x0600DC6E RID: 56430 RVA: 0x00205CD7 File Offset: 0x00203ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MaxMessageIdPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600DC6F RID: 56431 RVA: 0x00205CF8 File Offset: 0x00203EF8
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

		// Token: 0x0600DC70 RID: 56432 RVA: 0x00205D1E File Offset: 0x00203F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DC71 RID: 56433 RVA: 0x00205D2B File Offset: 0x00203F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC72 RID: 56434 RVA: 0x00205D34 File Offset: 0x00203F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC73 RID: 56435 RVA: 0x00205D4C File Offset: 0x00203F4C
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

		// Token: 0x0600DC74 RID: 56436 RVA: 0x00205D72 File Offset: 0x00203F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MaxMessageIdPush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DC75 RID: 56437 RVA: 0x00205D8F File Offset: 0x00203F8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC76 RID: 56438 RVA: 0x00205D98 File Offset: 0x00203F98
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

		// Token: 0x04005B52 RID: 23378
		private UnknownFieldSet _unknownFields;
	}
}
