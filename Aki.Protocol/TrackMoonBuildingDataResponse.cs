using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E0 RID: 5088
	[NetMessage(EMessageId.TrackMoonBuildingDataResponse)]
	public sealed class TrackMoonBuildingDataResponse : IMessage<TrackMoonBuildingDataResponse>, IMessage, IEquatable<TrackMoonBuildingDataResponse>, IDeepCloneable<TrackMoonBuildingDataResponse>, IBufferMessage
	{
		// Token: 0x0601AF91 RID: 110481 RVA: 0x003E8596 File Offset: 0x003E6796
		[NullableContext(1)]
		public static TrackMoonBuildingDataResponse Create()
		{
			return new TrackMoonBuildingDataResponse();
		}

		// Token: 0x17005AED RID: 23277
		// (get) Token: 0x0601AF92 RID: 110482 RVA: 0x003E859D File Offset: 0x003E679D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AEE RID: 23278
		// (get) Token: 0x0601AF93 RID: 110483 RVA: 0x003E85A0 File Offset: 0x003E67A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonBuildingDataResponse.Descriptor;
			}
		}

		// Token: 0x0601AF94 RID: 110484 RVA: 0x003E85A7 File Offset: 0x003E67A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildingDataResponse()
		{
		}

		// Token: 0x0601AF95 RID: 110485 RVA: 0x003E85BA File Offset: 0x003E67BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildingDataResponse(TrackMoonBuildingDataResponse other) : this()
		{
			this.buildingInfos_ = other.buildingInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AF96 RID: 110486 RVA: 0x003E85E4 File Offset: 0x003E67E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildingDataResponse Clone()
		{
			return new TrackMoonBuildingDataResponse(this);
		}

		// Token: 0x17005AEF RID: 23279
		// (get) Token: 0x0601AF97 RID: 110487 RVA: 0x003E85EC File Offset: 0x003E67EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BuildingInfo> BuildingInfos
		{
			get
			{
				return this.buildingInfos_;
			}
		}

		// Token: 0x0601AF98 RID: 110488 RVA: 0x003E85F4 File Offset: 0x003E67F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonBuildingDataResponse);
		}

		// Token: 0x0601AF99 RID: 110489 RVA: 0x003E8602 File Offset: 0x003E6802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonBuildingDataResponse other)
		{
			return other != null && (other == this || (this.buildingInfos_.Equals(other.buildingInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AF9A RID: 110490 RVA: 0x003E8638 File Offset: 0x003E6838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.buildingInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AF9B RID: 110491 RVA: 0x003E866C File Offset: 0x003E686C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AF9C RID: 110492 RVA: 0x003E8679 File Offset: 0x003E6879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AF9D RID: 110493 RVA: 0x003E8682 File Offset: 0x003E6882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buildingInfos_.WriteTo(ref output, TrackMoonBuildingDataResponse._repeated_buildingInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AF9E RID: 110494 RVA: 0x003E86AC File Offset: 0x003E68AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buildingInfos_.CalculateSize(TrackMoonBuildingDataResponse._repeated_buildingInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AF9F RID: 110495 RVA: 0x003E86E5 File Offset: 0x003E68E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonBuildingDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.buildingInfos_.Add(other.buildingInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AFA0 RID: 110496 RVA: 0x003E8713 File Offset: 0x003E6913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AFA1 RID: 110497 RVA: 0x003E871C File Offset: 0x003E691C
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
					this.buildingInfos_.AddEntriesFrom(ref input, TrackMoonBuildingDataResponse._repeated_buildingInfos_codec);
				}
			}
		}

		// Token: 0x04009C3F RID: 39999
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C40 RID: 40000
		public const int BuildingInfosFieldNumber = 12;

		// Token: 0x04009C41 RID: 40001
		private static readonly FieldCodec<BuildingInfo> _repeated_buildingInfos_codec = FieldCodec.ForMessage<BuildingInfo>(98U, BuildingInfo.Parser);

		// Token: 0x04009C42 RID: 40002
		private readonly RepeatedField<BuildingInfo> buildingInfos_ = new RepeatedField<BuildingInfo>();
	}
}
