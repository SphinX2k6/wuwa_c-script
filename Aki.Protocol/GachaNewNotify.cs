using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000694 RID: 1684
	[NetMessage(EMessageId.GachaNewNotify)]
	public sealed class GachaNewNotify : IMessage<GachaNewNotify>, IMessage, IEquatable<GachaNewNotify>, IDeepCloneable<GachaNewNotify>, IBufferMessage
	{
		// Token: 0x06009A2F RID: 39471 RVA: 0x00173B3D File Offset: 0x00171D3D
		[NullableContext(1)]
		public static GachaNewNotify Create()
		{
			return new GachaNewNotify();
		}

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x06009A30 RID: 39472 RVA: 0x00173B44 File Offset: 0x00171D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x06009A31 RID: 39473 RVA: 0x00173B47 File Offset: 0x00171D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaNewNotify.Descriptor;
			}
		}

		// Token: 0x06009A32 RID: 39474 RVA: 0x00173B4E File Offset: 0x00171D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaNewNotify()
		{
		}

		// Token: 0x06009A33 RID: 39475 RVA: 0x00173B56 File Offset: 0x00171D56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaNewNotify(GachaNewNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A34 RID: 39476 RVA: 0x00173B6F File Offset: 0x00171D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaNewNotify Clone()
		{
			return new GachaNewNotify(this);
		}

		// Token: 0x06009A35 RID: 39477 RVA: 0x00173B77 File Offset: 0x00171D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaNewNotify);
		}

		// Token: 0x06009A36 RID: 39478 RVA: 0x00173B85 File Offset: 0x00171D85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaNewNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009A37 RID: 39479 RVA: 0x00173BA4 File Offset: 0x00171DA4
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

		// Token: 0x06009A38 RID: 39480 RVA: 0x00173BCA File Offset: 0x00171DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009A39 RID: 39481 RVA: 0x00173BD7 File Offset: 0x00171DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A3A RID: 39482 RVA: 0x00173BE0 File Offset: 0x00171DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A3B RID: 39483 RVA: 0x00173BF8 File Offset: 0x00171DF8
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

		// Token: 0x06009A3C RID: 39484 RVA: 0x00173C1E File Offset: 0x00171E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaNewNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009A3D RID: 39485 RVA: 0x00173C3B File Offset: 0x00171E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A3E RID: 39486 RVA: 0x00173C44 File Offset: 0x00171E44
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

		// Token: 0x040048EB RID: 18667
		private UnknownFieldSet _unknownFields;
	}
}
