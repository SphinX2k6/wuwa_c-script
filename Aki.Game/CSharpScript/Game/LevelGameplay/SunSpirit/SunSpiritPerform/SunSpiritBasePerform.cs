using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritPerform
{
	// Token: 0x02005B5F RID: 23391
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritBasePerform
	{
		// Token: 0x06039855 RID: 235605 RVA: 0x010266A6 File Offset: 0x010248A6
		public SunSpiritBasePerform(SunSpiritData sunSpiritData)
		{
			this.SunSpiritData = sunSpiritData;
		}

		// Token: 0x06039856 RID: 235606 RVA: 0x010266B5 File Offset: 0x010248B5
		public bool Init()
		{
			return this.OnInit();
		}

		// Token: 0x06039857 RID: 235607 RVA: 0x010266BD File Offset: 0x010248BD
		protected virtual bool OnInit()
		{
			return true;
		}

		// Token: 0x06039858 RID: 235608 RVA: 0x010266C0 File Offset: 0x010248C0
		public void Destroy()
		{
			this.OnDestroy();
		}

		// Token: 0x06039859 RID: 235609 RVA: 0x010266C8 File Offset: 0x010248C8
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0401E5C1 RID: 124353
		protected SunSpiritData SunSpiritData;
	}
}
