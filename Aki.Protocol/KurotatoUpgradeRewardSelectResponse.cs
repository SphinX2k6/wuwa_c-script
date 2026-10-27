using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008DB RID: 2267
	[NetMessage(EMessageId.KurotatoUpgradeRewardSelectResponse)]
	public sealed class KurotatoUpgradeRewardSelectResponse : IMessage<KurotatoUpgradeRewardSelectResponse>, IMessage, IEquatable<KurotatoUpgradeRewardSelectResponse>, IDeepCloneable<KurotatoUpgradeRewardSelectResponse>, IBufferMessage
	{
		// Token: 0x0600C8BA RID: 51386 RVA: 0x001DAD61 File Offset: 0x001D8F61
		[NullableContext(1)]
		public static KurotatoUpgradeRewardSelectResponse Create()
		{
			return new KurotatoUpgradeRewardSelectResponse();
		}

		// Token: 0x1700288F RID: 10383
		// (get) Token: 0x0600C8BB RID: 51387 RVA: 0x001DAD68 File Offset: 0x001D8F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002890 RID: 10384
		// (get) Token: 0x0600C8BC RID: 51388 RVA: 0x001DAD6B File Offset: 0x001D8F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoUpgradeRewardSelectResponse.Descriptor;
			}
		}

		// Token: 0x0600C8BD RID: 51389 RVA: 0x001DAD72 File Offset: 0x001D8F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardSelectResponse()
		{
		}

		// Token: 0x0600C8BE RID: 51390 RVA: 0x001DAD7A File Offset: 0x001D8F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardSelectResponse(KurotatoUpgradeRewardSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C8BF RID: 51391 RVA: 0x001DAD9F File Offset: 0x001D8F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardSelectResponse Clone()
		{
			return new KurotatoUpgradeRewardSelectResponse(this);
		}

		// Token: 0x17002891 RID: 10385
		// (get) Token: 0x0600C8C0 RID: 51392 RVA: 0x001DADA7 File Offset: 0x001D8FA7
		// (set) Token: 0x0600C8C1 RID: 51393 RVA: 0x001DADAF File Offset: 0x001D8FAF
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

		// Token: 0x0600C8C2 RID: 51394 RVA: 0x001DADB8 File Offset: 0x001D8FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoUpgradeRewardSelectResponse);
		}

		// Token: 0x0600C8C3 RID: 51395 RVA: 0x001DADC6 File Offset: 0x001D8FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoUpgradeRewardSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C8C4 RID: 51396 RVA: 0x001DADF4 File Offset: 0x001D8FF4
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

		// Token: 0x0600C8C5 RID: 51397 RVA: 0x001DAE39 File Offset: 0x001D9039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C8C6 RID: 51398 RVA: 0x001DAE46 File Offset: 0x001D9046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C8C7 RID: 51399 RVA: 0x001DAE4F File Offset: 0x001D904F
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

		// Token: 0x0600C8C8 RID: 51400 RVA: 0x001DAE84 File Offset: 0x001D9084
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

		// Token: 0x0600C8C9 RID: 51401 RVA: 0x001DAEC2 File Offset: 0x001D90C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoUpgradeRewardSelectResponse other)
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

		// Token: 0x0600C8CA RID: 51402 RVA: 0x001DAEF3 File Offset: 0x001D90F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C8CB RID: 51403 RVA: 0x001DAEFC File Offset: 0x001D90FC
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

		// Token: 0x040055C8 RID: 21960
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055C9 RID: 21961
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040055CA RID: 21962
		private ErrorCode errorCode_;
	}
}
