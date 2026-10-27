using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B9E RID: 27550
	public class INewSplineMoveTarget_UnionUnion
	{
		// Token: 0x1700CCC8 RID: 52424
		// (get) Token: 0x06030631 RID: 198193 RVA: 0x00692939 File Offset: 0x00690B39
		// (set) Token: 0x06030632 RID: 198194 RVA: 0x00692941 File Offset: 0x00690B41
		public INewSplineMoveTarget_Union Type { get; set; }

		// Token: 0x1700CCC9 RID: 52425
		// (get) Token: 0x06030633 RID: 198195 RVA: 0x0069294A File Offset: 0x00690B4A
		// (set) Token: 0x06030634 RID: 198196 RVA: 0x00692952 File Offset: 0x00690B52
		public object Value { get; set; }

		// Token: 0x06030635 RID: 198197 RVA: 0x0069295B File Offset: 0x00690B5B
		public INewSplineMoveTarget_UnionUnion()
		{
			this.Type = INewSplineMoveTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030636 RID: 198198 RVA: 0x00692971 File Offset: 0x00690B71
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030637 RID: 198199 RVA: 0x00692983 File Offset: 0x00690B83
		public INewSplineMoveTargetT AsINewSplineMoveTarget()
		{
			return this.As<INewSplineMoveTargetT>();
		}

		// Token: 0x06030638 RID: 198200 RVA: 0x0069298B File Offset: 0x00690B8B
		public static INewSplineMoveTarget_UnionUnion FromINewSplineMoveTarget(INewSplineMoveTargetT _inewsplinemovetarget)
		{
			return new INewSplineMoveTarget_UnionUnion
			{
				Type = INewSplineMoveTarget_Union.INewSplineMoveTarget,
				Value = _inewsplinemovetarget
			};
		}

		// Token: 0x06030639 RID: 198201 RVA: 0x006929A0 File Offset: 0x00690BA0
		public IPlayerNewSplineMoveTargetT AsIPlayerNewSplineMoveTarget()
		{
			return this.As<IPlayerNewSplineMoveTargetT>();
		}

		// Token: 0x0603063A RID: 198202 RVA: 0x006929A8 File Offset: 0x00690BA8
		public static INewSplineMoveTarget_UnionUnion FromIPlayerNewSplineMoveTarget(IPlayerNewSplineMoveTargetT _iplayernewsplinemovetarget)
		{
			return new INewSplineMoveTarget_UnionUnion
			{
				Type = INewSplineMoveTarget_Union.IPlayerNewSplineMoveTarget,
				Value = _iplayernewsplinemovetarget
			};
		}

		// Token: 0x0603063B RID: 198203 RVA: 0x006929BD File Offset: 0x00690BBD
		public INpcNewSplineMoveTargetT AsINpcNewSplineMoveTarget()
		{
			return this.As<INpcNewSplineMoveTargetT>();
		}

		// Token: 0x0603063C RID: 198204 RVA: 0x006929C5 File Offset: 0x00690BC5
		public static INewSplineMoveTarget_UnionUnion FromINpcNewSplineMoveTarget(INpcNewSplineMoveTargetT _inpcnewsplinemovetarget)
		{
			return new INewSplineMoveTarget_UnionUnion
			{
				Type = INewSplineMoveTarget_Union.INpcNewSplineMoveTarget,
				Value = _inpcnewsplinemovetarget
			};
		}

		// Token: 0x0603063D RID: 198205 RVA: 0x006929DA File Offset: 0x00690BDA
		public ISceneItemNewSplineMoveTargetT AsISceneItemNewSplineMoveTarget()
		{
			return this.As<ISceneItemNewSplineMoveTargetT>();
		}

		// Token: 0x0603063E RID: 198206 RVA: 0x006929E2 File Offset: 0x00690BE2
		public static INewSplineMoveTarget_UnionUnion FromISceneItemNewSplineMoveTarget(ISceneItemNewSplineMoveTargetT _isceneitemnewsplinemovetarget)
		{
			return new INewSplineMoveTarget_UnionUnion
			{
				Type = INewSplineMoveTarget_Union.ISceneItemNewSplineMoveTarget,
				Value = _isceneitemnewsplinemovetarget
			};
		}

		// Token: 0x0603063F RID: 198207 RVA: 0x006929F7 File Offset: 0x00690BF7
		public IVehicleNewSplineMoveTargetT AsIVehicleNewSplineMoveTarget()
		{
			return this.As<IVehicleNewSplineMoveTargetT>();
		}

		// Token: 0x06030640 RID: 198208 RVA: 0x006929FF File Offset: 0x00690BFF
		public static INewSplineMoveTarget_UnionUnion FromIVehicleNewSplineMoveTarget(IVehicleNewSplineMoveTargetT _ivehiclenewsplinemovetarget)
		{
			return new INewSplineMoveTarget_UnionUnion
			{
				Type = INewSplineMoveTarget_Union.IVehicleNewSplineMoveTarget,
				Value = _ivehiclenewsplinemovetarget
			};
		}

		// Token: 0x06030641 RID: 198209 RVA: 0x00692A14 File Offset: 0x00690C14
		public static int Pack(FlatBufferBuilder builder, INewSplineMoveTarget_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case INewSplineMoveTarget_Union.INewSplineMoveTarget:
				return INewSplineMoveTarget.Pack(builder, _o.AsINewSplineMoveTarget()).Value;
			case INewSplineMoveTarget_Union.IPlayerNewSplineMoveTarget:
				return IPlayerNewSplineMoveTarget.Pack(builder, _o.AsIPlayerNewSplineMoveTarget()).Value;
			case INewSplineMoveTarget_Union.INpcNewSplineMoveTarget:
				return INpcNewSplineMoveTarget.Pack(builder, _o.AsINpcNewSplineMoveTarget()).Value;
			case INewSplineMoveTarget_Union.ISceneItemNewSplineMoveTarget:
				return ISceneItemNewSplineMoveTarget.Pack(builder, _o.AsISceneItemNewSplineMoveTarget()).Value;
			case INewSplineMoveTarget_Union.IVehicleNewSplineMoveTarget:
				return IVehicleNewSplineMoveTarget.Pack(builder, _o.AsIVehicleNewSplineMoveTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
