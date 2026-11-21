using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.BulletCaster
{
	// Token: 0x020062E8 RID: 25320
	[NullableContext(1)]
	[Nullable(0)]
	public class BulletCasterInitParam
	{
		// Token: 0x0603D3C2 RID: 250818 RVA: 0x011ADF7D File Offset: 0x011AC17D
		public BulletCasterInitParam(Entity ownerEntity, IBatchBulletCaster casterConfig, Transform casterRelTransform, long bulletContextId, string warningEffect)
		{
		}

		// Token: 0x0402078F RID: 133007
		public Entity OwnerEntity = ownerEntity;

		// Token: 0x04020790 RID: 133008
		public IBatchBulletCaster CasterConfig = casterConfig;

		// Token: 0x04020791 RID: 133009
		public Transform CasterRelTransform = casterRelTransform;

		// Token: 0x04020792 RID: 133010
		public long BulletContextId = bulletContextId;

		// Token: 0x04020793 RID: 133011
		public string WarningEffect = warningEffect;
	}
}
