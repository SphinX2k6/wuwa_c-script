using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001750 RID: 5968
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class CalabashAttributeContentItem : GridProxyAbstract<CalabashAttributeContentData>
{
	// Token: 0x0600AC89 RID: 44169 RVA: 0x0026B6D6 File Offset: 0x002698D6
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600AC8A RID: 44170 RVA: 0x0026B710 File Offset: 0x00269910
	public override void Refresh(CalabashAttributeContentData data, bool isSelected, int gridIndex)
	{
		if (data.Type == ECalabashLevelSubShowType.UpgradeTarget)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), data.StringKey, Array.Empty<object>());
			if (data.StringValue != null)
			{
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), data.StringValue.TextKey, data.StringValue.Params);
				return;
			}
		}
		else if (data.Type == ECalabashLevelSubShowType.UpgradeQuality)
		{
			int key = data.Key;
			int value = data.Value;
			QualityInfo? qualityConfig = ItemConfig.Instance.GetQualityConfig(key);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), (qualityConfig != null) ? qualityConfig.GetValueOrDefault().Name : null, Array.Empty<object>());
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetColor(FColor.FromHex(qualityConfig.Value.DropColor));
			}
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.SetText(StringUtils.Format("{0}%", new string[]
				{
					value.ToString()
				}), true);
			}
			UUIText text3 = base.GetText(1);
			if (text3 == null)
			{
				return;
			}
			text3.SetColor(FColor.FromHex(qualityConfig.Value.DropColor));
		}
	}
}
