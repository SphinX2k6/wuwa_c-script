using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Map
{
	// Token: 0x02003C14 RID: 15380
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SheriffMapMainTabItem : GridProxyAbstract<ISheriffMainTabItemData>
	{
		// Token: 0x0602767A RID: 161402 RVA: 0x00B0B9D0 File Offset: 0x00B09BD0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggleSpriteTransition));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickItem));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602767B RID: 161403 RVA: 0x00B0BA98 File Offset: 0x00B09C98
		private void OnClickItem(EToggleState state)
		{
			if (state == EToggleState.ETT_UnChecked)
			{
				return;
			}
			IScrollViewDelegate<IGridProxy<ISheriffMainTabItemData>, ISheriffMainTabItemData> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate != null)
			{
				scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
			}
			if (this.Data == null)
			{
				return;
			}
			Action<ISheriffMainTabItemData> selectCallBack = this.SelectCallBack;
			if (selectCallBack == null)
			{
				return;
			}
			selectCallBack(this.Data);
		}

		// Token: 0x0602767C RID: 161404 RVA: 0x00B0BAE6 File Offset: 0x00B09CE6
		protected override void OnStart()
		{
			base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			base.GetExtendToggle(0).bLockStateOnSelect = true;
			base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
		}

		// Token: 0x0602767D RID: 161405 RVA: 0x00B0BB22 File Offset: 0x00B09D22
		private void OnUndeterminedClicked()
		{
			this.OpenConditionView();
		}

		// Token: 0x0602767E RID: 161406 RVA: 0x00B0BB2C File Offset: 0x00B09D2C
		public override void Refresh(ISheriffMainTabItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), data.TabTxt, Array.Empty<object>());
			string tabIcon = data.TabIcon;
			UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(2);
			EToggleTransitionState[] array = new EToggleTransitionState[6];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.7723512959E7AC842AB4353C8D2156604031425482D367DAB73DB105164F34FA).FieldHandle);
			base.SetExtendToggleSpriteTransitionByStateList(tabIcon, uiExtendToggleSpriteTransition, array);
			if (data.IsLock.GetValueOrDefault())
			{
				base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnDetermined, false, false, false);
			}
		}

		// Token: 0x0602767F RID: 161407 RVA: 0x00B0BBA1 File Offset: 0x00B09DA1
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x06027680 RID: 161408 RVA: 0x00B0BBB3 File Offset: 0x00B09DB3
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x06027681 RID: 161409 RVA: 0x00B0BBC5 File Offset: 0x00B09DC5
		public override object GetKey(ISheriffMainTabItemData data, int displayIndex)
		{
			return data.TabType;
		}

		// Token: 0x06027682 RID: 161410 RVA: 0x00B0BBD4 File Offset: 0x00B09DD4
		public void OpenConditionView()
		{
			FunctionCondition? config = ConfigFunctionConditionByFunctionId.GetConfig((int)this.Data.FunctionType, true);
			if (config == null)
			{
				return;
			}
			List<IActivityConditionData> list = new List<IActivityConditionData>();
			int[] groupConditionIds = ConditionConfig.Instance.GetGroupConditionIds(config.Value.OpenConditionId);
			if (groupConditionIds == null)
			{
				return;
			}
			foreach (int conditionId in groupConditionIds)
			{
				Condition? conditionConfig = ConditionConfig.Instance.GetConditionConfig(conditionId);
				if (conditionConfig != null)
				{
					int accessType = -1;
					if (!string.IsNullOrEmpty(conditionConfig.Value.Description))
					{
						if (conditionConfig.Value.AccessId != 0)
						{
							AccessPath? configById = GetWayConfig.Instance.GetConfigById(conditionConfig.Value.AccessId);
							accessType = ((configById != null) ? configById.GetValueOrDefault().SkipName : -1);
						}
						ActivityConditionData item = new ActivityConditionData
						{
							ConditionId = conditionId,
							ConditionTextId = conditionConfig.Value.Description,
							IsFinished = false,
							AccessId = conditionConfig.Value.AccessId,
							AccessType = accessType
						};
						list.Add(item);
					}
				}
			}
			ConditionGroupData param = new ConditionGroupData(config.Value.OpenConditionId, list, "", false);
			UiManager.Instance.OpenView(EUiViewName.CommonConditionView, param, null);
		}

		// Token: 0x040157CF RID: 88015
		[Nullable(2)]
		private ISheriffMainTabItemData Data;

		// Token: 0x040157D0 RID: 88016
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ISheriffMainTabItemData> SelectCallBack;

		// Token: 0x0200982C RID: 38956
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x0402F771 RID: 194417
			public const int Toggle = 0;

			// Token: 0x0402F772 RID: 194418
			public const int Text = 1;

			// Token: 0x0402F773 RID: 194419
			public const int Icon = 2;
		}
	}
}
