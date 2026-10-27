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
	// Token: 0x02004C63 RID: 19555
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SheriffMapMainTabItem : GridProxyAbstract<ISheriffMainTabItemData>
	{
		// Token: 0x060328C7 RID: 207047 RVA: 0x00BC6D64 File Offset: 0x00BC4F64
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

		// Token: 0x060328C8 RID: 207048 RVA: 0x00BC6E2C File Offset: 0x00BC502C
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

		// Token: 0x060328C9 RID: 207049 RVA: 0x00BC6E7A File Offset: 0x00BC507A
		protected override void OnStart()
		{
			base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			base.GetExtendToggle(0).bLockStateOnSelect = true;
			base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
		}

		// Token: 0x060328CA RID: 207050 RVA: 0x00BC6EB6 File Offset: 0x00BC50B6
		private void OnUndeterminedClicked()
		{
			this.OpenConditionView();
		}

		// Token: 0x060328CB RID: 207051 RVA: 0x00BC6EC0 File Offset: 0x00BC50C0
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

		// Token: 0x060328CC RID: 207052 RVA: 0x00BC6F35 File Offset: 0x00BC5135
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x060328CD RID: 207053 RVA: 0x00BC6F47 File Offset: 0x00BC5147
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x060328CE RID: 207054 RVA: 0x00BC6F59 File Offset: 0x00BC5159
		public override object GetKey(ISheriffMainTabItemData data, int displayIndex)
		{
			return data.TabType;
		}

		// Token: 0x060328CF RID: 207055 RVA: 0x00BC6F68 File Offset: 0x00BC5168
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

		// Token: 0x0401AE72 RID: 110194
		[Nullable(2)]
		private ISheriffMainTabItemData Data;

		// Token: 0x0401AE73 RID: 110195
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ISheriffMainTabItemData> SelectCallBack;

		// Token: 0x0200AE0E RID: 44558
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x04034DCC RID: 216524
			public const int Toggle = 0;

			// Token: 0x04034DCD RID: 216525
			public const int Text = 1;

			// Token: 0x04034DCE RID: 216526
			public const int Icon = 2;
		}
	}
}
