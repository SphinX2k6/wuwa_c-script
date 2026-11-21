using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000997 RID: 2455
	[NetMessage(EMessageId.MapUnlockFieldInfoResponse)]
	public sealed class MapUnlockFieldInfoResponse : IMessage<MapUnlockFieldInfoResponse>, IMessage, IEquatable<MapUnlockFieldInfoResponse>, IDeepCloneable<MapUnlockFieldInfoResponse>, IBufferMessage
	{
		// Token: 0x0600D7DF RID: 55263 RVA: 0x001FBB8E File Offset: 0x001F9D8E
		[NullableContext(1)]
		public static MapUnlockFieldInfoResponse Create()
		{
			return new MapUnlockFieldInfoResponse();
		}

		// Token: 0x17002BAD RID: 11181
		// (get) Token: 0x0600D7E0 RID: 55264 RVA: 0x001FBB95 File Offset: 0x001F9D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BAE RID: 11182
		// (get) Token: 0x0600D7E1 RID: 55265 RVA: 0x001FBB98 File Offset: 0x001F9D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapUnlockFieldInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600D7E2 RID: 55266 RVA: 0x001FBB9F File Offset: 0x001F9D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapUnlockFieldInfoResponse()
		{
		}

		// Token: 0x0600D7E3 RID: 55267 RVA: 0x001FBBB2 File Offset: 0x001F9DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapUnlockFieldInfoResponse(MapUnlockFieldInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.fieldId_ = other.fieldId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D7E4 RID: 55268 RVA: 0x001FBBE8 File Offset: 0x001F9DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapUnlockFieldInfoResponse Clone()
		{
			return new MapUnlockFieldInfoResponse(this);
		}

		// Token: 0x17002BAF RID: 11183
		// (get) Token: 0x0600D7E5 RID: 55269 RVA: 0x001FBBF0 File Offset: 0x001F9DF0
		// (set) Token: 0x0600D7E6 RID: 55270 RVA: 0x001FBBF8 File Offset: 0x001F9DF8
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

		// Token: 0x17002BB0 RID: 11184
		// (get) Token: 0x0600D7E7 RID: 55271 RVA: 0x001FBC01 File Offset: 0x001F9E01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FieldId
		{
			get
			{
				return this.fieldId_;
			}
		}

		// Token: 0x0600D7E8 RID: 55272 RVA: 0x001FBC09 File Offset: 0x001F9E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapUnlockFieldInfoResponse);
		}

		// Token: 0x0600D7E9 RID: 55273 RVA: 0x001FBC18 File Offset: 0x001F9E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapUnlockFieldInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.fieldId_.Equals(other.fieldId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D7EA RID: 55274 RVA: 0x001FBC68 File Offset: 0x001F9E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.fieldId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D7EB RID: 55275 RVA: 0x001FBCBB File Offset: 0x001F9EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D7EC RID: 55276 RVA: 0x001FBCC8 File Offset: 0x001F9EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D7ED RID: 55277 RVA: 0x001FBCD4 File Offset: 0x001F9ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.fieldId_.WriteTo(ref output, MapUnlockFieldInfoResponse._repeated_fieldId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D7EE RID: 55278 RVA: 0x001FBD24 File Offset: 0x001F9F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.fieldId_.CalculateSize(MapUnlockFieldInfoResponse._repeated_fieldId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D7EF RID: 55279 RVA: 0x001FBD78 File Offset: 0x001F9F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapUnlockFieldInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.fieldId_.Add(other.fieldId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D7F0 RID: 55280 RVA: 0x001FBDC5 File Offset: 0x001F9FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D7F1 RID: 55281 RVA: 0x001FBDD0 File Offset: 0x001F9FD0
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
				if (num != 56U)
				{
					if (num != 80U && num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.fieldId_.AddEntriesFrom(ref input, MapUnlockFieldInfoResponse._repeated_fieldId_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005A4E RID: 23118
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A4F RID: 23119
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04005A50 RID: 23120
		private ErrorCode errorCode_;

		// Token: 0x04005A51 RID: 23121
		public const int FieldIdFieldNumber = 10;

		// Token: 0x04005A52 RID: 23122
		private static readonly FieldCodec<int> _repeated_fieldId_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04005A53 RID: 23123
		private readonly RepeatedField<int> fieldId_ = new RepeatedField<int>();
	}
}
