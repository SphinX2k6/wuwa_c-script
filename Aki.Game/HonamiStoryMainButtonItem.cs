using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EFA RID: 7930
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryMainButtonItem : UiPanelBase
{
	// Token: 0x0600F414 RID: 62484 RVA: 0x003AE248 File Offset: 0x003AC448
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

	// Token: 0x0600F415 RID: 62485 RVA: 0x003AE2C5 File Offset: 0x003AC4C5
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600F416 RID: 62486 RVA: 0x003AE2D8 File Offset: 0x003AC4D8
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

	// Token: 0x0600F417 RID: 62487 RVA: 0x003AE3BE File Offset: 0x003AC5BE
	[NullableContext(1)]
	public void SetClickCallback(Action callback)
	{
		this.ClickCallBack = callback;
	}

	// Token: 0x0600F418 RID: 62488 RVA: 0x003AE3C7 File Offset: 0x003AC5C7
	public bool CheckIsSpecialSet()
	{
		return this.ShowRedDotCallback != null && this.ShowRedDotCallback() && this.SpecialSequenceName != null;
	}

	// Token: 0x0600F419 RID: 62489 RVA: 0x003AE3EC File Offset: 0x003AC5EC
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

	// Token: 0x0600F41A RID: 62490 RVA: 0x003AE487 File Offset: 0x003AC687
	public void SetText()
	{
		if (this.SetTextCallback != null)
		{
			this.SetTextCallback(base.GetText(1));
			return;
		}
		base.GetText(1).SetText("", true);
	}

	// Token: 0x0600F41B RID: 62491 RVA: 0x003AE4B6 File Offset: 0x003AC6B6
	public void SetRedDot()
	{
		if (this.ShowRedDotCallback != null)
		{
			base.GetItem(2).SetUIActive(this.ShowRedDotCallback());
			return;
		}
		base.GetItem(2).SetUIActive(false);
	}

	// Token: 0x0600F41C RID: 62492 RVA: 0x003AE4E5 File Offset: 0x003AC6E5
	public void Clear()
	{
		this.ClickCallBack = null;
		this.SetTextCallback = null;
		this.ShowRedDotCallback = null;
		this.ShowCallback = null;
		this.SpecialParamName = null;
		this.SpecialSequenceName = null;
	}

	// Token: 0x0600F41D RID: 62493 RVA: 0x003AE511 File Offset: 0x003AC711
	private void OnBtnClick()
	{
		Action clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack();
	}

	// Token: 0x040070FC RID: 28924
	private int FunctionId;

	// Token: 0x040070FD RID: 28925
	private Action ClickCallBack;

	// Token: 0x040070FE RID: 28926
	private Func<bool> ShowCallback;

	// Token: 0x040070FF RID: 28927
	private Action<UUIText> SetTextCallback;

	// Token: 0x04007100 RID: 28928
	private Func<bool> ShowRedDotCallback;

	// Token: 0x04007101 RID: 28929
	public string SpecialParamName;

	// Token: 0x04007102 RID: 28930
	public string SpecialSequenceName;

	// Token: 0x04007103 RID: 28931
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x020084F7 RID: 34039
	[NullableContext(0)]
	private enum EHonamiStoryMainButtonItemComponent
	{
		// Token: 0x0402B457 RID: 177239
		Button,
		// Token: 0x0402B458 RID: 177240
		ProgressText,
		// Token: 0x0402B459 RID: 177241
		RedDotItem
	}
}
