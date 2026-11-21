using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200035E RID: 862
	public sealed class DangoBrawlFightActionWeaponStopInfo : IMessage<DangoBrawlFightActionWeaponStopInfo>, IMessage, IEquatable<DangoBrawlFightActionWeaponStopInfo>, IDeepCloneable<DangoBrawlFightActionWeaponStopInfo>, IBufferMessage
	{
		// Token: 0x0600564A RID: 22090 RVA: 0x000D3139 File Offset: 0x000D1339
		[NullableContext(1)]
		public static DangoBrawlFightActionWeaponStopInfo Create()
		{
			return new DangoBrawlFightActionWeaponStopInfo();
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x0600564B RID: 22091 RVA: 0x000D3140 File Offset: 0x000D1340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x0600564C RID: 22092 RVA: 0x000D3143 File Offset: 0x000D1343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionWeaponStopInfo.Descriptor;
			}
		}

		// Token: 0x0600564D RID: 22093 RVA: 0x000D314A File Offset: 0x000D134A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionWeaponStopInfo()
		{
		}

		// Token: 0x0600564E RID: 22094 RVA: 0x000D3152 File Offset: 0x000D1352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionWeaponStopInfo(DangoBrawlFightActionWeaponStopInfo other) : this()
		{
			this.targetFighterUId_ = other.targetFighterUId_;
			this.weaponSourceItemUid_ = other.weaponSourceItemUid_;
			this.stopMs_ = other.stopMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x000D318F File Offset: 0x000D138F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionWeaponStopInfo Clone()
		{
			return new DangoBrawlFightActionWeaponStopInfo(this);
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x06005650 RID: 22096 RVA: 0x000D3197 File Offset: 0x000D1397
		// (set) Token: 0x06005651 RID: 22097 RVA: 0x000D319F File Offset: 0x000D139F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetFighterUId
		{
			get
			{
				return this.targetFighterUId_;
			}
			set
			{
				this.targetFighterUId_ = value;
			}
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06005652 RID: 22098 RVA: 0x000D31A8 File Offset: 0x000D13A8
		// (set) Token: 0x06005653 RID: 22099 RVA: 0x000D31B0 File Offset: 0x000D13B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponSourceItemUid
		{
			get
			{
				return this.weaponSourceItemUid_;
			}
			set
			{
				this.weaponSourceItemUid_ = value;
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06005654 RID: 22100 RVA: 0x000D31B9 File Offset: 0x000D13B9
		// (set) Token: 0x06005655 RID: 22101 RVA: 0x000D31C1 File Offset: 0x000D13C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StopMs
		{
			get
			{
				return this.stopMs_;
			}
			set
			{
				this.stopMs_ = value;
			}
		}

		// Token: 0x06005656 RID: 22102 RVA: 0x000D31CA File Offset: 0x000D13CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionWeaponStopInfo);
		}

		// Token: 0x06005657 RID: 22103 RVA: 0x000D31D8 File Offset: 0x000D13D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionWeaponStopInfo other)
		{
			return other != null && (other == this || (this.TargetFighterUId == other.TargetFighterUId && this.WeaponSourceItemUid == other.WeaponSourceItemUid && this.StopMs == other.StopMs && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005658 RID: 22104 RVA: 0x000D3234 File Offset: 0x000D1434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetFighterUId != 0)
			{
				num ^= this.TargetFighterUId.GetHashCode();
			}
			if (this.WeaponSourceItemUid != 0)
			{
				num ^= this.WeaponSourceItemUid.GetHashCode();
			}
			if (this.StopMs != 0)
			{
				num ^= this.StopMs.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005659 RID: 22105 RVA: 0x000D32A5 File Offset: 0x000D14A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600565A RID: 22106 RVA: 0x000D32B2 File Offset: 0x000D14B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600565B RID: 22107 RVA: 0x000D32BC File Offset: 0x000D14BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetFighterUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetFighterUId);
			}
			if (this.WeaponSourceItemUid != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.WeaponSourceItemUid);
			}
			if (this.StopMs != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.StopMs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600565C RID: 22108 RVA: 0x000D3330 File Offset: 0x000D1530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetFighterUId);
			}
			if (this.WeaponSourceItemUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponSourceItemUid);
			}
			if (this.StopMs != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StopMs);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600565D RID: 22109 RVA: 0x000D33A0 File Offset: 0x000D15A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionWeaponStopInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetFighterUId != 0)
			{
				this.TargetFighterUId = other.TargetFighterUId;
			}
			if (other.WeaponSourceItemUid != 0)
			{
				this.WeaponSourceItemUid = other.WeaponSourceItemUid;
			}
			if (other.StopMs != 0)
			{
				this.StopMs = other.StopMs;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600565E RID: 22110 RVA: 0x000D3404 File Offset: 0x000D1604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600565F RID: 22111 RVA: 0x000D3410 File Offset: 0x000D1610
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.StopMs = input.ReadInt32();
						}
					}
					else
					{
						this.WeaponSourceItemUid = input.ReadInt32();
					}
				}
				else
				{
					this.TargetFighterUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040034BE RID: 13502
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034BF RID: 13503
		public const int TargetFighterUIdFieldNumber = 1;

		// Token: 0x040034C0 RID: 13504
		private int targetFighterUId_;

		// Token: 0x040034C1 RID: 13505
		public const int WeaponSourceItemUidFieldNumber = 2;

		// Token: 0x040034C2 RID: 13506
		private int weaponSourceItemUid_;

		// Token: 0x040034C3 RID: 13507
		public const int StopMsFieldNumber = 3;

		// Token: 0x040034C4 RID: 13508
		private int stopMs_;
	}
}
