using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B4D RID: 2893
	[NetMessage(EMessageId.NormalItemRequest)]
	public sealed class NormalItemRequest : IMessage<NormalItemRequest>, IMessage, IEquatable<NormalItemRequest>, IDeepCloneable<NormalItemRequest>, IBufferMessage
	{
		// Token: 0x0600FB1A RID: 64282 RVA: 0x00249A35 File Offset: 0x00247C35
		[NullableContext(1)]
		public static NormalItemRequest Create()
		{
			return new NormalItemRequest();
		}

		// Token: 0x1700332D RID: 13101
		// (get) Token: 0x0600FB1B RID: 64283 RVA: 0x00249A3C File Offset: 0x00247C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700332E RID: 13102
		// (get) Token: 0x0600FB1C RID: 64284 RVA: 0x00249A3F File Offset: 0x00247C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalItemRequest.Descriptor;
			}
		}

		// Token: 0x0600FB1D RID: 64285 RVA: 0x00249A46 File Offset: 0x00247C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemRequest()
		{
		}

		// Token: 0x0600FB1E RID: 64286 RVA: 0x00249A4E File Offset: 0x00247C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemRequest(NormalItemRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FB1F RID: 64287 RVA: 0x00249A67 File Offset: 0x00247C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemRequest Clone()
		{
			return new NormalItemRequest(this);
		}

		// Token: 0x0600FB20 RID: 64288 RVA: 0x00249A6F File Offset: 0x00247C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalItemRequest);
		}

		// Token: 0x0600FB21 RID: 64289 RVA: 0x00249A7D File Offset: 0x00247C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalItemRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600FB22 RID: 64290 RVA: 0x00249A9C File Offset: 0x00247C9C
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

		// Token: 0x0600FB23 RID: 64291 RVA: 0x00249AC2 File Offset: 0x00247CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FB24 RID: 64292 RVA: 0x00249ACF File Offset: 0x00247CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FB25 RID: 64293 RVA: 0x00249AD8 File Offset: 0x00247CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FB26 RID: 64294 RVA: 0x00249AF0 File Offset: 0x00247CF0
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

		// Token: 0x0600FB27 RID: 64295 RVA: 0x00249B16 File Offset: 0x00247D16
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

		// Token: 0x0600FB28 RID: 64296 RVA: 0x00249B33 File Offset: 0x00247D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FB29 RID: 64297 RVA: 0x00249B3C File Offset: 0x00247D3C
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

		// Token: 0x040064C1 RID: 25793
		private UnknownFieldSet _unknownFields;
	}
}
