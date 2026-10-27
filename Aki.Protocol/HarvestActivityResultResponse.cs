using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200074A RID: 1866
	[NetMessage(EMessageId.HarvestActivityResultResponse)]
	public sealed class HarvestActivityResultResponse : IMessage<HarvestActivityResultResponse>, IMessage, IEquatable<HarvestActivityResultResponse>, IDeepCloneable<HarvestActivityResultResponse>, IBufferMessage
	{
		// Token: 0x0600A8F6 RID: 43254 RVA: 0x00196552 File Offset: 0x00194752
		[NullableContext(1)]
		public static HarvestActivityResultResponse Create()
		{
			return new HarvestActivityResultResponse();
		}

		// Token: 0x170021F9 RID: 8697
		// (get) Token: 0x0600A8F7 RID: 43255 RVA: 0x00196559 File Offset: 0x00194759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x0600A8F8 RID: 43256 RVA: 0x0019655C File Offset: 0x0019475C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityResultResponse.Descriptor;
			}
		}

		// Token: 0x0600A8F9 RID: 43257 RVA: 0x00196563 File Offset: 0x00194763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityResultResponse()
		{
		}

		// Token: 0x0600A8FA RID: 43258 RVA: 0x0019656B File Offset: 0x0019476B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityResultResponse(HarvestActivityResultResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A8FB RID: 43259 RVA: 0x00196584 File Offset: 0x00194784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityResultResponse Clone()
		{
			return new HarvestActivityResultResponse(this);
		}

		// Token: 0x0600A8FC RID: 43260 RVA: 0x0019658C File Offset: 0x0019478C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityResultResponse);
		}

		// Token: 0x0600A8FD RID: 43261 RVA: 0x0019659A File Offset: 0x0019479A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityResultResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A8FE RID: 43262 RVA: 0x001965B8 File Offset: 0x001947B8
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

		// Token: 0x0600A8FF RID: 43263 RVA: 0x001965DE File Offset: 0x001947DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A900 RID: 43264 RVA: 0x001965EB File Offset: 0x001947EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A901 RID: 43265 RVA: 0x001965F4 File Offset: 0x001947F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A902 RID: 43266 RVA: 0x0019660C File Offset: 0x0019480C
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

		// Token: 0x0600A903 RID: 43267 RVA: 0x00196632 File Offset: 0x00194832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivityResultResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A904 RID: 43268 RVA: 0x0019664F File Offset: 0x0019484F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A905 RID: 43269 RVA: 0x00196658 File Offset: 0x00194858
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

		// Token: 0x04004CFA RID: 19706
		private UnknownFieldSet _unknownFields;
	}
}
