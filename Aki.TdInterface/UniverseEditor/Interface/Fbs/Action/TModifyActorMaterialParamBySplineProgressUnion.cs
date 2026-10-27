using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007714 RID: 30484
	public class TModifyActorMaterialParamBySplineProgressUnion
	{
		// Token: 0x1700E651 RID: 58961
		// (get) Token: 0x060376B8 RID: 227000 RVA: 0x0078136E File Offset: 0x0077F56E
		// (set) Token: 0x060376B9 RID: 227001 RVA: 0x00781376 File Offset: 0x0077F576
		public TModifyActorMaterialParamBySplineProgress Type { get; set; }

		// Token: 0x1700E652 RID: 58962
		// (get) Token: 0x060376BA RID: 227002 RVA: 0x0078137F File Offset: 0x0077F57F
		// (set) Token: 0x060376BB RID: 227003 RVA: 0x00781387 File Offset: 0x0077F587
		public object Value { get; set; }

		// Token: 0x060376BC RID: 227004 RVA: 0x00781390 File Offset: 0x0077F590
		public TModifyActorMaterialParamBySplineProgressUnion()
		{
			this.Type = TModifyActorMaterialParamBySplineProgress.NONE;
			this.Value = null;
		}

		// Token: 0x060376BD RID: 227005 RVA: 0x007813A6 File Offset: 0x0077F5A6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060376BE RID: 227006 RVA: 0x007813B8 File Offset: 0x0077F5B8
		public IModifyActorMaterialParamBySplineProgressEnterSplineT AsIModifyActorMaterialParamBySplineProgressEnterSpline()
		{
			return this.As<IModifyActorMaterialParamBySplineProgressEnterSplineT>();
		}

		// Token: 0x060376BF RID: 227007 RVA: 0x007813C0 File Offset: 0x0077F5C0
		public static TModifyActorMaterialParamBySplineProgressUnion FromIModifyActorMaterialParamBySplineProgressEnterSpline(IModifyActorMaterialParamBySplineProgressEnterSplineT _imodifyactormaterialparambysplineprogressenterspline)
		{
			return new TModifyActorMaterialParamBySplineProgressUnion
			{
				Type = TModifyActorMaterialParamBySplineProgress.IModifyActorMaterialParamBySplineProgressEnterSpline,
				Value = _imodifyactormaterialparambysplineprogressenterspline
			};
		}

		// Token: 0x060376C0 RID: 227008 RVA: 0x007813D5 File Offset: 0x0077F5D5
		public IModifyActorMaterialParamBySplineProgressExitSplineT AsIModifyActorMaterialParamBySplineProgressExitSpline()
		{
			return this.As<IModifyActorMaterialParamBySplineProgressExitSplineT>();
		}

		// Token: 0x060376C1 RID: 227009 RVA: 0x007813DD File Offset: 0x0077F5DD
		public static TModifyActorMaterialParamBySplineProgressUnion FromIModifyActorMaterialParamBySplineProgressExitSpline(IModifyActorMaterialParamBySplineProgressExitSplineT _imodifyactormaterialparambysplineprogressexitspline)
		{
			return new TModifyActorMaterialParamBySplineProgressUnion
			{
				Type = TModifyActorMaterialParamBySplineProgress.IModifyActorMaterialParamBySplineProgressExitSpline,
				Value = _imodifyactormaterialparambysplineprogressexitspline
			};
		}

		// Token: 0x060376C2 RID: 227010 RVA: 0x007813F4 File Offset: 0x0077F5F4
		public static int Pack(FlatBufferBuilder builder, TModifyActorMaterialParamBySplineProgressUnion _o)
		{
			TModifyActorMaterialParamBySplineProgress type = _o.Type;
			if (type == TModifyActorMaterialParamBySplineProgress.IModifyActorMaterialParamBySplineProgressEnterSpline)
			{
				return IModifyActorMaterialParamBySplineProgressEnterSpline.Pack(builder, _o.AsIModifyActorMaterialParamBySplineProgressEnterSpline()).Value;
			}
			if (type != TModifyActorMaterialParamBySplineProgress.IModifyActorMaterialParamBySplineProgressExitSpline)
			{
				return 0;
			}
			return IModifyActorMaterialParamBySplineProgressExitSpline.Pack(builder, _o.AsIModifyActorMaterialParamBySplineProgressExitSpline()).Value;
		}
	}
}
