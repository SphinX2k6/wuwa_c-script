using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000545 RID: 1349
	[NetMessage(EMessageId.FishingExitResponse)]
	public sealed class FishingExitResponse : IMessage<FishingExitResponse>, IMessage, IEquatable<FishingExitResponse>, IDeepCloneable<FishingExitResponse>, IBufferMessage
	{
		// Token: 0x06007E6B RID: 32363 RVA: 0x001322BA File Offset: 0x001304BA
		[NullableContext(1)]
		public static FishingExitResponse Create()
		{
			return new FishingExitResponse();
		}

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x06007E6C RID: 32364 RVA: 0x001322C1 File Offset: 0x001304C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x06007E6D RID: 32365 RVA: 0x001322C4 File Offset: 0x001304C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingExitResponse.Descriptor;
			}
		}

		// Token: 0x06007E6E RID: 32366 RVA: 0x001322CB File Offset: 0x001304CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingExitResponse()
		{
		}

		// Token: 0x06007E6F RID: 32367 RVA: 0x001322D3 File Offset: 0x001304D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingExitResponse(FishingExitResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E70 RID: 32368 RVA: 0x001322EC File Offset: 0x001304EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingExitResponse Clone()
		{
			return new FishingExitResponse(this);
		}

		// Token: 0x06007E71 RID: 32369 RVA: 0x001322F4 File Offset: 0x001304F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingExitResponse);
		}

		// Token: 0x06007E72 RID: 32370 RVA: 0x00132302 File Offset: 0x00130502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingExitResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007E73 RID: 32371 RVA: 0x00132320 File Offset: 0x00130520
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

		// Token: 0x06007E74 RID: 32372 RVA: 0x00132346 File Offset: 0x00130546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007E75 RID: 32373 RVA: 0x00132353 File Offset: 0x00130553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E76 RID: 32374 RVA: 0x0013235C File Offset: 0x0013055C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E77 RID: 32375 RVA: 0x00132374 File Offset: 0x00130574
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

		// Token: 0x06007E78 RID: 32376 RVA: 0x0013239A File Offset: 0x0013059A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingExitResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007E79 RID: 32377 RVA: 0x001323B7 File Offset: 0x001305B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E7A RID: 32378 RVA: 0x001323C0 File Offset: 0x001305C0
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

		// Token: 0x0400406B RID: 16491
		private UnknownFieldSet _unknownFields;
	}
}
