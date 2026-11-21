using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F53 RID: 3923
	[NetMessage(EMessageId.RiskHarvestScoreRewardRequest)]
	public sealed class RiskHarvestScoreRewardRequest : IMessage<RiskHarvestScoreRewardRequest>, IMessage, IEquatable<RiskHarvestScoreRewardRequest>, IDeepCloneable<RiskHarvestScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x06015029 RID: 86057 RVA: 0x0030CC1D File Offset: 0x0030AE1D
		[NullableContext(1)]
		public static RiskHarvestScoreRewardRequest Create()
		{
			return new RiskHarvestScoreRewardRequest();
		}

		// Token: 0x170045EA RID: 17898
		// (get) Token: 0x0601502A RID: 86058 RVA: 0x0030CC24 File Offset: 0x0030AE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045EB RID: 17899
		// (get) Token: 0x0601502B RID: 86059 RVA: 0x0030CC27 File Offset: 0x0030AE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601502C RID: 86060 RVA: 0x0030CC2E File Offset: 0x0030AE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestScoreRewardRequest()
		{
		}

		// Token: 0x0601502D RID: 86061 RVA: 0x0030CC36 File Offset: 0x0030AE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestScoreRewardRequest(RiskHarvestScoreRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601502E RID: 86062 RVA: 0x0030CC5B File Offset: 0x0030AE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestScoreRewardRequest Clone()
		{
			return new RiskHarvestScoreRewardRequest(this);
		}

		// Token: 0x170045EC RID: 17900
		// (get) Token: 0x0601502F RID: 86063 RVA: 0x0030CC63 File Offset: 0x0030AE63
		// (set) Token: 0x06015030 RID: 86064 RVA: 0x0030CC6B File Offset: 0x0030AE6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06015031 RID: 86065 RVA: 0x0030CC74 File Offset: 0x0030AE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestScoreRewardRequest);
		}

		// Token: 0x06015032 RID: 86066 RVA: 0x0030CC82 File Offset: 0x0030AE82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestScoreRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015033 RID: 86067 RVA: 0x0030CCB0 File Offset: 0x0030AEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015034 RID: 86068 RVA: 0x0030CCEF File Offset: 0x0030AEEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015035 RID: 86069 RVA: 0x0030CCFC File Offset: 0x0030AEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015036 RID: 86070 RVA: 0x0030CD05 File Offset: 0x0030AF05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015037 RID: 86071 RVA: 0x0030CD38 File Offset: 0x0030AF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015038 RID: 86072 RVA: 0x0030CD76 File Offset: 0x0030AF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015039 RID: 86073 RVA: 0x0030CDA7 File Offset: 0x0030AFA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601503A RID: 86074 RVA: 0x0030CDB0 File Offset: 0x0030AFB0
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007F0C RID: 32524
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F0D RID: 32525
		public const int IdFieldNumber = 12;

		// Token: 0x04007F0E RID: 32526
		private int id_;
	}
}
