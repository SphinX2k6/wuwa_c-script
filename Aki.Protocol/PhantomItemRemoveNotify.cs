using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CCF RID: 3279
	[NetMessage(EMessageId.PhantomItemRemoveNotify)]
	public sealed class PhantomItemRemoveNotify : IMessage<PhantomItemRemoveNotify>, IMessage, IEquatable<PhantomItemRemoveNotify>, IDeepCloneable<PhantomItemRemoveNotify>, IBufferMessage
	{
		// Token: 0x06011C4E RID: 72782 RVA: 0x0029A264 File Offset: 0x00298464
		[NullableContext(1)]
		public static PhantomItemRemoveNotify Create()
		{
			return new PhantomItemRemoveNotify();
		}

		// Token: 0x17003AE3 RID: 15075
		// (get) Token: 0x06011C4F RID: 72783 RVA: 0x0029A26B File Offset: 0x0029846B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AE4 RID: 15076
		// (get) Token: 0x06011C50 RID: 72784 RVA: 0x0029A26E File Offset: 0x0029846E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomItemRemoveNotify.Descriptor;
			}
		}

		// Token: 0x06011C51 RID: 72785 RVA: 0x0029A275 File Offset: 0x00298475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemRemoveNotify()
		{
		}

		// Token: 0x06011C52 RID: 72786 RVA: 0x0029A288 File Offset: 0x00298488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemRemoveNotify(PhantomItemRemoveNotify other) : this()
		{
			this.phantomItemIncrIdList_ = other.phantomItemIncrIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011C53 RID: 72787 RVA: 0x0029A2B2 File Offset: 0x002984B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemRemoveNotify Clone()
		{
			return new PhantomItemRemoveNotify(this);
		}

		// Token: 0x17003AE5 RID: 15077
		// (get) Token: 0x06011C54 RID: 72788 RVA: 0x0029A2BA File Offset: 0x002984BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PhantomItemIncrIdList
		{
			get
			{
				return this.phantomItemIncrIdList_;
			}
		}

		// Token: 0x06011C55 RID: 72789 RVA: 0x0029A2C2 File Offset: 0x002984C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomItemRemoveNotify);
		}

		// Token: 0x06011C56 RID: 72790 RVA: 0x0029A2D0 File Offset: 0x002984D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomItemRemoveNotify other)
		{
			return other != null && (other == this || (this.phantomItemIncrIdList_.Equals(other.phantomItemIncrIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011C57 RID: 72791 RVA: 0x0029A304 File Offset: 0x00298504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomItemIncrIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011C58 RID: 72792 RVA: 0x0029A338 File Offset: 0x00298538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011C59 RID: 72793 RVA: 0x0029A345 File Offset: 0x00298545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011C5A RID: 72794 RVA: 0x0029A34E File Offset: 0x0029854E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomItemIncrIdList_.WriteTo(ref output, PhantomItemRemoveNotify._repeated_phantomItemIncrIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011C5B RID: 72795 RVA: 0x0029A378 File Offset: 0x00298578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomItemIncrIdList_.CalculateSize(PhantomItemRemoveNotify._repeated_phantomItemIncrIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011C5C RID: 72796 RVA: 0x0029A3B1 File Offset: 0x002985B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomItemRemoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomItemIncrIdList_.Add(other.phantomItemIncrIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011C5D RID: 72797 RVA: 0x0029A3DF File Offset: 0x002985DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011C5E RID: 72798 RVA: 0x0029A3E8 File Offset: 0x002985E8
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomItemIncrIdList_.AddEntriesFrom(ref input, PhantomItemRemoveNotify._repeated_phantomItemIncrIdList_codec);
				}
			}
		}

		// Token: 0x04007012 RID: 28690
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007013 RID: 28691
		public const int PhantomItemIncrIdListFieldNumber = 11;

		// Token: 0x04007014 RID: 28692
		private static readonly FieldCodec<int> _repeated_phantomItemIncrIdList_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04007015 RID: 28693
		private readonly RepeatedField<int> phantomItemIncrIdList_ = new RepeatedField<int>();
	}
}
