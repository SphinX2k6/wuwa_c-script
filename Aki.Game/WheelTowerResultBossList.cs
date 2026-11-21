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

// Token: 0x02000A64 RID: 2660
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerResultBossList : UiPanelBase
{
	// Token: 0x06007189 RID: 29065 RVA: 0x0022DBA0 File Offset: 0x0022BDA0
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

	// Token: 0x0600718A RID: 29066 RVA: 0x0022DC2C File Offset: 0x0022BE2C
	protected override void OnStart()
	{
		UUIGridLayout gridLayout = base.GetGridLayout(1);
		if (gridLayout != null)
		{
			this.GridLayout = new GenericLayout<WheelTowerResultBossList.BossSmallItem, IBossItemData>(gridLayout, new Func<WheelTowerResultBossList.BossSmallItem>(this.CreateBossSmallItem), null, false, true);
		}
		this.Player = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600718B RID: 29067 RVA: 0x0022DC70 File Offset: 0x0022BE70
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer player = this.Player;
		if (player == null)
		{
			return;
		}
		player.Clear();
	}

	// Token: 0x0600718C RID: 29068 RVA: 0x0022DC82 File Offset: 0x0022BE82
	private WheelTowerResultBossList.BossSmallItem CreateBossSmallItem()
	{
		return new WheelTowerResultBossList.BossSmallItem();
	}

	// Token: 0x0600718D RID: 29069 RVA: 0x0022DC8C File Offset: 0x0022BE8C
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

	// Token: 0x04004643 RID: 17987
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerResultBossList.BossSmallItem, IBossItemData> GridLayout;

	// Token: 0x04004644 RID: 17988
	[Nullable(2)]
	private LevelSequencePlayer Player;

	// Token: 0x02006D44 RID: 27972
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private class BossSmallItem : GridProxyAbstract<IBossItemData>
	{
		// Token: 0x0603FB85 RID: 260997 RVA: 0x012A57EC File Offset: 0x012A39EC
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

		// Token: 0x0603FB86 RID: 260998 RVA: 0x012A5878 File Offset: 0x012A3A78
		protected override UniTask OnBeforeStartAsync()
		{
			WheelTowerResultBossList.BossSmallItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerResultBossList.BossSmallItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FB87 RID: 260999 RVA: 0x012A58BB File Offset: 0x012A3ABB
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

		// Token: 0x04023DEC RID: 146924
		[Nullable(2)]
		private WheelTowerBossItem BossItem;
	}
}
