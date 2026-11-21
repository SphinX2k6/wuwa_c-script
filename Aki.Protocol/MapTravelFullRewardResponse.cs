using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200098E RID: 2446
	[NetMessage(EMessageId.MapTravelFullRewardResponse)]
	public sealed class MapTravelFullRewardResponse : IMessage<MapTravelFullRewardResponse>, IMessage, IEquatable<MapTravelFullRewardResponse>, IDeepCloneable<MapTravelFullRewardResponse>, IBufferMessage
	{
		// Token: 0x0600D735 RID: 55093 RVA: 0x001FA852 File Offset: 0x001F8A52
		[NullableContext(1)]
		public static MapTravelFullRewardResponse Create()
		{
			return new MapTravelFullRewardResponse();
		}

		// Token: 0x17002B8E RID: 11150
		// (get) Token: 0x0600D736 RID: 55094 RVA: 0x001FA859 File Offset: 0x001F8A59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B8F RID: 11151
		// (get) Token: 0x0600D737 RID: 55095 RVA: 0x001FA85C File Offset: 0x001F8A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelFullRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600D738 RID: 55096 RVA: 0x001FA863 File Offset: 0x001F8A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelFullRewardResponse()
		{
		}

		// Token: 0x0600D739 RID: 55097 RVA: 0x001FA86B File Offset: 0x001F8A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelFullRewardResponse(MapTravelFullRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D73A RID: 55098 RVA: 0x001FA890 File Offset: 0x001F8A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelFullRewardResponse Clone()
		{
			return new MapTravelFullRewardResponse(this);
		}

		// Token: 0x17002B90 RID: 11152
		// (get) Token: 0x0600D73B RID: 55099 RVA: 0x001FA898 File Offset: 0x001F8A98
		// (set) Token: 0x0600D73C RID: 55100 RVA: 0x001FA8A0 File Offset: 0x001F8AA0
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

		// Token: 0x0600D73D RID: 55101 RVA: 0x001FA8A9 File Offset: 0x001F8AA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelFullRewardResponse);
		}

		// Token: 0x0600D73E RID: 55102 RVA: 0x001FA8B7 File Offset: 0x001F8AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelFullRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D73F RID: 55103 RVA: 0x001FA8E8 File Offset: 0x001F8AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D740 RID: 55104 RVA: 0x001FA92D File Offset: 0x001F8B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D741 RID: 55105 RVA: 0x001FA93A File Offset: 0x001F8B3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D742 RID: 55106 RVA: 0x001FA943 File Offset: 0x001F8B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x0600D743 RID: 55107 RVA: 0x001FA978 File Offset: 0x001F8B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D744 RID: 55108 RVA: 0x001FA9B6 File Offset: 0x001F8BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTravelFullRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D745 RID: 55109 RVA: 0x001FA9E7 File Offset: 0x001F8BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D746 RID: 55110 RVA: 0x001FA9F0 File Offset: 0x001F8BF0
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005A33 RID: 23091
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A34 RID: 23092
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04005A35 RID: 23093
		private ErrorCode errorCode_;
	}
}
