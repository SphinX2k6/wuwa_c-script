using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000132 RID: 306
	[NetMessage(EMessageId.AvoidBlockClientInitDoneRequest)]
	public sealed class AvoidBlockClientInitDoneRequest : IMessage<AvoidBlockClientInitDoneRequest>, IMessage, IEquatable<AvoidBlockClientInitDoneRequest>, IDeepCloneable<AvoidBlockClientInitDoneRequest>, IBufferMessage
	{
		// Token: 0x06002851 RID: 10321 RVA: 0x0006A301 File Offset: 0x00068501
		[NullableContext(1)]
		public static AvoidBlockClientInitDoneRequest Create()
		{
			return new AvoidBlockClientInitDoneRequest();
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06002852 RID: 10322 RVA: 0x0006A308 File Offset: 0x00068508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06002853 RID: 10323 RVA: 0x0006A30B File Offset: 0x0006850B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvoidBlockClientInitDoneRequest.Descriptor;
			}
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x0006A312 File Offset: 0x00068512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockClientInitDoneRequest()
		{
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x0006A31A File Offset: 0x0006851A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockClientInitDoneRequest(AvoidBlockClientInitDoneRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x0006A357 File Offset: 0x00068557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockClientInitDoneRequest Clone()
		{
			return new AvoidBlockClientInitDoneRequest(this);
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06002857 RID: 10327 RVA: 0x0006A35F File Offset: 0x0006855F
		// (set) Token: 0x06002858 RID: 10328 RVA: 0x0006A367 File Offset: 0x00068567
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

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06002859 RID: 10329 RVA: 0x0006A370 File Offset: 0x00068570
		// (set) Token: 0x0600285A RID: 10330 RVA: 0x0006A378 File Offset: 0x00068578
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

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x0600285B RID: 10331 RVA: 0x0006A381 File Offset: 0x00068581
		// (set) Token: 0x0600285C RID: 10332 RVA: 0x0006A389 File Offset: 0x00068589
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

		// Token: 0x0600285D RID: 10333 RVA: 0x0006A392 File Offset: 0x00068592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvoidBlockClientInitDoneRequest);
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x0006A3A0 File Offset: 0x000685A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvoidBlockClientInitDoneRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x0006A3FC File Offset: 0x000685FC
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x0006A46D File Offset: 0x0006866D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x0006A47A File Offset: 0x0006867A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x0006A484 File Offset: 0x00068684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.NodeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x0006A4FC File Offset: 0x000686FC
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x0006A56C File Offset: 0x0006876C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvoidBlockClientInitDoneRequest other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x0006A5D0 File Offset: 0x000687D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x0006A5DC File Offset: 0x000687DC
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
				if (num != 32U)
				{
					if (num != 88U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NodeId = input.ReadInt32();
						}
					}
					else
					{
						this.TreeOwnerId = input.ReadInt32();
					}
				}
				else
				{
					this.TreeIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400269A RID: 9882
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400269B RID: 9883
		public const int TreeOwnerIdFieldNumber = 11;

		// Token: 0x0400269C RID: 9884
		private int treeOwnerId_;

		// Token: 0x0400269D RID: 9885
		public const int TreeIncIdFieldNumber = 4;

		// Token: 0x0400269E RID: 9886
		private long treeIncId_;

		// Token: 0x0400269F RID: 9887
		public const int NodeIdFieldNumber = 14;

		// Token: 0x040026A0 RID: 9888
		private int nodeId_;
	}
}
