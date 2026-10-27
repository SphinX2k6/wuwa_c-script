using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005EB RID: 1515
	public sealed class FloroRanchUnitActionMsg : IMessage<FloroRanchUnitActionMsg>, IMessage, IEquatable<FloroRanchUnitActionMsg>, IDeepCloneable<FloroRanchUnitActionMsg>, IBufferMessage
	{
		// Token: 0x06008C2E RID: 35886 RVA: 0x0015323F File Offset: 0x0015143F
		[NullableContext(1)]
		public static FloroRanchUnitActionMsg Create()
		{
			return new FloroRanchUnitActionMsg();
		}

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x06008C2F RID: 35887 RVA: 0x00153246 File Offset: 0x00151446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroRanchUnitActionMsg> Parser
		{
			get
			{
				return FloroRanchUnitActionMsg._parser;
			}
		}

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x06008C30 RID: 35888 RVA: 0x0015324D File Offset: 0x0015144D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x06008C31 RID: 35889 RVA: 0x00153250 File Offset: 0x00151450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchUnitActionMsg.Descriptor;
			}
		}

		// Token: 0x06008C32 RID: 35890 RVA: 0x00153257 File Offset: 0x00151457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnitActionMsg()
		{
		}

		// Token: 0x06008C33 RID: 35891 RVA: 0x00153260 File Offset: 0x00151460
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

		// Token: 0x06008C34 RID: 35892 RVA: 0x00153405 File Offset: 0x00151605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnitActionMsg Clone()
		{
			return new FloroRanchUnitActionMsg(this);
		}

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x06008C35 RID: 35893 RVA: 0x0015340D File Offset: 0x0015160D
		// (set) Token: 0x06008C36 RID: 35894 RVA: 0x00153415 File Offset: 0x00151615
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

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x06008C37 RID: 35895 RVA: 0x0015341E File Offset: 0x0015161E
		// (set) Token: 0x06008C38 RID: 35896 RVA: 0x00153426 File Offset: 0x00151626
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

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x06008C39 RID: 35897 RVA: 0x0015342F File Offset: 0x0015162F
		// (set) Token: 0x06008C3A RID: 35898 RVA: 0x00153447 File Offset: 0x00151647
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

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x06008C3B RID: 35899 RVA: 0x0015345D File Offset: 0x0015165D
		// (set) Token: 0x06008C3C RID: 35900 RVA: 0x00153475 File Offset: 0x00151675
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

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x06008C3D RID: 35901 RVA: 0x0015348B File Offset: 0x0015168B
		// (set) Token: 0x06008C3E RID: 35902 RVA: 0x001534A3 File Offset: 0x001516A3
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

		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x06008C3F RID: 35903 RVA: 0x001534B9 File Offset: 0x001516B9
		// (set) Token: 0x06008C40 RID: 35904 RVA: 0x001534D1 File Offset: 0x001516D1
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

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x06008C41 RID: 35905 RVA: 0x001534E7 File Offset: 0x001516E7
		// (set) Token: 0x06008C42 RID: 35906 RVA: 0x001534FF File Offset: 0x001516FF
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

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x06008C43 RID: 35907 RVA: 0x00153515 File Offset: 0x00151715
		// (set) Token: 0x06008C44 RID: 35908 RVA: 0x0015352D File Offset: 0x0015172D
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

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x06008C45 RID: 35909 RVA: 0x00153543 File Offset: 0x00151743
		// (set) Token: 0x06008C46 RID: 35910 RVA: 0x0015355C File Offset: 0x0015175C
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

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x06008C47 RID: 35911 RVA: 0x00153573 File Offset: 0x00151773
		// (set) Token: 0x06008C48 RID: 35912 RVA: 0x0015358C File Offset: 0x0015178C
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

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x06008C49 RID: 35913 RVA: 0x001535A3 File Offset: 0x001517A3
		// (set) Token: 0x06008C4A RID: 35914 RVA: 0x001535BC File Offset: 0x001517BC
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

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x06008C4B RID: 35915 RVA: 0x001535D3 File Offset: 0x001517D3
		// (set) Token: 0x06008C4C RID: 35916 RVA: 0x001535EC File Offset: 0x001517EC
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

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x06008C4D RID: 35917 RVA: 0x00153603 File Offset: 0x00151803
		// (set) Token: 0x06008C4E RID: 35918 RVA: 0x0015361C File Offset: 0x0015181C
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

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x06008C4F RID: 35919 RVA: 0x00153633 File Offset: 0x00151833
		// (set) Token: 0x06008C50 RID: 35920 RVA: 0x0015364C File Offset: 0x0015184C
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

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x06008C51 RID: 35921 RVA: 0x00153663 File Offset: 0x00151863
		// (set) Token: 0x06008C52 RID: 35922 RVA: 0x0015367C File Offset: 0x0015187C
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

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x06008C53 RID: 35923 RVA: 0x00153693 File Offset: 0x00151893
		// (set) Token: 0x06008C54 RID: 35924 RVA: 0x001536AC File Offset: 0x001518AC
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

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x06008C55 RID: 35925 RVA: 0x001536C3 File Offset: 0x001518C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnitActionMsg.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06008C56 RID: 35926 RVA: 0x001536CB File Offset: 0x001518CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = FloroRanchUnitActionMsg.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06008C57 RID: 35927 RVA: 0x001536DB File Offset: 0x001518DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchUnitActionMsg);
		}

		// Token: 0x06008C58 RID: 35928 RVA: 0x001536EC File Offset: 0x001518EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchUnitActionMsg other)
		{
			return other != null && (other == this || (this.UnitActionType == other.UnitActionType && this.Caster == other.Caster && object.Equals(this.BuffOpGroup, other.BuffOpGroup) && object.Equals(this.UnitOpGroup, other.UnitOpGroup) && object.Equals(this.ResourcesChange, other.ResourcesChange) && object.Equals(this.EatingGroup, other.EatingGroup) && object.Equals(this.EvolveUpdate, other.EvolveUpdate) && object.Equals(this.MixAction, other.MixAction) && object.Equals(this.SacrificeAction, other.SacrificeAction) && object.Equals(this.ActionInfo, other.ActionInfo) && object.Equals(this.ChangePointAction, other.ChangePointAction) && object.Equals(this.ActionStop, other.ActionStop) && object.Equals(this.ToyLvUp, other.ToyLvUp) && object.Equals(this.ChangeTag, other.ChangeTag) && object.Equals(this.TributeChange, other.TributeChange) && object.Equals(this.SelfDefineValue, other.SelfDefineValue) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008C59 RID: 35929 RVA: 0x0015386C File Offset: 0x00151A6C
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

		// Token: 0x06008C5A RID: 35930 RVA: 0x00153A1D File Offset: 0x00151C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008C5B RID: 35931 RVA: 0x00153A2A File Offset: 0x00151C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C5C RID: 35932 RVA: 0x00153A34 File Offset: 0x00151C34
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

		// Token: 0x06008C5D RID: 35933 RVA: 0x00153C30 File Offset: 0x00151E30
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

		// Token: 0x06008C5E RID: 35934 RVA: 0x00153DEC File Offset: 0x00151FEC
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

		// Token: 0x06008C5F RID: 35935 RVA: 0x001540B8 File Offset: 0x001522B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C60 RID: 35936 RVA: 0x001540C4 File Offset: 0x001522C4
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

		// Token: 0x040044A7 RID: 17575
		private static readonly MessageParser<FloroRanchUnitActionMsg> _parser = new MessageParser<FloroRanchUnitActionMsg>(() => new FloroRanchUnitActionMsg());

		// Token: 0x040044A8 RID: 17576
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044A9 RID: 17577
		public const int UnitActionTypeFieldNumber = 1;

		// Token: 0x040044AA RID: 17578
		private FloroRanchUnitActionType unitActionType_;

		// Token: 0x040044AB RID: 17579
		public const int CasterFieldNumber = 2;

		// Token: 0x040044AC RID: 17580
		private int caster_;

		// Token: 0x040044AD RID: 17581
		public const int BuffOpGroupFieldNumber = 3;

		// Token: 0x040044AE RID: 17582
		public const int UnitOpGroupFieldNumber = 4;

		// Token: 0x040044AF RID: 17583
		public const int ResourcesChangeFieldNumber = 5;

		// Token: 0x040044B0 RID: 17584
		public const int EatingGroupFieldNumber = 6;

		// Token: 0x040044B1 RID: 17585
		public const int EvolveUpdateFieldNumber = 7;

		// Token: 0x040044B2 RID: 17586
		public const int MixActionFieldNumber = 8;

		// Token: 0x040044B3 RID: 17587
		public const int SacrificeActionFieldNumber = 9;

		// Token: 0x040044B4 RID: 17588
		public const int ActionInfoFieldNumber = 10;

		// Token: 0x040044B5 RID: 17589
		public const int ChangePointActionFieldNumber = 11;

		// Token: 0x040044B6 RID: 17590
		public const int ActionStopFieldNumber = 12;

		// Token: 0x040044B7 RID: 17591
		public const int ToyLvUpFieldNumber = 13;

		// Token: 0x040044B8 RID: 17592
		public const int ChangeTagFieldNumber = 14;

		// Token: 0x040044B9 RID: 17593
		public const int TributeChangeFieldNumber = 15;

		// Token: 0x040044BA RID: 17594
		public const int SelfDefineValueFieldNumber = 16;

		// Token: 0x040044BB RID: 17595
		private object data_;

		// Token: 0x040044BC RID: 17596
		private FloroRanchUnitActionMsg.DataOneofCase dataCase_;

		// Token: 0x020017A8 RID: 6056
		public enum DataOneofCase
		{
			// Token: 0x0400C6DB RID: 50907
			None,
			// Token: 0x0400C6DC RID: 50908
			BuffOpGroup = 3,
			// Token: 0x0400C6DD RID: 50909
			UnitOpGroup,
			// Token: 0x0400C6DE RID: 50910
			ResourcesChange,
			// Token: 0x0400C6DF RID: 50911
			EatingGroup,
			// Token: 0x0400C6E0 RID: 50912
			EvolveUpdate,
			// Token: 0x0400C6E1 RID: 50913
			MixAction,
			// Token: 0x0400C6E2 RID: 50914
			SacrificeAction,
			// Token: 0x0400C6E3 RID: 50915
			ActionInfo,
			// Token: 0x0400C6E4 RID: 50916
			ChangePointAction,
			// Token: 0x0400C6E5 RID: 50917
			ActionStop,
			// Token: 0x0400C6E6 RID: 50918
			ToyLvUp,
			// Token: 0x0400C6E7 RID: 50919
			ChangeTag,
			// Token: 0x0400C6E8 RID: 50920
			TributeChange,
			// Token: 0x0400C6E9 RID: 50921
			SelfDefineValue
		}
	}
}
