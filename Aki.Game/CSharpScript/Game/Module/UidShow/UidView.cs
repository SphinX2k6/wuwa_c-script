using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UidShow
{
	// Token: 0x02003984 RID: 14724
	public class UidView : UiViewBase
	{
		// Token: 0x06025E39 RID: 155193 RVA: 0x00AA3B9F File Offset: 0x00AA1D9F
		[NullableContext(1)]
		public UidView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06025E3A RID: 155194 RVA: 0x00AA3BA8 File Offset: 0x00AA1DA8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06025E3B RID: 155195 RVA: 0x00AA3C11 File Offset: 0x00AA1E11
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<bool>(EEventName.OnPreparePhotoScreenShot, new Action<bool>(this.OnRefreshUidViewShowState));
		}

		// Token: 0x06025E3C RID: 155196 RVA: 0x00AA3C2F File Offset: 0x00AA1E2F
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPreparePhotoScreenShot, new Action<bool>(this.OnRefreshUidViewShowState));
		}

		// Token: 0x06025E3D RID: 155197 RVA: 0x00AA3C50 File Offset: 0x00AA1E50
		protected override void OnStart()
		{
			string str = "";
			if (FeatureRestrictionTemplate.TemplateForPioneerClient.Check())
			{
				str = " " + TextConfig.Instance.GetTextById("BetaVersionTip");
			}
			LguiUtil.Instance.SetLocalText(base.GetText(0), "FriendMyUid", new <>z__ReadOnlySingleElementList<object>(FunctionModel.Instance.PlayerId.ToString() + str));
			this.RefreshRecallItem();
		}

		// Token: 0x06025E3E RID: 155198 RVA: 0x00AA3CC4 File Offset: 0x00AA1EC4
		private void RefreshRecallItem()
		{
			bool uiactive = RecallQuestModel.Instance.IsInRecallInstance();
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x06025E3F RID: 155199 RVA: 0x00AA3CEE File Offset: 0x00AA1EEE
		private void OnRefreshUidViewShowState(bool state)
		{
			UUIItem rootItem = base.GetRootItem();
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(state);
		}

		// Token: 0x020095D1 RID: 38353
		private class EUidViewComponent
		{
			// Token: 0x0402ECD5 RID: 191701
			public const int UidText = 0;

			// Token: 0x0402ECD6 RID: 191702
			public const int RecallTextItem = 1;
		}
	}
}
