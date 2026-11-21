using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000597 RID: 1431
public class AnniversaryCelebrationTitleIcon : ActivityCaptionDecorationTagBase
{
	// Token: 0x06004429 RID: 17449 RVA: 0x00178329 File Offset: 0x00176529
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x0600442A RID: 17450 RVA: 0x0017834C File Offset: 0x0017654C
	public override UniTask OnCaptionTagRefresh(int activityId)
	{
		string resourceId = (LanguageSystem.Instance.PackageLanguage == "zh-Hans") ? "T_AnniversaryCelebrationLogo_CN" : "T_AnniversaryCelebrationLogo_EN";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.TrySetTextureByPath(resourcePath, base.GetTexture(0), null, null);
		return UniTask.CompletedTask;
	}

	// Token: 0x0200683D RID: 26685
	private class EComponents
	{
		// Token: 0x040225E1 RID: 140769
		public const int TexIcon = 0;
	}
}
