using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E13 RID: 3603
	[NetMessage(EMessageId.QuestFinishActionRequest)]
	public sealed class QuestFinishActionRequest : IMessage<QuestFinishActionRequest>, IMessage, IEquatable<QuestFinishActionRequest>, IDeepCloneable<QuestFinishActionRequest>, IBufferMessage
	{
		// Token: 0x060135BF RID: 79295 RVA: 0x002D1021 File Offset: 0x002CF221
		[NullableContext(1)]
		public static QuestFinishActionRequest Create()
		{
			return new QuestFinishActionRequest();
		}

		// Token: 0x17004032 RID: 16434
		// (get) Token: 0x060135C0 RID: 79296 RVA: 0x002D1028 File Offset: 0x002CF228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004033 RID: 16435
		// (get) Token: 0x060135C1 RID: 79297 RVA: 0x002D102B File Offset: 0x002CF22B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestFinishActionRequest.Descriptor;
			}
		}

		// Token: 0x060135C2 RID: 79298 RVA: 0x002D1032 File Offset: 0x002CF232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionRequest()
		{
		}

		// Token: 0x060135C3 RID: 79299 RVA: 0x002D103C File Offset: 0x002CF23C
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

		// Token: 0x060135C4 RID: 79300 RVA: 0x002D1090 File Offset: 0x002CF290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionRequest Clone()
		{
			return new QuestFinishActionRequest(this);
		}

		// Token: 0x17004034 RID: 16436
		// (get) Token: 0x060135C5 RID: 79301 RVA: 0x002D1098 File Offset: 0x002CF298
		// (set) Token: 0x060135C6 RID: 79302 RVA: 0x002D10A0 File Offset: 0x002CF2A0
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

		// Token: 0x17004035 RID: 16437
		// (get) Token: 0x060135C7 RID: 79303 RVA: 0x002D10A9 File Offset: 0x002CF2A9
		// (set) Token: 0x060135C8 RID: 79304 RVA: 0x002D10B1 File Offset: 0x002CF2B1
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

		// Token: 0x17004036 RID: 16438
		// (get) Token: 0x060135C9 RID: 79305 RVA: 0x002D10BA File Offset: 0x002CF2BA
		// (set) Token: 0x060135CA RID: 79306 RVA: 0x002D10C2 File Offset: 0x002CF2C2
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

		// Token: 0x17004037 RID: 16439
		// (get) Token: 0x060135CB RID: 79307 RVA: 0x002D10CB File Offset: 0x002CF2CB
		// (set) Token: 0x060135CC RID: 79308 RVA: 0x002D10D3 File Offset: 0x002CF2D3
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

		// Token: 0x060135CD RID: 79309 RVA: 0x002D10DC File Offset: 0x002CF2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestFinishActionRequest);
		}

		// Token: 0x060135CE RID: 79310 RVA: 0x002D10EC File Offset: 0x002CF2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestFinishActionRequest other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.NodeId == other.NodeId && this.ActionId == other.ActionId && this.ActTime == other.ActTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060135CF RID: 79311 RVA: 0x002D1158 File Offset: 0x002CF358
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

		// Token: 0x060135D0 RID: 79312 RVA: 0x002D11E8 File Offset: 0x002CF3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060135D1 RID: 79313 RVA: 0x002D11F5 File Offset: 0x002CF3F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060135D2 RID: 79314 RVA: 0x002D1200 File Offset: 0x002CF400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.QuestId);
			}
			if (this.ActTime != ActionTime.Enter)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ActTime);
			}
			if (this.ActionId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActionId);
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

		// Token: 0x060135D3 RID: 79315 RVA: 0x002D1294 File Offset: 0x002CF494
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

		// Token: 0x060135D4 RID: 79316 RVA: 0x002D131C File Offset: 0x002CF51C
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

		// Token: 0x060135D5 RID: 79317 RVA: 0x002D1394 File Offset: 0x002CF594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060135D6 RID: 79318 RVA: 0x002D13A0 File Offset: 0x002CF5A0
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
				if (num <= 80U)
				{
					if (num == 24U)
					{
						this.QuestId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.ActTime = (ActionTime)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.ActionId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040076D7 RID: 30423
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076D8 RID: 30424
		public const int QuestIdFieldNumber = 3;

		// Token: 0x040076D9 RID: 30425
		private int questId_;

		// Token: 0x040076DA RID: 30426
		public const int NodeIdFieldNumber = 14;

		// Token: 0x040076DB RID: 30427
		private int nodeId_;

		// Token: 0x040076DC RID: 30428
		public const int ActionIdFieldNumber = 11;

		// Token: 0x040076DD RID: 30429
		private int actionId_;

		// Token: 0x040076DE RID: 30430
		public const int ActTimeFieldNumber = 10;

		// Token: 0x040076DF RID: 30431
		private ActionTime actTime_;
	}
}
