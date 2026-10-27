using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001532 RID: 5426
	[NetMessage(EMessageId.ZitherPlayNotePush)]
	public sealed class ZitherPlayNotePush : IMessage<ZitherPlayNotePush>, IMessage, IEquatable<ZitherPlayNotePush>, IDeepCloneable<ZitherPlayNotePush>, IBufferMessage
	{
		// Token: 0x0601CAAC RID: 117420 RVA: 0x004236F8 File Offset: 0x004218F8
		[NullableContext(1)]
		public static ZitherPlayNotePush Create()
		{
			return new ZitherPlayNotePush();
		}

		// Token: 0x170060A1 RID: 24737
		// (get) Token: 0x0601CAAD RID: 117421 RVA: 0x004236FF File Offset: 0x004218FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060A2 RID: 24738
		// (get) Token: 0x0601CAAE RID: 117422 RVA: 0x00423702 File Offset: 0x00421902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ZitherPlayNotePush.Descriptor;
			}
		}

		// Token: 0x0601CAAF RID: 117423 RVA: 0x00423709 File Offset: 0x00421909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayNotePush()
		{
		}

		// Token: 0x0601CAB0 RID: 117424 RVA: 0x0042371C File Offset: 0x0042191C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayNotePush(ZitherPlayNotePush other) : this()
		{
			this.note_ = other.note_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CAB1 RID: 117425 RVA: 0x00423741 File Offset: 0x00421941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayNotePush Clone()
		{
			return new ZitherPlayNotePush(this);
		}

		// Token: 0x170060A3 RID: 24739
		// (get) Token: 0x0601CAB2 RID: 117426 RVA: 0x00423749 File Offset: 0x00421949
		// (set) Token: 0x0601CAB3 RID: 117427 RVA: 0x00423751 File Offset: 0x00421951
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

		// Token: 0x0601CAB4 RID: 117428 RVA: 0x00423764 File Offset: 0x00421964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ZitherPlayNotePush);
		}

		// Token: 0x0601CAB5 RID: 117429 RVA: 0x00423772 File Offset: 0x00421972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ZitherPlayNotePush other)
		{
			return other != null && (other == this || (!(this.Note != other.Note) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CAB6 RID: 117430 RVA: 0x004237A8 File Offset: 0x004219A8
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

		// Token: 0x0601CAB7 RID: 117431 RVA: 0x004237E9 File Offset: 0x004219E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CAB8 RID: 117432 RVA: 0x004237F6 File Offset: 0x004219F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CAB9 RID: 117433 RVA: 0x004237FF File Offset: 0x004219FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Note.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.Note);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CABA RID: 117434 RVA: 0x00423838 File Offset: 0x00421A38
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

		// Token: 0x0601CABB RID: 117435 RVA: 0x0042387B File Offset: 0x00421A7B
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

		// Token: 0x0601CABC RID: 117436 RVA: 0x004238B1 File Offset: 0x00421AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CABD RID: 117437 RVA: 0x004238BC File Offset: 0x00421ABC
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Note = input.ReadString();
				}
			}
		}

		// Token: 0x0400A3D3 RID: 41939
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3D4 RID: 41940
		public const int NoteFieldNumber = 15;

		// Token: 0x0400A3D5 RID: 41941
		private string note_ = "";
	}
}
