using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000373 RID: 883
	[NetMessage(EMessageId.DangoBrawlSettleRequest)]
	public sealed class DangoBrawlSettleRequest : IMessage<DangoBrawlSettleRequest>, IMessage, IEquatable<DangoBrawlSettleRequest>, IDeepCloneable<DangoBrawlSettleRequest>, IBufferMessage
	{
		// Token: 0x06005813 RID: 22547 RVA: 0x000D75F0 File Offset: 0x000D57F0
		[NullableContext(1)]
		public static DangoBrawlSettleRequest Create()
		{
			return new DangoBrawlSettleRequest();
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06005814 RID: 22548 RVA: 0x000D75F7 File Offset: 0x000D57F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x06005815 RID: 22549 RVA: 0x000D75FA File Offset: 0x000D57FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlSettleRequest.Descriptor;
			}
		}

		// Token: 0x06005816 RID: 22550 RVA: 0x000D7601 File Offset: 0x000D5801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSettleRequest()
		{
		}

		// Token: 0x06005817 RID: 22551 RVA: 0x000D7609 File Offset: 0x000D5809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSettleRequest(DangoBrawlSettleRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005818 RID: 22552 RVA: 0x000D7622 File Offset: 0x000D5822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSettleRequest Clone()
		{
			return new DangoBrawlSettleRequest(this);
		}

		// Token: 0x06005819 RID: 22553 RVA: 0x000D762A File Offset: 0x000D582A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlSettleRequest);
		}

		// Token: 0x0600581A RID: 22554 RVA: 0x000D7638 File Offset: 0x000D5838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlSettleRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600581B RID: 22555 RVA: 0x000D7658 File Offset: 0x000D5858
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

		// Token: 0x0600581C RID: 22556 RVA: 0x000D767E File Offset: 0x000D587E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600581D RID: 22557 RVA: 0x000D768B File Offset: 0x000D588B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600581E RID: 22558 RVA: 0x000D7694 File Offset: 0x000D5894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600581F RID: 22559 RVA: 0x000D76AC File Offset: 0x000D58AC
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

		// Token: 0x06005820 RID: 22560 RVA: 0x000D76D2 File Offset: 0x000D58D2
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

		// Token: 0x06005821 RID: 22561 RVA: 0x000D76EF File Offset: 0x000D58EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005822 RID: 22562 RVA: 0x000D76F8 File Offset: 0x000D58F8
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

		// Token: 0x0400355B RID: 13659
		private UnknownFieldSet _unknownFields;
	}
}
