using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001002 RID: 4098
	[NetMessage(EMessageId.RogueResTotalShopItemUpdateNotify)]
	public sealed class RogueResTotalShopItemUpdateNotify : IMessage<RogueResTotalShopItemUpdateNotify>, IMessage, IEquatable<RogueResTotalShopItemUpdateNotify>, IDeepCloneable<RogueResTotalShopItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015F0C RID: 89868 RVA: 0x00331344 File Offset: 0x0032F544
		[NullableContext(1)]
		public static RogueResTotalShopItemUpdateNotify Create()
		{
			return new RogueResTotalShopItemUpdateNotify();
		}

		// Token: 0x1700495B RID: 18779
		// (get) Token: 0x06015F0D RID: 89869 RVA: 0x0033134B File Offset: 0x0032F54B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700495C RID: 18780
		// (get) Token: 0x06015F0E RID: 89870 RVA: 0x0033134E File Offset: 0x0032F54E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResTotalShopItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015F0F RID: 89871 RVA: 0x00331355 File Offset: 0x0032F555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTotalShopItemUpdateNotify()
		{
		}

		// Token: 0x06015F10 RID: 89872 RVA: 0x0033135D File Offset: 0x0032F55D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTotalShopItemUpdateNotify(RogueResTotalShopItemUpdateNotify other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this.totalShopItem_ = other.totalShopItem_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015F11 RID: 89873 RVA: 0x0033138E File Offset: 0x0032F58E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTotalShopItemUpdateNotify Clone()
		{
			return new RogueResTotalShopItemUpdateNotify(this);
		}

		// Token: 0x1700495D RID: 18781
		// (get) Token: 0x06015F12 RID: 89874 RVA: 0x00331396 File Offset: 0x0032F596
		// (set) Token: 0x06015F13 RID: 89875 RVA: 0x0033139E File Offset: 0x0032F59E
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

		// Token: 0x1700495E RID: 18782
		// (get) Token: 0x06015F14 RID: 89876 RVA: 0x003313A7 File Offset: 0x0032F5A7
		// (set) Token: 0x06015F15 RID: 89877 RVA: 0x003313AF File Offset: 0x0032F5AF
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

		// Token: 0x06015F16 RID: 89878 RVA: 0x003313B8 File Offset: 0x0032F5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResTotalShopItemUpdateNotify);
		}

		// Token: 0x06015F17 RID: 89879 RVA: 0x003313C6 File Offset: 0x0032F5C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResTotalShopItemUpdateNotify other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && this.TotalShopItem == other.TotalShopItem && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015F18 RID: 89880 RVA: 0x00331404 File Offset: 0x0032F604
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

		// Token: 0x06015F19 RID: 89881 RVA: 0x0033145C File Offset: 0x0032F65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015F1A RID: 89882 RVA: 0x00331469 File Offset: 0x0032F669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015F1B RID: 89883 RVA: 0x00331474 File Offset: 0x0032F674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SeasonId);
			}
			if (this.TotalShopItem != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TotalShopItem);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015F1C RID: 89884 RVA: 0x003314D0 File Offset: 0x0032F6D0
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

		// Token: 0x06015F1D RID: 89885 RVA: 0x00331528 File Offset: 0x0032F728
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

		// Token: 0x06015F1E RID: 89886 RVA: 0x00331578 File Offset: 0x0032F778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015F1F RID: 89887 RVA: 0x00331584 File Offset: 0x0032F784
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
				if (num != 16U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TotalShopItem = input.ReadInt32();
					}
				}
				else
				{
					this.SeasonId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400841A RID: 33818
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400841B RID: 33819
		public const int SeasonIdFieldNumber = 2;

		// Token: 0x0400841C RID: 33820
		private int seasonId_;

		// Token: 0x0400841D RID: 33821
		public const int TotalShopItemFieldNumber = 6;

		// Token: 0x0400841E RID: 33822
		private int totalShopItem_;
	}
}
