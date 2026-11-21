using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD3 RID: 3027
	[NetMessage(EMessageId.PayInfoResponse)]
	public sealed class PayInfoResponse : IMessage<PayInfoResponse>, IMessage, IEquatable<PayInfoResponse>, IDeepCloneable<PayInfoResponse>, IBufferMessage
	{
		// Token: 0x060106C4 RID: 67268 RVA: 0x002660FD File Offset: 0x002642FD
		[NullableContext(1)]
		public static PayInfoResponse Create()
		{
			return new PayInfoResponse();
		}

		// Token: 0x170035E8 RID: 13800
		// (get) Token: 0x060106C5 RID: 67269 RVA: 0x00266104 File Offset: 0x00264304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035E9 RID: 13801
		// (get) Token: 0x060106C6 RID: 67270 RVA: 0x00266107 File Offset: 0x00264307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayInfoResponse.Descriptor;
			}
		}

		// Token: 0x060106C7 RID: 67271 RVA: 0x0026610E File Offset: 0x0026430E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayInfoResponse()
		{
		}

		// Token: 0x060106C8 RID: 67272 RVA: 0x0026612C File Offset: 0x0026432C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayInfoResponse(PayInfoResponse other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this.version_ = other.version_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060106C9 RID: 67273 RVA: 0x00266179 File Offset: 0x00264379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayInfoResponse Clone()
		{
			return new PayInfoResponse(this);
		}

		// Token: 0x170035EA RID: 13802
		// (get) Token: 0x060106CA RID: 67274 RVA: 0x00266181 File Offset: 0x00264381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayItemInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x170035EB RID: 13803
		// (get) Token: 0x060106CB RID: 67275 RVA: 0x00266189 File Offset: 0x00264389
		// (set) Token: 0x060106CC RID: 67276 RVA: 0x00266191 File Offset: 0x00264391
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

		// Token: 0x170035EC RID: 13804
		// (get) Token: 0x060106CD RID: 67277 RVA: 0x002661A4 File Offset: 0x002643A4
		// (set) Token: 0x060106CE RID: 67278 RVA: 0x002661AC File Offset: 0x002643AC
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

		// Token: 0x060106CF RID: 67279 RVA: 0x002661B5 File Offset: 0x002643B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayInfoResponse);
		}

		// Token: 0x060106D0 RID: 67280 RVA: 0x002661C4 File Offset: 0x002643C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayInfoResponse other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && !(this.Version != other.Version) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060106D1 RID: 67281 RVA: 0x00266228 File Offset: 0x00264428
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

		// Token: 0x060106D2 RID: 67282 RVA: 0x00266296 File Offset: 0x00264496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060106D3 RID: 67283 RVA: 0x002662A3 File Offset: 0x002644A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060106D4 RID: 67284 RVA: 0x002662AC File Offset: 0x002644AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Version);
			}
			this.infos_.WriteTo(ref output, PayInfoResponse._repeated_infos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060106D5 RID: 67285 RVA: 0x0026631C File Offset: 0x0026451C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.infos_.CalculateSize(PayInfoResponse._repeated_infos_codec);
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

		// Token: 0x060106D6 RID: 67286 RVA: 0x0026638C File Offset: 0x0026458C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayInfoResponse other)
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

		// Token: 0x060106D7 RID: 67287 RVA: 0x002663F2 File Offset: 0x002645F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060106D8 RID: 67288 RVA: 0x002663FC File Offset: 0x002645FC
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
				if (num != 18U)
				{
					if (num != 98U)
					{
						if (num != 112U)
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
						this.infos_.AddEntriesFrom(ref input, PayInfoResponse._repeated_infos_codec);
					}
				}
				else
				{
					this.Version = input.ReadString();
				}
			}
		}

		// Token: 0x040068A7 RID: 26791
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068A8 RID: 26792
		public const int InfosFieldNumber = 12;

		// Token: 0x040068A9 RID: 26793
		private static readonly FieldCodec<PayItemInfo> _repeated_infos_codec = FieldCodec.ForMessage<PayItemInfo>(98U, PayItemInfo.Parser);

		// Token: 0x040068AA RID: 26794
		private readonly RepeatedField<PayItemInfo> infos_ = new RepeatedField<PayItemInfo>();

		// Token: 0x040068AB RID: 26795
		public const int VersionFieldNumber = 2;

		// Token: 0x040068AC RID: 26796
		private string version_ = "";

		// Token: 0x040068AD RID: 26797
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040068AE RID: 26798
		private ErrorCode errorCode_;
	}
}
