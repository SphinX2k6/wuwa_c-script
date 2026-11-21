using System;
using CSharpScript.Game.Module.ActivityAction;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058AC RID: 22700
	public abstract class SolarSchoolActionBase : ActivityActionBase
	{
		// Token: 0x17006B51 RID: 27473
		// (get) Token: 0x06037EC1 RID: 229057 RVA: 0x00FA1737 File Offset: 0x00F9F937
		public virtual bool ConsumesActionPoint
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17006B52 RID: 27474
		// (get) Token: 0x06037EC2 RID: 229058 RVA: 0x00FA173A File Offset: 0x00F9F93A
		public virtual bool NeedPrepareFirstScreen
		{
			get
			{
				return false;
			}
		}
	}
}
