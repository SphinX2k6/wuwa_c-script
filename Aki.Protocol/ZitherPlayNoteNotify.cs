using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001531 RID: 5425
	[NetMessage(EMessageId.ZitherPlayNoteNotify)]
	public sealed class ZitherPlayNoteNotify : IMessage<ZitherPlayNoteNotify>, IMessage, IEquatable<ZitherPlayNoteNotify>, IDeepCloneable<ZitherPlayNoteNotify>, IBufferMessage
	{
		// Token: 0x0601CA98 RID: 117400 RVA: 0x0042342C File Offset: 0x0042162C
		[NullableContext(1)]
		public static ZitherPlayNoteNotify Create()
		{
			return new ZitherPlayNoteNotify();
		}

		// Token: 0x1700609D RID: 24733
		// (get) Token: 0x0601CA99 RID: 117401 RVA: 0x00423433 File Offset: 0x00421633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700609E RID: 24734
		// (get) Token: 0x0601CA9A RID: 117402 RVA: 0x00423436 File Offset: 0x00421636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ZitherPlayNoteNotify.Descriptor;
			}
		}

		// Token: 0x0601CA9B RID: 117403 RVA: 0x0042343D File Offset: 0x0042163D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayNoteNotify()
		{
		}

		// Token: 0x0601CA9C RID: 117404 RVA: 0x00423450 File Offset: 0x00421650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayNoteNotify(ZitherPlayNoteNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.note_ = other.note_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CA9D RID: 117405 RVA: 0x00423481 File Offset: 0x00421681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayNoteNotify Clone()
		{
			return new ZitherPlayNoteNotify(this);
		}

		// Token: 0x1700609F RID: 24735
		// (get) Token: 0x0601CA9E RID: 117406 RVA: 0x00423489 File Offset: 0x00421689
		// (set) Token: 0x0601CA9F RID: 117407 RVA: 0x00423491 File Offset: 0x00421691
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

		// Token: 0x170060A0 RID: 24736
		// (get) Token: 0x0601CAA0 RID: 117408 RVA: 0x0042349A File Offset: 0x0042169A
		// (set) Token: 0x0601CAA1 RID: 117409 RVA: 0x004234A2 File Offset: 0x004216A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Note
		{
			get
			{
				return this.note_;
			}
			set
			{
				this.note_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601CAA2 RID: 117410 RVA: 0x004234B5 File Offset: 0x004216B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ZitherPlayNoteNotify);
		}

		// Token: 0x0601CAA3 RID: 117411 RVA: 0x004234C4 File Offset: 0x004216C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ZitherPlayNoteNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.Note != other.Note) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CAA4 RID: 117412 RVA: 0x00423514 File Offset: 0x00421714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Note.Length != 0)
			{
				num ^= this.Note.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CAA5 RID: 117413 RVA: 0x0042356E File Offset: 0x0042176E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CAA6 RID: 117414 RVA: 0x0042357B File Offset: 0x0042177B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CAA7 RID: 117415 RVA: 0x00423584 File Offset: 0x00421784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this.Note.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.Note);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CAA8 RID: 117416 RVA: 0x004235E4 File Offset: 0x004217E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Note.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Note);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CAA9 RID: 117417 RVA: 0x00423640 File Offset: 0x00421840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ZitherPlayNoteNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Note.Length != 0)
			{
				this.Note = other.Note;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CAAA RID: 117418 RVA: 0x00423695 File Offset: 0x00421895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CAAB RID: 117419 RVA: 0x004236A0 File Offset: 0x004218A0
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
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Note = input.ReadString();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A3CE RID: 41934
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3CF RID: 41935
		public const int EntityIdFieldNumber = 11;

		// Token: 0x0400A3D0 RID: 41936
		private long entityId_;

		// Token: 0x0400A3D1 RID: 41937
		public const int NoteFieldNumber = 13;

		// Token: 0x0400A3D2 RID: 41938
		private string note_ = "";
	}
}
