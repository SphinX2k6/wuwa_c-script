using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006CF RID: 1743
	[NetMessage(EMessageId.GetRewardTreasureBoxRequest)]
	public sealed class GetRewardTreasureBoxRequest : IMessage<GetRewardTreasureBoxRequest>, IMessage, IEquatable<GetRewardTreasureBoxRequest>, IDeepCloneable<GetRewardTreasureBoxRequest>, IBufferMessage
	{
		// Token: 0x06009F52 RID: 40786 RVA: 0x00182454 File Offset: 0x00180654
		[NullableContext(1)]
		public static GetRewardTreasureBoxRequest Create()
		{
			return new GetRewardTreasureBoxRequest();
		}

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x06009F53 RID: 40787 RVA: 0x0018245B File Offset: 0x0018065B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x06009F54 RID: 40788 RVA: 0x0018245E File Offset: 0x0018065E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRewardTreasureBoxRequest.Descriptor;
			}
		}

		// Token: 0x06009F55 RID: 40789 RVA: 0x00182465 File Offset: 0x00180665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRewardTreasureBoxRequest()
		{
		}

		// Token: 0x06009F56 RID: 40790 RVA: 0x0018246D File Offset: 0x0018066D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRewardTreasureBoxRequest(GetRewardTreasureBoxRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F57 RID: 40791 RVA: 0x00182492 File Offset: 0x00180692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRewardTreasureBoxRequest Clone()
		{
			return new GetRewardTreasureBoxRequest(this);
		}

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x06009F58 RID: 40792 RVA: 0x0018249A File Offset: 0x0018069A
		// (set) Token: 0x06009F59 RID: 40793 RVA: 0x001824A2 File Offset: 0x001806A2
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

		// Token: 0x06009F5A RID: 40794 RVA: 0x001824AB File Offset: 0x001806AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRewardTreasureBoxRequest);
		}

		// Token: 0x06009F5B RID: 40795 RVA: 0x001824B9 File Offset: 0x001806B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRewardTreasureBoxRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F5C RID: 40796 RVA: 0x001824E8 File Offset: 0x001806E8
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

		// Token: 0x06009F5D RID: 40797 RVA: 0x00182527 File Offset: 0x00180727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009F5E RID: 40798 RVA: 0x00182534 File Offset: 0x00180734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F5F RID: 40799 RVA: 0x0018253D File Offset: 0x0018073D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F60 RID: 40800 RVA: 0x00182570 File Offset: 0x00180770
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

		// Token: 0x06009F61 RID: 40801 RVA: 0x001825AE File Offset: 0x001807AE
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

		// Token: 0x06009F62 RID: 40802 RVA: 0x001825DF File Offset: 0x001807DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F63 RID: 40803 RVA: 0x001825E8 File Offset: 0x001807E8
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004A69 RID: 19049
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A6A RID: 19050
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04004A6B RID: 19051
		private long entityId_;
	}
}
