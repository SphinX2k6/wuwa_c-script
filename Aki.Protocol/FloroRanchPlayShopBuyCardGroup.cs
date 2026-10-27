using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005CE RID: 1486
	public sealed class FloroRanchPlayShopBuyCardGroup : IMessage<FloroRanchPlayShopBuyCardGroup>, IMessage, IEquatable<FloroRanchPlayShopBuyCardGroup>, IDeepCloneable<FloroRanchPlayShopBuyCardGroup>, IBufferMessage
	{
		// Token: 0x0600895C RID: 35164 RVA: 0x0014B3A4 File Offset: 0x001495A4
		[NullableContext(1)]
		public static FloroRanchPlayShopBuyCardGroup Create()
		{
			return new FloroRanchPlayShopBuyCardGroup();
		}

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x0600895D RID: 35165 RVA: 0x0014B3AB File Offset: 0x001495AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x0600895E RID: 35166 RVA: 0x0014B3AE File Offset: 0x001495AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayShopBuyCardGroup.Descriptor;
			}
		}

		// Token: 0x0600895F RID: 35167 RVA: 0x0014B3B5 File Offset: 0x001495B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyCardGroup()
		{
		}

		// Token: 0x06008960 RID: 35168 RVA: 0x0014B3C8 File Offset: 0x001495C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyCardGroup(FloroRanchPlayShopBuyCardGroup other) : this()
		{
			this.cardIds_ = other.cardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008961 RID: 35169 RVA: 0x0014B3F2 File Offset: 0x001495F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyCardGroup Clone()
		{
			return new FloroRanchPlayShopBuyCardGroup(this);
		}

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x06008962 RID: 35170 RVA: 0x0014B3FA File Offset: 0x001495FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardIds
		{
			get
			{
				return this.cardIds_;
			}
		}

		// Token: 0x06008963 RID: 35171 RVA: 0x0014B402 File Offset: 0x00149602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayShopBuyCardGroup);
		}

		// Token: 0x06008964 RID: 35172 RVA: 0x0014B410 File Offset: 0x00149610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayShopBuyCardGroup other)
		{
			return other != null && (other == this || (this.cardIds_.Equals(other.cardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008965 RID: 35173 RVA: 0x0014B444 File Offset: 0x00149644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008966 RID: 35174 RVA: 0x0014B478 File Offset: 0x00149678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008967 RID: 35175 RVA: 0x0014B485 File Offset: 0x00149685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008968 RID: 35176 RVA: 0x0014B48E File Offset: 0x0014968E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cardIds_.WriteTo(ref output, FloroRanchPlayShopBuyCardGroup._repeated_cardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008969 RID: 35177 RVA: 0x0014B4B8 File Offset: 0x001496B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cardIds_.CalculateSize(FloroRanchPlayShopBuyCardGroup._repeated_cardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600896A RID: 35178 RVA: 0x0014B4F1 File Offset: 0x001496F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayShopBuyCardGroup other)
		{
			if (other == null)
			{
				return;
			}
			this.cardIds_.Add(other.cardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600896B RID: 35179 RVA: 0x0014B51F File Offset: 0x0014971F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600896C RID: 35180 RVA: 0x0014B528 File Offset: 0x00149728
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.cardIds_.AddEntriesFrom(ref input, FloroRanchPlayShopBuyCardGroup._repeated_cardIds_codec);
				}
			}
		}

		// Token: 0x0400438D RID: 17293
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400438E RID: 17294
		public const int CardIdsFieldNumber = 1;

		// Token: 0x0400438F RID: 17295
		private static readonly FieldCodec<int> _repeated_cardIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04004390 RID: 17296
		private readonly RepeatedField<int> cardIds_ = new RepeatedField<int>();
	}
}
