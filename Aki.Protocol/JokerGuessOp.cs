using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200086E RID: 2158
	public sealed class JokerGuessOp : IMessage<JokerGuessOp>, IMessage, IEquatable<JokerGuessOp>, IDeepCloneable<JokerGuessOp>, IBufferMessage
	{
		// Token: 0x0600C02F RID: 49199 RVA: 0x001C8574 File Offset: 0x001C6774
		[NullableContext(1)]
		public static JokerGuessOp Create()
		{
			return new JokerGuessOp();
		}

		// Token: 0x170026D0 RID: 9936
		// (get) Token: 0x0600C030 RID: 49200 RVA: 0x001C857B File Offset: 0x001C677B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JokerGuessOp> Parser
		{
			get
			{
				return JokerGuessOp._parser;
			}
		}

		// Token: 0x170026D1 RID: 9937
		// (get) Token: 0x0600C031 RID: 49201 RVA: 0x001C8582 File Offset: 0x001C6782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026D2 RID: 9938
		// (get) Token: 0x0600C032 RID: 49202 RVA: 0x001C8585 File Offset: 0x001C6785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessOp.Descriptor;
			}
		}

		// Token: 0x0600C033 RID: 49203 RVA: 0x001C858C File Offset: 0x001C678C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessOp()
		{
		}

		// Token: 0x0600C034 RID: 49204 RVA: 0x001C8594 File Offset: 0x001C6794
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

		// Token: 0x0600C035 RID: 49205 RVA: 0x001C8695 File Offset: 0x001C6895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessOp Clone()
		{
			return new JokerGuessOp(this);
		}

		// Token: 0x170026D3 RID: 9939
		// (get) Token: 0x0600C036 RID: 49206 RVA: 0x001C869D File Offset: 0x001C689D
		// (set) Token: 0x0600C037 RID: 49207 RVA: 0x001C86A5 File Offset: 0x001C68A5
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

		// Token: 0x170026D4 RID: 9940
		// (get) Token: 0x0600C038 RID: 49208 RVA: 0x001C86AE File Offset: 0x001C68AE
		// (set) Token: 0x0600C039 RID: 49209 RVA: 0x001C86B6 File Offset: 0x001C68B6
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

		// Token: 0x170026D5 RID: 9941
		// (get) Token: 0x0600C03A RID: 49210 RVA: 0x001C86BF File Offset: 0x001C68BF
		// (set) Token: 0x0600C03B RID: 49211 RVA: 0x001C86D7 File Offset: 0x001C68D7
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

		// Token: 0x170026D6 RID: 9942
		// (get) Token: 0x0600C03C RID: 49212 RVA: 0x001C86ED File Offset: 0x001C68ED
		// (set) Token: 0x0600C03D RID: 49213 RVA: 0x001C8705 File Offset: 0x001C6905
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

		// Token: 0x170026D7 RID: 9943
		// (get) Token: 0x0600C03E RID: 49214 RVA: 0x001C871B File Offset: 0x001C691B
		// (set) Token: 0x0600C03F RID: 49215 RVA: 0x001C8733 File Offset: 0x001C6933
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

		// Token: 0x170026D8 RID: 9944
		// (get) Token: 0x0600C040 RID: 49216 RVA: 0x001C8749 File Offset: 0x001C6949
		// (set) Token: 0x0600C041 RID: 49217 RVA: 0x001C8761 File Offset: 0x001C6961
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

		// Token: 0x170026D9 RID: 9945
		// (get) Token: 0x0600C042 RID: 49218 RVA: 0x001C8777 File Offset: 0x001C6977
		// (set) Token: 0x0600C043 RID: 49219 RVA: 0x001C878F File Offset: 0x001C698F
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

		// Token: 0x170026DA RID: 9946
		// (get) Token: 0x0600C044 RID: 49220 RVA: 0x001C87A5 File Offset: 0x001C69A5
		// (set) Token: 0x0600C045 RID: 49221 RVA: 0x001C87BC File Offset: 0x001C69BC
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

		// Token: 0x170026DB RID: 9947
		// (get) Token: 0x0600C046 RID: 49222 RVA: 0x001C87D2 File Offset: 0x001C69D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasWinner
		{
			get
			{
				return this.dataCase_ == JokerGuessOp.DataOneofCase.Winner;
			}
		}

		// Token: 0x0600C047 RID: 49223 RVA: 0x001C87DE File Offset: 0x001C69DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearWinner()
		{
			if (this.HasWinner)
			{
				this.ClearData();
			}
		}

		// Token: 0x170026DC RID: 9948
		// (get) Token: 0x0600C048 RID: 49224 RVA: 0x001C87EE File Offset: 0x001C69EE
		// (set) Token: 0x0600C049 RID: 49225 RVA: 0x001C8807 File Offset: 0x001C6A07
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

		// Token: 0x170026DD RID: 9949
		// (get) Token: 0x0600C04A RID: 49226 RVA: 0x001C881E File Offset: 0x001C6A1E
		// (set) Token: 0x0600C04B RID: 49227 RVA: 0x001C8837 File Offset: 0x001C6A37
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

		// Token: 0x170026DE RID: 9950
		// (get) Token: 0x0600C04C RID: 49228 RVA: 0x001C884E File Offset: 0x001C6A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessOp.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0600C04D RID: 49229 RVA: 0x001C8856 File Offset: 0x001C6A56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = JokerGuessOp.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0600C04E RID: 49230 RVA: 0x001C8866 File Offset: 0x001C6A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessOp);
		}

		// Token: 0x0600C04F RID: 49231 RVA: 0x001C8874 File Offset: 0x001C6A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessOp other)
		{
			return other != null && (other == this || (this.JokerGuessLevelId == other.JokerGuessLevelId && this.OpType == other.OpType && object.Equals(this.DrawAction, other.DrawAction) && object.Equals(this.PlayAction, other.PlayAction) && object.Equals(this.NewRoundAction, other.NewRoundAction) && object.Equals(this.SkillTriggerAction, other.SkillTriggerAction) && object.Equals(this.SkillExecAction, other.SkillExecAction) && this.Winner == other.Winner && object.Equals(this.HpRefreshAction, other.HpRefreshAction) && object.Equals(this.DisPlayAction, other.DisPlayAction) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C050 RID: 49232 RVA: 0x001C8970 File Offset: 0x001C6B70
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

		// Token: 0x0600C051 RID: 49233 RVA: 0x001C8A99 File Offset: 0x001C6C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C052 RID: 49234 RVA: 0x001C8AA6 File Offset: 0x001C6CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C053 RID: 49235 RVA: 0x001C8AB0 File Offset: 0x001C6CB0
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

		// Token: 0x0600C054 RID: 49236 RVA: 0x001C8BF4 File Offset: 0x001C6DF4
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

		// Token: 0x0600C055 RID: 49237 RVA: 0x001C8D14 File Offset: 0x001C6F14
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

		// Token: 0x0600C056 RID: 49238 RVA: 0x001C8EB7 File Offset: 0x001C70B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C057 RID: 49239 RVA: 0x001C8EC0 File Offset: 0x001C70C0
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

		// Token: 0x04005389 RID: 21385
		private static readonly MessageParser<JokerGuessOp> _parser = new MessageParser<JokerGuessOp>(() => new JokerGuessOp());

		// Token: 0x0400538A RID: 21386
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400538B RID: 21387
		public const int JokerGuessLevelIdFieldNumber = 1;

		// Token: 0x0400538C RID: 21388
		private int jokerGuessLevelId_;

		// Token: 0x0400538D RID: 21389
		public const int OpTypeFieldNumber = 2;

		// Token: 0x0400538E RID: 21390
		private JokerActionType opType_;

		// Token: 0x0400538F RID: 21391
		public const int DrawActionFieldNumber = 4;

		// Token: 0x04005390 RID: 21392
		public const int PlayActionFieldNumber = 5;

		// Token: 0x04005391 RID: 21393
		public const int NewRoundActionFieldNumber = 6;

		// Token: 0x04005392 RID: 21394
		public const int SkillTriggerActionFieldNumber = 7;

		// Token: 0x04005393 RID: 21395
		public const int SkillExecActionFieldNumber = 8;

		// Token: 0x04005394 RID: 21396
		public const int WinnerFieldNumber = 9;

		// Token: 0x04005395 RID: 21397
		public const int HpRefreshActionFieldNumber = 10;

		// Token: 0x04005396 RID: 21398
		public const int DisPlayActionFieldNumber = 11;

		// Token: 0x04005397 RID: 21399
		private object data_;

		// Token: 0x04005398 RID: 21400
		private JokerGuessOp.DataOneofCase dataCase_;

		// Token: 0x02001809 RID: 6153
		public enum DataOneofCase
		{
			// Token: 0x0400C7B1 RID: 51121
			None,
			// Token: 0x0400C7B2 RID: 51122
			DrawAction = 4,
			// Token: 0x0400C7B3 RID: 51123
			PlayAction,
			// Token: 0x0400C7B4 RID: 51124
			NewRoundAction,
			// Token: 0x0400C7B5 RID: 51125
			SkillTriggerAction,
			// Token: 0x0400C7B6 RID: 51126
			SkillExecAction,
			// Token: 0x0400C7B7 RID: 51127
			Winner,
			// Token: 0x0400C7B8 RID: 51128
			HpRefreshAction,
			// Token: 0x0400C7B9 RID: 51129
			DisPlayAction
		}
	}
}
