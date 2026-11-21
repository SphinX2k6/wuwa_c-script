using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E2 RID: 482
	[NetMessage(EMessageId.BossRushSelectBuffNotify)]
	public sealed class BossRushSelectBuffNotify : IMessage<BossRushSelectBuffNotify>, IMessage, IEquatable<BossRushSelectBuffNotify>, IDeepCloneable<BossRushSelectBuffNotify>, IBufferMessage
	{
		// Token: 0x0600368A RID: 13962 RVA: 0x00089403 File Offset: 0x00087603
		[NullableContext(1)]
		public static BossRushSelectBuffNotify Create()
		{
			return new BossRushSelectBuffNotify();
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x0600368B RID: 13963 RVA: 0x0008940A File Offset: 0x0008760A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x0600368C RID: 13964 RVA: 0x0008940D File Offset: 0x0008760D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushSelectBuffNotify.Descriptor;
			}
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x00089414 File Offset: 0x00087614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushSelectBuffNotify()
		{
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x00089428 File Offset: 0x00087628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushSelectBuffNotify(BossRushSelectBuffNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.instId_ = other.instId_;
			this.selectBuffIndices_ = other.selectBuffIndices_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x00089475 File Offset: 0x00087675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushSelectBuffNotify Clone()
		{
			return new BossRushSelectBuffNotify(this);
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06003690 RID: 13968 RVA: 0x0008947D File Offset: 0x0008767D
		// (set) Token: 0x06003691 RID: 13969 RVA: 0x00089485 File Offset: 0x00087685
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

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06003692 RID: 13970 RVA: 0x0008948E File Offset: 0x0008768E
		// (set) Token: 0x06003693 RID: 13971 RVA: 0x00089496 File Offset: 0x00087696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06003694 RID: 13972 RVA: 0x0008949F File Offset: 0x0008769F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectBuffIndices
		{
			get
			{
				return this.selectBuffIndices_;
			}
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x000894A7 File Offset: 0x000876A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushSelectBuffNotify);
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x000894B8 File Offset: 0x000876B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushSelectBuffNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.InstId == other.InstId && this.selectBuffIndices_.Equals(other.selectBuffIndices_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x00089518 File Offset: 0x00087718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.selectBuffIndices_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x0008957E File Offset: 0x0008777E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x0008958B File Offset: 0x0008778B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x00089594 File Offset: 0x00087794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.selectBuffIndices_.WriteTo(ref output, BossRushSelectBuffNotify._repeated_selectBuffIndices_codec);
			if (this.InstId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.InstId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x00089600 File Offset: 0x00087800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.selectBuffIndices_.CalculateSize(BossRushSelectBuffNotify._repeated_selectBuffIndices_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x0008966C File Offset: 0x0008786C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushSelectBuffNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.selectBuffIndices_.Add(other.selectBuffIndices_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x000896CD File Offset: 0x000878CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x000896D8 File Offset: 0x000878D8
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
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.selectBuffIndices_.AddEntriesFrom(ref input, BossRushSelectBuffNotify._repeated_selectBuffIndices_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002B04 RID: 11012
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B05 RID: 11013
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x04002B06 RID: 11014
		private int activityId_;

		// Token: 0x04002B07 RID: 11015
		public const int InstIdFieldNumber = 10;

		// Token: 0x04002B08 RID: 11016
		private int instId_;

		// Token: 0x04002B09 RID: 11017
		public const int SelectBuffIndicesFieldNumber = 3;

		// Token: 0x04002B0A RID: 11018
		private static readonly FieldCodec<int> _repeated_selectBuffIndices_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04002B0B RID: 11019
		private readonly RepeatedField<int> selectBuffIndices_ = new RepeatedField<int>();
	}
}
