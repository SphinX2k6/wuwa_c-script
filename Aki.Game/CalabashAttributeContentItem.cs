using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000C09 RID: 3081
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class CalabashAttributeContentItem : GridProxyAbstract<CalabashAttributeContentData>
{
	// Token: 0x06008070 RID: 32880 RVA: 0x00275B1E File Offset: 0x00273D1E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06008071 RID: 32881 RVA: 0x00275B58 File Offset: 0x00273D58
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
