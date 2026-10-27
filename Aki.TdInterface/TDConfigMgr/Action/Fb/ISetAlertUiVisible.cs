using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029FC RID: 10748
	public class ISetAlertUiVisible : IAlertSystemOption
	{
		// Token: 0x0600ED3A RID: 60730 RVA: 0x00229989 File Offset: 0x00227B89
		[NullableContext(1)]
		public static ISetAlertUiVisible Create(ISetAlertUiVisible? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAlertUiVisible
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B04 RID: 19204
		// (get) Token: 0x0600ED3B RID: 60731 RVA: 0x002299A8 File Offset: 0x00227BA8
		public override EAlertSystemOption Type
		{
			get
			{
				return (EAlertSystemOption)this.Instance.Type;
			}
		}

		// Token: 0x17004B05 RID: 19205
		// (get) Token: 0x0600ED3C RID: 60732 RVA: 0x002299B5 File Offset: 0x00227BB5
		public override int AreaId
		{
			get
			{
				return this.Instance.AreaId;
			}
		}

		// Token: 0x17004B06 RID: 19206
		// (get) Token: 0x0600ED3D RID: 60733 RVA: 0x002299C2 File Offset: 0x00227BC2
		public virtual bool IsVisible
		{
			get
			{
				return this.Instance.IsVisible;
			}
		}

		// Token: 0x0400829A RID: 33434
		private ISetAlertUiVisible Instance;
	}
}
