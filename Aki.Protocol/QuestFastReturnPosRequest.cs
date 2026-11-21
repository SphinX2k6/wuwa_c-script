using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DFE RID: 3582
	[NetMessage(EMessageId.QuestFastReturnPosRequest)]
	public sealed class QuestFastReturnPosRequest : IMessage<QuestFastReturnPosRequest>, IMessage, IEquatable<QuestFastReturnPosRequest>, IDeepCloneable<QuestFastReturnPosRequest>, IBufferMessage
	{
		// Token: 0x0601347C RID: 78972 RVA: 0x002CEEA4 File Offset: 0x002CD0A4
		[NullableContext(1)]
		public static QuestFastReturnPosRequest Create()
		{
			return new QuestFastReturnPosRequest();
		}

		// Token: 0x17003FF7 RID: 16375
		// (get) Token: 0x0601347D RID: 78973 RVA: 0x002CEEAB File Offset: 0x002CD0AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FF8 RID: 16376
		// (get) Token: 0x0601347E RID: 78974 RVA: 0x002CEEAE File Offset: 0x002CD0AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestFastReturnPosRequest.Descriptor;
			}
		}

		// Token: 0x0601347F RID: 78975 RVA: 0x002CEEB5 File Offset: 0x002CD0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFastReturnPosRequest()
		{
		}

		// Token: 0x06013480 RID: 78976 RVA: 0x002CEEBD File Offset: 0x002CD0BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFastReturnPosRequest(QuestFastReturnPosRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013481 RID: 78977 RVA: 0x002CEEFA File Offset: 0x002CD0FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFastReturnPosRequest Clone()
		{
			return new QuestFastReturnPosRequest(this);
		}

		// Token: 0x17003FF9 RID: 16377
		// (get) Token: 0x06013482 RID: 78978 RVA: 0x002CEF02 File Offset: 0x002CD102
		// (set) Token: 0x06013483 RID: 78979 RVA: 0x002CEF0A File Offset: 0x002CD10A
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

		// Token: 0x17003FFA RID: 16378
		// (get) Token: 0x06013484 RID: 78980 RVA: 0x002CEF13 File Offset: 0x002CD113
		// (set) Token: 0x06013485 RID: 78981 RVA: 0x002CEF1B File Offset: 0x002CD11B
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

		// Token: 0x17003FFB RID: 16379
		// (get) Token: 0x06013486 RID: 78982 RVA: 0x002CEF24 File Offset: 0x002CD124
		// (set) Token: 0x06013487 RID: 78983 RVA: 0x002CEF2C File Offset: 0x002CD12C
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

		// Token: 0x06013488 RID: 78984 RVA: 0x002CEF35 File Offset: 0x002CD135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestFastReturnPosRequest);
		}

		// Token: 0x06013489 RID: 78985 RVA: 0x002CEF44 File Offset: 0x002CD144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestFastReturnPosRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601348A RID: 78986 RVA: 0x002CEFA0 File Offset: 0x002CD1A0
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

		// Token: 0x0601348B RID: 78987 RVA: 0x002CF011 File Offset: 0x002CD211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601348C RID: 78988 RVA: 0x002CF01E File Offset: 0x002CD21E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601348D RID: 78989 RVA: 0x002CF028 File Offset: 0x002CD228
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
				output.WriteRawTag(48);
				output.WriteInt32(this.NodeId);
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

		// Token: 0x0601348E RID: 78990 RVA: 0x002CF0A0 File Offset: 0x002CD2A0
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

		// Token: 0x0601348F RID: 78991 RVA: 0x002CF110 File Offset: 0x002CD310
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

		// Token: 0x06013490 RID: 78992 RVA: 0x002CF174 File Offset: 0x002CD374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013491 RID: 78993 RVA: 0x002CF180 File Offset: 0x002CD380
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
				if (num != 40U)
				{
					if (num != 48U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TreeIncId = input.ReadInt64();
						}
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
		}

		// Token: 0x040076ED RID: 30445
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076EE RID: 30446
		public const int TreeOwnerIdFieldNumber = 5;

		// Token: 0x040076EF RID: 30447
		private int treeOwnerId_;

		// Token: 0x040076F0 RID: 30448
		public const int TreeIncIdFieldNumber = 14;

		// Token: 0x040076F1 RID: 30449
		private long treeIncId_;

		// Token: 0x040076F2 RID: 30450
		public const int NodeIdFieldNumber = 6;

		// Token: 0x040076F3 RID: 30451
		private int nodeId_;
	}
}
