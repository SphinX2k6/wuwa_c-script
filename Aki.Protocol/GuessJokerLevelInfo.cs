using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000720 RID: 1824
	public sealed class GuessJokerLevelInfo : IMessage<GuessJokerLevelInfo>, IMessage, IEquatable<GuessJokerLevelInfo>, IDeepCloneable<GuessJokerLevelInfo>, IBufferMessage
	{
		// Token: 0x0600A5C2 RID: 42434 RVA: 0x0018FE7C File Offset: 0x0018E07C
		[NullableContext(1)]
		public static GuessJokerLevelInfo Create()
		{
			return new GuessJokerLevelInfo();
		}

		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x0600A5C3 RID: 42435 RVA: 0x0018FE83 File Offset: 0x0018E083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuessJokerLevelInfo> Parser
		{
			get
			{
				return GuessJokerLevelInfo._parser;
			}
		}

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x0600A5C4 RID: 42436 RVA: 0x0018FE8A File Offset: 0x0018E08A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x0600A5C5 RID: 42437 RVA: 0x0018FE8D File Offset: 0x0018E08D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuessJokerLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600A5C6 RID: 42438 RVA: 0x0018FE94 File Offset: 0x0018E094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuessJokerLevelInfo()
		{
		}

		// Token: 0x0600A5C7 RID: 42439 RVA: 0x0018FE9C File Offset: 0x0018E09C
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

		// Token: 0x0600A5C8 RID: 42440 RVA: 0x0018FEFC File Offset: 0x0018E0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuessJokerLevelInfo Clone()
		{
			return new GuessJokerLevelInfo(this);
		}

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x0600A5C9 RID: 42441 RVA: 0x0018FF04 File Offset: 0x0018E104
		// (set) Token: 0x0600A5CA RID: 42442 RVA: 0x0018FF0C File Offset: 0x0018E10C
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

		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x0600A5CB RID: 42443 RVA: 0x0018FF15 File Offset: 0x0018E115
		// (set) Token: 0x0600A5CC RID: 42444 RVA: 0x0018FF1D File Offset: 0x0018E11D
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

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x0600A5CD RID: 42445 RVA: 0x0018FF26 File Offset: 0x0018E126
		// (set) Token: 0x0600A5CE RID: 42446 RVA: 0x0018FF2E File Offset: 0x0018E12E
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

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x0600A5CF RID: 42447 RVA: 0x0018FF37 File Offset: 0x0018E137
		// (set) Token: 0x0600A5D0 RID: 42448 RVA: 0x0018FF3F File Offset: 0x0018E13F
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

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x0600A5D1 RID: 42449 RVA: 0x0018FF48 File Offset: 0x0018E148
		// (set) Token: 0x0600A5D2 RID: 42450 RVA: 0x0018FF50 File Offset: 0x0018E150
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

		// Token: 0x0600A5D3 RID: 42451 RVA: 0x0018FF59 File Offset: 0x0018E159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuessJokerLevelInfo);
		}

		// Token: 0x0600A5D4 RID: 42452 RVA: 0x0018FF68 File Offset: 0x0018E168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuessJokerLevelInfo other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.LevelPass == other.LevelPass && this.UnLock == other.UnLock && this.RewardGet == other.RewardGet && this.PlayerWin == other.PlayerWin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A5D5 RID: 42453 RVA: 0x0018FFE4 File Offset: 0x0018E1E4
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

		// Token: 0x0600A5D6 RID: 42454 RVA: 0x00190087 File Offset: 0x0018E287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A5D7 RID: 42455 RVA: 0x00190094 File Offset: 0x0018E294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A5D8 RID: 42456 RVA: 0x001900A0 File Offset: 0x0018E2A0
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

		// Token: 0x0600A5D9 RID: 42457 RVA: 0x0019014C File Offset: 0x0018E34C
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

		// Token: 0x0600A5DA RID: 42458 RVA: 0x001901BC File Offset: 0x0018E3BC
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

		// Token: 0x0600A5DB RID: 42459 RVA: 0x00190248 File Offset: 0x0018E448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A5DC RID: 42460 RVA: 0x00190254 File Offset: 0x0018E454
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

		// Token: 0x04004C2D RID: 19501
		private static readonly MessageParser<GuessJokerLevelInfo> _parser = new MessageParser<GuessJokerLevelInfo>(() => new GuessJokerLevelInfo());

		// Token: 0x04004C2E RID: 19502
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C2F RID: 19503
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04004C30 RID: 19504
		private int levelId_;

		// Token: 0x04004C31 RID: 19505
		public const int LevelPassFieldNumber = 2;

		// Token: 0x04004C32 RID: 19506
		private bool levelPass_;

		// Token: 0x04004C33 RID: 19507
		public const int UnLockFieldNumber = 3;

		// Token: 0x04004C34 RID: 19508
		private bool unLock_;

		// Token: 0x04004C35 RID: 19509
		public const int RewardGetFieldNumber = 4;

		// Token: 0x04004C36 RID: 19510
		private bool rewardGet_;

		// Token: 0x04004C37 RID: 19511
		public const int PlayerWinFieldNumber = 5;

		// Token: 0x04004C38 RID: 19512
		private bool playerWin_;
	}
}
