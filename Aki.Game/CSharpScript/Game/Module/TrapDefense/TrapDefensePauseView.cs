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
	// Token: 0x02003A93 RID: 14995
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefensePauseView : UiViewBase
	{
		// Token: 0x06026872 RID: 157810 RVA: 0x00ACC5DE File Offset: 0x00ACA7DE
		public TrapDefensePauseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06026873 RID: 157811 RVA: 0x00ACC5E8 File Offset: 0x00ACA7E8
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

		// Token: 0x06026874 RID: 157812 RVA: 0x00ACC7BC File Offset: 0x00ACA9BC
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefensePauseView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefensePauseView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026875 RID: 157813 RVA: 0x00ACC800 File Offset: 0x00ACAA00
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

		// Token: 0x06026876 RID: 157814 RVA: 0x00ACC8E9 File Offset: 0x00ACAAE9
		protected override void OnBeforeDestroy()
		{
			this.BtnBuff = null;
			this.BtnMonster = null;
			this.BtnSave = null;
			this.BtnEnd = null;
		}

		// Token: 0x06026877 RID: 157815 RVA: 0x00ACC907 File Offset: 0x00ACAB07
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06026878 RID: 157816 RVA: 0x00ACC910 File Offset: 0x00ACAB10
		private void OnClickSetting()
		{
			TrapDefenseModel.Instance.OpenViewKeySetting();
		}

		// Token: 0x06026879 RID: 157817 RVA: 0x00ACC91C File Offset: 0x00ACAB1C
		private void OnClickBuff()
		{
			if (!TrapDefenseModel.Instance.GetCurInstIsRogue())
			{
				return;
			}
			TrapDefenseModel.Instance.OpenViewBdSum(null, null, null);
		}

		// Token: 0x0602687A RID: 157818 RVA: 0x00ACC95C File Offset: 0x00ACAB5C
		private void OnClickMonsterInfo()
		{
			TrapDefenseModel.Instance.OpenViewMonster(null, new ETrapDefenseMonsterTabType?(ETrapDefenseMonsterTabType.MonsterWave), null);
		}

		// Token: 0x0602687B RID: 157819 RVA: 0x00ACC98B File Offset: 0x00ACAB8B
		private void OnClickSaveAndLeave()
		{
			if (!TrapDefenseModel.Instance.GetCurInstToLevelData().Config.IsCanSave)
			{
				return;
			}
			TrapDefenseModel.Instance.NeedOpenMainView = true;
			TrapDefenseController.Instance.RequestTrapDefenseChallengeQuit(false);
		}

		// Token: 0x0602687C RID: 157820 RVA: 0x00ACC9BB File Offset: 0x00ACABBB
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

		// Token: 0x0602687D RID: 157821 RVA: 0x00ACC9DA File Offset: 0x00ACABDA
		private TrapDefenseResultInfoItem CreateItem()
		{
			return new TrapDefenseResultInfoItem();
		}

		// Token: 0x040151D5 RID: 86485
		protected GenericLayout<TrapDefenseResultInfoItem, ITrapDefensePauseInfo> Layout;

		// Token: 0x040151D6 RID: 86486
		protected TrapDefenseResultInfoBtn BtnBuff;

		// Token: 0x040151D7 RID: 86487
		protected TrapDefenseResultInfoBtn BtnMonster;

		// Token: 0x040151D8 RID: 86488
		protected TrapDefenseResultInfoBtn BtnSave;

		// Token: 0x040151D9 RID: 86489
		protected TrapDefenseResultInfoBtn BtnEnd;
	}
}
