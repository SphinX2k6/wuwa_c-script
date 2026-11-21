using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001052 RID: 4178
	public sealed class RoleCoopActivityData : IMessage<RoleCoopActivityData>, IMessage, IEquatable<RoleCoopActivityData>, IDeepCloneable<RoleCoopActivityData>, IBufferMessage
	{
		// Token: 0x0601659D RID: 91549 RVA: 0x00340001 File Offset: 0x0033E201
		[NullableContext(1)]
		public static RoleCoopActivityData Create()
		{
			return new RoleCoopActivityData();
		}

		// Token: 0x17004ACB RID: 19147
		// (get) Token: 0x0601659E RID: 91550 RVA: 0x00340008 File Offset: 0x0033E208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004ACC RID: 19148
		// (get) Token: 0x0601659F RID: 91551 RVA: 0x0034000B File Offset: 0x0033E20B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleCoopActivityData.Descriptor;
			}
		}

		// Token: 0x060165A0 RID: 91552 RVA: 0x00340012 File Offset: 0x0033E212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleCoopActivityData()
		{
		}

		// Token: 0x060165A1 RID: 91553 RVA: 0x00340048 File Offset: 0x0033E248
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

		// Token: 0x060165A2 RID: 91554 RVA: 0x003400B0 File Offset: 0x0033E2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleCoopActivityData Clone()
		{
			return new RoleCoopActivityData(this);
		}

		// Token: 0x17004ACD RID: 19149
		// (get) Token: 0x060165A3 RID: 91555 RVA: 0x003400B8 File Offset: 0x0033E2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CoopRoleInfo> CoopRoleInfos
		{
			get
			{
				return this.coopRoleInfos_;
			}
		}

		// Token: 0x17004ACE RID: 19150
		// (get) Token: 0x060165A4 RID: 91556 RVA: 0x003400C0 File Offset: 0x0033E2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardGetList
		{
			get
			{
				return this.rewardGetList_;
			}
		}

		// Token: 0x17004ACF RID: 19151
		// (get) Token: 0x060165A5 RID: 91557 RVA: 0x003400C8 File Offset: 0x0033E2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CoopTaskCompleteInfo> CoopTaskCompleteInfos
		{
			get
			{
				return this.coopTaskCompleteInfos_;
			}
		}

		// Token: 0x17004AD0 RID: 19152
		// (get) Token: 0x060165A6 RID: 91558 RVA: 0x003400D0 File Offset: 0x0033E2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PreCompleteIds
		{
			get
			{
				return this.preCompleteIds_;
			}
		}

		// Token: 0x060165A7 RID: 91559 RVA: 0x003400D8 File Offset: 0x0033E2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleCoopActivityData);
		}

		// Token: 0x060165A8 RID: 91560 RVA: 0x003400E8 File Offset: 0x0033E2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleCoopActivityData other)
		{
			return other != null && (other == this || (this.coopRoleInfos_.Equals(other.coopRoleInfos_) && this.rewardGetList_.Equals(other.rewardGetList_) && this.coopTaskCompleteInfos_.Equals(other.coopTaskCompleteInfos_) && this.preCompleteIds_.Equals(other.preCompleteIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060165A9 RID: 91561 RVA: 0x00340168 File Offset: 0x0033E368
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

		// Token: 0x060165AA RID: 91562 RVA: 0x003401C6 File Offset: 0x0033E3C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060165AB RID: 91563 RVA: 0x003401D3 File Offset: 0x0033E3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060165AC RID: 91564 RVA: 0x003401DC File Offset: 0x0033E3DC
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

		// Token: 0x060165AD RID: 91565 RVA: 0x00340244 File Offset: 0x0033E444
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

		// Token: 0x060165AE RID: 91566 RVA: 0x003402B8 File Offset: 0x0033E4B8
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

		// Token: 0x060165AF RID: 91567 RVA: 0x00340324 File Offset: 0x0033E524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060165B0 RID: 91568 RVA: 0x00340330 File Offset: 0x0033E530
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

		// Token: 0x0400861F RID: 34335
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008620 RID: 34336
		public const int CoopRoleInfosFieldNumber = 2;

		// Token: 0x04008621 RID: 34337
		private static readonly FieldCodec<CoopRoleInfo> _repeated_coopRoleInfos_codec = FieldCodec.ForMessage<CoopRoleInfo>(18U, CoopRoleInfo.Parser);

		// Token: 0x04008622 RID: 34338
		private readonly RepeatedField<CoopRoleInfo> coopRoleInfos_ = new RepeatedField<CoopRoleInfo>();

		// Token: 0x04008623 RID: 34339
		public const int RewardGetListFieldNumber = 3;

		// Token: 0x04008624 RID: 34340
		private static readonly FieldCodec<int> _repeated_rewardGetList_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04008625 RID: 34341
		private readonly RepeatedField<int> rewardGetList_ = new RepeatedField<int>();

		// Token: 0x04008626 RID: 34342
		public const int CoopTaskCompleteInfosFieldNumber = 4;

		// Token: 0x04008627 RID: 34343
		private static readonly FieldCodec<CoopTaskCompleteInfo> _repeated_coopTaskCompleteInfos_codec = FieldCodec.ForMessage<CoopTaskCompleteInfo>(34U, CoopTaskCompleteInfo.Parser);

		// Token: 0x04008628 RID: 34344
		private readonly RepeatedField<CoopTaskCompleteInfo> coopTaskCompleteInfos_ = new RepeatedField<CoopTaskCompleteInfo>();

		// Token: 0x04008629 RID: 34345
		public const int PreCompleteIdsFieldNumber = 5;

		// Token: 0x0400862A RID: 34346
		private static readonly FieldCodec<int> _repeated_preCompleteIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400862B RID: 34347
		private readonly RepeatedField<int> preCompleteIds_ = new RepeatedField<int>();
	}
}
