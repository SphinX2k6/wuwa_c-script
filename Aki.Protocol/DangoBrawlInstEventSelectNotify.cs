using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000364 RID: 868
	[NetMessage(EMessageId.DangoBrawlInstEventSelectNotify)]
	public sealed class DangoBrawlInstEventSelectNotify : IMessage<DangoBrawlInstEventSelectNotify>, IMessage, IEquatable<DangoBrawlInstEventSelectNotify>, IDeepCloneable<DangoBrawlInstEventSelectNotify>, IBufferMessage
	{
		// Token: 0x060056DB RID: 22235 RVA: 0x000D4A7F File Offset: 0x000D2C7F
		[NullableContext(1)]
		public static DangoBrawlInstEventSelectNotify Create()
		{
			return new DangoBrawlInstEventSelectNotify();
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x060056DC RID: 22236 RVA: 0x000D4A86 File Offset: 0x000D2C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x060056DD RID: 22237 RVA: 0x000D4A89 File Offset: 0x000D2C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlInstEventSelectNotify.Descriptor;
			}
		}

		// Token: 0x060056DE RID: 22238 RVA: 0x000D4A90 File Offset: 0x000D2C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlInstEventSelectNotify()
		{
		}

		// Token: 0x060056DF RID: 22239 RVA: 0x000D4A98 File Offset: 0x000D2C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlInstEventSelectNotify(DangoBrawlInstEventSelectNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060056E0 RID: 22240 RVA: 0x000D4AB1 File Offset: 0x000D2CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlInstEventSelectNotify Clone()
		{
			return new DangoBrawlInstEventSelectNotify(this);
		}

		// Token: 0x060056E1 RID: 22241 RVA: 0x000D4AB9 File Offset: 0x000D2CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlInstEventSelectNotify);
		}

		// Token: 0x060056E2 RID: 22242 RVA: 0x000D4AC7 File Offset: 0x000D2CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlInstEventSelectNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060056E3 RID: 22243 RVA: 0x000D4AE8 File Offset: 0x000D2CE8
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

		// Token: 0x060056E4 RID: 22244 RVA: 0x000D4B0E File Offset: 0x000D2D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060056E5 RID: 22245 RVA: 0x000D4B1B File Offset: 0x000D2D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060056E6 RID: 22246 RVA: 0x000D4B24 File Offset: 0x000D2D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060056E7 RID: 22247 RVA: 0x000D4B3C File Offset: 0x000D2D3C
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

		// Token: 0x060056E8 RID: 22248 RVA: 0x000D4B62 File Offset: 0x000D2D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlInstEventSelectNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060056E9 RID: 22249 RVA: 0x000D4B7F File Offset: 0x000D2D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060056EA RID: 22250 RVA: 0x000D4B88 File Offset: 0x000D2D88
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

		// Token: 0x040034FC RID: 13564
		private UnknownFieldSet _unknownFields;
	}
}
