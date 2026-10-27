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
	// Token: 0x02004A08 RID: 18952
	public class UidView : UiViewBase
	{
		// Token: 0x060312EB RID: 201451 RVA: 0x00B68437 File Offset: 0x00B66637
		[NullableContext(1)]
		public UidView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060312EC RID: 201452 RVA: 0x00B68440 File Offset: 0x00B66640
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

		// Token: 0x060312ED RID: 201453 RVA: 0x00B684A9 File Offset: 0x00B666A9
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<bool>(EEventName.OnPreparePhotoScreenShot, new Action<bool>(this.OnRefreshUidViewShowState));
		}

		// Token: 0x060312EE RID: 201454 RVA: 0x00B684C7 File Offset: 0x00B666C7
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPreparePhotoScreenShot, new Action<bool>(this.OnRefreshUidViewShowState));
		}

		// Token: 0x060312EF RID: 201455 RVA: 0x00B684E8 File Offset: 0x00B666E8
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

		// Token: 0x060312F0 RID: 201456 RVA: 0x00B6855C File Offset: 0x00B6675C
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

		// Token: 0x060312F1 RID: 201457 RVA: 0x00B68588 File Offset: 0x00B66788
		private void OnRefreshUidViewShowState(bool state)
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetUIActive(state);
			}
		}

		// Token: 0x0200ABC2 RID: 43970
		private class EUidViewComponent
		{
			// Token: 0x04034352 RID: 213842
			public const int UidText = 0;

			// Token: 0x04034353 RID: 213843
			public const int RecallTextItem = 1;
		}
	}
}
