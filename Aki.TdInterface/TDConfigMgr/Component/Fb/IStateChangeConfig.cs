using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ABC RID: 2748
	[NullableContext(2)]
	[Nullable(0)]
	public class IStateChangeConfig
	{
		// Token: 0x06003F53 RID: 16211 RVA: 0x000A1D0A File Offset: 0x0009FF0A
		[NullableContext(1)]
		public static IStateChangeConfig Create(IStateChangeConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateChangeConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06003F54 RID: 16212 RVA: 0x000A1D29 File Offset: 0x0009FF29
		public virtual string RefreshState
		{
			get
			{
				return this.Instance.RefreshState;
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06003F55 RID: 16213 RVA: 0x000A1D36 File Offset: 0x0009FF36
		public virtual string SubDestroyState
		{
			get
			{
				return this.Instance.SubDestroyState;
			}
		}

		// Token: 0x0400232B RID: 9003
		private IStateChangeConfig Instance;
	}
}
