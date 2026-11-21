using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D1A RID: 3354
	[NetMessage(EMessageId.PhotoFightLevelInfoNotify)]
	public sealed class PhotoFightLevelInfoNotify : IMessage<PhotoFightLevelInfoNotify>, IMessage, IEquatable<PhotoFightLevelInfoNotify>, IDeepCloneable<PhotoFightLevelInfoNotify>, IBufferMessage
	{
		// Token: 0x0601222A RID: 74282 RVA: 0x002A6952 File Offset: 0x002A4B52
		[NullableContext(1)]
		public static PhotoFightLevelInfoNotify Create()
		{
			return new PhotoFightLevelInfoNotify();
		}

		// Token: 0x17003C17 RID: 15383
		// (get) Token: 0x0601222B RID: 74283 RVA: 0x002A6959 File Offset: 0x002A4B59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C18 RID: 15384
		// (get) Token: 0x0601222C RID: 74284 RVA: 0x002A695C File Offset: 0x002A4B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightLevelInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601222D RID: 74285 RVA: 0x002A6963 File Offset: 0x002A4B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightLevelInfoNotify()
		{
		}

		// Token: 0x0601222E RID: 74286 RVA: 0x002A6976 File Offset: 0x002A4B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightLevelInfoNotify(PhotoFightLevelInfoNotify other) : this()
		{
			this.photoFightLevelInfos_ = other.photoFightLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601222F RID: 74287 RVA: 0x002A69A0 File Offset: 0x002A4BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightLevelInfoNotify Clone()
		{
			return new PhotoFightLevelInfoNotify(this);
		}

		// Token: 0x17003C19 RID: 15385
		// (get) Token: 0x06012230 RID: 74288 RVA: 0x002A69A8 File Offset: 0x002A4BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhotoFightLevelPb> PhotoFightLevelInfos
		{
			get
			{
				return this.photoFightLevelInfos_;
			}
		}

		// Token: 0x06012231 RID: 74289 RVA: 0x002A69B0 File Offset: 0x002A4BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightLevelInfoNotify);
		}

		// Token: 0x06012232 RID: 74290 RVA: 0x002A69BE File Offset: 0x002A4BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightLevelInfoNotify other)
		{
			return other != null && (other == this || (this.photoFightLevelInfos_.Equals(other.photoFightLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012233 RID: 74291 RVA: 0x002A69F4 File Offset: 0x002A4BF4
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

		// Token: 0x06012234 RID: 74292 RVA: 0x002A6A28 File Offset: 0x002A4C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012235 RID: 74293 RVA: 0x002A6A35 File Offset: 0x002A4C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012236 RID: 74294 RVA: 0x002A6A3E File Offset: 0x002A4C3E
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

		// Token: 0x06012237 RID: 74295 RVA: 0x002A6A68 File Offset: 0x002A4C68
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

		// Token: 0x06012238 RID: 74296 RVA: 0x002A6AA1 File Offset: 0x002A4CA1
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

		// Token: 0x06012239 RID: 74297 RVA: 0x002A6ACF File Offset: 0x002A4CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601223A RID: 74298 RVA: 0x002A6AD8 File Offset: 0x002A4CD8
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.photoFightLevelInfos_.AddEntriesFrom(ref input, PhotoFightLevelInfoNotify._repeated_photoFightLevelInfos_codec);
				}
			}
		}

		// Token: 0x040071BB RID: 29115
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071BC RID: 29116
		public const int PhotoFightLevelInfosFieldNumber = 12;

		// Token: 0x040071BD RID: 29117
		private static readonly FieldCodec<PhotoFightLevelPb> _repeated_photoFightLevelInfos_codec = FieldCodec.ForMessage<PhotoFightLevelPb>(98U, PhotoFightLevelPb.Parser);

		// Token: 0x040071BE RID: 29118
		private readonly RepeatedField<PhotoFightLevelPb> photoFightLevelInfos_ = new RepeatedField<PhotoFightLevelPb>();
	}
}
