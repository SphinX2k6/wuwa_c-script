using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC9 RID: 4041
	[NetMessage(EMessageId.RogueResEndingUpdateNotify)]
	public sealed class RogueResEndingUpdateNotify : IMessage<RogueResEndingUpdateNotify>, IMessage, IEquatable<RogueResEndingUpdateNotify>, IDeepCloneable<RogueResEndingUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015A05 RID: 88581 RVA: 0x003240D1 File Offset: 0x003222D1
		[NullableContext(1)]
		public static RogueResEndingUpdateNotify Create()
		{
			return new RogueResEndingUpdateNotify();
		}

		// Token: 0x17004823 RID: 18467
		// (get) Token: 0x06015A06 RID: 88582 RVA: 0x003240D8 File Offset: 0x003222D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004824 RID: 18468
		// (get) Token: 0x06015A07 RID: 88583 RVA: 0x003240DB File Offset: 0x003222DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResEndingUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015A08 RID: 88584 RVA: 0x003240E2 File Offset: 0x003222E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEndingUpdateNotify()
		{
		}

		// Token: 0x06015A09 RID: 88585 RVA: 0x00324100 File Offset: 0x00322300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEndingUpdateNotify(RogueResEndingUpdateNotify other) : this()
		{
			this.endings_ = other.endings_.Clone();
			this.endingRewardIds_ = other.endingRewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015A0A RID: 88586 RVA: 0x0032413B File Offset: 0x0032233B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEndingUpdateNotify Clone()
		{
			return new RogueResEndingUpdateNotify(this);
		}

		// Token: 0x17004825 RID: 18469
		// (get) Token: 0x06015A0B RID: 88587 RVA: 0x00324143 File Offset: 0x00322343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Endings
		{
			get
			{
				return this.endings_;
			}
		}

		// Token: 0x17004826 RID: 18470
		// (get) Token: 0x06015A0C RID: 88588 RVA: 0x0032414B File Offset: 0x0032234B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> EndingRewardIds
		{
			get
			{
				return this.endingRewardIds_;
			}
		}

		// Token: 0x06015A0D RID: 88589 RVA: 0x00324153 File Offset: 0x00322353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResEndingUpdateNotify);
		}

		// Token: 0x06015A0E RID: 88590 RVA: 0x00324164 File Offset: 0x00322364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResEndingUpdateNotify other)
		{
			return other != null && (other == this || (this.endings_.Equals(other.endings_) && this.endingRewardIds_.Equals(other.endingRewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015A0F RID: 88591 RVA: 0x003241B8 File Offset: 0x003223B8
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

		// Token: 0x06015A10 RID: 88592 RVA: 0x003241FA File Offset: 0x003223FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015A11 RID: 88593 RVA: 0x00324207 File Offset: 0x00322407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015A12 RID: 88594 RVA: 0x00324210 File Offset: 0x00322410
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

		// Token: 0x06015A13 RID: 88595 RVA: 0x00324248 File Offset: 0x00322448
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

		// Token: 0x06015A14 RID: 88596 RVA: 0x00324294 File Offset: 0x00322494
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

		// Token: 0x06015A15 RID: 88597 RVA: 0x003242D3 File Offset: 0x003224D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015A16 RID: 88598 RVA: 0x003242DC File Offset: 0x003224DC
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
				if (num != 32U && num != 34U)
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

		// Token: 0x04008247 RID: 33351
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008248 RID: 33352
		public const int EndingsFieldNumber = 4;

		// Token: 0x04008249 RID: 33353
		private static readonly FieldCodec<int> _repeated_endings_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400824A RID: 33354
		private readonly RepeatedField<int> endings_ = new RepeatedField<int>();

		// Token: 0x0400824B RID: 33355
		public const int EndingRewardIdsFieldNumber = 13;

		// Token: 0x0400824C RID: 33356
		private static readonly FieldCodec<ActivityTask> _repeated_endingRewardIds_codec = FieldCodec.ForMessage<ActivityTask>(106U, ActivityTask.Parser);

		// Token: 0x0400824D RID: 33357
		private readonly RepeatedField<ActivityTask> endingRewardIds_ = new RepeatedField<ActivityTask>();
	}
}
