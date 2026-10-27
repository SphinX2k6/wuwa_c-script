using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200088A RID: 2186
	[NetMessage(EMessageId.KurotatoChestRewardSelectResponse)]
	public sealed class KurotatoChestRewardSelectResponse : IMessage<KurotatoChestRewardSelectResponse>, IMessage, IEquatable<KurotatoChestRewardSelectResponse>, IDeepCloneable<KurotatoChestRewardSelectResponse>, IBufferMessage
	{
		// Token: 0x0600C285 RID: 49797 RVA: 0x001CE0AD File Offset: 0x001CC2AD
		[NullableContext(1)]
		public static KurotatoChestRewardSelectResponse Create()
		{
			return new KurotatoChestRewardSelectResponse();
		}

		// Token: 0x17002757 RID: 10071
		// (get) Token: 0x0600C286 RID: 49798 RVA: 0x001CE0B4 File Offset: 0x001CC2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002758 RID: 10072
		// (get) Token: 0x0600C287 RID: 49799 RVA: 0x001CE0B7 File Offset: 0x001CC2B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoChestRewardSelectResponse.Descriptor;
			}
		}

		// Token: 0x0600C288 RID: 49800 RVA: 0x001CE0BE File Offset: 0x001CC2BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardSelectResponse()
		{
		}

		// Token: 0x0600C289 RID: 49801 RVA: 0x001CE0C6 File Offset: 0x001CC2C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardSelectResponse(KurotatoChestRewardSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C28A RID: 49802 RVA: 0x001CE0EB File Offset: 0x001CC2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardSelectResponse Clone()
		{
			return new KurotatoChestRewardSelectResponse(this);
		}

		// Token: 0x17002759 RID: 10073
		// (get) Token: 0x0600C28B RID: 49803 RVA: 0x001CE0F3 File Offset: 0x001CC2F3
		// (set) Token: 0x0600C28C RID: 49804 RVA: 0x001CE0FB File Offset: 0x001CC2FB
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

		// Token: 0x0600C28D RID: 49805 RVA: 0x001CE104 File Offset: 0x001CC304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoChestRewardSelectResponse);
		}

		// Token: 0x0600C28E RID: 49806 RVA: 0x001CE112 File Offset: 0x001CC312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoChestRewardSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C28F RID: 49807 RVA: 0x001CE140 File Offset: 0x001CC340
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

		// Token: 0x0600C290 RID: 49808 RVA: 0x001CE185 File Offset: 0x001CC385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C291 RID: 49809 RVA: 0x001CE192 File Offset: 0x001CC392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C292 RID: 49810 RVA: 0x001CE19B File Offset: 0x001CC39B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C293 RID: 49811 RVA: 0x001CE1D0 File Offset: 0x001CC3D0
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

		// Token: 0x0600C294 RID: 49812 RVA: 0x001CE20E File Offset: 0x001CC40E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoChestRewardSelectResponse other)
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

		// Token: 0x0600C295 RID: 49813 RVA: 0x001CE23F File Offset: 0x001CC43F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C296 RID: 49814 RVA: 0x001CE248 File Offset: 0x001CC448
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005443 RID: 21571
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005444 RID: 21572
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04005445 RID: 21573
		private ErrorCode errorCode_;
	}
}
