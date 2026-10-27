using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001012 RID: 4114
	[NetMessage(EMessageId.RogueResTotalShopItemUpdateNotify)]
	public sealed class RogueResTotalShopItemUpdateNotify : IMessage<RogueResTotalShopItemUpdateNotify>, IMessage, IEquatable<RogueResTotalShopItemUpdateNotify>, IDeepCloneable<RogueResTotalShopItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015FF1 RID: 90097 RVA: 0x00332A00 File Offset: 0x00330C00
		[NullableContext(1)]
		public static RogueResTotalShopItemUpdateNotify Create()
		{
			return new RogueResTotalShopItemUpdateNotify();
		}

		// Token: 0x17004985 RID: 18821
		// (get) Token: 0x06015FF2 RID: 90098 RVA: 0x00332A07 File Offset: 0x00330C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004986 RID: 18822
		// (get) Token: 0x06015FF3 RID: 90099 RVA: 0x00332A0A File Offset: 0x00330C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResTotalShopItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015FF4 RID: 90100 RVA: 0x00332A11 File Offset: 0x00330C11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTotalShopItemUpdateNotify()
		{
		}

		// Token: 0x06015FF5 RID: 90101 RVA: 0x00332A19 File Offset: 0x00330C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTotalShopItemUpdateNotify(RogueResTotalShopItemUpdateNotify other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this.totalShopItem_ = other.totalShopItem_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015FF6 RID: 90102 RVA: 0x00332A4A File Offset: 0x00330C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTotalShopItemUpdateNotify Clone()
		{
			return new RogueResTotalShopItemUpdateNotify(this);
		}

		// Token: 0x17004987 RID: 18823
		// (get) Token: 0x06015FF7 RID: 90103 RVA: 0x00332A52 File Offset: 0x00330C52
		// (set) Token: 0x06015FF8 RID: 90104 RVA: 0x00332A5A File Offset: 0x00330C5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
		{
			get
			{
				return this.seasonId_;
			}
			set
			{
				this.seasonId_ = value;
			}
		}

		// Token: 0x17004988 RID: 18824
		// (get) Token: 0x06015FF9 RID: 90105 RVA: 0x00332A63 File Offset: 0x00330C63
		// (set) Token: 0x06015FFA RID: 90106 RVA: 0x00332A6B File Offset: 0x00330C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalShopItem
		{
			get
			{
				return this.totalShopItem_;
			}
			set
			{
				this.totalShopItem_ = value;
			}
		}

		// Token: 0x06015FFB RID: 90107 RVA: 0x00332A74 File Offset: 0x00330C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResTotalShopItemUpdateNotify);
		}

		// Token: 0x06015FFC RID: 90108 RVA: 0x00332A82 File Offset: 0x00330C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResTotalShopItemUpdateNotify other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && this.TotalShopItem == other.TotalShopItem && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015FFD RID: 90109 RVA: 0x00332AC0 File Offset: 0x00330CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			if (this.TotalShopItem != 0)
			{
				num ^= this.TotalShopItem.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015FFE RID: 90110 RVA: 0x00332B18 File Offset: 0x00330D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015FFF RID: 90111 RVA: 0x00332B25 File Offset: 0x00330D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016000 RID: 90112 RVA: 0x00332B30 File Offset: 0x00330D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalShopItem != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TotalShopItem);
			}
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016001 RID: 90113 RVA: 0x00332B8C File Offset: 0x00330D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			if (this.TotalShopItem != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalShopItem);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016002 RID: 90114 RVA: 0x00332BE4 File Offset: 0x00330DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResTotalShopItemUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			if (other.TotalShopItem != 0)
			{
				this.TotalShopItem = other.TotalShopItem;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016003 RID: 90115 RVA: 0x00332C34 File Offset: 0x00330E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016004 RID: 90116 RVA: 0x00332C40 File Offset: 0x00330E40
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
				if (num != 24U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SeasonId = input.ReadInt32();
					}
				}
				else
				{
					this.TotalShopItem = input.ReadInt32();
				}
			}
		}

		// Token: 0x040083F0 RID: 33776
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083F1 RID: 33777
		public const int SeasonIdFieldNumber = 9;

		// Token: 0x040083F2 RID: 33778
		private int seasonId_;

		// Token: 0x040083F3 RID: 33779
		public const int TotalShopItemFieldNumber = 3;

		// Token: 0x040083F4 RID: 33780
		private int totalShopItem_;
	}
}
