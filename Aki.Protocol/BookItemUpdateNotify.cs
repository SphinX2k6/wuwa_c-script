using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C0 RID: 448
	[NetMessage(EMessageId.BookItemUpdateNotify)]
	public sealed class BookItemUpdateNotify : IMessage<BookItemUpdateNotify>, IMessage, IEquatable<BookItemUpdateNotify>, IDeepCloneable<BookItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600339A RID: 13210 RVA: 0x000827BB File Offset: 0x000809BB
		[NullableContext(1)]
		public static BookItemUpdateNotify Create()
		{
			return new BookItemUpdateNotify();
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x0600339B RID: 13211 RVA: 0x000827C2 File Offset: 0x000809C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x0600339C RID: 13212 RVA: 0x000827C5 File Offset: 0x000809C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BookItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x000827CC File Offset: 0x000809CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BookItemUpdateNotify()
		{
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x000827E0 File Offset: 0x000809E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BookItemUpdateNotify(BookItemUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.brochureId_ = other.brochureId_;
			this.bookItems_ = other.bookItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x0008282D File Offset: 0x00080A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BookItemUpdateNotify Clone()
		{
			return new BookItemUpdateNotify(this);
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060033A0 RID: 13216 RVA: 0x00082835 File Offset: 0x00080A35
		// (set) Token: 0x060033A1 RID: 13217 RVA: 0x0008283D File Offset: 0x00080A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060033A2 RID: 13218 RVA: 0x00082846 File Offset: 0x00080A46
		// (set) Token: 0x060033A3 RID: 13219 RVA: 0x0008284E File Offset: 0x00080A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BrochureId
		{
			get
			{
				return this.brochureId_;
			}
			set
			{
				this.brochureId_ = value;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060033A4 RID: 13220 RVA: 0x00082857 File Offset: 0x00080A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BookItemInfo> BookItems
		{
			get
			{
				return this.bookItems_;
			}
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x0008285F File Offset: 0x00080A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BookItemUpdateNotify);
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x00082870 File Offset: 0x00080A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BookItemUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.BrochureId == other.BrochureId && this.bookItems_.Equals(other.bookItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x000828D0 File Offset: 0x00080AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.BrochureId != 0)
			{
				num ^= this.BrochureId.GetHashCode();
			}
			num ^= this.bookItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x00082936 File Offset: 0x00080B36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x00082943 File Offset: 0x00080B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x0008294C File Offset: 0x00080B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bookItems_.WriteTo(ref output, BookItemUpdateNotify._repeated_bookItems_codec);
			if (this.BrochureId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BrochureId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x000829B8 File Offset: 0x00080BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.BrochureId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BrochureId);
			}
			num += this.bookItems_.CalculateSize(BookItemUpdateNotify._repeated_bookItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x00082A24 File Offset: 0x00080C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BookItemUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.BrochureId != 0)
			{
				this.BrochureId = other.BrochureId;
			}
			this.bookItems_.Add(other.bookItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060033AD RID: 13229 RVA: 0x00082A85 File Offset: 0x00080C85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x00082A90 File Offset: 0x00080C90
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
				if (num != 10U)
				{
					if (num != 40U)
					{
						if (num != 56U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ActivityId = input.ReadInt32();
						}
					}
					else
					{
						this.BrochureId = input.ReadInt32();
					}
				}
				else
				{
					this.bookItems_.AddEntriesFrom(ref input, BookItemUpdateNotify._repeated_bookItems_codec);
				}
			}
		}

		// Token: 0x040029C4 RID: 10692
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029C5 RID: 10693
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x040029C6 RID: 10694
		private int activityId_;

		// Token: 0x040029C7 RID: 10695
		public const int BrochureIdFieldNumber = 5;

		// Token: 0x040029C8 RID: 10696
		private int brochureId_;

		// Token: 0x040029C9 RID: 10697
		public const int BookItemsFieldNumber = 1;

		// Token: 0x040029CA RID: 10698
		private static readonly FieldCodec<BookItemInfo> _repeated_bookItems_codec = FieldCodec.ForMessage<BookItemInfo>(10U, BookItemInfo.Parser);

		// Token: 0x040029CB RID: 10699
		private readonly RepeatedField<BookItemInfo> bookItems_ = new RepeatedField<BookItemInfo>();
	}
}
