using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A3 RID: 1955
	[NetMessage(EMessageId.HonamiStorySellItemResponse)]
	public sealed class HonamiStorySellItemResponse : IMessage<HonamiStorySellItemResponse>, IMessage, IEquatable<HonamiStorySellItemResponse>, IDeepCloneable<HonamiStorySellItemResponse>, IBufferMessage
	{
		// Token: 0x0600B039 RID: 45113 RVA: 0x001A6B22 File Offset: 0x001A4D22
		[NullableContext(1)]
		public static HonamiStorySellItemResponse Create()
		{
			return new HonamiStorySellItemResponse();
		}

		// Token: 0x1700238C RID: 9100
		// (get) Token: 0x0600B03A RID: 45114 RVA: 0x001A6B29 File Offset: 0x001A4D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700238D RID: 9101
		// (get) Token: 0x0600B03B RID: 45115 RVA: 0x001A6B2C File Offset: 0x001A4D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStorySellItemResponse.Descriptor;
			}
		}

		// Token: 0x0600B03C RID: 45116 RVA: 0x001A6B33 File Offset: 0x001A4D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySellItemResponse()
		{
		}

		// Token: 0x0600B03D RID: 45117 RVA: 0x001A6B48 File Offset: 0x001A4D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySellItemResponse(HonamiStorySellItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activityId_ = other.activityId_;
			this.honamiStoryItemUidInfos_ = other.honamiStoryItemUidInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B03E RID: 45118 RVA: 0x001A6B95 File Offset: 0x001A4D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySellItemResponse Clone()
		{
			return new HonamiStorySellItemResponse(this);
		}

		// Token: 0x1700238E RID: 9102
		// (get) Token: 0x0600B03F RID: 45119 RVA: 0x001A6B9D File Offset: 0x001A4D9D
		// (set) Token: 0x0600B040 RID: 45120 RVA: 0x001A6BA5 File Offset: 0x001A4DA5
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

		// Token: 0x1700238F RID: 9103
		// (get) Token: 0x0600B041 RID: 45121 RVA: 0x001A6BAE File Offset: 0x001A4DAE
		// (set) Token: 0x0600B042 RID: 45122 RVA: 0x001A6BB6 File Offset: 0x001A4DB6
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

		// Token: 0x17002390 RID: 9104
		// (get) Token: 0x0600B043 RID: 45123 RVA: 0x001A6BBF File Offset: 0x001A4DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, HonamiStoryItemUidInfo> HonamiStoryItemUidInfos
		{
			get
			{
				return this.honamiStoryItemUidInfos_;
			}
		}

		// Token: 0x0600B044 RID: 45124 RVA: 0x001A6BC7 File Offset: 0x001A4DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStorySellItemResponse);
		}

		// Token: 0x0600B045 RID: 45125 RVA: 0x001A6BD8 File Offset: 0x001A4DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStorySellItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && this.HonamiStoryItemUidInfos.Equals(other.HonamiStoryItemUidInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B046 RID: 45126 RVA: 0x001A6C38 File Offset: 0x001A4E38
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

		// Token: 0x0600B047 RID: 45127 RVA: 0x001A6CA4 File Offset: 0x001A4EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B048 RID: 45128 RVA: 0x001A6CB1 File Offset: 0x001A4EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B049 RID: 45129 RVA: 0x001A6CBC File Offset: 0x001A4EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			this.honamiStoryItemUidInfos_.WriteTo(ref output, HonamiStorySellItemResponse._map_honamiStoryItemUidInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B04A RID: 45130 RVA: 0x001A6D28 File Offset: 0x001A4F28
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

		// Token: 0x0600B04B RID: 45131 RVA: 0x001A6D94 File Offset: 0x001A4F94
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

		// Token: 0x0600B04C RID: 45132 RVA: 0x001A6DF5 File Offset: 0x001A4FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B04D RID: 45133 RVA: 0x001A6E00 File Offset: 0x001A5000
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
				if (num != 24U)
				{
					if (num != 34U)
					{
						if (num != 120U)
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

		// Token: 0x04004F31 RID: 20273
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F32 RID: 20274
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04004F33 RID: 20275
		private ErrorCode errorCode_;

		// Token: 0x04004F34 RID: 20276
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04004F35 RID: 20277
		private int activityId_;

		// Token: 0x04004F36 RID: 20278
		public const int HonamiStoryItemUidInfosFieldNumber = 4;

		// Token: 0x04004F37 RID: 20279
		private static readonly MapField<int, HonamiStoryItemUidInfo>.Codec _map_honamiStoryItemUidInfos_codec = new MapField<int, HonamiStoryItemUidInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<HonamiStoryItemUidInfo>(18U, HonamiStoryItemUidInfo.Parser), 34U);

		// Token: 0x04004F38 RID: 20280
		private readonly MapField<int, HonamiStoryItemUidInfo> honamiStoryItemUidInfos_ = new MapField<int, HonamiStoryItemUidInfo>();
	}
}
