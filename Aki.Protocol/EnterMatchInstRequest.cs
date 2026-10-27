using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000458 RID: 1112
	[NetMessage(EMessageId.EnterMatchInstRequest)]
	public sealed class EnterMatchInstRequest : IMessage<EnterMatchInstRequest>, IMessage, IEquatable<EnterMatchInstRequest>, IDeepCloneable<EnterMatchInstRequest>, IBufferMessage
	{
		// Token: 0x06006A5E RID: 27230 RVA: 0x00100ED6 File Offset: 0x000FF0D6
		[NullableContext(1)]
		public static EnterMatchInstRequest Create()
		{
			return new EnterMatchInstRequest();
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06006A5F RID: 27231 RVA: 0x00100EDD File Offset: 0x000FF0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x06006A60 RID: 27232 RVA: 0x00100EE0 File Offset: 0x000FF0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterMatchInstRequest.Descriptor;
			}
		}

		// Token: 0x06006A61 RID: 27233 RVA: 0x00100EE7 File Offset: 0x000FF0E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMatchInstRequest()
		{
		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x00100EEF File Offset: 0x000FF0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMatchInstRequest(EnterMatchInstRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A63 RID: 27235 RVA: 0x00100F08 File Offset: 0x000FF108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMatchInstRequest Clone()
		{
			return new EnterMatchInstRequest(this);
		}

		// Token: 0x06006A64 RID: 27236 RVA: 0x00100F10 File Offset: 0x000FF110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterMatchInstRequest);
		}

		// Token: 0x06006A65 RID: 27237 RVA: 0x00100F1E File Offset: 0x000FF11E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterMatchInstRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006A66 RID: 27238 RVA: 0x00100F3C File Offset: 0x000FF13C
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

		// Token: 0x06006A67 RID: 27239 RVA: 0x00100F62 File Offset: 0x000FF162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006A68 RID: 27240 RVA: 0x00100F6F File Offset: 0x000FF16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A69 RID: 27241 RVA: 0x00100F78 File Offset: 0x000FF178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A6A RID: 27242 RVA: 0x00100F90 File Offset: 0x000FF190
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

		// Token: 0x06006A6B RID: 27243 RVA: 0x00100FB6 File Offset: 0x000FF1B6
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

		// Token: 0x06006A6C RID: 27244 RVA: 0x00100FD3 File Offset: 0x000FF1D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A6D RID: 27245 RVA: 0x00100FDC File Offset: 0x000FF1DC
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

		// Token: 0x04003A4E RID: 14926
		private UnknownFieldSet _unknownFields;
	}
}
