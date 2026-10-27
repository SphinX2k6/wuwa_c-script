using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B8B RID: 2955
	public sealed class OneInfluenceInfo : IMessage<OneInfluenceInfo>, IMessage, IEquatable<OneInfluenceInfo>, IDeepCloneable<OneInfluenceInfo>, IBufferMessage
	{
		// Token: 0x06010044 RID: 65604 RVA: 0x0025652A File Offset: 0x0025472A
		[NullableContext(1)]
		public static OneInfluenceInfo Create()
		{
			return new OneInfluenceInfo();
		}

		// Token: 0x17003468 RID: 13416
		// (get) Token: 0x06010045 RID: 65605 RVA: 0x00256531 File Offset: 0x00254731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneInfluenceInfo> Parser
		{
			get
			{
				return OneInfluenceInfo._parser;
			}
		}

		// Token: 0x17003469 RID: 13417
		// (get) Token: 0x06010046 RID: 65606 RVA: 0x00256538 File Offset: 0x00254738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700346A RID: 13418
		// (get) Token: 0x06010047 RID: 65607 RVA: 0x0025653B File Offset: 0x0025473B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneInfluenceInfo.Descriptor;
			}
		}

		// Token: 0x06010048 RID: 65608 RVA: 0x00256542 File Offset: 0x00254742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneInfluenceInfo()
		{
		}

		// Token: 0x06010049 RID: 65609 RVA: 0x0025654A File Offset: 0x0025474A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneInfluenceInfo(OneInfluenceInfo other) : this()
		{
			this.influenceId_ = other.influenceId_;
			this.rewardIndex_ = other.rewardIndex_;
			this.relation_ = other.relation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601004A RID: 65610 RVA: 0x00256587 File Offset: 0x00254787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneInfluenceInfo Clone()
		{
			return new OneInfluenceInfo(this);
		}

		// Token: 0x1700346B RID: 13419
		// (get) Token: 0x0601004B RID: 65611 RVA: 0x0025658F File Offset: 0x0025478F
		// (set) Token: 0x0601004C RID: 65612 RVA: 0x00256597 File Offset: 0x00254797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InfluenceId
		{
			get
			{
				return this.influenceId_;
			}
			set
			{
				this.influenceId_ = value;
			}
		}

		// Token: 0x1700346C RID: 13420
		// (get) Token: 0x0601004D RID: 65613 RVA: 0x002565A0 File Offset: 0x002547A0
		// (set) Token: 0x0601004E RID: 65614 RVA: 0x002565A8 File Offset: 0x002547A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardIndex
		{
			get
			{
				return this.rewardIndex_;
			}
			set
			{
				this.rewardIndex_ = value;
			}
		}

		// Token: 0x1700346D RID: 13421
		// (get) Token: 0x0601004F RID: 65615 RVA: 0x002565B1 File Offset: 0x002547B1
		// (set) Token: 0x06010050 RID: 65616 RVA: 0x002565B9 File Offset: 0x002547B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Relation
		{
			get
			{
				return this.relation_;
			}
			set
			{
				this.relation_ = value;
			}
		}

		// Token: 0x06010051 RID: 65617 RVA: 0x002565C2 File Offset: 0x002547C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneInfluenceInfo);
		}

		// Token: 0x06010052 RID: 65618 RVA: 0x002565D0 File Offset: 0x002547D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneInfluenceInfo other)
		{
			return other != null && (other == this || (this.InfluenceId == other.InfluenceId && this.RewardIndex == other.RewardIndex && this.Relation == other.Relation && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010053 RID: 65619 RVA: 0x0025662C File Offset: 0x0025482C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InfluenceId != 0)
			{
				num ^= this.InfluenceId.GetHashCode();
			}
			if (this.RewardIndex != 0)
			{
				num ^= this.RewardIndex.GetHashCode();
			}
			if (this.Relation != 0)
			{
				num ^= this.Relation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010054 RID: 65620 RVA: 0x0025669D File Offset: 0x0025489D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010055 RID: 65621 RVA: 0x002566AA File Offset: 0x002548AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010056 RID: 65622 RVA: 0x002566B4 File Offset: 0x002548B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InfluenceId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InfluenceId);
			}
			if (this.RewardIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RewardIndex);
			}
			if (this.Relation != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Relation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010057 RID: 65623 RVA: 0x00256728 File Offset: 0x00254928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InfluenceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InfluenceId);
			}
			if (this.RewardIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardIndex);
			}
			if (this.Relation != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Relation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010058 RID: 65624 RVA: 0x00256798 File Offset: 0x00254998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneInfluenceInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InfluenceId != 0)
			{
				this.InfluenceId = other.InfluenceId;
			}
			if (other.RewardIndex != 0)
			{
				this.RewardIndex = other.RewardIndex;
			}
			if (other.Relation != 0)
			{
				this.Relation = other.Relation;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010059 RID: 65625 RVA: 0x002567FC File Offset: 0x002549FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601005A RID: 65626 RVA: 0x00256808 File Offset: 0x00254A08
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Relation = input.ReadInt32();
						}
					}
					else
					{
						this.RewardIndex = input.ReadInt32();
					}
				}
				else
				{
					this.InfluenceId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400661E RID: 26142
		private static readonly MessageParser<OneInfluenceInfo> _parser = new MessageParser<OneInfluenceInfo>(() => new OneInfluenceInfo());

		// Token: 0x0400661F RID: 26143
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006620 RID: 26144
		public const int InfluenceIdFieldNumber = 1;

		// Token: 0x04006621 RID: 26145
		private int influenceId_;

		// Token: 0x04006622 RID: 26146
		public const int RewardIndexFieldNumber = 2;

		// Token: 0x04006623 RID: 26147
		private int rewardIndex_;

		// Token: 0x04006624 RID: 26148
		public const int RelationFieldNumber = 3;

		// Token: 0x04006625 RID: 26149
		private int relation_;
	}
}
