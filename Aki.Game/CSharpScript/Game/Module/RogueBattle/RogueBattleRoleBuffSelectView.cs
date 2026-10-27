using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EFA RID: 20218
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleRoleBuffSelectView : UiViewBase
	{
		// Token: 0x06033DB9 RID: 212409 RVA: 0x00C25D90 File Offset: 0x00C23F90
		public RogueBattleRoleBuffSelectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033DBA RID: 212410 RVA: 0x00C25D9C File Offset: 0x00C23F9C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(8, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action(this.OnBtnConfirm)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnBtnDetail))
			};
		}

		// Token: 0x06033DBB RID: 212411 RVA: 0x00C25EB8 File Offset: 0x00C240B8
		private void OnBtnConfirm()
		{
			int incId = (int)this.OpenParam;
			((MapRogueOpRoleBuffBondLinkId)MapRogueModel.Instance.GetOpData(incId)).Select(this.BuffLayout.GetSelectedGridIndex());
			MapRogueModel.Instance.ExecuteOpData(incId, null);
		}

		// Token: 0x06033DBC RID: 212412 RVA: 0x00C25F00 File Offset: 0x00C24100
		private unsafe void OnBtnDetail()
		{
			int parentId = ((MapRogueOpRoleBuffBondLinkId)MapRogueModel.Instance.GetOpData((int)this.OpenParam)).Data.RollBuffBondLinkIdOp.RoleBondInfoView.ParentId;
			RogueResBondRole? rogueResBondRole = RogueBattleConfig.Instance.GetRogueResBondRole(parentId);
			if (rogueResBondRole != null)
			{
				RoleController instance = RoleController.Instance;
				ERoleAgentType agentType = ERoleAgentType.Preview;
				int selectRoleId = 0;
				int num = 1;
				List<int> list = new List<int>(num);
				CollectionsMarshal.SetCount<int>(list, num);
				Span<int> span = CollectionsMarshal.AsSpan<int>(list);
				int index = 0;
				*span[index] = rogueResBondRole.Value.TrialRoleId;
				instance.OpenRoleMainView(agentType, selectRoleId, list, new EUiTabViewName?(EUiTabViewName.RoleSkillTabView), null);
			}
		}

		// Token: 0x06033DBD RID: 212413 RVA: 0x00C25F9C File Offset: 0x00C2419C
		private void OnSelectBuff(int index)
		{
			if (index == this.BuffLayout.GetSelectedGridIndex())
			{
				GenericLayout<RogueBattleRoleBuffItem, RogueResGainData> buffLayout = this.BuffLayout;
				if (buffLayout != null)
				{
					buffLayout.DeselectCurrentGridProxy();
				}
				base.GetButton(4).SetSelfInteractive(false);
				return;
			}
			GenericLayout<RogueBattleRoleBuffItem, RogueResGainData> buffLayout2 = this.BuffLayout;
			if (buffLayout2 != null)
			{
				buffLayout2.SelectGridProxy(index, false);
			}
			base.GetButton(4).SetSelfInteractive(true);
		}

		// Token: 0x06033DBE RID: 212414 RVA: 0x00C25FF8 File Offset: 0x00C241F8
		private void OnClickDetail(int index)
		{
			MapRogueOpRoleBuffBondLinkId mapRogueOpRoleBuffBondLinkId = (MapRogueOpRoleBuffBondLinkId)MapRogueModel.Instance.GetOpData((int)this.OpenParam);
			IList<RogueResGainData> gainDataList = mapRogueOpRoleBuffBondLinkId.GetGainDataList();
			List<int> list = new List<int>();
			for (int i = 0; i < gainDataList.Count; i++)
			{
				RogueResGainData rogueResGainData = gainDataList[i];
				if (rogueResGainData.RogueResRoleBuff != null)
				{
					list.Add(rogueResGainData.RogueResRoleBuff.ConfigId);
				}
			}
			IRogueBattleRoleAffixDetailOpenParam param = new RogueBattleRoleAffixDetailOpenParam
			{
				Index = index,
				AffixIds = list,
				RoleId = mapRogueOpRoleBuffBondLinkId.Data.RollBuffBondLinkIdOp.RogueResOption.RoleId
			};
			UiManager.Instance.OpenView(EUiViewName.RogueBattleRoleAffixDetailView, param, null);
		}

		// Token: 0x06033DBF RID: 212415 RVA: 0x00C260A7 File Offset: 0x00C242A7
		private RogueBattleRoleBuffItem CreateItem()
		{
			return new RogueBattleRoleBuffItem
			{
				OnSelectCallback = new Action<int>(this.OnSelectBuff),
				OnClickBtnDetailCallback = new Action<int>(this.OnClickDetail)
			};
		}

		// Token: 0x06033DC0 RID: 212416 RVA: 0x00C260D4 File Offset: 0x00C242D4
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleRoleBuffSelectView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleRoleBuffSelectView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033DC1 RID: 212417 RVA: 0x00C26117 File Offset: 0x00C24317
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x06033DC2 RID: 212418 RVA: 0x00C26135 File Offset: 0x00C24335
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x06033DC3 RID: 212419 RVA: 0x00C26153 File Offset: 0x00C24353
		private void OnActivitySequenceEmitEvent(string param)
		{
			if (param == "Enter")
			{
				this.RefreshStar();
			}
		}

		// Token: 0x06033DC4 RID: 212420 RVA: 0x00C26168 File Offset: 0x00C24368
		private void InitExtendToggle()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(6);
			EToggleState state = (RogueBattleModel.Instance.DescMode == EDescModel.DETAIL) ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(state, false, false, false);
			}
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnExtendToggleStateChange));
		}

		// Token: 0x06033DC5 RID: 212421 RVA: 0x00C261BA File Offset: 0x00C243BA
		private void OnExtendToggleStateChange(EToggleState _)
		{
			RogueBattleModel.Instance.ChangeDescMode();
		}

		// Token: 0x06033DC6 RID: 212422 RVA: 0x00C261C8 File Offset: 0x00C243C8
		private void RefreshStar()
		{
			RoleBondInfoView roleBondInfoView = MapRogueModel.Instance.GetOpData((int)this.OpenParam).Data.RollBuffBondLinkIdOp.RoleBondInfoView;
			int maxRoleStar = RogueBattleModel.Instance.MaxRoleStar;
			int oldStar = roleBondInfoView.OldStar;
			int newStar = roleBondInfoView.NewStar;
			List<ERogueRoleStarState> list = new List<ERogueRoleStarState>();
			for (int i = 0; i < maxRoleStar; i++)
			{
				if (i < newStar)
				{
					if (i >= oldStar)
					{
						list.Add(ERogueRoleStarState.LightOn);
					}
					else
					{
						list.Add(ERogueRoleStarState.Active);
					}
				}
				else
				{
					list.Add(ERogueRoleStarState.InActive);
				}
			}
			this.StarLayout.RefreshByData(list, null, true);
		}

		// Token: 0x06033DC7 RID: 212423 RVA: 0x00C26258 File Offset: 0x00C24458
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			GenericLayout<RogueBattleRoleBuffItem, RogueResGainData> buffLayout = this.BuffLayout;
			RogueBattleRoleBuffItem rogueBattleRoleBuffItem = (buffLayout != null) ? buffLayout.GetLayoutItemByIndex(0) : null;
			if (rogueBattleRoleBuffItem == null)
			{
				return null;
			}
			return rogueBattleRoleBuffItem.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0401B8EB RID: 112875
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RogueBattleRoleBuffItem, RogueResGainData> BuffLayout;

		// Token: 0x0401B8EC RID: 112876
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RogueBattleRoleStarItem, ERogueRoleStarState> StarLayout;

		// Token: 0x0401B8ED RID: 112877
		[Nullable(2)]
		private RogueBattleTopPanel TopPanel;
	}
}
