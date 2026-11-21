using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200055D RID: 1373
	[NetMessage(EMessageId.FishingQuickSellPreviewRequest)]
	public sealed class FishingQuickSellPreviewRequest : IMessage<FishingQuickSellPreviewRequest>, IMessage, IEquatable<FishingQuickSellPreviewRequest>, IDeepCloneable<FishingQuickSellPreviewRequest>, IBufferMessage
	{
		// Token: 0x0600805B RID: 32859 RVA: 0x00136AEF File Offset: 0x00134CEF
		[NullableContext(1)]
		public static FishingQuickSellPreviewRequest Create()
		{
			return new FishingQuickSellPreviewRequest();
		}

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x0600805C RID: 32860 RVA: 0x00136AF6 File Offset: 0x00134CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x0600805D RID: 32861 RVA: 0x00136AF9 File Offset: 0x00134CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingQuickSellPreviewRequest.Descriptor;
			}
		}

		// Token: 0x0600805E RID: 32862 RVA: 0x00136B00 File Offset: 0x00134D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellPreviewRequest()
		{
		}

		// Token: 0x0600805F RID: 32863 RVA: 0x00136B08 File Offset: 0x00134D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellPreviewRequest(FishingQuickSellPreviewRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008060 RID: 32864 RVA: 0x00136B21 File Offset: 0x00134D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellPreviewRequest Clone()
		{
			return new FishingQuickSellPreviewRequest(this);
		}

		// Token: 0x06008061 RID: 32865 RVA: 0x00136B29 File Offset: 0x00134D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingQuickSellPreviewRequest);
		}

		// Token: 0x06008062 RID: 32866 RVA: 0x00136B37 File Offset: 0x00134D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingQuickSellPreviewRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06008063 RID: 32867 RVA: 0x00136B58 File Offset: 0x00134D58
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

		// Token: 0x06008064 RID: 32868 RVA: 0x00136B7E File Offset: 0x00134D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008065 RID: 32869 RVA: 0x00136B8B File Offset: 0x00134D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008066 RID: 32870 RVA: 0x00136B94 File Offset: 0x00134D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008067 RID: 32871 RVA: 0x00136BAC File Offset: 0x00134DAC
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

		// Token: 0x06008068 RID: 32872 RVA: 0x00136BD2 File Offset: 0x00134DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingQuickSellPreviewRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008069 RID: 32873 RVA: 0x00136BEF File Offset: 0x00134DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600806A RID: 32874 RVA: 0x00136BF8 File Offset: 0x00134DF8
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

		// Token: 0x04004110 RID: 16656
		private UnknownFieldSet _unknownFields;
	}
}
