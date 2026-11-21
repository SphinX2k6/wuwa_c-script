using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001453 RID: 5203
	[NetMessage(EMessageId.TrackMoonBuildingDataResponse)]
	public sealed class TrackMoonBuildingDataResponse : IMessage<TrackMoonBuildingDataResponse>, IMessage, IEquatable<TrackMoonBuildingDataResponse>, IDeepCloneable<TrackMoonBuildingDataResponse>, IBufferMessage
	{
		// Token: 0x0601BA1C RID: 113180 RVA: 0x00403862 File Offset: 0x00401A62
		[NullableContext(1)]
		public static TrackMoonBuildingDataResponse Create()
		{
			return new TrackMoonBuildingDataResponse();
		}

		// Token: 0x17005D82 RID: 23938
		// (get) Token: 0x0601BA1D RID: 113181 RVA: 0x00403869 File Offset: 0x00401A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D83 RID: 23939
		// (get) Token: 0x0601BA1E RID: 113182 RVA: 0x0040386C File Offset: 0x00401A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonBuildingDataResponse.Descriptor;
			}
		}

		// Token: 0x0601BA1F RID: 113183 RVA: 0x00403873 File Offset: 0x00401A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildingDataResponse()
		{
		}

		// Token: 0x0601BA20 RID: 113184 RVA: 0x00403886 File Offset: 0x00401A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildingDataResponse(TrackMoonBuildingDataResponse other) : this()
		{
			this.buildingInfos_ = other.buildingInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BA21 RID: 113185 RVA: 0x004038B0 File Offset: 0x00401AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildingDataResponse Clone()
		{
			return new TrackMoonBuildingDataResponse(this);
		}

		// Token: 0x17005D84 RID: 23940
		// (get) Token: 0x0601BA22 RID: 113186 RVA: 0x004038B8 File Offset: 0x00401AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BuildingInfo> BuildingInfos
		{
			get
			{
				return this.buildingInfos_;
			}
		}

		// Token: 0x0601BA23 RID: 113187 RVA: 0x004038C0 File Offset: 0x00401AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonBuildingDataResponse);
		}

		// Token: 0x0601BA24 RID: 113188 RVA: 0x004038CE File Offset: 0x00401ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonBuildingDataResponse other)
		{
			return other != null && (other == this || (this.buildingInfos_.Equals(other.buildingInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BA25 RID: 113189 RVA: 0x00403904 File Offset: 0x00401B04
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

		// Token: 0x0601BA26 RID: 113190 RVA: 0x00403938 File Offset: 0x00401B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BA27 RID: 113191 RVA: 0x00403945 File Offset: 0x00401B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BA28 RID: 113192 RVA: 0x0040394E File Offset: 0x00401B4E
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

		// Token: 0x0601BA29 RID: 113193 RVA: 0x00403978 File Offset: 0x00401B78
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

		// Token: 0x0601BA2A RID: 113194 RVA: 0x004039B1 File Offset: 0x00401BB1
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

		// Token: 0x0601BA2B RID: 113195 RVA: 0x004039DF File Offset: 0x00401BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BA2C RID: 113196 RVA: 0x004039E8 File Offset: 0x00401BE8
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.buildingInfos_.AddEntriesFrom(ref input, TrackMoonBuildingDataResponse._repeated_buildingInfos_codec);
				}
			}
		}

		// Token: 0x0400A086 RID: 41094
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A087 RID: 41095
		public const int BuildingInfosFieldNumber = 14;

		// Token: 0x0400A088 RID: 41096
		private static readonly FieldCodec<BuildingInfo> _repeated_buildingInfos_codec = FieldCodec.ForMessage<BuildingInfo>(114U, BuildingInfo.Parser);

		// Token: 0x0400A089 RID: 41097
		private readonly RepeatedField<BuildingInfo> buildingInfos_ = new RepeatedField<BuildingInfo>();
	}
}
