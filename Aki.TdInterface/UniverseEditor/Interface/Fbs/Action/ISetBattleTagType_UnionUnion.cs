using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007790 RID: 30608
	public class ISetBattleTagType_UnionUnion
	{
		// Token: 0x1700E047 RID: 57415
		// (get) Token: 0x06035B9C RID: 220060 RVA: 0x00732E41 File Offset: 0x00731041
		// (set) Token: 0x06035B9D RID: 220061 RVA: 0x00732E49 File Offset: 0x00731049
		public ISetBattleTagType_Union Type { get; set; }

		// Token: 0x1700E048 RID: 57416
		// (get) Token: 0x06035B9E RID: 220062 RVA: 0x00732E52 File Offset: 0x00731052
		// (set) Token: 0x06035B9F RID: 220063 RVA: 0x00732E5A File Offset: 0x0073105A
		public object Value { get; set; }

		// Token: 0x06035BA0 RID: 220064 RVA: 0x00732E63 File Offset: 0x00731063
		public ISetBattleTagType_UnionUnion()
		{
			this.Type = ISetBattleTagType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035BA1 RID: 220065 RVA: 0x00732E79 File Offset: 0x00731079
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035BA2 RID: 220066 RVA: 0x00732E8B File Offset: 0x0073108B
		public ISetBattleTagTypeT AsISetBattleTagType()
		{
			return this.As<ISetBattleTagTypeT>();
		}

		// Token: 0x06035BA3 RID: 220067 RVA: 0x00732E93 File Offset: 0x00731093
		public static ISetBattleTagType_UnionUnion FromISetBattleTagType(ISetBattleTagTypeT _isetbattletagtype)
		{
			return new ISetBattleTagType_UnionUnion
			{
				Type = ISetBattleTagType_Union.ISetBattleTagType,
				Value = _isetbattletagtype
			};
		}

		// Token: 0x06035BA4 RID: 220068 RVA: 0x00732EA8 File Offset: 0x007310A8
		public IBattleStateMonsterLandingT AsIBattleStateMonsterLanding()
		{
			return this.As<IBattleStateMonsterLandingT>();
		}

		// Token: 0x06035BA5 RID: 220069 RVA: 0x00732EB0 File Offset: 0x007310B0
		public static ISetBattleTagType_UnionUnion FromIBattleStateMonsterLanding(IBattleStateMonsterLandingT _ibattlestatemonsterlanding)
		{
			return new ISetBattleTagType_UnionUnion
			{
				Type = ISetBattleTagType_Union.IBattleStateMonsterLanding,
				Value = _ibattlestatemonsterlanding
			};
		}

		// Token: 0x06035BA6 RID: 220070 RVA: 0x00732EC5 File Offset: 0x007310C5
		public IBattleStateFinalMonsterLandingT AsIBattleStateFinalMonsterLanding()
		{
			return this.As<IBattleStateFinalMonsterLandingT>();
		}

		// Token: 0x06035BA7 RID: 220071 RVA: 0x00732ECD File Offset: 0x007310CD
		public static ISetBattleTagType_UnionUnion FromIBattleStateFinalMonsterLanding(IBattleStateFinalMonsterLandingT _ibattlestatefinalmonsterlanding)
		{
			return new ISetBattleTagType_UnionUnion
			{
				Type = ISetBattleTagType_Union.IBattleStateFinalMonsterLanding,
				Value = _ibattlestatefinalmonsterlanding
			};
		}

		// Token: 0x06035BA8 RID: 220072 RVA: 0x00732EE2 File Offset: 0x007310E2
		public IBattleStateMonsterSleepT AsIBattleStateMonsterSleep()
		{
			return this.As<IBattleStateMonsterSleepT>();
		}

		// Token: 0x06035BA9 RID: 220073 RVA: 0x00732EEA File Offset: 0x007310EA
		public static ISetBattleTagType_UnionUnion FromIBattleStateMonsterSleep(IBattleStateMonsterSleepT _ibattlestatemonstersleep)
		{
			return new ISetBattleTagType_UnionUnion
			{
				Type = ISetBattleTagType_Union.IBattleStateMonsterSleep,
				Value = _ibattlestatemonstersleep
			};
		}

		// Token: 0x06035BAA RID: 220074 RVA: 0x00732F00 File Offset: 0x00731100
		public static int Pack(FlatBufferBuilder builder, ISetBattleTagType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISetBattleTagType_Union.ISetBattleTagType:
				return ISetBattleTagType.Pack(builder, _o.AsISetBattleTagType()).Value;
			case ISetBattleTagType_Union.IBattleStateMonsterLanding:
				return IBattleStateMonsterLanding.Pack(builder, _o.AsIBattleStateMonsterLanding()).Value;
			case ISetBattleTagType_Union.IBattleStateFinalMonsterLanding:
				return IBattleStateFinalMonsterLanding.Pack(builder, _o.AsIBattleStateFinalMonsterLanding()).Value;
			case ISetBattleTagType_Union.IBattleStateMonsterSleep:
				return IBattleStateMonsterSleep.Pack(builder, _o.AsIBattleStateMonsterSleep()).Value;
			default:
				return 0;
			}
		}
	}
}
