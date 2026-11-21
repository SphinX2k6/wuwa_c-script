using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA5 RID: 3237
	public sealed class PhantomBattleSettleReward : IMessage<PhantomBattleSettleReward>, IMessage, IEquatable<PhantomBattleSettleReward>, IDeepCloneable<PhantomBattleSettleReward>, IBufferMessage
	{
		// Token: 0x060118E8 RID: 71912 RVA: 0x002929A1 File Offset: 0x00290BA1
		[NullableContext(1)]
		public static PhantomBattleSettleReward Create()
		{
			return new PhantomBattleSettleReward();
		}

		// Token: 0x17003A27 RID: 14887
		// (get) Token: 0x060118E9 RID: 71913 RVA: 0x002929A8 File Offset: 0x00290BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A28 RID: 14888
		// (get) Token: 0x060118EA RID: 71914 RVA: 0x002929AB File Offset: 0x00290BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSettleReward.Descriptor;
			}
		}

		// Token: 0x060118EB RID: 71915 RVA: 0x002929B2 File Offset: 0x00290BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSettleReward()
		{
		}

		// Token: 0x060118EC RID: 71916 RVA: 0x002929C8 File Offset: 0x00290BC8
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

		// Token: 0x060118ED RID: 71917 RVA: 0x00292A2D File Offset: 0x00290C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSettleReward Clone()
		{
			return new PhantomBattleSettleReward(this);
		}

		// Token: 0x17003A29 RID: 14889
		// (get) Token: 0x060118EE RID: 71918 RVA: 0x00292A35 File Offset: 0x00290C35
		// (set) Token: 0x060118EF RID: 71919 RVA: 0x00292A3D File Offset: 0x00290C3D
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

		// Token: 0x17003A2A RID: 14890
		// (get) Token: 0x060118F0 RID: 71920 RVA: 0x00292A46 File Offset: 0x00290C46
		// (set) Token: 0x060118F1 RID: 71921 RVA: 0x00292A4E File Offset: 0x00290C4E
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

		// Token: 0x17003A2B RID: 14891
		// (get) Token: 0x060118F2 RID: 71922 RVA: 0x00292A57 File Offset: 0x00290C57
		// (set) Token: 0x060118F3 RID: 71923 RVA: 0x00292A5F File Offset: 0x00290C5F
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

		// Token: 0x17003A2C RID: 14892
		// (get) Token: 0x060118F4 RID: 71924 RVA: 0x00292A68 File Offset: 0x00290C68
		// (set) Token: 0x060118F5 RID: 71925 RVA: 0x00292A70 File Offset: 0x00290C70
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

		// Token: 0x17003A2D RID: 14893
		// (get) Token: 0x060118F6 RID: 71926 RVA: 0x00292A79 File Offset: 0x00290C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleReward> Reward
		{
			get
			{
				return this.reward_;
			}
		}

		// Token: 0x060118F7 RID: 71927 RVA: 0x00292A81 File Offset: 0x00290C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSettleReward);
		}

		// Token: 0x060118F8 RID: 71928 RVA: 0x00292A90 File Offset: 0x00290C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSettleReward other)
		{
			return other != null && (other == this || (this.BeforeLv == other.BeforeLv && this.AfterLv == other.AfterLv && this.AddExp == other.AddExp && this.TotalExp == other.TotalExp && this.reward_.Equals(other.reward_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060118F9 RID: 71929 RVA: 0x00292B10 File Offset: 0x00290D10
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

		// Token: 0x060118FA RID: 71930 RVA: 0x00292BA8 File Offset: 0x00290DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060118FB RID: 71931 RVA: 0x00292BB5 File Offset: 0x00290DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060118FC RID: 71932 RVA: 0x00292BC0 File Offset: 0x00290DC0
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

		// Token: 0x060118FD RID: 71933 RVA: 0x00292C64 File Offset: 0x00290E64
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

		// Token: 0x060118FE RID: 71934 RVA: 0x00292D00 File Offset: 0x00290F00
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

		// Token: 0x060118FF RID: 71935 RVA: 0x00292D89 File Offset: 0x00290F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011900 RID: 71936 RVA: 0x00292D94 File Offset: 0x00290F94
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

		// Token: 0x04006F06 RID: 28422
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F07 RID: 28423
		public const int BeforeLvFieldNumber = 1;

		// Token: 0x04006F08 RID: 28424
		private int beforeLv_;

		// Token: 0x04006F09 RID: 28425
		public const int AfterLvFieldNumber = 2;

		// Token: 0x04006F0A RID: 28426
		private int afterLv_;

		// Token: 0x04006F0B RID: 28427
		public const int AddExpFieldNumber = 3;

		// Token: 0x04006F0C RID: 28428
		private int addExp_;

		// Token: 0x04006F0D RID: 28429
		public const int TotalExpFieldNumber = 4;

		// Token: 0x04006F0E RID: 28430
		private int totalExp_;

		// Token: 0x04006F0F RID: 28431
		public const int RewardFieldNumber = 5;

		// Token: 0x04006F10 RID: 28432
		private static readonly FieldCodec<PhantomBattleReward> _repeated_reward_codec = FieldCodec.ForMessage<PhantomBattleReward>(42U, PhantomBattleReward.Parser);

		// Token: 0x04006F11 RID: 28433
		private readonly RepeatedField<PhantomBattleReward> reward_ = new RepeatedField<PhantomBattleReward>();
	}
}
