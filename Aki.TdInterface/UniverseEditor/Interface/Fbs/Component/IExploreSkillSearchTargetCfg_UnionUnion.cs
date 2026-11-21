using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005773 RID: 22387
	public class IExploreSkillSearchTargetCfg_UnionUnion
	{
		// Token: 0x1700A1D0 RID: 41424
		// (get) Token: 0x0602418E RID: 147854 RVA: 0x004F6D51 File Offset: 0x004F4F51
		// (set) Token: 0x0602418F RID: 147855 RVA: 0x004F6D59 File Offset: 0x004F4F59
		public IExploreSkillSearchTargetCfg_Union Type { get; set; }

		// Token: 0x1700A1D1 RID: 41425
		// (get) Token: 0x06024190 RID: 147856 RVA: 0x004F6D62 File Offset: 0x004F4F62
		// (set) Token: 0x06024191 RID: 147857 RVA: 0x004F6D6A File Offset: 0x004F4F6A
		public object Value { get; set; }

		// Token: 0x06024192 RID: 147858 RVA: 0x004F6D73 File Offset: 0x004F4F73
		public IExploreSkillSearchTargetCfg_UnionUnion()
		{
			this.Type = IExploreSkillSearchTargetCfg_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024193 RID: 147859 RVA: 0x004F6D89 File Offset: 0x004F4F89
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024194 RID: 147860 RVA: 0x004F6D9B File Offset: 0x004F4F9B
		public IExploreSkillSearchTargetCfgT AsIExploreSkillSearchTargetCfg()
		{
			return this.As<IExploreSkillSearchTargetCfgT>();
		}

		// Token: 0x06024195 RID: 147861 RVA: 0x004F6DA3 File Offset: 0x004F4FA3
		public static IExploreSkillSearchTargetCfg_UnionUnion FromIExploreSkillSearchTargetCfg(IExploreSkillSearchTargetCfgT _iexploreskillsearchtargetcfg)
		{
			return new IExploreSkillSearchTargetCfg_UnionUnion
			{
				Type = IExploreSkillSearchTargetCfg_Union.IExploreSkillSearchTargetCfg,
				Value = _iexploreskillsearchtargetcfg
			};
		}

		// Token: 0x06024196 RID: 147862 RVA: 0x004F6DB8 File Offset: 0x004F4FB8
		public IAngleWeightT AsIAngleWeight()
		{
			return this.As<IAngleWeightT>();
		}

		// Token: 0x06024197 RID: 147863 RVA: 0x004F6DC0 File Offset: 0x004F4FC0
		public static IExploreSkillSearchTargetCfg_UnionUnion FromIAngleWeight(IAngleWeightT _iangleweight)
		{
			return new IExploreSkillSearchTargetCfg_UnionUnion
			{
				Type = IExploreSkillSearchTargetCfg_Union.IAngleWeight,
				Value = _iangleweight
			};
		}

		// Token: 0x06024198 RID: 147864 RVA: 0x004F6DD5 File Offset: 0x004F4FD5
		public IEnterScreenWeightT AsIEnterScreenWeight()
		{
			return this.As<IEnterScreenWeightT>();
		}

		// Token: 0x06024199 RID: 147865 RVA: 0x004F6DDD File Offset: 0x004F4FDD
		public static IExploreSkillSearchTargetCfg_UnionUnion FromIEnterScreenWeight(IEnterScreenWeightT _ienterscreenweight)
		{
			return new IExploreSkillSearchTargetCfg_UnionUnion
			{
				Type = IExploreSkillSearchTargetCfg_Union.IEnterScreenWeight,
				Value = _ienterscreenweight
			};
		}

		// Token: 0x0602419A RID: 147866 RVA: 0x004F6DF4 File Offset: 0x004F4FF4
		public static int Pack(FlatBufferBuilder builder, IExploreSkillSearchTargetCfg_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IExploreSkillSearchTargetCfg_Union.IExploreSkillSearchTargetCfg:
				return IExploreSkillSearchTargetCfg.Pack(builder, _o.AsIExploreSkillSearchTargetCfg()).Value;
			case IExploreSkillSearchTargetCfg_Union.IAngleWeight:
				return IAngleWeight.Pack(builder, _o.AsIAngleWeight()).Value;
			case IExploreSkillSearchTargetCfg_Union.IEnterScreenWeight:
				return IEnterScreenWeight.Pack(builder, _o.AsIEnterScreenWeight()).Value;
			default:
				return 0;
			}
		}
	}
}
