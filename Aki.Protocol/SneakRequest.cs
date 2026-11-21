using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200129A RID: 4762
	[NetMessage(EMessageId.SneakRequest)]
	public sealed class SneakRequest : IMessage<SneakRequest>, IMessage, IEquatable<SneakRequest>, IDeepCloneable<SneakRequest>, IBufferMessage
	{
		// Token: 0x060196A9 RID: 104105 RVA: 0x003B4E8D File Offset: 0x003B308D
		[NullableContext(1)]
		public static SneakRequest Create()
		{
			return new SneakRequest();
		}

		// Token: 0x170055F9 RID: 22009
		// (get) Token: 0x060196AA RID: 104106 RVA: 0x003B4E94 File Offset: 0x003B3094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055FA RID: 22010
		// (get) Token: 0x060196AB RID: 104107 RVA: 0x003B4E97 File Offset: 0x003B3097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SneakRequest.Descriptor;
			}
		}

		// Token: 0x060196AC RID: 104108 RVA: 0x003B4E9E File Offset: 0x003B309E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakRequest()
		{
		}

		// Token: 0x060196AD RID: 104109 RVA: 0x003B4EA8 File Offset: 0x003B30A8
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

		// Token: 0x060196AE RID: 104110 RVA: 0x003B4EFC File Offset: 0x003B30FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakRequest Clone()
		{
			return new SneakRequest(this);
		}

		// Token: 0x170055FB RID: 22011
		// (get) Token: 0x060196AF RID: 104111 RVA: 0x003B4F04 File Offset: 0x003B3104
		// (set) Token: 0x060196B0 RID: 104112 RVA: 0x003B4F0C File Offset: 0x003B310C
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

		// Token: 0x170055FC RID: 22012
		// (get) Token: 0x060196B1 RID: 104113 RVA: 0x003B4F15 File Offset: 0x003B3115
		// (set) Token: 0x060196B2 RID: 104114 RVA: 0x003B4F1D File Offset: 0x003B311D
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

		// Token: 0x170055FD RID: 22013
		// (get) Token: 0x060196B3 RID: 104115 RVA: 0x003B4F26 File Offset: 0x003B3126
		// (set) Token: 0x060196B4 RID: 104116 RVA: 0x003B4F2E File Offset: 0x003B312E
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

		// Token: 0x170055FE RID: 22014
		// (get) Token: 0x060196B5 RID: 104117 RVA: 0x003B4F37 File Offset: 0x003B3137
		// (set) Token: 0x060196B6 RID: 104118 RVA: 0x003B4F3F File Offset: 0x003B313F
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

		// Token: 0x060196B7 RID: 104119 RVA: 0x003B4F48 File Offset: 0x003B3148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SneakRequest);
		}

		// Token: 0x060196B8 RID: 104120 RVA: 0x003B4F58 File Offset: 0x003B3158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SneakRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.IsStart == other.IsStart && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060196B9 RID: 104121 RVA: 0x003B4FC4 File Offset: 0x003B31C4
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

		// Token: 0x060196BA RID: 104122 RVA: 0x003B504E File Offset: 0x003B324E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060196BB RID: 104123 RVA: 0x003B505B File Offset: 0x003B325B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060196BC RID: 104124 RVA: 0x003B5064 File Offset: 0x003B3264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.NodeId);
			}
			if (this.IsStart)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsStart);
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

		// Token: 0x060196BD RID: 104125 RVA: 0x003B50F8 File Offset: 0x003B32F8
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

		// Token: 0x060196BE RID: 104126 RVA: 0x003B5174 File Offset: 0x003B3374
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

		// Token: 0x060196BF RID: 104127 RVA: 0x003B51EC File Offset: 0x003B33EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060196C0 RID: 104128 RVA: 0x003B51F8 File Offset: 0x003B33F8
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
				if (num <= 56U)
				{
					if (num == 40U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.IsStart = input.ReadBool();
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

		// Token: 0x04009644 RID: 38468
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009645 RID: 38469
		public const int TreeOwnerIdFieldNumber = 5;

		// Token: 0x04009646 RID: 38470
		private int treeOwnerId_;

		// Token: 0x04009647 RID: 38471
		public const int TreeIncIdFieldNumber = 14;

		// Token: 0x04009648 RID: 38472
		private long treeIncId_;

		// Token: 0x04009649 RID: 38473
		public const int NodeIdFieldNumber = 7;

		// Token: 0x0400964A RID: 38474
		private int nodeId_;

		// Token: 0x0400964B RID: 38475
		public const int IsStartFieldNumber = 11;

		// Token: 0x0400964C RID: 38476
		private bool isStart_;
	}
}
