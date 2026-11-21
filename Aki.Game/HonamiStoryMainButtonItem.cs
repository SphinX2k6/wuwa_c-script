using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013BC RID: 5052
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryMainButtonItem : UiPanelBase
{
	// Token: 0x0600C833 RID: 51251 RVA: 0x003B9D3C File Offset: 0x003B7F3C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnBtnClick))
		};
	}

	// Token: 0x0600C834 RID: 51252 RVA: 0x003B9DB9 File Offset: 0x003B7FB9
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600C835 RID: 51253 RVA: 0x003B9DCC File Offset: 0x003B7FCC
	[NullableContext(1)]
	public void SetConfigData(IHonamiStoryMainButtonConfig config)
	{
		if (config.FunctionId != null)
		{
			int value = (int)config.FunctionId.Value;
			if (value != 0)
			{
				this.FunctionId = value;
			}
		}
		if (config.SetTextCallback != null)
		{
			this.SetTextCallback = delegate(UUIText text)
			{
				config.SetTextCallback(text);
			};
		}
		if (config.ShowRedDot != null)
		{
			this.ShowRedDotCallback = (() => config.ShowRedDot());
		}
		if (config.ShowCallback != null)
		{
			this.ShowCallback = (() => config.ShowCallback());
		}
		if (config.SpecialParamName != null)
		{
			this.SpecialParamName = config.SpecialParamName;
		}
		if (config.SpecialSequenceName != null)
		{
			this.SpecialSequenceName = config.SpecialSequenceName;
		}
	}

	// Token: 0x0600C836 RID: 51254 RVA: 0x003B9EB2 File Offset: 0x003B80B2
	[NullableContext(1)]
	public void SetClickCallback(Action callback)
	{
		this.ClickCallBack = callback;
	}

	// Token: 0x0600C837 RID: 51255 RVA: 0x003B9EBB File Offset: 0x003B80BB
	public bool CheckIsSpecialSet()
	{
		return this.ShowRedDotCallback != null && this.ShowRedDotCallback() && this.SpecialSequenceName != null;
	}

	// Token: 0x0600C838 RID: 51256 RVA: 0x003B9EE0 File Offset: 0x003B80E0
	public void SetButtonState()
	{
		bool flag = FunctionModel.Instance.IsOpen(this.FunctionId);
		bool flag2 = this.ShowCallback == null || this.ShowCallback();
		if (!flag || !flag2)
		{
			base.SetUiActive(false);
			return;
		}
		base.SetUiActive(true);
		HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryMainButtonUnlockSet, new HashSet<int>());
		if (!player.Contains(this.FunctionId))
		{
			this.LevelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
			player.Add(this.FunctionId);
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryMainButtonUnlockSet, player);
		}
	}

	// Token: 0x0600C839 RID: 51257 RVA: 0x003B9F7B File Offset: 0x003B817B
	public void SetText()
	{
		if (this.SetTextCallback != null)
		{
			this.SetTextCallback(base.GetText(1));
			return;
		}
		base.GetText(1).SetText("", true);
	}

	// Token: 0x0600C83A RID: 51258 RVA: 0x003B9FAA File Offset: 0x003B81AA
	public void SetRedDot()
	{
		if (this.ShowRedDotCallback != null)
		{
			base.GetItem(2).SetUIActive(this.ShowRedDotCallback());
			return;
		}
		base.GetItem(2).SetUIActive(false);
	}

	// Token: 0x0600C83B RID: 51259 RVA: 0x003B9FD9 File Offset: 0x003B81D9
	public void Clear()
	{
		this.ClickCallBack = null;
		this.SetTextCallback = null;
		this.ShowRedDotCallback = null;
		this.ShowCallback = null;
		this.SpecialParamName = null;
		this.SpecialSequenceName = null;
	}

	// Token: 0x0600C83C RID: 51260 RVA: 0x003BA005 File Offset: 0x003B8205
	private void OnBtnClick()
	{
		Action clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack();
	}

	// Token: 0x040071DD RID: 29149
	private int FunctionId;

	// Token: 0x040071DE RID: 29150
	private Action ClickCallBack;

	// Token: 0x040071DF RID: 29151
	private Func<bool> ShowCallback;

	// Token: 0x040071E0 RID: 29152
	private Action<UUIText> SetTextCallback;

	// Token: 0x040071E1 RID: 29153
	private Func<bool> ShowRedDotCallback;

	// Token: 0x040071E2 RID: 29154
	public string SpecialParamName;

	// Token: 0x040071E3 RID: 29155
	public string SpecialSequenceName;

	// Token: 0x040071E4 RID: 29156
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0200767C RID: 30332
	[NullableContext(0)]
	private enum EHonamiStoryMainButtonItemComponent
	{
		// Token: 0x0402677B RID: 157563
		Button,
		// Token: 0x0402677C RID: 157564
		ProgressText,
		// Token: 0x0402677D RID: 157565
		RedDotItem
	}
}
