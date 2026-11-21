using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B6C RID: 2924
	public class ICustomAoizRadius
	{
		// Token: 0x060042DB RID: 17115 RVA: 0x000A9C21 File Offset: 0x000A7E21
		public static ICustomAoizRadius Create(ICustomAoizRadius? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomAoizRadius
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x060042DC RID: 17116 RVA: 0x000A9C40 File Offset: 0x000A7E40
		public virtual int? Up
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Up);
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x060042DD RID: 17117 RVA: 0x000A9C78 File Offset: 0x000A7E78
		public virtual int? Down
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Down);
			}
		}

		// Token: 0x040024EF RID: 9455
		private ICustomAoizRadius Instance;
	}
}
