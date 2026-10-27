using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D2A RID: 3370
	[NetMessage(EMessageId.PhotoFightLevelInfoNotify)]
	public sealed class PhotoFightLevelInfoNotify : IMessage<PhotoFightLevelInfoNotify>, IMessage, IEquatable<PhotoFightLevelInfoNotify>, IDeepCloneable<PhotoFightLevelInfoNotify>, IBufferMessage
	{
		// Token: 0x06012326 RID: 74534 RVA: 0x002A8576 File Offset: 0x002A6776
		[NullableContext(1)]
		public static PhotoFightLevelInfoNotify Create()
		{
			return new PhotoFightLevelInfoNotify();
		}

		// Token: 0x17003C4C RID: 15436
		// (get) Token: 0x06012327 RID: 74535 RVA: 0x002A857D File Offset: 0x002A677D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C4D RID: 15437
		// (get) Token: 0x06012328 RID: 74536 RVA: 0x002A8580 File Offset: 0x002A6780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightLevelInfoNotify.Descriptor;
			}
		}

		// Token: 0x06012329 RID: 74537 RVA: 0x002A8587 File Offset: 0x002A6787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightLevelInfoNotify()
		{
		}

		// Token: 0x0601232A RID: 74538 RVA: 0x002A859A File Offset: 0x002A679A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightLevelInfoNotify(PhotoFightLevelInfoNotify other) : this()
		{
			this.photoFightLevelInfos_ = other.photoFightLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601232B RID: 74539 RVA: 0x002A85C4 File Offset: 0x002A67C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightLevelInfoNotify Clone()
		{
			return new PhotoFightLevelInfoNotify(this);
		}

		// Token: 0x17003C4E RID: 15438
		// (get) Token: 0x0601232C RID: 74540 RVA: 0x002A85CC File Offset: 0x002A67CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhotoFightLevelPb> PhotoFightLevelInfos
		{
			get
			{
				return this.photoFightLevelInfos_;
			}
		}

		// Token: 0x0601232D RID: 74541 RVA: 0x002A85D4 File Offset: 0x002A67D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightLevelInfoNotify);
		}

		// Token: 0x0601232E RID: 74542 RVA: 0x002A85E2 File Offset: 0x002A67E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightLevelInfoNotify other)
		{
			return other != null && (other == this || (this.photoFightLevelInfos_.Equals(other.photoFightLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601232F RID: 74543 RVA: 0x002A8618 File Offset: 0x002A6818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.photoFightLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012330 RID: 74544 RVA: 0x002A864C File Offset: 0x002A684C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012331 RID: 74545 RVA: 0x002A8659 File Offset: 0x002A6859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012332 RID: 74546 RVA: 0x002A8662 File Offset: 0x002A6862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.photoFightLevelInfos_.WriteTo(ref output, PhotoFightLevelInfoNotify._repeated_photoFightLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012333 RID: 74547 RVA: 0x002A868C File Offset: 0x002A688C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.photoFightLevelInfos_.CalculateSize(PhotoFightLevelInfoNotify._repeated_photoFightLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012334 RID: 74548 RVA: 0x002A86C5 File Offset: 0x002A68C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoFightLevelInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.photoFightLevelInfos_.Add(other.photoFightLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012335 RID: 74549 RVA: 0x002A86F3 File Offset: 0x002A68F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012336 RID: 74550 RVA: 0x002A86FC File Offset: 0x002A68FC
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
					this.photoFightLevelInfos_.AddEntriesFrom(ref input, PhotoFightLevelInfoNotify._repeated_photoFightLevelInfos_codec);
				}
			}
		}

		// Token: 0x040071A3 RID: 29091
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071A4 RID: 29092
		public const int PhotoFightLevelInfosFieldNumber = 2;

		// Token: 0x040071A5 RID: 29093
		private static readonly FieldCodec<PhotoFightLevelPb> _repeated_photoFightLevelInfos_codec = FieldCodec.ForMessage<PhotoFightLevelPb>(18U, PhotoFightLevelPb.Parser);

		// Token: 0x040071A6 RID: 29094
		private readonly RepeatedField<PhotoFightLevelPb> photoFightLevelInfos_ = new RepeatedField<PhotoFightLevelPb>();
	}
}
