using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002964 RID: 10596
	public class IFocusOnCustomMapMark : IFocusOnMapMark
	{
		// Token: 0x0600EAE3 RID: 60131 RVA: 0x00226288 File Offset: 0x00224488
		[NullableContext(1)]
		public static IFocusOnCustomMapMark Create(IFocusOnCustomMapMark? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFocusOnCustomMapMark
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049DD RID: 18909
		// (get) Token: 0x0600EAE4 RID: 60132 RVA: 0x002262A7 File Offset: 0x002244A7
		public override EMapMarkType Type
		{
			get
			{
				return (EMapMarkType)this.Instance.Type;
			}
		}

		// Token: 0x170049DE RID: 18910
		// (get) Token: 0x0600EAE5 RID: 60133 RVA: 0x002262B4 File Offset: 0x002244B4
		public virtual int MarkId
		{
			get
			{
				return this.Instance.MarkId;
			}
		}

		// Token: 0x0400816C RID: 33132
		private IFocusOnCustomMapMark Instance;
	}
}
