using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200088E RID: 2190
	[NetMessage(EMessageId.KurotatoDieNotify)]
	public sealed class KurotatoDieNotify : IMessage<KurotatoDieNotify>, IMessage, IEquatable<KurotatoDieNotify>, IDeepCloneable<KurotatoDieNotify>, IBufferMessage
	{
		// Token: 0x0600C2CF RID: 49871 RVA: 0x001CE8D6 File Offset: 0x001CCAD6
		[NullableContext(1)]
		public static KurotatoDieNotify Create()
		{
			return new KurotatoDieNotify();
		}

		// Token: 0x17002764 RID: 10084
		// (get) Token: 0x0600C2D0 RID: 49872 RVA: 0x001CE8DD File Offset: 0x001CCADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002765 RID: 10085
		// (get) Token: 0x0600C2D1 RID: 49873 RVA: 0x001CE8E0 File Offset: 0x001CCAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoDieNotify.Descriptor;
			}
		}

		// Token: 0x0600C2D2 RID: 49874 RVA: 0x001CE8E7 File Offset: 0x001CCAE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDieNotify()
		{
		}

		// Token: 0x0600C2D3 RID: 49875 RVA: 0x001CE8EF File Offset: 0x001CCAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDieNotify(KurotatoDieNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C2D4 RID: 49876 RVA: 0x001CE908 File Offset: 0x001CCB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDieNotify Clone()
		{
			return new KurotatoDieNotify(this);
		}

		// Token: 0x0600C2D5 RID: 49877 RVA: 0x001CE910 File Offset: 0x001CCB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoDieNotify);
		}

		// Token: 0x0600C2D6 RID: 49878 RVA: 0x001CE91E File Offset: 0x001CCB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoDieNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C2D7 RID: 49879 RVA: 0x001CE93C File Offset: 0x001CCB3C
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

		// Token: 0x0600C2D8 RID: 49880 RVA: 0x001CE962 File Offset: 0x001CCB62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C2D9 RID: 49881 RVA: 0x001CE96F File Offset: 0x001CCB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C2DA RID: 49882 RVA: 0x001CE978 File Offset: 0x001CCB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C2DB RID: 49883 RVA: 0x001CE990 File Offset: 0x001CCB90
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

		// Token: 0x0600C2DC RID: 49884 RVA: 0x001CE9B6 File Offset: 0x001CCBB6
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

		// Token: 0x0600C2DD RID: 49885 RVA: 0x001CE9D3 File Offset: 0x001CCBD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C2DE RID: 49886 RVA: 0x001CE9DC File Offset: 0x001CCBDC
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

		// Token: 0x04005451 RID: 21585
		private UnknownFieldSet _unknownFields;
	}
}
