using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B7 RID: 183
	[NetMessage(EMessageId.AddUnlockedGuideNotify)]
	public sealed class AddUnlockedGuideNotify : IMessage<AddUnlockedGuideNotify>, IMessage, IEquatable<AddUnlockedGuideNotify>, IDeepCloneable<AddUnlockedGuideNotify>, IBufferMessage
	{
		// Token: 0x06001E01 RID: 7681 RVA: 0x00052239 File Offset: 0x00050439
		[NullableContext(1)]
		public static AddUnlockedGuideNotify Create()
		{
			return new AddUnlockedGuideNotify();
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x00052240 File Offset: 0x00050440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x00052243 File Offset: 0x00050443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddUnlockedGuideNotify.Descriptor;
			}
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x0005224A File Offset: 0x0005044A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddUnlockedGuideNotify()
		{
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x0005225D File Offset: 0x0005045D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddUnlockedGuideNotify(AddUnlockedGuideNotify other) : this()
		{
			this.unlockedGuideIds_ = other.unlockedGuideIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00052287 File Offset: 0x00050487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddUnlockedGuideNotify Clone()
		{
			return new AddUnlockedGuideNotify(this);
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x0005228F File Offset: 0x0005048F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedGuideIds
		{
			get
			{
				return this.unlockedGuideIds_;
			}
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x00052297 File Offset: 0x00050497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddUnlockedGuideNotify);
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x000522A5 File Offset: 0x000504A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddUnlockedGuideNotify other)
		{
			return other != null && (other == this || (this.unlockedGuideIds_.Equals(other.unlockedGuideIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x000522D8 File Offset: 0x000504D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockedGuideIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x0005230C File Offset: 0x0005050C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x00052319 File Offset: 0x00050519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00052322 File Offset: 0x00050522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockedGuideIds_.WriteTo(ref output, AddUnlockedGuideNotify._repeated_unlockedGuideIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x0005234C File Offset: 0x0005054C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockedGuideIds_.CalculateSize(AddUnlockedGuideNotify._repeated_unlockedGuideIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x00052385 File Offset: 0x00050585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddUnlockedGuideNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockedGuideIds_.Add(other.unlockedGuideIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x000523B3 File Offset: 0x000505B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x000523BC File Offset: 0x000505BC
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
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockedGuideIds_.AddEntriesFrom(ref input, AddUnlockedGuideNotify._repeated_unlockedGuideIds_codec);
				}
			}
		}

		// Token: 0x0400233E RID: 9022
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400233F RID: 9023
		public const int UnlockedGuideIdsFieldNumber = 5;

		// Token: 0x04002340 RID: 9024
		private static readonly FieldCodec<int> _repeated_unlockedGuideIds_codec = FieldCodec.ForSInt32(42U);

		// Token: 0x04002341 RID: 9025
		private readonly RepeatedField<int> unlockedGuideIds_ = new RepeatedField<int>();
	}
}
