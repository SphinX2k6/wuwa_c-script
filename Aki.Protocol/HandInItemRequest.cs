using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000724 RID: 1828
	[NetMessage(EMessageId.HandInItemRequest)]
	public sealed class HandInItemRequest : IMessage<HandInItemRequest>, IMessage, IEquatable<HandInItemRequest>, IDeepCloneable<HandInItemRequest>, IBufferMessage
	{
		// Token: 0x0600A633 RID: 42547 RVA: 0x00190A04 File Offset: 0x0018EC04
		[NullableContext(1)]
		public static HandInItemRequest Create()
		{
			return new HandInItemRequest();
		}

		// Token: 0x17002164 RID: 8548
		// (get) Token: 0x0600A634 RID: 42548 RVA: 0x00190A0B File Offset: 0x0018EC0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x0600A635 RID: 42549 RVA: 0x00190A0E File Offset: 0x0018EC0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HandInItemRequest.Descriptor;
			}
		}

		// Token: 0x0600A636 RID: 42550 RVA: 0x00190A15 File Offset: 0x0018EC15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInItemRequest()
		{
		}

		// Token: 0x0600A637 RID: 42551 RVA: 0x00190A28 File Offset: 0x0018EC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInItemRequest(HandInItemRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.handInItem_ = other.handInItem_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A638 RID: 42552 RVA: 0x00190A81 File Offset: 0x0018EC81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInItemRequest Clone()
		{
			return new HandInItemRequest(this);
		}

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x0600A639 RID: 42553 RVA: 0x00190A89 File Offset: 0x0018EC89
		// (set) Token: 0x0600A63A RID: 42554 RVA: 0x00190A91 File Offset: 0x0018EC91
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

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x0600A63B RID: 42555 RVA: 0x00190A9A File Offset: 0x0018EC9A
		// (set) Token: 0x0600A63C RID: 42556 RVA: 0x00190AA2 File Offset: 0x0018ECA2
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

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x0600A63D RID: 42557 RVA: 0x00190AAB File Offset: 0x0018ECAB
		// (set) Token: 0x0600A63E RID: 42558 RVA: 0x00190AB3 File Offset: 0x0018ECB3
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

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x0600A63F RID: 42559 RVA: 0x00190ABC File Offset: 0x0018ECBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbHandInItem> HandInItem
		{
			get
			{
				return this.handInItem_;
			}
		}

		// Token: 0x0600A640 RID: 42560 RVA: 0x00190AC4 File Offset: 0x0018ECC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HandInItemRequest);
		}

		// Token: 0x0600A641 RID: 42561 RVA: 0x00190AD4 File Offset: 0x0018ECD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HandInItemRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.handInItem_.Equals(other.handInItem_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A642 RID: 42562 RVA: 0x00190B44 File Offset: 0x0018ED44
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
			num ^= this.handInItem_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A643 RID: 42563 RVA: 0x00190BC3 File Offset: 0x0018EDC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A644 RID: 42564 RVA: 0x00190BD0 File Offset: 0x0018EDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A645 RID: 42565 RVA: 0x00190BDC File Offset: 0x0018EDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.handInItem_.WriteTo(ref output, HandInItemRequest._repeated_handInItem_codec);
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.NodeId);
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

		// Token: 0x0600A646 RID: 42566 RVA: 0x00190C64 File Offset: 0x0018EE64
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
			num += this.handInItem_.CalculateSize(HandInItemRequest._repeated_handInItem_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A647 RID: 42567 RVA: 0x00190CE8 File Offset: 0x0018EEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HandInItemRequest other)
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
			this.handInItem_.Add(other.handInItem_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A648 RID: 42568 RVA: 0x00190D5D File Offset: 0x0018EF5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A649 RID: 42569 RVA: 0x00190D68 File Offset: 0x0018EF68
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
					if (num == 18U)
					{
						this.handInItem_.AddEntriesFrom(ref input, HandInItemRequest._repeated_handInItem_codec);
						continue;
					}
					if (num == 64U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.NodeId = input.ReadInt32();
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

		// Token: 0x04004C8C RID: 19596
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C8D RID: 19597
		public const int TreeOwnerIdFieldNumber = 8;

		// Token: 0x04004C8E RID: 19598
		private int treeOwnerId_;

		// Token: 0x04004C8F RID: 19599
		public const int TreeIncIdFieldNumber = 15;

		// Token: 0x04004C90 RID: 19600
		private long treeIncId_;

		// Token: 0x04004C91 RID: 19601
		public const int NodeIdFieldNumber = 13;

		// Token: 0x04004C92 RID: 19602
		private int nodeId_;

		// Token: 0x04004C93 RID: 19603
		public const int HandInItemFieldNumber = 2;

		// Token: 0x04004C94 RID: 19604
		private static readonly FieldCodec<PbHandInItem> _repeated_handInItem_codec = FieldCodec.ForMessage<PbHandInItem>(18U, PbHandInItem.Parser);

		// Token: 0x04004C95 RID: 19605
		private readonly RepeatedField<PbHandInItem> handInItem_ = new RepeatedField<PbHandInItem>();
	}
}
