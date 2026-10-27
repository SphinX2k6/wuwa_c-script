using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000407 RID: 1031
	[NetMessage(EMessageId.DropCatchInfoRequest)]
	public sealed class DropCatchInfoRequest : IMessage<DropCatchInfoRequest>, IMessage, IEquatable<DropCatchInfoRequest>, IDeepCloneable<DropCatchInfoRequest>, IBufferMessage
	{
		// Token: 0x06006379 RID: 25465 RVA: 0x000EF415 File Offset: 0x000ED615
		[NullableContext(1)]
		public static DropCatchInfoRequest Create()
		{
			return new DropCatchInfoRequest();
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x0600637A RID: 25466 RVA: 0x000EF41C File Offset: 0x000ED61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x0600637B RID: 25467 RVA: 0x000EF41F File Offset: 0x000ED61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropCatchInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600637C RID: 25468 RVA: 0x000EF426 File Offset: 0x000ED626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchInfoRequest()
		{
		}

		// Token: 0x0600637D RID: 25469 RVA: 0x000EF42E File Offset: 0x000ED62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchInfoRequest(DropCatchInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600637E RID: 25470 RVA: 0x000EF447 File Offset: 0x000ED647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchInfoRequest Clone()
		{
			return new DropCatchInfoRequest(this);
		}

		// Token: 0x0600637F RID: 25471 RVA: 0x000EF44F File Offset: 0x000ED64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropCatchInfoRequest);
		}

		// Token: 0x06006380 RID: 25472 RVA: 0x000EF45D File Offset: 0x000ED65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropCatchInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006381 RID: 25473 RVA: 0x000EF47C File Offset: 0x000ED67C
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

		// Token: 0x06006382 RID: 25474 RVA: 0x000EF4A2 File Offset: 0x000ED6A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006383 RID: 25475 RVA: 0x000EF4AF File Offset: 0x000ED6AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006384 RID: 25476 RVA: 0x000EF4B8 File Offset: 0x000ED6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006385 RID: 25477 RVA: 0x000EF4D0 File Offset: 0x000ED6D0
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

		// Token: 0x06006386 RID: 25478 RVA: 0x000EF4F6 File Offset: 0x000ED6F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropCatchInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006387 RID: 25479 RVA: 0x000EF513 File Offset: 0x000ED713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006388 RID: 25480 RVA: 0x000EF51C File Offset: 0x000ED71C
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

		// Token: 0x04003827 RID: 14375
		private UnknownFieldSet _unknownFields;
	}
}
