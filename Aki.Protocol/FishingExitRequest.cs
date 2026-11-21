using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000544 RID: 1348
	[NetMessage(EMessageId.FishingExitRequest)]
	public sealed class FishingExitRequest : IMessage<FishingExitRequest>, IMessage, IEquatable<FishingExitRequest>, IDeepCloneable<FishingExitRequest>, IBufferMessage
	{
		// Token: 0x06007E5B RID: 32347 RVA: 0x00132181 File Offset: 0x00130381
		[NullableContext(1)]
		public static FishingExitRequest Create()
		{
			return new FishingExitRequest();
		}

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x06007E5C RID: 32348 RVA: 0x00132188 File Offset: 0x00130388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x06007E5D RID: 32349 RVA: 0x0013218B File Offset: 0x0013038B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingExitRequest.Descriptor;
			}
		}

		// Token: 0x06007E5E RID: 32350 RVA: 0x00132192 File Offset: 0x00130392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingExitRequest()
		{
		}

		// Token: 0x06007E5F RID: 32351 RVA: 0x0013219A File Offset: 0x0013039A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingExitRequest(FishingExitRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E60 RID: 32352 RVA: 0x001321B3 File Offset: 0x001303B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingExitRequest Clone()
		{
			return new FishingExitRequest(this);
		}

		// Token: 0x06007E61 RID: 32353 RVA: 0x001321BB File Offset: 0x001303BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingExitRequest);
		}

		// Token: 0x06007E62 RID: 32354 RVA: 0x001321C9 File Offset: 0x001303C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingExitRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007E63 RID: 32355 RVA: 0x001321E8 File Offset: 0x001303E8
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

		// Token: 0x06007E64 RID: 32356 RVA: 0x0013220E File Offset: 0x0013040E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007E65 RID: 32357 RVA: 0x0013221B File Offset: 0x0013041B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E66 RID: 32358 RVA: 0x00132224 File Offset: 0x00130424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E67 RID: 32359 RVA: 0x0013223C File Offset: 0x0013043C
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

		// Token: 0x06007E68 RID: 32360 RVA: 0x00132262 File Offset: 0x00130462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingExitRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007E69 RID: 32361 RVA: 0x0013227F File Offset: 0x0013047F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E6A RID: 32362 RVA: 0x00132288 File Offset: 0x00130488
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

		// Token: 0x0400406A RID: 16490
		private UnknownFieldSet _unknownFields;
	}
}
