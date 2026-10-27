using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02007169 RID: 29033
	[NullableContext(2)]
	[Nullable(0)]
	public class BulletData
	{
		// Token: 0x06046DEA RID: 290282 RVA: 0x011DFCE9 File Offset: 0x011DDEE9
		[NullableContext(1)]
		public BulletData(ISceneBulletGroup bullet, Transform trans)
		{
			this.BulletGroup = bullet;
			this.BulletTransform = trans;
		}

		// Token: 0x04025334 RID: 152372
		public int? BulletEntityId;

		// Token: 0x04025335 RID: 152373
		public ISceneBulletGroup BulletGroup;

		// Token: 0x04025336 RID: 152374
		public Transform BulletTransform;
	}
}
