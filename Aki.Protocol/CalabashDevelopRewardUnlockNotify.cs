using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200021C RID: 540
	[NetMessage(EMessageId.CalabashDevelopRewardUnlockNotify)]
	public sealed class CalabashDevelopRewardUnlockNotify : IMessage<CalabashDevelopRewardUnlockNotify>, IMessage, IEquatable<CalabashDevelopRewardUnlockNotify>, IDeepCloneable<CalabashDevelopRewardUnlockNotify>, IBufferMessage
	{
		// Token: 0x06003B1C RID: 15132 RVA: 0x00093269 File Offset: 0x00091469
		[NullableContext(1)]
		public static CalabashDevelopRewardUnlockNotify Create()
		{
			return new CalabashDevelopRewardUnlockNotify();
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06003B1D RID: 15133 RVA: 0x00093270 File Offset: 0x00091470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06003B1E RID: 15134 RVA: 0x00093273 File Offset: 0x00091473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashDevelopRewardUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x0009327A File Offset: 0x0009147A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopRewardUnlockNotify()
		{
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x00093284 File Offset: 0x00091484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopRewardUnlockNotify(CalabashDevelopRewardUnlockNotify other) : this()
		{
			this.unlockedDevelopReward_ = ((other.unlockedDevelopReward_ != null) ? other.unlockedDevelopReward_.Clone() : null);
			this.itemId_ = other.itemId_;
			this.incrId_ = other.incrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x000932DC File Offset: 0x000914DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopRewardUnlockNotify Clone()
		{
			return new CalabashDevelopRewardUnlockNotify(this);
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06003B22 RID: 15138 RVA: 0x000932E4 File Offset: 0x000914E4
		// (set) Token: 0x06003B23 RID: 15139 RVA: 0x000932EC File Offset: 0x000914EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopInfo UnlockedDevelopReward
		{
			get
			{
				return this.unlockedDevelopReward_;
			}
			set
			{
				this.unlockedDevelopReward_ = value;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06003B24 RID: 15140 RVA: 0x000932F5 File Offset: 0x000914F5
		// (set) Token: 0x06003B25 RID: 15141 RVA: 0x000932FD File Offset: 0x000914FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06003B26 RID: 15142 RVA: 0x00093306 File Offset: 0x00091506
		// (set) Token: 0x06003B27 RID: 15143 RVA: 0x0009330E File Offset: 0x0009150E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x00093317 File Offset: 0x00091517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashDevelopRewardUnlockNotify);
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x00093328 File Offset: 0x00091528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashDevelopRewardUnlockNotify other)
		{
			return other != null && (other == this || (object.Equals(this.UnlockedDevelopReward, other.UnlockedDevelopReward) && this.ItemId == other.ItemId && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x00093388 File Offset: 0x00091588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.unlockedDevelopReward_ != null)
			{
				num ^= this.UnlockedDevelopReward.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x000933F6 File Offset: 0x000915F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x00093403 File Offset: 0x00091603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B2D RID: 15149 RVA: 0x0009340C File Offset: 0x0009160C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ItemId);
			}
			if (this.unlockedDevelopReward_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.UnlockedDevelopReward);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x00093484 File Offset: 0x00091684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.unlockedDevelopReward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UnlockedDevelopReward);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x000934F4 File Offset: 0x000916F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashDevelopRewardUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.unlockedDevelopReward_ != null)
			{
				if (this.unlockedDevelopReward_ == null)
				{
					this.UnlockedDevelopReward = new CalabashDevelopInfo();
				}
				this.UnlockedDevelopReward.MergeFrom(other.UnlockedDevelopReward);
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003B30 RID: 15152 RVA: 0x00093570 File Offset: 0x00091770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x0009357C File Offset: 0x0009177C
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
				if (num != 64U)
				{
					if (num != 98U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IncrId = input.ReadInt32();
						}
					}
					else
					{
						if (this.unlockedDevelopReward_ == null)
						{
							this.UnlockedDevelopReward = new CalabashDevelopInfo();
						}
						input.ReadMessage(this.UnlockedDevelopReward);
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002C0F RID: 11279
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C10 RID: 11280
		public const int UnlockedDevelopRewardFieldNumber = 12;

		// Token: 0x04002C11 RID: 11281
		private CalabashDevelopInfo unlockedDevelopReward_;

		// Token: 0x04002C12 RID: 11282
		public const int ItemIdFieldNumber = 8;

		// Token: 0x04002C13 RID: 11283
		private int itemId_;

		// Token: 0x04002C14 RID: 11284
		public const int IncrIdFieldNumber = 13;

		// Token: 0x04002C15 RID: 11285
		private int incrId_;
	}
}
