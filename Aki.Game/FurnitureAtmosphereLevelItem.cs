using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000FC7 RID: 4039
public class FurnitureAtmosphereLevelItem : UiPanelBase
{
	// Token: 0x06006784 RID: 26500 RVA: 0x00147830 File Offset: 0x00145A30
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

	// Token: 0x06006785 RID: 26501 RVA: 0x0014791B File Offset: 0x00145B1B
	[NullableContext(1)]
	public void Refresh(IFurnitureAtmosphereLevelData data)
	{
		this.Data = data;
		this.RefreshAtmosphereArt();
		this.RefreshProgress();
		this.RefreshBg(this.Data.Level);
	}

	// Token: 0x06006786 RID: 26502 RVA: 0x00147944 File Offset: 0x00145B44
	private void RefreshAtmosphereArt()
	{
		if (this.Data == null)
		{
			return;
		}
		base.GetArtText(3).SetText(this.Data.Level.ToString());
	}

	// Token: 0x06006787 RID: 26503 RVA: 0x0014797C File Offset: 0x00145B7C
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

	// Token: 0x06006788 RID: 26504 RVA: 0x00147A9C File Offset: 0x00145C9C
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

	// Token: 0x06006789 RID: 26505 RVA: 0x00147B34 File Offset: 0x00145D34
	private void OnItemButtonClick()
	{
		UiManager.Instance.OpenView(EUiViewName.SpringManorAtmosphereLevelView, null, null);
	}

	// Token: 0x04002F13 RID: 12051
	[Nullable(2)]
	private IFurnitureAtmosphereLevelData Data;
}
