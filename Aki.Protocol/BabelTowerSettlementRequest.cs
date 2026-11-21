using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000154 RID: 340
	[NetMessage(EMessageId.BabelTowerSettlementRequest)]
	public sealed class BabelTowerSettlementRequest : IMessage<BabelTowerSettlementRequest>, IMessage, IEquatable<BabelTowerSettlementRequest>, IDeepCloneable<BabelTowerSettlementRequest>, IBufferMessage
	{
		// Token: 0x06002B5C RID: 11100 RVA: 0x000717EB File Offset: 0x0006F9EB
		[NullableContext(1)]
		public static BabelTowerSettlementRequest Create()
		{
			return new BabelTowerSettlementRequest();
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06002B5D RID: 11101 RVA: 0x000717F2 File Offset: 0x0006F9F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06002B5E RID: 11102 RVA: 0x000717F5 File Offset: 0x0006F9F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerSettlementRequest.Descriptor;
			}
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x000717FC File Offset: 0x0006F9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSettlementRequest()
		{
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x00071804 File Offset: 0x0006FA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSettlementRequest(BabelTowerSettlementRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x0007181D File Offset: 0x0006FA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSettlementRequest Clone()
		{
			return new BabelTowerSettlementRequest(this);
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x00071825 File Offset: 0x0006FA25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerSettlementRequest);
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x00071833 File Offset: 0x0006FA33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerSettlementRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x00071854 File Offset: 0x0006FA54
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

		// Token: 0x06002B65 RID: 11109 RVA: 0x0007187A File Offset: 0x0006FA7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x00071887 File Offset: 0x0006FA87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x00071890 File Offset: 0x0006FA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x000718A8 File Offset: 0x0006FAA8
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

		// Token: 0x06002B69 RID: 11113 RVA: 0x000718CE File Offset: 0x0006FACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerSettlementRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x000718EB File Offset: 0x0006FAEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x000718F4 File Offset: 0x0006FAF4
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

		// Token: 0x040027F5 RID: 10229
		private UnknownFieldSet _unknownFields;
	}
}
