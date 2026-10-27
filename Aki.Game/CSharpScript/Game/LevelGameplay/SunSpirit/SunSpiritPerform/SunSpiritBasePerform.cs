using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritPerform
{
	// Token: 0x02006A02 RID: 27138
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritBasePerform
	{
		// Token: 0x06043809 RID: 276489 RVA: 0x01082082 File Offset: 0x01080282
		public SunSpiritBasePerform(SunSpiritData sunSpiritData)
		{
			this.SunSpiritData = sunSpiritData;
		}

		// Token: 0x0604380A RID: 276490 RVA: 0x01082091 File Offset: 0x01080291
		public bool Init()
		{
			return this.OnInit();
		}

		// Token: 0x0604380B RID: 276491 RVA: 0x01082099 File Offset: 0x01080299
		protected virtual bool OnInit()
		{
			return true;
		}

		// Token: 0x0604380C RID: 276492 RVA: 0x0108209C File Offset: 0x0108029C
		public void Destroy()
		{
			this.OnDestroy();
		}

		// Token: 0x0604380D RID: 276493 RVA: 0x010820A4 File Offset: 0x010802A4
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x040233CF RID: 144335
		protected SunSpiritData SunSpiritData;
	}
}
