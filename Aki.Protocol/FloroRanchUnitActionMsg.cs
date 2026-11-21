using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D6 RID: 1494
	public sealed class FloroRanchUnitActionMsg : IMessage<FloroRanchUnitActionMsg>, IMessage, IEquatable<FloroRanchUnitActionMsg>, IDeepCloneable<FloroRanchUnitActionMsg>, IBufferMessage
	{
		// Token: 0x06008AC6 RID: 35526 RVA: 0x0015062B File Offset: 0x0014E82B
		[NullableContext(1)]
		public static FloroRanchUnitActionMsg Create()
		{
			return new FloroRanchUnitActionMsg();
		}

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x06008AC7 RID: 35527 RVA: 0x00150632 File Offset: 0x0014E832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroRanchUnitActionMsg> Parser
		{
			get
			{
				return FloroRanchUnitActionMsg._parser;
			}
		}

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x06008AC8 RID: 35528 RVA: 0x00150639 File Offset: 0x0014E839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x06008AC9 RID: 35529 RVA: 0x0015063C File Offset: 0x0014E83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchUnitActionMsg.Descriptor;
			}
		}

		// Token: 0x06008ACA RID: 35530 RVA: 0x00150643 File Offset: 0x0014E843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnitActionMsg()
		{
		}

		// Token: 0x06008ACB RID: 35531 RVA: 0x0015064C File Offset: 0x0014E84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnitActionMsg(FloroRanchUnitActionMsg other) : this()
		{
			this.unitActionType_ = other.unitActionType_;
			this.caster_ = other.caster_;
			switch (other.DataCase)
			{
			case FloroRanchUnitActionMsg.DataOneofCase.BuffOpGroup:
				this.BuffOpGroup = other.BuffOpGroup.Clone();
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.UnitOpGroup:
				this.UnitOpGroup = other.UnitOpGroup.Clone();
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.ResourcesChange:
				this.ResourcesChange = other.ResourcesChange.Clone();
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.EatingGroup:
				this.EatingGroup = other.EatingGroup.Clone();
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.EvolveUpdate:
				this.EvolveUpdate = other.EvolveUpdate.Clone();
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.MixAction:
				this.MixAction = other.MixAction.Clone();
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.SacrificeAction:
				this.SacrificeAction = other.SacrificeAction.Clone();
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.ActionInfo:
				this.ActionInfo = other.ActionInfo.Clone();
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.ChangePointAction:
				this.ChangePointAction = other.ChangePointAction.Clone();
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.ActionStop:
				this.ActionStop = other.ActionStop.Clone();
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.ToyLvUp:
				this.ToyLvUp = other.ToyLvUp.Clone();
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.ChangeTag:
				this.ChangeTag = other.ChangeTag.Clone();
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.TributeChange:
				this.TributeChange = other.TributeChange.Clone();
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.SelfDefineValue:
				this.SelfDefineValue = other.SelfDefineValue.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008ACC RID: 35532 RVA: 0x001507F1 File Offset: 0x0014E9F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnitActionMsg Clone()
		{
			return new FloroRanchUnitActionMsg(this);
		}

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x06008ACD RID: 35533 RVA: 0x001507F9 File Offset: 0x0014E9F9
		// (set) Token: 0x06008ACE RID: 35534 RVA: 0x00150801 File Offset: 0x0014EA01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnitActionType UnitActionType
		{
			get
			{
				return this.unitActionType_;
			}
			set
			{
				this.unitActionType_ = value;
			}
		}

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x06008ACF RID: 35535 RVA: 0x0015080A File Offset: 0x0014EA0A
		// (set) Token: 0x06008AD0 RID: 35536 RVA: 0x00150812 File Offset: 0x0014EA12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Caster
		{
			get
			{
				return this.caster_;
			}
			set
			{
				this.caster_ = value;
			}
		}

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x06008AD1 RID: 35537 RVA: 0x0015081B File Offset: 0x0014EA1B
		// (set) Token: 0x06008AD2 RID: 35538 RVA: 0x00150833 File Offset: 0x0014EA33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitBuffOperateActionGroup BuffOpGroup
		{
			get
			{
				if (this.dataCase_ != FloroRanchUnitActionMsg.DataOneofCase.BuffOpGroup)
				{
					return null;
				}
				return (FRUnitBuffOperateActionGroup)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUnitActionMsg.DataOneofCase.None : FloroRanchUnitActionMsg.DataOneofCase.BuffOpGroup);
			}
		}

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x06008AD3 RID: 35539 RVA: 0x00150849 File Offset: 0x0014EA49
		// (set) Token: 0x06008AD4 RID: 35540 RVA: 0x00150861 File Offset: 0x0014EA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateActionGroup UnitOpGroup
		{
			get
			{
				if (this.dataCase_ != FloroRanchUnitActionMsg.DataOneofCase.UnitOpGroup)
				{
					return null;
				}
				return (FRUnitOperateActionGroup)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUnitActionMsg.DataOneofCase.None : FloroRanchUnitActionMsg.DataOneofCase.UnitOpGroup);
			}
		}

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x06008AD5 RID: 35541 RVA: 0x00150877 File Offset: 0x0014EA77
		// (set) Token: 0x06008AD6 RID: 35542 RVA: 0x0015088F File Offset: 0x0014EA8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitResourcesChangeAction ResourcesChange
		{
			get
			{
				if (this.dataCase_ != FloroRanchUnitActionMsg.DataOneofCase.ResourcesChange)
				{
					return null;
				}
				return (FRUnitResourcesChangeAction)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUnitActionMsg.DataOneofCase.None : FloroRanchUnitActionMsg.DataOneofCase.ResourcesChange);
			}
		}

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x06008AD7 RID: 35543 RVA: 0x001508A5 File Offset: 0x0014EAA5
		// (set) Token: 0x06008AD8 RID: 35544 RVA: 0x001508BD File Offset: 0x0014EABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitEatingActionGroup EatingGroup
		{
			get
			{
				if (this.dataCase_ != FloroRanchUnitActionMsg.DataOneofCase.EatingGroup)
				{
					return null;
				}
				return (FRUnitEatingActionGroup)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUnitActionMsg.DataOneofCase.None : FloroRanchUnitActionMsg.DataOneofCase.EatingGroup);
			}
		}

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x06008AD9 RID: 35545 RVA: 0x001508D3 File Offset: 0x0014EAD3
		// (set) Token: 0x06008ADA RID: 35546 RVA: 0x001508EB File Offset: 0x0014EAEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FREvolveUpdateAction EvolveUpdate
		{
			get
			{
				if (this.dataCase_ != FloroRanchUnitActionMsg.DataOneofCase.EvolveUpdate)
				{
					return null;
				}
				return (FREvolveUpdateAction)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUnitActionMsg.DataOneofCase.None : FloroRanchUnitActionMsg.DataOneofCase.EvolveUpdate);
			}
		}

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x06008ADB RID: 35547 RVA: 0x00150901 File Offset: 0x0014EB01
		// (set) Token: 0x06008ADC RID: 35548 RVA: 0x00150919 File Offset: 0x0014EB19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRMixAction MixAction
		{
			get
			{
				if (this.dataCase_ != FloroRanchUnitActionMsg.DataOneofCase.MixAction)
				{
					return null;
				}
				return (FRMixAction)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUnitActionMsg.DataOneofCase.None : FloroRanchUnitActionMsg.DataOneofCase.MixAction);
			}
		}

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x06008ADD RID: 35549 RVA: 0x0015092F File Offset: 0x0014EB2F
		// (set) Token: 0x06008ADE RID: 35550 RVA: 0x00150948 File Offset: 0x0014EB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRSacrifice SacrificeAction
		{
			get
			{
				if (this.dataCase_ != FloroRanchUnitActionMsg.DataOneofCase.SacrificeAction)
				{
					return null;
				}
				return (FRSacrifice)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUnitActionMsg.DataOneofCase.None : FloroRanchUnitActionMsg.DataOneofCase.SacrificeAction);
			}
		}

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x06008ADF RID: 35551 RVA: 0x0015095F File Offset: 0x0014EB5F
		// (set) Token: 0x06008AE0 RID: 35552 RVA: 0x00150978 File Offset: 0x0014EB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRDebugActionInfo ActionInfo
		{
			get
			{
				if (this.dataCase_ != FloroRanchUnitActionMsg.DataOneofCase.ActionInfo)
				{
					return null;
				}
				return (FRDebugActionInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUnitActionMsg.DataOneofCase.None : FloroRanchUnitActionMsg.DataOneofCase.ActionInfo);
			}
		}

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x06008AE1 RID: 35553 RVA: 0x0015098F File Offset: 0x0014EB8F
		// (set) Token: 0x06008AE2 RID: 35554 RVA: 0x001509A8 File Offset: 0x0014EBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRChangePointAction ChangePointAction
		{
			get
			{
				if (this.dataCase_ != FloroRanchUnitActionMsg.DataOneofCase.ChangePointAction)
				{
					return null;
				}
				return (FRChangePointAction)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUnitActionMsg.DataOneofCase.None : FloroRanchUnitActionMsg.DataOneofCase.ChangePointAction);
			}
		}

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x06008AE3 RID: 35555 RVA: 0x001509BF File Offset: 0x0014EBBF
		// (set) Token: 0x06008AE4 RID: 35556 RVA: 0x001509D8 File Offset: 0x0014EBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionStop ActionStop
		{
			get
			{
				if (this.dataCase_ != FloroRanchUnitActionMsg.DataOneofCase.ActionStop)
				{
					return null;
				}
				return (FRActionStop)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUnitActionMsg.DataOneofCase.None : FloroRanchUnitActionMsg.DataOneofCase.ActionStop);
			}
		}

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x06008AE5 RID: 35557 RVA: 0x001509EF File Offset: 0x0014EBEF
		// (set) Token: 0x06008AE6 RID: 35558 RVA: 0x00150A08 File Offset: 0x0014EC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionToyLvUp ToyLvUp
		{
			get
			{
				if (this.dataCase_ != FloroRanchUnitActionMsg.DataOneofCase.ToyLvUp)
				{
					return null;
				}
				return (FRActionToyLvUp)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUnitActionMsg.DataOneofCase.None : FloroRanchUnitActionMsg.DataOneofCase.ToyLvUp);
			}
		}

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x06008AE7 RID: 35559 RVA: 0x00150A1F File Offset: 0x0014EC1F
		// (set) Token: 0x06008AE8 RID: 35560 RVA: 0x00150A38 File Offset: 0x0014EC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionChangeTag ChangeTag
		{
			get
			{
				if (this.dataCase_ != FloroRanchUnitActionMsg.DataOneofCase.ChangeTag)
				{
					return null;
				}
				return (FRActionChangeTag)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUnitActionMsg.DataOneofCase.None : FloroRanchUnitActionMsg.DataOneofCase.ChangeTag);
			}
		}

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x06008AE9 RID: 35561 RVA: 0x00150A4F File Offset: 0x0014EC4F
		// (set) Token: 0x06008AEA RID: 35562 RVA: 0x00150A68 File Offset: 0x0014EC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionStageTributeChange TributeChange
		{
			get
			{
				if (this.dataCase_ != FloroRanchUnitActionMsg.DataOneofCase.TributeChange)
				{
					return null;
				}
				return (FRActionStageTributeChange)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUnitActionMsg.DataOneofCase.None : FloroRanchUnitActionMsg.DataOneofCase.TributeChange);
			}
		}

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x06008AEB RID: 35563 RVA: 0x00150A7F File Offset: 0x0014EC7F
		// (set) Token: 0x06008AEC RID: 35564 RVA: 0x00150A98 File Offset: 0x0014EC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionSelfDefineValue SelfDefineValue
		{
			get
			{
				if (this.dataCase_ != FloroRanchUnitActionMsg.DataOneofCase.SelfDefineValue)
				{
					return null;
				}
				return (FRActionSelfDefineValue)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUnitActionMsg.DataOneofCase.None : FloroRanchUnitActionMsg.DataOneofCase.SelfDefineValue);
			}
		}

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x06008AED RID: 35565 RVA: 0x00150AAF File Offset: 0x0014ECAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnitActionMsg.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06008AEE RID: 35566 RVA: 0x00150AB7 File Offset: 0x0014ECB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = FloroRanchUnitActionMsg.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06008AEF RID: 35567 RVA: 0x00150AC7 File Offset: 0x0014ECC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchUnitActionMsg);
		}

		// Token: 0x06008AF0 RID: 35568 RVA: 0x00150AD8 File Offset: 0x0014ECD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchUnitActionMsg other)
		{
			return other != null && (other == this || (this.UnitActionType == other.UnitActionType && this.Caster == other.Caster && object.Equals(this.BuffOpGroup, other.BuffOpGroup) && object.Equals(this.UnitOpGroup, other.UnitOpGroup) && object.Equals(this.ResourcesChange, other.ResourcesChange) && object.Equals(this.EatingGroup, other.EatingGroup) && object.Equals(this.EvolveUpdate, other.EvolveUpdate) && object.Equals(this.MixAction, other.MixAction) && object.Equals(this.SacrificeAction, other.SacrificeAction) && object.Equals(this.ActionInfo, other.ActionInfo) && object.Equals(this.ChangePointAction, other.ChangePointAction) && object.Equals(this.ActionStop, other.ActionStop) && object.Equals(this.ToyLvUp, other.ToyLvUp) && object.Equals(this.ChangeTag, other.ChangeTag) && object.Equals(this.TributeChange, other.TributeChange) && object.Equals(this.SelfDefineValue, other.SelfDefineValue) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008AF1 RID: 35569 RVA: 0x00150C58 File Offset: 0x0014EE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UnitActionType != FloroRanchUnitActionType.OpBuff)
			{
				num ^= this.UnitActionType.GetHashCode();
			}
			if (this.Caster != 0)
			{
				num ^= this.Caster.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.BuffOpGroup)
			{
				num ^= this.BuffOpGroup.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.UnitOpGroup)
			{
				num ^= this.UnitOpGroup.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ResourcesChange)
			{
				num ^= this.ResourcesChange.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.EatingGroup)
			{
				num ^= this.EatingGroup.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.EvolveUpdate)
			{
				num ^= this.EvolveUpdate.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.MixAction)
			{
				num ^= this.MixAction.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.SacrificeAction)
			{
				num ^= this.SacrificeAction.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ActionInfo)
			{
				num ^= this.ActionInfo.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ChangePointAction)
			{
				num ^= this.ChangePointAction.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ActionStop)
			{
				num ^= this.ActionStop.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ToyLvUp)
			{
				num ^= this.ToyLvUp.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ChangeTag)
			{
				num ^= this.ChangeTag.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.TributeChange)
			{
				num ^= this.TributeChange.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.SelfDefineValue)
			{
				num ^= this.SelfDefineValue.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008AF2 RID: 35570 RVA: 0x00150E09 File Offset: 0x0014F009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008AF3 RID: 35571 RVA: 0x00150E16 File Offset: 0x0014F016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008AF4 RID: 35572 RVA: 0x00150E20 File Offset: 0x0014F020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UnitActionType != FloroRanchUnitActionType.OpBuff)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.UnitActionType);
			}
			if (this.Caster != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Caster);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.BuffOpGroup)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.BuffOpGroup);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.UnitOpGroup)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.UnitOpGroup);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ResourcesChange)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ResourcesChange);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.EatingGroup)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.EatingGroup);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.EvolveUpdate)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.EvolveUpdate);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.MixAction)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.MixAction);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.SacrificeAction)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.SacrificeAction);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ActionInfo)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.ActionInfo);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ChangePointAction)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ChangePointAction);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ActionStop)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.ActionStop);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ToyLvUp)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.ToyLvUp);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ChangeTag)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.ChangeTag);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.TributeChange)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.TributeChange);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.SelfDefineValue)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.SelfDefineValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008AF5 RID: 35573 RVA: 0x0015101C File Offset: 0x0014F21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UnitActionType != FloroRanchUnitActionType.OpBuff)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.UnitActionType);
			}
			if (this.Caster != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Caster);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.BuffOpGroup)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BuffOpGroup);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.UnitOpGroup)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UnitOpGroup);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ResourcesChange)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ResourcesChange);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.EatingGroup)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EatingGroup);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.EvolveUpdate)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EvolveUpdate);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.MixAction)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MixAction);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.SacrificeAction)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SacrificeAction);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ActionInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActionInfo);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ChangePointAction)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChangePointAction);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ActionStop)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActionStop);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ToyLvUp)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ToyLvUp);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ChangeTag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChangeTag);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.TributeChange)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TributeChange);
			}
			if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.SelfDefineValue)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SelfDefineValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008AF6 RID: 35574 RVA: 0x001511D8 File Offset: 0x0014F3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchUnitActionMsg other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UnitActionType != FloroRanchUnitActionType.OpBuff)
			{
				this.UnitActionType = other.UnitActionType;
			}
			if (other.Caster != 0)
			{
				this.Caster = other.Caster;
			}
			switch (other.DataCase)
			{
			case FloroRanchUnitActionMsg.DataOneofCase.BuffOpGroup:
				if (this.BuffOpGroup == null)
				{
					this.BuffOpGroup = new FRUnitBuffOperateActionGroup();
				}
				this.BuffOpGroup.MergeFrom(other.BuffOpGroup);
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.UnitOpGroup:
				if (this.UnitOpGroup == null)
				{
					this.UnitOpGroup = new FRUnitOperateActionGroup();
				}
				this.UnitOpGroup.MergeFrom(other.UnitOpGroup);
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.ResourcesChange:
				if (this.ResourcesChange == null)
				{
					this.ResourcesChange = new FRUnitResourcesChangeAction();
				}
				this.ResourcesChange.MergeFrom(other.ResourcesChange);
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.EatingGroup:
				if (this.EatingGroup == null)
				{
					this.EatingGroup = new FRUnitEatingActionGroup();
				}
				this.EatingGroup.MergeFrom(other.EatingGroup);
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.EvolveUpdate:
				if (this.EvolveUpdate == null)
				{
					this.EvolveUpdate = new FREvolveUpdateAction();
				}
				this.EvolveUpdate.MergeFrom(other.EvolveUpdate);
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.MixAction:
				if (this.MixAction == null)
				{
					this.MixAction = new FRMixAction();
				}
				this.MixAction.MergeFrom(other.MixAction);
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.SacrificeAction:
				if (this.SacrificeAction == null)
				{
					this.SacrificeAction = new FRSacrifice();
				}
				this.SacrificeAction.MergeFrom(other.SacrificeAction);
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.ActionInfo:
				if (this.ActionInfo == null)
				{
					this.ActionInfo = new FRDebugActionInfo();
				}
				this.ActionInfo.MergeFrom(other.ActionInfo);
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.ChangePointAction:
				if (this.ChangePointAction == null)
				{
					this.ChangePointAction = new FRChangePointAction();
				}
				this.ChangePointAction.MergeFrom(other.ChangePointAction);
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.ActionStop:
				if (this.ActionStop == null)
				{
					this.ActionStop = new FRActionStop();
				}
				this.ActionStop.MergeFrom(other.ActionStop);
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.ToyLvUp:
				if (this.ToyLvUp == null)
				{
					this.ToyLvUp = new FRActionToyLvUp();
				}
				this.ToyLvUp.MergeFrom(other.ToyLvUp);
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.ChangeTag:
				if (this.ChangeTag == null)
				{
					this.ChangeTag = new FRActionChangeTag();
				}
				this.ChangeTag.MergeFrom(other.ChangeTag);
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.TributeChange:
				if (this.TributeChange == null)
				{
					this.TributeChange = new FRActionStageTributeChange();
				}
				this.TributeChange.MergeFrom(other.TributeChange);
				break;
			case FloroRanchUnitActionMsg.DataOneofCase.SelfDefineValue:
				if (this.SelfDefineValue == null)
				{
					this.SelfDefineValue = new FRActionSelfDefineValue();
				}
				this.SelfDefineValue.MergeFrom(other.SelfDefineValue);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008AF7 RID: 35575 RVA: 0x001514A4 File Offset: 0x0014F6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008AF8 RID: 35576 RVA: 0x001514B0 File Offset: 0x0014F6B0
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
				if (num <= 66U)
				{
					if (num <= 34U)
					{
						if (num <= 16U)
						{
							if (num == 8U)
							{
								this.UnitActionType = (FloroRanchUnitActionType)input.ReadEnum();
								continue;
							}
							if (num == 16U)
							{
								this.Caster = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 26U)
							{
								FRUnitBuffOperateActionGroup frunitBuffOperateActionGroup = new FRUnitBuffOperateActionGroup();
								if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.BuffOpGroup)
								{
									frunitBuffOperateActionGroup.MergeFrom(this.BuffOpGroup);
								}
								input.ReadMessage(frunitBuffOperateActionGroup);
								this.BuffOpGroup = frunitBuffOperateActionGroup;
								continue;
							}
							if (num == 34U)
							{
								FRUnitOperateActionGroup frunitOperateActionGroup = new FRUnitOperateActionGroup();
								if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.UnitOpGroup)
								{
									frunitOperateActionGroup.MergeFrom(this.UnitOpGroup);
								}
								input.ReadMessage(frunitOperateActionGroup);
								this.UnitOpGroup = frunitOperateActionGroup;
								continue;
							}
						}
					}
					else if (num <= 50U)
					{
						if (num == 42U)
						{
							FRUnitResourcesChangeAction frunitResourcesChangeAction = new FRUnitResourcesChangeAction();
							if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ResourcesChange)
							{
								frunitResourcesChangeAction.MergeFrom(this.ResourcesChange);
							}
							input.ReadMessage(frunitResourcesChangeAction);
							this.ResourcesChange = frunitResourcesChangeAction;
							continue;
						}
						if (num == 50U)
						{
							FRUnitEatingActionGroup frunitEatingActionGroup = new FRUnitEatingActionGroup();
							if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.EatingGroup)
							{
								frunitEatingActionGroup.MergeFrom(this.EatingGroup);
							}
							input.ReadMessage(frunitEatingActionGroup);
							this.EatingGroup = frunitEatingActionGroup;
							continue;
						}
					}
					else
					{
						if (num == 58U)
						{
							FREvolveUpdateAction frevolveUpdateAction = new FREvolveUpdateAction();
							if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.EvolveUpdate)
							{
								frevolveUpdateAction.MergeFrom(this.EvolveUpdate);
							}
							input.ReadMessage(frevolveUpdateAction);
							this.EvolveUpdate = frevolveUpdateAction;
							continue;
						}
						if (num == 66U)
						{
							FRMixAction frmixAction = new FRMixAction();
							if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.MixAction)
							{
								frmixAction.MergeFrom(this.MixAction);
							}
							input.ReadMessage(frmixAction);
							this.MixAction = frmixAction;
							continue;
						}
					}
				}
				else if (num <= 98U)
				{
					if (num <= 82U)
					{
						if (num == 74U)
						{
							FRSacrifice frsacrifice = new FRSacrifice();
							if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.SacrificeAction)
							{
								frsacrifice.MergeFrom(this.SacrificeAction);
							}
							input.ReadMessage(frsacrifice);
							this.SacrificeAction = frsacrifice;
							continue;
						}
						if (num == 82U)
						{
							FRDebugActionInfo frdebugActionInfo = new FRDebugActionInfo();
							if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ActionInfo)
							{
								frdebugActionInfo.MergeFrom(this.ActionInfo);
							}
							input.ReadMessage(frdebugActionInfo);
							this.ActionInfo = frdebugActionInfo;
							continue;
						}
					}
					else
					{
						if (num == 90U)
						{
							FRChangePointAction frchangePointAction = new FRChangePointAction();
							if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ChangePointAction)
							{
								frchangePointAction.MergeFrom(this.ChangePointAction);
							}
							input.ReadMessage(frchangePointAction);
							this.ChangePointAction = frchangePointAction;
							continue;
						}
						if (num == 98U)
						{
							FRActionStop fractionStop = new FRActionStop();
							if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ActionStop)
							{
								fractionStop.MergeFrom(this.ActionStop);
							}
							input.ReadMessage(fractionStop);
							this.ActionStop = fractionStop;
							continue;
						}
					}
				}
				else if (num <= 114U)
				{
					if (num == 106U)
					{
						FRActionToyLvUp fractionToyLvUp = new FRActionToyLvUp();
						if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ToyLvUp)
						{
							fractionToyLvUp.MergeFrom(this.ToyLvUp);
						}
						input.ReadMessage(fractionToyLvUp);
						this.ToyLvUp = fractionToyLvUp;
						continue;
					}
					if (num == 114U)
					{
						FRActionChangeTag fractionChangeTag = new FRActionChangeTag();
						if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.ChangeTag)
						{
							fractionChangeTag.MergeFrom(this.ChangeTag);
						}
						input.ReadMessage(fractionChangeTag);
						this.ChangeTag = fractionChangeTag;
						continue;
					}
				}
				else
				{
					if (num == 122U)
					{
						FRActionStageTributeChange fractionStageTributeChange = new FRActionStageTributeChange();
						if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.TributeChange)
						{
							fractionStageTributeChange.MergeFrom(this.TributeChange);
						}
						input.ReadMessage(fractionStageTributeChange);
						this.TributeChange = fractionStageTributeChange;
						continue;
					}
					if (num == 130U)
					{
						FRActionSelfDefineValue fractionSelfDefineValue = new FRActionSelfDefineValue();
						if (this.dataCase_ == FloroRanchUnitActionMsg.DataOneofCase.SelfDefineValue)
						{
							fractionSelfDefineValue.MergeFrom(this.SelfDefineValue);
						}
						input.ReadMessage(fractionSelfDefineValue);
						this.SelfDefineValue = fractionSelfDefineValue;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400449D RID: 17565
		private static readonly MessageParser<FloroRanchUnitActionMsg> _parser = new MessageParser<FloroRanchUnitActionMsg>(() => new FloroRanchUnitActionMsg());

		// Token: 0x0400449E RID: 17566
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400449F RID: 17567
		public const int UnitActionTypeFieldNumber = 1;

		// Token: 0x040044A0 RID: 17568
		private FloroRanchUnitActionType unitActionType_;

		// Token: 0x040044A1 RID: 17569
		public const int CasterFieldNumber = 2;

		// Token: 0x040044A2 RID: 17570
		private int caster_;

		// Token: 0x040044A3 RID: 17571
		public const int BuffOpGroupFieldNumber = 3;

		// Token: 0x040044A4 RID: 17572
		public const int UnitOpGroupFieldNumber = 4;

		// Token: 0x040044A5 RID: 17573
		public const int ResourcesChangeFieldNumber = 5;

		// Token: 0x040044A6 RID: 17574
		public const int EatingGroupFieldNumber = 6;

		// Token: 0x040044A7 RID: 17575
		public const int EvolveUpdateFieldNumber = 7;

		// Token: 0x040044A8 RID: 17576
		public const int MixActionFieldNumber = 8;

		// Token: 0x040044A9 RID: 17577
		public const int SacrificeActionFieldNumber = 9;

		// Token: 0x040044AA RID: 17578
		public const int ActionInfoFieldNumber = 10;

		// Token: 0x040044AB RID: 17579
		public const int ChangePointActionFieldNumber = 11;

		// Token: 0x040044AC RID: 17580
		public const int ActionStopFieldNumber = 12;

		// Token: 0x040044AD RID: 17581
		public const int ToyLvUpFieldNumber = 13;

		// Token: 0x040044AE RID: 17582
		public const int ChangeTagFieldNumber = 14;

		// Token: 0x040044AF RID: 17583
		public const int TributeChangeFieldNumber = 15;

		// Token: 0x040044B0 RID: 17584
		public const int SelfDefineValueFieldNumber = 16;

		// Token: 0x040044B1 RID: 17585
		private object data_;

		// Token: 0x040044B2 RID: 17586
		private FloroRanchUnitActionMsg.DataOneofCase dataCase_;

		// Token: 0x02001820 RID: 6176
		public enum DataOneofCase
		{
			// Token: 0x0400CC06 RID: 52230
			None,
			// Token: 0x0400CC07 RID: 52231
			BuffOpGroup = 3,
			// Token: 0x0400CC08 RID: 52232
			UnitOpGroup,
			// Token: 0x0400CC09 RID: 52233
			ResourcesChange,
			// Token: 0x0400CC0A RID: 52234
			EatingGroup,
			// Token: 0x0400CC0B RID: 52235
			EvolveUpdate,
			// Token: 0x0400CC0C RID: 52236
			MixAction,
			// Token: 0x0400CC0D RID: 52237
			SacrificeAction,
			// Token: 0x0400CC0E RID: 52238
			ActionInfo,
			// Token: 0x0400CC0F RID: 52239
			ChangePointAction,
			// Token: 0x0400CC10 RID: 52240
			ActionStop,
			// Token: 0x0400CC11 RID: 52241
			ToyLvUp,
			// Token: 0x0400CC12 RID: 52242
			ChangeTag,
			// Token: 0x0400CC13 RID: 52243
			TributeChange,
			// Token: 0x0400CC14 RID: 52244
			SelfDefineValue
		}
	}
}
