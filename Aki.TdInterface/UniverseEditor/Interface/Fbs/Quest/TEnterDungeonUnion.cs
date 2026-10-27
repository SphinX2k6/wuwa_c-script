using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042D0 RID: 17104
	public class TEnterDungeonUnion
	{
		// Token: 0x17007942 RID: 31042
		// (get) Token: 0x060195F1 RID: 103921 RVA: 0x003A3E50 File Offset: 0x003A2050
		// (set) Token: 0x060195F2 RID: 103922 RVA: 0x003A3E58 File Offset: 0x003A2058
		public TEnterDungeon Type { get; set; }

		// Token: 0x17007943 RID: 31043
		// (get) Token: 0x060195F3 RID: 103923 RVA: 0x003A3E61 File Offset: 0x003A2061
		// (set) Token: 0x060195F4 RID: 103924 RVA: 0x003A3E69 File Offset: 0x003A2069
		public object Value { get; set; }

		// Token: 0x060195F5 RID: 103925 RVA: 0x003A3E72 File Offset: 0x003A2072
		public TEnterDungeonUnion()
		{
			this.Type = TEnterDungeon.NONE;
			this.Value = null;
		}

		// Token: 0x060195F6 RID: 103926 RVA: 0x003A3E88 File Offset: 0x003A2088
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060195F7 RID: 103927 RVA: 0x003A3E9A File Offset: 0x003A209A
		public IEnterDungeonIdConditionT AsIEnterDungeonIdCondition()
		{
			return this.As<IEnterDungeonIdConditionT>();
		}

		// Token: 0x060195F8 RID: 103928 RVA: 0x003A3EA2 File Offset: 0x003A20A2
		public static TEnterDungeonUnion FromIEnterDungeonIdCondition(IEnterDungeonIdConditionT _ienterdungeonidcondition)
		{
			return new TEnterDungeonUnion
			{
				Type = TEnterDungeon.IEnterDungeonIdCondition,
				Value = _ienterdungeonidcondition
			};
		}

		// Token: 0x060195F9 RID: 103929 RVA: 0x003A3EB7 File Offset: 0x003A20B7
		public IEnterDungeonSubTypeConditionT AsIEnterDungeonSubTypeCondition()
		{
			return this.As<IEnterDungeonSubTypeConditionT>();
		}

		// Token: 0x060195FA RID: 103930 RVA: 0x003A3EBF File Offset: 0x003A20BF
		public static TEnterDungeonUnion FromIEnterDungeonSubTypeCondition(IEnterDungeonSubTypeConditionT _ienterdungeonsubtypecondition)
		{
			return new TEnterDungeonUnion
			{
				Type = TEnterDungeon.IEnterDungeonSubTypeCondition,
				Value = _ienterdungeonsubtypecondition
			};
		}

		// Token: 0x060195FB RID: 103931 RVA: 0x003A3ED4 File Offset: 0x003A20D4
		public static int Pack(FlatBufferBuilder builder, TEnterDungeonUnion _o)
		{
			TEnterDungeon type = _o.Type;
			if (type == TEnterDungeon.IEnterDungeonIdCondition)
			{
				return IEnterDungeonIdCondition.Pack(builder, _o.AsIEnterDungeonIdCondition()).Value;
			}
			if (type != TEnterDungeon.IEnterDungeonSubTypeCondition)
			{
				return 0;
			}
			return IEnterDungeonSubTypeCondition.Pack(builder, _o.AsIEnterDungeonSubTypeCondition()).Value;
		}
	}
}
