using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200087D RID: 2173
	[NetMessage(EMessageId.KurotatoDieNotify)]
	public sealed class KurotatoDieNotify : IMessage<KurotatoDieNotify>, IMessage, IEquatable<KurotatoDieNotify>, IDeepCloneable<KurotatoDieNotify>, IBufferMessage
	{
		// Token: 0x0600C1B3 RID: 49587 RVA: 0x001CC5EE File Offset: 0x001CA7EE
		[NullableContext(1)]
		public static KurotatoDieNotify Create()
		{
			return new KurotatoDieNotify();
		}

		// Token: 0x17002725 RID: 10021
		// (get) Token: 0x0600C1B4 RID: 49588 RVA: 0x001CC5F5 File Offset: 0x001CA7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002726 RID: 10022
		// (get) Token: 0x0600C1B5 RID: 49589 RVA: 0x001CC5F8 File Offset: 0x001CA7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoDieNotify.Descriptor;
			}
		}

		// Token: 0x0600C1B6 RID: 49590 RVA: 0x001CC5FF File Offset: 0x001CA7FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDieNotify()
		{
		}

		// Token: 0x0600C1B7 RID: 49591 RVA: 0x001CC607 File Offset: 0x001CA807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDieNotify(KurotatoDieNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C1B8 RID: 49592 RVA: 0x001CC620 File Offset: 0x001CA820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDieNotify Clone()
		{
			return new KurotatoDieNotify(this);
		}

		// Token: 0x0600C1B9 RID: 49593 RVA: 0x001CC628 File Offset: 0x001CA828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoDieNotify);
		}

		// Token: 0x0600C1BA RID: 49594 RVA: 0x001CC636 File Offset: 0x001CA836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoDieNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C1BB RID: 49595 RVA: 0x001CC654 File Offset: 0x001CA854
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

		// Token: 0x0600C1BC RID: 49596 RVA: 0x001CC67A File Offset: 0x001CA87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C1BD RID: 49597 RVA: 0x001CC687 File Offset: 0x001CA887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C1BE RID: 49598 RVA: 0x001CC690 File Offset: 0x001CA890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C1BF RID: 49599 RVA: 0x001CC6A8 File Offset: 0x001CA8A8
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

		// Token: 0x0600C1C0 RID: 49600 RVA: 0x001CC6CE File Offset: 0x001CA8CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoDieNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C1C1 RID: 49601 RVA: 0x001CC6EB File Offset: 0x001CA8EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C1C2 RID: 49602 RVA: 0x001CC6F4 File Offset: 0x001CA8F4
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

		// Token: 0x04005458 RID: 21592
		private UnknownFieldSet _unknownFields;
	}
}
