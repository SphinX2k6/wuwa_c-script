using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200047C RID: 1148
public class FurnitureAtmosphereLevelItem : UiPanelBase
{
	// Token: 0x06003B1C RID: 15132 RVA: 0x001500F4 File Offset: 0x0014E2F4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIArtText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(7, new Action(this.OnItemButtonClick))
		};
	}

	// Token: 0x06003B1D RID: 15133 RVA: 0x001501DF File Offset: 0x0014E3DF
	[NullableContext(1)]
	public void Refresh(IFurnitureAtmosphereLevelData data)
	{
		this.Data = data;
		this.RefreshAtmosphereArt();
		this.RefreshProgress();
		this.RefreshBg(this.Data.Level);
	}

	// Token: 0x06003B1E RID: 15134 RVA: 0x00150208 File Offset: 0x0014E408
	private void RefreshAtmosphereArt()
	{
		if (this.Data == null)
		{
			return;
		}
		base.GetArtText(3).SetText(this.Data.Level.ToString());
	}

	// Token: 0x06003B1F RID: 15135 RVA: 0x00150240 File Offset: 0x0014E440
	private void RefreshProgress()
	{
		if (this.Data == null)
		{
			return;
		}
		SpringManorConfig instance = SpringManorConfig.Instance;
		AtmosphereLevel? atmosphereLevel = (instance != null) ? instance.GetLevelConfigById(this.Data.Level) : null;
		if (atmosphereLevel == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.SpringManor;
			ELogAuthor author = ELogAuthor.LJ;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
			defaultInterpolatedStringHandler.AppendLiteral("获取不到等级配置！");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Data.Level);
			instance2.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int num = MathUtils.Instance.Clamp((this.Data.CurLevelAtmosphere - atmosphereLevel.Value.AtmosphereNeed) / atmosphereLevel.Value.AtmosphereNext, 0, 1);
		base.GetSlider(5).SetValue((float)num, true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "Spring26_MainHud_PassProgress", new <>z__ReadOnlyArray<object>(new object[]
		{
			this.Data.CurLevelAtmosphere,
			this.Data.CurLevelMaxAtmosphere
		}));
	}

	// Token: 0x06003B20 RID: 15136 RVA: 0x00150360 File Offset: 0x0014E560
	public void RefreshBg(int level)
	{
		int num = 1;
		foreach (int num2 in SpringManorDefine.atmosphereLevelList)
		{
			if (level < num2)
			{
				break;
			}
			num++;
		}
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(num == 1);
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 != null)
		{
			item2.SetUIActive(num == 2);
		}
		UUIItem item3 = base.GetItem(2);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(num == 3);
	}

	// Token: 0x06003B21 RID: 15137 RVA: 0x001503F8 File Offset: 0x0014E5F8
	private void OnItemButtonClick()
	{
		UiManager.Instance.OpenView(EUiViewName.SpringManorAtmosphereLevelView, null, null);
	}

	// Token: 0x04002FAC RID: 12204
	[Nullable(2)]
	private IFurnitureAtmosphereLevelData Data;
}
