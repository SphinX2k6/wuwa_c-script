using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008DF RID: 2271
	public sealed class KurotatoWeaponPbData : IMessage<KurotatoWeaponPbData>, IMessage, IEquatable<KurotatoWeaponPbData>, IDeepCloneable<KurotatoWeaponPbData>, IBufferMessage
	{
		// Token: 0x0600C900 RID: 51456 RVA: 0x001DB435 File Offset: 0x001D9635
		[NullableContext(1)]
		public static KurotatoWeaponPbData Create()
		{
			return new KurotatoWeaponPbData();
		}

		// Token: 0x1700289A RID: 10394
		// (get) Token: 0x0600C901 RID: 51457 RVA: 0x001DB43C File Offset: 0x001D963C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KurotatoWeaponPbData> Parser
		{
			get
			{
				return KurotatoWeaponPbData._parser;
			}
		}

		// Token: 0x1700289B RID: 10395
		// (get) Token: 0x0600C902 RID: 51458 RVA: 0x001DB443 File Offset: 0x001D9643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700289C RID: 10396
		// (get) Token: 0x0600C903 RID: 51459 RVA: 0x001DB446 File Offset: 0x001D9646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoWeaponPbData.Descriptor;
			}
		}

		// Token: 0x0600C904 RID: 51460 RVA: 0x001DB44D File Offset: 0x001D964D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponPbData()
		{
		}

		// Token: 0x0600C905 RID: 51461 RVA: 0x001DB458 File Offset: 0x001D9658
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

		// Token: 0x0600C906 RID: 51462 RVA: 0x001DB4AC File Offset: 0x001D96AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponPbData Clone()
		{
			return new KurotatoWeaponPbData(this);
		}

		// Token: 0x1700289D RID: 10397
		// (get) Token: 0x0600C907 RID: 51463 RVA: 0x001DB4B4 File Offset: 0x001D96B4
		// (set) Token: 0x0600C908 RID: 51464 RVA: 0x001DB4BC File Offset: 0x001D96BC
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

		// Token: 0x1700289E RID: 10398
		// (get) Token: 0x0600C909 RID: 51465 RVA: 0x001DB4C5 File Offset: 0x001D96C5
		// (set) Token: 0x0600C90A RID: 51466 RVA: 0x001DB4CD File Offset: 0x001D96CD
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

		// Token: 0x1700289F RID: 10399
		// (get) Token: 0x0600C90B RID: 51467 RVA: 0x001DB4D6 File Offset: 0x001D96D6
		// (set) Token: 0x0600C90C RID: 51468 RVA: 0x001DB4DE File Offset: 0x001D96DE
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

		// Token: 0x170028A0 RID: 10400
		// (get) Token: 0x0600C90D RID: 51469 RVA: 0x001DB4E7 File Offset: 0x001D96E7
		// (set) Token: 0x0600C90E RID: 51470 RVA: 0x001DB4EF File Offset: 0x001D96EF
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

		// Token: 0x0600C90F RID: 51471 RVA: 0x001DB4F8 File Offset: 0x001D96F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoWeaponPbData);
		}

		// Token: 0x0600C910 RID: 51472 RVA: 0x001DB508 File Offset: 0x001D9708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoWeaponPbData other)
		{
			return other != null && (other == this || (this.WeaponId == other.WeaponId && this.IncId == other.IncId && this.PreWaveDealtDamage == other.PreWaveDealtDamage && this.SellPrice == other.SellPrice && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C911 RID: 51473 RVA: 0x001DB574 File Offset: 0x001D9774
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

		// Token: 0x0600C912 RID: 51474 RVA: 0x001DB5FE File Offset: 0x001D97FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C913 RID: 51475 RVA: 0x001DB60B File Offset: 0x001D980B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C914 RID: 51476 RVA: 0x001DB614 File Offset: 0x001D9814
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

		// Token: 0x0600C915 RID: 51477 RVA: 0x001DB6A4 File Offset: 0x001D98A4
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

		// Token: 0x0600C916 RID: 51478 RVA: 0x001DB72C File Offset: 0x001D992C
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

		// Token: 0x0600C917 RID: 51479 RVA: 0x001DB7A4 File Offset: 0x001D99A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C918 RID: 51480 RVA: 0x001DB7B0 File Offset: 0x001D99B0
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

		// Token: 0x040055D3 RID: 21971
		private static readonly MessageParser<KurotatoWeaponPbData> _parser = new MessageParser<KurotatoWeaponPbData>(() => new KurotatoWeaponPbData());

		// Token: 0x040055D4 RID: 21972
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055D5 RID: 21973
		public const int WeaponIdFieldNumber = 1;

		// Token: 0x040055D6 RID: 21974
		private int weaponId_;

		// Token: 0x040055D7 RID: 21975
		public const int IncIdFieldNumber = 2;

		// Token: 0x040055D8 RID: 21976
		private int incId_;

		// Token: 0x040055D9 RID: 21977
		public const int PreWaveDealtDamageFieldNumber = 3;

		// Token: 0x040055DA RID: 21978
		private int preWaveDealtDamage_;

		// Token: 0x040055DB RID: 21979
		public const int SellPriceFieldNumber = 4;

		// Token: 0x040055DC RID: 21980
		private int sellPrice_;
	}
}
