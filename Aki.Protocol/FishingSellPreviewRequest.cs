using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000579 RID: 1401
	[NetMessage(EMessageId.FishingSellPreviewRequest)]
	public sealed class FishingSellPreviewRequest : IMessage<FishingSellPreviewRequest>, IMessage, IEquatable<FishingSellPreviewRequest>, IDeepCloneable<FishingSellPreviewRequest>, IBufferMessage
	{
		// Token: 0x06008244 RID: 33348 RVA: 0x0013A60F File Offset: 0x0013880F
		[NullableContext(1)]
		public static FishingSellPreviewRequest Create()
		{
			return new FishingSellPreviewRequest();
		}

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x06008245 RID: 33349 RVA: 0x0013A616 File Offset: 0x00138816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x06008246 RID: 33350 RVA: 0x0013A619 File Offset: 0x00138819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSellPreviewRequest.Descriptor;
			}
		}

		// Token: 0x06008247 RID: 33351 RVA: 0x0013A620 File Offset: 0x00138820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellPreviewRequest()
		{
		}

		// Token: 0x06008248 RID: 33352 RVA: 0x0013A633 File Offset: 0x00138833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellPreviewRequest(FishingSellPreviewRequest other) : this()
		{
			this.incrIds_ = other.incrIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008249 RID: 33353 RVA: 0x0013A65D File Offset: 0x0013885D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellPreviewRequest Clone()
		{
			return new FishingSellPreviewRequest(this);
		}

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x0600824A RID: 33354 RVA: 0x0013A665 File Offset: 0x00138865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> IncrIds
		{
			get
			{
				return this.incrIds_;
			}
		}

		// Token: 0x0600824B RID: 33355 RVA: 0x0013A66D File Offset: 0x0013886D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSellPreviewRequest);
		}

		// Token: 0x0600824C RID: 33356 RVA: 0x0013A67B File Offset: 0x0013887B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSellPreviewRequest other)
		{
			return other != null && (other == this || (this.incrIds_.Equals(other.incrIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600824D RID: 33357 RVA: 0x0013A6B0 File Offset: 0x001388B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.incrIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600824E RID: 33358 RVA: 0x0013A6E4 File Offset: 0x001388E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600824F RID: 33359 RVA: 0x0013A6F1 File Offset: 0x001388F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008250 RID: 33360 RVA: 0x0013A6FA File Offset: 0x001388FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.incrIds_.WriteTo(ref output, FishingSellPreviewRequest._repeated_incrIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008251 RID: 33361 RVA: 0x0013A724 File Offset: 0x00138924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.incrIds_.CalculateSize(FishingSellPreviewRequest._repeated_incrIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008252 RID: 33362 RVA: 0x0013A75D File Offset: 0x0013895D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSellPreviewRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.incrIds_.Add(other.incrIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008253 RID: 33363 RVA: 0x0013A78B File Offset: 0x0013898B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008254 RID: 33364 RVA: 0x0013A794 File Offset: 0x00138994
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.incrIds_.AddEntriesFrom(ref input, FishingSellPreviewRequest._repeated_incrIds_codec);
				}
			}
		}

		// Token: 0x04004135 RID: 16693
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004136 RID: 16694
		public const int IncrIdsFieldNumber = 14;

		// Token: 0x04004137 RID: 16695
		private static readonly FieldCodec<int> _repeated_incrIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04004138 RID: 16696
		private readonly RepeatedField<int> incrIds_ = new RepeatedField<int>();
	}
}
