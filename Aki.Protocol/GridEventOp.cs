using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000719 RID: 1817
	public sealed class GridEventOp : IMessage<GridEventOp>, IMessage, IEquatable<GridEventOp>, IDeepCloneable<GridEventOp>, IBufferMessage
	{
		// Token: 0x0600A522 RID: 42274 RVA: 0x0018E641 File Offset: 0x0018C841
		[NullableContext(1)]
		public static GridEventOp Create()
		{
			return new GridEventOp();
		}

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x0600A523 RID: 42275 RVA: 0x0018E648 File Offset: 0x0018C848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x0600A524 RID: 42276 RVA: 0x0018E64B File Offset: 0x0018C84B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GridEventOp.Descriptor;
			}
		}

		// Token: 0x0600A525 RID: 42277 RVA: 0x0018E652 File Offset: 0x0018C852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridEventOp()
		{
		}

		// Token: 0x0600A526 RID: 42278 RVA: 0x0018E65C File Offset: 0x0018C85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridEventOp(GridEventOp other) : this()
		{
			this.gridEventData_ = ((other.gridEventData_ != null) ? other.gridEventData_.Clone() : null);
			this.clientStepState_ = other.clientStepState_;
			switch (other.DataCase)
			{
			case GridEventOp.DataOneofCase.NoStep:
				this.NoStep = other.NoStep;
				break;
			case GridEventOp.DataOneofCase.SpecialEffectInfo:
				this.SpecialEffectInfo = other.SpecialEffectInfo.Clone();
				break;
			case GridEventOp.DataOneofCase.EventPlotInfo:
				this.EventPlotInfo = other.EventPlotInfo.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A527 RID: 42279 RVA: 0x0018E6F7 File Offset: 0x0018C8F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridEventOp Clone()
		{
			return new GridEventOp(this);
		}

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x0600A528 RID: 42280 RVA: 0x0018E6FF File Offset: 0x0018C8FF
		// (set) Token: 0x0600A529 RID: 42281 RVA: 0x0018E707 File Offset: 0x0018C907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridEventData GridEventData
		{
			get
			{
				return this.gridEventData_;
			}
			set
			{
				this.gridEventData_ = value;
			}
		}

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x0600A52A RID: 42282 RVA: 0x0018E710 File Offset: 0x0018C910
		// (set) Token: 0x0600A52B RID: 42283 RVA: 0x0018E718 File Offset: 0x0018C918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStepState ClientStepState
		{
			get
			{
				return this.clientStepState_;
			}
			set
			{
				this.clientStepState_ = value;
			}
		}

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x0600A52C RID: 42284 RVA: 0x0018E721 File Offset: 0x0018C921
		// (set) Token: 0x0600A52D RID: 42285 RVA: 0x0018E738 File Offset: 0x0018C938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NoStep
		{
			get
			{
				if (!this.HasNoStep)
				{
					return 0;
				}
				return (int)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = GridEventOp.DataOneofCase.NoStep;
			}
		}

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x0600A52E RID: 42286 RVA: 0x0018E74D File Offset: 0x0018C94D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasNoStep
		{
			get
			{
				return this.dataCase_ == GridEventOp.DataOneofCase.NoStep;
			}
		}

		// Token: 0x0600A52F RID: 42287 RVA: 0x0018E758 File Offset: 0x0018C958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearNoStep()
		{
			if (this.HasNoStep)
			{
				this.ClearData();
			}
		}

		// Token: 0x17002139 RID: 8505
		// (get) Token: 0x0600A530 RID: 42288 RVA: 0x0018E768 File Offset: 0x0018C968
		// (set) Token: 0x0600A531 RID: 42289 RVA: 0x0018E780 File Offset: 0x0018C980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialEffectInfo SpecialEffectInfo
		{
			get
			{
				if (this.dataCase_ != GridEventOp.DataOneofCase.SpecialEffectInfo)
				{
					return null;
				}
				return (SpecialEffectInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? GridEventOp.DataOneofCase.None : GridEventOp.DataOneofCase.SpecialEffectInfo);
			}
		}

		// Token: 0x1700213A RID: 8506
		// (get) Token: 0x0600A532 RID: 42290 RVA: 0x0018E796 File Offset: 0x0018C996
		// (set) Token: 0x0600A533 RID: 42291 RVA: 0x0018E7AE File Offset: 0x0018C9AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EventPlotInfo EventPlotInfo
		{
			get
			{
				if (this.dataCase_ != GridEventOp.DataOneofCase.EventPlotInfo)
				{
					return null;
				}
				return (EventPlotInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? GridEventOp.DataOneofCase.None : GridEventOp.DataOneofCase.EventPlotInfo);
			}
		}

		// Token: 0x1700213B RID: 8507
		// (get) Token: 0x0600A534 RID: 42292 RVA: 0x0018E7C4 File Offset: 0x0018C9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridEventOp.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0600A535 RID: 42293 RVA: 0x0018E7CC File Offset: 0x0018C9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = GridEventOp.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0600A536 RID: 42294 RVA: 0x0018E7DC File Offset: 0x0018C9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GridEventOp);
		}

		// Token: 0x0600A537 RID: 42295 RVA: 0x0018E7EC File Offset: 0x0018C9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GridEventOp other)
		{
			return other != null && (other == this || (object.Equals(this.GridEventData, other.GridEventData) && this.ClientStepState == other.ClientStepState && this.NoStep == other.NoStep && object.Equals(this.SpecialEffectInfo, other.SpecialEffectInfo) && object.Equals(this.EventPlotInfo, other.EventPlotInfo) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A538 RID: 42296 RVA: 0x0018E884 File Offset: 0x0018CA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gridEventData_ != null)
			{
				num ^= this.GridEventData.GetHashCode();
			}
			if (this.ClientStepState != ClientStepState.NoStep)
			{
				num ^= this.ClientStepState.GetHashCode();
			}
			if (this.HasNoStep)
			{
				num ^= this.NoStep.GetHashCode();
			}
			if (this.dataCase_ == GridEventOp.DataOneofCase.SpecialEffectInfo)
			{
				num ^= this.SpecialEffectInfo.GetHashCode();
			}
			if (this.dataCase_ == GridEventOp.DataOneofCase.EventPlotInfo)
			{
				num ^= this.EventPlotInfo.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A539 RID: 42297 RVA: 0x0018E92F File Offset: 0x0018CB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A53A RID: 42298 RVA: 0x0018E93C File Offset: 0x0018CB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A53B RID: 42299 RVA: 0x0018E948 File Offset: 0x0018CB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gridEventData_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GridEventData);
			}
			if (this.ClientStepState != ClientStepState.NoStep)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ClientStepState);
			}
			if (this.HasNoStep)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.NoStep);
			}
			if (this.dataCase_ == GridEventOp.DataOneofCase.SpecialEffectInfo)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.SpecialEffectInfo);
			}
			if (this.dataCase_ == GridEventOp.DataOneofCase.EventPlotInfo)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.EventPlotInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A53C RID: 42300 RVA: 0x0018E9F8 File Offset: 0x0018CBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gridEventData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GridEventData);
			}
			if (this.ClientStepState != ClientStepState.NoStep)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ClientStepState);
			}
			if (this.HasNoStep)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NoStep);
			}
			if (this.dataCase_ == GridEventOp.DataOneofCase.SpecialEffectInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SpecialEffectInfo);
			}
			if (this.dataCase_ == GridEventOp.DataOneofCase.EventPlotInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EventPlotInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A53D RID: 42301 RVA: 0x0018EA98 File Offset: 0x0018CC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GridEventOp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gridEventData_ != null)
			{
				if (this.gridEventData_ == null)
				{
					this.GridEventData = new GridEventData();
				}
				this.GridEventData.MergeFrom(other.GridEventData);
			}
			if (other.ClientStepState != ClientStepState.NoStep)
			{
				this.ClientStepState = other.ClientStepState;
			}
			switch (other.DataCase)
			{
			case GridEventOp.DataOneofCase.NoStep:
				this.NoStep = other.NoStep;
				break;
			case GridEventOp.DataOneofCase.SpecialEffectInfo:
				if (this.SpecialEffectInfo == null)
				{
					this.SpecialEffectInfo = new SpecialEffectInfo();
				}
				this.SpecialEffectInfo.MergeFrom(other.SpecialEffectInfo);
				break;
			case GridEventOp.DataOneofCase.EventPlotInfo:
				if (this.EventPlotInfo == null)
				{
					this.EventPlotInfo = new EventPlotInfo();
				}
				this.EventPlotInfo.MergeFrom(other.EventPlotInfo);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A53E RID: 42302 RVA: 0x0018EB75 File Offset: 0x0018CD75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A53F RID: 42303 RVA: 0x0018EB80 File Offset: 0x0018CD80
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
				if (num <= 24U)
				{
					if (num == 10U)
					{
						if (this.gridEventData_ == null)
						{
							this.GridEventData = new GridEventData();
						}
						input.ReadMessage(this.GridEventData);
						continue;
					}
					if (num == 24U)
					{
						this.ClientStepState = (ClientStepState)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.NoStep = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						SpecialEffectInfo specialEffectInfo = new SpecialEffectInfo();
						if (this.dataCase_ == GridEventOp.DataOneofCase.SpecialEffectInfo)
						{
							specialEffectInfo.MergeFrom(this.SpecialEffectInfo);
						}
						input.ReadMessage(specialEffectInfo);
						this.SpecialEffectInfo = specialEffectInfo;
						continue;
					}
					if (num == 50U)
					{
						EventPlotInfo eventPlotInfo = new EventPlotInfo();
						if (this.dataCase_ == GridEventOp.DataOneofCase.EventPlotInfo)
						{
							eventPlotInfo.MergeFrom(this.EventPlotInfo);
						}
						input.ReadMessage(eventPlotInfo);
						this.EventPlotInfo = eventPlotInfo;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004BF8 RID: 19448
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BF9 RID: 19449
		public const int GridEventDataFieldNumber = 1;

		// Token: 0x04004BFA RID: 19450
		private GridEventData gridEventData_;

		// Token: 0x04004BFB RID: 19451
		public const int ClientStepStateFieldNumber = 3;

		// Token: 0x04004BFC RID: 19452
		private ClientStepState clientStepState_;

		// Token: 0x04004BFD RID: 19453
		public const int NoStepFieldNumber = 4;

		// Token: 0x04004BFE RID: 19454
		public const int SpecialEffectInfoFieldNumber = 5;

		// Token: 0x04004BFF RID: 19455
		public const int EventPlotInfoFieldNumber = 6;

		// Token: 0x04004C00 RID: 19456
		private object data_;

		// Token: 0x04004C01 RID: 19457
		private GridEventOp.DataOneofCase dataCase_;

		// Token: 0x020017DC RID: 6108
		public enum DataOneofCase
		{
			// Token: 0x0400C777 RID: 51063
			None,
			// Token: 0x0400C778 RID: 51064
			NoStep = 4,
			// Token: 0x0400C779 RID: 51065
			SpecialEffectInfo,
			// Token: 0x0400C77A RID: 51066
			EventPlotInfo
		}
	}
}
