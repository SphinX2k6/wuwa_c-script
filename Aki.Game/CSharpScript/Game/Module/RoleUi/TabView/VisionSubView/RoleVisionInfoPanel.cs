using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Phantom.Vision.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.TabView.VisionSubView
{
	// Token: 0x02003CA5 RID: 15525
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleVisionInfoPanel : UiPanelBase
	{
		// Token: 0x06027C30 RID: 162864 RVA: 0x00B2217F File Offset: 0x00B2037F
		[NullableContext(1)]
		public RoleVisionInfoPanel(UUIItem uiItem)
		{
			this.SourceItem = uiItem;
		}

		// Token: 0x06027C31 RID: 162865 RVA: 0x00B22190 File Offset: 0x00B20390
		public UniTask Init()
		{
			RoleVisionInfoPanel.<Init>d__7 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<RoleVisionInfoPanel.<Init>d__7>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06027C32 RID: 162866 RVA: 0x00B221D4 File Offset: 0x00B203D4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickMoreButton)),
				new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirmButton)),
				new ValueTuple<int, Delegate>(4, new Action(this.OnOneKeyDownEquipmentButton)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnOneKeyUpEquipmentButton))
			};
		}

		// Token: 0x06027C33 RID: 162867 RVA: 0x00B222F4 File Offset: 0x00B204F4
		protected override UniTask OnBeforeStartAsync()
		{
			RoleVisionInfoPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleVisionInfoPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027C34 RID: 162868 RVA: 0x00B22337 File Offset: 0x00B20537
		protected override void OnStart()
		{
			this.VisionDetailDescComponent.SetActive(true);
			this.RoleVisionAttribute = new RoleVisionAttribute(base.GetItem(0));
			this.RoleVisionAttribute.Init();
			this.AddEventListener();
		}

		// Token: 0x06027C35 RID: 162869 RVA: 0x00B22368 File Offset: 0x00B20568
		private void BindRedDot()
		{
			if (!this.RedDotBindState)
			{
				this.RedDotBindState = true;
				int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
				RedDotController.Instance.BindRedDot(ERedDotName.VisionOneKeyEquip, base.GetItem(6), null, curSelectRoleId);
			}
		}

		// Token: 0x06027C36 RID: 162870 RVA: 0x00B223A5 File Offset: 0x00B205A5
		private void UnBindRedDot()
		{
			if (this.RedDotBindState)
			{
				this.RedDotBindState = false;
				RedDotController.Instance.UnBindGivenUi(ERedDotName.VisionOneKeyEquip, base.GetItem(6), 0);
			}
		}

		// Token: 0x06027C37 RID: 162871 RVA: 0x00B223CA File Offset: 0x00B205CA
		public UUIItem GetTxtItemByIndex(int index)
		{
			VisionDetailDescComponent visionDetailDescComponent = this.VisionDetailDescComponent;
			if (visionDetailDescComponent == null)
			{
				return null;
			}
			return visionDetailDescComponent.GetTxtItemByIndex(index);
		}

		// Token: 0x06027C38 RID: 162872 RVA: 0x00B223E0 File Offset: 0x00B205E0
		private void OnOneKeyDownEquipmentButton()
		{
			RoleDataBase roleInstance = this.RoleViewAgent.GetCurSelectRoleData();
			int[] tempList = new int[5];
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.VisionDownAllEquipmentTip);
			confirmBoxDataNew.FunctionMap.Add(1, delegate
			{
				ConfirmBoxController.Instance.CloseConfirmBoxView();
			});
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				PhantomBattleController.Instance.SendPhantomAutoPutRequest(roleInstance.GetRoleId(), new List<int>(tempList), null);
				ConfirmBoxController.Instance.CloseConfirmBoxView();
				UiManager.Instance.CloseView(EUiViewName.VisionNewRecommendView, null);
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06027C39 RID: 162873 RVA: 0x00B2246C File Offset: 0x00B2066C
		private void OnOneKeyUpEquipmentButton()
		{
			int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
			VisionRecommendViewOpenParam param = new VisionRecommendViewOpenParam
			{
				RoleId = curSelectRoleId,
				IsFromRoleDev = false
			};
			UiManager.Instance.OpenView(EUiViewName.VisionNewRecommendView, param, null);
		}

		// Token: 0x06027C3A RID: 162874 RVA: 0x00B224AC File Offset: 0x00B206AC
		private void OnClickMoreButton()
		{
			RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
			if (curSelectRoleData == null)
			{
				return;
			}
			List<AttrListScrollData> extraAttrList = PhantomBattleModel.Instance.GetExtraAttrList(curSelectRoleData.GetDataId());
			UiManager.Instance.OpenView(EUiViewName.RoleAttributeDetailView, extraAttrList, null);
		}

		// Token: 0x06027C3B RID: 162875 RVA: 0x00B224EB File Offset: 0x00B206EB
		private void OnClickConfirmButton()
		{
			Action onClickConfirmCall = this.OnClickConfirmCall;
			if (onClickConfirmCall == null)
			{
				return;
			}
			onClickConfirmCall();
		}

		// Token: 0x06027C3C RID: 162876 RVA: 0x00B224FD File Offset: 0x00B206FD
		[NullableContext(1)]
		public void SetConfirmButtonCall(Action call)
		{
			this.OnClickConfirmCall = call;
		}

		// Token: 0x06027C3D RID: 162877 RVA: 0x00B22508 File Offset: 0x00B20708
		public void RefreshButtonShowState()
		{
			bool flag = this.RoleViewAgent.GetCurSelectRoleData().IsTrialRole();
			this.RefreshConfirmButtonState(!flag);
			this.RefreshOneKeyButtonState(!flag);
		}

		// Token: 0x06027C3E RID: 162878 RVA: 0x00B2253C File Offset: 0x00B2073C
		public void RefreshConfirmButtonState(bool state)
		{
			base.GetButton(3).RootUIComp.Get().SetUIActive(state);
		}

		// Token: 0x06027C3F RID: 162879 RVA: 0x00B22564 File Offset: 0x00B20764
		public void RefreshOneKeyButtonState(bool state)
		{
			base.GetButton(5).RootUIComp.Get().SetUIActive(state);
		}

		// Token: 0x06027C40 RID: 162880 RVA: 0x00B2258B File Offset: 0x00B2078B
		protected void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.PhantomEquip, new Action(this.OnPhantomEquip));
		}

		// Token: 0x06027C41 RID: 162881 RVA: 0x00B225A9 File Offset: 0x00B207A9
		protected void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PhantomEquip, new Action(this.OnPhantomEquip));
		}

		// Token: 0x06027C42 RID: 162882 RVA: 0x00B225C7 File Offset: 0x00B207C7
		[NullableContext(1)]
		public void RefreshView(RoleViewAgent roleViewAgent)
		{
			this.RoleViewAgent = roleViewAgent;
			this.RefreshUi();
		}

		// Token: 0x06027C43 RID: 162883 RVA: 0x00B225D6 File Offset: 0x00B207D6
		private void RefreshUi()
		{
			this.RefreshAttribute();
			this.RefreshDetailComponent();
			this.RefreshOneKeyDownButtonState();
			this.RefreshButtonShowState();
			this.UnBindRedDot();
			this.BindRedDot();
		}

		// Token: 0x06027C44 RID: 162884 RVA: 0x00B225FC File Offset: 0x00B207FC
		private void RefreshAttribute()
		{
			RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
			List<AttrListScrollData> list = new List<AttrListScrollData>(PhantomBattleModel.Instance.GetShowAttrList(curSelectRoleData.GetDataId()));
			int count = list.Count;
			IEnumerable<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("VisionMainViewShowAttribute");
			List<AttrListScrollData> list2 = new List<AttrListScrollData>();
			foreach (int num in intArrayConfig)
			{
				PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(num);
				bool flag = false;
				for (int i = 0; i < count; i++)
				{
					if (list[i].Id == num)
					{
						list2.Add(list[i]);
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list2.Add(new AttrListScrollData(num, 0.0, 0.0, propertyIndexInfo.Value.Priority, false, CommonComponentDefine.EAttributeType.PhantomType));
				}
			}
			this.RoleVisionAttribute.Refresh(list2, true);
		}

		// Token: 0x06027C45 RID: 162885 RVA: 0x00B2270C File Offset: 0x00B2090C
		private void RefreshDetailComponent()
		{
			RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
			PhantomDataBase dataByIndex = curSelectRoleData.GetPhantomData().GetDataByIndex(0);
			List<VisionDetailDesc> list = new List<VisionDetailDesc>();
			if (dataByIndex != null)
			{
				using (List<VisionDetailDesc>.Enumerator enumerator = VisionDetailDesc.ConvertVisionSkillDescToDescData(dataByIndex.GetNormalSkillConfig().Value, dataByIndex.GetPhantomLevel(), true, false, dataByIndex.GetQuality()).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						VisionDetailDesc item = enumerator.Current;
						list.Add(item);
					}
					goto IL_AF;
				}
			}
			foreach (VisionDetailDesc item2 in VisionDetailDesc.CreateEmptySkillDescData())
			{
				list.Add(item2);
			}
			IL_AF:
			VisionFetterData[] phantomFettersData = curSelectRoleData.GetPhantomData().GetPhantomFettersData();
			if (phantomFettersData.Length == 0)
			{
				using (List<VisionDetailDesc>.Enumerator enumerator = VisionDetailDesc.CreateEmptyFetterDescData().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						VisionDetailDesc item3 = enumerator.Current;
						list.Add(item3);
					}
					goto IL_141;
				}
			}
			foreach (VisionDetailDesc item4 in VisionDetailDesc.ConvertVisionFetterDataToDetailDescData(new List<VisionFetterData>(phantomFettersData), false, null, null))
			{
				list.Add(item4);
			}
			IL_141:
			foreach (VisionDetailDesc visionDetailDesc in list)
			{
				visionDetailDesc.DoNotNeedCheckSimplyState = true;
			}
			this.VisionDetailDescComponent.Refresh(list, false);
		}

		// Token: 0x06027C46 RID: 162886 RVA: 0x00B228D8 File Offset: 0x00B20AD8
		private void RefreshOneKeyDownButtonState()
		{
			RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
			if (curSelectRoleData.IsTrialRole())
			{
				this.RefreshOneKeyButtonState(false);
				base.GetButton(4).RootUIComp.Get().SetUIActive(false);
				return;
			}
			Dictionary<int, PhantomDataBase> dataMap = curSelectRoleData.GetPhantomData().GetDataMap();
			int num = 0;
			foreach (KeyValuePair<int, PhantomDataBase> keyValuePair in dataMap)
			{
				if (keyValuePair.Value != null)
				{
					num++;
				}
			}
			base.GetButton(4).RootUIComp.Get().SetUIActive(num >= 1);
		}

		// Token: 0x06027C47 RID: 162887 RVA: 0x00B22990 File Offset: 0x00B20B90
		private void OnPhantomEquip()
		{
			this.RefreshUi();
		}

		// Token: 0x06027C48 RID: 162888 RVA: 0x00B22998 File Offset: 0x00B20B98
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
			this.RemoveEventListener();
		}

		// Token: 0x04015A9E RID: 88734
		private RoleViewAgent RoleViewAgent;

		// Token: 0x04015A9F RID: 88735
		private RoleVisionAttribute RoleVisionAttribute;

		// Token: 0x04015AA0 RID: 88736
		private VisionDetailDescComponent VisionDetailDescComponent;

		// Token: 0x04015AA1 RID: 88737
		private Action OnClickConfirmCall;

		// Token: 0x04015AA2 RID: 88738
		private readonly UUIItem SourceItem;

		// Token: 0x04015AA3 RID: 88739
		private bool RedDotBindState;

		// Token: 0x0200989E RID: 39070
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0402F96E RID: 194926
			AttributeItem,
			// Token: 0x0402F96F RID: 194927
			MoreButton,
			// Token: 0x0402F970 RID: 194928
			DetailContent,
			// Token: 0x0402F971 RID: 194929
			ConfirmButton,
			// Token: 0x0402F972 RID: 194930
			OneKeyDownEquipmentButton,
			// Token: 0x0402F973 RID: 194931
			OneKeyUpEquipmentButton,
			// Token: 0x0402F974 RID: 194932
			OneKeyEquipRedItem
		}
	}
}
