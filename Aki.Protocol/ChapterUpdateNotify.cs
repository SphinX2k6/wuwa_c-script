using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000274 RID: 628
	[NetMessage(EMessageId.ChapterUpdateNotify)]
	public sealed class ChapterUpdateNotify : IMessage<ChapterUpdateNotify>, IMessage, IEquatable<ChapterUpdateNotify>, IDeepCloneable<ChapterUpdateNotify>, IBufferMessage
	{
		// Token: 0x06004254 RID: 16980 RVA: 0x000A3249 File Offset: 0x000A1449
		[NullableContext(1)]
		public static ChapterUpdateNotify Create()
		{
			return new ChapterUpdateNotify();
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06004255 RID: 16981 RVA: 0x000A3250 File Offset: 0x000A1450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06004256 RID: 16982 RVA: 0x000A3253 File Offset: 0x000A1453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChapterUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x000A325A File Offset: 0x000A145A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterUpdateNotify()
		{
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x000A326D File Offset: 0x000A146D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterUpdateNotify(ChapterUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.chapterDatas_ = other.chapterDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x000A32A3 File Offset: 0x000A14A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterUpdateNotify Clone()
		{
			return new ChapterUpdateNotify(this);
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x0600425A RID: 16986 RVA: 0x000A32AB File Offset: 0x000A14AB
		// (set) Token: 0x0600425B RID: 16987 RVA: 0x000A32B3 File Offset: 0x000A14B3
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

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x0600425C RID: 16988 RVA: 0x000A32BC File Offset: 0x000A14BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CiacconaChapterPbData> ChapterDatas
		{
			get
			{
				return this.chapterDatas_;
			}
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x000A32C4 File Offset: 0x000A14C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChapterUpdateNotify);
		}

		// Token: 0x0600425E RID: 16990 RVA: 0x000A32D4 File Offset: 0x000A14D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChapterUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.chapterDatas_.Equals(other.chapterDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x000A3324 File Offset: 0x000A1524
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

		// Token: 0x06004260 RID: 16992 RVA: 0x000A3371 File Offset: 0x000A1571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x000A337E File Offset: 0x000A157E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x000A3388 File Offset: 0x000A1588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			this.chapterDatas_.WriteTo(ref output, ChapterUpdateNotify._repeated_chapterDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x000A33D8 File Offset: 0x000A15D8
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

		// Token: 0x06004264 RID: 16996 RVA: 0x000A342C File Offset: 0x000A162C
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

		// Token: 0x06004265 RID: 16997 RVA: 0x000A3479 File Offset: 0x000A1679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x000A3484 File Offset: 0x000A1684
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
				if (num != 24U)
				{
					if (num != 50U)
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

		// Token: 0x04002E51 RID: 11857
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E52 RID: 11858
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04002E53 RID: 11859
		private int activityId_;

		// Token: 0x04002E54 RID: 11860
		public const int ChapterDatasFieldNumber = 6;

		// Token: 0x04002E55 RID: 11861
		private static readonly FieldCodec<CiacconaChapterPbData> _repeated_chapterDatas_codec = FieldCodec.ForMessage<CiacconaChapterPbData>(50U, CiacconaChapterPbData.Parser);

		// Token: 0x04002E56 RID: 11862
		private readonly RepeatedField<CiacconaChapterPbData> chapterDatas_ = new RepeatedField<CiacconaChapterPbData>();
	}
}
