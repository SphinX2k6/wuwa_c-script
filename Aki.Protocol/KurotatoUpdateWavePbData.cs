using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D6 RID: 2262
	public sealed class KurotatoUpdateWavePbData : IMessage<KurotatoUpdateWavePbData>, IMessage, IEquatable<KurotatoUpdateWavePbData>, IDeepCloneable<KurotatoUpdateWavePbData>, IBufferMessage
	{
		// Token: 0x0600C862 RID: 51298 RVA: 0x001DA3F7 File Offset: 0x001D85F7
		[NullableContext(1)]
		public static KurotatoUpdateWavePbData Create()
		{
			return new KurotatoUpdateWavePbData();
		}

		// Token: 0x17002881 RID: 10369
		// (get) Token: 0x0600C863 RID: 51299 RVA: 0x001DA3FE File Offset: 0x001D85FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002882 RID: 10370
		// (get) Token: 0x0600C864 RID: 51300 RVA: 0x001DA401 File Offset: 0x001D8601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoUpdateWavePbData.Descriptor;
			}
		}

		// Token: 0x0600C865 RID: 51301 RVA: 0x001DA408 File Offset: 0x001D8608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpdateWavePbData()
		{
		}

		// Token: 0x0600C866 RID: 51302 RVA: 0x001DA410 File Offset: 0x001D8610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpdateWavePbData(KurotatoUpdateWavePbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C867 RID: 51303 RVA: 0x001DA429 File Offset: 0x001D8629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpdateWavePbData Clone()
		{
			return new KurotatoUpdateWavePbData(this);
		}

		// Token: 0x0600C868 RID: 51304 RVA: 0x001DA431 File Offset: 0x001D8631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoUpdateWavePbData);
		}

		// Token: 0x0600C869 RID: 51305 RVA: 0x001DA43F File Offset: 0x001D863F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoUpdateWavePbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C86A RID: 51306 RVA: 0x001DA460 File Offset: 0x001D8660
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

		// Token: 0x0600C86B RID: 51307 RVA: 0x001DA486 File Offset: 0x001D8686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C86C RID: 51308 RVA: 0x001DA493 File Offset: 0x001D8693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C86D RID: 51309 RVA: 0x001DA49C File Offset: 0x001D869C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C86E RID: 51310 RVA: 0x001DA4B4 File Offset: 0x001D86B4
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

		// Token: 0x0600C86F RID: 51311 RVA: 0x001DA4DA File Offset: 0x001D86DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoUpdateWavePbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C870 RID: 51312 RVA: 0x001DA4F7 File Offset: 0x001D86F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C871 RID: 51313 RVA: 0x001DA500 File Offset: 0x001D8700
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

		// Token: 0x040055BB RID: 21947
		private UnknownFieldSet _unknownFields;
	}
}
