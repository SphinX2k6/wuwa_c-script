using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x0200478A RID: 18314
	public struct IEffectConfigMonsterDeath : IFlatbufferObject
	{
		// Token: 0x17008357 RID: 33623
		// (get) Token: 0x0601C331 RID: 115505 RVA: 0x003FE3AC File Offset: 0x003FC5AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C332 RID: 115506 RVA: 0x003FE3B9 File Offset: 0x003FC5B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C333 RID: 115507 RVA: 0x003FE3C0 File Offset: 0x003FC5C0
		public static IEffectConfigMonsterDeath GetRootAsIEffectConfigMonsterDeath(ByteBuffer _bb)
		{
			return IEffectConfigMonsterDeath.GetRootAsIEffectConfigMonsterDeath(_bb, default(IEffectConfigMonsterDeath));
		}

		// Token: 0x0601C334 RID: 115508 RVA: 0x003FE3DC File Offset: 0x003FC5DC
		public static IEffectConfigMonsterDeath GetRootAsIEffectConfigMonsterDeath(ByteBuffer _bb, IEffectConfigMonsterDeath obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C335 RID: 115509 RVA: 0x003FE3F9 File Offset: 0x003FC5F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C336 RID: 115510 RVA: 0x003FE408 File Offset: 0x003FC608
		public IEffectConfigMonsterDeath __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008358 RID: 33624
		// (get) Token: 0x0601C337 RID: 115511 RVA: 0x003FE418 File Offset: 0x003FC618
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

		// Token: 0x17008359 RID: 33625
		// (get) Token: 0x0601C338 RID: 115512 RVA: 0x003FE454 File Offset: 0x003FC654
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

		// Token: 0x0601C339 RID: 115513 RVA: 0x003FE48B File Offset: 0x003FC68B
		public Span<byte> GetParticleEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601C33A RID: 115514 RVA: 0x003FE49A File Offset: 0x003FC69A
		public byte[] GetParticleEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700835A RID: 33626
		// (get) Token: 0x0601C33B RID: 115515 RVA: 0x003FE4A8 File Offset: 0x003FC6A8
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

		// Token: 0x0601C33C RID: 115516 RVA: 0x003FE4DF File Offset: 0x003FC6DF
		public Span<byte> GetMaterialEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601C33D RID: 115517 RVA: 0x003FE4EE File Offset: 0x003FC6EE
		public byte[] GetMaterialEffectArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700835B RID: 33627
		// (get) Token: 0x0601C33E RID: 115518 RVA: 0x003FE4FC File Offset: 0x003FC6FC
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

		// Token: 0x1700835C RID: 33628
		// (get) Token: 0x0601C33F RID: 115519 RVA: 0x003FE53C File Offset: 0x003FC73C
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

		// Token: 0x0601C340 RID: 115520 RVA: 0x003FE579 File Offset: 0x003FC779
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

		// Token: 0x0601C341 RID: 115521 RVA: 0x003FE5AD File Offset: 0x003FC7AD
		public static void StartIEffectConfigMonsterDeath(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601C342 RID: 115522 RVA: 0x003FE5B6 File Offset: 0x003FC7B6
		public static void AddType(FlatBufferBuilder builder, EEffectConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C343 RID: 115523 RVA: 0x003FE5C1 File Offset: 0x003FC7C1
		public static void AddParticleEffect(FlatBufferBuilder builder, StringOffset particleEffectOffset)
		{
			builder.AddOffset(1, particleEffectOffset.Value, 0);
		}

		// Token: 0x0601C344 RID: 115524 RVA: 0x003FE5D1 File Offset: 0x003FC7D1
		public static void AddMaterialEffect(FlatBufferBuilder builder, StringOffset materialEffectOffset)
		{
			builder.AddOffset(2, materialEffectOffset.Value, 0);
		}

		// Token: 0x0601C345 RID: 115525 RVA: 0x003FE5E1 File Offset: 0x003FC7E1
		public static void AddEndRule(FlatBufferBuilder builder, EMonsterDeathEffectEndRule endRule)
		{
			builder.AddByte(3, (byte)endRule, 0);
		}

		// Token: 0x0601C346 RID: 115526 RVA: 0x003FE5EC File Offset: 0x003FC7EC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601C347 RID: 115527 RVA: 0x003FE5F7 File Offset: 0x003FC7F7
		public static Offset<IEffectConfigMonsterDeath> EndIEffectConfigMonsterDeath(FlatBufferBuilder builder)
		{
			return new Offset<IEffectConfigMonsterDeath>(builder.EndTable());
		}

		// Token: 0x0601C348 RID: 115528 RVA: 0x003FE604 File Offset: 0x003FC804
		public IEffectConfigMonsterDeathT UnPack()
		{
			IEffectConfigMonsterDeathT effectConfigMonsterDeathT = new IEffectConfigMonsterDeathT();
			this.UnPackTo(effectConfigMonsterDeathT);
			return effectConfigMonsterDeathT;
		}

		// Token: 0x0601C349 RID: 115529 RVA: 0x003FE61F File Offset: 0x003FC81F
		public void UnPackTo(IEffectConfigMonsterDeathT _o)
		{
			_o.Type = this.Type;
			_o.ParticleEffect = this.ParticleEffect;
			_o.MaterialEffect = this.MaterialEffect;
			_o.EndRule = this.EndRule;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C34A RID: 115530 RVA: 0x003FE660 File Offset: 0x003FC860
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

		// Token: 0x0400CBEF RID: 52207
		private Table __p;
	}
}
