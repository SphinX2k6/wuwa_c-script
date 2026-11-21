using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008CE RID: 2254
	public sealed class KurotatoWeaponPbData : IMessage<KurotatoWeaponPbData>, IMessage, IEquatable<KurotatoWeaponPbData>, IDeepCloneable<KurotatoWeaponPbData>, IBufferMessage
	{
		// Token: 0x0600C7E4 RID: 51172 RVA: 0x001D9159 File Offset: 0x001D7359
		[NullableContext(1)]
		public static KurotatoWeaponPbData Create()
		{
			return new KurotatoWeaponPbData();
		}

		// Token: 0x1700285B RID: 10331
		// (get) Token: 0x0600C7E5 RID: 51173 RVA: 0x001D9160 File Offset: 0x001D7360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KurotatoWeaponPbData> Parser
		{
			get
			{
				return KurotatoWeaponPbData._parser;
			}
		}

		// Token: 0x1700285C RID: 10332
		// (get) Token: 0x0600C7E6 RID: 51174 RVA: 0x001D9167 File Offset: 0x001D7367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700285D RID: 10333
		// (get) Token: 0x0600C7E7 RID: 51175 RVA: 0x001D916A File Offset: 0x001D736A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoWeaponPbData.Descriptor;
			}
		}

		// Token: 0x0600C7E8 RID: 51176 RVA: 0x001D9171 File Offset: 0x001D7371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponPbData()
		{
		}

		// Token: 0x0600C7E9 RID: 51177 RVA: 0x001D917C File Offset: 0x001D737C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponPbData(KurotatoWeaponPbData other) : this()
		{
			this.weaponId_ = other.weaponId_;
			this.incId_ = other.incId_;
			this.preWaveDealtDamage_ = other.preWaveDealtDamage_;
			this.sellPrice_ = other.sellPrice_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C7EA RID: 51178 RVA: 0x001D91D0 File Offset: 0x001D73D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponPbData Clone()
		{
			return new KurotatoWeaponPbData(this);
		}

		// Token: 0x1700285E RID: 10334
		// (get) Token: 0x0600C7EB RID: 51179 RVA: 0x001D91D8 File Offset: 0x001D73D8
		// (set) Token: 0x0600C7EC RID: 51180 RVA: 0x001D91E0 File Offset: 0x001D73E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponId
		{
			get
			{
				return this.weaponId_;
			}
			set
			{
				this.weaponId_ = value;
			}
		}

		// Token: 0x1700285F RID: 10335
		// (get) Token: 0x0600C7ED RID: 51181 RVA: 0x001D91E9 File Offset: 0x001D73E9
		// (set) Token: 0x0600C7EE RID: 51182 RVA: 0x001D91F1 File Offset: 0x001D73F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17002860 RID: 10336
		// (get) Token: 0x0600C7EF RID: 51183 RVA: 0x001D91FA File Offset: 0x001D73FA
		// (set) Token: 0x0600C7F0 RID: 51184 RVA: 0x001D9202 File Offset: 0x001D7402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PreWaveDealtDamage
		{
			get
			{
				return this.preWaveDealtDamage_;
			}
			set
			{
				this.preWaveDealtDamage_ = value;
			}
		}

		// Token: 0x17002861 RID: 10337
		// (get) Token: 0x0600C7F1 RID: 51185 RVA: 0x001D920B File Offset: 0x001D740B
		// (set) Token: 0x0600C7F2 RID: 51186 RVA: 0x001D9213 File Offset: 0x001D7413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SellPrice
		{
			get
			{
				return this.sellPrice_;
			}
			set
			{
				this.sellPrice_ = value;
			}
		}

		// Token: 0x0600C7F3 RID: 51187 RVA: 0x001D921C File Offset: 0x001D741C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoWeaponPbData);
		}

		// Token: 0x0600C7F4 RID: 51188 RVA: 0x001D922C File Offset: 0x001D742C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoWeaponPbData other)
		{
			return other != null && (other == this || (this.WeaponId == other.WeaponId && this.IncId == other.IncId && this.PreWaveDealtDamage == other.PreWaveDealtDamage && this.SellPrice == other.SellPrice && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C7F5 RID: 51189 RVA: 0x001D9298 File Offset: 0x001D7498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeaponId != 0)
			{
				num ^= this.WeaponId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.PreWaveDealtDamage != 0)
			{
				num ^= this.PreWaveDealtDamage.GetHashCode();
			}
			if (this.SellPrice != 0)
			{
				num ^= this.SellPrice.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C7F6 RID: 51190 RVA: 0x001D9322 File Offset: 0x001D7522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C7F7 RID: 51191 RVA: 0x001D932F File Offset: 0x001D752F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C7F8 RID: 51192 RVA: 0x001D9338 File Offset: 0x001D7538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WeaponId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.IncId);
			}
			if (this.PreWaveDealtDamage != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PreWaveDealtDamage);
			}
			if (this.SellPrice != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SellPrice);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C7F9 RID: 51193 RVA: 0x001D93C8 File Offset: 0x001D75C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeaponId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.PreWaveDealtDamage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PreWaveDealtDamage);
			}
			if (this.SellPrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SellPrice);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C7FA RID: 51194 RVA: 0x001D9450 File Offset: 0x001D7650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoWeaponPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeaponId != 0)
			{
				this.WeaponId = other.WeaponId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.PreWaveDealtDamage != 0)
			{
				this.PreWaveDealtDamage = other.PreWaveDealtDamage;
			}
			if (other.SellPrice != 0)
			{
				this.SellPrice = other.SellPrice;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C7FB RID: 51195 RVA: 0x001D94C8 File Offset: 0x001D76C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C7FC RID: 51196 RVA: 0x001D94D4 File Offset: 0x001D76D4
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
						this.WeaponId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.PreWaveDealtDamage = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.SellPrice = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040055DA RID: 21978
		private static readonly MessageParser<KurotatoWeaponPbData> _parser = new MessageParser<KurotatoWeaponPbData>(() => new KurotatoWeaponPbData());

		// Token: 0x040055DB RID: 21979
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055DC RID: 21980
		public const int WeaponIdFieldNumber = 1;

		// Token: 0x040055DD RID: 21981
		private int weaponId_;

		// Token: 0x040055DE RID: 21982
		public const int IncIdFieldNumber = 2;

		// Token: 0x040055DF RID: 21983
		private int incId_;

		// Token: 0x040055E0 RID: 21984
		public const int PreWaveDealtDamageFieldNumber = 3;

		// Token: 0x040055E1 RID: 21985
		private int preWaveDealtDamage_;

		// Token: 0x040055E2 RID: 21986
		public const int SellPriceFieldNumber = 4;

		// Token: 0x040055E3 RID: 21987
		private int sellPrice_;
	}
}
