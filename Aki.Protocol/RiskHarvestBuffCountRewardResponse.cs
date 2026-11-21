using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F47 RID: 3911
	[NetMessage(EMessageId.RiskHarvestBuffCountRewardResponse)]
	public sealed class RiskHarvestBuffCountRewardResponse : IMessage<RiskHarvestBuffCountRewardResponse>, IMessage, IEquatable<RiskHarvestBuffCountRewardResponse>, IDeepCloneable<RiskHarvestBuffCountRewardResponse>, IBufferMessage
	{
		// Token: 0x06014F2F RID: 85807 RVA: 0x0030AA35 File Offset: 0x00308C35
		[NullableContext(1)]
		public static RiskHarvestBuffCountRewardResponse Create()
		{
			return new RiskHarvestBuffCountRewardResponse();
		}

		// Token: 0x170045B4 RID: 17844
		// (get) Token: 0x06014F30 RID: 85808 RVA: 0x0030AA3C File Offset: 0x00308C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045B5 RID: 17845
		// (get) Token: 0x06014F31 RID: 85809 RVA: 0x0030AA3F File Offset: 0x00308C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestBuffCountRewardResponse.Descriptor;
			}
		}

		// Token: 0x06014F32 RID: 85810 RVA: 0x0030AA46 File Offset: 0x00308C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffCountRewardResponse()
		{
		}

		// Token: 0x06014F33 RID: 85811 RVA: 0x0030AA4E File Offset: 0x00308C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffCountRewardResponse(RiskHarvestBuffCountRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014F34 RID: 85812 RVA: 0x0030AA73 File Offset: 0x00308C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffCountRewardResponse Clone()
		{
			return new RiskHarvestBuffCountRewardResponse(this);
		}

		// Token: 0x170045B6 RID: 17846
		// (get) Token: 0x06014F35 RID: 85813 RVA: 0x0030AA7B File Offset: 0x00308C7B
		// (set) Token: 0x06014F36 RID: 85814 RVA: 0x0030AA83 File Offset: 0x00308C83
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

		// Token: 0x06014F37 RID: 85815 RVA: 0x0030AA8C File Offset: 0x00308C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestBuffCountRewardResponse);
		}

		// Token: 0x06014F38 RID: 85816 RVA: 0x0030AA9A File Offset: 0x00308C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestBuffCountRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014F39 RID: 85817 RVA: 0x0030AAC8 File Offset: 0x00308CC8
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

		// Token: 0x06014F3A RID: 85818 RVA: 0x0030AB0D File Offset: 0x00308D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014F3B RID: 85819 RVA: 0x0030AB1A File Offset: 0x00308D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014F3C RID: 85820 RVA: 0x0030AB23 File Offset: 0x00308D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014F3D RID: 85821 RVA: 0x0030AB58 File Offset: 0x00308D58
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

		// Token: 0x06014F3E RID: 85822 RVA: 0x0030AB96 File Offset: 0x00308D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestBuffCountRewardResponse other)
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

		// Token: 0x06014F3F RID: 85823 RVA: 0x0030ABC7 File Offset: 0x00308DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014F40 RID: 85824 RVA: 0x0030ABD0 File Offset: 0x00308DD0
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007EC0 RID: 32448
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EC1 RID: 32449
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04007EC2 RID: 32450
		private ErrorCode errorCode_;
	}
}
