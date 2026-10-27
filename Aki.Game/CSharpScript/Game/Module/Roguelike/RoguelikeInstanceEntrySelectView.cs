using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02004E0F RID: 19983
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeInstanceEntrySelectView : UiViewBase
	{
		// Token: 0x060338E3 RID: 211171 RVA: 0x00C0CE24 File Offset: 0x00C0B024
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

		// Token: 0x060338E4 RID: 211172 RVA: 0x00C0CF2D File Offset: 0x00C0B12D
		public RoguelikeInstanceEntrySelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060338E5 RID: 211173 RVA: 0x00C0CF36 File Offset: 0x00C0B136
		private void OnBtnConfirmClick()
		{
			RoguelikeController.Instance.RoguelikePopularEntriesChangeRequest((this.OpenParam as PopularEntrie).InstId, RoguelikeInstanceEntrySelectView.SelectIndexList.ToList<int>()).ContinueWith(delegate()
			{
				base.CloseMe(null);
			});
		}

		// Token: 0x060338E6 RID: 211174 RVA: 0x00C0CF70 File Offset: 0x00C0B170
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

		// Token: 0x060338E7 RID: 211175 RVA: 0x00C0CFEB File Offset: 0x00C0B1EB
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

		// Token: 0x060338E8 RID: 211176 RVA: 0x00C0D011 File Offset: 0x00C0B211
		private RoguelikeInstanceEntrySelectItem OnCreateBuffItem()
		{
			return new RoguelikeInstanceEntrySelectItem
			{
				OnSelectBuff = new Action<int, bool, UUIExtendToggle>(this.OnSelectBuff),
				CheckCanExecuteChange = new Func<UUIExtendToggle, bool>(this.CheckCanExecuteChange)
			};
		}

		// Token: 0x060338E9 RID: 211177 RVA: 0x00C0D03C File Offset: 0x00C0B23C
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeInstanceEntrySelectView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeInstanceEntrySelectView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060338EA RID: 211178 RVA: 0x00C0D07F File Offset: 0x00C0B27F
		protected override void OnBeforeDestroy()
		{
			RoguelikeInstanceEntrySelectView.SelectIndexList = null;
			if (this.TextChangeAnimationTimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TextChangeAnimationTimerHandle);
			}
		}

		// Token: 0x060338EB RID: 211179 RVA: 0x00C0D0A0 File Offset: 0x00C0B2A0
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

		// Token: 0x0401B583 RID: 112003
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public GenericLayout<RoguelikeInstanceEntrySelectItem, RougePopularEntrie> LeftLayout;

		// Token: 0x0401B584 RID: 112004
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public GenericLayout<RoguelikeInstanceEntrySelectItem, RougePopularEntrie> RightLayout;

		// Token: 0x0401B585 RID: 112005
		[Nullable(2)]
		public TimerHandle TextChangeAnimationTimerHandle;

		// Token: 0x0401B586 RID: 112006
		[Nullable(2)]
		[StaticVariableRuleIgnore]
		public static HashSet<int> SelectIndexList;

		// Token: 0x0401B587 RID: 112007
		public float CurRate;

		// Token: 0x0200AFA7 RID: 44967
		[NullableContext(0)]
		private class ERoguelikeInstanceEntrySelectView
		{
			// Token: 0x0403553A RID: 218426
			public const int LeftLayout = 0;

			// Token: 0x0403553B RID: 218427
			public const int RightLayout = 1;

			// Token: 0x0403553C RID: 218428
			public const int TxtBuffNumber = 2;

			// Token: 0x0403553D RID: 218429
			public const int TxtSelectBuffNumber = 3;

			// Token: 0x0403553E RID: 218430
			public const int BtnConfirm = 4;
		}
	}
}
