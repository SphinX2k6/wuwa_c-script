using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001282 RID: 4738
	[NetMessage(EMessageId.SkinRewardRequest)]
	public sealed class SkinRewardRequest : IMessage<SkinRewardRequest>, IMessage, IEquatable<SkinRewardRequest>, IDeepCloneable<SkinRewardRequest>, IBufferMessage
	{
		// Token: 0x060194B5 RID: 103605 RVA: 0x003B0820 File Offset: 0x003AEA20
		[NullableContext(1)]
		public static SkinRewardRequest Create()
		{
			return new SkinRewardRequest();
		}

		// Token: 0x1700558D RID: 21901
		// (get) Token: 0x060194B6 RID: 103606 RVA: 0x003B0827 File Offset: 0x003AEA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700558E RID: 21902
		// (get) Token: 0x060194B7 RID: 103607 RVA: 0x003B082A File Offset: 0x003AEA2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkinRewardRequest.Descriptor;
			}
		}

		// Token: 0x060194B8 RID: 103608 RVA: 0x003B0831 File Offset: 0x003AEA31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardRequest()
		{
		}

		// Token: 0x060194B9 RID: 103609 RVA: 0x003B0839 File Offset: 0x003AEA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardRequest(SkinRewardRequest other) : this()
		{
			this.rewardId_ = other.rewardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060194BA RID: 103610 RVA: 0x003B085E File Offset: 0x003AEA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardRequest Clone()
		{
			return new SkinRewardRequest(this);
		}

		// Token: 0x1700558F RID: 21903
		// (get) Token: 0x060194BB RID: 103611 RVA: 0x003B0866 File Offset: 0x003AEA66
		// (set) Token: 0x060194BC RID: 103612 RVA: 0x003B086E File Offset: 0x003AEA6E
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

		// Token: 0x060194BD RID: 103613 RVA: 0x003B0877 File Offset: 0x003AEA77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkinRewardRequest);
		}

		// Token: 0x060194BE RID: 103614 RVA: 0x003B0885 File Offset: 0x003AEA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkinRewardRequest other)
		{
			return other != null && (other == this || (this.RewardId == other.RewardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060194BF RID: 103615 RVA: 0x003B08B4 File Offset: 0x003AEAB4
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

		// Token: 0x060194C0 RID: 103616 RVA: 0x003B08F3 File Offset: 0x003AEAF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060194C1 RID: 103617 RVA: 0x003B0900 File Offset: 0x003AEB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060194C2 RID: 103618 RVA: 0x003B0909 File Offset: 0x003AEB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060194C3 RID: 103619 RVA: 0x003B093C File Offset: 0x003AEB3C
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

		// Token: 0x060194C4 RID: 103620 RVA: 0x003B097A File Offset: 0x003AEB7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkinRewardRequest other)
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

		// Token: 0x060194C5 RID: 103621 RVA: 0x003B09AB File Offset: 0x003AEBAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060194C6 RID: 103622 RVA: 0x003B09B4 File Offset: 0x003AEBB4
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
					this.RewardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040095AB RID: 38315
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095AC RID: 38316
		public const int RewardIdFieldNumber = 14;

		// Token: 0x040095AD RID: 38317
		private int rewardId_;
	}
}
