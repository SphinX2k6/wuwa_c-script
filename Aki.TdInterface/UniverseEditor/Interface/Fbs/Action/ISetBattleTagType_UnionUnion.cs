using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FC7 RID: 28615
	public class ISetBattleTagType_UnionUnion
	{
		// Token: 0x1700D473 RID: 54387
		// (get) Token: 0x06032936 RID: 207158 RVA: 0x006D31FD File Offset: 0x006D13FD
		// (set) Token: 0x06032937 RID: 207159 RVA: 0x006D3205 File Offset: 0x006D1405
		public ISetBattleTagType_Union Type { get; set; }

		// Token: 0x1700D474 RID: 54388
		// (get) Token: 0x06032938 RID: 207160 RVA: 0x006D320E File Offset: 0x006D140E
		// (set) Token: 0x06032939 RID: 207161 RVA: 0x006D3216 File Offset: 0x006D1416
		public object Value { get; set; }

		// Token: 0x0603293A RID: 207162 RVA: 0x006D321F File Offset: 0x006D141F
		public ISetBattleTagType_UnionUnion()
		{
			this.Type = ISetBattleTagType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603293B RID: 207163 RVA: 0x006D3235 File Offset: 0x006D1435
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603293C RID: 207164 RVA: 0x006D3247 File Offset: 0x006D1447
		public ISetBattleTagTypeT AsISetBattleTagType()
		{
			return this.As<ISetBattleTagTypeT>();
		}

		// Token: 0x0603293D RID: 207165 RVA: 0x006D324F File Offset: 0x006D144F
		public static ISetBattleTagType_UnionUnion FromISetBattleTagType(ISetBattleTagTypeT _isetbattletagtype)
		{
			return new ISetBattleTagType_UnionUnion
			{
				Type = ISetBattleTagType_Union.ISetBattleTagType,
				Value = _isetbattletagtype
			};
		}

		// Token: 0x0603293E RID: 207166 RVA: 0x006D3264 File Offset: 0x006D1464
		public IBattleStateMonsterLandingT AsIBattleStateMonsterLanding()
		{
			return this.As<IBattleStateMonsterLandingT>();
		}

		// Token: 0x0603293F RID: 207167 RVA: 0x006D326C File Offset: 0x006D146C
		public static ISetBattleTagType_UnionUnion FromIBattleStateMonsterLanding(IBattleStateMonsterLandingT _ibattlestatemonsterlanding)
		{
			return new ISetBattleTagType_UnionUnion
			{
				Type = ISetBattleTagType_Union.IBattleStateMonsterLanding,
				Value = _ibattlestatemonsterlanding
			};
		}

		// Token: 0x06032940 RID: 207168 RVA: 0x006D3281 File Offset: 0x006D1481
		public IBattleStateFinalMonsterLandingT AsIBattleStateFinalMonsterLanding()
		{
			return this.As<IBattleStateFinalMonsterLandingT>();
		}

		// Token: 0x06032941 RID: 207169 RVA: 0x006D3289 File Offset: 0x006D1489
		public static ISetBattleTagType_UnionUnion FromIBattleStateFinalMonsterLanding(IBattleStateFinalMonsterLandingT _ibattlestatefinalmonsterlanding)
		{
			return new ISetBattleTagType_UnionUnion
			{
				Type = ISetBattleTagType_Union.IBattleStateFinalMonsterLanding,
				Value = _ibattlestatefinalmonsterlanding
			};
		}

		// Token: 0x06032942 RID: 207170 RVA: 0x006D329E File Offset: 0x006D149E
		public IBattleStateMonsterSleepT AsIBattleStateMonsterSleep()
		{
			return this.As<IBattleStateMonsterSleepT>();
		}

		// Token: 0x06032943 RID: 207171 RVA: 0x006D32A6 File Offset: 0x006D14A6
		public static ISetBattleTagType_UnionUnion FromIBattleStateMonsterSleep(IBattleStateMonsterSleepT _ibattlestatemonstersleep)
		{
			return new ISetBattleTagType_UnionUnion
			{
				Type = ISetBattleTagType_Union.IBattleStateMonsterSleep,
				Value = _ibattlestatemonstersleep
			};
		}

		// Token: 0x06032944 RID: 207172 RVA: 0x006D32BC File Offset: 0x006D14BC
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
