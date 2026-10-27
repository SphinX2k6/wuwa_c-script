using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001DA RID: 474
	[NetMessage(EMessageId.BossRushLevelScoreRewardRequest)]
	public sealed class BossRushLevelScoreRewardRequest : IMessage<BossRushLevelScoreRewardRequest>, IMessage, IEquatable<BossRushLevelScoreRewardRequest>, IDeepCloneable<BossRushLevelScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x060035A3 RID: 13731 RVA: 0x00086F6F File Offset: 0x0008516F
		[NullableContext(1)]
		public static BossRushLevelScoreRewardRequest Create()
		{
			return new BossRushLevelScoreRewardRequest();
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x060035A4 RID: 13732 RVA: 0x00086F76 File Offset: 0x00085176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x060035A5 RID: 13733 RVA: 0x00086F79 File Offset: 0x00085179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushLevelScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x00086F80 File Offset: 0x00085180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelScoreRewardRequest()
		{
		}

		// Token: 0x060035A7 RID: 13735 RVA: 0x00086F88 File Offset: 0x00085188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelScoreRewardRequest(BossRushLevelScoreRewardRequest other) : this()
		{
			this.bossRushActivityId_ = other.bossRushActivityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x00086FB9 File Offset: 0x000851B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelScoreRewardRequest Clone()
		{
			return new BossRushLevelScoreRewardRequest(this);
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x060035A9 RID: 13737 RVA: 0x00086FC1 File Offset: 0x000851C1
		// (set) Token: 0x060035AA RID: 13738 RVA: 0x00086FC9 File Offset: 0x000851C9
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

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x060035AB RID: 13739 RVA: 0x00086FD2 File Offset: 0x000851D2
		// (set) Token: 0x060035AC RID: 13740 RVA: 0x00086FDA File Offset: 0x000851DA
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

		// Token: 0x060035AD RID: 13741 RVA: 0x00086FE3 File Offset: 0x000851E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushLevelScoreRewardRequest);
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x00086FF1 File Offset: 0x000851F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushLevelScoreRewardRequest other)
		{
			return other != null && (other == this || (this.BossRushActivityId == other.BossRushActivityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x00087030 File Offset: 0x00085230
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

		// Token: 0x060035B0 RID: 13744 RVA: 0x00087088 File Offset: 0x00085288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x00087095 File Offset: 0x00085295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x000870A0 File Offset: 0x000852A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BossRushActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BossRushActivityId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x000870FC File Offset: 0x000852FC
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

		// Token: 0x060035B4 RID: 13748 RVA: 0x00087154 File Offset: 0x00085354
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

		// Token: 0x060035B5 RID: 13749 RVA: 0x000871A4 File Offset: 0x000853A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x000871B0 File Offset: 0x000853B0
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
				if (num != 40U)
				{
					if (num != 48U)
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

		// Token: 0x04002A6C RID: 10860
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A6D RID: 10861
		public const int BossRushActivityIdFieldNumber = 5;

		// Token: 0x04002A6E RID: 10862
		private int bossRushActivityId_;

		// Token: 0x04002A6F RID: 10863
		public const int IndexFieldNumber = 6;

		// Token: 0x04002A70 RID: 10864
		private int index_;
	}
}
