using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B0 RID: 2224
	[NetMessage(EMessageId.KurotatoSettlementRequest)]
	public sealed class KurotatoSettlementRequest : IMessage<KurotatoSettlementRequest>, IMessage, IEquatable<KurotatoSettlementRequest>, IDeepCloneable<KurotatoSettlementRequest>, IBufferMessage
	{
		// Token: 0x0600C59C RID: 50588 RVA: 0x001D43A4 File Offset: 0x001D25A4
		[NullableContext(1)]
		public static KurotatoSettlementRequest Create()
		{
			return new KurotatoSettlementRequest();
		}

		// Token: 0x170027EA RID: 10218
		// (get) Token: 0x0600C59D RID: 50589 RVA: 0x001D43AB File Offset: 0x001D25AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027EB RID: 10219
		// (get) Token: 0x0600C59E RID: 50590 RVA: 0x001D43AE File Offset: 0x001D25AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoSettlementRequest.Descriptor;
			}
		}

		// Token: 0x0600C59F RID: 50591 RVA: 0x001D43B5 File Offset: 0x001D25B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementRequest()
		{
		}

		// Token: 0x0600C5A0 RID: 50592 RVA: 0x001D43BD File Offset: 0x001D25BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementRequest(KurotatoSettlementRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C5A1 RID: 50593 RVA: 0x001D43D6 File Offset: 0x001D25D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementRequest Clone()
		{
			return new KurotatoSettlementRequest(this);
		}

		// Token: 0x0600C5A2 RID: 50594 RVA: 0x001D43DE File Offset: 0x001D25DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoSettlementRequest);
		}

		// Token: 0x0600C5A3 RID: 50595 RVA: 0x001D43EC File Offset: 0x001D25EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoSettlementRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C5A4 RID: 50596 RVA: 0x001D440C File Offset: 0x001D260C
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

		// Token: 0x0600C5A5 RID: 50597 RVA: 0x001D4432 File Offset: 0x001D2632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C5A6 RID: 50598 RVA: 0x001D443F File Offset: 0x001D263F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C5A7 RID: 50599 RVA: 0x001D4448 File Offset: 0x001D2648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C5A8 RID: 50600 RVA: 0x001D4460 File Offset: 0x001D2660
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

		// Token: 0x0600C5A9 RID: 50601 RVA: 0x001D4486 File Offset: 0x001D2686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoSettlementRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C5AA RID: 50602 RVA: 0x001D44A3 File Offset: 0x001D26A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C5AB RID: 50603 RVA: 0x001D44AC File Offset: 0x001D26AC
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

		// Token: 0x04005557 RID: 21847
		private UnknownFieldSet _unknownFields;
	}
}
