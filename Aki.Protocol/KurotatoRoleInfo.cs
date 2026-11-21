using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A4 RID: 2212
	public sealed class KurotatoRoleInfo : IMessage<KurotatoRoleInfo>, IMessage, IEquatable<KurotatoRoleInfo>, IDeepCloneable<KurotatoRoleInfo>, IBufferMessage
	{
		// Token: 0x0600C4A9 RID: 50345 RVA: 0x001D21D1 File Offset: 0x001D03D1
		[NullableContext(1)]
		public static KurotatoRoleInfo Create()
		{
			return new KurotatoRoleInfo();
		}

		// Token: 0x170027B7 RID: 10167
		// (get) Token: 0x0600C4AA RID: 50346 RVA: 0x001D21D8 File Offset: 0x001D03D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KurotatoRoleInfo> Parser
		{
			get
			{
				return KurotatoRoleInfo._parser;
			}
		}

		// Token: 0x170027B8 RID: 10168
		// (get) Token: 0x0600C4AB RID: 50347 RVA: 0x001D21DF File Offset: 0x001D03DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027B9 RID: 10169
		// (get) Token: 0x0600C4AC RID: 50348 RVA: 0x001D21E2 File Offset: 0x001D03E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoRoleInfo.Descriptor;
			}
		}

		// Token: 0x0600C4AD RID: 50349 RVA: 0x001D21E9 File Offset: 0x001D03E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleInfo()
		{
		}

		// Token: 0x0600C4AE RID: 50350 RVA: 0x001D21F4 File Offset: 0x001D03F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleInfo(KurotatoRoleInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.isUnlock_ = other.isUnlock_;
			this.maxFinishWave_ = other.maxFinishWave_;
			this.instData_ = ((other.instData_ != null) ? other.instData_.Clone() : null);
			this.killCount_ = other.killCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C4AF RID: 50351 RVA: 0x001D2264 File Offset: 0x001D0464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleInfo Clone()
		{
			return new KurotatoRoleInfo(this);
		}

		// Token: 0x170027BA RID: 10170
		// (get) Token: 0x0600C4B0 RID: 50352 RVA: 0x001D226C File Offset: 0x001D046C
		// (set) Token: 0x0600C4B1 RID: 50353 RVA: 0x001D2274 File Offset: 0x001D0474
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

		// Token: 0x170027BB RID: 10171
		// (get) Token: 0x0600C4B2 RID: 50354 RVA: 0x001D227D File Offset: 0x001D047D
		// (set) Token: 0x0600C4B3 RID: 50355 RVA: 0x001D2285 File Offset: 0x001D0485
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

		// Token: 0x170027BC RID: 10172
		// (get) Token: 0x0600C4B4 RID: 50356 RVA: 0x001D228E File Offset: 0x001D048E
		// (set) Token: 0x0600C4B5 RID: 50357 RVA: 0x001D2296 File Offset: 0x001D0496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxFinishWave
		{
			get
			{
				return this.maxFinishWave_;
			}
			set
			{
				this.maxFinishWave_ = value;
			}
		}

		// Token: 0x170027BD RID: 10173
		// (get) Token: 0x0600C4B6 RID: 50358 RVA: 0x001D229F File Offset: 0x001D049F
		// (set) Token: 0x0600C4B7 RID: 50359 RVA: 0x001D22A7 File Offset: 0x001D04A7
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

		// Token: 0x170027BE RID: 10174
		// (get) Token: 0x0600C4B8 RID: 50360 RVA: 0x001D22B0 File Offset: 0x001D04B0
		// (set) Token: 0x0600C4B9 RID: 50361 RVA: 0x001D22B8 File Offset: 0x001D04B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int KillCount
		{
			get
			{
				return this.killCount_;
			}
			set
			{
				this.killCount_ = value;
			}
		}

		// Token: 0x0600C4BA RID: 50362 RVA: 0x001D22C1 File Offset: 0x001D04C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoRoleInfo);
		}

		// Token: 0x0600C4BB RID: 50363 RVA: 0x001D22D0 File Offset: 0x001D04D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoRoleInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.IsUnlock == other.IsUnlock && this.MaxFinishWave == other.MaxFinishWave && object.Equals(this.InstData, other.InstData) && this.KillCount == other.KillCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C4BC RID: 50364 RVA: 0x001D2350 File Offset: 0x001D0550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.MaxFinishWave != 0)
			{
				num ^= this.MaxFinishWave.GetHashCode();
			}
			if (this.instData_ != null)
			{
				num ^= this.InstData.GetHashCode();
			}
			if (this.KillCount != 0)
			{
				num ^= this.KillCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C4BD RID: 50365 RVA: 0x001D23F0 File Offset: 0x001D05F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C4BE RID: 50366 RVA: 0x001D23FD File Offset: 0x001D05FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C4BF RID: 50367 RVA: 0x001D2408 File Offset: 0x001D0608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnlock);
			}
			if (this.MaxFinishWave != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MaxFinishWave);
			}
			if (this.instData_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.InstData);
			}
			if (this.KillCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.KillCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C4C0 RID: 50368 RVA: 0x001D24B4 File Offset: 0x001D06B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.MaxFinishWave != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxFinishWave);
			}
			if (this.instData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InstData);
			}
			if (this.KillCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KillCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C4C1 RID: 50369 RVA: 0x001D2548 File Offset: 0x001D0748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoRoleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.MaxFinishWave != 0)
			{
				this.MaxFinishWave = other.MaxFinishWave;
			}
			if (other.instData_ != null)
			{
				if (this.instData_ == null)
				{
					this.InstData = new KurotatoInstInfo();
				}
				this.InstData.MergeFrom(other.InstData);
			}
			if (other.KillCount != 0)
			{
				this.KillCount = other.KillCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C4C2 RID: 50370 RVA: 0x001D25EC File Offset: 0x001D07EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C4C3 RID: 50371 RVA: 0x001D25F8 File Offset: 0x001D07F8
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
						this.RoleId = input.ReadInt32();
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
						this.MaxFinishWave = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						if (this.instData_ == null)
						{
							this.InstData = new KurotatoInstInfo();
						}
						input.ReadMessage(this.InstData);
						continue;
					}
					if (num == 40U)
					{
						this.KillCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400550F RID: 21775
		private static readonly MessageParser<KurotatoRoleInfo> _parser = new MessageParser<KurotatoRoleInfo>(() => new KurotatoRoleInfo());

		// Token: 0x04005510 RID: 21776
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005511 RID: 21777
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04005512 RID: 21778
		private int roleId_;

		// Token: 0x04005513 RID: 21779
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x04005514 RID: 21780
		private bool isUnlock_;

		// Token: 0x04005515 RID: 21781
		public const int MaxFinishWaveFieldNumber = 3;

		// Token: 0x04005516 RID: 21782
		private int maxFinishWave_;

		// Token: 0x04005517 RID: 21783
		public const int InstDataFieldNumber = 4;

		// Token: 0x04005518 RID: 21784
		private KurotatoInstInfo instData_;

		// Token: 0x04005519 RID: 21785
		public const int KillCountFieldNumber = 5;

		// Token: 0x0400551A RID: 21786
		private int killCount_;
	}
}
