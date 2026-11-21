using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001316 RID: 4886
	[NetMessage(EMessageId.SubmitWalkingPatternPointRequest)]
	public sealed class SubmitWalkingPatternPointRequest : IMessage<SubmitWalkingPatternPointRequest>, IMessage, IEquatable<SubmitWalkingPatternPointRequest>, IDeepCloneable<SubmitWalkingPatternPointRequest>, IBufferMessage
	{
		// Token: 0x0601A0D4 RID: 106708 RVA: 0x003CC105 File Offset: 0x003CA305
		[NullableContext(1)]
		public static SubmitWalkingPatternPointRequest Create()
		{
			return new SubmitWalkingPatternPointRequest();
		}

		// Token: 0x17005835 RID: 22581
		// (get) Token: 0x0601A0D5 RID: 106709 RVA: 0x003CC10C File Offset: 0x003CA30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005836 RID: 22582
		// (get) Token: 0x0601A0D6 RID: 106710 RVA: 0x003CC10F File Offset: 0x003CA30F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitWalkingPatternPointRequest.Descriptor;
			}
		}

		// Token: 0x0601A0D7 RID: 106711 RVA: 0x003CC116 File Offset: 0x003CA316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitWalkingPatternPointRequest()
		{
		}

		// Token: 0x0601A0D8 RID: 106712 RVA: 0x003CC120 File Offset: 0x003CA320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitWalkingPatternPointRequest(SubmitWalkingPatternPointRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.point_ = other.point_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A0D9 RID: 106713 RVA: 0x003CC174 File Offset: 0x003CA374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitWalkingPatternPointRequest Clone()
		{
			return new SubmitWalkingPatternPointRequest(this);
		}

		// Token: 0x17005837 RID: 22583
		// (get) Token: 0x0601A0DA RID: 106714 RVA: 0x003CC17C File Offset: 0x003CA37C
		// (set) Token: 0x0601A0DB RID: 106715 RVA: 0x003CC184 File Offset: 0x003CA384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeOwnerId
		{
			get
			{
				return this.treeOwnerId_;
			}
			set
			{
				this.treeOwnerId_ = value;
			}
		}

		// Token: 0x17005838 RID: 22584
		// (get) Token: 0x0601A0DC RID: 106716 RVA: 0x003CC18D File Offset: 0x003CA38D
		// (set) Token: 0x0601A0DD RID: 106717 RVA: 0x003CC195 File Offset: 0x003CA395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x17005839 RID: 22585
		// (get) Token: 0x0601A0DE RID: 106718 RVA: 0x003CC19E File Offset: 0x003CA39E
		// (set) Token: 0x0601A0DF RID: 106719 RVA: 0x003CC1A6 File Offset: 0x003CA3A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NodeId
		{
			get
			{
				return this.nodeId_;
			}
			set
			{
				this.nodeId_ = value;
			}
		}

		// Token: 0x1700583A RID: 22586
		// (get) Token: 0x0601A0E0 RID: 106720 RVA: 0x003CC1AF File Offset: 0x003CA3AF
		// (set) Token: 0x0601A0E1 RID: 106721 RVA: 0x003CC1B7 File Offset: 0x003CA3B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Point
		{
			get
			{
				return this.point_;
			}
			set
			{
				this.point_ = value;
			}
		}

		// Token: 0x0601A0E2 RID: 106722 RVA: 0x003CC1C0 File Offset: 0x003CA3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitWalkingPatternPointRequest);
		}

		// Token: 0x0601A0E3 RID: 106723 RVA: 0x003CC1D0 File Offset: 0x003CA3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitWalkingPatternPointRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.Point == other.Point && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A0E4 RID: 106724 RVA: 0x003CC23C File Offset: 0x003CA43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeOwnerId != 0)
			{
				num ^= this.TreeOwnerId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this.NodeId != 0)
			{
				num ^= this.NodeId.GetHashCode();
			}
			if (this.Point != 0)
			{
				num ^= this.Point.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A0E5 RID: 106725 RVA: 0x003CC2C6 File Offset: 0x003CA4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A0E6 RID: 106726 RVA: 0x003CC2D3 File Offset: 0x003CA4D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A0E7 RID: 106727 RVA: 0x003CC2DC File Offset: 0x003CA4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NodeId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.NodeId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.Point != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Point);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A0E8 RID: 106728 RVA: 0x003CC370 File Offset: 0x003CA570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this.NodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NodeId);
			}
			if (this.Point != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Point);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A0E9 RID: 106729 RVA: 0x003CC3F8 File Offset: 0x003CA5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitWalkingPatternPointRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeOwnerId != 0)
			{
				this.TreeOwnerId = other.TreeOwnerId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			if (other.NodeId != 0)
			{
				this.NodeId = other.NodeId;
			}
			if (other.Point != 0)
			{
				this.Point = other.Point;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A0EA RID: 106730 RVA: 0x003CC470 File Offset: 0x003CA670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A0EB RID: 106731 RVA: 0x003CC47C File Offset: 0x003CA67C
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
				if (num <= 72U)
				{
					if (num == 24U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.Point = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009962 RID: 39266
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009963 RID: 39267
		public const int TreeOwnerIdFieldNumber = 9;

		// Token: 0x04009964 RID: 39268
		private int treeOwnerId_;

		// Token: 0x04009965 RID: 39269
		public const int TreeIncIdFieldNumber = 14;

		// Token: 0x04009966 RID: 39270
		private long treeIncId_;

		// Token: 0x04009967 RID: 39271
		public const int NodeIdFieldNumber = 3;

		// Token: 0x04009968 RID: 39272
		private int nodeId_;

		// Token: 0x04009969 RID: 39273
		public const int PointFieldNumber = 15;

		// Token: 0x0400996A RID: 39274
		private int point_;
	}
}
