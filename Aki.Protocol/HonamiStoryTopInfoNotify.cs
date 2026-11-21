using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000795 RID: 1941
	[NetMessage(EMessageId.HonamiStoryTopInfoNotify)]
	public sealed class HonamiStoryTopInfoNotify : IMessage<HonamiStoryTopInfoNotify>, IMessage, IEquatable<HonamiStoryTopInfoNotify>, IDeepCloneable<HonamiStoryTopInfoNotify>, IBufferMessage
	{
		// Token: 0x0600AF61 RID: 44897 RVA: 0x001A5153 File Offset: 0x001A3353
		[NullableContext(1)]
		public static HonamiStoryTopInfoNotify Create()
		{
			return new HonamiStoryTopInfoNotify();
		}

		// Token: 0x1700235D RID: 9053
		// (get) Token: 0x0600AF62 RID: 44898 RVA: 0x001A515A File Offset: 0x001A335A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700235E RID: 9054
		// (get) Token: 0x0600AF63 RID: 44899 RVA: 0x001A515D File Offset: 0x001A335D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryTopInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600AF64 RID: 44900 RVA: 0x001A5164 File Offset: 0x001A3364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTopInfoNotify()
		{
		}

		// Token: 0x0600AF65 RID: 44901 RVA: 0x001A5177 File Offset: 0x001A3377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTopInfoNotify(HonamiStoryTopInfoNotify other) : this()
		{
			this.honamiStoryTopInfos_ = other.honamiStoryTopInfos_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF66 RID: 44902 RVA: 0x001A51AD File Offset: 0x001A33AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTopInfoNotify Clone()
		{
			return new HonamiStoryTopInfoNotify(this);
		}

		// Token: 0x1700235F RID: 9055
		// (get) Token: 0x0600AF67 RID: 44903 RVA: 0x001A51B5 File Offset: 0x001A33B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryTopInfo> HonamiStoryTopInfos
		{
			get
			{
				return this.honamiStoryTopInfos_;
			}
		}

		// Token: 0x17002360 RID: 9056
		// (get) Token: 0x0600AF68 RID: 44904 RVA: 0x001A51BD File Offset: 0x001A33BD
		// (set) Token: 0x0600AF69 RID: 44905 RVA: 0x001A51C5 File Offset: 0x001A33C5
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

		// Token: 0x0600AF6A RID: 44906 RVA: 0x001A51CE File Offset: 0x001A33CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryTopInfoNotify);
		}

		// Token: 0x0600AF6B RID: 44907 RVA: 0x001A51DC File Offset: 0x001A33DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryTopInfoNotify other)
		{
			return other != null && (other == this || (this.honamiStoryTopInfos_.Equals(other.honamiStoryTopInfos_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF6C RID: 44908 RVA: 0x001A522C File Offset: 0x001A342C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.honamiStoryTopInfos_.GetHashCode();
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF6D RID: 44909 RVA: 0x001A5279 File Offset: 0x001A3479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AF6E RID: 44910 RVA: 0x001A5286 File Offset: 0x001A3486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF6F RID: 44911 RVA: 0x001A5290 File Offset: 0x001A3490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.honamiStoryTopInfos_.WriteTo(ref output, HonamiStoryTopInfoNotify._repeated_honamiStoryTopInfos_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF70 RID: 44912 RVA: 0x001A52E0 File Offset: 0x001A34E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.honamiStoryTopInfos_.CalculateSize(HonamiStoryTopInfoNotify._repeated_honamiStoryTopInfos_codec);
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF71 RID: 44913 RVA: 0x001A5334 File Offset: 0x001A3534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryTopInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.honamiStoryTopInfos_.Add(other.honamiStoryTopInfos_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AF72 RID: 44914 RVA: 0x001A5381 File Offset: 0x001A3581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF73 RID: 44915 RVA: 0x001A538C File Offset: 0x001A358C
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.honamiStoryTopInfos_.AddEntriesFrom(ref input, HonamiStoryTopInfoNotify._repeated_honamiStoryTopInfos_codec);
				}
			}
		}

		// Token: 0x04004F4E RID: 20302
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F4F RID: 20303
		public const int HonamiStoryTopInfosFieldNumber = 12;

		// Token: 0x04004F50 RID: 20304
		private static readonly FieldCodec<HonamiStoryTopInfo> _repeated_honamiStoryTopInfos_codec = FieldCodec.ForMessage<HonamiStoryTopInfo>(98U, HonamiStoryTopInfo.Parser);

		// Token: 0x04004F51 RID: 20305
		private readonly RepeatedField<HonamiStoryTopInfo> honamiStoryTopInfos_ = new RepeatedField<HonamiStoryTopInfo>();

		// Token: 0x04004F52 RID: 20306
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04004F53 RID: 20307
		private int activityId_;
	}
}
