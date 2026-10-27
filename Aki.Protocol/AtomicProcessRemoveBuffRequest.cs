using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200011B RID: 283
	[NetMessage(EMessageId.AtomicProcessRemoveBuffRequest)]
	public sealed class AtomicProcessRemoveBuffRequest : IMessage<AtomicProcessRemoveBuffRequest>, IMessage, IEquatable<AtomicProcessRemoveBuffRequest>, IDeepCloneable<AtomicProcessRemoveBuffRequest>, IBufferMessage
	{
		// Token: 0x06002677 RID: 9847 RVA: 0x000662D5 File Offset: 0x000644D5
		[NullableContext(1)]
		public static AtomicProcessRemoveBuffRequest Create()
		{
			return new AtomicProcessRemoveBuffRequest();
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06002678 RID: 9848 RVA: 0x000662DC File Offset: 0x000644DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06002679 RID: 9849 RVA: 0x000662DF File Offset: 0x000644DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AtomicProcessRemoveBuffRequest.Descriptor;
			}
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x000662E6 File Offset: 0x000644E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessRemoveBuffRequest()
		{
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x000662FC File Offset: 0x000644FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessRemoveBuffRequest(AtomicProcessRemoveBuffRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.entityId_ = other.entityId_;
			this.buffIds_ = other.buffIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x00066361 File Offset: 0x00064561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessRemoveBuffRequest Clone()
		{
			return new AtomicProcessRemoveBuffRequest(this);
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600267D RID: 9853 RVA: 0x00066369 File Offset: 0x00064569
		// (set) Token: 0x0600267E RID: 9854 RVA: 0x00066371 File Offset: 0x00064571
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

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x0006637A File Offset: 0x0006457A
		// (set) Token: 0x06002680 RID: 9856 RVA: 0x00066382 File Offset: 0x00064582
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

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06002681 RID: 9857 RVA: 0x0006638B File Offset: 0x0006458B
		// (set) Token: 0x06002682 RID: 9858 RVA: 0x00066393 File Offset: 0x00064593
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

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06002683 RID: 9859 RVA: 0x0006639C File Offset: 0x0006459C
		// (set) Token: 0x06002684 RID: 9860 RVA: 0x000663A4 File Offset: 0x000645A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06002685 RID: 9861 RVA: 0x000663AD File Offset: 0x000645AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x000663B5 File Offset: 0x000645B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AtomicProcessRemoveBuffRequest);
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x000663C4 File Offset: 0x000645C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AtomicProcessRemoveBuffRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.EntityId == other.EntityId && this.buffIds_.Equals(other.buffIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x00066444 File Offset: 0x00064644
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
			if (this.EntityId != 0)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.buffIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x000664DC File Offset: 0x000646DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x000664E9 File Offset: 0x000646E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x000664F4 File Offset: 0x000646F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NodeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.NodeId);
			}
			if (this.EntityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EntityId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TreeOwnerId);
			}
			this.buffIds_.WriteTo(ref output, AtomicProcessRemoveBuffRequest._repeated_buffIds_codec);
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x00066598 File Offset: 0x00064798
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
			if (this.EntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityId);
			}
			num += this.buffIds_.CalculateSize(AtomicProcessRemoveBuffRequest._repeated_buffIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x00066634 File Offset: 0x00064834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AtomicProcessRemoveBuffRequest other)
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
			if (other.EntityId != 0)
			{
				this.EntityId = other.EntityId;
			}
			this.buffIds_.Add(other.buffIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x000666BD File Offset: 0x000648BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x000666C8 File Offset: 0x000648C8
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
				if (num <= 48U)
				{
					if (num == 8U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.EntityId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U || num == 66U)
					{
						this.buffIds_.AddEntriesFrom(ref input, AtomicProcessRemoveBuffRequest._repeated_buffIds_codec);
						continue;
					}
					if (num == 88U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002618 RID: 9752
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002619 RID: 9753
		public const int TreeOwnerIdFieldNumber = 6;

		// Token: 0x0400261A RID: 9754
		private int treeOwnerId_;

		// Token: 0x0400261B RID: 9755
		public const int TreeIncIdFieldNumber = 11;

		// Token: 0x0400261C RID: 9756
		private long treeIncId_;

		// Token: 0x0400261D RID: 9757
		public const int NodeIdFieldNumber = 1;

		// Token: 0x0400261E RID: 9758
		private int nodeId_;

		// Token: 0x0400261F RID: 9759
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04002620 RID: 9760
		private int entityId_;

		// Token: 0x04002621 RID: 9761
		public const int BuffIdsFieldNumber = 8;

		// Token: 0x04002622 RID: 9762
		private static readonly FieldCodec<long> _repeated_buffIds_codec = FieldCodec.ForInt64(66U);

		// Token: 0x04002623 RID: 9763
		private readonly RepeatedField<long> buffIds_ = new RepeatedField<long>();
	}
}
