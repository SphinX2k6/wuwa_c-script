using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA2 RID: 3490
	public sealed class PlayerTitleInfo : IMessage<PlayerTitleInfo>, IMessage, IEquatable<PlayerTitleInfo>, IDeepCloneable<PlayerTitleInfo>, IBufferMessage
	{
		// Token: 0x06012D48 RID: 77128 RVA: 0x002BFD06 File Offset: 0x002BDF06
		[NullableContext(1)]
		public static PlayerTitleInfo Create()
		{
			return new PlayerTitleInfo();
		}

		// Token: 0x17003E81 RID: 16001
		// (get) Token: 0x06012D49 RID: 77129 RVA: 0x002BFD0D File Offset: 0x002BDF0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerTitleInfo> Parser
		{
			get
			{
				return PlayerTitleInfo._parser;
			}
		}

		// Token: 0x17003E82 RID: 16002
		// (get) Token: 0x06012D4A RID: 77130 RVA: 0x002BFD14 File Offset: 0x002BDF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E83 RID: 16003
		// (get) Token: 0x06012D4B RID: 77131 RVA: 0x002BFD17 File Offset: 0x002BDF17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerTitleInfo.Descriptor;
			}
		}

		// Token: 0x06012D4C RID: 77132 RVA: 0x002BFD1E File Offset: 0x002BDF1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleInfo()
		{
		}

		// Token: 0x06012D4D RID: 77133 RVA: 0x002BFD28 File Offset: 0x002BDF28
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

		// Token: 0x06012D4E RID: 77134 RVA: 0x002BFD98 File Offset: 0x002BDF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleInfo Clone()
		{
			return new PlayerTitleInfo(this);
		}

		// Token: 0x17003E84 RID: 16004
		// (get) Token: 0x06012D4F RID: 77135 RVA: 0x002BFDA0 File Offset: 0x002BDFA0
		// (set) Token: 0x06012D50 RID: 77136 RVA: 0x002BFDA8 File Offset: 0x002BDFA8
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

		// Token: 0x17003E85 RID: 16005
		// (get) Token: 0x06012D51 RID: 77137 RVA: 0x002BFDB1 File Offset: 0x002BDFB1
		// (set) Token: 0x06012D52 RID: 77138 RVA: 0x002BFDB9 File Offset: 0x002BDFB9
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

		// Token: 0x17003E86 RID: 16006
		// (get) Token: 0x06012D53 RID: 77139 RVA: 0x002BFDC2 File Offset: 0x002BDFC2
		// (set) Token: 0x06012D54 RID: 77140 RVA: 0x002BFDCA File Offset: 0x002BDFCA
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

		// Token: 0x17003E87 RID: 16007
		// (get) Token: 0x06012D55 RID: 77141 RVA: 0x002BFDD3 File Offset: 0x002BDFD3
		// (set) Token: 0x06012D56 RID: 77142 RVA: 0x002BFDDB File Offset: 0x002BDFDB
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

		// Token: 0x17003E88 RID: 16008
		// (get) Token: 0x06012D57 RID: 77143 RVA: 0x002BFDE4 File Offset: 0x002BDFE4
		// (set) Token: 0x06012D58 RID: 77144 RVA: 0x002BFDEC File Offset: 0x002BDFEC
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

		// Token: 0x06012D59 RID: 77145 RVA: 0x002BFDF5 File Offset: 0x002BDFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerTitleInfo);
		}

		// Token: 0x06012D5A RID: 77146 RVA: 0x002BFE04 File Offset: 0x002BE004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerTitleInfo other)
		{
			return other != null && (other == this || (this.PlayerTitleId == other.PlayerTitleId && this.IsUnlock == other.IsUnlock && this.UnlockTime == other.UnlockTime && this.ExtraInfo == other.ExtraInfo && object.Equals(this.ConditionTask, other.ConditionTask) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012D5B RID: 77147 RVA: 0x002BFE84 File Offset: 0x002BE084
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

		// Token: 0x06012D5C RID: 77148 RVA: 0x002BFF24 File Offset: 0x002BE124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012D5D RID: 77149 RVA: 0x002BFF31 File Offset: 0x002BE131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012D5E RID: 77150 RVA: 0x002BFF3C File Offset: 0x002BE13C
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

		// Token: 0x06012D5F RID: 77151 RVA: 0x002BFFE8 File Offset: 0x002BE1E8
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

		// Token: 0x06012D60 RID: 77152 RVA: 0x002C007C File Offset: 0x002BE27C
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

		// Token: 0x06012D61 RID: 77153 RVA: 0x002C0120 File Offset: 0x002BE320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012D62 RID: 77154 RVA: 0x002C012C File Offset: 0x002BE32C
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

		// Token: 0x04007506 RID: 29958
		private static readonly MessageParser<PlayerTitleInfo> _parser = new MessageParser<PlayerTitleInfo>(() => new PlayerTitleInfo());

		// Token: 0x04007507 RID: 29959
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007508 RID: 29960
		public const int PlayerTitleIdFieldNumber = 1;

		// Token: 0x04007509 RID: 29961
		private int playerTitleId_;

		// Token: 0x0400750A RID: 29962
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x0400750B RID: 29963
		private bool isUnlock_;

		// Token: 0x0400750C RID: 29964
		public const int UnlockTimeFieldNumber = 3;

		// Token: 0x0400750D RID: 29965
		private long unlockTime_;

		// Token: 0x0400750E RID: 29966
		public const int ExtraInfoFieldNumber = 4;

		// Token: 0x0400750F RID: 29967
		private int extraInfo_;

		// Token: 0x04007510 RID: 29968
		public const int ConditionTaskFieldNumber = 5;

		// Token: 0x04007511 RID: 29969
		private ConditionTask conditionTask_;
	}
}
