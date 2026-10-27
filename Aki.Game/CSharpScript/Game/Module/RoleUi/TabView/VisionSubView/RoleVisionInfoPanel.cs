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
	// Token: 0x02004CF3 RID: 19699
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleVisionInfoPanel : UiPanelBase
	{
		// Token: 0x06032E55 RID: 208469 RVA: 0x00BDC877 File Offset: 0x00BDAA77
		[NullableContext(1)]
		public RoleVisionInfoPanel(UUIItem uiItem)
		{
			this.SourceItem = uiItem;
		}

		// Token: 0x06032E56 RID: 208470 RVA: 0x00BDC888 File Offset: 0x00BDAA88
		public UniTask Init()
		{
			RoleVisionInfoPanel.<Init>d__7 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<RoleVisionInfoPanel.<Init>d__7>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06032E57 RID: 208471 RVA: 0x00BDC8CC File Offset: 0x00BDAACC
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

		// Token: 0x06032E58 RID: 208472 RVA: 0x00BDC9EC File Offset: 0x00BDABEC
		protected override UniTask OnBeforeStartAsync()
		{
			RoleVisionInfoPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleVisionInfoPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032E59 RID: 208473 RVA: 0x00BDCA2F File Offset: 0x00BDAC2F
		protected override void OnStart()
		{
			this.VisionDetailDescComponent.SetActive(true);
			this.RoleVisionAttribute = new RoleVisionAttribute(base.GetItem(0));
			this.RoleVisionAttribute.Init();
			this.AddEventListener();
		}

		// Token: 0x06032E5A RID: 208474 RVA: 0x00BDCA60 File Offset: 0x00BDAC60
		private void BindRedDot()
		{
			if (!this.RedDotBindState)
			{
				this.RedDotBindState = true;
				int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
				RedDotController.Instance.BindRedDot(ERedDotName.VisionOneKeyEquip, base.GetItem(6), null, curSelectRoleId);
			}
		}

		// Token: 0x06032E5B RID: 208475 RVA: 0x00BDCA9D File Offset: 0x00BDAC9D
		private void UnBindRedDot()
		{
			if (this.RedDotBindState)
			{
				this.RedDotBindState = false;
				RedDotController.Instance.UnBindGivenUi(ERedDotName.VisionOneKeyEquip, base.GetItem(6), 0);
			}
		}

		// Token: 0x06032E5C RID: 208476 RVA: 0x00BDCAC2 File Offset: 0x00BDACC2
		public UUIItem GetTxtItemByIndex(int index)
		{
			VisionDetailDescComponent visionDetailDescComponent = this.VisionDetailDescComponent;
			if (visionDetailDescComponent == null)
			{
				return null;
			}
			return visionDetailDescComponent.GetTxtItemByIndex(index);
		}

		// Token: 0x06032E5D RID: 208477 RVA: 0x00BDCAD8 File Offset: 0x00BDACD8
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

		// Token: 0x06032E5E RID: 208478 RVA: 0x00BDCB64 File Offset: 0x00BDAD64
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

		// Token: 0x06032E5F RID: 208479 RVA: 0x00BDCBA4 File Offset: 0x00BDADA4
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

		// Token: 0x06032E60 RID: 208480 RVA: 0x00BDCBE3 File Offset: 0x00BDADE3
		private void OnClickConfirmButton()
		{
			Action onClickConfirmCall = this.OnClickConfirmCall;
			if (onClickConfirmCall == null)
			{
				return;
			}
			onClickConfirmCall();
		}

		// Token: 0x06032E61 RID: 208481 RVA: 0x00BDCBF5 File Offset: 0x00BDADF5
		[NullableContext(1)]
		public void SetConfirmButtonCall(Action call)
		{
			this.OnClickConfirmCall = call;
		}

		// Token: 0x06032E62 RID: 208482 RVA: 0x00BDCC00 File Offset: 0x00BDAE00
		public void RefreshButtonShowState()
		{
			bool flag = this.RoleViewAgent.GetCurSelectRoleData().IsTrialRole();
			this.RefreshConfirmButtonState(!flag);
			this.RefreshOneKeyButtonState(!flag);
		}

		// Token: 0x06032E63 RID: 208483 RVA: 0x00BDCC34 File Offset: 0x00BDAE34
		public void RefreshConfirmButtonState(bool state)
		{
			base.GetButton(3).RootUIComp.Get().SetUIActive(state);
		}

		// Token: 0x06032E64 RID: 208484 RVA: 0x00BDCC5C File Offset: 0x00BDAE5C
		public void RefreshOneKeyButtonState(bool state)
		{
			base.GetButton(5).RootUIComp.Get().SetUIActive(state);
		}

		// Token: 0x06032E65 RID: 208485 RVA: 0x00BDCC83 File Offset: 0x00BDAE83
		protected void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.PhantomEquip, new Action(this.OnPhantomEquip));
		}

		// Token: 0x06032E66 RID: 208486 RVA: 0x00BDCCA1 File Offset: 0x00BDAEA1
		protected void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PhantomEquip, new Action(this.OnPhantomEquip));
		}

		// Token: 0x06032E67 RID: 208487 RVA: 0x00BDCCBF File Offset: 0x00BDAEBF
		[NullableContext(1)]
		public void RefreshView(RoleViewAgent roleViewAgent)
		{
			this.RoleViewAgent = roleViewAgent;
			this.RefreshUi();
		}

		// Token: 0x06032E68 RID: 208488 RVA: 0x00BDCCCE File Offset: 0x00BDAECE
		private void RefreshUi()
		{
			this.RefreshAttribute();
			this.RefreshDetailComponent();
			this.RefreshOneKeyDownButtonState();
			this.RefreshButtonShowState();
			this.UnBindRedDot();
			this.BindRedDot();
		}

		// Token: 0x06032E69 RID: 208489 RVA: 0x00BDCCF4 File Offset: 0x00BDAEF4
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

		// Token: 0x06032E6A RID: 208490 RVA: 0x00BDCE04 File Offset: 0x00BDB004
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

		// Token: 0x06032E6B RID: 208491 RVA: 0x00BDCFD0 File Offset: 0x00BDB1D0
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

		// Token: 0x06032E6C RID: 208492 RVA: 0x00BDD088 File Offset: 0x00BDB288
		private void OnPhantomEquip()
		{
			this.RefreshUi();
		}

		// Token: 0x06032E6D RID: 208493 RVA: 0x00BDD090 File Offset: 0x00BDB290
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
			this.RemoveEventListener();
		}

		// Token: 0x0401B119 RID: 110873
		private RoleViewAgent RoleViewAgent;

		// Token: 0x0401B11A RID: 110874
		private RoleVisionAttribute RoleVisionAttribute;

		// Token: 0x0401B11B RID: 110875
		private VisionDetailDescComponent VisionDetailDescComponent;

		// Token: 0x0401B11C RID: 110876
		private Action OnClickConfirmCall;

		// Token: 0x0401B11D RID: 110877
		private readonly UUIItem SourceItem;

		// Token: 0x0401B11E RID: 110878
		private bool RedDotBindState;

		// Token: 0x0200AE80 RID: 44672
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04034FC6 RID: 217030
			AttributeItem,
			// Token: 0x04034FC7 RID: 217031
			MoreButton,
			// Token: 0x04034FC8 RID: 217032
			DetailContent,
			// Token: 0x04034FC9 RID: 217033
			ConfirmButton,
			// Token: 0x04034FCA RID: 217034
			OneKeyDownEquipmentButton,
			// Token: 0x04034FCB RID: 217035
			OneKeyUpEquipmentButton,
			// Token: 0x04034FCC RID: 217036
			OneKeyEquipRedItem
		}
	}
}
