using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB5 RID: 3253
	public sealed class PhantomBattleSettleReward : IMessage<PhantomBattleSettleReward>, IMessage, IEquatable<PhantomBattleSettleReward>, IDeepCloneable<PhantomBattleSettleReward>, IBufferMessage
	{
		// Token: 0x060119E8 RID: 72168 RVA: 0x00294709 File Offset: 0x00292909
		[NullableContext(1)]
		public static PhantomBattleSettleReward Create()
		{
			return new PhantomBattleSettleReward();
		}

		// Token: 0x17003A5E RID: 14942
		// (get) Token: 0x060119E9 RID: 72169 RVA: 0x00294710 File Offset: 0x00292910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A5F RID: 14943
		// (get) Token: 0x060119EA RID: 72170 RVA: 0x00294713 File Offset: 0x00292913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSettleReward.Descriptor;
			}
		}

		// Token: 0x060119EB RID: 72171 RVA: 0x0029471A File Offset: 0x0029291A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSettleReward()
		{
		}

		// Token: 0x060119EC RID: 72172 RVA: 0x00294730 File Offset: 0x00292930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSettleReward(PhantomBattleSettleReward other) : this()
		{
			this.beforeLv_ = other.beforeLv_;
			this.afterLv_ = other.afterLv_;
			this.addExp_ = other.addExp_;
			this.totalExp_ = other.totalExp_;
			this.reward_ = other.reward_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060119ED RID: 72173 RVA: 0x00294795 File Offset: 0x00292995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSettleReward Clone()
		{
			return new PhantomBattleSettleReward(this);
		}

		// Token: 0x17003A60 RID: 14944
		// (get) Token: 0x060119EE RID: 72174 RVA: 0x0029479D File Offset: 0x0029299D
		// (set) Token: 0x060119EF RID: 72175 RVA: 0x002947A5 File Offset: 0x002929A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BeforeLv
		{
			get
			{
				return this.beforeLv_;
			}
			set
			{
				this.beforeLv_ = value;
			}
		}

		// Token: 0x17003A61 RID: 14945
		// (get) Token: 0x060119F0 RID: 72176 RVA: 0x002947AE File Offset: 0x002929AE
		// (set) Token: 0x060119F1 RID: 72177 RVA: 0x002947B6 File Offset: 0x002929B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AfterLv
		{
			get
			{
				return this.afterLv_;
			}
			set
			{
				this.afterLv_ = value;
			}
		}

		// Token: 0x17003A62 RID: 14946
		// (get) Token: 0x060119F2 RID: 72178 RVA: 0x002947BF File Offset: 0x002929BF
		// (set) Token: 0x060119F3 RID: 72179 RVA: 0x002947C7 File Offset: 0x002929C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AddExp
		{
			get
			{
				return this.addExp_;
			}
			set
			{
				this.addExp_ = value;
			}
		}

		// Token: 0x17003A63 RID: 14947
		// (get) Token: 0x060119F4 RID: 72180 RVA: 0x002947D0 File Offset: 0x002929D0
		// (set) Token: 0x060119F5 RID: 72181 RVA: 0x002947D8 File Offset: 0x002929D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalExp
		{
			get
			{
				return this.totalExp_;
			}
			set
			{
				this.totalExp_ = value;
			}
		}

		// Token: 0x17003A64 RID: 14948
		// (get) Token: 0x060119F6 RID: 72182 RVA: 0x002947E1 File Offset: 0x002929E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleReward> Reward
		{
			get
			{
				return this.reward_;
			}
		}

		// Token: 0x060119F7 RID: 72183 RVA: 0x002947E9 File Offset: 0x002929E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSettleReward);
		}

		// Token: 0x060119F8 RID: 72184 RVA: 0x002947F8 File Offset: 0x002929F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSettleReward other)
		{
			return other != null && (other == this || (this.BeforeLv == other.BeforeLv && this.AfterLv == other.AfterLv && this.AddExp == other.AddExp && this.TotalExp == other.TotalExp && this.reward_.Equals(other.reward_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060119F9 RID: 72185 RVA: 0x00294878 File Offset: 0x00292A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BeforeLv != 0)
			{
				num ^= this.BeforeLv.GetHashCode();
			}
			if (this.AfterLv != 0)
			{
				num ^= this.AfterLv.GetHashCode();
			}
			if (this.AddExp != 0)
			{
				num ^= this.AddExp.GetHashCode();
			}
			if (this.TotalExp != 0)
			{
				num ^= this.TotalExp.GetHashCode();
			}
			num ^= this.reward_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060119FA RID: 72186 RVA: 0x00294910 File Offset: 0x00292B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060119FB RID: 72187 RVA: 0x0029491D File Offset: 0x00292B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060119FC RID: 72188 RVA: 0x00294928 File Offset: 0x00292B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BeforeLv != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BeforeLv);
			}
			if (this.AfterLv != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.AfterLv);
			}
			if (this.AddExp != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AddExp);
			}
			if (this.TotalExp != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TotalExp);
			}
			this.reward_.WriteTo(ref output, PhantomBattleSettleReward._repeated_reward_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060119FD RID: 72189 RVA: 0x002949CC File Offset: 0x00292BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BeforeLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BeforeLv);
			}
			if (this.AfterLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AfterLv);
			}
			if (this.AddExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AddExp);
			}
			if (this.TotalExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalExp);
			}
			num += this.reward_.CalculateSize(PhantomBattleSettleReward._repeated_reward_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060119FE RID: 72190 RVA: 0x00294A68 File Offset: 0x00292C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSettleReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BeforeLv != 0)
			{
				this.BeforeLv = other.BeforeLv;
			}
			if (other.AfterLv != 0)
			{
				this.AfterLv = other.AfterLv;
			}
			if (other.AddExp != 0)
			{
				this.AddExp = other.AddExp;
			}
			if (other.TotalExp != 0)
			{
				this.TotalExp = other.TotalExp;
			}
			this.reward_.Add(other.reward_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060119FF RID: 72191 RVA: 0x00294AF1 File Offset: 0x00292CF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011A00 RID: 72192 RVA: 0x00294AFC File Offset: 0x00292CFC
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.BeforeLv = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.AfterLv = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.AddExp = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.TotalExp = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						this.reward_.AddEntriesFrom(ref input, PhantomBattleSettleReward._repeated_reward_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006EF2 RID: 28402
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EF3 RID: 28403
		public const int BeforeLvFieldNumber = 1;

		// Token: 0x04006EF4 RID: 28404
		private int beforeLv_;

		// Token: 0x04006EF5 RID: 28405
		public const int AfterLvFieldNumber = 2;

		// Token: 0x04006EF6 RID: 28406
		private int afterLv_;

		// Token: 0x04006EF7 RID: 28407
		public const int AddExpFieldNumber = 3;

		// Token: 0x04006EF8 RID: 28408
		private int addExp_;

		// Token: 0x04006EF9 RID: 28409
		public const int TotalExpFieldNumber = 4;

		// Token: 0x04006EFA RID: 28410
		private int totalExp_;

		// Token: 0x04006EFB RID: 28411
		public const int RewardFieldNumber = 5;

		// Token: 0x04006EFC RID: 28412
		private static readonly FieldCodec<PhantomBattleReward> _repeated_reward_codec = FieldCodec.ForMessage<PhantomBattleReward>(42U, PhantomBattleReward.Parser);

		// Token: 0x04006EFD RID: 28413
		private readonly RepeatedField<PhantomBattleReward> reward_ = new RepeatedField<PhantomBattleReward>();
	}
}
