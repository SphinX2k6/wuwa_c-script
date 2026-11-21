using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB7 RID: 3767
	[NetMessage(EMessageId.RecallQuestRollBackEndNotify)]
	public sealed class RecallQuestRollBackEndNotify : IMessage<RecallQuestRollBackEndNotify>, IMessage, IEquatable<RecallQuestRollBackEndNotify>, IDeepCloneable<RecallQuestRollBackEndNotify>, IBufferMessage
	{
		// Token: 0x060143A6 RID: 82854 RVA: 0x002F158D File Offset: 0x002EF78D
		[NullableContext(1)]
		public static RecallQuestRollBackEndNotify Create()
		{
			return new RecallQuestRollBackEndNotify();
		}

		// Token: 0x17004344 RID: 17220
		// (get) Token: 0x060143A7 RID: 82855 RVA: 0x002F1594 File Offset: 0x002EF794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004345 RID: 17221
		// (get) Token: 0x060143A8 RID: 82856 RVA: 0x002F1597 File Offset: 0x002EF797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestRollBackEndNotify.Descriptor;
			}
		}

		// Token: 0x060143A9 RID: 82857 RVA: 0x002F159E File Offset: 0x002EF79E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestRollBackEndNotify()
		{
		}

		// Token: 0x060143AA RID: 82858 RVA: 0x002F15A6 File Offset: 0x002EF7A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestRollBackEndNotify(RecallQuestRollBackEndNotify other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this.treeIncId_ = other.treeIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060143AB RID: 82859 RVA: 0x002F15D7 File Offset: 0x002EF7D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestRollBackEndNotify Clone()
		{
			return new RecallQuestRollBackEndNotify(this);
		}

		// Token: 0x17004346 RID: 17222
		// (get) Token: 0x060143AC RID: 82860 RVA: 0x002F15DF File Offset: 0x002EF7DF
		// (set) Token: 0x060143AD RID: 82861 RVA: 0x002F15E7 File Offset: 0x002EF7E7
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

		// Token: 0x17004347 RID: 17223
		// (get) Token: 0x060143AE RID: 82862 RVA: 0x002F15F0 File Offset: 0x002EF7F0
		// (set) Token: 0x060143AF RID: 82863 RVA: 0x002F15F8 File Offset: 0x002EF7F8
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

		// Token: 0x060143B0 RID: 82864 RVA: 0x002F1601 File Offset: 0x002EF801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestRollBackEndNotify);
		}

		// Token: 0x060143B1 RID: 82865 RVA: 0x002F160F File Offset: 0x002EF80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestRollBackEndNotify other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && this.TreeIncId == other.TreeIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060143B2 RID: 82866 RVA: 0x002F1650 File Offset: 0x002EF850
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

		// Token: 0x060143B3 RID: 82867 RVA: 0x002F16A8 File Offset: 0x002EF8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060143B4 RID: 82868 RVA: 0x002F16B5 File Offset: 0x002EF8B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060143B5 RID: 82869 RVA: 0x002F16C0 File Offset: 0x002EF8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RecallQuestId);
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

		// Token: 0x060143B6 RID: 82870 RVA: 0x002F171C File Offset: 0x002EF91C
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

		// Token: 0x060143B7 RID: 82871 RVA: 0x002F1774 File Offset: 0x002EF974
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

		// Token: 0x060143B8 RID: 82872 RVA: 0x002F17C4 File Offset: 0x002EF9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060143B9 RID: 82873 RVA: 0x002F17D0 File Offset: 0x002EF9D0
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
				if (num != 104U)
				{
					if (num != 120U)
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

		// Token: 0x04007B6C RID: 31596
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B6D RID: 31597
		public const int RecallQuestIdFieldNumber = 13;

		// Token: 0x04007B6E RID: 31598
		private int recallQuestId_;

		// Token: 0x04007B6F RID: 31599
		public const int TreeIncIdFieldNumber = 15;

		// Token: 0x04007B70 RID: 31600
		private long treeIncId_;
	}
}
