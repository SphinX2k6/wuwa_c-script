using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200078E RID: 1934
	[NetMessage(EMessageId.HonamiStorySellItemRequest)]
	public sealed class HonamiStorySellItemRequest : IMessage<HonamiStorySellItemRequest>, IMessage, IEquatable<HonamiStorySellItemRequest>, IDeepCloneable<HonamiStorySellItemRequest>, IBufferMessage
	{
		// Token: 0x0600AECF RID: 44751 RVA: 0x001A3E3E File Offset: 0x001A203E
		[NullableContext(1)]
		public static HonamiStorySellItemRequest Create()
		{
			return new HonamiStorySellItemRequest();
		}

		// Token: 0x1700233E RID: 9022
		// (get) Token: 0x0600AED0 RID: 44752 RVA: 0x001A3E45 File Offset: 0x001A2045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700233F RID: 9023
		// (get) Token: 0x0600AED1 RID: 44753 RVA: 0x001A3E48 File Offset: 0x001A2048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStorySellItemRequest.Descriptor;
			}
		}

		// Token: 0x0600AED2 RID: 44754 RVA: 0x001A3E4F File Offset: 0x001A204F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySellItemRequest()
		{
		}

		// Token: 0x0600AED3 RID: 44755 RVA: 0x001A3E62 File Offset: 0x001A2062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySellItemRequest(HonamiStorySellItemRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.honamiStoryItemUidInfos_ = other.honamiStoryItemUidInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AED4 RID: 44756 RVA: 0x001A3E98 File Offset: 0x001A2098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySellItemRequest Clone()
		{
			return new HonamiStorySellItemRequest(this);
		}

		// Token: 0x17002340 RID: 9024
		// (get) Token: 0x0600AED5 RID: 44757 RVA: 0x001A3EA0 File Offset: 0x001A20A0
		// (set) Token: 0x0600AED6 RID: 44758 RVA: 0x001A3EA8 File Offset: 0x001A20A8
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

		// Token: 0x17002341 RID: 9025
		// (get) Token: 0x0600AED7 RID: 44759 RVA: 0x001A3EB1 File Offset: 0x001A20B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, HonamiStoryItemUidInfo> HonamiStoryItemUidInfos
		{
			get
			{
				return this.honamiStoryItemUidInfos_;
			}
		}

		// Token: 0x0600AED8 RID: 44760 RVA: 0x001A3EB9 File Offset: 0x001A20B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStorySellItemRequest);
		}

		// Token: 0x0600AED9 RID: 44761 RVA: 0x001A3EC8 File Offset: 0x001A20C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStorySellItemRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.HonamiStoryItemUidInfos.Equals(other.HonamiStoryItemUidInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AEDA RID: 44762 RVA: 0x001A3F18 File Offset: 0x001A2118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.HonamiStoryItemUidInfos.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AEDB RID: 44763 RVA: 0x001A3F65 File Offset: 0x001A2165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AEDC RID: 44764 RVA: 0x001A3F72 File Offset: 0x001A2172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AEDD RID: 44765 RVA: 0x001A3F7C File Offset: 0x001A217C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.honamiStoryItemUidInfos_.WriteTo(ref output, HonamiStorySellItemRequest._map_honamiStoryItemUidInfos_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AEDE RID: 44766 RVA: 0x001A3FCC File Offset: 0x001A21CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.honamiStoryItemUidInfos_.CalculateSize(HonamiStorySellItemRequest._map_honamiStoryItemUidInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AEDF RID: 44767 RVA: 0x001A4020 File Offset: 0x001A2220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStorySellItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.honamiStoryItemUidInfos_.MergeFrom(other.honamiStoryItemUidInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AEE0 RID: 44768 RVA: 0x001A406D File Offset: 0x001A226D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AEE1 RID: 44769 RVA: 0x001A4078 File Offset: 0x001A2278
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
				if (num != 74U)
				{
					if (num != 96U)
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
					this.honamiStoryItemUidInfos_.AddEntriesFrom(ref input, HonamiStorySellItemRequest._map_honamiStoryItemUidInfos_codec);
				}
			}
		}

		// Token: 0x04004F24 RID: 20260
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F25 RID: 20261
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x04004F26 RID: 20262
		private int activityId_;

		// Token: 0x04004F27 RID: 20263
		public const int HonamiStoryItemUidInfosFieldNumber = 9;

		// Token: 0x04004F28 RID: 20264
		private static readonly MapField<int, HonamiStoryItemUidInfo>.Codec _map_honamiStoryItemUidInfos_codec = new MapField<int, HonamiStoryItemUidInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<HonamiStoryItemUidInfo>(18U, HonamiStoryItemUidInfo.Parser), 74U);

		// Token: 0x04004F29 RID: 20265
		private readonly MapField<int, HonamiStoryItemUidInfo> honamiStoryItemUidInfos_ = new MapField<int, HonamiStoryItemUidInfo>();
	}
}
