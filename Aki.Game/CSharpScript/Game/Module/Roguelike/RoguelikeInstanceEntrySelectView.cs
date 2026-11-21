using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DD8 RID: 15832
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeInstanceEntrySelectView : UiViewBase
	{
		// Token: 0x0602874E RID: 165710 RVA: 0x00B56330 File Offset: 0x00B54530
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnBtnConfirmClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602874F RID: 165711 RVA: 0x00B56439 File Offset: 0x00B54639
		public RoguelikeInstanceEntrySelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06028750 RID: 165712 RVA: 0x00B56442 File Offset: 0x00B54642
		private void OnBtnConfirmClick()
		{
			RoguelikeController.Instance.RoguelikePopularEntriesChangeRequest((this.OpenParam as PopularEntrie).InstId, new List<int>(RoguelikeInstanceEntrySelectView.SelectIndexList)).ContinueWith(delegate()
			{
				base.CloseMe(null);
			});
		}

		// Token: 0x06028751 RID: 165713 RVA: 0x00B5647C File Offset: 0x00B5467C
		private bool CheckCanExecuteChange(UUIExtendToggle extendToggle)
		{
			if (extendToggle.GetToggleState() == EToggleState.ETT_Checked)
			{
				return true;
			}
			int slot = RoguelikeConfig.Instance.GetRoguePopularEntrieArg(ActivityRogueController.Instance.GetCurrentActivityData().SeasonData.SeasonId, (this.OpenParam as PopularEntrie).InstId).Value.Slot;
			if (RoguelikeInstanceEntrySelectView.SelectIndexList.Count >= slot)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Roguelike_Instance_Entry_Select_MAX_COUNT", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x06028752 RID: 165714 RVA: 0x00B564F7 File Offset: 0x00B546F7
		private void OnSelectBuff(int index, bool isSelected, UUIExtendToggle toggle)
		{
			if (!isSelected)
			{
				RoguelikeInstanceEntrySelectView.SelectIndexList.Remove(index);
			}
			else
			{
				RoguelikeInstanceEntrySelectView.SelectIndexList.Add(index);
			}
			this.RefreshBuffTxt(false);
		}

		// Token: 0x06028753 RID: 165715 RVA: 0x00B5651D File Offset: 0x00B5471D
		private RoguelikeInstanceEntrySelectItem OnCreateBuffItem()
		{
			return new RoguelikeInstanceEntrySelectItem
			{
				OnSelectBuff = new Action<int, bool, UUIExtendToggle>(this.OnSelectBuff),
				CheckCanExecuteChange = new Func<UUIExtendToggle, bool>(this.CheckCanExecuteChange)
			};
		}

		// Token: 0x06028754 RID: 165716 RVA: 0x00B56548 File Offset: 0x00B54748
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeInstanceEntrySelectView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeInstanceEntrySelectView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028755 RID: 165717 RVA: 0x00B5658B File Offset: 0x00B5478B
		protected override void OnBeforeDestroy()
		{
			RoguelikeInstanceEntrySelectView.SelectIndexList = null;
			if (this.TextChangeAnimationTimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TextChangeAnimationTimerHandle);
			}
		}

		// Token: 0x06028756 RID: 165718 RVA: 0x00B565AC File Offset: 0x00B547AC
		protected void RefreshBuffTxt(bool isFirstIn = false)
		{
			float rate = 10000f;
			int displayDefaultRate = 100;
			foreach (int id in RoguelikeInstanceEntrySelectView.SelectIndexList)
			{
				RougePopularEntrie? roguelikePopularEntriesById = RoguelikeConfig.Instance.GetRoguelikePopularEntriesById(id);
				if (roguelikePopularEntriesById != null)
				{
					rate += (float)roguelikePopularEntriesById.Value.Rate;
				}
			}
			rate /= 100f;
			if (isFirstIn)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Rogue_Entry_Multiple", new <>z__ReadOnlySingleElementList<object>(rate));
				this.CurRate = rate;
				FColor color = FColor.FromHex("6e6a62");
				if (rate > (float)displayDefaultRate)
				{
					color = FColor.FromHex("c25757");
				}
				else if (rate < (float)displayDefaultRate)
				{
					color = FColor.FromHex("36cd33");
				}
				UUIText text = base.GetText(2);
				if (text != null)
				{
					text.SetColor(color);
				}
			}
			else
			{
				if (this.TextChangeAnimationTimerHandle != null)
				{
					TimerSystem.GameplayTimeInstance.Remove(this.TextChangeAnimationTimerHandle);
				}
				float time = 0f;
				this.TextChangeAnimationTimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float delta)
				{
					if (this.CurRate < rate)
					{
						this.CurRate += 1f;
					}
					else if (this.CurRate > rate)
					{
						this.CurRate -= 1f;
					}
					UUIText text2 = this.GetText(2);
					if (text2 != null)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
						defaultInterpolatedStringHandler.AppendLiteral("x");
						defaultInterpolatedStringHandler.AppendFormatted<float>(this.CurRate);
						defaultInterpolatedStringHandler.AppendLiteral("%");
						text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
					}
					time = time + delta + 100f;
					if (time >= 500f)
					{
						FColor color2 = FColor.FromHex("6e6a62");
						if (rate > (float)displayDefaultRate)
						{
							color2 = FColor.FromHex("c25757");
						}
						else if (rate < (float)displayDefaultRate)
						{
							color2 = FColor.FromHex("36cd33");
						}
						this.CurRate = rate;
						LguiUtil.Instance.SetLocalTextNew(this.GetText(2), "Rogue_Entry_Multiple", new <>z__ReadOnlySingleElementList<object>(rate));
						UUIText text3 = this.GetText(2);
						if (text3 != null)
						{
							text3.SetColor(color2);
						}
						TimerSystem.GameplayTimeInstance.Remove(this.TextChangeAnimationTimerHandle);
					}
				}, 100f, 5f, null, null, true);
			}
			RoguePopularEntrieArg? roguePopularEntrieArg = RoguelikeConfig.Instance.GetRoguePopularEntrieArg(ActivityRogueController.Instance.GetCurrentActivityData().SeasonData.SeasonId, (this.OpenParam as PopularEntrie).InstId);
			if (roguePopularEntrieArg != null)
			{
				int slot = roguePopularEntrieArg.Value.Slot;
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "Roguelike_Instance_Entry_Select_Buff_Number", new <>z__ReadOnlyArray<object>(new object[]
				{
					RoguelikeInstanceEntrySelectView.SelectIndexList.Count,
					slot
				}));
			}
		}

		// Token: 0x04015F56 RID: 89942
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public GenericLayout<RoguelikeInstanceEntrySelectItem, RougePopularEntrie> LeftLayout;

		// Token: 0x04015F57 RID: 89943
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public GenericLayout<RoguelikeInstanceEntrySelectItem, RougePopularEntrie> RightLayout;

		// Token: 0x04015F58 RID: 89944
		[Nullable(2)]
		public TimerHandle TextChangeAnimationTimerHandle;

		// Token: 0x04015F59 RID: 89945
		[Nullable(2)]
		[StaticVariableRuleIgnore]
		public static HashSet<int> SelectIndexList;

		// Token: 0x04015F5A RID: 89946
		public float CurRate;

		// Token: 0x020099DC RID: 39388
		[NullableContext(0)]
		private class ERoguelikeInstanceEntrySelectView
		{
			// Token: 0x0402FF6D RID: 196461
			public const int LeftLayout = 0;

			// Token: 0x0402FF6E RID: 196462
			public const int RightLayout = 1;

			// Token: 0x0402FF6F RID: 196463
			public const int TxtBuffNumber = 2;

			// Token: 0x0402FF70 RID: 196464
			public const int TxtSelectBuffNumber = 3;

			// Token: 0x0402FF71 RID: 196465
			public const int BtnConfirm = 4;
		}
	}
}
