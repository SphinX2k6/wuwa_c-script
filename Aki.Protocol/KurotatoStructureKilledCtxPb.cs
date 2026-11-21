using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C2 RID: 2242
	public sealed class KurotatoStructureKilledCtxPb : IMessage<KurotatoStructureKilledCtxPb>, IMessage, IEquatable<KurotatoStructureKilledCtxPb>, IDeepCloneable<KurotatoStructureKilledCtxPb>, IBufferMessage
	{
		// Token: 0x0600C708 RID: 50952 RVA: 0x001D7742 File Offset: 0x001D5942
		[NullableContext(1)]
		public static KurotatoStructureKilledCtxPb Create()
		{
			return new KurotatoStructureKilledCtxPb();
		}

		// Token: 0x17002834 RID: 10292
		// (get) Token: 0x0600C709 RID: 50953 RVA: 0x001D7749 File Offset: 0x001D5949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002835 RID: 10293
		// (get) Token: 0x0600C70A RID: 50954 RVA: 0x001D774C File Offset: 0x001D594C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoStructureKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x0600C70B RID: 50955 RVA: 0x001D7753 File Offset: 0x001D5953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStructureKilledCtxPb()
		{
		}

		// Token: 0x0600C70C RID: 50956 RVA: 0x001D775B File Offset: 0x001D595B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStructureKilledCtxPb(KurotatoStructureKilledCtxPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C70D RID: 50957 RVA: 0x001D7774 File Offset: 0x001D5974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStructureKilledCtxPb Clone()
		{
			return new KurotatoStructureKilledCtxPb(this);
		}

		// Token: 0x0600C70E RID: 50958 RVA: 0x001D777C File Offset: 0x001D597C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoStructureKilledCtxPb);
		}

		// Token: 0x0600C70F RID: 50959 RVA: 0x001D778A File Offset: 0x001D598A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoStructureKilledCtxPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C710 RID: 50960 RVA: 0x001D77A8 File Offset: 0x001D59A8
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

		// Token: 0x0600C711 RID: 50961 RVA: 0x001D77CE File Offset: 0x001D59CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C712 RID: 50962 RVA: 0x001D77DB File Offset: 0x001D59DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C713 RID: 50963 RVA: 0x001D77E4 File Offset: 0x001D59E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C714 RID: 50964 RVA: 0x001D77FC File Offset: 0x001D59FC
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

		// Token: 0x0600C715 RID: 50965 RVA: 0x001D7822 File Offset: 0x001D5A22
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

		// Token: 0x0600C716 RID: 50966 RVA: 0x001D783F File Offset: 0x001D5A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C717 RID: 50967 RVA: 0x001D7848 File Offset: 0x001D5A48
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

		// Token: 0x040055AB RID: 21931
		private UnknownFieldSet _unknownFields;
	}
}
