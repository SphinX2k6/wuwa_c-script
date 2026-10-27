using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.BulletCaster
{
	// Token: 0x02007233 RID: 29235
	[NullableContext(1)]
	[Nullable(0)]
	public class BulletCasterInitParam
	{
		// Token: 0x06047A61 RID: 293473 RVA: 0x012553E5 File Offset: 0x012535E5
		public BulletCasterInitParam(Entity ownerEntity, IBatchBulletCaster casterConfig, Transform casterRelTransform, long bulletContextId, string warningEffect)
		{
		}

		// Token: 0x04025B20 RID: 154400
		public Entity OwnerEntity = ownerEntity;

		// Token: 0x04025B21 RID: 154401
		public IBatchBulletCaster CasterConfig = casterConfig;

		// Token: 0x04025B22 RID: 154402
		public Transform CasterRelTransform = casterRelTransform;

		// Token: 0x04025B23 RID: 154403
		public long BulletContextId = bulletContextId;

		// Token: 0x04025B24 RID: 154404
		public string WarningEffect = warningEffect;
	}
}
