using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F93 RID: 3987
	[NetMessage(EMessageId.RoguelikeChooseDataNotify)]
	public sealed class RoguelikeChooseDataNotify : IMessage<RoguelikeChooseDataNotify>, IMessage, IEquatable<RoguelikeChooseDataNotify>, IDeepCloneable<RoguelikeChooseDataNotify>, IBufferMessage
	{
		// Token: 0x06015530 RID: 87344 RVA: 0x003182C3 File Offset: 0x003164C3
		[NullableContext(1)]
		public static RoguelikeChooseDataNotify Create()
		{
			return new RoguelikeChooseDataNotify();
		}

		// Token: 0x1700470F RID: 18191
		// (get) Token: 0x06015531 RID: 87345 RVA: 0x003182CA File Offset: 0x003164CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004710 RID: 18192
		// (get) Token: 0x06015532 RID: 87346 RVA: 0x003182CD File Offset: 0x003164CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeChooseDataNotify.Descriptor;
			}
		}

		// Token: 0x06015533 RID: 87347 RVA: 0x003182D4 File Offset: 0x003164D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataNotify()
		{
		}

		// Token: 0x06015534 RID: 87348 RVA: 0x003182E7 File Offset: 0x003164E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataNotify(RoguelikeChooseDataNotify other) : this()
		{
			this.roguelikeChooseDataList_ = other.roguelikeChooseDataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015535 RID: 87349 RVA: 0x00318311 File Offset: 0x00316511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataNotify Clone()
		{
			return new RoguelikeChooseDataNotify(this);
		}

		// Token: 0x17004711 RID: 18193
		// (get) Token: 0x06015536 RID: 87350 RVA: 0x00318319 File Offset: 0x00316519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoguelikeChooseData> RoguelikeChooseDataList
		{
			get
			{
				return this.roguelikeChooseDataList_;
			}
		}

		// Token: 0x06015537 RID: 87351 RVA: 0x00318321 File Offset: 0x00316521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeChooseDataNotify);
		}

		// Token: 0x06015538 RID: 87352 RVA: 0x0031832F File Offset: 0x0031652F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeChooseDataNotify other)
		{
			return other != null && (other == this || (this.roguelikeChooseDataList_.Equals(other.roguelikeChooseDataList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015539 RID: 87353 RVA: 0x00318364 File Offset: 0x00316564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roguelikeChooseDataList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601553A RID: 87354 RVA: 0x00318398 File Offset: 0x00316598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601553B RID: 87355 RVA: 0x003183A5 File Offset: 0x003165A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601553C RID: 87356 RVA: 0x003183AE File Offset: 0x003165AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roguelikeChooseDataList_.WriteTo(ref output, RoguelikeChooseDataNotify._repeated_roguelikeChooseDataList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601553D RID: 87357 RVA: 0x003183D8 File Offset: 0x003165D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roguelikeChooseDataList_.CalculateSize(RoguelikeChooseDataNotify._repeated_roguelikeChooseDataList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601553E RID: 87358 RVA: 0x00318411 File Offset: 0x00316611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeChooseDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roguelikeChooseDataList_.Add(other.roguelikeChooseDataList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601553F RID: 87359 RVA: 0x0031843F File Offset: 0x0031663F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015540 RID: 87360 RVA: 0x00318448 File Offset: 0x00316648
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roguelikeChooseDataList_.AddEntriesFrom(ref input, RoguelikeChooseDataNotify._repeated_roguelikeChooseDataList_codec);
				}
			}
		}

		// Token: 0x04008050 RID: 32848
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008051 RID: 32849
		public const int RoguelikeChooseDataListFieldNumber = 3;

		// Token: 0x04008052 RID: 32850
		private static readonly FieldCodec<RoguelikeChooseData> _repeated_roguelikeChooseDataList_codec = FieldCodec.ForMessage<RoguelikeChooseData>(26U, RoguelikeChooseData.Parser);

		// Token: 0x04008053 RID: 32851
		private readonly RepeatedField<RoguelikeChooseData> roguelikeChooseDataList_ = new RepeatedField<RoguelikeChooseData>();
	}
}
