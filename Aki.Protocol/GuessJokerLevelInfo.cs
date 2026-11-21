using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200070C RID: 1804
	public sealed class GuessJokerLevelInfo : IMessage<GuessJokerLevelInfo>, IMessage, IEquatable<GuessJokerLevelInfo>, IDeepCloneable<GuessJokerLevelInfo>, IBufferMessage
	{
		// Token: 0x0600A46C RID: 42092 RVA: 0x0018D448 File Offset: 0x0018B648
		[NullableContext(1)]
		public static GuessJokerLevelInfo Create()
		{
			return new GuessJokerLevelInfo();
		}

		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x0600A46D RID: 42093 RVA: 0x0018D44F File Offset: 0x0018B64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuessJokerLevelInfo> Parser
		{
			get
			{
				return GuessJokerLevelInfo._parser;
			}
		}

		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x0600A46E RID: 42094 RVA: 0x0018D456 File Offset: 0x0018B656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x0600A46F RID: 42095 RVA: 0x0018D459 File Offset: 0x0018B659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuessJokerLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600A470 RID: 42096 RVA: 0x0018D460 File Offset: 0x0018B660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuessJokerLevelInfo()
		{
		}

		// Token: 0x0600A471 RID: 42097 RVA: 0x0018D468 File Offset: 0x0018B668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuessJokerLevelInfo(GuessJokerLevelInfo other) : this()
		{
			this.levelId_ = other.levelId_;
			this.levelPass_ = other.levelPass_;
			this.unLock_ = other.unLock_;
			this.rewardGet_ = other.rewardGet_;
			this.playerWin_ = other.playerWin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A472 RID: 42098 RVA: 0x0018D4C8 File Offset: 0x0018B6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuessJokerLevelInfo Clone()
		{
			return new GuessJokerLevelInfo(this);
		}

		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x0600A473 RID: 42099 RVA: 0x0018D4D0 File Offset: 0x0018B6D0
		// (set) Token: 0x0600A474 RID: 42100 RVA: 0x0018D4D8 File Offset: 0x0018B6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x0600A475 RID: 42101 RVA: 0x0018D4E1 File Offset: 0x0018B6E1
		// (set) Token: 0x0600A476 RID: 42102 RVA: 0x0018D4E9 File Offset: 0x0018B6E9
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

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x0600A477 RID: 42103 RVA: 0x0018D4F2 File Offset: 0x0018B6F2
		// (set) Token: 0x0600A478 RID: 42104 RVA: 0x0018D4FA File Offset: 0x0018B6FA
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

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x0600A479 RID: 42105 RVA: 0x0018D503 File Offset: 0x0018B703
		// (set) Token: 0x0600A47A RID: 42106 RVA: 0x0018D50B File Offset: 0x0018B70B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool RewardGet
		{
			get
			{
				return this.rewardGet_;
			}
			set
			{
				this.rewardGet_ = value;
			}
		}

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x0600A47B RID: 42107 RVA: 0x0018D514 File Offset: 0x0018B714
		// (set) Token: 0x0600A47C RID: 42108 RVA: 0x0018D51C File Offset: 0x0018B71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PlayerWin
		{
			get
			{
				return this.playerWin_;
			}
			set
			{
				this.playerWin_ = value;
			}
		}

		// Token: 0x0600A47D RID: 42109 RVA: 0x0018D525 File Offset: 0x0018B725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuessJokerLevelInfo);
		}

		// Token: 0x0600A47E RID: 42110 RVA: 0x0018D534 File Offset: 0x0018B734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuessJokerLevelInfo other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.LevelPass == other.LevelPass && this.UnLock == other.UnLock && this.RewardGet == other.RewardGet && this.PlayerWin == other.PlayerWin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A47F RID: 42111 RVA: 0x0018D5B0 File Offset: 0x0018B7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.LevelPass)
			{
				num ^= this.LevelPass.GetHashCode();
			}
			if (this.UnLock)
			{
				num ^= this.UnLock.GetHashCode();
			}
			if (this.RewardGet)
			{
				num ^= this.RewardGet.GetHashCode();
			}
			if (this.PlayerWin)
			{
				num ^= this.PlayerWin.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A480 RID: 42112 RVA: 0x0018D653 File Offset: 0x0018B853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A481 RID: 42113 RVA: 0x0018D660 File Offset: 0x0018B860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A482 RID: 42114 RVA: 0x0018D66C File Offset: 0x0018B86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.LevelPass)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.LevelPass);
			}
			if (this.UnLock)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.UnLock);
			}
			if (this.RewardGet)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.RewardGet);
			}
			if (this.PlayerWin)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.PlayerWin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A483 RID: 42115 RVA: 0x0018D718 File Offset: 0x0018B918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.LevelPass)
			{
				num += 2;
			}
			if (this.UnLock)
			{
				num += 2;
			}
			if (this.RewardGet)
			{
				num += 2;
			}
			if (this.PlayerWin)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A484 RID: 42116 RVA: 0x0018D788 File Offset: 0x0018B988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GuessJokerLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.LevelPass)
			{
				this.LevelPass = other.LevelPass;
			}
			if (other.UnLock)
			{
				this.UnLock = other.UnLock;
			}
			if (other.RewardGet)
			{
				this.RewardGet = other.RewardGet;
			}
			if (other.PlayerWin)
			{
				this.PlayerWin = other.PlayerWin;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A485 RID: 42117 RVA: 0x0018D814 File Offset: 0x0018BA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A486 RID: 42118 RVA: 0x0018D820 File Offset: 0x0018BA20
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.LevelId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LevelPass = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.UnLock = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.RewardGet = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.PlayerWin = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004C26 RID: 19494
		private static readonly MessageParser<GuessJokerLevelInfo> _parser = new MessageParser<GuessJokerLevelInfo>(() => new GuessJokerLevelInfo());

		// Token: 0x04004C27 RID: 19495
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C28 RID: 19496
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04004C29 RID: 19497
		private int levelId_;

		// Token: 0x04004C2A RID: 19498
		public const int LevelPassFieldNumber = 2;

		// Token: 0x04004C2B RID: 19499
		private bool levelPass_;

		// Token: 0x04004C2C RID: 19500
		public const int UnLockFieldNumber = 3;

		// Token: 0x04004C2D RID: 19501
		private bool unLock_;

		// Token: 0x04004C2E RID: 19502
		public const int RewardGetFieldNumber = 4;

		// Token: 0x04004C2F RID: 19503
		private bool rewardGet_;

		// Token: 0x04004C30 RID: 19504
		public const int PlayerWinFieldNumber = 5;

		// Token: 0x04004C31 RID: 19505
		private bool playerWin_;
	}
}
