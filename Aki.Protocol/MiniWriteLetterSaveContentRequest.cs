using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D8 RID: 2520
	[NetMessage(EMessageId.MiniWriteLetterSaveContentRequest)]
	public sealed class MiniWriteLetterSaveContentRequest : IMessage<MiniWriteLetterSaveContentRequest>, IMessage, IEquatable<MiniWriteLetterSaveContentRequest>, IDeepCloneable<MiniWriteLetterSaveContentRequest>, IBufferMessage
	{
		// Token: 0x0600DCF2 RID: 56562 RVA: 0x00206DC1 File Offset: 0x00204FC1
		[NullableContext(1)]
		public static MiniWriteLetterSaveContentRequest Create()
		{
			return new MiniWriteLetterSaveContentRequest();
		}

		// Token: 0x17002CCA RID: 11466
		// (get) Token: 0x0600DCF3 RID: 56563 RVA: 0x00206DC8 File Offset: 0x00204FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CCB RID: 11467
		// (get) Token: 0x0600DCF4 RID: 56564 RVA: 0x00206DCB File Offset: 0x00204FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MiniWriteLetterSaveContentRequest.Descriptor;
			}
		}

		// Token: 0x0600DCF5 RID: 56565 RVA: 0x00206DD2 File Offset: 0x00204FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniWriteLetterSaveContentRequest()
		{
		}

		// Token: 0x0600DCF6 RID: 56566 RVA: 0x00206DE5 File Offset: 0x00204FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniWriteLetterSaveContentRequest(MiniWriteLetterSaveContentRequest other) : this()
		{
			this.letterContent_ = other.letterContent_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DCF7 RID: 56567 RVA: 0x00206E0F File Offset: 0x0020500F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniWriteLetterSaveContentRequest Clone()
		{
			return new MiniWriteLetterSaveContentRequest(this);
		}

		// Token: 0x17002CCC RID: 11468
		// (get) Token: 0x0600DCF8 RID: 56568 RVA: 0x00206E17 File Offset: 0x00205017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MiniLetterContentPb> LetterContent
		{
			get
			{
				return this.letterContent_;
			}
		}

		// Token: 0x0600DCF9 RID: 56569 RVA: 0x00206E1F File Offset: 0x0020501F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MiniWriteLetterSaveContentRequest);
		}

		// Token: 0x0600DCFA RID: 56570 RVA: 0x00206E2D File Offset: 0x0020502D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MiniWriteLetterSaveContentRequest other)
		{
			return other != null && (other == this || (this.letterContent_.Equals(other.letterContent_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DCFB RID: 56571 RVA: 0x00206E60 File Offset: 0x00205060
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

		// Token: 0x0600DCFC RID: 56572 RVA: 0x00206E94 File Offset: 0x00205094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DCFD RID: 56573 RVA: 0x00206EA1 File Offset: 0x002050A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DCFE RID: 56574 RVA: 0x00206EAA File Offset: 0x002050AA
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

		// Token: 0x0600DCFF RID: 56575 RVA: 0x00206ED4 File Offset: 0x002050D4
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

		// Token: 0x0600DD00 RID: 56576 RVA: 0x00206F0D File Offset: 0x0020510D
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

		// Token: 0x0600DD01 RID: 56577 RVA: 0x00206F3B File Offset: 0x0020513B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD02 RID: 56578 RVA: 0x00206F44 File Offset: 0x00205144
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

		// Token: 0x04005B75 RID: 23413
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B76 RID: 23414
		public const int LetterContentFieldNumber = 11;

		// Token: 0x04005B77 RID: 23415
		private static readonly FieldCodec<MiniLetterContentPb> _repeated_letterContent_codec = FieldCodec.ForMessage<MiniLetterContentPb>(90U, MiniLetterContentPb.Parser);

		// Token: 0x04005B78 RID: 23416
		private readonly RepeatedField<MiniLetterContentPb> letterContent_ = new RepeatedField<MiniLetterContentPb>();
	}
}
