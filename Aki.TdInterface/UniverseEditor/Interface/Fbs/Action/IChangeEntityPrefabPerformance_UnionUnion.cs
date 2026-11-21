using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006959 RID: 26969
	public class IChangeEntityPrefabPerformance_UnionUnion
	{
		// Token: 0x1700C67C RID: 50812
		// (get) Token: 0x0602E398 RID: 189336 RVA: 0x00650305 File Offset: 0x0064E505
		// (set) Token: 0x0602E399 RID: 189337 RVA: 0x0065030D File Offset: 0x0064E50D
		public IChangeEntityPrefabPerformance_Union Type { get; set; }

		// Token: 0x1700C67D RID: 50813
		// (get) Token: 0x0602E39A RID: 189338 RVA: 0x00650316 File Offset: 0x0064E516
		// (set) Token: 0x0602E39B RID: 189339 RVA: 0x0065031E File Offset: 0x0064E51E
		public object Value { get; set; }

		// Token: 0x0602E39C RID: 189340 RVA: 0x00650327 File Offset: 0x0064E527
		public IChangeEntityPrefabPerformance_UnionUnion()
		{
			this.Type = IChangeEntityPrefabPerformance_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E39D RID: 189341 RVA: 0x0065033D File Offset: 0x0064E53D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E39E RID: 189342 RVA: 0x0065034F File Offset: 0x0064E54F
		public IChangeEntityPrefabPerformanceT AsIChangeEntityPrefabPerformance()
		{
			return this.As<IChangeEntityPrefabPerformanceT>();
		}

		// Token: 0x0602E39F RID: 189343 RVA: 0x00650357 File Offset: 0x0064E557
		public static IChangeEntityPrefabPerformance_UnionUnion FromIChangeEntityPrefabPerformance(IChangeEntityPrefabPerformanceT _ichangeentityprefabperformance)
		{
			return new IChangeEntityPrefabPerformance_UnionUnion
			{
				Type = IChangeEntityPrefabPerformance_Union.IChangeEntityPrefabPerformance,
				Value = _ichangeentityprefabperformance
			};
		}

		// Token: 0x0602E3A0 RID: 189344 RVA: 0x0065036C File Offset: 0x0064E56C
		public IChangeTargetEntityPrefabPerformanceT AsIChangeTargetEntityPrefabPerformance()
		{
			return this.As<IChangeTargetEntityPrefabPerformanceT>();
		}

		// Token: 0x0602E3A1 RID: 189345 RVA: 0x00650374 File Offset: 0x0064E574
		public static IChangeEntityPrefabPerformance_UnionUnion FromIChangeTargetEntityPrefabPerformance(IChangeTargetEntityPrefabPerformanceT _ichangetargetentityprefabperformance)
		{
			return new IChangeEntityPrefabPerformance_UnionUnion
			{
				Type = IChangeEntityPrefabPerformance_Union.IChangeTargetEntityPrefabPerformance,
				Value = _ichangetargetentityprefabperformance
			};
		}

		// Token: 0x0602E3A2 RID: 189346 RVA: 0x00650389 File Offset: 0x0064E589
		public IChangeSelfEntityPrefabPerformanceT AsIChangeSelfEntityPrefabPerformance()
		{
			return this.As<IChangeSelfEntityPrefabPerformanceT>();
		}

		// Token: 0x0602E3A3 RID: 189347 RVA: 0x00650391 File Offset: 0x0064E591
		public static IChangeEntityPrefabPerformance_UnionUnion FromIChangeSelfEntityPrefabPerformance(IChangeSelfEntityPrefabPerformanceT _ichangeselfentityprefabperformance)
		{
			return new IChangeEntityPrefabPerformance_UnionUnion
			{
				Type = IChangeEntityPrefabPerformance_Union.IChangeSelfEntityPrefabPerformance,
				Value = _ichangeselfentityprefabperformance
			};
		}

		// Token: 0x0602E3A4 RID: 189348 RVA: 0x006503A8 File Offset: 0x0064E5A8
		public static int Pack(FlatBufferBuilder builder, IChangeEntityPrefabPerformance_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IChangeEntityPrefabPerformance_Union.IChangeEntityPrefabPerformance:
				return IChangeEntityPrefabPerformance.Pack(builder, _o.AsIChangeEntityPrefabPerformance()).Value;
			case IChangeEntityPrefabPerformance_Union.IChangeTargetEntityPrefabPerformance:
				return IChangeTargetEntityPrefabPerformance.Pack(builder, _o.AsIChangeTargetEntityPrefabPerformance()).Value;
			case IChangeEntityPrefabPerformance_Union.IChangeSelfEntityPrefabPerformance:
				return IChangeSelfEntityPrefabPerformance.Pack(builder, _o.AsIChangeSelfEntityPrefabPerformance()).Value;
			default:
				return 0;
			}
		}
	}
}
