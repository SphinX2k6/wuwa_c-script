using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C32 RID: 3122
	[NetMessage(EMessageId.PhantomBattleCallCardRequest)]
	public sealed class PhantomBattleCallCardRequest : IMessage<PhantomBattleCallCardRequest>, IMessage, IEquatable<PhantomBattleCallCardRequest>, IDeepCloneable<PhantomBattleCallCardRequest>, IBufferMessage
	{
		// Token: 0x06010F45 RID: 69445 RVA: 0x0027BE6E File Offset: 0x0027A06E
		[NullableContext(1)]
		public static PhantomBattleCallCardRequest Create()
		{
			return new PhantomBattleCallCardRequest();
		}

		// Token: 0x170037FF RID: 14335
		// (get) Token: 0x06010F46 RID: 69446 RVA: 0x0027BE75 File Offset: 0x0027A075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003800 RID: 14336
		// (get) Token: 0x06010F47 RID: 69447 RVA: 0x0027BE78 File Offset: 0x0027A078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCallCardRequest.Descriptor;
			}
		}

		// Token: 0x06010F48 RID: 69448 RVA: 0x0027BE7F File Offset: 0x0027A07F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardRequest()
		{
		}

		// Token: 0x06010F49 RID: 69449 RVA: 0x0027BE92 File Offset: 0x0027A092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardRequest(PhantomBattleCallCardRequest other) : this()
		{
			this.effectUid_ = other.effectUid_;
			this.selectedCardUid_ = other.selectedCardUid_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010F4A RID: 69450 RVA: 0x0027BEC8 File Offset: 0x0027A0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardRequest Clone()
		{
			return new PhantomBattleCallCardRequest(this);
		}

		// Token: 0x17003801 RID: 14337
		// (get) Token: 0x06010F4B RID: 69451 RVA: 0x0027BED0 File Offset: 0x0027A0D0
		// (set) Token: 0x06010F4C RID: 69452 RVA: 0x0027BED8 File Offset: 0x0027A0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EffectUid
		{
			get
			{
				return this.effectUid_;
			}
			set
			{
				this.effectUid_ = value;
			}
		}

		// Token: 0x17003802 RID: 14338
		// (get) Token: 0x06010F4D RID: 69453 RVA: 0x0027BEE1 File Offset: 0x0027A0E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectedCardUid
		{
			get
			{
				return this.selectedCardUid_;
			}
		}

		// Token: 0x06010F4E RID: 69454 RVA: 0x0027BEE9 File Offset: 0x0027A0E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCallCardRequest);
		}

		// Token: 0x06010F4F RID: 69455 RVA: 0x0027BEF8 File Offset: 0x0027A0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCallCardRequest other)
		{
			return other != null && (other == this || (this.EffectUid == other.EffectUid && this.selectedCardUid_.Equals(other.selectedCardUid_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010F50 RID: 69456 RVA: 0x0027BF48 File Offset: 0x0027A148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EffectUid != 0)
			{
				num ^= this.EffectUid.GetHashCode();
			}
			num ^= this.selectedCardUid_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010F51 RID: 69457 RVA: 0x0027BF95 File Offset: 0x0027A195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010F52 RID: 69458 RVA: 0x0027BFA2 File Offset: 0x0027A1A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010F53 RID: 69459 RVA: 0x0027BFAC File Offset: 0x0027A1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EffectUid != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.EffectUid);
			}
			this.selectedCardUid_.WriteTo(ref output, PhantomBattleCallCardRequest._repeated_selectedCardUid_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010F54 RID: 69460 RVA: 0x0027BFFC File Offset: 0x0027A1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EffectUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EffectUid);
			}
			num += this.selectedCardUid_.CalculateSize(PhantomBattleCallCardRequest._repeated_selectedCardUid_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010F55 RID: 69461 RVA: 0x0027C050 File Offset: 0x0027A250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCallCardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EffectUid != 0)
			{
				this.EffectUid = other.EffectUid;
			}
			this.selectedCardUid_.Add(other.selectedCardUid_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010F56 RID: 69462 RVA: 0x0027C09D File Offset: 0x0027A29D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010F57 RID: 69463 RVA: 0x0027C0A8 File Offset: 0x0027A2A8
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
					if (num != 96U && num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.selectedCardUid_.AddEntriesFrom(ref input, PhantomBattleCallCardRequest._repeated_selectedCardUid_codec);
					}
				}
				else
				{
					this.EffectUid = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006BE8 RID: 27624
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BE9 RID: 27625
		public const int EffectUidFieldNumber = 4;

		// Token: 0x04006BEA RID: 27626
		private int effectUid_;

		// Token: 0x04006BEB RID: 27627
		public const int SelectedCardUidFieldNumber = 12;

		// Token: 0x04006BEC RID: 27628
		private static readonly FieldCodec<int> _repeated_selectedCardUid_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04006BED RID: 27629
		private readonly RepeatedField<int> selectedCardUid_ = new RepeatedField<int>();
	}
}
