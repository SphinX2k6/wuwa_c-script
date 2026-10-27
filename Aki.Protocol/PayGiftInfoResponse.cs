using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BDD RID: 3037
	[NetMessage(EMessageId.PayGiftInfoResponse)]
	public sealed class PayGiftInfoResponse : IMessage<PayGiftInfoResponse>, IMessage, IEquatable<PayGiftInfoResponse>, IDeepCloneable<PayGiftInfoResponse>, IBufferMessage
	{
		// Token: 0x06010748 RID: 67400 RVA: 0x00266BED File Offset: 0x00264DED
		[NullableContext(1)]
		public static PayGiftInfoResponse Create()
		{
			return new PayGiftInfoResponse();
		}

		// Token: 0x17003605 RID: 13829
		// (get) Token: 0x06010749 RID: 67401 RVA: 0x00266BF4 File Offset: 0x00264DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003606 RID: 13830
		// (get) Token: 0x0601074A RID: 67402 RVA: 0x00266BF7 File Offset: 0x00264DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayGiftInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601074B RID: 67403 RVA: 0x00266BFE File Offset: 0x00264DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftInfoResponse()
		{
		}

		// Token: 0x0601074C RID: 67404 RVA: 0x00266C1C File Offset: 0x00264E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftInfoResponse(PayGiftInfoResponse other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this.version_ = other.version_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601074D RID: 67405 RVA: 0x00266C69 File Offset: 0x00264E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftInfoResponse Clone()
		{
			return new PayGiftInfoResponse(this);
		}

		// Token: 0x17003607 RID: 13831
		// (get) Token: 0x0601074E RID: 67406 RVA: 0x00266C71 File Offset: 0x00264E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayGiftInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x17003608 RID: 13832
		// (get) Token: 0x0601074F RID: 67407 RVA: 0x00266C79 File Offset: 0x00264E79
		// (set) Token: 0x06010750 RID: 67408 RVA: 0x00266C81 File Offset: 0x00264E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003609 RID: 13833
		// (get) Token: 0x06010751 RID: 67409 RVA: 0x00266C94 File Offset: 0x00264E94
		// (set) Token: 0x06010752 RID: 67410 RVA: 0x00266C9C File Offset: 0x00264E9C
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

		// Token: 0x06010753 RID: 67411 RVA: 0x00266CA5 File Offset: 0x00264EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayGiftInfoResponse);
		}

		// Token: 0x06010754 RID: 67412 RVA: 0x00266CB4 File Offset: 0x00264EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayGiftInfoResponse other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && !(this.Version != other.Version) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010755 RID: 67413 RVA: 0x00266D18 File Offset: 0x00264F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.infos_.GetHashCode();
			if (this.Version.Length != 0)
			{
				num ^= this.Version.GetHashCode();
			}
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

		// Token: 0x06010756 RID: 67414 RVA: 0x00266D86 File Offset: 0x00264F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010757 RID: 67415 RVA: 0x00266D93 File Offset: 0x00264F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010758 RID: 67416 RVA: 0x00266D9C File Offset: 0x00264F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.infos_.WriteTo(ref output, PayGiftInfoResponse._repeated_infos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010759 RID: 67417 RVA: 0x00266E0C File Offset: 0x0026500C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.infos_.CalculateSize(PayGiftInfoResponse._repeated_infos_codec);
			if (this.Version.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Version);
			}
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

		// Token: 0x0601075A RID: 67418 RVA: 0x00266E7C File Offset: 0x0026507C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayGiftInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.infos_.Add(other.infos_);
			if (other.Version.Length != 0)
			{
				this.Version = other.Version;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601075B RID: 67419 RVA: 0x00266EE2 File Offset: 0x002650E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601075C RID: 67420 RVA: 0x00266EEC File Offset: 0x002650EC
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
				if (num != 50U)
				{
					if (num != 80U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Version = input.ReadString();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.infos_.AddEntriesFrom(ref input, PayGiftInfoResponse._repeated_infos_codec);
				}
			}
		}

		// Token: 0x0400686F RID: 26735
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006870 RID: 26736
		public const int InfosFieldNumber = 6;

		// Token: 0x04006871 RID: 26737
		private static readonly FieldCodec<PayGiftInfo> _repeated_infos_codec = FieldCodec.ForMessage<PayGiftInfo>(50U, PayGiftInfo.Parser);

		// Token: 0x04006872 RID: 26738
		private readonly RepeatedField<PayGiftInfo> infos_ = new RepeatedField<PayGiftInfo>();

		// Token: 0x04006873 RID: 26739
		public const int VersionFieldNumber = 15;

		// Token: 0x04006874 RID: 26740
		private string version_ = "";

		// Token: 0x04006875 RID: 26741
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04006876 RID: 26742
		private ErrorCode errorCode_;
	}
}
