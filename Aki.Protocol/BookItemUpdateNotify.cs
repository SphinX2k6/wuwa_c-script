using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C4 RID: 452
	[NetMessage(EMessageId.BookItemUpdateNotify)]
	public sealed class BookItemUpdateNotify : IMessage<BookItemUpdateNotify>, IMessage, IEquatable<BookItemUpdateNotify>, IDeepCloneable<BookItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x06003427 RID: 13351 RVA: 0x00083F2B File Offset: 0x0008212B
		[NullableContext(1)]
		public static BookItemUpdateNotify Create()
		{
			return new BookItemUpdateNotify();
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06003428 RID: 13352 RVA: 0x00083F32 File Offset: 0x00082132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06003429 RID: 13353 RVA: 0x00083F35 File Offset: 0x00082135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BookItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x00083F3C File Offset: 0x0008213C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BookItemUpdateNotify()
		{
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x00083F50 File Offset: 0x00082150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BookItemUpdateNotify(BookItemUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.brochureId_ = other.brochureId_;
			this.bookItems_ = other.bookItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x00083F9D File Offset: 0x0008219D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BookItemUpdateNotify Clone()
		{
			return new BookItemUpdateNotify(this);
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x0600342D RID: 13357 RVA: 0x00083FA5 File Offset: 0x000821A5
		// (set) Token: 0x0600342E RID: 13358 RVA: 0x00083FAD File Offset: 0x000821AD
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

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x0600342F RID: 13359 RVA: 0x00083FB6 File Offset: 0x000821B6
		// (set) Token: 0x06003430 RID: 13360 RVA: 0x00083FBE File Offset: 0x000821BE
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

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06003431 RID: 13361 RVA: 0x00083FC7 File Offset: 0x000821C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BookItemInfo> BookItems
		{
			get
			{
				return this.bookItems_;
			}
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x00083FCF File Offset: 0x000821CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BookItemUpdateNotify);
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x00083FE0 File Offset: 0x000821E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BookItemUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.BrochureId == other.BrochureId && this.bookItems_.Equals(other.bookItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x00084040 File Offset: 0x00082240
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

		// Token: 0x06003435 RID: 13365 RVA: 0x000840A6 File Offset: 0x000822A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x000840B3 File Offset: 0x000822B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003437 RID: 13367 RVA: 0x000840BC File Offset: 0x000822BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bookItems_.WriteTo(ref output, BookItemUpdateNotify._repeated_bookItems_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this.BrochureId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.BrochureId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x00084128 File Offset: 0x00082328
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

		// Token: 0x06003439 RID: 13369 RVA: 0x00084194 File Offset: 0x00082394
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

		// Token: 0x0600343A RID: 13370 RVA: 0x000841F5 File Offset: 0x000823F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600343B RID: 13371 RVA: 0x00084200 File Offset: 0x00082400
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
				if (num != 50U)
				{
					if (num != 96U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BrochureId = input.ReadInt32();
						}
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.bookItems_.AddEntriesFrom(ref input, BookItemUpdateNotify._repeated_bookItems_codec);
				}
			}
		}

		// Token: 0x04002A3F RID: 10815
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A40 RID: 10816
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x04002A41 RID: 10817
		private int activityId_;

		// Token: 0x04002A42 RID: 10818
		public const int BrochureIdFieldNumber = 14;

		// Token: 0x04002A43 RID: 10819
		private int brochureId_;

		// Token: 0x04002A44 RID: 10820
		public const int BookItemsFieldNumber = 6;

		// Token: 0x04002A45 RID: 10821
		private static readonly FieldCodec<BookItemInfo> _repeated_bookItems_codec = FieldCodec.ForMessage<BookItemInfo>(50U, BookItemInfo.Parser);

		// Token: 0x04002A46 RID: 10822
		private readonly RepeatedField<BookItemInfo> bookItems_ = new RepeatedField<BookItemInfo>();
	}
}
