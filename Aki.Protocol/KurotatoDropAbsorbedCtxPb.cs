using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200088F RID: 2191
	public sealed class KurotatoDropAbsorbedCtxPb : IMessage<KurotatoDropAbsorbedCtxPb>, IMessage, IEquatable<KurotatoDropAbsorbedCtxPb>, IDeepCloneable<KurotatoDropAbsorbedCtxPb>, IBufferMessage
	{
		// Token: 0x0600C2DF RID: 49887 RVA: 0x001CEA0E File Offset: 0x001CCC0E
		[NullableContext(1)]
		public static KurotatoDropAbsorbedCtxPb Create()
		{
			return new KurotatoDropAbsorbedCtxPb();
		}

		// Token: 0x17002766 RID: 10086
		// (get) Token: 0x0600C2E0 RID: 49888 RVA: 0x001CEA15 File Offset: 0x001CCC15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002767 RID: 10087
		// (get) Token: 0x0600C2E1 RID: 49889 RVA: 0x001CEA18 File Offset: 0x001CCC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoDropAbsorbedCtxPb.Descriptor;
			}
		}

		// Token: 0x0600C2E2 RID: 49890 RVA: 0x001CEA1F File Offset: 0x001CCC1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDropAbsorbedCtxPb()
		{
		}

		// Token: 0x0600C2E3 RID: 49891 RVA: 0x001CEA27 File Offset: 0x001CCC27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDropAbsorbedCtxPb(KurotatoDropAbsorbedCtxPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C2E4 RID: 49892 RVA: 0x001CEA40 File Offset: 0x001CCC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDropAbsorbedCtxPb Clone()
		{
			return new KurotatoDropAbsorbedCtxPb(this);
		}

		// Token: 0x0600C2E5 RID: 49893 RVA: 0x001CEA48 File Offset: 0x001CCC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoDropAbsorbedCtxPb);
		}

		// Token: 0x0600C2E6 RID: 49894 RVA: 0x001CEA56 File Offset: 0x001CCC56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoDropAbsorbedCtxPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C2E7 RID: 49895 RVA: 0x001CEA74 File Offset: 0x001CCC74
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

		// Token: 0x0600C2E8 RID: 49896 RVA: 0x001CEA9A File Offset: 0x001CCC9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C2E9 RID: 49897 RVA: 0x001CEAA7 File Offset: 0x001CCCA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C2EA RID: 49898 RVA: 0x001CEAB0 File Offset: 0x001CCCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C2EB RID: 49899 RVA: 0x001CEAC8 File Offset: 0x001CCCC8
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

		// Token: 0x0600C2EC RID: 49900 RVA: 0x001CEAEE File Offset: 0x001CCCEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoDropAbsorbedCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C2ED RID: 49901 RVA: 0x001CEB0B File Offset: 0x001CCD0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C2EE RID: 49902 RVA: 0x001CEB14 File Offset: 0x001CCD14
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

		// Token: 0x04005452 RID: 21586
		private UnknownFieldSet _unknownFields;
	}
}
