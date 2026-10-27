using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E04 RID: 15876
	public class IEnterDungeon_UnionUnion
	{
		// Token: 0x17006DB5 RID: 28085
		// (get) Token: 0x0601634D RID: 90957 RVA: 0x00334DFE File Offset: 0x00332FFE
		// (set) Token: 0x0601634E RID: 90958 RVA: 0x00334E06 File Offset: 0x00333006
		public IEnterDungeon_Union Type { get; set; }

		// Token: 0x17006DB6 RID: 28086
		// (get) Token: 0x0601634F RID: 90959 RVA: 0x00334E0F File Offset: 0x0033300F
		// (set) Token: 0x06016350 RID: 90960 RVA: 0x00334E17 File Offset: 0x00333017
		public object Value { get; set; }

		// Token: 0x06016351 RID: 90961 RVA: 0x00334E20 File Offset: 0x00333020
		public IEnterDungeon_UnionUnion()
		{
			this.Type = IEnterDungeon_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016352 RID: 90962 RVA: 0x00334E36 File Offset: 0x00333036
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016353 RID: 90963 RVA: 0x00334E48 File Offset: 0x00333048
		public IEnterDungeonT AsIEnterDungeon()
		{
			return this.As<IEnterDungeonT>();
		}

		// Token: 0x06016354 RID: 90964 RVA: 0x00334E50 File Offset: 0x00333050
		public static IEnterDungeon_UnionUnion FromIEnterDungeon(IEnterDungeonT _ienterdungeon)
		{
			return new IEnterDungeon_UnionUnion
			{
				Type = IEnterDungeon_Union.IEnterDungeon,
				Value = _ienterdungeon
			};
		}

		// Token: 0x06016355 RID: 90965 RVA: 0x00334E65 File Offset: 0x00333065
		public IEnterDungeonIdConditionT AsIEnterDungeonIdCondition()
		{
			return this.As<IEnterDungeonIdConditionT>();
		}

		// Token: 0x06016356 RID: 90966 RVA: 0x00334E6D File Offset: 0x0033306D
		public static IEnterDungeon_UnionUnion FromIEnterDungeonIdCondition(IEnterDungeonIdConditionT _ienterdungeonidcondition)
		{
			return new IEnterDungeon_UnionUnion
			{
				Type = IEnterDungeon_Union.IEnterDungeonIdCondition,
				Value = _ienterdungeonidcondition
			};
		}

		// Token: 0x06016357 RID: 90967 RVA: 0x00334E82 File Offset: 0x00333082
		public IEnterDungeonSubTypeConditionT AsIEnterDungeonSubTypeCondition()
		{
			return this.As<IEnterDungeonSubTypeConditionT>();
		}

		// Token: 0x06016358 RID: 90968 RVA: 0x00334E8A File Offset: 0x0033308A
		public static IEnterDungeon_UnionUnion FromIEnterDungeonSubTypeCondition(IEnterDungeonSubTypeConditionT _ienterdungeonsubtypecondition)
		{
			return new IEnterDungeon_UnionUnion
			{
				Type = IEnterDungeon_Union.IEnterDungeonSubTypeCondition,
				Value = _ienterdungeonsubtypecondition
			};
		}

		// Token: 0x06016359 RID: 90969 RVA: 0x00334EA0 File Offset: 0x003330A0
		public static int Pack(FlatBufferBuilder builder, IEnterDungeon_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IEnterDungeon_Union.IEnterDungeon:
				return IEnterDungeon.Pack(builder, _o.AsIEnterDungeon()).Value;
			case IEnterDungeon_Union.IEnterDungeonIdCondition:
				return IEnterDungeonIdCondition.Pack(builder, _o.AsIEnterDungeonIdCondition()).Value;
			case IEnterDungeon_Union.IEnterDungeonSubTypeCondition:
				return IEnterDungeonSubTypeCondition.Pack(builder, _o.AsIEnterDungeonSubTypeCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
