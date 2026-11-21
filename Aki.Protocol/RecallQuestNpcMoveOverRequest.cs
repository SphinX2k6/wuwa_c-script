using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB3 RID: 3763
	[NetMessage(EMessageId.RecallQuestNpcMoveOverRequest)]
	public sealed class RecallQuestNpcMoveOverRequest : IMessage<RecallQuestNpcMoveOverRequest>, IMessage, IEquatable<RecallQuestNpcMoveOverRequest>, IDeepCloneable<RecallQuestNpcMoveOverRequest>, IBufferMessage
	{
		// Token: 0x0601435E RID: 82782 RVA: 0x002F0E21 File Offset: 0x002EF021
		[NullableContext(1)]
		public static RecallQuestNpcMoveOverRequest Create()
		{
			return new RecallQuestNpcMoveOverRequest();
		}

		// Token: 0x17004338 RID: 17208
		// (get) Token: 0x0601435F RID: 82783 RVA: 0x002F0E28 File Offset: 0x002EF028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004339 RID: 17209
		// (get) Token: 0x06014360 RID: 82784 RVA: 0x002F0E2B File Offset: 0x002EF02B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestNpcMoveOverRequest.Descriptor;
			}
		}

		// Token: 0x06014361 RID: 82785 RVA: 0x002F0E32 File Offset: 0x002EF032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestNpcMoveOverRequest()
		{
		}

		// Token: 0x06014362 RID: 82786 RVA: 0x002F0E3A File Offset: 0x002EF03A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestNpcMoveOverRequest(RecallQuestNpcMoveOverRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014363 RID: 82787 RVA: 0x002F0E5F File Offset: 0x002EF05F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestNpcMoveOverRequest Clone()
		{
			return new RecallQuestNpcMoveOverRequest(this);
		}

		// Token: 0x1700433A RID: 17210
		// (get) Token: 0x06014364 RID: 82788 RVA: 0x002F0E67 File Offset: 0x002EF067
		// (set) Token: 0x06014365 RID: 82789 RVA: 0x002F0E6F File Offset: 0x002EF06F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x06014366 RID: 82790 RVA: 0x002F0E78 File Offset: 0x002EF078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestNpcMoveOverRequest);
		}

		// Token: 0x06014367 RID: 82791 RVA: 0x002F0E86 File Offset: 0x002EF086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestNpcMoveOverRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014368 RID: 82792 RVA: 0x002F0EB4 File Offset: 0x002EF0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014369 RID: 82793 RVA: 0x002F0EF3 File Offset: 0x002EF0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601436A RID: 82794 RVA: 0x002F0F00 File Offset: 0x002EF100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601436B RID: 82795 RVA: 0x002F0F09 File Offset: 0x002EF109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601436C RID: 82796 RVA: 0x002F0F3C File Offset: 0x002EF13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601436D RID: 82797 RVA: 0x002F0F7A File Offset: 0x002EF17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestNpcMoveOverRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601436E RID: 82798 RVA: 0x002F0FAB File Offset: 0x002EF1AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601436F RID: 82799 RVA: 0x002F0FB4 File Offset: 0x002EF1B4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007B60 RID: 31584
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B61 RID: 31585
		public const int EntityIdFieldNumber = 11;

		// Token: 0x04007B62 RID: 31586
		private long entityId_;
	}
}
