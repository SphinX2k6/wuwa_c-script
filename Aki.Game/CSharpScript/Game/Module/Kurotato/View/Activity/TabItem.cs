using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x02004760 RID: 18272
	internal class TabItem : GridProxyAbstract<KurotatoRewardTab>
	{
		// Token: 0x0602DDD4 RID: 187860 RVA: 0x00CD6594 File Offset: 0x00CD4794
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602DDD5 RID: 187861 RVA: 0x00CD665B File Offset: 0x00CD485B
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.OnRefreshKurotatoLimitRewardData, new Action(this.RefreshTabNameText));
		}

		// Token: 0x0602DDD6 RID: 187862 RVA: 0x00CD6679 File Offset: 0x00CD4879
		protected override void OnBeforeHide()
		{
			this.UnBindRedDot();
			EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoLimitRewardData, new Action(this.RefreshTabNameText));
		}

		// Token: 0x0602DDD7 RID: 187863 RVA: 0x00CD66A0 File Offset: 0x00CD48A0
		public override void Refresh(KurotatoRewardTab data, bool isSelected, int gridIndex)
		{
			this.TabIndex = data.Id;
			ValueTuple<int, int> limitedTimeTabRewardProgress = KurotatoActivityController.Instance.GetActivityData().GetLimitedTimeTabRewardProgress(this.TabIndex);
			int item = limitedTimeTabRewardProgress.Item1;
			int item2 = limitedTimeTabRewardProgress.Item2;
			string multiText = TextConfig.Instance.GetMultiText(data.Name, Array.Empty<string>());
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 3);
			defaultInterpolatedStringHandler.AppendFormatted(multiText);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			string newText = defaultInterpolatedStringHandler.ToStringAndClear();
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetText(newText, true);
			}
			this.BindRedDot(ERedDotName.RedDotKurotatoLimitRewardTabItem, this.TabIndex);
		}

		// Token: 0x0602DDD8 RID: 187864 RVA: 0x00CD6768 File Offset: 0x00CD4968
		private void RefreshTabNameText()
		{
			ValueTuple<int, int> limitedTimeTabRewardProgress = KurotatoActivityController.Instance.GetActivityData().GetLimitedTimeTabRewardProgress(this.TabIndex);
			int item = limitedTimeTabRewardProgress.Item1;
			int item2 = limitedTimeTabRewardProgress.Item2;
			KurotatoRewardTab? rewardTabConfigById = KurotatoConfig.Instance.GetRewardTabConfigById(this.TabIndex);
			if (rewardTabConfigById == null)
			{
				return;
			}
			string multiText = TextConfig.Instance.GetMultiText(rewardTabConfigById.Value.Name, Array.Empty<string>());
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 3);
			defaultInterpolatedStringHandler.AppendFormatted(multiText);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			string newText = defaultInterpolatedStringHandler.ToStringAndClear();
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText(newText, true);
		}

		// Token: 0x0602DDD9 RID: 187865 RVA: 0x00CD6834 File Offset: 0x00CD4A34
		public void BindRedDot(ERedDotName redDotName, int uId)
		{
			RedDotController.Instance.BindRedDot(redDotName, base.GetItem(2), null, uId);
		}

		// Token: 0x0602DDDA RID: 187866 RVA: 0x00CD684A File Offset: 0x00CD4A4A
		public void UnBindRedDot()
		{
			RedDotController.Instance.UnBindRedDot(ERedDotName.RedDotKurotatoLimitRewardTabItem);
		}

		// Token: 0x0602DDDB RID: 187867 RVA: 0x00CD685B File Offset: 0x00CD4A5B
		private void OnClickToggle(EToggleState state)
		{
			Action<int> onTabClickCallBack = this.OnTabClickCallBack;
			if (onTabClickCallBack == null)
			{
				return;
			}
			onTabClickCallBack(this.TabIndex);
		}

		// Token: 0x0602DDDC RID: 187868 RVA: 0x00CD6873 File Offset: 0x00CD4A73
		[NullableContext(1)]
		public void SetTabClickCallback(Action<int> callback)
		{
			this.OnTabClickCallBack = callback;
		}

		// Token: 0x0602DDDD RID: 187869 RVA: 0x00CD687C File Offset: 0x00CD4A7C
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleSelect(false, false);
		}

		// Token: 0x0602DDDE RID: 187870 RVA: 0x00CD6886 File Offset: 0x00CD4A86
		public void SetToggleSelect(bool isSelected, bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x04018808 RID: 100360
		private int TabIndex = -1;

		// Token: 0x04018809 RID: 100361
		[Nullable(2)]
		private Action<int> OnTabClickCallBack;

		// Token: 0x0200A3C5 RID: 41925
		private enum ETab
		{
			// Token: 0x04032C38 RID: 207928
			Name,
			// Token: 0x04032C39 RID: 207929
			Toggle,
			// Token: 0x04032C3A RID: 207930
			RedPoint
		}
	}
}
