using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000536 RID: 1334
	public sealed class FightBuffComponentPb : IMessage<FightBuffComponentPb>, IMessage, IEquatable<FightBuffComponentPb>, IDeepCloneable<FightBuffComponentPb>, IBufferMessage
	{
		// Token: 0x06007CE4 RID: 31972 RVA: 0x0012E5A1 File Offset: 0x0012C7A1
		[NullableContext(1)]
		public static FightBuffComponentPb Create()
		{
			return new FightBuffComponentPb();
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x06007CE5 RID: 31973 RVA: 0x0012E5A8 File Offset: 0x0012C7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x06007CE6 RID: 31974 RVA: 0x0012E5AB File Offset: 0x0012C7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightBuffComponentPb.Descriptor;
			}
		}

		// Token: 0x06007CE7 RID: 31975 RVA: 0x0012E5B2 File Offset: 0x0012C7B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffComponentPb()
		{
		}

		// Token: 0x06007CE8 RID: 31976 RVA: 0x0012E5DC File Offset: 0x0012C7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffComponentPb(FightBuffComponentPb other) : this()
		{
			this.fightBuffInfos_ = other.fightBuffInfos_.Clone();
			this.listBuffEffectCd_ = other.listBuffEffectCd_.Clone();
			this.needClientApplyBuffIds_ = other.needClientApplyBuffIds_.Clone();
			this.needClientApplyBuffIdsMessageId_ = other.needClientApplyBuffIdsMessageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007CE9 RID: 31977 RVA: 0x0012E63F File Offset: 0x0012C83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffComponentPb Clone()
		{
			return new FightBuffComponentPb(this);
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x06007CEA RID: 31978 RVA: 0x0012E647 File Offset: 0x0012C847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightBuffInformation> FightBuffInfos
		{
			get
			{
				return this.fightBuffInfos_;
			}
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x06007CEB RID: 31979 RVA: 0x0012E64F File Offset: 0x0012C84F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BuffEffectCd> ListBuffEffectCd
		{
			get
			{
				return this.listBuffEffectCd_;
			}
		}

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x06007CEC RID: 31980 RVA: 0x0012E657 File Offset: 0x0012C857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> NeedClientApplyBuffIds
		{
			get
			{
				return this.needClientApplyBuffIds_;
			}
		}

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x06007CED RID: 31981 RVA: 0x0012E65F File Offset: 0x0012C85F
		// (set) Token: 0x06007CEE RID: 31982 RVA: 0x0012E667 File Offset: 0x0012C867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NeedClientApplyBuffIdsMessageId
		{
			get
			{
				return this.needClientApplyBuffIdsMessageId_;
			}
			set
			{
				this.needClientApplyBuffIdsMessageId_ = value;
			}
		}

		// Token: 0x06007CEF RID: 31983 RVA: 0x0012E670 File Offset: 0x0012C870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightBuffComponentPb);
		}

		// Token: 0x06007CF0 RID: 31984 RVA: 0x0012E680 File Offset: 0x0012C880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightBuffComponentPb other)
		{
			return other != null && (other == this || (this.fightBuffInfos_.Equals(other.fightBuffInfos_) && this.listBuffEffectCd_.Equals(other.listBuffEffectCd_) && this.needClientApplyBuffIds_.Equals(other.needClientApplyBuffIds_) && this.NeedClientApplyBuffIdsMessageId == other.NeedClientApplyBuffIdsMessageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007CF1 RID: 31985 RVA: 0x0012E6F8 File Offset: 0x0012C8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fightBuffInfos_.GetHashCode();
			num ^= this.listBuffEffectCd_.GetHashCode();
			num ^= this.needClientApplyBuffIds_.GetHashCode();
			if (this.NeedClientApplyBuffIdsMessageId != 0L)
			{
				num ^= this.NeedClientApplyBuffIdsMessageId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007CF2 RID: 31986 RVA: 0x0012E761 File Offset: 0x0012C961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007CF3 RID: 31987 RVA: 0x0012E76E File Offset: 0x0012C96E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007CF4 RID: 31988 RVA: 0x0012E778 File Offset: 0x0012C978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fightBuffInfos_.WriteTo(ref output, FightBuffComponentPb._repeated_fightBuffInfos_codec);
			this.listBuffEffectCd_.WriteTo(ref output, FightBuffComponentPb._repeated_listBuffEffectCd_codec);
			this.needClientApplyBuffIds_.WriteTo(ref output, FightBuffComponentPb._repeated_needClientApplyBuffIds_codec);
			if (this.NeedClientApplyBuffIdsMessageId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.NeedClientApplyBuffIdsMessageId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007CF5 RID: 31989 RVA: 0x0012E7E8 File Offset: 0x0012C9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fightBuffInfos_.CalculateSize(FightBuffComponentPb._repeated_fightBuffInfos_codec);
			num += this.listBuffEffectCd_.CalculateSize(FightBuffComponentPb._repeated_listBuffEffectCd_codec);
			num += this.needClientApplyBuffIds_.CalculateSize(FightBuffComponentPb._repeated_needClientApplyBuffIds_codec);
			if (this.NeedClientApplyBuffIdsMessageId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NeedClientApplyBuffIdsMessageId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007CF6 RID: 31990 RVA: 0x0012E860 File Offset: 0x0012CA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightBuffComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.fightBuffInfos_.Add(other.fightBuffInfos_);
			this.listBuffEffectCd_.Add(other.listBuffEffectCd_);
			this.needClientApplyBuffIds_.Add(other.needClientApplyBuffIds_);
			if (other.NeedClientApplyBuffIdsMessageId != 0L)
			{
				this.NeedClientApplyBuffIdsMessageId = other.NeedClientApplyBuffIdsMessageId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007CF7 RID: 31991 RVA: 0x0012E8CF File Offset: 0x0012CACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007CF8 RID: 31992 RVA: 0x0012E8D8 File Offset: 0x0012CAD8
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						this.fightBuffInfos_.AddEntriesFrom(ref input, FightBuffComponentPb._repeated_fightBuffInfos_codec);
						continue;
					}
					if (num == 18U)
					{
						this.listBuffEffectCd_.AddEntriesFrom(ref input, FightBuffComponentPb._repeated_listBuffEffectCd_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.needClientApplyBuffIds_.AddEntriesFrom(ref input, FightBuffComponentPb._repeated_needClientApplyBuffIds_codec);
						continue;
					}
					if (num == 32U)
					{
						this.NeedClientApplyBuffIdsMessageId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003F8C RID: 16268
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F8D RID: 16269
		public const int FightBuffInfosFieldNumber = 1;

		// Token: 0x04003F8E RID: 16270
		private static readonly FieldCodec<FightBuffInformation> _repeated_fightBuffInfos_codec = FieldCodec.ForMessage<FightBuffInformation>(10U, FightBuffInformation.Parser);

		// Token: 0x04003F8F RID: 16271
		private readonly RepeatedField<FightBuffInformation> fightBuffInfos_ = new RepeatedField<FightBuffInformation>();

		// Token: 0x04003F90 RID: 16272
		public const int ListBuffEffectCdFieldNumber = 2;

		// Token: 0x04003F91 RID: 16273
		private static readonly FieldCodec<BuffEffectCd> _repeated_listBuffEffectCd_codec = FieldCodec.ForMessage<BuffEffectCd>(18U, BuffEffectCd.Parser);

		// Token: 0x04003F92 RID: 16274
		private readonly RepeatedField<BuffEffectCd> listBuffEffectCd_ = new RepeatedField<BuffEffectCd>();

		// Token: 0x04003F93 RID: 16275
		public const int NeedClientApplyBuffIdsFieldNumber = 3;

		// Token: 0x04003F94 RID: 16276
		private static readonly FieldCodec<long> _repeated_needClientApplyBuffIds_codec = FieldCodec.ForInt64(26U);

		// Token: 0x04003F95 RID: 16277
		private readonly RepeatedField<long> needClientApplyBuffIds_ = new RepeatedField<long>();

		// Token: 0x04003F96 RID: 16278
		public const int NeedClientApplyBuffIdsMessageIdFieldNumber = 4;

		// Token: 0x04003F97 RID: 16279
		private long needClientApplyBuffIdsMessageId_;
	}
}
