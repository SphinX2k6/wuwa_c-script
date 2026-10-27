using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200125D RID: 4701
	[NetMessage(EMessageId.SneakRequest)]
	public sealed class SneakRequest : IMessage<SneakRequest>, IMessage, IEquatable<SneakRequest>, IDeepCloneable<SneakRequest>, IBufferMessage
	{
		// Token: 0x060190BF RID: 102591 RVA: 0x003A4F38 File Offset: 0x003A3138
		[NullableContext(1)]
		public static SneakRequest Create()
		{
			return new SneakRequest();
		}

		// Token: 0x1700547A RID: 21626
		// (get) Token: 0x060190C0 RID: 102592 RVA: 0x003A4F3F File Offset: 0x003A313F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700547B RID: 21627
		// (get) Token: 0x060190C1 RID: 102593 RVA: 0x003A4F42 File Offset: 0x003A3142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SneakRequest.Descriptor;
			}
		}

		// Token: 0x060190C2 RID: 102594 RVA: 0x003A4F49 File Offset: 0x003A3149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakRequest()
		{
		}

		// Token: 0x060190C3 RID: 102595 RVA: 0x003A4F54 File Offset: 0x003A3154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakRequest(SneakRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.isStart_ = other.isStart_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060190C4 RID: 102596 RVA: 0x003A4FA8 File Offset: 0x003A31A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakRequest Clone()
		{
			return new SneakRequest(this);
		}

		// Token: 0x1700547C RID: 21628
		// (get) Token: 0x060190C5 RID: 102597 RVA: 0x003A4FB0 File Offset: 0x003A31B0
		// (set) Token: 0x060190C6 RID: 102598 RVA: 0x003A4FB8 File Offset: 0x003A31B8
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

		// Token: 0x1700547D RID: 21629
		// (get) Token: 0x060190C7 RID: 102599 RVA: 0x003A4FC1 File Offset: 0x003A31C1
		// (set) Token: 0x060190C8 RID: 102600 RVA: 0x003A4FC9 File Offset: 0x003A31C9
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

		// Token: 0x1700547E RID: 21630
		// (get) Token: 0x060190C9 RID: 102601 RVA: 0x003A4FD2 File Offset: 0x003A31D2
		// (set) Token: 0x060190CA RID: 102602 RVA: 0x003A4FDA File Offset: 0x003A31DA
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

		// Token: 0x1700547F RID: 21631
		// (get) Token: 0x060190CB RID: 102603 RVA: 0x003A4FE3 File Offset: 0x003A31E3
		// (set) Token: 0x060190CC RID: 102604 RVA: 0x003A4FEB File Offset: 0x003A31EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsStart
		{
			get
			{
				return this.isStart_;
			}
			set
			{
				this.isStart_ = value;
			}
		}

		// Token: 0x060190CD RID: 102605 RVA: 0x003A4FF4 File Offset: 0x003A31F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SneakRequest);
		}

		// Token: 0x060190CE RID: 102606 RVA: 0x003A5004 File Offset: 0x003A3204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SneakRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.IsStart == other.IsStart && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060190CF RID: 102607 RVA: 0x003A5070 File Offset: 0x003A3270
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
			if (this.IsStart)
			{
				num ^= this.IsStart.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060190D0 RID: 102608 RVA: 0x003A50FA File Offset: 0x003A32FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060190D1 RID: 102609 RVA: 0x003A5107 File Offset: 0x003A3307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060190D2 RID: 102610 RVA: 0x003A5110 File Offset: 0x003A3310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NodeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.NodeId);
			}
			if (this.IsStart)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsStart);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060190D3 RID: 102611 RVA: 0x003A51A0 File Offset: 0x003A33A0
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
			if (this.IsStart)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060190D4 RID: 102612 RVA: 0x003A521C File Offset: 0x003A341C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SneakRequest other)
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
			if (other.IsStart)
			{
				this.IsStart = other.IsStart;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060190D5 RID: 102613 RVA: 0x003A5294 File Offset: 0x003A3494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060190D6 RID: 102614 RVA: 0x003A52A0 File Offset: 0x003A34A0
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
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsStart = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009392 RID: 37778
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009393 RID: 37779
		public const int TreeOwnerIdFieldNumber = 3;

		// Token: 0x04009394 RID: 37780
		private int treeOwnerId_;

		// Token: 0x04009395 RID: 37781
		public const int TreeIncIdFieldNumber = 6;

		// Token: 0x04009396 RID: 37782
		private long treeIncId_;

		// Token: 0x04009397 RID: 37783
		public const int NodeIdFieldNumber = 1;

		// Token: 0x04009398 RID: 37784
		private int nodeId_;

		// Token: 0x04009399 RID: 37785
		public const int IsStartFieldNumber = 2;

		// Token: 0x0400939A RID: 37786
		private bool isStart_;
	}
}
