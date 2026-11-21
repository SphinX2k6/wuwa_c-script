using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000892 RID: 2194
	[NetMessage(EMessageId.KurotatoLevelRecordDeleteResponse)]
	public sealed class KurotatoLevelRecordDeleteResponse : IMessage<KurotatoLevelRecordDeleteResponse>, IMessage, IEquatable<KurotatoLevelRecordDeleteResponse>, IDeepCloneable<KurotatoLevelRecordDeleteResponse>, IBufferMessage
	{
		// Token: 0x0600C358 RID: 50008 RVA: 0x001CFB89 File Offset: 0x001CDD89
		[NullableContext(1)]
		public static KurotatoLevelRecordDeleteResponse Create()
		{
			return new KurotatoLevelRecordDeleteResponse();
		}

		// Token: 0x1700277A RID: 10106
		// (get) Token: 0x0600C359 RID: 50009 RVA: 0x001CFB90 File Offset: 0x001CDD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700277B RID: 10107
		// (get) Token: 0x0600C35A RID: 50010 RVA: 0x001CFB93 File Offset: 0x001CDD93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoLevelRecordDeleteResponse.Descriptor;
			}
		}

		// Token: 0x0600C35B RID: 50011 RVA: 0x001CFB9A File Offset: 0x001CDD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelRecordDeleteResponse()
		{
		}

		// Token: 0x0600C35C RID: 50012 RVA: 0x001CFBA2 File Offset: 0x001CDDA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelRecordDeleteResponse(KurotatoLevelRecordDeleteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C35D RID: 50013 RVA: 0x001CFBC7 File Offset: 0x001CDDC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelRecordDeleteResponse Clone()
		{
			return new KurotatoLevelRecordDeleteResponse(this);
		}

		// Token: 0x1700277C RID: 10108
		// (get) Token: 0x0600C35E RID: 50014 RVA: 0x001CFBCF File Offset: 0x001CDDCF
		// (set) Token: 0x0600C35F RID: 50015 RVA: 0x001CFBD7 File Offset: 0x001CDDD7
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

		// Token: 0x0600C360 RID: 50016 RVA: 0x001CFBE0 File Offset: 0x001CDDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoLevelRecordDeleteResponse);
		}

		// Token: 0x0600C361 RID: 50017 RVA: 0x001CFBEE File Offset: 0x001CDDEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoLevelRecordDeleteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C362 RID: 50018 RVA: 0x001CFC1C File Offset: 0x001CDE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600C363 RID: 50019 RVA: 0x001CFC61 File Offset: 0x001CDE61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C364 RID: 50020 RVA: 0x001CFC6E File Offset: 0x001CDE6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C365 RID: 50021 RVA: 0x001CFC77 File Offset: 0x001CDE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C366 RID: 50022 RVA: 0x001CFCAC File Offset: 0x001CDEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600C367 RID: 50023 RVA: 0x001CFCEA File Offset: 0x001CDEEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoLevelRecordDeleteResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C368 RID: 50024 RVA: 0x001CFD1B File Offset: 0x001CDF1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C369 RID: 50025 RVA: 0x001CFD24 File Offset: 0x001CDF24
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040054C5 RID: 21701
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054C6 RID: 21702
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040054C7 RID: 21703
		private ErrorCode errorCode_;
	}
}
