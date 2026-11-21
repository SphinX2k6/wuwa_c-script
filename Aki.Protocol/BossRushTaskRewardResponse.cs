using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E6 RID: 486
	[NetMessage(EMessageId.BossRushTaskRewardResponse)]
	public sealed class BossRushTaskRewardResponse : IMessage<BossRushTaskRewardResponse>, IMessage, IEquatable<BossRushTaskRewardResponse>, IDeepCloneable<BossRushTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x060036D4 RID: 14036 RVA: 0x00089C55 File Offset: 0x00087E55
		[NullableContext(1)]
		public static BossRushTaskRewardResponse Create()
		{
			return new BossRushTaskRewardResponse();
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x060036D5 RID: 14037 RVA: 0x00089C5C File Offset: 0x00087E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x060036D6 RID: 14038 RVA: 0x00089C5F File Offset: 0x00087E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x00089C66 File Offset: 0x00087E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushTaskRewardResponse()
		{
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x00089C6E File Offset: 0x00087E6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushTaskRewardResponse(BossRushTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x00089C93 File Offset: 0x00087E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushTaskRewardResponse Clone()
		{
			return new BossRushTaskRewardResponse(this);
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x060036DA RID: 14042 RVA: 0x00089C9B File Offset: 0x00087E9B
		// (set) Token: 0x060036DB RID: 14043 RVA: 0x00089CA3 File Offset: 0x00087EA3
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

		// Token: 0x060036DC RID: 14044 RVA: 0x00089CAC File Offset: 0x00087EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushTaskRewardResponse);
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x00089CBA File Offset: 0x00087EBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x00089CE8 File Offset: 0x00087EE8
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

		// Token: 0x060036DF RID: 14047 RVA: 0x00089D2D File Offset: 0x00087F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x00089D3A File Offset: 0x00087F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x00089D43 File Offset: 0x00087F43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x00089D78 File Offset: 0x00087F78
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

		// Token: 0x060036E3 RID: 14051 RVA: 0x00089DB6 File Offset: 0x00087FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushTaskRewardResponse other)
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

		// Token: 0x060036E4 RID: 14052 RVA: 0x00089DE7 File Offset: 0x00087FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x00089DF0 File Offset: 0x00087FF0
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002B13 RID: 11027
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B14 RID: 11028
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04002B15 RID: 11029
		private ErrorCode errorCode_;
	}
}
