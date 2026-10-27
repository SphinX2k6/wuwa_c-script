using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A4E RID: 10830
	public class ReignsSetPropertyVisible : ActionParams
	{
		// Token: 0x0600EE5A RID: 61018 RVA: 0x0022B3E4 File Offset: 0x002295E4
		[NullableContext(1)]
		public static ReignsSetPropertyVisible Create(IReignsSetPropertyVisible? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsSetPropertyVisible
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B80 RID: 19328
		// (get) Token: 0x0600EE5B RID: 61019 RVA: 0x0022B403 File Offset: 0x00229603
		public virtual int PropertyId
		{
			get
			{
				return this.Instance.PropertyId;
			}
		}

		// Token: 0x17004B81 RID: 19329
		// (get) Token: 0x0600EE5C RID: 61020 RVA: 0x0022B410 File Offset: 0x00229610
		public virtual bool IsVisible
		{
			get
			{
				return this.Instance.IsVisible;
			}
		}

		// Token: 0x0400832A RID: 33578
		private IReignsSetPropertyVisible Instance;
	}
}
