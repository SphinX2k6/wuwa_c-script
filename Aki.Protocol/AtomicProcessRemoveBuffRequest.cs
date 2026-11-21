using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200011D RID: 285
	[NetMessage(EMessageId.AtomicProcessRemoveBuffRequest)]
	public sealed class AtomicProcessRemoveBuffRequest : IMessage<AtomicProcessRemoveBuffRequest>, IMessage, IEquatable<AtomicProcessRemoveBuffRequest>, IDeepCloneable<AtomicProcessRemoveBuffRequest>, IBufferMessage
	{
		// Token: 0x060026D6 RID: 9942 RVA: 0x000672F9 File Offset: 0x000654F9
		[NullableContext(1)]
		public static AtomicProcessRemoveBuffRequest Create()
		{
			return new AtomicProcessRemoveBuffRequest();
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x00067300 File Offset: 0x00065500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060026D8 RID: 9944 RVA: 0x00067303 File Offset: 0x00065503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AtomicProcessRemoveBuffRequest.Descriptor;
			}
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x0006730A File Offset: 0x0006550A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessRemoveBuffRequest()
		{
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x00067320 File Offset: 0x00065520
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

		// Token: 0x060026DB RID: 9947 RVA: 0x00067385 File Offset: 0x00065585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessRemoveBuffRequest Clone()
		{
			return new AtomicProcessRemoveBuffRequest(this);
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060026DC RID: 9948 RVA: 0x0006738D File Offset: 0x0006558D
		// (set) Token: 0x060026DD RID: 9949 RVA: 0x00067395 File Offset: 0x00065595
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

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060026DE RID: 9950 RVA: 0x0006739E File Offset: 0x0006559E
		// (set) Token: 0x060026DF RID: 9951 RVA: 0x000673A6 File Offset: 0x000655A6
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

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060026E0 RID: 9952 RVA: 0x000673AF File Offset: 0x000655AF
		// (set) Token: 0x060026E1 RID: 9953 RVA: 0x000673B7 File Offset: 0x000655B7
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

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060026E2 RID: 9954 RVA: 0x000673C0 File Offset: 0x000655C0
		// (set) Token: 0x060026E3 RID: 9955 RVA: 0x000673C8 File Offset: 0x000655C8
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

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060026E4 RID: 9956 RVA: 0x000673D1 File Offset: 0x000655D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x000673D9 File Offset: 0x000655D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AtomicProcessRemoveBuffRequest);
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x000673E8 File Offset: 0x000655E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AtomicProcessRemoveBuffRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.EntityId == other.EntityId && this.buffIds_.Equals(other.buffIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x00067468 File Offset: 0x00065668
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

		// Token: 0x060026E8 RID: 9960 RVA: 0x00067500 File Offset: 0x00065700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0006750D File Offset: 0x0006570D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x00067518 File Offset: 0x00065718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.EntityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EntityId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.NodeId);
			}
			this.buffIds_.WriteTo(ref output, AtomicProcessRemoveBuffRequest._repeated_buffIds_codec);
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x000675BC File Offset: 0x000657BC
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

		// Token: 0x060026EC RID: 9964 RVA: 0x00067658 File Offset: 0x00065858
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

		// Token: 0x060026ED RID: 9965 RVA: 0x000676E1 File Offset: 0x000658E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x000676EC File Offset: 0x000658EC
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
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.EntityId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U || num == 90U)
					{
						this.buffIds_.AddEntriesFrom(ref input, AtomicProcessRemoveBuffRequest._repeated_buffIds_codec);
						continue;
					}
					if (num == 96U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002683 RID: 9859
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002684 RID: 9860
		public const int TreeOwnerIdFieldNumber = 12;

		// Token: 0x04002685 RID: 9861
		private int treeOwnerId_;

		// Token: 0x04002686 RID: 9862
		public const int TreeIncIdFieldNumber = 1;

		// Token: 0x04002687 RID: 9863
		private long treeIncId_;

		// Token: 0x04002688 RID: 9864
		public const int NodeIdFieldNumber = 6;

		// Token: 0x04002689 RID: 9865
		private int nodeId_;

		// Token: 0x0400268A RID: 9866
		public const int EntityIdFieldNumber = 2;

		// Token: 0x0400268B RID: 9867
		private int entityId_;

		// Token: 0x0400268C RID: 9868
		public const int BuffIdsFieldNumber = 11;

		// Token: 0x0400268D RID: 9869
		private static readonly FieldCodec<long> _repeated_buffIds_codec = FieldCodec.ForInt64(90U);

		// Token: 0x0400268E RID: 9870
		private readonly RepeatedField<long> buffIds_ = new RepeatedField<long>();
	}
}
