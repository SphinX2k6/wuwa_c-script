using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000073 RID: 115
	public sealed class ActionOpenSystemParam : IMessage<ActionOpenSystemParam>, IMessage, IEquatable<ActionOpenSystemParam>, IDeepCloneable<ActionOpenSystemParam>, IBufferMessage
	{
		// Token: 0x060017C9 RID: 6089 RVA: 0x0003E163 File Offset: 0x0003C363
		[NullableContext(1)]
		public static ActionOpenSystemParam Create()
		{
			return new ActionOpenSystemParam();
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x0003E16A File Offset: 0x0003C36A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x0003E16D File Offset: 0x0003C36D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionOpenSystemParam.Descriptor;
			}
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x0003E174 File Offset: 0x0003C374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOpenSystemParam()
		{
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x0003E17C File Offset: 0x0003C37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOpenSystemParam(ActionOpenSystemParam other) : this()
		{
			this.actionOpenType_ = other.actionOpenType_;
			this.incId_ = other.incId_;
			switch (other.MessageCase)
			{
			case ActionOpenSystemParam.MessageOneofCase.OpenSystemBoardData:
				this.OpenSystemBoardData = other.OpenSystemBoardData.Clone();
				break;
			case ActionOpenSystemParam.MessageOneofCase.SoaringChallengeData:
				this.SoaringChallengeData = other.SoaringChallengeData.Clone();
				break;
			case ActionOpenSystemParam.MessageOneofCase.FishingHandInData:
				this.FishingHandInData = other.FishingHandInData.Clone();
				break;
			case ActionOpenSystemParam.MessageOneofCase.GreatSwordChallengeData:
				this.GreatSwordChallengeData = other.GreatSwordChallengeData.Clone();
				break;
			case ActionOpenSystemParam.MessageOneofCase.InfrHandInData:
				this.InfrHandInData = other.InfrHandInData.Clone();
				break;
			case ActionOpenSystemParam.MessageOneofCase.MotorRaceChallengeData:
				this.MotorRaceChallengeData = other.MotorRaceChallengeData.Clone();
				break;
			case ActionOpenSystemParam.MessageOneofCase.InfrV2HandInData:
				this.InfrV2HandInData = other.InfrV2HandInData.Clone();
				break;
			case ActionOpenSystemParam.MessageOneofCase.GiantSystemBoardData:
				this.GiantSystemBoardData = other.GiantSystemBoardData.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x0003E285 File Offset: 0x0003C485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOpenSystemParam Clone()
		{
			return new ActionOpenSystemParam(this);
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x0003E28D File Offset: 0x0003C48D
		// (set) Token: 0x060017D0 RID: 6096 RVA: 0x0003E295 File Offset: 0x0003C495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOpenSystemType ActionOpenType
		{
			get
			{
				return this.actionOpenType_;
			}
			set
			{
				this.actionOpenType_ = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x0003E29E File Offset: 0x0003C49E
		// (set) Token: 0x060017D2 RID: 6098 RVA: 0x0003E2A6 File Offset: 0x0003C4A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x0003E2AF File Offset: 0x0003C4AF
		// (set) Token: 0x060017D4 RID: 6100 RVA: 0x0003E2C7 File Offset: 0x0003C4C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardData OpenSystemBoardData
		{
			get
			{
				if (this.messageCase_ != ActionOpenSystemParam.MessageOneofCase.OpenSystemBoardData)
				{
					return null;
				}
				return (OpenSystemBoardData)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? ActionOpenSystemParam.MessageOneofCase.None : ActionOpenSystemParam.MessageOneofCase.OpenSystemBoardData);
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060017D5 RID: 6101 RVA: 0x0003E2DD File Offset: 0x0003C4DD
		// (set) Token: 0x060017D6 RID: 6102 RVA: 0x0003E2F5 File Offset: 0x0003C4F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SoaringChallengeData SoaringChallengeData
		{
			get
			{
				if (this.messageCase_ != ActionOpenSystemParam.MessageOneofCase.SoaringChallengeData)
				{
					return null;
				}
				return (SoaringChallengeData)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? ActionOpenSystemParam.MessageOneofCase.None : ActionOpenSystemParam.MessageOneofCase.SoaringChallengeData);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060017D7 RID: 6103 RVA: 0x0003E30B File Offset: 0x0003C50B
		// (set) Token: 0x060017D8 RID: 6104 RVA: 0x0003E323 File Offset: 0x0003C523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInData FishingHandInData
		{
			get
			{
				if (this.messageCase_ != ActionOpenSystemParam.MessageOneofCase.FishingHandInData)
				{
					return null;
				}
				return (FishingHandInData)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? ActionOpenSystemParam.MessageOneofCase.None : ActionOpenSystemParam.MessageOneofCase.FishingHandInData);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060017D9 RID: 6105 RVA: 0x0003E339 File Offset: 0x0003C539
		// (set) Token: 0x060017DA RID: 6106 RVA: 0x0003E351 File Offset: 0x0003C551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GreatSwordChallengeData GreatSwordChallengeData
		{
			get
			{
				if (this.messageCase_ != ActionOpenSystemParam.MessageOneofCase.GreatSwordChallengeData)
				{
					return null;
				}
				return (GreatSwordChallengeData)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? ActionOpenSystemParam.MessageOneofCase.None : ActionOpenSystemParam.MessageOneofCase.GreatSwordChallengeData);
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060017DB RID: 6107 RVA: 0x0003E367 File Offset: 0x0003C567
		// (set) Token: 0x060017DC RID: 6108 RVA: 0x0003E37F File Offset: 0x0003C57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrHandInData InfrHandInData
		{
			get
			{
				if (this.messageCase_ != ActionOpenSystemParam.MessageOneofCase.InfrHandInData)
				{
					return null;
				}
				return (InfrHandInData)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? ActionOpenSystemParam.MessageOneofCase.None : ActionOpenSystemParam.MessageOneofCase.InfrHandInData);
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x0003E395 File Offset: 0x0003C595
		// (set) Token: 0x060017DE RID: 6110 RVA: 0x0003E3AD File Offset: 0x0003C5AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorRaceChallengeData MotorRaceChallengeData
		{
			get
			{
				if (this.messageCase_ != ActionOpenSystemParam.MessageOneofCase.MotorRaceChallengeData)
				{
					return null;
				}
				return (MotorRaceChallengeData)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? ActionOpenSystemParam.MessageOneofCase.None : ActionOpenSystemParam.MessageOneofCase.MotorRaceChallengeData);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x0003E3C3 File Offset: 0x0003C5C3
		// (set) Token: 0x060017E0 RID: 6112 RVA: 0x0003E3DC File Offset: 0x0003C5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2HandInData InfrV2HandInData
		{
			get
			{
				if (this.messageCase_ != ActionOpenSystemParam.MessageOneofCase.InfrV2HandInData)
				{
					return null;
				}
				return (InfrV2HandInData)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? ActionOpenSystemParam.MessageOneofCase.None : ActionOpenSystemParam.MessageOneofCase.InfrV2HandInData);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060017E1 RID: 6113 RVA: 0x0003E3F3 File Offset: 0x0003C5F3
		// (set) Token: 0x060017E2 RID: 6114 RVA: 0x0003E40C File Offset: 0x0003C60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantSystemBoardData GiantSystemBoardData
		{
			get
			{
				if (this.messageCase_ != ActionOpenSystemParam.MessageOneofCase.GiantSystemBoardData)
				{
					return null;
				}
				return (GiantSystemBoardData)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? ActionOpenSystemParam.MessageOneofCase.None : ActionOpenSystemParam.MessageOneofCase.GiantSystemBoardData);
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060017E3 RID: 6115 RVA: 0x0003E423 File Offset: 0x0003C623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOpenSystemParam.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x0003E42B File Offset: 0x0003C62B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessage()
		{
			this.messageCase_ = ActionOpenSystemParam.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x0003E43B File Offset: 0x0003C63B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionOpenSystemParam);
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x0003E44C File Offset: 0x0003C64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionOpenSystemParam other)
		{
			return other != null && (other == this || (this.ActionOpenType == other.ActionOpenType && this.IncId == other.IncId && object.Equals(this.OpenSystemBoardData, other.OpenSystemBoardData) && object.Equals(this.SoaringChallengeData, other.SoaringChallengeData) && object.Equals(this.FishingHandInData, other.FishingHandInData) && object.Equals(this.GreatSwordChallengeData, other.GreatSwordChallengeData) && object.Equals(this.InfrHandInData, other.InfrHandInData) && object.Equals(this.MotorRaceChallengeData, other.MotorRaceChallengeData) && object.Equals(this.InfrV2HandInData, other.InfrV2HandInData) && object.Equals(this.GiantSystemBoardData, other.GiantSystemBoardData) && this.MessageCase == other.MessageCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x0003E550 File Offset: 0x0003C750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActionOpenType != ActionOpenSystemType.None)
			{
				num ^= this.ActionOpenType.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.OpenSystemBoardData)
			{
				num ^= this.OpenSystemBoardData.GetHashCode();
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.SoaringChallengeData)
			{
				num ^= this.SoaringChallengeData.GetHashCode();
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.FishingHandInData)
			{
				num ^= this.FishingHandInData.GetHashCode();
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.GreatSwordChallengeData)
			{
				num ^= this.GreatSwordChallengeData.GetHashCode();
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.InfrHandInData)
			{
				num ^= this.InfrHandInData.GetHashCode();
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.MotorRaceChallengeData)
			{
				num ^= this.MotorRaceChallengeData.GetHashCode();
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.InfrV2HandInData)
			{
				num ^= this.InfrV2HandInData.GetHashCode();
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.GiantSystemBoardData)
			{
				num ^= this.GiantSystemBoardData.GetHashCode();
			}
			num ^= (int)this.messageCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x0003E671 File Offset: 0x0003C871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x0003E67E File Offset: 0x0003C87E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x0003E688 File Offset: 0x0003C888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActionOpenType != ActionOpenSystemType.None)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ActionOpenType);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.IncId);
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.OpenSystemBoardData)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.OpenSystemBoardData);
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.SoaringChallengeData)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.SoaringChallengeData);
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.FishingHandInData)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.FishingHandInData);
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.GreatSwordChallengeData)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.GreatSwordChallengeData);
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.InfrHandInData)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.InfrHandInData);
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.MotorRaceChallengeData)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.MotorRaceChallengeData);
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.InfrV2HandInData)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.InfrV2HandInData);
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.GiantSystemBoardData)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.GiantSystemBoardData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x0003E7CC File Offset: 0x0003C9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActionOpenType != ActionOpenSystemType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ActionOpenType);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.OpenSystemBoardData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OpenSystemBoardData);
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.SoaringChallengeData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SoaringChallengeData);
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.FishingHandInData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FishingHandInData);
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.GreatSwordChallengeData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GreatSwordChallengeData);
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.InfrHandInData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InfrHandInData);
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.MotorRaceChallengeData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MotorRaceChallengeData);
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.InfrV2HandInData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InfrV2HandInData);
			}
			if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.GiantSystemBoardData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GiantSystemBoardData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x0003E8EC File Offset: 0x0003CAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionOpenSystemParam other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActionOpenType != ActionOpenSystemType.None)
			{
				this.ActionOpenType = other.ActionOpenType;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			switch (other.MessageCase)
			{
			case ActionOpenSystemParam.MessageOneofCase.OpenSystemBoardData:
				if (this.OpenSystemBoardData == null)
				{
					this.OpenSystemBoardData = new OpenSystemBoardData();
				}
				this.OpenSystemBoardData.MergeFrom(other.OpenSystemBoardData);
				break;
			case ActionOpenSystemParam.MessageOneofCase.SoaringChallengeData:
				if (this.SoaringChallengeData == null)
				{
					this.SoaringChallengeData = new SoaringChallengeData();
				}
				this.SoaringChallengeData.MergeFrom(other.SoaringChallengeData);
				break;
			case ActionOpenSystemParam.MessageOneofCase.FishingHandInData:
				if (this.FishingHandInData == null)
				{
					this.FishingHandInData = new FishingHandInData();
				}
				this.FishingHandInData.MergeFrom(other.FishingHandInData);
				break;
			case ActionOpenSystemParam.MessageOneofCase.GreatSwordChallengeData:
				if (this.GreatSwordChallengeData == null)
				{
					this.GreatSwordChallengeData = new GreatSwordChallengeData();
				}
				this.GreatSwordChallengeData.MergeFrom(other.GreatSwordChallengeData);
				break;
			case ActionOpenSystemParam.MessageOneofCase.InfrHandInData:
				if (this.InfrHandInData == null)
				{
					this.InfrHandInData = new InfrHandInData();
				}
				this.InfrHandInData.MergeFrom(other.InfrHandInData);
				break;
			case ActionOpenSystemParam.MessageOneofCase.MotorRaceChallengeData:
				if (this.MotorRaceChallengeData == null)
				{
					this.MotorRaceChallengeData = new MotorRaceChallengeData();
				}
				this.MotorRaceChallengeData.MergeFrom(other.MotorRaceChallengeData);
				break;
			case ActionOpenSystemParam.MessageOneofCase.InfrV2HandInData:
				if (this.InfrV2HandInData == null)
				{
					this.InfrV2HandInData = new InfrV2HandInData();
				}
				this.InfrV2HandInData.MergeFrom(other.InfrV2HandInData);
				break;
			case ActionOpenSystemParam.MessageOneofCase.GiantSystemBoardData:
				if (this.GiantSystemBoardData == null)
				{
					this.GiantSystemBoardData = new GiantSystemBoardData();
				}
				this.GiantSystemBoardData.MergeFrom(other.GiantSystemBoardData);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x0003EAAA File Offset: 0x0003CCAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x0003EAB4 File Offset: 0x0003CCB4
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
				if (num <= 42U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.ActionOpenType = (ActionOpenSystemType)input.ReadEnum();
							continue;
						}
						if (num == 16U)
						{
							this.IncId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							OpenSystemBoardData openSystemBoardData = new OpenSystemBoardData();
							if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.OpenSystemBoardData)
							{
								openSystemBoardData.MergeFrom(this.OpenSystemBoardData);
							}
							input.ReadMessage(openSystemBoardData);
							this.OpenSystemBoardData = openSystemBoardData;
							continue;
						}
						if (num == 34U)
						{
							SoaringChallengeData soaringChallengeData = new SoaringChallengeData();
							if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.SoaringChallengeData)
							{
								soaringChallengeData.MergeFrom(this.SoaringChallengeData);
							}
							input.ReadMessage(soaringChallengeData);
							this.SoaringChallengeData = soaringChallengeData;
							continue;
						}
						if (num == 42U)
						{
							FishingHandInData fishingHandInData = new FishingHandInData();
							if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.FishingHandInData)
							{
								fishingHandInData.MergeFrom(this.FishingHandInData);
							}
							input.ReadMessage(fishingHandInData);
							this.FishingHandInData = fishingHandInData;
							continue;
						}
					}
				}
				else if (num <= 58U)
				{
					if (num == 50U)
					{
						GreatSwordChallengeData greatSwordChallengeData = new GreatSwordChallengeData();
						if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.GreatSwordChallengeData)
						{
							greatSwordChallengeData.MergeFrom(this.GreatSwordChallengeData);
						}
						input.ReadMessage(greatSwordChallengeData);
						this.GreatSwordChallengeData = greatSwordChallengeData;
						continue;
					}
					if (num == 58U)
					{
						InfrHandInData infrHandInData = new InfrHandInData();
						if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.InfrHandInData)
						{
							infrHandInData.MergeFrom(this.InfrHandInData);
						}
						input.ReadMessage(infrHandInData);
						this.InfrHandInData = infrHandInData;
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						MotorRaceChallengeData motorRaceChallengeData = new MotorRaceChallengeData();
						if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.MotorRaceChallengeData)
						{
							motorRaceChallengeData.MergeFrom(this.MotorRaceChallengeData);
						}
						input.ReadMessage(motorRaceChallengeData);
						this.MotorRaceChallengeData = motorRaceChallengeData;
						continue;
					}
					if (num == 74U)
					{
						InfrV2HandInData infrV2HandInData = new InfrV2HandInData();
						if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.InfrV2HandInData)
						{
							infrV2HandInData.MergeFrom(this.InfrV2HandInData);
						}
						input.ReadMessage(infrV2HandInData);
						this.InfrV2HandInData = infrV2HandInData;
						continue;
					}
					if (num == 82U)
					{
						GiantSystemBoardData giantSystemBoardData = new GiantSystemBoardData();
						if (this.messageCase_ == ActionOpenSystemParam.MessageOneofCase.GiantSystemBoardData)
						{
							giantSystemBoardData.MergeFrom(this.GiantSystemBoardData);
						}
						input.ReadMessage(giantSystemBoardData);
						this.GiantSystemBoardData = giantSystemBoardData;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002192 RID: 8594
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002193 RID: 8595
		public const int ActionOpenTypeFieldNumber = 1;

		// Token: 0x04002194 RID: 8596
		private ActionOpenSystemType actionOpenType_;

		// Token: 0x04002195 RID: 8597
		public const int IncIdFieldNumber = 2;

		// Token: 0x04002196 RID: 8598
		private int incId_;

		// Token: 0x04002197 RID: 8599
		public const int OpenSystemBoardDataFieldNumber = 3;

		// Token: 0x04002198 RID: 8600
		public const int SoaringChallengeDataFieldNumber = 4;

		// Token: 0x04002199 RID: 8601
		public const int FishingHandInDataFieldNumber = 5;

		// Token: 0x0400219A RID: 8602
		public const int GreatSwordChallengeDataFieldNumber = 6;

		// Token: 0x0400219B RID: 8603
		public const int InfrHandInDataFieldNumber = 7;

		// Token: 0x0400219C RID: 8604
		public const int MotorRaceChallengeDataFieldNumber = 8;

		// Token: 0x0400219D RID: 8605
		public const int InfrV2HandInDataFieldNumber = 9;

		// Token: 0x0400219E RID: 8606
		public const int GiantSystemBoardDataFieldNumber = 10;

		// Token: 0x0400219F RID: 8607
		private object message_;

		// Token: 0x040021A0 RID: 8608
		private ActionOpenSystemParam.MessageOneofCase messageCase_;

		// Token: 0x0200174E RID: 5966
		public enum MessageOneofCase
		{
			// Token: 0x0400C9C0 RID: 51648
			None,
			// Token: 0x0400C9C1 RID: 51649
			OpenSystemBoardData = 3,
			// Token: 0x0400C9C2 RID: 51650
			SoaringChallengeData,
			// Token: 0x0400C9C3 RID: 51651
			FishingHandInData,
			// Token: 0x0400C9C4 RID: 51652
			GreatSwordChallengeData,
			// Token: 0x0400C9C5 RID: 51653
			InfrHandInData,
			// Token: 0x0400C9C6 RID: 51654
			MotorRaceChallengeData,
			// Token: 0x0400C9C7 RID: 51655
			InfrV2HandInData,
			// Token: 0x0400C9C8 RID: 51656
			GiantSystemBoardData
		}
	}
}
