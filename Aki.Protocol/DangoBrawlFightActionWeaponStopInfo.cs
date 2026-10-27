using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000356 RID: 854
	public sealed class DangoBrawlFightActionWeaponStopInfo : IMessage<DangoBrawlFightActionWeaponStopInfo>, IMessage, IEquatable<DangoBrawlFightActionWeaponStopInfo>, IDeepCloneable<DangoBrawlFightActionWeaponStopInfo>, IBufferMessage
	{
		// Token: 0x0600555D RID: 21853 RVA: 0x000D0AAD File Offset: 0x000CECAD
		[NullableContext(1)]
		public static DangoBrawlFightActionWeaponStopInfo Create()
		{
			return new DangoBrawlFightActionWeaponStopInfo();
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x0600555E RID: 21854 RVA: 0x000D0AB4 File Offset: 0x000CECB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x0600555F RID: 21855 RVA: 0x000D0AB7 File Offset: 0x000CECB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionWeaponStopInfo.Descriptor;
			}
		}

		// Token: 0x06005560 RID: 21856 RVA: 0x000D0ABE File Offset: 0x000CECBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionWeaponStopInfo()
		{
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x000D0AC6 File Offset: 0x000CECC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionWeaponStopInfo(DangoBrawlFightActionWeaponStopInfo other) : this()
		{
			this.targetFighterUId_ = other.targetFighterUId_;
			this.weaponSourceItemUid_ = other.weaponSourceItemUid_;
			this.stopMs_ = other.stopMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005562 RID: 21858 RVA: 0x000D0B03 File Offset: 0x000CED03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionWeaponStopInfo Clone()
		{
			return new DangoBrawlFightActionWeaponStopInfo(this);
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06005563 RID: 21859 RVA: 0x000D0B0B File Offset: 0x000CED0B
		// (set) Token: 0x06005564 RID: 21860 RVA: 0x000D0B13 File Offset: 0x000CED13
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

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06005565 RID: 21861 RVA: 0x000D0B1C File Offset: 0x000CED1C
		// (set) Token: 0x06005566 RID: 21862 RVA: 0x000D0B24 File Offset: 0x000CED24
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

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06005567 RID: 21863 RVA: 0x000D0B2D File Offset: 0x000CED2D
		// (set) Token: 0x06005568 RID: 21864 RVA: 0x000D0B35 File Offset: 0x000CED35
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

		// Token: 0x06005569 RID: 21865 RVA: 0x000D0B3E File Offset: 0x000CED3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionWeaponStopInfo);
		}

		// Token: 0x0600556A RID: 21866 RVA: 0x000D0B4C File Offset: 0x000CED4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionWeaponStopInfo other)
		{
			return other != null && (other == this || (this.TargetFighterUId == other.TargetFighterUId && this.WeaponSourceItemUid == other.WeaponSourceItemUid && this.StopMs == other.StopMs && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600556B RID: 21867 RVA: 0x000D0BA8 File Offset: 0x000CEDA8
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

		// Token: 0x0600556C RID: 21868 RVA: 0x000D0C19 File Offset: 0x000CEE19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600556D RID: 21869 RVA: 0x000D0C26 File Offset: 0x000CEE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600556E RID: 21870 RVA: 0x000D0C30 File Offset: 0x000CEE30
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

		// Token: 0x0600556F RID: 21871 RVA: 0x000D0CA4 File Offset: 0x000CEEA4
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

		// Token: 0x06005570 RID: 21872 RVA: 0x000D0D14 File Offset: 0x000CEF14
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

		// Token: 0x06005571 RID: 21873 RVA: 0x000D0D78 File Offset: 0x000CEF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005572 RID: 21874 RVA: 0x000D0D84 File Offset: 0x000CEF84
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

		// Token: 0x04003422 RID: 13346
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003423 RID: 13347
		public const int TargetFighterUIdFieldNumber = 1;

		// Token: 0x04003424 RID: 13348
		private int targetFighterUId_;

		// Token: 0x04003425 RID: 13349
		public const int WeaponSourceItemUidFieldNumber = 2;

		// Token: 0x04003426 RID: 13350
		private int weaponSourceItemUid_;

		// Token: 0x04003427 RID: 13351
		public const int StopMsFieldNumber = 3;

		// Token: 0x04003428 RID: 13352
		private int stopMs_;
	}
}
