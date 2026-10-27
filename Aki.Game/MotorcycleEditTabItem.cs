using System;
using Aki.Config;

// Token: 0x02002266 RID: 8806
public class MotorcycleEditTabItem : MotorcycleTabItem
{
	// Token: 0x060112F1 RID: 70385 RVA: 0x004302A4 File Offset: 0x0042E4A4
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
