using System;
using Aki.Config;

// Token: 0x0200174A RID: 5962
public class MotorcycleEditTabItem : MotorcycleTabItem
{
	// Token: 0x0600E787 RID: 59271 RVA: 0x0043CEB0 File Offset: 0x0043B0B0
	protected override void OnStart()
	{
		base.OnStart();
		string stringConfig = ConfigCommonParamById.GetStringConfig("MotorEditRedDotIcon");
		if (!string.IsNullOrEmpty(stringConfig))
		{
			this.SetSpriteByPath(stringConfig, base.GetSprite(4), true, null, null);
		}
	}
}
