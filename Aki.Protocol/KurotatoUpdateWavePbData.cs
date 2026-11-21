using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C5 RID: 2245
	public sealed class KurotatoUpdateWavePbData : IMessage<KurotatoUpdateWavePbData>, IMessage, IEquatable<KurotatoUpdateWavePbData>, IDeepCloneable<KurotatoUpdateWavePbData>, IBufferMessage
	{
		// Token: 0x0600C746 RID: 51014 RVA: 0x001D811B File Offset: 0x001D631B
		[NullableContext(1)]
		public static KurotatoUpdateWavePbData Create()
		{
			return new KurotatoUpdateWavePbData();
		}

		// Token: 0x17002842 RID: 10306
		// (get) Token: 0x0600C747 RID: 51015 RVA: 0x001D8122 File Offset: 0x001D6322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002843 RID: 10307
		// (get) Token: 0x0600C748 RID: 51016 RVA: 0x001D8125 File Offset: 0x001D6325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoUpdateWavePbData.Descriptor;
			}
		}

		// Token: 0x0600C749 RID: 51017 RVA: 0x001D812C File Offset: 0x001D632C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpdateWavePbData()
		{
		}

		// Token: 0x0600C74A RID: 51018 RVA: 0x001D8134 File Offset: 0x001D6334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpdateWavePbData(KurotatoUpdateWavePbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C74B RID: 51019 RVA: 0x001D814D File Offset: 0x001D634D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpdateWavePbData Clone()
		{
			return new KurotatoUpdateWavePbData(this);
		}

		// Token: 0x0600C74C RID: 51020 RVA: 0x001D8155 File Offset: 0x001D6355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoUpdateWavePbData);
		}

		// Token: 0x0600C74D RID: 51021 RVA: 0x001D8163 File Offset: 0x001D6363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoUpdateWavePbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C74E RID: 51022 RVA: 0x001D8184 File Offset: 0x001D6384
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

		// Token: 0x0600C74F RID: 51023 RVA: 0x001D81AA File Offset: 0x001D63AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C750 RID: 51024 RVA: 0x001D81B7 File Offset: 0x001D63B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C751 RID: 51025 RVA: 0x001D81C0 File Offset: 0x001D63C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C752 RID: 51026 RVA: 0x001D81D8 File Offset: 0x001D63D8
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

		// Token: 0x0600C753 RID: 51027 RVA: 0x001D81FE File Offset: 0x001D63FE
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

		// Token: 0x0600C754 RID: 51028 RVA: 0x001D821B File Offset: 0x001D641B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C755 RID: 51029 RVA: 0x001D8224 File Offset: 0x001D6424
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

		// Token: 0x040055C2 RID: 21954
		private UnknownFieldSet _unknownFields;
	}
}
