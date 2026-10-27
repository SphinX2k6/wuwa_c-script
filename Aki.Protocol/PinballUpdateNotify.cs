using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D69 RID: 3433
	[NetMessage(EMessageId.PinballUpdateNotify)]
	public sealed class PinballUpdateNotify : IMessage<PinballUpdateNotify>, IMessage, IEquatable<PinballUpdateNotify>, IDeepCloneable<PinballUpdateNotify>, IBufferMessage
	{
		// Token: 0x06012824 RID: 75812 RVA: 0x002B31AD File Offset: 0x002B13AD
		[NullableContext(1)]
		public static PinballUpdateNotify Create()
		{
			return new PinballUpdateNotify();
		}

		// Token: 0x17003D57 RID: 15703
		// (get) Token: 0x06012825 RID: 75813 RVA: 0x002B31B4 File Offset: 0x002B13B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D58 RID: 15704
		// (get) Token: 0x06012826 RID: 75814 RVA: 0x002B31B7 File Offset: 0x002B13B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06012827 RID: 75815 RVA: 0x002B31BE File Offset: 0x002B13BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballUpdateNotify()
		{
		}

		// Token: 0x06012828 RID: 75816 RVA: 0x002B31C8 File Offset: 0x002B13C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballUpdateNotify(PinballUpdateNotify other) : this()
		{
			PinballUpdateNotify.DataOneofCase dataCase = other.DataCase;
			switch (dataCase)
			{
			case PinballUpdateNotify.DataOneofCase.GroupFormation:
				this.GroupFormation = other.GroupFormation.Clone();
				break;
			case PinballUpdateNotify.DataOneofCase.ConditionTask:
				this.ConditionTask = other.ConditionTask.Clone();
				break;
			case PinballUpdateNotify.DataOneofCase.NewRole:
				this.NewRole = other.NewRole.Clone();
				break;
			default:
				if (dataCase != PinballUpdateNotify.DataOneofCase.NewWeapon)
				{
					if (dataCase == PinballUpdateNotify.DataOneofCase.LevelData)
					{
						this.LevelData = other.LevelData.Clone();
					}
				}
				else
				{
					this.NewWeapon = other.NewWeapon.Clone();
				}
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012829 RID: 75817 RVA: 0x002B3270 File Offset: 0x002B1470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballUpdateNotify Clone()
		{
			return new PinballUpdateNotify(this);
		}

		// Token: 0x17003D59 RID: 15705
		// (get) Token: 0x0601282A RID: 75818 RVA: 0x002B3278 File Offset: 0x002B1478
		// (set) Token: 0x0601282B RID: 75819 RVA: 0x002B3290 File Offset: 0x002B1490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask ConditionTask
		{
			get
			{
				if (this.dataCase_ != PinballUpdateNotify.DataOneofCase.ConditionTask)
				{
					return null;
				}
				return (ConditionTask)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? PinballUpdateNotify.DataOneofCase.None : PinballUpdateNotify.DataOneofCase.ConditionTask);
			}
		}

		// Token: 0x17003D5A RID: 15706
		// (get) Token: 0x0601282C RID: 75820 RVA: 0x002B32A6 File Offset: 0x002B14A6
		// (set) Token: 0x0601282D RID: 75821 RVA: 0x002B32BF File Offset: 0x002B14BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballLevelData LevelData
		{
			get
			{
				if (this.dataCase_ != PinballUpdateNotify.DataOneofCase.LevelData)
				{
					return null;
				}
				return (PinballLevelData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? PinballUpdateNotify.DataOneofCase.None : PinballUpdateNotify.DataOneofCase.LevelData);
			}
		}

		// Token: 0x17003D5B RID: 15707
		// (get) Token: 0x0601282E RID: 75822 RVA: 0x002B32D6 File Offset: 0x002B14D6
		// (set) Token: 0x0601282F RID: 75823 RVA: 0x002B32EF File Offset: 0x002B14EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeapons NewWeapon
		{
			get
			{
				if (this.dataCase_ != PinballUpdateNotify.DataOneofCase.NewWeapon)
				{
					return null;
				}
				return (PinballWeapons)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? PinballUpdateNotify.DataOneofCase.None : PinballUpdateNotify.DataOneofCase.NewWeapon);
			}
		}

		// Token: 0x17003D5C RID: 15708
		// (get) Token: 0x06012830 RID: 75824 RVA: 0x002B3306 File Offset: 0x002B1506
		// (set) Token: 0x06012831 RID: 75825 RVA: 0x002B331E File Offset: 0x002B151E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoles NewRole
		{
			get
			{
				if (this.dataCase_ != PinballUpdateNotify.DataOneofCase.NewRole)
				{
					return null;
				}
				return (PinballRoles)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? PinballUpdateNotify.DataOneofCase.None : PinballUpdateNotify.DataOneofCase.NewRole);
			}
		}

		// Token: 0x17003D5D RID: 15709
		// (get) Token: 0x06012832 RID: 75826 RVA: 0x002B3334 File Offset: 0x002B1534
		// (set) Token: 0x06012833 RID: 75827 RVA: 0x002B334C File Offset: 0x002B154C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupFormation GroupFormation
		{
			get
			{
				if (this.dataCase_ != PinballUpdateNotify.DataOneofCase.GroupFormation)
				{
					return null;
				}
				return (GroupFormation)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? PinballUpdateNotify.DataOneofCase.None : PinballUpdateNotify.DataOneofCase.GroupFormation);
			}
		}

		// Token: 0x17003D5E RID: 15710
		// (get) Token: 0x06012834 RID: 75828 RVA: 0x002B3362 File Offset: 0x002B1562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballUpdateNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06012835 RID: 75829 RVA: 0x002B336A File Offset: 0x002B156A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = PinballUpdateNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06012836 RID: 75830 RVA: 0x002B337A File Offset: 0x002B157A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballUpdateNotify);
		}

		// Token: 0x06012837 RID: 75831 RVA: 0x002B3388 File Offset: 0x002B1588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ConditionTask, other.ConditionTask) && object.Equals(this.LevelData, other.LevelData) && object.Equals(this.NewWeapon, other.NewWeapon) && object.Equals(this.NewRole, other.NewRole) && object.Equals(this.GroupFormation, other.GroupFormation) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012838 RID: 75832 RVA: 0x002B342C File Offset: 0x002B162C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.ConditionTask)
			{
				num ^= this.ConditionTask.GetHashCode();
			}
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.LevelData)
			{
				num ^= this.LevelData.GetHashCode();
			}
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.NewWeapon)
			{
				num ^= this.NewWeapon.GetHashCode();
			}
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.NewRole)
			{
				num ^= this.NewRole.GetHashCode();
			}
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.GroupFormation)
			{
				num ^= this.GroupFormation.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012839 RID: 75833 RVA: 0x002B34D0 File Offset: 0x002B16D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601283A RID: 75834 RVA: 0x002B34DD File Offset: 0x002B16DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601283B RID: 75835 RVA: 0x002B34E8 File Offset: 0x002B16E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.GroupFormation)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.GroupFormation);
			}
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.ConditionTask)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ConditionTask);
			}
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.NewRole)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.NewRole);
			}
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.NewWeapon)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.NewWeapon);
			}
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.LevelData)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.LevelData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601283C RID: 75836 RVA: 0x002B359C File Offset: 0x002B179C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.ConditionTask)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ConditionTask);
			}
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.LevelData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LevelData);
			}
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.NewWeapon)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewWeapon);
			}
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.NewRole)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewRole);
			}
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.GroupFormation)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GroupFormation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601283D RID: 75837 RVA: 0x002B3644 File Offset: 0x002B1844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			PinballUpdateNotify.DataOneofCase dataCase = other.DataCase;
			switch (dataCase)
			{
			case PinballUpdateNotify.DataOneofCase.GroupFormation:
				if (this.GroupFormation == null)
				{
					this.GroupFormation = new GroupFormation();
				}
				this.GroupFormation.MergeFrom(other.GroupFormation);
				break;
			case PinballUpdateNotify.DataOneofCase.ConditionTask:
				if (this.ConditionTask == null)
				{
					this.ConditionTask = new ConditionTask();
				}
				this.ConditionTask.MergeFrom(other.ConditionTask);
				break;
			case PinballUpdateNotify.DataOneofCase.NewRole:
				if (this.NewRole == null)
				{
					this.NewRole = new PinballRoles();
				}
				this.NewRole.MergeFrom(other.NewRole);
				break;
			default:
				if (dataCase != PinballUpdateNotify.DataOneofCase.NewWeapon)
				{
					if (dataCase == PinballUpdateNotify.DataOneofCase.LevelData)
					{
						if (this.LevelData == null)
						{
							this.LevelData = new PinballLevelData();
						}
						this.LevelData.MergeFrom(other.LevelData);
					}
				}
				else
				{
					if (this.NewWeapon == null)
					{
						this.NewWeapon = new PinballWeapons();
					}
					this.NewWeapon.MergeFrom(other.NewWeapon);
				}
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601283E RID: 75838 RVA: 0x002B3755 File Offset: 0x002B1955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601283F RID: 75839 RVA: 0x002B3760 File Offset: 0x002B1960
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
				if (num <= 34U)
				{
					if (num == 26U)
					{
						GroupFormation groupFormation = new GroupFormation();
						if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.GroupFormation)
						{
							groupFormation.MergeFrom(this.GroupFormation);
						}
						input.ReadMessage(groupFormation);
						this.GroupFormation = groupFormation;
						continue;
					}
					if (num == 34U)
					{
						ConditionTask conditionTask = new ConditionTask();
						if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.ConditionTask)
						{
							conditionTask.MergeFrom(this.ConditionTask);
						}
						input.ReadMessage(conditionTask);
						this.ConditionTask = conditionTask;
						continue;
					}
				}
				else
				{
					if (num == 42U)
					{
						PinballRoles pinballRoles = new PinballRoles();
						if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.NewRole)
						{
							pinballRoles.MergeFrom(this.NewRole);
						}
						input.ReadMessage(pinballRoles);
						this.NewRole = pinballRoles;
						continue;
					}
					if (num == 106U)
					{
						PinballWeapons pinballWeapons = new PinballWeapons();
						if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.NewWeapon)
						{
							pinballWeapons.MergeFrom(this.NewWeapon);
						}
						input.ReadMessage(pinballWeapons);
						this.NewWeapon = pinballWeapons;
						continue;
					}
					if (num == 114U)
					{
						PinballLevelData pinballLevelData = new PinballLevelData();
						if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.LevelData)
						{
							pinballLevelData.MergeFrom(this.LevelData);
						}
						input.ReadMessage(pinballLevelData);
						this.LevelData = pinballLevelData;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007308 RID: 29448
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007309 RID: 29449
		public const int ConditionTaskFieldNumber = 4;

		// Token: 0x0400730A RID: 29450
		public const int LevelDataFieldNumber = 14;

		// Token: 0x0400730B RID: 29451
		public const int NewWeaponFieldNumber = 13;

		// Token: 0x0400730C RID: 29452
		public const int NewRoleFieldNumber = 5;

		// Token: 0x0400730D RID: 29453
		public const int GroupFormationFieldNumber = 3;

		// Token: 0x0400730E RID: 29454
		private object data_;

		// Token: 0x0400730F RID: 29455
		private PinballUpdateNotify.DataOneofCase dataCase_;

		// Token: 0x020018D7 RID: 6359
		public enum DataOneofCase
		{
			// Token: 0x0400C8E5 RID: 51429
			None,
			// Token: 0x0400C8E6 RID: 51430
			ConditionTask = 4,
			// Token: 0x0400C8E7 RID: 51431
			LevelData = 14,
			// Token: 0x0400C8E8 RID: 51432
			NewWeapon = 13,
			// Token: 0x0400C8E9 RID: 51433
			NewRole = 5,
			// Token: 0x0400C8EA RID: 51434
			GroupFormation = 3
		}
	}
}
