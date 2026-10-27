using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000999 RID: 2457
	[NetMessage(EMessageId.MapTraceInfoResponse)]
	public sealed class MapTraceInfoResponse : IMessage<MapTraceInfoResponse>, IMessage, IEquatable<MapTraceInfoResponse>, IDeepCloneable<MapTraceInfoResponse>, IBufferMessage
	{
		// Token: 0x0600D7DA RID: 55258 RVA: 0x001FBAAE File Offset: 0x001F9CAE
		[NullableContext(1)]
		public static MapTraceInfoResponse Create()
		{
			return new MapTraceInfoResponse();
		}

		// Token: 0x17002BB4 RID: 11188
		// (get) Token: 0x0600D7DB RID: 55259 RVA: 0x001FBAB5 File Offset: 0x001F9CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BB5 RID: 11189
		// (get) Token: 0x0600D7DC RID: 55260 RVA: 0x001FBAB8 File Offset: 0x001F9CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTraceInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600D7DD RID: 55261 RVA: 0x001FBABF File Offset: 0x001F9CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceInfoResponse()
		{
		}

		// Token: 0x0600D7DE RID: 55262 RVA: 0x001FBAD2 File Offset: 0x001F9CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceInfoResponse(MapTraceInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.markIdList_ = other.markIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D7DF RID: 55263 RVA: 0x001FBB08 File Offset: 0x001F9D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceInfoResponse Clone()
		{
			return new MapTraceInfoResponse(this);
		}

		// Token: 0x17002BB6 RID: 11190
		// (get) Token: 0x0600D7E0 RID: 55264 RVA: 0x001FBB10 File Offset: 0x001F9D10
		// (set) Token: 0x0600D7E1 RID: 55265 RVA: 0x001FBB18 File Offset: 0x001F9D18
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

		// Token: 0x17002BB7 RID: 11191
		// (get) Token: 0x0600D7E2 RID: 55266 RVA: 0x001FBB21 File Offset: 0x001F9D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MarkIdList
		{
			get
			{
				return this.markIdList_;
			}
		}

		// Token: 0x0600D7E3 RID: 55267 RVA: 0x001FBB29 File Offset: 0x001F9D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTraceInfoResponse);
		}

		// Token: 0x0600D7E4 RID: 55268 RVA: 0x001FBB38 File Offset: 0x001F9D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTraceInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.markIdList_.Equals(other.markIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D7E5 RID: 55269 RVA: 0x001FBB88 File Offset: 0x001F9D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.markIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D7E6 RID: 55270 RVA: 0x001FBBDB File Offset: 0x001F9DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D7E7 RID: 55271 RVA: 0x001FBBE8 File Offset: 0x001F9DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D7E8 RID: 55272 RVA: 0x001FBBF4 File Offset: 0x001F9DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.markIdList_.WriteTo(ref output, MapTraceInfoResponse._repeated_markIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D7E9 RID: 55273 RVA: 0x001FBC44 File Offset: 0x001F9E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.markIdList_.CalculateSize(MapTraceInfoResponse._repeated_markIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D7EA RID: 55274 RVA: 0x001FBC98 File Offset: 0x001F9E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTraceInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.markIdList_.Add(other.markIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D7EB RID: 55275 RVA: 0x001FBCE5 File Offset: 0x001F9EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D7EC RID: 55276 RVA: 0x001FBCF0 File Offset: 0x001F9EF0
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
				if (num != 40U)
				{
					if (num != 96U && num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.markIdList_.AddEntriesFrom(ref input, MapTraceInfoResponse._repeated_markIdList_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005A07 RID: 23047
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A08 RID: 23048
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04005A09 RID: 23049
		private ErrorCode errorCode_;

		// Token: 0x04005A0A RID: 23050
		public const int MarkIdListFieldNumber = 12;

		// Token: 0x04005A0B RID: 23051
		private static readonly FieldCodec<int> _repeated_markIdList_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04005A0C RID: 23052
		private readonly RepeatedField<int> markIdList_ = new RepeatedField<int>();
	}
}
