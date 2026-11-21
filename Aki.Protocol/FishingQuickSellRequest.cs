using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200055F RID: 1375
	[NetMessage(EMessageId.FishingQuickSellRequest)]
	public sealed class FishingQuickSellRequest : IMessage<FishingQuickSellRequest>, IMessage, IEquatable<FishingQuickSellRequest>, IDeepCloneable<FishingQuickSellRequest>, IBufferMessage
	{
		// Token: 0x06008080 RID: 32896 RVA: 0x00136F93 File Offset: 0x00135193
		[NullableContext(1)]
		public static FishingQuickSellRequest Create()
		{
			return new FishingQuickSellRequest();
		}

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x06008081 RID: 32897 RVA: 0x00136F9A File Offset: 0x0013519A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x06008082 RID: 32898 RVA: 0x00136F9D File Offset: 0x0013519D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingQuickSellRequest.Descriptor;
			}
		}

		// Token: 0x06008083 RID: 32899 RVA: 0x00136FA4 File Offset: 0x001351A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellRequest()
		{
		}

		// Token: 0x06008084 RID: 32900 RVA: 0x00136FAC File Offset: 0x001351AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellRequest(FishingQuickSellRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008085 RID: 32901 RVA: 0x00136FC5 File Offset: 0x001351C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellRequest Clone()
		{
			return new FishingQuickSellRequest(this);
		}

		// Token: 0x06008086 RID: 32902 RVA: 0x00136FCD File Offset: 0x001351CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingQuickSellRequest);
		}

		// Token: 0x06008087 RID: 32903 RVA: 0x00136FDB File Offset: 0x001351DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingQuickSellRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06008088 RID: 32904 RVA: 0x00136FFC File Offset: 0x001351FC
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

		// Token: 0x06008089 RID: 32905 RVA: 0x00137022 File Offset: 0x00135222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600808A RID: 32906 RVA: 0x0013702F File Offset: 0x0013522F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600808B RID: 32907 RVA: 0x00137038 File Offset: 0x00135238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600808C RID: 32908 RVA: 0x00137050 File Offset: 0x00135250
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

		// Token: 0x0600808D RID: 32909 RVA: 0x00137076 File Offset: 0x00135276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingQuickSellRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600808E RID: 32910 RVA: 0x00137093 File Offset: 0x00135293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600808F RID: 32911 RVA: 0x0013709C File Offset: 0x0013529C
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

		// Token: 0x0400411A RID: 16666
		private UnknownFieldSet _unknownFields;
	}
}
