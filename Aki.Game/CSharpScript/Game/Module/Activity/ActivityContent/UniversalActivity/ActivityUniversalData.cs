using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalActivity
{
	// Token: 0x02005F83 RID: 24451
	public class ActivityUniversalData : ActivityBaseData
	{
		// Token: 0x0603E0DA RID: 254170 RVA: 0x00EFB52F File Offset: 0x00EF972F
		[NullableContext(1)]
		protected override void PhraseEx(ActivityData data)
		{
		}

		// Token: 0x0603E0DB RID: 254171 RVA: 0x00EFB531 File Offset: 0x00EF9731
		public override bool NeedSelfControlFirstRedPoint()
		{
			return false;
		}

		// Token: 0x0603E0DC RID: 254172 RVA: 0x00EFB534 File Offset: 0x00EF9734
		public UniversalActivity? GetExtraConfig()
		{
			return ActivityUniversalConfig.Instance.GetActivityUniversalConfig(base.Id);
		}
	}
}
