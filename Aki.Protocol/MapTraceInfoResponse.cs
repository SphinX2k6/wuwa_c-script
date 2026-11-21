using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000988 RID: 2440
	[NetMessage(EMessageId.MapTraceInfoResponse)]
	public sealed class MapTraceInfoResponse : IMessage<MapTraceInfoResponse>, IMessage, IEquatable<MapTraceInfoResponse>, IDeepCloneable<MapTraceInfoResponse>, IBufferMessage
	{
		// Token: 0x0600D6C0 RID: 54976 RVA: 0x001F98BE File Offset: 0x001F7ABE
		[NullableContext(1)]
		public static MapTraceInfoResponse Create()
		{
			return new MapTraceInfoResponse();
		}

		// Token: 0x17002B76 RID: 11126
		// (get) Token: 0x0600D6C1 RID: 54977 RVA: 0x001F98C5 File Offset: 0x001F7AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B77 RID: 11127
		// (get) Token: 0x0600D6C2 RID: 54978 RVA: 0x001F98C8 File Offset: 0x001F7AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTraceInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600D6C3 RID: 54979 RVA: 0x001F98CF File Offset: 0x001F7ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceInfoResponse()
		{
		}

		// Token: 0x0600D6C4 RID: 54980 RVA: 0x001F98E2 File Offset: 0x001F7AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceInfoResponse(MapTraceInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.markIdList_ = other.markIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D6C5 RID: 54981 RVA: 0x001F9918 File Offset: 0x001F7B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceInfoResponse Clone()
		{
			return new MapTraceInfoResponse(this);
		}

		// Token: 0x17002B78 RID: 11128
		// (get) Token: 0x0600D6C6 RID: 54982 RVA: 0x001F9920 File Offset: 0x001F7B20
		// (set) Token: 0x0600D6C7 RID: 54983 RVA: 0x001F9928 File Offset: 0x001F7B28
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

		// Token: 0x17002B79 RID: 11129
		// (get) Token: 0x0600D6C8 RID: 54984 RVA: 0x001F9931 File Offset: 0x001F7B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MarkIdList
		{
			get
			{
				return this.markIdList_;
			}
		}

		// Token: 0x0600D6C9 RID: 54985 RVA: 0x001F9939 File Offset: 0x001F7B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTraceInfoResponse);
		}

		// Token: 0x0600D6CA RID: 54986 RVA: 0x001F9948 File Offset: 0x001F7B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTraceInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.markIdList_.Equals(other.markIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D6CB RID: 54987 RVA: 0x001F9998 File Offset: 0x001F7B98
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

		// Token: 0x0600D6CC RID: 54988 RVA: 0x001F99EB File Offset: 0x001F7BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D6CD RID: 54989 RVA: 0x001F99F8 File Offset: 0x001F7BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D6CE RID: 54990 RVA: 0x001F9A04 File Offset: 0x001F7C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.markIdList_.WriteTo(ref output, MapTraceInfoResponse._repeated_markIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D6CF RID: 54991 RVA: 0x001F9A54 File Offset: 0x001F7C54
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

		// Token: 0x0600D6D0 RID: 54992 RVA: 0x001F9AA8 File Offset: 0x001F7CA8
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

		// Token: 0x0600D6D1 RID: 54993 RVA: 0x001F9AF5 File Offset: 0x001F7CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D6D2 RID: 54994 RVA: 0x001F9B00 File Offset: 0x001F7D00
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
					if (num != 40U && num != 42U)
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

		// Token: 0x04005A10 RID: 23056
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A11 RID: 23057
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005A12 RID: 23058
		private ErrorCode errorCode_;

		// Token: 0x04005A13 RID: 23059
		public const int MarkIdListFieldNumber = 5;

		// Token: 0x04005A14 RID: 23060
		private static readonly FieldCodec<int> _repeated_markIdList_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04005A15 RID: 23061
		private readonly RepeatedField<int> markIdList_ = new RepeatedField<int>();
	}
}
