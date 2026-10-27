using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A2 RID: 1954
	[NetMessage(EMessageId.HonamiStorySellItemRequest)]
	public sealed class HonamiStorySellItemRequest : IMessage<HonamiStorySellItemRequest>, IMessage, IEquatable<HonamiStorySellItemRequest>, IDeepCloneable<HonamiStorySellItemRequest>, IBufferMessage
	{
		// Token: 0x0600B025 RID: 45093 RVA: 0x001A686A File Offset: 0x001A4A6A
		[NullableContext(1)]
		public static HonamiStorySellItemRequest Create()
		{
			return new HonamiStorySellItemRequest();
		}

		// Token: 0x17002388 RID: 9096
		// (get) Token: 0x0600B026 RID: 45094 RVA: 0x001A6871 File Offset: 0x001A4A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002389 RID: 9097
		// (get) Token: 0x0600B027 RID: 45095 RVA: 0x001A6874 File Offset: 0x001A4A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStorySellItemRequest.Descriptor;
			}
		}

		// Token: 0x0600B028 RID: 45096 RVA: 0x001A687B File Offset: 0x001A4A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySellItemRequest()
		{
		}

		// Token: 0x0600B029 RID: 45097 RVA: 0x001A688E File Offset: 0x001A4A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySellItemRequest(HonamiStorySellItemRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.honamiStoryItemUidInfos_ = other.honamiStoryItemUidInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B02A RID: 45098 RVA: 0x001A68C4 File Offset: 0x001A4AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySellItemRequest Clone()
		{
			return new HonamiStorySellItemRequest(this);
		}

		// Token: 0x1700238A RID: 9098
		// (get) Token: 0x0600B02B RID: 45099 RVA: 0x001A68CC File Offset: 0x001A4ACC
		// (set) Token: 0x0600B02C RID: 45100 RVA: 0x001A68D4 File Offset: 0x001A4AD4
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

		// Token: 0x1700238B RID: 9099
		// (get) Token: 0x0600B02D RID: 45101 RVA: 0x001A68DD File Offset: 0x001A4ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, HonamiStoryItemUidInfo> HonamiStoryItemUidInfos
		{
			get
			{
				return this.honamiStoryItemUidInfos_;
			}
		}

		// Token: 0x0600B02E RID: 45102 RVA: 0x001A68E5 File Offset: 0x001A4AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStorySellItemRequest);
		}

		// Token: 0x0600B02F RID: 45103 RVA: 0x001A68F4 File Offset: 0x001A4AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStorySellItemRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.HonamiStoryItemUidInfos.Equals(other.HonamiStoryItemUidInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B030 RID: 45104 RVA: 0x001A6944 File Offset: 0x001A4B44
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

		// Token: 0x0600B031 RID: 45105 RVA: 0x001A6991 File Offset: 0x001A4B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B032 RID: 45106 RVA: 0x001A699E File Offset: 0x001A4B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B033 RID: 45107 RVA: 0x001A69A8 File Offset: 0x001A4BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.honamiStoryItemUidInfos_.WriteTo(ref output, HonamiStorySellItemRequest._map_honamiStoryItemUidInfos_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B034 RID: 45108 RVA: 0x001A69F8 File Offset: 0x001A4BF8
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

		// Token: 0x0600B035 RID: 45109 RVA: 0x001A6A4C File Offset: 0x001A4C4C
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

		// Token: 0x0600B036 RID: 45110 RVA: 0x001A6A99 File Offset: 0x001A4C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B037 RID: 45111 RVA: 0x001A6AA4 File Offset: 0x001A4CA4
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
				if (num != 10U)
				{
					if (num != 16U)
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

		// Token: 0x04004F2B RID: 20267
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F2C RID: 20268
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04004F2D RID: 20269
		private int activityId_;

		// Token: 0x04004F2E RID: 20270
		public const int HonamiStoryItemUidInfosFieldNumber = 1;

		// Token: 0x04004F2F RID: 20271
		private static readonly MapField<int, HonamiStoryItemUidInfo>.Codec _map_honamiStoryItemUidInfos_codec = new MapField<int, HonamiStoryItemUidInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<HonamiStoryItemUidInfo>(18U, HonamiStoryItemUidInfo.Parser), 10U);

		// Token: 0x04004F30 RID: 20272
		private readonly MapField<int, HonamiStoryItemUidInfo> honamiStoryItemUidInfos_ = new MapField<int, HonamiStoryItemUidInfo>();
	}
}
