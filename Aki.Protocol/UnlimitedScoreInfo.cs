using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F6 RID: 5366
	public sealed class UnlimitedScoreInfo : IMessage<UnlimitedScoreInfo>, IMessage, IEquatable<UnlimitedScoreInfo>, IDeepCloneable<UnlimitedScoreInfo>, IBufferMessage
	{
		// Token: 0x0601C726 RID: 116518 RVA: 0x00420309 File Offset: 0x0041E509
		[NullableContext(1)]
		public static UnlimitedScoreInfo Create()
		{
			return new UnlimitedScoreInfo();
		}

		// Token: 0x17006043 RID: 24643
		// (get) Token: 0x0601C727 RID: 116519 RVA: 0x00420310 File Offset: 0x0041E510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlimitedScoreInfo> Parser
		{
			get
			{
				return UnlimitedScoreInfo._parser;
			}
		}

		// Token: 0x17006044 RID: 24644
		// (get) Token: 0x0601C728 RID: 116520 RVA: 0x00420317 File Offset: 0x0041E517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006045 RID: 24645
		// (get) Token: 0x0601C729 RID: 116521 RVA: 0x0042031A File Offset: 0x0041E51A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlimitedScoreInfo.Descriptor;
			}
		}

		// Token: 0x0601C72A RID: 116522 RVA: 0x00420321 File Offset: 0x0041E521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlimitedScoreInfo()
		{
		}

		// Token: 0x0601C72B RID: 116523 RVA: 0x00420329 File Offset: 0x0041E529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlimitedScoreInfo(UnlimitedScoreInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.highestScore_ = other.highestScore_;
			this.accumulatedScore_ = other.accumulatedScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C72C RID: 116524 RVA: 0x00420366 File Offset: 0x0041E566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlimitedScoreInfo Clone()
		{
			return new UnlimitedScoreInfo(this);
		}

		// Token: 0x17006046 RID: 24646
		// (get) Token: 0x0601C72D RID: 116525 RVA: 0x0042036E File Offset: 0x0041E56E
		// (set) Token: 0x0601C72E RID: 116526 RVA: 0x00420376 File Offset: 0x0041E576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17006047 RID: 24647
		// (get) Token: 0x0601C72F RID: 116527 RVA: 0x0042037F File Offset: 0x0041E57F
		// (set) Token: 0x0601C730 RID: 116528 RVA: 0x00420387 File Offset: 0x0041E587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HighestScore
		{
			get
			{
				return this.highestScore_;
			}
			set
			{
				this.highestScore_ = value;
			}
		}

		// Token: 0x17006048 RID: 24648
		// (get) Token: 0x0601C731 RID: 116529 RVA: 0x00420390 File Offset: 0x0041E590
		// (set) Token: 0x0601C732 RID: 116530 RVA: 0x00420398 File Offset: 0x0041E598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AccumulatedScore
		{
			get
			{
				return this.accumulatedScore_;
			}
			set
			{
				this.accumulatedScore_ = value;
			}
		}

		// Token: 0x0601C733 RID: 116531 RVA: 0x004203A1 File Offset: 0x0041E5A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlimitedScoreInfo);
		}

		// Token: 0x0601C734 RID: 116532 RVA: 0x004203B0 File Offset: 0x0041E5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlimitedScoreInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.HighestScore == other.HighestScore && this.AccumulatedScore == other.AccumulatedScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C735 RID: 116533 RVA: 0x0042040C File Offset: 0x0041E60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.HighestScore != 0)
			{
				num ^= this.HighestScore.GetHashCode();
			}
			if (this.AccumulatedScore != 0)
			{
				num ^= this.AccumulatedScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C736 RID: 116534 RVA: 0x0042047D File Offset: 0x0041E67D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C737 RID: 116535 RVA: 0x0042048A File Offset: 0x0041E68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C738 RID: 116536 RVA: 0x00420494 File Offset: 0x0041E694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EntityId);
			}
			if (this.HighestScore != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HighestScore);
			}
			if (this.AccumulatedScore != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AccumulatedScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C739 RID: 116537 RVA: 0x00420508 File Offset: 0x0041E708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityId);
			}
			if (this.HighestScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HighestScore);
			}
			if (this.AccumulatedScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AccumulatedScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C73A RID: 116538 RVA: 0x00420578 File Offset: 0x0041E778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlimitedScoreInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0)
			{
				this.EntityId = other.EntityId;
			}
			if (other.HighestScore != 0)
			{
				this.HighestScore = other.HighestScore;
			}
			if (other.AccumulatedScore != 0)
			{
				this.AccumulatedScore = other.AccumulatedScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C73B RID: 116539 RVA: 0x004205DC File Offset: 0x0041E7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C73C RID: 116540 RVA: 0x004205E8 File Offset: 0x0041E7E8
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
							this.AccumulatedScore = input.ReadInt32();
						}
					}
					else
					{
						this.HighestScore = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A431 RID: 42033
		private static readonly MessageParser<UnlimitedScoreInfo> _parser = new MessageParser<UnlimitedScoreInfo>(() => new UnlimitedScoreInfo());

		// Token: 0x0400A432 RID: 42034
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A433 RID: 42035
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400A434 RID: 42036
		private int entityId_;

		// Token: 0x0400A435 RID: 42037
		public const int HighestScoreFieldNumber = 2;

		// Token: 0x0400A436 RID: 42038
		private int highestScore_;

		// Token: 0x0400A437 RID: 42039
		public const int AccumulatedScoreFieldNumber = 3;

		// Token: 0x0400A438 RID: 42040
		private int accumulatedScore_;
	}
}
