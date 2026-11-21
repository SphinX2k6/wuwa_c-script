using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F1 RID: 1521
	[NetMessage(EMessageId.FlowStartNotify)]
	public sealed class FlowStartNotify : IMessage<FlowStartNotify>, IMessage, IEquatable<FlowStartNotify>, IDeepCloneable<FlowStartNotify>, IBufferMessage
	{
		// Token: 0x06008D2D RID: 36141 RVA: 0x00156CA0 File Offset: 0x00154EA0
		[NullableContext(1)]
		public static FlowStartNotify Create()
		{
			return new FlowStartNotify();
		}

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x06008D2E RID: 36142 RVA: 0x00156CA7 File Offset: 0x00154EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x06008D2F RID: 36143 RVA: 0x00156CAA File Offset: 0x00154EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowStartNotify.Descriptor;
			}
		}

		// Token: 0x06008D30 RID: 36144 RVA: 0x00156CB1 File Offset: 0x00154EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowStartNotify()
		{
		}

		// Token: 0x06008D31 RID: 36145 RVA: 0x00156CD0 File Offset: 0x00154ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowStartNotify(FlowStartNotify other) : this()
		{
			this.flowIncId_ = other.flowIncId_;
			this.flowListName_ = other.flowListName_;
			this.flowId_ = other.flowId_;
			this.stateId_ = other.stateId_;
			this.gameCtx_ = ((other.gameCtx_ != null) ? other.gameCtx_.Clone() : null);
			this.plotMode_ = other.plotMode_;
			this.async_ = other.async_;
			this.isSkip_ = other.isSkip_;
			this.hasPlotPos_ = other.hasPlotPos_;
			this.plotPos_ = ((other.plotPos_ != null) ? other.plotPos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D32 RID: 36146 RVA: 0x00156D8C File Offset: 0x00154F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowStartNotify Clone()
		{
			return new FlowStartNotify(this);
		}

		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x06008D33 RID: 36147 RVA: 0x00156D94 File Offset: 0x00154F94
		// (set) Token: 0x06008D34 RID: 36148 RVA: 0x00156D9C File Offset: 0x00154F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FlowIncId
		{
			get
			{
				return this.flowIncId_;
			}
			set
			{
				this.flowIncId_ = value;
			}
		}

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x06008D35 RID: 36149 RVA: 0x00156DA5 File Offset: 0x00154FA5
		// (set) Token: 0x06008D36 RID: 36150 RVA: 0x00156DAD File Offset: 0x00154FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FlowListName
		{
			get
			{
				return this.flowListName_;
			}
			set
			{
				this.flowListName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x06008D37 RID: 36151 RVA: 0x00156DC0 File Offset: 0x00154FC0
		// (set) Token: 0x06008D38 RID: 36152 RVA: 0x00156DC8 File Offset: 0x00154FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FlowId
		{
			get
			{
				return this.flowId_;
			}
			set
			{
				this.flowId_ = value;
			}
		}

		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x06008D39 RID: 36153 RVA: 0x00156DD1 File Offset: 0x00154FD1
		// (set) Token: 0x06008D3A RID: 36154 RVA: 0x00156DD9 File Offset: 0x00154FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateId
		{
			get
			{
				return this.stateId_;
			}
			set
			{
				this.stateId_ = value;
			}
		}

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x06008D3B RID: 36155 RVA: 0x00156DE2 File Offset: 0x00154FE2
		// (set) Token: 0x06008D3C RID: 36156 RVA: 0x00156DEA File Offset: 0x00154FEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxPb GameCtx
		{
			get
			{
				return this.gameCtx_;
			}
			set
			{
				this.gameCtx_ = value;
			}
		}

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x06008D3D RID: 36157 RVA: 0x00156DF3 File Offset: 0x00154FF3
		// (set) Token: 0x06008D3E RID: 36158 RVA: 0x00156DFB File Offset: 0x00154FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PlotMode
		{
			get
			{
				return this.plotMode_;
			}
			set
			{
				this.plotMode_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x06008D3F RID: 36159 RVA: 0x00156E0E File Offset: 0x0015500E
		// (set) Token: 0x06008D40 RID: 36160 RVA: 0x00156E16 File Offset: 0x00155016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Async
		{
			get
			{
				return this.async_;
			}
			set
			{
				this.async_ = value;
			}
		}

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x06008D41 RID: 36161 RVA: 0x00156E1F File Offset: 0x0015501F
		// (set) Token: 0x06008D42 RID: 36162 RVA: 0x00156E27 File Offset: 0x00155027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSkip
		{
			get
			{
				return this.isSkip_;
			}
			set
			{
				this.isSkip_ = value;
			}
		}

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x06008D43 RID: 36163 RVA: 0x00156E30 File Offset: 0x00155030
		// (set) Token: 0x06008D44 RID: 36164 RVA: 0x00156E38 File Offset: 0x00155038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPlotPos
		{
			get
			{
				return this.hasPlotPos_;
			}
			set
			{
				this.hasPlotPos_ = value;
			}
		}

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x06008D45 RID: 36165 RVA: 0x00156E41 File Offset: 0x00155041
		// (set) Token: 0x06008D46 RID: 36166 RVA: 0x00156E49 File Offset: 0x00155049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector PlotPos
		{
			get
			{
				return this.plotPos_;
			}
			set
			{
				this.plotPos_ = value;
			}
		}

		// Token: 0x06008D47 RID: 36167 RVA: 0x00156E52 File Offset: 0x00155052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowStartNotify);
		}

		// Token: 0x06008D48 RID: 36168 RVA: 0x00156E60 File Offset: 0x00155060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowStartNotify other)
		{
			return other != null && (other == this || (this.FlowIncId == other.FlowIncId && !(this.FlowListName != other.FlowListName) && this.FlowId == other.FlowId && this.StateId == other.StateId && object.Equals(this.GameCtx, other.GameCtx) && !(this.PlotMode != other.PlotMode) && this.Async == other.Async && this.IsSkip == other.IsSkip && this.HasPlotPos == other.HasPlotPos && object.Equals(this.PlotPos, other.PlotPos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D49 RID: 36169 RVA: 0x00156F40 File Offset: 0x00155140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlowIncId != 0L)
			{
				num ^= this.FlowIncId.GetHashCode();
			}
			if (this.FlowListName.Length != 0)
			{
				num ^= this.FlowListName.GetHashCode();
			}
			if (this.FlowId != 0)
			{
				num ^= this.FlowId.GetHashCode();
			}
			if (this.StateId != 0)
			{
				num ^= this.StateId.GetHashCode();
			}
			if (this.gameCtx_ != null)
			{
				num ^= this.GameCtx.GetHashCode();
			}
			if (this.PlotMode.Length != 0)
			{
				num ^= this.PlotMode.GetHashCode();
			}
			if (this.Async)
			{
				num ^= this.Async.GetHashCode();
			}
			if (this.IsSkip)
			{
				num ^= this.IsSkip.GetHashCode();
			}
			if (this.HasPlotPos)
			{
				num ^= this.HasPlotPos.GetHashCode();
			}
			if (this.plotPos_ != null)
			{
				num ^= this.PlotPos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D4A RID: 36170 RVA: 0x0015705E File Offset: 0x0015525E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008D4B RID: 36171 RVA: 0x0015706B File Offset: 0x0015526B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D4C RID: 36172 RVA: 0x00157074 File Offset: 0x00155274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasPlotPos)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.HasPlotPos);
			}
			if (this.StateId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.StateId);
			}
			if (this.plotPos_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.PlotPos);
			}
			if (this.FlowIncId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.FlowIncId);
			}
			if (this.FlowListName.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.FlowListName);
			}
			if (this.PlotMode.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.PlotMode);
			}
			if (this.Async)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.Async);
			}
			if (this.FlowId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.FlowId);
			}
			if (this.gameCtx_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.GameCtx);
			}
			if (this.IsSkip)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsSkip);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D4D RID: 36173 RVA: 0x001571B8 File Offset: 0x001553B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlowIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FlowIncId);
			}
			if (this.FlowListName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FlowListName);
			}
			if (this.FlowId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FlowId);
			}
			if (this.StateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateId);
			}
			if (this.gameCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameCtx);
			}
			if (this.PlotMode.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PlotMode);
			}
			if (this.Async)
			{
				num += 2;
			}
			if (this.IsSkip)
			{
				num += 2;
			}
			if (this.HasPlotPos)
			{
				num += 2;
			}
			if (this.plotPos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlotPos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D4E RID: 36174 RVA: 0x001572B4 File Offset: 0x001554B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowStartNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlowIncId != 0L)
			{
				this.FlowIncId = other.FlowIncId;
			}
			if (other.FlowListName.Length != 0)
			{
				this.FlowListName = other.FlowListName;
			}
			if (other.FlowId != 0)
			{
				this.FlowId = other.FlowId;
			}
			if (other.StateId != 0)
			{
				this.StateId = other.StateId;
			}
			if (other.gameCtx_ != null)
			{
				if (this.gameCtx_ == null)
				{
					this.GameCtx = new GameCtxPb();
				}
				this.GameCtx.MergeFrom(other.GameCtx);
			}
			if (other.PlotMode.Length != 0)
			{
				this.PlotMode = other.PlotMode;
			}
			if (other.Async)
			{
				this.Async = other.Async;
			}
			if (other.IsSkip)
			{
				this.IsSkip = other.IsSkip;
			}
			if (other.HasPlotPos)
			{
				this.HasPlotPos = other.HasPlotPos;
			}
			if (other.plotPos_ != null)
			{
				if (this.plotPos_ == null)
				{
					this.PlotPos = new Vector();
				}
				this.PlotPos.MergeFrom(other.PlotPos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008D4F RID: 36175 RVA: 0x001573DE File Offset: 0x001555DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D50 RID: 36176 RVA: 0x001573E8 File Offset: 0x001555E8
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
					if (num <= 32U)
					{
						if (num == 24U)
						{
							this.HasPlotPos = input.ReadBool();
							continue;
						}
						if (num == 32U)
						{
							this.StateId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 42U)
						{
							if (this.plotPos_ == null)
							{
								this.PlotPos = new Vector();
							}
							input.ReadMessage(this.PlotPos);
							continue;
						}
						if (num == 48U)
						{
							this.FlowIncId = input.ReadInt64();
							continue;
						}
						if (num == 66U)
						{
							this.FlowListName = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 74U)
					{
						this.PlotMode = input.ReadString();
						continue;
					}
					if (num == 80U)
					{
						this.Async = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.FlowId = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.gameCtx_ == null)
						{
							this.GameCtx = new GameCtxPb();
						}
						input.ReadMessage(this.GameCtx);
						continue;
					}
					if (num == 120U)
					{
						this.IsSkip = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004559 RID: 17753
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400455A RID: 17754
		public const int FlowIncIdFieldNumber = 6;

		// Token: 0x0400455B RID: 17755
		private long flowIncId_;

		// Token: 0x0400455C RID: 17756
		public const int FlowListNameFieldNumber = 8;

		// Token: 0x0400455D RID: 17757
		private string flowListName_ = "";

		// Token: 0x0400455E RID: 17758
		public const int FlowIdFieldNumber = 12;

		// Token: 0x0400455F RID: 17759
		private int flowId_;

		// Token: 0x04004560 RID: 17760
		public const int StateIdFieldNumber = 4;

		// Token: 0x04004561 RID: 17761
		private int stateId_;

		// Token: 0x04004562 RID: 17762
		public const int GameCtxFieldNumber = 14;

		// Token: 0x04004563 RID: 17763
		private GameCtxPb gameCtx_;

		// Token: 0x04004564 RID: 17764
		public const int PlotModeFieldNumber = 9;

		// Token: 0x04004565 RID: 17765
		private string plotMode_ = "";

		// Token: 0x04004566 RID: 17766
		public const int AsyncFieldNumber = 10;

		// Token: 0x04004567 RID: 17767
		private bool async_;

		// Token: 0x04004568 RID: 17768
		public const int IsSkipFieldNumber = 15;

		// Token: 0x04004569 RID: 17769
		private bool isSkip_;

		// Token: 0x0400456A RID: 17770
		public const int HasPlotPosFieldNumber = 3;

		// Token: 0x0400456B RID: 17771
		private bool hasPlotPos_;

		// Token: 0x0400456C RID: 17772
		public const int PlotPosFieldNumber = 5;

		// Token: 0x0400456D RID: 17773
		private Vector plotPos_;
	}
}
