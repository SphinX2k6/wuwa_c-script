using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001DE RID: 478
	[NetMessage(EMessageId.BossRushLevelScoreRewardRequest)]
	public sealed class BossRushLevelScoreRewardRequest : IMessage<BossRushLevelScoreRewardRequest>, IMessage, IEquatable<BossRushLevelScoreRewardRequest>, IDeepCloneable<BossRushLevelScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x06003630 RID: 13872 RVA: 0x000886E3 File Offset: 0x000868E3
		[NullableContext(1)]
		public static BossRushLevelScoreRewardRequest Create()
		{
			return new BossRushLevelScoreRewardRequest();
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06003631 RID: 13873 RVA: 0x000886EA File Offset: 0x000868EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06003632 RID: 13874 RVA: 0x000886ED File Offset: 0x000868ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushLevelScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x000886F4 File Offset: 0x000868F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelScoreRewardRequest()
		{
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x000886FC File Offset: 0x000868FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelScoreRewardRequest(BossRushLevelScoreRewardRequest other) : this()
		{
			this.bossRushActivityId_ = other.bossRushActivityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x0008872D File Offset: 0x0008692D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelScoreRewardRequest Clone()
		{
			return new BossRushLevelScoreRewardRequest(this);
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06003636 RID: 13878 RVA: 0x00088735 File Offset: 0x00086935
		// (set) Token: 0x06003637 RID: 13879 RVA: 0x0008873D File Offset: 0x0008693D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BossRushActivityId
		{
			get
			{
				return this.bossRushActivityId_;
			}
			set
			{
				this.bossRushActivityId_ = value;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06003638 RID: 13880 RVA: 0x00088746 File Offset: 0x00086946
		// (set) Token: 0x06003639 RID: 13881 RVA: 0x0008874E File Offset: 0x0008694E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x00088757 File Offset: 0x00086957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushLevelScoreRewardRequest);
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x00088765 File Offset: 0x00086965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushLevelScoreRewardRequest other)
		{
			return other != null && (other == this || (this.BossRushActivityId == other.BossRushActivityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x000887A4 File Offset: 0x000869A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BossRushActivityId != 0)
			{
				num ^= this.BossRushActivityId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x000887FC File Offset: 0x000869FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x00088809 File Offset: 0x00086A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x00088814 File Offset: 0x00086A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BossRushActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BossRushActivityId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x00088870 File Offset: 0x00086A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BossRushActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BossRushActivityId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x000888C8 File Offset: 0x00086AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushLevelScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BossRushActivityId != 0)
			{
				this.BossRushActivityId = other.BossRushActivityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x00088918 File Offset: 0x00086B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x00088924 File Offset: 0x00086B24
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
				if (num != 32U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.BossRushActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002AE7 RID: 10983
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AE8 RID: 10984
		public const int BossRushActivityIdFieldNumber = 4;

		// Token: 0x04002AE9 RID: 10985
		private int bossRushActivityId_;

		// Token: 0x04002AEA RID: 10986
		public const int IndexFieldNumber = 10;

		// Token: 0x04002AEB RID: 10987
		private int index_;
	}
}
