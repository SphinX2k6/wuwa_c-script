using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C1 RID: 2241
	[NetMessage(EMessageId.KurotatoSettlementRequest)]
	public sealed class KurotatoSettlementRequest : IMessage<KurotatoSettlementRequest>, IMessage, IEquatable<KurotatoSettlementRequest>, IDeepCloneable<KurotatoSettlementRequest>, IBufferMessage
	{
		// Token: 0x0600C6B8 RID: 50872 RVA: 0x001D668C File Offset: 0x001D488C
		[NullableContext(1)]
		public static KurotatoSettlementRequest Create()
		{
			return new KurotatoSettlementRequest();
		}

		// Token: 0x17002829 RID: 10281
		// (get) Token: 0x0600C6B9 RID: 50873 RVA: 0x001D6693 File Offset: 0x001D4893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700282A RID: 10282
		// (get) Token: 0x0600C6BA RID: 50874 RVA: 0x001D6696 File Offset: 0x001D4896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoSettlementRequest.Descriptor;
			}
		}

		// Token: 0x0600C6BB RID: 50875 RVA: 0x001D669D File Offset: 0x001D489D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementRequest()
		{
		}

		// Token: 0x0600C6BC RID: 50876 RVA: 0x001D66A5 File Offset: 0x001D48A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementRequest(KurotatoSettlementRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C6BD RID: 50877 RVA: 0x001D66BE File Offset: 0x001D48BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementRequest Clone()
		{
			return new KurotatoSettlementRequest(this);
		}

		// Token: 0x0600C6BE RID: 50878 RVA: 0x001D66C6 File Offset: 0x001D48C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoSettlementRequest);
		}

		// Token: 0x0600C6BF RID: 50879 RVA: 0x001D66D4 File Offset: 0x001D48D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoSettlementRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C6C0 RID: 50880 RVA: 0x001D66F4 File Offset: 0x001D48F4
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

		// Token: 0x0600C6C1 RID: 50881 RVA: 0x001D671A File Offset: 0x001D491A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C6C2 RID: 50882 RVA: 0x001D6727 File Offset: 0x001D4927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C6C3 RID: 50883 RVA: 0x001D6730 File Offset: 0x001D4930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C6C4 RID: 50884 RVA: 0x001D6748 File Offset: 0x001D4948
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

		// Token: 0x0600C6C5 RID: 50885 RVA: 0x001D676E File Offset: 0x001D496E
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

		// Token: 0x0600C6C6 RID: 50886 RVA: 0x001D678B File Offset: 0x001D498B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C6C7 RID: 50887 RVA: 0x001D6794 File Offset: 0x001D4994
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

		// Token: 0x04005550 RID: 21840
		private UnknownFieldSet _unknownFields;
	}
}
