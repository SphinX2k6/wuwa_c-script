using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015A8 RID: 5544
	[NetMessage(EMessageId.ZitherPlayNotePush)]
	public sealed class ZitherPlayNotePush : IMessage<ZitherPlayNotePush>, IMessage, IEquatable<ZitherPlayNotePush>, IDeepCloneable<ZitherPlayNotePush>, IBufferMessage
	{
		// Token: 0x0601D577 RID: 120183 RVA: 0x0043F318 File Offset: 0x0043D518
		[NullableContext(1)]
		public static ZitherPlayNotePush Create()
		{
			return new ZitherPlayNotePush();
		}

		// Token: 0x17006344 RID: 25412
		// (get) Token: 0x0601D578 RID: 120184 RVA: 0x0043F31F File Offset: 0x0043D51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006345 RID: 25413
		// (get) Token: 0x0601D579 RID: 120185 RVA: 0x0043F322 File Offset: 0x0043D522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ZitherPlayNotePush.Descriptor;
			}
		}

		// Token: 0x0601D57A RID: 120186 RVA: 0x0043F329 File Offset: 0x0043D529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayNotePush()
		{
		}

		// Token: 0x0601D57B RID: 120187 RVA: 0x0043F33C File Offset: 0x0043D53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayNotePush(ZitherPlayNotePush other) : this()
		{
			this.note_ = other.note_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D57C RID: 120188 RVA: 0x0043F361 File Offset: 0x0043D561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayNotePush Clone()
		{
			return new ZitherPlayNotePush(this);
		}

		// Token: 0x17006346 RID: 25414
		// (get) Token: 0x0601D57D RID: 120189 RVA: 0x0043F369 File Offset: 0x0043D569
		// (set) Token: 0x0601D57E RID: 120190 RVA: 0x0043F371 File Offset: 0x0043D571
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

		// Token: 0x0601D57F RID: 120191 RVA: 0x0043F384 File Offset: 0x0043D584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ZitherPlayNotePush);
		}

		// Token: 0x0601D580 RID: 120192 RVA: 0x0043F392 File Offset: 0x0043D592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ZitherPlayNotePush other)
		{
			return other != null && (other == this || (!(this.Note != other.Note) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D581 RID: 120193 RVA: 0x0043F3C8 File Offset: 0x0043D5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0601D582 RID: 120194 RVA: 0x0043F409 File Offset: 0x0043D609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D583 RID: 120195 RVA: 0x0043F416 File Offset: 0x0043D616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D584 RID: 120196 RVA: 0x0043F41F File Offset: 0x0043D61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Note.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Note);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D585 RID: 120197 RVA: 0x0043F458 File Offset: 0x0043D658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0601D586 RID: 120198 RVA: 0x0043F49B File Offset: 0x0043D69B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ZitherPlayNotePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Note.Length != 0)
			{
				this.Note = other.Note;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D587 RID: 120199 RVA: 0x0043F4D1 File Offset: 0x0043D6D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D588 RID: 120200 RVA: 0x0043F4DC File Offset: 0x0043D6DC
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Note = input.ReadString();
				}
			}
		}

		// Token: 0x0400A830 RID: 43056
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A831 RID: 43057
		public const int NoteFieldNumber = 3;

		// Token: 0x0400A832 RID: 43058
		private string note_ = "";
	}
}
