using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000680 RID: 1664
	[NetMessage(EMessageId.GachaNewNotify)]
	public sealed class GachaNewNotify : IMessage<GachaNewNotify>, IMessage, IEquatable<GachaNewNotify>, IDeepCloneable<GachaNewNotify>, IBufferMessage
	{
		// Token: 0x060098D9 RID: 39129 RVA: 0x00171109 File Offset: 0x0016F309
		[NullableContext(1)]
		public static GachaNewNotify Create()
		{
			return new GachaNewNotify();
		}

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x060098DA RID: 39130 RVA: 0x00171110 File Offset: 0x0016F310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x060098DB RID: 39131 RVA: 0x00171113 File Offset: 0x0016F313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaNewNotify.Descriptor;
			}
		}

		// Token: 0x060098DC RID: 39132 RVA: 0x0017111A File Offset: 0x0016F31A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaNewNotify()
		{
		}

		// Token: 0x060098DD RID: 39133 RVA: 0x00171122 File Offset: 0x0016F322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaNewNotify(GachaNewNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060098DE RID: 39134 RVA: 0x0017113B File Offset: 0x0016F33B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaNewNotify Clone()
		{
			return new GachaNewNotify(this);
		}

		// Token: 0x060098DF RID: 39135 RVA: 0x00171143 File Offset: 0x0016F343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaNewNotify);
		}

		// Token: 0x060098E0 RID: 39136 RVA: 0x00171151 File Offset: 0x0016F351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaNewNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060098E1 RID: 39137 RVA: 0x00171170 File Offset: 0x0016F370
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

		// Token: 0x060098E2 RID: 39138 RVA: 0x00171196 File Offset: 0x0016F396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060098E3 RID: 39139 RVA: 0x001711A3 File Offset: 0x0016F3A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060098E4 RID: 39140 RVA: 0x001711AC File Offset: 0x0016F3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060098E5 RID: 39141 RVA: 0x001711C4 File Offset: 0x0016F3C4
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

		// Token: 0x060098E6 RID: 39142 RVA: 0x001711EA File Offset: 0x0016F3EA
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

		// Token: 0x060098E7 RID: 39143 RVA: 0x00171207 File Offset: 0x0016F407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060098E8 RID: 39144 RVA: 0x00171210 File Offset: 0x0016F410
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

		// Token: 0x040048E4 RID: 18660
		private UnknownFieldSet _unknownFields;
	}
}
