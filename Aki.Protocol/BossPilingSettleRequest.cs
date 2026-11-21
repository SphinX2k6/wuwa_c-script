using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001CE RID: 462
	[NetMessage(EMessageId.BossPilingSettleRequest)]
	public sealed class BossPilingSettleRequest : IMessage<BossPilingSettleRequest>, IMessage, IEquatable<BossPilingSettleRequest>, IDeepCloneable<BossPilingSettleRequest>, IBufferMessage
	{
		// Token: 0x060034F4 RID: 13556 RVA: 0x00085B75 File Offset: 0x00083D75
		[NullableContext(1)]
		public static BossPilingSettleRequest Create()
		{
			return new BossPilingSettleRequest();
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x060034F5 RID: 13557 RVA: 0x00085B7C File Offset: 0x00083D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x060034F6 RID: 13558 RVA: 0x00085B7F File Offset: 0x00083D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingSettleRequest.Descriptor;
			}
		}

		// Token: 0x060034F7 RID: 13559 RVA: 0x00085B86 File Offset: 0x00083D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingSettleRequest()
		{
		}

		// Token: 0x060034F8 RID: 13560 RVA: 0x00085B8E File Offset: 0x00083D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingSettleRequest(BossPilingSettleRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x00085BA7 File Offset: 0x00083DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingSettleRequest Clone()
		{
			return new BossPilingSettleRequest(this);
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x00085BAF File Offset: 0x00083DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingSettleRequest);
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x00085BBD File Offset: 0x00083DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingSettleRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x00085BDC File Offset: 0x00083DDC
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

		// Token: 0x060034FD RID: 13565 RVA: 0x00085C02 File Offset: 0x00083E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x00085C0F File Offset: 0x00083E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x00085C18 File Offset: 0x00083E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x00085C30 File Offset: 0x00083E30
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

		// Token: 0x06003501 RID: 13569 RVA: 0x00085C56 File Offset: 0x00083E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingSettleRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x00085C73 File Offset: 0x00083E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x00085C7C File Offset: 0x00083E7C
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

		// Token: 0x04002A82 RID: 10882
		private UnknownFieldSet _unknownFields;
	}
}
