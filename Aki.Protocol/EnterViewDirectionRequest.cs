using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200045C RID: 1116
	[NetMessage(EMessageId.EnterViewDirectionRequest)]
	public sealed class EnterViewDirectionRequest : IMessage<EnterViewDirectionRequest>, IMessage, IEquatable<EnterViewDirectionRequest>, IDeepCloneable<EnterViewDirectionRequest>, IBufferMessage
	{
		// Token: 0x06006AA2 RID: 27298 RVA: 0x00101552 File Offset: 0x000FF752
		[NullableContext(1)]
		public static EnterViewDirectionRequest Create()
		{
			return new EnterViewDirectionRequest();
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x06006AA3 RID: 27299 RVA: 0x00101559 File Offset: 0x000FF759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x06006AA4 RID: 27300 RVA: 0x0010155C File Offset: 0x000FF75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterViewDirectionRequest.Descriptor;
			}
		}

		// Token: 0x06006AA5 RID: 27301 RVA: 0x00101563 File Offset: 0x000FF763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionRequest()
		{
		}

		// Token: 0x06006AA6 RID: 27302 RVA: 0x0010156B File Offset: 0x000FF76B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionRequest(EnterViewDirectionRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006AA7 RID: 27303 RVA: 0x00101584 File Offset: 0x000FF784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionRequest Clone()
		{
			return new EnterViewDirectionRequest(this);
		}

		// Token: 0x06006AA8 RID: 27304 RVA: 0x0010158C File Offset: 0x000FF78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterViewDirectionRequest);
		}

		// Token: 0x06006AA9 RID: 27305 RVA: 0x0010159A File Offset: 0x000FF79A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterViewDirectionRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006AAA RID: 27306 RVA: 0x001015B8 File Offset: 0x000FF7B8
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

		// Token: 0x06006AAB RID: 27307 RVA: 0x001015DE File Offset: 0x000FF7DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006AAC RID: 27308 RVA: 0x001015EB File Offset: 0x000FF7EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006AAD RID: 27309 RVA: 0x001015F4 File Offset: 0x000FF7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006AAE RID: 27310 RVA: 0x0010160C File Offset: 0x000FF80C
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

		// Token: 0x06006AAF RID: 27311 RVA: 0x00101632 File Offset: 0x000FF832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterViewDirectionRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006AB0 RID: 27312 RVA: 0x0010164F File Offset: 0x000FF84F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006AB1 RID: 27313 RVA: 0x00101658 File Offset: 0x000FF858
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

		// Token: 0x04003A56 RID: 14934
		private UnknownFieldSet _unknownFields;
	}
}
