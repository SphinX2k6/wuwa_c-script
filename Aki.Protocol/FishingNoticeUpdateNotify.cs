using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000558 RID: 1368
	[NetMessage(EMessageId.FishingNoticeUpdateNotify)]
	public sealed class FishingNoticeUpdateNotify : IMessage<FishingNoticeUpdateNotify>, IMessage, IEquatable<FishingNoticeUpdateNotify>, IDeepCloneable<FishingNoticeUpdateNotify>, IBufferMessage
	{
		// Token: 0x06007FFA RID: 32762 RVA: 0x00135E6D File Offset: 0x0013406D
		[NullableContext(1)]
		public static FishingNoticeUpdateNotify Create()
		{
			return new FishingNoticeUpdateNotify();
		}

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x06007FFB RID: 32763 RVA: 0x00135E74 File Offset: 0x00134074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x06007FFC RID: 32764 RVA: 0x00135E77 File Offset: 0x00134077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingNoticeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06007FFD RID: 32765 RVA: 0x00135E7E File Offset: 0x0013407E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingNoticeUpdateNotify()
		{
		}

		// Token: 0x06007FFE RID: 32766 RVA: 0x00135E9C File Offset: 0x0013409C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingNoticeUpdateNotify(FishingNoticeUpdateNotify other) : this()
		{
			this.noticeIds_ = other.noticeIds_.Clone();
			this.completeNoticeIds_ = other.completeNoticeIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FFF RID: 32767 RVA: 0x00135ED7 File Offset: 0x001340D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingNoticeUpdateNotify Clone()
		{
			return new FishingNoticeUpdateNotify(this);
		}

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x06008000 RID: 32768 RVA: 0x00135EDF File Offset: 0x001340DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NoticeIds
		{
			get
			{
				return this.noticeIds_;
			}
		}

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x06008001 RID: 32769 RVA: 0x00135EE7 File Offset: 0x001340E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CompleteNoticeIds
		{
			get
			{
				return this.completeNoticeIds_;
			}
		}

		// Token: 0x06008002 RID: 32770 RVA: 0x00135EEF File Offset: 0x001340EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingNoticeUpdateNotify);
		}

		// Token: 0x06008003 RID: 32771 RVA: 0x00135F00 File Offset: 0x00134100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingNoticeUpdateNotify other)
		{
			return other != null && (other == this || (this.noticeIds_.Equals(other.noticeIds_) && this.completeNoticeIds_.Equals(other.completeNoticeIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008004 RID: 32772 RVA: 0x00135F54 File Offset: 0x00134154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.noticeIds_.GetHashCode();
			num ^= this.completeNoticeIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008005 RID: 32773 RVA: 0x00135F96 File Offset: 0x00134196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008006 RID: 32774 RVA: 0x00135FA3 File Offset: 0x001341A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008007 RID: 32775 RVA: 0x00135FAC File Offset: 0x001341AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.completeNoticeIds_.WriteTo(ref output, FishingNoticeUpdateNotify._repeated_completeNoticeIds_codec);
			this.noticeIds_.WriteTo(ref output, FishingNoticeUpdateNotify._repeated_noticeIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008008 RID: 32776 RVA: 0x00135FE4 File Offset: 0x001341E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.noticeIds_.CalculateSize(FishingNoticeUpdateNotify._repeated_noticeIds_codec);
			num += this.completeNoticeIds_.CalculateSize(FishingNoticeUpdateNotify._repeated_completeNoticeIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008009 RID: 32777 RVA: 0x00136030 File Offset: 0x00134230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingNoticeUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.noticeIds_.Add(other.noticeIds_);
			this.completeNoticeIds_.Add(other.completeNoticeIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600800A RID: 32778 RVA: 0x0013606F File Offset: 0x0013426F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600800B RID: 32779 RVA: 0x00136078 File Offset: 0x00134278
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
				if (num <= 58U)
				{
					if (num == 56U || num == 58U)
					{
						this.completeNoticeIds_.AddEntriesFrom(ref input, FishingNoticeUpdateNotify._repeated_completeNoticeIds_codec);
						continue;
					}
				}
				else if (num == 72U || num == 74U)
				{
					this.noticeIds_.AddEntriesFrom(ref input, FishingNoticeUpdateNotify._repeated_noticeIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040040F6 RID: 16630
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040F7 RID: 16631
		public const int NoticeIdsFieldNumber = 9;

		// Token: 0x040040F8 RID: 16632
		private static readonly FieldCodec<int> _repeated_noticeIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040040F9 RID: 16633
		private readonly RepeatedField<int> noticeIds_ = new RepeatedField<int>();

		// Token: 0x040040FA RID: 16634
		public const int CompleteNoticeIdsFieldNumber = 7;

		// Token: 0x040040FB RID: 16635
		private static readonly FieldCodec<int> _repeated_completeNoticeIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x040040FC RID: 16636
		private readonly RepeatedField<int> completeNoticeIds_ = new RepeatedField<int>();
	}
}
