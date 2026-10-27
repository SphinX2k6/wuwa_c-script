using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000738 RID: 1848
	[NetMessage(EMessageId.HandInItemRequest)]
	public sealed class HandInItemRequest : IMessage<HandInItemRequest>, IMessage, IEquatable<HandInItemRequest>, IDeepCloneable<HandInItemRequest>, IBufferMessage
	{
		// Token: 0x0600A789 RID: 42889 RVA: 0x00193438 File Offset: 0x00191638
		[NullableContext(1)]
		public static HandInItemRequest Create()
		{
			return new HandInItemRequest();
		}

		// Token: 0x170021AE RID: 8622
		// (get) Token: 0x0600A78A RID: 42890 RVA: 0x0019343F File Offset: 0x0019163F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021AF RID: 8623
		// (get) Token: 0x0600A78B RID: 42891 RVA: 0x00193442 File Offset: 0x00191642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HandInItemRequest.Descriptor;
			}
		}

		// Token: 0x0600A78C RID: 42892 RVA: 0x00193449 File Offset: 0x00191649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInItemRequest()
		{
		}

		// Token: 0x0600A78D RID: 42893 RVA: 0x0019345C File Offset: 0x0019165C
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

		// Token: 0x0600A78E RID: 42894 RVA: 0x001934B5 File Offset: 0x001916B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInItemRequest Clone()
		{
			return new HandInItemRequest(this);
		}

		// Token: 0x170021B0 RID: 8624
		// (get) Token: 0x0600A78F RID: 42895 RVA: 0x001934BD File Offset: 0x001916BD
		// (set) Token: 0x0600A790 RID: 42896 RVA: 0x001934C5 File Offset: 0x001916C5
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

		// Token: 0x170021B1 RID: 8625
		// (get) Token: 0x0600A791 RID: 42897 RVA: 0x001934CE File Offset: 0x001916CE
		// (set) Token: 0x0600A792 RID: 42898 RVA: 0x001934D6 File Offset: 0x001916D6
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

		// Token: 0x170021B2 RID: 8626
		// (get) Token: 0x0600A793 RID: 42899 RVA: 0x001934DF File Offset: 0x001916DF
		// (set) Token: 0x0600A794 RID: 42900 RVA: 0x001934E7 File Offset: 0x001916E7
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

		// Token: 0x170021B3 RID: 8627
		// (get) Token: 0x0600A795 RID: 42901 RVA: 0x001934F0 File Offset: 0x001916F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbHandInItem> HandInItem
		{
			get
			{
				return this.handInItem_;
			}
		}

		// Token: 0x0600A796 RID: 42902 RVA: 0x001934F8 File Offset: 0x001916F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HandInItemRequest);
		}

		// Token: 0x0600A797 RID: 42903 RVA: 0x00193508 File Offset: 0x00191708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HandInItemRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.handInItem_.Equals(other.handInItem_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A798 RID: 42904 RVA: 0x00193578 File Offset: 0x00191778
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

		// Token: 0x0600A799 RID: 42905 RVA: 0x001935F7 File Offset: 0x001917F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A79A RID: 42906 RVA: 0x00193604 File Offset: 0x00191804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A79B RID: 42907 RVA: 0x00193610 File Offset: 0x00191810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NodeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.NodeId);
			}
			this.handInItem_.WriteTo(ref output, HandInItemRequest._repeated_handInItem_codec);
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
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A79C RID: 42908 RVA: 0x00193698 File Offset: 0x00191898
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

		// Token: 0x0600A79D RID: 42909 RVA: 0x0019371C File Offset: 0x0019191C
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

		// Token: 0x0600A79E RID: 42910 RVA: 0x00193791 File Offset: 0x00191991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A79F RID: 42911 RVA: 0x0019379C File Offset: 0x0019199C
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
				if (num <= 50U)
				{
					if (num == 8U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						this.handInItem_.AddEntriesFrom(ref input, HandInItemRequest._repeated_handInItem_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004C93 RID: 19603
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C94 RID: 19604
		public const int TreeOwnerIdFieldNumber = 9;

		// Token: 0x04004C95 RID: 19605
		private int treeOwnerId_;

		// Token: 0x04004C96 RID: 19606
		public const int TreeIncIdFieldNumber = 14;

		// Token: 0x04004C97 RID: 19607
		private long treeIncId_;

		// Token: 0x04004C98 RID: 19608
		public const int NodeIdFieldNumber = 1;

		// Token: 0x04004C99 RID: 19609
		private int nodeId_;

		// Token: 0x04004C9A RID: 19610
		public const int HandInItemFieldNumber = 6;

		// Token: 0x04004C9B RID: 19611
		private static readonly FieldCodec<PbHandInItem> _repeated_handInItem_codec = FieldCodec.ForMessage<PbHandInItem>(50U, PbHandInItem.Parser);

		// Token: 0x04004C9C RID: 19612
		private readonly RepeatedField<PbHandInItem> handInItem_ = new RepeatedField<PbHandInItem>();
	}
}
