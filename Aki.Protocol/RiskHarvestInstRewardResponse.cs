using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F61 RID: 3937
	[NetMessage(EMessageId.RiskHarvestInstRewardResponse)]
	public sealed class RiskHarvestInstRewardResponse : IMessage<RiskHarvestInstRewardResponse>, IMessage, IEquatable<RiskHarvestInstRewardResponse>, IDeepCloneable<RiskHarvestInstRewardResponse>, IBufferMessage
	{
		// Token: 0x060150EA RID: 86250 RVA: 0x0030DF0D File Offset: 0x0030C10D
		[NullableContext(1)]
		public static RiskHarvestInstRewardResponse Create()
		{
			return new RiskHarvestInstRewardResponse();
		}

		// Token: 0x1700460E RID: 17934
		// (get) Token: 0x060150EB RID: 86251 RVA: 0x0030DF14 File Offset: 0x0030C114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700460F RID: 17935
		// (get) Token: 0x060150EC RID: 86252 RVA: 0x0030DF17 File Offset: 0x0030C117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestInstRewardResponse.Descriptor;
			}
		}

		// Token: 0x060150ED RID: 86253 RVA: 0x0030DF1E File Offset: 0x0030C11E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstRewardResponse()
		{
		}

		// Token: 0x060150EE RID: 86254 RVA: 0x0030DF26 File Offset: 0x0030C126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstRewardResponse(RiskHarvestInstRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060150EF RID: 86255 RVA: 0x0030DF4B File Offset: 0x0030C14B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstRewardResponse Clone()
		{
			return new RiskHarvestInstRewardResponse(this);
		}

		// Token: 0x17004610 RID: 17936
		// (get) Token: 0x060150F0 RID: 86256 RVA: 0x0030DF53 File Offset: 0x0030C153
		// (set) Token: 0x060150F1 RID: 86257 RVA: 0x0030DF5B File Offset: 0x0030C15B
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

		// Token: 0x060150F2 RID: 86258 RVA: 0x0030DF64 File Offset: 0x0030C164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestInstRewardResponse);
		}

		// Token: 0x060150F3 RID: 86259 RVA: 0x0030DF72 File Offset: 0x0030C172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestInstRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060150F4 RID: 86260 RVA: 0x0030DFA0 File Offset: 0x0030C1A0
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

		// Token: 0x060150F5 RID: 86261 RVA: 0x0030DFE5 File Offset: 0x0030C1E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060150F6 RID: 86262 RVA: 0x0030DFF2 File Offset: 0x0030C1F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060150F7 RID: 86263 RVA: 0x0030DFFB File Offset: 0x0030C1FB
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

		// Token: 0x060150F8 RID: 86264 RVA: 0x0030E030 File Offset: 0x0030C230
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

		// Token: 0x060150F9 RID: 86265 RVA: 0x0030E06E File Offset: 0x0030C26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestInstRewardResponse other)
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

		// Token: 0x060150FA RID: 86266 RVA: 0x0030E09F File Offset: 0x0030C29F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060150FB RID: 86267 RVA: 0x0030E0A8 File Offset: 0x0030C2A8
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

		// Token: 0x04007EDB RID: 32475
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EDC RID: 32476
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04007EDD RID: 32477
		private ErrorCode errorCode_;
	}
}
