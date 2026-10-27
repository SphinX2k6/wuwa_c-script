using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000087 RID: 135
	public sealed class ActivityLinkageData : IMessage<ActivityLinkageData>, IMessage, IEquatable<ActivityLinkageData>, IDeepCloneable<ActivityLinkageData>, IBufferMessage
	{
		// Token: 0x06001A45 RID: 6725 RVA: 0x0004A4ED File Offset: 0x000486ED
		[NullableContext(1)]
		public static ActivityLinkageData Create()
		{
			return new ActivityLinkageData();
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06001A46 RID: 6726 RVA: 0x0004A4F4 File Offset: 0x000486F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06001A47 RID: 6727 RVA: 0x0004A4F7 File Offset: 0x000486F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityLinkageData.Descriptor;
			}
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x0004A4FE File Offset: 0x000486FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityLinkageData()
		{
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0004A511 File Offset: 0x00048711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityLinkageData(ActivityLinkageData other) : this()
		{
			this.activityId_ = other.activityId_;
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x0004A547 File Offset: 0x00048747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityLinkageData Clone()
		{
			return new ActivityLinkageData(this);
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06001A4B RID: 6731 RVA: 0x0004A54F File Offset: 0x0004874F
		// (set) Token: 0x06001A4C RID: 6732 RVA: 0x0004A557 File Offset: 0x00048757
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

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06001A4D RID: 6733 RVA: 0x0004A560 File Offset: 0x00048760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityLinkagePageData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0004A568 File Offset: 0x00048768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityLinkageData);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0004A578 File Offset: 0x00048778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityLinkageData other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.data_.Equals(other.data_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0004A5C8 File Offset: 0x000487C8
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

		// Token: 0x06001A51 RID: 6737 RVA: 0x0004A615 File Offset: 0x00048815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x0004A622 File Offset: 0x00048822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x0004A62C File Offset: 0x0004882C
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

		// Token: 0x06001A54 RID: 6740 RVA: 0x0004A67C File Offset: 0x0004887C
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

		// Token: 0x06001A55 RID: 6741 RVA: 0x0004A6D0 File Offset: 0x000488D0
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

		// Token: 0x06001A56 RID: 6742 RVA: 0x0004A71D File Offset: 0x0004891D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x0004A728 File Offset: 0x00048928
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

		// Token: 0x04002243 RID: 8771
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002244 RID: 8772
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04002245 RID: 8773
		private int activityId_;

		// Token: 0x04002246 RID: 8774
		public const int DataFieldNumber = 2;

		// Token: 0x04002247 RID: 8775
		private static readonly FieldCodec<ActivityLinkagePageData> _repeated_data_codec = FieldCodec.ForMessage<ActivityLinkagePageData>(18U, ActivityLinkagePageData.Parser);

		// Token: 0x04002248 RID: 8776
		private readonly RepeatedField<ActivityLinkagePageData> data_ = new RepeatedField<ActivityLinkagePageData>();
	}
}
