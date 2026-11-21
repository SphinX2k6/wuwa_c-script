using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200085D RID: 2141
	public sealed class JokerGuessOp : IMessage<JokerGuessOp>, IMessage, IEquatable<JokerGuessOp>, IDeepCloneable<JokerGuessOp>, IBufferMessage
	{
		// Token: 0x0600BF13 RID: 48915 RVA: 0x001C628C File Offset: 0x001C448C
		[NullableContext(1)]
		public static JokerGuessOp Create()
		{
			return new JokerGuessOp();
		}

		// Token: 0x17002691 RID: 9873
		// (get) Token: 0x0600BF14 RID: 48916 RVA: 0x001C6293 File Offset: 0x001C4493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JokerGuessOp> Parser
		{
			get
			{
				return JokerGuessOp._parser;
			}
		}

		// Token: 0x17002692 RID: 9874
		// (get) Token: 0x0600BF15 RID: 48917 RVA: 0x001C629A File Offset: 0x001C449A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002693 RID: 9875
		// (get) Token: 0x0600BF16 RID: 48918 RVA: 0x001C629D File Offset: 0x001C449D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessOp.Descriptor;
			}
		}

		// Token: 0x0600BF17 RID: 48919 RVA: 0x001C62A4 File Offset: 0x001C44A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessOp()
		{
		}

		// Token: 0x0600BF18 RID: 48920 RVA: 0x001C62AC File Offset: 0x001C44AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessOp(JokerGuessOp other) : this()
		{
			this.jokerGuessLevelId_ = other.jokerGuessLevelId_;
			this.opType_ = other.opType_;
			switch (other.DataCase)
			{
			case JokerGuessOp.DataOneofCase.DrawAction:
				this.DrawAction = other.DrawAction.Clone();
				break;
			case JokerGuessOp.DataOneofCase.PlayAction:
				this.PlayAction = other.PlayAction.Clone();
				break;
			case JokerGuessOp.DataOneofCase.NewRoundAction:
				this.NewRoundAction = other.NewRoundAction.Clone();
				break;
			case JokerGuessOp.DataOneofCase.SkillTriggerAction:
				this.SkillTriggerAction = other.SkillTriggerAction.Clone();
				break;
			case JokerGuessOp.DataOneofCase.SkillExecAction:
				this.SkillExecAction = other.SkillExecAction.Clone();
				break;
			case JokerGuessOp.DataOneofCase.Winner:
				this.Winner = other.Winner;
				break;
			case JokerGuessOp.DataOneofCase.HpRefreshAction:
				this.HpRefreshAction = other.HpRefreshAction.Clone();
				break;
			case JokerGuessOp.DataOneofCase.DisPlayAction:
				this.DisPlayAction = other.DisPlayAction.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF19 RID: 48921 RVA: 0x001C63AD File Offset: 0x001C45AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessOp Clone()
		{
			return new JokerGuessOp(this);
		}

		// Token: 0x17002694 RID: 9876
		// (get) Token: 0x0600BF1A RID: 48922 RVA: 0x001C63B5 File Offset: 0x001C45B5
		// (set) Token: 0x0600BF1B RID: 48923 RVA: 0x001C63BD File Offset: 0x001C45BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int JokerGuessLevelId
		{
			get
			{
				return this.jokerGuessLevelId_;
			}
			set
			{
				this.jokerGuessLevelId_ = value;
			}
		}

		// Token: 0x17002695 RID: 9877
		// (get) Token: 0x0600BF1C RID: 48924 RVA: 0x001C63C6 File Offset: 0x001C45C6
		// (set) Token: 0x0600BF1D RID: 48925 RVA: 0x001C63CE File Offset: 0x001C45CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerActionType OpType
		{
			get
			{
				return this.opType_;
			}
			set
			{
				this.opType_ = value;
			}
		}

		// Token: 0x17002696 RID: 9878
		// (get) Token: 0x0600BF1E RID: 48926 RVA: 0x001C63D7 File Offset: 0x001C45D7
		// (set) Token: 0x0600BF1F RID: 48927 RVA: 0x001C63EF File Offset: 0x001C45EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardAction DrawAction
		{
			get
			{
				if (this.dataCase_ != JokerGuessOp.DataOneofCase.DrawAction)
				{
					return null;
				}
				return (JokerGuessDrawCardAction)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? JokerGuessOp.DataOneofCase.None : JokerGuessOp.DataOneofCase.DrawAction);
			}
		}

		// Token: 0x17002697 RID: 9879
		// (get) Token: 0x0600BF20 RID: 48928 RVA: 0x001C6405 File Offset: 0x001C4605
		// (set) Token: 0x0600BF21 RID: 48929 RVA: 0x001C641D File Offset: 0x001C461D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardAction PlayAction
		{
			get
			{
				if (this.dataCase_ != JokerGuessOp.DataOneofCase.PlayAction)
				{
					return null;
				}
				return (JokerGuessPlayCardAction)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? JokerGuessOp.DataOneofCase.None : JokerGuessOp.DataOneofCase.PlayAction);
			}
		}

		// Token: 0x17002698 RID: 9880
		// (get) Token: 0x0600BF22 RID: 48930 RVA: 0x001C6433 File Offset: 0x001C4633
		// (set) Token: 0x0600BF23 RID: 48931 RVA: 0x001C644B File Offset: 0x001C464B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRoundInfo NewRoundAction
		{
			get
			{
				if (this.dataCase_ != JokerGuessOp.DataOneofCase.NewRoundAction)
				{
					return null;
				}
				return (JokerGuessRoundInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? JokerGuessOp.DataOneofCase.None : JokerGuessOp.DataOneofCase.NewRoundAction);
			}
		}

		// Token: 0x17002699 RID: 9881
		// (get) Token: 0x0600BF24 RID: 48932 RVA: 0x001C6461 File Offset: 0x001C4661
		// (set) Token: 0x0600BF25 RID: 48933 RVA: 0x001C6479 File Offset: 0x001C4679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessSkillTriggerAction SkillTriggerAction
		{
			get
			{
				if (this.dataCase_ != JokerGuessOp.DataOneofCase.SkillTriggerAction)
				{
					return null;
				}
				return (JokerGuessSkillTriggerAction)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? JokerGuessOp.DataOneofCase.None : JokerGuessOp.DataOneofCase.SkillTriggerAction);
			}
		}

		// Token: 0x1700269A RID: 9882
		// (get) Token: 0x0600BF26 RID: 48934 RVA: 0x001C648F File Offset: 0x001C468F
		// (set) Token: 0x0600BF27 RID: 48935 RVA: 0x001C64A7 File Offset: 0x001C46A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessSkillExecAction SkillExecAction
		{
			get
			{
				if (this.dataCase_ != JokerGuessOp.DataOneofCase.SkillExecAction)
				{
					return null;
				}
				return (JokerGuessSkillExecAction)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? JokerGuessOp.DataOneofCase.None : JokerGuessOp.DataOneofCase.SkillExecAction);
			}
		}

		// Token: 0x1700269B RID: 9883
		// (get) Token: 0x0600BF28 RID: 48936 RVA: 0x001C64BD File Offset: 0x001C46BD
		// (set) Token: 0x0600BF29 RID: 48937 RVA: 0x001C64D4 File Offset: 0x001C46D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessActor Winner
		{
			get
			{
				if (!this.HasWinner)
				{
					return JokerGuessActor.Who;
				}
				return (JokerGuessActor)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = JokerGuessOp.DataOneofCase.Winner;
			}
		}

		// Token: 0x1700269C RID: 9884
		// (get) Token: 0x0600BF2A RID: 48938 RVA: 0x001C64EA File Offset: 0x001C46EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasWinner
		{
			get
			{
				return this.dataCase_ == JokerGuessOp.DataOneofCase.Winner;
			}
		}

		// Token: 0x0600BF2B RID: 48939 RVA: 0x001C64F6 File Offset: 0x001C46F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearWinner()
		{
			if (this.HasWinner)
			{
				this.ClearData();
			}
		}

		// Token: 0x1700269D RID: 9885
		// (get) Token: 0x0600BF2C RID: 48940 RVA: 0x001C6506 File Offset: 0x001C4706
		// (set) Token: 0x0600BF2D RID: 48941 RVA: 0x001C651F File Offset: 0x001C471F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessHpAction HpRefreshAction
		{
			get
			{
				if (this.dataCase_ != JokerGuessOp.DataOneofCase.HpRefreshAction)
				{
					return null;
				}
				return (JokerGuessHpAction)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? JokerGuessOp.DataOneofCase.None : JokerGuessOp.DataOneofCase.HpRefreshAction);
			}
		}

		// Token: 0x1700269E RID: 9886
		// (get) Token: 0x0600BF2E RID: 48942 RVA: 0x001C6536 File Offset: 0x001C4736
		// (set) Token: 0x0600BF2F RID: 48943 RVA: 0x001C654F File Offset: 0x001C474F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDisPlayCardAction DisPlayAction
		{
			get
			{
				if (this.dataCase_ != JokerGuessOp.DataOneofCase.DisPlayAction)
				{
					return null;
				}
				return (JokerGuessDisPlayCardAction)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? JokerGuessOp.DataOneofCase.None : JokerGuessOp.DataOneofCase.DisPlayAction);
			}
		}

		// Token: 0x1700269F RID: 9887
		// (get) Token: 0x0600BF30 RID: 48944 RVA: 0x001C6566 File Offset: 0x001C4766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessOp.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0600BF31 RID: 48945 RVA: 0x001C656E File Offset: 0x001C476E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = JokerGuessOp.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0600BF32 RID: 48946 RVA: 0x001C657E File Offset: 0x001C477E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessOp);
		}

		// Token: 0x0600BF33 RID: 48947 RVA: 0x001C658C File Offset: 0x001C478C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessOp other)
		{
			return other != null && (other == this || (this.JokerGuessLevelId == other.JokerGuessLevelId && this.OpType == other.OpType && object.Equals(this.DrawAction, other.DrawAction) && object.Equals(this.PlayAction, other.PlayAction) && object.Equals(this.NewRoundAction, other.NewRoundAction) && object.Equals(this.SkillTriggerAction, other.SkillTriggerAction) && object.Equals(this.SkillExecAction, other.SkillExecAction) && this.Winner == other.Winner && object.Equals(this.HpRefreshAction, other.HpRefreshAction) && object.Equals(this.DisPlayAction, other.DisPlayAction) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF34 RID: 48948 RVA: 0x001C6688 File Offset: 0x001C4888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JokerGuessLevelId != 0)
			{
				num ^= this.JokerGuessLevelId.GetHashCode();
			}
			if (this.OpType != JokerActionType.EnterNewRound)
			{
				num ^= this.OpType.GetHashCode();
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.DrawAction)
			{
				num ^= this.DrawAction.GetHashCode();
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.PlayAction)
			{
				num ^= this.PlayAction.GetHashCode();
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.NewRoundAction)
			{
				num ^= this.NewRoundAction.GetHashCode();
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.SkillTriggerAction)
			{
				num ^= this.SkillTriggerAction.GetHashCode();
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.SkillExecAction)
			{
				num ^= this.SkillExecAction.GetHashCode();
			}
			if (this.HasWinner)
			{
				num ^= this.Winner.GetHashCode();
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.HpRefreshAction)
			{
				num ^= this.HpRefreshAction.GetHashCode();
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.DisPlayAction)
			{
				num ^= this.DisPlayAction.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BF35 RID: 48949 RVA: 0x001C67B1 File Offset: 0x001C49B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BF36 RID: 48950 RVA: 0x001C67BE File Offset: 0x001C49BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF37 RID: 48951 RVA: 0x001C67C8 File Offset: 0x001C49C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JokerGuessLevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.JokerGuessLevelId);
			}
			if (this.OpType != JokerActionType.EnterNewRound)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.OpType);
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.DrawAction)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.DrawAction);
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.PlayAction)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.PlayAction);
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.NewRoundAction)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.NewRoundAction);
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.SkillTriggerAction)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.SkillTriggerAction);
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.SkillExecAction)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.SkillExecAction);
			}
			if (this.HasWinner)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Winner);
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.HpRefreshAction)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.HpRefreshAction);
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.DisPlayAction)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.DisPlayAction);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF38 RID: 48952 RVA: 0x001C690C File Offset: 0x001C4B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JokerGuessLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.JokerGuessLevelId);
			}
			if (this.OpType != JokerActionType.EnterNewRound)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OpType);
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.DrawAction)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DrawAction);
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.PlayAction)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayAction);
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.NewRoundAction)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewRoundAction);
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.SkillTriggerAction)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillTriggerAction);
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.SkillExecAction)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillExecAction);
			}
			if (this.HasWinner)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Winner);
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.HpRefreshAction)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HpRefreshAction);
			}
			if (this.dataCase_ == JokerGuessOp.DataOneofCase.DisPlayAction)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DisPlayAction);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BF39 RID: 48953 RVA: 0x001C6A2C File Offset: 0x001C4C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessOp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JokerGuessLevelId != 0)
			{
				this.JokerGuessLevelId = other.JokerGuessLevelId;
			}
			if (other.OpType != JokerActionType.EnterNewRound)
			{
				this.OpType = other.OpType;
			}
			switch (other.DataCase)
			{
			case JokerGuessOp.DataOneofCase.DrawAction:
				if (this.DrawAction == null)
				{
					this.DrawAction = new JokerGuessDrawCardAction();
				}
				this.DrawAction.MergeFrom(other.DrawAction);
				break;
			case JokerGuessOp.DataOneofCase.PlayAction:
				if (this.PlayAction == null)
				{
					this.PlayAction = new JokerGuessPlayCardAction();
				}
				this.PlayAction.MergeFrom(other.PlayAction);
				break;
			case JokerGuessOp.DataOneofCase.NewRoundAction:
				if (this.NewRoundAction == null)
				{
					this.NewRoundAction = new JokerGuessRoundInfo();
				}
				this.NewRoundAction.MergeFrom(other.NewRoundAction);
				break;
			case JokerGuessOp.DataOneofCase.SkillTriggerAction:
				if (this.SkillTriggerAction == null)
				{
					this.SkillTriggerAction = new JokerGuessSkillTriggerAction();
				}
				this.SkillTriggerAction.MergeFrom(other.SkillTriggerAction);
				break;
			case JokerGuessOp.DataOneofCase.SkillExecAction:
				if (this.SkillExecAction == null)
				{
					this.SkillExecAction = new JokerGuessSkillExecAction();
				}
				this.SkillExecAction.MergeFrom(other.SkillExecAction);
				break;
			case JokerGuessOp.DataOneofCase.Winner:
				this.Winner = other.Winner;
				break;
			case JokerGuessOp.DataOneofCase.HpRefreshAction:
				if (this.HpRefreshAction == null)
				{
					this.HpRefreshAction = new JokerGuessHpAction();
				}
				this.HpRefreshAction.MergeFrom(other.HpRefreshAction);
				break;
			case JokerGuessOp.DataOneofCase.DisPlayAction:
				if (this.DisPlayAction == null)
				{
					this.DisPlayAction = new JokerGuessDisPlayCardAction();
				}
				this.DisPlayAction.MergeFrom(other.DisPlayAction);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BF3A RID: 48954 RVA: 0x001C6BCF File Offset: 0x001C4DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF3B RID: 48955 RVA: 0x001C6BD8 File Offset: 0x001C4DD8
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
				if (num <= 50U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.JokerGuessLevelId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.OpType = (JokerActionType)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							JokerGuessDrawCardAction jokerGuessDrawCardAction = new JokerGuessDrawCardAction();
							if (this.dataCase_ == JokerGuessOp.DataOneofCase.DrawAction)
							{
								jokerGuessDrawCardAction.MergeFrom(this.DrawAction);
							}
							input.ReadMessage(jokerGuessDrawCardAction);
							this.DrawAction = jokerGuessDrawCardAction;
							continue;
						}
						if (num == 42U)
						{
							JokerGuessPlayCardAction jokerGuessPlayCardAction = new JokerGuessPlayCardAction();
							if (this.dataCase_ == JokerGuessOp.DataOneofCase.PlayAction)
							{
								jokerGuessPlayCardAction.MergeFrom(this.PlayAction);
							}
							input.ReadMessage(jokerGuessPlayCardAction);
							this.PlayAction = jokerGuessPlayCardAction;
							continue;
						}
						if (num == 50U)
						{
							JokerGuessRoundInfo jokerGuessRoundInfo = new JokerGuessRoundInfo();
							if (this.dataCase_ == JokerGuessOp.DataOneofCase.NewRoundAction)
							{
								jokerGuessRoundInfo.MergeFrom(this.NewRoundAction);
							}
							input.ReadMessage(jokerGuessRoundInfo);
							this.NewRoundAction = jokerGuessRoundInfo;
							continue;
						}
					}
				}
				else if (num <= 66U)
				{
					if (num == 58U)
					{
						JokerGuessSkillTriggerAction jokerGuessSkillTriggerAction = new JokerGuessSkillTriggerAction();
						if (this.dataCase_ == JokerGuessOp.DataOneofCase.SkillTriggerAction)
						{
							jokerGuessSkillTriggerAction.MergeFrom(this.SkillTriggerAction);
						}
						input.ReadMessage(jokerGuessSkillTriggerAction);
						this.SkillTriggerAction = jokerGuessSkillTriggerAction;
						continue;
					}
					if (num == 66U)
					{
						JokerGuessSkillExecAction jokerGuessSkillExecAction = new JokerGuessSkillExecAction();
						if (this.dataCase_ == JokerGuessOp.DataOneofCase.SkillExecAction)
						{
							jokerGuessSkillExecAction.MergeFrom(this.SkillExecAction);
						}
						input.ReadMessage(jokerGuessSkillExecAction);
						this.SkillExecAction = jokerGuessSkillExecAction;
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.data_ = input.ReadEnum();
						this.dataCase_ = JokerGuessOp.DataOneofCase.Winner;
						continue;
					}
					if (num == 82U)
					{
						JokerGuessHpAction jokerGuessHpAction = new JokerGuessHpAction();
						if (this.dataCase_ == JokerGuessOp.DataOneofCase.HpRefreshAction)
						{
							jokerGuessHpAction.MergeFrom(this.HpRefreshAction);
						}
						input.ReadMessage(jokerGuessHpAction);
						this.HpRefreshAction = jokerGuessHpAction;
						continue;
					}
					if (num == 90U)
					{
						JokerGuessDisPlayCardAction jokerGuessDisPlayCardAction = new JokerGuessDisPlayCardAction();
						if (this.dataCase_ == JokerGuessOp.DataOneofCase.DisPlayAction)
						{
							jokerGuessDisPlayCardAction.MergeFrom(this.DisPlayAction);
						}
						input.ReadMessage(jokerGuessDisPlayCardAction);
						this.DisPlayAction = jokerGuessDisPlayCardAction;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005390 RID: 21392
		private static readonly MessageParser<JokerGuessOp> _parser = new MessageParser<JokerGuessOp>(() => new JokerGuessOp());

		// Token: 0x04005391 RID: 21393
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005392 RID: 21394
		public const int JokerGuessLevelIdFieldNumber = 1;

		// Token: 0x04005393 RID: 21395
		private int jokerGuessLevelId_;

		// Token: 0x04005394 RID: 21396
		public const int OpTypeFieldNumber = 2;

		// Token: 0x04005395 RID: 21397
		private JokerActionType opType_;

		// Token: 0x04005396 RID: 21398
		public const int DrawActionFieldNumber = 4;

		// Token: 0x04005397 RID: 21399
		public const int PlayActionFieldNumber = 5;

		// Token: 0x04005398 RID: 21400
		public const int NewRoundActionFieldNumber = 6;

		// Token: 0x04005399 RID: 21401
		public const int SkillTriggerActionFieldNumber = 7;

		// Token: 0x0400539A RID: 21402
		public const int SkillExecActionFieldNumber = 8;

		// Token: 0x0400539B RID: 21403
		public const int WinnerFieldNumber = 9;

		// Token: 0x0400539C RID: 21404
		public const int HpRefreshActionFieldNumber = 10;

		// Token: 0x0400539D RID: 21405
		public const int DisPlayActionFieldNumber = 11;

		// Token: 0x0400539E RID: 21406
		private object data_;

		// Token: 0x0400539F RID: 21407
		private JokerGuessOp.DataOneofCase dataCase_;

		// Token: 0x02001881 RID: 6273
		public enum DataOneofCase
		{
			// Token: 0x0400CCDC RID: 52444
			None,
			// Token: 0x0400CCDD RID: 52445
			DrawAction = 4,
			// Token: 0x0400CCDE RID: 52446
			PlayAction,
			// Token: 0x0400CCDF RID: 52447
			NewRoundAction,
			// Token: 0x0400CCE0 RID: 52448
			SkillTriggerAction,
			// Token: 0x0400CCE1 RID: 52449
			SkillExecAction,
			// Token: 0x0400CCE2 RID: 52450
			Winner,
			// Token: 0x0400CCE3 RID: 52451
			HpRefreshAction,
			// Token: 0x0400CCE4 RID: 52452
			DisPlayAction
		}
	}
}
