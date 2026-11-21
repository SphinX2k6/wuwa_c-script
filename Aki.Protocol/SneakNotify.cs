using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001299 RID: 4761
	[NetMessage(EMessageId.SneakNotify)]
	public sealed class SneakNotify : IMessage<SneakNotify>, IMessage, IEquatable<SneakNotify>, IDeepCloneable<SneakNotify>, IBufferMessage
	{
		// Token: 0x06019691 RID: 104081 RVA: 0x003B4A91 File Offset: 0x003B2C91
		[NullableContext(1)]
		public static SneakNotify Create()
		{
			return new SneakNotify();
		}

		// Token: 0x170055F3 RID: 22003
		// (get) Token: 0x06019692 RID: 104082 RVA: 0x003B4A98 File Offset: 0x003B2C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055F4 RID: 22004
		// (get) Token: 0x06019693 RID: 104083 RVA: 0x003B4A9B File Offset: 0x003B2C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SneakNotify.Descriptor;
			}
		}

		// Token: 0x06019694 RID: 104084 RVA: 0x003B4AA2 File Offset: 0x003B2CA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakNotify()
		{
		}

		// Token: 0x06019695 RID: 104085 RVA: 0x003B4AAC File Offset: 0x003B2CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakNotify(SneakNotify other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019696 RID: 104086 RVA: 0x003B4B00 File Offset: 0x003B2D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakNotify Clone()
		{
			return new SneakNotify(this);
		}

		// Token: 0x170055F5 RID: 22005
		// (get) Token: 0x06019697 RID: 104087 RVA: 0x003B4B08 File Offset: 0x003B2D08
		// (set) Token: 0x06019698 RID: 104088 RVA: 0x003B4B10 File Offset: 0x003B2D10
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

		// Token: 0x170055F6 RID: 22006
		// (get) Token: 0x06019699 RID: 104089 RVA: 0x003B4B19 File Offset: 0x003B2D19
		// (set) Token: 0x0601969A RID: 104090 RVA: 0x003B4B21 File Offset: 0x003B2D21
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

		// Token: 0x170055F7 RID: 22007
		// (get) Token: 0x0601969B RID: 104091 RVA: 0x003B4B2A File Offset: 0x003B2D2A
		// (set) Token: 0x0601969C RID: 104092 RVA: 0x003B4B32 File Offset: 0x003B2D32
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

		// Token: 0x170055F8 RID: 22008
		// (get) Token: 0x0601969D RID: 104093 RVA: 0x003B4B3B File Offset: 0x003B2D3B
		// (set) Token: 0x0601969E RID: 104094 RVA: 0x003B4B43 File Offset: 0x003B2D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x0601969F RID: 104095 RVA: 0x003B4B4C File Offset: 0x003B2D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SneakNotify);
		}

		// Token: 0x060196A0 RID: 104096 RVA: 0x003B4B5C File Offset: 0x003B2D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SneakNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060196A1 RID: 104097 RVA: 0x003B4BC8 File Offset: 0x003B2DC8
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
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060196A2 RID: 104098 RVA: 0x003B4C52 File Offset: 0x003B2E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060196A3 RID: 104099 RVA: 0x003B4C5F File Offset: 0x003B2E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060196A4 RID: 104100 RVA: 0x003B4C68 File Offset: 0x003B2E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.NodeId);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EndTime);
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

		// Token: 0x060196A5 RID: 104101 RVA: 0x003B4CFC File Offset: 0x003B2EFC
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
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060196A6 RID: 104102 RVA: 0x003B4D84 File Offset: 0x003B2F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SneakNotify other)
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
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060196A7 RID: 104103 RVA: 0x003B4DFC File Offset: 0x003B2FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060196A8 RID: 104104 RVA: 0x003B4E08 File Offset: 0x003B3008
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
				if (num <= 32U)
				{
					if (num == 16U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.EndTime = input.ReadInt64();
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

		// Token: 0x0400963B RID: 38459
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400963C RID: 38460
		public const int TreeOwnerIdFieldNumber = 2;

		// Token: 0x0400963D RID: 38461
		private int treeOwnerId_;

		// Token: 0x0400963E RID: 38462
		public const int TreeIncIdFieldNumber = 15;

		// Token: 0x0400963F RID: 38463
		private long treeIncId_;

		// Token: 0x04009640 RID: 38464
		public const int NodeIdFieldNumber = 4;

		// Token: 0x04009641 RID: 38465
		private int nodeId_;

		// Token: 0x04009642 RID: 38466
		public const int EndTimeFieldNumber = 9;

		// Token: 0x04009643 RID: 38467
		private long endTime_;
	}
}
