using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B7B RID: 2939
	public sealed class OneInfluenceInfo : IMessage<OneInfluenceInfo>, IMessage, IEquatable<OneInfluenceInfo>, IDeepCloneable<OneInfluenceInfo>, IBufferMessage
	{
		// Token: 0x0600FF40 RID: 65344 RVA: 0x0025465A File Offset: 0x0025285A
		[NullableContext(1)]
		public static OneInfluenceInfo Create()
		{
			return new OneInfluenceInfo();
		}

		// Token: 0x1700342F RID: 13359
		// (get) Token: 0x0600FF41 RID: 65345 RVA: 0x00254661 File Offset: 0x00252861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneInfluenceInfo> Parser
		{
			get
			{
				return OneInfluenceInfo._parser;
			}
		}

		// Token: 0x17003430 RID: 13360
		// (get) Token: 0x0600FF42 RID: 65346 RVA: 0x00254668 File Offset: 0x00252868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003431 RID: 13361
		// (get) Token: 0x0600FF43 RID: 65347 RVA: 0x0025466B File Offset: 0x0025286B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneInfluenceInfo.Descriptor;
			}
		}

		// Token: 0x0600FF44 RID: 65348 RVA: 0x00254672 File Offset: 0x00252872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneInfluenceInfo()
		{
		}

		// Token: 0x0600FF45 RID: 65349 RVA: 0x0025467A File Offset: 0x0025287A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneInfluenceInfo(OneInfluenceInfo other) : this()
		{
			this.influenceId_ = other.influenceId_;
			this.rewardIndex_ = other.rewardIndex_;
			this.relation_ = other.relation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FF46 RID: 65350 RVA: 0x002546B7 File Offset: 0x002528B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneInfluenceInfo Clone()
		{
			return new OneInfluenceInfo(this);
		}

		// Token: 0x17003432 RID: 13362
		// (get) Token: 0x0600FF47 RID: 65351 RVA: 0x002546BF File Offset: 0x002528BF
		// (set) Token: 0x0600FF48 RID: 65352 RVA: 0x002546C7 File Offset: 0x002528C7
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

		// Token: 0x17003433 RID: 13363
		// (get) Token: 0x0600FF49 RID: 65353 RVA: 0x002546D0 File Offset: 0x002528D0
		// (set) Token: 0x0600FF4A RID: 65354 RVA: 0x002546D8 File Offset: 0x002528D8
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

		// Token: 0x17003434 RID: 13364
		// (get) Token: 0x0600FF4B RID: 65355 RVA: 0x002546E1 File Offset: 0x002528E1
		// (set) Token: 0x0600FF4C RID: 65356 RVA: 0x002546E9 File Offset: 0x002528E9
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

		// Token: 0x0600FF4D RID: 65357 RVA: 0x002546F2 File Offset: 0x002528F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneInfluenceInfo);
		}

		// Token: 0x0600FF4E RID: 65358 RVA: 0x00254700 File Offset: 0x00252900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneInfluenceInfo other)
		{
			return other != null && (other == this || (this.InfluenceId == other.InfluenceId && this.RewardIndex == other.RewardIndex && this.Relation == other.Relation && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FF4F RID: 65359 RVA: 0x0025475C File Offset: 0x0025295C
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

		// Token: 0x0600FF50 RID: 65360 RVA: 0x002547CD File Offset: 0x002529CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FF51 RID: 65361 RVA: 0x002547DA File Offset: 0x002529DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FF52 RID: 65362 RVA: 0x002547E4 File Offset: 0x002529E4
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

		// Token: 0x0600FF53 RID: 65363 RVA: 0x00254858 File Offset: 0x00252A58
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

		// Token: 0x0600FF54 RID: 65364 RVA: 0x002548C8 File Offset: 0x00252AC8
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

		// Token: 0x0600FF55 RID: 65365 RVA: 0x0025492C File Offset: 0x00252B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FF56 RID: 65366 RVA: 0x00254938 File Offset: 0x00252B38
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

		// Token: 0x0400662E RID: 26158
		private static readonly MessageParser<OneInfluenceInfo> _parser = new MessageParser<OneInfluenceInfo>(() => new OneInfluenceInfo());

		// Token: 0x0400662F RID: 26159
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006630 RID: 26160
		public const int InfluenceIdFieldNumber = 1;

		// Token: 0x04006631 RID: 26161
		private int influenceId_;

		// Token: 0x04006632 RID: 26162
		public const int RewardIndexFieldNumber = 2;

		// Token: 0x04006633 RID: 26163
		private int rewardIndex_;

		// Token: 0x04006634 RID: 26164
		public const int RelationFieldNumber = 3;

		// Token: 0x04006635 RID: 26165
		private int relation_;
	}
}
