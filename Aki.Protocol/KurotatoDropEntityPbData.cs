using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000890 RID: 2192
	public sealed class KurotatoDropEntityPbData : IMessage<KurotatoDropEntityPbData>, IMessage, IEquatable<KurotatoDropEntityPbData>, IDeepCloneable<KurotatoDropEntityPbData>, IBufferMessage
	{
		// Token: 0x0600C2EF RID: 49903 RVA: 0x001CEB46 File Offset: 0x001CCD46
		[NullableContext(1)]
		public static KurotatoDropEntityPbData Create()
		{
			return new KurotatoDropEntityPbData();
		}

		// Token: 0x17002768 RID: 10088
		// (get) Token: 0x0600C2F0 RID: 49904 RVA: 0x001CEB4D File Offset: 0x001CCD4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002769 RID: 10089
		// (get) Token: 0x0600C2F1 RID: 49905 RVA: 0x001CEB50 File Offset: 0x001CCD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoDropEntityPbData.Descriptor;
			}
		}

		// Token: 0x0600C2F2 RID: 49906 RVA: 0x001CEB57 File Offset: 0x001CCD57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDropEntityPbData()
		{
		}

		// Token: 0x0600C2F3 RID: 49907 RVA: 0x001CEB5F File Offset: 0x001CCD5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDropEntityPbData(KurotatoDropEntityPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C2F4 RID: 49908 RVA: 0x001CEB78 File Offset: 0x001CCD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDropEntityPbData Clone()
		{
			return new KurotatoDropEntityPbData(this);
		}

		// Token: 0x0600C2F5 RID: 49909 RVA: 0x001CEB80 File Offset: 0x001CCD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoDropEntityPbData);
		}

		// Token: 0x0600C2F6 RID: 49910 RVA: 0x001CEB8E File Offset: 0x001CCD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoDropEntityPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C2F7 RID: 49911 RVA: 0x001CEBAC File Offset: 0x001CCDAC
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

		// Token: 0x0600C2F8 RID: 49912 RVA: 0x001CEBD2 File Offset: 0x001CCDD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C2F9 RID: 49913 RVA: 0x001CEBDF File Offset: 0x001CCDDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C2FA RID: 49914 RVA: 0x001CEBE8 File Offset: 0x001CCDE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C2FB RID: 49915 RVA: 0x001CEC00 File Offset: 0x001CCE00
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

		// Token: 0x0600C2FC RID: 49916 RVA: 0x001CEC26 File Offset: 0x001CCE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoDropEntityPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C2FD RID: 49917 RVA: 0x001CEC43 File Offset: 0x001CCE43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C2FE RID: 49918 RVA: 0x001CEC4C File Offset: 0x001CCE4C
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

		// Token: 0x04005453 RID: 21587
		private UnknownFieldSet _unknownFields;
	}
}
