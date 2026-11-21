using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BCD RID: 3021
	[NetMessage(EMessageId.PayGiftInfoResponse)]
	public sealed class PayGiftInfoResponse : IMessage<PayGiftInfoResponse>, IMessage, IEquatable<PayGiftInfoResponse>, IDeepCloneable<PayGiftInfoResponse>, IBufferMessage
	{
		// Token: 0x06010644 RID: 67140 RVA: 0x00264D31 File Offset: 0x00262F31
		[NullableContext(1)]
		public static PayGiftInfoResponse Create()
		{
			return new PayGiftInfoResponse();
		}

		// Token: 0x170035CC RID: 13772
		// (get) Token: 0x06010645 RID: 67141 RVA: 0x00264D38 File Offset: 0x00262F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035CD RID: 13773
		// (get) Token: 0x06010646 RID: 67142 RVA: 0x00264D3B File Offset: 0x00262F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayGiftInfoResponse.Descriptor;
			}
		}

		// Token: 0x06010647 RID: 67143 RVA: 0x00264D42 File Offset: 0x00262F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftInfoResponse()
		{
		}

		// Token: 0x06010648 RID: 67144 RVA: 0x00264D60 File Offset: 0x00262F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftInfoResponse(PayGiftInfoResponse other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this.version_ = other.version_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010649 RID: 67145 RVA: 0x00264DAD File Offset: 0x00262FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftInfoResponse Clone()
		{
			return new PayGiftInfoResponse(this);
		}

		// Token: 0x170035CE RID: 13774
		// (get) Token: 0x0601064A RID: 67146 RVA: 0x00264DB5 File Offset: 0x00262FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayGiftInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x170035CF RID: 13775
		// (get) Token: 0x0601064B RID: 67147 RVA: 0x00264DBD File Offset: 0x00262FBD
		// (set) Token: 0x0601064C RID: 67148 RVA: 0x00264DC5 File Offset: 0x00262FC5
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

		// Token: 0x170035D0 RID: 13776
		// (get) Token: 0x0601064D RID: 67149 RVA: 0x00264DD8 File Offset: 0x00262FD8
		// (set) Token: 0x0601064E RID: 67150 RVA: 0x00264DE0 File Offset: 0x00262FE0
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

		// Token: 0x0601064F RID: 67151 RVA: 0x00264DE9 File Offset: 0x00262FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayGiftInfoResponse);
		}

		// Token: 0x06010650 RID: 67152 RVA: 0x00264DF8 File Offset: 0x00262FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayGiftInfoResponse other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && !(this.Version != other.Version) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010651 RID: 67153 RVA: 0x00264E5C File Offset: 0x0026305C
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

		// Token: 0x06010652 RID: 67154 RVA: 0x00264ECA File Offset: 0x002630CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010653 RID: 67155 RVA: 0x00264ED7 File Offset: 0x002630D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010654 RID: 67156 RVA: 0x00264EE0 File Offset: 0x002630E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.infos_.WriteTo(ref output, PayGiftInfoResponse._repeated_infos_codec);
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Version);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010655 RID: 67157 RVA: 0x00264F50 File Offset: 0x00263150
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

		// Token: 0x06010656 RID: 67158 RVA: 0x00264FC0 File Offset: 0x002631C0
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

		// Token: 0x06010657 RID: 67159 RVA: 0x00265026 File Offset: 0x00263226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010658 RID: 67160 RVA: 0x00265030 File Offset: 0x00263230
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
				if (num != 26U)
				{
					if (num != 34U)
					{
						if (num != 48U)
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
						this.Version = input.ReadString();
					}
				}
				else
				{
					this.infos_.AddEntriesFrom(ref input, PayGiftInfoResponse._repeated_infos_codec);
				}
			}
		}

		// Token: 0x0400687F RID: 26751
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006880 RID: 26752
		public const int InfosFieldNumber = 3;

		// Token: 0x04006881 RID: 26753
		private static readonly FieldCodec<PayGiftInfo> _repeated_infos_codec = FieldCodec.ForMessage<PayGiftInfo>(26U, PayGiftInfo.Parser);

		// Token: 0x04006882 RID: 26754
		private readonly RepeatedField<PayGiftInfo> infos_ = new RepeatedField<PayGiftInfo>();

		// Token: 0x04006883 RID: 26755
		public const int VersionFieldNumber = 4;

		// Token: 0x04006884 RID: 26756
		private string version_ = "";

		// Token: 0x04006885 RID: 26757
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04006886 RID: 26758
		private ErrorCode errorCode_;
	}
}
