using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000552 RID: 1362
	[NetMessage(EMessageId.FishingInfoRequest)]
	public sealed class FishingInfoRequest : IMessage<FishingInfoRequest>, IMessage, IEquatable<FishingInfoRequest>, IDeepCloneable<FishingInfoRequest>, IBufferMessage
	{
		// Token: 0x06007F7F RID: 32639 RVA: 0x00134D70 File Offset: 0x00132F70
		[NullableContext(1)]
		public static FishingInfoRequest Create()
		{
			return new FishingInfoRequest();
		}

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x06007F80 RID: 32640 RVA: 0x00134D77 File Offset: 0x00132F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x06007F81 RID: 32641 RVA: 0x00134D7A File Offset: 0x00132F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingInfoRequest.Descriptor;
			}
		}

		// Token: 0x06007F82 RID: 32642 RVA: 0x00134D81 File Offset: 0x00132F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoRequest()
		{
		}

		// Token: 0x06007F83 RID: 32643 RVA: 0x00134D89 File Offset: 0x00132F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoRequest(FishingInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F84 RID: 32644 RVA: 0x00134DA2 File Offset: 0x00132FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoRequest Clone()
		{
			return new FishingInfoRequest(this);
		}

		// Token: 0x06007F85 RID: 32645 RVA: 0x00134DAA File Offset: 0x00132FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingInfoRequest);
		}

		// Token: 0x06007F86 RID: 32646 RVA: 0x00134DB8 File Offset: 0x00132FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007F87 RID: 32647 RVA: 0x00134DD8 File Offset: 0x00132FD8
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

		// Token: 0x06007F88 RID: 32648 RVA: 0x00134DFE File Offset: 0x00132FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007F89 RID: 32649 RVA: 0x00134E0B File Offset: 0x0013300B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F8A RID: 32650 RVA: 0x00134E14 File Offset: 0x00133014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F8B RID: 32651 RVA: 0x00134E2C File Offset: 0x0013302C
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

		// Token: 0x06007F8C RID: 32652 RVA: 0x00134E52 File Offset: 0x00133052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F8D RID: 32653 RVA: 0x00134E6F File Offset: 0x0013306F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F8E RID: 32654 RVA: 0x00134E78 File Offset: 0x00133078
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

		// Token: 0x040040D2 RID: 16594
		private UnknownFieldSet _unknownFields;
	}
}
