using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E03 RID: 3587
	[NetMessage(EMessageId.QuestFinishActionRequest)]
	public sealed class QuestFinishActionRequest : IMessage<QuestFinishActionRequest>, IMessage, IEquatable<QuestFinishActionRequest>, IDeepCloneable<QuestFinishActionRequest>, IBufferMessage
	{
		// Token: 0x060134DA RID: 79066 RVA: 0x002CF961 File Offset: 0x002CDB61
		[NullableContext(1)]
		public static QuestFinishActionRequest Create()
		{
			return new QuestFinishActionRequest();
		}

		// Token: 0x17004008 RID: 16392
		// (get) Token: 0x060134DB RID: 79067 RVA: 0x002CF968 File Offset: 0x002CDB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004009 RID: 16393
		// (get) Token: 0x060134DC RID: 79068 RVA: 0x002CF96B File Offset: 0x002CDB6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestFinishActionRequest.Descriptor;
			}
		}

		// Token: 0x060134DD RID: 79069 RVA: 0x002CF972 File Offset: 0x002CDB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionRequest()
		{
		}

		// Token: 0x060134DE RID: 79070 RVA: 0x002CF97C File Offset: 0x002CDB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionRequest(QuestFinishActionRequest other) : this()
		{
			this.questId_ = other.questId_;
			this.nodeId_ = other.nodeId_;
			this.actionId_ = other.actionId_;
			this.actTime_ = other.actTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060134DF RID: 79071 RVA: 0x002CF9D0 File Offset: 0x002CDBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionRequest Clone()
		{
			return new QuestFinishActionRequest(this);
		}

		// Token: 0x1700400A RID: 16394
		// (get) Token: 0x060134E0 RID: 79072 RVA: 0x002CF9D8 File Offset: 0x002CDBD8
		// (set) Token: 0x060134E1 RID: 79073 RVA: 0x002CF9E0 File Offset: 0x002CDBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x1700400B RID: 16395
		// (get) Token: 0x060134E2 RID: 79074 RVA: 0x002CF9E9 File Offset: 0x002CDBE9
		// (set) Token: 0x060134E3 RID: 79075 RVA: 0x002CF9F1 File Offset: 0x002CDBF1
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

		// Token: 0x1700400C RID: 16396
		// (get) Token: 0x060134E4 RID: 79076 RVA: 0x002CF9FA File Offset: 0x002CDBFA
		// (set) Token: 0x060134E5 RID: 79077 RVA: 0x002CFA02 File Offset: 0x002CDC02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionId
		{
			get
			{
				return this.actionId_;
			}
			set
			{
				this.actionId_ = value;
			}
		}

		// Token: 0x1700400D RID: 16397
		// (get) Token: 0x060134E6 RID: 79078 RVA: 0x002CFA0B File Offset: 0x002CDC0B
		// (set) Token: 0x060134E7 RID: 79079 RVA: 0x002CFA13 File Offset: 0x002CDC13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionTime ActTime
		{
			get
			{
				return this.actTime_;
			}
			set
			{
				this.actTime_ = value;
			}
		}

		// Token: 0x060134E8 RID: 79080 RVA: 0x002CFA1C File Offset: 0x002CDC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestFinishActionRequest);
		}

		// Token: 0x060134E9 RID: 79081 RVA: 0x002CFA2C File Offset: 0x002CDC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestFinishActionRequest other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.NodeId == other.NodeId && this.ActionId == other.ActionId && this.ActTime == other.ActTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060134EA RID: 79082 RVA: 0x002CFA98 File Offset: 0x002CDC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.NodeId != 0)
			{
				num ^= this.NodeId.GetHashCode();
			}
			if (this.ActionId != 0)
			{
				num ^= this.ActionId.GetHashCode();
			}
			if (this.ActTime != ActionTime.Enter)
			{
				num ^= this.ActTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060134EB RID: 79083 RVA: 0x002CFB28 File Offset: 0x002CDD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060134EC RID: 79084 RVA: 0x002CFB35 File Offset: 0x002CDD35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060134ED RID: 79085 RVA: 0x002CFB40 File Offset: 0x002CDD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NodeId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.NodeId);
			}
			if (this.ActTime != ActionTime.Enter)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ActTime);
			}
			if (this.ActionId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActionId);
			}
			if (this.QuestId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060134EE RID: 79086 RVA: 0x002CFBD4 File Offset: 0x002CDDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this.NodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NodeId);
			}
			if (this.ActionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionId);
			}
			if (this.ActTime != ActionTime.Enter)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ActTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060134EF RID: 79087 RVA: 0x002CFC5C File Offset: 0x002CDE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestFinishActionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.NodeId != 0)
			{
				this.NodeId = other.NodeId;
			}
			if (other.ActionId != 0)
			{
				this.ActionId = other.ActionId;
			}
			if (other.ActTime != ActionTime.Enter)
			{
				this.ActTime = other.ActTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060134F0 RID: 79088 RVA: 0x002CFCD4 File Offset: 0x002CDED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060134F1 RID: 79089 RVA: 0x002CFCE0 File Offset: 0x002CDEE0
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
				if (num <= 64U)
				{
					if (num == 56U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.ActTime = (ActionTime)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.ActionId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.QuestId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007701 RID: 30465
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007702 RID: 30466
		public const int QuestIdFieldNumber = 14;

		// Token: 0x04007703 RID: 30467
		private int questId_;

		// Token: 0x04007704 RID: 30468
		public const int NodeIdFieldNumber = 7;

		// Token: 0x04007705 RID: 30469
		private int nodeId_;

		// Token: 0x04007706 RID: 30470
		public const int ActionIdFieldNumber = 13;

		// Token: 0x04007707 RID: 30471
		private int actionId_;

		// Token: 0x04007708 RID: 30472
		public const int ActTimeFieldNumber = 8;

		// Token: 0x04007709 RID: 30473
		private ActionTime actTime_;
	}
}
