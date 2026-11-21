using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AEE RID: 2798
	public sealed class NewbieAdventureV2Pb : IMessage<NewbieAdventureV2Pb>, IMessage, IEquatable<NewbieAdventureV2Pb>, IDeepCloneable<NewbieAdventureV2Pb>, IBufferMessage
	{
		// Token: 0x0600F39C RID: 62364 RVA: 0x002396EB File Offset: 0x002378EB
		[NullableContext(1)]
		public static NewbieAdventureV2Pb Create()
		{
			return new NewbieAdventureV2Pb();
		}

		// Token: 0x1700319C RID: 12700
		// (get) Token: 0x0600F39D RID: 62365 RVA: 0x002396F2 File Offset: 0x002378F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700319D RID: 12701
		// (get) Token: 0x0600F39E RID: 62366 RVA: 0x002396F5 File Offset: 0x002378F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieAdventureV2Pb.Descriptor;
			}
		}

		// Token: 0x0600F39F RID: 62367 RVA: 0x002396FC File Offset: 0x002378FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureV2Pb()
		{
		}

		// Token: 0x0600F3A0 RID: 62368 RVA: 0x0023970F File Offset: 0x0023790F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureV2Pb(NewbieAdventureV2Pb other) : this()
		{
			this.chapter_ = other.chapter_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F3A1 RID: 62369 RVA: 0x00239739 File Offset: 0x00237939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureV2Pb Clone()
		{
			return new NewbieAdventureV2Pb(this);
		}

		// Token: 0x1700319E RID: 12702
		// (get) Token: 0x0600F3A2 RID: 62370 RVA: 0x00239741 File Offset: 0x00237941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewbieAdventureV2ChapterPb> Chapter
		{
			get
			{
				return this.chapter_;
			}
		}

		// Token: 0x0600F3A3 RID: 62371 RVA: 0x00239749 File Offset: 0x00237949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieAdventureV2Pb);
		}

		// Token: 0x0600F3A4 RID: 62372 RVA: 0x00239757 File Offset: 0x00237957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieAdventureV2Pb other)
		{
			return other != null && (other == this || (this.chapter_.Equals(other.chapter_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F3A5 RID: 62373 RVA: 0x0023978C File Offset: 0x0023798C
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

		// Token: 0x0600F3A6 RID: 62374 RVA: 0x002397C0 File Offset: 0x002379C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F3A7 RID: 62375 RVA: 0x002397CD File Offset: 0x002379CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F3A8 RID: 62376 RVA: 0x002397D6 File Offset: 0x002379D6
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

		// Token: 0x0600F3A9 RID: 62377 RVA: 0x00239800 File Offset: 0x00237A00
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

		// Token: 0x0600F3AA RID: 62378 RVA: 0x00239839 File Offset: 0x00237A39
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

		// Token: 0x0600F3AB RID: 62379 RVA: 0x00239867 File Offset: 0x00237A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F3AC RID: 62380 RVA: 0x00239870 File Offset: 0x00237A70
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

		// Token: 0x0400628C RID: 25228
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400628D RID: 25229
		public const int ChapterFieldNumber = 2;

		// Token: 0x0400628E RID: 25230
		private static readonly FieldCodec<NewbieAdventureV2ChapterPb> _repeated_chapter_codec = FieldCodec.ForMessage<NewbieAdventureV2ChapterPb>(18U, NewbieAdventureV2ChapterPb.Parser);

		// Token: 0x0400628F RID: 25231
		private readonly RepeatedField<NewbieAdventureV2ChapterPb> chapter_ = new RepeatedField<NewbieAdventureV2ChapterPb>();
	}
}
