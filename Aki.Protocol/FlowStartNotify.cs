using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000606 RID: 1542
	[NetMessage(EMessageId.FlowStartNotify)]
	public sealed class FlowStartNotify : IMessage<FlowStartNotify>, IMessage, IEquatable<FlowStartNotify>, IDeepCloneable<FlowStartNotify>, IBufferMessage
	{
		// Token: 0x06008E95 RID: 36501 RVA: 0x001598A4 File Offset: 0x00157AA4
		[NullableContext(1)]
		public static FlowStartNotify Create()
		{
			return new FlowStartNotify();
		}

		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x06008E96 RID: 36502 RVA: 0x001598AB File Offset: 0x00157AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x06008E97 RID: 36503 RVA: 0x001598AE File Offset: 0x00157AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowStartNotify.Descriptor;
			}
		}

		// Token: 0x06008E98 RID: 36504 RVA: 0x001598B5 File Offset: 0x00157AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowStartNotify()
		{
		}

		// Token: 0x06008E99 RID: 36505 RVA: 0x001598D4 File Offset: 0x00157AD4
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

		// Token: 0x06008E9A RID: 36506 RVA: 0x00159990 File Offset: 0x00157B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowStartNotify Clone()
		{
			return new FlowStartNotify(this);
		}

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x06008E9B RID: 36507 RVA: 0x00159998 File Offset: 0x00157B98
		// (set) Token: 0x06008E9C RID: 36508 RVA: 0x001599A0 File Offset: 0x00157BA0
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

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x06008E9D RID: 36509 RVA: 0x001599A9 File Offset: 0x00157BA9
		// (set) Token: 0x06008E9E RID: 36510 RVA: 0x001599B1 File Offset: 0x00157BB1
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

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x06008E9F RID: 36511 RVA: 0x001599C4 File Offset: 0x00157BC4
		// (set) Token: 0x06008EA0 RID: 36512 RVA: 0x001599CC File Offset: 0x00157BCC
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

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x06008EA1 RID: 36513 RVA: 0x001599D5 File Offset: 0x00157BD5
		// (set) Token: 0x06008EA2 RID: 36514 RVA: 0x001599DD File Offset: 0x00157BDD
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

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x06008EA3 RID: 36515 RVA: 0x001599E6 File Offset: 0x00157BE6
		// (set) Token: 0x06008EA4 RID: 36516 RVA: 0x001599EE File Offset: 0x00157BEE
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

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x06008EA5 RID: 36517 RVA: 0x001599F7 File Offset: 0x00157BF7
		// (set) Token: 0x06008EA6 RID: 36518 RVA: 0x001599FF File Offset: 0x00157BFF
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

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x06008EA7 RID: 36519 RVA: 0x00159A12 File Offset: 0x00157C12
		// (set) Token: 0x06008EA8 RID: 36520 RVA: 0x00159A1A File Offset: 0x00157C1A
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

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x06008EA9 RID: 36521 RVA: 0x00159A23 File Offset: 0x00157C23
		// (set) Token: 0x06008EAA RID: 36522 RVA: 0x00159A2B File Offset: 0x00157C2B
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

		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x06008EAB RID: 36523 RVA: 0x00159A34 File Offset: 0x00157C34
		// (set) Token: 0x06008EAC RID: 36524 RVA: 0x00159A3C File Offset: 0x00157C3C
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

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x06008EAD RID: 36525 RVA: 0x00159A45 File Offset: 0x00157C45
		// (set) Token: 0x06008EAE RID: 36526 RVA: 0x00159A4D File Offset: 0x00157C4D
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

		// Token: 0x06008EAF RID: 36527 RVA: 0x00159A56 File Offset: 0x00157C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowStartNotify);
		}

		// Token: 0x06008EB0 RID: 36528 RVA: 0x00159A64 File Offset: 0x00157C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowStartNotify other)
		{
			return other != null && (other == this || (this.FlowIncId == other.FlowIncId && !(this.FlowListName != other.FlowListName) && this.FlowId == other.FlowId && this.StateId == other.StateId && object.Equals(this.GameCtx, other.GameCtx) && !(this.PlotMode != other.PlotMode) && this.Async == other.Async && this.IsSkip == other.IsSkip && this.HasPlotPos == other.HasPlotPos && object.Equals(this.PlotPos, other.PlotPos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008EB1 RID: 36529 RVA: 0x00159B44 File Offset: 0x00157D44
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

		// Token: 0x06008EB2 RID: 36530 RVA: 0x00159C62 File Offset: 0x00157E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008EB3 RID: 36531 RVA: 0x00159C6F File Offset: 0x00157E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008EB4 RID: 36532 RVA: 0x00159C78 File Offset: 0x00157E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlotMode.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.PlotMode);
			}
			if (this.Async)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Async);
			}
			if (this.gameCtx_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.GameCtx);
			}
			if (this.IsSkip)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsSkip);
			}
			if (this.FlowId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.FlowId);
			}
			if (this.StateId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.StateId);
			}
			if (this.HasPlotPos)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.HasPlotPos);
			}
			if (this.FlowIncId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.FlowIncId);
			}
			if (this.plotPos_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.PlotPos);
			}
			if (this.FlowListName.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.FlowListName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008EB5 RID: 36533 RVA: 0x00159DBC File Offset: 0x00157FBC
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

		// Token: 0x06008EB6 RID: 36534 RVA: 0x00159EB8 File Offset: 0x001580B8
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

		// Token: 0x06008EB7 RID: 36535 RVA: 0x00159FE2 File Offset: 0x001581E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008EB8 RID: 36536 RVA: 0x00159FEC File Offset: 0x001581EC
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
				if (num <= 64U)
				{
					if (num <= 24U)
					{
						if (num == 18U)
						{
							this.PlotMode = input.ReadString();
							continue;
						}
						if (num == 24U)
						{
							this.Async = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							if (this.gameCtx_ == null)
							{
								this.GameCtx = new GameCtxPb();
							}
							input.ReadMessage(this.GameCtx);
							continue;
						}
						if (num == 40U)
						{
							this.IsSkip = input.ReadBool();
							continue;
						}
						if (num == 64U)
						{
							this.FlowId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 80U)
					{
						this.StateId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.HasPlotPos = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.FlowIncId = input.ReadInt64();
						continue;
					}
					if (num == 114U)
					{
						if (this.plotPos_ == null)
						{
							this.PlotPos = new Vector();
						}
						input.ReadMessage(this.PlotPos);
						continue;
					}
					if (num == 122U)
					{
						this.FlowListName = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004563 RID: 17763
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004564 RID: 17764
		public const int FlowIncIdFieldNumber = 12;

		// Token: 0x04004565 RID: 17765
		private long flowIncId_;

		// Token: 0x04004566 RID: 17766
		public const int FlowListNameFieldNumber = 15;

		// Token: 0x04004567 RID: 17767
		private string flowListName_ = "";

		// Token: 0x04004568 RID: 17768
		public const int FlowIdFieldNumber = 8;

		// Token: 0x04004569 RID: 17769
		private int flowId_;

		// Token: 0x0400456A RID: 17770
		public const int StateIdFieldNumber = 10;

		// Token: 0x0400456B RID: 17771
		private int stateId_;

		// Token: 0x0400456C RID: 17772
		public const int GameCtxFieldNumber = 4;

		// Token: 0x0400456D RID: 17773
		private GameCtxPb gameCtx_;

		// Token: 0x0400456E RID: 17774
		public const int PlotModeFieldNumber = 2;

		// Token: 0x0400456F RID: 17775
		private string plotMode_ = "";

		// Token: 0x04004570 RID: 17776
		public const int AsyncFieldNumber = 3;

		// Token: 0x04004571 RID: 17777
		private bool async_;

		// Token: 0x04004572 RID: 17778
		public const int IsSkipFieldNumber = 5;

		// Token: 0x04004573 RID: 17779
		private bool isSkip_;

		// Token: 0x04004574 RID: 17780
		public const int HasPlotPosFieldNumber = 11;

		// Token: 0x04004575 RID: 17781
		private bool hasPlotPos_;

		// Token: 0x04004576 RID: 17782
		public const int PlotPosFieldNumber = 14;

		// Token: 0x04004577 RID: 17783
		private Vector plotPos_;
	}
}
