using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001255 RID: 4693
	public sealed class SlashLevelPlayInfo : IMessage<SlashLevelPlayInfo>, IMessage, IEquatable<SlashLevelPlayInfo>, IDeepCloneable<SlashLevelPlayInfo>, IBufferMessage
	{
		// Token: 0x06019009 RID: 102409 RVA: 0x003A332C File Offset: 0x003A152C
		[NullableContext(1)]
		public static SlashLevelPlayInfo Create()
		{
			return new SlashLevelPlayInfo();
		}

		// Token: 0x1700544F RID: 21583
		// (get) Token: 0x0601900A RID: 102410 RVA: 0x003A3333 File Offset: 0x003A1533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SlashLevelPlayInfo> Parser
		{
			get
			{
				return SlashLevelPlayInfo._parser;
			}
		}

		// Token: 0x17005450 RID: 21584
		// (get) Token: 0x0601900B RID: 102411 RVA: 0x003A333A File Offset: 0x003A153A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005451 RID: 21585
		// (get) Token: 0x0601900C RID: 102412 RVA: 0x003A333D File Offset: 0x003A153D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashLevelPlayInfo.Descriptor;
			}
		}

		// Token: 0x0601900D RID: 102413 RVA: 0x003A3344 File Offset: 0x003A1544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashLevelPlayInfo()
		{
		}

		// Token: 0x0601900E RID: 102414 RVA: 0x003A334C File Offset: 0x003A154C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashLevelPlayInfo(SlashLevelPlayInfo other) : this()
		{
			this.id_ = other.id_;
			this.unLock_ = other.unLock_;
			this.slashFirstScore_ = other.slashFirstScore_;
			this.slashSecondScore_ = other.slashSecondScore_;
			this.firstBattle_ = ((other.firstBattle_ != null) ? other.firstBattle_.Clone() : null);
			this.secondBattle_ = ((other.secondBattle_ != null) ? other.secondBattle_.Clone() : null);
			this.levelPass_ = other.levelPass_;
			this.isEasyPass_ = other.isEasyPass_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601900F RID: 102415 RVA: 0x003A33F0 File Offset: 0x003A15F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashLevelPlayInfo Clone()
		{
			return new SlashLevelPlayInfo(this);
		}

		// Token: 0x17005452 RID: 21586
		// (get) Token: 0x06019010 RID: 102416 RVA: 0x003A33F8 File Offset: 0x003A15F8
		// (set) Token: 0x06019011 RID: 102417 RVA: 0x003A3400 File Offset: 0x003A1600
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

		// Token: 0x17005453 RID: 21587
		// (get) Token: 0x06019012 RID: 102418 RVA: 0x003A3409 File Offset: 0x003A1609
		// (set) Token: 0x06019013 RID: 102419 RVA: 0x003A3411 File Offset: 0x003A1611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UnLock
		{
			get
			{
				return this.unLock_;
			}
			set
			{
				this.unLock_ = value;
			}
		}

		// Token: 0x17005454 RID: 21588
		// (get) Token: 0x06019014 RID: 102420 RVA: 0x003A341A File Offset: 0x003A161A
		// (set) Token: 0x06019015 RID: 102421 RVA: 0x003A3422 File Offset: 0x003A1622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlashFirstScore
		{
			get
			{
				return this.slashFirstScore_;
			}
			set
			{
				this.slashFirstScore_ = value;
			}
		}

		// Token: 0x17005455 RID: 21589
		// (get) Token: 0x06019016 RID: 102422 RVA: 0x003A342B File Offset: 0x003A162B
		// (set) Token: 0x06019017 RID: 102423 RVA: 0x003A3433 File Offset: 0x003A1633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlashSecondScore
		{
			get
			{
				return this.slashSecondScore_;
			}
			set
			{
				this.slashSecondScore_ = value;
			}
		}

		// Token: 0x17005456 RID: 21590
		// (get) Token: 0x06019018 RID: 102424 RVA: 0x003A343C File Offset: 0x003A163C
		// (set) Token: 0x06019019 RID: 102425 RVA: 0x003A3444 File Offset: 0x003A1644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleFormation FirstBattle
		{
			get
			{
				return this.firstBattle_;
			}
			set
			{
				this.firstBattle_ = value;
			}
		}

		// Token: 0x17005457 RID: 21591
		// (get) Token: 0x0601901A RID: 102426 RVA: 0x003A344D File Offset: 0x003A164D
		// (set) Token: 0x0601901B RID: 102427 RVA: 0x003A3455 File Offset: 0x003A1655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleFormation SecondBattle
		{
			get
			{
				return this.secondBattle_;
			}
			set
			{
				this.secondBattle_ = value;
			}
		}

		// Token: 0x17005458 RID: 21592
		// (get) Token: 0x0601901C RID: 102428 RVA: 0x003A345E File Offset: 0x003A165E
		// (set) Token: 0x0601901D RID: 102429 RVA: 0x003A3466 File Offset: 0x003A1666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LevelPass
		{
			get
			{
				return this.levelPass_;
			}
			set
			{
				this.levelPass_ = value;
			}
		}

		// Token: 0x17005459 RID: 21593
		// (get) Token: 0x0601901E RID: 102430 RVA: 0x003A346F File Offset: 0x003A166F
		// (set) Token: 0x0601901F RID: 102431 RVA: 0x003A3477 File Offset: 0x003A1677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEasyPass
		{
			get
			{
				return this.isEasyPass_;
			}
			set
			{
				this.isEasyPass_ = value;
			}
		}

		// Token: 0x06019020 RID: 102432 RVA: 0x003A3480 File Offset: 0x003A1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashLevelPlayInfo);
		}

		// Token: 0x06019021 RID: 102433 RVA: 0x003A3490 File Offset: 0x003A1690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashLevelPlayInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.UnLock == other.UnLock && this.SlashFirstScore == other.SlashFirstScore && this.SlashSecondScore == other.SlashSecondScore && object.Equals(this.FirstBattle, other.FirstBattle) && object.Equals(this.SecondBattle, other.SecondBattle) && this.LevelPass == other.LevelPass && this.IsEasyPass == other.IsEasyPass && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019022 RID: 102434 RVA: 0x003A3544 File Offset: 0x003A1744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.UnLock)
			{
				num ^= this.UnLock.GetHashCode();
			}
			if (this.SlashFirstScore != 0)
			{
				num ^= this.SlashFirstScore.GetHashCode();
			}
			if (this.SlashSecondScore != 0)
			{
				num ^= this.SlashSecondScore.GetHashCode();
			}
			if (this.firstBattle_ != null)
			{
				num ^= this.FirstBattle.GetHashCode();
			}
			if (this.secondBattle_ != null)
			{
				num ^= this.SecondBattle.GetHashCode();
			}
			if (this.LevelPass)
			{
				num ^= this.LevelPass.GetHashCode();
			}
			if (this.IsEasyPass)
			{
				num ^= this.IsEasyPass.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019023 RID: 102435 RVA: 0x003A362C File Offset: 0x003A182C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019024 RID: 102436 RVA: 0x003A3639 File Offset: 0x003A1839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019025 RID: 102437 RVA: 0x003A3644 File Offset: 0x003A1844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.UnLock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.UnLock);
			}
			if (this.SlashFirstScore != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SlashFirstScore);
			}
			if (this.SlashSecondScore != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SlashSecondScore);
			}
			if (this.firstBattle_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.FirstBattle);
			}
			if (this.secondBattle_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.SecondBattle);
			}
			if (this.LevelPass)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.LevelPass);
			}
			if (this.IsEasyPass)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsEasyPass);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019026 RID: 102438 RVA: 0x003A3744 File Offset: 0x003A1944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.UnLock)
			{
				num += 2;
			}
			if (this.SlashFirstScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlashFirstScore);
			}
			if (this.SlashSecondScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlashSecondScore);
			}
			if (this.firstBattle_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FirstBattle);
			}
			if (this.secondBattle_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SecondBattle);
			}
			if (this.LevelPass)
			{
				num += 2;
			}
			if (this.IsEasyPass)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019027 RID: 102439 RVA: 0x003A3808 File Offset: 0x003A1A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashLevelPlayInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.UnLock)
			{
				this.UnLock = other.UnLock;
			}
			if (other.SlashFirstScore != 0)
			{
				this.SlashFirstScore = other.SlashFirstScore;
			}
			if (other.SlashSecondScore != 0)
			{
				this.SlashSecondScore = other.SlashSecondScore;
			}
			if (other.firstBattle_ != null)
			{
				if (this.firstBattle_ == null)
				{
					this.FirstBattle = new BattleFormation();
				}
				this.FirstBattle.MergeFrom(other.FirstBattle);
			}
			if (other.secondBattle_ != null)
			{
				if (this.secondBattle_ == null)
				{
					this.SecondBattle = new BattleFormation();
				}
				this.SecondBattle.MergeFrom(other.SecondBattle);
			}
			if (other.LevelPass)
			{
				this.LevelPass = other.LevelPass;
			}
			if (other.IsEasyPass)
			{
				this.IsEasyPass = other.IsEasyPass;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019028 RID: 102440 RVA: 0x003A3900 File Offset: 0x003A1B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019029 RID: 102441 RVA: 0x003A390C File Offset: 0x003A1B0C
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
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.Id = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.UnLock = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.SlashFirstScore = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.SlashSecondScore = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 50U)
				{
					if (num == 42U)
					{
						if (this.firstBattle_ == null)
						{
							this.FirstBattle = new BattleFormation();
						}
						input.ReadMessage(this.FirstBattle);
						continue;
					}
					if (num == 50U)
					{
						if (this.secondBattle_ == null)
						{
							this.SecondBattle = new BattleFormation();
						}
						input.ReadMessage(this.SecondBattle);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.LevelPass = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.IsEasyPass = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009355 RID: 37717
		private static readonly MessageParser<SlashLevelPlayInfo> _parser = new MessageParser<SlashLevelPlayInfo>(() => new SlashLevelPlayInfo());

		// Token: 0x04009356 RID: 37718
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009357 RID: 37719
		public const int IdFieldNumber = 1;

		// Token: 0x04009358 RID: 37720
		private int id_;

		// Token: 0x04009359 RID: 37721
		public const int UnLockFieldNumber = 2;

		// Token: 0x0400935A RID: 37722
		private bool unLock_;

		// Token: 0x0400935B RID: 37723
		public const int SlashFirstScoreFieldNumber = 3;

		// Token: 0x0400935C RID: 37724
		private int slashFirstScore_;

		// Token: 0x0400935D RID: 37725
		public const int SlashSecondScoreFieldNumber = 4;

		// Token: 0x0400935E RID: 37726
		private int slashSecondScore_;

		// Token: 0x0400935F RID: 37727
		public const int FirstBattleFieldNumber = 5;

		// Token: 0x04009360 RID: 37728
		private BattleFormation firstBattle_;

		// Token: 0x04009361 RID: 37729
		public const int SecondBattleFieldNumber = 6;

		// Token: 0x04009362 RID: 37730
		private BattleFormation secondBattle_;

		// Token: 0x04009363 RID: 37731
		public const int LevelPassFieldNumber = 7;

		// Token: 0x04009364 RID: 37732
		private bool levelPass_;

		// Token: 0x04009365 RID: 37733
		public const int IsEasyPassFieldNumber = 8;

		// Token: 0x04009366 RID: 37734
		private bool isEasyPass_;
	}
}
