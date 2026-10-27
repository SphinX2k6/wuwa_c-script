using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024F5 RID: 9461
	public class AdjustTodTime : ActionParams
	{
		// Token: 0x0600D33F RID: 54079 RVA: 0x001F5376 File Offset: 0x001F3576
		[NullableContext(1)]
		public static AdjustTodTime Create(IAdjustTodTime? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AdjustTodTime
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B17 RID: 15127
		// (get) Token: 0x0600D340 RID: 54080 RVA: 0x001F5395 File Offset: 0x001F3595
		public virtual int Hour
		{
			get
			{
				return this.Instance.Hour;
			}
		}

		// Token: 0x17003B18 RID: 15128
		// (get) Token: 0x0600D341 RID: 54081 RVA: 0x001F53A2 File Offset: 0x001F35A2
		public virtual int Min
		{
			get
			{
				return this.Instance.Min;
			}
		}

		// Token: 0x17003B19 RID: 15129
		// (get) Token: 0x0600D342 RID: 54082 RVA: 0x001F53AF File Offset: 0x001F35AF
		public virtual bool ShowUi
		{
			get
			{
				return this.Instance.ShowUi;
			}
		}

		// Token: 0x040073D3 RID: 29651
		private IAdjustTodTime Instance;
	}
}
