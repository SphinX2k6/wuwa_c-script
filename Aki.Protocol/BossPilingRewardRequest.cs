using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001CB RID: 459
	[NetMessage(EMessageId.BossPilingRewardRequest)]
	public sealed class BossPilingRewardRequest : IMessage<BossPilingRewardRequest>, IMessage, IEquatable<BossPilingRewardRequest>, IDeepCloneable<BossPilingRewardRequest>, IBufferMessage
	{
		// Token: 0x060034B6 RID: 13494 RVA: 0x00085305 File Offset: 0x00083505
		[NullableContext(1)]
		public static BossPilingRewardRequest Create()
		{
			return new BossPilingRewardRequest();
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x060034B7 RID: 13495 RVA: 0x0008530C File Offset: 0x0008350C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x060034B8 RID: 13496 RVA: 0x0008530F File Offset: 0x0008350F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingRewardRequest.Descriptor;
			}
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x00085316 File Offset: 0x00083516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingRewardRequest()
		{
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x00085329 File Offset: 0x00083529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingRewardRequest(BossPilingRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.bossPilingTaskIds_ = other.bossPilingTaskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x0008535F File Offset: 0x0008355F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingRewardRequest Clone()
		{
			return new BossPilingRewardRequest(this);
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x060034BC RID: 13500 RVA: 0x00085367 File Offset: 0x00083567
		// (set) Token: 0x060034BD RID: 13501 RVA: 0x0008536F File Offset: 0x0008356F
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

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x060034BE RID: 13502 RVA: 0x00085378 File Offset: 0x00083578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BossPilingTaskIds
		{
			get
			{
				return this.bossPilingTaskIds_;
			}
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x00085380 File Offset: 0x00083580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingRewardRequest);
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x00085390 File Offset: 0x00083590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.bossPilingTaskIds_.Equals(other.bossPilingTaskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x000853E0 File Offset: 0x000835E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.bossPilingTaskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x0008542D File Offset: 0x0008362D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x0008543A File Offset: 0x0008363A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x00085444 File Offset: 0x00083644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bossPilingTaskIds_.WriteTo(ref output, BossPilingRewardRequest._repeated_bossPilingTaskIds_codec);
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

		// Token: 0x060034C5 RID: 13509 RVA: 0x00085494 File Offset: 0x00083694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.bossPilingTaskIds_.CalculateSize(BossPilingRewardRequest._repeated_bossPilingTaskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x000854E8 File Offset: 0x000836E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.bossPilingTaskIds_.Add(other.bossPilingTaskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x00085535 File Offset: 0x00083735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x00085540 File Offset: 0x00083740
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
				if (num != 104U && num != 106U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.bossPilingTaskIds_.AddEntriesFrom(ref input, BossPilingRewardRequest._repeated_bossPilingTaskIds_codec);
				}
			}
		}

		// Token: 0x04002A70 RID: 10864
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A71 RID: 10865
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x04002A72 RID: 10866
		private int activityId_;

		// Token: 0x04002A73 RID: 10867
		public const int BossPilingTaskIdsFieldNumber = 13;

		// Token: 0x04002A74 RID: 10868
		private static readonly FieldCodec<int> _repeated_bossPilingTaskIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04002A75 RID: 10869
		private readonly RepeatedField<int> bossPilingTaskIds_ = new RepeatedField<int>();
	}
}
