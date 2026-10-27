using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061F1 RID: 25073
	public struct IBattleStateMonsterLanding : IFlatbufferObject
	{
		// Token: 0x1700BAEC RID: 47852
		// (get) Token: 0x0602B37B RID: 177019 RVA: 0x005F48A9 File Offset: 0x005F2AA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B37C RID: 177020 RVA: 0x005F48B6 File Offset: 0x005F2AB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B37D RID: 177021 RVA: 0x005F48C0 File Offset: 0x005F2AC0
		public static IBattleStateMonsterLanding GetRootAsIBattleStateMonsterLanding(ByteBuffer _bb)
		{
			return IBattleStateMonsterLanding.GetRootAsIBattleStateMonsterLanding(_bb, default(IBattleStateMonsterLanding));
		}

		// Token: 0x0602B37E RID: 177022 RVA: 0x005F48DC File Offset: 0x005F2ADC
		public static IBattleStateMonsterLanding GetRootAsIBattleStateMonsterLanding(ByteBuffer _bb, IBattleStateMonsterLanding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B37F RID: 177023 RVA: 0x005F48F9 File Offset: 0x005F2AF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B380 RID: 177024 RVA: 0x005F4908 File Offset: 0x005F2B08
		public IBattleStateMonsterLanding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAED RID: 47853
		// (get) Token: 0x0602B381 RID: 177025 RVA: 0x005F4918 File Offset: 0x005F2B18
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

		// Token: 0x0602B382 RID: 177026 RVA: 0x005F4954 File Offset: 0x005F2B54
		public static Offset<IBattleStateMonsterLanding> CreateIBattleStateMonsterLanding(FlatBufferBuilder builder, ESetBattleTagType Type = ESetBattleTagType.BattleMonsterLanding)
		{
			builder.StartTable(1);
			IBattleStateMonsterLanding.AddType(builder, Type);
			return IBattleStateMonsterLanding.EndIBattleStateMonsterLanding(builder);
		}

		// Token: 0x0602B383 RID: 177027 RVA: 0x005F496A File Offset: 0x005F2B6A
		public static void StartIBattleStateMonsterLanding(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B384 RID: 177028 RVA: 0x005F4973 File Offset: 0x005F2B73
		public static void AddType(FlatBufferBuilder builder, ESetBattleTagType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B385 RID: 177029 RVA: 0x005F497E File Offset: 0x005F2B7E
		public static Offset<IBattleStateMonsterLanding> EndIBattleStateMonsterLanding(FlatBufferBuilder builder)
		{
			return new Offset<IBattleStateMonsterLanding>(builder.EndTable());
		}

		// Token: 0x0602B386 RID: 177030 RVA: 0x005F498C File Offset: 0x005F2B8C
		public IBattleStateMonsterLandingT UnPack()
		{
			IBattleStateMonsterLandingT battleStateMonsterLandingT = new IBattleStateMonsterLandingT();
			this.UnPackTo(battleStateMonsterLandingT);
			return battleStateMonsterLandingT;
		}

		// Token: 0x0602B387 RID: 177031 RVA: 0x005F49A7 File Offset: 0x005F2BA7
		public void UnPackTo(IBattleStateMonsterLandingT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B388 RID: 177032 RVA: 0x005F49B8 File Offset: 0x005F2BB8
		public static Offset<IBattleStateMonsterLanding> Pack(FlatBufferBuilder builder, IBattleStateMonsterLandingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBattleStateMonsterLanding>);
			}
			return IBattleStateMonsterLanding.CreateIBattleStateMonsterLanding(builder, _o.Type);
		}

		// Token: 0x04010725 RID: 67365
		private Table __p;
	}
}
