using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200078F RID: 1935
	[NetMessage(EMessageId.HonamiStorySellItemResponse)]
	public sealed class HonamiStorySellItemResponse : IMessage<HonamiStorySellItemResponse>, IMessage, IEquatable<HonamiStorySellItemResponse>, IDeepCloneable<HonamiStorySellItemResponse>, IBufferMessage
	{
		// Token: 0x0600AEE3 RID: 44771 RVA: 0x001A40F6 File Offset: 0x001A22F6
		[NullableContext(1)]
		public static HonamiStorySellItemResponse Create()
		{
			return new HonamiStorySellItemResponse();
		}

		// Token: 0x17002342 RID: 9026
		// (get) Token: 0x0600AEE4 RID: 44772 RVA: 0x001A40FD File Offset: 0x001A22FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002343 RID: 9027
		// (get) Token: 0x0600AEE5 RID: 44773 RVA: 0x001A4100 File Offset: 0x001A2300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStorySellItemResponse.Descriptor;
			}
		}

		// Token: 0x0600AEE6 RID: 44774 RVA: 0x001A4107 File Offset: 0x001A2307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySellItemResponse()
		{
		}

		// Token: 0x0600AEE7 RID: 44775 RVA: 0x001A411C File Offset: 0x001A231C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySellItemResponse(HonamiStorySellItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activityId_ = other.activityId_;
			this.honamiStoryItemUidInfos_ = other.honamiStoryItemUidInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AEE8 RID: 44776 RVA: 0x001A4169 File Offset: 0x001A2369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySellItemResponse Clone()
		{
			return new HonamiStorySellItemResponse(this);
		}

		// Token: 0x17002344 RID: 9028
		// (get) Token: 0x0600AEE9 RID: 44777 RVA: 0x001A4171 File Offset: 0x001A2371
		// (set) Token: 0x0600AEEA RID: 44778 RVA: 0x001A4179 File Offset: 0x001A2379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17002345 RID: 9029
		// (get) Token: 0x0600AEEB RID: 44779 RVA: 0x001A4182 File Offset: 0x001A2382
		// (set) Token: 0x0600AEEC RID: 44780 RVA: 0x001A418A File Offset: 0x001A238A
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

		// Token: 0x17002346 RID: 9030
		// (get) Token: 0x0600AEED RID: 44781 RVA: 0x001A4193 File Offset: 0x001A2393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, HonamiStoryItemUidInfo> HonamiStoryItemUidInfos
		{
			get
			{
				return this.honamiStoryItemUidInfos_;
			}
		}

		// Token: 0x0600AEEE RID: 44782 RVA: 0x001A419B File Offset: 0x001A239B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStorySellItemResponse);
		}

		// Token: 0x0600AEEF RID: 44783 RVA: 0x001A41AC File Offset: 0x001A23AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStorySellItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && this.HonamiStoryItemUidInfos.Equals(other.HonamiStoryItemUidInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AEF0 RID: 44784 RVA: 0x001A420C File Offset: 0x001A240C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
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

		// Token: 0x0600AEF1 RID: 44785 RVA: 0x001A4278 File Offset: 0x001A2478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AEF2 RID: 44786 RVA: 0x001A4285 File Offset: 0x001A2485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AEF3 RID: 44787 RVA: 0x001A4290 File Offset: 0x001A2490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			this.honamiStoryItemUidInfos_.WriteTo(ref output, HonamiStorySellItemResponse._map_honamiStoryItemUidInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AEF4 RID: 44788 RVA: 0x001A42FC File Offset: 0x001A24FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.honamiStoryItemUidInfos_.CalculateSize(HonamiStorySellItemResponse._map_honamiStoryItemUidInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AEF5 RID: 44789 RVA: 0x001A4368 File Offset: 0x001A2568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStorySellItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.honamiStoryItemUidInfos_.MergeFrom(other.honamiStoryItemUidInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AEF6 RID: 44790 RVA: 0x001A43C9 File Offset: 0x001A25C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AEF7 RID: 44791 RVA: 0x001A43D4 File Offset: 0x001A25D4
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
				if (num != 16U)
				{
					if (num != 90U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.honamiStoryItemUidInfos_.AddEntriesFrom(ref input, HonamiStorySellItemResponse._map_honamiStoryItemUidInfos_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004F2A RID: 20266
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F2B RID: 20267
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04004F2C RID: 20268
		private ErrorCode errorCode_;

		// Token: 0x04004F2D RID: 20269
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04004F2E RID: 20270
		private int activityId_;

		// Token: 0x04004F2F RID: 20271
		public const int HonamiStoryItemUidInfosFieldNumber = 11;

		// Token: 0x04004F30 RID: 20272
		private static readonly MapField<int, HonamiStoryItemUidInfo>.Codec _map_honamiStoryItemUidInfos_codec = new MapField<int, HonamiStoryItemUidInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<HonamiStoryItemUidInfo>(18U, HonamiStoryItemUidInfo.Parser), 90U);

		// Token: 0x04004F31 RID: 20273
		private readonly MapField<int, HonamiStoryItemUidInfo> honamiStoryItemUidInfos_ = new MapField<int, HonamiStoryItemUidInfo>();
	}
}
