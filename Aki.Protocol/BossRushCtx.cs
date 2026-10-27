using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D6 RID: 470
	public sealed class BossRushCtx : IMessage<BossRushCtx>, IMessage, IEquatable<BossRushCtx>, IDeepCloneable<BossRushCtx>, IBufferMessage
	{
		// Token: 0x06003546 RID: 13638 RVA: 0x00085E7D File Offset: 0x0008407D
		[NullableContext(1)]
		public static BossRushCtx Create()
		{
			return new BossRushCtx();
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06003547 RID: 13639 RVA: 0x00085E84 File Offset: 0x00084084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06003548 RID: 13640 RVA: 0x00085E87 File Offset: 0x00084087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushCtx.Descriptor;
			}
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x00085E8E File Offset: 0x0008408E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushCtx()
		{
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x00085EAC File Offset: 0x000840AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushCtx(BossRushCtx other) : this()
		{
			this.id_ = other.id_;
			this.activityId_ = other.activityId_;
			this.buffSelections_ = other.buffSelections_.Clone();
			this.scoreBuff_ = other.scoreBuff_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x00085F0A File Offset: 0x0008410A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushCtx Clone()
		{
			return new BossRushCtx(this);
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x0600354C RID: 13644 RVA: 0x00085F12 File Offset: 0x00084112
		// (set) Token: 0x0600354D RID: 13645 RVA: 0x00085F1A File Offset: 0x0008411A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x0600354E RID: 13646 RVA: 0x00085F23 File Offset: 0x00084123
		// (set) Token: 0x0600354F RID: 13647 RVA: 0x00085F2B File Offset: 0x0008412B
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

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06003550 RID: 13648 RVA: 0x00085F34 File Offset: 0x00084134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BuffSelection> BuffSelections
		{
			get
			{
				return this.buffSelections_;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06003551 RID: 13649 RVA: 0x00085F3C File Offset: 0x0008413C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreBuff
		{
			get
			{
				return this.scoreBuff_;
			}
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x00085F44 File Offset: 0x00084144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushCtx);
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x00085F54 File Offset: 0x00084154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushCtx other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ActivityId == other.ActivityId && this.buffSelections_.Equals(other.buffSelections_) && this.scoreBuff_.Equals(other.scoreBuff_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x00085FC8 File Offset: 0x000841C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.buffSelections_.GetHashCode();
			num ^= this.scoreBuff_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x0008603C File Offset: 0x0008423C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x00086049 File Offset: 0x00084249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x00086054 File Offset: 0x00084254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			this.buffSelections_.WriteTo(ref output, BossRushCtx._repeated_buffSelections_codec);
			this.scoreBuff_.WriteTo(ref output, BossRushCtx._repeated_scoreBuff_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x000860D0 File Offset: 0x000842D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.buffSelections_.CalculateSize(BossRushCtx._repeated_buffSelections_codec);
			num += this.scoreBuff_.CalculateSize(BossRushCtx._repeated_scoreBuff_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003559 RID: 13657 RVA: 0x0008614C File Offset: 0x0008434C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.buffSelections_.Add(other.buffSelections_);
			this.scoreBuff_.Add(other.scoreBuff_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x000861BE File Offset: 0x000843BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x000861C8 File Offset: 0x000843C8
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.buffSelections_.AddEntriesFrom(ref input, BossRushCtx._repeated_buffSelections_codec);
						continue;
					}
					if (num == 56U || num == 58U)
					{
						this.scoreBuff_.AddEntriesFrom(ref input, BossRushCtx._repeated_scoreBuff_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002A3C RID: 10812
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A3D RID: 10813
		public const int IdFieldNumber = 1;

		// Token: 0x04002A3E RID: 10814
		private int id_;

		// Token: 0x04002A3F RID: 10815
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04002A40 RID: 10816
		private int activityId_;

		// Token: 0x04002A41 RID: 10817
		public const int BuffSelectionsFieldNumber = 3;

		// Token: 0x04002A42 RID: 10818
		private static readonly FieldCodec<BuffSelection> _repeated_buffSelections_codec = FieldCodec.ForMessage<BuffSelection>(26U, BuffSelection.Parser);

		// Token: 0x04002A43 RID: 10819
		private readonly RepeatedField<BuffSelection> buffSelections_ = new RepeatedField<BuffSelection>();

		// Token: 0x04002A44 RID: 10820
		public const int ScoreBuffFieldNumber = 7;

		// Token: 0x04002A45 RID: 10821
		private static readonly FieldCodec<int> _repeated_scoreBuff_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04002A46 RID: 10822
		private readonly RepeatedField<int> scoreBuff_ = new RepeatedField<int>();
	}
}
