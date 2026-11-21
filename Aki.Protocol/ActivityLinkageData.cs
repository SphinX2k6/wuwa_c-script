using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000088 RID: 136
	public sealed class ActivityLinkageData : IMessage<ActivityLinkageData>, IMessage, IEquatable<ActivityLinkageData>, IDeepCloneable<ActivityLinkageData>, IBufferMessage
	{
		// Token: 0x06001A8C RID: 6796 RVA: 0x0004B0FD File Offset: 0x000492FD
		[NullableContext(1)]
		public static ActivityLinkageData Create()
		{
			return new ActivityLinkageData();
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06001A8D RID: 6797 RVA: 0x0004B104 File Offset: 0x00049304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06001A8E RID: 6798 RVA: 0x0004B107 File Offset: 0x00049307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityLinkageData.Descriptor;
			}
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x0004B10E File Offset: 0x0004930E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityLinkageData()
		{
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x0004B121 File Offset: 0x00049321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityLinkageData(ActivityLinkageData other) : this()
		{
			this.activityId_ = other.activityId_;
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x0004B157 File Offset: 0x00049357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityLinkageData Clone()
		{
			return new ActivityLinkageData(this);
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06001A92 RID: 6802 RVA: 0x0004B15F File Offset: 0x0004935F
		// (set) Token: 0x06001A93 RID: 6803 RVA: 0x0004B167 File Offset: 0x00049367
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

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06001A94 RID: 6804 RVA: 0x0004B170 File Offset: 0x00049370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityLinkagePageData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x0004B178 File Offset: 0x00049378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityLinkageData);
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x0004B188 File Offset: 0x00049388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityLinkageData other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.data_.Equals(other.data_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x0004B1D8 File Offset: 0x000493D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.data_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x0004B225 File Offset: 0x00049425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x0004B232 File Offset: 0x00049432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x0004B23C File Offset: 0x0004943C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			this.data_.WriteTo(ref output, ActivityLinkageData._repeated_data_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x0004B28C File Offset: 0x0004948C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.data_.CalculateSize(ActivityLinkageData._repeated_data_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x0004B2E0 File Offset: 0x000494E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityLinkageData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.data_.Add(other.data_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x0004B32D File Offset: 0x0004952D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x0004B338 File Offset: 0x00049538
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.data_.AddEntriesFrom(ref input, ActivityLinkageData._repeated_data_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040022A4 RID: 8868
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022A5 RID: 8869
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x040022A6 RID: 8870
		private int activityId_;

		// Token: 0x040022A7 RID: 8871
		public const int DataFieldNumber = 2;

		// Token: 0x040022A8 RID: 8872
		private static readonly FieldCodec<ActivityLinkagePageData> _repeated_data_codec = FieldCodec.ForMessage<ActivityLinkagePageData>(18U, ActivityLinkagePageData.Parser);

		// Token: 0x040022A9 RID: 8873
		private readonly RepeatedField<ActivityLinkagePageData> data_ = new RepeatedField<ActivityLinkagePageData>();
	}
}
