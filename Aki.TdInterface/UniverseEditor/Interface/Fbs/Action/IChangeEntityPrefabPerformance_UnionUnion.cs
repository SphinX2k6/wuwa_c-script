using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062E8 RID: 25320
	public class IChangeEntityPrefabPerformance_UnionUnion
	{
		// Token: 0x1700BCF2 RID: 48370
		// (get) Token: 0x0602BC2F RID: 179247 RVA: 0x006052F9 File Offset: 0x006034F9
		// (set) Token: 0x0602BC30 RID: 179248 RVA: 0x00605301 File Offset: 0x00603501
		public IChangeEntityPrefabPerformance_Union Type { get; set; }

		// Token: 0x1700BCF3 RID: 48371
		// (get) Token: 0x0602BC31 RID: 179249 RVA: 0x0060530A File Offset: 0x0060350A
		// (set) Token: 0x0602BC32 RID: 179250 RVA: 0x00605312 File Offset: 0x00603512
		public object Value { get; set; }

		// Token: 0x0602BC33 RID: 179251 RVA: 0x0060531B File Offset: 0x0060351B
		public IChangeEntityPrefabPerformance_UnionUnion()
		{
			this.Type = IChangeEntityPrefabPerformance_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602BC34 RID: 179252 RVA: 0x00605331 File Offset: 0x00603531
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BC35 RID: 179253 RVA: 0x00605343 File Offset: 0x00603543
		public IChangeEntityPrefabPerformanceT AsIChangeEntityPrefabPerformance()
		{
			return this.As<IChangeEntityPrefabPerformanceT>();
		}

		// Token: 0x0602BC36 RID: 179254 RVA: 0x0060534B File Offset: 0x0060354B
		public static IChangeEntityPrefabPerformance_UnionUnion FromIChangeEntityPrefabPerformance(IChangeEntityPrefabPerformanceT _ichangeentityprefabperformance)
		{
			return new IChangeEntityPrefabPerformance_UnionUnion
			{
				Type = IChangeEntityPrefabPerformance_Union.IChangeEntityPrefabPerformance,
				Value = _ichangeentityprefabperformance
			};
		}

		// Token: 0x0602BC37 RID: 179255 RVA: 0x00605360 File Offset: 0x00603560
		public IChangeTargetEntityPrefabPerformanceT AsIChangeTargetEntityPrefabPerformance()
		{
			return this.As<IChangeTargetEntityPrefabPerformanceT>();
		}

		// Token: 0x0602BC38 RID: 179256 RVA: 0x00605368 File Offset: 0x00603568
		public static IChangeEntityPrefabPerformance_UnionUnion FromIChangeTargetEntityPrefabPerformance(IChangeTargetEntityPrefabPerformanceT _ichangetargetentityprefabperformance)
		{
			return new IChangeEntityPrefabPerformance_UnionUnion
			{
				Type = IChangeEntityPrefabPerformance_Union.IChangeTargetEntityPrefabPerformance,
				Value = _ichangetargetentityprefabperformance
			};
		}

		// Token: 0x0602BC39 RID: 179257 RVA: 0x0060537D File Offset: 0x0060357D
		public IChangeSelfEntityPrefabPerformanceT AsIChangeSelfEntityPrefabPerformance()
		{
			return this.As<IChangeSelfEntityPrefabPerformanceT>();
		}

		// Token: 0x0602BC3A RID: 179258 RVA: 0x00605385 File Offset: 0x00603585
		public static IChangeEntityPrefabPerformance_UnionUnion FromIChangeSelfEntityPrefabPerformance(IChangeSelfEntityPrefabPerformanceT _ichangeselfentityprefabperformance)
		{
			return new IChangeEntityPrefabPerformance_UnionUnion
			{
				Type = IChangeEntityPrefabPerformance_Union.IChangeSelfEntityPrefabPerformance,
				Value = _ichangeselfentityprefabperformance
			};
		}

		// Token: 0x0602BC3B RID: 179259 RVA: 0x0060539C File Offset: 0x0060359C
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
