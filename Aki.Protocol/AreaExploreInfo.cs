using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200010C RID: 268
	public sealed class AreaExploreInfo : IMessage<AreaExploreInfo>, IMessage, IEquatable<AreaExploreInfo>, IDeepCloneable<AreaExploreInfo>, IBufferMessage
	{
		// Token: 0x06002567 RID: 9575 RVA: 0x00063F7F File Offset: 0x0006217F
		[NullableContext(1)]
		public static AreaExploreInfo Create()
		{
			return new AreaExploreInfo();
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06002568 RID: 9576 RVA: 0x00063F86 File Offset: 0x00062186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AreaExploreInfo> Parser
		{
			get
			{
				return AreaExploreInfo._parser;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x00063F8D File Offset: 0x0006218D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x00063F90 File Offset: 0x00062190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AreaExploreInfo.Descriptor;
			}
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x00063F97 File Offset: 0x00062197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaExploreInfo()
		{
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x00063FAC File Offset: 0x000621AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaExploreInfo(AreaExploreInfo other) : this()
		{
			this.areaId_ = other.areaId_;
			this.exploreProgress_ = other.exploreProgress_.Clone();
			this.explorePercent_ = other.explorePercent_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x00063FF9 File Offset: 0x000621F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaExploreInfo Clone()
		{
			return new AreaExploreInfo(this);
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x0600256E RID: 9582 RVA: 0x00064001 File Offset: 0x00062201
		// (set) Token: 0x0600256F RID: 9583 RVA: 0x00064009 File Offset: 0x00062209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06002570 RID: 9584 RVA: 0x00064012 File Offset: 0x00062212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneExploreItem> ExploreProgress
		{
			get
			{
				return this.exploreProgress_;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06002571 RID: 9585 RVA: 0x0006401A File Offset: 0x0006221A
		// (set) Token: 0x06002572 RID: 9586 RVA: 0x00064022 File Offset: 0x00062222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExplorePercent
		{
			get
			{
				return this.explorePercent_;
			}
			set
			{
				this.explorePercent_ = value;
			}
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x0006402B File Offset: 0x0006222B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AreaExploreInfo);
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x0006403C File Offset: 0x0006223C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AreaExploreInfo other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && this.exploreProgress_.Equals(other.exploreProgress_) && this.ExplorePercent == other.ExplorePercent && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x0006409C File Offset: 0x0006229C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0)
			{
				num ^= this.AreaId.GetHashCode();
			}
			num ^= this.exploreProgress_.GetHashCode();
			if (this.ExplorePercent != 0)
			{
				num ^= this.ExplorePercent.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x00064102 File Offset: 0x00062302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x0006410F File Offset: 0x0006230F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x00064118 File Offset: 0x00062318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AreaId);
			}
			this.exploreProgress_.WriteTo(ref output, AreaExploreInfo._repeated_exploreProgress_codec);
			if (this.ExplorePercent != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ExplorePercent);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x00064184 File Offset: 0x00062384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaId);
			}
			num += this.exploreProgress_.CalculateSize(AreaExploreInfo._repeated_exploreProgress_codec);
			if (this.ExplorePercent != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExplorePercent);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x000641F0 File Offset: 0x000623F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AreaExploreInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0)
			{
				this.AreaId = other.AreaId;
			}
			this.exploreProgress_.Add(other.exploreProgress_);
			if (other.ExplorePercent != 0)
			{
				this.ExplorePercent = other.ExplorePercent;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x00064251 File Offset: 0x00062451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x0006425C File Offset: 0x0006245C
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
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ExplorePercent = input.ReadInt32();
						}
					}
					else
					{
						this.exploreProgress_.AddEntriesFrom(ref input, AreaExploreInfo._repeated_exploreProgress_codec);
					}
				}
				else
				{
					this.AreaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400260E RID: 9742
		private static readonly MessageParser<AreaExploreInfo> _parser = new MessageParser<AreaExploreInfo>(() => new AreaExploreInfo());

		// Token: 0x0400260F RID: 9743
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002610 RID: 9744
		public const int AreaIdFieldNumber = 1;

		// Token: 0x04002611 RID: 9745
		private int areaId_;

		// Token: 0x04002612 RID: 9746
		public const int ExploreProgressFieldNumber = 2;

		// Token: 0x04002613 RID: 9747
		private static readonly FieldCodec<OneExploreItem> _repeated_exploreProgress_codec = FieldCodec.ForMessage<OneExploreItem>(18U, OneExploreItem.Parser);

		// Token: 0x04002614 RID: 9748
		private readonly RepeatedField<OneExploreItem> exploreProgress_ = new RepeatedField<OneExploreItem>();

		// Token: 0x04002615 RID: 9749
		public const int ExplorePercentFieldNumber = 3;

		// Token: 0x04002616 RID: 9750
		private int explorePercent_;
	}
}
