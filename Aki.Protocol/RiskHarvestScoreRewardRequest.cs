using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F63 RID: 3939
	[NetMessage(EMessageId.RiskHarvestScoreRewardRequest)]
	public sealed class RiskHarvestScoreRewardRequest : IMessage<RiskHarvestScoreRewardRequest>, IMessage, IEquatable<RiskHarvestScoreRewardRequest>, IDeepCloneable<RiskHarvestScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x0601510E RID: 86286 RVA: 0x0030E2CD File Offset: 0x0030C4CD
		[NullableContext(1)]
		public static RiskHarvestScoreRewardRequest Create()
		{
			return new RiskHarvestScoreRewardRequest();
		}

		// Token: 0x17004614 RID: 17940
		// (get) Token: 0x0601510F RID: 86287 RVA: 0x0030E2D4 File Offset: 0x0030C4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004615 RID: 17941
		// (get) Token: 0x06015110 RID: 86288 RVA: 0x0030E2D7 File Offset: 0x0030C4D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x06015111 RID: 86289 RVA: 0x0030E2DE File Offset: 0x0030C4DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestScoreRewardRequest()
		{
		}

		// Token: 0x06015112 RID: 86290 RVA: 0x0030E2E6 File Offset: 0x0030C4E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestScoreRewardRequest(RiskHarvestScoreRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015113 RID: 86291 RVA: 0x0030E30B File Offset: 0x0030C50B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestScoreRewardRequest Clone()
		{
			return new RiskHarvestScoreRewardRequest(this);
		}

		// Token: 0x17004616 RID: 17942
		// (get) Token: 0x06015114 RID: 86292 RVA: 0x0030E313 File Offset: 0x0030C513
		// (set) Token: 0x06015115 RID: 86293 RVA: 0x0030E31B File Offset: 0x0030C51B
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

		// Token: 0x06015116 RID: 86294 RVA: 0x0030E324 File Offset: 0x0030C524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestScoreRewardRequest);
		}

		// Token: 0x06015117 RID: 86295 RVA: 0x0030E332 File Offset: 0x0030C532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestScoreRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015118 RID: 86296 RVA: 0x0030E360 File Offset: 0x0030C560
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

		// Token: 0x06015119 RID: 86297 RVA: 0x0030E39F File Offset: 0x0030C59F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601511A RID: 86298 RVA: 0x0030E3AC File Offset: 0x0030C5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601511B RID: 86299 RVA: 0x0030E3B5 File Offset: 0x0030C5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601511C RID: 86300 RVA: 0x0030E3E8 File Offset: 0x0030C5E8
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

		// Token: 0x0601511D RID: 86301 RVA: 0x0030E426 File Offset: 0x0030C626
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

		// Token: 0x0601511E RID: 86302 RVA: 0x0030E457 File Offset: 0x0030C657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601511F RID: 86303 RVA: 0x0030E460 File Offset: 0x0030C660
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007EE2 RID: 32482
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EE3 RID: 32483
		public const int IdFieldNumber = 14;

		// Token: 0x04007EE4 RID: 32484
		private int id_;
	}
}
