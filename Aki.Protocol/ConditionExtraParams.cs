using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C8 RID: 712
	public sealed class ConditionExtraParams : IMessage<ConditionExtraParams>, IMessage, IEquatable<ConditionExtraParams>, IDeepCloneable<ConditionExtraParams>, IBufferMessage
	{
		// Token: 0x0600491D RID: 18717 RVA: 0x000B2EC6 File Offset: 0x000B10C6
		[NullableContext(1)]
		public static ConditionExtraParams Create()
		{
			return new ConditionExtraParams();
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x0600491E RID: 18718 RVA: 0x000B2ECD File Offset: 0x000B10CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x0600491F RID: 18719 RVA: 0x000B2ED0 File Offset: 0x000B10D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConditionExtraParams.Descriptor;
			}
		}

		// Token: 0x06004920 RID: 18720 RVA: 0x000B2ED7 File Offset: 0x000B10D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionExtraParams()
		{
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x000B2EE0 File Offset: 0x000B10E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionExtraParams(ConditionExtraParams other) : this()
		{
			this.roleId_ = other.roleId_;
			this.rogueSeasonId_ = other.rogueSeasonId_;
			this.instRogueRoomInfo_ = ((other.instRogueRoomInfo_ != null) ? other.instRogueRoomInfo_.Clone() : null);
			this.seasonRogueRoomInfo_ = ((other.seasonRogueRoomInfo_ != null) ? other.seasonRogueRoomInfo_.Clone() : null);
			this.miracleCreationId_ = other.miracleCreationId_;
			this.phantomLevel_ = other.phantomLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x000B2F6C File Offset: 0x000B116C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionExtraParams Clone()
		{
			return new ConditionExtraParams(this);
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06004923 RID: 18723 RVA: 0x000B2F74 File Offset: 0x000B1174
		// (set) Token: 0x06004924 RID: 18724 RVA: 0x000B2F7C File Offset: 0x000B117C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06004925 RID: 18725 RVA: 0x000B2F85 File Offset: 0x000B1185
		// (set) Token: 0x06004926 RID: 18726 RVA: 0x000B2F8D File Offset: 0x000B118D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RogueSeasonId
		{
			get
			{
				return this.rogueSeasonId_;
			}
			set
			{
				this.rogueSeasonId_ = value;
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06004927 RID: 18727 RVA: 0x000B2F96 File Offset: 0x000B1196
		// (set) Token: 0x06004928 RID: 18728 RVA: 0x000B2F9E File Offset: 0x000B119E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoomInfo InstRogueRoomInfo
		{
			get
			{
				return this.instRogueRoomInfo_;
			}
			set
			{
				this.instRogueRoomInfo_ = value;
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06004929 RID: 18729 RVA: 0x000B2FA7 File Offset: 0x000B11A7
		// (set) Token: 0x0600492A RID: 18730 RVA: 0x000B2FAF File Offset: 0x000B11AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoomInfo SeasonRogueRoomInfo
		{
			get
			{
				return this.seasonRogueRoomInfo_;
			}
			set
			{
				this.seasonRogueRoomInfo_ = value;
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x0600492B RID: 18731 RVA: 0x000B2FB8 File Offset: 0x000B11B8
		// (set) Token: 0x0600492C RID: 18732 RVA: 0x000B2FC0 File Offset: 0x000B11C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MiracleCreationId
		{
			get
			{
				return this.miracleCreationId_;
			}
			set
			{
				this.miracleCreationId_ = value;
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x0600492D RID: 18733 RVA: 0x000B2FC9 File Offset: 0x000B11C9
		// (set) Token: 0x0600492E RID: 18734 RVA: 0x000B2FD1 File Offset: 0x000B11D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomLevel
		{
			get
			{
				return this.phantomLevel_;
			}
			set
			{
				this.phantomLevel_ = value;
			}
		}

		// Token: 0x0600492F RID: 18735 RVA: 0x000B2FDA File Offset: 0x000B11DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConditionExtraParams);
		}

		// Token: 0x06004930 RID: 18736 RVA: 0x000B2FE8 File Offset: 0x000B11E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConditionExtraParams other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.RogueSeasonId == other.RogueSeasonId && object.Equals(this.InstRogueRoomInfo, other.InstRogueRoomInfo) && object.Equals(this.SeasonRogueRoomInfo, other.SeasonRogueRoomInfo) && this.MiracleCreationId == other.MiracleCreationId && this.PhantomLevel == other.PhantomLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004931 RID: 18737 RVA: 0x000B307C File Offset: 0x000B127C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.RogueSeasonId != 0)
			{
				num ^= this.RogueSeasonId.GetHashCode();
			}
			if (this.instRogueRoomInfo_ != null)
			{
				num ^= this.InstRogueRoomInfo.GetHashCode();
			}
			if (this.seasonRogueRoomInfo_ != null)
			{
				num ^= this.SeasonRogueRoomInfo.GetHashCode();
			}
			if (this.MiracleCreationId != 0)
			{
				num ^= this.MiracleCreationId.GetHashCode();
			}
			if (this.PhantomLevel != 0)
			{
				num ^= this.PhantomLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004932 RID: 18738 RVA: 0x000B3132 File Offset: 0x000B1332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x000B313F File Offset: 0x000B133F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004934 RID: 18740 RVA: 0x000B3148 File Offset: 0x000B1348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.RogueSeasonId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RogueSeasonId);
			}
			if (this.instRogueRoomInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.InstRogueRoomInfo);
			}
			if (this.seasonRogueRoomInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.SeasonRogueRoomInfo);
			}
			if (this.MiracleCreationId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MiracleCreationId);
			}
			if (this.PhantomLevel != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PhantomLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004935 RID: 18741 RVA: 0x000B3210 File Offset: 0x000B1410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.RogueSeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RogueSeasonId);
			}
			if (this.instRogueRoomInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InstRogueRoomInfo);
			}
			if (this.seasonRogueRoomInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SeasonRogueRoomInfo);
			}
			if (this.MiracleCreationId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MiracleCreationId);
			}
			if (this.PhantomLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x000B32C8 File Offset: 0x000B14C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConditionExtraParams other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.RogueSeasonId != 0)
			{
				this.RogueSeasonId = other.RogueSeasonId;
			}
			if (other.instRogueRoomInfo_ != null)
			{
				if (this.instRogueRoomInfo_ == null)
				{
					this.InstRogueRoomInfo = new RogueRoomInfo();
				}
				this.InstRogueRoomInfo.MergeFrom(other.InstRogueRoomInfo);
			}
			if (other.seasonRogueRoomInfo_ != null)
			{
				if (this.seasonRogueRoomInfo_ == null)
				{
					this.SeasonRogueRoomInfo = new RogueRoomInfo();
				}
				this.SeasonRogueRoomInfo.MergeFrom(other.SeasonRogueRoomInfo);
			}
			if (other.MiracleCreationId != 0)
			{
				this.MiracleCreationId = other.MiracleCreationId;
			}
			if (other.PhantomLevel != 0)
			{
				this.PhantomLevel = other.PhantomLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004937 RID: 18743 RVA: 0x000B3398 File Offset: 0x000B1598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x000B33A4 File Offset: 0x000B15A4
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.RogueSeasonId = input.ReadInt32();
						continue;
					}
					if (num == 26U)
					{
						if (this.instRogueRoomInfo_ == null)
						{
							this.InstRogueRoomInfo = new RogueRoomInfo();
						}
						input.ReadMessage(this.InstRogueRoomInfo);
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						if (this.seasonRogueRoomInfo_ == null)
						{
							this.SeasonRogueRoomInfo = new RogueRoomInfo();
						}
						input.ReadMessage(this.SeasonRogueRoomInfo);
						continue;
					}
					if (num == 40U)
					{
						this.MiracleCreationId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.PhantomLevel = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003010 RID: 12304
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003011 RID: 12305
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04003012 RID: 12306
		private int roleId_;

		// Token: 0x04003013 RID: 12307
		public const int RogueSeasonIdFieldNumber = 2;

		// Token: 0x04003014 RID: 12308
		private int rogueSeasonId_;

		// Token: 0x04003015 RID: 12309
		public const int InstRogueRoomInfoFieldNumber = 3;

		// Token: 0x04003016 RID: 12310
		private RogueRoomInfo instRogueRoomInfo_;

		// Token: 0x04003017 RID: 12311
		public const int SeasonRogueRoomInfoFieldNumber = 4;

		// Token: 0x04003018 RID: 12312
		private RogueRoomInfo seasonRogueRoomInfo_;

		// Token: 0x04003019 RID: 12313
		public const int MiracleCreationIdFieldNumber = 5;

		// Token: 0x0400301A RID: 12314
		private int miracleCreationId_;

		// Token: 0x0400301B RID: 12315
		public const int PhantomLevelFieldNumber = 6;

		// Token: 0x0400301C RID: 12316
		private int phantomLevel_;
	}
}
