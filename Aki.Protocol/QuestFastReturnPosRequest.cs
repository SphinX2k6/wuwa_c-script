using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E0E RID: 3598
	[NetMessage(EMessageId.QuestFastReturnPosRequest)]
	public sealed class QuestFastReturnPosRequest : IMessage<QuestFastReturnPosRequest>, IMessage, IEquatable<QuestFastReturnPosRequest>, IDeepCloneable<QuestFastReturnPosRequest>, IBufferMessage
	{
		// Token: 0x06013561 RID: 79201 RVA: 0x002D0560 File Offset: 0x002CE760
		[NullableContext(1)]
		public static QuestFastReturnPosRequest Create()
		{
			return new QuestFastReturnPosRequest();
		}

		// Token: 0x17004021 RID: 16417
		// (get) Token: 0x06013562 RID: 79202 RVA: 0x002D0567 File Offset: 0x002CE767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004022 RID: 16418
		// (get) Token: 0x06013563 RID: 79203 RVA: 0x002D056A File Offset: 0x002CE76A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestFastReturnPosRequest.Descriptor;
			}
		}

		// Token: 0x06013564 RID: 79204 RVA: 0x002D0571 File Offset: 0x002CE771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFastReturnPosRequest()
		{
		}

		// Token: 0x06013565 RID: 79205 RVA: 0x002D0579 File Offset: 0x002CE779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFastReturnPosRequest(QuestFastReturnPosRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013566 RID: 79206 RVA: 0x002D05B6 File Offset: 0x002CE7B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFastReturnPosRequest Clone()
		{
			return new QuestFastReturnPosRequest(this);
		}

		// Token: 0x17004023 RID: 16419
		// (get) Token: 0x06013567 RID: 79207 RVA: 0x002D05BE File Offset: 0x002CE7BE
		// (set) Token: 0x06013568 RID: 79208 RVA: 0x002D05C6 File Offset: 0x002CE7C6
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

		// Token: 0x17004024 RID: 16420
		// (get) Token: 0x06013569 RID: 79209 RVA: 0x002D05CF File Offset: 0x002CE7CF
		// (set) Token: 0x0601356A RID: 79210 RVA: 0x002D05D7 File Offset: 0x002CE7D7
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

		// Token: 0x17004025 RID: 16421
		// (get) Token: 0x0601356B RID: 79211 RVA: 0x002D05E0 File Offset: 0x002CE7E0
		// (set) Token: 0x0601356C RID: 79212 RVA: 0x002D05E8 File Offset: 0x002CE7E8
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

		// Token: 0x0601356D RID: 79213 RVA: 0x002D05F1 File Offset: 0x002CE7F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestFastReturnPosRequest);
		}

		// Token: 0x0601356E RID: 79214 RVA: 0x002D0600 File Offset: 0x002CE800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestFastReturnPosRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601356F RID: 79215 RVA: 0x002D065C File Offset: 0x002CE85C
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

		// Token: 0x06013570 RID: 79216 RVA: 0x002D06CD File Offset: 0x002CE8CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013571 RID: 79217 RVA: 0x002D06DA File Offset: 0x002CE8DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013572 RID: 79218 RVA: 0x002D06E4 File Offset: 0x002CE8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.NodeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013573 RID: 79219 RVA: 0x002D075C File Offset: 0x002CE95C
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

		// Token: 0x06013574 RID: 79220 RVA: 0x002D07CC File Offset: 0x002CE9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestFastReturnPosRequest other)
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

		// Token: 0x06013575 RID: 79221 RVA: 0x002D0830 File Offset: 0x002CEA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013576 RID: 79222 RVA: 0x002D083C File Offset: 0x002CEA3C
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
				if (num != 56U)
				{
					if (num != 72U)
					{
						if (num != 120U)
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

		// Token: 0x040076C3 RID: 30403
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076C4 RID: 30404
		public const int TreeOwnerIdFieldNumber = 9;

		// Token: 0x040076C5 RID: 30405
		private int treeOwnerId_;

		// Token: 0x040076C6 RID: 30406
		public const int TreeIncIdFieldNumber = 7;

		// Token: 0x040076C7 RID: 30407
		private long treeIncId_;

		// Token: 0x040076C8 RID: 30408
		public const int NodeIdFieldNumber = 15;

		// Token: 0x040076C9 RID: 30409
		private int nodeId_;
	}
}
