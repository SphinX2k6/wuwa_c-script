using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalActivity
{
	// Token: 0x02004F6A RID: 20330
	public class ActivityUniversalData : ActivityBaseData
	{
		// Token: 0x06033074 RID: 209012 RVA: 0x00E4D1FF File Offset: 0x00E4B3FF
		[NullableContext(1)]
		protected override void PhraseEx(ActivityData data)
		{
		}

		// Token: 0x06033075 RID: 209013 RVA: 0x00E4D201 File Offset: 0x00E4B401
		public override bool NeedSelfControlFirstRedPoint()
		{
			return false;
		}

		// Token: 0x06033076 RID: 209014 RVA: 0x00E4D204 File Offset: 0x00E4B404
		public UniversalActivity? GetExtraConfig()
		{
			return ActivityUniversalConfig.Instance.GetActivityUniversalConfig(base.Id);
		}
	}
}
