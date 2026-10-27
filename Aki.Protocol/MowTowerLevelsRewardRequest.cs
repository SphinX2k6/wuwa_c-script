using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ACE RID: 2766
	[NetMessage(EMessageId.MowTowerLevelsRewardRequest)]
	public sealed class MowTowerLevelsRewardRequest : IMessage<MowTowerLevelsRewardRequest>, IMessage, IEquatable<MowTowerLevelsRewardRequest>, IDeepCloneable<MowTowerLevelsRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F0D5 RID: 61653 RVA: 0x00233179 File Offset: 0x00231379
		[NullableContext(1)]
		public static MowTowerLevelsRewardRequest Create()
		{
			return new MowTowerLevelsRewardRequest();
		}

		// Token: 0x1700310D RID: 12557
		// (get) Token: 0x0600F0D6 RID: 61654 RVA: 0x00233180 File Offset: 0x00231380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700310E RID: 12558
		// (get) Token: 0x0600F0D7 RID: 61655 RVA: 0x00233183 File Offset: 0x00231383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerLevelsRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F0D8 RID: 61656 RVA: 0x0023318A File Offset: 0x0023138A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsRewardRequest()
		{
		}

		// Token: 0x0600F0D9 RID: 61657 RVA: 0x00233192 File Offset: 0x00231392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsRewardRequest(MowTowerLevelsRewardRequest other) : this()
		{
			this.rewardId_ = other.rewardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F0DA RID: 61658 RVA: 0x002331B7 File Offset: 0x002313B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsRewardRequest Clone()
		{
			return new MowTowerLevelsRewardRequest(this);
		}

		// Token: 0x1700310F RID: 12559
		// (get) Token: 0x0600F0DB RID: 61659 RVA: 0x002331BF File Offset: 0x002313BF
		// (set) Token: 0x0600F0DC RID: 61660 RVA: 0x002331C7 File Offset: 0x002313C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardId
		{
			get
			{
				return this.rewardId_;
			}
			set
			{
				this.rewardId_ = value;
			}
		}

		// Token: 0x0600F0DD RID: 61661 RVA: 0x002331D0 File Offset: 0x002313D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerLevelsRewardRequest);
		}

		// Token: 0x0600F0DE RID: 61662 RVA: 0x002331DE File Offset: 0x002313DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerLevelsRewardRequest other)
		{
			return other != null && (other == this || (this.RewardId == other.RewardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F0DF RID: 61663 RVA: 0x0023320C File Offset: 0x0023140C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RewardId != 0)
			{
				num ^= this.RewardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F0E0 RID: 61664 RVA: 0x0023324B File Offset: 0x0023144B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F0E1 RID: 61665 RVA: 0x00233258 File Offset: 0x00231458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F0E2 RID: 61666 RVA: 0x00233261 File Offset: 0x00231461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F0E3 RID: 61667 RVA: 0x00233294 File Offset: 0x00231494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F0E4 RID: 61668 RVA: 0x002332D2 File Offset: 0x002314D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MowTowerLevelsRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RewardId != 0)
			{
				this.RewardId = other.RewardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F0E5 RID: 61669 RVA: 0x00233303 File Offset: 0x00231503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F0E6 RID: 61670 RVA: 0x0023330C File Offset: 0x0023150C
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RewardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400615F RID: 24927
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006160 RID: 24928
		public const int RewardIdFieldNumber = 1;

		// Token: 0x04006161 RID: 24929
		private int rewardId_;
	}
}
