using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001266 RID: 4710
	public sealed class SimpleTrackReportMsg : IMessage<SimpleTrackReportMsg>, IMessage, IEquatable<SimpleTrackReportMsg>, IDeepCloneable<SimpleTrackReportMsg>, IBufferMessage
	{
		// Token: 0x06019255 RID: 102997 RVA: 0x003AAFED File Offset: 0x003A91ED
		[NullableContext(1)]
		public static SimpleTrackReportMsg Create()
		{
			return new SimpleTrackReportMsg();
		}

		// Token: 0x17005501 RID: 21761
		// (get) Token: 0x06019256 RID: 102998 RVA: 0x003AAFF4 File Offset: 0x003A91F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SimpleTrackReportMsg> Parser
		{
			get
			{
				return SimpleTrackReportMsg._parser;
			}
		}

		// Token: 0x17005502 RID: 21762
		// (get) Token: 0x06019257 RID: 102999 RVA: 0x003AAFFB File Offset: 0x003A91FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005503 RID: 21763
		// (get) Token: 0x06019258 RID: 103000 RVA: 0x003AAFFE File Offset: 0x003A91FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleTrackReportMsg.Descriptor;
			}
		}

		// Token: 0x06019259 RID: 103001 RVA: 0x003AB005 File Offset: 0x003A9205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleTrackReportMsg()
		{
		}

		// Token: 0x0601925A RID: 103002 RVA: 0x003AB00D File Offset: 0x003A920D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleTrackReportMsg(SimpleTrackReportMsg other) : this()
		{
			this.instId_ = other.instId_;
			this.levelPlayId_ = other.levelPlayId_;
			this.gainTreasureCount_ = other.gainTreasureCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601925B RID: 103003 RVA: 0x003AB04A File Offset: 0x003A924A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleTrackReportMsg Clone()
		{
			return new SimpleTrackReportMsg(this);
		}

		// Token: 0x17005504 RID: 21764
		// (get) Token: 0x0601925C RID: 103004 RVA: 0x003AB052 File Offset: 0x003A9252
		// (set) Token: 0x0601925D RID: 103005 RVA: 0x003AB05A File Offset: 0x003A925A
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

		// Token: 0x17005505 RID: 21765
		// (get) Token: 0x0601925E RID: 103006 RVA: 0x003AB063 File Offset: 0x003A9263
		// (set) Token: 0x0601925F RID: 103007 RVA: 0x003AB06B File Offset: 0x003A926B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x17005506 RID: 21766
		// (get) Token: 0x06019260 RID: 103008 RVA: 0x003AB074 File Offset: 0x003A9274
		// (set) Token: 0x06019261 RID: 103009 RVA: 0x003AB07C File Offset: 0x003A927C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GainTreasureCount
		{
			get
			{
				return this.gainTreasureCount_;
			}
			set
			{
				this.gainTreasureCount_ = value;
			}
		}

		// Token: 0x06019262 RID: 103010 RVA: 0x003AB085 File Offset: 0x003A9285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleTrackReportMsg);
		}

		// Token: 0x06019263 RID: 103011 RVA: 0x003AB094 File Offset: 0x003A9294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleTrackReportMsg other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.LevelPlayId == other.LevelPlayId && this.GainTreasureCount == other.GainTreasureCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019264 RID: 103012 RVA: 0x003AB0F0 File Offset: 0x003A92F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this.GainTreasureCount != 0)
			{
				num ^= this.GainTreasureCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019265 RID: 103013 RVA: 0x003AB161 File Offset: 0x003A9361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019266 RID: 103014 RVA: 0x003AB16E File Offset: 0x003A936E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019267 RID: 103015 RVA: 0x003AB178 File Offset: 0x003A9378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this.GainTreasureCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.GainTreasureCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019268 RID: 103016 RVA: 0x003AB1EC File Offset: 0x003A93EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this.GainTreasureCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GainTreasureCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019269 RID: 103017 RVA: 0x003AB25C File Offset: 0x003A945C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleTrackReportMsg other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			if (other.GainTreasureCount != 0)
			{
				this.GainTreasureCount = other.GainTreasureCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601926A RID: 103018 RVA: 0x003AB2C0 File Offset: 0x003A94C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601926B RID: 103019 RVA: 0x003AB2CC File Offset: 0x003A94CC
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GainTreasureCount = input.ReadInt32();
						}
					}
					else
					{
						this.LevelPlayId = input.ReadInt32();
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040094E5 RID: 38117
		private static readonly MessageParser<SimpleTrackReportMsg> _parser = new MessageParser<SimpleTrackReportMsg>(() => new SimpleTrackReportMsg());

		// Token: 0x040094E6 RID: 38118
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094E7 RID: 38119
		public const int InstIdFieldNumber = 1;

		// Token: 0x040094E8 RID: 38120
		private int instId_;

		// Token: 0x040094E9 RID: 38121
		public const int LevelPlayIdFieldNumber = 2;

		// Token: 0x040094EA RID: 38122
		private int levelPlayId_;

		// Token: 0x040094EB RID: 38123
		public const int GainTreasureCountFieldNumber = 3;

		// Token: 0x040094EC RID: 38124
		private int gainTreasureCount_;
	}
}
