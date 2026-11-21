using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CFC RID: 3324
	[NetMessage(EMessageId.PhantomUnlockNotify)]
	public sealed class PhantomUnlockNotify : IMessage<PhantomUnlockNotify>, IMessage, IEquatable<PhantomUnlockNotify>, IDeepCloneable<PhantomUnlockNotify>, IBufferMessage
	{
		// Token: 0x06011FCD RID: 73677 RVA: 0x002A1944 File Offset: 0x0029FB44
		[NullableContext(1)]
		public static PhantomUnlockNotify Create()
		{
			return new PhantomUnlockNotify();
		}

		// Token: 0x17003B99 RID: 15257
		// (get) Token: 0x06011FCE RID: 73678 RVA: 0x002A194B File Offset: 0x0029FB4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B9A RID: 15258
		// (get) Token: 0x06011FCF RID: 73679 RVA: 0x002A194E File Offset: 0x0029FB4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06011FD0 RID: 73680 RVA: 0x002A1955 File Offset: 0x0029FB55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomUnlockNotify()
		{
		}

		// Token: 0x06011FD1 RID: 73681 RVA: 0x002A1973 File Offset: 0x0029FB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomUnlockNotify(PhantomUnlockNotify other) : this()
		{
			this.unlockQualityItemList_ = other.unlockQualityItemList_.Clone();
			this.unlockMonsterItemList_ = other.unlockMonsterItemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011FD2 RID: 73682 RVA: 0x002A19AE File Offset: 0x0029FBAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomUnlockNotify Clone()
		{
			return new PhantomUnlockNotify(this);
		}

		// Token: 0x17003B9B RID: 15259
		// (get) Token: 0x06011FD3 RID: 73683 RVA: 0x002A19B6 File Offset: 0x0029FBB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockQualityItemList
		{
			get
			{
				return this.unlockQualityItemList_;
			}
		}

		// Token: 0x17003B9C RID: 15260
		// (get) Token: 0x06011FD4 RID: 73684 RVA: 0x002A19BE File Offset: 0x0029FBBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockMonsterItemList
		{
			get
			{
				return this.unlockMonsterItemList_;
			}
		}

		// Token: 0x06011FD5 RID: 73685 RVA: 0x002A19C6 File Offset: 0x0029FBC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomUnlockNotify);
		}

		// Token: 0x06011FD6 RID: 73686 RVA: 0x002A19D4 File Offset: 0x0029FBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockQualityItemList_.Equals(other.unlockQualityItemList_) && this.unlockMonsterItemList_.Equals(other.unlockMonsterItemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011FD7 RID: 73687 RVA: 0x002A1A28 File Offset: 0x0029FC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockQualityItemList_.GetHashCode();
			num ^= this.unlockMonsterItemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011FD8 RID: 73688 RVA: 0x002A1A6A File Offset: 0x0029FC6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011FD9 RID: 73689 RVA: 0x002A1A77 File Offset: 0x0029FC77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011FDA RID: 73690 RVA: 0x002A1A80 File Offset: 0x0029FC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockMonsterItemList_.WriteTo(ref output, PhantomUnlockNotify._repeated_unlockMonsterItemList_codec);
			this.unlockQualityItemList_.WriteTo(ref output, PhantomUnlockNotify._repeated_unlockQualityItemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011FDB RID: 73691 RVA: 0x002A1AB8 File Offset: 0x0029FCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockQualityItemList_.CalculateSize(PhantomUnlockNotify._repeated_unlockQualityItemList_codec);
			num += this.unlockMonsterItemList_.CalculateSize(PhantomUnlockNotify._repeated_unlockMonsterItemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011FDC RID: 73692 RVA: 0x002A1B04 File Offset: 0x0029FD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockQualityItemList_.Add(other.unlockQualityItemList_);
			this.unlockMonsterItemList_.Add(other.unlockMonsterItemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011FDD RID: 73693 RVA: 0x002A1B43 File Offset: 0x0029FD43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011FDE RID: 73694 RVA: 0x002A1B4C File Offset: 0x0029FD4C
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.unlockMonsterItemList_.AddEntriesFrom(ref input, PhantomUnlockNotify._repeated_unlockMonsterItemList_codec);
						continue;
					}
				}
				else if (num == 24U || num == 26U)
				{
					this.unlockQualityItemList_.AddEntriesFrom(ref input, PhantomUnlockNotify._repeated_unlockQualityItemList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007112 RID: 28946
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007113 RID: 28947
		public const int UnlockQualityItemListFieldNumber = 3;

		// Token: 0x04007114 RID: 28948
		private static readonly FieldCodec<int> _repeated_unlockQualityItemList_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04007115 RID: 28949
		private readonly RepeatedField<int> unlockQualityItemList_ = new RepeatedField<int>();

		// Token: 0x04007116 RID: 28950
		public const int UnlockMonsterItemListFieldNumber = 1;

		// Token: 0x04007117 RID: 28951
		private static readonly FieldCodec<int> _repeated_unlockMonsterItemList_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04007118 RID: 28952
		private readonly RepeatedField<int> unlockMonsterItemList_ = new RepeatedField<int>();
	}
}
