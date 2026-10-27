using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200520B RID: 21003
	public class IExploreSkillSearchTargetCfg_UnionUnion
	{
		// Token: 0x170099D4 RID: 39380
		// (get) Token: 0x060221F8 RID: 139768 RVA: 0x004BC28D File Offset: 0x004BA48D
		// (set) Token: 0x060221F9 RID: 139769 RVA: 0x004BC295 File Offset: 0x004BA495
		public IExploreSkillSearchTargetCfg_Union Type { get; set; }

		// Token: 0x170099D5 RID: 39381
		// (get) Token: 0x060221FA RID: 139770 RVA: 0x004BC29E File Offset: 0x004BA49E
		// (set) Token: 0x060221FB RID: 139771 RVA: 0x004BC2A6 File Offset: 0x004BA4A6
		public object Value { get; set; }

		// Token: 0x060221FC RID: 139772 RVA: 0x004BC2AF File Offset: 0x004BA4AF
		public IExploreSkillSearchTargetCfg_UnionUnion()
		{
			this.Type = IExploreSkillSearchTargetCfg_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060221FD RID: 139773 RVA: 0x004BC2C5 File Offset: 0x004BA4C5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060221FE RID: 139774 RVA: 0x004BC2D7 File Offset: 0x004BA4D7
		public IExploreSkillSearchTargetCfgT AsIExploreSkillSearchTargetCfg()
		{
			return this.As<IExploreSkillSearchTargetCfgT>();
		}

		// Token: 0x060221FF RID: 139775 RVA: 0x004BC2DF File Offset: 0x004BA4DF
		public static IExploreSkillSearchTargetCfg_UnionUnion FromIExploreSkillSearchTargetCfg(IExploreSkillSearchTargetCfgT _iexploreskillsearchtargetcfg)
		{
			return new IExploreSkillSearchTargetCfg_UnionUnion
			{
				Type = IExploreSkillSearchTargetCfg_Union.IExploreSkillSearchTargetCfg,
				Value = _iexploreskillsearchtargetcfg
			};
		}

		// Token: 0x06022200 RID: 139776 RVA: 0x004BC2F4 File Offset: 0x004BA4F4
		public IAngleWeightT AsIAngleWeight()
		{
			return this.As<IAngleWeightT>();
		}

		// Token: 0x06022201 RID: 139777 RVA: 0x004BC2FC File Offset: 0x004BA4FC
		public static IExploreSkillSearchTargetCfg_UnionUnion FromIAngleWeight(IAngleWeightT _iangleweight)
		{
			return new IExploreSkillSearchTargetCfg_UnionUnion
			{
				Type = IExploreSkillSearchTargetCfg_Union.IAngleWeight,
				Value = _iangleweight
			};
		}

		// Token: 0x06022202 RID: 139778 RVA: 0x004BC311 File Offset: 0x004BA511
		public IEnterScreenWeightT AsIEnterScreenWeight()
		{
			return this.As<IEnterScreenWeightT>();
		}

		// Token: 0x06022203 RID: 139779 RVA: 0x004BC319 File Offset: 0x004BA519
		public static IExploreSkillSearchTargetCfg_UnionUnion FromIEnterScreenWeight(IEnterScreenWeightT _ienterscreenweight)
		{
			return new IExploreSkillSearchTargetCfg_UnionUnion
			{
				Type = IExploreSkillSearchTargetCfg_Union.IEnterScreenWeight,
				Value = _ienterscreenweight
			};
		}

		// Token: 0x06022204 RID: 139780 RVA: 0x004BC330 File Offset: 0x004BA530
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
