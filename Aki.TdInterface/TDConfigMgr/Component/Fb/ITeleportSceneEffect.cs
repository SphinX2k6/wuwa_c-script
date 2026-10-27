using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D07 RID: 3335
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportSceneEffect
	{
		// Token: 0x06004C20 RID: 19488 RVA: 0x000BDC63 File Offset: 0x000BBE63
		[NullableContext(1)]
		public static ITeleportSceneEffect Create(ITeleportSceneEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportSceneEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x06004C21 RID: 19489 RVA: 0x000BDC82 File Offset: 0x000BBE82
		public virtual string WorldEffectPath
		{
			get
			{
				return this.Instance.WorldEffectPath;
			}
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x06004C22 RID: 19490 RVA: 0x000BDC8F File Offset: 0x000BBE8F
		public virtual string ScreenEffectPath
		{
			get
			{
				return this.Instance.ScreenEffectPath;
			}
		}

		// Token: 0x04002B8A RID: 11146
		private ITeleportSceneEffect Instance;
	}
}
