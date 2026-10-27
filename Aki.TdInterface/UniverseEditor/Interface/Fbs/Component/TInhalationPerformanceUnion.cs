using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C3D RID: 23613
	public class TInhalationPerformanceUnion
	{
		// Token: 0x1700B206 RID: 45574
		// (get) Token: 0x060287D5 RID: 165845 RVA: 0x005920EA File Offset: 0x005902EA
		// (set) Token: 0x060287D6 RID: 165846 RVA: 0x005920F2 File Offset: 0x005902F2
		public TInhalationPerformance Type { get; set; }

		// Token: 0x1700B207 RID: 45575
		// (get) Token: 0x060287D7 RID: 165847 RVA: 0x005920FB File Offset: 0x005902FB
		// (set) Token: 0x060287D8 RID: 165848 RVA: 0x00592103 File Offset: 0x00590303
		public object Value { get; set; }

		// Token: 0x060287D9 RID: 165849 RVA: 0x0059210C File Offset: 0x0059030C
		public TInhalationPerformanceUnion()
		{
			this.Type = TInhalationPerformance.NONE;
			this.Value = null;
		}

		// Token: 0x060287DA RID: 165850 RVA: 0x00592122 File Offset: 0x00590322
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060287DB RID: 165851 RVA: 0x00592134 File Offset: 0x00590334
		public IRoleInhalationT AsIRoleInhalation()
		{
			return this.As<IRoleInhalationT>();
		}

		// Token: 0x060287DC RID: 165852 RVA: 0x0059213C File Offset: 0x0059033C
		public static TInhalationPerformanceUnion FromIRoleInhalation(IRoleInhalationT _iroleinhalation)
		{
			return new TInhalationPerformanceUnion
			{
				Type = TInhalationPerformance.IRoleInhalation,
				Value = _iroleinhalation
			};
		}

		// Token: 0x060287DD RID: 165853 RVA: 0x00592151 File Offset: 0x00590351
		public ISceneItemInhalationT AsISceneItemInhalation()
		{
			return this.As<ISceneItemInhalationT>();
		}

		// Token: 0x060287DE RID: 165854 RVA: 0x00592159 File Offset: 0x00590359
		public static TInhalationPerformanceUnion FromISceneItemInhalation(ISceneItemInhalationT _isceneiteminhalation)
		{
			return new TInhalationPerformanceUnion
			{
				Type = TInhalationPerformance.ISceneItemInhalation,
				Value = _isceneiteminhalation
			};
		}

		// Token: 0x060287DF RID: 165855 RVA: 0x00592170 File Offset: 0x00590370
		public static int Pack(FlatBufferBuilder builder, TInhalationPerformanceUnion _o)
		{
			TInhalationPerformance type = _o.Type;
			if (type == TInhalationPerformance.IRoleInhalation)
			{
				return IRoleInhalation.Pack(builder, _o.AsIRoleInhalation()).Value;
			}
			if (type != TInhalationPerformance.ISceneItemInhalation)
			{
				return 0;
			}
			return ISceneItemInhalation.Pack(builder, _o.AsISceneItemInhalation()).Value;
		}
	}
}
