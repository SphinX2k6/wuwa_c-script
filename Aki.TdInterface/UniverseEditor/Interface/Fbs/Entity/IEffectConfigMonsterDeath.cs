using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BF2 RID: 19442
	public struct IEffectConfigMonsterDeath : IFlatbufferObject
	{
		// Token: 0x17008998 RID: 35224
		// (get) Token: 0x0601DB06 RID: 121606 RVA: 0x0042A648 File Offset: 0x00428848
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DB07 RID: 121607 RVA: 0x0042A655 File Offset: 0x00428855
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DB08 RID: 121608 RVA: 0x0042A65C File Offset: 0x0042885C
		public static IEffectConfigMonsterDeath GetRootAsIEffectConfigMonsterDeath(ByteBuffer _bb)
		{
			return IEffectConfigMonsterDeath.GetRootAsIEffectConfigMonsterDeath(_bb, default(IEffectConfigMonsterDeath));
		}

		// Token: 0x0601DB09 RID: 121609 RVA: 0x0042A678 File Offset: 0x00428878
		public static IEffectConfigMonsterDeath GetRootAsIEffectConfigMonsterDeath(ByteBuffer _bb, IEffectConfigMonsterDeath obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DB0A RID: 121610 RVA: 0x0042A695 File Offset: 0x00428895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DB0B RID: 121611 RVA: 0x0042A6A4 File Offset: 0x004288A4
		public IEffectConfigMonsterDeath __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008999 RID: 35225
		// (get) Token: 0x0601DB0C RID: 121612 RVA: 0x0042A6B4 File Offset: 0x004288B4
		public EEffectConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEffectConfigType.Death;
				}
				return (EEffectConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700899A RID: 35226
		// (get) Token: 0x0601DB0D RID: 121613 RVA: 0x0042A6F0 File Offset: 0x004288F0
		public string ParticleEffect
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DB0E RID: 121614 RVA: 0x0042A727 File Offset: 0x00428927
		public Span<byte> GetParticleEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601DB0F RID: 121615 RVA: 0x0042A736 File Offset: 0x00428936
		public byte[] GetParticleEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700899B RID: 35227
		// (get) Token: 0x0601DB10 RID: 121616 RVA: 0x0042A744 File Offset: 0x00428944
		public string MaterialEffect
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DB11 RID: 121617 RVA: 0x0042A77B File Offset: 0x0042897B
		public Span<byte> GetMaterialEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601DB12 RID: 121618 RVA: 0x0042A78A File Offset: 0x0042898A
		public byte[] GetMaterialEffectArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700899C RID: 35228
		// (get) Token: 0x0601DB13 RID: 121619 RVA: 0x0042A798 File Offset: 0x00428998
		public EMonsterDeathEffectEndRule EndRule
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EMonsterDeathEffectEndRule.Any;
				}
				return (EMonsterDeathEffectEndRule)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700899D RID: 35229
		// (get) Token: 0x0601DB14 RID: 121620 RVA: 0x0042A7D8 File Offset: 0x004289D8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DB15 RID: 121621 RVA: 0x0042A815 File Offset: 0x00428A15
		public static Offset<IEffectConfigMonsterDeath> CreateIEffectConfigMonsterDeath(FlatBufferBuilder builder, EEffectConfigType Type = EEffectConfigType.Death, StringOffset ParticleEffectOffset = default(StringOffset), StringOffset MaterialEffectOffset = default(StringOffset), EMonsterDeathEffectEndRule EndRule = EMonsterDeathEffectEndRule.Any, byte NullMask = 0)
		{
			builder.StartTable(5);
			IEffectConfigMonsterDeath.AddMaterialEffect(builder, MaterialEffectOffset);
			IEffectConfigMonsterDeath.AddParticleEffect(builder, ParticleEffectOffset);
			IEffectConfigMonsterDeath.AddNullMask(builder, NullMask);
			IEffectConfigMonsterDeath.AddEndRule(builder, EndRule);
			IEffectConfigMonsterDeath.AddType(builder, Type);
			return IEffectConfigMonsterDeath.EndIEffectConfigMonsterDeath(builder);
		}

		// Token: 0x0601DB16 RID: 121622 RVA: 0x0042A849 File Offset: 0x00428A49
		public static void StartIEffectConfigMonsterDeath(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601DB17 RID: 121623 RVA: 0x0042A852 File Offset: 0x00428A52
		public static void AddType(FlatBufferBuilder builder, EEffectConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DB18 RID: 121624 RVA: 0x0042A85D File Offset: 0x00428A5D
		public static void AddParticleEffect(FlatBufferBuilder builder, StringOffset particleEffectOffset)
		{
			builder.AddOffset(1, particleEffectOffset.Value, 0);
		}

		// Token: 0x0601DB19 RID: 121625 RVA: 0x0042A86D File Offset: 0x00428A6D
		public static void AddMaterialEffect(FlatBufferBuilder builder, StringOffset materialEffectOffset)
		{
			builder.AddOffset(2, materialEffectOffset.Value, 0);
		}

		// Token: 0x0601DB1A RID: 121626 RVA: 0x0042A87D File Offset: 0x00428A7D
		public static void AddEndRule(FlatBufferBuilder builder, EMonsterDeathEffectEndRule endRule)
		{
			builder.AddByte(3, (byte)endRule, 0);
		}

		// Token: 0x0601DB1B RID: 121627 RVA: 0x0042A888 File Offset: 0x00428A88
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601DB1C RID: 121628 RVA: 0x0042A893 File Offset: 0x00428A93
		public static Offset<IEffectConfigMonsterDeath> EndIEffectConfigMonsterDeath(FlatBufferBuilder builder)
		{
			return new Offset<IEffectConfigMonsterDeath>(builder.EndTable());
		}

		// Token: 0x0601DB1D RID: 121629 RVA: 0x0042A8A0 File Offset: 0x00428AA0
		public IEffectConfigMonsterDeathT UnPack()
		{
			IEffectConfigMonsterDeathT effectConfigMonsterDeathT = new IEffectConfigMonsterDeathT();
			this.UnPackTo(effectConfigMonsterDeathT);
			return effectConfigMonsterDeathT;
		}

		// Token: 0x0601DB1E RID: 121630 RVA: 0x0042A8BB File Offset: 0x00428ABB
		public void UnPackTo(IEffectConfigMonsterDeathT _o)
		{
			_o.Type = this.Type;
			_o.ParticleEffect = this.ParticleEffect;
			_o.MaterialEffect = this.MaterialEffect;
			_o.EndRule = this.EndRule;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601DB1F RID: 121631 RVA: 0x0042A8FC File Offset: 0x00428AFC
		public static Offset<IEffectConfigMonsterDeath> Pack(FlatBufferBuilder builder, IEffectConfigMonsterDeathT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEffectConfigMonsterDeath>);
			}
			StringOffset particleEffectOffset = (_o.ParticleEffect == null) ? default(StringOffset) : builder.CreateString(_o.ParticleEffect);
			StringOffset materialEffectOffset = (_o.MaterialEffect == null) ? default(StringOffset) : builder.CreateString(_o.MaterialEffect);
			return IEffectConfigMonsterDeath.CreateIEffectConfigMonsterDeath(builder, _o.Type, particleEffectOffset, materialEffectOffset, _o.EndRule, _o.NullMask);
		}

		// Token: 0x0400D625 RID: 54821
		private Table __p;
	}
}
