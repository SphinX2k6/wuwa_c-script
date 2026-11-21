using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D59 RID: 3417
	[NetMessage(EMessageId.PinballUpdateNotify)]
	public sealed class PinballUpdateNotify : IMessage<PinballUpdateNotify>, IMessage, IEquatable<PinballUpdateNotify>, IDeepCloneable<PinballUpdateNotify>, IBufferMessage
	{
		// Token: 0x06012728 RID: 75560 RVA: 0x002B1589 File Offset: 0x002AF789
		[NullableContext(1)]
		public static PinballUpdateNotify Create()
		{
			return new PinballUpdateNotify();
		}

		// Token: 0x17003D22 RID: 15650
		// (get) Token: 0x06012729 RID: 75561 RVA: 0x002B1590 File Offset: 0x002AF790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D23 RID: 15651
		// (get) Token: 0x0601272A RID: 75562 RVA: 0x002B1593 File Offset: 0x002AF793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601272B RID: 75563 RVA: 0x002B159A File Offset: 0x002AF79A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballUpdateNotify()
		{
		}

		// Token: 0x0601272C RID: 75564 RVA: 0x002B15A4 File Offset: 0x002AF7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballUpdateNotify(PinballUpdateNotify other) : this()
		{
			PinballUpdateNotify.DataOneofCase dataCase = other.DataCase;
			switch (dataCase)
			{
			case PinballUpdateNotify.DataOneofCase.NewRole:
				this.NewRole = other.NewRole.Clone();
				break;
			case (PinballUpdateNotify.DataOneofCase)3:
			case (PinballUpdateNotify.DataOneofCase)6:
				break;
			case PinballUpdateNotify.DataOneofCase.GroupFormation:
				this.GroupFormation = other.GroupFormation.Clone();
				break;
			case PinballUpdateNotify.DataOneofCase.NewWeapon:
				this.NewWeapon = other.NewWeapon.Clone();
				break;
			case PinballUpdateNotify.DataOneofCase.ConditionTask:
				this.ConditionTask = other.ConditionTask.Clone();
				break;
			default:
				if (dataCase == PinballUpdateNotify.DataOneofCase.LevelData)
				{
					this.LevelData = other.LevelData.Clone();
				}
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601272D RID: 75565 RVA: 0x002B1653 File Offset: 0x002AF853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballUpdateNotify Clone()
		{
			return new PinballUpdateNotify(this);
		}

		// Token: 0x17003D24 RID: 15652
		// (get) Token: 0x0601272E RID: 75566 RVA: 0x002B165B File Offset: 0x002AF85B
		// (set) Token: 0x0601272F RID: 75567 RVA: 0x002B1673 File Offset: 0x002AF873
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

		// Token: 0x17003D25 RID: 15653
		// (get) Token: 0x06012730 RID: 75568 RVA: 0x002B1689 File Offset: 0x002AF889
		// (set) Token: 0x06012731 RID: 75569 RVA: 0x002B16A2 File Offset: 0x002AF8A2
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

		// Token: 0x17003D26 RID: 15654
		// (get) Token: 0x06012732 RID: 75570 RVA: 0x002B16B9 File Offset: 0x002AF8B9
		// (set) Token: 0x06012733 RID: 75571 RVA: 0x002B16D1 File Offset: 0x002AF8D1
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

		// Token: 0x17003D27 RID: 15655
		// (get) Token: 0x06012734 RID: 75572 RVA: 0x002B16E7 File Offset: 0x002AF8E7
		// (set) Token: 0x06012735 RID: 75573 RVA: 0x002B16FF File Offset: 0x002AF8FF
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

		// Token: 0x17003D28 RID: 15656
		// (get) Token: 0x06012736 RID: 75574 RVA: 0x002B1715 File Offset: 0x002AF915
		// (set) Token: 0x06012737 RID: 75575 RVA: 0x002B172D File Offset: 0x002AF92D
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

		// Token: 0x17003D29 RID: 15657
		// (get) Token: 0x06012738 RID: 75576 RVA: 0x002B1743 File Offset: 0x002AF943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballUpdateNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06012739 RID: 75577 RVA: 0x002B174B File Offset: 0x002AF94B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = PinballUpdateNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0601273A RID: 75578 RVA: 0x002B175B File Offset: 0x002AF95B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballUpdateNotify);
		}

		// Token: 0x0601273B RID: 75579 RVA: 0x002B176C File Offset: 0x002AF96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ConditionTask, other.ConditionTask) && object.Equals(this.LevelData, other.LevelData) && object.Equals(this.NewWeapon, other.NewWeapon) && object.Equals(this.NewRole, other.NewRole) && object.Equals(this.GroupFormation, other.GroupFormation) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601273C RID: 75580 RVA: 0x002B1810 File Offset: 0x002AFA10
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

		// Token: 0x0601273D RID: 75581 RVA: 0x002B18B3 File Offset: 0x002AFAB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601273E RID: 75582 RVA: 0x002B18C0 File Offset: 0x002AFAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601273F RID: 75583 RVA: 0x002B18CC File Offset: 0x002AFACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.NewRole)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.NewRole);
			}
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.GroupFormation)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.GroupFormation);
			}
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.NewWeapon)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.NewWeapon);
			}
			if (this.dataCase_ == PinballUpdateNotify.DataOneofCase.ConditionTask)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.ConditionTask);
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

		// Token: 0x06012740 RID: 75584 RVA: 0x002B1980 File Offset: 0x002AFB80
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

		// Token: 0x06012741 RID: 75585 RVA: 0x002B1A24 File Offset: 0x002AFC24
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
			case PinballUpdateNotify.DataOneofCase.NewRole:
				if (this.NewRole == null)
				{
					this.NewRole = new PinballRoles();
				}
				this.NewRole.MergeFrom(other.NewRole);
				break;
			case (PinballUpdateNotify.DataOneofCase)3:
			case (PinballUpdateNotify.DataOneofCase)6:
				break;
			case PinballUpdateNotify.DataOneofCase.GroupFormation:
				if (this.GroupFormation == null)
				{
					this.GroupFormation = new GroupFormation();
				}
				this.GroupFormation.MergeFrom(other.GroupFormation);
				break;
			case PinballUpdateNotify.DataOneofCase.NewWeapon:
				if (this.NewWeapon == null)
				{
					this.NewWeapon = new PinballWeapons();
				}
				this.NewWeapon.MergeFrom(other.NewWeapon);
				break;
			case PinballUpdateNotify.DataOneofCase.ConditionTask:
				if (this.ConditionTask == null)
				{
					this.ConditionTask = new ConditionTask();
				}
				this.ConditionTask.MergeFrom(other.ConditionTask);
				break;
			default:
				if (dataCase == PinballUpdateNotify.DataOneofCase.LevelData)
				{
					if (this.LevelData == null)
					{
						this.LevelData = new PinballLevelData();
					}
					this.LevelData.MergeFrom(other.LevelData);
				}
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012742 RID: 75586 RVA: 0x002B1B3C File Offset: 0x002AFD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012743 RID: 75587 RVA: 0x002B1B48 File Offset: 0x002AFD48
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
					if (num == 18U)
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
					if (num == 34U)
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
				}
				else
				{
					if (num == 42U)
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
					if (num == 58U)
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

		// Token: 0x04007320 RID: 29472
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007321 RID: 29473
		public const int ConditionTaskFieldNumber = 7;

		// Token: 0x04007322 RID: 29474
		public const int LevelDataFieldNumber = 14;

		// Token: 0x04007323 RID: 29475
		public const int NewWeaponFieldNumber = 5;

		// Token: 0x04007324 RID: 29476
		public const int NewRoleFieldNumber = 2;

		// Token: 0x04007325 RID: 29477
		public const int GroupFormationFieldNumber = 4;

		// Token: 0x04007326 RID: 29478
		private object data_;

		// Token: 0x04007327 RID: 29479
		private PinballUpdateNotify.DataOneofCase dataCase_;

		// Token: 0x0200194F RID: 6479
		public enum DataOneofCase
		{
			// Token: 0x0400CE10 RID: 52752
			None,
			// Token: 0x0400CE11 RID: 52753
			ConditionTask = 7,
			// Token: 0x0400CE12 RID: 52754
			LevelData = 14,
			// Token: 0x0400CE13 RID: 52755
			NewWeapon = 5,
			// Token: 0x0400CE14 RID: 52756
			NewRole = 2,
			// Token: 0x0400CE15 RID: 52757
			GroupFormation = 4
		}
	}
}
