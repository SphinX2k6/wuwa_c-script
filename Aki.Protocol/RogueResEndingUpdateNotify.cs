using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD9 RID: 4057
	[NetMessage(EMessageId.RogueResEndingUpdateNotify)]
	public sealed class RogueResEndingUpdateNotify : IMessage<RogueResEndingUpdateNotify>, IMessage, IEquatable<RogueResEndingUpdateNotify>, IDeepCloneable<RogueResEndingUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015AEA RID: 88810 RVA: 0x00325785 File Offset: 0x00323985
		[NullableContext(1)]
		public static RogueResEndingUpdateNotify Create()
		{
			return new RogueResEndingUpdateNotify();
		}

		// Token: 0x1700484D RID: 18509
		// (get) Token: 0x06015AEB RID: 88811 RVA: 0x0032578C File Offset: 0x0032398C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700484E RID: 18510
		// (get) Token: 0x06015AEC RID: 88812 RVA: 0x0032578F File Offset: 0x0032398F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResEndingUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015AED RID: 88813 RVA: 0x00325796 File Offset: 0x00323996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEndingUpdateNotify()
		{
		}

		// Token: 0x06015AEE RID: 88814 RVA: 0x003257B4 File Offset: 0x003239B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEndingUpdateNotify(RogueResEndingUpdateNotify other) : this()
		{
			this.endings_ = other.endings_.Clone();
			this.endingRewardIds_ = other.endingRewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015AEF RID: 88815 RVA: 0x003257EF File Offset: 0x003239EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEndingUpdateNotify Clone()
		{
			return new RogueResEndingUpdateNotify(this);
		}

		// Token: 0x1700484F RID: 18511
		// (get) Token: 0x06015AF0 RID: 88816 RVA: 0x003257F7 File Offset: 0x003239F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Endings
		{
			get
			{
				return this.endings_;
			}
		}

		// Token: 0x17004850 RID: 18512
		// (get) Token: 0x06015AF1 RID: 88817 RVA: 0x003257FF File Offset: 0x003239FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> EndingRewardIds
		{
			get
			{
				return this.endingRewardIds_;
			}
		}

		// Token: 0x06015AF2 RID: 88818 RVA: 0x00325807 File Offset: 0x00323A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResEndingUpdateNotify);
		}

		// Token: 0x06015AF3 RID: 88819 RVA: 0x00325818 File Offset: 0x00323A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResEndingUpdateNotify other)
		{
			return other != null && (other == this || (this.endings_.Equals(other.endings_) && this.endingRewardIds_.Equals(other.endingRewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015AF4 RID: 88820 RVA: 0x0032586C File Offset: 0x00323A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.endings_.GetHashCode();
			num ^= this.endingRewardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015AF5 RID: 88821 RVA: 0x003258AE File Offset: 0x00323AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015AF6 RID: 88822 RVA: 0x003258BB File Offset: 0x00323ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015AF7 RID: 88823 RVA: 0x003258C4 File Offset: 0x00323AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.endings_.WriteTo(ref output, RogueResEndingUpdateNotify._repeated_endings_codec);
			this.endingRewardIds_.WriteTo(ref output, RogueResEndingUpdateNotify._repeated_endingRewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015AF8 RID: 88824 RVA: 0x003258FC File Offset: 0x00323AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.endings_.CalculateSize(RogueResEndingUpdateNotify._repeated_endings_codec);
			num += this.endingRewardIds_.CalculateSize(RogueResEndingUpdateNotify._repeated_endingRewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015AF9 RID: 88825 RVA: 0x00325948 File Offset: 0x00323B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResEndingUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.endings_.Add(other.endings_);
			this.endingRewardIds_.Add(other.endingRewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015AFA RID: 88826 RVA: 0x00325987 File Offset: 0x00323B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015AFB RID: 88827 RVA: 0x00325990 File Offset: 0x00323B90
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
				if (num != 80U && num != 82U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.endingRewardIds_.AddEntriesFrom(ref input, RogueResEndingUpdateNotify._repeated_endingRewardIds_codec);
					}
				}
				else
				{
					this.endings_.AddEntriesFrom(ref input, RogueResEndingUpdateNotify._repeated_endings_codec);
				}
			}
		}

		// Token: 0x0400821D RID: 33309
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400821E RID: 33310
		public const int EndingsFieldNumber = 10;

		// Token: 0x0400821F RID: 33311
		private static readonly FieldCodec<int> _repeated_endings_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04008220 RID: 33312
		private readonly RepeatedField<int> endings_ = new RepeatedField<int>();

		// Token: 0x04008221 RID: 33313
		public const int EndingRewardIdsFieldNumber = 13;

		// Token: 0x04008222 RID: 33314
		private static readonly FieldCodec<ActivityTask> _repeated_endingRewardIds_codec = FieldCodec.ForMessage<ActivityTask>(106U, ActivityTask.Parser);

		// Token: 0x04008223 RID: 33315
		private readonly RepeatedField<ActivityTask> endingRewardIds_ = new RepeatedField<ActivityTask>();
	}
}
