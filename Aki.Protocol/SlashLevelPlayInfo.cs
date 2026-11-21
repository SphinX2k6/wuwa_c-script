using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001292 RID: 4754
	public sealed class SlashLevelPlayInfo : IMessage<SlashLevelPlayInfo>, IMessage, IEquatable<SlashLevelPlayInfo>, IDeepCloneable<SlashLevelPlayInfo>, IBufferMessage
	{
		// Token: 0x060195F3 RID: 103923 RVA: 0x003B327C File Offset: 0x003B147C
		[NullableContext(1)]
		public static SlashLevelPlayInfo Create()
		{
			return new SlashLevelPlayInfo();
		}

		// Token: 0x170055CE RID: 21966
		// (get) Token: 0x060195F4 RID: 103924 RVA: 0x003B3283 File Offset: 0x003B1483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SlashLevelPlayInfo> Parser
		{
			get
			{
				return SlashLevelPlayInfo._parser;
			}
		}

		// Token: 0x170055CF RID: 21967
		// (get) Token: 0x060195F5 RID: 103925 RVA: 0x003B328A File Offset: 0x003B148A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055D0 RID: 21968
		// (get) Token: 0x060195F6 RID: 103926 RVA: 0x003B328D File Offset: 0x003B148D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashLevelPlayInfo.Descriptor;
			}
		}

		// Token: 0x060195F7 RID: 103927 RVA: 0x003B3294 File Offset: 0x003B1494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashLevelPlayInfo()
		{
		}

		// Token: 0x060195F8 RID: 103928 RVA: 0x003B329C File Offset: 0x003B149C
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

		// Token: 0x060195F9 RID: 103929 RVA: 0x003B3340 File Offset: 0x003B1540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashLevelPlayInfo Clone()
		{
			return new SlashLevelPlayInfo(this);
		}

		// Token: 0x170055D1 RID: 21969
		// (get) Token: 0x060195FA RID: 103930 RVA: 0x003B3348 File Offset: 0x003B1548
		// (set) Token: 0x060195FB RID: 103931 RVA: 0x003B3350 File Offset: 0x003B1550
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

		// Token: 0x170055D2 RID: 21970
		// (get) Token: 0x060195FC RID: 103932 RVA: 0x003B3359 File Offset: 0x003B1559
		// (set) Token: 0x060195FD RID: 103933 RVA: 0x003B3361 File Offset: 0x003B1561
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

		// Token: 0x170055D3 RID: 21971
		// (get) Token: 0x060195FE RID: 103934 RVA: 0x003B336A File Offset: 0x003B156A
		// (set) Token: 0x060195FF RID: 103935 RVA: 0x003B3372 File Offset: 0x003B1572
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

		// Token: 0x170055D4 RID: 21972
		// (get) Token: 0x06019600 RID: 103936 RVA: 0x003B337B File Offset: 0x003B157B
		// (set) Token: 0x06019601 RID: 103937 RVA: 0x003B3383 File Offset: 0x003B1583
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

		// Token: 0x170055D5 RID: 21973
		// (get) Token: 0x06019602 RID: 103938 RVA: 0x003B338C File Offset: 0x003B158C
		// (set) Token: 0x06019603 RID: 103939 RVA: 0x003B3394 File Offset: 0x003B1594
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

		// Token: 0x170055D6 RID: 21974
		// (get) Token: 0x06019604 RID: 103940 RVA: 0x003B339D File Offset: 0x003B159D
		// (set) Token: 0x06019605 RID: 103941 RVA: 0x003B33A5 File Offset: 0x003B15A5
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

		// Token: 0x170055D7 RID: 21975
		// (get) Token: 0x06019606 RID: 103942 RVA: 0x003B33AE File Offset: 0x003B15AE
		// (set) Token: 0x06019607 RID: 103943 RVA: 0x003B33B6 File Offset: 0x003B15B6
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

		// Token: 0x170055D8 RID: 21976
		// (get) Token: 0x06019608 RID: 103944 RVA: 0x003B33BF File Offset: 0x003B15BF
		// (set) Token: 0x06019609 RID: 103945 RVA: 0x003B33C7 File Offset: 0x003B15C7
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

		// Token: 0x0601960A RID: 103946 RVA: 0x003B33D0 File Offset: 0x003B15D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashLevelPlayInfo);
		}

		// Token: 0x0601960B RID: 103947 RVA: 0x003B33E0 File Offset: 0x003B15E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashLevelPlayInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.UnLock == other.UnLock && this.SlashFirstScore == other.SlashFirstScore && this.SlashSecondScore == other.SlashSecondScore && object.Equals(this.FirstBattle, other.FirstBattle) && object.Equals(this.SecondBattle, other.SecondBattle) && this.LevelPass == other.LevelPass && this.IsEasyPass == other.IsEasyPass && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601960C RID: 103948 RVA: 0x003B3494 File Offset: 0x003B1694
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

		// Token: 0x0601960D RID: 103949 RVA: 0x003B357C File Offset: 0x003B177C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601960E RID: 103950 RVA: 0x003B3589 File Offset: 0x003B1789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601960F RID: 103951 RVA: 0x003B3594 File Offset: 0x003B1794
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

		// Token: 0x06019610 RID: 103952 RVA: 0x003B3694 File Offset: 0x003B1894
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

		// Token: 0x06019611 RID: 103953 RVA: 0x003B3758 File Offset: 0x003B1958
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

		// Token: 0x06019612 RID: 103954 RVA: 0x003B3850 File Offset: 0x003B1A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019613 RID: 103955 RVA: 0x003B385C File Offset: 0x003B1A5C
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

		// Token: 0x04009607 RID: 38407
		private static readonly MessageParser<SlashLevelPlayInfo> _parser = new MessageParser<SlashLevelPlayInfo>(() => new SlashLevelPlayInfo());

		// Token: 0x04009608 RID: 38408
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009609 RID: 38409
		public const int IdFieldNumber = 1;

		// Token: 0x0400960A RID: 38410
		private int id_;

		// Token: 0x0400960B RID: 38411
		public const int UnLockFieldNumber = 2;

		// Token: 0x0400960C RID: 38412
		private bool unLock_;

		// Token: 0x0400960D RID: 38413
		public const int SlashFirstScoreFieldNumber = 3;

		// Token: 0x0400960E RID: 38414
		private int slashFirstScore_;

		// Token: 0x0400960F RID: 38415
		public const int SlashSecondScoreFieldNumber = 4;

		// Token: 0x04009610 RID: 38416
		private int slashSecondScore_;

		// Token: 0x04009611 RID: 38417
		public const int FirstBattleFieldNumber = 5;

		// Token: 0x04009612 RID: 38418
		private BattleFormation firstBattle_;

		// Token: 0x04009613 RID: 38419
		public const int SecondBattleFieldNumber = 6;

		// Token: 0x04009614 RID: 38420
		private BattleFormation secondBattle_;

		// Token: 0x04009615 RID: 38421
		public const int LevelPassFieldNumber = 7;

		// Token: 0x04009616 RID: 38422
		private bool levelPass_;

		// Token: 0x04009617 RID: 38423
		public const int IsEasyPassFieldNumber = 8;

		// Token: 0x04009618 RID: 38424
		private bool isEasyPass_;
	}
}
