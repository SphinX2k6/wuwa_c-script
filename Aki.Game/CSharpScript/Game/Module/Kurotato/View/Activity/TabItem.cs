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
	// Token: 0x02005789 RID: 22409
	internal class TabItem : GridProxyAbstract<KurotatoRewardTab>
	{
		// Token: 0x06038EC4 RID: 233156 RVA: 0x00D87838 File Offset: 0x00D85A38
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

		// Token: 0x06038EC5 RID: 233157 RVA: 0x00D878FF File Offset: 0x00D85AFF
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.OnRefreshKurotatoLimitRewardData, new Action(this.RefreshTabNameText));
		}

		// Token: 0x06038EC6 RID: 233158 RVA: 0x00D8791D File Offset: 0x00D85B1D
		protected override void OnBeforeHide()
		{
			this.UnBindRedDot();
			EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoLimitRewardData, new Action(this.RefreshTabNameText));
		}

		// Token: 0x06038EC7 RID: 233159 RVA: 0x00D87944 File Offset: 0x00D85B44
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

		// Token: 0x06038EC8 RID: 233160 RVA: 0x00D87A0C File Offset: 0x00D85C0C
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

		// Token: 0x06038EC9 RID: 233161 RVA: 0x00D87AD8 File Offset: 0x00D85CD8
		public void BindRedDot(ERedDotName redDotName, int uId)
		{
			RedDotController.Instance.BindRedDot(redDotName, base.GetItem(2), null, uId);
		}

		// Token: 0x06038ECA RID: 233162 RVA: 0x00D87AEE File Offset: 0x00D85CEE
		public void UnBindRedDot()
		{
			RedDotController.Instance.UnBindRedDot(ERedDotName.RedDotKurotatoLimitRewardTabItem);
		}

		// Token: 0x06038ECB RID: 233163 RVA: 0x00D87AFF File Offset: 0x00D85CFF
		private void OnClickToggle(EToggleState state)
		{
			Action<int> onTabClickCallBack = this.OnTabClickCallBack;
			if (onTabClickCallBack == null)
			{
				return;
			}
			onTabClickCallBack(this.TabIndex);
		}

		// Token: 0x06038ECC RID: 233164 RVA: 0x00D87B17 File Offset: 0x00D85D17
		[NullableContext(1)]
		public void SetTabClickCallback(Action<int> callback)
		{
			this.OnTabClickCallBack = callback;
		}

		// Token: 0x06038ECD RID: 233165 RVA: 0x00D87B20 File Offset: 0x00D85D20
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleSelect(false, false);
		}

		// Token: 0x06038ECE RID: 233166 RVA: 0x00D87B2A File Offset: 0x00D85D2A
		public void SetToggleSelect(bool isSelected, bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0401DD72 RID: 122226
		private int TabIndex = -1;

		// Token: 0x0401DD73 RID: 122227
		[Nullable(2)]
		private Action<int> OnTabClickCallBack;

		// Token: 0x0200B9AF RID: 47535
		private enum ETab
		{
			// Token: 0x04038247 RID: 229959
			Name,
			// Token: 0x04038248 RID: 229960
			Toggle,
			// Token: 0x04038249 RID: 229961
			RedPoint
		}
	}
}
