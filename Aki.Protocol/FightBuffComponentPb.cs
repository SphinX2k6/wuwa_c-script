using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000521 RID: 1313
	public sealed class FightBuffComponentPb : IMessage<FightBuffComponentPb>, IMessage, IEquatable<FightBuffComponentPb>, IDeepCloneable<FightBuffComponentPb>, IBufferMessage
	{
		// Token: 0x06007B7C RID: 31612 RVA: 0x0012B99D File Offset: 0x00129B9D
		[NullableContext(1)]
		public static FightBuffComponentPb Create()
		{
			return new FightBuffComponentPb();
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x06007B7D RID: 31613 RVA: 0x0012B9A4 File Offset: 0x00129BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x06007B7E RID: 31614 RVA: 0x0012B9A7 File Offset: 0x00129BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightBuffComponentPb.Descriptor;
			}
		}

		// Token: 0x06007B7F RID: 31615 RVA: 0x0012B9AE File Offset: 0x00129BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffComponentPb()
		{
		}

		// Token: 0x06007B80 RID: 31616 RVA: 0x0012B9D8 File Offset: 0x00129BD8
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

		// Token: 0x06007B81 RID: 31617 RVA: 0x0012BA3B File Offset: 0x00129C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffComponentPb Clone()
		{
			return new FightBuffComponentPb(this);
		}

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x06007B82 RID: 31618 RVA: 0x0012BA43 File Offset: 0x00129C43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightBuffInformation> FightBuffInfos
		{
			get
			{
				return this.fightBuffInfos_;
			}
		}

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x06007B83 RID: 31619 RVA: 0x0012BA4B File Offset: 0x00129C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BuffEffectCd> ListBuffEffectCd
		{
			get
			{
				return this.listBuffEffectCd_;
			}
		}

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x06007B84 RID: 31620 RVA: 0x0012BA53 File Offset: 0x00129C53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> NeedClientApplyBuffIds
		{
			get
			{
				return this.needClientApplyBuffIds_;
			}
		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x06007B85 RID: 31621 RVA: 0x0012BA5B File Offset: 0x00129C5B
		// (set) Token: 0x06007B86 RID: 31622 RVA: 0x0012BA63 File Offset: 0x00129C63
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

		// Token: 0x06007B87 RID: 31623 RVA: 0x0012BA6C File Offset: 0x00129C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightBuffComponentPb);
		}

		// Token: 0x06007B88 RID: 31624 RVA: 0x0012BA7C File Offset: 0x00129C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightBuffComponentPb other)
		{
			return other != null && (other == this || (this.fightBuffInfos_.Equals(other.fightBuffInfos_) && this.listBuffEffectCd_.Equals(other.listBuffEffectCd_) && this.needClientApplyBuffIds_.Equals(other.needClientApplyBuffIds_) && this.NeedClientApplyBuffIdsMessageId == other.NeedClientApplyBuffIdsMessageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B89 RID: 31625 RVA: 0x0012BAF4 File Offset: 0x00129CF4
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

		// Token: 0x06007B8A RID: 31626 RVA: 0x0012BB5D File Offset: 0x00129D5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007B8B RID: 31627 RVA: 0x0012BB6A File Offset: 0x00129D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B8C RID: 31628 RVA: 0x0012BB74 File Offset: 0x00129D74
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

		// Token: 0x06007B8D RID: 31629 RVA: 0x0012BBE4 File Offset: 0x00129DE4
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

		// Token: 0x06007B8E RID: 31630 RVA: 0x0012BC5C File Offset: 0x00129E5C
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

		// Token: 0x06007B8F RID: 31631 RVA: 0x0012BCCB File Offset: 0x00129ECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B90 RID: 31632 RVA: 0x0012BCD4 File Offset: 0x00129ED4
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

		// Token: 0x04003F82 RID: 16258
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F83 RID: 16259
		public const int FightBuffInfosFieldNumber = 1;

		// Token: 0x04003F84 RID: 16260
		private static readonly FieldCodec<FightBuffInformation> _repeated_fightBuffInfos_codec = FieldCodec.ForMessage<FightBuffInformation>(10U, FightBuffInformation.Parser);

		// Token: 0x04003F85 RID: 16261
		private readonly RepeatedField<FightBuffInformation> fightBuffInfos_ = new RepeatedField<FightBuffInformation>();

		// Token: 0x04003F86 RID: 16262
		public const int ListBuffEffectCdFieldNumber = 2;

		// Token: 0x04003F87 RID: 16263
		private static readonly FieldCodec<BuffEffectCd> _repeated_listBuffEffectCd_codec = FieldCodec.ForMessage<BuffEffectCd>(18U, BuffEffectCd.Parser);

		// Token: 0x04003F88 RID: 16264
		private readonly RepeatedField<BuffEffectCd> listBuffEffectCd_ = new RepeatedField<BuffEffectCd>();

		// Token: 0x04003F89 RID: 16265
		public const int NeedClientApplyBuffIdsFieldNumber = 3;

		// Token: 0x04003F8A RID: 16266
		private static readonly FieldCodec<long> _repeated_needClientApplyBuffIds_codec = FieldCodec.ForInt64(26U);

		// Token: 0x04003F8B RID: 16267
		private readonly RepeatedField<long> needClientApplyBuffIds_ = new RepeatedField<long>();

		// Token: 0x04003F8C RID: 16268
		public const int NeedClientApplyBuffIdsMessageIdFieldNumber = 4;

		// Token: 0x04003F8D RID: 16269
		private long needClientApplyBuffIdsMessageId_;
	}
}
