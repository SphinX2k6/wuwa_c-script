using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001DB5 RID: 7605
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GreatSwordTrialLevelItem : GridProxyAbstract<TrialSubChallenge>
{
	// Token: 0x0600E6CB RID: 59083 RVA: 0x00365EBC File Offset: 0x003640BC
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

	// Token: 0x0600E6CC RID: 59084 RVA: 0x00365F94 File Offset: 0x00364194
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

	// Token: 0x0600E6CD RID: 59085 RVA: 0x00366007 File Offset: 0x00364207
	public override object GetKey(TrialSubChallenge data, int gridIndex)
	{
		return gridIndex;
	}

	// Token: 0x0600E6CE RID: 59086 RVA: 0x00366010 File Offset: 0x00364210
	protected override UniTask OnBeforeStartAsync()
	{
		GreatSwordTrialLevelItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GreatSwordTrialLevelItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E6CF RID: 59087 RVA: 0x00366053 File Offset: 0x00364253
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x0600E6D0 RID: 59088 RVA: 0x00366074 File Offset: 0x00364274
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

	// Token: 0x0600E6D1 RID: 59089 RVA: 0x003661B7 File Offset: 0x003643B7
	public void SetToggleState(EToggleState state)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state, false, false, false);
	}

	// Token: 0x0600E6D2 RID: 59090 RVA: 0x003661CF File Offset: 0x003643CF
	public EToggleState GetToggleState()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return EToggleState.ETT_UnChecked;
		}
		return extendToggle.GetToggleState();
	}

	// Token: 0x0600E6D3 RID: 59091 RVA: 0x003661E3 File Offset: 0x003643E3
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

	// Token: 0x0600E6D4 RID: 59092 RVA: 0x003661FF File Offset: 0x003643FF
	private bool OnCanExecuteChange()
	{
		return this.CanClickCallBack != null && this.CanClickCallBack(this.LevelIndex);
	}

	// Token: 0x04006AD0 RID: 27344
	public int LevelIndex;

	// Token: 0x04006AD1 RID: 27345
	[Nullable(2)]
	public Action<int> OnClickToggleCallBack;

	// Token: 0x04006AD2 RID: 27346
	[Nullable(2)]
	public Func<int, bool> CanClickCallBack;
}
