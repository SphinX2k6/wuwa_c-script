using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E6E RID: 32366
	public class TChangeEntityPrefabPerformanceUnion
	{
		// Token: 0x1700F211 RID: 61969
		// (get) Token: 0x0603A749 RID: 239433 RVA: 0x007DEA5A File Offset: 0x007DCC5A
		// (set) Token: 0x0603A74A RID: 239434 RVA: 0x007DEA62 File Offset: 0x007DCC62
		public TChangeEntityPrefabPerformance Type { get; set; }

		// Token: 0x1700F212 RID: 61970
		// (get) Token: 0x0603A74B RID: 239435 RVA: 0x007DEA6B File Offset: 0x007DCC6B
		// (set) Token: 0x0603A74C RID: 239436 RVA: 0x007DEA73 File Offset: 0x007DCC73
		public object Value { get; set; }

		// Token: 0x0603A74D RID: 239437 RVA: 0x007DEA7C File Offset: 0x007DCC7C
		public TChangeEntityPrefabPerformanceUnion()
		{
			this.Type = TChangeEntityPrefabPerformance.NONE;
			this.Value = null;
		}

		// Token: 0x0603A74E RID: 239438 RVA: 0x007DEA92 File Offset: 0x007DCC92
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A74F RID: 239439 RVA: 0x007DEAA4 File Offset: 0x007DCCA4
		public IChangeSelfEntityPrefabPerformanceT AsIChangeSelfEntityPrefabPerformance()
		{
			return this.As<IChangeSelfEntityPrefabPerformanceT>();
		}

		// Token: 0x0603A750 RID: 239440 RVA: 0x007DEAAC File Offset: 0x007DCCAC
		public static TChangeEntityPrefabPerformanceUnion FromIChangeSelfEntityPrefabPerformance(IChangeSelfEntityPrefabPerformanceT _ichangeselfentityprefabperformance)
		{
			return new TChangeEntityPrefabPerformanceUnion
			{
				Type = TChangeEntityPrefabPerformance.IChangeSelfEntityPrefabPerformance,
				Value = _ichangeselfentityprefabperformance
			};
		}

		// Token: 0x0603A751 RID: 239441 RVA: 0x007DEAC1 File Offset: 0x007DCCC1
		public IChangeTargetEntityPrefabPerformanceT AsIChangeTargetEntityPrefabPerformance()
		{
			return this.As<IChangeTargetEntityPrefabPerformanceT>();
		}

		// Token: 0x0603A752 RID: 239442 RVA: 0x007DEAC9 File Offset: 0x007DCCC9
		public static TChangeEntityPrefabPerformanceUnion FromIChangeTargetEntityPrefabPerformance(IChangeTargetEntityPrefabPerformanceT _ichangetargetentityprefabperformance)
		{
			return new TChangeEntityPrefabPerformanceUnion
			{
				Type = TChangeEntityPrefabPerformance.IChangeTargetEntityPrefabPerformance,
				Value = _ichangetargetentityprefabperformance
			};
		}

		// Token: 0x0603A753 RID: 239443 RVA: 0x007DEAE0 File Offset: 0x007DCCE0
		public static int Pack(FlatBufferBuilder builder, TChangeEntityPrefabPerformanceUnion _o)
		{
			TChangeEntityPrefabPerformance type = _o.Type;
			if (type == TChangeEntityPrefabPerformance.IChangeSelfEntityPrefabPerformance)
			{
				return IChangeSelfEntityPrefabPerformance.Pack(builder, _o.AsIChangeSelfEntityPrefabPerformance()).Value;
			}
			if (type != TChangeEntityPrefabPerformance.IChangeTargetEntityPrefabPerformance)
			{
				return 0;
			}
			return IChangeTargetEntityPrefabPerformance.Pack(builder, _o.AsIChangeTargetEntityPrefabPerformance()).Value;
		}
	}
}
