using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB9 RID: 3769
	public sealed class RecallQuestDestroyActionCtxPb : IMessage<RecallQuestDestroyActionCtxPb>, IMessage, IEquatable<RecallQuestDestroyActionCtxPb>, IDeepCloneable<RecallQuestDestroyActionCtxPb>, IBufferMessage
	{
		// Token: 0x06014381 RID: 82817 RVA: 0x002F0D9C File Offset: 0x002EEF9C
		[NullableContext(1)]
		public static RecallQuestDestroyActionCtxPb Create()
		{
			return new RecallQuestDestroyActionCtxPb();
		}

		// Token: 0x1700433D RID: 17213
		// (get) Token: 0x06014382 RID: 82818 RVA: 0x002F0DA3 File Offset: 0x002EEFA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700433E RID: 17214
		// (get) Token: 0x06014383 RID: 82819 RVA: 0x002F0DA6 File Offset: 0x002EEFA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestDestroyActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06014384 RID: 82820 RVA: 0x002F0DAD File Offset: 0x002EEFAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestDestroyActionCtxPb()
		{
		}

		// Token: 0x06014385 RID: 82821 RVA: 0x002F0DB5 File Offset: 0x002EEFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestDestroyActionCtxPb(RecallQuestDestroyActionCtxPb other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014386 RID: 82822 RVA: 0x002F0DDA File Offset: 0x002EEFDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestDestroyActionCtxPb Clone()
		{
			return new RecallQuestDestroyActionCtxPb(this);
		}

		// Token: 0x1700433F RID: 17215
		// (get) Token: 0x06014387 RID: 82823 RVA: 0x002F0DE2 File Offset: 0x002EEFE2
		// (set) Token: 0x06014388 RID: 82824 RVA: 0x002F0DEA File Offset: 0x002EEFEA
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

		// Token: 0x06014389 RID: 82825 RVA: 0x002F0DF3 File Offset: 0x002EEFF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestDestroyActionCtxPb);
		}

		// Token: 0x0601438A RID: 82826 RVA: 0x002F0E01 File Offset: 0x002EF001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestDestroyActionCtxPb other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601438B RID: 82827 RVA: 0x002F0E30 File Offset: 0x002EF030
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

		// Token: 0x0601438C RID: 82828 RVA: 0x002F0E6F File Offset: 0x002EF06F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601438D RID: 82829 RVA: 0x002F0E7C File Offset: 0x002EF07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601438E RID: 82830 RVA: 0x002F0E85 File Offset: 0x002EF085
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

		// Token: 0x0601438F RID: 82831 RVA: 0x002F0EB8 File Offset: 0x002EF0B8
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

		// Token: 0x06014390 RID: 82832 RVA: 0x002F0EF6 File Offset: 0x002EF0F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestDestroyActionCtxPb other)
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

		// Token: 0x06014391 RID: 82833 RVA: 0x002F0F27 File Offset: 0x002EF127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014392 RID: 82834 RVA: 0x002F0F30 File Offset: 0x002EF130
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

		// Token: 0x04007B07 RID: 31495
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B08 RID: 31496
		public const int RecallQuestIdFieldNumber = 1;

		// Token: 0x04007B09 RID: 31497
		private int recallQuestId_;
	}
}
