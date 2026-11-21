using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A0 RID: 4768
	public sealed class SolarSchoolActivityPb : IMessage<SolarSchoolActivityPb>, IMessage, IEquatable<SolarSchoolActivityPb>, IDeepCloneable<SolarSchoolActivityPb>, IBufferMessage
	{
		// Token: 0x06019728 RID: 104232 RVA: 0x003B604F File Offset: 0x003B424F
		[NullableContext(1)]
		public static SolarSchoolActivityPb Create()
		{
			return new SolarSchoolActivityPb();
		}

		// Token: 0x17005615 RID: 22037
		// (get) Token: 0x06019729 RID: 104233 RVA: 0x003B6056 File Offset: 0x003B4256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005616 RID: 22038
		// (get) Token: 0x0601972A RID: 104234 RVA: 0x003B6059 File Offset: 0x003B4259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolActivityPb.Descriptor;
			}
		}

		// Token: 0x0601972B RID: 104235 RVA: 0x003B6060 File Offset: 0x003B4260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolActivityPb()
		{
		}

		// Token: 0x0601972C RID: 104236 RVA: 0x003B608C File Offset: 0x003B428C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolActivityPb(SolarSchoolActivityPb other) : this()
		{
			this.taskType_ = other.taskType_.Clone();
			this.gallery_ = other.gallery_.Clone();
			this.savePreview_ = other.savePreview_.Clone();
			this.galleryEntryUnlocked_ = other.galleryEntryUnlocked_;
			this.limitTaskProgressRewarded_ = other.limitTaskProgressRewarded_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601972D RID: 104237 RVA: 0x003B60FB File Offset: 0x003B42FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolActivityPb Clone()
		{
			return new SolarSchoolActivityPb(this);
		}

		// Token: 0x17005617 RID: 22039
		// (get) Token: 0x0601972E RID: 104238 RVA: 0x003B6103 File Offset: 0x003B4303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolTaskTypePb> TaskType
		{
			get
			{
				return this.taskType_;
			}
		}

		// Token: 0x17005618 RID: 22040
		// (get) Token: 0x0601972F RID: 104239 RVA: 0x003B610B File Offset: 0x003B430B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolGalleryPb> Gallery
		{
			get
			{
				return this.gallery_;
			}
		}

		// Token: 0x17005619 RID: 22041
		// (get) Token: 0x06019730 RID: 104240 RVA: 0x003B6113 File Offset: 0x003B4313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolSavePreviewPb> SavePreview
		{
			get
			{
				return this.savePreview_;
			}
		}

		// Token: 0x1700561A RID: 22042
		// (get) Token: 0x06019731 RID: 104241 RVA: 0x003B611B File Offset: 0x003B431B
		// (set) Token: 0x06019732 RID: 104242 RVA: 0x003B6123 File Offset: 0x003B4323
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

		// Token: 0x1700561B RID: 22043
		// (get) Token: 0x06019733 RID: 104243 RVA: 0x003B612C File Offset: 0x003B432C
		// (set) Token: 0x06019734 RID: 104244 RVA: 0x003B6134 File Offset: 0x003B4334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LimitTaskProgressRewarded
		{
			get
			{
				return this.limitTaskProgressRewarded_;
			}
			set
			{
				this.limitTaskProgressRewarded_ = value;
			}
		}

		// Token: 0x06019735 RID: 104245 RVA: 0x003B613D File Offset: 0x003B433D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolActivityPb);
		}

		// Token: 0x06019736 RID: 104246 RVA: 0x003B614C File Offset: 0x003B434C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolActivityPb other)
		{
			return other != null && (other == this || (this.taskType_.Equals(other.taskType_) && this.gallery_.Equals(other.gallery_) && this.savePreview_.Equals(other.savePreview_) && this.GalleryEntryUnlocked == other.GalleryEntryUnlocked && this.LimitTaskProgressRewarded == other.LimitTaskProgressRewarded && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019737 RID: 104247 RVA: 0x003B61D4 File Offset: 0x003B43D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskType_.GetHashCode();
			num ^= this.gallery_.GetHashCode();
			num ^= this.savePreview_.GetHashCode();
			if (this.GalleryEntryUnlocked)
			{
				num ^= this.GalleryEntryUnlocked.GetHashCode();
			}
			if (this.LimitTaskProgressRewarded)
			{
				num ^= this.LimitTaskProgressRewarded.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019738 RID: 104248 RVA: 0x003B6256 File Offset: 0x003B4456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019739 RID: 104249 RVA: 0x003B6263 File Offset: 0x003B4463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601973A RID: 104250 RVA: 0x003B626C File Offset: 0x003B446C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskType_.WriteTo(ref output, SolarSchoolActivityPb._repeated_taskType_codec);
			this.gallery_.WriteTo(ref output, SolarSchoolActivityPb._repeated_gallery_codec);
			this.savePreview_.WriteTo(ref output, SolarSchoolActivityPb._repeated_savePreview_codec);
			if (this.GalleryEntryUnlocked)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.GalleryEntryUnlocked);
			}
			if (this.LimitTaskProgressRewarded)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.LimitTaskProgressRewarded);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601973B RID: 104251 RVA: 0x003B62F8 File Offset: 0x003B44F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskType_.CalculateSize(SolarSchoolActivityPb._repeated_taskType_codec);
			num += this.gallery_.CalculateSize(SolarSchoolActivityPb._repeated_gallery_codec);
			num += this.savePreview_.CalculateSize(SolarSchoolActivityPb._repeated_savePreview_codec);
			if (this.GalleryEntryUnlocked)
			{
				num += 2;
			}
			if (this.LimitTaskProgressRewarded)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601973C RID: 104252 RVA: 0x003B6370 File Offset: 0x003B4570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolActivityPb other)
		{
			if (other == null)
			{
				return;
			}
			this.taskType_.Add(other.taskType_);
			this.gallery_.Add(other.gallery_);
			this.savePreview_.Add(other.savePreview_);
			if (other.GalleryEntryUnlocked)
			{
				this.GalleryEntryUnlocked = other.GalleryEntryUnlocked;
			}
			if (other.LimitTaskProgressRewarded)
			{
				this.LimitTaskProgressRewarded = other.LimitTaskProgressRewarded;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601973D RID: 104253 RVA: 0x003B63F3 File Offset: 0x003B45F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601973E RID: 104254 RVA: 0x003B63FC File Offset: 0x003B45FC
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
				if (num <= 26U)
				{
					if (num == 18U)
					{
						this.taskType_.AddEntriesFrom(ref input, SolarSchoolActivityPb._repeated_taskType_codec);
						continue;
					}
					if (num == 26U)
					{
						this.gallery_.AddEntriesFrom(ref input, SolarSchoolActivityPb._repeated_gallery_codec);
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.savePreview_.AddEntriesFrom(ref input, SolarSchoolActivityPb._repeated_savePreview_codec);
						continue;
					}
					if (num == 40U)
					{
						this.GalleryEntryUnlocked = input.ReadBool();
						continue;
					}
					if (num == 48U)
					{
						this.LimitTaskProgressRewarded = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400966A RID: 38506
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400966B RID: 38507
		public const int TaskTypeFieldNumber = 2;

		// Token: 0x0400966C RID: 38508
		private static readonly FieldCodec<SolarSchoolTaskTypePb> _repeated_taskType_codec = FieldCodec.ForMessage<SolarSchoolTaskTypePb>(18U, SolarSchoolTaskTypePb.Parser);

		// Token: 0x0400966D RID: 38509
		private readonly RepeatedField<SolarSchoolTaskTypePb> taskType_ = new RepeatedField<SolarSchoolTaskTypePb>();

		// Token: 0x0400966E RID: 38510
		public const int GalleryFieldNumber = 3;

		// Token: 0x0400966F RID: 38511
		private static readonly FieldCodec<SolarSchoolGalleryPb> _repeated_gallery_codec = FieldCodec.ForMessage<SolarSchoolGalleryPb>(26U, SolarSchoolGalleryPb.Parser);

		// Token: 0x04009670 RID: 38512
		private readonly RepeatedField<SolarSchoolGalleryPb> gallery_ = new RepeatedField<SolarSchoolGalleryPb>();

		// Token: 0x04009671 RID: 38513
		public const int SavePreviewFieldNumber = 4;

		// Token: 0x04009672 RID: 38514
		private static readonly FieldCodec<SolarSchoolSavePreviewPb> _repeated_savePreview_codec = FieldCodec.ForMessage<SolarSchoolSavePreviewPb>(34U, SolarSchoolSavePreviewPb.Parser);

		// Token: 0x04009673 RID: 38515
		private readonly RepeatedField<SolarSchoolSavePreviewPb> savePreview_ = new RepeatedField<SolarSchoolSavePreviewPb>();

		// Token: 0x04009674 RID: 38516
		public const int GalleryEntryUnlockedFieldNumber = 5;

		// Token: 0x04009675 RID: 38517
		private bool galleryEntryUnlocked_;

		// Token: 0x04009676 RID: 38518
		public const int LimitTaskProgressRewardedFieldNumber = 6;

		// Token: 0x04009677 RID: 38519
		private bool limitTaskProgressRewarded_;
	}
}
