using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE3 RID: 3043
	[NetMessage(EMessageId.PayInfoResponse)]
	public sealed class PayInfoResponse : IMessage<PayInfoResponse>, IMessage, IEquatable<PayInfoResponse>, IDeepCloneable<PayInfoResponse>, IBufferMessage
	{
		// Token: 0x060107C8 RID: 67528 RVA: 0x00267FBD File Offset: 0x002661BD
		[NullableContext(1)]
		public static PayInfoResponse Create()
		{
			return new PayInfoResponse();
		}

		// Token: 0x17003621 RID: 13857
		// (get) Token: 0x060107C9 RID: 67529 RVA: 0x00267FC4 File Offset: 0x002661C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003622 RID: 13858
		// (get) Token: 0x060107CA RID: 67530 RVA: 0x00267FC7 File Offset: 0x002661C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayInfoResponse.Descriptor;
			}
		}

		// Token: 0x060107CB RID: 67531 RVA: 0x00267FCE File Offset: 0x002661CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayInfoResponse()
		{
		}

		// Token: 0x060107CC RID: 67532 RVA: 0x00267FEC File Offset: 0x002661EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayInfoResponse(PayInfoResponse other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this.version_ = other.version_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060107CD RID: 67533 RVA: 0x00268039 File Offset: 0x00266239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayInfoResponse Clone()
		{
			return new PayInfoResponse(this);
		}

		// Token: 0x17003623 RID: 13859
		// (get) Token: 0x060107CE RID: 67534 RVA: 0x00268041 File Offset: 0x00266241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayItemInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x17003624 RID: 13860
		// (get) Token: 0x060107CF RID: 67535 RVA: 0x00268049 File Offset: 0x00266249
		// (set) Token: 0x060107D0 RID: 67536 RVA: 0x00268051 File Offset: 0x00266251
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

		// Token: 0x17003625 RID: 13861
		// (get) Token: 0x060107D1 RID: 67537 RVA: 0x00268064 File Offset: 0x00266264
		// (set) Token: 0x060107D2 RID: 67538 RVA: 0x0026806C File Offset: 0x0026626C
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

		// Token: 0x060107D3 RID: 67539 RVA: 0x00268075 File Offset: 0x00266275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayInfoResponse);
		}

		// Token: 0x060107D4 RID: 67540 RVA: 0x00268084 File Offset: 0x00266284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayInfoResponse other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && !(this.Version != other.Version) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060107D5 RID: 67541 RVA: 0x002680E8 File Offset: 0x002662E8
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

		// Token: 0x060107D6 RID: 67542 RVA: 0x00268156 File Offset: 0x00266356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060107D7 RID: 67543 RVA: 0x00268163 File Offset: 0x00266363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060107D8 RID: 67544 RVA: 0x0026816C File Offset: 0x0026636C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.infos_.WriteTo(ref output, PayInfoResponse._repeated_infos_codec);
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060107D9 RID: 67545 RVA: 0x002681DC File Offset: 0x002663DC
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

		// Token: 0x060107DA RID: 67546 RVA: 0x0026824C File Offset: 0x0026644C
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

		// Token: 0x060107DB RID: 67547 RVA: 0x002682B2 File Offset: 0x002664B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060107DC RID: 67548 RVA: 0x002682BC File Offset: 0x002664BC
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
					if (num != 58U)
					{
						if (num != 98U)
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
						this.infos_.AddEntriesFrom(ref input, PayInfoResponse._repeated_infos_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006897 RID: 26775
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006898 RID: 26776
		public const int InfosFieldNumber = 7;

		// Token: 0x04006899 RID: 26777
		private static readonly FieldCodec<PayItemInfo> _repeated_infos_codec = FieldCodec.ForMessage<PayItemInfo>(58U, PayItemInfo.Parser);

		// Token: 0x0400689A RID: 26778
		private readonly RepeatedField<PayItemInfo> infos_ = new RepeatedField<PayItemInfo>();

		// Token: 0x0400689B RID: 26779
		public const int VersionFieldNumber = 12;

		// Token: 0x0400689C RID: 26780
		private string version_ = "";

		// Token: 0x0400689D RID: 26781
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400689E RID: 26782
		private ErrorCode errorCode_;
	}
}
