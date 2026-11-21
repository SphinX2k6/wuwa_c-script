using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008CA RID: 2250
	[NetMessage(EMessageId.KurotatoUpgradeRewardSelectResponse)]
	public sealed class KurotatoUpgradeRewardSelectResponse : IMessage<KurotatoUpgradeRewardSelectResponse>, IMessage, IEquatable<KurotatoUpgradeRewardSelectResponse>, IDeepCloneable<KurotatoUpgradeRewardSelectResponse>, IBufferMessage
	{
		// Token: 0x0600C79E RID: 51102 RVA: 0x001D8A85 File Offset: 0x001D6C85
		[NullableContext(1)]
		public static KurotatoUpgradeRewardSelectResponse Create()
		{
			return new KurotatoUpgradeRewardSelectResponse();
		}

		// Token: 0x17002850 RID: 10320
		// (get) Token: 0x0600C79F RID: 51103 RVA: 0x001D8A8C File Offset: 0x001D6C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002851 RID: 10321
		// (get) Token: 0x0600C7A0 RID: 51104 RVA: 0x001D8A8F File Offset: 0x001D6C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoUpgradeRewardSelectResponse.Descriptor;
			}
		}

		// Token: 0x0600C7A1 RID: 51105 RVA: 0x001D8A96 File Offset: 0x001D6C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardSelectResponse()
		{
		}

		// Token: 0x0600C7A2 RID: 51106 RVA: 0x001D8A9E File Offset: 0x001D6C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardSelectResponse(KurotatoUpgradeRewardSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C7A3 RID: 51107 RVA: 0x001D8AC3 File Offset: 0x001D6CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardSelectResponse Clone()
		{
			return new KurotatoUpgradeRewardSelectResponse(this);
		}

		// Token: 0x17002852 RID: 10322
		// (get) Token: 0x0600C7A4 RID: 51108 RVA: 0x001D8ACB File Offset: 0x001D6CCB
		// (set) Token: 0x0600C7A5 RID: 51109 RVA: 0x001D8AD3 File Offset: 0x001D6CD3
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

		// Token: 0x0600C7A6 RID: 51110 RVA: 0x001D8ADC File Offset: 0x001D6CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoUpgradeRewardSelectResponse);
		}

		// Token: 0x0600C7A7 RID: 51111 RVA: 0x001D8AEA File Offset: 0x001D6CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoUpgradeRewardSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C7A8 RID: 51112 RVA: 0x001D8B18 File Offset: 0x001D6D18
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

		// Token: 0x0600C7A9 RID: 51113 RVA: 0x001D8B5D File Offset: 0x001D6D5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C7AA RID: 51114 RVA: 0x001D8B6A File Offset: 0x001D6D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C7AB RID: 51115 RVA: 0x001D8B73 File Offset: 0x001D6D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C7AC RID: 51116 RVA: 0x001D8BA8 File Offset: 0x001D6DA8
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

		// Token: 0x0600C7AD RID: 51117 RVA: 0x001D8BE6 File Offset: 0x001D6DE6
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

		// Token: 0x0600C7AE RID: 51118 RVA: 0x001D8C17 File Offset: 0x001D6E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C7AF RID: 51119 RVA: 0x001D8C20 File Offset: 0x001D6E20
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040055CF RID: 21967
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055D0 RID: 21968
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040055D1 RID: 21969
		private ErrorCode errorCode_;
	}
}
