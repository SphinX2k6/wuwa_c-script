using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D3 RID: 2259
	public sealed class KurotatoStructureKilledCtxPb : IMessage<KurotatoStructureKilledCtxPb>, IMessage, IEquatable<KurotatoStructureKilledCtxPb>, IDeepCloneable<KurotatoStructureKilledCtxPb>, IBufferMessage
	{
		// Token: 0x0600C824 RID: 51236 RVA: 0x001D9A26 File Offset: 0x001D7C26
		[NullableContext(1)]
		public static KurotatoStructureKilledCtxPb Create()
		{
			return new KurotatoStructureKilledCtxPb();
		}

		// Token: 0x17002873 RID: 10355
		// (get) Token: 0x0600C825 RID: 51237 RVA: 0x001D9A2D File Offset: 0x001D7C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002874 RID: 10356
		// (get) Token: 0x0600C826 RID: 51238 RVA: 0x001D9A30 File Offset: 0x001D7C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoStructureKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x0600C827 RID: 51239 RVA: 0x001D9A37 File Offset: 0x001D7C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStructureKilledCtxPb()
		{
		}

		// Token: 0x0600C828 RID: 51240 RVA: 0x001D9A3F File Offset: 0x001D7C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStructureKilledCtxPb(KurotatoStructureKilledCtxPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C829 RID: 51241 RVA: 0x001D9A58 File Offset: 0x001D7C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStructureKilledCtxPb Clone()
		{
			return new KurotatoStructureKilledCtxPb(this);
		}

		// Token: 0x0600C82A RID: 51242 RVA: 0x001D9A60 File Offset: 0x001D7C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoStructureKilledCtxPb);
		}

		// Token: 0x0600C82B RID: 51243 RVA: 0x001D9A6E File Offset: 0x001D7C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoStructureKilledCtxPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C82C RID: 51244 RVA: 0x001D9A8C File Offset: 0x001D7C8C
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

		// Token: 0x0600C82D RID: 51245 RVA: 0x001D9AB2 File Offset: 0x001D7CB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C82E RID: 51246 RVA: 0x001D9ABF File Offset: 0x001D7CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C82F RID: 51247 RVA: 0x001D9AC8 File Offset: 0x001D7CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C830 RID: 51248 RVA: 0x001D9AE0 File Offset: 0x001D7CE0
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

		// Token: 0x0600C831 RID: 51249 RVA: 0x001D9B06 File Offset: 0x001D7D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoStructureKilledCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C832 RID: 51250 RVA: 0x001D9B23 File Offset: 0x001D7D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C833 RID: 51251 RVA: 0x001D9B2C File Offset: 0x001D7D2C
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

		// Token: 0x040055A4 RID: 21924
		private UnknownFieldSet _unknownFields;
	}
}
