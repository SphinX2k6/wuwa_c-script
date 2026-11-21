using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200086F RID: 2159
	[NetMessage(EMessageId.KickMatchTeamPlayerResponse)]
	public sealed class KickMatchTeamPlayerResponse : IMessage<KickMatchTeamPlayerResponse>, IMessage, IEquatable<KickMatchTeamPlayerResponse>, IDeepCloneable<KickMatchTeamPlayerResponse>, IBufferMessage
	{
		// Token: 0x0600C09C RID: 49308 RVA: 0x001CA009 File Offset: 0x001C8209
		[NullableContext(1)]
		public static KickMatchTeamPlayerResponse Create()
		{
			return new KickMatchTeamPlayerResponse();
		}

		// Token: 0x170026EA RID: 9962
		// (get) Token: 0x0600C09D RID: 49309 RVA: 0x001CA010 File Offset: 0x001C8210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026EB RID: 9963
		// (get) Token: 0x0600C09E RID: 49310 RVA: 0x001CA013 File Offset: 0x001C8213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KickMatchTeamPlayerResponse.Descriptor;
			}
		}

		// Token: 0x0600C09F RID: 49311 RVA: 0x001CA01A File Offset: 0x001C821A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickMatchTeamPlayerResponse()
		{
		}

		// Token: 0x0600C0A0 RID: 49312 RVA: 0x001CA022 File Offset: 0x001C8222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickMatchTeamPlayerResponse(KickMatchTeamPlayerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C0A1 RID: 49313 RVA: 0x001CA047 File Offset: 0x001C8247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickMatchTeamPlayerResponse Clone()
		{
			return new KickMatchTeamPlayerResponse(this);
		}

		// Token: 0x170026EC RID: 9964
		// (get) Token: 0x0600C0A2 RID: 49314 RVA: 0x001CA04F File Offset: 0x001C824F
		// (set) Token: 0x0600C0A3 RID: 49315 RVA: 0x001CA057 File Offset: 0x001C8257
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

		// Token: 0x0600C0A4 RID: 49316 RVA: 0x001CA060 File Offset: 0x001C8260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KickMatchTeamPlayerResponse);
		}

		// Token: 0x0600C0A5 RID: 49317 RVA: 0x001CA06E File Offset: 0x001C826E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KickMatchTeamPlayerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C0A6 RID: 49318 RVA: 0x001CA09C File Offset: 0x001C829C
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

		// Token: 0x0600C0A7 RID: 49319 RVA: 0x001CA0E1 File Offset: 0x001C82E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C0A8 RID: 49320 RVA: 0x001CA0EE File Offset: 0x001C82EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C0A9 RID: 49321 RVA: 0x001CA0F7 File Offset: 0x001C82F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C0AA RID: 49322 RVA: 0x001CA12C File Offset: 0x001C832C
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

		// Token: 0x0600C0AB RID: 49323 RVA: 0x001CA16A File Offset: 0x001C836A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KickMatchTeamPlayerResponse other)
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

		// Token: 0x0600C0AC RID: 49324 RVA: 0x001CA19B File Offset: 0x001C839B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C0AD RID: 49325 RVA: 0x001CA1A4 File Offset: 0x001C83A4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005404 RID: 21508
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005405 RID: 21509
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04005406 RID: 21510
		private ErrorCode errorCode_;
	}
}
