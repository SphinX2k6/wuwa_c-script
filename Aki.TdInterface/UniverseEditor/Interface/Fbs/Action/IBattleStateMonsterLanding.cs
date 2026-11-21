using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200685F RID: 26719
	public struct IBattleStateMonsterLanding : IFlatbufferObject
	{
		// Token: 0x1700C46F RID: 50287
		// (get) Token: 0x0602DAC2 RID: 187074 RVA: 0x0063F31D File Offset: 0x0063D51D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DAC3 RID: 187075 RVA: 0x0063F32A File Offset: 0x0063D52A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DAC4 RID: 187076 RVA: 0x0063F334 File Offset: 0x0063D534
		public static IBattleStateMonsterLanding GetRootAsIBattleStateMonsterLanding(ByteBuffer _bb)
		{
			return IBattleStateMonsterLanding.GetRootAsIBattleStateMonsterLanding(_bb, default(IBattleStateMonsterLanding));
		}

		// Token: 0x0602DAC5 RID: 187077 RVA: 0x0063F350 File Offset: 0x0063D550
		public static IBattleStateMonsterLanding GetRootAsIBattleStateMonsterLanding(ByteBuffer _bb, IBattleStateMonsterLanding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DAC6 RID: 187078 RVA: 0x0063F36D File Offset: 0x0063D56D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DAC7 RID: 187079 RVA: 0x0063F37C File Offset: 0x0063D57C
		public IBattleStateMonsterLanding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C470 RID: 50288
		// (get) Token: 0x0602DAC8 RID: 187080 RVA: 0x0063F38C File Offset: 0x0063D58C
		public ESetBattleTagType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetBattleTagType.BattleMonsterLanding;
				}
				return (ESetBattleTagType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DAC9 RID: 187081 RVA: 0x0063F3C8 File Offset: 0x0063D5C8
		public static Offset<IBattleStateMonsterLanding> CreateIBattleStateMonsterLanding(FlatBufferBuilder builder, ESetBattleTagType Type = ESetBattleTagType.BattleMonsterLanding)
		{
			builder.StartTable(1);
			IBattleStateMonsterLanding.AddType(builder, Type);
			return IBattleStateMonsterLanding.EndIBattleStateMonsterLanding(builder);
		}

		// Token: 0x0602DACA RID: 187082 RVA: 0x0063F3DE File Offset: 0x0063D5DE
		public static void StartIBattleStateMonsterLanding(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DACB RID: 187083 RVA: 0x0063F3E7 File Offset: 0x0063D5E7
		public static void AddType(FlatBufferBuilder builder, ESetBattleTagType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DACC RID: 187084 RVA: 0x0063F3F2 File Offset: 0x0063D5F2
		public static Offset<IBattleStateMonsterLanding> EndIBattleStateMonsterLanding(FlatBufferBuilder builder)
		{
			return new Offset<IBattleStateMonsterLanding>(builder.EndTable());
		}

		// Token: 0x0602DACD RID: 187085 RVA: 0x0063F400 File Offset: 0x0063D600
		public IBattleStateMonsterLandingT UnPack()
		{
			IBattleStateMonsterLandingT battleStateMonsterLandingT = new IBattleStateMonsterLandingT();
			this.UnPackTo(battleStateMonsterLandingT);
			return battleStateMonsterLandingT;
		}

		// Token: 0x0602DACE RID: 187086 RVA: 0x0063F41B File Offset: 0x0063D61B
		public void UnPackTo(IBattleStateMonsterLandingT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DACF RID: 187087 RVA: 0x0063F42C File Offset: 0x0063D62C
		public static Offset<IBattleStateMonsterLanding> Pack(FlatBufferBuilder builder, IBattleStateMonsterLandingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBattleStateMonsterLanding>);
			}
			return IBattleStateMonsterLanding.CreateIBattleStateMonsterLanding(builder, _o.Type);
		}

		// Token: 0x04011537 RID: 70967
		private Table __p;
	}
}
