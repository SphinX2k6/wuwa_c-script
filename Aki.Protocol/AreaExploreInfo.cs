using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200010A RID: 266
	public sealed class AreaExploreInfo : IMessage<AreaExploreInfo>, IMessage, IEquatable<AreaExploreInfo>, IDeepCloneable<AreaExploreInfo>, IBufferMessage
	{
		// Token: 0x06002508 RID: 9480 RVA: 0x00062F5C File Offset: 0x0006115C
		[NullableContext(1)]
		public static AreaExploreInfo Create()
		{
			return new AreaExploreInfo();
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x00062F63 File Offset: 0x00061163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AreaExploreInfo> Parser
		{
			get
			{
				return AreaExploreInfo._parser;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600250A RID: 9482 RVA: 0x00062F6A File Offset: 0x0006116A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600250B RID: 9483 RVA: 0x00062F6D File Offset: 0x0006116D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AreaExploreInfo.Descriptor;
			}
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x00062F74 File Offset: 0x00061174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaExploreInfo()
		{
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x00062F88 File Offset: 0x00061188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaExploreInfo(AreaExploreInfo other) : this()
		{
			this.areaId_ = other.areaId_;
			this.exploreProgress_ = other.exploreProgress_.Clone();
			this.explorePercent_ = other.explorePercent_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x00062FD5 File Offset: 0x000611D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaExploreInfo Clone()
		{
			return new AreaExploreInfo(this);
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x00062FDD File Offset: 0x000611DD
		// (set) Token: 0x06002510 RID: 9488 RVA: 0x00062FE5 File Offset: 0x000611E5
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

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06002511 RID: 9489 RVA: 0x00062FEE File Offset: 0x000611EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneExploreItem> ExploreProgress
		{
			get
			{
				return this.exploreProgress_;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06002512 RID: 9490 RVA: 0x00062FF6 File Offset: 0x000611F6
		// (set) Token: 0x06002513 RID: 9491 RVA: 0x00062FFE File Offset: 0x000611FE
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

		// Token: 0x06002514 RID: 9492 RVA: 0x00063007 File Offset: 0x00061207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AreaExploreInfo);
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x00063018 File Offset: 0x00061218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AreaExploreInfo other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && this.exploreProgress_.Equals(other.exploreProgress_) && this.ExplorePercent == other.ExplorePercent && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x00063078 File Offset: 0x00061278
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

		// Token: 0x06002517 RID: 9495 RVA: 0x000630DE File Offset: 0x000612DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x000630EB File Offset: 0x000612EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x000630F4 File Offset: 0x000612F4
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

		// Token: 0x0600251A RID: 9498 RVA: 0x00063160 File Offset: 0x00061360
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

		// Token: 0x0600251B RID: 9499 RVA: 0x000631CC File Offset: 0x000613CC
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

		// Token: 0x0600251C RID: 9500 RVA: 0x0006322D File Offset: 0x0006142D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x00063238 File Offset: 0x00061438
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

		// Token: 0x040025A3 RID: 9635
		private static readonly MessageParser<AreaExploreInfo> _parser = new MessageParser<AreaExploreInfo>(() => new AreaExploreInfo());

		// Token: 0x040025A4 RID: 9636
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025A5 RID: 9637
		public const int AreaIdFieldNumber = 1;

		// Token: 0x040025A6 RID: 9638
		private int areaId_;

		// Token: 0x040025A7 RID: 9639
		public const int ExploreProgressFieldNumber = 2;

		// Token: 0x040025A8 RID: 9640
		private static readonly FieldCodec<OneExploreItem> _repeated_exploreProgress_codec = FieldCodec.ForMessage<OneExploreItem>(18U, OneExploreItem.Parser);

		// Token: 0x040025A9 RID: 9641
		private readonly RepeatedField<OneExploreItem> exploreProgress_ = new RepeatedField<OneExploreItem>();

		// Token: 0x040025AA RID: 9642
		public const int ExplorePercentFieldNumber = 3;

		// Token: 0x040025AB RID: 9643
		private int explorePercent_;
	}
}
