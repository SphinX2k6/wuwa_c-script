using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000072 RID: 114
	public sealed class ActionOpenSystemParam : IMessage<ActionOpenSystemParam>, IMessage, IEquatable<ActionOpenSystemParam>, IDeepCloneable<ActionOpenSystemParam>, IBufferMessage
	{
		// Token: 0x06001786 RID: 6022 RVA: 0x0003D7BF File Offset: 0x0003B9BF
		[NullableContext(1)]
		public static ActionOpenSystemParam Create()
		{
			return new ActionOpenSystemParam();
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x0003D7C6 File Offset: 0x0003B9C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x0003D7C9 File Offset: 0x0003B9C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionOpenSystemParam.Descriptor;
			}
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x0003D7D0 File Offset: 0x0003B9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOpenSystemParam()
		{
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x0003D7D8 File Offset: 0x0003B9D8
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

		// Token: 0x0600178B RID: 6027 RVA: 0x0003D8E1 File Offset: 0x0003BAE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOpenSystemParam Clone()
		{
			return new ActionOpenSystemParam(this);
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x0003D8E9 File Offset: 0x0003BAE9
		// (set) Token: 0x0600178D RID: 6029 RVA: 0x0003D8F1 File Offset: 0x0003BAF1
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

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x0003D8FA File Offset: 0x0003BAFA
		// (set) Token: 0x0600178F RID: 6031 RVA: 0x0003D902 File Offset: 0x0003BB02
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

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x0003D90B File Offset: 0x0003BB0B
		// (set) Token: 0x06001791 RID: 6033 RVA: 0x0003D923 File Offset: 0x0003BB23
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

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06001792 RID: 6034 RVA: 0x0003D939 File Offset: 0x0003BB39
		// (set) Token: 0x06001793 RID: 6035 RVA: 0x0003D951 File Offset: 0x0003BB51
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

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06001794 RID: 6036 RVA: 0x0003D967 File Offset: 0x0003BB67
		// (set) Token: 0x06001795 RID: 6037 RVA: 0x0003D97F File Offset: 0x0003BB7F
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

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x0003D995 File Offset: 0x0003BB95
		// (set) Token: 0x06001797 RID: 6039 RVA: 0x0003D9AD File Offset: 0x0003BBAD
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

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x0003D9C3 File Offset: 0x0003BBC3
		// (set) Token: 0x06001799 RID: 6041 RVA: 0x0003D9DB File Offset: 0x0003BBDB
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

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x0003D9F1 File Offset: 0x0003BBF1
		// (set) Token: 0x0600179B RID: 6043 RVA: 0x0003DA09 File Offset: 0x0003BC09
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

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x0003DA1F File Offset: 0x0003BC1F
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x0003DA38 File Offset: 0x0003BC38
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

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x0003DA4F File Offset: 0x0003BC4F
		// (set) Token: 0x0600179F RID: 6047 RVA: 0x0003DA68 File Offset: 0x0003BC68
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

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x0003DA7F File Offset: 0x0003BC7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOpenSystemParam.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x0003DA87 File Offset: 0x0003BC87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessage()
		{
			this.messageCase_ = ActionOpenSystemParam.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x0003DA97 File Offset: 0x0003BC97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionOpenSystemParam);
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x0003DAA8 File Offset: 0x0003BCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionOpenSystemParam other)
		{
			return other != null && (other == this || (this.ActionOpenType == other.ActionOpenType && this.IncId == other.IncId && object.Equals(this.OpenSystemBoardData, other.OpenSystemBoardData) && object.Equals(this.SoaringChallengeData, other.SoaringChallengeData) && object.Equals(this.FishingHandInData, other.FishingHandInData) && object.Equals(this.GreatSwordChallengeData, other.GreatSwordChallengeData) && object.Equals(this.InfrHandInData, other.InfrHandInData) && object.Equals(this.MotorRaceChallengeData, other.MotorRaceChallengeData) && object.Equals(this.InfrV2HandInData, other.InfrV2HandInData) && object.Equals(this.GiantSystemBoardData, other.GiantSystemBoardData) && this.MessageCase == other.MessageCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x0003DBAC File Offset: 0x0003BDAC
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

		// Token: 0x060017A5 RID: 6053 RVA: 0x0003DCCD File Offset: 0x0003BECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x0003DCDA File Offset: 0x0003BEDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x0003DCE4 File Offset: 0x0003BEE4
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

		// Token: 0x060017A8 RID: 6056 RVA: 0x0003DE28 File Offset: 0x0003C028
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

		// Token: 0x060017A9 RID: 6057 RVA: 0x0003DF48 File Offset: 0x0003C148
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

		// Token: 0x060017AA RID: 6058 RVA: 0x0003E106 File Offset: 0x0003C306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x0003E110 File Offset: 0x0003C310
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

		// Token: 0x04002133 RID: 8499
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002134 RID: 8500
		public const int ActionOpenTypeFieldNumber = 1;

		// Token: 0x04002135 RID: 8501
		private ActionOpenSystemType actionOpenType_;

		// Token: 0x04002136 RID: 8502
		public const int IncIdFieldNumber = 2;

		// Token: 0x04002137 RID: 8503
		private int incId_;

		// Token: 0x04002138 RID: 8504
		public const int OpenSystemBoardDataFieldNumber = 3;

		// Token: 0x04002139 RID: 8505
		public const int SoaringChallengeDataFieldNumber = 4;

		// Token: 0x0400213A RID: 8506
		public const int FishingHandInDataFieldNumber = 5;

		// Token: 0x0400213B RID: 8507
		public const int GreatSwordChallengeDataFieldNumber = 6;

		// Token: 0x0400213C RID: 8508
		public const int InfrHandInDataFieldNumber = 7;

		// Token: 0x0400213D RID: 8509
		public const int MotorRaceChallengeDataFieldNumber = 8;

		// Token: 0x0400213E RID: 8510
		public const int InfrV2HandInDataFieldNumber = 9;

		// Token: 0x0400213F RID: 8511
		public const int GiantSystemBoardDataFieldNumber = 10;

		// Token: 0x04002140 RID: 8512
		private object message_;

		// Token: 0x04002141 RID: 8513
		private ActionOpenSystemParam.MessageOneofCase messageCase_;

		// Token: 0x020016D2 RID: 5842
		public enum MessageOneofCase
		{
			// Token: 0x0400C491 RID: 50321
			None,
			// Token: 0x0400C492 RID: 50322
			OpenSystemBoardData = 3,
			// Token: 0x0400C493 RID: 50323
			SoaringChallengeData,
			// Token: 0x0400C494 RID: 50324
			FishingHandInData,
			// Token: 0x0400C495 RID: 50325
			GreatSwordChallengeData,
			// Token: 0x0400C496 RID: 50326
			InfrHandInData,
			// Token: 0x0400C497 RID: 50327
			MotorRaceChallengeData,
			// Token: 0x0400C498 RID: 50328
			InfrV2HandInData,
			// Token: 0x0400C499 RID: 50329
			GiantSystemBoardData
		}
	}
}
