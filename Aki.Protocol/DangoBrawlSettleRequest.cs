using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200036B RID: 875
	[NetMessage(EMessageId.DangoBrawlSettleRequest)]
	public sealed class DangoBrawlSettleRequest : IMessage<DangoBrawlSettleRequest>, IMessage, IEquatable<DangoBrawlSettleRequest>, IDeepCloneable<DangoBrawlSettleRequest>, IBufferMessage
	{
		// Token: 0x06005726 RID: 22310 RVA: 0x000D4F67 File Offset: 0x000D3167
		[NullableContext(1)]
		public static DangoBrawlSettleRequest Create()
		{
			return new DangoBrawlSettleRequest();
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06005727 RID: 22311 RVA: 0x000D4F6E File Offset: 0x000D316E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06005728 RID: 22312 RVA: 0x000D4F71 File Offset: 0x000D3171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlSettleRequest.Descriptor;
			}
		}

		// Token: 0x06005729 RID: 22313 RVA: 0x000D4F78 File Offset: 0x000D3178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSettleRequest()
		{
		}

		// Token: 0x0600572A RID: 22314 RVA: 0x000D4F80 File Offset: 0x000D3180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSettleRequest(DangoBrawlSettleRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600572B RID: 22315 RVA: 0x000D4F99 File Offset: 0x000D3199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSettleRequest Clone()
		{
			return new DangoBrawlSettleRequest(this);
		}

		// Token: 0x0600572C RID: 22316 RVA: 0x000D4FA1 File Offset: 0x000D31A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlSettleRequest);
		}

		// Token: 0x0600572D RID: 22317 RVA: 0x000D4FAF File Offset: 0x000D31AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlSettleRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600572E RID: 22318 RVA: 0x000D4FD0 File Offset: 0x000D31D0
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

		// Token: 0x0600572F RID: 22319 RVA: 0x000D4FF6 File Offset: 0x000D31F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005730 RID: 22320 RVA: 0x000D5003 File Offset: 0x000D3203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005731 RID: 22321 RVA: 0x000D500C File Offset: 0x000D320C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005732 RID: 22322 RVA: 0x000D5024 File Offset: 0x000D3224
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

		// Token: 0x06005733 RID: 22323 RVA: 0x000D504A File Offset: 0x000D324A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlSettleRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005734 RID: 22324 RVA: 0x000D5067 File Offset: 0x000D3267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005735 RID: 22325 RVA: 0x000D5070 File Offset: 0x000D3270
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

		// Token: 0x040034BF RID: 13503
		private UnknownFieldSet _unknownFields;
	}
}
