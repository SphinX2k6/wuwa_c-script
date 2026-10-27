using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200026F RID: 623
	[NetMessage(EMessageId.ChapterUpdateNotify)]
	public sealed class ChapterUpdateNotify : IMessage<ChapterUpdateNotify>, IMessage, IEquatable<ChapterUpdateNotify>, IDeepCloneable<ChapterUpdateNotify>, IBufferMessage
	{
		// Token: 0x060041AD RID: 16813 RVA: 0x000A157D File Offset: 0x0009F77D
		[NullableContext(1)]
		public static ChapterUpdateNotify Create()
		{
			return new ChapterUpdateNotify();
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x060041AE RID: 16814 RVA: 0x000A1584 File Offset: 0x0009F784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x060041AF RID: 16815 RVA: 0x000A1587 File Offset: 0x0009F787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChapterUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060041B0 RID: 16816 RVA: 0x000A158E File Offset: 0x0009F78E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterUpdateNotify()
		{
		}

		// Token: 0x060041B1 RID: 16817 RVA: 0x000A15A1 File Offset: 0x0009F7A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterUpdateNotify(ChapterUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.chapterDatas_ = other.chapterDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060041B2 RID: 16818 RVA: 0x000A15D7 File Offset: 0x0009F7D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterUpdateNotify Clone()
		{
			return new ChapterUpdateNotify(this);
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x060041B3 RID: 16819 RVA: 0x000A15DF File Offset: 0x0009F7DF
		// (set) Token: 0x060041B4 RID: 16820 RVA: 0x000A15E7 File Offset: 0x0009F7E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x060041B5 RID: 16821 RVA: 0x000A15F0 File Offset: 0x0009F7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CiacconaChapterPbData> ChapterDatas
		{
			get
			{
				return this.chapterDatas_;
			}
		}

		// Token: 0x060041B6 RID: 16822 RVA: 0x000A15F8 File Offset: 0x0009F7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChapterUpdateNotify);
		}

		// Token: 0x060041B7 RID: 16823 RVA: 0x000A1608 File Offset: 0x0009F808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChapterUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.chapterDatas_.Equals(other.chapterDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x000A1658 File Offset: 0x0009F858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.chapterDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x000A16A5 File Offset: 0x0009F8A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060041BA RID: 16826 RVA: 0x000A16B2 File Offset: 0x0009F8B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060041BB RID: 16827 RVA: 0x000A16BC File Offset: 0x0009F8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			this.chapterDatas_.WriteTo(ref output, ChapterUpdateNotify._repeated_chapterDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x000A170C File Offset: 0x0009F90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.chapterDatas_.CalculateSize(ChapterUpdateNotify._repeated_chapterDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x000A1760 File Offset: 0x0009F960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChapterUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.chapterDatas_.Add(other.chapterDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060041BE RID: 16830 RVA: 0x000A17AD File Offset: 0x0009F9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060041BF RID: 16831 RVA: 0x000A17B8 File Offset: 0x0009F9B8
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
				if (num != 88U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.chapterDatas_.AddEntriesFrom(ref input, ChapterUpdateNotify._repeated_chapterDatas_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002DCD RID: 11725
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DCE RID: 11726
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04002DCF RID: 11727
		private int activityId_;

		// Token: 0x04002DD0 RID: 11728
		public const int ChapterDatasFieldNumber = 14;

		// Token: 0x04002DD1 RID: 11729
		private static readonly FieldCodec<CiacconaChapterPbData> _repeated_chapterDatas_codec = FieldCodec.ForMessage<CiacconaChapterPbData>(114U, CiacconaChapterPbData.Parser);

		// Token: 0x04002DD2 RID: 11730
		private readonly RepeatedField<CiacconaChapterPbData> chapterDatas_ = new RepeatedField<CiacconaChapterPbData>();
	}
}
