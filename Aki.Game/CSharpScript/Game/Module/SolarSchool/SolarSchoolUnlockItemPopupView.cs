using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityCondition;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059DD RID: 23005
	public class SolarSchoolUnlockItemPopupView : UiViewBase
	{
		// Token: 0x06038AA3 RID: 232099 RVA: 0x00FDBE12 File Offset: 0x00FDA012
		[NullableContext(1)]
		public SolarSchoolUnlockItemPopupView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038AA4 RID: 232100 RVA: 0x00FDBE1C File Offset: 0x00FDA01C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038AA5 RID: 232101 RVA: 0x00FDBEC8 File Offset: 0x00FDA0C8
		protected override void OnStart()
		{
			this.GroupData = (this.OpenParam as ConditionGroupData);
			UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(2);
			UUIItem item = base.GetItem(3);
			this.ConditionLayout = new LoopScrollView<SolarSchoolUnlockConditionItem, IActivityConditionData>(loopScrollViewComponent, item.GetOwner() as AUIBaseActor, () => new SolarSchoolUnlockConditionItem(), false);
		}

		// Token: 0x06038AA6 RID: 232102 RVA: 0x00FDBF30 File Offset: 0x00FDA130
		protected override void OnBeforeDestroy()
		{
			this.ConditionLayout = null;
			this.GroupData = null;
			SolarSchoolUnlockItemPopupParam solarSchoolUnlockItemPopupParam = this.OpenParam as SolarSchoolUnlockItemPopupParam;
			if (solarSchoolUnlockItemPopupParam == null)
			{
				return;
			}
			Action closeCallback = solarSchoolUnlockItemPopupParam.CloseCallback;
			solarSchoolUnlockItemPopupParam.CloseCallback = null;
			try
			{
				if (closeCallback != null)
				{
					closeCallback();
				}
			}
			catch (Exception item)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 解锁条件弹窗关闭回调异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("exception", item);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06038AA7 RID: 232103 RVA: 0x00FDBFB4 File Offset: 0x00FDA1B4
		protected override void OnBeforeShow()
		{
			if (this.GroupData == null)
			{
				return;
			}
			LoopScrollView<SolarSchoolUnlockConditionItem, IActivityConditionData> conditionLayout = this.ConditionLayout;
			if (conditionLayout != null)
			{
				conditionLayout.RefreshByData(this.GroupData.DataList, false, null, false);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.GroupData.TitleId ?? string.Empty, Array.Empty<object>());
			Aki.Config.ActivityConditionGroup? conditionGroupConfig = ActivityConditionConfig.Instance.GetConditionGroupConfig(this.GroupData.ConditionGroupId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), ((conditionGroupConfig != null) ? conditionGroupConfig.GetValueOrDefault().HintText : null) ?? string.Empty, Array.Empty<object>());
		}

		// Token: 0x0401DD7C RID: 122236
		[Nullable(2)]
		private ConditionGroupData GroupData;

		// Token: 0x0401DD7D RID: 122237
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<SolarSchoolUnlockConditionItem, IActivityConditionData> ConditionLayout;

		// Token: 0x0200B588 RID: 46472
		private class EComponent
		{
			// Token: 0x04038222 RID: 229922
			public const int TxtTitle = 0;

			// Token: 0x04038223 RID: 229923
			public const int TxtTips = 1;

			// Token: 0x04038224 RID: 229924
			public const int ConditionLayout = 2;

			// Token: 0x04038225 RID: 229925
			public const int ConditionItem = 3;
		}
	}
}
