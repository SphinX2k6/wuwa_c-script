using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC7 RID: 3783
	[NetMessage(EMessageId.RecallQuestRollBackEndNotify)]
	public sealed class RecallQuestRollBackEndNotify : IMessage<RecallQuestRollBackEndNotify>, IMessage, IEquatable<RecallQuestRollBackEndNotify>, IDeepCloneable<RecallQuestRollBackEndNotify>, IBufferMessage
	{
		// Token: 0x0601448B RID: 83083 RVA: 0x002F2C41 File Offset: 0x002F0E41
		[NullableContext(1)]
		public static RecallQuestRollBackEndNotify Create()
		{
			return new RecallQuestRollBackEndNotify();
		}

		// Token: 0x1700436E RID: 17262
		// (get) Token: 0x0601448C RID: 83084 RVA: 0x002F2C48 File Offset: 0x002F0E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700436F RID: 17263
		// (get) Token: 0x0601448D RID: 83085 RVA: 0x002F2C4B File Offset: 0x002F0E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestRollBackEndNotify.Descriptor;
			}
		}

		// Token: 0x0601448E RID: 83086 RVA: 0x002F2C52 File Offset: 0x002F0E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestRollBackEndNotify()
		{
		}

		// Token: 0x0601448F RID: 83087 RVA: 0x002F2C5A File Offset: 0x002F0E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestRollBackEndNotify(RecallQuestRollBackEndNotify other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this.treeIncId_ = other.treeIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014490 RID: 83088 RVA: 0x002F2C8B File Offset: 0x002F0E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestRollBackEndNotify Clone()
		{
			return new RecallQuestRollBackEndNotify(this);
		}

		// Token: 0x17004370 RID: 17264
		// (get) Token: 0x06014491 RID: 83089 RVA: 0x002F2C93 File Offset: 0x002F0E93
		// (set) Token: 0x06014492 RID: 83090 RVA: 0x002F2C9B File Offset: 0x002F0E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallQuestId
		{
			get
			{
				return this.recallQuestId_;
			}
			set
			{
				this.recallQuestId_ = value;
			}
		}

		// Token: 0x17004371 RID: 17265
		// (get) Token: 0x06014493 RID: 83091 RVA: 0x002F2CA4 File Offset: 0x002F0EA4
		// (set) Token: 0x06014494 RID: 83092 RVA: 0x002F2CAC File Offset: 0x002F0EAC
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

		// Token: 0x06014495 RID: 83093 RVA: 0x002F2CB5 File Offset: 0x002F0EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestRollBackEndNotify);
		}

		// Token: 0x06014496 RID: 83094 RVA: 0x002F2CC3 File Offset: 0x002F0EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestRollBackEndNotify other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && this.TreeIncId == other.TreeIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014497 RID: 83095 RVA: 0x002F2D04 File Offset: 0x002F0F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallQuestId != 0)
			{
				num ^= this.RecallQuestId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014498 RID: 83096 RVA: 0x002F2D5C File Offset: 0x002F0F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014499 RID: 83097 RVA: 0x002F2D69 File Offset: 0x002F0F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601449A RID: 83098 RVA: 0x002F2D74 File Offset: 0x002F0F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601449B RID: 83099 RVA: 0x002F2DD0 File Offset: 0x002F0FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallQuestId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601449C RID: 83100 RVA: 0x002F2E28 File Offset: 0x002F1028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestRollBackEndNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallQuestId != 0)
			{
				this.RecallQuestId = other.RecallQuestId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601449D RID: 83101 RVA: 0x002F2E78 File Offset: 0x002F1078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601449E RID: 83102 RVA: 0x002F2E84 File Offset: 0x002F1084
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TreeIncId = input.ReadInt64();
					}
				}
				else
				{
					this.RecallQuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007B42 RID: 31554
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B43 RID: 31555
		public const int RecallQuestIdFieldNumber = 5;

		// Token: 0x04007B44 RID: 31556
		private int recallQuestId_;

		// Token: 0x04007B45 RID: 31557
		public const int TreeIncIdFieldNumber = 6;

		// Token: 0x04007B46 RID: 31558
		private long treeIncId_;
	}
}
