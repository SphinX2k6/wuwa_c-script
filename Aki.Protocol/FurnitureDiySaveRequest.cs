using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200066E RID: 1646
	[NetMessage(EMessageId.FurnitureDiySaveRequest)]
	public sealed class FurnitureDiySaveRequest : IMessage<FurnitureDiySaveRequest>, IMessage, IEquatable<FurnitureDiySaveRequest>, IDeepCloneable<FurnitureDiySaveRequest>, IBufferMessage
	{
		// Token: 0x06009738 RID: 38712 RVA: 0x0016CDEB File Offset: 0x0016AFEB
		[NullableContext(1)]
		public static FurnitureDiySaveRequest Create()
		{
			return new FurnitureDiySaveRequest();
		}

		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x06009739 RID: 38713 RVA: 0x0016CDF2 File Offset: 0x0016AFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x0600973A RID: 38714 RVA: 0x0016CDF5 File Offset: 0x0016AFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FurnitureDiySaveRequest.Descriptor;
			}
		}

		// Token: 0x0600973B RID: 38715 RVA: 0x0016CDFC File Offset: 0x0016AFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureDiySaveRequest()
		{
		}

		// Token: 0x0600973C RID: 38716 RVA: 0x0016CE10 File Offset: 0x0016B010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureDiySaveRequest(FurnitureDiySaveRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.areaId_ = other.areaId_;
			this.furnitureDiySlotInfos_ = other.furnitureDiySlotInfos_.Clone();
			this.isOneClickPreset_ = other.isOneClickPreset_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600973D RID: 38717 RVA: 0x0016CE69 File Offset: 0x0016B069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureDiySaveRequest Clone()
		{
			return new FurnitureDiySaveRequest(this);
		}

		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x0600973E RID: 38718 RVA: 0x0016CE71 File Offset: 0x0016B071
		// (set) Token: 0x0600973F RID: 38719 RVA: 0x0016CE79 File Offset: 0x0016B079
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

		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x06009740 RID: 38720 RVA: 0x0016CE82 File Offset: 0x0016B082
		// (set) Token: 0x06009741 RID: 38721 RVA: 0x0016CE8A File Offset: 0x0016B08A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x06009742 RID: 38722 RVA: 0x0016CE93 File Offset: 0x0016B093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FurnitureDiySlotInfo> FurnitureDiySlotInfos
		{
			get
			{
				return this.furnitureDiySlotInfos_;
			}
		}

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x06009743 RID: 38723 RVA: 0x0016CE9B File Offset: 0x0016B09B
		// (set) Token: 0x06009744 RID: 38724 RVA: 0x0016CEA3 File Offset: 0x0016B0A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOneClickPreset
		{
			get
			{
				return this.isOneClickPreset_;
			}
			set
			{
				this.isOneClickPreset_ = value;
			}
		}

		// Token: 0x06009745 RID: 38725 RVA: 0x0016CEAC File Offset: 0x0016B0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FurnitureDiySaveRequest);
		}

		// Token: 0x06009746 RID: 38726 RVA: 0x0016CEBC File Offset: 0x0016B0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FurnitureDiySaveRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.AreaId == other.AreaId && this.furnitureDiySlotInfos_.Equals(other.furnitureDiySlotInfos_) && this.IsOneClickPreset == other.IsOneClickPreset && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009747 RID: 38727 RVA: 0x0016CF2C File Offset: 0x0016B12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.AreaId != 0)
			{
				num ^= this.AreaId.GetHashCode();
			}
			num ^= this.furnitureDiySlotInfos_.GetHashCode();
			if (this.IsOneClickPreset)
			{
				num ^= this.IsOneClickPreset.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009748 RID: 38728 RVA: 0x0016CFAB File Offset: 0x0016B1AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009749 RID: 38729 RVA: 0x0016CFB8 File Offset: 0x0016B1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600974A RID: 38730 RVA: 0x0016CFC4 File Offset: 0x0016B1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsOneClickPreset)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsOneClickPreset);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			this.furnitureDiySlotInfos_.WriteTo(ref output, FurnitureDiySaveRequest._repeated_furnitureDiySlotInfos_codec);
			if (this.AreaId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600974B RID: 38731 RVA: 0x0016D04C File Offset: 0x0016B24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.AreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaId);
			}
			num += this.furnitureDiySlotInfos_.CalculateSize(FurnitureDiySaveRequest._repeated_furnitureDiySlotInfos_codec);
			if (this.IsOneClickPreset)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600974C RID: 38732 RVA: 0x0016D0C4 File Offset: 0x0016B2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FurnitureDiySaveRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.AreaId != 0)
			{
				this.AreaId = other.AreaId;
			}
			this.furnitureDiySlotInfos_.Add(other.furnitureDiySlotInfos_);
			if (other.IsOneClickPreset)
			{
				this.IsOneClickPreset = other.IsOneClickPreset;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600974D RID: 38733 RVA: 0x0016D139 File Offset: 0x0016B339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600974E RID: 38734 RVA: 0x0016D144 File Offset: 0x0016B344
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
				if (num <= 48U)
				{
					if (num == 40U)
					{
						this.IsOneClickPreset = input.ReadBool();
						continue;
					}
					if (num == 48U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.furnitureDiySlotInfos_.AddEntriesFrom(ref input, FurnitureDiySaveRequest._repeated_furnitureDiySlotInfos_codec);
						continue;
					}
					if (num == 96U)
					{
						this.AreaId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004842 RID: 18498
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004843 RID: 18499
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04004844 RID: 18500
		private int activityId_;

		// Token: 0x04004845 RID: 18501
		public const int AreaIdFieldNumber = 12;

		// Token: 0x04004846 RID: 18502
		private int areaId_;

		// Token: 0x04004847 RID: 18503
		public const int FurnitureDiySlotInfosFieldNumber = 11;

		// Token: 0x04004848 RID: 18504
		private static readonly FieldCodec<FurnitureDiySlotInfo> _repeated_furnitureDiySlotInfos_codec = FieldCodec.ForMessage<FurnitureDiySlotInfo>(90U, FurnitureDiySlotInfo.Parser);

		// Token: 0x04004849 RID: 18505
		private readonly RepeatedField<FurnitureDiySlotInfo> furnitureDiySlotInfos_ = new RepeatedField<FurnitureDiySlotInfo>();

		// Token: 0x0400484A RID: 18506
		public const int IsOneClickPresetFieldNumber = 5;

		// Token: 0x0400484B RID: 18507
		private bool isOneClickPreset_;
	}
}
