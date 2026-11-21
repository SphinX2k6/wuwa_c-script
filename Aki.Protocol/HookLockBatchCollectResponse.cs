using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200079D RID: 1949
	[NetMessage(EMessageId.HookLockBatchCollectResponse)]
	public sealed class HookLockBatchCollectResponse : IMessage<HookLockBatchCollectResponse>, IMessage, IEquatable<HookLockBatchCollectResponse>, IDeepCloneable<HookLockBatchCollectResponse>, IBufferMessage
	{
		// Token: 0x0600B009 RID: 45065 RVA: 0x001A690D File Offset: 0x001A4B0D
		[NullableContext(1)]
		public static HookLockBatchCollectResponse Create()
		{
			return new HookLockBatchCollectResponse();
		}

		// Token: 0x17002381 RID: 9089
		// (get) Token: 0x0600B00A RID: 45066 RVA: 0x001A6914 File Offset: 0x001A4B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002382 RID: 9090
		// (get) Token: 0x0600B00B RID: 45067 RVA: 0x001A6917 File Offset: 0x001A4B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockBatchCollectResponse.Descriptor;
			}
		}

		// Token: 0x0600B00C RID: 45068 RVA: 0x001A691E File Offset: 0x001A4B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockBatchCollectResponse()
		{
		}

		// Token: 0x0600B00D RID: 45069 RVA: 0x001A6934 File Offset: 0x001A4B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockBatchCollectResponse(HookLockBatchCollectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.entityConfigId_ = other.entityConfigId_;
			this.successConfigIds_ = other.successConfigIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B00E RID: 45070 RVA: 0x001A6981 File Offset: 0x001A4B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockBatchCollectResponse Clone()
		{
			return new HookLockBatchCollectResponse(this);
		}

		// Token: 0x17002383 RID: 9091
		// (get) Token: 0x0600B00F RID: 45071 RVA: 0x001A6989 File Offset: 0x001A4B89
		// (set) Token: 0x0600B010 RID: 45072 RVA: 0x001A6991 File Offset: 0x001A4B91
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

		// Token: 0x17002384 RID: 9092
		// (get) Token: 0x0600B011 RID: 45073 RVA: 0x001A699A File Offset: 0x001A4B9A
		// (set) Token: 0x0600B012 RID: 45074 RVA: 0x001A69A2 File Offset: 0x001A4BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x17002385 RID: 9093
		// (get) Token: 0x0600B013 RID: 45075 RVA: 0x001A69AB File Offset: 0x001A4BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SuccessConfigIds
		{
			get
			{
				return this.successConfigIds_;
			}
		}

		// Token: 0x0600B014 RID: 45076 RVA: 0x001A69B3 File Offset: 0x001A4BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockBatchCollectResponse);
		}

		// Token: 0x0600B015 RID: 45077 RVA: 0x001A69C4 File Offset: 0x001A4BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockBatchCollectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EntityConfigId == other.EntityConfigId && this.successConfigIds_.Equals(other.successConfigIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B016 RID: 45078 RVA: 0x001A6A24 File Offset: 0x001A4C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			num ^= this.successConfigIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B017 RID: 45079 RVA: 0x001A6A90 File Offset: 0x001A4C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B018 RID: 45080 RVA: 0x001A6A9D File Offset: 0x001A4C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B019 RID: 45081 RVA: 0x001A6AA8 File Offset: 0x001A4CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.EntityConfigId);
			}
			this.successConfigIds_.WriteTo(ref output, HookLockBatchCollectResponse._repeated_successConfigIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B01A RID: 45082 RVA: 0x001A6B14 File Offset: 0x001A4D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			num += this.successConfigIds_.CalculateSize(HookLockBatchCollectResponse._repeated_successConfigIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B01B RID: 45083 RVA: 0x001A6B80 File Offset: 0x001A4D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HookLockBatchCollectResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			this.successConfigIds_.Add(other.successConfigIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B01C RID: 45084 RVA: 0x001A6BE1 File Offset: 0x001A4DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B01D RID: 45085 RVA: 0x001A6BEC File Offset: 0x001A4DEC
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
				if (num <= 48U)
				{
					if (num == 32U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 48U)
					{
						this.EntityConfigId = input.ReadInt32();
						continue;
					}
				}
				else if (num == 72U || num == 74U)
				{
					this.successConfigIds_.AddEntriesFrom(ref input, HookLockBatchCollectResponse._repeated_successConfigIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004F81 RID: 20353
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F82 RID: 20354
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04004F83 RID: 20355
		private ErrorCode errorCode_;

		// Token: 0x04004F84 RID: 20356
		public const int EntityConfigIdFieldNumber = 6;

		// Token: 0x04004F85 RID: 20357
		private int entityConfigId_;

		// Token: 0x04004F86 RID: 20358
		public const int SuccessConfigIdsFieldNumber = 9;

		// Token: 0x04004F87 RID: 20359
		private static readonly FieldCodec<int> _repeated_successConfigIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04004F88 RID: 20360
		private readonly RepeatedField<int> successConfigIds_ = new RepeatedField<int>();
	}
}
