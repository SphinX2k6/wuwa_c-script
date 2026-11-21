using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000604 RID: 1540
[NullableContext(2)]
[Nullable(0)]
public class DeTermItem : GridProxyAbstract<int>
{
	// Token: 0x060047E9 RID: 18409 RVA: 0x00184F18 File Offset: 0x00183118
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

	// Token: 0x060047EA RID: 18410 RVA: 0x00185000 File Offset: 0x00183200
	protected override UniTask OnBeforeStartAsync()
	{
		DeTermItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DeTermItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060047EB RID: 18411 RVA: 0x00185044 File Offset: 0x00183244
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		base.GetExtendToggle(2).CanExecuteChange.Bind(() => this.CanClickCallBack == null || this.CanClickCallBack());
		base.GetExtendToggle(2).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
	}

	// Token: 0x060047EC RID: 18412 RVA: 0x0018509C File Offset: 0x0018329C
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

	// Token: 0x060047ED RID: 18413 RVA: 0x00185115 File Offset: 0x00183315
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

	// Token: 0x060047EE RID: 18414 RVA: 0x0018514B File Offset: 0x0018334B
	public void SetToggleState(EToggleState state)
	{
		base.GetExtendToggle(2).SetToggleStateForce(state, false, false, false);
	}

	// Token: 0x060047EF RID: 18415 RVA: 0x00185160 File Offset: 0x00183360
	public void UseChangeColor(bool use)
	{
		UUIItem sprite = base.GetSprite(1);
		FColor? fcolor = new FColor?(base.GetSprite(1).changeColor);
		sprite.SetChangeColor(use, fcolor);
		UUIItem texture = base.GetTexture(0);
		fcolor = new FColor?(base.GetTexture(0).changeColor);
		texture.SetChangeColor(use, fcolor);
	}

	// Token: 0x060047F0 RID: 18416 RVA: 0x001851B0 File Offset: 0x001833B0
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

	// Token: 0x060047F1 RID: 18417 RVA: 0x001851F0 File Offset: 0x001833F0
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

	// Token: 0x060047F2 RID: 18418 RVA: 0x00185230 File Offset: 0x00183430
	public void SetDailyQuestItem(bool isActivity)
	{
		this.DeTermDailyQuestItem.SetUiActive(isActivity);
	}

	// Token: 0x060047F3 RID: 18419 RVA: 0x0018523E File Offset: 0x0018343E
	[NullableContext(1)]
	public UUIExtendToggle GetDeTermToggle()
	{
		return base.GetExtendToggle(2);
	}

	// Token: 0x0400362C RID: 13868
	public int DeTermId;

	// Token: 0x0400362D RID: 13869
	public Action<int, UUIExtendToggle> OnClickToggleCallBack;

	// Token: 0x0400362E RID: 13870
	public Func<bool> CanClickCallBack;

	// Token: 0x0400362F RID: 13871
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04003630 RID: 13872
	private DeTermDailyQuestItem DeTermDailyQuestItem;

	// Token: 0x02006891 RID: 26769
	[NullableContext(0)]
	private class EDeTermItem
	{
		// Token: 0x0402276A RID: 141162
		public const int Texture = 0;

		// Token: 0x0402276B RID: 141163
		public const int BgSprite = 1;

		// Token: 0x0402276C RID: 141164
		public const int Toggle = 2;

		// Token: 0x0402276D RID: 141165
		public const int DailyItem = 4;
	}
}
