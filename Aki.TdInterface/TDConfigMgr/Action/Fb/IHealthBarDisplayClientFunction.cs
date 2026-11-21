using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C1B RID: 11291
	public class IHealthBarDisplayClientFunction : EnableClientFunction
	{
		// Token: 0x0600F87B RID: 63611 RVA: 0x00241E91 File Offset: 0x00240091
		public static IHealthBarDisplayClientFunction Create(IHealthBarDisplayClientFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHealthBarDisplayClientFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CF3 RID: 19699
		// (get) Token: 0x0600F87C RID: 63612 RVA: 0x00241EB0 File Offset: 0x002400B0
		public override EEnableClientFunctionType Type
		{
			get
			{
				return (EEnableClientFunctionType)this.Instance.Type;
			}
		}

		// Token: 0x17004CF4 RID: 19700
		// (get) Token: 0x0600F87D RID: 63613 RVA: 0x00241EBD File Offset: 0x002400BD
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004CF5 RID: 19701
		// (get) Token: 0x0600F87E RID: 63614 RVA: 0x00241ECA File Offset: 0x002400CA
		public virtual bool IsVisible
		{
			get
			{
				return this.Instance.IsVisible;
			}
		}

		// Token: 0x040087F3 RID: 34803
		private IHealthBarDisplayClientFunction Instance;
	}
}
