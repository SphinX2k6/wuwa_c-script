using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003FF RID: 1023
	[NetMessage(EMessageId.DrownPush)]
	public sealed class DrownPush : IMessage<DrownPush>, IMessage, IEquatable<DrownPush>, IDeepCloneable<DrownPush>, IBufferMessage
	{
		// Token: 0x0600630A RID: 25354 RVA: 0x000EE552 File Offset: 0x000EC752
		[NullableContext(1)]
		public static DrownPush Create()
		{
			return new DrownPush();
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x0600630B RID: 25355 RVA: 0x000EE559 File Offset: 0x000EC759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x0600630C RID: 25356 RVA: 0x000EE55C File Offset: 0x000EC75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrownPush.Descriptor;
			}
		}

		// Token: 0x0600630D RID: 25357 RVA: 0x000EE563 File Offset: 0x000EC763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownPush()
		{
		}

		// Token: 0x0600630E RID: 25358 RVA: 0x000EE56B File Offset: 0x000EC76B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownPush(DrownPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600630F RID: 25359 RVA: 0x000EE584 File Offset: 0x000EC784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownPush Clone()
		{
			return new DrownPush(this);
		}

		// Token: 0x06006310 RID: 25360 RVA: 0x000EE58C File Offset: 0x000EC78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrownPush);
		}

		// Token: 0x06006311 RID: 25361 RVA: 0x000EE59A File Offset: 0x000EC79A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrownPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006312 RID: 25362 RVA: 0x000EE5B8 File Offset: 0x000EC7B8
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

		// Token: 0x06006313 RID: 25363 RVA: 0x000EE5DE File Offset: 0x000EC7DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006314 RID: 25364 RVA: 0x000EE5EB File Offset: 0x000EC7EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006315 RID: 25365 RVA: 0x000EE5F4 File Offset: 0x000EC7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006316 RID: 25366 RVA: 0x000EE60C File Offset: 0x000EC80C
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

		// Token: 0x06006317 RID: 25367 RVA: 0x000EE632 File Offset: 0x000EC832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrownPush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006318 RID: 25368 RVA: 0x000EE64F File Offset: 0x000EC84F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006319 RID: 25369 RVA: 0x000EE658 File Offset: 0x000EC858
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

		// Token: 0x04003858 RID: 14424
		private UnknownFieldSet _unknownFields;
	}
}
