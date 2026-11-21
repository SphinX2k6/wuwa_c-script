using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA7 RID: 3751
	public sealed class RecallQuestActiveActionCtxPb : IMessage<RecallQuestActiveActionCtxPb>, IMessage, IEquatable<RecallQuestActiveActionCtxPb>, IDeepCloneable<RecallQuestActiveActionCtxPb>, IBufferMessage
	{
		// Token: 0x06014278 RID: 82552 RVA: 0x002EF335 File Offset: 0x002ED535
		[NullableContext(1)]
		public static RecallQuestActiveActionCtxPb Create()
		{
			return new RecallQuestActiveActionCtxPb();
		}

		// Token: 0x1700430D RID: 17165
		// (get) Token: 0x06014279 RID: 82553 RVA: 0x002EF33C File Offset: 0x002ED53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700430E RID: 17166
		// (get) Token: 0x0601427A RID: 82554 RVA: 0x002EF33F File Offset: 0x002ED53F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestActiveActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0601427B RID: 82555 RVA: 0x002EF346 File Offset: 0x002ED546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestActiveActionCtxPb()
		{
		}

		// Token: 0x0601427C RID: 82556 RVA: 0x002EF34E File Offset: 0x002ED54E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestActiveActionCtxPb(RecallQuestActiveActionCtxPb other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601427D RID: 82557 RVA: 0x002EF373 File Offset: 0x002ED573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestActiveActionCtxPb Clone()
		{
			return new RecallQuestActiveActionCtxPb(this);
		}

		// Token: 0x1700430F RID: 17167
		// (get) Token: 0x0601427E RID: 82558 RVA: 0x002EF37B File Offset: 0x002ED57B
		// (set) Token: 0x0601427F RID: 82559 RVA: 0x002EF383 File Offset: 0x002ED583
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

		// Token: 0x06014280 RID: 82560 RVA: 0x002EF38C File Offset: 0x002ED58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestActiveActionCtxPb);
		}

		// Token: 0x06014281 RID: 82561 RVA: 0x002EF39A File Offset: 0x002ED59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestActiveActionCtxPb other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014282 RID: 82562 RVA: 0x002EF3C8 File Offset: 0x002ED5C8
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

		// Token: 0x06014283 RID: 82563 RVA: 0x002EF407 File Offset: 0x002ED607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014284 RID: 82564 RVA: 0x002EF414 File Offset: 0x002ED614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014285 RID: 82565 RVA: 0x002EF41D File Offset: 0x002ED61D
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

		// Token: 0x06014286 RID: 82566 RVA: 0x002EF450 File Offset: 0x002ED650
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

		// Token: 0x06014287 RID: 82567 RVA: 0x002EF48E File Offset: 0x002ED68E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestActiveActionCtxPb other)
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

		// Token: 0x06014288 RID: 82568 RVA: 0x002EF4BF File Offset: 0x002ED6BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014289 RID: 82569 RVA: 0x002EF4C8 File Offset: 0x002ED6C8
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

		// Token: 0x04007B2A RID: 31530
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B2B RID: 31531
		public const int RecallQuestIdFieldNumber = 1;

		// Token: 0x04007B2C RID: 31532
		private int recallQuestId_;
	}
}
