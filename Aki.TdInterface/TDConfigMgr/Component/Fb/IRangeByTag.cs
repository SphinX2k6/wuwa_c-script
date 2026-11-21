using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B4C RID: 2892
	public class IRangeByTag
	{
		// Token: 0x0600420A RID: 16906 RVA: 0x000A7DF6 File Offset: 0x000A5FF6
		public static IRangeByTag Create(IRangeByTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRangeByTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x0600420B RID: 16907 RVA: 0x000A7E15 File Offset: 0x000A6015
		public virtual int Tag
		{
			get
			{
				return this.Instance.Tag;
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x0600420C RID: 16908 RVA: 0x000A7E22 File Offset: 0x000A6022
		public virtual float Range
		{
			get
			{
				return this.Instance.Range;
			}
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x0600420D RID: 16909 RVA: 0x000A7E30 File Offset: 0x000A6030
		public virtual float? ExitRange
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.ExitRange);
			}
		}

		// Token: 0x0400248D RID: 9357
		private IRangeByTag Instance;
	}
}
