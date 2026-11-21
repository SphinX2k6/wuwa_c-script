using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E3 RID: 483
	[NetMessage(EMessageId.BossRushSettlementRequest)]
	public sealed class BossRushSettlementRequest : IMessage<BossRushSettlementRequest>, IMessage, IEquatable<BossRushSettlementRequest>, IDeepCloneable<BossRushSettlementRequest>, IBufferMessage
	{
		// Token: 0x060036A0 RID: 13984 RVA: 0x00089762 File Offset: 0x00087962
		[NullableContext(1)]
		public static BossRushSettlementRequest Create()
		{
			return new BossRushSettlementRequest();
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x060036A1 RID: 13985 RVA: 0x00089769 File Offset: 0x00087969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x060036A2 RID: 13986 RVA: 0x0008976C File Offset: 0x0008796C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushSettlementRequest.Descriptor;
			}
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x00089773 File Offset: 0x00087973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushSettlementRequest()
		{
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x0008977B File Offset: 0x0008797B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushSettlementRequest(BossRushSettlementRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x00089794 File Offset: 0x00087994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushSettlementRequest Clone()
		{
			return new BossRushSettlementRequest(this);
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x0008979C File Offset: 0x0008799C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushSettlementRequest);
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x000897AA File Offset: 0x000879AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushSettlementRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x000897C8 File Offset: 0x000879C8
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

		// Token: 0x060036A9 RID: 13993 RVA: 0x000897EE File Offset: 0x000879EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x000897FB File Offset: 0x000879FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x00089804 File Offset: 0x00087A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x0008981C File Offset: 0x00087A1C
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

		// Token: 0x060036AD RID: 13997 RVA: 0x00089842 File Offset: 0x00087A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushSettlementRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x0008985F File Offset: 0x00087A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x00089868 File Offset: 0x00087A68
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

		// Token: 0x04002B0C RID: 11020
		private UnknownFieldSet _unknownFields;
	}
}
