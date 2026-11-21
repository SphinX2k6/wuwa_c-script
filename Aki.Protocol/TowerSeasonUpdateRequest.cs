using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200143F RID: 5183
	[NetMessage(EMessageId.TowerSeasonUpdateRequest)]
	public sealed class TowerSeasonUpdateRequest : IMessage<TowerSeasonUpdateRequest>, IMessage, IEquatable<TowerSeasonUpdateRequest>, IDeepCloneable<TowerSeasonUpdateRequest>, IBufferMessage
	{
		// Token: 0x0601B8A4 RID: 112804 RVA: 0x00400C82 File Offset: 0x003FEE82
		[NullableContext(1)]
		public static TowerSeasonUpdateRequest Create()
		{
			return new TowerSeasonUpdateRequest();
		}

		// Token: 0x17005D3E RID: 23870
		// (get) Token: 0x0601B8A5 RID: 112805 RVA: 0x00400C89 File Offset: 0x003FEE89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D3F RID: 23871
		// (get) Token: 0x0601B8A6 RID: 112806 RVA: 0x00400C8C File Offset: 0x003FEE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerSeasonUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0601B8A7 RID: 112807 RVA: 0x00400C93 File Offset: 0x003FEE93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerSeasonUpdateRequest()
		{
		}

		// Token: 0x0601B8A8 RID: 112808 RVA: 0x00400C9B File Offset: 0x003FEE9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerSeasonUpdateRequest(TowerSeasonUpdateRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B8A9 RID: 112809 RVA: 0x00400CB4 File Offset: 0x003FEEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerSeasonUpdateRequest Clone()
		{
			return new TowerSeasonUpdateRequest(this);
		}

		// Token: 0x0601B8AA RID: 112810 RVA: 0x00400CBC File Offset: 0x003FEEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerSeasonUpdateRequest);
		}

		// Token: 0x0601B8AB RID: 112811 RVA: 0x00400CCA File Offset: 0x003FEECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerSeasonUpdateRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601B8AC RID: 112812 RVA: 0x00400CE8 File Offset: 0x003FEEE8
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

		// Token: 0x0601B8AD RID: 112813 RVA: 0x00400D0E File Offset: 0x003FEF0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B8AE RID: 112814 RVA: 0x00400D1B File Offset: 0x003FEF1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B8AF RID: 112815 RVA: 0x00400D24 File Offset: 0x003FEF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B8B0 RID: 112816 RVA: 0x00400D3C File Offset: 0x003FEF3C
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

		// Token: 0x0601B8B1 RID: 112817 RVA: 0x00400D62 File Offset: 0x003FEF62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerSeasonUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B8B2 RID: 112818 RVA: 0x00400D7F File Offset: 0x003FEF7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B8B3 RID: 112819 RVA: 0x00400D88 File Offset: 0x003FEF88
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

		// Token: 0x0400A039 RID: 41017
		private UnknownFieldSet _unknownFields;
	}
}
