using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000890 RID: 2192
	public sealed class KurotatoLevelInfo : IMessage<KurotatoLevelInfo>, IMessage, IEquatable<KurotatoLevelInfo>, IDeepCloneable<KurotatoLevelInfo>, IBufferMessage
	{
		// Token: 0x0600C328 RID: 49960 RVA: 0x001CF3ED File Offset: 0x001CD5ED
		[NullableContext(1)]
		public static KurotatoLevelInfo Create()
		{
			return new KurotatoLevelInfo();
		}

		// Token: 0x1700276E RID: 10094
		// (get) Token: 0x0600C329 RID: 49961 RVA: 0x001CF3F4 File Offset: 0x001CD5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KurotatoLevelInfo> Parser
		{
			get
			{
				return KurotatoLevelInfo._parser;
			}
		}

		// Token: 0x1700276F RID: 10095
		// (get) Token: 0x0600C32A RID: 49962 RVA: 0x001CF3FB File Offset: 0x001CD5FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002770 RID: 10096
		// (get) Token: 0x0600C32B RID: 49963 RVA: 0x001CF3FE File Offset: 0x001CD5FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600C32C RID: 49964 RVA: 0x001CF405 File Offset: 0x001CD605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelInfo()
		{
		}

		// Token: 0x0600C32D RID: 49965 RVA: 0x001CF410 File Offset: 0x001CD610
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

		// Token: 0x0600C32E RID: 49966 RVA: 0x001CF49C File Offset: 0x001CD69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelInfo Clone()
		{
			return new KurotatoLevelInfo(this);
		}

		// Token: 0x17002771 RID: 10097
		// (get) Token: 0x0600C32F RID: 49967 RVA: 0x001CF4A4 File Offset: 0x001CD6A4
		// (set) Token: 0x0600C330 RID: 49968 RVA: 0x001CF4AC File Offset: 0x001CD6AC
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

		// Token: 0x17002772 RID: 10098
		// (get) Token: 0x0600C331 RID: 49969 RVA: 0x001CF4B5 File Offset: 0x001CD6B5
		// (set) Token: 0x0600C332 RID: 49970 RVA: 0x001CF4BD File Offset: 0x001CD6BD
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

		// Token: 0x17002773 RID: 10099
		// (get) Token: 0x0600C333 RID: 49971 RVA: 0x001CF4C6 File Offset: 0x001CD6C6
		// (set) Token: 0x0600C334 RID: 49972 RVA: 0x001CF4CE File Offset: 0x001CD6CE
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

		// Token: 0x17002774 RID: 10100
		// (get) Token: 0x0600C335 RID: 49973 RVA: 0x001CF4D7 File Offset: 0x001CD6D7
		// (set) Token: 0x0600C336 RID: 49974 RVA: 0x001CF4DF File Offset: 0x001CD6DF
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

		// Token: 0x17002775 RID: 10101
		// (get) Token: 0x0600C337 RID: 49975 RVA: 0x001CF4E8 File Offset: 0x001CD6E8
		// (set) Token: 0x0600C338 RID: 49976 RVA: 0x001CF4F0 File Offset: 0x001CD6F0
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

		// Token: 0x17002776 RID: 10102
		// (get) Token: 0x0600C339 RID: 49977 RVA: 0x001CF4F9 File Offset: 0x001CD6F9
		// (set) Token: 0x0600C33A RID: 49978 RVA: 0x001CF501 File Offset: 0x001CD701
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

		// Token: 0x0600C33B RID: 49979 RVA: 0x001CF50A File Offset: 0x001CD70A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoLevelInfo);
		}

		// Token: 0x0600C33C RID: 49980 RVA: 0x001CF518 File Offset: 0x001CD718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoLevelInfo other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.IsUnlock == other.IsUnlock && this.UnlockTime == other.UnlockTime && this.IsFinished == other.IsFinished && object.Equals(this.EndlessLevelInfo, other.EndlessLevelInfo) && object.Equals(this.InstData, other.InstData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C33D RID: 49981 RVA: 0x001CF5AC File Offset: 0x001CD7AC
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

		// Token: 0x0600C33E RID: 49982 RVA: 0x001CF662 File Offset: 0x001CD862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C33F RID: 49983 RVA: 0x001CF66F File Offset: 0x001CD86F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C340 RID: 49984 RVA: 0x001CF678 File Offset: 0x001CD878
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

		// Token: 0x0600C341 RID: 49985 RVA: 0x001CF740 File Offset: 0x001CD940
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

		// Token: 0x0600C342 RID: 49986 RVA: 0x001CF7E0 File Offset: 0x001CD9E0
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

		// Token: 0x0600C343 RID: 49987 RVA: 0x001CF8B0 File Offset: 0x001CDAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C344 RID: 49988 RVA: 0x001CF8BC File Offset: 0x001CDABC
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

		// Token: 0x040054B4 RID: 21684
		private static readonly MessageParser<KurotatoLevelInfo> _parser = new MessageParser<KurotatoLevelInfo>(() => new KurotatoLevelInfo());

		// Token: 0x040054B5 RID: 21685
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054B6 RID: 21686
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040054B7 RID: 21687
		private int levelId_;

		// Token: 0x040054B8 RID: 21688
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x040054B9 RID: 21689
		private bool isUnlock_;

		// Token: 0x040054BA RID: 21690
		public const int UnlockTimeFieldNumber = 3;

		// Token: 0x040054BB RID: 21691
		private long unlockTime_;

		// Token: 0x040054BC RID: 21692
		public const int IsFinishedFieldNumber = 4;

		// Token: 0x040054BD RID: 21693
		private bool isFinished_;

		// Token: 0x040054BE RID: 21694
		public const int EndlessLevelInfoFieldNumber = 5;

		// Token: 0x040054BF RID: 21695
		private KurotatoEndlessLevelInfo endlessLevelInfo_;

		// Token: 0x040054C0 RID: 21696
		public const int InstDataFieldNumber = 8;

		// Token: 0x040054C1 RID: 21697
		private KurotatoInstInfo instData_;
	}
}
