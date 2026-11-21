using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000705 RID: 1797
	public sealed class GridEventOp : IMessage<GridEventOp>, IMessage, IEquatable<GridEventOp>, IDeepCloneable<GridEventOp>, IBufferMessage
	{
		// Token: 0x0600A3CC RID: 41932 RVA: 0x0018BC0D File Offset: 0x00189E0D
		[NullableContext(1)]
		public static GridEventOp Create()
		{
			return new GridEventOp();
		}

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x0600A3CD RID: 41933 RVA: 0x0018BC14 File Offset: 0x00189E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x0600A3CE RID: 41934 RVA: 0x0018BC17 File Offset: 0x00189E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GridEventOp.Descriptor;
			}
		}

		// Token: 0x0600A3CF RID: 41935 RVA: 0x0018BC1E File Offset: 0x00189E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridEventOp()
		{
		}

		// Token: 0x0600A3D0 RID: 41936 RVA: 0x0018BC28 File Offset: 0x00189E28
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

		// Token: 0x0600A3D1 RID: 41937 RVA: 0x0018BCC3 File Offset: 0x00189EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridEventOp Clone()
		{
			return new GridEventOp(this);
		}

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x0600A3D2 RID: 41938 RVA: 0x0018BCCB File Offset: 0x00189ECB
		// (set) Token: 0x0600A3D3 RID: 41939 RVA: 0x0018BCD3 File Offset: 0x00189ED3
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

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x0600A3D4 RID: 41940 RVA: 0x0018BCDC File Offset: 0x00189EDC
		// (set) Token: 0x0600A3D5 RID: 41941 RVA: 0x0018BCE4 File Offset: 0x00189EE4
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

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x0600A3D6 RID: 41942 RVA: 0x0018BCED File Offset: 0x00189EED
		// (set) Token: 0x0600A3D7 RID: 41943 RVA: 0x0018BD04 File Offset: 0x00189F04
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

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x0600A3D8 RID: 41944 RVA: 0x0018BD19 File Offset: 0x00189F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasNoStep
		{
			get
			{
				return this.dataCase_ == GridEventOp.DataOneofCase.NoStep;
			}
		}

		// Token: 0x0600A3D9 RID: 41945 RVA: 0x0018BD24 File Offset: 0x00189F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearNoStep()
		{
			if (this.HasNoStep)
			{
				this.ClearData();
			}
		}

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x0600A3DA RID: 41946 RVA: 0x0018BD34 File Offset: 0x00189F34
		// (set) Token: 0x0600A3DB RID: 41947 RVA: 0x0018BD4C File Offset: 0x00189F4C
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

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x0600A3DC RID: 41948 RVA: 0x0018BD62 File Offset: 0x00189F62
		// (set) Token: 0x0600A3DD RID: 41949 RVA: 0x0018BD7A File Offset: 0x00189F7A
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

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x0600A3DE RID: 41950 RVA: 0x0018BD90 File Offset: 0x00189F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridEventOp.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0600A3DF RID: 41951 RVA: 0x0018BD98 File Offset: 0x00189F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = GridEventOp.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0600A3E0 RID: 41952 RVA: 0x0018BDA8 File Offset: 0x00189FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GridEventOp);
		}

		// Token: 0x0600A3E1 RID: 41953 RVA: 0x0018BDB8 File Offset: 0x00189FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GridEventOp other)
		{
			return other != null && (other == this || (object.Equals(this.GridEventData, other.GridEventData) && this.ClientStepState == other.ClientStepState && this.NoStep == other.NoStep && object.Equals(this.SpecialEffectInfo, other.SpecialEffectInfo) && object.Equals(this.EventPlotInfo, other.EventPlotInfo) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A3E2 RID: 41954 RVA: 0x0018BE50 File Offset: 0x0018A050
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

		// Token: 0x0600A3E3 RID: 41955 RVA: 0x0018BEFB File Offset: 0x0018A0FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A3E4 RID: 41956 RVA: 0x0018BF08 File Offset: 0x0018A108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A3E5 RID: 41957 RVA: 0x0018BF14 File Offset: 0x0018A114
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

		// Token: 0x0600A3E6 RID: 41958 RVA: 0x0018BFC4 File Offset: 0x0018A1C4
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

		// Token: 0x0600A3E7 RID: 41959 RVA: 0x0018C064 File Offset: 0x0018A264
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

		// Token: 0x0600A3E8 RID: 41960 RVA: 0x0018C141 File Offset: 0x0018A341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A3E9 RID: 41961 RVA: 0x0018C14C File Offset: 0x0018A34C
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

		// Token: 0x04004BF1 RID: 19441
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BF2 RID: 19442
		public const int GridEventDataFieldNumber = 1;

		// Token: 0x04004BF3 RID: 19443
		private GridEventData gridEventData_;

		// Token: 0x04004BF4 RID: 19444
		public const int ClientStepStateFieldNumber = 3;

		// Token: 0x04004BF5 RID: 19445
		private ClientStepState clientStepState_;

		// Token: 0x04004BF6 RID: 19446
		public const int NoStepFieldNumber = 4;

		// Token: 0x04004BF7 RID: 19447
		public const int SpecialEffectInfoFieldNumber = 5;

		// Token: 0x04004BF8 RID: 19448
		public const int EventPlotInfoFieldNumber = 6;

		// Token: 0x04004BF9 RID: 19449
		private object data_;

		// Token: 0x04004BFA RID: 19450
		private GridEventOp.DataOneofCase dataCase_;

		// Token: 0x02001854 RID: 6228
		public enum DataOneofCase
		{
			// Token: 0x0400CCA2 RID: 52386
			None,
			// Token: 0x0400CCA3 RID: 52387
			NoStep = 4,
			// Token: 0x0400CCA4 RID: 52388
			SpecialEffectInfo,
			// Token: 0x0400CCA5 RID: 52389
			EventPlotInfo
		}
	}
}
