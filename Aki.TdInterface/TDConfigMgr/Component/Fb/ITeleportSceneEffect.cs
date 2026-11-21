using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DFF RID: 3583
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportSceneEffect
	{
		// Token: 0x0600512E RID: 20782 RVA: 0x000C9193 File Offset: 0x000C7393
		[NullableContext(0)]
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

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x0600512F RID: 20783 RVA: 0x000C91B2 File Offset: 0x000C73B2
		public virtual string WorldEffectPath
		{
			get
			{
				return this.Instance.WorldEffectPath;
			}
		}

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x06005130 RID: 20784 RVA: 0x000C91BF File Offset: 0x000C73BF
		public virtual string ScreenEffectPath
		{
			get
			{
				return this.Instance.ScreenEffectPath;
			}
		}

		// Token: 0x04002E44 RID: 11844
		private ITeleportSceneEffect Instance;
	}
}
