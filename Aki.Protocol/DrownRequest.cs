using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000400 RID: 1024
	[NetMessage(EMessageId.DrownRequest)]
	public sealed class DrownRequest : IMessage<DrownRequest>, IMessage, IEquatable<DrownRequest>, IDeepCloneable<DrownRequest>, IBufferMessage
	{
		// Token: 0x0600631A RID: 25370 RVA: 0x000EE68A File Offset: 0x000EC88A
		[NullableContext(1)]
		public static DrownRequest Create()
		{
			return new DrownRequest();
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x0600631B RID: 25371 RVA: 0x000EE691 File Offset: 0x000EC891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x0600631C RID: 25372 RVA: 0x000EE694 File Offset: 0x000EC894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrownRequest.Descriptor;
			}
		}

		// Token: 0x0600631D RID: 25373 RVA: 0x000EE69B File Offset: 0x000EC89B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownRequest()
		{
		}

		// Token: 0x0600631E RID: 25374 RVA: 0x000EE6A3 File Offset: 0x000EC8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownRequest(DrownRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600631F RID: 25375 RVA: 0x000EE6BC File Offset: 0x000EC8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownRequest Clone()
		{
			return new DrownRequest(this);
		}

		// Token: 0x06006320 RID: 25376 RVA: 0x000EE6C4 File Offset: 0x000EC8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrownRequest);
		}

		// Token: 0x06006321 RID: 25377 RVA: 0x000EE6D2 File Offset: 0x000EC8D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrownRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006322 RID: 25378 RVA: 0x000EE6F0 File Offset: 0x000EC8F0
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

		// Token: 0x06006323 RID: 25379 RVA: 0x000EE716 File Offset: 0x000EC916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006324 RID: 25380 RVA: 0x000EE723 File Offset: 0x000EC923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006325 RID: 25381 RVA: 0x000EE72C File Offset: 0x000EC92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006326 RID: 25382 RVA: 0x000EE744 File Offset: 0x000EC944
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

		// Token: 0x06006327 RID: 25383 RVA: 0x000EE76A File Offset: 0x000EC96A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrownRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006328 RID: 25384 RVA: 0x000EE787 File Offset: 0x000EC987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006329 RID: 25385 RVA: 0x000EE790 File Offset: 0x000EC990
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

		// Token: 0x04003859 RID: 14425
		private UnknownFieldSet _unknownFields;
	}
}
