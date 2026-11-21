using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006BB RID: 1723
	[NetMessage(EMessageId.GetRewardTreasureBoxRequest)]
	public sealed class GetRewardTreasureBoxRequest : IMessage<GetRewardTreasureBoxRequest>, IMessage, IEquatable<GetRewardTreasureBoxRequest>, IDeepCloneable<GetRewardTreasureBoxRequest>, IBufferMessage
	{
		// Token: 0x06009DFC RID: 40444 RVA: 0x0017FA1F File Offset: 0x0017DC1F
		[NullableContext(1)]
		public static GetRewardTreasureBoxRequest Create()
		{
			return new GetRewardTreasureBoxRequest();
		}

		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x06009DFD RID: 40445 RVA: 0x0017FA26 File Offset: 0x0017DC26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x06009DFE RID: 40446 RVA: 0x0017FA29 File Offset: 0x0017DC29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRewardTreasureBoxRequest.Descriptor;
			}
		}

		// Token: 0x06009DFF RID: 40447 RVA: 0x0017FA30 File Offset: 0x0017DC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRewardTreasureBoxRequest()
		{
		}

		// Token: 0x06009E00 RID: 40448 RVA: 0x0017FA38 File Offset: 0x0017DC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRewardTreasureBoxRequest(GetRewardTreasureBoxRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E01 RID: 40449 RVA: 0x0017FA5D File Offset: 0x0017DC5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRewardTreasureBoxRequest Clone()
		{
			return new GetRewardTreasureBoxRequest(this);
		}

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x06009E02 RID: 40450 RVA: 0x0017FA65 File Offset: 0x0017DC65
		// (set) Token: 0x06009E03 RID: 40451 RVA: 0x0017FA6D File Offset: 0x0017DC6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x06009E04 RID: 40452 RVA: 0x0017FA76 File Offset: 0x0017DC76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRewardTreasureBoxRequest);
		}

		// Token: 0x06009E05 RID: 40453 RVA: 0x0017FA84 File Offset: 0x0017DC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRewardTreasureBoxRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E06 RID: 40454 RVA: 0x0017FAB4 File Offset: 0x0017DCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009E07 RID: 40455 RVA: 0x0017FAF3 File Offset: 0x0017DCF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009E08 RID: 40456 RVA: 0x0017FB00 File Offset: 0x0017DD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E09 RID: 40457 RVA: 0x0017FB09 File Offset: 0x0017DD09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E0A RID: 40458 RVA: 0x0017FB3C File Offset: 0x0017DD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009E0B RID: 40459 RVA: 0x0017FB7A File Offset: 0x0017DD7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRewardTreasureBoxRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009E0C RID: 40460 RVA: 0x0017FBAB File Offset: 0x0017DDAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E0D RID: 40461 RVA: 0x0017FBB4 File Offset: 0x0017DDB4
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004A62 RID: 19042
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A63 RID: 19043
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04004A64 RID: 19044
		private long entityId_;
	}
}
