using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C0 RID: 2496
	[NetMessage(EMessageId.MaxMessageIdPush)]
	public sealed class MaxMessageIdPush : IMessage<MaxMessageIdPush>, IMessage, IEquatable<MaxMessageIdPush>, IDeepCloneable<MaxMessageIdPush>, IBufferMessage
	{
		// Token: 0x0600DB4D RID: 56141 RVA: 0x00203A9F File Offset: 0x00201C9F
		[NullableContext(1)]
		public static MaxMessageIdPush Create()
		{
			return new MaxMessageIdPush();
		}

		// Token: 0x17002C70 RID: 11376
		// (get) Token: 0x0600DB4E RID: 56142 RVA: 0x00203AA6 File Offset: 0x00201CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C71 RID: 11377
		// (get) Token: 0x0600DB4F RID: 56143 RVA: 0x00203AA9 File Offset: 0x00201CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MaxMessageIdPush.Descriptor;
			}
		}

		// Token: 0x0600DB50 RID: 56144 RVA: 0x00203AB0 File Offset: 0x00201CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaxMessageIdPush()
		{
		}

		// Token: 0x0600DB51 RID: 56145 RVA: 0x00203AB8 File Offset: 0x00201CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaxMessageIdPush(MaxMessageIdPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB52 RID: 56146 RVA: 0x00203AD1 File Offset: 0x00201CD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaxMessageIdPush Clone()
		{
			return new MaxMessageIdPush(this);
		}

		// Token: 0x0600DB53 RID: 56147 RVA: 0x00203AD9 File Offset: 0x00201CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MaxMessageIdPush);
		}

		// Token: 0x0600DB54 RID: 56148 RVA: 0x00203AE7 File Offset: 0x00201CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MaxMessageIdPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600DB55 RID: 56149 RVA: 0x00203B08 File Offset: 0x00201D08
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

		// Token: 0x0600DB56 RID: 56150 RVA: 0x00203B2E File Offset: 0x00201D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DB57 RID: 56151 RVA: 0x00203B3B File Offset: 0x00201D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB58 RID: 56152 RVA: 0x00203B44 File Offset: 0x00201D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DB59 RID: 56153 RVA: 0x00203B5C File Offset: 0x00201D5C
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

		// Token: 0x0600DB5A RID: 56154 RVA: 0x00203B82 File Offset: 0x00201D82
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

		// Token: 0x0600DB5B RID: 56155 RVA: 0x00203B9F File Offset: 0x00201D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB5C RID: 56156 RVA: 0x00203BA8 File Offset: 0x00201DA8
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

		// Token: 0x04005B5B RID: 23387
		private UnknownFieldSet _unknownFields;
	}
}
