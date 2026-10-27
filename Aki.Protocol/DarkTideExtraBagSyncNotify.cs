using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A5 RID: 933
	[NetMessage(EMessageId.DarkTideExtraBagSyncNotify)]
	public sealed class DarkTideExtraBagSyncNotify : IMessage<DarkTideExtraBagSyncNotify>, IMessage, IEquatable<DarkTideExtraBagSyncNotify>, IDeepCloneable<DarkTideExtraBagSyncNotify>, IBufferMessage
	{
		// Token: 0x06005BD1 RID: 23505 RVA: 0x000DF407 File Offset: 0x000DD607
		[NullableContext(1)]
		public static DarkTideExtraBagSyncNotify Create()
		{
			return new DarkTideExtraBagSyncNotify();
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x06005BD2 RID: 23506 RVA: 0x000DF40E File Offset: 0x000DD60E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x06005BD3 RID: 23507 RVA: 0x000DF411 File Offset: 0x000DD611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideExtraBagSyncNotify.Descriptor;
			}
		}

		// Token: 0x06005BD4 RID: 23508 RVA: 0x000DF418 File Offset: 0x000DD618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideExtraBagSyncNotify()
		{
		}

		// Token: 0x06005BD5 RID: 23509 RVA: 0x000DF42B File Offset: 0x000DD62B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideExtraBagSyncNotify(DarkTideExtraBagSyncNotify other) : this()
		{
			this.normalItemBag_ = other.normalItemBag_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005BD6 RID: 23510 RVA: 0x000DF455 File Offset: 0x000DD655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideExtraBagSyncNotify Clone()
		{
			return new DarkTideExtraBagSyncNotify(this);
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x06005BD7 RID: 23511 RVA: 0x000DF45D File Offset: 0x000DD65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DarkTideNormalItemPb> NormalItemBag
		{
			get
			{
				return this.normalItemBag_;
			}
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x000DF465 File Offset: 0x000DD665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideExtraBagSyncNotify);
		}

		// Token: 0x06005BD9 RID: 23513 RVA: 0x000DF473 File Offset: 0x000DD673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideExtraBagSyncNotify other)
		{
			return other != null && (other == this || (this.normalItemBag_.Equals(other.normalItemBag_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005BDA RID: 23514 RVA: 0x000DF4A8 File Offset: 0x000DD6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.normalItemBag_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005BDB RID: 23515 RVA: 0x000DF4DC File Offset: 0x000DD6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005BDC RID: 23516 RVA: 0x000DF4E9 File Offset: 0x000DD6E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005BDD RID: 23517 RVA: 0x000DF4F2 File Offset: 0x000DD6F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.normalItemBag_.WriteTo(ref output, DarkTideExtraBagSyncNotify._repeated_normalItemBag_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005BDE RID: 23518 RVA: 0x000DF51C File Offset: 0x000DD71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.normalItemBag_.CalculateSize(DarkTideExtraBagSyncNotify._repeated_normalItemBag_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005BDF RID: 23519 RVA: 0x000DF555 File Offset: 0x000DD755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideExtraBagSyncNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.normalItemBag_.Add(other.normalItemBag_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005BE0 RID: 23520 RVA: 0x000DF583 File Offset: 0x000DD783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005BE1 RID: 23521 RVA: 0x000DF58C File Offset: 0x000DD78C
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.normalItemBag_.AddEntriesFrom(ref input, DarkTideExtraBagSyncNotify._repeated_normalItemBag_codec);
				}
			}
		}

		// Token: 0x0400361D RID: 13853
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400361E RID: 13854
		public const int NormalItemBagFieldNumber = 4;

		// Token: 0x0400361F RID: 13855
		private static readonly FieldCodec<DarkTideNormalItemPb> _repeated_normalItemBag_codec = FieldCodec.ForMessage<DarkTideNormalItemPb>(34U, DarkTideNormalItemPb.Parser);

		// Token: 0x04003620 RID: 13856
		private readonly RepeatedField<DarkTideNormalItemPb> normalItemBag_ = new RepeatedField<DarkTideNormalItemPb>();
	}
}
