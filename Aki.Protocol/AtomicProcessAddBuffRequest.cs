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
	[NetMessage(EMessageId.AtomicProcessAddBuffRequest)]
	public sealed class AtomicProcessAddBuffRequest : IMessage<AtomicProcessAddBuffRequest>, IMessage, IEquatable<AtomicProcessAddBuffRequest>, IDeepCloneable<AtomicProcessAddBuffRequest>, IBufferMessage
	{
		// Token: 0x060026AA RID: 9898 RVA: 0x00066C6D File Offset: 0x00064E6D
		[NullableContext(1)]
		public static AtomicProcessAddBuffRequest Create()
		{
			return new AtomicProcessAddBuffRequest();
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060026AB RID: 9899 RVA: 0x00066C74 File Offset: 0x00064E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x00066C77 File Offset: 0x00064E77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AtomicProcessAddBuffRequest.Descriptor;
			}
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x00066C7E File Offset: 0x00064E7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessAddBuffRequest()
		{
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x00066C94 File Offset: 0x00064E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessAddBuffRequest(AtomicProcessAddBuffRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.entityId_ = other.entityId_;
			this.buffIds_ = other.buffIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x00066CF9 File Offset: 0x00064EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessAddBuffRequest Clone()
		{
			return new AtomicProcessAddBuffRequest(this);
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060026B0 RID: 9904 RVA: 0x00066D01 File Offset: 0x00064F01
		// (set) Token: 0x060026B1 RID: 9905 RVA: 0x00066D09 File Offset: 0x00064F09
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

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x060026B2 RID: 9906 RVA: 0x00066D12 File Offset: 0x00064F12
		// (set) Token: 0x060026B3 RID: 9907 RVA: 0x00066D1A File Offset: 0x00064F1A
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

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060026B4 RID: 9908 RVA: 0x00066D23 File Offset: 0x00064F23
		// (set) Token: 0x060026B5 RID: 9909 RVA: 0x00066D2B File Offset: 0x00064F2B
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

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060026B6 RID: 9910 RVA: 0x00066D34 File Offset: 0x00064F34
		// (set) Token: 0x060026B7 RID: 9911 RVA: 0x00066D3C File Offset: 0x00064F3C
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

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060026B8 RID: 9912 RVA: 0x00066D45 File Offset: 0x00064F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x00066D4D File Offset: 0x00064F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AtomicProcessAddBuffRequest);
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x00066D5C File Offset: 0x00064F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AtomicProcessAddBuffRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.EntityId == other.EntityId && this.buffIds_.Equals(other.buffIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x00066DDC File Offset: 0x00064FDC
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

		// Token: 0x060026BC RID: 9916 RVA: 0x00066E74 File Offset: 0x00065074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x00066E81 File Offset: 0x00065081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x00066E8C File Offset: 0x0006508C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.NodeId);
			}
			if (this.EntityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.EntityId);
			}
			this.buffIds_.WriteTo(ref output, AtomicProcessAddBuffRequest._repeated_buffIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x00066F30 File Offset: 0x00065130
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
			num += this.buffIds_.CalculateSize(AtomicProcessAddBuffRequest._repeated_buffIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00066FCC File Offset: 0x000651CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AtomicProcessAddBuffRequest other)
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

		// Token: 0x060026C1 RID: 9921 RVA: 0x00067055 File Offset: 0x00065255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x00067060 File Offset: 0x00065260
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
				if (num <= 96U)
				{
					if (num == 40U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 88U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.EntityId = input.ReadInt32();
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.buffIds_.AddEntriesFrom(ref input, AtomicProcessAddBuffRequest._repeated_buffIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002674 RID: 9844
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002675 RID: 9845
		public const int TreeOwnerIdFieldNumber = 11;

		// Token: 0x04002676 RID: 9846
		private int treeOwnerId_;

		// Token: 0x04002677 RID: 9847
		public const int TreeIncIdFieldNumber = 5;

		// Token: 0x04002678 RID: 9848
		private long treeIncId_;

		// Token: 0x04002679 RID: 9849
		public const int NodeIdFieldNumber = 12;

		// Token: 0x0400267A RID: 9850
		private int nodeId_;

		// Token: 0x0400267B RID: 9851
		public const int EntityIdFieldNumber = 13;

		// Token: 0x0400267C RID: 9852
		private int entityId_;

		// Token: 0x0400267D RID: 9853
		public const int BuffIdsFieldNumber = 15;

		// Token: 0x0400267E RID: 9854
		private static readonly FieldCodec<long> _repeated_buffIds_codec = FieldCodec.ForInt64(122U);

		// Token: 0x0400267F RID: 9855
		private readonly RepeatedField<long> buffIds_ = new RepeatedField<long>();
	}
}
