using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C9 RID: 457
	[NetMessage(EMessageId.BossPilingSettleNotify)]
	public sealed class BossPilingSettleNotify : IMessage<BossPilingSettleNotify>, IMessage, IEquatable<BossPilingSettleNotify>, IDeepCloneable<BossPilingSettleNotify>, IBufferMessage
	{
		// Token: 0x0600344F RID: 13391 RVA: 0x00084021 File Offset: 0x00082221
		[NullableContext(1)]
		public static BossPilingSettleNotify Create()
		{
			return new BossPilingSettleNotify();
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06003450 RID: 13392 RVA: 0x00084028 File Offset: 0x00082228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06003451 RID: 13393 RVA: 0x0008402B File Offset: 0x0008222B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingSettleNotify.Descriptor;
			}
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x00084032 File Offset: 0x00082232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingSettleNotify()
		{
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x0008403C File Offset: 0x0008223C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingSettleNotify(BossPilingSettleNotify other) : this()
		{
			this.challengeLevelId_ = other.challengeLevelId_;
			this.bossHpNum_ = other.bossHpNum_;
			this.isSuc_ = other.isSuc_;
			this.isUpdateBossHpNum_ = other.isUpdateBossHpNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x00084090 File Offset: 0x00082290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingSettleNotify Clone()
		{
			return new BossPilingSettleNotify(this);
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06003455 RID: 13397 RVA: 0x00084098 File Offset: 0x00082298
		// (set) Token: 0x06003456 RID: 13398 RVA: 0x000840A0 File Offset: 0x000822A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeLevelId
		{
			get
			{
				return this.challengeLevelId_;
			}
			set
			{
				this.challengeLevelId_ = value;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06003457 RID: 13399 RVA: 0x000840A9 File Offset: 0x000822A9
		// (set) Token: 0x06003458 RID: 13400 RVA: 0x000840B1 File Offset: 0x000822B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BossHpNum
		{
			get
			{
				return this.bossHpNum_;
			}
			set
			{
				this.bossHpNum_ = value;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06003459 RID: 13401 RVA: 0x000840BA File Offset: 0x000822BA
		// (set) Token: 0x0600345A RID: 13402 RVA: 0x000840C2 File Offset: 0x000822C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuc
		{
			get
			{
				return this.isSuc_;
			}
			set
			{
				this.isSuc_ = value;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x0600345B RID: 13403 RVA: 0x000840CB File Offset: 0x000822CB
		// (set) Token: 0x0600345C RID: 13404 RVA: 0x000840D3 File Offset: 0x000822D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUpdateBossHpNum
		{
			get
			{
				return this.isUpdateBossHpNum_;
			}
			set
			{
				this.isUpdateBossHpNum_ = value;
			}
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x000840DC File Offset: 0x000822DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingSettleNotify);
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x000840EC File Offset: 0x000822EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingSettleNotify other)
		{
			return other != null && (other == this || (this.ChallengeLevelId == other.ChallengeLevelId && this.BossHpNum == other.BossHpNum && this.IsSuc == other.IsSuc && this.IsUpdateBossHpNum == other.IsUpdateBossHpNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x00084158 File Offset: 0x00082358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeLevelId != 0)
			{
				num ^= this.ChallengeLevelId.GetHashCode();
			}
			if (this.BossHpNum != 0)
			{
				num ^= this.BossHpNum.GetHashCode();
			}
			if (this.IsSuc)
			{
				num ^= this.IsSuc.GetHashCode();
			}
			if (this.IsUpdateBossHpNum)
			{
				num ^= this.IsUpdateBossHpNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x000841E2 File Offset: 0x000823E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x000841EF File Offset: 0x000823EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x000841F8 File Offset: 0x000823F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BossHpNum != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BossHpNum);
			}
			if (this.IsSuc)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsSuc);
			}
			if (this.ChallengeLevelId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ChallengeLevelId);
			}
			if (this.IsUpdateBossHpNum)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsUpdateBossHpNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x00084288 File Offset: 0x00082488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeLevelId);
			}
			if (this.BossHpNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BossHpNum);
			}
			if (this.IsSuc)
			{
				num += 2;
			}
			if (this.IsUpdateBossHpNum)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x000842F8 File Offset: 0x000824F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeLevelId != 0)
			{
				this.ChallengeLevelId = other.ChallengeLevelId;
			}
			if (other.BossHpNum != 0)
			{
				this.BossHpNum = other.BossHpNum;
			}
			if (other.IsSuc)
			{
				this.IsSuc = other.IsSuc;
			}
			if (other.IsUpdateBossHpNum)
			{
				this.IsUpdateBossHpNum = other.IsUpdateBossHpNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x00084370 File Offset: 0x00082570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x0008437C File Offset: 0x0008257C
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
				if (num <= 88U)
				{
					if (num == 8U)
					{
						this.BossHpNum = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.IsSuc = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.ChallengeLevelId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.IsUpdateBossHpNum = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040029FE RID: 10750
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029FF RID: 10751
		public const int ChallengeLevelIdFieldNumber = 12;

		// Token: 0x04002A00 RID: 10752
		private int challengeLevelId_;

		// Token: 0x04002A01 RID: 10753
		public const int BossHpNumFieldNumber = 1;

		// Token: 0x04002A02 RID: 10754
		private int bossHpNum_;

		// Token: 0x04002A03 RID: 10755
		public const int IsSucFieldNumber = 11;

		// Token: 0x04002A04 RID: 10756
		private bool isSuc_;

		// Token: 0x04002A05 RID: 10757
		public const int IsUpdateBossHpNumFieldNumber = 14;

		// Token: 0x04002A06 RID: 10758
		private bool isUpdateBossHpNum_;
	}
}
