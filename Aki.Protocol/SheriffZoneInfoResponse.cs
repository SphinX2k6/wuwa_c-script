using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E8 RID: 4584
	[NetMessage(EMessageId.SheriffZoneInfoResponse)]
	public sealed class SheriffZoneInfoResponse : IMessage<SheriffZoneInfoResponse>, IMessage, IEquatable<SheriffZoneInfoResponse>, IDeepCloneable<SheriffZoneInfoResponse>, IBufferMessage
	{
		// Token: 0x060186F4 RID: 100084 RVA: 0x0038D771 File Offset: 0x0038B971
		[NullableContext(1)]
		public static SheriffZoneInfoResponse Create()
		{
			return new SheriffZoneInfoResponse();
		}

		// Token: 0x17005243 RID: 21059
		// (get) Token: 0x060186F5 RID: 100085 RVA: 0x0038D778 File Offset: 0x0038B978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005244 RID: 21060
		// (get) Token: 0x060186F6 RID: 100086 RVA: 0x0038D77B File Offset: 0x0038B97B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SheriffZoneInfoResponse.Descriptor;
			}
		}

		// Token: 0x060186F7 RID: 100087 RVA: 0x0038D782 File Offset: 0x0038B982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneInfoResponse()
		{
		}

		// Token: 0x060186F8 RID: 100088 RVA: 0x0038D795 File Offset: 0x0038B995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneInfoResponse(SheriffZoneInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.zoneInfos_ = other.zoneInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060186F9 RID: 100089 RVA: 0x0038D7CB File Offset: 0x0038B9CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneInfoResponse Clone()
		{
			return new SheriffZoneInfoResponse(this);
		}

		// Token: 0x17005245 RID: 21061
		// (get) Token: 0x060186FA RID: 100090 RVA: 0x0038D7D3 File Offset: 0x0038B9D3
		// (set) Token: 0x060186FB RID: 100091 RVA: 0x0038D7DB File Offset: 0x0038B9DB
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

		// Token: 0x17005246 RID: 21062
		// (get) Token: 0x060186FC RID: 100092 RVA: 0x0038D7E4 File Offset: 0x0038B9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SheriffZoneInfo> ZoneInfos
		{
			get
			{
				return this.zoneInfos_;
			}
		}

		// Token: 0x060186FD RID: 100093 RVA: 0x0038D7EC File Offset: 0x0038B9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SheriffZoneInfoResponse);
		}

		// Token: 0x060186FE RID: 100094 RVA: 0x0038D7FC File Offset: 0x0038B9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SheriffZoneInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.zoneInfos_.Equals(other.zoneInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060186FF RID: 100095 RVA: 0x0038D84C File Offset: 0x0038BA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.zoneInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018700 RID: 100096 RVA: 0x0038D89F File Offset: 0x0038BA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018701 RID: 100097 RVA: 0x0038D8AC File Offset: 0x0038BAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018702 RID: 100098 RVA: 0x0038D8B8 File Offset: 0x0038BAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.zoneInfos_.WriteTo(ref output, SheriffZoneInfoResponse._repeated_zoneInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018703 RID: 100099 RVA: 0x0038D908 File Offset: 0x0038BB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.zoneInfos_.CalculateSize(SheriffZoneInfoResponse._repeated_zoneInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018704 RID: 100100 RVA: 0x0038D95C File Offset: 0x0038BB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SheriffZoneInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.zoneInfos_.Add(other.zoneInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018705 RID: 100101 RVA: 0x0038D9A9 File Offset: 0x0038BBA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018706 RID: 100102 RVA: 0x0038D9B4 File Offset: 0x0038BBB4
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
				if (num != 34U)
				{
					if (num != 40U)
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
					this.zoneInfos_.AddEntriesFrom(ref input, SheriffZoneInfoResponse._repeated_zoneInfos_codec);
				}
			}
		}

		// Token: 0x04009075 RID: 36981
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009076 RID: 36982
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04009077 RID: 36983
		private ErrorCode errorCode_;

		// Token: 0x04009078 RID: 36984
		public const int ZoneInfosFieldNumber = 4;

		// Token: 0x04009079 RID: 36985
		private static readonly FieldCodec<SheriffZoneInfo> _repeated_zoneInfos_codec = FieldCodec.ForMessage<SheriffZoneInfo>(34U, SheriffZoneInfo.Parser);

		// Token: 0x0400907A RID: 36986
		private readonly RepeatedField<SheriffZoneInfo> zoneInfos_ = new RepeatedField<SheriffZoneInfo>();
	}
}
