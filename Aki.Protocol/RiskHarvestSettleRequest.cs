using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F55 RID: 3925
	[NetMessage(EMessageId.RiskHarvestSettleRequest)]
	public sealed class RiskHarvestSettleRequest : IMessage<RiskHarvestSettleRequest>, IMessage, IEquatable<RiskHarvestSettleRequest>, IDeepCloneable<RiskHarvestSettleRequest>, IBufferMessage
	{
		// Token: 0x0601504D RID: 86093 RVA: 0x0030CFD5 File Offset: 0x0030B1D5
		[NullableContext(1)]
		public static RiskHarvestSettleRequest Create()
		{
			return new RiskHarvestSettleRequest();
		}

		// Token: 0x170045F0 RID: 17904
		// (get) Token: 0x0601504E RID: 86094 RVA: 0x0030CFDC File Offset: 0x0030B1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045F1 RID: 17905
		// (get) Token: 0x0601504F RID: 86095 RVA: 0x0030CFDF File Offset: 0x0030B1DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestSettleRequest.Descriptor;
			}
		}

		// Token: 0x06015050 RID: 86096 RVA: 0x0030CFE6 File Offset: 0x0030B1E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestSettleRequest()
		{
		}

		// Token: 0x06015051 RID: 86097 RVA: 0x0030CFEE File Offset: 0x0030B1EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestSettleRequest(RiskHarvestSettleRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015052 RID: 86098 RVA: 0x0030D007 File Offset: 0x0030B207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestSettleRequest Clone()
		{
			return new RiskHarvestSettleRequest(this);
		}

		// Token: 0x06015053 RID: 86099 RVA: 0x0030D00F File Offset: 0x0030B20F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestSettleRequest);
		}

		// Token: 0x06015054 RID: 86100 RVA: 0x0030D01D File Offset: 0x0030B21D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestSettleRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06015055 RID: 86101 RVA: 0x0030D03C File Offset: 0x0030B23C
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

		// Token: 0x06015056 RID: 86102 RVA: 0x0030D062 File Offset: 0x0030B262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015057 RID: 86103 RVA: 0x0030D06F File Offset: 0x0030B26F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015058 RID: 86104 RVA: 0x0030D078 File Offset: 0x0030B278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015059 RID: 86105 RVA: 0x0030D090 File Offset: 0x0030B290
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

		// Token: 0x0601505A RID: 86106 RVA: 0x0030D0B6 File Offset: 0x0030B2B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestSettleRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601505B RID: 86107 RVA: 0x0030D0D3 File Offset: 0x0030B2D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601505C RID: 86108 RVA: 0x0030D0DC File Offset: 0x0030B2DC
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

		// Token: 0x04007F12 RID: 32530
		private UnknownFieldSet _unknownFields;
	}
}
