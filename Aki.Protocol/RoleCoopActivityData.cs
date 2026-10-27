using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001062 RID: 4194
	public sealed class RoleCoopActivityData : IMessage<RoleCoopActivityData>, IMessage, IEquatable<RoleCoopActivityData>, IDeepCloneable<RoleCoopActivityData>, IBufferMessage
	{
		// Token: 0x06016682 RID: 91778 RVA: 0x003416D5 File Offset: 0x0033F8D5
		[NullableContext(1)]
		public static RoleCoopActivityData Create()
		{
			return new RoleCoopActivityData();
		}

		// Token: 0x17004AF5 RID: 19189
		// (get) Token: 0x06016683 RID: 91779 RVA: 0x003416DC File Offset: 0x0033F8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AF6 RID: 19190
		// (get) Token: 0x06016684 RID: 91780 RVA: 0x003416DF File Offset: 0x0033F8DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleCoopActivityData.Descriptor;
			}
		}

		// Token: 0x06016685 RID: 91781 RVA: 0x003416E6 File Offset: 0x0033F8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleCoopActivityData()
		{
		}

		// Token: 0x06016686 RID: 91782 RVA: 0x0034171C File Offset: 0x0033F91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleCoopActivityData(RoleCoopActivityData other) : this()
		{
			this.coopRoleInfos_ = other.coopRoleInfos_.Clone();
			this.rewardGetList_ = other.rewardGetList_.Clone();
			this.coopTaskCompleteInfos_ = other.coopTaskCompleteInfos_.Clone();
			this.preCompleteIds_ = other.preCompleteIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016687 RID: 91783 RVA: 0x00341784 File Offset: 0x0033F984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleCoopActivityData Clone()
		{
			return new RoleCoopActivityData(this);
		}

		// Token: 0x17004AF7 RID: 19191
		// (get) Token: 0x06016688 RID: 91784 RVA: 0x0034178C File Offset: 0x0033F98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CoopRoleInfo> CoopRoleInfos
		{
			get
			{
				return this.coopRoleInfos_;
			}
		}

		// Token: 0x17004AF8 RID: 19192
		// (get) Token: 0x06016689 RID: 91785 RVA: 0x00341794 File Offset: 0x0033F994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardGetList
		{
			get
			{
				return this.rewardGetList_;
			}
		}

		// Token: 0x17004AF9 RID: 19193
		// (get) Token: 0x0601668A RID: 91786 RVA: 0x0034179C File Offset: 0x0033F99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CoopTaskCompleteInfo> CoopTaskCompleteInfos
		{
			get
			{
				return this.coopTaskCompleteInfos_;
			}
		}

		// Token: 0x17004AFA RID: 19194
		// (get) Token: 0x0601668B RID: 91787 RVA: 0x003417A4 File Offset: 0x0033F9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PreCompleteIds
		{
			get
			{
				return this.preCompleteIds_;
			}
		}

		// Token: 0x0601668C RID: 91788 RVA: 0x003417AC File Offset: 0x0033F9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleCoopActivityData);
		}

		// Token: 0x0601668D RID: 91789 RVA: 0x003417BC File Offset: 0x0033F9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleCoopActivityData other)
		{
			return other != null && (other == this || (this.coopRoleInfos_.Equals(other.coopRoleInfos_) && this.rewardGetList_.Equals(other.rewardGetList_) && this.coopTaskCompleteInfos_.Equals(other.coopTaskCompleteInfos_) && this.preCompleteIds_.Equals(other.preCompleteIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601668E RID: 91790 RVA: 0x0034183C File Offset: 0x0033FA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.coopRoleInfos_.GetHashCode();
			num ^= this.rewardGetList_.GetHashCode();
			num ^= this.coopTaskCompleteInfos_.GetHashCode();
			num ^= this.preCompleteIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601668F RID: 91791 RVA: 0x0034189A File Offset: 0x0033FA9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016690 RID: 91792 RVA: 0x003418A7 File Offset: 0x0033FAA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016691 RID: 91793 RVA: 0x003418B0 File Offset: 0x0033FAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.coopRoleInfos_.WriteTo(ref output, RoleCoopActivityData._repeated_coopRoleInfos_codec);
			this.rewardGetList_.WriteTo(ref output, RoleCoopActivityData._repeated_rewardGetList_codec);
			this.coopTaskCompleteInfos_.WriteTo(ref output, RoleCoopActivityData._repeated_coopTaskCompleteInfos_codec);
			this.preCompleteIds_.WriteTo(ref output, RoleCoopActivityData._repeated_preCompleteIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016692 RID: 91794 RVA: 0x00341918 File Offset: 0x0033FB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.coopRoleInfos_.CalculateSize(RoleCoopActivityData._repeated_coopRoleInfos_codec);
			num += this.rewardGetList_.CalculateSize(RoleCoopActivityData._repeated_rewardGetList_codec);
			num += this.coopTaskCompleteInfos_.CalculateSize(RoleCoopActivityData._repeated_coopTaskCompleteInfos_codec);
			num += this.preCompleteIds_.CalculateSize(RoleCoopActivityData._repeated_preCompleteIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016693 RID: 91795 RVA: 0x0034198C File Offset: 0x0033FB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleCoopActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.coopRoleInfos_.Add(other.coopRoleInfos_);
			this.rewardGetList_.Add(other.rewardGetList_);
			this.coopTaskCompleteInfos_.Add(other.coopTaskCompleteInfos_);
			this.preCompleteIds_.Add(other.preCompleteIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016694 RID: 91796 RVA: 0x003419F8 File Offset: 0x0033FBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016695 RID: 91797 RVA: 0x00341A04 File Offset: 0x0033FC04
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
				if (num <= 26U)
				{
					if (num == 18U)
					{
						this.coopRoleInfos_.AddEntriesFrom(ref input, RoleCoopActivityData._repeated_coopRoleInfos_codec);
						continue;
					}
					if (num == 24U || num == 26U)
					{
						this.rewardGetList_.AddEntriesFrom(ref input, RoleCoopActivityData._repeated_rewardGetList_codec);
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.coopTaskCompleteInfos_.AddEntriesFrom(ref input, RoleCoopActivityData._repeated_coopTaskCompleteInfos_codec);
						continue;
					}
					if (num == 40U || num == 42U)
					{
						this.preCompleteIds_.AddEntriesFrom(ref input, RoleCoopActivityData._repeated_preCompleteIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040085F5 RID: 34293
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085F6 RID: 34294
		public const int CoopRoleInfosFieldNumber = 2;

		// Token: 0x040085F7 RID: 34295
		private static readonly FieldCodec<CoopRoleInfo> _repeated_coopRoleInfos_codec = FieldCodec.ForMessage<CoopRoleInfo>(18U, CoopRoleInfo.Parser);

		// Token: 0x040085F8 RID: 34296
		private readonly RepeatedField<CoopRoleInfo> coopRoleInfos_ = new RepeatedField<CoopRoleInfo>();

		// Token: 0x040085F9 RID: 34297
		public const int RewardGetListFieldNumber = 3;

		// Token: 0x040085FA RID: 34298
		private static readonly FieldCodec<int> _repeated_rewardGetList_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040085FB RID: 34299
		private readonly RepeatedField<int> rewardGetList_ = new RepeatedField<int>();

		// Token: 0x040085FC RID: 34300
		public const int CoopTaskCompleteInfosFieldNumber = 4;

		// Token: 0x040085FD RID: 34301
		private static readonly FieldCodec<CoopTaskCompleteInfo> _repeated_coopTaskCompleteInfos_codec = FieldCodec.ForMessage<CoopTaskCompleteInfo>(34U, CoopTaskCompleteInfo.Parser);

		// Token: 0x040085FE RID: 34302
		private readonly RepeatedField<CoopTaskCompleteInfo> coopTaskCompleteInfos_ = new RepeatedField<CoopTaskCompleteInfo>();

		// Token: 0x040085FF RID: 34303
		public const int PreCompleteIdsFieldNumber = 5;

		// Token: 0x04008600 RID: 34304
		private static readonly FieldCodec<int> _repeated_preCompleteIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04008601 RID: 34305
		private readonly RepeatedField<int> preCompleteIds_ = new RepeatedField<int>();
	}
}
