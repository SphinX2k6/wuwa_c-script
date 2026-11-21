using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F66 RID: 3942
	public sealed class RoadNetworkComponentPb : IMessage<RoadNetworkComponentPb>, IMessage, IEquatable<RoadNetworkComponentPb>, IDeepCloneable<RoadNetworkComponentPb>, IBufferMessage
	{
		// Token: 0x060151A5 RID: 86437 RVA: 0x0030FCCC File Offset: 0x0030DECC
		[NullableContext(1)]
		public static RoadNetworkComponentPb Create()
		{
			return new RoadNetworkComponentPb();
		}

		// Token: 0x17004638 RID: 17976
		// (get) Token: 0x060151A6 RID: 86438 RVA: 0x0030FCD3 File Offset: 0x0030DED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004639 RID: 17977
		// (get) Token: 0x060151A7 RID: 86439 RVA: 0x0030FCD6 File Offset: 0x0030DED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadNetworkComponentPb.Descriptor;
			}
		}

		// Token: 0x060151A8 RID: 86440 RVA: 0x0030FCDD File Offset: 0x0030DEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNetworkComponentPb()
		{
		}

		// Token: 0x060151A9 RID: 86441 RVA: 0x0030FCE8 File Offset: 0x0030DEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNetworkComponentPb(RoadNetworkComponentPb other) : this()
		{
			this.destRoadId_ = other.destRoadId_;
			this.destIndex_ = other.destIndex_;
			this.genRoadId_ = other.genRoadId_;
			this.genRoadIndex_ = other.genRoadIndex_;
			this.navMoveData_ = ((other.navMoveData_ != null) ? other.navMoveData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060151AA RID: 86442 RVA: 0x0030FD58 File Offset: 0x0030DF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNetworkComponentPb Clone()
		{
			return new RoadNetworkComponentPb(this);
		}

		// Token: 0x1700463A RID: 17978
		// (get) Token: 0x060151AB RID: 86443 RVA: 0x0030FD60 File Offset: 0x0030DF60
		// (set) Token: 0x060151AC RID: 86444 RVA: 0x0030FD68 File Offset: 0x0030DF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DestRoadId
		{
			get
			{
				return this.destRoadId_;
			}
			set
			{
				this.destRoadId_ = value;
			}
		}

		// Token: 0x1700463B RID: 17979
		// (get) Token: 0x060151AD RID: 86445 RVA: 0x0030FD71 File Offset: 0x0030DF71
		// (set) Token: 0x060151AE RID: 86446 RVA: 0x0030FD79 File Offset: 0x0030DF79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DestIndex
		{
			get
			{
				return this.destIndex_;
			}
			set
			{
				this.destIndex_ = value;
			}
		}

		// Token: 0x1700463C RID: 17980
		// (get) Token: 0x060151AF RID: 86447 RVA: 0x0030FD82 File Offset: 0x0030DF82
		// (set) Token: 0x060151B0 RID: 86448 RVA: 0x0030FD8A File Offset: 0x0030DF8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GenRoadId
		{
			get
			{
				return this.genRoadId_;
			}
			set
			{
				this.genRoadId_ = value;
			}
		}

		// Token: 0x1700463D RID: 17981
		// (get) Token: 0x060151B1 RID: 86449 RVA: 0x0030FD93 File Offset: 0x0030DF93
		// (set) Token: 0x060151B2 RID: 86450 RVA: 0x0030FD9B File Offset: 0x0030DF9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GenRoadIndex
		{
			get
			{
				return this.genRoadIndex_;
			}
			set
			{
				this.genRoadIndex_ = value;
			}
		}

		// Token: 0x1700463E RID: 17982
		// (get) Token: 0x060151B3 RID: 86451 RVA: 0x0030FDA4 File Offset: 0x0030DFA4
		// (set) Token: 0x060151B4 RID: 86452 RVA: 0x0030FDAC File Offset: 0x0030DFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNavMoveData NavMoveData
		{
			get
			{
				return this.navMoveData_;
			}
			set
			{
				this.navMoveData_ = value;
			}
		}

		// Token: 0x060151B5 RID: 86453 RVA: 0x0030FDB5 File Offset: 0x0030DFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadNetworkComponentPb);
		}

		// Token: 0x060151B6 RID: 86454 RVA: 0x0030FDC4 File Offset: 0x0030DFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadNetworkComponentPb other)
		{
			return other != null && (other == this || (this.DestRoadId == other.DestRoadId && this.DestIndex == other.DestIndex && this.GenRoadId == other.GenRoadId && this.GenRoadIndex == other.GenRoadIndex && object.Equals(this.NavMoveData, other.NavMoveData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060151B7 RID: 86455 RVA: 0x0030FE44 File Offset: 0x0030E044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DestRoadId != 0)
			{
				num ^= this.DestRoadId.GetHashCode();
			}
			if (this.DestIndex != 0)
			{
				num ^= this.DestIndex.GetHashCode();
			}
			if (this.GenRoadId != 0)
			{
				num ^= this.GenRoadId.GetHashCode();
			}
			if (this.GenRoadIndex != 0)
			{
				num ^= this.GenRoadIndex.GetHashCode();
			}
			if (this.navMoveData_ != null)
			{
				num ^= this.NavMoveData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060151B8 RID: 86456 RVA: 0x0030FEE4 File Offset: 0x0030E0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060151B9 RID: 86457 RVA: 0x0030FEF1 File Offset: 0x0030E0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060151BA RID: 86458 RVA: 0x0030FEFC File Offset: 0x0030E0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DestRoadId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DestRoadId);
			}
			if (this.DestIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DestIndex);
			}
			if (this.GenRoadId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.GenRoadId);
			}
			if (this.GenRoadIndex != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.GenRoadIndex);
			}
			if (this.navMoveData_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.NavMoveData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060151BB RID: 86459 RVA: 0x0030FFA8 File Offset: 0x0030E1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DestRoadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DestRoadId);
			}
			if (this.DestIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DestIndex);
			}
			if (this.GenRoadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GenRoadId);
			}
			if (this.GenRoadIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GenRoadIndex);
			}
			if (this.navMoveData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NavMoveData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060151BC RID: 86460 RVA: 0x00310048 File Offset: 0x0030E248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadNetworkComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DestRoadId != 0)
			{
				this.DestRoadId = other.DestRoadId;
			}
			if (other.DestIndex != 0)
			{
				this.DestIndex = other.DestIndex;
			}
			if (other.GenRoadId != 0)
			{
				this.GenRoadId = other.GenRoadId;
			}
			if (other.GenRoadIndex != 0)
			{
				this.GenRoadIndex = other.GenRoadIndex;
			}
			if (other.navMoveData_ != null)
			{
				if (this.navMoveData_ == null)
				{
					this.NavMoveData = new RoadNavMoveData();
				}
				this.NavMoveData.MergeFrom(other.NavMoveData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060151BD RID: 86461 RVA: 0x003100EC File Offset: 0x0030E2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060151BE RID: 86462 RVA: 0x003100F8 File Offset: 0x0030E2F8
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.DestRoadId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.DestIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.GenRoadId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.GenRoadIndex = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						if (this.navMoveData_ == null)
						{
							this.NavMoveData = new RoadNavMoveData();
						}
						input.ReadMessage(this.NavMoveData);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007F6B RID: 32619
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F6C RID: 32620
		public const int DestRoadIdFieldNumber = 1;

		// Token: 0x04007F6D RID: 32621
		private int destRoadId_;

		// Token: 0x04007F6E RID: 32622
		public const int DestIndexFieldNumber = 2;

		// Token: 0x04007F6F RID: 32623
		private int destIndex_;

		// Token: 0x04007F70 RID: 32624
		public const int GenRoadIdFieldNumber = 3;

		// Token: 0x04007F71 RID: 32625
		private int genRoadId_;

		// Token: 0x04007F72 RID: 32626
		public const int GenRoadIndexFieldNumber = 4;

		// Token: 0x04007F73 RID: 32627
		private int genRoadIndex_;

		// Token: 0x04007F74 RID: 32628
		public const int NavMoveDataFieldNumber = 5;

		// Token: 0x04007F75 RID: 32629
		private RoadNavMoveData navMoveData_;
	}
}
