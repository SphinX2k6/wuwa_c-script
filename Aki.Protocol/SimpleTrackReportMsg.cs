using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200122A RID: 4650
	public sealed class SimpleTrackReportMsg : IMessage<SimpleTrackReportMsg>, IMessage, IEquatable<SimpleTrackReportMsg>, IDeepCloneable<SimpleTrackReportMsg>, IBufferMessage
	{
		// Token: 0x06018C7B RID: 101499 RVA: 0x0039B145 File Offset: 0x00399345
		[NullableContext(1)]
		public static SimpleTrackReportMsg Create()
		{
			return new SimpleTrackReportMsg();
		}

		// Token: 0x17005384 RID: 21380
		// (get) Token: 0x06018C7C RID: 101500 RVA: 0x0039B14C File Offset: 0x0039934C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SimpleTrackReportMsg> Parser
		{
			get
			{
				return SimpleTrackReportMsg._parser;
			}
		}

		// Token: 0x17005385 RID: 21381
		// (get) Token: 0x06018C7D RID: 101501 RVA: 0x0039B153 File Offset: 0x00399353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005386 RID: 21382
		// (get) Token: 0x06018C7E RID: 101502 RVA: 0x0039B156 File Offset: 0x00399356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleTrackReportMsg.Descriptor;
			}
		}

		// Token: 0x06018C7F RID: 101503 RVA: 0x0039B15D File Offset: 0x0039935D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleTrackReportMsg()
		{
		}

		// Token: 0x06018C80 RID: 101504 RVA: 0x0039B165 File Offset: 0x00399365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleTrackReportMsg(SimpleTrackReportMsg other) : this()
		{
			this.instId_ = other.instId_;
			this.levelPlayId_ = other.levelPlayId_;
			this.gainTreasureCount_ = other.gainTreasureCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018C81 RID: 101505 RVA: 0x0039B1A2 File Offset: 0x003993A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleTrackReportMsg Clone()
		{
			return new SimpleTrackReportMsg(this);
		}

		// Token: 0x17005387 RID: 21383
		// (get) Token: 0x06018C82 RID: 101506 RVA: 0x0039B1AA File Offset: 0x003993AA
		// (set) Token: 0x06018C83 RID: 101507 RVA: 0x0039B1B2 File Offset: 0x003993B2
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

		// Token: 0x17005388 RID: 21384
		// (get) Token: 0x06018C84 RID: 101508 RVA: 0x0039B1BB File Offset: 0x003993BB
		// (set) Token: 0x06018C85 RID: 101509 RVA: 0x0039B1C3 File Offset: 0x003993C3
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

		// Token: 0x17005389 RID: 21385
		// (get) Token: 0x06018C86 RID: 101510 RVA: 0x0039B1CC File Offset: 0x003993CC
		// (set) Token: 0x06018C87 RID: 101511 RVA: 0x0039B1D4 File Offset: 0x003993D4
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

		// Token: 0x06018C88 RID: 101512 RVA: 0x0039B1DD File Offset: 0x003993DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleTrackReportMsg);
		}

		// Token: 0x06018C89 RID: 101513 RVA: 0x0039B1EC File Offset: 0x003993EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleTrackReportMsg other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.LevelPlayId == other.LevelPlayId && this.GainTreasureCount == other.GainTreasureCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018C8A RID: 101514 RVA: 0x0039B248 File Offset: 0x00399448
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

		// Token: 0x06018C8B RID: 101515 RVA: 0x0039B2B9 File Offset: 0x003994B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018C8C RID: 101516 RVA: 0x0039B2C6 File Offset: 0x003994C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018C8D RID: 101517 RVA: 0x0039B2D0 File Offset: 0x003994D0
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

		// Token: 0x06018C8E RID: 101518 RVA: 0x0039B344 File Offset: 0x00399544
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

		// Token: 0x06018C8F RID: 101519 RVA: 0x0039B3B4 File Offset: 0x003995B4
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

		// Token: 0x06018C90 RID: 101520 RVA: 0x0039B418 File Offset: 0x00399618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018C91 RID: 101521 RVA: 0x0039B424 File Offset: 0x00399624
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

		// Token: 0x04009234 RID: 37428
		private static readonly MessageParser<SimpleTrackReportMsg> _parser = new MessageParser<SimpleTrackReportMsg>(() => new SimpleTrackReportMsg());

		// Token: 0x04009235 RID: 37429
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009236 RID: 37430
		public const int InstIdFieldNumber = 1;

		// Token: 0x04009237 RID: 37431
		private int instId_;

		// Token: 0x04009238 RID: 37432
		public const int LevelPlayIdFieldNumber = 2;

		// Token: 0x04009239 RID: 37433
		private int levelPlayId_;

		// Token: 0x0400923A RID: 37434
		public const int GainTreasureCountFieldNumber = 3;

		// Token: 0x0400923B RID: 37435
		private int gainTreasureCount_;
	}
}
