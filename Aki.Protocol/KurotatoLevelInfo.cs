using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A1 RID: 2209
	public sealed class KurotatoLevelInfo : IMessage<KurotatoLevelInfo>, IMessage, IEquatable<KurotatoLevelInfo>, IDeepCloneable<KurotatoLevelInfo>, IBufferMessage
	{
		// Token: 0x0600C444 RID: 50244 RVA: 0x001D16D1 File Offset: 0x001CF8D1
		[NullableContext(1)]
		public static KurotatoLevelInfo Create()
		{
			return new KurotatoLevelInfo();
		}

		// Token: 0x170027AD RID: 10157
		// (get) Token: 0x0600C445 RID: 50245 RVA: 0x001D16D8 File Offset: 0x001CF8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KurotatoLevelInfo> Parser
		{
			get
			{
				return KurotatoLevelInfo._parser;
			}
		}

		// Token: 0x170027AE RID: 10158
		// (get) Token: 0x0600C446 RID: 50246 RVA: 0x001D16DF File Offset: 0x001CF8DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027AF RID: 10159
		// (get) Token: 0x0600C447 RID: 50247 RVA: 0x001D16E2 File Offset: 0x001CF8E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600C448 RID: 50248 RVA: 0x001D16E9 File Offset: 0x001CF8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelInfo()
		{
		}

		// Token: 0x0600C449 RID: 50249 RVA: 0x001D16F4 File Offset: 0x001CF8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelInfo(KurotatoLevelInfo other) : this()
		{
			this.levelId_ = other.levelId_;
			this.isUnlock_ = other.isUnlock_;
			this.unlockTime_ = other.unlockTime_;
			this.isFinished_ = other.isFinished_;
			this.endlessLevelInfo_ = ((other.endlessLevelInfo_ != null) ? other.endlessLevelInfo_.Clone() : null);
			this.instData_ = ((other.instData_ != null) ? other.instData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C44A RID: 50250 RVA: 0x001D1780 File Offset: 0x001CF980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelInfo Clone()
		{
			return new KurotatoLevelInfo(this);
		}

		// Token: 0x170027B0 RID: 10160
		// (get) Token: 0x0600C44B RID: 50251 RVA: 0x001D1788 File Offset: 0x001CF988
		// (set) Token: 0x0600C44C RID: 50252 RVA: 0x001D1790 File Offset: 0x001CF990
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

		// Token: 0x170027B1 RID: 10161
		// (get) Token: 0x0600C44D RID: 50253 RVA: 0x001D1799 File Offset: 0x001CF999
		// (set) Token: 0x0600C44E RID: 50254 RVA: 0x001D17A1 File Offset: 0x001CF9A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x170027B2 RID: 10162
		// (get) Token: 0x0600C44F RID: 50255 RVA: 0x001D17AA File Offset: 0x001CF9AA
		// (set) Token: 0x0600C450 RID: 50256 RVA: 0x001D17B2 File Offset: 0x001CF9B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x170027B3 RID: 10163
		// (get) Token: 0x0600C451 RID: 50257 RVA: 0x001D17BB File Offset: 0x001CF9BB
		// (set) Token: 0x0600C452 RID: 50258 RVA: 0x001D17C3 File Offset: 0x001CF9C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinished
		{
			get
			{
				return this.isFinished_;
			}
			set
			{
				this.isFinished_ = value;
			}
		}

		// Token: 0x170027B4 RID: 10164
		// (get) Token: 0x0600C453 RID: 50259 RVA: 0x001D17CC File Offset: 0x001CF9CC
		// (set) Token: 0x0600C454 RID: 50260 RVA: 0x001D17D4 File Offset: 0x001CF9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndlessLevelInfo EndlessLevelInfo
		{
			get
			{
				return this.endlessLevelInfo_;
			}
			set
			{
				this.endlessLevelInfo_ = value;
			}
		}

		// Token: 0x170027B5 RID: 10165
		// (get) Token: 0x0600C455 RID: 50261 RVA: 0x001D17DD File Offset: 0x001CF9DD
		// (set) Token: 0x0600C456 RID: 50262 RVA: 0x001D17E5 File Offset: 0x001CF9E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoInstInfo InstData
		{
			get
			{
				return this.instData_;
			}
			set
			{
				this.instData_ = value;
			}
		}

		// Token: 0x0600C457 RID: 50263 RVA: 0x001D17EE File Offset: 0x001CF9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoLevelInfo);
		}

		// Token: 0x0600C458 RID: 50264 RVA: 0x001D17FC File Offset: 0x001CF9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoLevelInfo other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.IsUnlock == other.IsUnlock && this.UnlockTime == other.UnlockTime && this.IsFinished == other.IsFinished && object.Equals(this.EndlessLevelInfo, other.EndlessLevelInfo) && object.Equals(this.InstData, other.InstData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C459 RID: 50265 RVA: 0x001D1890 File Offset: 0x001CFA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.IsFinished)
			{
				num ^= this.IsFinished.GetHashCode();
			}
			if (this.endlessLevelInfo_ != null)
			{
				num ^= this.EndlessLevelInfo.GetHashCode();
			}
			if (this.instData_ != null)
			{
				num ^= this.InstData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C45A RID: 50266 RVA: 0x001D1946 File Offset: 0x001CFB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C45B RID: 50267 RVA: 0x001D1953 File Offset: 0x001CFB53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C45C RID: 50268 RVA: 0x001D195C File Offset: 0x001CFB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnlock);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.IsFinished)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsFinished);
			}
			if (this.endlessLevelInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.EndlessLevelInfo);
			}
			if (this.instData_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.InstData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C45D RID: 50269 RVA: 0x001D1A24 File Offset: 0x001CFC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.IsFinished)
			{
				num += 2;
			}
			if (this.endlessLevelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EndlessLevelInfo);
			}
			if (this.instData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InstData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C45E RID: 50270 RVA: 0x001D1AC4 File Offset: 0x001CFCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.IsFinished)
			{
				this.IsFinished = other.IsFinished;
			}
			if (other.endlessLevelInfo_ != null)
			{
				if (this.endlessLevelInfo_ == null)
				{
					this.EndlessLevelInfo = new KurotatoEndlessLevelInfo();
				}
				this.EndlessLevelInfo.MergeFrom(other.EndlessLevelInfo);
			}
			if (other.instData_ != null)
			{
				if (this.instData_ == null)
				{
					this.InstData = new KurotatoInstInfo();
				}
				this.InstData.MergeFrom(other.InstData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C45F RID: 50271 RVA: 0x001D1B94 File Offset: 0x001CFD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C460 RID: 50272 RVA: 0x001D1BA0 File Offset: 0x001CFDA0
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.LevelId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsUnlock = input.ReadBool();
						continue;
					}
					if (num == 24U)
					{
						this.UnlockTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.IsFinished = input.ReadBool();
						continue;
					}
					if (num == 42U)
					{
						if (this.endlessLevelInfo_ == null)
						{
							this.EndlessLevelInfo = new KurotatoEndlessLevelInfo();
						}
						input.ReadMessage(this.EndlessLevelInfo);
						continue;
					}
					if (num == 66U)
					{
						if (this.instData_ == null)
						{
							this.InstData = new KurotatoInstInfo();
						}
						input.ReadMessage(this.InstData);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040054AD RID: 21677
		private static readonly MessageParser<KurotatoLevelInfo> _parser = new MessageParser<KurotatoLevelInfo>(() => new KurotatoLevelInfo());

		// Token: 0x040054AE RID: 21678
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054AF RID: 21679
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040054B0 RID: 21680
		private int levelId_;

		// Token: 0x040054B1 RID: 21681
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x040054B2 RID: 21682
		private bool isUnlock_;

		// Token: 0x040054B3 RID: 21683
		public const int UnlockTimeFieldNumber = 3;

		// Token: 0x040054B4 RID: 21684
		private long unlockTime_;

		// Token: 0x040054B5 RID: 21685
		public const int IsFinishedFieldNumber = 4;

		// Token: 0x040054B6 RID: 21686
		private bool isFinished_;

		// Token: 0x040054B7 RID: 21687
		public const int EndlessLevelInfoFieldNumber = 5;

		// Token: 0x040054B8 RID: 21688
		private KurotatoEndlessLevelInfo endlessLevelInfo_;

		// Token: 0x040054B9 RID: 21689
		public const int InstDataFieldNumber = 8;

		// Token: 0x040054BA RID: 21690
		private KurotatoInstInfo instData_;
	}
}
