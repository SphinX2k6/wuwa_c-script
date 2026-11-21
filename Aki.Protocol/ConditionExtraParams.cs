using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002CF RID: 719
	public sealed class ConditionExtraParams : IMessage<ConditionExtraParams>, IMessage, IEquatable<ConditionExtraParams>, IDeepCloneable<ConditionExtraParams>, IBufferMessage
	{
		// Token: 0x060049F6 RID: 18934 RVA: 0x000B52AE File Offset: 0x000B34AE
		[NullableContext(1)]
		public static ConditionExtraParams Create()
		{
			return new ConditionExtraParams();
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x060049F7 RID: 18935 RVA: 0x000B52B5 File Offset: 0x000B34B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x060049F8 RID: 18936 RVA: 0x000B52B8 File Offset: 0x000B34B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConditionExtraParams.Descriptor;
			}
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x000B52BF File Offset: 0x000B34BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionExtraParams()
		{
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x000B52C8 File Offset: 0x000B34C8
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

		// Token: 0x060049FB RID: 18939 RVA: 0x000B5354 File Offset: 0x000B3554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionExtraParams Clone()
		{
			return new ConditionExtraParams(this);
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x060049FC RID: 18940 RVA: 0x000B535C File Offset: 0x000B355C
		// (set) Token: 0x060049FD RID: 18941 RVA: 0x000B5364 File Offset: 0x000B3564
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

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x060049FE RID: 18942 RVA: 0x000B536D File Offset: 0x000B356D
		// (set) Token: 0x060049FF RID: 18943 RVA: 0x000B5375 File Offset: 0x000B3575
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

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x06004A00 RID: 18944 RVA: 0x000B537E File Offset: 0x000B357E
		// (set) Token: 0x06004A01 RID: 18945 RVA: 0x000B5386 File Offset: 0x000B3586
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

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x06004A02 RID: 18946 RVA: 0x000B538F File Offset: 0x000B358F
		// (set) Token: 0x06004A03 RID: 18947 RVA: 0x000B5397 File Offset: 0x000B3597
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

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06004A04 RID: 18948 RVA: 0x000B53A0 File Offset: 0x000B35A0
		// (set) Token: 0x06004A05 RID: 18949 RVA: 0x000B53A8 File Offset: 0x000B35A8
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

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06004A06 RID: 18950 RVA: 0x000B53B1 File Offset: 0x000B35B1
		// (set) Token: 0x06004A07 RID: 18951 RVA: 0x000B53B9 File Offset: 0x000B35B9
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

		// Token: 0x06004A08 RID: 18952 RVA: 0x000B53C2 File Offset: 0x000B35C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConditionExtraParams);
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x000B53D0 File Offset: 0x000B35D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConditionExtraParams other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.RogueSeasonId == other.RogueSeasonId && object.Equals(this.InstRogueRoomInfo, other.InstRogueRoomInfo) && object.Equals(this.SeasonRogueRoomInfo, other.SeasonRogueRoomInfo) && this.MiracleCreationId == other.MiracleCreationId && this.PhantomLevel == other.PhantomLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x000B5464 File Offset: 0x000B3664
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

		// Token: 0x06004A0B RID: 18955 RVA: 0x000B551A File Offset: 0x000B371A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004A0C RID: 18956 RVA: 0x000B5527 File Offset: 0x000B3727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A0D RID: 18957 RVA: 0x000B5530 File Offset: 0x000B3730
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

		// Token: 0x06004A0E RID: 18958 RVA: 0x000B55F8 File Offset: 0x000B37F8
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

		// Token: 0x06004A0F RID: 18959 RVA: 0x000B56B0 File Offset: 0x000B38B0
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

		// Token: 0x06004A10 RID: 18960 RVA: 0x000B5780 File Offset: 0x000B3980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A11 RID: 18961 RVA: 0x000B578C File Offset: 0x000B398C
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

		// Token: 0x040030A7 RID: 12455
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030A8 RID: 12456
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040030A9 RID: 12457
		private int roleId_;

		// Token: 0x040030AA RID: 12458
		public const int RogueSeasonIdFieldNumber = 2;

		// Token: 0x040030AB RID: 12459
		private int rogueSeasonId_;

		// Token: 0x040030AC RID: 12460
		public const int InstRogueRoomInfoFieldNumber = 3;

		// Token: 0x040030AD RID: 12461
		private RogueRoomInfo instRogueRoomInfo_;

		// Token: 0x040030AE RID: 12462
		public const int SeasonRogueRoomInfoFieldNumber = 4;

		// Token: 0x040030AF RID: 12463
		private RogueRoomInfo seasonRogueRoomInfo_;

		// Token: 0x040030B0 RID: 12464
		public const int MiracleCreationIdFieldNumber = 5;

		// Token: 0x040030B1 RID: 12465
		private int miracleCreationId_;

		// Token: 0x040030B2 RID: 12466
		public const int PhantomLevelFieldNumber = 6;

		// Token: 0x040030B3 RID: 12467
		private int phantomLevel_;
	}
}
