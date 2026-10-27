using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024F7 RID: 9463
	public class IFixedTime
	{
		// Token: 0x0600D347 RID: 54087 RVA: 0x001F53F8 File Offset: 0x001F35F8
		[NullableContext(1)]
		public static IFixedTime Create(IFixedTime? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedTime
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B1B RID: 15131
		// (get) Token: 0x0600D348 RID: 54088 RVA: 0x001F5417 File Offset: 0x001F3617
		public virtual int Hour
		{
			get
			{
				return this.Instance.Hour;
			}
		}

		// Token: 0x17003B1C RID: 15132
		// (get) Token: 0x0600D349 RID: 54089 RVA: 0x001F5424 File Offset: 0x001F3624
		public virtual int Minutes
		{
			get
			{
				return this.Instance.Minutes;
			}
		}

		// Token: 0x040073D5 RID: 29653
		private IFixedTime Instance;
	}
}
