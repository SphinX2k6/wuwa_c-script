using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EBA RID: 3770
	public sealed class RecallQuestFinishActionCtxPb : IMessage<RecallQuestFinishActionCtxPb>, IMessage, IEquatable<RecallQuestFinishActionCtxPb>, IDeepCloneable<RecallQuestFinishActionCtxPb>, IBufferMessage
	{
		// Token: 0x06014393 RID: 82835 RVA: 0x002F0F74 File Offset: 0x002EF174
		[NullableContext(1)]
		public static RecallQuestFinishActionCtxPb Create()
		{
			return new RecallQuestFinishActionCtxPb();
		}

		// Token: 0x17004340 RID: 17216
		// (get) Token: 0x06014394 RID: 82836 RVA: 0x002F0F7B File Offset: 0x002EF17B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004341 RID: 17217
		// (get) Token: 0x06014395 RID: 82837 RVA: 0x002F0F7E File Offset: 0x002EF17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestFinishActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06014396 RID: 82838 RVA: 0x002F0F85 File Offset: 0x002EF185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionCtxPb()
		{
		}

		// Token: 0x06014397 RID: 82839 RVA: 0x002F0F8D File Offset: 0x002EF18D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionCtxPb(RecallQuestFinishActionCtxPb other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014398 RID: 82840 RVA: 0x002F0FB2 File Offset: 0x002EF1B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionCtxPb Clone()
		{
			return new RecallQuestFinishActionCtxPb(this);
		}

		// Token: 0x17004342 RID: 17218
		// (get) Token: 0x06014399 RID: 82841 RVA: 0x002F0FBA File Offset: 0x002EF1BA
		// (set) Token: 0x0601439A RID: 82842 RVA: 0x002F0FC2 File Offset: 0x002EF1C2
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

		// Token: 0x0601439B RID: 82843 RVA: 0x002F0FCB File Offset: 0x002EF1CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestFinishActionCtxPb);
		}

		// Token: 0x0601439C RID: 82844 RVA: 0x002F0FD9 File Offset: 0x002EF1D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestFinishActionCtxPb other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601439D RID: 82845 RVA: 0x002F1008 File Offset: 0x002EF208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallQuestId != 0)
			{
				num ^= this.RecallQuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601439E RID: 82846 RVA: 0x002F1047 File Offset: 0x002EF247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601439F RID: 82847 RVA: 0x002F1054 File Offset: 0x002EF254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060143A0 RID: 82848 RVA: 0x002F105D File Offset: 0x002EF25D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060143A1 RID: 82849 RVA: 0x002F1090 File Offset: 0x002EF290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060143A2 RID: 82850 RVA: 0x002F10CE File Offset: 0x002EF2CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestFinishActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallQuestId != 0)
			{
				this.RecallQuestId = other.RecallQuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060143A3 RID: 82851 RVA: 0x002F10FF File Offset: 0x002EF2FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060143A4 RID: 82852 RVA: 0x002F1108 File Offset: 0x002EF308
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RecallQuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007B0A RID: 31498
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B0B RID: 31499
		public const int RecallQuestIdFieldNumber = 1;

		// Token: 0x04007B0C RID: 31500
		private int recallQuestId_;
	}
}
