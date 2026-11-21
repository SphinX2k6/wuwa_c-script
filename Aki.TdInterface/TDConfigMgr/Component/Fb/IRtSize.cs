using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F2C RID: 3884
	public class IRtSize
	{
		// Token: 0x06005744 RID: 22340 RVA: 0x000D5E43 File Offset: 0x000D4043
		public static IRtSize Create(IRtSize? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRtSize
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x06005745 RID: 22341 RVA: 0x000D5E62 File Offset: 0x000D4062
		public virtual int Length
		{
			get
			{
				return this.Instance.Length;
			}
		}

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x06005746 RID: 22342 RVA: 0x000D5E6F File Offset: 0x000D406F
		public virtual int Width
		{
			get
			{
				return this.Instance.Width;
			}
		}

		// Token: 0x04003215 RID: 12821
		private IRtSize Instance;
	}
}
