using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C7 RID: 2503
	[NetMessage(EMessageId.MiniWriteLetterSaveContentRequest)]
	public sealed class MiniWriteLetterSaveContentRequest : IMessage<MiniWriteLetterSaveContentRequest>, IMessage, IEquatable<MiniWriteLetterSaveContentRequest>, IDeepCloneable<MiniWriteLetterSaveContentRequest>, IBufferMessage
	{
		// Token: 0x0600DBD8 RID: 56280 RVA: 0x00204BD5 File Offset: 0x00202DD5
		[NullableContext(1)]
		public static MiniWriteLetterSaveContentRequest Create()
		{
			return new MiniWriteLetterSaveContentRequest();
		}

		// Token: 0x17002C8C RID: 11404
		// (get) Token: 0x0600DBD9 RID: 56281 RVA: 0x00204BDC File Offset: 0x00202DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C8D RID: 11405
		// (get) Token: 0x0600DBDA RID: 56282 RVA: 0x00204BDF File Offset: 0x00202DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MiniWriteLetterSaveContentRequest.Descriptor;
			}
		}

		// Token: 0x0600DBDB RID: 56283 RVA: 0x00204BE6 File Offset: 0x00202DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniWriteLetterSaveContentRequest()
		{
		}

		// Token: 0x0600DBDC RID: 56284 RVA: 0x00204BF9 File Offset: 0x00202DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniWriteLetterSaveContentRequest(MiniWriteLetterSaveContentRequest other) : this()
		{
			this.letterContent_ = other.letterContent_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DBDD RID: 56285 RVA: 0x00204C23 File Offset: 0x00202E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniWriteLetterSaveContentRequest Clone()
		{
			return new MiniWriteLetterSaveContentRequest(this);
		}

		// Token: 0x17002C8E RID: 11406
		// (get) Token: 0x0600DBDE RID: 56286 RVA: 0x00204C2B File Offset: 0x00202E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MiniLetterContentPb> LetterContent
		{
			get
			{
				return this.letterContent_;
			}
		}

		// Token: 0x0600DBDF RID: 56287 RVA: 0x00204C33 File Offset: 0x00202E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MiniWriteLetterSaveContentRequest);
		}

		// Token: 0x0600DBE0 RID: 56288 RVA: 0x00204C41 File Offset: 0x00202E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MiniWriteLetterSaveContentRequest other)
		{
			return other != null && (other == this || (this.letterContent_.Equals(other.letterContent_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DBE1 RID: 56289 RVA: 0x00204C74 File Offset: 0x00202E74
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

		// Token: 0x0600DBE2 RID: 56290 RVA: 0x00204CA8 File Offset: 0x00202EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DBE3 RID: 56291 RVA: 0x00204CB5 File Offset: 0x00202EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DBE4 RID: 56292 RVA: 0x00204CBE File Offset: 0x00202EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.letterContent_.WriteTo(ref output, MiniWriteLetterSaveContentRequest._repeated_letterContent_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DBE5 RID: 56293 RVA: 0x00204CE8 File Offset: 0x00202EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.letterContent_.CalculateSize(MiniWriteLetterSaveContentRequest._repeated_letterContent_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DBE6 RID: 56294 RVA: 0x00204D21 File Offset: 0x00202F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MiniWriteLetterSaveContentRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.letterContent_.Add(other.letterContent_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DBE7 RID: 56295 RVA: 0x00204D4F File Offset: 0x00202F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DBE8 RID: 56296 RVA: 0x00204D58 File Offset: 0x00202F58
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
					this.letterContent_.AddEntriesFrom(ref input, MiniWriteLetterSaveContentRequest._repeated_letterContent_codec);
				}
			}
		}

		// Token: 0x04005B7E RID: 23422
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B7F RID: 23423
		public const int LetterContentFieldNumber = 11;

		// Token: 0x04005B80 RID: 23424
		private static readonly FieldCodec<MiniLetterContentPb> _repeated_letterContent_codec = FieldCodec.ForMessage<MiniLetterContentPb>(90U, MiniLetterContentPb.Parser);

		// Token: 0x04005B81 RID: 23425
		private readonly RepeatedField<MiniLetterContentPb> letterContent_ = new RepeatedField<MiniLetterContentPb>();
	}
}
