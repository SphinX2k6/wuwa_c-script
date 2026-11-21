using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012AC RID: 4780
	[NetMessage(EMessageId.SolarSchoolGalleryUpdateNotify)]
	public sealed class SolarSchoolGalleryUpdateNotify : IMessage<SolarSchoolGalleryUpdateNotify>, IMessage, IEquatable<SolarSchoolGalleryUpdateNotify>, IDeepCloneable<SolarSchoolGalleryUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601983F RID: 104511 RVA: 0x003B8DB3 File Offset: 0x003B6FB3
		[NullableContext(1)]
		public static SolarSchoolGalleryUpdateNotify Create()
		{
			return new SolarSchoolGalleryUpdateNotify();
		}

		// Token: 0x1700565A RID: 22106
		// (get) Token: 0x06019840 RID: 104512 RVA: 0x003B8DBA File Offset: 0x003B6FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700565B RID: 22107
		// (get) Token: 0x06019841 RID: 104513 RVA: 0x003B8DBD File Offset: 0x003B6FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolGalleryUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06019842 RID: 104514 RVA: 0x003B8DC4 File Offset: 0x003B6FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolGalleryUpdateNotify()
		{
		}

		// Token: 0x06019843 RID: 104515 RVA: 0x003B8DD8 File Offset: 0x003B6FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolGalleryUpdateNotify(SolarSchoolGalleryUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.gallery_ = other.gallery_.Clone();
			this.galleryEntryUnlocked_ = other.galleryEntryUnlocked_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019844 RID: 104516 RVA: 0x003B8E25 File Offset: 0x003B7025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolGalleryUpdateNotify Clone()
		{
			return new SolarSchoolGalleryUpdateNotify(this);
		}

		// Token: 0x1700565C RID: 22108
		// (get) Token: 0x06019845 RID: 104517 RVA: 0x003B8E2D File Offset: 0x003B702D
		// (set) Token: 0x06019846 RID: 104518 RVA: 0x003B8E35 File Offset: 0x003B7035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x1700565D RID: 22109
		// (get) Token: 0x06019847 RID: 104519 RVA: 0x003B8E3E File Offset: 0x003B703E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolGalleryPb> Gallery
		{
			get
			{
				return this.gallery_;
			}
		}

		// Token: 0x1700565E RID: 22110
		// (get) Token: 0x06019848 RID: 104520 RVA: 0x003B8E46 File Offset: 0x003B7046
		// (set) Token: 0x06019849 RID: 104521 RVA: 0x003B8E4E File Offset: 0x003B704E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GalleryEntryUnlocked
		{
			get
			{
				return this.galleryEntryUnlocked_;
			}
			set
			{
				this.galleryEntryUnlocked_ = value;
			}
		}

		// Token: 0x0601984A RID: 104522 RVA: 0x003B8E57 File Offset: 0x003B7057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolGalleryUpdateNotify);
		}

		// Token: 0x0601984B RID: 104523 RVA: 0x003B8E68 File Offset: 0x003B7068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolGalleryUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.gallery_.Equals(other.gallery_) && this.GalleryEntryUnlocked == other.GalleryEntryUnlocked && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601984C RID: 104524 RVA: 0x003B8EC8 File Offset: 0x003B70C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.gallery_.GetHashCode();
			if (this.GalleryEntryUnlocked)
			{
				num ^= this.GalleryEntryUnlocked.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601984D RID: 104525 RVA: 0x003B8F2E File Offset: 0x003B712E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601984E RID: 104526 RVA: 0x003B8F3B File Offset: 0x003B713B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601984F RID: 104527 RVA: 0x003B8F44 File Offset: 0x003B7144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this.GalleryEntryUnlocked)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.GalleryEntryUnlocked);
			}
			this.gallery_.WriteTo(ref output, SolarSchoolGalleryUpdateNotify._repeated_gallery_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019850 RID: 104528 RVA: 0x003B8FB0 File Offset: 0x003B71B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.gallery_.CalculateSize(SolarSchoolGalleryUpdateNotify._repeated_gallery_codec);
			if (this.GalleryEntryUnlocked)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019851 RID: 104529 RVA: 0x003B9010 File Offset: 0x003B7210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolGalleryUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.gallery_.Add(other.gallery_);
			if (other.GalleryEntryUnlocked)
			{
				this.GalleryEntryUnlocked = other.GalleryEntryUnlocked;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019852 RID: 104530 RVA: 0x003B9071 File Offset: 0x003B7271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019853 RID: 104531 RVA: 0x003B907C File Offset: 0x003B727C
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
				if (num != 40U)
				{
					if (num != 48U)
					{
						if (num != 58U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.gallery_.AddEntriesFrom(ref input, SolarSchoolGalleryUpdateNotify._repeated_gallery_codec);
						}
					}
					else
					{
						this.GalleryEntryUnlocked = input.ReadBool();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040096C9 RID: 38601
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096CA RID: 38602
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x040096CB RID: 38603
		private int activityId_;

		// Token: 0x040096CC RID: 38604
		public const int GalleryFieldNumber = 7;

		// Token: 0x040096CD RID: 38605
		private static readonly FieldCodec<SolarSchoolGalleryPb> _repeated_gallery_codec = FieldCodec.ForMessage<SolarSchoolGalleryPb>(58U, SolarSchoolGalleryPb.Parser);

		// Token: 0x040096CE RID: 38606
		private readonly RepeatedField<SolarSchoolGalleryPb> gallery_ = new RepeatedField<SolarSchoolGalleryPb>();

		// Token: 0x040096CF RID: 38607
		public const int GalleryEntryUnlockedFieldNumber = 6;

		// Token: 0x040096D0 RID: 38608
		private bool galleryEntryUnlocked_;
	}
}
