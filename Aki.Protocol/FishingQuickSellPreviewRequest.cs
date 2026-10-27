using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000572 RID: 1394
	[NetMessage(EMessageId.FishingQuickSellPreviewRequest)]
	public sealed class FishingQuickSellPreviewRequest : IMessage<FishingQuickSellPreviewRequest>, IMessage, IEquatable<FishingQuickSellPreviewRequest>, IDeepCloneable<FishingQuickSellPreviewRequest>, IBufferMessage
	{
		// Token: 0x060081C3 RID: 33219 RVA: 0x001396EF File Offset: 0x001378EF
		[NullableContext(1)]
		public static FishingQuickSellPreviewRequest Create()
		{
			return new FishingQuickSellPreviewRequest();
		}

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x060081C4 RID: 33220 RVA: 0x001396F6 File Offset: 0x001378F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x060081C5 RID: 33221 RVA: 0x001396F9 File Offset: 0x001378F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingQuickSellPreviewRequest.Descriptor;
			}
		}

		// Token: 0x060081C6 RID: 33222 RVA: 0x00139700 File Offset: 0x00137900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellPreviewRequest()
		{
		}

		// Token: 0x060081C7 RID: 33223 RVA: 0x00139708 File Offset: 0x00137908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellPreviewRequest(FishingQuickSellPreviewRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081C8 RID: 33224 RVA: 0x00139721 File Offset: 0x00137921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellPreviewRequest Clone()
		{
			return new FishingQuickSellPreviewRequest(this);
		}

		// Token: 0x060081C9 RID: 33225 RVA: 0x00139729 File Offset: 0x00137929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingQuickSellPreviewRequest);
		}

		// Token: 0x060081CA RID: 33226 RVA: 0x00139737 File Offset: 0x00137937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingQuickSellPreviewRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060081CB RID: 33227 RVA: 0x00139758 File Offset: 0x00137958
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

		// Token: 0x060081CC RID: 33228 RVA: 0x0013977E File Offset: 0x0013797E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060081CD RID: 33229 RVA: 0x0013978B File Offset: 0x0013798B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081CE RID: 33230 RVA: 0x00139794 File Offset: 0x00137994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060081CF RID: 33231 RVA: 0x001397AC File Offset: 0x001379AC
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

		// Token: 0x060081D0 RID: 33232 RVA: 0x001397D2 File Offset: 0x001379D2
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

		// Token: 0x060081D1 RID: 33233 RVA: 0x001397EF File Offset: 0x001379EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081D2 RID: 33234 RVA: 0x001397F8 File Offset: 0x001379F8
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
