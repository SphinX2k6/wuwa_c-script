using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200125C RID: 4700
	[NetMessage(EMessageId.SneakNotify)]
	public sealed class SneakNotify : IMessage<SneakNotify>, IMessage, IEquatable<SneakNotify>, IDeepCloneable<SneakNotify>, IBufferMessage
	{
		// Token: 0x060190A7 RID: 102567 RVA: 0x003A4B42 File Offset: 0x003A2D42
		[NullableContext(1)]
		public static SneakNotify Create()
		{
			return new SneakNotify();
		}

		// Token: 0x17005474 RID: 21620
		// (get) Token: 0x060190A8 RID: 102568 RVA: 0x003A4B49 File Offset: 0x003A2D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005475 RID: 21621
		// (get) Token: 0x060190A9 RID: 102569 RVA: 0x003A4B4C File Offset: 0x003A2D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SneakNotify.Descriptor;
			}
		}

		// Token: 0x060190AA RID: 102570 RVA: 0x003A4B53 File Offset: 0x003A2D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakNotify()
		{
		}

		// Token: 0x060190AB RID: 102571 RVA: 0x003A4B5C File Offset: 0x003A2D5C
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

		// Token: 0x060190AC RID: 102572 RVA: 0x003A4BB0 File Offset: 0x003A2DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakNotify Clone()
		{
			return new SneakNotify(this);
		}

		// Token: 0x17005476 RID: 21622
		// (get) Token: 0x060190AD RID: 102573 RVA: 0x003A4BB8 File Offset: 0x003A2DB8
		// (set) Token: 0x060190AE RID: 102574 RVA: 0x003A4BC0 File Offset: 0x003A2DC0
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

		// Token: 0x17005477 RID: 21623
		// (get) Token: 0x060190AF RID: 102575 RVA: 0x003A4BC9 File Offset: 0x003A2DC9
		// (set) Token: 0x060190B0 RID: 102576 RVA: 0x003A4BD1 File Offset: 0x003A2DD1
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

		// Token: 0x17005478 RID: 21624
		// (get) Token: 0x060190B1 RID: 102577 RVA: 0x003A4BDA File Offset: 0x003A2DDA
		// (set) Token: 0x060190B2 RID: 102578 RVA: 0x003A4BE2 File Offset: 0x003A2DE2
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

		// Token: 0x17005479 RID: 21625
		// (get) Token: 0x060190B3 RID: 102579 RVA: 0x003A4BEB File Offset: 0x003A2DEB
		// (set) Token: 0x060190B4 RID: 102580 RVA: 0x003A4BF3 File Offset: 0x003A2DF3
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

		// Token: 0x060190B5 RID: 102581 RVA: 0x003A4BFC File Offset: 0x003A2DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SneakNotify);
		}

		// Token: 0x060190B6 RID: 102582 RVA: 0x003A4C0C File Offset: 0x003A2E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SneakNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060190B7 RID: 102583 RVA: 0x003A4C78 File Offset: 0x003A2E78
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

		// Token: 0x060190B8 RID: 102584 RVA: 0x003A4D02 File Offset: 0x003A2F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060190B9 RID: 102585 RVA: 0x003A4D0F File Offset: 0x003A2F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060190BA RID: 102586 RVA: 0x003A4D18 File Offset: 0x003A2F18
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
				output.WriteRawTag(16);
				output.WriteInt32(this.NodeId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060190BB RID: 102587 RVA: 0x003A4DA8 File Offset: 0x003A2FA8
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

		// Token: 0x060190BC RID: 102588 RVA: 0x003A4E30 File Offset: 0x003A3030
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

		// Token: 0x060190BD RID: 102589 RVA: 0x003A4EA8 File Offset: 0x003A30A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060190BE RID: 102590 RVA: 0x003A4EB4 File Offset: 0x003A30B4
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
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009389 RID: 37769
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400938A RID: 37770
		public const int TreeOwnerIdFieldNumber = 1;

		// Token: 0x0400938B RID: 37771
		private int treeOwnerId_;

		// Token: 0x0400938C RID: 37772
		public const int TreeIncIdFieldNumber = 13;

		// Token: 0x0400938D RID: 37773
		private long treeIncId_;

		// Token: 0x0400938E RID: 37774
		public const int NodeIdFieldNumber = 2;

		// Token: 0x0400938F RID: 37775
		private int nodeId_;

		// Token: 0x04009390 RID: 37776
		public const int EndTimeFieldNumber = 14;

		// Token: 0x04009391 RID: 37777
		private long endTime_;
	}
}
