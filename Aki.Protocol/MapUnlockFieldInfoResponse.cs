using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A8 RID: 2472
	[NetMessage(EMessageId.MapUnlockFieldInfoResponse)]
	public sealed class MapUnlockFieldInfoResponse : IMessage<MapUnlockFieldInfoResponse>, IMessage, IEquatable<MapUnlockFieldInfoResponse>, IDeepCloneable<MapUnlockFieldInfoResponse>, IBufferMessage
	{
		// Token: 0x0600D8F9 RID: 55545 RVA: 0x001FDD82 File Offset: 0x001FBF82
		[NullableContext(1)]
		public static MapUnlockFieldInfoResponse Create()
		{
			return new MapUnlockFieldInfoResponse();
		}

		// Token: 0x17002BEB RID: 11243
		// (get) Token: 0x0600D8FA RID: 55546 RVA: 0x001FDD89 File Offset: 0x001FBF89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BEC RID: 11244
		// (get) Token: 0x0600D8FB RID: 55547 RVA: 0x001FDD8C File Offset: 0x001FBF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapUnlockFieldInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600D8FC RID: 55548 RVA: 0x001FDD93 File Offset: 0x001FBF93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapUnlockFieldInfoResponse()
		{
		}

		// Token: 0x0600D8FD RID: 55549 RVA: 0x001FDDA6 File Offset: 0x001FBFA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapUnlockFieldInfoResponse(MapUnlockFieldInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.fieldId_ = other.fieldId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D8FE RID: 55550 RVA: 0x001FDDDC File Offset: 0x001FBFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapUnlockFieldInfoResponse Clone()
		{
			return new MapUnlockFieldInfoResponse(this);
		}

		// Token: 0x17002BED RID: 11245
		// (get) Token: 0x0600D8FF RID: 55551 RVA: 0x001FDDE4 File Offset: 0x001FBFE4
		// (set) Token: 0x0600D900 RID: 55552 RVA: 0x001FDDEC File Offset: 0x001FBFEC
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

		// Token: 0x17002BEE RID: 11246
		// (get) Token: 0x0600D901 RID: 55553 RVA: 0x001FDDF5 File Offset: 0x001FBFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FieldId
		{
			get
			{
				return this.fieldId_;
			}
		}

		// Token: 0x0600D902 RID: 55554 RVA: 0x001FDDFD File Offset: 0x001FBFFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapUnlockFieldInfoResponse);
		}

		// Token: 0x0600D903 RID: 55555 RVA: 0x001FDE0C File Offset: 0x001FC00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapUnlockFieldInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.fieldId_.Equals(other.fieldId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D904 RID: 55556 RVA: 0x001FDE5C File Offset: 0x001FC05C
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

		// Token: 0x0600D905 RID: 55557 RVA: 0x001FDEAF File Offset: 0x001FC0AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D906 RID: 55558 RVA: 0x001FDEBC File Offset: 0x001FC0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D907 RID: 55559 RVA: 0x001FDEC8 File Offset: 0x001FC0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.fieldId_.WriteTo(ref output, MapUnlockFieldInfoResponse._repeated_fieldId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D908 RID: 55560 RVA: 0x001FDF18 File Offset: 0x001FC118
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

		// Token: 0x0600D909 RID: 55561 RVA: 0x001FDF6C File Offset: 0x001FC16C
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

		// Token: 0x0600D90A RID: 55562 RVA: 0x001FDFB9 File Offset: 0x001FC1B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D90B RID: 55563 RVA: 0x001FDFC4 File Offset: 0x001FC1C4
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
				if (num != 32U)
				{
					if (num != 112U && num != 114U)
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

		// Token: 0x04005A45 RID: 23109
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A46 RID: 23110
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04005A47 RID: 23111
		private ErrorCode errorCode_;

		// Token: 0x04005A48 RID: 23112
		public const int FieldIdFieldNumber = 14;

		// Token: 0x04005A49 RID: 23113
		private static readonly FieldCodec<int> _repeated_fieldId_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04005A4A RID: 23114
		private readonly RepeatedField<int> fieldId_ = new RepeatedField<int>();
	}
}
