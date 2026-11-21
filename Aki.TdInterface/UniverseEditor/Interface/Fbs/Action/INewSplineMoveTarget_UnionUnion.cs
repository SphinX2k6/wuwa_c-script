using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072E4 RID: 29412
	public class INewSplineMoveTarget_UnionUnion
	{
		// Token: 0x1700D7AF RID: 55215
		// (get) Token: 0x0603348D RID: 210061 RVA: 0x006EB065 File Offset: 0x006E9265
		// (set) Token: 0x0603348E RID: 210062 RVA: 0x006EB06D File Offset: 0x006E926D
		public INewSplineMoveTarget_Union Type { get; set; }

		// Token: 0x1700D7B0 RID: 55216
		// (get) Token: 0x0603348F RID: 210063 RVA: 0x006EB076 File Offset: 0x006E9276
		// (set) Token: 0x06033490 RID: 210064 RVA: 0x006EB07E File Offset: 0x006E927E
		public object Value { get; set; }

		// Token: 0x06033491 RID: 210065 RVA: 0x006EB087 File Offset: 0x006E9287
		public INewSplineMoveTarget_UnionUnion()
		{
			this.Type = INewSplineMoveTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033492 RID: 210066 RVA: 0x006EB09D File Offset: 0x006E929D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033493 RID: 210067 RVA: 0x006EB0AF File Offset: 0x006E92AF
		public INewSplineMoveTargetT AsINewSplineMoveTarget()
		{
			return this.As<INewSplineMoveTargetT>();
		}

		// Token: 0x06033494 RID: 210068 RVA: 0x006EB0B7 File Offset: 0x006E92B7
		public static INewSplineMoveTarget_UnionUnion FromINewSplineMoveTarget(INewSplineMoveTargetT _inewsplinemovetarget)
		{
			return new INewSplineMoveTarget_UnionUnion
			{
				Type = INewSplineMoveTarget_Union.INewSplineMoveTarget,
				Value = _inewsplinemovetarget
			};
		}

		// Token: 0x06033495 RID: 210069 RVA: 0x006EB0CC File Offset: 0x006E92CC
		public IPlayerNewSplineMoveTargetT AsIPlayerNewSplineMoveTarget()
		{
			return this.As<IPlayerNewSplineMoveTargetT>();
		}

		// Token: 0x06033496 RID: 210070 RVA: 0x006EB0D4 File Offset: 0x006E92D4
		public static INewSplineMoveTarget_UnionUnion FromIPlayerNewSplineMoveTarget(IPlayerNewSplineMoveTargetT _iplayernewsplinemovetarget)
		{
			return new INewSplineMoveTarget_UnionUnion
			{
				Type = INewSplineMoveTarget_Union.IPlayerNewSplineMoveTarget,
				Value = _iplayernewsplinemovetarget
			};
		}

		// Token: 0x06033497 RID: 210071 RVA: 0x006EB0E9 File Offset: 0x006E92E9
		public INpcNewSplineMoveTargetT AsINpcNewSplineMoveTarget()
		{
			return this.As<INpcNewSplineMoveTargetT>();
		}

		// Token: 0x06033498 RID: 210072 RVA: 0x006EB0F1 File Offset: 0x006E92F1
		public static INewSplineMoveTarget_UnionUnion FromINpcNewSplineMoveTarget(INpcNewSplineMoveTargetT _inpcnewsplinemovetarget)
		{
			return new INewSplineMoveTarget_UnionUnion
			{
				Type = INewSplineMoveTarget_Union.INpcNewSplineMoveTarget,
				Value = _inpcnewsplinemovetarget
			};
		}

		// Token: 0x06033499 RID: 210073 RVA: 0x006EB106 File Offset: 0x006E9306
		public ISceneItemNewSplineMoveTargetT AsISceneItemNewSplineMoveTarget()
		{
			return this.As<ISceneItemNewSplineMoveTargetT>();
		}

		// Token: 0x0603349A RID: 210074 RVA: 0x006EB10E File Offset: 0x006E930E
		public static INewSplineMoveTarget_UnionUnion FromISceneItemNewSplineMoveTarget(ISceneItemNewSplineMoveTargetT _isceneitemnewsplinemovetarget)
		{
			return new INewSplineMoveTarget_UnionUnion
			{
				Type = INewSplineMoveTarget_Union.ISceneItemNewSplineMoveTarget,
				Value = _isceneitemnewsplinemovetarget
			};
		}

		// Token: 0x0603349B RID: 210075 RVA: 0x006EB123 File Offset: 0x006E9323
		public IVehicleNewSplineMoveTargetT AsIVehicleNewSplineMoveTarget()
		{
			return this.As<IVehicleNewSplineMoveTargetT>();
		}

		// Token: 0x0603349C RID: 210076 RVA: 0x006EB12B File Offset: 0x006E932B
		public static INewSplineMoveTarget_UnionUnion FromIVehicleNewSplineMoveTarget(IVehicleNewSplineMoveTargetT _ivehiclenewsplinemovetarget)
		{
			return new INewSplineMoveTarget_UnionUnion
			{
				Type = INewSplineMoveTarget_Union.IVehicleNewSplineMoveTarget,
				Value = _ivehiclenewsplinemovetarget
			};
		}

		// Token: 0x0603349D RID: 210077 RVA: 0x006EB140 File Offset: 0x006E9340
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
