using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001277 RID: 4727
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GreatSwordTrialLevelItem : GridProxyAbstract<TrialSubChallenge>
{
	// Token: 0x0600BAE9 RID: 47849 RVA: 0x00371B1C File Offset: 0x0036FD1C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x0600BAEA RID: 47850 RVA: 0x00371BF4 File Offset: 0x0036FDF4
	public override void Refresh(TrialSubChallenge data, bool isSelected, int gridIndex)
	{
		this.LevelIndex = gridIndex;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Config.TitleText, Array.Empty<object>());
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(!data.Unlocked);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(data.Completed);
		}
		this.RefreshStyleByIndex(data, gridIndex);
	}

	// Token: 0x0600BAEB RID: 47851 RVA: 0x00371C67 File Offset: 0x0036FE67
	public override object GetKey(TrialSubChallenge data, int gridIndex)
	{
		return gridIndex;
	}

	// Token: 0x0600BAEC RID: 47852 RVA: 0x00371C70 File Offset: 0x0036FE70
	protected override UniTask OnBeforeStartAsync()
	{
		GreatSwordTrialLevelItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GreatSwordTrialLevelItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BAED RID: 47853 RVA: 0x00371CB3 File Offset: 0x0036FEB3
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x0600BAEE RID: 47854 RVA: 0x00371CD4 File Offset: 0x0036FED4
	private void RefreshStyleByIndex(TrialSubChallenge data, int levelIndex)
	{
		BlackSwordUIAsset? config = ConfigBlackSwordUIAssetById.GetConfig(data.Config.UIConfigId, true);
		string[] array = ((config != null) ? config.GetValueOrDefault().LevelColors() : null) ?? Array.Empty<string>();
		string[] array2 = ((config != null) ? config.GetValueOrDefault().PatternPaths() : null) ?? Array.Empty<string>();
		string[] array3 = ((config != null) ? config.GetValueOrDefault().StarPaths() : null) ?? Array.Empty<string>();
		string hexStr = (levelIndex < array.Length) ? array[levelIndex] : "#ffffff";
		string path = (levelIndex < array2.Length) ? array2[levelIndex] : "";
		string path2 = (levelIndex < array3.Length) ? array3[levelIndex] : "";
		FColor color = FColor.FromHex(hexStr);
		UUITexture texture = base.GetTexture(2);
		if (texture != null)
		{
			texture.SetColor(color);
		}
		UUITexture texture2 = base.GetTexture(3);
		base.SetTextureByPath(path, texture2, null, null);
		UUITexture texture3 = base.GetTexture(4);
		base.SetTextureByPath(path2, texture3, null, null);
		bool flag = !data.Unlocked || data.Completed;
		if (texture3 != null)
		{
			texture3.SetUIActive(!flag);
		}
	}

	// Token: 0x0600BAEF RID: 47855 RVA: 0x00371E17 File Offset: 0x00370017
	public void SetToggleState(EToggleState state)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state, false, false, false);
	}

	// Token: 0x0600BAF0 RID: 47856 RVA: 0x00371E2F File Offset: 0x0037002F
	public EToggleState GetToggleState()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return EToggleState.ETT_UnChecked;
		}
		return extendToggle.GetToggleState();
	}

	// Token: 0x0600BAF1 RID: 47857 RVA: 0x00371E43 File Offset: 0x00370043
	protected void OnClickToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action<int> onClickToggleCallBack = this.OnClickToggleCallBack;
			if (onClickToggleCallBack == null)
			{
				return;
			}
			onClickToggleCallBack(this.LevelIndex);
		}
	}

	// Token: 0x0600BAF2 RID: 47858 RVA: 0x00371E5F File Offset: 0x0037005F
	private bool OnCanExecuteChange()
	{
		return this.CanClickCallBack != null && this.CanClickCallBack(this.LevelIndex);
	}

	// Token: 0x04006BB1 RID: 27569
	public int LevelIndex;

	// Token: 0x04006BB2 RID: 27570
	[Nullable(2)]
	public Action<int> OnClickToggleCallBack;

	// Token: 0x04006BB3 RID: 27571
	[Nullable(2)]
	public Func<int, bool> CanClickCallBack;
}
