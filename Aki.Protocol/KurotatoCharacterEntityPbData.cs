using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000887 RID: 2183
	public sealed class KurotatoCharacterEntityPbData : IMessage<KurotatoCharacterEntityPbData>, IMessage, IEquatable<KurotatoCharacterEntityPbData>, IDeepCloneable<KurotatoCharacterEntityPbData>, IBufferMessage
	{
		// Token: 0x0600C24B RID: 49739 RVA: 0x001CD9AC File Offset: 0x001CBBAC
		[NullableContext(1)]
		public static KurotatoCharacterEntityPbData Create()
		{
			return new KurotatoCharacterEntityPbData();
		}

		// Token: 0x1700274C RID: 10060
		// (get) Token: 0x0600C24C RID: 49740 RVA: 0x001CD9B3 File Offset: 0x001CBBB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700274D RID: 10061
		// (get) Token: 0x0600C24D RID: 49741 RVA: 0x001CD9B6 File Offset: 0x001CBBB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoCharacterEntityPbData.Descriptor;
			}
		}

		// Token: 0x0600C24E RID: 49742 RVA: 0x001CD9BD File Offset: 0x001CBBBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCharacterEntityPbData()
		{
		}

		// Token: 0x0600C24F RID: 49743 RVA: 0x001CD9C5 File Offset: 0x001CBBC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCharacterEntityPbData(KurotatoCharacterEntityPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C250 RID: 49744 RVA: 0x001CD9DE File Offset: 0x001CBBDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCharacterEntityPbData Clone()
		{
			return new KurotatoCharacterEntityPbData(this);
		}

		// Token: 0x0600C251 RID: 49745 RVA: 0x001CD9E6 File Offset: 0x001CBBE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoCharacterEntityPbData);
		}

		// Token: 0x0600C252 RID: 49746 RVA: 0x001CD9F4 File Offset: 0x001CBBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoCharacterEntityPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C253 RID: 49747 RVA: 0x001CDA14 File Offset: 0x001CBC14
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

		// Token: 0x0600C254 RID: 49748 RVA: 0x001CDA3A File Offset: 0x001CBC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C255 RID: 49749 RVA: 0x001CDA47 File Offset: 0x001CBC47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C256 RID: 49750 RVA: 0x001CDA50 File Offset: 0x001CBC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C257 RID: 49751 RVA: 0x001CDA68 File Offset: 0x001CBC68
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

		// Token: 0x0600C258 RID: 49752 RVA: 0x001CDA8E File Offset: 0x001CBC8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoCharacterEntityPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C259 RID: 49753 RVA: 0x001CDAAB File Offset: 0x001CBCAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C25A RID: 49754 RVA: 0x001CDAB4 File Offset: 0x001CBCB4
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

		// Token: 0x04005436 RID: 21558
		private UnknownFieldSet _unknownFields;
	}
}
