using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002FB RID: 763
	public sealed class CoopRoleInfo : IMessage<CoopRoleInfo>, IMessage, IEquatable<CoopRoleInfo>, IDeepCloneable<CoopRoleInfo>, IBufferMessage
	{
		// Token: 0x06004D2D RID: 19757 RVA: 0x000BBAA8 File Offset: 0x000B9CA8
		[NullableContext(1)]
		public static CoopRoleInfo Create()
		{
			return new CoopRoleInfo();
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06004D2E RID: 19758 RVA: 0x000BBAAF File Offset: 0x000B9CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CoopRoleInfo> Parser
		{
			get
			{
				return CoopRoleInfo._parser;
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06004D2F RID: 19759 RVA: 0x000BBAB6 File Offset: 0x000B9CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06004D30 RID: 19760 RVA: 0x000BBAB9 File Offset: 0x000B9CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CoopRoleInfo.Descriptor;
			}
		}

		// Token: 0x06004D31 RID: 19761 RVA: 0x000BBAC0 File Offset: 0x000B9CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleInfo()
		{
		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x000BBAC8 File Offset: 0x000B9CC8
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

		// Token: 0x06004D33 RID: 19763 RVA: 0x000BBB1C File Offset: 0x000B9D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleInfo Clone()
		{
			return new CoopRoleInfo(this);
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06004D34 RID: 19764 RVA: 0x000BBB24 File Offset: 0x000B9D24
		// (set) Token: 0x06004D35 RID: 19765 RVA: 0x000BBB2C File Offset: 0x000B9D2C
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

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06004D36 RID: 19766 RVA: 0x000BBB35 File Offset: 0x000B9D35
		// (set) Token: 0x06004D37 RID: 19767 RVA: 0x000BBB3D File Offset: 0x000B9D3D
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

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06004D38 RID: 19768 RVA: 0x000BBB46 File Offset: 0x000B9D46
		// (set) Token: 0x06004D39 RID: 19769 RVA: 0x000BBB4E File Offset: 0x000B9D4E
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

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06004D3A RID: 19770 RVA: 0x000BBB57 File Offset: 0x000B9D57
		// (set) Token: 0x06004D3B RID: 19771 RVA: 0x000BBB5F File Offset: 0x000B9D5F
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

		// Token: 0x06004D3C RID: 19772 RVA: 0x000BBB68 File Offset: 0x000B9D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CoopRoleInfo);
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x000BBB78 File Offset: 0x000B9D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CoopRoleInfo other)
		{
			return other != null && (other == this || (this.CoopRoleId == other.CoopRoleId && this.RoleLevel == other.RoleLevel && this.RewardLevel == other.RewardLevel && this.FinishTime == other.FinishTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x000BBBE4 File Offset: 0x000B9DE4
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

		// Token: 0x06004D3F RID: 19775 RVA: 0x000BBC6E File Offset: 0x000B9E6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x000BBC7B File Offset: 0x000B9E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x000BBC84 File Offset: 0x000B9E84
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

		// Token: 0x06004D42 RID: 19778 RVA: 0x000BBD14 File Offset: 0x000B9F14
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

		// Token: 0x06004D43 RID: 19779 RVA: 0x000BBD9C File Offset: 0x000B9F9C
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

		// Token: 0x06004D44 RID: 19780 RVA: 0x000BBE14 File Offset: 0x000BA014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x000BBE20 File Offset: 0x000BA020
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

		// Token: 0x04003139 RID: 12601
		private static readonly MessageParser<CoopRoleInfo> _parser = new MessageParser<CoopRoleInfo>(() => new CoopRoleInfo());

		// Token: 0x0400313A RID: 12602
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400313B RID: 12603
		public const int CoopRoleIdFieldNumber = 1;

		// Token: 0x0400313C RID: 12604
		private int coopRoleId_;

		// Token: 0x0400313D RID: 12605
		public const int RoleLevelFieldNumber = 2;

		// Token: 0x0400313E RID: 12606
		private int roleLevel_;

		// Token: 0x0400313F RID: 12607
		public const int RewardLevelFieldNumber = 3;

		// Token: 0x04003140 RID: 12608
		private int rewardLevel_;

		// Token: 0x04003141 RID: 12609
		public const int FinishTimeFieldNumber = 4;

		// Token: 0x04003142 RID: 12610
		private long finishTime_;
	}
}
