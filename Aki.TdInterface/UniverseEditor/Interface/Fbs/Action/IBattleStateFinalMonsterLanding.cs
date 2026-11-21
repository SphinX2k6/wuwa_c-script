using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200685C RID: 26716
	public struct IBattleStateFinalMonsterLanding : IFlatbufferObject
	{
		// Token: 0x1700C46C RID: 50284
		// (get) Token: 0x0602DAB0 RID: 187056 RVA: 0x0063F1A8 File Offset: 0x0063D3A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DAB1 RID: 187057 RVA: 0x0063F1B5 File Offset: 0x0063D3B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DAB2 RID: 187058 RVA: 0x0063F1BC File Offset: 0x0063D3BC
		public static IBattleStateFinalMonsterLanding GetRootAsIBattleStateFinalMonsterLanding(ByteBuffer _bb)
		{
			return IBattleStateFinalMonsterLanding.GetRootAsIBattleStateFinalMonsterLanding(_bb, default(IBattleStateFinalMonsterLanding));
		}

		// Token: 0x0602DAB3 RID: 187059 RVA: 0x0063F1D8 File Offset: 0x0063D3D8
		public static IBattleStateFinalMonsterLanding GetRootAsIBattleStateFinalMonsterLanding(ByteBuffer _bb, IBattleStateFinalMonsterLanding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DAB4 RID: 187060 RVA: 0x0063F1F5 File Offset: 0x0063D3F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DAB5 RID: 187061 RVA: 0x0063F204 File Offset: 0x0063D404
		public IBattleStateFinalMonsterLanding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C46D RID: 50285
		// (get) Token: 0x0602DAB6 RID: 187062 RVA: 0x0063F214 File Offset: 0x0063D414
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

		// Token: 0x0602DAB7 RID: 187063 RVA: 0x0063F250 File Offset: 0x0063D450
		public static Offset<IBattleStateFinalMonsterLanding> CreateIBattleStateFinalMonsterLanding(FlatBufferBuilder builder, ESetBattleTagType Type = ESetBattleTagType.BattleMonsterLanding)
		{
			builder.StartTable(1);
			IBattleStateFinalMonsterLanding.AddType(builder, Type);
			return IBattleStateFinalMonsterLanding.EndIBattleStateFinalMonsterLanding(builder);
		}

		// Token: 0x0602DAB8 RID: 187064 RVA: 0x0063F266 File Offset: 0x0063D466
		public static void StartIBattleStateFinalMonsterLanding(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DAB9 RID: 187065 RVA: 0x0063F26F File Offset: 0x0063D46F
		public static void AddType(FlatBufferBuilder builder, ESetBattleTagType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DABA RID: 187066 RVA: 0x0063F27A File Offset: 0x0063D47A
		public static Offset<IBattleStateFinalMonsterLanding> EndIBattleStateFinalMonsterLanding(FlatBufferBuilder builder)
		{
			return new Offset<IBattleStateFinalMonsterLanding>(builder.EndTable());
		}

		// Token: 0x0602DABB RID: 187067 RVA: 0x0063F288 File Offset: 0x0063D488
		public IBattleStateFinalMonsterLandingT UnPack()
		{
			IBattleStateFinalMonsterLandingT battleStateFinalMonsterLandingT = new IBattleStateFinalMonsterLandingT();
			this.UnPackTo(battleStateFinalMonsterLandingT);
			return battleStateFinalMonsterLandingT;
		}

		// Token: 0x0602DABC RID: 187068 RVA: 0x0063F2A3 File Offset: 0x0063D4A3
		public void UnPackTo(IBattleStateFinalMonsterLandingT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DABD RID: 187069 RVA: 0x0063F2B4 File Offset: 0x0063D4B4
		public static Offset<IBattleStateFinalMonsterLanding> Pack(FlatBufferBuilder builder, IBattleStateFinalMonsterLandingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBattleStateFinalMonsterLanding>);
			}
			return IBattleStateFinalMonsterLanding.CreateIBattleStateFinalMonsterLanding(builder, _o.Type);
		}

		// Token: 0x04011535 RID: 70965
		private Table __p;
	}
}
