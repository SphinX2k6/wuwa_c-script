using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001150 RID: 4432
[NullableContext(2)]
[Nullable(0)]
public class DeTermItem : GridProxyAbstract<int>
{
	// Token: 0x06007452 RID: 29778 RVA: 0x0017C3CC File Offset: 0x0017A5CC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007453 RID: 29779 RVA: 0x0017C4B4 File Offset: 0x0017A6B4
	protected override UniTask OnBeforeStartAsync()
	{
		DeTermItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DeTermItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007454 RID: 29780 RVA: 0x0017C4F8 File Offset: 0x0017A6F8
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		base.GetExtendToggle(2).CanExecuteChange.Bind(() => this.CanClickCallBack == null || this.CanClickCallBack());
		base.GetExtendToggle(2).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
	}

	// Token: 0x06007455 RID: 29781 RVA: 0x0017C550 File Offset: 0x0017A750
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		if (data <= 0)
		{
			base.GetExtendToggle(2).RootUIComp.Get().SetUIActive(false);
			return;
		}
		this.DeTermId = data;
		base.GetExtendToggle(2).RootUIComp.Get().SetUIActive(true);
		string texture = BabelTowerConfig.Instance.GetBabelTowerDeTerm(data).Texture;
		base.SetTextureByPath(texture, base.GetTexture(0), null, null);
	}

	// Token: 0x06007456 RID: 29782 RVA: 0x0017C5C9 File Offset: 0x0017A7C9
	private void OnClickToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action<int, UUIExtendToggle> onClickToggleCallBack = this.OnClickToggleCallBack;
			if (onClickToggleCallBack == null)
			{
				return;
			}
			onClickToggleCallBack(this.DeTermId, base.GetExtendToggle(2));
			return;
		}
		else
		{
			Action<int, UUIExtendToggle> onClickToggleCallBack2 = this.OnClickToggleCallBack;
			if (onClickToggleCallBack2 == null)
			{
				return;
			}
			onClickToggleCallBack2(0, null);
			return;
		}
	}

	// Token: 0x06007457 RID: 29783 RVA: 0x0017C5FF File Offset: 0x0017A7FF
	public void SetToggleState(EToggleState state)
	{
		base.GetExtendToggle(2).SetToggleStateForce(state, false, false, false);
	}

	// Token: 0x06007458 RID: 29784 RVA: 0x0017C614 File Offset: 0x0017A814
	public void UseChangeColor(bool use)
	{
		UUIItem sprite = base.GetSprite(1);
		FColor? fcolor = new FColor?(base.GetSprite(1).changeColor);
		sprite.SetChangeColor(use, fcolor);
		UUIItem texture = base.GetTexture(0);
		fcolor = new FColor?(base.GetTexture(0).changeColor);
		texture.SetChangeColor(use, fcolor);
	}

	// Token: 0x06007459 RID: 29785 RVA: 0x0017C664 File Offset: 0x0017A864
	private void OnUndeterminedClicked()
	{
		BabelTowerItemInfoViewInfo param = new BabelTowerItemInfoViewInfo
		{
			IsDeTerm = true,
			ConfigId = this.DeTermId,
			ShowWays = true
		};
		UiManager.Instance.OpenView(EUiViewName.BabelTowerItemInfoView, param, null);
	}

	// Token: 0x0600745A RID: 29786 RVA: 0x0017C6A4 File Offset: 0x0017A8A4
	public void PlayPositionSequence()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 == null)
		{
			return;
		}
		levelSequencePlayer2.PlayLevelSequenceByName("Once_ComBuff", false, null, false);
	}

	// Token: 0x0600745B RID: 29787 RVA: 0x0017C6E4 File Offset: 0x0017A8E4
	public void SetDailyQuestItem(bool isActivity)
	{
		this.DeTermDailyQuestItem.SetUiActive(isActivity);
	}

	// Token: 0x0600745C RID: 29788 RVA: 0x0017C6F2 File Offset: 0x0017A8F2
	[NullableContext(1)]
	public UUIExtendToggle GetDeTermToggle()
	{
		return base.GetExtendToggle(2);
	}

	// Token: 0x04003593 RID: 13715
	public int DeTermId;

	// Token: 0x04003594 RID: 13716
	public Action<int, UUIExtendToggle> OnClickToggleCallBack;

	// Token: 0x04003595 RID: 13717
	public Func<bool> CanClickCallBack;

	// Token: 0x04003596 RID: 13718
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04003597 RID: 13719
	private DeTermDailyQuestItem DeTermDailyQuestItem;

	// Token: 0x02007702 RID: 30466
	[NullableContext(0)]
	private class EDeTermItem
	{
		// Token: 0x04027429 RID: 160809
		public const int Texture = 0;

		// Token: 0x0402742A RID: 160810
		public const int BgSprite = 1;

		// Token: 0x0402742B RID: 160811
		public const int Toggle = 2;

		// Token: 0x0402742C RID: 160812
		public const int DailyItem = 4;
	}
}
