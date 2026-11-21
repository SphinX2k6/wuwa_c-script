using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015A7 RID: 5543
	[NetMessage(EMessageId.ZitherPlayNoteNotify)]
	public sealed class ZitherPlayNoteNotify : IMessage<ZitherPlayNoteNotify>, IMessage, IEquatable<ZitherPlayNoteNotify>, IDeepCloneable<ZitherPlayNoteNotify>, IBufferMessage
	{
		// Token: 0x0601D563 RID: 120163 RVA: 0x0043F04B File Offset: 0x0043D24B
		[NullableContext(1)]
		public static ZitherPlayNoteNotify Create()
		{
			return new ZitherPlayNoteNotify();
		}

		// Token: 0x17006340 RID: 25408
		// (get) Token: 0x0601D564 RID: 120164 RVA: 0x0043F052 File Offset: 0x0043D252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006341 RID: 25409
		// (get) Token: 0x0601D565 RID: 120165 RVA: 0x0043F055 File Offset: 0x0043D255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ZitherPlayNoteNotify.Descriptor;
			}
		}

		// Token: 0x0601D566 RID: 120166 RVA: 0x0043F05C File Offset: 0x0043D25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayNoteNotify()
		{
		}

		// Token: 0x0601D567 RID: 120167 RVA: 0x0043F06F File Offset: 0x0043D26F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayNoteNotify(ZitherPlayNoteNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.note_ = other.note_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D568 RID: 120168 RVA: 0x0043F0A0 File Offset: 0x0043D2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayNoteNotify Clone()
		{
			return new ZitherPlayNoteNotify(this);
		}

		// Token: 0x17006342 RID: 25410
		// (get) Token: 0x0601D569 RID: 120169 RVA: 0x0043F0A8 File Offset: 0x0043D2A8
		// (set) Token: 0x0601D56A RID: 120170 RVA: 0x0043F0B0 File Offset: 0x0043D2B0
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

		// Token: 0x17006343 RID: 25411
		// (get) Token: 0x0601D56B RID: 120171 RVA: 0x0043F0B9 File Offset: 0x0043D2B9
		// (set) Token: 0x0601D56C RID: 120172 RVA: 0x0043F0C1 File Offset: 0x0043D2C1
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

		// Token: 0x0601D56D RID: 120173 RVA: 0x0043F0D4 File Offset: 0x0043D2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ZitherPlayNoteNotify);
		}

		// Token: 0x0601D56E RID: 120174 RVA: 0x0043F0E4 File Offset: 0x0043D2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ZitherPlayNoteNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.Note != other.Note) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D56F RID: 120175 RVA: 0x0043F134 File Offset: 0x0043D334
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

		// Token: 0x0601D570 RID: 120176 RVA: 0x0043F18E File Offset: 0x0043D38E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D571 RID: 120177 RVA: 0x0043F19B File Offset: 0x0043D39B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D572 RID: 120178 RVA: 0x0043F1A4 File Offset: 0x0043D3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Note.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Note);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D573 RID: 120179 RVA: 0x0043F204 File Offset: 0x0043D404
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

		// Token: 0x0601D574 RID: 120180 RVA: 0x0043F260 File Offset: 0x0043D460
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

		// Token: 0x0601D575 RID: 120181 RVA: 0x0043F2B5 File Offset: 0x0043D4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D576 RID: 120182 RVA: 0x0043F2C0 File Offset: 0x0043D4C0
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.Note = input.ReadString();
				}
			}
		}

		// Token: 0x0400A82B RID: 43051
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A82C RID: 43052
		public const int EntityIdFieldNumber = 15;

		// Token: 0x0400A82D RID: 43053
		private long entityId_;

		// Token: 0x0400A82E RID: 43054
		public const int NoteFieldNumber = 1;

		// Token: 0x0400A82F RID: 43055
		private string note_ = "";
	}
}
