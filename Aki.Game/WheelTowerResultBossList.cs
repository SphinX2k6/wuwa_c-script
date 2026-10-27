using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020015AC RID: 5548
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerResultBossList : UiPanelBase
{
	// Token: 0x06009DAB RID: 40363 RVA: 0x00223DF0 File Offset: 0x00221FF0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009DAC RID: 40364 RVA: 0x00223E7C File Offset: 0x0022207C
	protected override void OnStart()
	{
		UUIGridLayout gridLayout = base.GetGridLayout(1);
		if (gridLayout != null)
		{
			this.GridLayout = new GenericLayout<WheelTowerResultBossList.BossSmallItem, IBossItemData>(gridLayout, new Func<WheelTowerResultBossList.BossSmallItem>(this.CreateBossSmallItem), null, false, true);
		}
		this.Player = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06009DAD RID: 40365 RVA: 0x00223EC0 File Offset: 0x002220C0
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer player = this.Player;
		if (player == null)
		{
			return;
		}
		player.Clear();
	}

	// Token: 0x06009DAE RID: 40366 RVA: 0x00223ED2 File Offset: 0x002220D2
	private WheelTowerResultBossList.BossSmallItem CreateBossSmallItem()
	{
		return new WheelTowerResultBossList.BossSmallItem();
	}

	// Token: 0x06009DAF RID: 40367 RVA: 0x00223EDC File Offset: 0x002220DC
	public void Refresh(List<IBossItemData> bossList)
	{
		base.SetUiActive(true);
		GenericLayout<WheelTowerResultBossList.BossSmallItem, IBossItemData> gridLayout = this.GridLayout;
		if (gridLayout != null)
		{
			gridLayout.RefreshByData(bossList, null, false);
		}
		LevelSequencePlayer player = this.Player;
		if (player == null)
		{
			return;
		}
		player.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x0400459D RID: 17821
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerResultBossList.BossSmallItem, IBossItemData> GridLayout;

	// Token: 0x0400459E RID: 17822
	[Nullable(2)]
	private LevelSequencePlayer Player;

	// Token: 0x02007BB9 RID: 31673
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private class BossSmallItem : GridProxyAbstract<IBossItemData>
	{
		// Token: 0x0604975E RID: 300894 RVA: 0x013024D4 File Offset: 0x013006D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0604975F RID: 300895 RVA: 0x01302560 File Offset: 0x01300760
		protected override UniTask OnBeforeStartAsync()
		{
			WheelTowerResultBossList.BossSmallItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerResultBossList.BossSmallItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06049760 RID: 300896 RVA: 0x013025A3 File Offset: 0x013007A3
		public override void Refresh(IBossItemData data, bool isSelected, int gridIndex)
		{
			WheelTowerBossItem bossItem = this.BossItem;
			if (bossItem != null)
			{
				bossItem.Refresh(data, isSelected, gridIndex);
			}
			WheelTowerBossItem bossItem2 = this.BossItem;
			if (bossItem2 == null)
			{
				return;
			}
			bossItem2.SetTagVisible(false);
		}

		// Token: 0x04028AB1 RID: 166577
		[Nullable(2)]
		private WheelTowerBossItem BossItem;
	}
}
