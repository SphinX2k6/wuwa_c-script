using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000682 RID: 1666
	[NetMessage(EMessageId.FurnitureDiySaveRequest)]
	public sealed class FurnitureDiySaveRequest : IMessage<FurnitureDiySaveRequest>, IMessage, IEquatable<FurnitureDiySaveRequest>, IDeepCloneable<FurnitureDiySaveRequest>, IBufferMessage
	{
		// Token: 0x0600988E RID: 39054 RVA: 0x0016F81B File Offset: 0x0016DA1B
		[NullableContext(1)]
		public static FurnitureDiySaveRequest Create()
		{
			return new FurnitureDiySaveRequest();
		}

		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x0600988F RID: 39055 RVA: 0x0016F822 File Offset: 0x0016DA22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x06009890 RID: 39056 RVA: 0x0016F825 File Offset: 0x0016DA25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FurnitureDiySaveRequest.Descriptor;
			}
		}

		// Token: 0x06009891 RID: 39057 RVA: 0x0016F82C File Offset: 0x0016DA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureDiySaveRequest()
		{
		}

		// Token: 0x06009892 RID: 39058 RVA: 0x0016F840 File Offset: 0x0016DA40
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

		// Token: 0x06009893 RID: 39059 RVA: 0x0016F899 File Offset: 0x0016DA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureDiySaveRequest Clone()
		{
			return new FurnitureDiySaveRequest(this);
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x06009894 RID: 39060 RVA: 0x0016F8A1 File Offset: 0x0016DAA1
		// (set) Token: 0x06009895 RID: 39061 RVA: 0x0016F8A9 File Offset: 0x0016DAA9
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

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x06009896 RID: 39062 RVA: 0x0016F8B2 File Offset: 0x0016DAB2
		// (set) Token: 0x06009897 RID: 39063 RVA: 0x0016F8BA File Offset: 0x0016DABA
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

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x06009898 RID: 39064 RVA: 0x0016F8C3 File Offset: 0x0016DAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FurnitureDiySlotInfo> FurnitureDiySlotInfos
		{
			get
			{
				return this.furnitureDiySlotInfos_;
			}
		}

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x06009899 RID: 39065 RVA: 0x0016F8CB File Offset: 0x0016DACB
		// (set) Token: 0x0600989A RID: 39066 RVA: 0x0016F8D3 File Offset: 0x0016DAD3
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

		// Token: 0x0600989B RID: 39067 RVA: 0x0016F8DC File Offset: 0x0016DADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FurnitureDiySaveRequest);
		}

		// Token: 0x0600989C RID: 39068 RVA: 0x0016F8EC File Offset: 0x0016DAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FurnitureDiySaveRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.AreaId == other.AreaId && this.furnitureDiySlotInfos_.Equals(other.furnitureDiySlotInfos_) && this.IsOneClickPreset == other.IsOneClickPreset && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600989D RID: 39069 RVA: 0x0016F95C File Offset: 0x0016DB5C
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

		// Token: 0x0600989E RID: 39070 RVA: 0x0016F9DB File Offset: 0x0016DBDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600989F RID: 39071 RVA: 0x0016F9E8 File Offset: 0x0016DBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060098A0 RID: 39072 RVA: 0x0016F9F4 File Offset: 0x0016DBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsOneClickPreset)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsOneClickPreset);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			if (this.AreaId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.AreaId);
			}
			this.furnitureDiySlotInfos_.WriteTo(ref output, FurnitureDiySaveRequest._repeated_furnitureDiySlotInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060098A1 RID: 39073 RVA: 0x0016FA7C File Offset: 0x0016DC7C
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

		// Token: 0x060098A2 RID: 39074 RVA: 0x0016FAF4 File Offset: 0x0016DCF4
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

		// Token: 0x060098A3 RID: 39075 RVA: 0x0016FB69 File Offset: 0x0016DD69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060098A4 RID: 39076 RVA: 0x0016FB74 File Offset: 0x0016DD74
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
				if (num <= 64U)
				{
					if (num == 32U)
					{
						this.IsOneClickPreset = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.AreaId = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						this.furnitureDiySlotInfos_.AddEntriesFrom(ref input, FurnitureDiySaveRequest._repeated_furnitureDiySlotInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004849 RID: 18505
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400484A RID: 18506
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x0400484B RID: 18507
		private int activityId_;

		// Token: 0x0400484C RID: 18508
		public const int AreaIdFieldNumber = 12;

		// Token: 0x0400484D RID: 18509
		private int areaId_;

		// Token: 0x0400484E RID: 18510
		public const int FurnitureDiySlotInfosFieldNumber = 15;

		// Token: 0x0400484F RID: 18511
		private static readonly FieldCodec<FurnitureDiySlotInfo> _repeated_furnitureDiySlotInfos_codec = FieldCodec.ForMessage<FurnitureDiySlotInfo>(122U, FurnitureDiySlotInfo.Parser);

		// Token: 0x04004850 RID: 18512
		private readonly RepeatedField<FurnitureDiySlotInfo> furnitureDiySlotInfos_ = new RepeatedField<FurnitureDiySlotInfo>();

		// Token: 0x04004851 RID: 18513
		public const int IsOneClickPresetFieldNumber = 4;

		// Token: 0x04004852 RID: 18514
		private bool isOneClickPreset_;
	}
}
