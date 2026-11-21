using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000302 RID: 770
	public sealed class CoopRoleInfo : IMessage<CoopRoleInfo>, IMessage, IEquatable<CoopRoleInfo>, IDeepCloneable<CoopRoleInfo>, IBufferMessage
	{
		// Token: 0x06004E06 RID: 19974 RVA: 0x000BDE94 File Offset: 0x000BC094
		[NullableContext(1)]
		public static CoopRoleInfo Create()
		{
			return new CoopRoleInfo();
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06004E07 RID: 19975 RVA: 0x000BDE9B File Offset: 0x000BC09B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CoopRoleInfo> Parser
		{
			get
			{
				return CoopRoleInfo._parser;
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06004E08 RID: 19976 RVA: 0x000BDEA2 File Offset: 0x000BC0A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06004E09 RID: 19977 RVA: 0x000BDEA5 File Offset: 0x000BC0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CoopRoleInfo.Descriptor;
			}
		}

		// Token: 0x06004E0A RID: 19978 RVA: 0x000BDEAC File Offset: 0x000BC0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleInfo()
		{
		}

		// Token: 0x06004E0B RID: 19979 RVA: 0x000BDEB4 File Offset: 0x000BC0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleInfo(CoopRoleInfo other) : this()
		{
			this.coopRoleId_ = other.coopRoleId_;
			this.roleLevel_ = other.roleLevel_;
			this.rewardLevel_ = other.rewardLevel_;
			this.finishTime_ = other.finishTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E0C RID: 19980 RVA: 0x000BDF08 File Offset: 0x000BC108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleInfo Clone()
		{
			return new CoopRoleInfo(this);
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06004E0D RID: 19981 RVA: 0x000BDF10 File Offset: 0x000BC110
		// (set) Token: 0x06004E0E RID: 19982 RVA: 0x000BDF18 File Offset: 0x000BC118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CoopRoleId
		{
			get
			{
				return this.coopRoleId_;
			}
			set
			{
				this.coopRoleId_ = value;
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06004E0F RID: 19983 RVA: 0x000BDF21 File Offset: 0x000BC121
		// (set) Token: 0x06004E10 RID: 19984 RVA: 0x000BDF29 File Offset: 0x000BC129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleLevel
		{
			get
			{
				return this.roleLevel_;
			}
			set
			{
				this.roleLevel_ = value;
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06004E11 RID: 19985 RVA: 0x000BDF32 File Offset: 0x000BC132
		// (set) Token: 0x06004E12 RID: 19986 RVA: 0x000BDF3A File Offset: 0x000BC13A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardLevel
		{
			get
			{
				return this.rewardLevel_;
			}
			set
			{
				this.rewardLevel_ = value;
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06004E13 RID: 19987 RVA: 0x000BDF43 File Offset: 0x000BC143
		// (set) Token: 0x06004E14 RID: 19988 RVA: 0x000BDF4B File Offset: 0x000BC14B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FinishTime
		{
			get
			{
				return this.finishTime_;
			}
			set
			{
				this.finishTime_ = value;
			}
		}

		// Token: 0x06004E15 RID: 19989 RVA: 0x000BDF54 File Offset: 0x000BC154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CoopRoleInfo);
		}

		// Token: 0x06004E16 RID: 19990 RVA: 0x000BDF64 File Offset: 0x000BC164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CoopRoleInfo other)
		{
			return other != null && (other == this || (this.CoopRoleId == other.CoopRoleId && this.RoleLevel == other.RoleLevel && this.RewardLevel == other.RewardLevel && this.FinishTime == other.FinishTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E17 RID: 19991 RVA: 0x000BDFD0 File Offset: 0x000BC1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CoopRoleId != 0)
			{
				num ^= this.CoopRoleId.GetHashCode();
			}
			if (this.RoleLevel != 0)
			{
				num ^= this.RoleLevel.GetHashCode();
			}
			if (this.RewardLevel != 0)
			{
				num ^= this.RewardLevel.GetHashCode();
			}
			if (this.FinishTime != 0L)
			{
				num ^= this.FinishTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004E18 RID: 19992 RVA: 0x000BE05A File Offset: 0x000BC25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004E19 RID: 19993 RVA: 0x000BE067 File Offset: 0x000BC267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E1A RID: 19994 RVA: 0x000BE070 File Offset: 0x000BC270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CoopRoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CoopRoleId);
			}
			if (this.RoleLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleLevel);
			}
			if (this.RewardLevel != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RewardLevel);
			}
			if (this.FinishTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.FinishTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x000BE100 File Offset: 0x000BC300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CoopRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CoopRoleId);
			}
			if (this.RoleLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleLevel);
			}
			if (this.RewardLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardLevel);
			}
			if (this.FinishTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FinishTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004E1C RID: 19996 RVA: 0x000BE188 File Offset: 0x000BC388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CoopRoleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CoopRoleId != 0)
			{
				this.CoopRoleId = other.CoopRoleId;
			}
			if (other.RoleLevel != 0)
			{
				this.RoleLevel = other.RoleLevel;
			}
			if (other.RewardLevel != 0)
			{
				this.RewardLevel = other.RewardLevel;
			}
			if (other.FinishTime != 0L)
			{
				this.FinishTime = other.FinishTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004E1D RID: 19997 RVA: 0x000BE200 File Offset: 0x000BC400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x000BE20C File Offset: 0x000BC40C
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
						this.CoopRoleId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.RoleLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.RewardLevel = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.FinishTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040031D0 RID: 12752
		private static readonly MessageParser<CoopRoleInfo> _parser = new MessageParser<CoopRoleInfo>(() => new CoopRoleInfo());

		// Token: 0x040031D1 RID: 12753
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031D2 RID: 12754
		public const int CoopRoleIdFieldNumber = 1;

		// Token: 0x040031D3 RID: 12755
		private int coopRoleId_;

		// Token: 0x040031D4 RID: 12756
		public const int RoleLevelFieldNumber = 2;

		// Token: 0x040031D5 RID: 12757
		private int roleLevel_;

		// Token: 0x040031D6 RID: 12758
		public const int RewardLevelFieldNumber = 3;

		// Token: 0x040031D7 RID: 12759
		private int rewardLevel_;

		// Token: 0x040031D8 RID: 12760
		public const int FinishTimeFieldNumber = 4;

		// Token: 0x040031D9 RID: 12761
		private long finishTime_;
	}
}
