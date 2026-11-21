using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C6 RID: 2502
	[NetMessage(EMessageId.MiniWriteLetterLoginNotify)]
	public sealed class MiniWriteLetterLoginNotify : IMessage<MiniWriteLetterLoginNotify>, IMessage, IEquatable<MiniWriteLetterLoginNotify>, IDeepCloneable<MiniWriteLetterLoginNotify>, IBufferMessage
	{
		// Token: 0x0600DBC6 RID: 56262 RVA: 0x002049F4 File Offset: 0x00202BF4
		[NullableContext(1)]
		public static MiniWriteLetterLoginNotify Create()
		{
			return new MiniWriteLetterLoginNotify();
		}

		// Token: 0x17002C89 RID: 11401
		// (get) Token: 0x0600DBC7 RID: 56263 RVA: 0x002049FB File Offset: 0x00202BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C8A RID: 11402
		// (get) Token: 0x0600DBC8 RID: 56264 RVA: 0x002049FE File Offset: 0x00202BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MiniWriteLetterLoginNotify.Descriptor;
			}
		}

		// Token: 0x0600DBC9 RID: 56265 RVA: 0x00204A05 File Offset: 0x00202C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniWriteLetterLoginNotify()
		{
		}

		// Token: 0x0600DBCA RID: 56266 RVA: 0x00204A18 File Offset: 0x00202C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniWriteLetterLoginNotify(MiniWriteLetterLoginNotify other) : this()
		{
			this.letterContent_ = other.letterContent_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DBCB RID: 56267 RVA: 0x00204A42 File Offset: 0x00202C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniWriteLetterLoginNotify Clone()
		{
			return new MiniWriteLetterLoginNotify(this);
		}

		// Token: 0x17002C8B RID: 11403
		// (get) Token: 0x0600DBCC RID: 56268 RVA: 0x00204A4A File Offset: 0x00202C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MiniLetterContentPb> LetterContent
		{
			get
			{
				return this.letterContent_;
			}
		}

		// Token: 0x0600DBCD RID: 56269 RVA: 0x00204A52 File Offset: 0x00202C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MiniWriteLetterLoginNotify);
		}

		// Token: 0x0600DBCE RID: 56270 RVA: 0x00204A60 File Offset: 0x00202C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MiniWriteLetterLoginNotify other)
		{
			return other != null && (other == this || (this.letterContent_.Equals(other.letterContent_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DBCF RID: 56271 RVA: 0x00204A94 File Offset: 0x00202C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.letterContent_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DBD0 RID: 56272 RVA: 0x00204AC8 File Offset: 0x00202CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DBD1 RID: 56273 RVA: 0x00204AD5 File Offset: 0x00202CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DBD2 RID: 56274 RVA: 0x00204ADE File Offset: 0x00202CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.letterContent_.WriteTo(ref output, MiniWriteLetterLoginNotify._repeated_letterContent_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DBD3 RID: 56275 RVA: 0x00204B08 File Offset: 0x00202D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.letterContent_.CalculateSize(MiniWriteLetterLoginNotify._repeated_letterContent_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DBD4 RID: 56276 RVA: 0x00204B41 File Offset: 0x00202D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MiniWriteLetterLoginNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.letterContent_.Add(other.letterContent_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DBD5 RID: 56277 RVA: 0x00204B6F File Offset: 0x00202D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DBD6 RID: 56278 RVA: 0x00204B78 File Offset: 0x00202D78
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.letterContent_.AddEntriesFrom(ref input, MiniWriteLetterLoginNotify._repeated_letterContent_codec);
				}
			}
		}

		// Token: 0x04005B7A RID: 23418
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B7B RID: 23419
		public const int LetterContentFieldNumber = 11;

		// Token: 0x04005B7C RID: 23420
		private static readonly FieldCodec<MiniLetterContentPb> _repeated_letterContent_codec = FieldCodec.ForMessage<MiniLetterContentPb>(90U, MiniLetterContentPb.Parser);

		// Token: 0x04005B7D RID: 23421
		private readonly RepeatedField<MiniLetterContentPb> letterContent_ = new RepeatedField<MiniLetterContentPb>();
	}
}
