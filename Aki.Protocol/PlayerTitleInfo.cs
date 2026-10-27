using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB2 RID: 3506
	public sealed class PlayerTitleInfo : IMessage<PlayerTitleInfo>, IMessage, IEquatable<PlayerTitleInfo>, IDeepCloneable<PlayerTitleInfo>, IBufferMessage
	{
		// Token: 0x06012E44 RID: 77380 RVA: 0x002C192A File Offset: 0x002BFB2A
		[NullableContext(1)]
		public static PlayerTitleInfo Create()
		{
			return new PlayerTitleInfo();
		}

		// Token: 0x17003EB6 RID: 16054
		// (get) Token: 0x06012E45 RID: 77381 RVA: 0x002C1931 File Offset: 0x002BFB31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerTitleInfo> Parser
		{
			get
			{
				return PlayerTitleInfo._parser;
			}
		}

		// Token: 0x17003EB7 RID: 16055
		// (get) Token: 0x06012E46 RID: 77382 RVA: 0x002C1938 File Offset: 0x002BFB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EB8 RID: 16056
		// (get) Token: 0x06012E47 RID: 77383 RVA: 0x002C193B File Offset: 0x002BFB3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerTitleInfo.Descriptor;
			}
		}

		// Token: 0x06012E48 RID: 77384 RVA: 0x002C1942 File Offset: 0x002BFB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleInfo()
		{
		}

		// Token: 0x06012E49 RID: 77385 RVA: 0x002C194C File Offset: 0x002BFB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleInfo(PlayerTitleInfo other) : this()
		{
			this.playerTitleId_ = other.playerTitleId_;
			this.isUnlock_ = other.isUnlock_;
			this.unlockTime_ = other.unlockTime_;
			this.extraInfo_ = other.extraInfo_;
			this.conditionTask_ = ((other.conditionTask_ != null) ? other.conditionTask_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012E4A RID: 77386 RVA: 0x002C19BC File Offset: 0x002BFBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleInfo Clone()
		{
			return new PlayerTitleInfo(this);
		}

		// Token: 0x17003EB9 RID: 16057
		// (get) Token: 0x06012E4B RID: 77387 RVA: 0x002C19C4 File Offset: 0x002BFBC4
		// (set) Token: 0x06012E4C RID: 77388 RVA: 0x002C19CC File Offset: 0x002BFBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerTitleId
		{
			get
			{
				return this.playerTitleId_;
			}
			set
			{
				this.playerTitleId_ = value;
			}
		}

		// Token: 0x17003EBA RID: 16058
		// (get) Token: 0x06012E4D RID: 77389 RVA: 0x002C19D5 File Offset: 0x002BFBD5
		// (set) Token: 0x06012E4E RID: 77390 RVA: 0x002C19DD File Offset: 0x002BFBDD
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

		// Token: 0x17003EBB RID: 16059
		// (get) Token: 0x06012E4F RID: 77391 RVA: 0x002C19E6 File Offset: 0x002BFBE6
		// (set) Token: 0x06012E50 RID: 77392 RVA: 0x002C19EE File Offset: 0x002BFBEE
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

		// Token: 0x17003EBC RID: 16060
		// (get) Token: 0x06012E51 RID: 77393 RVA: 0x002C19F7 File Offset: 0x002BFBF7
		// (set) Token: 0x06012E52 RID: 77394 RVA: 0x002C19FF File Offset: 0x002BFBFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExtraInfo
		{
			get
			{
				return this.extraInfo_;
			}
			set
			{
				this.extraInfo_ = value;
			}
		}

		// Token: 0x17003EBD RID: 16061
		// (get) Token: 0x06012E53 RID: 77395 RVA: 0x002C1A08 File Offset: 0x002BFC08
		// (set) Token: 0x06012E54 RID: 77396 RVA: 0x002C1A10 File Offset: 0x002BFC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask ConditionTask
		{
			get
			{
				return this.conditionTask_;
			}
			set
			{
				this.conditionTask_ = value;
			}
		}

		// Token: 0x06012E55 RID: 77397 RVA: 0x002C1A19 File Offset: 0x002BFC19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerTitleInfo);
		}

		// Token: 0x06012E56 RID: 77398 RVA: 0x002C1A28 File Offset: 0x002BFC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerTitleInfo other)
		{
			return other != null && (other == this || (this.PlayerTitleId == other.PlayerTitleId && this.IsUnlock == other.IsUnlock && this.UnlockTime == other.UnlockTime && this.ExtraInfo == other.ExtraInfo && object.Equals(this.ConditionTask, other.ConditionTask) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012E57 RID: 77399 RVA: 0x002C1AA8 File Offset: 0x002BFCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerTitleId != 0)
			{
				num ^= this.PlayerTitleId.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.ExtraInfo != 0)
			{
				num ^= this.ExtraInfo.GetHashCode();
			}
			if (this.conditionTask_ != null)
			{
				num ^= this.ConditionTask.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012E58 RID: 77400 RVA: 0x002C1B48 File Offset: 0x002BFD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012E59 RID: 77401 RVA: 0x002C1B55 File Offset: 0x002BFD55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012E5A RID: 77402 RVA: 0x002C1B60 File Offset: 0x002BFD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerTitleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerTitleId);
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
			if (this.ExtraInfo != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ExtraInfo);
			}
			if (this.conditionTask_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ConditionTask);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012E5B RID: 77403 RVA: 0x002C1C0C File Offset: 0x002BFE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerTitleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerTitleId);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.ExtraInfo != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExtraInfo);
			}
			if (this.conditionTask_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ConditionTask);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012E5C RID: 77404 RVA: 0x002C1CA0 File Offset: 0x002BFEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerTitleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerTitleId != 0)
			{
				this.PlayerTitleId = other.PlayerTitleId;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.ExtraInfo != 0)
			{
				this.ExtraInfo = other.ExtraInfo;
			}
			if (other.conditionTask_ != null)
			{
				if (this.conditionTask_ == null)
				{
					this.ConditionTask = new ConditionTask();
				}
				this.ConditionTask.MergeFrom(other.ConditionTask);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012E5D RID: 77405 RVA: 0x002C1D44 File Offset: 0x002BFF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012E5E RID: 77406 RVA: 0x002C1D50 File Offset: 0x002BFF50
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
						this.PlayerTitleId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsUnlock = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.UnlockTime = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.ExtraInfo = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						if (this.conditionTask_ == null)
						{
							this.ConditionTask = new ConditionTask();
						}
						input.ReadMessage(this.ConditionTask);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040074EE RID: 29934
		private static readonly MessageParser<PlayerTitleInfo> _parser = new MessageParser<PlayerTitleInfo>(() => new PlayerTitleInfo());

		// Token: 0x040074EF RID: 29935
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074F0 RID: 29936
		public const int PlayerTitleIdFieldNumber = 1;

		// Token: 0x040074F1 RID: 29937
		private int playerTitleId_;

		// Token: 0x040074F2 RID: 29938
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x040074F3 RID: 29939
		private bool isUnlock_;

		// Token: 0x040074F4 RID: 29940
		public const int UnlockTimeFieldNumber = 3;

		// Token: 0x040074F5 RID: 29941
		private long unlockTime_;

		// Token: 0x040074F6 RID: 29942
		public const int ExtraInfoFieldNumber = 4;

		// Token: 0x040074F7 RID: 29943
		private int extraInfo_;

		// Token: 0x040074F8 RID: 29944
		public const int ConditionTaskFieldNumber = 5;

		// Token: 0x040074F9 RID: 29945
		private ConditionTask conditionTask_;
	}
}
