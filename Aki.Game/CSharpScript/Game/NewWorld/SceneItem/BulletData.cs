using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200621D RID: 25117
	[NullableContext(2)]
	[Nullable(0)]
	public class BulletData
	{
		// Token: 0x0603C637 RID: 247351 RVA: 0x0113B6D7 File Offset: 0x011398D7
		[NullableContext(1)]
		public BulletData(ISceneBulletGroup bullet, Transform trans)
		{
			this.BulletGroup = bullet;
			this.BulletTransform = trans;
		}

		// Token: 0x0401FF9B RID: 130971
		public int? BulletEntityId;

		// Token: 0x0401FF9C RID: 130972
		public ISceneBulletGroup BulletGroup;

		// Token: 0x0401FF9D RID: 130973
		public Transform BulletTransform;
	}
}
