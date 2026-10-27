using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200011D RID: 285
	[NetMessage(EMessageId.AtomicProcessTeleportRequest)]
	public sealed class AtomicProcessTeleportRequest : IMessage<AtomicProcessTeleportRequest>, IMessage, IEquatable<AtomicProcessTeleportRequest>, IDeepCloneable<AtomicProcessTeleportRequest>, IBufferMessage
	{
		// Token: 0x060026A3 RID: 9891 RVA: 0x0006695D File Offset: 0x00064B5D
		[NullableContext(1)]
		public static AtomicProcessTeleportRequest Create()
		{
			return new AtomicProcessTeleportRequest();
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060026A4 RID: 9892 RVA: 0x00066964 File Offset: 0x00064B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060026A5 RID: 9893 RVA: 0x00066967 File Offset: 0x00064B67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AtomicProcessTeleportRequest.Descriptor;
			}
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x0006696E File Offset: 0x00064B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessTeleportRequest()
		{
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x00066978 File Offset: 0x00064B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessTeleportRequest(AtomicProcessTeleportRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.splineEntityId_ = other.splineEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x000669CC File Offset: 0x00064BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessTeleportRequest Clone()
		{
			return new AtomicProcessTeleportRequest(this);
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060026A9 RID: 9897 RVA: 0x000669D4 File Offset: 0x00064BD4
		// (set) Token: 0x060026AA RID: 9898 RVA: 0x000669DC File Offset: 0x00064BDC
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

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060026AB RID: 9899 RVA: 0x000669E5 File Offset: 0x00064BE5
		// (set) Token: 0x060026AC RID: 9900 RVA: 0x000669ED File Offset: 0x00064BED
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

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060026AD RID: 9901 RVA: 0x000669F6 File Offset: 0x00064BF6
		// (set) Token: 0x060026AE RID: 9902 RVA: 0x000669FE File Offset: 0x00064BFE
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

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060026AF RID: 9903 RVA: 0x00066A07 File Offset: 0x00064C07
		// (set) Token: 0x060026B0 RID: 9904 RVA: 0x00066A0F File Offset: 0x00064C0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SplineEntityId
		{
			get
			{
				return this.splineEntityId_;
			}
			set
			{
				this.splineEntityId_ = value;
			}
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x00066A18 File Offset: 0x00064C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AtomicProcessTeleportRequest);
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x00066A28 File Offset: 0x00064C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AtomicProcessTeleportRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.SplineEntityId == other.SplineEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x00066A94 File Offset: 0x00064C94
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
			if (this.SplineEntityId != 0)
			{
				num ^= this.SplineEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x00066B1E File Offset: 0x00064D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x00066B2B File Offset: 0x00064D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x00066B34 File Offset: 0x00064D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.NodeId);
			}
			if (this.SplineEntityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SplineEntityId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x00066BC4 File Offset: 0x00064DC4
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
			if (this.SplineEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x00066C4C File Offset: 0x00064E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AtomicProcessTeleportRequest other)
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
			if (other.SplineEntityId != 0)
			{
				this.SplineEntityId = other.SplineEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x00066CC4 File Offset: 0x00064EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x00066CD0 File Offset: 0x00064ED0
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
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.SplineEntityId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002627 RID: 9767
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002628 RID: 9768
		public const int TreeOwnerIdFieldNumber = 1;

		// Token: 0x04002629 RID: 9769
		private int treeOwnerId_;

		// Token: 0x0400262A RID: 9770
		public const int TreeIncIdFieldNumber = 15;

		// Token: 0x0400262B RID: 9771
		private long treeIncId_;

		// Token: 0x0400262C RID: 9772
		public const int NodeIdFieldNumber = 5;

		// Token: 0x0400262D RID: 9773
		private int nodeId_;

		// Token: 0x0400262E RID: 9774
		public const int SplineEntityIdFieldNumber = 8;

		// Token: 0x0400262F RID: 9775
		private int splineEntityId_;
	}
}
