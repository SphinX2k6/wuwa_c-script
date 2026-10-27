using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AFF RID: 2815
	public sealed class NewbieAdventureV2Pb : IMessage<NewbieAdventureV2Pb>, IMessage, IEquatable<NewbieAdventureV2Pb>, IDeepCloneable<NewbieAdventureV2Pb>, IBufferMessage
	{
		// Token: 0x0600F4B6 RID: 62646 RVA: 0x0023B8F7 File Offset: 0x00239AF7
		[NullableContext(1)]
		public static NewbieAdventureV2Pb Create()
		{
			return new NewbieAdventureV2Pb();
		}

		// Token: 0x170031DA RID: 12762
		// (get) Token: 0x0600F4B7 RID: 62647 RVA: 0x0023B8FE File Offset: 0x00239AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031DB RID: 12763
		// (get) Token: 0x0600F4B8 RID: 62648 RVA: 0x0023B901 File Offset: 0x00239B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieAdventureV2Pb.Descriptor;
			}
		}

		// Token: 0x0600F4B9 RID: 62649 RVA: 0x0023B908 File Offset: 0x00239B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureV2Pb()
		{
		}

		// Token: 0x0600F4BA RID: 62650 RVA: 0x0023B91B File Offset: 0x00239B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureV2Pb(NewbieAdventureV2Pb other) : this()
		{
			this.chapter_ = other.chapter_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F4BB RID: 62651 RVA: 0x0023B945 File Offset: 0x00239B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureV2Pb Clone()
		{
			return new NewbieAdventureV2Pb(this);
		}

		// Token: 0x170031DC RID: 12764
		// (get) Token: 0x0600F4BC RID: 62652 RVA: 0x0023B94D File Offset: 0x00239B4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewbieAdventureV2ChapterPb> Chapter
		{
			get
			{
				return this.chapter_;
			}
		}

		// Token: 0x0600F4BD RID: 62653 RVA: 0x0023B955 File Offset: 0x00239B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieAdventureV2Pb);
		}

		// Token: 0x0600F4BE RID: 62654 RVA: 0x0023B963 File Offset: 0x00239B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieAdventureV2Pb other)
		{
			return other != null && (other == this || (this.chapter_.Equals(other.chapter_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F4BF RID: 62655 RVA: 0x0023B998 File Offset: 0x00239B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.chapter_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F4C0 RID: 62656 RVA: 0x0023B9CC File Offset: 0x00239BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F4C1 RID: 62657 RVA: 0x0023B9D9 File Offset: 0x00239BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F4C2 RID: 62658 RVA: 0x0023B9E2 File Offset: 0x00239BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.chapter_.WriteTo(ref output, NewbieAdventureV2Pb._repeated_chapter_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F4C3 RID: 62659 RVA: 0x0023BA0C File Offset: 0x00239C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.chapter_.CalculateSize(NewbieAdventureV2Pb._repeated_chapter_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F4C4 RID: 62660 RVA: 0x0023BA45 File Offset: 0x00239C45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieAdventureV2Pb other)
		{
			if (other == null)
			{
				return;
			}
			this.chapter_.Add(other.chapter_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F4C5 RID: 62661 RVA: 0x0023BA73 File Offset: 0x00239C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F4C6 RID: 62662 RVA: 0x0023BA7C File Offset: 0x00239C7C
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.chapter_.AddEntriesFrom(ref input, NewbieAdventureV2Pb._repeated_chapter_codec);
				}
			}
		}

		// Token: 0x04006283 RID: 25219
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006284 RID: 25220
		public const int ChapterFieldNumber = 2;

		// Token: 0x04006285 RID: 25221
		private static readonly FieldCodec<NewbieAdventureV2ChapterPb> _repeated_chapter_codec = FieldCodec.ForMessage<NewbieAdventureV2ChapterPb>(18U, NewbieAdventureV2ChapterPb.Parser);

		// Token: 0x04006286 RID: 25222
		private readonly RepeatedField<NewbieAdventureV2ChapterPb> chapter_ = new RepeatedField<NewbieAdventureV2ChapterPb>();
	}
}
