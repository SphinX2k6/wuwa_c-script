using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ACF RID: 2767
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityState
	{
		// Token: 0x06003FC2 RID: 16322 RVA: 0x000A3046 File Offset: 0x000A1246
		public static IEntityState Create(IEntityState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x06003FC3 RID: 16323 RVA: 0x000A3065 File Offset: 0x000A1265
		public virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x06003FC4 RID: 16324 RVA: 0x000A3072 File Offset: 0x000A1272
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x0400237C RID: 9084
		private IEntityState Instance;
	}
}
