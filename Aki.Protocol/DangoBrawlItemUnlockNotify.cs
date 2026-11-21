using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000369 RID: 873
	[NetMessage(EMessageId.DangoBrawlItemUnlockNotify)]
	public sealed class DangoBrawlItemUnlockNotify : IMessage<DangoBrawlItemUnlockNotify>, IMessage, IEquatable<DangoBrawlItemUnlockNotify>, IDeepCloneable<DangoBrawlItemUnlockNotify>, IBufferMessage
	{
		// Token: 0x06005739 RID: 22329 RVA: 0x000D54E8 File Offset: 0x000D36E8
		[NullableContext(1)]
		public static DangoBrawlItemUnlockNotify Create()
		{
			return new DangoBrawlItemUnlockNotify();
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x0600573A RID: 22330 RVA: 0x000D54EF File Offset: 0x000D36EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x0600573B RID: 22331 RVA: 0x000D54F2 File Offset: 0x000D36F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlItemUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600573C RID: 22332 RVA: 0x000D54F9 File Offset: 0x000D36F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemUnlockNotify()
		{
		}

		// Token: 0x0600573D RID: 22333 RVA: 0x000D550C File Offset: 0x000D370C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemUnlockNotify(DangoBrawlItemUnlockNotify other) : this()
		{
			this.itemIds_ = other.itemIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600573E RID: 22334 RVA: 0x000D5536 File Offset: 0x000D3736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemUnlockNotify Clone()
		{
			return new DangoBrawlItemUnlockNotify(this);
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x0600573F RID: 22335 RVA: 0x000D553E File Offset: 0x000D373E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ItemIds
		{
			get
			{
				return this.itemIds_;
			}
		}

		// Token: 0x06005740 RID: 22336 RVA: 0x000D5546 File Offset: 0x000D3746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlItemUnlockNotify);
		}

		// Token: 0x06005741 RID: 22337 RVA: 0x000D5554 File Offset: 0x000D3754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlItemUnlockNotify other)
		{
			return other != null && (other == this || (this.itemIds_.Equals(other.itemIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005742 RID: 22338 RVA: 0x000D5588 File Offset: 0x000D3788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005743 RID: 22339 RVA: 0x000D55BC File Offset: 0x000D37BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005744 RID: 22340 RVA: 0x000D55C9 File Offset: 0x000D37C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005745 RID: 22341 RVA: 0x000D55D2 File Offset: 0x000D37D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemIds_.WriteTo(ref output, DangoBrawlItemUnlockNotify._repeated_itemIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005746 RID: 22342 RVA: 0x000D55FC File Offset: 0x000D37FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemIds_.CalculateSize(DangoBrawlItemUnlockNotify._repeated_itemIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005747 RID: 22343 RVA: 0x000D5635 File Offset: 0x000D3835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlItemUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.itemIds_.Add(other.itemIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005748 RID: 22344 RVA: 0x000D5663 File Offset: 0x000D3863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005749 RID: 22345 RVA: 0x000D566C File Offset: 0x000D386C
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemIds_.AddEntriesFrom(ref input, DangoBrawlItemUnlockNotify._repeated_itemIds_codec);
				}
			}
		}

		// Token: 0x0400350F RID: 13583
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003510 RID: 13584
		public const int ItemIdsFieldNumber = 7;

		// Token: 0x04003511 RID: 13585
		private static readonly FieldCodec<int> _repeated_itemIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04003512 RID: 13586
		private readonly RepeatedField<int> itemIds_ = new RepeatedField<int>();
	}
}
