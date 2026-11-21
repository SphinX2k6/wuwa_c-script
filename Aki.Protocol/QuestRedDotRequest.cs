using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E15 RID: 3605
	[NetMessage(EMessageId.QuestRedDotRequest)]
	public sealed class QuestRedDotRequest : IMessage<QuestRedDotRequest>, IMessage, IEquatable<QuestRedDotRequest>, IDeepCloneable<QuestRedDotRequest>, IBufferMessage
	{
		// Token: 0x0601363A RID: 79418 RVA: 0x002D2349 File Offset: 0x002D0549
		[NullableContext(1)]
		public static QuestRedDotRequest Create()
		{
			return new QuestRedDotRequest();
		}

		// Token: 0x1700404C RID: 16460
		// (get) Token: 0x0601363B RID: 79419 RVA: 0x002D2350 File Offset: 0x002D0550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700404D RID: 16461
		// (get) Token: 0x0601363C RID: 79420 RVA: 0x002D2353 File Offset: 0x002D0553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestRedDotRequest.Descriptor;
			}
		}

		// Token: 0x0601363D RID: 79421 RVA: 0x002D235A File Offset: 0x002D055A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRedDotRequest()
		{
		}

		// Token: 0x0601363E RID: 79422 RVA: 0x002D2362 File Offset: 0x002D0562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRedDotRequest(QuestRedDotRequest other) : this()
		{
			this.questId_ = other.questId_;
			this.operate_ = other.operate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601363F RID: 79423 RVA: 0x002D2393 File Offset: 0x002D0593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRedDotRequest Clone()
		{
			return new QuestRedDotRequest(this);
		}

		// Token: 0x1700404E RID: 16462
		// (get) Token: 0x06013640 RID: 79424 RVA: 0x002D239B File Offset: 0x002D059B
		// (set) Token: 0x06013641 RID: 79425 RVA: 0x002D23A3 File Offset: 0x002D05A3
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

		// Token: 0x1700404F RID: 16463
		// (get) Token: 0x06013642 RID: 79426 RVA: 0x002D23AC File Offset: 0x002D05AC
		// (set) Token: 0x06013643 RID: 79427 RVA: 0x002D23B4 File Offset: 0x002D05B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Operate
		{
			get
			{
				return this.operate_;
			}
			set
			{
				this.operate_ = value;
			}
		}

		// Token: 0x06013644 RID: 79428 RVA: 0x002D23BD File Offset: 0x002D05BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestRedDotRequest);
		}

		// Token: 0x06013645 RID: 79429 RVA: 0x002D23CB File Offset: 0x002D05CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestRedDotRequest other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.Operate == other.Operate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013646 RID: 79430 RVA: 0x002D240C File Offset: 0x002D060C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.Operate != 0)
			{
				num ^= this.Operate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013647 RID: 79431 RVA: 0x002D2464 File Offset: 0x002D0664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013648 RID: 79432 RVA: 0x002D2471 File Offset: 0x002D0671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013649 RID: 79433 RVA: 0x002D247C File Offset: 0x002D067C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Operate != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Operate);
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

		// Token: 0x0601364A RID: 79434 RVA: 0x002D24D8 File Offset: 0x002D06D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this.Operate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Operate);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601364B RID: 79435 RVA: 0x002D2530 File Offset: 0x002D0730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestRedDotRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.Operate != 0)
			{
				this.Operate = other.Operate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601364C RID: 79436 RVA: 0x002D2580 File Offset: 0x002D0780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601364D RID: 79437 RVA: 0x002D258C File Offset: 0x002D078C
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
				if (num != 88U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.QuestId = input.ReadInt32();
					}
				}
				else
				{
					this.Operate = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007756 RID: 30550
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007757 RID: 30551
		public const int QuestIdFieldNumber = 14;

		// Token: 0x04007758 RID: 30552
		private int questId_;

		// Token: 0x04007759 RID: 30553
		public const int OperateFieldNumber = 11;

		// Token: 0x0400775A RID: 30554
		private int operate_;
	}
}
