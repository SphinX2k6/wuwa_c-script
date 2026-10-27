using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020010E3 RID: 4323
public class AnniversaryCelebrationTitleIcon : ActivityCaptionDecorationTagBase
{
	// Token: 0x06007093 RID: 28819 RVA: 0x0016F96D File Offset: 0x0016DB6D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x06007094 RID: 28820 RVA: 0x0016F990 File Offset: 0x0016DB90
	public override UniTask OnCaptionTagRefresh(int activityId)
	{
		string resourceId = (LanguageSystem.Instance.PackageLanguage == "zh-Hans") ? "T_AnniversaryCelebrationLogo_CN" : "T_AnniversaryCelebrationLogo_EN";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.TrySetTextureByPath(resourcePath, base.GetTexture(0), null, null);
		return UniTask.CompletedTask;
	}

	// Token: 0x020076A9 RID: 30377
	private class EComponents
	{
		// Token: 0x04027298 RID: 160408
		public const int TexIcon = 0;
	}
}
