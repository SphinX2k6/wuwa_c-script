using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AEB RID: 19179
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefensePauseView : UiViewBase
	{
		// Token: 0x06031AE2 RID: 203490 RVA: 0x00B8862A File Offset: 0x00B8682A
		public TrapDefensePauseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06031AE3 RID: 203491 RVA: 0x00B88634 File Offset: 0x00B86834
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickClose));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickSetting));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031AE4 RID: 203492 RVA: 0x00B88808 File Offset: 0x00B86A08
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefensePauseView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefensePauseView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031AE5 RID: 203493 RVA: 0x00B8884C File Offset: 0x00B86A4C
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<TrapDefenseResultInfoItem, ITrapDefensePauseInfo>(base.GetHorizontalLayout(2), new Func<TrapDefenseResultInfoItem>(this.CreateItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, true);
			UUIText text = base.GetText(4);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(0);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			List<ITrapDefensePauseInfo> list = new List<ITrapDefensePauseInfo>();
			list.Add(new TrapDefensePauseInfo
			{
				Type = ETrapDefensePauseInfoType.Health
			});
			list.Add(new TrapDefensePauseInfo
			{
				Type = ETrapDefensePauseInfoType.BatchCur
			});
			this.Layout.RefreshByData(list, null, true);
			bool needStarWhenPause = TrapDefenseModel.Instance.GetCurInstToLevelData().Config.NeedStarWhenPause;
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(needStarWhenPause);
			}
			if (needStarWhenPause)
			{
				TrapDefenseController.Instance.RequestTrapDefenseCurChallengeInfo().ContinueWith(delegate(int task)
				{
					UUIText text2 = base.GetText(4);
					if (text2 == null)
					{
						return;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler2.AppendFormatted<int>(task);
					text2.SetText(defaultInterpolatedStringHandler2.ToStringAndClear(), true);
				});
			}
		}

		// Token: 0x06031AE6 RID: 203494 RVA: 0x00B88935 File Offset: 0x00B86B35
		protected override void OnBeforeDestroy()
		{
			this.BtnBuff = null;
			this.BtnMonster = null;
			this.BtnSave = null;
			this.BtnEnd = null;
		}

		// Token: 0x06031AE7 RID: 203495 RVA: 0x00B88953 File Offset: 0x00B86B53
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06031AE8 RID: 203496 RVA: 0x00B8895C File Offset: 0x00B86B5C
		private void OnClickSetting()
		{
			TrapDefenseModel.Instance.OpenViewKeySetting();
		}

		// Token: 0x06031AE9 RID: 203497 RVA: 0x00B88968 File Offset: 0x00B86B68
		private void OnClickBuff()
		{
			if (!TrapDefenseModel.Instance.GetCurInstIsRogue())
			{
				return;
			}
			TrapDefenseModel.Instance.OpenViewBdSum(null, null, null);
		}

		// Token: 0x06031AEA RID: 203498 RVA: 0x00B889A8 File Offset: 0x00B86BA8
		private void OnClickMonsterInfo()
		{
			TrapDefenseModel.Instance.OpenViewMonster(null, new ETrapDefenseMonsterTabType?(ETrapDefenseMonsterTabType.MonsterWave), null);
		}

		// Token: 0x06031AEB RID: 203499 RVA: 0x00B889D7 File Offset: 0x00B86BD7
		private void OnClickSaveAndLeave()
		{
			if (!TrapDefenseModel.Instance.GetCurInstToLevelData().Config.IsCanSave)
			{
				return;
			}
			TrapDefenseModel.Instance.NeedOpenMainView = true;
			TrapDefenseController.Instance.RequestTrapDefenseChallengeQuit(false);
		}

		// Token: 0x06031AEC RID: 203500 RVA: 0x00B88A07 File Offset: 0x00B86C07
		private void OnClickEndAndLeave()
		{
			TrapDefenseController.Instance.RequestTrapDefenseChallengeQuit(true).ContinueWith(delegate(bool task)
			{
				if (task)
				{
					base.CloseMe(null);
				}
			});
		}

		// Token: 0x06031AED RID: 203501 RVA: 0x00B88A26 File Offset: 0x00B86C26
		private TrapDefenseResultInfoItem CreateItem()
		{
			return new TrapDefenseResultInfoItem();
		}

		// Token: 0x0401A883 RID: 108675
		protected GenericLayout<TrapDefenseResultInfoItem, ITrapDefensePauseInfo> Layout;

		// Token: 0x0401A884 RID: 108676
		protected TrapDefenseResultInfoBtn BtnBuff;

		// Token: 0x0401A885 RID: 108677
		protected TrapDefenseResultInfoBtn BtnMonster;

		// Token: 0x0401A886 RID: 108678
		protected TrapDefenseResultInfoBtn BtnSave;

		// Token: 0x0401A887 RID: 108679
		protected TrapDefenseResultInfoBtn BtnEnd;
	}
}
