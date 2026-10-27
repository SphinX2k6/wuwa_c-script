using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B70 RID: 7024
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchRaceSelectView : UiViewBase
{
	// Token: 0x0600D0E6 RID: 53478 RVA: 0x002FC04F File Offset: 0x002FA24F
	public FloroRanchRaceSelectView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D0E7 RID: 53479 RVA: 0x002FC070 File Offset: 0x002FA270
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnConfirmBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnCloseBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D0E8 RID: 53480 RVA: 0x002FC19C File Offset: 0x002FA39C
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchRaceSelectView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchRaceSelectView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D0E9 RID: 53481 RVA: 0x002FC1E0 File Offset: 0x002FA3E0
	public void RefreshSelectedNum()
	{
		int num = this.FixedRaceIds.Count + this.SelectedRaceIds.Count;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "FloroRanchRaceSelectedNum", new <>z__ReadOnlyArray<object>(new object[]
		{
			num,
			this.TotalNum
		}));
		base.GetButton(3).SetSelfInteractive(num == this.TotalNum);
	}

	// Token: 0x0600D0EA RID: 53482 RVA: 0x002FC254 File Offset: 0x002FA454
	private bool IsRaceFixed(int raceId)
	{
		using (List<int>.Enumerator enumerator = this.FixedRaceIds.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == raceId)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600D0EB RID: 53483 RVA: 0x002FC2AC File Offset: 0x002FA4AC
	private void OnToggleCallback(int raceId)
	{
		if (this.FixedRaceIds.Count != this.TotalNum)
		{
			int num = this.SelectedRaceIds.IndexOf(raceId);
			if (num != -1)
			{
				this.SelectedRaceIds.RemoveAt(num);
			}
			else
			{
				if (this.FixedRaceIds.Count + this.SelectedRaceIds.Count == this.TotalNum)
				{
					int num2 = this.SelectedRaceIds[0];
					this.SelectedRaceIds.RemoveAt(0);
					FloroRanchRaceCardItem layoutItemByKey = this.RaceLayout.GetLayoutItemByKey(num2);
					if (layoutItemByKey != null)
					{
						layoutItemByKey.SetToggleState(false);
					}
				}
				this.SelectedRaceIds.Add(raceId);
			}
			this.RefreshSelectedNum();
			return;
		}
		ScrollingTipsController.Instance.ShowTipsByTextId("Farm_RaceLock", Array.Empty<object>());
		FloroRanchRaceCardItem layoutItemByKey2 = this.RaceLayout.GetLayoutItemByKey(raceId);
		if (layoutItemByKey2 == null)
		{
			return;
		}
		layoutItemByKey2.SetToggleState(false);
	}

	// Token: 0x0600D0EC RID: 53484 RVA: 0x002FC385 File Offset: 0x002FA585
	private FloroRanchRaceCardItem CreateRaceCard()
	{
		return new FloroRanchRaceCardItem
		{
			ActivityDataType = this.ActivityDataType,
			IsFixedRace = new Func<int, bool>(this.IsRaceFixed),
			OnToggleCallBack = new Action<int>(this.OnToggleCallback)
		};
	}

	// Token: 0x0600D0ED RID: 53485 RVA: 0x002FC3BC File Offset: 0x002FA5BC
	private void OnConfirmBtnClick()
	{
		List<int> list = new List<int>();
		list.AddRange(this.FixedRaceIds);
		list.AddRange(this.SelectedRaceIds);
		if (this.ActivityDataType == EFloroRanchActivityDataType.Normal)
		{
			EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.FloroRanchRaceRedDot, list);
		}
		Dictionary<int, List<int>> dictionary = LocalStorage.GetPlayer<Dictionary<int, List<int>>>(ELocalStoragePlayerKey.FloroRanchSelectedRaceIds, null) ?? new Dictionary<int, List<int>>();
		dictionary[this.SubDungeonId] = list;
		LocalStorage.SetPlayer<Dictionary<int, List<int>>>(ELocalStoragePlayerKey.FloroRanchSelectedRaceIds, dictionary);
		base.CloseMe(null);
	}

	// Token: 0x0600D0EE RID: 53486 RVA: 0x002FC438 File Offset: 0x002FA638
	private void OnCloseBtnClick()
	{
		if (this.ActivityDataType == EFloroRanchActivityDataType.Normal)
		{
			FloroRanchRaceSelectViewParam floroRanchRaceSelectViewParam = (FloroRanchRaceSelectViewParam)this.OpenParam;
			EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.FloroRanchRaceRedDot, floroRanchRaceSelectViewParam.SubDungeonData.SelectedRaceIds);
		}
		base.CloseMe(null);
	}

	// Token: 0x04005FDC RID: 24540
	private List<int> FixedRaceIds = new List<int>();

	// Token: 0x04005FDD RID: 24541
	private List<int> SelectedRaceIds = new List<int>();

	// Token: 0x04005FDE RID: 24542
	private int SubDungeonId;

	// Token: 0x04005FDF RID: 24543
	private int TotalNum;

	// Token: 0x04005FE0 RID: 24544
	private EFloroRanchActivityDataType ActivityDataType;

	// Token: 0x04005FE1 RID: 24545
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<FloroRanchRaceCardItem, FloroRanchRaceData> RaceLayout;

	// Token: 0x020080E3 RID: 32995
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A0DA RID: 172250
		public const int LayoutRaceCard = 0;

		// Token: 0x0402A0DB RID: 172251
		public const int ItemRaceCard = 1;

		// Token: 0x0402A0DC RID: 172252
		public const int TextSelectedNum = 2;

		// Token: 0x0402A0DD RID: 172253
		public const int ButtonConfirm = 3;

		// Token: 0x0402A0DE RID: 172254
		public const int ButtonHelp = 4;

		// Token: 0x0402A0DF RID: 172255
		public const int ButtonClose = 5;
	}
}
