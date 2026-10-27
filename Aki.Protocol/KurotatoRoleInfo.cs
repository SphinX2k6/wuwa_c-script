using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B5 RID: 2229
	public sealed class KurotatoRoleInfo : IMessage<KurotatoRoleInfo>, IMessage, IEquatable<KurotatoRoleInfo>, IDeepCloneable<KurotatoRoleInfo>, IBufferMessage
	{
		// Token: 0x0600C5C5 RID: 50629 RVA: 0x001D44B9 File Offset: 0x001D26B9
		[NullableContext(1)]
		public static KurotatoRoleInfo Create()
		{
			return new KurotatoRoleInfo();
		}

		// Token: 0x170027F6 RID: 10230
		// (get) Token: 0x0600C5C6 RID: 50630 RVA: 0x001D44C0 File Offset: 0x001D26C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KurotatoRoleInfo> Parser
		{
			get
			{
				return KurotatoRoleInfo._parser;
			}
		}

		// Token: 0x170027F7 RID: 10231
		// (get) Token: 0x0600C5C7 RID: 50631 RVA: 0x001D44C7 File Offset: 0x001D26C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027F8 RID: 10232
		// (get) Token: 0x0600C5C8 RID: 50632 RVA: 0x001D44CA File Offset: 0x001D26CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoRoleInfo.Descriptor;
			}
		}

		// Token: 0x0600C5C9 RID: 50633 RVA: 0x001D44D1 File Offset: 0x001D26D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleInfo()
		{
		}

		// Token: 0x0600C5CA RID: 50634 RVA: 0x001D44DC File Offset: 0x001D26DC
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

		// Token: 0x0600C5CB RID: 50635 RVA: 0x001D454C File Offset: 0x001D274C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleInfo Clone()
		{
			return new KurotatoRoleInfo(this);
		}

		// Token: 0x170027F9 RID: 10233
		// (get) Token: 0x0600C5CC RID: 50636 RVA: 0x001D4554 File Offset: 0x001D2754
		// (set) Token: 0x0600C5CD RID: 50637 RVA: 0x001D455C File Offset: 0x001D275C
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

		// Token: 0x170027FA RID: 10234
		// (get) Token: 0x0600C5CE RID: 50638 RVA: 0x001D4565 File Offset: 0x001D2765
		// (set) Token: 0x0600C5CF RID: 50639 RVA: 0x001D456D File Offset: 0x001D276D
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

		// Token: 0x170027FB RID: 10235
		// (get) Token: 0x0600C5D0 RID: 50640 RVA: 0x001D4576 File Offset: 0x001D2776
		// (set) Token: 0x0600C5D1 RID: 50641 RVA: 0x001D457E File Offset: 0x001D277E
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

		// Token: 0x170027FC RID: 10236
		// (get) Token: 0x0600C5D2 RID: 50642 RVA: 0x001D4587 File Offset: 0x001D2787
		// (set) Token: 0x0600C5D3 RID: 50643 RVA: 0x001D458F File Offset: 0x001D278F
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

		// Token: 0x170027FD RID: 10237
		// (get) Token: 0x0600C5D4 RID: 50644 RVA: 0x001D4598 File Offset: 0x001D2798
		// (set) Token: 0x0600C5D5 RID: 50645 RVA: 0x001D45A0 File Offset: 0x001D27A0
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

		// Token: 0x0600C5D6 RID: 50646 RVA: 0x001D45A9 File Offset: 0x001D27A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoRoleInfo);
		}

		// Token: 0x0600C5D7 RID: 50647 RVA: 0x001D45B8 File Offset: 0x001D27B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoRoleInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.IsUnlock == other.IsUnlock && this.MaxFinishWave == other.MaxFinishWave && object.Equals(this.InstData, other.InstData) && this.KillCount == other.KillCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C5D8 RID: 50648 RVA: 0x001D4638 File Offset: 0x001D2838
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

		// Token: 0x0600C5D9 RID: 50649 RVA: 0x001D46D8 File Offset: 0x001D28D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C5DA RID: 50650 RVA: 0x001D46E5 File Offset: 0x001D28E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C5DB RID: 50651 RVA: 0x001D46F0 File Offset: 0x001D28F0
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

		// Token: 0x0600C5DC RID: 50652 RVA: 0x001D479C File Offset: 0x001D299C
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

		// Token: 0x0600C5DD RID: 50653 RVA: 0x001D4830 File Offset: 0x001D2A30
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

		// Token: 0x0600C5DE RID: 50654 RVA: 0x001D48D4 File Offset: 0x001D2AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C5DF RID: 50655 RVA: 0x001D48E0 File Offset: 0x001D2AE0
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

		// Token: 0x04005508 RID: 21768
		private static readonly MessageParser<KurotatoRoleInfo> _parser = new MessageParser<KurotatoRoleInfo>(() => new KurotatoRoleInfo());

		// Token: 0x04005509 RID: 21769
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400550A RID: 21770
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400550B RID: 21771
		private int roleId_;

		// Token: 0x0400550C RID: 21772
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x0400550D RID: 21773
		private bool isUnlock_;

		// Token: 0x0400550E RID: 21774
		public const int MaxFinishWaveFieldNumber = 3;

		// Token: 0x0400550F RID: 21775
		private int maxFinishWave_;

		// Token: 0x04005510 RID: 21776
		public const int InstDataFieldNumber = 4;

		// Token: 0x04005511 RID: 21777
		private KurotatoInstInfo instData_;

		// Token: 0x04005512 RID: 21778
		public const int KillCountFieldNumber = 5;

		// Token: 0x04005513 RID: 21779
		private int killCount_;
	}
}
