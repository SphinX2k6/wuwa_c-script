using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061EE RID: 25070
	public struct IBattleStateFinalMonsterLanding : IFlatbufferObject
	{
		// Token: 0x1700BAE9 RID: 47849
		// (get) Token: 0x0602B369 RID: 177001 RVA: 0x005F4734 File Offset: 0x005F2934
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B36A RID: 177002 RVA: 0x005F4741 File Offset: 0x005F2941
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B36B RID: 177003 RVA: 0x005F4748 File Offset: 0x005F2948
		public static IBattleStateFinalMonsterLanding GetRootAsIBattleStateFinalMonsterLanding(ByteBuffer _bb)
		{
			return IBattleStateFinalMonsterLanding.GetRootAsIBattleStateFinalMonsterLanding(_bb, default(IBattleStateFinalMonsterLanding));
		}

		// Token: 0x0602B36C RID: 177004 RVA: 0x005F4764 File Offset: 0x005F2964
		public static IBattleStateFinalMonsterLanding GetRootAsIBattleStateFinalMonsterLanding(ByteBuffer _bb, IBattleStateFinalMonsterLanding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B36D RID: 177005 RVA: 0x005F4781 File Offset: 0x005F2981
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B36E RID: 177006 RVA: 0x005F4790 File Offset: 0x005F2990
		public IBattleStateFinalMonsterLanding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAEA RID: 47850
		// (get) Token: 0x0602B36F RID: 177007 RVA: 0x005F47A0 File Offset: 0x005F29A0
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

		// Token: 0x0602B370 RID: 177008 RVA: 0x005F47DC File Offset: 0x005F29DC
		public static Offset<IBattleStateFinalMonsterLanding> CreateIBattleStateFinalMonsterLanding(FlatBufferBuilder builder, ESetBattleTagType Type = ESetBattleTagType.BattleMonsterLanding)
		{
			builder.StartTable(1);
			IBattleStateFinalMonsterLanding.AddType(builder, Type);
			return IBattleStateFinalMonsterLanding.EndIBattleStateFinalMonsterLanding(builder);
		}

		// Token: 0x0602B371 RID: 177009 RVA: 0x005F47F2 File Offset: 0x005F29F2
		public static void StartIBattleStateFinalMonsterLanding(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B372 RID: 177010 RVA: 0x005F47FB File Offset: 0x005F29FB
		public static void AddType(FlatBufferBuilder builder, ESetBattleTagType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B373 RID: 177011 RVA: 0x005F4806 File Offset: 0x005F2A06
		public static Offset<IBattleStateFinalMonsterLanding> EndIBattleStateFinalMonsterLanding(FlatBufferBuilder builder)
		{
			return new Offset<IBattleStateFinalMonsterLanding>(builder.EndTable());
		}

		// Token: 0x0602B374 RID: 177012 RVA: 0x005F4814 File Offset: 0x005F2A14
		public IBattleStateFinalMonsterLandingT UnPack()
		{
			IBattleStateFinalMonsterLandingT battleStateFinalMonsterLandingT = new IBattleStateFinalMonsterLandingT();
			this.UnPackTo(battleStateFinalMonsterLandingT);
			return battleStateFinalMonsterLandingT;
		}

		// Token: 0x0602B375 RID: 177013 RVA: 0x005F482F File Offset: 0x005F2A2F
		public void UnPackTo(IBattleStateFinalMonsterLandingT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B376 RID: 177014 RVA: 0x005F4840 File Offset: 0x005F2A40
		public static Offset<IBattleStateFinalMonsterLanding> Pack(FlatBufferBuilder builder, IBattleStateFinalMonsterLandingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBattleStateFinalMonsterLanding>);
			}
			return IBattleStateFinalMonsterLanding.CreateIBattleStateFinalMonsterLanding(builder, _o.Type);
		}

		// Token: 0x04010723 RID: 67363
		private Table __p;
	}
}
